using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using WuLin;
using WuLin.StateMachine;

namespace WulinTweaks
{
    internal static class Hooks
    {
        /// <summary>
        /// 递归探测「原版结果」时置位。名单 guard / 对比探针 / 诊断都会递归调用
        /// CheckCondition 本身，内层必须直接放行到原方法，否则无限套娃。
        /// </summary>

        // ============ ① 场景高亮 ============

        /// <summary>InteractiveObject.SetOutLine(bool) —— 拦截"关灯"</summary>
        [HarmonyPatch]
        internal static class InteractiveOutLine1
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(InteractiveObject), "SetOutLine", new[] { typeof(bool) });

            static void Prefix(ref bool isOn)
            {
                try { if (Plugin.AlwaysHighlight.Value) isOn = true; }
                catch (Exception e) { ModKit.Err("hook outline1", e); }
            }
        }

        /// <summary>InteractiveObject.SetOutLine(Transform, bool)</summary>
        [HarmonyPatch]
        internal static class InteractiveOutLine2
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(InteractiveObject), "SetOutLine", new[] { typeof(Transform), typeof(bool) });

            static void Prefix(ref bool isOn)
            {
                try { if (Plugin.AlwaysHighlight.Value) isOn = true; }
                catch (Exception e) { ModKit.Err("hook outline2", e); }
            }
        }

        /// <summary>ViewElemenetAdapator.SetOutLine —— 白名单里的适配器一律锁亮（NPC 不受影响）</summary>
        [HarmonyPatch(typeof(ViewElemenetAdapator), "SetOutLine")]
        internal static class ViewAdapterOutLine
        {
            static void Prefix(ViewElemenetAdapator __instance, ref bool isActive)
            {
                try
                {
                    if (!Plugin.AlwaysHighlight.Value) return;
                    if (!ModKit.IsHighlightAdapter(__instance.Pointer)) return;
                    isActive = true;
                }
                catch (Exception e) { ModKit.Err("hook viewadapter", e); }
            }
        }

        /// <summary>自由模式每帧：第一帧引导 Lua；每 60 帧兜底重置队伍条件委托</summary>
        [HarmonyPatch(typeof(RoamingManager), "Update")]
        internal static class RoamingUpdate
        {
            private static bool _booted;
            private static int _frame;

            static void Postfix()
            {
                try
                {
                    if (!_booted)
                    {
                        _booted = true;
                        ModKit.TryBootstrapLua();
                        ModKit.ForceIgnoreTeamCondition();
                    }

                    if (_frame++ < 6000) ModUi.TryCreate();
                    ModUi.UpdateTick();
                    if ((_frame % 60) == 0) ModKit.ForceIgnoreTeamCondition();
                }
                catch (Exception e) { ModKit.Err("hook roamingUpdate", e); }
            }
        }

        /// <summary>进图完成：全场景扫一次点亮</summary>
        [HarmonyPatch(typeof(MapManager), "OnLoadMapComplated")]
        internal static class MapLoaded
        {
            static void Postfix()
            {
                try
                {
                    ModKit.TryBootstrapLua();
                    ModKit.ForceIgnoreTeamCondition();
                    ModKit.ForceHighlightNow();
                    ModKit.UnlockWorldMapTick();
                    // v1.10.4：换图/读档后把姓名窗口收干净（剧情里换图的场景，下一节点会重新开）
                    RelaxName.EndNow();
                    // v1.11.28：家园「可入」白名单（CTMED 是运行时配置，重启即失效，只能每次补）
                    FiefAuto.Tick();
                    // v1.11.29：大地图「真解锁」—— 把 343 个地点图标真写进存档 listShowIcon
                    MapTrueUnlock.Tick();
                }
                catch (Exception e) { ModKit.Err("hook mapLoaded", e); }
            }
        }

        /// <summary>地图实体创建完成（切图/子地图）：再补一次</summary>
        [HarmonyPatch(typeof(MapManager), "OnCreateMapEntityComplated")]
        internal static class MapEntityCreated
        {
            static void Postfix()
            {
                try { ModKit.ForceHighlightNow(); }
                catch (Exception e) { ModKit.Err("hook mapEntityCreated", e); }
            }
        }

        // ============ ② 大地图解锁 ============

        /// <summary>UIWorldMapManager.Update —— 打开大地图期间按 2 秒节流刷新</summary>
        [HarmonyPatch(typeof(UIWorldMapManager), "Update")]
        internal static class WorldMapUpdate
        {
            static void Postfix()
            {
                try
                {
                    ModKit.TryBootstrapLua();
                    ModKit.UnlockWorldMapTick();
                }
                catch (Exception e) { ModKit.Err("hook worldmapUpdate", e); }
            }
        }

        /// <summary>IsMapEnable —— 世界地图"是否已解锁"判定恒 true</summary>
        [HarmonyPatch]
        internal static class MapEnableCheck
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(UIWorldMapManager), "IsMapEnable", new[] { typeof(int) });

            static void Postfix(ref bool __result)
            {
                try { if (Plugin.UnlockWorldMap.Value) __result = true; }
                catch (Exception e) { ModKit.Err("hook isMapEnable", e); }
            }
        }

        /// <summary>SetCityVisible —— 城市图标显隐强制打开</summary>
        [HarmonyPatch]
        internal static class CityVisible
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(UIWorldMap), "SetCityVisible", new[] { typeof(int), typeof(bool) });

            static void Prefix(ref bool isShow)
            {
                try
                {
                    if (!Plugin.UnlockWorldMap.Value) return;
                    isShow = true;
                }
                catch (Exception e) { ModKit.Err("hook cityVisible", e); }
            }
        }

        /// <summary>每次打开大地图：重刷图标</summary>
        [HarmonyPatch(typeof(UIWorldMap), "OnShow")]
        internal static class WorldMapOnShow
        {
            static void Postfix(UIWorldMap __instance)
            {
                try { ModKit.ForceCityIconsNow(__instance); }
                catch (Exception e) { ModKit.Err("hook worldMapOnShow", e); }
            }
        }

        // ============ ②b 马车地图 ============

        /// <summary>IsPassIcon —— 地点"是否已去过"恒 true</summary>
        [HarmonyPatch]
        internal static class CabIsPassIcon
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(UICabMapManager), "IsPassIcon", new[] { typeof(int) });

            static void Postfix(ref bool __result)
            {
                try { if (Plugin.MapMaster) __result = true; }
                catch (Exception e) { ModKit.Err("hook cabIsPassIcon", e); }
            }
        }

        [HarmonyPatch(typeof(UICabMapManager), "UpdateIconShow")]
        internal static class CabUpdateIconShow
        {
            static void Postfix(UICabMapManager __instance)
            {
                try { ModKit.ForceCabIconsNow(__instance); }
                catch (Exception e) { ModKit.Err("hook cabUpdateIconShow", e); }
            }
        }

        [HarmonyPatch]
        internal static class CabShow
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(UICabMapManager), "Show", new[] { typeof(int) });

            static void Postfix(UICabMapManager __instance)
            {
                try { ModKit.ForceCabIconsNow(__instance); }
                catch (Exception e) { ModKit.Err("hook cabShow", e); }
            }
        }

        // ============ ④ 易物 ============

        /// <summary>ValueOffset() —— ConfirmTrading 的第一道门槛（&lt; 0 直接放弃）</summary>
        [HarmonyPatch]
        internal static class TradeValueOffset
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(TradingWithNpcManager), "ValueOffset");

            static void Postfix(ref long __result)
            {
                try { TradeKit.ForceValueOffset(ref __result); }
                catch (Exception e) { ModKit.Err("hook trade offset", e); }
            }
        }

        /// <summary>GameItemPack.GetTotalValue —— ConfirmTrading 的第二道门槛（玩家交易区总价必须 &gt; 0）</summary>
        [HarmonyPatch]
        internal static class TradePackTotalValue
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(GameItemPack), "GetTotalValue", new[] { typeof(float) });

            static void Postfix(GameItemPack __instance, ref long __result)
            {
                try { TradeKit.ForceTradingZoneValue(__instance, ref __result); }
                catch (Exception e) { ModKit.Err("hook trade value", e); }
            }
        }

        /// <summary>StartTrading —— 并入击杀必掉物 / 暗取池，可选地自动摆进交易区</summary>
        [HarmonyPatch(typeof(TradingWithNpcManager), "StartTrading")]
        internal static class TradeStart
        {
            static void Prefix()
            {
                try { TradeKit.BeforeTradingStart(); }
                catch (Exception e) { ModKit.Err("hook trade prestart", e); }
            }

            static void Postfix()
            {
                try { TradeKit.OnTradingStarted(); }
                catch (Exception e) { ModKit.Err("hook trade start", e); }
            }
        }

        /// <summary>ConfirmTrading —— 成交后把交易区残留 + NPC 背包剩余一并搬进队伍背包</summary>
        [HarmonyPatch(typeof(TradingWithNpcManager), "ConfirmTrading")]
        internal static class TradeConfirm
        {
            static void Postfix()
            {
                try { TradeKit.AfterConfirm(); }
                catch (Exception e) { ModKit.Err("hook trade confirm", e); }
            }
        }

        /// <summary>CancelTrading —— 取消后把为显示而复制的池子副本删掉</summary>
        [HarmonyPatch(typeof(TradingWithNpcManager), "CancelTrading")]
        internal static class TradeCancel
        {
            static void Postfix()
            {
                try { TradeKit.CleanupCopies(); }
                catch (Exception e) { ModKit.Err("hook trade cancel", e); }
            }
        }

        // ============ ③ 剧情：条件放宽的递归看门狗 ============

        /// <summary>
        /// 放宽「队友是否在队 / 是否有伙伴」之后，某些剧情图里的 Hold 节点会立刻满足，
        /// 于是 StoryManager.ContinueArrange ↔ HoldNode.OnActive 在同一帧里互相递归，
        /// 几千层后原生栈溢出 —— 表现就是"对话到一半游戏直接消失"。
        ///
        /// 证据（2026-10-20 17:55 那次）：
        ///   Windows 事件日志 Application Error id=1000：
        ///     错误模块 GameAssembly.dll，异常代码 0xc00000fd（= STATUS_STACK_OVERFLOW）
        ///   同一时刻 BepInEx 日志已打出 "team condition patched (skip-to-base) 2/2"，
        ///   之后没有任何托管异常 —— 是原生栈溢出，不是 C# 异常。
        ///
        /// 这里按「同一帧内的调用层数」限深：正常剧情个位数，超阈值就跳过这一层推进
        /// （跨帧计数会重置，所以卡住的那一帧下一帧还会继续，不会把剧情永久堵死）。
        /// </summary>
        [HarmonyPatch(typeof(StoryManager), "ContinueArrange")]
        internal static class ContinueArrangeGuard
        {
            // 原来这里是 16，太低了：正常一段交互剧情一帧内推进会轻易超过 16 步，
            // 被当成死循环截断 → 剧情停在半路、事件不弹（实测日志里出现了
            // 「ContinueArrange 同帧已递归 16 层，阻断这一层」，而 [once]/[blacklist] 都是 0）。
            // 真正的空转是「没有上界」的递归，256 已经足够兜住栈，又远高于正常推进量。
            private const int MaxDepth = 256;

            private static int _depth;
            private static int _frame = -1;
            private static int _warned;

            static bool Prefix()
            {
                try
                {
                    if (!Plugin.IgnoreTeamCondition.Value) return true;

                    int f = Time.frameCount;
                    // 跨帧不可能还留着栈上的递归，顺手把可能泄漏的计数清掉
                    if (f != _frame) { _frame = f; _depth = 0; }

                    if (_depth >= MaxDepth)
                    {
                        if (_warned < 5)
                        {
                            _warned++;
                            Plugin.L.LogWarning("[WulinTweaks] ContinueArrange 同帧已递归 " + _depth
                                + " 层，阻断这一层（剧情条件放宽引起 Hold 空转；不会栈溢出）");
                        }
                        return false;
                    }
                    _depth++;
                }
                catch (Exception e) { ModKit.Err("guard continueArrange", e); }
                return true;
            }

            static void Postfix()
            {
                if (_depth > 0) _depth--;
            }
        }
        // ============ ④ 剧情重复触发诊断（只观测，不改行为） ============

        /// <summary>
        /// 排查「跳过队友条件后剧情反复触发」用的探针。要回答三个问题：
        ///   1. checkSucessTimes(0x70) 会不会被 Lua 正常置 0→1？（决定「Hold 级一次性放行」是否可行）
        ///   2. 结果 result=true 时，这个 Hold 是否本来该被条件挡住？（= 放宽是否生效）
        ///   3. 同一个 Hold 是否在一帧里被反复检查？（= 是不是在同一帧空转）
        /// 排查完把 StoryDiagnostics 关掉即可，关掉后零开销。
        /// </summary>
        [HarmonyPatch(typeof(HoldNode), "CheckCondition")]
        internal static class HoldDiag
        {
            private static readonly Dictionary<IntPtr, int> _calls = new Dictionary<IntPtr, int>();
            private static readonly Dictionary<IntPtr, int> _frameOf = new Dictionary<IntPtr, int>();
            private static readonly Dictionary<IntPtr, int> _frameHits = new Dictionary<IntPtr, int>();

            static void Postfix(HoldNode __instance, bool __result)
            {
                if (!Plugin.StoryDiag.Value) return;
                try
                {
                    // 条件构成：走纯原生内存读（SafeMem 先校验可读性），
                    // 不再用 new XNode.NodePort(ptr) 那种错误的托管包装。
                    HoldCondProbeNative.Dump(__instance);

                    IntPtr p = __instance.Pointer;
                    int f = Time.frameCount;

                    _calls.TryGetValue(p, out int n);
                    _calls[p] = ++n;

                    _frameOf.TryGetValue(p, out int lastF);
                    if (lastF == f) { _frameHits.TryGetValue(p, out int h); _frameHits[p] = h + 1; }
                    else { _frameOf[p] = f; _frameHits[p] = 1; }
                    _frameHits.TryGetValue(p, out int hits);

                    // 前 5 次全打；之后每 50 次一条；同帧重复 ≥5 次的一律打（那才是空转现场）
                    if (n > 5 && (n % 50) != 0 && hits < 5) return;

                    string nm;
                    try { nm = __instance.name; } catch { nm = "?"; }
                    int times;
                    try { times = __instance.checkSucessTimes; } catch { times = -1; }

                    Plugin.L.LogInfo("[diag] Hold \"" + nm + "\" " + p.ToString("X")
                        + " times=" + times
                        + " result=" + (__result ? "true" : "false")
                        + " calls=" + n
                        + " frameHits=" + hits);
                }
                catch (Exception e) { ModKit.Err("diag hold", e); }
            }
        }
        // ============ ⑤ 剧情：Hold 只放行一次（只对被放宽影响的 Hold 生效） ============

        /// <summary>
        /// 判据不再看"图名像不像角色剧情"，而是看**这次判定到底有没有碰队友条件**：
        /// NativeTeamHook.TeamCondHits 在每次 IsJoinedTeam/HavePartner 判定时自增，
        /// 所以「本次 CheckCondition 期间计数有没有变」= 这个 Hold 是否经由放宽才通过。
        ///
        ///   - 计数没变 → 这个 Hold 与队友条件无关，一行都不碰（游戏设计的可重复剧情不受影响）；
        ///   - 计数变了 + times != 0 + 这次仍然通过 → 是放宽把"一次性"变成了"可重复"
        ///     → 压回 false，每个 Hold 只放行一次。
        ///
        /// 三条例外（交给原版语义，不做压制）：R{角色id}- 图、固定名单（主线/师父线）、手动名单。
        /// —— 这些图的 Hold 由 TeamRule 在条件层就精确判定过，再压制会违背原版语义。
        /// </summary>
        [HarmonyPatch(typeof(HoldNode), "CheckCondition")]
        internal static class HoldOnceGuard
        {
            private static int _warned;

            static void Prefix(out int __state) { __state = NativeTeamHook.TeamCondHits; }

            static void Postfix(HoldNode __instance, ref bool __result, int __state)
            {
                try
                {
                    if (!Plugin.IgnoreTeamCondition.Value) return;
                    if (!__result) return;
                    if (NativeTeamHook.TeamCondHits == __state) return;    // 本次没检查队友条件 → 不干预
                    if (__instance.checkSucessTimes == 0) return;          // 还没成功过：正常放行

                    string gn;
                    try { gn = (__instance.graph == null) ? null : __instance.graph.name; } catch { gn = null; }
                    if (!string.IsNullOrEmpty(gn) && TeamRule.IsProtectedGraph(gn))
                        return;                                            // 例外：交给原版语义

                    __result = false;

                    if (_warned < 8)
                    {
                        _warned++;
                        string nm;
                        try { nm = __instance.name; } catch { nm = "?"; }
                        Plugin.L.LogInfo("[once] 剧情图 " + (gn ?? "?") + " 的 Hold \"" + nm + "\" times="
                            + __instance.checkSucessTimes + " 已通过过，压制本次（放宽引起的重复触发）");
                    }
                }
                catch (Exception e) { ModKit.Err("guard hold once", e); }
            }
        }
        // ============ ⑦ 剧情条件构成探针（回答「是不是因为角色在队」）============

        /// <summary>
        /// `IsJoinedTeamCondition` / `HavePartnerCondition` 没有导出到互操作程序集，
        /// 所以 C# 里既不能 typeof 也不能 GetField。这里退回原生：
        ///   il2cpp_object_get_class(obj) -> Il2CppClass*
        ///   il2cpp_class_get_name(cls)   -> const char*（类名，未混淆，就是 dump 里的名字）
        /// 再按已知偏移直接读 ConditionNode 上的 partnerID(+0x58) / Negate(+0x5C)。
        /// 只读不改，用于判断某个 Hold 到底卡在「角色在队」还是别的条件上。
        /// </summary>
        internal static class Il2CppProbe
        {
            [System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
            private static extern IntPtr GetModuleHandleA(string name);

            [System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
            private static extern IntPtr GetProcAddress(IntPtr module, string proc);

            private delegate IntPtr FnObjGetClass(IntPtr obj);
            private delegate IntPtr FnClsGetName(IntPtr klass);

            private static FnObjGetClass _objGetClass;
            private static FnClsGetName _clsGetName;
            private static bool _inited;

            private static void Init()
            {
                if (_inited) return;
                _inited = true;
                try
                {
                    var h = GetModuleHandleA("GameAssembly.dll");
                    if (h == IntPtr.Zero) { Plugin.L.LogWarning("[probe] GameAssembly.dll 没找到"); return; }
                    var p1 = GetProcAddress(h, "il2cpp_object_get_class");
                    var p2 = GetProcAddress(h, "il2cpp_class_get_name");
                    if (p1 != IntPtr.Zero)
                        _objGetClass = System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer<FnObjGetClass>(p1);
                    if (p2 != IntPtr.Zero)
                        _clsGetName = System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer<FnClsGetName>(p2);
                }
                catch (Exception e) { ModKit.Err("probe init", e); }
            }

            internal static string ClassNameOf(IntPtr obj)
            {
                Init();
                if (_objGetClass == null || _clsGetName == null || obj == IntPtr.Zero) return "?";
                // 进 il2cpp API 之前先确认对象头可读，否则它会拿垃圾 klass 指针继续解引用
                if (!SafeMem.Readable(obj, 0x10)) return "?";
                try
                {
                    var cls = _objGetClass(obj);
                    if (cls == IntPtr.Zero || !SafeMem.Readable(cls, 0x10)) return "?";
                    var p = _clsGetName(cls);
                    if (p == IntPtr.Zero || !SafeMem.Readable(p, 1)) return "?";
                    // 不定长读法：定长版会把结尾 \0 和后面的内存一起读进来
                    return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(p);
                }
                catch { return "?"; }
            }
        }

        /// <summary>把一个 Hold 的条件端口上的节点全列出来：类名 + partnerID + 取反</summary>
        internal static class HoldConditionProbe
        {
            private static readonly HashSet<IntPtr> _done = new HashSet<IntPtr>();

            internal static void Dump(HoldNode node)
            {
                if (!Plugin.StoryDiag.Value) return;
                if (node == null) return;

                IntPtr holdPtr = node.Pointer;
                if (!_done.Add(holdPtr)) return;          // 每个 Hold 只抽一次

                try
                {
                    string graph;
                    try { graph = node.graph == null ? "?" : node.graph.name; } catch { graph = "?"; }
                    string nm;
                    try { nm = node.name; } catch { nm = "?"; }

                    Plugin.L.LogInfo("[cond] Hold \"" + nm + "\" graph=" + graph);

                    var port = node.conditionPort;
                    if (port == null) { Plugin.L.LogInfo("    (conditionPort = null)"); return; }

                    // StoryDefaultNode.ConditionPort 在 interop 里没有继承 XNode.NodePort
                    // （两个类型分属不同程序集），所以拿不到 GetConnections()。
                    // 用原生指针包一层 NodePort 再走它的公开方法。
                    XNode.NodePort xport;
                    try { xport = new XNode.NodePort(port.Pointer); }
                    catch (Exception ex) { Plugin.L.LogInfo("    (包 NodePort 失败: " + ex.GetType().Name + ")"); return; }
                    if (xport == null) { Plugin.L.LogInfo("    (NodePort = null)"); return; }

                    var list = xport.GetConnections();
                    if (list == null || list.Count == 0)
                    {
                        Plugin.L.LogInfo("    (条件端口没有连线)");
                        return;
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        var np = list[i];
                        if (np == null) continue;
                        var condNode = np.node;
                        if (condNode == null) continue;

                        IntPtr p = condNode.Pointer;
                        string cn = Il2CppProbe.ClassNameOf(p);

                        string extra = "";
                        if (cn != null && (cn.Contains("JoinedTeam") || cn.Contains("HavePartner")))
                        {
                            try
                            {
                                // 同样是运行期解析（PC 是 0x48/0x4C，不是手机端的 0x58/0x5C）
                                int pid = Il2CppNative.Int32(p, "partnerID");
                                bool neg = Il2CppNative.Byte(p, "Negate") != 0;
                                extra = "  partnerID=" + pid + " Negate=" + (neg ? "true" : "false");
                            }
                            catch { }
                        }
                        Plugin.L.LogInfo("    - " + cn + extra);
                    }
                }
                catch (Exception e) { ModKit.Err("probe cond", e); }
            }
        }
        // ============ ⑧ 剧情条件构成探针（纯原生内存读，带地址校验）============

        /// <summary>
        /// 上一次用 `new XNode.NodePort(ptr).GetConnections()` 把 coreclr 打崩了
        /// （ConditionPort 在 interop 里没继承 NodePort，布局对不上）。
        /// 这次完全不碰托管包装，只按已知偏移走原生内存：
        ///   HoldNode.conditionPort   +0x60  -> NodePort*
        ///   NodePort.connections     +0x20  -> List&lt;PortConnection&gt;*
        ///   List._items              +0x10  -> Il2CppArray*
        ///   List._size               +0x18  -> int
        ///   Il2CppArray 数据          +0x20  -> PortConnection*[]
        ///   PortConnection.node      +0x18  -> ConditionNode*
        /// 每次读之前先用 VirtualQuery 确认目标页可读，避免再出现访问冲突。
        /// </summary>
        internal static class SafeMem
        {
            [System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
            private static extern UIntPtr VirtualQuery(IntPtr addr, out MBI info, UIntPtr len);

            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            private struct MBI
            {
                public IntPtr BaseAddress;
                public IntPtr AllocationBase;
                public uint AllocationProtect;
                public UIntPtr RegionSize;
                public uint State;
                public uint Protect;
                public uint Type;
            }

            private const uint MEM_COMMIT = 0x1000;
            private const uint PAGE_GUARD = 0x100;
            private const uint PAGE_NOACCESS = 0x01;

            internal static bool Readable(IntPtr addr, int size)
            {
                if (addr == IntPtr.Zero) return false;
                if (addr.ToInt64() < 0x10000) return false;          // 挡住空指针与低地址垃圾
                if (addr.ToInt64() > 0x7FFFFFFFFFFF) return false;    // 用户态上限
                try
                {
                    MBI mbi;
                    var sz = (UIntPtr)System.Runtime.InteropServices.Marshal.SizeOf(typeof(MBI));
                    if (VirtualQuery(addr, out mbi, sz) == UIntPtr.Zero) return false;
                    if (mbi.State != MEM_COMMIT) return false;
                    if ((mbi.Protect & PAGE_GUARD) != 0) return false;
                    if ((mbi.Protect & 0xFF) == PAGE_NOACCESS) return false;
                    long remain = (long)mbi.RegionSize.ToUInt64() - (addr.ToInt64() - mbi.BaseAddress.ToInt64());
                    return remain >= size;
                }
                catch { return false; }
            }

            internal static IntPtr Ptr(IntPtr baseAddr, int offset)
            {
                if (!Readable(baseAddr, offset + 8)) return IntPtr.Zero;
                try { return System.Runtime.InteropServices.Marshal.ReadIntPtr(baseAddr, offset); }
                catch { return IntPtr.Zero; }
            }

            internal static int Int32(IntPtr baseAddr, int offset)
            {
                if (!Readable(baseAddr, offset + 4)) return 0;
                try { return System.Runtime.InteropServices.Marshal.ReadInt32(baseAddr, offset); }
                catch { return 0; }
            }

            internal static byte Byte(IntPtr baseAddr, int offset)
            {
                if (!Readable(baseAddr, offset + 1)) return 0;
                try { return System.Runtime.InteropServices.Marshal.ReadByte(baseAddr, offset); }
                catch { return 0; }
            }
        }

        /// <summary>列出某个 Hold 条件端口上的节点：类名 + partnerID + 取反</summary>
        internal static class HoldCondProbeNative
        {
            private const int OFF_HOLD_COND_PORT = 0x60;
            private const int OFF_NODEPORT_CONNS = 0x20;
            private const int OFF_LIST_ITEMS = 0x10;
            private const int OFF_LIST_SIZE = 0x18;
            private const int OFF_ARRAY_DATA = 0x20;
            private const int OFF_CONN_NODE = 0x18;

            private static readonly HashSet<IntPtr> _done = new HashSet<IntPtr>();

            internal static void Dump(HoldNode node)
            {
                if (!Plugin.StoryDiag.Value) return;
                if (node == null) return;

                IntPtr holdPtr = node.Pointer;
                if (!SafeMem.Readable(holdPtr, 0x68)) return;
                if (!_done.Add(holdPtr)) return;      // 每个 Hold 只抽一次

                try
                {
                    string graph;
                    try { graph = (node.graph == null) ? "?" : node.graph.name; } catch { graph = "?"; }
                    string nm;
                    try { nm = node.name; } catch { nm = "?"; }

                    Plugin.L.LogInfo("[cond] Hold \"" + nm + "\" graph=" + graph);

                    // ---- 偏移自适应 ----
                    // 手机版 dump 里 conditionPort 在 0x60，但 PC 是 Unity 2020.3 的另一套
                    // 编译产物，布局未必一致（实测按 0x60 裸读出来的 list 是垃圾值）。
                    // 这里用 interop 字段访问拿一次「真」的 ConditionPort 指针作锚点
                    // （读字段本身是安全的，之前崩的是拿去强转 NodePort 再调方法），
                    // 再扫一遍 NodePort 的候选偏移，找哪个位置像是 List<PortConnection>。
                    IntPtr portInterop = IntPtr.Zero;
                    try { if (node.conditionPort != null) portInterop = node.conditionPort.Pointer; }
                    catch { }
                    IntPtr portRaw = SafeMem.Ptr(holdPtr, OFF_HOLD_COND_PORT);

                    Plugin.L.LogInfo("[off] hold=" + holdPtr.ToString("X")
                        + " condPort(interop)=" + portInterop.ToString("X")
                        + " condPort(raw+0x60)=" + portRaw.ToString("X")
                        + (portInterop == portRaw ? "  ✔ 偏移正确" : "  ✘ 偏移不符"));

                    IntPtr port = (portInterop != IntPtr.Zero) ? portInterop : portRaw;
                    if (port == IntPtr.Zero) { Plugin.L.LogInfo("    (conditionPort = null)"); return; }

                    // 扫描：把 port 各候选偏移处的值当成 List 试读，_items 有效且 _size 在 (0,64] 就报出来
                    int listOff = -1;
                    for (int o = 0x10; o <= 0x40; o += 8)
                    {
                        IntPtr cand = SafeMem.Ptr(port, o);
                        if (cand == IntPtr.Zero) continue;
                        IntPtr items = SafeMem.Ptr(cand, OFF_LIST_ITEMS);
                        int size = SafeMem.Int32(cand, OFF_LIST_SIZE);
                        if (items == IntPtr.Zero) continue;
                        if (size <= 0 || size > 64) continue;
                        Plugin.L.LogInfo("    [off] 候选 connections @port+0x" + o.ToString("X")
                            + " items=" + items.ToString("X") + " size=" + size);
                        if (listOff < 0) listOff = o;
                    }
                    if (listOff < 0) { Plugin.L.LogInfo("    (没扫到像 List 的偏移)"); return; }

                    IntPtr list = SafeMem.Ptr(port, listOff);
                    if (list == IntPtr.Zero) { Plugin.L.LogInfo("    (connections = null)"); return; }

                    IntPtr arr = SafeMem.Ptr(list, OFF_LIST_ITEMS);
                    int n = SafeMem.Int32(list, OFF_LIST_SIZE);
                    if (arr == IntPtr.Zero || n <= 0 || n > 64)
                    {
                        Plugin.L.LogInfo("    (连线数异常: n=" + n + " arr=" + arr.ToString("X") + ")");
                        return;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        IntPtr conn = SafeMem.Ptr(arr, OFF_ARRAY_DATA + i * 8);
                        if (conn == IntPtr.Zero) continue;

                        IntPtr cn = SafeMem.Ptr(conn, OFF_CONN_NODE);
                        if (cn == IntPtr.Zero) continue;

                        string cls = Il2CppProbe.ClassNameOf(cn);
                        string extra = "";
                        if (cls != null && (cls.Contains("JoinedTeam") || cls.Contains("HavePartner")))
                        {
                            // 2026-10-23：原来这里写的是手机端的 0x58/0x5C，PC 实际是 0x48/0x4C
                            // （见 NativeTeamHook.OFF_PARTNER_ID_PC），而且布局可能随版本变 →
                            // 改成走 Il2CppNative 在运行期解析字段偏移，不再靠猜。
                            int pid = Il2CppNative.Int32(cn, "partnerID");
                            bool neg = Il2CppNative.Byte(cn, "Negate") != 0;
                            extra = "  partnerID=" + pid + " Negate=" + (neg ? "true" : "false");
                        }
                        Plugin.L.LogInfo("    - " + cls + extra);
                    }
                }
                catch (Exception e) { ModKit.Err("probe cond native", e); }
            }
        }
    }
}
