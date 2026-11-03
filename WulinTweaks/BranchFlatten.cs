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

        /// <summary>
        /// v1.11.65：展平改线会**跳过** region 对外出口的原目标。
        /// 这里只允许跳过「纯流程分支、不写任何存档状态」的节点 —— 白名单，
        /// 不在名单里的一律不改这一对。
        ///
        /// 为什么必须是白名单而不是黑名单：剧情资产不止 ModEditor.zip，
        /// 还有 aa/config_assets_all.bundle 里的一大批（例如 R10136 一族 280 个资产）。
        /// 黑名单靠"列出所有写状态的节点名"，遇到没见过的类型就漏；
        /// 白名单则对未知类型默认拒绝改线，天然覆盖全部资产包。
        ///
        /// 全量统计（tools/audit_safe_skip_whitelist.py）：
        ///   902 个可改线门对 → 717 个（79%）出口只落在这些节点上，可改线；
        ///   185 个命中「时间流逝 / 添加标记 / 改变NPC关系值 / 设置自定义变量 …」→ 不改。
        ///
        /// - 流程判断：HoldNode，纯分支
        /// - 选项：玩家选择分支
        /// - 注释：不执行
        /// - 「播放剧情」内容以 StoryScenarioNode 开头：跳过它只是"这一段不播"，
        ///   与"原版 if/else 只播一段"的语义一致，不会写全局状态。
        ///   （注意：它的**内部**若含写状态节点，那些节点本来也只在这段被播时才执行。）
        /// </summary>
        private static readonly HashSet<string> SafeSkipNodes = new HashSet<string>(StringComparer.Ordinal)
        {
            "流程判断",
            "选项",
            "注释",
        };

        /// <summary>StoryScenarioNode 的名字是空/场景键，单独判定（见 IsSafeSkipNode）。</summary>
        private static bool IsStoryNode(IntPtr node)
        {
            try { return Il2CppNative.Str(node, "ScenarioKey") != null; } catch { return true; }
        }

        /// <summary>这个节点被"跳过"是否安全（纯流程分支 / 播放入口 / 注释）。</summary>
        private static bool IsSafeSkipNode(IntPtr node)
        {
            if (node == IntPtr.Zero) return false;
            // 剧情节点：「播放剧情」，等同于"这一段不播"，不写状态
            if (IsStoryNode(node)) return true;
            string tn = null;
            try { tn = Il2CppNative.Str(node, "name"); } catch { return false; }
            if (string.IsNullOrEmpty(tn)) return false;      // 读不到名字 → 保守拒绝
            return SafeSkipNodes.Contains(tn);
        }

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
        private static int _busy;   // v1.11.45：重入保护（条件判定可能跑在加载线程）

        internal static void Try(IntPtr anyNode)
        {
            if (System.Threading.Interlocked.Exchange(ref _busy, 1) != 0) return;
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
            finally { System.Threading.Interlocked.Exchange(ref _busy, 0); }
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
            public bool Skip;      // v1.11.57：本对由链式补丁接管，跳过 region 法
        public IntPtr G0;      // Negate = 0（在队侧）
            public IntPtr G1;      // Negate = 1（不在队侧）
            public int Pid;
            public bool BothStory; // 两侧都是单节点剧情 = B 类
            public bool FirstIsG0; // v1.11.48：父端口第一条连接是不是「在队」侧
            public IntPtr First;   // v1.11.50：父端口第一条连接（引擎先问这一道）
            public IntPtr Second;  // v1.11.50：第二条
            public HashSet<IntPtr> Region;
            public List<KeyValuePair<IntPtr, IntPtr>> Exits;  // (源节点, 旧目标)
        }

        // ================================================================ 主流程
        private static void Apply(IntPtr graph, string graphName)
        {
            IntPtr list = Il2CppNative.Ptr(graph, "nodes");
            int n = Il2CppNative.ListCount(list);
            if (n <= 2 || n > MaxNodes)
            {
                /* v1.11.65：**这里绝对不能再 Add(_processed)。**
                 *
                 * _processed 的唯一消费者是 RelaxAllowed，语义是「这张图展平已经处理过 →
                 * 只有登记进 _relaxOk 的条件才准放宽」。而这条早退分支是"节点表没读到"
                 * （n = 0 基本只可能是 Ptr(graph,"nodes") 这一次失败），它一个 RelaxOk 都没登记。
                 * 一旦把图名塞进 _processed，该图**所有**「某人在队」的条件就永久不放宽
                 * （本次进程内），表现正是「某事件有时不触发；关掉展平重启就恢复」。
                 *
                 * 现在：只记尝试次数、不碰 _processed，给有限次重试；重试到上限才放弃展开
                 * （放宽始终不受影响）。_attempts / MaxAttempts 早就声明了但从未使用，这里正式用上。 */
                int a;
                _attempts.TryGetValue(graph, out a);
                _attempts[graph] = ++a;
                if (a < MaxAttempts)
                {
                    if (_logMiss++ < 50)
                        Plugin.L.LogWarning("[flat] 图 " + graphName + " 节点数异常（" + n
                                            + "），本次跳过、下次重试（" + a + "/" + MaxAttempts + "）");
                    return;
                }
                _done.Add(graph);          // 重试到上限：只放弃"展开"，放宽照常
                Plugin.L.LogWarning("[flat] 图 " + graphName + " 节点数异常（" + n
                                    + "），已重试 " + a + " 次，放弃展开");
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
                if (condOf[nd] != IntPtr.Zero)
                {
                    try { _gateCls[nd] = Il2CppNative.ClassNameOf(condOf[nd]) ?? ""; } catch { }
                    try
                    {
                        int p2 = Il2CppNative.Int32(condOf[nd], "partnerID");
                        bool n2 = Il2CppNative.Byte(condOf[nd], "Negate") != 0;
                        _gatePidAll[nd] = new KeyValuePair<int, bool>(p2, !n2);
                    }
                    catch { }
                }
            }

            /* v1.11.65：入边计数 —— 链式接续要判断"能不能安全穿过某个节点"，
             * 只有**单入单出**的节点才允许穿过（改它的出口不会影响别的路径）。 */
            var ins = new Dictionary<IntPtr, int>(n);
            foreach (var kv in outs)
                foreach (var t in kv.Value.Targets)
                {
                    int c;
                    ins.TryGetValue(t, out c);
                    ins[t] = c + 1;
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

                // v1.11.47：**白名单**——只认「当前在队」这一类条件（HavePartnerCondition）。
                // 以前只看 partnerID+Negate，于是「存活/死亡」(NpcDeadCondition)、关系值、位置等
                // 同样带 partnerID 的条件也被当成在队门对，展平后两侧都强制放行 → 语义矛盾
                // （实测 R10049-2 的 10063：石万三存活与死亡两侧都播）。
                // IsJoinedTeamCondition 语义是「曾经加入过队伍」，与当前在队无关；
                // SlgHavePartnerCondition 属 DLC 小游戏，均不参与。
                if (!IsInTeamCond(ca) || !IsInTeamCond(cb)) continue;

                int pa = Il2CppNative.Int32(ca, "partnerID");
                int pb = Il2CppNative.Int32(cb, "partnerID");
                if (pa <= 0 || pa != pb) continue;                 // partnerID<=0 不是「需要伙伴」

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
                // v1.11.47：改用「这一侧的可达集里是否含播放剧情节点」，
                // 于是「门 → 设置标记 → 播放剧情」这类 X 类也能放开；
                // 两侧都只有辅助节点（设标记/时间流逝）的仍然放弃。
                bool s0 = SideHasStory(outs, g0);
                bool s1 = SideHasStory(outs, g1);
                if (!s0 && !s1) { xSkipped++; continue; }

                pairs.Add(new Pair
                {
                    G0 = g0,
                    G1 = g1,
                    Pid = pa,
                    BothStory = s0 && s1,
                    FirstIsG0 = (a == g0),
                    First = a,
                    Second = b,
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
                // v1.11.61：图里没有门对 → 允许放宽“门直接挂着的队友条件”（与手机 v178 一致）
                foreach (var kv in condOf)
                {
                    try { if (IsInTeamCond(kv.Value)) RelaxOkAdd(graphName, kv.Value); } catch { }
                }
                _processed.Add(graphName);
                _processed.Add(graphName);
                _done.Add(graph); return;
            }

            // ---------- ③ 每对算独占内容 region 与对外出口 ----------
            foreach (var p in pairs)
            {
                var r0 = Reach(p.First, outs);
                var r1 = Reach(p.Second, outs);
                var region = new HashSet<IntPtr>(r0);
                region.ExceptWith(r1);
                region.Remove(p.First);
                region.Remove(p.Second);
                p.Region = region;
                p.Exits = region.Count == 0 || region.Count > MaxRegion
                    ? new List<KeyValuePair<IntPtr, IntPtr>>()
                    : FindExits(region, outs, p.Second);
            }

            // ---------- ④ 剔除有问题的对（空 / 过大 / 无出口） ----------
            // v1.11.43（用户指定）：**删掉“与另一对 region 相交就跳过”这一条**。
            // 实测 R10049-2：10054 的 region 只有 1 个节点（R10049-2_3_2_2），却被 10063（8 节点）
            // 完整包住 → 老规则两对都放弃 → 10054 的剧情永远不播。
            // 而“让重叠部分只播一次”需要在重叠节点上做执行期标记，代价与风险都大于收益；
            // 两对都展开后执行期天然只走一条路径，不会重复播放。
            //
            // ===== v1.11.65：链式接续**停用**，理由有据，不是图省事 =====
            //
            // 它当初是为了解决"放宽后 p 的支线演完就结束、后一个角色的门轮不到"。
            // 用同一份剧情资产实测，这个前提**不成立**：
            //   · tools/audit_chain_patch_v2.py：名单 13 条里 11 条的 region
            //     （= reach(G0) − reach(G1)，即"该角色的独占内容"）**为空** ——
            //     说明放宽这些对根本不改变后续走向，无从堵死。
            //   · R10049-2-1 实际连线：_4_2（10061 的剧情）→ 添加标记 →
            //     **入边=9 的共享分派门** → 继续问 20243/20231/42161/42162/42163…
            //     也就是所有角色的支线本来就汇回同一个分派门，10098 的门自然会被问到。
            //
            // 而它带来的代价是实打实的：旧实现"只跳一层 + 硬编码添加标记/追加简介"，
            // 遇到「时间流逝 Num=8」就直接改它前面那条边 → **时间不推进**（R10005-5 实测），
            // 依赖时间的无关剧情全部错位。这正是"开了分支展开后某些剧情触发不了"的成因。
            //
            // 所以：不串。名单与 ApplyChain 保留（v1.11.65 已把 ApplyChain 改成 region 判据，
            // 需要时可单独放开验证），默认一个都不调。
            //
            //   int[] chainOrder;
            //   if (_chains.TryGetValue(graphName ?? "", out chainOrder) && chainOrder.Length >= 2 && pairs.Count >= 2)
            //       ApplyChain(graphName, chainOrder, pairs, outs, ins, _gateCls);

            var expand = new List<Pair>();
            int skippedOverlap = 0, skippedExits = 0, skippedEmpty = 0, skippedGlobal = 0;
            foreach (var p in pairs)
            {
                if (p.Region.Count == 0) { skippedEmpty++; continue; }
                if (p.Region.Count > MaxRegion) { skippedEmpty++; continue; }
                if (p.Exits.Count == 0) { skippedExits++; continue; }

                foreach (var q in pairs)
                {
                    if (q == p || q.Region.Count == 0) continue;
                    if (p.Region.Overlaps(q.Region)) { skippedOverlap++; break; }   // 只计数
                }

                if (p.Skip) continue;      // v1.11.57：已被链式补丁接管的对，不再走 region 法

                /* v1.11.65：**白名单保护** —— "局部改线不得影响全局触发"的硬闸。
                 * 改线的本质是「把 region 对外出口改指到不在队门」，原目标被跳过。
                 * 这条只放行"纯流程分支"；只要有一个出口落到写状态的节点上，
                 * 或者节点名读不出来（后果不可预期），就放弃改这一对。
                 * 详见 SafeSkipNodes 的注释与 tools/audit_safe_skip_whitelist.py。 */
                bool unsafePair = false;
                foreach (var e in p.Exits)
                {
                    if (!IsSafeSkipNode(e.Value)) { unsafePair = true; break; }
                }
                if (unsafePair) { skippedGlobal++; continue; }

                try { RelaxOkAdd(graphName, condOf[p.First]); RelaxOkAdd(graphName, condOf[p.Second]); } catch { }
                expand.Add(p);
            }

            if (_logGraph++ < 200)
                Plugin.L.LogInfo("[flat] 图 " + graphName + "：节点 " + n + "，门对 " + pairs.Count
                                 + "，展开 " + expand.Count + "（B 类 "
                                 + CountB(expand) + "），跳过 重叠" + skippedOverlap
                                 + "/空或无出口" + (skippedEmpty + skippedExits)
                                 + "/全局状态保护" + skippedGlobal
                                 + "/非A-B类" + xSkipped);

            if (expand.Count == 0) { _done.Add(graph); return; }

            // ---------- ⑤ 改线（事务化：先全改、再校验、不合格整体回滚） ----------
            // v1.11.45：校验两条，缺一都会导致「剧情卡死」：
            //   ① 无新增环 —— 新环必然经过某条被改的边 (src→g1)，所以只需判断 g1 能否回到 src；
            //   ② 可达性守恒 —— 改线后 Reach(g1) 必须仍包含改线前的 Reach(g1)（汇合点不能丢）。
            // 任一不过 → 逆序还原所有边 + 撤销门登记。
            // v1.11.46：可达性守恒**按对**比较（并集比较是 v1.11.45 的错误做法）
            var beforeByPair = new Dictionary<Pair, HashSet<IntPtr>>();
            foreach (var p in expand) beforeByPair[p] = Reach(p.Second, outs);

            var undo = new List<(IntPtr Port, IntPtr OldT, IntPtr Src, IntPtr G1)>();
            bool commitFail = false;
            int ok = 0, fail = 0;

            foreach (var p in expand)
            {
                foreach (var e in p.Exits)
                {
                    IntPtr srcNode = e.Key, oldT = e.Value;
                    if (!outs.TryGetValue(srcNode, out var info) || info.Port == IntPtr.Zero
                        || !RedirectEdge(info.Port, oldT, p.Second))
                    {
                        commitFail = true;
                        break;
                    }
                    int idx = info.Targets.IndexOf(oldT);
                    if (idx >= 0) info.Targets[idx] = p.Second; // 同步内存模型，供环检测使用
                    undo.Add((info.Port, oldT, srcNode, p.Second));
                    ok++;
                }
                if (commitFail) break;
            }

            bool rolled = commitFail;
            if (!rolled)
            {
                foreach (var u in undo)
                {
                    if (Reach(u.G1, outs).Contains(u.Src)) { rolled = true; break; }   // 新增环
                }
            }
            if (!rolled)
            {
                foreach (var p in expand)
                {
                    if (!beforeByPair[p].IsSubsetOf(Reach(p.Second, outs))) { rolled = true; break; }
                }
            }

            if (rolled)
            {
                for (int i = undo.Count - 1; i >= 0; i--)
                {
                    var u = undo[i];
                    // 还原连线（此时目标已是 G1，用 RedirectEdge 把它指回旧目标）
                    try { RedirectEdge(u.Port, u.G1, u.OldT); } catch { }
                }
                ok = 0;
                Plugin.L.LogWarning("[flat] 图 " + graphName + " 回滚：改线 " + undo.Count
                                    + " 条后校验不通过（环或可达性），已全部还原");
            }
            else
            {
                foreach (var p in expand)
                {
                    _gateForced.Add(p.First);
                    _gateForced.Add(p.Second);
                    // v1.11.52：强制表登记的是 First/Second，日志查询的也是它们
                    _gateInfo[p.First] = new KeyValuePair<int, bool>(p.Pid, p.First == p.G0);
                    _gateInfo[p.Second] = new KeyValuePair<int, bool>(p.Pid, p.Second == p.G0);
                    RelaxOkAdd(graphName, condOf[p.First]);
                    RelaxOkAdd(graphName, condOf[p.Second]);
                    try { RelaxName.MarkRelaxed(p.Pid, graphName); } catch { }

                    if (_logPair++ < 300)
                        Plugin.L.LogInfo("[flat]   pid=" + p.Pid + (p.BothStory ? " (B 类)" : " (A 类)")
                                         + " 在队门=" + Hex(p.G0) + " 不在队门=" + Hex(p.G1)
                                         + " 先问=" + (p.FirstIsG0 ? "在队" : "不在队")
                                         + " 内容 " + p.Region.Count + " 节点，改线 " + p.Exits.Count);
                }
            }

            _done.Add(graph);

            if (_logGraph <= 200)
                Plugin.L.LogInfo("[flat] 图 " + graphName + " 展开完成：改线 " + ok + " 条"
                                 + (rolled ? "（已回滚）" : "")
                                 + "，接管门 " + _gateForced.Count + " 个（累计）");
        }


        /// <summary>v1.11.57：链式接续表（与 Android v173 完全一致）。
        /// 顺序由场景编号推出、离线环检测通过；含义：把「第 i 个角色内容末端」接到「第 i+1 个角色在队门」。</summary>
        private static readonly Dictionary<string, int[]> _chains = new Dictionary<string, int[]> {
            { "M5061-5",    new[] { 10008, 10018, 10086, 10088, 10067, 10053 } },
            { "R10005-5",   new[] { 10061, 10098 } },
            { "R10049-2-1", new[] { 10061, 10075, 10052, 10098 } },
            { "R10098-1",   new[] { 10075, 10005 } },
            // v1.11.58：逐张分析后新增
            { "Role5-10",   new[] { 10035, 10036 } },
            { "M5061-3",    new[] { 10005, 10098 } },
            { "R10039-6",   new[] { 20022, 10064 } },
        };

        /// <summary>
        /// 把名单里的一张图按 pid 顺序串起来：内容末端 → 下一对在队门。
        ///
        /// v1.11.65 重写：**不再"只跳一层 + 硬编码两个节点名"**。
        ///
        /// 为什么要串：放宽会让 p 的在队条件判真 → 流程走进 p 的独占支线，而那条支线
        /// 往往以「添加标记」之类的收尾节点结束、不回到主线 → 后面角色（比如鱼薇儿 10098）
        /// 的门永远轮不到。串起来就是把 p 内容的出口接到 q 的在队门，保证链上每人都能演。
        ///
        /// 旧实现的 bug：只前瞻一层，且只认「添加标记」「追加简介」两个名字。
        /// 遇到「时间流逝（Num=8）」这种节点就停在前一个节点上，把这条边改掉 →
        /// **时间流逝被整个跳过**（R10005-5 实测），游戏时间不推进，连累无关剧情。
        /// 遇到「播放剧情 X」同理，直接砍掉那一段。
        ///
        /// 现在：从内容起点开始，沿着**单入单出**的节点一路走到头，改最后一个节点的出口。
        ///   · 时间流逝 / 添加标记 / 追加简介 / 写入记事本 / 关系值 … 只要单入单出，全部保留执行
        ///   · 一旦遇到分支（出口 ≠ 1）或多入节点（改它会波及别的路径）→ 放弃这一对，不改线
        /// 放弃是安全的：不放线时后面角色的门能不能轮到，由"未接管禁止放宽"那条兜底
        /// （见 TeamRule / flatten_relax_forbidden 的对称实现）。
        /// </summary>
        private static int ApplyChain(string gn, int[] order, List<Pair> pairs,
                                      Dictionary<IntPtr, OutInfo> outs,
                                      Dictionary<IntPtr, int> ins,
                                      Dictionary<IntPtr, string> gateCls)
        {
            int applied = 0, gaveUp = 0;
            for (int i = 0; i + 1 < order.Length; i++)
            {
                Pair p = null, q = null;
                foreach (var x in pairs) { if (x.Pid == order[i]) p = x; if (x.Pid == order[i + 1]) q = x; }
                if (p == null || q == null) continue;

                OutInfo fo;
                if (!outs.TryGetValue(p.G0, out fo) || fo.Targets.Count < 1) continue;
                IntPtr src = fo.Targets[0];            // p 的在队门第一条出边 = 内容起点

                // 沿单入单出的节点一路走到底（最多 64 跳，防意外环路）
                bool ok = true;
                for (int guard = 0; guard < 64; guard++)
                {
                    OutInfo cur;
                    if (!outs.TryGetValue(src, out cur)) { ok = false; break; }
                    if (cur.Targets.Count != 1) { ok = false; break; }   // 分支：不知道该改哪条

                    IntPtr nxt = cur.Targets[0];
                    // 撞到门（含本对/下一对的四道门）→ 到此为止，改 src 的出口
                    if (gateCls.ContainsKey(nxt) || nxt == p.G0 || nxt == p.G1 ||
                        nxt == q.G0 || nxt == q.G1) break;

                    OutInfo no;
                    if (!outs.TryGetValue(nxt, out no)) { ok = false; break; }
                    if (no.Targets.Count != 1) { ok = false; break; }    // 下一个是分支 → 只能停，但停在前一个节点上会跳过它

                    int inc;
                    if (!ins.TryGetValue(nxt, out inc) || inc != 1) { ok = false; break; } // 多入 → 改它会波及别的路径

                    src = nxt;                          // 单入单出 → 穿过去（副作用节点照常执行）
                }
                if (!ok)
                {
                    gaveUp++;
                    if (_logPair++ < 300)
                        Plugin.L.LogInfo("[flat] 图 " + gn + " 链式接续放弃 pid=" + p.Pid
                                         + " → " + q.Pid + "：末端不是单入单出，改了会丢副作用");
                    continue;
                }

                OutInfo se;
                if (!outs.TryGetValue(src, out se) || se.Targets.Count != 1) { gaveUp++; continue; }
                if (!RedirectEdge(se.Port, se.Targets[0], q.G0)) { gaveUp++; continue; }
                se.Targets[0] = q.G0;
                applied++;
                _gateForced.Add(p.G0); _gateForced.Add(q.G0);
                p.Skip = true; q.Skip = true;
                if (_logPair++ < 300)
                    Plugin.L.LogInfo("[flat] 图 " + gn + " 链式接续：pid " + p.Pid
                                     + " 内容末端(" + NodeLabel(src) + ") → pid " + q.Pid + " 在队门");
            }
            if (applied > 0 || gaveUp > 0)
                Plugin.L.LogInfo("[flat] 图 " + gn + " 链式接续：改线 " + applied
                                 + " 条，放弃 " + gaveUp + " 条");
            return applied;
        }

        private static string NodeLabel(IntPtr nd)
        {
            try
            {
                string sk = Il2CppNative.Str(nd, "ScenarioKey");
                if (sk != null) return "播放剧情 " + sk;
                return Il2CppNative.Str(nd, "name") ?? "?";
            }
            catch { return "?"; }
        }

        private static int CountB(List<Pair> ps)
        {
            int c = 0;
            for (int i = 0; i < ps.Count; i++) if (ps[i].BothStory) c++;
            return c;
        }

        /// <summary>
        /// v1.11.49：允许参与展平的条件类。
        ///   需要伙伴（当前在队） / 判断地图存在NPC / 需要NPC处于家园中。
        ///   需要NPC情缘**未加入**：R10049-2 里它的下游是 R10049-2_6_6（定海棠出演），
        ///   绛紫烟本人出演的 _6_7 由「需要伙伴」控制，按用户规则不加。
        /// </summary>
        private static bool IsInTeamCond(IntPtr cond)
        {
            try
            {
                string cn = Il2CppNative.ClassNameOf(cond);
                if (string.IsNullOrEmpty(cn)) return false;
                // v1.11.50（用户指定）：放宽与展平**都只对「需要伙伴」生效**。
                return cn == "HavePartnerCondition";
            }
            catch { return false; }
        }

        /// <summary>v1.11.49：门 → (pid, 是否在队侧)，供 [gate] 轨迹日志打印。</summary>
        private static readonly Dictionary<IntPtr, KeyValuePair<int, bool>> _gateInfo =
            new Dictionary<IntPtr, KeyValuePair<int, bool>>();
        private static readonly Dictionary<IntPtr, string> _gateCls = new Dictionary<IntPtr, string>();
        // v1.11.54：非白名单门也记一份 (pid, 侧别)，按**字段名**读（各子类偏移不同）
        private static readonly Dictionary<IntPtr, KeyValuePair<int, bool>> _gatePidAll =
            new Dictionary<IntPtr, KeyValuePair<int, bool>>();

        // v1.11.61：只有属于门对的条件才允许放宽（与手机 v178 对齐）
        private static readonly Dictionary<string, HashSet<IntPtr>> _relaxOk =
            new Dictionary<string, HashSet<IntPtr>>(StringComparer.OrdinalIgnoreCase);
        private static readonly HashSet<string> _processed =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        internal static bool RelaxAllowed(string gn, IntPtr cond)
        {
            if (string.IsNullOrEmpty(gn)) return true;
            HashSet<IntPtr> set;
            if (!_processed.Contains(gn)) return true;      // 还没处理过这张图 → 不阻断（兼容）
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

        internal static string GateCls(IntPtr gate)
        {
            string v; return _gateCls.TryGetValue(gate, out v) ? v : "";
        }

        internal static int GatePid(IntPtr gate, out bool inTeam)
        {
            inTeam = false;
            KeyValuePair<int, bool> v;
            if (_gateInfo.TryGetValue(gate, out v)) { inTeam = v.Value; return v.Key; }
            if (_gatePidAll.TryGetValue(gate, out v)) { inTeam = v.Value; return v.Key; }   // v1.11.54
            return 0;
        }

        /// <summary>v1.11.47：这一侧的可达集里是否含「播放剧情」节点。</summary>
        private static bool SideHasStory(Dictionary<IntPtr, OutInfo> outs, IntPtr gate)
        {
            foreach (var n in Reach(gate, outs))
            {
                if (Il2CppNative.Str(n, "ScenarioKey") != null) return true;
            }
            return false;
        }

        /// <summary>这一侧是不是「单个播放剧情节点」——用来区分 A 类/B 类（只用于日志）。</summary>
        private static bool IsStoryExit(Dictionary<IntPtr, OutInfo> outs, IntPtr gate)
        {
            if (!outs.TryGetValue(gate, out var o)) return false;
            if (o.Targets.Count != 1) return false;
            return Il2CppNative.Str(o.Targets[0], "ScenarioKey") != null;
        }

        /// <summary>从 start 出发（含）能到的节点集合。</summary>
        private static HashSet<IntPtr> Reach(IntPtr start, Dictionary<IntPtr, OutInfo> outs)
        {
            var seen = new HashSet<IntPtr> { start };
            var stack = new Stack<IntPtr>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                IntPtr cur = stack.Pop();
                if (!outs.TryGetValue(cur, out var o)) continue;
                for (int i = 0; i < o.Targets.Count; i++)
                {
                    IntPtr t = o.Targets[i];
                    if (seen.Add(t)) stack.Push(t);
                }
            }
            return seen;
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
