using System;
using HarmonyLib;
using UnityEngine;
using WuLin;

namespace WulinTweaks
{
    internal static class Hooks
    {
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
                try { if (Plugin.UnlockCabMap.Value) __result = true; }
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
            private const int MaxDepth = 16;

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
    }
}
