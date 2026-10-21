using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using WuLin;
using WuLin.StateMachine;
using UnityEngine;
using XNode;

namespace WulinTweaks
{
    /// <summary>只用于探测：保留作后续排查。</summary>
    internal static class Probe_CondNode
    {
        internal static void Report()
        {
            try
            {
                var t = typeof(ConditionNode);
                Plugin.L.LogInfo("[probe] ConditionNode = " + t.FullName);
                bool hasGraph = t.GetProperty("graph") != null || t.GetField("graph") != null;
                Plugin.L.LogInfo("[probe] ConditionNode 能否直接看到 graph 成员: " + hasGraph);
            }
            catch (Exception e) { Plugin.L.LogWarning("[probe] ConditionNode 探测失败: " + e.Message); }
        }
    }

    /// <summary>
    /// 条件检查总入口（StoryManager.CheckConditionFromRoot）的分流规则：
    ///
    ///  1) R{角色id}-xxx 这类角色剧情图：
    ///     仅当「需要伙伴」的角色 id == 图名里的角色 id **且该角色从未入队**时，
    ///     才按原版判断（故事线等 ta 入队后才开启）。
    ///     条件是别的角色 -> 放宽；本命角色已经入过队 -> 也放宽（离队后故事线可继续）。
    ///  2) 主线和师父的故事线（Fame-2 / Guide10099-*）固定按原版判断。
    ///  3) 手动名单仍然生效。
    ///  4) 其余一律放宽。
    ///
    /// 「从未入队」判据：GameCharacterInstance.m_TeamMemberState(+0x130) == NULL。
    /// 实测：苗彩蝶/曼陀罗/癞头癫 = NULL；猎户/铁匠/玩家 = 非 NULL。
    /// </summary>
    [HarmonyPatch]
    internal static class ConditionRootGuard
    {
        [ThreadStatic] private static bool _inside;
        private static readonly HashSet<string> _logged = new HashSet<string>();

        private static readonly HashSet<string> _fixedOriginal =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Fame-2",
                "Guide10099-6", "Guide10099-11", "Guide10099-13",
                "Guide10099-15", "Guide10099-16", "Guide10099-18",
            };

        // PC 版条件节点的 partnerID 偏移（手机版是 0x58；实测 PC 为 0x48）
        private const int OFF_PARTNER_ID_PC = 0x48;

        private static readonly Regex _rId = new Regex(@"^R(\d{5})-", RegexOptions.Compiled);

        static MethodBase TargetMethod()
        {
            try { return AccessTools.Method(typeof(StoryManager), "CheckConditionFromRoot"); }
            catch (Exception e) { ModKit.Err("targetmethod condroot", e); return null; }
        }

        /// <summary>
        /// 读 port 上连的**所有**队友/伙伴条件节点的 partnerID。
        /// 一个端口可能同时挂多个「需要伙伴」（例如 R20001-3 里既有刘十八 20001、又有铁匠 20006），
        /// 只取第一个会把别的角色的条件一起挡掉。
        /// </summary>
        private static readonly HashSet<string> _rpLog = new HashSet<string>();

        // 端口 -> partnerID 列表 的缓存（条件节点的 partnerID 不会变，端口生命周期长）
        private static readonly Dictionary<IntPtr, int[]> _portCache = new Dictionary<IntPtr, int[]>(64);

        private static List<int> ReadPartnerIds(NodePort port)
        {
            IntPtr key;
            try { key = port.Pointer; } catch { key = IntPtr.Zero; }
            if (key != IntPtr.Zero && _portCache.TryGetValue(key, out var cached))
                return new List<int>(cached);

            var list = new List<int>();
            try
            {
                var conns = port.GetConnections();
                if (conns == null)
                {
                    if (_rpLog.Add("null")) Plugin.L.LogInfo("[rp] GetConnections = null");
                    return list;
                }
                if (conns.Count == 0 && _rpLog.Add("empty"))
                    Plugin.L.LogInfo("[rp] GetConnections 返回 0 个连接");
                for (int i = 0; i < conns.Count; i++)
                {
                    var np = conns[i];
                    if (np == null) continue;
                    var n = np.node;
                    if (n == null) continue;
                    IntPtr p;
                    try { p = n.Pointer; } catch { continue; }
                    if (p == IntPtr.Zero) continue;
                    string cls = Hooks.Il2CppProbe.ClassNameOf(p);
                    if (cls == null) continue;
                    int cut = cls.IndexOfAny(new[] { ' ', '\0', '\n', '\r', '\t' });
                if (cut > 0) cls = cls.Substring(0, cut);
                if (cls.Contains("JoinedTeam") || cls.Contains("HavePartner"))
                    {
                        // PC 版 partnerID 在 +0x48（手机版 0x58，实测 2026-10-20）
                        int pid = Hooks.SafeMem.Int32(p, OFF_PARTNER_ID_PC);
                        if (_rpLog.Add("n" + i + "-" + cls))
                            Plugin.L.LogInfo("[rp] conns=" + conns.Count + " node[" + i + "] cls=" + cls + " pid(0x48)=" + pid);

                        if (pid <= 0)
                        {
                            // PC 版偏移可能与手机不同：扫 0x40~0xB0，把像 ID 的值打出来
                            var sb = new System.Text.StringBuilder();
                            for (int off = 0x40; off <= 0xB0; off += 4)
                            {
                                int v = Hooks.SafeMem.Int32(p, off);
                                if (v > 1000 && v < 1000000)
                                    sb.Append(" +").Append(off.ToString("X")).Append("=").Append(v);
                            }
                            if (_rpLog.Add("scan-" + cls))
                                Plugin.L.LogInfo("[rp] 候选 ID 偏移(cls=" + cls + "):" + sb);
                        }
                        if (pid > 0) list.Add(pid);
                    }
                }
            }
            catch (Exception e) { ModKit.Err("read partner ids", e); }

            if (key != IntPtr.Zero && _portCache.Count < 512)
                _portCache[key] = list.ToArray();
            return list;
        }

        private static readonly HashSet<string> _njLog = new HashSet<string>();

        /// <summary>该角色是否从未入队：m_TeamMemberState(+0x130) == NULL。拿不到就返回 false（不特殊处理）。</summary>
        // uid -> (是否从未入队, 计算时刻)。入队状态会变，5 秒过期。
        private static readonly Dictionary<int, KeyValuePair<bool, float>> _njCache = new Dictionary<int, KeyValuePair<bool, float>>();

        private static bool IsNeverJoined(int uid)
        {
            if (_njCache.TryGetValue(uid, out var e) && (Time.realtimeSinceStartup - e.Value) < 5f)
                return e.Key;
            bool v = IsNeverJoinedRaw(uid);
            _njCache[uid] = new KeyValuePair<bool, float>(v, Time.realtimeSinceStartup);
            return v;
        }

        private static bool IsNeverJoinedRaw(int uid)
        {
            try
            {
                if (uid <= 0)
                {
                    if (_njLog.Add("uid" + uid)) Plugin.L.LogInfo("[nj] uid=" + uid + " -> 无效 id，返回 false");
                    return false;
                }
                var mgr = GameCharacterManager.Instance;
                if (mgr == null)
                {
                    if (_njLog.Add("mgr")) Plugin.L.LogWarning("[nj] GameCharacterManager.Instance = null");
                    return false;
                }
                var c = mgr.GetCharacter(uid);
                if (c == null)
                {
                    if (_njLog.Add("c" + uid)) Plugin.L.LogInfo("[nj] uid=" + uid + " -> GetCharacter=null，返回 false");
                    return false;
                }
                IntPtr cp = c.Pointer;
                IntPtr tms = Hooks.SafeMem.Ptr(cp, 0x130);
                if (_njLog.Add("ok" + uid))
                    Plugin.L.LogInfo("[nj] uid=" + uid + " ptr=" + cp.ToString("X")
                        + " tms(0x130)=" + tms.ToString("X")
                        + " -> neverJoined=" + (tms == IntPtr.Zero));
                return tms == IntPtr.Zero;
            }
            catch (Exception e)
            {
                if (_njLog.Add("ex" + uid))
                    Plugin.L.LogWarning("[nj] uid=" + uid + " 异常: " + e.GetType().Name + " " + e.Message);
                return false;
            }
        }

        static bool Prefix(StoryManager __instance,
                           NodePort port,
                           Il2CppSystem.Type conditionType,
                           Il2CppReferenceArray<Il2CppSystem.Object> extra,
                           Il2CppSystem.Collections.Generic.List<ConditionNode> successList,
                           bool checkNodeTimes,
                           ref bool __result)
        {
            try
            {
                if (_inside) return true;
                if (!Plugin.IgnoreTeamCondition.Value) return true;
                if (port == null) return true;

                string gn = null;
                try
                {
                    var n = port.node;
                    if (n != null) { var g = n.graph; if (g != null) gn = g.name; }
                }
                catch { return true; }

                if (string.IsNullOrEmpty(gn)) return true;

                bool needOriginal;
                if (_fixedOriginal.Contains(gn))
                {
                    needOriginal = true;
                }
                else if (Plugin.IsStoryBlacklisted(gn))
                {
                    needOriginal = true;
                }
                else
                {
                    var m = _rId.Match(gn);
                    if (!m.Success)
                    {
                        needOriginal = false;                       // 非角色剧情图：放宽
                    }
                    else
                    {
                        int selfId = int.Parse(m.Groups[1].Value);
                        var pids = ReadPartnerIds(port);

                        // 规则：
                        //   端口上有「非本命角色」的条件 -> 放宽（让别的角色的彩蛋条件生效）
                        //   全部是本命角色且都没入过队        -> 按原版（故事线不开）
                        //   本命角色入过队 / 读不到条件        -> 放宽
                        bool anyOther = false, allSelfNever = pids.Count > 0;
                        foreach (var pid in pids)
                        {
                            if (pid != selfId) { anyOther = true; break; }
                            if (!IsNeverJoined(pid)) allSelfNever = false;
                        }
                        needOriginal = !anyOther && allSelfNever;
                    }
                }

                if (!needOriginal) return true;                     // 放宽：不干预

                _inside = true;
                Hooks.ProbingOrig = true;
                try
                {
                    ModKit.RestoreTeamCondition();
                    __result = __instance.CheckConditionFromRoot(port, conditionType, extra, successList, checkNodeTimes);
                }
                finally
                {
                    ModKit.ForceIgnoreTeamCondition();
                    Hooks.ProbingOrig = false;
                    _inside = false;
                }

                if (_logged.Add(gn))
                    Plugin.L.LogInfo("[orig] 剧情图 " + gn + " 按原版判断 → " + (__result ? "通过" : "不通过"));
                return false;
            }
            catch (Exception e) { ModKit.Err("condroot guard", e); return true; }
        }
    }
}
