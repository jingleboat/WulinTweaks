using System;
using GameData;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// 剧情期间显示「熟悉后姓名」—— 只在**剧情真正播放期间**生效（v1.9.9 起，与手机端 v79 对齐）。
    ///
    /// === 演进过程（两端同源，别再走回头路）===
    /// 1.9.6：只挂 get_FullName 的 Postfix → 无效（那俩补丁当时还根本没被注册）。
    /// 1.9.8：模板「陌生时姓名」+ IsUsingStangerName 判假 + getter 兜底 → 手机端证明前两条都
    ///        不被显示层读；PC 上实测同样无效（2026-10-23 用户验证：单人多人都还是陌生名）。
    /// 1.9.9：改名只在播放期间、且只作用于当前图（时机对了，但落点仍然不对）。
    /// 1.10.1：**落点改成角色实例的 m_surName / m_givenName 字段** —— 这是手机端试了六轮
    ///        才找到、并且真实生效的那一层（见交接文档 §3.3）。显示层读的是实例上的这两个
    ///        字符串，「算不算陌生」也是由 m_givenName 的 '@' 前缀决定的，所以直接改写数据
    ///        就同时解决了「显示什么」和「走哪条分支」两件事。
    ///
    /// === 一句话结构 ===
    ///   MarkRelaxed(uid, graph)  —— 放宽命中：只登记 (uid, 图名, 到期时间)，不改名
    ///   PlayBegin(graph)         —— 开始播剧情：把「同图 + 未过期」的角色实例改成真名
    ///   PlayEnd()                —— 播完：400ms 宽限后还原
    ///   IsLiveInStory(uid)       —— 三层补丁共用的判据
    /// </summary>
    internal static class RelaxName
    {
        private const long WinMs = 90000;        // 槽位登记有效期（放宽命中时刷新）
        private const long IdleMs = 30000;       // 没有新节点激活就认为剧情停了（1.10.4 起不再用 400ms 宽限）
        private const long PlayHardCapMs = 180000;
        private const long ReapplyMs = 500;      // 播放期间每 500ms 复查一次（游戏可能自己把名字写回去）
        private const int SlotCount = 24;

        private sealed class Slot
        {
            public int Uid;
            public string Graph;          // 这个窗口是从哪张剧情图记下来的
            public long Until;

            public GameCharacterInstance Inst;   // 改过名的那个实例
            public string OrigSur;               // 改之前的 m_surName
            public string OrigGiven;             // 改之前的 m_givenName（陌生名带 '@' 前缀）
            public bool InstPatched;
            public bool HasOrig;                 // 有没有值得还原的原值
        }

        private static readonly Slot[] Slots = new Slot[SlotCount];
        private static string _playingGraph;
        private static long _playUntil;
        private static int _playState;
        private static long _lastSync;
        private static int _logBegin, _logRename, _logRestore, _logWarn, _logRewrite;

        private static long Now => Environment.TickCount64;

        private static Slot Find(int uid)
        {
            if (uid <= 0) return null;
            for (int i = 0; i < SlotCount; i++)
                if (Slots[i] != null && Slots[i].Uid == uid) return Slots[i];
            return null;
        }

        private static Slot Alloc(int uid)
        {
            var s = Find(uid);
            if (s != null) return s;
            for (int i = 0; i < SlotCount; i++)
                if (Slots[i] == null) { Slots[i] = new Slot { Uid = uid }; return Slots[i]; }
            int worst = 0;
            for (int i = 1; i < SlotCount; i++)
                if (Slots[i].Until < Slots[worst].Until) worst = i;
            Restore(Slots[worst]);
            Slots[worst] = new Slot { Uid = uid };
            return Slots[worst];
        }

        /// <summary>三层补丁共用的判据：正在播剧情 && 窗口未过期 && 窗口来自当前这张图。</summary>
        internal static bool IsLiveInStory(int uid)
        {
            if (Now > _playUntil) return false;
            var s = Find(uid);
            if (s == null || Now > s.Until) return false;
            if (string.IsNullOrEmpty(s.Graph) || _playingGraph == null) return false;
            return string.Equals(s.Graph, _playingGraph, StringComparison.Ordinal);
        }

        /// <summary>放宽命中：只登记，不改名。</summary>
        internal static void MarkRelaxed(int uid, string graph)
        {
            if (uid <= 0) return;
            if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return;
            try
            {
                var s = Alloc(uid);
                if (!string.IsNullOrEmpty(graph)) s.Graph = graph;
                s.Until = Now + WinMs;
            }
            catch (Exception e) { if (_logWarn++ < 10) Plugin.L.LogWarning("[name] mark 异常: " + e.Message); }
        }

        internal static void PlayBegin(string graph)
        {
            if (!Plugin.IgnoreTeamCondition.Value) return;
            _playingGraph = graph;
            _playUntil = Now + IdleMs;      // 每个节点激活都续期（硬顶之外不再用短宽限）
            _playState = 1;
            _lastSync = Now;
            _lastApply = Now;
            if (_logBegin++ < 20) Plugin.L.LogInfo("[name] 开始播放剧情 graph=" + (graph ?? "?") + " → 只改这张图的角色");
            Sync();
        }

        /// <summary>
        /// 一个「播放剧情」节点播完了（Continue）。
        ///
        /// ⚠️ 这里**不再缩短窗口**。1.10.3 的探针实测：Continue 是**每节点一次**，
        /// 而节点之间的空档能到 1.8~19 秒（玩家读字、选项、Hold 等待）——
        /// 用 400ms/2.5s 的宽限判断"这段播完了"，就会在每个空档里把名字还原掉，
        /// 看起来就是"聊了几句之后突然变陌生名"。
        /// 现在只续期，真正结束交给 StoryCloseNode / 换图 / 空闲超时（见 EndNow）。
        /// </summary>
        internal static void PlayEnd()
        {
            if (Now > _playUntil) return;
            _playUntil = Now + IdleMs;
        }

        /// <summary>剧情事件真的结束了：立刻还原所有被改过的名字。</summary>
        internal static void EndNow()
        {
            _playUntil = 0;
            _playState = 0;
            try { Sync(); } catch { }
        }

        /// <summary>当前正在播的剧情图名（给 StoryCloseNode 比对用）。</summary>
        internal static string PlayingGraph => _playingGraph;

        /// <summary>
        /// 挂在热路径上探测「播放中」状态（250ms 节流）。
        ///
        /// 2026-10-23 踩的坑：原来只在状态翻转时才 Sync，结果段与段之间只要空档超过宽限，
        /// 名字就被还原；而且游戏自己把实例名字写回去时我们也发现不了（没有翻转，不 Sync）。
        /// 现在改成「播放期间每 ReapplyMs 复查一次」—— Sync 内部按值比较，已经对了就不重复写。
        /// </summary>
        internal static void MaybeSync()
        {
            if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return;
            long now = Now;
            if (now - _lastSync < 250) return;
            _lastSync = now;

            bool playing = now <= _playUntil;
            if (!playing && _playState == 0) return;      // 空闲且已还原过：什么都不做

            int st = playing ? 1 : 0;
            if (st != _playState) { _playState = st; Sync(); return; }

            if (playing && now - _lastApply >= ReapplyMs) { _lastApply = now; Sync(); }
        }

        private static long _lastApply;

        private static void Sync()
        {
            for (int i = 0; i < SlotCount; i++)
            {
                var s = Slots[i];
                if (s == null || s.Uid <= 0) continue;
                bool want = Now <= _playUntil && Now <= s.Until && s.Graph != null
                            && _playingGraph != null
                            && string.Equals(s.Graph, _playingGraph, StringComparison.Ordinal);
                if (want)
                {
                    // 播放期间续命：不放宽命中的门可能早就判完了，光靠 MarkRelaxed 的 90s
                    // 窗口撑不到剧情结尾，续一次省得中途被还原。
                    s.Until = Now + WinMs;
                    Apply(s);
                }
                else if (s.InstPatched) Restore(s);
            }
        }

        /// <summary>
        /// 把角色实例的姓/名换成本地拼的真名。
        ///
        /// 为什么是这两个字段：手机端六轮否证后才确认 —— 显示层既不读 get_FullName 的返回值，
        /// 也不读「陌生时姓名」模板；它读的是实例上的 m_surName / m_givenName，
        /// 而「算不算陌生」由 m_givenName 的 '@' 前缀决定。所以直接改写数据即可。
        /// 用 interop 的属性 setter 写（它走 il2cpp_gc_wbarrier_set_field，GC 安全）。
        /// </summary>
        private static void Apply(Slot s)
        {
            GameCharacterInstance inst;
            try
            {
                var mgr = GameCharacterManager.Instance;
                inst = mgr == null ? null : mgr.GetCharacter(s.Uid);
            }
            catch { inst = null; }
            if (inst == null) return;           // 实例还没创建：下一轮 Sync 再试

            string sur, given;
            if (!RealNamesOf(inst, out sur, out given)) return;

            // 已经是目标状态就不重复写（Sync 会周期性地来）
            string curSur = null, curGiven = null;
            try { curSur = inst.m_surName; curGiven = inst.m_givenName; } catch { }
            bool curIsOurs = string.Equals(curSur, sur, StringComparison.Ordinal)
                             && string.Equals(curGiven, given, StringComparison.Ordinal);
            if (s.InstPatched && s.Inst == inst && curIsOurs) return;

            if (!s.InstPatched || s.Inst != inst)
            {
                s.Inst = inst;
                // 只有「当前不是我们写的」才值得记原值；否则还原时会把真名再写一遍，
                // 结果角色从此永远显示真名（游戏重建实例时会出现这种情况）。
                s.HasOrig = !curIsOurs;
                if (s.HasOrig)
                {
                    s.OrigSur = curSur;
                    s.OrigGiven = curGiven;
                    if (_logRename++ < 80)
                        Plugin.L.LogInfo("[name] uid=" + s.Uid + " 实例原名 姓=\"" + (s.OrigSur ?? "")
                                         + "\" 名=\"" + (s.OrigGiven ?? "") + "\"");
                }
                s.InstPatched = true;
            }

            // 已经改过、但当前值又不是我们的 → 游戏自己把名字写回去了，这里补一刀。
            // 这条日志很重要：首句"先闪陌生名"通常就是这一刀晚了一步（见 Patch_StoryPlayBegin.Prefix）。
            bool rewrite = s.InstPatched && s.Inst == inst && !curIsOurs && s.HasOrig;
            if (rewrite && _logRewrite++ < 40)
                Plugin.L.LogInfo("[name] uid=" + s.Uid + " 游戏把名字改回去了（当前名=\"" + (curGiven ?? "")
                                 + "\"），重新改写");

            try
            {
                inst.m_surName = sur;
                inst.m_givenName = given;
                if (!rewrite && _logRename++ < 80)
                    Plugin.L.LogInfo("[name] uid=" + s.Uid + " 实例改名 -> \"" + (sur ?? "") + (given ?? "") + "\"");
            }
            catch (Exception e)
            {
                if (_logWarn++ < 10) Plugin.L.LogWarning("[name] uid=" + s.Uid + " 写实例姓名失败: " + e.Message);
            }
        }

        /// <summary>把实例的「真姓 / 真名」算出来。模板优先，模板缺就用 RealFullName 拆。</summary>
        private static bool RealNamesOf(GameCharacterInstance inst, out string sur, out string given)
        {
            sur = null;
            given = null;

            CharacterPoolData tpl = null;
            try { tpl = inst.Templete; } catch { }
            if (tpl != null)
            {
                try { sur = Trim(tpl.SurName); } catch { }
                try { given = Trim(tpl.GivenName); } catch { }
            }

            if (string.IsNullOrEmpty(given))
            {
                string real = null;
                try { real = Trim(inst.RealFullName); } catch { }
                if (!string.IsNullOrEmpty(real))
                {
                    if (!string.IsNullOrEmpty(sur) && real.StartsWith(sur, StringComparison.Ordinal))
                        given = real.Substring(sur.Length);
                    else
                        given = real;
                }
            }

            if (string.IsNullOrEmpty(given) && string.IsNullOrEmpty(sur)) return false;
            if (sur == null) sur = "";
            if (given == null) given = "";
            return true;
        }

        /// <summary>去掉首尾空白与可能的 '@' 陌生名标记。</summary>
        private static string Trim(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            s = s.Trim();
            while (s.Length > 0 && s[0] == '@') s = s.Substring(1);
            return s;
        }

        private static void Restore(Slot s)
        {
            if (s == null) return;
            if (s.InstPatched)
            {
                if (s.HasOrig)
                {
                    try
                    {
                        if (s.Inst != null)
                        {
                            s.Inst.m_surName = s.OrigSur;
                            s.Inst.m_givenName = s.OrigGiven;
                        }
                    }
                    catch { }
                    if (_logRestore++ < 40) Plugin.L.LogInfo("[name] uid=" + s.Uid + " 姓名已还原");
                }
                s.InstPatched = false;
                s.HasOrig = false;
            }
            s.Inst = null;
        }

        internal static void RestoreAll()
        {
            for (int i = 0; i < SlotCount; i++)
            {
                if (Slots[i] == null) continue;
                Restore(Slots[i]);
                Slots[i] = null;
            }
            _playingGraph = null;
            _playUntil = 0;
            _playState = 0;
        }
    }
}
