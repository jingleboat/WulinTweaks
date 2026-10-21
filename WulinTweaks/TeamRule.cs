using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WuLin;
using XNode;

namespace WulinTweaks
{
    /// <summary>
    /// 「需要伙伴」条件的判定规则，供 dobby hook 调用。
    ///   partnerID != 图名角色id        -> 放宽（别的角色的彩蛋）
    ///   partnerID == 图名角色id 且未入队 -> 不放宽（走原版）
    ///   本命角色入过队 / 读不到          -> 放宽
    /// 固定名单（主线/师父线）与手动名单 -> 不放宽
    /// PC 版 partnerID 偏移 = 0x48，graph = 0x18，m_TeamMemberState = 0x130。
    /// </summary>
    internal static class TeamRule
    {
        private const int OFF_GRAPH = 0x18;
        private const int OFF_PARTNER_ID = 0x48;
        private const int OFF_TEAM_STATE = 0x130;

        // 缓存带过期时间：入队状态会变，不能永久缓存判定结果
        private static readonly Dictionary<IntPtr, KeyValuePair<bool, float>> _cache =
            new Dictionary<IntPtr, KeyValuePair<bool, float>>(256);
        private const float CacheTtl = 3f;
        private static readonly Regex _rId = new Regex(@"^R(\d{5})-", RegexOptions.Compiled);
        private static readonly Dictionary<int, KeyValuePair<bool, float>> _nj = new Dictionary<int, KeyValuePair<bool, float>>();

        private static readonly HashSet<string> _fixed = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Fame-2",
            "Guide10099-6", "Guide10099-11", "Guide10099-13",
            "Guide10099-15", "Guide10099-16", "Guide10099-18",
        };

        internal static string GraphNameOf(IntPtr condNode)
        {
            try
            {
                if (condNode == IntPtr.Zero) return null;
                IntPtr gp = Hooks.SafeMem.Ptr(condNode, OFF_GRAPH);
                if (gp == IntPtr.Zero) return null;
                return new NodeGraph(gp).name;
            }
            catch { return null; }
        }

        internal static bool ShouldRelax(IntPtr condNode)
        {
            if (condNode == IntPtr.Zero) return true;

            float now = UnityEngine.Time.realtimeSinceStartup;
            if (_cache.TryGetValue(condNode, out var c) && (now - c.Value) < CacheTtl)
                return c.Key;

            bool v = Compute(condNode);
            if (_cache.Count < 4096) _cache[condNode] = new KeyValuePair<bool, float>(v, now);
            return v;
        }

        private static bool Compute(IntPtr condNode)
        {
            try
            {
                string gn = GraphNameOf(condNode);
                int pid = Hooks.SafeMem.Int32(condNode, OFF_PARTNER_ID);

                if (string.IsNullOrEmpty(gn)) return true;
                if (_fixed.Contains(gn)) return false;
                if (Plugin.IsStoryBlacklisted(gn)) return false;

                if (pid <= 0) return true;

                var m = _rId.Match(gn);
                if (!m.Success) return true;                        // 非角色剧情图：放宽
                int selfId = int.Parse(m.Groups[1].Value);
                if (pid != selfId) return true;                     // 别的角色：放宽
                return !IsNeverJoined(pid);                         // 本命 + 未入队 -> 不放宽
            }
            catch (Exception e) { ModKit.Err("team rule", e); return true; }
        }

        private static bool IsNeverJoined(int uid)
        {
            if (_nj.TryGetValue(uid, out var e) && (UnityEngine.Time.realtimeSinceStartup - e.Value) < 5f)
                return e.Key;
            bool v;
            try
            {
                var mgr = GameCharacterManager.Instance;
                var c = (mgr == null) ? null : mgr.GetCharacter(uid);
                v = (c != null) && (Hooks.SafeMem.Ptr(c.Pointer, OFF_TEAM_STATE) == IntPtr.Zero);
            }
            catch { v = false; }
            _nj[uid] = new KeyValuePair<bool, float>(v, UnityEngine.Time.realtimeSinceStartup);
            return v;
        }
    }
}