using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using WuLin;

namespace WulinModKit
{
    /// <summary>
    /// 插件运行时状态与各功能的实际逻辑。
    /// 设计原则：每一项功能独立开关、独立 try/catch，坏了不影响其它功能。
    /// </summary>
    internal static class ModKit
    {
        // ---------- 通用 ----------
        internal static bool LuaLoaded;
        internal static float LastWorldMapScan;
        internal static int WorldMapUnlockCount;
        internal static bool LoggedTeamCheck;

        private static int _errCount;

        internal static void Err(string where, Exception e)
        {
            // 避免每帧刷屏：同样位置最多打 5 次
            if (_errCount > 200) return;
            _errCount++;
            Plugin.L.LogError("[WulinModKit] " + where + ": " + e.GetType().Name + ": " + e.Message);
        }

        internal static bool Truthy(Il2CppObjectBase o)
        {
            return o != null && o.Pointer != IntPtr.Zero;
        }

        // ---------- Lua 引导 ----------
        /// <summary>
        /// 在 LuaManager 就绪后执行 BepInEx/config/WulinModKit/*.lua。
        /// 官方文档只把 Lua 挂在动态修改器上，但 LuaManager.DoScript 是 public 实例方法，
        /// 这里直接借用游戏自己的 LuaEnv，省掉自建 Lua 运行时。
        /// </summary>
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

            if (files.Length == 0)
            {
                Plugin.L.LogInfo("[WulinModKit] no lua scripts in " + Plugin.LuaDir);
                return;
            }

            foreach (var f in files)
            {
                try
                {
                    var code = File.ReadAllText(f);
                    mgr.DoScript(code);
                    Plugin.L.LogInfo("[WulinModKit] lua ok: " + Path.GetFileName(f));
                }
                catch (Exception e)
                {
                    Err("lua " + Path.GetFileName(f), e);
                }
            }
        }

        internal static void DoLua(string code, string label)
        {
            try
            {
                if (!LuaManager.HasInstance) return;
                LuaManager.Instance.DoScript(code);
            }
            catch (Exception e) { Err("lua:" + label, e); }
        }

        // ---------- ① 高亮 ----------

        /// <summary>
        /// 方案 A：遍历场景里所有视图适配器，凡 isInteractiveable == true 的一律锁亮。
        /// 人物（ActorViewElemenetAdapator）不参与。
        /// 这是"鼠标放上去会高亮"的同一判据，不猜 bt / ct / kit。
        /// </summary>
        internal static void ForceInteractiveAdapters()
        {
            if (!Plugin.AlwaysHighlight.Value) return;
            if (!RoamingManager.HasInstance) return;

            var rm = RoamingManager.Instance;
            if (!Truthy(rm)) return;

            var list = rm.objectViewElemenetAdapators;
            if (list == null) return;

            HighlightAdapters.Clear();

            int n = list.Count;
            int lit = 0, actor = 0, noInter = 0;
            for (int i = 0; i < n; i++)
            {
                ViewElemenetAdapator ad;
                try { ad = list[i]; }
                catch (Exception e) { Err("adapter list", e); continue; }
                if (!Truthy(ad)) continue;

                if (IsActorAdapter(ad)) { actor++; continue; }

                bool inter = false;
                try { inter = ad.isInteractiveable; }
                catch (Exception e) { Err("adapter inter", e); continue; }
                if (!inter) { noInter++; continue; }

                HighlightAdapters.Add(ad.Pointer);
                try { ad.SetOutLine(true); lit++; }
                catch (Exception e) { Err("adapter setoutline", e); }
            }

            if (lit != _lastAdapterLit)
            {
                _lastAdapterLit = lit;
                Plugin.L.LogInfo("[WulinModKit] adapter-scan: total=" + n
                    + " actor=" + actor + " nointer=" + noInter + " lit=" + lit);
            }
        }

        private static int _lastAdapterLit = -1;

        internal static void ResetAdapterDump()
        {
            _adapterDumped = false;
        }

        private static bool _adapterDumped;

        /// <summary>
        /// 一次性导出场景里所有视图适配器：类型 / isInteractiveable / 宿主 InteractiveObject 的 bt·ct·interactable。
        /// 用来确定"鼠标放上去会高亮"到底对应哪个字段。
        /// </summary>
        internal static void AdapterDumpTick()
        {
            if (_adapterDumped || !Plugin.DumpAdapters.Value) return;
            if (!RoamingManager.HasInstance) return;

            var rm = RoamingManager.Instance;
            if (!Truthy(rm)) return;

            var list = rm.objectViewElemenetAdapators;
            if (list == null || list.Count == 0) return;

            _adapterDumped = true;
            int n = list.Count;
            Plugin.L.LogInfo("[WulinModKit] adapter dump: count=" + n);

            int limit = Math.Min(n, 400);
            for (int i = 0; i < limit; i++)
            {
                var ad = list[i];
                if (!Truthy(ad)) continue;

                string kind = "view";
                try { if (ad.TryCast<ActorViewElemenetAdapator>() != null) kind = "ACTOR"; }
                catch { }
                try { if (ad.TryCast<MiscViewElemenetAdapator>() != null) kind = "misc"; }
                catch { }
                try { if (ad.TryCast<ObjectViewElemenetAdapator>() != null) kind = "obj"; }
                catch { }

                bool inter = false;
                try { inter = ad.isInteractiveable; } catch { }

                string extra = "";
                try
                {
                    var io = ad.GetComponent<InteractiveObject>();
                    if (io == null || io.Pointer == IntPtr.Zero)
                        io = ad.GetComponentInParent<InteractiveObject>();
                    if (io != null && io.Pointer != IntPtr.Zero)
                        extra = " io{bt=" + (int)io.buildingType
                              + ",ct=" + (int)io.clickType
                              + ",act=" + io.interactivable + "}";
                }
                catch { }

                try
                {
                    Plugin.L.LogInfo("[WulinModKit] ad[" + i + "] " + kind
                        + " inter=" + inter + " name=" + ad.name + extra);
                }
                catch { }
            }
        }        private static float _lastHighlightScan;
        private static float _lastMiscScan;
        private static int _lastHighlightCount;
        private const float MiscScanInterval = 3f;

        /// <summary>
        /// 只允许这些视图适配器被强制点亮。
        /// 每轮扫描重建，避免把 NPC / 装饰物的适配器也算进来。
        /// </summary>
        internal static readonly HashSet<IntPtr> HighlightAdapters = new HashSet<IntPtr>();

        internal static bool IsHighlightAdapter(IntPtr ptr)
        {
            return ptr != IntPtr.Zero && HighlightAdapters.Contains(ptr);
        }

        private static int _dumpLitBudget = 40;
        private static int _dumpSkipBudget = 40;
        private static int _dumpMiscLitBudget = 20;
        private static int _dumpMiscSkipBudget = 20;

        /// <summary>
        /// 建筑物判定（按 buildingType 位）：
        ///  · 排除 GATEWAY(2 城门) / GATEWAYBUILDING(4 建筑本体) / ESCAPEWAY(8 密道) / BRIDGE(0x20 桥)
        ///  · 保留 GEAR(1 箱子/草药/木材/神龛…)、DOOR(0x10)、SEAT(0x40)
        /// 注意：不能用 Kit 判，游戏给几乎所有场景物件（灯/树/灌木）都挂了 BaseBuildingKit。
        /// </summary>
        private static bool IsBuildingLike(InteractiveObject io)
        {
            int v = (int)io.buildingType;
            return (v & (2 | 4 | 8 | 0x20)) != 0;
        }

        // clickType 白名单（配置热更新）
        private static HashSet<int> _allowedCts;
        private static string _allowedCtsRaw;

        internal static bool IsClickTypeAllowed(int ct)
        {
            var raw = Plugin.AllowedClickTypes.Value;
            if (_allowedCts == null || _allowedCtsRaw != raw)
            {
                _allowedCtsRaw = raw;
                _allowedCts = new HashSet<int>();
                foreach (var s in raw.Split(','))
                {
                    var t = s.Trim();
                    if (t.Length == 0) continue;
                    if (int.TryParse(t, out var v)) _allowedCts.Add(v);
                }
            }
            return _allowedCts.Contains(ct);
        }

        /// <summary>是不是"人物"的视图适配器（角色/NPC）</summary>
        internal static bool IsActorAdapter(ViewElemenetAdapator ad)
        {
            try
            {
                var a = ad.TryCast<ActorViewElemenetAdapator>();
                return a != null && a.Pointer != IntPtr.Zero;
            }
            catch { return false; }
        }

        private static readonly Dictionary<int, int> _btSkipStat = new Dictionary<int, int>();

        private static void StatBuildingSkip(int v)
        {
            if (_btSkipStat.ContainsKey(v)) _btSkipStat[v]++;
            else _btSkipStat[v] = 1;
        }

        private static string BtStatText()
        {
            if (_btSkipStat.Count == 0) return "";
            var sb = new System.Text.StringBuilder();
            foreach (var kv in _btSkipStat)
            {
                if (sb.Length > 0) sb.Append(", ");
                sb.Append(kv.Key).Append("=").Append(kv.Value);
            }
            return sb.ToString();
        }

        private static readonly Dictionary<int, int> _ctSkipStat = new Dictionary<int, int>();

        private static void StatClickSkip(int v)
        {
            if (_ctSkipStat.ContainsKey(v)) _ctSkipStat[v]++;
            else _ctSkipStat[v] = 1;
        }

        private static string CtStatText()
        {
            if (_ctSkipStat.Count == 0) return "";
            var sb = new System.Text.StringBuilder();
            foreach (var kv in _ctSkipStat)
            {
                if (sb.Length > 0) sb.Append(", ");
                sb.Append(kv.Key).Append("=").Append(kv.Value);
            }
            return sb.ToString();
        }

        /// <summary>遍历当前场景所有 InteractiveObject：先补齐 ViewElemenetAdapator，再点亮</summary>
        internal static void ForceHighlightAllNow()
        {
            if (!Plugin.AlwaysHighlight.Value) return;
            if (Plugin.ForceAllAdapters.Value) return;

            if (!Plugin.ScanOnEntry.Value)
            {
                // 方案 A：不为每个 InteractiveObject 做类型猜测，
                // 只认 adapter 自己的 isInteractiveable（= 游戏判定"这里能交互"）
                ForceInteractiveAdapters();
                return;
            }

            _lastHighlightScan = Time.realtimeSinceStartup;

            Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<InteractiveObject> arr;
            try
            {
                arr = UnityEngine.Object.FindObjectsOfType<InteractiveObject>();
            }
            catch (Exception e) { Err("highlight find", e); return; }

            if (arr == null) return;

            RoamingManager rm = null;
            if (RoamingManager.HasInstance)
            {
                var tmp = RoamingManager.Instance;
                if (Truthy(tmp)) rm = tmp;
            }

            HighlightAdapters.Clear();
            _btSkipStat.Clear();
            _ctSkipStat.Clear();

            int total = 0, skipped = 0, adapters = 0, lit = 0, skippedBuilding = 0, skippedClick = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var io = arr[i];
                if (!Truthy(io)) continue;
                total++;

                // 用户方案：只看 clickType > 0（ct=0 全是火把/凳子/桌子/灯/地板这类摆设）
                try
                {
                    int ct = (int)io.clickType;
                    bool pass = Plugin.UseClickTypeFilter.Value ? IsClickTypeAllowed(ct) : (ct > 0);
                    if (!pass)
                    {
                        skippedClick++;
                        StatClickSkip(ct);
                        continue;
                    }
                }
                catch (Exception e) { Err("highlight clickType", e); }

                // 建筑类交互（buildingType 非 NONE）一律不点亮
                try
                {
                    if (Plugin.ExcludeBuildingObjects.Value && IsBuildingLike(io))
                    {
                        skippedBuilding++;
                        StatBuildingSkip((int)io.buildingType);
                        if (Plugin.DumpLitObjects.Value && _dumpSkipBudget > 0)
                        {
                            _dumpSkipBudget--;
                            try
                            {
                                Plugin.L.LogInfo("[WulinModKit] skip-building: " + io.name
                                    + " bt=" + (int)io.buildingType
                                    + " kit=" + (Truthy(io.Kit) ? "yes" : "no")
                                    + " ct=" + (int)io.clickType);
                            }
                            catch { }
                        }
                        continue;
                    }
                }
                catch (Exception e) { Err("highlight building filter", e); }

                if (Plugin.DumpLitObjects.Value && _dumpLitBudget > 0)
                {
                    _dumpLitBudget--;
                    try
                    {
                        Plugin.L.LogInfo("[WulinModKit] lit: " + io.name
                            + " bt=" + (int)io.buildingType + " ct=" + (int)io.clickType);
                    }
                    catch { }
                }

                // 1) 拿到（或现场创建）这个物体对应的视图适配器
                ViewElemenetAdapator ad = null;
                if (rm != null)
                {
                    try
                    {
                        var view = io.View;
                        if (Truthy(view))
                            ad = rm.GetOrCreateViewAdapatorOnParent(view.gameObject);
                    }
                    catch (Exception e) { Err("highlight getAdapter(view)", e); }

                    if (!Truthy(ad))
                    {
                        try { ad = rm.GetOrCreateViewAdapatorOnParent(io.gameObject); }
                        catch (Exception e) { Err("highlight getAdapter(self)", e); }
                    }
                }

                // 2) 强制 adapter 认为"可交互"，再登记白名单并点亮
                if (Truthy(ad))
                {
                    adapters++;
                    if (Plugin.ForceInteractiveable.Value)
                    {
                        try { ad.isInteractiveable = true; }
                        catch (Exception e) { Err("highlight set interactiveable", e); }
                    }
                    HighlightAdapters.Add(ad.Pointer);
                    try { ad.SetOutLine(true); }
                    catch (Exception e) { Err("highlight adapter set", e); }
                }

                // 3) 同时通知 InteractiveObject 自己
                try { io.SetOutLine(true); lit++; }
                catch (Exception e) { Err("highlight io set", e); }
            }

            // 4) 地面可拾取物品单独一遍（它们不是 InteractiveObject）
            int miscLit = HighlightMiscItems(rm);
            _lastMiscScan = Time.realtimeSinceStartup;

            if (total != _lastHighlightCount)
            {
                _lastHighlightCount = total;
                Plugin.L.LogInfo("[WulinModKit] highlight scan: total=" + total
                    + " skipped(non-interactable)=" + skipped
                    + " skipped(clickType)=" + skippedClick
                    + " skipped(building)=" + skippedBuilding
                    + " adapters=" + adapters + " ioLit=" + lit
                    + " misc=" + miscLit
                    + " clickTypes={" + CtStatText() + "}"
                    + " buildingTypes={" + BtStatText() + "}");
            }
        }

        /// <summary>
        /// 轻量轮询：只扫地面可拾取物，每 3 秒一次。
        /// 场景物件（InteractiveObject）仍然只在进图时全扫，避免重建白名单。
        /// </summary>
        internal static void MiscItemsTick()
        {
            if (!Plugin.AlwaysHighlight.Value) return;
            if (Plugin.ForceAllAdapters.Value) return;

            float now = Time.realtimeSinceStartup;
            if (now - _lastMiscScan < MiscScanInterval) return;
            _lastMiscScan = now;

            // 方案 A：统一走 adapter 判定，地面物件也由它覆盖，不再单独扫 MiscItem
            if (!Plugin.ScanOnEntry.Value)
            {
                ForceInteractiveAdapters();
                return;
            }

            RoamingManager rm = null;
            if (RoamingManager.HasInstance)
            {
                var tmp = RoamingManager.Instance;
                if (Truthy(tmp)) rm = tmp;
            }
            if (rm == null) return;

            HighlightMiscItems(rm);
        }

        /// <summary>地面可拾取物（MiscItem）也走同一套视图适配器</summary>
        private static int HighlightMiscItems(RoamingManager rm)
        {
            int lit = 0;
            Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<MiscItem> arr;
            try
            {
                arr = UnityEngine.Object.FindObjectsOfType<MiscItem>();
            }
            catch (Exception e) { Err("misc find", e); return 0; }

            if (arr == null) return 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var mi = arr[i];
                if (!Truthy(mi)) continue;

                // 判据：MiscItem.TempID > 0 —— 指向物品表里一个真实物品模板，
                // 说明它是"某样东西"而不是地图贴图（石头/绿树/地毯/蜘蛛网这类 TempID 为 0）。
                // 注意 ShowNameCollider 是手机移植版才填的字段，PC 版全为 null，不能用。
                int num = 0;
                int tempId = 0;
                bool hideOnPick = false;
                bool hasNameCollider = false;
                bool pickable = false;
                try
                {
                    num = mi.Num;
                    tempId = mi.TempID;
                    hideOnPick = mi.HideOnPick;
                    hasNameCollider = Truthy(mi.ShowNameCollider);
                    pickable = tempId > 0;
                }
                catch (Exception e) { Err("misc fields", e); }

                if (Plugin.MiscRequirePickable.Value && !pickable)
                {
                    if (Plugin.DumpLitObjects.Value && _dumpMiscSkipBudget > 0)
                    {
                        _dumpMiscSkipBudget--;
                        try
                        {
                            Plugin.L.LogInfo("[WulinModKit] skip-misc: " + mi.name
                                + " temp=" + tempId + " num=" + num + " hide=" + hideOnPick
                                + " nameCollider=" + hasNameCollider
                                + " type=" + (int)mi.type);
                        }
                        catch { }
                    }
                    continue;
                }

                if (Plugin.DumpLitObjects.Value && _dumpMiscLitBudget > 0)
                {
                    _dumpMiscLitBudget--;
                    try
                    {
                        Plugin.L.LogInfo("[WulinModKit] misc-lit: " + mi.name
                            + " temp=" + tempId + " num=" + num + " hide=" + hideOnPick
                            + " nameCollider=" + hasNameCollider
                            + " type=" + (int)mi.type);
                    }
                    catch { }
                }

                ViewElemenetAdapator ad = null;
                if (rm != null)
                {
                    try { ad = rm.GetOrCreateViewAdapatorOnParent(mi.gameObject); }
                    catch (Exception e) { Err("misc getAdapter", e); }
                }

                if (Truthy(ad))
                {
                    if (Plugin.ForceInteractiveable.Value)
                    {
                        try { ad.isInteractiveable = true; }
                        catch (Exception e) { Err("misc set interactiveable", e); }
                    }
                    HighlightAdapters.Add(ad.Pointer);
                    try { ad.SetOutLine(true); }
                    catch (Exception e) { Err("misc adapter set", e); }
                }

                lit++;
            }
            return lit;
        }

        /// <summary>
        /// 节流版：进图后 force=true 立即扫；平时按配置间隔。
        /// RescanSeconds = 0 时只靠进图那一次，没有任何每帧开销。
        /// </summary>
        internal static void ForceHighlightTick(bool force)
        {
            if (!Plugin.AlwaysHighlight.Value) return;

            float now = Time.realtimeSinceStartup;

            // 防抖：0.3 秒内不重复全场景扫描
            if (now - _lastHighlightScan < 0.3f) return;

            float interval = Plugin.HighlightRescanSeconds.Value;
            if (!force)
            {
                if (interval <= 0f) return;
                if (now - _lastHighlightScan < interval) return;
            }
            ForceHighlightAllNow();
        }

        /// <summary>
        /// 兜底：只补亮白名单里的适配器。
        /// 注意 objectViewElemenetAdapators 是 RoamingManager 的全量列表（含 NPC），
        /// 不能无脑全点亮，否则 NPC 会被永久描边。
        /// </summary>
        internal static void ForceHighlightAdapters()
        {
            if (!Plugin.AlwaysHighlight.Value) return;
            if (!RoamingManager.HasInstance) return;

            var rm = RoamingManager.Instance;
            if (!Truthy(rm)) return;

            var list = rm.objectViewElemenetAdapators;
            if (list == null) return;

            int n = list.Count;
            for (int i = 0; i < n; i++)
            {
                var ad = list[i];
                if (!Truthy(ad)) continue;
                if (!IsHighlightAdapter(ad.Pointer)) continue;
                try { ad.SetOutLine(true); }
                catch (Exception e) { Err("highlight adapter", e); }
            }
        }

        // ---------- ② 大地图解锁 ----------
        internal static void UnlockWorldMapTick(bool force)
        {
            if (!Plugin.UnlockWorldMap.Value) return;

            float now = Time.realtimeSinceStartup;
            float interval = Plugin.WorldMapRescanInterval.Value;
            if (!force)
            {
                if (interval <= 0f) return;
                if (now - LastWorldMapScan < interval) return;
            }
            LastWorldMapScan = now;

            if (!UIWorldMapManager.HasInstance()) return;
            var mgr = UIWorldMapManager.Instance;
            if (!Truthy(mgr)) return;

            try
            {
                var list = mgr.listWorldMap;
                if (list == null) return;

                int unlocked = 0;
                int seen = 0;

                // list 是 Dictionary<int, UIWorldMap>，必须按 key 枚举；
                // 之前用 0..Count 当下标会 KeyNotFoundException。
                foreach (var kv in list)
                {
                    seen++;
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
                    catch (Exception e) { Err("worldmap set " + id, e); }

                    ForceWorldMapIcons(wm, id);
                }

                if (unlocked > 0)
                {
                    WorldMapUnlockCount += unlocked;
                    Plugin.L.LogInfo("[WulinModKit] world map unlocked +" + unlocked
                        + " (total " + WorldMapUnlockCount + ", maps=" + seen + ")");
                }
            }
            catch (Exception e) { Err("worldmap", e); }
        }

        // ---------- ②b 大地图城市图标 / 马车地图图标 ----------
        private static float _lastCityForce;
        private static readonly HashSet<int> _wmInited = new HashSet<int>();
        private static bool _dumpedWorldMap;
        private static bool _dumpedCabMap;

        internal static void ForceCityIconsNow(UIWorldMap wm)
        {
            if (!Truthy(wm)) return;

            float now = Time.realtimeSinceStartup;
            if (now - _lastCityForce < 0.3f) return;
            _lastCityForce = now;

            ForceWorldMapIcons(wm, -1);
        }

        /// <summary>
        /// 单个世界地图：首次进场用游戏自己的 initIconShow 重刷，然后强制图标可见。
        /// </summary>
        private static void ForceWorldMapIcons(UIWorldMap wm, int id)
        {
            if (!Truthy(wm)) return;

            int key = id;
            bool first = false;
            try
            {
                if (id < 0) id = wm.worldMapID;
                key = id;
                first = _wmInited.Add(key);
            }
            catch (Exception e) { Err("wm init check", e); }

            if (first)
            {
                try { wm.initIconShow(); }
                catch (Exception e) { Err("city initIconShow", e); }
            }

            if (!Plugin.ForceShowAllIcons.Value) return;

            // 反汇编 initIconShow() 得到的真实结构：
            //   遍历 this.CityIcon（字段偏移 0x48）的**直接子节点**，
            //   int.TryParse(child.name) 成功 → child.SetActive(showList.Contains(mapID))
            //   失败 → child.SetActive(false)
            // 也就是说地点图标全在 CityIcon 下、节点名就是 mapID 字符串；
            // Content/Test 那批（地名命名）根本不是地点图标，开了就会串区、进图黑屏。
            try
            {
                var iconRoot = wm.CityIcon;
                if (Truthy(iconRoot))
                {
                    int shown = 0, total = 0;
                    WalkMapIcons(iconRoot, 0, 3, ref shown, ref total);
                    if (shown > 0)
                        Plugin.L.LogInfo("[WulinModKit] worldmap#" + key + " cityicon shown=" + shown + "/" + total);
                }
            }
            catch (Exception e) { Err("city icons", e); }

            if (Plugin.DumpMapUi.Value && !_dumpedWorldMap)
            {
                _dumpedWorldMap = true;
                try
                {
                    int c = 0;
                    DumpDeep(wm.CityIcon, "cityicon" + key, 0, 4, ref c, 200);
                    DumpDeep(wm.BgGrid, "bggrid" + key, 0, 2, ref c, 40);
                    DumpWorldMapIds();
                }
                catch (Exception e) { Err("city dump", e); }
            }
        }

        /// <summary>地点图标判定：名字能解析成整数（initIconShow 的判据），或带 boxName 名字标签</summary>
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

        /// <summary>马车地图：图标容器（CityIcon 子树）递归强制可见</summary>
        internal static void ForceCabIconsNow(UICabMapManager mgr)
        {
            if (!Truthy(mgr)) return;

            if (Plugin.ForceShowAllIcons.Value)
            {
                try
                {
                    ForceShowChildrenAll(mgr.ContentArea, "cabmap", 2);
                    ForceShowChildrenAll(mgr.CityIcon, "cabmap/CityIcon", 4);
                }
                catch (Exception e) { Err("cab forceShow", e); }
            }

            if (Plugin.DumpMapUi.Value && !_dumpedCabMap)
            {
                _dumpedCabMap = true;
                try { Plugin.L.LogInfo("[WulinModKit] cabmap CAB_MAP_ID=" + UICabMapManager.CAB_MAP_ID); }
                catch (Exception e) { Err("cab cabMapId", e); }
                try
                {
                    int c = 0;
                    DumpDeep(mgr.ContentArea, "cab", 0, 4, ref c, 260);
                }
                catch (Exception e) { Err("cab dump", e); }
            }
        }

        /// <summary>
        /// 只打开"地点图标容器"里的节点。
        /// Content 下的 CityIcon / BattleIcon 是对象池模板、BgGrid 是背景格、CollideArea 是碰撞区，
        /// 统统跳过——全开会在右上角摊出一块半透明黑块。
        /// </summary>
        private static void ForceWorldMapIconNodes(Transform root, string tag)
        {
            if (!Truthy(root)) return;

            int containers = 0, shown = 0, total = 0;
            int n = root.childCount;
            for (int i = 0; i < n; i++)
            {
                Transform c;
                try { c = root.GetChild(i); }
                catch { continue; }
                if (!Truthy(c)) continue;

                string cname = "";
                try { cname = c.name; } catch { }
                if (IsPoolContainer(cname)) continue;

                containers++;
                int m = c.childCount;
                for (int j = 0; j < m; j++)
                {
                    Transform ic;
                    try { ic = c.GetChild(j); }
                    catch { continue; }
                    if (!Truthy(ic)) continue;

                    total++;
                    try
                    {
                        var go = ic.gameObject;
                        if (go != null && !go.activeSelf) { go.SetActive(true); shown++; }
                    }
                    catch { }
                }
            }

            if (shown > 0)
                Plugin.L.LogInfo("[WulinModKit] " + tag + " icon-nodes containers=" + containers
                    + " shown=" + shown + "/" + total);
        }

        /// <summary>对象池/背景/碰撞容器：这些容器里的子节点不能无脑打开</summary>
        private static bool IsPoolContainer(string n)
        {
            if (string.IsNullOrEmpty(n)) return true;
            var s = n.ToLowerInvariant();
            return s.Contains("grid") || s.Contains("collide") || s.Contains("icon")
                || s.Contains("tag") || s.Contains("prefab") || s.Contains("pool");
        }

        private static void ForceShowChildren(Transform root, string tag)        {
            if (!Truthy(root)) return;

            int n = root.childCount;
            int shown = 0;
            for (int i = 0; i < n; i++)
            {
                Transform c;
                try { c = root.GetChild(i); }
                catch (Exception e) { Err(tag + " getchild", e); continue; }
                if (!Truthy(c)) continue;

                try
                {
                    var go = c.gameObject;
                    if (go != null && !go.activeSelf) { go.SetActive(true); shown++; }
                }
                catch (Exception e) { Err(tag + " setActive", e); }
            }

            if (shown > 0)
                Plugin.L.LogInfo("[WulinModKit] " + tag + " force-show children +" + shown + "/" + n);
        }

        /// <summary>递归把整棵子树里的 inactive 节点全部打开</summary>
        private static void ForceShowChildrenAll(Transform root, string tag, int maxDepth)
        {
            if (!Truthy(root)) return;

            int shown = 0, total = 0;
            try { WalkShow(root, 0, maxDepth, ref shown, ref total); }
            catch (Exception e) { Err(tag + " walk", e); }

            if (shown > 0)
                Plugin.L.LogInfo("[WulinModKit] " + tag + " force-show deep +" + shown + "/" + total);
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

        private static void DumpDeep(Transform t, string tag, int depth, int maxDepth, ref int count, int maxNodes)
        {
            if (!Truthy(t) || count >= maxNodes) return;
            count++;

            string pad = new string(' ', depth * 2);
            try
            {
                Plugin.L.LogInfo("[WulinModKit] " + tag + "|" + pad + t.name
                    + " active=" + t.gameObject.activeSelf + " n=" + t.childCount);
            }
            catch { }

            if (depth >= maxDepth) return;

            int n = t.childCount;
            for (int i = 0; i < n; i++)
            {
                Transform c;
                try { c = t.GetChild(i); }
                catch { continue; }
                if (!Truthy(c)) continue;
                DumpDeep(c, tag, depth + 1, maxDepth, ref count, maxNodes);
                if (count >= maxNodes) return;
            }
        }

        private static void DumpWorldMapIds()
        {
            try
            {
                if (!UIWorldMapManager.HasInstance()) { Plugin.L.LogInfo("[WulinModKit] dump worldmap: no manager"); return; }
                var mgr = UIWorldMapManager.Instance;
                if (!Truthy(mgr)) return;

                var list = mgr.listWorldMap;
                if (list == null) { Plugin.L.LogInfo("[WulinModKit] dump worldmap: list null"); return; }

                var sb = new System.Text.StringBuilder();
                sb.Append("[WulinModKit] dump worldmap ids: count=").Append(list.Count).Append(" ->");
                foreach (var kv in list)
                {
                    var wm = kv.Value;
                    if (!Truthy(wm)) { sb.Append(" key=").Append(kv.Key).Append("=null"); continue; }
                    sb.Append(" key=").Append(kv.Key).Append(":id=").Append(wm.worldMapID);
                }
                Plugin.L.LogInfo(sb.ToString());
            }
            catch (Exception e) { Err("dump worldmap ids", e); }
        }

        // ---------- ④ 伤害 ----------

        internal static bool IsPlayerSide(BattleActor actor)
        {
            if (!Truthy(actor)) return false;
            try
            {
                // BattleTeamEnum { Player, Enemy, Allie, Neutral }
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
                if (!Mathf.Approximately(mul, 1f))
                    result *= mul;
            }
            catch (Exception e) { Err("damageMul", e); }
        }
    }
}
