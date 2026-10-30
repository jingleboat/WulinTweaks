using System;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// v1.11.28：家园「可入」白名单 —— 每次进图/读档后自动补一遍。
    ///
    /// 为什么只能"补"而不能"写进存档"：
    ///   家园判定读的是 `CharacterTeamMemberExtendData`（`SerializedScriptableObject` 配置表），
    ///   `CouldBackToFief` 是这张表里的字段，**不属于任何 SaveObject** ——
    ///   16 个 Save0 的 .save 文件里 `couldBackToFief` 一次都不出现（实测扫过）。
    ///   所以它天生是内存态：改完当次有效，重启就没了。
    ///
    /// 用法：配置 `3_Story / FiefReadyList = 10142,10143`（逗号分隔的 uid）。
    /// 名字来源：`PartnerTools.FiefReady()` —— 已有行就置真，没有行就现补一行（AddData）。
    ///
    /// 触发时机：`MapLoaded`（MapManager.OnLoadMapComplated）之后。
    /// 角色实例还没建出来 / 还不是队友时不计失败，继续重试；尝试 60 次仍不齐就放弃并记日志。
    /// </summary>
    internal static class FiefAuto
    {
        private const int MaxTries = 60;

        private static int _state;      // 0 = 未做，1 = 做完，2 = 放弃
        private static int _tries;
        private static int[] _list;
        private static int _logs;

        /// <summary>换档时复位，让下一张图重来一遍。</summary>
        internal static void Reset()
        {
            _state = 0;
            _tries = 0;
            _list = null;
        }

        internal static void Tick()
        {
            if (Plugin.FiefReadyList == null) return;
            string raw = Plugin.FiefReadyList.Value;
            if (string.IsNullOrWhiteSpace(raw)) return;
            if (_state != 0) return;

            if (_list == null)
            {
                _list = Parse(raw);
                if (_list.Length == 0) { _state = 1; return; }
                if (_logs++ < 4)
                    Plugin.L.LogInfo("[fief] 白名单 " + _list.Length + " 个：" + string.Join(",", _list));
            }

            if (++_tries > MaxTries)
            {
                _state = 2;
                Plugin.L.LogWarning("[fief] 放弃：尝试 " + MaxTries + " 次仍有角色取不到实例（没入队？）");
                return;
            }

            int pending = 0, ok = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                int uid = _list[i];
                try
                {
                    GameCharacterInstance inst = PartnerTools.Instance(uid);
                    if (inst == null) { pending++; continue; }

                    // 只补"当过队友"的角色：没有 TeamMemberState 的还不能进家园，等它入队
                    TeamMemberState st = inst.TeamMemberState;
                    if (st == null) { pending++; continue; }

                    PartnerTools.FiefReady(inst);
                    ok++;
                }
                catch (Exception e)
                {
                    pending++;
                    if (_logs++ < 6) Plugin.L.LogWarning("[fief] uid=" + uid + " 失败: " + e.Message);
                }
            }

            if (pending == 0)
            {
                _state = 1;
                Plugin.L.LogInfo("[fief] 家园可入补完：" + ok + "/" + _list.Length);
            }
        }

        private static int[] Parse(string raw)
        {
            var parts = raw.Split(new[] { ',', '，', ' ', ';', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var buf = new System.Collections.Generic.List<int>(parts.Length);
            foreach (string p in parts)
            {
                int v;
                if (int.TryParse(p.Trim(), out v) && v > 0 && !buf.Contains(v)) buf.Add(v);
            }
            return buf.ToArray();
        }
    }
}
