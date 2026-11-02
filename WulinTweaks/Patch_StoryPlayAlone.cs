using System;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace WulinTweaks
{
    /// <summary>
    /// v1.11.43：独立剧情 / 头部独立剧情节点的**播放日志**（纯观测，不改行为）。
    ///
    /// 背景：`StoryScenarioNode.OnActive` 只覆盖普通「播放剧情」节点；
    /// R10049-2 里还有 `StoryOpenAloneNodePort ×2` / `StoryHeadAloneNodePort ×2`，
    /// 这类节点走的是另一个方法 —— 所以 PC 上明明看到 10061 的剧情（`R10049-2-1_4_2`），
    /// 日志里却一条 `graph=R10049-2-1` 都没有，无法定位到底哪条路径播的。
    ///
    /// 做法：运行期按类型名找类 → 找 OnActive → 挂 Prefix 打一条 `[play]`，找不到就跳过。
    /// ⚠️ 不注册进 Plugin 的 SafePatch 列表，由 Plugin.Awake 里显式调用 <see cref="Apply"/>，
    ///    因为这两个类型是否存在于 interop 程序集里无法在编译期确定。
    /// </summary>
    internal static class Patch_StoryPlayAlone
    {
        private static readonly string[] FallbackNames =
        {
            "WuLin.StateMachine.StoryOpenAloneNode",
            "WuLin.StateMachine.StoryHeadAloneNode",
        };

        private static int _logged;

        internal static void Apply(Harmony harmony)
        {
            var prefix = new HarmonyMethod(
                typeof(Patch_StoryPlayAlone).GetMethod(nameof(Prefix), BindingFlags.Static | BindingFlags.NonPublic));

            // v1.11.43：**不猜类名** —— 遍历已加载程序集里所有名字含 "Alone" 且有无参 OnActive 的类型。
            // （手机端实测 `WuLin.StateMachine.StoryOpenAloneNode` 这个名字并不存在，所以按特征扫。）
            int hooked = 0;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] types;
                try { types = asm.GetTypes(); }
                catch (ReflectionTypeLoadException e) { types = e.Types; }
                catch { continue; }
                if (types == null) continue;

                foreach (var t in types)
                {
                    if (t == null || t.Name == null || t.Name.IndexOf("Alone", StringComparison.Ordinal) < 0) continue;
                    MethodBase m;
                    try { m = t.GetMethod("OnActive", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null); }
                    catch { continue; }
                    if (m == null) continue;
                    try
                    {
                        harmony.Patch(m, prefix: prefix);
                        hooked++;
                        Plugin.L.LogInfo("[play] " + t.FullName + ".OnActive 已挂（播放日志）");
                    }
                    catch (Exception e) { Plugin.L.LogWarning("[play] 挂 " + t.FullName + " 失败: " + e.Message); }
                }
            }

            if (hooked == 0)
            {
                Plugin.L.LogInfo("[play] 没有扫到名字含 Alone 的类型，回退按类名找");
                foreach (var tn in FallbackNames)
                {
                    try
                    {
                        Type t = AccessTools.TypeByName(tn);
                        if (t == null) continue;
                        MethodBase m = AccessTools.Method(t, "OnActive");
                        if (m == null) continue;
                        harmony.Patch(m, prefix: prefix);
                        hooked++;
                        Plugin.L.LogInfo("[play] " + tn + ".OnActive 已挂（播放日志）");
                    }
                    catch (Exception e) { Plugin.L.LogWarning("[play] 回退挂 " + tn + " 失败: " + e.Message); }
                }
            }

            if (hooked == 0) Plugin.L.LogInfo("[play] 独立剧情播放日志未挂上（不影响功能）");
        }

        private static void Prefix(MonoBehaviour __instance)
        {
            try
            {
                if (__instance == null) return;
                if (_logged++ >= 300) return;

                Il2CppNative.Init();
                if (!Il2CppNative.Ready) return;

                IntPtr p = __instance.Pointer;
                string key = Il2CppNative.Str(p, "ScenarioKey");
                if (string.IsNullOrEmpty(key)) return;

                string graph = null;
                IntPtr g = Il2CppNative.Ptr(p, "graph");
                if (g != IntPtr.Zero) graph = Il2CppNative.Str(g, "name");

                Plugin.L.LogInfo("[play] Alone key=" + key + "（图 " + (graph ?? "?") + "）");
            }
            catch { }
        }
    }
}
