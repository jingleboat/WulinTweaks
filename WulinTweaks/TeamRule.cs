using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WuLin;
using XNode;

namespace WulinTweaks
{
    /// <summary>
    /// «需要伙伴»条件的判定规则，供 dobby hook 调用。
    ///   partnerID != 图名角色id        -> 放宽（别的角色的彩蛋）
    ///   partnerID == 图名角色id 且未入队 -> 不放宽（走原版）
    ///   本命角色入过队 / 读不到          -> 放宽（人不在队也照演，这是要保留的功能）
    ///   **图里含「结缘界面」**           -> 一律不放宽（v1.11.19）：那类图收尾要写情缘/武功/buff，
    ///                                      人不在队会写到临时实例上 → 人物数据分裂
    /// 固定名单（主线/师父线）与手动名单 -> 不放宽
    /// PC 版 partnerID 偏移 = 0x48，Negate = 0x4C，graph = 0x18，m_TeamMemberState = 0x130。
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


        /// <summary>
        /// 该剧情图是否属于「不做 Hold 压制」的例外：
        ///   R{角色id}- 图（条件层已由本规则精确判定）、固定名单、手动名单。
        /// 与手机端 hook_hold_check 里的三条例外一一对应。
        /// </summary>
        internal static bool IsProtectedGraph(string gn)
        {
            if (string.IsNullOrEmpty(gn)) return false;
            if (_rId.IsMatch(gn)) return true;
            try { return Plugin.IsStoryBlacklisted(gn); } catch { return false; }
        }

        /// <summary>Hold 压制层的例外：只认真白名单（固定名单 + 手动名单），不再豁免整族 R 图。
        /// R 图的重复触发就是 times 压制该管的事（例如苗彩蝶 10005 的 R10005-*）。</summary>
        internal static bool IsHoldGuardExempt(string gn)
        {
            if (string.IsNullOrEmpty(gn)) return false;
            try { return Plugin.IsStoryBlacklisted(gn); } catch { return false; }
        }

        /// <summary>v1.11.24：同一张剧情图**只放宽一次**。第二次起走原版（剧情已播过，原版不会再放行）。
        /// 这就是「times 压制」真正该管的东西 —— 压制放宽本身，而不是压制 Hold 的通过。</summary>
        private static readonly HashSet<string> _relaxedOnce = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private static bool RelaxOnce(string gn)
        {
            if (string.IsNullOrEmpty(gn)) return true;
            if (_relaxedOnce.Add(gn)) return true;          // 第一次：放宽
            if (_logRelaxOnce++ < 12)
                Plugin.L.LogInfo("[relax] 图 " + gn + " 已放宽过一次 → 本次走原版");
            return false;
        }

        private static int _logRelaxOnce;

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
                if (Plugin.IsStoryBlacklisted(gn)) return false;

                if (pid <= 0) return RelaxOnce(gn);

                var m = _rId.Match(gn);
                if (!m.Success) return RelaxOnce(gn);                // 非角色剧情图：放宽（每图一次）
                int selfId = int.Parse(m.Groups[1].Value);
                if (pid != selfId) return RelaxOnce(gn);             // 别的角色（彩蛋）：放宽（每图一次）

                // ★ 结缘图（图里有「结缘界面」节点）**不放宽**。
                //   这类图的收尾会写人物数据：`激活NPC情缘`（SetBond 双向写）、`获得武功或绝学`（武功）、
                //   buff 85xx/89xx/88xx、`改变NPC关系值`。她不在队/实例不唯一时这些写入会落到临时实例上，
                //   人物数据就分裂了 —— 所以这类图直接跳过放宽，让原版判定"必须在队"生效。
                //   其余本命图（个人剧情）继续放宽：人不在队也照演，这是要保留的功能。
                if (IsBondGraph(condNode, gn))
                {
                    if (_logBond++ < 20)
                        Plugin.L.LogInfo("[team] 图 " + gn + " 含「结缘界面」→ 跳过放宽（按原版：必须在队）");
                    return false;
                }

                if (IsNeverJoined(pid)) return false;                // 本命 + 未入队 -> 不放宽
                return RelaxOnce(gn);                                // 本命 + 入过队 -> 放宽（每图一次）
            }
            catch (Exception e) { ModKit.Err("team rule", e); return true; }
        }

        private static int _logBond;

        // ---------------------------------------------------------------- 结缘图判定
        /// <summary>已知的 12 张结缘图（扫描失败时的兜底；新增/DLC 的靠节点扫描发现）。</summary>
        private static readonly HashSet<string> _knownBond = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "R10008-5", "R10009-6", "R10039-9", "R10052-3", "R10056-4", "R10064-6",
            "R10081-3", "R10084-5", "R10092-4", "R10108-3", "R20025-11", "R20063-2",
        };

        /// <summary>图指针 → 是否结缘图（只扫一次）。</summary>
        private static readonly Dictionary<IntPtr, bool> _bondGraphCache = new Dictionary<IntPtr, bool>(128);

        /// <summary>
        /// 这张图里有没有「结缘界面」节点（`ShowUIBondsNode`）。
        /// 做法：拿 graph → `nodes` 列表，逐个节点问 IL2CPP 类名；命中即结缘图。
        /// 类名读不到时退回 12 张已知图名。
        /// </summary>
        private static bool IsBondGraph(IntPtr condNode, string gn)
        {
            IntPtr graph = IntPtr.Zero;
            try { graph = Hooks.SafeMem.Ptr(condNode, OFF_GRAPH); } catch { }

            if (graph != IntPtr.Zero && _bondGraphCache.TryGetValue(graph, out var cached)) return cached;

            bool hit = false;
            bool scanned = false;
            try
            {
                Il2CppNative.Init();                       // 与 BranchFlatten 一样：用字段解析前先 Init
                if (graph != IntPtr.Zero && Il2CppNative.Ready)
                {
                    IntPtr list = Il2CppNative.Ptr(graph, "nodes");
                    int n = list == IntPtr.Zero ? 0 : Il2CppNative.ListCount(list);
                    if (n > 0 && n <= 4096)
                    {
                        scanned = true;
                        for (int i = 0; i < n; i++)
                        {
                            IntPtr nd = Il2CppNative.ListItem(list, i);
                            if (nd == IntPtr.Zero) continue;
                            string cn = Il2CppNative.ClassNameOf(nd);
                            if (cn == "ShowUIBondsNode") { hit = true; break; }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (_logBond++ < 20) Plugin.L.LogWarning("[team] 扫图失败（" + gn + "）→ 退回图名表: " + e.Message);
                scanned = false;
            }

            if (!scanned) hit = _knownBond.Contains(gn);      // 扫不了：按已知 12 张
            else if (!hit) hit = false;

            if (graph != IntPtr.Zero) _bondGraphCache[graph] = hit;
            return hit;
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