using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// ④ 易物（TradingWithNpc）。
    ///
    /// 反汇编 GameAssembly.dll 得到的真实流程（RVA 为 PC 版）：
    ///   StartTrading 0x8C35E0 → 新建两个交易区 GameItemPack，npc = 目标，最后 TradingWithNpcUI.Init()
    ///   Init 0x8C4440         → npcBackPack.ShowPack(npc.BackPack) / playerTrading / npcTrading
    ///   MoveItem 0x8C4B00     → 源包按 PackType 写死，不看物品在哪个包：
    ///        Player(0)  TeamInventory → playerTradingZone
    ///        Npc(1)     npc.BackPack  → npcTradingZone
    ///        PlayerTrading(2) playerTradingZone → TeamInventory
    ///        NpcTrading(3)    npcTradingZone    → npc.BackPack
    ///   ConfirmTrading 0x8C3100 两道门槛：
    ///        ① ValueOffset() &lt; 0 → 放弃            (0x8C322C test/js)
    ///        ② playerTradingZone.GetTotalValue() &lt;= 0 → 放弃 (0x8C32C5 test/jle)
    ///        通过后：npcTradingZone.MergeInto(TeamInventory)、playerTradingZone.MergeInto(npc.BackPack)
    ///   CancelTrading 0x8C2CD0 → 两个区分别退回 npc.BackPack / TeamInventory，然后关面板
    ///
    /// ⚠ 搬运物品必须「新建实例再删原件」：
    ///   GameItemPack.RemoveItem 反汇编（0x71E870~0x71E877）显示它先做
    ///       gii.Stack -= count        ← 直接改原实例
    ///   再在 Stack &lt;= 0 时把它从 Contents 里移除。
    ///   而 AddItem / AddItemAsIndependent 都以 Stack &gt; 0 为前置条件（0x71AA42），
    ///   所以「同一个实例加进另一个包、再从原包删掉」会让两边都变成空壳。
    ///
    /// ⚠ 搬运必须用 AddItem（可堆叠物品会按 ItemData 合并），**不能用 AddItemAsIndependent**：
    ///   后者只做 Contents.Add，同一种可堆叠物品搬几次就成几堆
    ///   （易物「搬空」后队伍背包里金疮药分三四堆的根因）。AddItemAsIndependent
    ///   只留给「NPC 背包里没有同类、必须按实例删掉的显示副本」。
    ///
    /// ⚠ 「读取池子」只做副本，绝不写 stealBackPack / dropOnDeadBackPack：
    ///   NPC 的这两个包是暗取（StealManager.OnStealSuccess 读 [char+0x150]）和死亡掉落的数据源，
    ///   往里写东西等于同时改了暗取与掉落。这里只把内容复制进 npc.BackPack 供易物面板显示，
    ///   两个池子本身一个字节都不动。
    /// </summary>
    internal static class TradeKit
    {
        /// <summary>为易物显示而复制进 NPC 背包的副本；交易结束（未拿走）要删掉。
        /// Merged=false：独立实例，按实例删/记账；
        /// Merged=true ：NPC 背包本来就有同 ID 的堆，副本合并进去了，按数量删/记账
        ///               （独立堆能按实例删，但会在面板里变成两个同 ID 堆；合并 + 数量记账
        ///                才能既不拆堆、又不让池子里的东西漏掉）。</summary>
        private sealed class PoolCopy
        {
            public GameItemInstance Copy;
            public int Id;
            public bool Drop;
            public string Label;
            /// <summary>造副本时的数量（Merged=true 时是「实际加进去的数量」），用来算玩家拿走了几个</summary>
            public int Stack0;
            public bool Merged;
            /// <summary>合并前那一堆的数量：撤副本时只撤我们加的部分，绝不碰 NPC 原货</summary>
            public int Npc0;
        }

        private static readonly List<PoolCopy> _copies = new List<PoolCopy>();

        private static GameCharacterInstance _npc;
        private static IntPtr _playerZonePtr = IntPtr.Zero;

        internal static bool Truthy(Il2CppObjectBase o)
        {
            return o != null && o.Pointer != IntPtr.Zero;
        }

        private static GameItemPack TeamInventory()
        {
            try
            {
                if (!PlayerTeamManager.HasInstance) return null;
                var ptm = PlayerTeamManager.Instance;
                if (!Truthy(ptm)) return null;
                return ptm.TeamInventory;
            }
            catch (Exception e) { ModKit.Err("trade teamInv", e); }
            return null;
        }

        private static List<GameItemInstance> Snapshot(GameItemPack pack)
        {
            var outp = new List<GameItemInstance>();
            if (!Truthy(pack)) return outp;
            try
            {
                var c = pack.Contents;
                if (c == null) return outp;
                int n = c.Count;
                for (int i = 0; i < n; i++)
                {
                    GameItemInstance it;
                    try { it = c[i]; }
                    catch { continue; }
                    if (Truthy(it)) outp.Add(it);
                }
            }
            catch (Exception e) { ModKit.Err("trade snapshot", e); }
            return outp;
        }

        /// <summary>只数「真货」：Stack &gt; 0</summary>
        private static int CountValid(GameItemPack pack)
        {
            if (!Truthy(pack)) return -1;
            int n = 0;
            foreach (var it in Snapshot(pack))
            {
                try { if (it.Stack > 0) n++; }
                catch { }
            }
            return n;
        }

        /// <summary>清掉 Stack&lt;=0 的空壳条目</summary>
        internal static int PurgeInvalid(GameItemPack pack)
        {
            if (!Truthy(pack)) return 0;
            int n = 0;
            foreach (var it in Snapshot(pack))
            {
                try
                {
                    if (it.Stack > 0 && it.IsValid) continue;
                    if (pack.RemoveItem(it, 1)) n++;
                    else if (pack.RemoveItem(it, 0)) n++;
                }
                catch { }
            }
            return n;
        }

        /// <summary>复制成新实例（独立 Stack），失败返回 null。
        /// craftLevel 必须传 0：传 -1 会让 CreateForgeModify 给可锻造装备滚一份随机附加属性，
        /// 搬一次物品属性就变；原件本来就带 ItemModifyData 就直接共用同一份。</summary>
        private static GameItemInstance Clone(GameItemInstance it)
        {
            try
            {
                int stack = it.Stack;
                if (stack <= 0) return null;
                int id = it.TempleteId;
                if (id <= 0) return null;

                var c = new GameItemInstance(id, stack, 0);
                if (c == null || c.Stack <= 0) return null;
                if (!c.IsValid) return null;
                try
                {
                    var md = it.modifyData;
                    if (md != null) c.modifyData = md;
                }
                catch { }
                return c;
            }
            catch (Exception e) { ModKit.Err("trade clone", e); }
            return null;
        }

        /// <summary>目标包里同 ID 的活堆（找不到返回 null）；顺带带出它的数量</summary>
        private static GameItemInstance FindId(GameItemPack pack, int id, out int stack)
        {
            stack = 0;
            if (!Truthy(pack) || id <= 0) return null;
            foreach (var it in Snapshot(pack))
            {
                try
                {
                    if (!Truthy(it) || it.Stack <= 0 || it.TempleteId != id) continue;
                    stack = it.Stack;
                    return it;
                }
                catch { }
            }
            return null;
        }

        /// <summary>src → dst：新实例进 dst，再删 src 原件。
        /// **必须用 AddItem（会按 ItemData 合并）**；AddItemAsIndependent 只做 contents.Add，
        /// 同一种可堆叠物品搬几次就成几堆（易物「搬空」后队伍背包里金疮药分三四堆的根因）。
        /// 顺序上先扣源再合并写目标：合并写入后拿不到目标里那一堆，没法按实例回滚。</summary>
        private static int Transfer(GameItemPack src, GameItemPack dst)
        {
            if (!Truthy(src) || !Truthy(dst) || src.Pointer == dst.Pointer) return 0;
            int n = 0, skipped = 0;
            foreach (var it in Snapshot(src))
            {
                try
                {
                    int stack = it.Stack;
                    if (stack <= 0) { skipped++; continue; }

                    var c = Clone(it);
                    if (c == null) { skipped++; continue; }

                    if (!src.RemoveItem(it, stack))
                    {
                        skipped++;
                        continue;
                    }
                    if (dst.AddItem(c, false)) { n++; continue; }

                    // 目标加不进去（极端情况）→ 把原件数量还原后塞回源
                    try { it.ChangeStack(stack); src.AddItem(it, false); } catch { }
                    skipped++;
                }
                catch (Exception e) { ModKit.Err("trade transfer", e); }
            }
            if (skipped > 0)
                Plugin.L.LogWarning("[WulinTweaks] trade: transfer skipped " + skipped + " (stack<=0 / invalid)");
            return n;
        }

        /// <summary>把包里同 ID 的可堆叠物堆并回一堆 —— 修复旧版本已经拆开的存档。
        /// 只动 IsStackable 条目（同 ItemData、无 ItemModifyData），数量一分不差。</summary>
        internal static int MergeDupPiles(GameItemPack pack)
        {
            if (!Truthy(pack)) return 0;
            int merged = 0;
            for (int round = 0; round < 64; round++)
            {
                var list = Snapshot(pack);
                if (list.Count < 2) break;
                bool hit = false;
                for (int i = 0; i < list.Count && !hit; i++)
                {
                    GameItemInstance a = list[i];
                    int ta;
                    try
                    {
                        if (!Truthy(a) || a.Stack <= 0 || !a.IsStackable) continue;
                        ta = a.TempleteId;
                    }
                    catch { continue; }
                    if (ta <= 0) continue;

                    for (int j = i + 1; j < list.Count; j++)
                    {
                        try
                        {
                            var b = list[j];
                            if (!Truthy(b) || b.Pointer == a.Pointer) continue;
                            if (b.TempleteId != ta || b.Stack <= 0) continue;
                            int add = b.Stack;
                            if (!a.ChangeStack(add)) break;
                            if (pack.RemoveItem(b, add)) merged++;
                            hit = true;
                            Plugin.L.LogInfo("[WulinTweaks] trade: merged duplicate pile "
                                + add + " x id=" + ta);
                            break;
                        }
                        catch { }
                    }
                }
                if (!hit) break;
            }
            return merged;
        }

        /// <summary>体检：包里是否还有「同 ID 多堆」</summary>
        private static void LogDupPiles(string tag, GameItemPack pack)
        {
            if (!Truthy(pack)) return;
            var list = Snapshot(pack);
            int bad = 0;
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                int ta;
                try
                {
                    var a = list[i];
                    if (!Truthy(a) || a.Stack <= 0) continue;
                    ta = a.TempleteId;
                }
                catch { continue; }
                if (ta <= 0) continue;

                bool first = true;
                for (int k = 0; k < i; k++)
                {
                    try
                    {
                        var p = list[k];
                        if (Truthy(p) && p.Stack > 0 && p.TempleteId == ta) { first = false; break; }
                    }
                    catch { }
                }
                if (!first) continue;

                int cnt = 0;
                foreach (var b in list)
                {
                    try { if (Truthy(b) && b.Stack > 0 && b.TempleteId == ta) cnt++; }
                    catch { }
                }
                if (cnt > 1) { bad++; sb.Append(' ').Append(ta).Append('x').Append(cnt); }
            }
            if (bad > 0) Plugin.L.LogInfo("[WulinTweaks] trade: " + tag + " dup-id piles " + bad + " kinds:" + sb);
            else Plugin.L.LogInfo("[WulinTweaks] trade: " + tag + " no dup-id piles (" + list.Count + " entries)");
        }

        // ---------- 「易物拿走过」台账（持久化，防止同一件东西被易物无限复制） ----------

        private static readonly HashSet<string> _ledger = new HashSet<string>();
        private static bool _ledgerLoaded;
        private static string _ledgerPath;

        /// <summary>键：TempleteUid:InstanceId:池:物品id —— 只记「被易物拿走过」的那些</summary>
        private static string CopyKey(GameCharacterInstance npc, bool drop, int itemId)
        {
            try
            {
                return npc.TempleteUid + ":" + npc.InstanceId + (drop ? ":d:" : ":s:") + itemId;
            }
            catch { return null; }
        }

        private static bool TakenBefore(GameCharacterInstance npc, bool drop, int itemId)
        {
            EnsureLedgerLoaded();
            var k = CopyKey(npc, drop, itemId);
            return k != null && _ledger.Contains(k);
        }

        private static void MarkTaken(GameCharacterInstance npc, bool drop, int itemId)
        {
            EnsureLedgerLoaded();
            var k = CopyKey(npc, drop, itemId);
            if (k == null) return;
            try
            {
                if (!_ledger.Add(k)) return;
                if (_ledgerPath == null) return;
                System.IO.File.WriteAllLines(_ledgerPath, new List<string>(_ledger));
            }
            catch (Exception e) { ModKit.Err("ledger save", e); }
        }

        private static void EnsureLedgerLoaded()
        {
            if (_ledgerLoaded) return;
            _ledgerLoaded = true;
            try
            {
                _ledgerPath = System.IO.Path.Combine(Plugin.DataDir, "trade-taken.txt");
                if (System.IO.File.Exists(_ledgerPath))
                {
                    foreach (var line in System.IO.File.ReadAllLines(_ledgerPath))
                    {
                        var s = line == null ? "" : line.Trim();
                        if (s.Length > 0 && !s.StartsWith("#")) _ledger.Add(s);
                    }
                }
                Plugin.L.LogInfo("[WulinTweaks] taken ledger: " + _ledger.Count + " entries @ " + _ledgerPath);
            }
            catch (Exception e) { ModKit.Err("ledger load", e); }
        }

        // ---------- 往 NPC 背包造「只给易物看」的副本 ----------

        /// <summary>把池子里现有的实物复制一份进背包（池子本身不动）</summary>
        private static int CopyFromPool(GameItemPack src, GameItemPack dst,
                                        GameCharacterInstance npc, bool drop, HashSet<int> seen)
        {
            if (!Truthy(src) || !Truthy(dst) || src.Pointer == dst.Pointer) return 0;
            string tag = drop ? "dropPool" : "stealPool";
            int n = 0;
            foreach (var it in Snapshot(src))
            {
                try
                {
                    int id = it.TempleteId;
                    if (id <= 0 || it.Stack <= 0) continue;
                    if (seen != null && seen.Contains(id)) continue;
                    if (TakenBefore(npc, drop, id)) continue;      // 之前已被易物拿走过

                    var c = Clone(it);
                    if (c == null) continue;
                    int st0;
                    try { st0 = c.Stack; } catch { st0 = it.Stack; }

                    // NPC 背包已有同 ID 的堆 → 合并进去（面板不出现两个同 ID 堆），按数量记账
                    int npc0;
                    var pile = FindId(dst, id, out npc0);
                    if (Truthy(pile))
                    {
                        if (!dst.AddItem(c, false)) continue;
                        int now = 0;
                        try { now = pile.Stack; } catch { }
                        int added = now - npc0;
                        if (added <= 0) continue;
                        if (seen != null) seen.Add(id);
                        _copies.Add(new PoolCopy
                        {
                            Copy = pile, Id = id, Drop = drop, Label = tag,
                            Stack0 = added, Merged = true, Npc0 = npc0
                        });
                        Plugin.L.LogInfo("[WulinTweaks] trade: " + tag + "#" + id
                            + " x" + st0 + " merged into bag pile " + npc0 + " -> " + now);
                        n++;
                        continue;
                    }

                    if (!dst.AddItemAsIndependent(c)) continue;

                    if (seen != null) seen.Add(id);
                    _copies.Add(new PoolCopy { Copy = c, Id = id, Drop = drop, Label = tag, Stack0 = st0 });
                    n++;
                }
                catch (Exception e) { ModKit.Err("trade copy pool", e); }
            }
            return n;
        }

        /// <summary>
        /// 池子里没有、但 NPC 模板里有的条目 → 直接造副本进背包。
        /// 不能调游戏自己的 ImportItemsFromTempleteData（反汇编 0x71DF50 会静默跳过取不到的条目，
        /// 实测补出 0 件），这里自己按 KeyWithValues 的 key/values 建。
        /// </summary>
        private static int CopyFromTemplate(GameItemPack dst, GameCharacterInstance npc,
                                            bool drop, HashSet<int> seen)
        {
            if (!Truthy(dst) || !Truthy(npc)) return 0;
            string tag = drop ? "tplDrop" : "tplSteal";

            int len;
            try
            {
                var t = npc.Templete;
                if (t == null) return 0;
                var a = drop ? t.ItemsDropOnKill : t.StealPool;
                if (a == null) return 0;
                len = a.Length;
            }
            catch (Exception e) { ModKit.Err("trade tpl read", e); return 0; }
            if (len <= 0) return 0;

            int n = 0;
            for (int i = 0; i < len; i++)
            {
                try
                {
                    KeyWithValues kvw;
                    try
                    {
                        var t2 = npc.Templete;
                        var a2 = drop ? t2.ItemsDropOnKill : t2.StealPool;
                        kvw = a2[i];
                    }
                    catch (Exception e) { ModKit.Err("trade tpl entry", e); continue; }
                    if (kvw == null) continue;

                    string k = null;
                    int cnt = 1;
                    try { k = kvw.key; } catch { }
                    try
                    {
                        var vs = kvw.values;
                        if (vs != null && vs.Count > 0) cnt = vs[0];
                    }
                    catch { }
                    if (cnt <= 0) cnt = 1;
                    if (string.IsNullOrEmpty(k)) continue;

                    var gii = new GameItemInstance(k, cnt, -1);
                    if (gii == null || !gii.IsValid || gii.Stack <= 0)
                    {
                        Plugin.L.LogWarning("[WulinTweaks] trade: " + tag + "#" + i
                            + " key=" + k + " cnt=" + cnt + " -> unresolved");
                        continue;
                    }

                    int id = gii.TempleteId;
                    if (seen != null && seen.Contains(id)) continue;
                    if (TakenBefore(npc, drop, id)) continue;

                    int st0 = gii.Stack;
                    int npc0;
                    var pile = FindId(dst, id, out npc0);
                    if (Truthy(pile))
                    {
                        if (!dst.AddItem(gii, false)) continue;
                        int now = 0;
                        try { now = pile.Stack; } catch { }
                        int added = now - npc0;
                        if (added <= 0) continue;
                        if (seen != null) seen.Add(id);
                        _copies.Add(new PoolCopy
                        {
                            Copy = pile, Id = id, Drop = drop, Label = tag,
                            Stack0 = added, Merged = true, Npc0 = npc0
                        });
                        Plugin.L.LogInfo("[WulinTweaks] trade: " + tag + "#" + i + " key=" + k
                            + " merged into bag pile " + npc0 + " -> " + now);
                        n++;
                        continue;
                    }
                    if (!dst.AddItemAsIndependent(gii)) continue;
                    if (seen != null) seen.Add(id);
                    _copies.Add(new PoolCopy { Copy = gii, Id = id, Drop = drop, Label = tag, Stack0 = st0 });
                    n++;
                    Plugin.L.LogInfo("[WulinTweaks] trade: " + tag + "#" + i + " key=" + k
                        + " cnt=" + cnt + " -> " + gii.ItemName);
                }
                catch (Exception e) { ModKit.Err("trade tpl item", e); }
            }
            return n;
        }

        private static int TplLen(GameCharacterInstance npc, bool drop)
        {
            try
            {
                var t = npc.Templete;
                if (t == null) return -1;
                var arr = drop ? t.ItemsDropOnKill : t.StealPool;
                return arr == null ? -1 : arr.Length;
            }
            catch { return -9; }
        }

        /// <summary>
        /// StartTrading 之前：上一次若是异常关闭（没走 Cancel/Confirm），
        /// 交易区里还剩东西，而 StartTrading 会把两个区换成新的空包 —— 先把残余退回去。
        /// </summary>
        internal static void BeforeTradingStart()
        {
            try
            {
                var oldNpc = TradingWithNpcManager.npc;
                GameItemPack bp = null;
                if (Truthy(oldNpc))
                {
                    try { bp = oldNpc.BackPack; } catch { }
                }

                var nz = TradingWithNpcManager.npcTradingZone;
                if (Truthy(nz))
                {
                    int ghost = PurgeInvalid(nz);
                    if (ghost > 0)
                        Plugin.L.LogWarning("[WulinTweaks] trade: purged " + ghost + " empty entries in stale npc zone");
                    if (Truthy(bp) && CountValid(nz) > 0)
                    {
                        int n = Transfer(nz, bp);
                        Plugin.L.LogWarning("[WulinTweaks] trade: stale npc zone -> npc bag " + n);
                    }
                }

                var pz = TradingWithNpcManager.playerTradingZone;
                if (Truthy(pz))
                {
                    int ghost = PurgeInvalid(pz);
                    if (ghost > 0)
                        Plugin.L.LogWarning("[WulinTweaks] trade: purged " + ghost + " empty entries in stale player zone");
                    var inv = TeamInventory();
                    if (Truthy(inv) && CountValid(pz) > 0)
                    {
                        int n = Transfer(pz, inv);
                        Plugin.L.LogWarning("[WulinTweaks] trade: stale player zone -> team inv " + n);
                    }
                }
            }
            catch (Exception e) { ModKit.Err("trade stale cleanup", e); }

            CleanupCopies();
        }

        /// <summary>StartTrading 之后：往 NPC 背包放一份「池子内容 + 模板条目」的副本，只给易物看</summary>
        internal static void OnTradingStarted()
        {
            try
            {
                if (_copies.Count > 0) CleanupCopies();

                _playerZonePtr = IntPtr.Zero;
                try
                {
                    var pz0 = TradingWithNpcManager.playerTradingZone;
                    if (Truthy(pz0)) _playerZonePtr = pz0.Pointer;
                }
                catch { }

                // 顺手把老存档里被拆开的同类堆并回去（与池子开关无关）
                try
                {
                    int fixedInv = MergeDupPiles(TeamInventory());
                    if (fixedInv > 0)
                    {
                        Plugin.L.LogInfo("[WulinTweaks] trade: merged " + fixedInv
                            + " duplicate piles in team inventory");
                        Refresh();
                    }
                    int fixedBag = MergeDupPiles(TradingWithNpcManager.npc != null
                        ? TradingWithNpcManager.npc.BackPack : null);
                    if (fixedBag > 0)
                        Plugin.L.LogInfo("[WulinTweaks] trade: merged " + fixedBag
                            + " duplicate piles in npc bag");
                }
                catch (Exception e) { ModKit.Err("trade merge dup", e); }

                if (!Plugin.TradePools.Value) return;

                var npc = TradingWithNpcManager.npc;
                if (!Truthy(npc)) return;
                _npc = npc;

                GameItemPack bp = null;
                try { bp = npc.BackPack; }
                catch (Exception e) { ModKit.Err("trade backpack", e); }
                if (!Truthy(bp)) return;

                int purged = PurgeInvalid(bp);
                if (purged > 0)
                    Plugin.L.LogInfo("[WulinTweaks] trade: purged " + purged + " empty entries in npc bag");

                int before = CountValid(bp);

                string npcName = "?";
                try { npcName = npc.TempleteName; } catch { }

                GameItemPack drop = null, steal = null;
                try { drop = npc.DropOnDeadBackPack; }
                catch (Exception e) { ModKit.Err("trade dropPool", e); }
                try { steal = npc.StealBackPack; }
                catch (Exception e) { ModKit.Err("trade stealPool", e); }

                Plugin.L.LogInfo("[WulinTweaks] trade: npc=" + npcName
                    + " bag=" + before
                    + " dropPool=" + CountValid(drop) + " stealPool=" + CountValid(steal)
                    + " tplDrop=" + TplLen(npc, true) + " tplSteal=" + TplLen(npc, false));

                var seen = new HashSet<int>();
                int a = CopyFromPool(drop, bp, npc, true, seen);
                int b = CopyFromPool(steal, bp, npc, false, seen);
                int c = CopyFromTemplate(bp, npc, true, seen);
                int d = CopyFromTemplate(bp, npc, false, seen);

                if (a + b + c + d > 0)
                    Plugin.L.LogInfo("[WulinTweaks] trade: copies (display only, pools untouched)"
                        + " fromDrop=" + a + " fromSteal=" + b + " tplDrop=" + c + " tplSteal=" + d);

                Refresh();
                Plugin.L.LogInfo("[WulinTweaks] trade start: npc bag " + before + " -> " + CountValid(bp));
            }
            catch (Exception e) { ModKit.Err("trade start", e); }
        }

        /// <summary>
        /// ConfirmTrading 之后：把交易区残留 + NPC 背包剩余全部搬进队伍背包。
        /// 玩家交易区的东西也一并退回，等于玩家不付出任何东西。
        /// </summary>
        internal static void AfterConfirm()
        {
            try
            {
                if (!Plugin.TradeTakeAll.Value) { CleanupCopies(); return; }

                var inv = TeamInventory();
                if (!Truthy(inv))
                {
                    Plugin.L.LogWarning("[WulinTweaks] trade: take-all skipped, no team inventory");
                    CleanupCopies();
                    return;
                }

                int invBefore = CountValid(inv);

                GameItemPack pz = null, nz = null;
                try { pz = TradingWithNpcManager.playerTradingZone; } catch { }
                try { nz = TradingWithNpcManager.npcTradingZone; } catch { }

                PurgeInvalid(pz);
                PurgeInvalid(nz);

                int a = Transfer(pz, inv);          // 玩家交易区残留（正常应已被原版退回）
                int b = Transfer(nz, inv);          // NPC 交易区残留
                int c = 0;
                GameItemPack npcBag = null;
                if (Truthy(_npc))
                {
                    try { npcBag = _npc.BackPack; } catch { }
                    if (Truthy(npcBag))
                    {
                        PurgeInvalid(npcBag);
                        c = Transfer(npcBag, inv);  // NPC 背包剩下的全拿走
                    }
                }

                // 副本被拿走 → 记账，之后不再给这个 NPC 造同一件副本（否则可无限复制）
                int marked = MarkTakenCopies(npcBag);

                int invAfter = CountValid(inv);
                Plugin.L.LogInfo("[WulinTweaks] trade: TAKE ALL zoneP=" + a + " zoneN=" + b
                    + " npcBag=" + c + " takenMarked=" + marked
                    + " | team inv " + invBefore + " -> " + invAfter
                    + (invAfter > invBefore ? "  OK" : "  <<< NOTHING ARRIVED"));
                if (invAfter <= invBefore && a + b + c == 0)
                    Plugin.L.LogWarning("[WulinTweaks] trade: nothing to move "
                        + "(zones and npc bag all empty)");

                int fixedAfter = MergeDupPiles(inv);
                if (fixedAfter > 0)
                    Plugin.L.LogInfo("[WulinTweaks] trade: merged " + fixedAfter
                        + " duplicate piles in team inventory");
                LogDupPiles("team inv", inv);

                Refresh();
                _copies.Clear();
                _npc = null;
                _playerZonePtr = IntPtr.Zero;
            }
            catch (Exception e) { ModKit.Err("trade takeall", e); }
        }

        /// <summary>
        /// 从池子原件里扣掉 count 个 itemId。
        /// 易物拿走的是「副本」，而暗取（StealManager 读 npc.stealBackPack）和摸尸读的是
        /// 池子原件；不扣的话同一件东西还能被暗取再偷一次。返回实际扣掉的数量。
        /// </summary>
        private static int PoolDeduct(GameCharacterInstance npc, bool drop, int itemId, int count)
        {
            if (!Truthy(npc) || itemId <= 0 || count <= 0) return 0;
            GameItemPack pool;
            try { pool = drop ? npc.DropOnDeadBackPack : npc.StealBackPack; }
            catch (Exception e) { ModKit.Err("trade pool get", e); return 0; }
            if (!Truthy(pool)) return 0;

            foreach (var it in Snapshot(pool))
            {
                try
                {
                    if (it.TempleteId != itemId || it.Stack <= 0) continue;
                    int take = count < it.Stack ? count : it.Stack;
                    if (!pool.RemoveItem(it, take)) return 0;
                    return take;
                }
                catch (Exception e) { ModKit.Err("trade pool deduct", e); return 0; }
            }
            return 0;
        }

        /// <summary>池子里这个物品 ID 还剩多少（物理实物）</summary>
        private static int PoolRemaining(GameCharacterInstance npc, bool drop, int itemId)
        {
            if (!Truthy(npc) || itemId <= 0) return 0;
            GameItemPack pool;
            try { pool = drop ? npc.DropOnDeadBackPack : npc.StealBackPack; }
            catch { return 0; }
            if (!Truthy(pool)) return 0;
            int sum = 0;
            foreach (var it in Snapshot(pool))
            {
                try { if (Truthy(it) && it.Stack > 0 && it.TempleteId == itemId) sum += it.Stack; }
                catch { }
            }
            return sum;
        }

        /// <summary>已被搬走的副本 → 记进台账，并把池子原件按拿走数量扣掉</summary>
        private static int MarkTakenCopies(GameItemPack bag)
        {
            if (_copies.Count == 0 || !Truthy(_npc)) return 0;

            var present = new HashSet<IntPtr>();
            foreach (var it in Snapshot(bag))
            {
                try { present.Add(it.Pointer); } catch { }
            }

            int marked = 0;
            foreach (var rec in _copies)
            {
                try
                {
                    if (!Truthy(rec.Copy)) continue;
                    bool stillInBag = present.Contains(rec.Copy.Pointer);
                    int cur = 0;
                    try { cur = rec.Copy.Stack; } catch { }
                    int left = stillInBag && cur > 0 ? cur : 0;
                    int took;
                    if (rec.Merged)
                    {
                        /* 合并形态：拿走量 = (背包原数量 + 副本量) - 剩余，再按副本量截断
                         * （超出部分算玩家拿的是 NPC 原货，不影响池子）。 */
                        took = rec.Npc0 + rec.Stack0 - left;
                        if (took < 0) took = 0;
                        if (took > rec.Stack0) took = rec.Stack0;
                    }
                    else
                    {
                        took = rec.Stack0 - left;
                    }
                    if (took <= 0) continue;                 // 还在背包里 = 玩家没要

                    int got = PoolDeduct(_npc, rec.Drop, rec.Id, took);
                    // 台账只在「池子里这件被扣干」时才记：只拿一部分的话下次开面板还能补剩下的；
                    // 模板条目没有实物可扣（remain=0）→ 仍然一次记掉，避免无实物却无限生成。
                    int remain = PoolRemaining(_npc, rec.Drop, rec.Id);
                    bool markOk = remain <= 0;
                    if (markOk) MarkTaken(_npc, rec.Drop, rec.Id);
                    if (markOk) marked++;
                    Plugin.L.LogInfo("[WulinTweaks] trade pool: " + rec.Label + " id=" + rec.Id
                        + " took=" + took + " deducted=" + got + " remain=" + remain
                        + (markOk ? " ledger+1" : ""));
                }
                catch (Exception e) { ModKit.Err("trade mark taken", e); }
            }
            return marked;
        }

        /// <summary>取消之后：把「为显示而复制」的副本从 NPC 背包删掉（池子原件不动）</summary>
        internal static void CleanupCopies()
        {
            try
            {
                if (_copies.Count == 0) { _npc = null; return; }

                GameItemPack bp = null;
                if (Truthy(_npc))
                {
                    try { bp = _npc.BackPack; }
                    catch (Exception e) { ModKit.Err("trade cleanup backpack", e); }
                }

                int removed = 0;
                if (Truthy(bp))
                {
                    foreach (var rec in _copies)
                    {
                        try
                        {
                            if (!Truthy(rec.Copy)) continue;
                            int stack = rec.Copy.Stack;
                            if (stack <= 0) continue;
                            int take = stack;
                            if (rec.Merged)
                            {
                                // 合并形态：只撤我们加进去的那部分（当前 - 合并前），绝不碰 NPC 原货
                                int extra = stack - rec.Npc0;
                                if (extra <= 0) continue;
                                take = extra < rec.Stack0 ? extra : rec.Stack0;
                            }
                            if (bp.RemoveItem(rec.Copy, take)) removed++;
                        }
                        catch (Exception e) { ModKit.Err("trade cleanup item", e); }
                    }
                }

                Plugin.L.LogInfo("[WulinTweaks] trade: display copies cleaned " + removed + "/" + _copies.Count);
                _copies.Clear();
                _npc = null;
                _playerZonePtr = IntPtr.Zero;
            }
            catch (Exception e) { ModKit.Err("trade cleanup", e); }
        }

        internal static void Refresh()
        {
            try
            {
                if (!TradingWithNpcUI.HasInstance()) return;
                var ui = TradingWithNpcUI.Instance;
                if (!Truthy(ui)) return;

                if (Truthy(ui.npcBackPack)) ui.npcBackPack.SetDirty();
                if (Truthy(ui.npcTrading)) ui.npcTrading.SetDirty();
            }
            catch (Exception e) { ModKit.Err("trade refresh", e); }
        }

        /// <summary>门槛①：ValueOffset() 必须 &gt;= 0</summary>
        internal static void ForceValueOffset(ref long result)
        {
            try
            {
                if (!Plugin.TradeAlwaysWin.Value) return;
                if (result <= 0) result = 1;
            }
            catch (Exception e) { ModKit.Err("trade offset", e); }
        }

        /// <summary>门槛②：playerTradingZone.GetTotalValue() 必须 &gt; 0（跟随「作价恒占优」）</summary>
        internal static void ForceTradingZoneValue(GameItemPack pack, ref long result)
        {
            try
            {
                if (!Plugin.TradeAlwaysWin.Value) return;
                if (result > 0) return;
                if (!Truthy(pack)) return;

                if (_playerZonePtr == IntPtr.Zero) return;
                if (pack.Pointer != _playerZonePtr) return;

                result = 1;
            }
            catch (Exception e) { ModKit.Err("trade zone value", e); }
        }
    }
}
