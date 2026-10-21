using System;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// 只读诊断：验证「从未入队」能否用 GameCharacterInstance.m_TeamMemberState(+0x130) 判定。
    /// TeamMemberState 结构：isJoined(+0x10, bool) / leaveTeamMap(+0x1C, int)。
    /// 若 state 指针为 0 => 从未入队；非 0 且 leaveTeamMap != 0 => 入过队又离队。
    /// </summary>
    internal static class Probe_TeamState
    {
        private static bool _done;

        // 采样：从未入队（苗彩蝶/曼陀罗/癞头癫）、入队后离队（猎户/铁匠）、玩家自己
        private static readonly int[] Ids = { 10005, 10021, 10025, 20001, 20006, 100401 };

        internal static void Report()
        {
            if (_done) return;
            _done = true;
            try
            {
                var mgr = GameCharacterManager.Instance;
                if (mgr == null) { Plugin.L.LogWarning("[teams] GameCharacterManager.Instance = null"); return; }
                Plugin.L.LogInfo("[teams] === m_TeamMemberState 诊断 ===");
                foreach (var id in Ids)
                {
                    try
                    {
                        var c = mgr.GetCharacter(id);
                        if (c == null) { Plugin.L.LogInfo("[teams] " + id + " -> GetCharacter = null"); continue; }

                        IntPtr p = c.Pointer;
                        IntPtr tms = Hooks.SafeMem.Ptr(p, 0x130);
                        if (tms == IntPtr.Zero)
                        {
                            Plugin.L.LogInfo("[teams] " + id + " -> state=NULL  (从未入队)");
                        }
                        else
                        {
                            bool joined = Hooks.SafeMem.Byte(tms, 0x10) != 0;
                            int hp = Hooks.SafeMem.Int32(tms, 0x14);
                            int leaveMap = Hooks.SafeMem.Int32(tms, 0x1C);
                            Plugin.L.LogInfo("[teams] " + id + " -> state!=NULL isJoined=" + joined
                                + " curHp=" + hp + " leaveTeamMap=" + leaveMap);
                        }
                    }
                    catch (Exception e)
                    {
                        Plugin.L.LogWarning("[teams] " + id + " 失败: " + e.GetType().Name + " " + e.Message);
                    }
                }
            }
            catch (Exception e) { ModKit.Err("probe team", e); }
        }
    }
}
