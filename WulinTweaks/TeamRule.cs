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
        // 「从未入队」判定缓存：太短会每次都读内存，太长则角色入队后剧情开得晚
        private const float NjTtl = 2f;
        private static readonly Regex _rId = new Regex(@"^R(\d{5})-", RegexOptions.Compiled);
        private static readonly Dictionary<int, KeyValuePair<bool, float>> _nj = new Dictionary<int, KeyValuePair<bool, float>>();

        private static readonly HashSet<string> _fixed = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Fame-2",
            "Guide10099-1",                                     // 2026-10-21 追加：与 6/11/13… 同属师父线
            "Guide10099-6", "Guide10099-11", "Guide10099-13",
            "Guide10099-15", "Guide10099-16", "Guide10099-18",
            // 2026-10-21 追加：烈酒与故事。图里 8 条「需要伙伴」全是别人的角色
            // （10008/10009/10005/10015），按彩蛋规则会被放宽 → 剧情提前播出。
            // 用户要求压回原版：那些角色不在队就不该演。
            "R10112-2",
        };

        /// <summary>
        /// 该剧情图是否属于「不做 Hold 压制」的例外：
        ///   R{角色id}- 图（条件层已由本规则精确判定）、固定名单、手动名单。
        /// 与手机端 hook_hold_check 里的三条例外一一对应。
        /// </summary>
        internal static bool IsProtectedGraph(string gn)
        {
            if (string.IsNullOrEmpty(gn)) return false;
            if (_rId.IsMatch(gn)) return true;
            if (_fixed.Contains(gn)) return true;
            try { return Plugin.IsStoryBlacklisted(gn); } catch { return false; }
        }

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

        /// <summary>
        /// 「该角色从未入过队」。
        ///   实例存在 → 看 m_TeamMemberState(0x130) 是否 NULL；
        ///   实例不存在 / 管理器未就绪 / 抛异常 → **也是从未入队**（不放宽）。
        ///
        /// 2026-10-21 修正：旧实现把「拿不到实例」当成「已入队」（返回 false），
        /// 于是新档里游戏还没创建实例的角色（大部分角色）判据全部失效，
        /// 本命角色的个人剧情被放宽 → 不该触发的剧情提前触发。
        /// 语义上「连实例都没有」必然没入过队，所以兜底方向只能是 true。
        /// </summary>
        private static bool IsNeverJoined(int uid)
        {
            if (uid <= 0) return false;          // 没有 partnerID 不算本命条件

            if (_nj.TryGetValue(uid, out var e) && (UnityEngine.Time.realtimeSinceStartup - e.Value) < NjTtl)
                return e.Key;

            bool v;
            try
            {
                var mgr = GameCharacterManager.Instance;
                if (mgr == null) v = true;                       // 管理器未就绪：保守按「从未入队」
                else
                {
                    var c = mgr.GetCharacter(uid);
                    if (c == null) v = true;                     // 实例还没创建：必然没入过队
                    else v = Hooks.SafeMem.Ptr(c.Pointer, OFF_TEAM_STATE) == IntPtr.Zero;
                }
            }
            catch { v = true; }                                  // 读失败：保守按「从未入队」

            _nj[uid] = new KeyValuePair<bool, float>(v, UnityEngine.Time.realtimeSinceStartup);
            return v;
        }
    }
}