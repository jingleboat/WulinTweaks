using System;
using HarmonyLib;
using WuLin;
using WuLin.StateMachine;

namespace WulinTweaks
{
    /// <summary>
    /// 剧情播放的起止钩子 —— 与手机端 v79/v80 同一套思路。
    ///
    /// StoryScenarioNode 就是剧情图里的「播放剧情」节点：
    ///   OnActive()          开始播这段 scenario
    ///   Continue(string)    播完走向下一个节点
    ///
    /// 手机端（0x3DA0730 / 0x3DA0798）用内联 hook；PC 这边是 Harmony，直接拿强类型实例，
    /// 不用碰裸偏移。
    /// </summary>
    [HarmonyPatch(typeof(StoryScenarioNode), "OnActive")]
    internal static class Patch_StoryPlayBegin
    {
        /// <summary>
        /// Prefix：**必须在原函数之前把名字改好**。
        ///
        /// 气泡是在 `OnActive` 里生成的，改名放到 Postfix 就晚了一步 ——
        /// 第一句会先用陌生名渲染一遍，下一句才变成真名（现象就是"先闪一下陌生名"）。
        /// 手机端同理：`hook_ssn_onactive` 里 `story_play_begin` 也必须排在原函数之前。
        /// </summary>
        private static void Prefix(StoryScenarioNode __instance)
        {
            try
            {
                if (__instance == null) return;
                string graph = null;
                try { graph = __instance.graph == null ? null : __instance.graph.name; } catch { }
                RelaxName.PlayBegin(graph);
            }
            catch (Exception e) { Plugin.L.LogWarning("[name] PlayBegin 异常: " + e.Message); }
        }

        /// <summary>
        /// Postfix：在这张图上套「分支展开」补丁（每张图只做一次，之后是一次哈希查找）。
        /// 分支展开改的是连线，与气泡生成无关，放 Postfix 没问题。
        /// </summary>
        private static void Postfix(StoryScenarioNode __instance)
        {
            try
            {
                if (__instance == null) return;
                BranchFlatten.Try(__instance.Pointer);
            }
            catch (Exception e) { Plugin.L.LogWarning("[flat] Try 异常: " + e.Message); }
        }
    }

    [HarmonyPatch(typeof(StoryScenarioNode), "Continue")]
    internal static class Patch_StoryPlayEnd
    {
        private static void Postfix()
        {
            try { RelaxName.PlayEnd(); }
            catch (Exception e) { Plugin.L.LogWarning("[name] PlayEnd 异常: " + e.Message); }
        }
    }

    /// <summary>
    /// 剧情分支展开：把「已被展开接管」的门无条件判真。
    ///
    /// 为什么打在 HoldNode.CheckCondition 上、而不是像手机端那样在条件判定入口里判：
    /// PC 版的 HoldNode.conditionPort 挂着一个空的 ConditionPort 对象（无字段无方法），
    /// 从它身上走不到条件节点，所以只能在「门」这一层动手 —— 门就是剧情图里那个
    /// 带 InPort / conditionPort / OutPort 的「流程判断」节点。
    ///
    /// 语义与手机端一致：这个门上的「需要伙伴」条件不再参与判定。
    /// </summary>
    [HarmonyPatch(typeof(HoldNode), "CheckCondition")]
    internal static class Patch_FlattenGate
    {
        private static void Postfix(HoldNode __instance, ref bool __result)
        {
            try
            {
                if (__result || __instance == null) return;
                if (!BranchFlatten.IsGateForced(__instance.Pointer)) return;
                __result = true;
            }
            catch (Exception e) { ModKit.Err("patch flatten gate", e); }
        }
    }

    /// <summary>
    /// 剧情事件真正结束的信号 —— 剧情图里那个「结束剧情」节点（StoryCloseNode）执行结果时。
    ///
    /// 为什么需要它：`StoryScenarioNode.Continue` 是**每个节点**都会调一次，
    /// 而节点之间的空档实测能到 1~19 秒（玩家读字、选项、Hold 等待）。
    /// 靠 Continue + 短宽限判断"剧情播完了"必然在空档里误还原。
    /// 这个节点只在剧情收尾时出现一次，带着自己的 GraphName，可以精确判断"是我们这张图结束了"。
    /// </summary>
    [HarmonyPatch(typeof(StoryCloseNode), "OnResult")]
    internal static class Patch_StoryClose
    {
        private static void Postfix(StoryCloseNode __instance)
        {
            try
            {
                if (__instance == null) return;
                string gn = null;
                try { gn = __instance.GraphName; } catch { }

                string playing = RelaxName.PlayingGraph;
                if (string.IsNullOrEmpty(playing)) return;

                // 只结束"我们自己这张图"：别的剧情收尾不应影响当前播放中的姓名窗口
                if (string.IsNullOrEmpty(gn) || !string.Equals(gn, playing, StringComparison.Ordinal))
                    return;

                Plugin.L.LogInfo("[name] 剧情收尾（StoryCloseNode graph=" + gn + "）→ 还原姓名");
                RelaxName.EndNow();
            }
            catch (Exception e) { ModKit.Err("patch story close", e); }
        }
    }
}
