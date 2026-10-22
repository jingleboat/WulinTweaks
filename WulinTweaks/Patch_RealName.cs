using System;
using HarmonyLib;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// 剧情期间显示「熟悉后姓名」—— 三个独立的 Harmony 补丁 + 共用逻辑。
    ///
    /// === v1.9.8 的行为变化（重要）===
    /// 1.9.6 只挂了 get_FullName / get_FullNameWithTitle 的 Postfix，而且**从来没有被注册进
    /// Plugin 的补丁列表**（Plugin.cs 里只有 SafePatch(Hooks.*)，没有 Patch_RealName）——
    /// 也就是说 1.9.6 的姓名功能在 PC 上完全没生效过。
    ///
    /// 手机端（v61~v77）踩了六轮得到的结论，对 PC 同样成立：
    ///   ① 显示层**不看** get_FullName 的返回值（实测：getter 返回真名，画面仍是陌生名）；
    ///   ② 真正决定显示的是「这个角色算不算陌生」这个状态（get_IsUsingStangerName）；
    ///   ③ 窗口必须「每个 uid 一个」，单个全局 uid 会被反复重判的门对钉死。
    ///
    /// 所以这里三层一起上：
    ///   ① 状态层 RelaxName 把模板的「陌生时姓名」换掉；
    ///   ② 这里把 get_IsUsingStangerName 判成 false，让显示层走「熟悉」分支；
    ///   ③ get_FullName / get_FullNameWithTitle 兜底返回真名。
    /// 任意一层被显示层走到都会显示真名。
    /// </summary>
    internal static class RealNameCore
    {
        private static int _logs;

        /// <summary>防重入：RealFullName 在「不是陌生名」时会尾调 FullNameWithTitle，
        /// 那里挂着本类的 Postfix —— 否则 Apply → RealFullName → FullNameWithTitle → Apply
        /// 无限递归，.NET 的 StackOverflowException 无法 catch，直接杀进程。</summary>
        [ThreadStatic] private static bool _busy;

        internal static void Apply(GameCharacterInstance inst, ref string result)
        {
            try
            {
                if (inst == null) return;
                if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return;

                int uid;
                try { uid = inst.TempleteUid; } catch { return; }
                if (!RelaxName.IsLiveInStory(uid)) return;

                if (_busy) return;                  // 已在拼真名的途中：这一层放行原版
                _busy = true;
                string real;
                try { real = inst.RealFullName; }
                finally { _busy = false; }

                if (!string.IsNullOrWhiteSpace(real))
                {
                    if (_logs++ < 20) Plugin.L.LogInfo("[name] uid=" + uid + " 显示熟悉的姓名");
                    result = real;
                }
            }
            catch (Exception e)
            {
                if (_logs++ < 5) Plugin.L.LogWarning("[name] 显示真名判断异常，按原版: " + e.Message);
            }
        }

        /// <summary>窗口内的角色一律判为「不是陌生名」—— 让显示层走「熟悉」那条分支。</summary>
        internal static void Flag(GameCharacterInstance inst, ref bool result)
        {
            try
            {
                if (!result) return;
                if (inst == null) return;
                if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return;
                int uid;
                try { uid = inst.TempleteUid; } catch { return; }
                if (RelaxName.IsLiveInStory(uid)) result = false;
            }
            catch { }
        }
    }

    /// <summary>第三层兜底：get_FullName 直接给真名。</summary>
    [HarmonyPatch(typeof(GameCharacterInstance), "FullName", MethodType.Getter)]
    internal static class Patch_RealNameFull
    {
        private static void Postfix(GameCharacterInstance __instance, ref string __result)
            => RealNameCore.Apply(__instance, ref __result);
    }

    /// <summary>第三层兜底：get_FullNameWithTitle 直接给真名。</summary>
    [HarmonyPatch(typeof(GameCharacterInstance), "FullNameWithTitle", MethodType.Getter)]
    internal static class Patch_RealNameTitle
    {
        private static void Postfix(GameCharacterInstance __instance, ref string __result)
            => RealNameCore.Apply(__instance, ref __result);
    }

    /// <summary>第二层：把窗口内角色判成「不是陌生名」。手机端证明这是关键的一层。</summary>
    [HarmonyPatch(typeof(GameCharacterInstance), "IsUsingStangerName", MethodType.Getter)]
    internal static class Patch_RealNameStrangerFlag
    {
        private static void Postfix(GameCharacterInstance __instance, ref bool __result)
            => RealNameCore.Flag(__instance, ref __result);
    }
}
