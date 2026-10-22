using System;
using System.Collections.Generic;

namespace WulinTweaks
{
    /// <summary>
    /// 剧情分支展开（Branch Flattener）—— PC 版，与手机端 v69~v79 的 flatten.cpp 同一套语义。
    ///
    /// === 它做什么 ===
    /// 原版剧情图里「某角色是否在队」的条件是**互补兄弟对**（Negate=0 / Negate=1），
    /// 引擎语义是「按顺序问，第一个满足的就被走，后面的不再问」，也就是 if/else。
    /// 而讲解类剧情的出口直接连到汇合点，所以第一个命中的分支一播完就推进主线，
    /// 另一侧永远不播。
    ///
    /// 这里把讲解链的出口改接到「下一段讲解的门」上，于是变成**顺序播放**：
    /// 先播「队内有该角色」的剧情，一路串下去，最后落到原版「无伙伴」那条兜底，再汇合收尾。
    ///
    /// === PC 与手机端的实现差别（重要，别再走回头路）===
    /// 手机端是「找到每个门挂着的条件节点，把那个条件判真」。PC 上一度照抄，结果卡死在
    /// `HoldNode.conditionPort` 上：
    ///
    ///   [flat:gate] 门类=HoldNode 端口类=ConditionPort  connections字段=无
    ///               get_Connection=无  GetConnections=无
    ///
    /// 也就是说 PC 版这个 `ConditionPort` 对象是个**空壳**（il2cpp 里只有 .ctor，
    /// 无字段无方法），根本不是真正的 NodePort，从它出发永远走不到条件节点。
    ///
    /// 所以 PC 版改成**完全结构化的路线**：
    ///   ① 认门：从起点沿 `OutPort.connections[1]` 走 5 步，一路收集 10 个门，
    ///      第 5 步落点就是「无伙伴」兜底门 —— 与手机端 FLAT_WALK_STEPS 的做法一致，
    ///      完全不碰 conditionPort、也不需要读 partnerID；
    ///   ② 接管：把认出来的门登记进 _gateForced，由 `HoldNode.CheckCondition` 的
    ///      Postfix 直接判真（见 Patch_FlattenGate）。
    ///
    /// 实测结构（PC 的 R10049-2.asset 核对过，380 节点）：
    ///   _2_1 ─┬→ 门84N0 → _2_2 → _2_9
    ///         └→ 门84N1 ─┬→ 门83N0 → _2_3 → _2_9
    ///                     └→ 门83N1 ─┬→ 门78N0 → _2_4 → _2_9
    ///                                 └→ 门78N1 ─┬→ 门53N0 → _2_5 → _2_9
    ///                                             └→ 门53N1 ─┬→ 门08N0 → _2_6 → _2_9
    ///                                                         └→ 门08N1 ─┬→ 门20204N0 → _2_7_1
    ///                                                                     └→ 门20204N1 → _2_8 → _2_9
    /// </summary>
    internal static class BranchFlatten
    {
        // ---------------------------------------------------------------- 目标
        private const string GraphName = "R10049-2";
        private const string StartKey = "R10049-2_2_1";

        /// <summary>依次串起来的 5 段讲解（最后一段出口改接到兜底门）。</summary>
        private static readonly string[] ChainKeys =
        {
            "R10049-2_2_2",   // 洛千雪 10084
            "R10049-2_2_3",   // 洛天雄 10083
            "R10049-2_2_4",   // 裘之墨 10078
            "R10049-2_2_5",   // 说书人 10053
            "R10049-2_2_6",   // 凌梦蝶 10008
        };

        /// <summary>讲解链上的 5 个角色（只用于提前打开姓名窗口与日志）。</summary>
        private static readonly int[] NeutralPids = { 10084, 10083, 10078, 10053, 10008 };

        /// <summary>从起点沿 OutPort.connections[1] 走几步到兜底门。</summary>
        private const int LadderSteps = 5;

        // ---------------------------------------------------------------- 状态
        /// <summary>被「展开」接管、一律判真的门（HoldNode 指针）。</summary>
        private static readonly HashSet<IntPtr> _gateForced = new HashSet<IntPtr>();

        /// <summary>已处理过 / 不是目标图的 graph 指针（避免在热路径上反复取名字）。</summary>
        private static readonly HashSet<IntPtr> _skip = new HashSet<IntPtr>();
        private static readonly Queue<IntPtr> _skipOrder = new Queue<IntPtr>();
        private const int SkipCap = 512;

        /// <summary>
        /// 「这个节点已经判定过归属」。Try 挂在 dobby 的条件判定上，每秒上百次，
        /// 而每次判定都要取 graph 指针 + 读图名（会分配 .NET 字符串）。
        /// 这里按节点指针缓存结论，让同一节点的第二次之后只剩一次哈希查找。
        /// </summary>
        private static readonly HashSet<IntPtr> _nodeChecked = new HashSet<IntPtr>();
        private static readonly Queue<IntPtr> _nodeOrder = new Queue<IntPtr>();
        private const int NodeCap = 8192;

        /// <summary>目标图的套用尝试次数（节点没加载完时重试，但必须限次）。</summary>
        private static readonly Dictionary<IntPtr, int> _attempts = new Dictionary<IntPtr, int>();
        private const int MaxAttempts = 8;

        private static int _logMiss, _logTake;
        private static bool _warnedApi;

        // ================================================================ 对外
        /// <summary>
        /// 这个门是否已被「分支展开」接管（= 无条件判真）。
        /// 由 `Patch_FlattenGate`（HoldNode.CheckCondition 的 Postfix）调用。
        ///
        /// ⚠️ 这里**故意不看开关**：一旦补写出边，图就回不去了 —— 若中途把开关关掉、
        /// 而判真也一起失效，那么「_2_6 出口已指向兜底门」+「兜底门判假」= 剧情永久卡死。
        /// 开关只在「决定要不要打补丁」时读。
        /// </summary>
        internal static bool IsGateForced(IntPtr holdNode)
        {
            return holdNode != IntPtr.Zero && _gateForced.Count > 0 && _gateForced.Contains(holdNode);
        }

        /// <summary>
        /// 在图上套用补丁。anyNode 可以是目标图里的任意一个节点（用它的 graph 指针去重）。
        /// 由 Patch_StoryPlayBegin（剧情开始播放）和 NativeTeamHook.Dispatch（条件判定）
        /// 两个很热的点调用，所以除了首次命中，其余都是一次哈希查找。
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
                if (graph == IntPtr.Zero)
                {
                    Probe("取不到 graph：node=" + Hex(anyNode)
                          + " class=" + (Il2CppNative.ClassNameOf(anyNode) ?? "?"));
                    Remember(anyNode);
                    return;
                }
                if (_skip.Contains(graph)) { Remember(anyNode); return; }

                string gn = Il2CppNative.Str(graph, "_name");
                if (gn == null)
                {
                    // 读不到图名 ≠ 不是目标图：可能是对象还没完全初始化。
                    // 不能 Skip（那样这张图就永久不处理了），下次再试。
                    Probe("读不到图名 graph=" + Hex(graph));
                    return;
                }
                if (!string.Equals(gn, GraphName, StringComparison.Ordinal))
                {
                    Probe("非目标图 name=\"" + gn + "\"");
                    Skip(graph);
                    Remember(anyNode);
                    return;
                }

                Plugin.L.LogInfo("[flat] 命中目标图 " + GraphName + "，开始套补丁");
                Apply(graph, gn);
                if (_skip.Contains(graph)) Remember(anyNode);   // 打成功 / 放弃 → 以后不必再看
            }
            catch (Exception e)
            {
                if (_logMiss++ < 6) Plugin.L.LogError("[flat] Try 异常: " + e);
            }
        }

        // ================================================================ 打补丁
        private static void Apply(IntPtr graph, string graphName)
        {
            IntPtr list = Il2CppNative.Ptr(graph, "nodes");
            int n = Il2CppNative.ListCount(list);
            if (n <= 0 || n > 4096)
            {
                Skip(graph);
                Plugin.L.LogWarning("[flat] 图 " + graphName + " 的节点表异常（n=" + n + "），放弃");
                return;
            }

            // ---------- 第一遍：起点 + 5 段讲解（按 ScenarioKey） ----------
            IntPtr start = IntPtr.Zero;
            var chain = new IntPtr[ChainKeys.Length];
            int scenSeen = 0;
            string sampleKeys = "";

            for (int i = 0; i < n; i++)
            {
                IntPtr nd = Il2CppNative.ListItem(list, i);
                if (nd == IntPtr.Zero) continue;
                // 有效性校验：图里每个节点的 graph 字段都指回这张图。
                // 数组万一读偏，这一条能挡住，不至于把垃圾当节点用（手机端 v68 的 SIGSEGV）。
                if (Il2CppNative.Ptr(nd, "graph") != graph) continue;
                if (Il2CppNative.ClassNameOf(nd) != "StoryScenarioNode") continue;

                string key = Il2CppNative.Str(nd, "ScenarioKey");
                if (string.IsNullOrEmpty(key)) continue;
                scenSeen++;
                if (scenSeen <= 6) sampleKeys += (sampleKeys.Length == 0 ? "" : ", ") + key;

                if (start == IntPtr.Zero && string.Equals(key, StartKey, StringComparison.Ordinal)) start = nd;
                for (int e = 0; e < ChainKeys.Length; e++)
                    if (chain[e] == IntPtr.Zero && string.Equals(key, ChainKeys[e], StringComparison.Ordinal))
                        chain[e] = nd;
            }

            if (start == IntPtr.Zero)
            {
                // 图可能还没加载完 → 下次 hook 再试。但**必须限次**：
                // Try 挂在每次队友条件判定上，重试一次就要扫 380 个节点。
                _attempts.TryGetValue(graph, out int att);
                att++;
                _attempts[graph] = att;
                if (att <= 3)
                    Plugin.L.LogWarning("[flat] 图 " + graphName + " 里没找到起点 " + StartKey
                                        + "（第 " + att + " 次；共 " + n + " 节点，其中播放剧情节点 "
                                        + scenSeen + " 个；样例：[" + sampleKeys + "]）");
                if (att >= MaxAttempts)
                {
                    Skip(graph);
                    Plugin.L.LogWarning("[flat] 图 " + graphName + " 重试 " + att + " 次仍找不到起点，放弃");
                }
                return;
            }

            // ---------- 第二遍：结构走链认门（不依赖 conditionPort） ----------
            var gates = new List<IntPtr>(16);
            IntPtr gateLast = WalkLadder(start, gates);

            if (gateLast == IntPtr.Zero)
            {
                Skip(graph);
                Plugin.L.LogWarning("[flat] 图 " + graphName + " 结构走链失败，认不出兜底门，放弃展开"
                                    + "（共 " + n + " 节点，起点已找到）");
                return;
            }

            for (int e = 0; e < ChainKeys.Length; e++)
            {
                if (chain[e] != IntPtr.Zero) continue;
                Skip(graph);
                Plugin.L.LogWarning("[flat] 图 " + graphName + " 缺讲解节点 " + ChainKeys[e] + "，放弃展开");
                return;
            }

            // ---------- 第三遍：改连线（先把 5 条都验一遍再写） ----------
            var ops = new IntPtr[ChainKeys.Length];
            var conns = new IntPtr[ChainKeys.Length];
            var targets = new IntPtr[ChainKeys.Length];

            for (int e = 0; e < ChainKeys.Length; e++)
            {
                targets[e] = (e + 1 < ChainKeys.Length) ? chain[e + 1] : gateLast;

                ops[e] = NodePort(chain[e], "OutPort");
                if (ops[e] == IntPtr.Zero)
                {
                    Skip(graph);
                    Plugin.L.LogWarning("[flat] 图 " + graphName + " 的 " + ChainKeys[e]
                                        + " 取不到 OutPort 端口，放弃展开（节点类="
                                        + (Il2CppNative.ClassNameOf(chain[e]) ?? "?") + "）");
                    return;
                }
                conns[e] = ConnAt(ops[e], 0);

                if (conns[e] == IntPtr.Zero && !Il2CppNative.HasMethod(ops[e], "Connect", 1))
                {
                    Skip(graph);
                    Plugin.L.LogWarning("[flat] 图 " + graphName + " 的 " + ChainKeys[e]
                                        + " 既读不到 connections、也没有 Connect 方法，放弃展开"
                                        + "（端口类=" + (Il2CppNative.ClassNameOf(ops[e]) ?? "?")
                                        + " 继承=" + Il2CppNative.ClassChain(ops[e]) + "）");
                    return;
                }
            }

            int ok = 0;
            var how = new string[ChainKeys.Length];
            for (int e = 0; e < ChainKeys.Length; e++)
            {
                if (conns[e] != IntPtr.Zero && Il2CppNative.WritePtr(conns[e], "node", targets[e]))
                {
                    ok++;
                    how[e] = "字";
                    continue;
                }
                if (ApiRedirect(ops[e], targets[e]))
                {
                    ok++;
                    how[e] = "方";
                    continue;
                }
                how[e] = "×";
                Plugin.L.LogWarning("[flat] 改连失败 " + ChainKeys[e]);
            }
            if (ok < ChainKeys.Length)
                Plugin.L.LogError("[flat] ⚠ 只改成功 " + ok + "/" + ChainKeys.Length
                                  + " 条连线 —— 这张图的走线现在是半改状态，重启游戏可复原");

            // ---------- 第四遍：把认出来的门接管为「无条件判真」 ----------
            int added = 0;
            for (int i = 0; i < gates.Count; i++)
                if (_gateForced.Add(gates[i])) added++;

            Skip(graph);

            // ---------- 顺带把 5 个名字窗口打开 ----------
            // 后几位在剧情刚开始时可能还没有实例，等轮到各自的门才开窗口就晚了
            // （手机端 v75/v76 失败、v77 提前开才成功）。
            for (int i = 0; i < NeutralPids.Length; i++)
            {
                try { RelaxName.MarkRelaxed(NeutralPids[i], graphName); } catch { }
            }

            Plugin.L.LogInfo("[flat] 图 " + graphName + " 展开完成：改连 " + ok + "/" + ChainKeys.Length
                             + "（" + string.Join("", how) + "），接管门 " + added + " 个（累计 "
                             + _gateForced.Count + "），共 " + n + " 节点");
            if (_logTake++ < 3)
                Plugin.L.LogInfo("[flat] 播放顺序：_2_1 → 洛千雪 _2_2 → 洛天雄 _2_3 → 裘之墨 _2_4"
                                 + " → 说书人 _2_5 → 凌梦蝶 _2_6 → 兜底（无伙伴）→ 汇合 _2_9");
        }

        /// <summary>
        /// 从起点沿 `OutPort.connections[1]` 走 LadderSteps 步，收集沿途的 10 个门。
        /// 返回落点（= 第 5 层的 Negate=1 门 = 「无伙伴」兜底门）。
        ///
        /// 依据（已用 PC 的 R10049-2.asset 核对）：
        ///   每个门有两条出边 —— [下一层的 Negate=0 门, 下一层的 Negate=1 门]，
        ///   所以「走第 2 条」正好是 if/else 的 else 侧，一路走到底就是兜底门。
        /// </summary>
        private static IntPtr WalkLadder(IntPtr start, List<IntPtr> gates)
        {
            IntPtr cur = start;
            for (int step = 1; step <= LadderSteps; step++)
            {
                IntPtr op = NodePort(cur, "OutPort");
                if (op == IntPtr.Zero)
                {
                    Plugin.L.LogWarning("[flat] 走链第 " + step + " 步：取不到 OutPort（节点类="
                                        + (Il2CppNative.ClassNameOf(cur) ?? "?") + "）");
                    return IntPtr.Zero;
                }

                int cnt = ConnCount(op);
                IntPtr a = ConnNodeAt(op, 0);
                IntPtr b = cnt >= 2 ? ConnNodeAt(op, 1) : IntPtr.Zero;

                if (step == 1)
                    LadderProbe("第 1 步 取端口=" + _lastPortVia
                                + " 端口类=" + (Il2CppNative.ClassNameOf(op) ?? "?")
                                + " 继承=" + Il2CppNative.ClassChain(op)
                                + " 连线数=" + cnt
                                + " 门A=" + Hex(a) + " 门B=" + Hex(b));

                if (b == IntPtr.Zero)
                {
                    Plugin.L.LogWarning("[flat] 走链第 " + step + " 步：第 2 条连线取不到（连线数=" + cnt + "）"
                                        + "  取端口=" + _lastPortVia
                                        + " 端口类=" + (Il2CppNative.ClassNameOf(op) ?? "?")
                                        + " 继承=" + Il2CppNative.ClassChain(op));
                    return IntPtr.Zero;
                }

                AddUnique(gates, a);
                AddUnique(gates, b);
                cur = b;
            }
            return cur;   // 第 5 个 else 门 = 兜底门
        }

        // ================================================================ 状态缓存
        private static void Skip(IntPtr graph)
        {
            if (graph == IntPtr.Zero || !_skip.Add(graph)) return;
            _skipOrder.Enqueue(graph);
            while (_skipOrder.Count > SkipCap) _skip.Remove(_skipOrder.Dequeue());
        }

        private static void Remember(IntPtr node)
        {
            if (node == IntPtr.Zero || !_nodeChecked.Add(node)) return;
            _nodeOrder.Enqueue(node);
            while (_nodeOrder.Count > NodeCap) _nodeChecked.Remove(_nodeOrder.Dequeue());
        }

        // ================================================================ 诊断
        private static int _logProbe;
        private static void Probe(string m)
        {
            if (_logProbe++ < 12) Plugin.L.LogInfo("[flat:probe] " + m);
        }

        private static int _logLadder;
        private static void LadderProbe(string m)
        {
            if (_logLadder++ < 6) Plugin.L.LogInfo("[flat:ladder] " + m);
        }

        // ================================================================ 端口/连线
        /// <summary>
        /// 取节点上的端口对象。
        ///
        /// ⚠️ 关键事实（2026-10-23 查 il2cpp dump 确认）：`StoryDefaultNode.ConditionPort` /
        /// `DialogNodePort` 这些类型是**空类** —— 没有基类、没有字段、没有方法，纯粹是占位。
        /// 而节点上那些 `[SerializeField]` 端口字段（`OutPort` / `conditionPort` / `InPort`）
        /// 的类型正是这些占位类，所以**读字段拿到的是空壳，不能当端口用**。
        /// 真正的端口只在 `Node.ports` 字典里，必须通过 `Node.GetPort(名字)` 取。
        /// </summary>
        private static IntPtr NodePort(IntPtr node, string name)
        {
            IntPtr p = Il2CppNative.Ptr(node, name);
            if (IsUsablePort(p)) { _lastPortVia = "字段"; return p; }

            IntPtr q = Il2CppNative.GetPort(node, name);
            if (IsUsablePort(q)) { _lastPortVia = "GetPort"; return q; }

            _lastPortVia = p != IntPtr.Zero ? "字段(空壳)" : "无";
            return p != IntPtr.Zero ? p : q;
        }

        private static string _lastPortVia = "?";

        /// <summary>这个对象像不像一个真端口（有 connections 字段或端口方法）。</summary>
        private static bool IsUsablePort(IntPtr port)
        {
            if (port == IntPtr.Zero) return false;
            return Il2CppNative.HasField(port, "connections")
                || Il2CppNative.HasMethod(port, "get_Connection", 0)
                || Il2CppNative.HasMethod(port, "GetConnections", 1);
        }

        /// <summary>NodePort.connections[i]（PortConnection 对象），字段路。</summary>
        private static IntPtr ConnAt(IntPtr port, int idx)
        {
            if (port == IntPtr.Zero || idx < 0) return IntPtr.Zero;
            IntPtr cl = Il2CppNative.Ptr(port, "connections");
            if (cl == IntPtr.Zero) return IntPtr.Zero;
            if (idx >= Il2CppNative.ListCount(cl)) return IntPtr.Zero;
            return Il2CppNative.ListItem(cl, idx);
        }

        /// <summary>端口上的连线数（字段路 → GetConnections 路）。</summary>
        private static int ConnCount(IntPtr port)
        {
            IntPtr cl = Il2CppNative.Ptr(port, "connections");
            if (cl != IntPtr.Zero)
            {
                int n = Il2CppNative.ListCount(cl);
                if (n > 0) return n;
            }
            IntPtr lst = Il2CppNative.CallRefBool(port, "GetConnections", false);
            if (lst != IntPtr.Zero) return Il2CppNative.ListCount(lst);
            return 0;
        }

        /// <summary>
        /// 第 idx 条连线连到的「节点」。三条路依次试：
        ///   ① connections[idx].node          （与手机端同源）
        ///   ② GetConnections(false)[idx] → get_node
        ///   ③ get_Connection → get_node      （只有 idx=0 时可用）
        /// </summary>
        private static IntPtr ConnNodeAt(IntPtr port, int idx)
        {
            if (port == IntPtr.Zero || idx < 0) return IntPtr.Zero;

            IntPtr c = ConnAt(port, idx);
            if (c != IntPtr.Zero)
            {
                IntPtr nd = Il2CppNative.Ptr(c, "node");
                if (nd != IntPtr.Zero) return nd;
            }

            IntPtr lst = Il2CppNative.CallRefBool(port, "GetConnections", false);
            if (lst != IntPtr.Zero)
            {
                IntPtr p = Il2CppNative.ListItem(lst, idx);
                if (p != IntPtr.Zero)
                {
                    IntPtr nd = Il2CppNative.CallRef(p, "get_node");
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

        /// <summary>
        /// 方法路改连：Disconnect 掉原有那条，再 Connect 到目标节点的 InPort，
        /// 最后回读一次确认真的指过去了。
        /// </summary>
        private static bool ApiRedirect(IntPtr fromOut, IntPtr targetNode)
        {
            IntPtr targetIn = NodePort(targetNode, "InPort");
            if (targetIn == IntPtr.Zero) return false;

            IntPtr peer = Il2CppNative.CallRef(fromOut, "get_Connection");
            if (peer != IntPtr.Zero && peer != targetIn)
                Il2CppNative.CallVoid1(fromOut, "Disconnect", peer);

            if (!Il2CppNative.CallVoid1(fromOut, "Connect", targetIn)) return false;

            return ConnNodeAt(fromOut, 0) == targetNode;
        }

        private static void AddUnique(List<IntPtr> list, IntPtr v)
        {
            if (v != IntPtr.Zero && !list.Contains(v)) list.Add(v);
        }

        private static string Hex(IntPtr p)
        {
            return "0x" + p.ToInt64().ToString("X");
        }
    }
}
