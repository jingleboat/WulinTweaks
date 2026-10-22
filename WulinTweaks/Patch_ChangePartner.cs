using System;
using HarmonyLib;
using WuLin;
using WuLin.StateMachine;

namespace WulinTweaks
{
    /// <summary>
    /// 「伙伴邀请或离队」容错（v1.9.5）。
    ///
    /// 背景：剧情条件放宽后，某些图的对话会在「某角色在队」这条判断被放宽的情况下
    /// 于角色**不在队**时也播出来。对话紧接着的 ChangePartnerNode(remove) 要把该角色
    /// 踢出队伍 —— 人本来就不在，动作落空，后面那对「他在队 / 他不在队」的流程判断
    /// 就可能两边都进不去，剧情从此不动（大梁捞朱 EJ-004 实测：洛天雄不在队，对话完卡死）。
    ///
    /// 做法：remove 一个不在队的角色时，跳过原版 OnResult（什么都不做 = 已满足）。
    /// ChangePartnerNode.OnResult 本身只是「取静态委托 OnResultAction，非空就尾调」的空壳，
    /// 所以跳过它不会破坏任何副作用，也不会误伤真正在队的离队流程。
    /// </summary>
    [HarmonyPatch(typeof(ChangePartnerNode), "OnResult")]
    internal static class Patch_ChangePartner
    {
        private const int MODE_ID = 0;      // ChangePartnerNode.SelectionMode.ID
        private const int STATE_REMOVE = 1; // ChangePartnerNode.PartnerIO.remove

        private static int _logs;

        private static bool Prefix(ChangePartnerNode __instance)
        {
            try
            {
                if (__instance == null) return true;
                if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return true;
                if ((int)__instance.state != STATE_REMOVE) return true;

                int pid = 0;
                bool skip = false;   // true = 队伍里根本没有这个角色 → 视为已成功
                if ((int)__instance.mode == MODE_ID)
                {
                    pid = __instance.partnerID;
                    if (pid <= 0) skip = true;
                }
                else
                {
                    // 按队中位置：Index 越界 = 队伍没那么多人。
                    // 释法寺 School-2020-1 就是 mode=1/Index=5，玩家队伍只有 2 人；
                    // 旧版这里退回原版，原版去踢一个不存在的队员 → 场景卡死。
                    var tm0 = PlayerTeamManager.Instance;
                    if (tm0 == null) return true;
                    int idx = __instance.Index;
                    int n = tm0.TeamSize;
                    if (n >= 0 && idx >= 0 && idx < n)
                    {
                        var c = tm0.GetTeamMemberByIndex(idx);
                        if (c != null) pid = c.TempleteUid;
                        else skip = true;
                    }
                    else skip = true;
                }
                if (skip)
                {
                    if (_logs++ < 40)
                        Plugin.L.LogInfo("[partner] remove(mode=" + (int)__instance.mode + ") 队伍里没有这个角色 → 视为成功，跳过原版");
                    return false;
                }
                if (pid <= 0) return true;

                if (InTeam(pid)) return true;

                if (_logs++ < 40)
                    Plugin.L.LogInfo("[partner] remove uid=" + pid + " 不在队 → 视为成功，跳过原版");
                return false;   // 跳过原版 OnResult
            }
            catch (Exception e)
            {
                if (_logs++ < 5) Plugin.L.LogWarning("[partner] 容错判断异常，走原版: " + e.Message);
                return true;
            }
        }

        /// <summary>true = 在队（也包含「查不到，保守走原版」）</summary>
        private static bool InTeam(int uid)
        {
            var tm = PlayerTeamManager.Instance;
            if (tm == null) return true;
            int n = tm.TeamSize;
            if (n < 0 || n > 32) return true;
            for (int i = 0; i < n; i++)
            {
                var c = tm.GetTeamMemberByIndex(i);
                if (c != null && c.TempleteUid == uid) return true;
            }
            return false;
        }
    }
}
