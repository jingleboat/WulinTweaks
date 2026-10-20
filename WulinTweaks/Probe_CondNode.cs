using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using WuLin;
using WuLin.StateMachine;
using XNode;

namespace WulinTweaks
{
    /// <summary>只用于探测：ConditionNode / StoryManager.CheckConditionFromRoot 能否被 Harmony 定位。</summary>
    internal static class Probe_CondNode
    {
        internal static void Report()
        {
            try
            {
                var t = typeof(ConditionNode);
                Plugin.L.LogInfo("[probe] ConditionNode = " + t.FullName);
                var ms = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                int ca = 0, ce = 0;
                foreach (var m in ms) { if (m.Name == "CheckAllConnectNode") ca++; if (m.Name == "CheckExtra") ce++; }
                Plugin.L.LogInfo("[probe] ConditionNode.CheckAllConnectNode=" + ca + " CheckExtra=" + ce);
                bool hasGraph = t.GetProperty("graph") != null || t.GetField("graph") != null;
                Plugin.L.LogInfo("[probe] ConditionNode 能否直接看到 graph 成员: " + hasGraph);
            }
            catch (Exception e) { Plugin.L.LogWarning("[probe] ConditionNode 探测失败: " + e.GetType().Name + " " + e.Message); }
        }
    }

    /// <summary>
    /// 条件检查总入口的分流：StoryManager.CheckConditionFromRoot。
    /// Hold 上的「流程判断」和事件头黄点上的「需要伙伴」最终都走这里，
    /// 所以在这一层按剧情图名分流，能覆盖所有入口。
    ///   名单内 -> 临时撤掉条件 patch，跑真正的原版判断（需要伙伴=在队才成立），跑完装回；
    ///   名单外 -> 什么都不做，正常放宽。
    /// </summary>
    [HarmonyPatch]
    internal static class ConditionRootGuard
    {
        [ThreadStatic] private static bool _inside;
        private static readonly HashSet<string> _logged = new HashSet<string>();

        static MethodBase TargetMethod()
        {
            try { return AccessTools.Method(typeof(StoryManager), "CheckConditionFromRoot"); }
            catch (Exception e) { ModKit.Err("targetmethod condroot", e); return null; }
        }

        static bool Prefix(StoryManager __instance,
                           NodePort port,
                           Il2CppSystem.Type conditionType,
                           Il2CppReferenceArray<Il2CppSystem.Object> extra,
                           Il2CppSystem.Collections.Generic.List<ConditionNode> successList,
                           bool checkNodeTimes,
                           ref bool __result)
        {
            try
            {
                if (_inside) return true;
                if (!Plugin.IgnoreTeamCondition.Value) return true;
                if (port == null) return true;

                string gn = null;
                try
                {
                    var n = port.node;
                    if (n != null)
                    {
                        var g = n.graph;
                        if (g != null) gn = g.name;
                    }
                }
                catch { return true; }

                if (string.IsNullOrEmpty(gn)) return true;
                if (!Plugin.IsStoryBlacklisted(gn)) return true;     // 名单外：照常放宽

                // 名单内：按原版判断
                _inside = true;
                Hooks.ProbingOrig = true;
                try
                {
                    ModKit.RestoreTeamCondition();
                    __result = __instance.CheckConditionFromRoot(port, conditionType, extra, successList, checkNodeTimes);
                }
                finally
                {
                    ModKit.ForceIgnoreTeamCondition();
                    Hooks.ProbingOrig = false;
                    _inside = false;
                }

                if (_logged.Add(gn))
                    Plugin.L.LogInfo("[blacklist-root] 剧情图 " + gn + " 条件按原版判断（不放宽）→ "
                        + (__result ? "通过" : "不通过"));
                return false;
            }
            catch (Exception e)
            {
                ModKit.Err("condroot guard", e);
                return true;
            }
        }
    }
}
