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

        private static bool IsBlacklisted(string gn)
        {
            try
            {
                var cfg = Plugin.FlattenBlacklist;
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
        }

        // ================================================================ 主流程
        private static void Apply(IntPtr graph, string graphName)
        {
            IntPtr list = Il2CppNative.Ptr(graph, "nodes");
            int n = Il2CppNative.ListCount(list);
            if (n <= 2 || n > MaxNodes)
            {
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

            if (pairs.Count == 0) { _done.Add(graph); return; }

            // ---------- ③ 每对算独占内容 region 与对外出口 ----------
            foreach (var p in pairs)
            {
                var r0 = Reach(p.G0, outs);
                var r1 = Reach(p.G1, outs);
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
            int skippedOverlap = 0, skippedExits = 0, skippedEmpty = 0;
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

                expand.Add(p);
            }

            if (_logGraph++ < 40)
                Plugin.L.LogInfo("[flat] 图 " + graphName + "：节点 " + n + "，门对 " + pairs.Count
                                 + "，展开 " + expand.Count + "（B 类 "
                                 + CountB(expand) + "），跳过 重叠" + skippedOverlap
                                 + "/空或无出口" + (skippedEmpty + skippedExits)
                                 + "/非A-B类" + xSkipped);

            if (expand.Count == 0) { _done.Add(graph); return; }

            // ---------- ⑤ 改线 + 接管门 ----------
            int ok = 0, fail = 0;
            foreach (var p in expand)
            {
                bool allOk = true;
                foreach (var e in p.Exits)
                {
                    IntPtr src = e.Key, oldT = e.Value;
                    var info = outs[src];
                    if (info.Port == IntPtr.Zero || !RedirectEdge(info.Port, oldT, p.G1))
                    {
                        allOk = false;
                        fail++;
                    }
                    else ok++;
                }

                _gateForced.Add(p.G0);
                _gateForced.Add(p.G1);

                try { RelaxName.MarkRelaxed(p.Pid, graphName); } catch { }

                if (_logPair++ < 60)
                    Plugin.L.LogInfo("[flat]   pid=" + p.Pid + (p.BothStory ? " (B 类)" : " (A 类)")
                                     + " 在队门=" + Hex(p.G0) + " 不在队门=" + Hex(p.G1)
                                     + " 内容 " + p.Region.Count + " 节点，改线 " + p.Exits.Count
                                     + (allOk ? "" : " ⚠部分失败"));
            }

            _done.Add(graph);

            if (_logGraph <= 40)
                Plugin.L.LogInfo("[flat] 图 " + graphName + " 展开完成：改线 " + ok + " 条"
                                 + (fail > 0 ? "，失败 " + fail + " 条" : "")
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
