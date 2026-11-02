using System;
using System.Collections.Generic;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// v1.11.34：放宽「需要伙伴 / 某角色在队」判定时，把**这条条件涉及到的那个角色**
    /// 从「陌生名」改回真名。
    ///
    /// === 为什么是这个范围 ===
    /// 不做全档扫描、不按 uid 名单：只处理「刚被跳过的那条在队条件」里的 partnerID。
    /// 判定点就在 NativeTeamHook.MarkRelaxed —— 那里已经读出了 pid 并排除了 Negate 一侧。
    ///
    /// === 为什么清空名字就等于显示真名（反汇编依据）===
    ///   get_IsUsingStangerName = m_givenName 非空 && StartsWith("@")
    ///   get_FullName          = 陌生 ? 模板 NameAsStranger
    ///                                : (实例 m_surName/m_givenName → 空则回落模板)
    /// 所以把实例的 m_surName / m_givenName 清成空串，显示自动回落到模板的真姓真名。
    /// 这里**不写模板名**：模板缺失时写空会得到无名，而空串恰好让模板自己去兜底；
    /// 万一模板也没有，显示退化也只影响那一个角色，不会写坏数据。
    ///
    /// === 存档安全性 ===
    /// 只改两个 string 字段的值（"" —— 存档里本来就有 3732 条是这个值），
    /// 不增删字典键、不碰 relationShip / AdditionProps / m_TeamMemberState，
    /// 因此不会改变 SaveObjectGameCharacter 的结构。写前重新 GetCharacter(uid) 并
    /// 记录实例指针，指针变了（换图/销毁重建）才重新判定，避免写到被复用的地址上。
    /// </summary>
    internal static class Unstranger
    {
        /// <summary>uid → 已经处理过的实例指针。指针变了说明实例重建过，要重新判定。</summary>
        private static readonly Dictionary<int, IntPtr> _done = new Dictionary<int, IntPtr>(128);

        private static int _logs, _warns;

        internal static void Apply(int uid, bool force = false)
        {
            try
            {
                if (uid <= 0) return;
                if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return;

                var mgr = GameCharacterManager.Instance;
                if (mgr == null) return;

                var inst = mgr.GetCharacter(uid);
                if (inst == null) return;                  // 实例还没建出来：下次放宽再来

                IntPtr p = inst.Pointer;
                if (!force && _done.TryGetValue(uid, out var old) && old == p) return;   // 已写过真名（force=false 时才信任缓存）

                string g = null;
                try { g = inst.m_givenName; } catch { return; }

                // v1.11.36：**不在"不是陌生名"时缓存**。
                // 老版本把"此刻不带 @"记成"以后也不会陌生"，而 @ 是角色初始化时才写进实例的——
                // 放宽判定若早于初始化，就会永久漏掉这个角色（正是"有时正常有时失效"的成因之一）。
                if (string.IsNullOrEmpty(g) || g[0] != '@') return;

                try
                {
                    inst.m_surName = "";
                    inst.m_givenName = "";
                }
                catch (Exception e)
                {
                    if (_warns++ < 5) Plugin.L.LogWarning("[unstranger] uid=" + uid + " 写实例姓名失败: " + e.Message);
                    return;
                }

                _done[uid] = p;
                if (_logs++ < 60)
                    Plugin.L.LogInfo("[unstranger] 放宽在队条件 uid=" + uid
                                     + " 原陌生名=\"" + g + "\" → 已清空（显示回落模板真名）");
            }
            catch (Exception e)
            {
                if (_warns++ < 5) Plugin.L.LogWarning("[unstranger] 异常: " + e.Message);
            }
        }

        /// <summary>
        /// v1.11.36：剧情开始播放时，按「本图被放宽过的 uid」补一次。
        /// 为什么需要：放宽判定常远早于真正播放（Hold 条件被反复预判），那一刻角色可能还没实例化、
        /// 或者名字还没带上 '@'；而「每图只放宽一次」不给我们第二次机会。播放剧情是必然发生的时机。
        /// ⚠️ 必须排在 RelaxName.PlayBegin 之前：先清掉 '@'，RelaxName 拍到的"原值"才是空串，
        /// 收尾还原后仍回落到模板真名，而不是把 '@' 还回去。
        /// </summary>
        internal static void OnPlay(string graph)
        {
            if (string.IsNullOrEmpty(graph)) return;
            var uids = RelaxName.UidsOfGraph(graph);
            for (int i = 0; i < uids.Length; i++)
            {
                try { Apply(uids[i], true); } catch { }
            }
        }

        /// <summary>换图 / 读档：实例指针可能整批失效，缓存清掉重新判定。</summary>
        internal static void Reset() => _done.Clear();
    }
}
