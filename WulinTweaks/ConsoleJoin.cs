using System;
using System.Collections.Generic;
using GameData;
using HarmonyLib;
using TMPro;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// 控制台指令：`join &lt;人物ID|人物名&gt; [1]`
    ///   `join 曲忘忧`    → 入队 + 解除陌生（初次见面=1、好感100、清陌生名）+ 可入家园
    ///   `join 曲忘忧 1`  → 再设为结缘（情缘武功 + 三件 buff）
    /// **静默**：不往控制台 / 聊天栏写任何文字（原来的 okTip / errorTip 全部去掉），
    /// 只留 BepInEx 日志用于排查。
    /// </summary>
    internal static class ConsoleJoin
    {
        private const string Cmd = "join";

        private static string _lastText;
        private static int _lastFrame = -1;
        private static int _diagLog;

        internal static bool IsOurs(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            string s = text.Trim();
            if (s.Length < Cmd.Length) return false;
            if (string.Compare(s, 0, Cmd, 0, Cmd.Length, StringComparison.OrdinalIgnoreCase) != 0) return false;
            return s.Length == Cmd.Length || char.IsWhiteSpace(s[Cmd.Length]);
        }

        /// <summary>同一帧里三个 Harmony 入口可能都被调用，只执行一次。</summary>
        internal static bool HandleOnce(string text)
        {
            string s = (text ?? "").Trim();
            int frame = -1;
            try { frame = UnityEngine.Time.frameCount; } catch { }
            if (frame >= 0 && frame == _lastFrame && string.Equals(s, _lastText, StringComparison.Ordinal))
                return true;
            _lastFrame = frame;
            _lastText = s;
            Handle(s);
            return true;
        }

        private static void Handle(string text)
        {
            try
            {
                string[] tk = text.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (tk.Length < 2)
                {
                    Plugin.L.LogInfo("[join] 用法：join <人物ID|人物名> [1]");
                    return;
                }

                string target = tk[1];
                bool bond = false;
                if (tk.Length >= 3)
                {
                    string last = tk[tk.Length - 1];
                    bond = last == "1" || last.Equals("true", StringComparison.OrdinalIgnoreCase);
                }

                int uid;
                string how;
                if (!Resolve(target, out uid, out how))
                {
                    Plugin.L.LogWarning("[join] 找不到目标：" + target);
                    return;
                }

                var inst = PartnerTools.Instance(uid);
                if (inst == null)
                {
                    Plugin.L.LogWarning("[join] uid=" + uid + " 实例不存在（还没被游戏创建）");
                    return;
                }

                bool revived = PartnerTools.ReviveIfDead(inst);

                bool joined = false;
                try
                {
                    var tm = PlayerTeamManager.Instance;
                    if (tm != null)
                    {
                        bool inTeam = tm.HasCharacterAsMember(inst, false);
                        if (!inTeam && tm.TeamSize < tm.MaxTeamSize)
                        {
                            tm.AddCharacter(inst);
                            joined = true;
                        }
                    }
                }
                catch (Exception e) { Plugin.L.LogWarning("[join] 入队失败: " + e.Message); }

                PartnerTools.Unstranger(inst);
                PartnerTools.FiefReady(inst);
                if (bond) PartnerTools.MakeBond(inst);

                Plugin.L.LogInfo("[join] " + text + " → uid=" + uid + "（" + how + "）"
                                 + "，复活=" + revived + "，本次入队=" + joined + "，结缘=" + bond);
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 执行异常: " + e); }
        }

        private static bool Resolve(string token, out int uid, out string how)
        {
            uid = 0;
            how = null;

            int n;
            if (int.TryParse(token, out n) && n > 0)
            {
                uid = n;
                how = "ID";
                return true;
            }

            try
            {
                var cfg = GameConfig.Instance;
                var pool = cfg == null ? null : cfg.CharacterPoolDataScriptObject;
                var arr = pool == null ? null : pool.CharacterPoolData;
                if (arr != null)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        var e = arr[i];
                        if (e == null) continue;
                        string full = (e.SurName ?? "") + (e.GivenName ?? "");
                        bool hit = string.Equals(e.UName, token, StringComparison.Ordinal)
                                   || (full.Length > 0 && string.Equals(full, token, StringComparison.Ordinal));
                        if (!hit) continue;
                        int id = e.Uid;
                        if (uid == 0 || id < uid) uid = id;      // 同名克隆里取最小 uid（真身是 100xx/200xx）
                    }
                    if (uid > 0) { how = "名字"; return true; }
                }
            }
            catch (Exception e) { Plugin.L.LogWarning("[join] 查名字失败: " + e.Message); }

            return false;
        }

        /// <summary>读 `ConsoleUI.textInput.text`。走强类型（interop 字段），反射只做兜底。</summary>
        internal static string TextOf(ConsoleUI ui)
        {
            if (ui == null) return null;
            try
            {
                TMP_InputField f = ui.textInput;
                if (f != null) return f.text;
            }
            catch (Exception e)
            {
                if (_diagLog++ < 3) Plugin.L.LogWarning("[join] 强类型读 textInput 失败: " + e.Message);
            }

            try
            {
                object f = Traverse.Create(ui).Field("textInput").GetValue();
                if (f == null) return null;
                var p = f.GetType().GetProperty("text");
                return p == null ? null : p.GetValue(f) as string;
            }
            catch { return null; }
        }

        internal static void ClearInput(ConsoleUI ui)
        {
            if (ui == null) return;
            try
            {
                TMP_InputField f = ui.textInput;
                if (f != null) { f.text = ""; return; }
            }
            catch { }

            try
            {
                object f = Traverse.Create(ui).Field("textInput").GetValue();
                if (f == null) return;
                var p = f.GetType().GetProperty("text");
                if (p != null && p.CanWrite) p.SetValue(f, "", null);
            }
            catch { }
        }

        /// <summary>诊断：拿到文本却不是我们要的命令时打一条（上限几条），只看不干预。</summary>
        internal static void Diag(string where, string text)
        {
            if (_diagLog >= 12) return;
            _diagLog++;
            Plugin.L.LogInfo("[join] 诊断 " + where + " text=" + (text == null ? "<null>" : "\"" + text + "\""));
        }
    }

    // ① 私有入口：Enter 键 / 按钮走这里（内部读 textInput.text 再分发）
    [HarmonyPatch(typeof(ConsoleUI), "InvokeCommandInternal")]
    internal static class Patch_ConsoleJoinInternal
    {
        private static bool Prefix(ConsoleUI __instance)
        {
            string text = ConsoleJoin.TextOf(__instance);
            if (!ConsoleJoin.IsOurs(text))
            {
                if (!string.IsNullOrEmpty(text)) ConsoleJoin.Diag("InvokeCommandInternal", text);
                return true;
            }
            try { ConsoleJoin.HandleOnce(text); ConsoleJoin.ClearInput(__instance); } catch { }
            return false;                     // 吞掉原版：不打印任何提示
        }
    }

    // ② 公开重载 InvokeCommand(string)：有的调用链直接走它
    [HarmonyPatch(typeof(ConsoleUI), "InvokeCommand", new[] { typeof(string) })]
    internal static class Patch_ConsoleJoinTyped
    {
        private static bool Prefix(ConsoleUI __instance, string command)
        {
            if (!ConsoleJoin.IsOurs(command))
            {
                if (!string.IsNullOrEmpty(command)) ConsoleJoin.Diag("InvokeCommand(string)", command);
                return true;
            }
            try { ConsoleJoin.HandleOnce(command); ConsoleJoin.ClearInput(__instance); } catch { }
            return false;
        }
    }

    // ③ 无参重载 InvokeCommand()：按钮点击可能走这条
    [HarmonyPatch(typeof(ConsoleUI), "InvokeCommand", new Type[0])]
    internal static class Patch_ConsoleJoinNoArg
    {
        private static bool Prefix(ConsoleUI __instance)
        {
            string text = ConsoleJoin.TextOf(__instance);
            if (!ConsoleJoin.IsOurs(text))
            {
                if (!string.IsNullOrEmpty(text)) ConsoleJoin.Diag("InvokeCommand()", text);
                return true;
            }
            try { ConsoleJoin.HandleOnce(text); ConsoleJoin.ClearInput(__instance); } catch { }
            return false;
        }
    }
}
