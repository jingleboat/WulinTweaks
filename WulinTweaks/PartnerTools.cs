using System;
using System.Collections.Generic;
using GameData;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// 控制台指令 `join` 用到的动作：解除陌生 / 复活 / 可入家园 / 结缘。
    /// 全部走游戏自己的字段与接口，**不写任何界面文字**（指令要求静默），
    /// 只在 BepInEx 日志里留痕，方便排查。
    /// </summary>
    internal static class PartnerTools
    {
        internal const int RelationFull = 100;          // FriendlyData 顶格「生死」
        internal const string MeetProp = "初次见面";     // 陌生与否的判据（存档实证）

        /// <summary>情缘武功表：uid → kungfuId（12 张结缘图的「获得武功或绝学」节点）。</summary>
        private static readonly Dictionary<int, int> BondKungfu = new Dictionary<int, int>
        {
            { 20025, 300001 }, { 10092, 300002 }, { 10084, 300003 }, { 10064, 300005 },
            { 10056, 300006 }, { 10009, 300007 }, { 10081, 300008 }, { 10008, 300009 },
            { 20063, 300011 }, { 10052, 300013 }, { 10108, 300021 }, { 10039, 300022 },
        };

        /// <summary>按模板 uid 取已存在的实例（不新建）。</summary>
        internal static GameCharacterInstance Instance(int uid)
        {
            try
            {
                var m = GameCharacterManager.Instance;
                return m == null ? null : m.GetCharacter(uid);
            }
            catch { return null; }
        }

        // ---------------------------------------------------------------- ① 解除陌生
        /// <summary>
        /// 存档实证的「已认识」形状：`m_additionProps["初次见面"] = 1` + 双向好感 100 +
        /// `m_surName` / `m_givenName` 为空串（显示走模板真名）。
        /// </summary>
        internal static void Unstranger(GameCharacterInstance inst)
        {
            if (inst == null) return;
            int uid = 0, self = 0;
            try { uid = inst.TempleteUid; } catch { }
            try { self = inst.InstanceId; } catch { }

            // ① 双向好感 100
            try
            {
                var tm = PlayerTeamManager.Instance;
                var me = tm == null ? null : tm.PlayerDataInstance;
                if (me != null)
                {
                    inst.SetRelation(me.InstanceId, RelationFull);
                    me.SetRelation(self, RelationFull);
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 写好感失败: " + e.Message); }

            // ② 初次见面 = 1
            try { inst.SetAdditionProp(MeetProp, new Il2CppSystem.Decimal(1)); }
            catch
            {
                try
                {
                    int cur = -1;
                    try { cur = inst.GetFinalProp(MeetProp); } catch { }
                    inst.ChangeAdditionPropWithLog(MeetProp, 1 - Math.Max(0, cur));
                }
                catch (Exception e) { Plugin.L.LogWarning("[join] 写「初次见面」失败: " + e.Message); }
            }

            // ③ 清掉陌生名（实例里存的是不带 @ 的陌生名，@ 是显示层加的）
            try
            {
                string sn = inst.SurName ?? "";
                string gn = inst.GivenName ?? "";
                string tplStranger = null;
                try { var t = inst.Templete; if (t != null) tplStranger = t.NameAsStranger; } catch { }

                bool stranger = false;
                try { stranger = inst.IsUsingStangerName; } catch { }
                bool isStrangerName = gn.Length > 0 &&
                                      (gn[0] == '@' ||
                                       (!string.IsNullOrEmpty(tplStranger) &&
                                        (gn == tplStranger || gn == "@" + tplStranger)));
                if (isStrangerName || stranger)
                {
                    if (sn.Length > 0) { try { inst.SetSurName(""); } catch { } }
                    if (gn.Length > 0) { try { inst.SetGivenName(""); } catch { } }
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 清陌生名失败: " + e.Message); }

            int meet = -1;
            try { meet = inst.GetFinalProp(MeetProp); } catch { }
            Plugin.L.LogInfo("[join] uid=" + uid + " 解除陌生：初次见面=" + meet + "，given=" + GiveName(inst));
        }

        // ---------------------------------------------------------------- ② 复活
        /// <summary>复活的落点就是 `m_isAlive`：`SetAlive(true)`。返回是否真的复活了。</summary>
        internal static bool ReviveIfDead(GameCharacterInstance inst)
        {
            if (inst == null) return false;
            bool alive = true;
            try { alive = inst.IsAlive; } catch { return false; }
            if (alive) return false;

            try { inst.SetAlive(true, false); }
            catch (Exception e) { Plugin.L.LogWarning("[join] SetAlive 失败: " + e.Message); }
            try { if (inst.CurHp <= 0) inst.FullyRecover(); } catch { }

            bool now = false;
            try { now = inst.IsAlive; } catch { }
            Plugin.L.LogInfo("[join] uid=" + inst.TempleteUid + " 复活 → m_isAlive=" + now);
            return now;
        }

        // ---------------------------------------------------------------- ③ 可入家园
        /// <summary>
        /// 让她能被放进家园，三件缺一不可：
        ///   ① `CharacterTeamMemberExtendData.CouldBackToFief = true`（缺数据行就现补一行）
        ///   ② 队友状态 `m_TeamMemberState`（含离队回程点 leaveTeamMap/Pos/Dir）
        ///   ③ 故事标签 `UnlockInviting-&lt;uid&gt;`（家园提示「未完成相关事件」的判据）
        /// </summary>
        internal static void FiefReady(GameCharacterInstance inst)
        {
            if (inst == null) return;
            int uid = 0;
            try { uid = inst.TempleteUid; } catch { }
            if (uid <= 0) return;

            try
            {
                var so = BaseDataClass.GetGameData<CharacterTeamMemberExtendDataScriptObject>();
                if (so != null)
                {
                    var rec = so.GetData(uid);
                    if (rec == null)
                    {
                        rec = new CharacterTeamMemberExtendData();
                        rec.Uid = uid;
                        try { rec.UName = inst.TempleteName ?? ""; } catch { }
                        rec.CouldBackToFief = true;
                        so.AddData(rec);
                    }
                    else if (!rec.CouldBackToFief) rec.CouldBackToFief = true;
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 写 CouldBackToFief 失败: " + e.Message); }

            EnsureTeamState(inst);

            try
            {
                var sm = StoryManager.Instance;
                if (sm != null)
                {
                    string tag = "UnlockInviting-" + uid;
                    if (!sm.HaveString(tag)) sm.WriteString(tag);
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 写 UnlockInviting 失败: " + e.Message); }

            Plugin.L.LogInfo("[join] uid=" + uid + " 家园：CouldBackToFief + TeamMemberState + UnlockInviting-" + uid);
        }

        private static void EnsureTeamState(GameCharacterInstance inst)
        {
            try
            {
                TeamMemberState st = null;
                try { st = inst.TeamMemberState; } catch { }
                if (st == null)
                {
                    try { inst.InitTeamMemberState(); } catch { }
                    try { st = inst.TeamMemberState; } catch { }
                    if (st == null) { try { inst.FixNullTeamMemberState(); } catch { } try { st = inst.TeamMemberState; } catch { } }
                }
                if (st == null) return;

                if (st.leaveTeamMap <= 0)
                {
                    try { st.leaveTeamMap = inst.CurMapId; } catch { }
                    try { st.leaveTeamPos = inst.CurPos; } catch { }
                    try { st.leaveTeamDir = inst.Dir; } catch { }
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 队友状态失败: " + e.Message); }
        }

        // ---------------------------------------------------------------- ④ 结缘
        /// <summary>真实结缘的改动：`SetBond` 双向 + 情缘武功 + 三件情缘 buff。</summary>
        internal static void MakeBond(GameCharacterInstance inst)
        {
            if (inst == null) return;
            int uid = 0;
            try { uid = inst.TempleteUid; } catch { }

            try
            {
                var tm = PlayerTeamManager.Instance;
                var me = tm == null ? null : tm.PlayerDataInstance;
                if (me != null)
                {
                    /* 方向口径（存档实证）：她那一侧永远是「主角是什么身份」——
                     * 女角色 → Husband(1)，男角色 → Wife(2)；主角那一侧相反（alsoSetOther 自动写）。
                     * 旧代码按 uid 硬编码 20025/20063 是错的：其余女角色会被写成 Wife(2)。 */
                    bool female = true;
                    try { female = inst.Templete == null || (int)inst.Templete.Sex != 1; } catch { }
                    inst.SetBond(me.InstanceId, female ? BondType.Husband : BondType.Wife, true);
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] SetBond 失败: " + e.Message); }

            int kf;
            if (BondKungfu.TryGetValue(uid, out kf))
            {
                try { inst.InstantLearnKungfu(kf, 1, false); } catch (Exception e) { Plugin.L.LogWarning("[join] 情缘武功失败: " + e.Message); }
                int xx = kf % 100;
                try { inst.ApplyBuff(8500 + xx); } catch { }
                try { inst.ApplyBuff(8900 + xx); } catch { }
                try
                {
                    var tm2 = PlayerTeamManager.Instance;
                    var me = tm2 == null ? null : tm2.PlayerDataInstance;
                    if (me != null) me.ApplyBuff(8800 + xx);
                }
                catch { }
            }
            Plugin.L.LogInfo("[join] uid=" + uid + " 结缘完成：kungfu="
                             + (BondKungfu.ContainsKey(uid) ? BondKungfu[uid].ToString() : "无"));
        }

        // ---------------------------------------------------------------- 小工具
        private static string GiveName(GameCharacterInstance inst)
        {
            try { return "\"" + (inst.GivenName ?? "") + "\""; }
            catch { return "?"; }
        }
    }
}
