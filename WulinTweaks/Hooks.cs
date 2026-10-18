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
    }
}
