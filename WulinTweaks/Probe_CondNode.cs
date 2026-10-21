using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using WuLin;
using WuLin.StateMachine;
using UnityEngine;
using XNode;

namespace WulinTweaks
{
    /// <summary>只用于探测：保留作后续排查。</summary>
    internal static class Probe_CondNode
    {
        internal static void Report()
        {
            try
            {
                var t = typeof(ConditionNode);
                Plugin.L.LogInfo("[probe] ConditionNode = " + t.FullName);
                bool hasGraph = t.GetProperty("graph") != null || t.GetField("graph") != null;
                Plugin.L.LogInfo("[probe] ConditionNode 能否直接看到 graph 成员: " + hasGraph);
            }
            catch (Exception e) { Plugin.L.LogWarning("[probe] ConditionNode 探测失败: " + e.Message); }
        }
    }
}
