using System;
using HarmonyLib;
using WuLin;
using WuLin.StateMachine;

namespace WulinTweaks
{
    /// <summary>
    /// 剧情播放的起止钩子 —— 与手机端 v79 同一套思路。
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
        // ---- 诊断（1.10.3）：确认 Continue 的触发粒度与段间空档 ----
        // 每行对话都调 Continue，还是每个节点只调一次？这决定了「播完宽限」这种时间窗
        // 到底能不能用来判断"这段剧情播完了"。日志形如：
        //   [name] ▶ ScenarioKey=R10049-2_2_3 距上一节点 12ms，其间 Continue=1
        private static long _lastBeginAt;
        private static int _contSinceBegin;
        private static int _logPlay;

        internal static void NoteContinue() { _contSinceBegin++; }

        private static void Postfix(StoryScenarioNode __instance)
        {
            try
            {
                if (__instance == null) return;

                string graph = null;
                try { graph = __instance.graph == null ? null : __instance.graph.name; } catch { }

                long now = Environment.TickCount64;
                if (_logPlay++ < 40)
                {
                    string key;
                    try { key = __instance.ScenarioKey; } catch { key = "?"; }
                    long gap = _lastBeginAt == 0 ? -1 : now - _lastBeginAt;
                    Plugin.L.LogInfo("[name] ▶ ScenarioKey=" + (key ?? "?")
                                     + " 距上一节点 " + gap + "ms"
                                     + "，其间 Continue=" + _contSinceBegin);
                }
                _lastBeginAt = now;
                _contSinceBegin = 0;

                RelaxName.PlayBegin(graph);

                // v1.10.0：剧情一开始播就在这张图上套「分支展开」补丁。
                // 这是最早也最可靠的时机 —— 图此刻必然已加载完，而且 _2_1 还没播完，
                // 等它播完要走 OutPort 时，改连已经生效。
                BranchFlatten.Try(__instance.Pointer);
            }
            catch (Exception e) { Plugin.L.LogWarning("[name] PlayBegin 异常: " + e.Message); }
        }
    }

    [HarmonyPatch(typeof(StoryScenarioNode), "Continue")]
    internal static class Patch_StoryPlayEnd
    {
        private static void Postfix()
        {
            try
            {
                Patch_StoryPlayBegin.NoteContinue();
                RelaxName.PlayEnd();
            }
            catch (Exception e) { Plugin.L.LogWarning("[name] PlayEnd 异常: " + e.Message); }
        }
    }

    /// <summary>
    /// 剧情事件真正结束的信号 —— 剧情图里那个「结束剧情」节点（StoryCloseNode）执行结果时。
    ///
    /// 为什么需要它：`StoryScenarioNode.Continue` 是**每个节点**都会调一次，
    /// 而节点之间的空档实测能到 1~19 秒（玩家读字、选项、Hold 等待）。
    /// 靠 Continue + 短宽限判断"剧情播完了"必然在空档里误还原（1.10.3 实测就是这么翻车的）。
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

    /// <summary>
    /// 剧情分支展开：把「已被展开接管」的门无条件判真。
    ///
    /// 为什么打在 HoldNode.CheckCondition 上、而不是像手机端那样在条件判定入口里判：
    /// PC 版的 HoldNode.conditionPort 挂着一个空的 ConditionPort 对象（无字段无方法），
    /// 从它身上走不到条件节点，所以只能在「门」这一层动手 —— 门就是剧情图里那个
    /// 名字叫「流程判断」、带 InPort / conditionPort / OutPort 的节点。
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
}
