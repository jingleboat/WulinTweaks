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
        public new const string Version = "0.1.0";

        internal static ManualLogSource L;
        internal static Plugin Inst;
        internal static Harmony H;

        // ① 场景互动物体常亮
        internal static ConfigEntry<bool> AlwaysHighlight;
        internal static ConfigEntry<bool> HighlightOnlyInteractive;
        internal static ConfigEntry<float> HighlightRescanSeconds;
        internal static ConfigEntry<bool> ExcludeBuildingObjects;
        internal static ConfigEntry<bool> DumpLitObjects;
        internal static ConfigEntry<bool> ScanOnEntry;
        internal static ConfigEntry<bool> ForceAllAdapters;
        internal static ConfigEntry<bool> DumpAdapters;
        internal static ConfigEntry<string> AllowedClickTypes;
        internal static ConfigEntry<bool> UseClickTypeFilter;
        internal static ConfigEntry<bool> ForceInteractiveable;
        internal static ConfigEntry<bool> MiscRequirePickable;

        // ② 大地图地点全解锁
        internal static ConfigEntry<bool> UnlockWorldMap;
        internal static ConfigEntry<float> WorldMapRescanInterval;

        // ②b 马车地图地点全解锁
        internal static ConfigEntry<bool> UnlockCabMap;
        internal static ConfigEntry<bool> ForceShowAllIcons;
        internal static ConfigEntry<bool> DumpMapUi;

        // ③ 剧情触发忽略队伍角色条件
        internal static ConfigEntry<bool> IgnoreTeamCondition;
        internal static ConfigEntry<bool> TeamConditionDebug;

        // ④ 伤害
        internal static ConfigEntry<float> PlayerDamageMul;
        internal static ConfigEntry<float> EnemyDamageMul;

        // Lua
        internal static string LuaDir;

        public override void Load()
        {
            Inst = this;
            L = Log;

            LuaDir = Path.Combine(Paths.ConfigPath, "WulinModKit");
            Directory.CreateDirectory(LuaDir);

            AlwaysHighlight = Config.Bind("1_Highlight", "AlwaysHighlight", true,
                "场景可互动物体保持高亮（靠近过一次后永久描边）");
            HighlightOnlyInteractive = Config.Bind("1_Highlight", "OnlyInteractiveObjects", true,
                "只对可互动物体高亮；false = 所有视图元素（角色/NPC 也会亮）");
            HighlightRescanSeconds = Config.Bind("1_Highlight", "RescanSeconds", 0f,
                "全场景重新扫描补亮的间隔（秒）；0 = 只在进图时扫一次（推荐，零每帧开销）");
            ExcludeBuildingObjects = Config.Bind("1_Highlight", "ExcludeBuildings", true,
                "跳过建筑类交互点（建筑入口/城门/桥），避免整栋楼被描边");
            DumpLitObjects = Config.Bind("1_Highlight", "DumpLitObjects", true,
                "把被点亮的物体名字+类型打到日志（前 40 条，排查用）");
            ScanOnEntry = Config.Bind("1_Highlight", "ScanOnEntry", true,
                "true = 进图全场景扫描并点亮（推荐）；false = 只遍历 RoamingManager 现成的 adapter 列表（范围很小，会变成扫过才亮）");
            ForceAllAdapters = Config.Bind("1_Highlight", "ForceAllAdapters", false,
                "暴力模式：除人物（ActorViewElemenetAdapator）外，所有视图元素永久保持悬停描边；不扫描、不判定类型");
            DumpAdapters = Config.Bind("1_Highlight", "DumpAdapters", true,
                "进图后一次性把场景所有视图适配器的类型/isInteractiveable/宿主物件属性打到日志（排查用）");
            AllowedClickTypes = Config.Bind("1_Highlight", "AllowedClickTypes", "1,2,3,6,9,10",
                "只有 clickType 在这个列表里的交互对象才高亮（逗号分隔）。ct=0 通常是桌子/地板/灯/门这类纯装饰与建筑部件");
            UseClickTypeFilter = Config.Bind("1_Highlight", "UseClickTypeFilter", false,
                "false = 只要求 clickType > 0（火把/凳子/桌子/灯/地板都是 ct=0，自动排除）；true = 改用 AllowedClickTypes 白名单");
            ForceInteractiveable = Config.Bind("1_Highlight", "ForceInteractiveable", false,
                "把物体的 ViewElemenetAdapator.isInteractiveable 强制设为 true；开启后会绕过游戏自身的可交互判定，连摆设也会亮");
            MiscRequirePickable = Config.Bind("1_Highlight", "MiscRequirePickable", true,
                "地面物件只高亮「可拾取」的（Num > 0 且 HideOnPick = true）；false = 所有 MiscItem 都亮");

            UnlockWorldMap = Config.Bind("2_WorldMap", "UnlockAll", true,
                "大地图地点全解锁");
            WorldMapRescanInterval = Config.Bind("2_WorldMap", "RescanSeconds", 2.0f,
                "重新扫描并解锁的间隔（秒），0 = 只在打开地图时一次");

            UnlockCabMap = Config.Bind("2_WorldMap", "UnlockCabMap", true,
                "马车地图（UICabMapManager）所有地点解锁、全部图标可见可点");
            ForceShowAllIcons = Config.Bind("2_WorldMap", "ForceShowAllIcons", true,
                "打开地图时把地图容器下所有图标强制 SetActive(true)（覆盖隐藏/未解锁状态）");
            DumpMapUi = Config.Bind("2_WorldMap", "DumpMapUiToLog", true,
                "第一次打开大地图/马车地图时把图标节点结构打到日志（排查用，只打一次）");

            IgnoreTeamCondition = Config.Bind("3_Story", "IgnoreTeamMemberCondition", true,
                "剧情触发时忽略「队伍中是否存在某角色」条件");
            TeamConditionDebug = Config.Bind("3_Story", "DebugLogConditionCalls", false,
                "把条件检查调用打到日志（排查用，会刷屏）");

            PlayerDamageMul = Config.Bind("4_Damage", "PlayerMultiplier", 1.0f,
                "玩家方造成的伤害倍率（1 = 原版）");
            EnemyDamageMul = Config.Bind("4_Damage", "EnemyMultiplier", 1.0f,
                "敌方造成的伤害倍率（1 = 原版）");

            H = new Harmony(Guid);

            SafePatch(typeof(Hooks.InteractiveOutLine1), "InteractiveObject.SetOutLine(bool)");
            SafePatch(typeof(Hooks.InteractiveOutLine2), "InteractiveObject.SetOutLine(Transform,bool)");
            SafePatch(typeof(Hooks.ViewAdapterOutLine), "ViewElemenetAdapator.SetOutLine(bool,bool)");
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
            SafePatch(typeof(Hooks.TeamMemberCheck), "PlayerTeamManager.HasCharacterAsMember");

            L.LogInfo("[WulinModKit] loaded. Lua dir = " + LuaDir);
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
