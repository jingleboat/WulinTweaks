using System;
using System.IO;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace WulinTweaks
{
    [BepInPlugin(Guid, "Wulin Tweaks", Version)]
    public class Plugin : BasePlugin
    {
        public const string Guid = "wulin.tweaks";
        public const string Version = "1.11.29";  // 1.11.29 大地图改「真解锁」：343 个地点图标真写进存档 listShowIcon（剧情「判断大地图图标显示」读的是这份数据）

        internal static ManualLogSource L;
        internal static Plugin Inst;
        internal static Harmony H;

        // ① 场景高亮（地面物品恒按「可拾取」过滤，不做开关）
        internal static ConfigEntry<bool> AlwaysHighlight;
        internal static ConfigEntry<bool> ExcludeBuildings;

        // ② 大地图 / 马车地图
        internal static ConfigEntry<bool> UnlockWorldMap;
        internal static ConfigEntry<bool> UnlockCabMap;

        // ③ 剧情
        internal static ConfigEntry<bool> IgnoreTeamCondition;
        internal static ConfigEntry<bool> FlattenBranches;
        internal static ConfigEntry<string> FlattenBlacklist;
        internal static ConfigEntry<string> StoryBlacklist;
        internal static ConfigEntry<string> FiefReadyList;

        // ④ 易物
        // 默认全关；面板上改动会立即写进 cfg，下次启动沿用上次状态。
        // 「确认搬空」不是独立开关：它跟随 TradeAlwaysWin（作价恒占优）—— 打开后成交即搬空。
        internal static ConfigEntry<bool> TradeAlwaysWin;
        internal static ConfigEntry<bool> TradePools;

        // UI
        internal static ConfigEntry<string> UiToggleKey;

        // 诊断（排查用，默认关）
        internal static ConfigEntry<bool> StoryDiag;

        internal static string DataDir;

        public override void Load()
        {
            Inst = this;
            L = Log;

            DataDir = Path.Combine(Paths.ConfigPath, "WulinTweaks");
            Directory.CreateDirectory(DataDir);

            AlwaysHighlight = Config.Bind("1_Highlight", "AlwaysHighlight", false,
                "进图时点亮场景里可交互的物件，并保持描边不再熄灭（地面物品只亮可拾取的）");
            ExcludeBuildings = Config.Bind("1_Highlight", "ExcludeBuildings", true,
                "跳过建筑本体（城门/建筑/密道/桥），避免整栋楼被描边");

            UnlockWorldMap = Config.Bind("2_WorldMap", "UnlockAll", false,
                "大地图地区与地点全解锁");
            UnlockCabMap = Config.Bind("2_WorldMap", "UnlockCabMap", false,
                "马车地图所有地点解锁、图标全部可见");

            IgnoreTeamCondition = Config.Bind("3_Story", "IgnoreTeamMemberCondition", false,
                "剧情触发时忽略「队伍中是否存在某角色」条件。含「结缘界面」的图**不会**被放宽"
                + "（那类图收尾要写情缘/武功/buff，人不在队会写坏人物数据），其余本命图照常放宽；"
                + "不动队伍、不做临时入队");

            FlattenBlacklist = Config.Bind("3_Story", "FlattenBlacklist", "",
                "剧情分支展开的**排除名单**（逗号分隔；末尾带 * 按前缀匹配）。"
                + "留空 = 所有剧情图都按通用规则展开。"
                + "遇到某张图播得不对（比如两侧是互斥剧情、展开后自相矛盾），把它的图名填进来重启即可；"
                + "图名就是剧情资产名，例如 R10049-2。");

FlattenBlacklist = Config.Bind("3_Story", "FlattenBlacklist", "",
                "剧情分支展开的**排除名单**（逗号分隔；末尾带 * 按前缀匹配）。"
                + "留空 = 所有剧情图都按通用规则展开。"
                + "遇到某张图播得不对（比如两侧是互斥剧情、展开后自相矛盾），把它的图名填进来重启即可；"
                + "图名就是剧情资产名，例如 R10049-2。");

            FlattenBranches = Config.Bind("3_Story", "FlattenBranches", true,
                "剧情分支展开：把「某角色是否在队」的互补分支由 if/else 改成**顺序播放** —— "
                + "先播队内有该角色的那几段，再播队内没有时的兜底，最后汇合。"
                + "目前只处理 R10049-2（大梁城衙门铡刀那段五人讲解）。"
                + "和「忽略队伍角色条件」是两个独立开关：这个只改剧情的走线，不改变条件判定规则。"
                + "⚠️ 关掉不会复原已经展开过的图（出边已经改过），要彻底还原请重启游戏。");

            StoryBlacklist = Config.Bind("3_Story", "IgnoreTeamConditionBlacklist", "R10005-11",
                "「只触发一次」的剧情图名单（逗号分隔；按前缀匹配就在末尾加 *，例如 R10005-*）。"
                + "名单里的剧情图：Hold 只放行第一次，之后不再重复 —— 用来治那些条件一旦恒真就会反复触发的事件。"
                + "留空 = 所有剧情都照常放宽。"
                + "已知对照：R10005-11=苗彩蝶(uid 10005) 那段循环；"
                + "R10028-7=一醉方休，R10025-6=杯中明镜，R10112-2=烈酒与故事（需要时自行加上）");

            FiefReadyList = Config.Bind("3_Story", "FiefReadyList", "",
                "读档/换图后自动给这些人物补「可入家园」（逗号分隔的 uid，例如 10142,10143）。"
                + "用来治 10142/10143 这类**不在 CharacterTeamMemberExtendData 表里**的角色："
                + "那张表是运行时配置（SerializedScriptableObject），存档里根本没有这个字段 —— "
                + "所以没法写进存档，只能每次启动补一遍；留空 = 什么都不做。");

            TradeAlwaysWin = Config.Bind("4_Trade", "AlwaysWin", false,
                "易物「通吃」总开关：玩家方作价永远 >= NPC 方，NPC 一律接受；"
                + "玩家交易区为空也能确认成交；"
                + "并且点确认成交后，把交易区残留和 NPC 背包剩下的东西一起塞进队伍背包 —— "
                + "NPC 的东西全拿走，玩家不用付出任何东西。"
                + "（1.11.5 起「确认搬空」跟随本开关，不再单独提供）");
            TradePools = Config.Bind("4_Trade", "Pools", false,
                "易物 NPC 侧同时列出「击杀必掉物」与「暗取池」的内容。"
                + "只往 NPC 背包放一份仅供显示的副本，两个池子本身一个字节都不动 —— "
                + "不会改变暗取能偷到什么，也不会改变打死掉什么");

            UiToggleKey = Config.Bind("0_UI", "ToggleKey", "BackQuote",
                "打开/关闭面板的热键（Unity KeyCode 名称：BackQuote=` / F9 / Insert / Home …）");

            StoryDiag = Config.Bind("5_Diag", "StoryDiagnostics", false,
                "【排查用】打印每个剧情 Hold 节点的条件检查结果、checkSucessTimes 和同帧重复次数。"
                + "用来定位「跳过队友条件后剧情反复触发」，平时请保持关闭（开着会刷日志）");


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

            SafePatch(typeof(Hooks.TradeValueOffset), "TradingWithNpcManager.ValueOffset");
            SafePatch(typeof(Hooks.TradePackTotalValue), "GameItemPack.GetTotalValue");
            SafePatch(typeof(Hooks.TradeStart), "TradingWithNpcManager.StartTrading");
            SafePatch(typeof(Hooks.TradeConfirm), "TradingWithNpcManager.ConfirmTrading");
            SafePatch(typeof(Hooks.TradeCancel), "TradingWithNpcManager.CancelTrading");

            // ③ 剧情：条件放宽的递归看门狗（见 Hooks.ContinueArrangeGuard 的注释）
            SafePatch(typeof(Hooks.ContinueArrangeGuard), "StoryManager.ContinueArrange");

            // ④ 剧情重复触发诊断（只观测）
            SafePatch(typeof(Hooks.HoldDiag), "HoldNode.CheckCondition");

            // ⑤ 剧情：兜底压制 —— 名单**外**的图，Hold 的 times 非 0 就不再放行。
            // 名单只能覆盖已知事件，未知的循环事件靠这里兜住。
            // （名单内的图在 ⑥ 的 Prefix 里就返回了，不会走到这里的 Postfix。）
            SafePatch(typeof(Hooks.HoldOnceGuard), "HoldNode.CheckCondition");

            // ⑦ 剧情：伙伴离队容错（这个类 v1.9.5 就写好了，但**从来没被注册进补丁列表** —— v1.9.8 补上）
            SafePatch(typeof(Patch_ChangePartner), "ChangePartnerNode.OnResult(离队容错)");

            // ⑧ 剧情：显示「熟悉后姓名」三层（v1.9.8；1.9.6 的 Patch_RealName 同样从未注册过）
            SafePatch(typeof(Patch_RealNameStrangerFlag), "GameCharacterInstance.IsUsingStangerName(状态层)");
            SafePatch(typeof(Patch_RealNameFull), "GameCharacterInstance.FullName(兜底)");
            SafePatch(typeof(Patch_RealNameTitle), "GameCharacterInstance.FullNameWithTitle(兜底)");

            // ⑨ 剧情播放起止（v1.9.9：名字切换只在播放期间、且只作用于当前图）
            SafePatch(typeof(Patch_StoryPlayBegin), "StoryScenarioNode.OnActive(播放开始)");
            SafePatch(typeof(Patch_StoryPlayEnd), "StoryScenarioNode.Continue(播放结束)");

            // ⑩ 剧情分支展开：被接管的门无条件判真（v1.10.0）
                        SafePatch(typeof(Patch_FlattenGate), "HoldNode.CheckCondition(分支展开的门)");

            // ⑪ 剧情收尾：StoryCloseNode 执行结果时还原姓名（v1.10.4 的事件驱动窗口终点）
            SafePatch(typeof(Patch_StoryClose), "StoryCloseNode.OnResult(剧情收尾)");

            // ⑫ 控制台指令 `join <人物ID|人物名> [1]`（静默：不写任何界面文字）
            SafePatch(typeof(Patch_ConsoleJoinInternal), "ConsoleUI.InvokeCommandInternal(join)");
            SafePatch(typeof(Patch_ConsoleJoinTyped), "ConsoleUI.InvokeCommand(string)(join)");
            SafePatch(typeof(Patch_ConsoleJoinNoArg), "ConsoleUI.InvokeCommand()(join)");

            L.LogInfo("[WulinTweaks] v" + Version + " loaded. data dir = " + DataDir);
        }

        /// <summary>
        /// 非拦截名单匹配：默认精确比对剧情图 ID；条目末尾带 * 时按前缀匹配
        /// （比如 R10005-* 覆盖该角色的所有剧情图）。
        /// </summary>
        internal static bool IsStoryBlacklisted(string graphName)
        {
            try
            {
                string raw = StoryBlacklist == null ? null : StoryBlacklist.Value;
                if (string.IsNullOrEmpty(raw) || string.IsNullOrEmpty(graphName)) return false;

                foreach (var piece in raw.Split(new[] { ',', ';', ' ', '\t', '\r', '\n' },
                                                StringSplitOptions.RemoveEmptyEntries))
                {
                    var p = piece.Trim();
                    if (p.Length == 0) continue;

                    if (p.EndsWith("*"))
                    {
                        var prefix = p.Substring(0, p.Length - 1);
                        if (prefix.Length > 0 &&
                            graphName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                            return true;
                    }
                    else if (string.Equals(graphName, p, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }

        private void SafePatch(Type patchClass, string label)
        {
            try
            {
                H.CreateClassProcessor(patchClass).Patch();
                L.LogInfo("[WulinTweaks] patched: " + label);
            }
            catch (Exception e)
            {
                L.LogError("[WulinTweaks] patch FAILED: " + label + " -> " + e.GetType().Name + ": " + e.Message);
            }
        }
    }
}
