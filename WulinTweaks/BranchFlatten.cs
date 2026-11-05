using System;
using System.Collections.Generic;

namespace WulinTweaks
{
    /// <summary>
    /// 剧情分支展开（Branch Flattener）v2 —— **通用规则**，不再针对某一张图。
    ///
    /// === 规则（一句话）===
    /// 把「在队侧（Negate=0）」的**出口**改接到「不在队侧那道门（Negate=1）」，
    /// 再让两道门都判真 —— 于是先播在队侧的内容，接着播不在队侧的内容。
    ///
    /// === 为什么成立 ===
    /// 一对门的父节点出边是 `[G0(Negate=0), G1(Negate=1)]`，引擎按顺序问、
    /// 第一个满足的就被走；两道都真时永远走 G0。所以只要把「G0 分支走完之后
    /// 指向外面那条边」改成指向 G1，就等于在 G0 的内容后面接上 G1 侧的内容，
    /// 而 **G1 侧原样保留**（它连着的是一对门还是汇合点都无所谓）。
    ///
    /// 这对两种形状同时成立：
    ///   · A 类：一侧「播放剧情」/ 一侧「直通」 —— 改完就变成梯子顺序展开
    ///   · B 类：两侧都是「播放剧情」 —— 改完变成"先播 A 侧、再播 B 侧"
    ///
    /// === 内容区域怎么界定 ===
    /// 不取"第 1 条出边"，而是按可达性算：
    ///     region = reach(G0) − reach(G1) − {G0, G1}
    /// 也就是**只有在队侧能到、不在队侧到不了**的节点 = 这一侧的独占内容。
    /// 这样多节点剧情、剧情内部自带分支都能覆盖，而汇合点和之后的流程天然被排除。
    ///     exits = region 内所有指向 region 外的边（已指向 G1 的除外）
    ///     动作  = exits 全部改指 G1；G0、G1 都判真
    ///
    /// === 跳过条件（宁可不动，也不要改坏）===
    /// · region 为空（两侧内容重叠）：本来就不需要改
    /// · region 太大（> 512）：认不出边界，跳过
    /// · region 没有对外出口（内容自环）：跳过
    /// · 与另一对门的 region 相交（嵌套门对）：两对都跳过，留给人工
    ///
    /// 离线模拟（1641 张图）见 `tools/simulate_flatten.py`：A 类 108 张 / A+B 199 张
    /// 可安全展开，跳过的基本就是上面后两条。
    /// </summary>
    internal static class BranchFlatten
    {
        private const int MaxNodes = 4096;      // 单图节点上限
        private const int MaxRegion = 512;      // 独占内容节点上限

        // ---------------------------------------------------------------- 状态
        /// <summary>被接管、一律判真的门（HoldNode 指针）。</summary>
        private static readonly HashSet<IntPtr> _gateForced = new HashSet<IntPtr>();

        /// <summary>已经处理过的 graph 指针（补丁只打一次）。</summary>
        private static readonly HashSet<IntPtr> _done = new HashSet<IntPtr>();

        /// <summary>「这个节点已经判定过归属」——Try 挂在热路径上，省掉重复取图名。</summary>
        private static readonly HashSet<IntPtr> _nodeChecked = new HashSet<IntPtr>();
        private static readonly Queue<IntPtr> _nodeOrder = new Queue<IntPtr>();
        private const int NodeCap = 8192;

        /// <summary>图没加载完时重试的次数上限。</summary>
        private static readonly Dictionary<IntPtr, int> _attempts = new Dictionary<IntPtr, int>();
        private const int MaxAttempts = 8;

        private static int _logGraph, _logPair, _logMiss;
        private static bool _warnedApi;

        /* ================================================================ 放宽白名单（v1.11.61 机制）
         *
         * 只有「属于某个互补门对」的队友条件才允许放宽；不满足就按原版判定。
         *
         * 为什么需要：门链里还夹着一些**孤立**的角色条件（不成对、没有 Negate 互补那一半）。
         * 放宽它们 = 那道门直接放行，而它并不在"先播在队、再播不在队"的展平控制之下，
         * 于是同一段演出会被反复拉起。实测这类孤立条件的位置：
         *   R10049-2（护花使者 / 柳月樱）：10056、42161、42162、42163 —— 共 8 个条件
         *   R10054-4（夜坊良友 / 沈无欺）：52 个（占该图队友条件的 49%）
         *
         * 关键细节：**没被处理过的图不阻断**。展平只在图被扫过之后才知道门对是谁，
         * 所以对没扫过的图（含没有门对的图）返回 true，保持"照常放宽"。
         * 而没有门对的图在 Apply 里会把「所有角色条件」一次性登记进白名单，
         * 效果同样是"照常放宽"——不会被这张表误伤。 */
        private static readonly Dictionary<string, HashSet<IntPtr>> _relaxOk =
            new Dictionary<string, HashSet<IntPtr>>(StringComparer.OrdinalIgnoreCase);
        private static readonly HashSet<string> _processed =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>这张图里，这个条件是否允许放宽。未处理过的图返回 true（不阻断）。</summary>
        internal static bool RelaxAllowed(string gn, IntPtr cond)
        {
            if (string.IsNullOrEmpty(gn)) return true;
            if (!_processed.Contains(gn)) return true;
            HashSet<IntPtr> set;
            if (_relaxOk.TryGetValue(gn, out set)) return set.Contains(cond);
            return false;
        }

        private static void RelaxOkAdd(string gn, IntPtr cond)
        {
            if (cond == IntPtr.Zero || string.IsNullOrEmpty(gn)) return;
            HashSet<IntPtr> set;
            if (!_relaxOk.TryGetValue(gn, out set))
            {
                set = new HashSet<IntPtr>();
                _relaxOk[gn] = set;
            }
            set.Add(cond);
        }

        /// <summary>这个条件是否「与某个角色相关」（partnerID &gt; 0）。
        /// 用于「图里没有门对」时把所有角色条件放进白名单 —— 等价于上游 IsInTeamCond 的作用。</summary>
        /// <summary>v260：这个条件是不是「队友条件」类 —— 只有它们才构成可展开的门对。</summary>
        /// <remarks>
        /// partnerID 字段**不是**队友条件专属。实测 dump 里带该字段的类有 43 个，包括
        /// NpcAtMapCondition（判断地图存在NPC）、NpcDeadCondition、TalkToNpcCondition、
        /// HaveBuffCondition、HaveEquipCondition、HaveFactionCondition … 
        /// 旧代码只看 partnerID + Negate 互补，于是「判断地图存在NPC 10063」(Negate 0/1) 被当成
        /// 「需要伙伴」门对展开 → 石万三「在地点」和「不在地点」两段依次播放（安卓端实测）。
        /// 手机端 v251 按中文名加白名单，PC 这里按类名加，语义等价且更可靠。
        /// </remarks>
        private static bool IsTeamCond(IntPtr cond)
        {
            if (cond == IntPtr.Zero) return false;
            try
            {
                string cls = Il2CppNative.ClassNameOf(cond);
                if (string.IsNullOrEmpty(cls)) return false;
                // v280（对齐手机版 v272）：**只认「当前在队」语义**。
                //
                // IsJoinedTeamCondition（是否加入过队伍）是**历史入队**，与「当前在队」不是同一维度：
                // Negate 互补的「加入过 / 没加入过」不能当「在队 / 不在队」去展平 ——
                // 一个人不可能既加入过又没加入过，两侧剧情同时播是逻辑矛盾。
                // 而且手机版 v212 起已决定它**不放宽** → 对它展平不会生效，只会白登记门表。
                //
                // 实证（手机版）：离线全库伙伴/入队类条件里，`需要伙伴` 1546 次，
                // `判断NPC加入过队伍` 7 次，其它备用名 0 次 → 收窄后门对总数不变（零影响）。
                return cls == "HavePartnerCondition"        // 需要伙伴（当前在队）
                    || cls == "SlgHavePartnerCondition";     // SLG 模式的当前在队
            }
            catch { return false; }
        }

        private static bool IsPartnerCond(IntPtr cond)
        {
            if (cond == IntPtr.Zero) return false;
            try { return Il2CppNative.Int32(cond, "partnerID") > 0; } catch { return false; }
        }

        // ================================================================ 对外
        /// <summary>
        /// 这个门是否已被「分支展开」接管（= 无条件判真）。
        /// 由 `Patch_FlattenGate`（HoldNode.CheckCondition 的 Postfix）调用。
        ///
        /// ⚠️ 故意不看开关：补丁一旦写下，图就回不去了 —— 若中途关掉开关、判真也一起失效，
        /// 就会「出口已改指别处」+「那道门判假」= 剧情永久卡死。
        /// </summary>
        internal static bool IsGateForced(IntPtr gate)
        {
            return gate != IntPtr.Zero && _gateForced.Count > 0 && _gateForced.Contains(gate);
        }

        /// <summary>
        /// 在图上套用补丁。anyNode 可以是图里任意节点（用它的 graph 指针去重）。
        /// 由 Patch_StoryPlayBegin（剧情开始播放）和 NativeTeamHook.Dispatch（条件判定）调用。
        /// </summary>
        internal static void Try(IntPtr anyNode)
        {
            try
            {
                if (Plugin.FlattenBranches == null || !Plugin.FlattenBranches.Value) return;
                if (anyNode == IntPtr.Zero) return;
                if (_nodeChecked.Contains(anyNode)) return;      // 热路径：一次哈希查找

                Il2CppNative.Init();
                if (!Il2CppNative.Ready)
                {
                    if (!_warnedApi)
                    {
                        _warnedApi = true;
                        Plugin.L.LogError("[flat] il2cpp 字段解析不可用 → 剧情分支展开停用");
                    }
                    return;
                }

                IntPtr graph = Il2CppNative.Ptr(anyNode, "graph");
                if (graph == IntPtr.Zero) { Remember(anyNode); return; }
                if (_done.Contains(graph)) { Remember(anyNode); return; }

                string gn = Il2CppNative.Str(graph, "_name");
                if (gn == null) return;              // 读不到图名 ≠ 不是目标：下次再试

                if (IsBlacklisted(gn)) { _done.Add(graph); Remember(anyNode); return; }

                Apply(graph, gn);
                if (_done.Contains(graph)) Remember(anyNode);
            }
            catch (Exception e)
            {
                if (_logMiss++ < 6) Plugin.L.LogError("[flat] Try 异常: " + e);
            }
        }

        /// <summary>
        /// 门对级跳过名单（v1.11.33）：名单项写成 `图名:partnerID`（如 `Fame-10:10049`），
        /// 只跳过这张图里 partnerID 命中的那一对「在队 / 不在队」门，其余门对照常展开。
        /// 不带 `:` 的项由 IsBlacklisted 走整图跳过；带 `*` 的图名部分仍支持前缀匹配。
        /// </summary>
        private static bool SkipPair(string gn, int pid)
        {
            try
            {
                if (string.IsNullOrEmpty(gn) || pid <= 0) return false;
                var cfg = Plugin.FlattenBlacklist;
                string raw = cfg == null ? null : cfg.Value;
                if (string.IsNullOrEmpty(raw)) return false;

                foreach (var piece in raw.Split(new[] { ',', ';', ' ', '\t', '\r', '\n' },
                                                StringSplitOptions.RemoveEmptyEntries))
                {
                    var p = piece.Trim();
                    int c = p.IndexOf(':');
                    if (c <= 0 || c >= p.Length - 1) continue;      // 没有 :pid → 整图项，跳过

                    var gpart = p.Substring(0, c).Trim();
                    var ppart = p.Substring(c + 1).Trim();
                    if (gpart.Length == 0) continue;

                    bool gok;
                    if (gpart.EndsWith("*"))
                        gok = gpart.Length > 1 &&
                              gn.StartsWith(gpart.Substring(0, gpart.Length - 1), StringComparison.OrdinalIgnoreCase);
                    else
                        gok = string.Equals(gn, gpart, StringComparison.OrdinalIgnoreCase);
                    if (!gok) continue;

                    int want;
                    if (int.TryParse(ppart, out want) && want > 0 && want == pid) return true;
                }
            }
            catch { }
            return false;
        }

        private static bool IsBlacklisted(string gn)
        {
            try
            {                var cfg = Plugin.FlattenBlacklist;
                string raw = cfg == null ? null : cfg.Value;
                if (string.IsNullOrEmpty(raw)) return false;
                foreach (var piece in raw.Split(new[] { ',', ';', ' ', '\t', '\r', '\n' },
                                                StringSplitOptions.RemoveEmptyEntries))
                {
                    var p = piece.Trim();
                    if (p.Length == 0) continue;
                    if (p.EndsWith("*"))
                    {
                        if (gn.StartsWith(p.Substring(0, p.Length - 1), StringComparison.OrdinalIgnoreCase))
                            return true;
                    }
                    else if (string.Equals(gn, p, StringComparison.OrdinalIgnoreCase)) return true;
                }
            }
            catch { }
            return false;
        }

        // ================================================================ 数据结构
        private sealed class OutInfo
        {
            public IntPtr Port;
            public readonly List<IntPtr> Targets = new List<IntPtr>(2);
        }

        private sealed class Pair
        {
            public IntPtr G0;      // Negate = 0（在队侧）
            public IntPtr G1;      // Negate = 1（不在队侧）
            public int Pid;
            public bool BothStory; // 两侧都是单节点剧情 = B 类
            public HashSet<IntPtr> Region;
            public List<KeyValuePair<IntPtr, IntPtr>> Exits;  // (源节点, 旧目标)
            public IntPtr NextG0 = IntPtr.Zero;   // v260：链式接续的下一对在队门（Zero = 自己是最后一对）
        }

        // ================================================================ 主流程
        private static void Apply(IntPtr graph, string graphName)
        {
            IntPtr list = Il2CppNative.Ptr(graph, "nodes");
            int n = Il2CppNative.ListCount(list);
            if (n <= 2 || n > MaxNodes)
            {
                // v1.11.61：节点表读不到 → 这张图的门对一个都算不出来。
                // 标成已处理 + 白名单为空 ⇒ RelaxAllowed 会返回 false ⇒ 这张图整体按原版。
                // 这是刻意的保守：算不出门对就不该放宽（否则孤立的角色条件会把门整道放行）。
                _processed.Add(graphName);
                _done.Add(graph);
                Plugin.L.LogWarning("[flat] 图 " + graphName + " 节点数异常（" + n + "），跳过");
                return;
            }

            // ---------- ① 收节点表 + 每条出边（只看 OutPort：剧情走线就在它上面） ----------
            var outs = new Dictionary<IntPtr, OutInfo>(n);
            var condOf = new Dictionary<IntPtr, IntPtr>(n);
            for (int i = 0; i < n; i++)
            {
                IntPtr nd = Il2CppNative.ListItem(list, i);
                if (nd == IntPtr.Zero) continue;
                if (Il2CppNative.Ptr(nd, "graph") != graph) continue;    // 数组读偏的保险

                var info = new OutInfo();
                IntPtr op = NodePort(nd, "OutPort");
                if (op != IntPtr.Zero)
                {
                    info.Port = op;
                    int c = ConnCount(op);
                    if (c > 0 && c <= 32)
                        for (int k = 0; k < c; k++)
                        {
                            IntPtr t = ConnNodeAt(op, k);
                            if (t != IntPtr.Zero) info.Targets.Add(t);
                        }
                }
                outs[nd] = info;

                // 门才有 conditionPort
                IntPtr cp = NodePort(nd, "conditionPort");
                condOf[nd] = cp == IntPtr.Zero ? IntPtr.Zero : ConditionOf(cp);
            }

            // ---------- ② 找互补门对 ----------
            var pairs = new List<Pair>();
            var seenPair = new HashSet<long>();
            int xSkipped = 0;
            int pairSkipped = 0;
            foreach (var kv in outs)
            {
                var ts = kv.Value.Targets;
                if (ts.Count != 2) continue;
                IntPtr a = ts[0], b = ts[1];
                if (a == b) continue;

                IntPtr ca = condOf.TryGetValue(a, out var x) ? x : IntPtr.Zero;
                IntPtr cb = condOf.TryGetValue(b, out var y) ? y : IntPtr.Zero;
                if (ca == IntPtr.Zero || cb == IntPtr.Zero) continue;

                int pa = Il2CppNative.Int32(ca, "partnerID");
                int pb = Il2CppNative.Int32(cb, "partnerID");
                if (pa <= 0 || pa != pb) continue;                 // partnerID<=0 不是「需要伙伴」

                // v260：**必须是队友条件类**，否则会把 NpcAtMapCondition 之类当成门对
                if (!IsTeamCond(ca) || !IsTeamCond(cb)) continue;

                // v280（对齐手机版 P0-2）：**门的 conditionPort 必须恰好 1 条连接**。
                // 强制放行的粒度是**门**（IsGateForced → 整门判真），门上若串了多个条件，
                // 放行整个门就把**所有条件**一起跳过了。
                // 实证（手机版）：Fame-4-1 pid=10099 的 G0 门有 2 个条件
                // （「需要伙伴」+「判断角色带有Buff」）→ 强制放行绕过了 Buff 限制。
                if (CondPortCount(a) != 1 || CondPortCount(b) != 1) continue;

                // v1.11.33：门对级跳过 —— 只压 partnerID 命中的那一对
                if (SkipPair(graphName, pa)) { pairSkipped++; continue; }

                bool na = Il2CppNative.Byte(ca, "Negate") != 0;
                bool nb = Il2CppNative.Byte(cb, "Negate") != 0;
                if (na == nb) continue;                            // 必须互补

                IntPtr g0 = na ? b : a;                            // Negate=0 = 在队侧
                IntPtr g1 = na ? a : b;

                long key = (long)g0.ToInt64() ^ ((long)g1.ToInt64() << 1);
                if (!seenPair.Add(key)) continue;

                // 只处理 A/B 类（至少一侧是「单个播放剧情节点」）。
                // X 类（两侧都不是）形状不明，离线没验证过，这里不动，只计数。
                bool s0 = IsStoryExit(outs, g0);
                bool s1 = IsStoryExit(outs, g1);
                if (!s0 && !s1) { xSkipped++; continue; }

                pairs.Add(new Pair
                {
                    G0 = g0,
                    G1 = g1,
                    Pid = pa,
                    BothStory = s0 && s1,
                });
            }

            if (pairSkipped > 0 && _logGraph < 200)
            {
                _logGraph++;
                Plugin.L.LogInfo("[flat] 图 " + graphName + " 按门对名单跳过 " + pairSkipped
                                 + " 对（partnerID 命中，其余照常展开）");
            }
            if (pairs.Count == 0)
            {
                // v1.11.61：图里没有门对 → 允许放宽"门直接挂着的角色条件"（否则这张图会被
                // 白名单判成"一条都不许放宽"，那是误伤）。登记完再标记已处理。
                foreach (var kv in condOf)
                {
                    try { if (IsPartnerCond(kv.Value)) RelaxOkAdd(graphName, kv.Value); } catch { }
                }
                _processed.Add(graphName);
                _done.Add(graph);
                return;
            }

            // ---------- ③ 每对算独占内容 region 与对外出口 ----------
            foreach (var p in pairs)
            {
                // v260：两侧都加避让 —— G1 侧避自己的 G0；G0 侧避同图其它门对的 G0
                var g0Avoid = new HashSet<IntPtr>();
                foreach (var q in pairs) if (!ReferenceEquals(q, p)) g0Avoid.Add(q.G0);
                var r0 = Reach(p.G0, outs, g0Avoid);
                var r1 = Reach(p.G1, outs, new HashSet<IntPtr> { p.G0 });
                var region = new HashSet<IntPtr>(r0);
                region.ExceptWith(r1);
                region.Remove(p.G0);
                region.Remove(p.G1);
                p.Region = region;
                p.Exits = region.Count == 0 || region.Count > MaxRegion
                    ? new List<KeyValuePair<IntPtr, IntPtr>>()
                    : FindExits(region, outs, p.G1);
            }

            // ---------- ④ 剔除有问题的对（重叠 / 无出口 / 过大） ----------
            var expand = new List<Pair>();
            int skippedOverlap = 0, skippedExits = 0, skippedEmpty = 0, skippedOrphan = 0;
            foreach (var p in pairs)
            {
                if (p.Region.Count == 0) { skippedEmpty++; continue; }
                if (p.Region.Count > MaxRegion) { skippedEmpty++; continue; }
                if (p.Exits.Count == 0) { skippedExits++; continue; }

                bool clash = false;
                foreach (var q in pairs)
                {
                    if (q == p || q.Region.Count == 0) continue;
                    if (p.Region.Overlaps(q.Region)) { clash = true; break; }
                }
                if (clash) { skippedOverlap++; continue; }

                // v260：**:孤岛判据** —— 任何一条出口边的目标若「除这条边外没有其它入边」，
                // 改线会让它连同整个下游不可达（丢剧情 / 丢标记 / 丢 NPC 死亡等效果）。
                // v280：**排除「目标是任何门对的 G0/G1」**。
                // 门对成员在改线时必然被处理（成为改线目标或被串联），
                // 不会因为这条出口被改指而下落不明。
                // 实证（手机版，JuQingYouHua 覆盖版 R10049-2-1）：10098 对的 region 膨胀到 20，
                // 出口 4 条全部判孤岛 —— 但它们的目标正是另外三对的 G0 和自己的 G0，
                // 每条入度都只有 1（mod 把「G1 门」和「下一对父节点」合成同一节点）。
                // 按旧判据 → 全中 → 整链清零 → 只播都不在队那段。
                bool orphan = false;
                var pairGates = new HashSet<IntPtr>();
                foreach (var q in pairs) { pairGates.Add(q.G0); pairGates.Add(q.G1); }
                foreach (var e in p.Exits)
                {
                    if (HasOtherIn(outs, e.Value, e.Key)) continue;
                    if (pairGates.Contains(e.Value)) continue;   // v280：门对成员不算孤岛
                    orphan = true; break;
                }
                if (orphan) { skippedOrphan++; continue; }

                expand.Add(p);
            }

            if (_logGraph++ < 200)
                Plugin.L.LogInfo("[flat] 图 " + graphName + "：节点 " + n + "，门对 " + pairs.Count
                                 + "，展开 " + expand.Count + "（B 类 "
                                 + CountB(expand) + "），跳过 重叠" + skippedOverlap
                                 + "/空或无出口" + (skippedEmpty + skippedExits)
                                 + "/孤岛" + skippedOrphan
                                 + "/非A-B类" + xSkipped);

            // ---------- ④b 整链决策（v280，对齐手机版） ----------
            expand = ChainDecide(expand, pairs, outs);

            if (expand.Count == 0) { _done.Add(graph); return; }

            // ---------- ⑤ 改线 + 接管门 ----------
            int ok = 0, fail = 0, g1ToG0 = 0, guarded = 0;
            foreach (var p in expand)
            {
                // ---- 链式接续：算「下一对」 ----
                p.NextG0 = FindNextG0(pairs, p, outs);

                // v280（对齐手机版 v269）：**删掉「最后一对改指 G1 前的两道校验」**。
                //
                // 手机版实测结论：那两道校验建立在「图论成环」上，而环形图**原版就处处是环**
                // （R10049-2-1 原版有 9 个剧情节点在静态图上「成环」，实测完全正常，因为运行时
                // 门判定会断开那些路）。所以它们没有判别力，只会误伤。
                //
                // 手机版 v255 实测：最后一对改指自己的 G1 后，_4_5 正常播、_4_6 也播、不循环
                // （_4_6 之后走它自己的标记 → 汇合点 → 5 个「当与Npc交互」门判假 → 停）。

                IntPtr rewireTo = p.NextG0 != IntPtr.Zero ? p.NextG0 : p.G1;

                // v281（P0-7）：**事务化** —— 任一出口改线失败就回滚本次全部改线，
                // 并且**不登记门表**（避免「连接只改了一半 + 门被强制放行」这种不一致）。
                // 审查意见原话：「任意步骤失败都恢复原连接，不留下部分改线或部分门表。」
                bool allOk = true;
                var applied = new List<(IntPtr port, IntPtr from, IntPtr to)>();
                foreach (var e in p.Exits)
                {
                    IntPtr src = e.Key, oldT = e.Value;
                    var info = outs[src];
                    if (info.Port == IntPtr.Zero || !RedirectEdge(info.Port, oldT, rewireTo))
                    {
                        allOk = false;
                        fail++;
                    }
                    else { applied.Add((info.Port, oldT, rewireTo)); ok++; }
                }
                if (!allOk)
                {
                    for (int i = applied.Count - 1; i >= 0; --i)
                        RedirectEdge(applied[i].port, applied[i].to, applied[i].from);
                    ok -= applied.Count;
                    fail -= 1;                     // 只记「这一对失败」一次
                    if (_logPair < 300)
                    {
                        _logPair++;
                        Plugin.L.LogWarning("[flat-rollback] pid=" + p.Pid
                            + " 出口改线失败 → 已回滚 " + applied.Count + " 条，不登记门表");
                    }
                    continue;
                }

                // ---- G1 → G0：只对有下一对的门对生效 ----
                // v1.11.6x：引擎在分叉点只走 OutPort 的**最后一条**连接。若那条是 G1 而 G1 判真，
                // 流程会掉进「不在队」链，在队剧情全都不播。让 G1 的出边改指 G0 后，
                // 无论走哪条分叉都落到在队剧情，再由链式接续接力到下一对。
                // ⚠️ 最后一对绝不能做：否则 _4_5 → G1 → G0 → _4_5 死循环（安卓端 v244 实测）。
                if (p.NextG0 != IntPtr.Zero && outs.TryGetValue(p.G1, out var g1o) && g1o.Port != IntPtr.Zero)
                {
                    // v280（策略 C，对齐手机版 v270）：**只改「目标还有别的入边」的边**。
                    //
                    // 旧实现把 G1 的**所有**出边都改指 G0 → G1 独占的下级子树全部不可达。
                    // 手机版实测（真实数据）：DBZX-6 / M2190-3 / M10140-3 / DNJH-6 等图
                    // 会因此丢掉整棵子树（剧情、强制NPC死亡、预设战斗、背包物品）。
                    //
                    // 判据：目标若只有 G1 指着 = 它独占的下级 → 改指就切断 → 保持原样。
                    var targetsCopy = new List<IntPtr>(g1o.Targets);
                    var g1Applied = new List<(IntPtr port, IntPtr from, IntPtr to)>();
                    bool g1AllOk = true;
                    foreach (var t in targetsCopy)
                    {
                        if (!HasOtherIn(outs, t, p.G1)) continue;   // 独占下级 → 不改
                        if (RedirectEdge(g1o.Port, t, p.G0)) g1Applied.Add((g1o.Port, t, p.G0));
                        else g1AllOk = false;
                    }
                    if (!g1AllOk)
                    {
                        // v281（P0-7）：G1→G0 失败同样回滚（含本次已做的出口改线）
                        for (int i = g1Applied.Count - 1; i >= 0; --i)
                            RedirectEdge(g1Applied[i].port, g1Applied[i].to, g1Applied[i].from);
                        for (int i = applied.Count - 1; i >= 0; --i)
                            RedirectEdge(applied[i].port, applied[i].to, applied[i].from);
                        ok -= applied.Count;
                        if (_logPair < 300)
                        {
                            _logPair++;
                            Plugin.L.LogWarning("[flat-rollback] pid=" + p.Pid
                                + " G1→G0 改线失败 → 已回滚本次全部改线，不登记门表");
                        }
                        continue;
                    }
                    g1ToG0 += g1Applied.Count;
                }

                _gateForced.Add(p.G0);
                _gateForced.Add(p.G1);

                // v1.11.61：这一对的门条件是**允许放宽**的；图里其它孤立条件不放宽
                try
                {
                    IntPtr c0; if (condOf.TryGetValue(p.G0, out c0)) RelaxOkAdd(graphName, c0);
                    IntPtr c1; if (condOf.TryGetValue(p.G1, out c1)) RelaxOkAdd(graphName, c1);
                }
                catch { }

                try { RelaxName.MarkRelaxed(p.Pid, graphName); } catch { }

                if (_logPair++ < 300)
                    Plugin.L.LogInfo("[flat]   pid=" + p.Pid + (p.BothStory ? " (B 类)" : " (A 类)")
                                     + " 内容 " + p.Region.Count + " 节点，改线 " + p.Exits.Count
                                     + "，接续=" + (p.NextG0 != IntPtr.Zero ? "下一对" : "最后一对")
                                     + (allOk ? "" : " ⚠部分失败"));
            }

            _done.Add(graph);

            if (_logGraph <= 200)
                Plugin.L.LogInfo("[flat] 图 " + graphName + " 展开完成：改线 " + ok + " 条"
                                 + (fail > 0 ? "，失败 " + fail + " 条" : "")
                                 + "，G1→G0 " + g1ToG0 + " 条，校验跳过 " + guarded
                                 + "，接管门 " + _gateForced.Count + " 个（累计）");
            if (fail > 0)
                Plugin.L.LogError("[flat] ⚠ 图 " + graphName + " 有 " + fail
                                  + " 条连线没改成 —— 该图走线处于半改状态，重启游戏可复原");
        }

        private static int CountB(List<Pair> ps)
        {
            int c = 0;
            for (int i = 0; i < ps.Count; i++) if (ps[i].BothStory) c++;
            return c;
        }

        /// <summary>本对 G1 门的出边指向哪一对的门 → 那一对的 G0 就是「下一对」；找不到返回 Zero。</summary>
        /// <remarks>v260 链式接续：剧情出口改指下一对的 G0，而不是自己的 G1。
        /// 安卓端实测：不改指的话流程会沿「不在队」链一路到底，只播最后一段（都不在队）。</remarks>
        private static IntPtr FindNextG0(List<Pair> pairs, Pair self, Dictionary<IntPtr, OutInfo> outs)
        {
            if (!outs.TryGetValue(self.G1, out var o)) return IntPtr.Zero;
            for (int i = 0; i < o.Targets.Count; i++)
            {
                IntPtr t = o.Targets[i];
                for (int q = 0; q < pairs.Count; q++)
                {
                    var pq = pairs[q];
                    if (ReferenceEquals(pq, self)) continue;
                    if (t == pq.G0 || t == pq.G1) return pq.G0;
                }
            }
            return IntPtr.Zero;
        }

        /// <summary>从 from 出发沿 OutPort 能否到达 target。</summary>
        private static bool ReachHits(Dictionary<IntPtr, OutInfo> outs, IntPtr from, IntPtr target)
        {
            var seen = new HashSet<IntPtr> { from };
            var stack = new Stack<IntPtr>();
            stack.Push(from);
            while (stack.Count > 0)
            {
                IntPtr cur = stack.Pop();
                if (cur == target) return true;
                if (!outs.TryGetValue(cur, out var o)) continue;
                for (int i = 0; i < o.Targets.Count; i++)
                {
                    IntPtr t = o.Targets[i];
                    if (seen.Add(t)) stack.Push(t);
                }
            }
            return false;
        }

        /// <summary>门后面直接挂着的剧情节点（G0 → 剧情）。没有则 Zero。</summary>
        private static IntPtr StoryOfGate(Dictionary<IntPtr, OutInfo> outs, IntPtr gate)
        {
            if (!outs.TryGetValue(gate, out var o)) return IntPtr.Zero;
            for (int i = 0; i < o.Targets.Count; i++)
                if (Il2CppNative.Str(o.Targets[i], "ScenarioKey") != null) return o.Targets[i];
            return IntPtr.Zero;
        }

        /// <summary>这一侧是不是「单个播放剧情节点」——用来区分 A 类/B 类（只用于日志）。</summary>
        private static bool IsStoryExit(Dictionary<IntPtr, OutInfo> outs, IntPtr gate)
        {
            if (!outs.TryGetValue(gate, out var o)) return false;
            if (o.Targets.Count != 1) return false;
            return Il2CppNative.Str(o.Targets[0], "ScenarioKey") != null;
        }

        /// <summary>从 start 出发（含）能到的节点集合。</summary>
        /// <summary>从 start 出发沿 OutPort 可达的节点集合。</summary>
        /// <param name="avoid">扩展时**不穿过**的节点（自己会包含在结果里，但不会继续往下走）。</param>
        /// <remarks>v260：区域计算需要两种避让 ——
        ///  G1 侧不穿过自己的 G0（v213：否则环形图里 G1 会绕回 G0，region 恒为 0）；
        ///  G0 侧不穿过同图其它门对的 G0（v233：否则一张图里多对门会互相把对方的独占内容圈进来，
        ///  导致 region 膨胀、冲突判定把全部对否掉）。</remarks>
        private static HashSet<IntPtr> Reach(IntPtr start, Dictionary<IntPtr, OutInfo> outs,
                                             HashSet<IntPtr> avoid = null)
        {
            var seen = new HashSet<IntPtr> { start };
            var stack = new Stack<IntPtr>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                IntPtr cur = stack.Pop();
                if (avoid != null && cur != start && avoid.Contains(cur)) continue;
                if (!outs.TryGetValue(cur, out var o)) continue;
                for (int i = 0; i < o.Targets.Count; i++)
                {
                    IntPtr t = o.Targets[i];
                    if (seen.Add(t)) stack.Push(t);
                }
            }
            return seen;
        }

        /// <summary>v260：目标节点除 excludeSrc 之外还有没有别的入边。</summary>
        /// <remarks>用于「孤岛判据」：region 的出口边 (src→tgt) 一旦改指别处，若 tgt 只有这一条入边，
        /// tgt 连同它的整个下游都会不可达。实测（安卓端全库 450 对改线）命中 20 处，
        /// 丢的是整段内容 —— DBZX-6 丢 43 个节点：6 段剧情 + 强制NPC死亡×6 + 删除标记×10 + 选项×2。</remarks>
        private static bool HasOtherIn(Dictionary<IntPtr, OutInfo> outs, IntPtr tgt, IntPtr excludeSrc)
        {
            foreach (var kv in outs)
            {
                if (kv.Key == excludeSrc) continue;
                var ts = kv.Value.Targets;
                for (int i = 0; i < ts.Count; i++) if (ts[i] == tgt) return true;
            }
            return false;
        }

        /// <summary>v280：门的 conditionPort 连接数。强制放行的粒度是门，必须恰好 1 个条件。</summary>
        private static int CondPortCount(IntPtr gate)
        {
            if (gate == IntPtr.Zero) return 0;
            try
            {
                IntPtr cp = NodePort(gate, "conditionPort");
                return cp == IntPtr.Zero ? 0 : ConnCount(cp);
            }
            catch { return 0; }
        }

        /// <summary>v280：**整链决策** —— 同一条链上的门对必须一起展开或一起不展开。
        ///
        /// 链的定义（宽松，对齐手机版）：pair i 的 G1 门出边指向 pair j 的 G0 / G1 / j 的父节点
        /// → i 与 j 同链。
        ///
        /// 为什么必须整链：全展开 = 并联改串联（确定）；全不展开 = 保持互斥（确定）；
        /// **部分展开 = 一边串联一边并联 → 引擎「无法确定走哪个分支」**（官方 ModEditor 文档
        /// 第 251 段原话）。手机版实测 R10049-0：5 段剧情在几毫秒内连续触发，玩家看不见。
        /// </summary>
        private static List<Pair> ChainDecide(List<Pair> expand, List<Pair> all,
                                              Dictionary<IntPtr, OutInfo> outs)
        {
            if (expand.Count <= 1) return expand;
            // 并查集
            var idx = new Dictionary<Pair, int>();
            for (int i = 0; i < all.Count; i++) idx[all[i]] = i;
            var par = new int[all.Count];
            for (int i = 0; i < par.Length; i++) par[i] = i;
            Func<int, int> find = null;
            find = x => { while (par[x] != x) { par[x] = par[par[x]]; x = par[x]; } return x; };

            // 父节点表：谁的 Targets 恰好含 {G0,G1}
            var parentOf = new Dictionary<Pair, IntPtr>();
            foreach (var q in all)
            {
                foreach (var kv in outs)
                {
                    var ts = kv.Value.Targets;
                    if (ts.Count == 2 && ((ts[0] == q.G0 && ts[1] == q.G1) || (ts[0] == q.G1 && ts[1] == q.G0)))
                    { parentOf[q] = kv.Key; break; }
                }
            }

            for (int i = 0; i < all.Count; i++)
            {
                var p = all[i];
                if (!outs.TryGetValue(p.G1, out var g1o)) continue;
                foreach (var t in g1o.Targets)
                {
                    for (int j = 0; j < all.Count; j++)
                    {
                        if (j == i) continue;
                        var q = all[j];
                        bool linked = (t == q.G0 || t == q.G1);
                        IntPtr pq; if (!linked && parentOf.TryGetValue(q, out pq)) linked = (t == pq);
                        if (!linked) continue;
                        int ra = find(i), rb = find(j);
                        if (ra != rb) par[ra] = rb;
                    }
                }
            }

            var expandSet = new HashSet<Pair>(expand);
            var keep = new List<Pair>();
            var groups = new Dictionary<int, List<Pair>>();
            for (int i = 0; i < all.Count; i++)
            {
                int r = find(i);
                List<Pair> g;
                if (!groups.TryGetValue(r, out g)) { g = new List<Pair>(); groups[r] = g; }
                g.Add(all[i]);
            }
            int blockedByChain = 0;
            foreach (var kv in groups)
            {
                bool allOk = true;
                foreach (var q in kv.Value) if (!expandSet.Contains(q)) { allOk = false; break; }
                if (allOk) { foreach (var q in kv.Value) keep.Add(q); }
                else blockedByChain += kv.Value.Count;
            }
            if (blockedByChain > 0 && _logGraph < 200)
                Plugin.L.LogInfo("[flat] 整链决策：连带拦下 " + blockedByChain + " 对（链内有不通过的对）");
            return keep;
        }

        private static List<KeyValuePair<IntPtr, IntPtr>> FindExits(
            HashSet<IntPtr> region, Dictionary<IntPtr, OutInfo> outs, IntPtr g1)
        {
            var res = new List<KeyValuePair<IntPtr, IntPtr>>(4);
            foreach (var node in region)
            {
                if (!outs.TryGetValue(node, out var o)) continue;
                for (int i = 0; i < o.Targets.Count; i++)
                {
                    IntPtr t = o.Targets[i];
                    if (region.Contains(t)) continue;
                    if (t == g1) continue;                        // 已经接过去了
                    res.Add(new KeyValuePair<IntPtr, IntPtr>(node, t));
                }
            }
            return res;
        }

        // ================================================================ 状态缓存

        private static void Remember(IntPtr node)
        {
            if (node == IntPtr.Zero || !_nodeChecked.Add(node)) return;
            _nodeOrder.Enqueue(node);
            while (_nodeOrder.Count > NodeCap) _nodeChecked.Remove(_nodeOrder.Dequeue());
        }

        // ================================================================ 端口/连线
        /// <summary>
        /// 取节点上的端口对象。
        ///
        /// ⚠️ `StoryDefaultNode.ConditionPort` / `DialogNodePort` 这些类型在 il2cpp 里是**空类**
        /// （无基类、无字段、无方法），而节点上的端口字段声明的正是它们 —— 读字段拿到的是空壳。
        /// 真端口只在 `Node.ports` 字典里，必须走 `Node.GetPort(名字)`。
        /// </summary>
        private static IntPtr NodePort(IntPtr node, string name)
        {
            IntPtr p = Il2CppNative.Ptr(node, name);
            if (IsUsablePort(p)) return p;

            IntPtr q = Il2CppNative.GetPort(node, name);
            if (IsUsablePort(q)) return q;
            return IntPtr.Zero;                 // 空壳没用，当没有
        }

        private static bool IsUsablePort(IntPtr port)
        {
            if (port == IntPtr.Zero) return false;
            return Il2CppNative.HasField(port, "connections")
                || Il2CppNative.HasMethod(port, "get_Connection", 0);
        }

        private static int ConnCount(IntPtr port)
        {
            IntPtr cl = Il2CppNative.Ptr(port, "connections");
            if (cl != IntPtr.Zero)
            {
                int n = Il2CppNative.ListCount(cl);
                if (n > 0) return n;
            }
            return 0;
        }

        /// <summary>第 idx 条连线连到的节点。</summary>
        private static IntPtr ConnNodeAt(IntPtr port, int idx)
        {
            if (port == IntPtr.Zero || idx < 0) return IntPtr.Zero;
            IntPtr cl = Il2CppNative.Ptr(port, "connections");
            if (cl != IntPtr.Zero)
            {
                if (idx >= Il2CppNative.ListCount(cl)) return IntPtr.Zero;
                IntPtr c = Il2CppNative.ListItem(cl, idx);
                if (c != IntPtr.Zero)
                {
                    IntPtr nd = Il2CppNative.Ptr(c, "node");
                    if (nd != IntPtr.Zero) return nd;
                }
            }
            if (idx == 0)
            {
                IntPtr p = Il2CppNative.CallRef(port, "get_Connection");
                if (p != IntPtr.Zero) return Il2CppNative.CallRef(p, "get_node");
            }
            return IntPtr.Zero;
        }

        /// <summary>conditionPort 连着的条件节点。</summary>
        private static IntPtr ConditionOf(IntPtr port)
        {
            IntPtr c = ConnNodeAt(port, 0);
            if (c != IntPtr.Zero) return c;
            IntPtr peer = Il2CppNative.CallRef(port, "get_Connection");
            return peer == IntPtr.Zero ? IntPtr.Zero : Il2CppNative.CallRef(peer, "get_node");
        }

        /// <summary>
        /// 从门指针直接读它 conditionPort 连着的条件节点的 partnerID。
        ///
        /// 用于「门通过时清陌生名」：需要一个「门 → 角色 uid」的映射，而 1.11.42 里
        /// 还没有后加的 _gateInfo 表，所以现场从字段读（条件节点 partnerID 偏移 0x48）。
        /// 读不到就返回 0，调用方按「与角色无关」处理。
        /// </summary>
        internal static int GatePartnerId(IntPtr gate)
        {
            try
            {
                if (gate == IntPtr.Zero) return 0;
                IntPtr cp = NodePort(gate, "conditionPort");
                if (cp == IntPtr.Zero) return 0;
                IntPtr cond = ConditionOf(cp);
                if (cond == IntPtr.Zero) return 0;
                return Il2CppNative.Int32(cond, "partnerID");
            }
            catch { return 0; }
        }

        /// <summary>把端口上「指向 oldTarget」的那条连线改成指向 newTarget。</summary>
        private static bool RedirectEdge(IntPtr port, IntPtr oldTarget, IntPtr newTarget)
        {
            if (port == IntPtr.Zero || newTarget == IntPtr.Zero) return false;

            IntPtr cl = Il2CppNative.Ptr(port, "connections");
            if (cl != IntPtr.Zero)
            {
                int cnt = Il2CppNative.ListCount(cl);
                for (int i = 0; i < cnt && i < 32; i++)
                {
                    IntPtr c = Il2CppNative.ListItem(cl, i);
                    if (c == IntPtr.Zero) continue;
                    if (Il2CppNative.Ptr(c, "node") != oldTarget) continue;
                    if (Il2CppNative.WritePtr(c, "node", newTarget)) return true;
                }
            }
            return false;
        }

        private static string Hex(IntPtr p)
        {
            return "0x" + p.ToInt64().ToString("X");
        }
    }
}
