using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using WuLin;

namespace WulinModKit
{
    /// <summary>
    /// 插件运行时逻辑。每项功能独立开关、独立 try/catch。
    /// </summary>
    internal static class ModKit
    {
        // ---------- 通用 ----------
        internal static bool LuaLoaded;
        private static int _errCount;

        internal static void Err(string where, Exception e)
        {
            if (_errCount > 200) return;
            _errCount++;
            Plugin.L.LogError("[WulinModKit] " + where + ": " + e.GetType().Name + ": " + e.Message);
        }

        internal static bool Truthy(Il2CppObjectBase o)
        {
            return o != null && o.Pointer != IntPtr.Zero;
        }

        /// <summary>借用游戏自己的 LuaEnv 执行 BepInEx/config/WulinModKit/*.lua</summary>
        internal static void TryBootstrapLua()
        {
            if (LuaLoaded) return;
            if (!LuaManager.HasInstance) return;

            var mgr = LuaManager.Instance;
            if (!Truthy(mgr)) return;

            LuaLoaded = true;

            string[] files;
            try
            {
                files = Directory.GetFiles(Plugin.LuaDir, "*.lua", SearchOption.TopDirectoryOnly);
                Array.Sort(files, StringComparer.OrdinalIgnoreCase);
            }
            catch (Exception e) { Err("lua list", e); return; }

            if (files.Length == 0) return;

            foreach (var f in files)
            {
                try
                {
                    mgr.DoScript(File.ReadAllText(f));
                    Plugin.L.LogInfo("[WulinModKit] lua ok: " + Path.GetFileName(f));
                }
                catch (Exception e) { Err("lua " + Path.GetFileName(f), e); }
            }
        }

        // ---------- ① 场景高亮 ----------
        private static float _lastHighlightScan;
        private static readonly HashSet<IntPtr> HighlightAdapters = new HashSet<IntPtr>();

        internal static bool IsHighlightAdapter(IntPtr ptr)
        {
            return ptr != IntPtr.Zero && HighlightAdapters.Contains(ptr);
        }

        /// <summary>建筑本体：城门(2) / 建筑(4) / 密道(8) / 桥(0x20)</summary>
        private static bool IsBuildingLike(InteractiveObject io)
        {
            int v = (int)io.buildingType;
            return (v & (2 | 4 | 8 | 0x20)) != 0;
        }

        internal static bool IsActorAdapter(ViewElemenetAdapator ad)
        {
            try
            {
                var a = ad.TryCast<ActorViewElemenetAdapator>();
                return a != null && a.Pointer != IntPtr.Zero;
            }
            catch { return false; }
        }

        /// <summary>进图时全场景扫一遍：交互物按 clickType>0、地面物按 TempID>0，点亮后锁住</summary>
        internal static void ForceHighlightNow()
        {
            if (!Plugin.AlwaysHighlight.Value) return;

            float now = Time.realtimeSinceStartup;
            if (now - _lastHighlightScan < 0.3f) return;
            _lastHighlightScan = now;

            Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<InteractiveObject> arr;
            try { arr = UnityEngine.Object.FindObjectsOfType<InteractiveObject>(); }
            catch (Exception e) { Err("highlight find", e); return; }
            if (arr == null) return;

            RoamingManager rm = null;
            if (RoamingManager.HasInstance)
            {
                var tmp = RoamingManager.Instance;
                if (Truthy(tmp)) rm = tmp;
            }

            HighlightAdapters.Clear();

            int ioLit = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var io = arr[i];
                if (!Truthy(io)) continue;

                // clickType > 0 才是真正可交互的（ct=0 是火把/凳子/桌子/灯/地板这类摆设）
                try
                {
                    if ((int)io.clickType <= 0) continue;
                }
                catch (Exception e) { Err("highlight clickType", e); continue; }

                if (Plugin.ExcludeBuildings.Value)
                {
                    try
                    {
                        if (IsBuildingLike(io)) continue;
                    }
                    catch (Exception e) { Err("highlight building", e); }
                }

                ViewElemenetAdapator ad = null;
                if (rm != null)
                {
                    try
                    {
                        var view = io.View;
                        if (Truthy(view)) ad = rm.GetOrCreateViewAdapatorOnParent(view.gameObject);
                    }
                    catch (Exception e) { Err("highlight adapter(view)", e); }

                    if (!Truthy(ad))
                    {
                        try { ad = rm.GetOrCreateViewAdapatorOnParent(io.gameObject); }
                        catch (Exception e) { Err("highlight adapter(self)", e); }
                    }
                }

                if (Truthy(ad))
                {
                    HighlightAdapters.Add(ad.Pointer);
                    try { ad.SetOutLine(true); }
                    catch (Exception e) { Err("highlight adapter set", e); }
                }

                try { io.SetOutLine(true); ioLit++; }
                catch (Exception e) { Err("highlight io set", e); }
            }

            int miscLit = HighlightMiscItems(rm);
            Plugin.L.LogInfo("[WulinModKit] highlight: io=" + ioLit + " misc=" + miscLit);
        }

        /// <summary>地面物品：只亮 TempID &gt; 0 的（有真实物品模板 = 可拾取）</summary>
        private static int HighlightMiscItems(RoamingManager rm)
        {
            Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<MiscItem> arr;
            try { arr = UnityEngine.Object.FindObjectsOfType<MiscItem>(); }
            catch (Exception e) { Err("misc find", e); return 0; }
            if (arr == null) return 0;

            int lit = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var mi = arr[i];
                if (!Truthy(mi)) continue;

                if (Plugin.MiscRequirePickable.Value)
                {
                    try
                    {
                        if (mi.TempID <= 0) continue;
                    }
                    catch (Exception e) { Err("misc tempId", e); continue; }
                }

                ViewElemenetAdapator ad = null;
                if (rm != null)
                {
                    try { ad = rm.GetOrCreateViewAdapatorOnParent(mi.gameObject); }
                    catch (Exception e) { Err("misc adapter", e); }
                }

                if (Truthy(ad))
                {
                    HighlightAdapters.Add(ad.Pointer);
                    try { ad.SetOutLine(true); }
                    catch (Exception e) { Err("misc adapter set", e); }
                }

                lit++;
            }
            return lit;
        }

        // ---------- ② 大地图 ----------
        private static float _lastWorldMapScan;
        private static readonly HashSet<int> _wmInited = new HashSet<int>();

        internal static void UnlockWorldMapTick()
        {
            if (!Plugin.UnlockWorldMap.Value) return;

            float now = Time.realtimeSinceStartup;
            if (now - _lastWorldMapScan < 2f) return;
            _lastWorldMapScan = now;

            if (!UIWorldMapManager.HasInstance()) return;
            var mgr = UIWorldMapManager.Instance;
            if (!Truthy(mgr)) return;

            try
            {
                var list = mgr.listWorldMap;
                if (list == null) return;

                int unlocked = 0;
                foreach (var kv in list)
                {
                    var wm = kv.Value;
                    if (!Truthy(wm)) continue;

                    int id = wm.worldMapID;
                    try
                    {
                        if (!mgr.IsMapEnable(id))
                        {
                            mgr.SetMapEnable(id, true, false);
                            unlocked++;
                        }
                    }
                    catch (Exception e) { Err("worldmap enable " + id, e); }

                    ForceWorldMapIcons(wm);
                }

                if (unlocked > 0)
                    Plugin.L.LogInfo("[WulinModKit] world map unlocked +" + unlocked);
            }
            catch (Exception e) { Err("worldmap", e); }
        }

        internal static void ForceCityIconsNow(UIWorldMap wm)
        {
            if (!Plugin.UnlockWorldMap.Value) return;
            ForceWorldMapIcons(wm);
        }

        /// <summary>
        /// 地点图标全在 UIWorldMap.CityIcon 下，节点名就是 mapID 字符串
        /// （initIconShow 用 int.TryParse(child.name) 判断，再用 listShowIcon.Contains 决定显隐）。
        /// </summary>
        private static void ForceWorldMapIcons(UIWorldMap wm)
        {
            if (!Truthy(wm)) return;

            bool first;
            try { first = _wmInited.Add(wm.worldMapID); }
            catch { return; }

            if (first)
            {
                try { wm.initIconShow(); }
                catch (Exception e) { Err("city initIconShow", e); }
            }

            try
            {
                int shown = 0, total = 0;
                WalkMapIcons(wm.CityIcon, 0, 3, ref shown, ref total);
                if (first)
                    Plugin.L.LogInfo("[WulinModKit] city icon shown=" + shown + "/" + total
                        + " (worldMapID " + wm.worldMapID + ")");
            }
            catch (Exception e) { Err("city icons", e); }
        }

        /// <summary>地点图标：名字能解析成整数，或带 boxName 名字标签</summary>
        private static bool LooksLikeMapIcon(Transform t)
        {
            try
            {
                if (int.TryParse(t.name, out _)) return true;

                int n = t.childCount;
                for (int i = 0; i < n; i++)
                {
                    var c = t.GetChild(i);
                    if (Truthy(c) && c.name == "boxName") return true;
                }
            }
            catch { }
            return false;
        }

        private static void WalkMapIcons(Transform t, int depth, int maxDepth, ref int shown, ref int total)
        {
            if (!Truthy(t) || depth > maxDepth) return;

            int n = t.childCount;
            for (int i = 0; i < n; i++)
            {
                Transform c;
                try { c = t.GetChild(i); }
                catch { continue; }
                if (!Truthy(c)) continue;

                total++;
                if (LooksLikeMapIcon(c))
                {
                    try
                    {
                        var go = c.gameObject;
                        if (go != null && !go.activeSelf) { go.SetActive(true); shown++; }
                    }
                    catch { }
                }
                else
                {
                    WalkMapIcons(c, depth + 1, maxDepth, ref shown, ref total);
                }
            }
        }

        // ---------- ②b 马车地图 ----------
        internal static void ForceCabIconsNow(UICabMapManager mgr)
        {
            if (!Plugin.UnlockCabMap.Value) return;
            if (!Truthy(mgr)) return;

            int shown = 0, total = 0;
            try
            {
                WalkShow(mgr.ContentArea, 0, 2, ref shown, ref total);
                WalkShow(mgr.CityIcon, 0, 4, ref shown, ref total);
            }
            catch (Exception e) { Err("cab icons", e); }

            if (shown > 0)
                Plugin.L.LogInfo("[WulinModKit] cab icon shown=" + shown + "/" + total);
        }

        private static void WalkShow(Transform t, int depth, int maxDepth, ref int shown, ref int total)
        {
            if (!Truthy(t) || depth > maxDepth) return;

            int n = t.childCount;
            for (int i = 0; i < n; i++)
            {
                Transform c;
                try { c = t.GetChild(i); }
                catch { continue; }
                if (!Truthy(c)) continue;

                total++;
                try
                {
                    var go = c.gameObject;
                    if (go != null && !go.activeSelf) { go.SetActive(true); shown++; }
                }
                catch { }

                WalkShow(c, depth + 1, maxDepth, ref shown, ref total);
            }
        }

        // ---------- ③ 剧情：忽略「队伍中是否有某角色」条件 ----------
        //
        // 反汇编 IsJoinedTeamCondition.CheckExtra / CheckAllConnectNode 得到：
        //     var del = IsJoinedTeamCondition.CheckExtraAction;
        //     if (del != null) return del(this, extra);
        //     return true;                                  ← 委托为空时恒成立
        // 所以把两个静态委托置空，条件就永远满足（不依赖 interop 是否导出该类型）。
        private static bool _teamPatchDone;

        /// <summary>函数入口前 5 字节：mov [rsp+8], rbx（一条完整指令，可整条覆盖）</summary>
        private static readonly byte[] SigHead5 = { 0x48, 0x89, 0x5C, 0x24, 0x08 };

        /// <summary>
        /// ConditionNode.CheckAllConnectNode 的基类实现（VA 0x181105A00）。
        /// 子类会把"角色是否在队"的委托判断放在自己重写的实现里，通过后才尾调用基类。
        /// 直接把子类入口改成 jmp 基类 = 跳过角色判断，但保留连接节点的其余条件检查。
        /// </summary>
        private const int BaseCheckAllConnectNodeRva = 0x1105A00;

        private static readonly (string Name, int Rva)[] TeamCondConnectNodes =
        {
            ("IsJoinedTeamCondition.CheckAllConnectNode", 0x10F4CB0),
            ("HavePartnerCondition.CheckAllConnectNode",  0x10F2230),
        };

        internal static void ForceIgnoreTeamCondition()
        {
            if (!Plugin.IgnoreTeamCondition.Value) return;
            if (_teamPatchDone) return;

            try
            {
                var h = GetModuleHandle("GameAssembly.dll");
                if (h == IntPtr.Zero)
                {
                    Plugin.L.LogWarning("[WulinModKit] GameAssembly.dll handle not found");
                    return;
                }

                var baseImpl = h + BaseCheckAllConnectNodeRva;

                int ok = 0;
                var failed = "";
                foreach (var t in TeamCondConnectNodes)
                {
                    if (PatchJumpTo(h, t.Rva, baseImpl)) ok++;
                    else failed += (failed.Length == 0 ? "" : ", ") + t.Name;
                }

                if (ok == TeamCondConnectNodes.Length)
                {
                    _teamPatchDone = true;
                    Plugin.L.LogInfo("[WulinModKit] team condition patched (skip-to-base) " + ok + "/" + TeamCondConnectNodes.Length);
                }
                else
                {
                    Plugin.L.LogWarning("[WulinModKit] team condition patch " + ok + "/" + TeamCondConnectNodes.Length
                        + "; failed: " + failed);
                    _teamPatchDone = ok > 0;
                }
            }
            catch (Exception e) { Err("team condition", e); }
        }

        private static readonly List<(IntPtr Addr, byte[] Orig)> _teamSaved = new List<(IntPtr, byte[])>();

        /// <summary>校验入口 5 字节后写入 E9 相对跳转，并保留原始字节以便撤销</summary>
        private static bool PatchJumpTo(IntPtr moduleBase, int rva, IntPtr target)
        {
            var orig = moduleBase + rva;

            var head = new byte[5];
            Marshal.Copy(orig, head, 0, 5);
            for (int i = 0; i < 5; i++)
                if (head[i] != SigHead5[i]) return false;

            long rel = (long)target - ((long)orig + 5);
            if (rel < int.MinValue || rel > int.MaxValue) return false;

            uint old;
            if (!VirtualProtect(orig, (UIntPtr)5, 0x40, out old)) return false;

            Marshal.WriteByte(orig, 0xE9);
            Marshal.WriteInt32(orig + 1, (int)rel);

            VirtualProtect(orig, (UIntPtr)5, old, out _);

            _teamSaved.Add((orig, head));
            return true;
        }

        /// <summary>撤销队伍条件 patch，写回原始字节</summary>
        internal static void RestoreTeamCondition()
        {
            try
            {
                foreach (var s in _teamSaved)
                {
                    uint old;
                    if (!VirtualProtect(s.Addr, (UIntPtr)5, 0x40, out old)) continue;
                    Marshal.Copy(s.Orig, 0, s.Addr, 5);
                    VirtualProtect(s.Addr, (UIntPtr)5, old, out _);
                }
                _teamSaved.Clear();
                _teamPatchDone = false;
                Plugin.L.LogInfo("[WulinModKit] team condition restored");
            }
            catch (Exception e) { Err("team restore", e); }
        }

        /// <summary>熄灭所有已点亮的高亮（先清白名单，否则会被 prefix 又点亮）</summary>
        internal static void ClearHighlights()
        {
            var ptrs = new List<IntPtr>(HighlightAdapters);
            HighlightAdapters.Clear();

            int cleared = 0;
            foreach (var p in ptrs)
            {
                if (p == IntPtr.Zero) continue;
                try
                {
                    var ad = new ViewElemenetAdapator(p);
                    if (ad != null && ad.Pointer != IntPtr.Zero)
                    {
                        ad.SetOutLine(false);
                        cleared++;
                    }
                }
                catch { }
            }

            Plugin.L.LogInfo("[WulinModKit] highlight cleared: " + cleared + "/" + ptrs.Count);
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        // ---------- ④ 伤害 ----------
        internal static bool IsPlayerSide(BattleActor actor)
        {
            if (!Truthy(actor)) return false;
            try
            {
                var team = actor.battleTeam;
                return team == BattleTeamEnum.Player || team == BattleTeamEnum.Allie;
            }
            catch (Exception e) { Err("IsPlayerSide", e); }
            return false;
        }

        internal static void ApplyDamageMul(ref float result, BattleActor dealer)
        {
            try
            {
                float pm = Plugin.PlayerDamageMul.Value;
                float em = Plugin.EnemyDamageMul.Value;
                if (Mathf.Approximately(pm, 1f) && Mathf.Approximately(em, 1f)) return;

                float mul = IsPlayerSide(dealer) ? pm : em;
                if (!Mathf.Approximately(mul, 1f)) result *= mul;
            }
            catch (Exception e) { Err("damageMul", e); }
        }
    }
}
