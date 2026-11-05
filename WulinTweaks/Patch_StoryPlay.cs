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

                // v1.11.36：剧情开播时按本图名单强制补一次「陌生名 → 真名」（force 绕过缓存）。
                // 这是「显示真名」的唯一执行路径：把实例的 m_givenName 置空，
                // get_IsUsingStangerName 随即变 false（它判的就是 m_givenName 是否以 '@' 开头），
                // 显示层走「熟悉」分支，游戏自己从模板取真名。
                try { Unstranger.OnPlay(graph); } catch { }

                /* 原来这里还有一行 RelaxName.PlayBegin(graph) —— 已去掉。
                 * 它只为 IsLiveInStory 开窗口，而消费它的 Patch_RealName 从未注册（Plugin.cs 里注明
                 * "未注册 = 不生效"）；Sync 本体在 1.11.40 也 return 掉了（停用临时改名）。
                 * 也就是这一行早就是死调用，留着只会让人误以为还有一层"改名 + 收尾还原"的机制。
                 * RelaxName 里的槽位登记（MarkRelaxed / UidsOfGraph）仍然保留 —— OnPlay 靠它拿本图 uid 列表。 */

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
                if (__instance == null) return;

                // 原逻辑：判假的门如果被展平接管 → 强制放行
                bool forced = false;
                if (!__result && BranchFlatten.IsGateForced(__instance.Pointer))
                {
                    __result = true;
                    forced = true;
                }

                /* 【「显示真名」—— 门通过时补清，只针对**我们放宽造成的**通过】
                 *
                 * 为什么需要：临时实例（GetOrCreateCharacter(uid, isPernament:false)）在剧情用到她
                 * 的那一刻才被创建，创建时才把 "@清冷的蒙面女子" 写进 m_givenName。而
                 *   · 放宽判定时实例往往还不存在 → Unstranger.Apply 返回 null 直接跳过；
                 *   · 剧情开播（OnActive → OnPlay）时也可能还没建 → 同样清不到。
                 * 门判定通过时实例一定已经存在（剧情正在用它），所以这里再补一次。
                 *
                 * 两条判定，都只认「mod 介入」的门：
                 *   ① forced —— 原版判假、被展平强制放行；
                 *   ② 原版判真，但这个 (图, pid) 属于我们放宽过的（RelaxName.WasRelaxed）。
                 * 原版本来就走通、跟我们无关的门，一律不碰。 */
                int pidc = 0;
                try { pidc = BranchFlatten.GatePartnerId(__instance.Pointer); } catch { }

                if (pidc > 0)
                {
                    bool ours = forced;
                    if (!ours)
                    {
                        try
                        {
                            string gn = null;
                            try { gn = __instance.graph == null ? null : __instance.graph.name; } catch { }
                            ours = RelaxName.WasRelaxed(gn, pidc);
                        }
                        catch { }
                    }
                    if (ours)
                    {
                        try { Unstranger.Apply(pidc); } catch { }
                    }
                }
            }
            catch (Exception e) { ModKit.Err("patch flatten gate", e); }
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

    /* Patch_StoryClose（StoryCloseNode.OnResult）已删除。
     * 它原本的职责是"剧情收尾 → 还原被临时改掉的姓名"，而临时改名那套在 1.11.40 就停用了；
     * 现在显示真名只靠 Unstranger 清空 m_givenName（不需要还原），这个补丁没有任何事可做。 */
}
