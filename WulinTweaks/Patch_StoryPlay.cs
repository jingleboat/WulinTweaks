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

                // v1.11.36：先按本图名单补一次「陌生名 → 真名」，再开播放窗口。
                // 顺序不能反：PlayBegin 里 Sync 会拍下实例"原值"，先清掉 @ 才不会在收尾时被还原回去。
                try { Unstranger.OnPlay(graph); } catch { }

                RelaxName.PlayBegin(graph);

                // v1.11.32：记录这张图「正在播的场景键」，供「场景级固定名单」判定。
                // 用 Il2CppNative 按字段名读（不依赖 interop 是否导出 ScenarioKey 属性）。
                try
                {
                    Il2CppNative.Init();
                    if (Il2CppNative.Ready)
                    {
                        string key = Il2CppNative.Str(__instance.Pointer, "ScenarioKey");
                        if (!string.IsNullOrEmpty(key)) StoryScene.Record(graph, key);
                    }
                }
                catch { }
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
    /// <summary>v1.11.60：在门判定之前记录"这道门是否通过过"，供条件层决定要不要放宽。</summary>
    [HarmonyPatch(typeof(HoldNode), "CheckCondition")]
    internal static class Patch_GateTimesPrefix
    {
        /// <summary>本门判定期间需要保存/恢复的全部跨 patch 状态。</summary>
        private struct GateEvalState
        {
            public bool NoRelax;
            public bool Relaxed;
        }

        /// <summary>
        /// v1.11.67：**保存 / 恢复，不能直接清 false。**
        ///
        /// `NoRelaxThisEval` / `RelaxedThisEval` 都是全局静态，而 `HoldNode.CheckCondition`
        /// 是**递归**的（原版 CheckCondition 会推进剧情、进而判定下一道门，又进这里）。
        /// 原来 Postfix 直接 `NoRelaxThisEval = false`，会把**外层**刚设好的状态冲掉 →
        /// 同一段剧情跑得深就出错、跑得浅就正常，也就是「有时可触发有时不行」。
        ///
        /// ⚠️ 还必须保证本 Prefix **一定执行**：Harmony 在某个 prefix 返回 false 之后会
        /// **跳过后续还没跑的 prefix**，但 **postfix 全部照跑**。本类若排在
        /// `Patch_FlattenGate`（唯一 return false 的那个）之后，Prefix 不执行 → `__state`
        /// 是默认 false → Postfix 反而把外层设成 false，比原来更糟。
        /// 所以用 `HarmonyPriority(Priority.First)` 把它钉在最前面。
        ///
        /// 手机端 v197 同一处改法（`g_no_relax_eval` 改 `__thread` + 保存/恢复）。
        /// </summary>
        [HarmonyPriority(Priority.First)]
        private static void Prefix(HoldNode __instance, out GateEvalState __state)
        {
            __state = new GateEvalState
            {
                NoRelax = NativeTeamHook.NoRelaxThisEval,
                Relaxed = NativeTeamHook.RelaxedThisEval,
            };
            NativeTeamHook.RelaxedThisEval = false;        // 本门判定从"没放宽"开始
            try
            {
                int t = 0; try { t = __instance.checkSucessTimes; } catch { }
                NativeTeamHook.NoRelaxThisEval = t != 0;
            }
            catch { }
        }
        private static void Postfix(GateEvalState __state)
        {
            NativeTeamHook.NoRelaxThisEval = __state.NoRelax;   // 恢复，不是清零
            NativeTeamHook.RelaxedThisEval = __state.Relaxed;
        }
    }

    [HarmonyPatch(typeof(HoldNode), "CheckCondition")]
    internal static class Patch_FlattenGate
    {
        /// <summary>
        /// v1.11.55（S1）：已被展平接管的门 —— **Prefix 直接短路，不执行原版**。
        /// 原版 CheckCondition 内部会把 checkSucessTimes +1，"先调再覆盖"等于白耗原生次数；
        /// 展平的"两侧各播一次"由改线保证，不需要原生次数参与。
        /// </summary>
        private static bool Prefix(HoldNode __instance, ref bool __result)
        {
            try
            {
                if (__instance == null || !BranchFlatten.IsGateForced(__instance.Pointer)) return true;
                int t = 0; try { t = __instance.checkSucessTimes; } catch { }
                __result = true;
                // v1.11.62：强制放行的门 → 顺带清掉该角色的 '@' 陌生名。
                // 之前只靠 Unstranger.OnPlay（按 RelaxName 槽位清），而链式接管的门**没有走放宽**、
                // 槽位里没有这些 uid → 李乐雅/顾倾城一直显示陌生名（实测）。
                try
                {
                    bool it2; int pidc = BranchFlatten.GatePid(__instance.Pointer, out it2);
                    if (pidc > 0) Unstranger.Apply(pidc);
                }
                catch { }
                GateTrace.Log(__instance, true, "FLATTENED", t, t);
                return false;          // 跳过原版
            }
            catch (Exception e) { ModKit.Err("patch flatten gate prefix", e); return true; }
        }
    }

    /// <summary>v1.11.55（S1.5）：非展平门的判定轨迹，带"通过来源"标记。</summary>
    [HarmonyPatch(typeof(HoldNode), "CheckCondition")]
    internal static class Patch_GateTrace
    {
        private static void Postfix(HoldNode __instance, ref bool __result)
        {
            try
            {
                if (__instance == null) return;
                if (BranchFlatten.IsGateForced(__instance.Pointer)) return;   // 已由 Prefix 记录
                int t = 0; try { t = __instance.checkSucessTimes; } catch { }
                string src = Hooks.HoldOnceGuard.SuppressedThisEval ? "GUARDED"
                           : (__result && NativeTeamHook.RelaxedThisEval ? "RELAXED"
                           : (__result ? "VANILLA" : "VANILLA_FAIL"));
                // v1.11.62：播放期间任何与角色相关的门通过 → 清该角色陌生名（与手机 v166 一致）
                if (__result)
                {
                    try
                    {
                        bool it2; int pidc = BranchFlatten.GatePid(__instance.Pointer, out it2);
                        if (pidc > 0 && !string.IsNullOrEmpty(RelaxName.PlayingGraph)) Unstranger.Apply(pidc);
                    }
                    catch { }
                }
                GateTrace.Log(__instance, __result, src, t, t);
            }
            catch { }
        }
    }

    /// <summary>v1.11.55：两端同构的 [gate] 轨迹输出。</summary>
    internal static class GateTrace
    {
        private static readonly System.Collections.Generic.Dictionary<IntPtr, string> _last =
            new System.Collections.Generic.Dictionary<IntPtr, string>();
        private static int _n;

        internal static void Log(HoldNode node, bool result, string src, int t0, int t1)
        {
            if (node == null || _n >= 600) return;
            IntPtr p = node.Pointer;
            string key = (result ? "1" : "0") + src;
            string prev;
            if (_last.TryGetValue(p, out prev) && prev == key) return;
            _last[p] = key;
            _n++;
            string gn = null;
            try { gn = node.graph == null ? null : node.graph.name; } catch { }
            bool inTeam;
            int pid = BranchFlatten.GatePid(p, out inTeam);
            Plugin.L.LogInfo("[gate] 图=" + (gn ?? "?") + " 门=" + p.ToString("X")
                             + " pid=" + pid + " 类=" + BranchFlatten.GateCls(p)
                             + " 侧=" + (pid <= 0 ? "?" : (inTeam ? "在队" : "不在队"))
                             + " times=" + t0 + "→" + t1
                             + " forced=" + (BranchFlatten.IsGateForced(p) ? "Y" : "N")
                             + " 源=" + src
                             + " → " + (result ? "通过" : "不通过"));
        }
    }

    /// <summary>
    /// v1.11.37：读档完成 —— 清掉「每图只放宽一次」和所有姓名缓存。
    ///
    /// 为什么必须清：读手动存档后 `TeamRule._relaxedOnce` 还留着上一局的图名，
    /// 于是第二次触发同一段剧情时只有「已放宽过一次 → 本次走原版」，
    /// MarkRelaxed / Unstranger 一次都不被调用 → 陌生名没机会被改写。
    /// 手机端 v143 用同一处（GameCharacterManager.OnLoadFinished）修的同一条。
    /// </summary>
    [HarmonyPatch(typeof(GameCharacterManager), "OnLoadFinished")]
    internal static class Patch_LoadFinished
    {
        private static int _logs;

        private static void Postfix()
        {
            try
            {
                TeamRule.Reset();
                Unstranger.Reset();
                RelaxName.DropAll();     // 只丢槽位，不回写（旧实例已经作废，写它就是写野指针）
                if (_logs++ < 10) Plugin.L.LogInfo("[name] 读档完成 → 重置放宽一次性状态与姓名缓存");
            }
            catch (Exception e) { ModKit.Err("patch load finished", e); }
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
