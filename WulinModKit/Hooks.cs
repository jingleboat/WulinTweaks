using System;
using HarmonyLib;
using UnityEngine;
using WuLin;

namespace WulinModKit
{
    internal static class Hooks
    {
        // ============ ① 场景互动物体常亮 ============

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

        /// <summary>InteractiveObject.SetOutLine(Transform, bool) —— 内部真正做事的那层</summary>
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

        /// <summary>
        /// ViewElemenetAdapator.SetOutLine —— 游戏每帧按悬停状态调这个函数。
        /// 重写它恒为 true 就等于"碰过即永久亮"；
        /// 扫描模式下再加白名单，避免 NPC / 建筑被永久描边。
        /// </summary>
        [HarmonyPatch(typeof(ViewElemenetAdapator), "SetOutLine")]
        internal static class ViewAdapterOutLine
        {
            static void Prefix(ViewElemenetAdapator __instance, ref bool isActive)
            {
                try
                {
                    if (!Plugin.AlwaysHighlight.Value) return;

                    // 暴力模式：除人物外，一切视图元素（物件/建筑/地形）永久描边
                    if (Plugin.ForceAllAdapters.Value)
                    {
                        if (ModKit.IsActorAdapter(__instance)) return;
                        isActive = true;
                        return;
                    }

                    if (!Plugin.ScanOnEntry.Value)
                    {
                        // 纯拦截模式：不主动扫描，凡游戏判定为"可交互"的视图元素一律锁亮
                        if (!__instance.isInteractiveable) return;
                        isActive = true;
                        return;
                    }

                    // 扫描模式：只锁亮白名单里的（避免 NPC / 建筑被永久描边）
                    if (!ModKit.IsHighlightAdapter(__instance.Pointer)) return;
                    isActive = true;
                }
                catch (Exception e) { ModKit.Err("hook viewadapter", e); }
            }
        }

        /// <summary>自由模式每帧：Lua 引导 + 每 3 秒补扫地面物品</summary>
        [HarmonyPatch(typeof(RoamingManager), "Update")]
        internal static class RoamingUpdate
        {
            private static int _frame;

            static void Postfix()
            {
                try
                {
                    if (++_frame == 1) ModKit.TryBootstrapLua();
                    if ((_frame % 30) == 0)
                    {
                        ModKit.AdapterDumpTick();
                        ModKit.MiscItemsTick();
                    }
                }
                catch (Exception e) { ModKit.Err("hook roamingUpdate", e); }
            }
        }

        /// <summary>进图完成：立刻全场景点亮，不等鼠标经过</summary>
        [HarmonyPatch(typeof(MapManager), "OnLoadMapComplated")]
        internal static class MapLoaded
        {
            static void Postfix()
            {
                try
                {
                    ModKit.TryBootstrapLua();
                    ModKit.ResetAdapterDump();
                    ModKit.ForceHighlightTick(true);
                    ModKit.UnlockWorldMapTick(true);
                }
                catch (Exception e) { ModKit.Err("hook mapLoaded", e); }
            }
        }

        /// <summary>新地图实体创建完成（切图/子地图）：再补一次</summary>
        [HarmonyPatch(typeof(MapManager), "OnCreateMapEntityComplated")]
        internal static class MapEntityCreated
        {
            static void Postfix()
            {
                try { ModKit.ForceHighlightTick(true); }
                catch (Exception e) { ModKit.Err("hook mapEntityCreated", e); }
            }
        }

        // ============ ② 大地图解锁 ============

        [HarmonyPatch(typeof(UIWorldMapManager), "Update")]
        internal static class WorldMapUpdate
        {
            static void Postfix()
            {
                try
                {
                    ModKit.TryBootstrapLua();
                    ModKit.UnlockWorldMapTick(false);
                }
                catch (Exception e) { ModKit.Err("hook worldmapUpdate", e); }
            }
        }

        /// <summary>UIWorldMapManager.IsMapEnable —— 世界地图"是否已解锁"的唯一判定口，恒 true</summary>
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

        /// <summary>UIWorldMap.SetCityVisible —— 大地图上城市图标显隐，强制显示</summary>
        [HarmonyPatch]
        internal static class CityVisible
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(UIWorldMap), "SetCityVisible", new[] { typeof(int), typeof(bool) });

            static void Prefix(int mapID, ref bool isShow)
            {
                try
                {
                    if (!Plugin.UnlockWorldMap.Value) return;
                    isShow = true;
                }
                catch (Exception e) { ModKit.Err("hook cityVisible", e); }
            }
        }

        /// <summary>每次打开大地图：重刷图标显隐 + 强制全显示</summary>
        [HarmonyPatch(typeof(UIWorldMap), "OnShow")]
        internal static class WorldMapOnShow
        {
            static void Postfix(UIWorldMap __instance)
            {
                try
                {
                    if (!Plugin.UnlockWorldMap.Value) return;
                    ModKit.ForceCityIconsNow(__instance);
                }
                catch (Exception e) { ModKit.Err("hook worldMapOnShow", e); }
            }
        }

        // ============ ②b 马车地图解锁 ============

        /// <summary>UICabMapManager.IsPassIcon —— 该地点是否"已去过"，恒 true</summary>
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

        /// <summary>马车地图重刷图标显隐之后：再强制全显示一遍</summary>
        [HarmonyPatch(typeof(UICabMapManager), "UpdateIconShow")]
        internal static class CabUpdateIconShow
        {
            static void Postfix(UICabMapManager __instance)
            {
                try
                {
                    if (!Plugin.UnlockCabMap.Value) return;
                    ModKit.ForceCabIconsNow(__instance);
                }
                catch (Exception e) { ModKit.Err("hook cabUpdateIconShow", e); }
            }
        }

        /// <summary>打开马车地图</summary>
        [HarmonyPatch]
        internal static class CabShow
        {
            static System.Reflection.MethodBase TargetMethod()
                => AccessTools.Method(typeof(UICabMapManager), "Show", new[] { typeof(int) });

            static void Postfix(UICabMapManager __instance)
            {
                try
                {
                    if (!Plugin.UnlockCabMap.Value) return;
                    ModKit.ForceCabIconsNow(__instance);
                }
                catch (Exception e) { ModKit.Err("hook cabShow", e); }
            }
        }

        // ============ ④ 伤害倍率 ============

        [HarmonyPatch(typeof(KungfuAtomicEffectExt.DefaultDamageEffect_Logic),
                      nameof(KungfuAtomicEffectExt.DefaultDamageEffect_Logic.StandardDamageCalculate))]
        internal static class DamageCalc
        {
            static void Postfix(ref float __result, BattleActor dealerActor)
            {
                try { ModKit.ApplyDamageMul(ref __result, dealerActor); }
                catch (Exception e) { ModKit.Err("hook damage", e); }
            }
        }

        [HarmonyPatch(typeof(KungfuAtomicEffectExt.DefaultDamageEffect_Logic),
                      nameof(KungfuAtomicEffectExt.DefaultDamageEffect_Logic.SlgModeDamageCalculate))]
        internal static class DamageCalcSlg
        {
            static void Postfix(ref float __result, BattleActor dealerActor)
            {
                try { ModKit.ApplyDamageMul(ref __result, dealerActor); }
                catch (Exception e) { ModKit.Err("hook damageSlg", e); }
            }
        }

        // ============ ③ 剧情条件 ============

        /// <summary>
        /// 先把条件检查的调用链摸清楚：不改逻辑，只记录。
        /// 确认命中点后再改成放行。
        /// </summary>
        [HarmonyPatch(typeof(PlayerTeamManager), "HasCharacterAsMember")]
        internal static class TeamMemberCheck
        {
            static void Postfix(bool __result, GameCharacterInstance gameCharacterInstance, bool includePet)
            {
                if (!__result && Plugin.TeamConditionDebug.Value)
                {
                    try
                    {
                        Plugin.L.LogInfo("[WulinModKit] HasCharacterAsMember(false) includePet=" + includePet
                            + " caller=" + new System.Diagnostics.StackTrace(1, false).GetFrame(0)?.GetMethod()?.Name);
                    }
                    catch { }
                }
            }
        }
    }
}
