using System;

namespace WulinTweaks
{
    /// <summary>
    /// 「放宽过谁」的登记表 —— **只登记，不改名**。
    ///
    /// === 为什么不改名了 ===
    /// 1.11.40 起临时改名（把模板真名写进实例 → 收尾再还原）整体停用：
    /// 那套既是"只显示姓""称号·姓名拼重复"一类脏数据的来源，也没必要 ——
    /// 现在「显示真名」只有一条路：
    ///     Unstranger 把实例的 m_givenName 置空
    ///     → get_IsUsingStangerName 随之变 false（它判的就是 m_givenName 是否以 '@' 开头）
    ///     → 显示层走「熟悉」分支
    ///     → 游戏自己从模板取真名
    ///
    /// === 那这张表还留着做什么 ===
    /// 只为一件事：`Unstranger.OnPlay(graph)` 需要知道「本图被放宽过哪些 uid」，
    /// 好在剧情**真正开播**时强制补清一遍。
    /// 因为放宽判定常常远早于角色实例化（那时 GetCharacter 返回 null，清不了），
    /// 而「每图只放宽一次」不给我们第二次机会。
    ///
    /// 表里的窗口只是"这个名字还算活跃"的有效期，过期自然被覆盖，不涉及任何写回。
    /// </summary>
    internal static class RelaxName
    {
        private const long WinMs = 90000;        // 槽位登记有效期（放宽命中时刷新）
        private const int SlotCount = 24;

        private sealed class Slot
        {
            public int Uid;
            public string Graph;      // 这个窗口是从哪张剧情图记下来的
            public long Until;        // 有效期
        }

        private static readonly Slot[] Slots = new Slot[SlotCount];
        private static int _logWarn;

        private static long Now => Environment.TickCount64;

        private static Slot Find(int uid)
        {
            if (uid <= 0) return null;
            for (int i = 0; i < SlotCount; i++)
                if (Slots[i] != null && Slots[i].Uid == uid) return Slots[i];
            return null;
        }

        private static Slot Alloc(int uid)
        {
            var s = Find(uid);
            if (s != null) return s;
            for (int i = 0; i < SlotCount; i++)
                if (Slots[i] == null) { Slots[i] = new Slot { Uid = uid }; return Slots[i]; }

            // 满了：挤掉最早过期的那个。不还原、不回写 —— 这里已经不碰名字了。
            int worst = 0;
            for (int i = 1; i < SlotCount; i++)
                if (Slots[i].Until < Slots[worst].Until) worst = i;
            Slots[worst] = new Slot { Uid = uid };
            return Slots[worst];
        }

        /// <summary>放宽命中：登记这个 uid 属于哪张图。</summary>
        internal static void MarkRelaxed(int uid, string graph)
        {
            if (uid <= 0) return;
            if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value) return;
            try
            {
                var s = Alloc(uid);
                if (!string.IsNullOrEmpty(graph)) s.Graph = graph;
                s.Until = Now + WinMs;
            }
            catch (Exception e) { if (_logWarn++ < 10) Plugin.L.LogWarning("[name] mark 异常: " + e.Message); }
        }

        /// <summary>本图被放宽过的 uid 列表 —— 供 Unstranger.OnPlay 在开播时强制补清。</summary>
        internal static int[] UidsOfGraph(string graph)
        {
            if (string.IsNullOrEmpty(graph)) return Array.Empty<int>();
            var list = new System.Collections.Generic.List<int>(8);
            for (int i = 0; i < SlotCount; i++)
            {
                var s = Slots[i];
                if (s == null || s.Uid <= 0) continue;
                if (s.Graph == null || !string.Equals(s.Graph, graph, StringComparison.Ordinal)) continue;
                if (!list.Contains(s.Uid)) list.Add(s.Uid);
            }
            return list.ToArray();
        }

        /// <summary>
        /// 这个 uid 在这张图里，是不是**被我们放宽过**？
        ///
        /// 用途：门通过时清名要"只清我们自己造成的通过" —— 原版本来就满足条件的门不该被碰。
        /// 放宽命中时 Dispatch 会 MarkRelaxed(pid, graph)，所以这里查得到就说明"这次是 mod 放它过去的"。
        /// </summary>
        internal static bool WasRelaxed(string graph, int uid)
        {
            if (uid <= 0 || string.IsNullOrEmpty(graph)) return false;
            for (int i = 0; i < SlotCount; i++)
            {
                var s = Slots[i];
                if (s == null || s.Uid != uid) continue;
                if (s.Graph != null && string.Equals(s.Graph, graph, StringComparison.Ordinal)) return true;
            }
            return false;
        }

        /// <summary>
        /// 读档完成 / 换图：**只丢弃槽位**。
        /// 旧实例在读档时已经作废，往它的地址写东西就是写野指针（v90/v91 那类事故），
        /// 所以这里连"还原"都不做 —— 本来也没改过名。
        /// </summary>
        internal static void DropAll()
        {
            for (int i = 0; i < SlotCount; i++) Slots[i] = null;
        }
    }
}
