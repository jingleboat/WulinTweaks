using System;
using System.IO;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace WulinModKit
{
    [BepInPlugin(Guid, "Wulin ModKit", Version)]
    public class Plugin : BasePlugin
    {
        public const string Guid = "wulin.modkit";
        public const string Version = "1.1.0";

        internal static ManualLogSource L;
        internal static Plugin Inst;
        internal static Harmony H;

        // ① 场景高亮
        internal static ConfigEntry<bool> AlwaysHighlight;
        internal static ConfigEntry<bool> ExcludeBuildings;
        internal static ConfigEntry<bool> MiscRequirePickable;

        // ② 大地图 / 马车地图
        internal static ConfigEntry<bool> UnlockWorldMap;
        internal static ConfigEntry<bool> UnlockCabMap;

        // ③ 剧情
        internal static ConfigEntry<bool> IgnoreTeamCondition;

        // ④ 伤害
        internal static ConfigEntry<float> PlayerDamageMul;
        internal static ConfigEntry<float> EnemyDamageMul;

        internal static string LuaDir;

        public override void Load()
        {
            Inst = this;
            L = Log;

            LuaDir = Path.Combine(Paths.ConfigPath, "WulinModKit");
            Directory.CreateDirectory(LuaDir);

            AlwaysHighlight = Config.Bind("1_Highlight", "AlwaysHighlight", true,
                "进图时点亮场景里可交互的物件，并保持描边不再熄灭");
            ExcludeBuildings = Config.Bind("1_Highlight", "ExcludeBuildings", true,
                "跳过建筑本体（城门/建筑/密道/桥），避免整栋楼被描边");
            MiscRequirePickable = Config.Bind("1_Highlight", "MiscRequirePickable", true,
                "地面物品只亮可拾取的（TempID > 0，即对应真实物品模板）");

            UnlockWorldMap = Config.Bind("2_WorldMap", "UnlockAll", true,
                "大地图地区与地点全解锁");
            UnlockCabMap = Config.Bind("2_WorldMap", "UnlockCabMap", true,
                "马车地图所有地点解锁、图标全部可见");

            IgnoreTeamCondition = Config.Bind("3_Story", "IgnoreTeamMemberCondition", true,
                "剧情触发时忽略「队伍中是否存在某角色」条件");

            PlayerDamageMul = Config.Bind("4_Damage", "PlayerMultiplier", 1.0f,
                "玩家方造成的伤害倍率（1 = 原版）");
            EnemyDamageMul = Config.Bind("4_Damage", "EnemyMultiplier", 1.0f,
                "敌方造成的伤害倍率（1 = 原版）");

            H = new Harmony(Guid);

            SafePatch(typeof(Hooks.InteractiveOutLine1), "InteractiveObject.SetOutLine(bool)");
            SafePatch(typeof(Hooks.InteractiveOutLine2), "InteractiveObject.SetOutLine(Transform,bool)");
            SafePatch(typeof(Hooks.ViewAdapterOutLine), "ViewElemenetAdapator.SetOutLine");
            SafePatch(typeof(Hooks.RoamingUpdate), "RoamingManager.Update");
            SafePatch(typeof(Hooks.MapLoaded), "MapManager.OnLoadMapComplated");
            SafePatch(typeof(Hooks.MapEntityCreated), "MapManager.OnCreateMapEntityComplated");

            SafePatch(typeof(Hooks.WorldMapUpdate), "UIWorldMapManager.Update");
            SafePatch(typeof(Hooks.MapEnableCheck), "UIWorldMapManager.IsMapEnable");
            SafePatch(typeof(Hooks.CityVisible), "UIWorldMap.SetCityVisible");
            SafePatch(typeof(Hooks.WorldMapOnShow), "UIWorldMap.OnShow");
            SafePatch(typeof(Hooks.CabIsPassIcon), "UICabMapManager.IsPassIcon");
            SafePatch(typeof(Hooks.CabUpdateIconShow), "UICabMapManager.UpdateIconShow");
            SafePatch(typeof(Hooks.CabShow), "UICabMapManager.Show(int)");

            SafePatch(typeof(Hooks.DamageCalc), "DefaultDamageEffect_Logic.StandardDamageCalculate");
            SafePatch(typeof(Hooks.DamageCalcSlg), "DefaultDamageEffect_Logic.SlgModeDamageCalculate");

            L.LogInfo("[WulinModKit] v" + Version + " loaded. Lua dir = " + LuaDir);
        }

        private void SafePatch(Type patchClass, string label)
        {
            try
            {
                H.CreateClassProcessor(patchClass).Patch();
                L.LogInfo("[WulinModKit] patched: " + label);
            }
            catch (Exception e)
            {
                L.LogError("[WulinModKit] patch FAILED: " + label + " -> " + e.GetType().Name + ": " + e.Message);
            }
        }
    }
}
