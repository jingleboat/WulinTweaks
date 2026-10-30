using System;
using System.Reflection;
using WuLin;

namespace WulinTweaks
{
    /// <summary>
    /// v1.11.29：大地图「真解锁」。
    ///
    /// 为什么要有这个：从 1.9.x 起「大地图地区与地点全解锁」只改**显示层**
    /// （Harmony 把 `UIWorldMapManager.IsMapEnable` 判真、`UIWorldMap.SetCityVisible` 强制 isShow、
    /// 再把 `CityIcon` 子节点 SetActive），存档里的 `SaveObjectMapManager.listShowIcon` 一直没变。
    /// 而剧情节点「判断大地图图标显示 mapID=X」读的正是那份**存档数据**，于是
    /// 曼陀罗 R10021-4（玉门关 5059）、M2221-12 问路（炎城 20400）这类事件会被永久卡死 ——
    /// 图标看着是亮的，剧情却永远判不过。
    ///
    /// v1.11.29 改成真写：把「大地图可显示的地点图标」全集（LocData 里全部 WMapName_&lt;id&gt;，
    /// 343 个）逐个 Add 进 `listShowIcon`。游戏一存盘就是永久解锁。
    /// 显示层那套补丁保留着（应急/首帧不掉帧），但剧情门从此按真实数据走。
    /// </summary>
    internal static class MapTrueUnlock
    {
        private static readonly int[] Icons =
        {
              1301,   1400,   1200,   5008,   2010,   2060,   2080,  20100,   2140,   2020,   2030,   2040,
              2110,   5025,  20200,   2050,   2070,   2090,   5009,  20300,   5033,   6000,   5060,   5063,
              2100,   2170,   2130,   5015,   5016,   1100,   5059,   2160,   2220,    500,    600,   1500,
              1600,   2120,   2150,   2155,   2180,   2190,   2200,   2230,   2240,   2250,   2270,   2280,
              2290,   2299,   5001,   5003,   5005,   5007,   5011,   5012,   5014,   5029,   5032,   5037,
              5039,   5046,   5049,   5050,   5051,   5052,   5061,   5062,   5064,   5065,   5068,  10040,
             10050,  10060,  10070,  10100,  10110,  10120,  10140,  10150,  10160,  10170,  10180,  20400,
             20500,   1000,   1001,   1002,   1003,   1004,   1005,   1006,   1007,   1101,   1102,   1103,
              1104,   1105,   1106,   1107,   1108,   1109,   1201,   1202,   1203,   1204,   1300,   1302,
              1401,   1402,   1501,   1700,   2000,   2011,   2012,   2013,   2014,   2015,   2016,   2017,
              2018,   2021,   2022,   2023,   2024,   2025,   2026,   2027,   2028,   2031,   2032,   2041,
              2042,   2043,   2051,   2052,   2053,   2061,   2062,   2063,   2064,   2065,   2071,   2072,
              2073,   2074,   2081,   2082,   2083,   2091,   2092,   2101,   2102,   2111,   2121,   2122,
              2131,   2139,   2151,   2152,   2153,   2156,   2157,   2158,   2159,   2161,   2231,   2241,
              2251,   2252,   2253,   2254,   2255,   2271,   2272,   2273,   2274,   2279,   2281,   2282,
              2300,   2310,   2998,   2999,   5002,   5004,   5006,   5013,   5018,   5019,   5020,   5022,
              5023,   5026,   5027,   5030,   5031,   5034,   5035,   5036,   5038,   5043,   5053,   5054,
              5055,   5056,   5057,   5058,   5066,   5067,   6001,   6002,  10010,  10020,  10030,  10031,
             10038,  10039,  10071,  10080,  10130,  20101,  20102,  20103,  20104,  20105,  20106,  20107,
             20108,  20109,  20110,  20111,  20112,  20113,  20114,  20115,  20116,  20117,  20118,  20119,
             20120,  20121,  20122,  20123,  20124,  20195,  20196,  20197,  20198,  20199,  20201,  20202,
             20203,  20204,  20205,  20206,  20207,  20208,  20209,  20210,  20211,  20212,  20213,  20214,
             20215,  20216,  20217,  20218,  20219,  20220,  20221,  20222,  20223,  20224,  20225,  20226,
             20227,  20228,  20229,  20297,  20298,  20301,  20302,  20303,  20304,  20305,  20306,  20307,
             20308,  20309,  20310,  20311,  20312,  20313,  20314,  20315,  20316,  20317,  20318,  20319,
             20320,  20321,  20322,  20323,  20324,  20325,  20326,  20327,  20328,  20329,  20330,  20331,
             20332,  20333,  20334,  20335,  20336,  20397,  20398,  20401,  20402,  20420,  20491,  20492,
             20501,  20502,  20503,  20504,  20505,  20506,  20507,  20508,  20509,  20510,  20511,  20512,
             20513,  20514,  20515,  20516,  20517,  20518,  20519
        };

        private static bool _done;
        private static int _logs;

        internal static void Reset() { _done = false; }

        internal static void Tick()
        {
            if (!Plugin.MapMaster) return;   /* v1.11.30：地图三合一总开关 */
            if (_done) return;

            object so = FindSaveObject();
            if (so == null)
            {
                if (_logs++ < 10) Plugin.L.LogWarning("[map] 取不到 SaveObjectMapManager，稍后再试");
                return;
            }

            object list = GetMember(so, "listShowIcon");
            if (list == null)
            {
                _done = true;
                Plugin.L.LogWarning("[map] SaveObjectMapManager 上没有 listShowIcon 字段，跳过真解锁");
                return;
            }

            MethodInfo contains = list.GetType().GetMethod("Contains", new[] { typeof(int) });
            MethodInfo add = list.GetType().GetMethod("Add", new[] { typeof(int) });
            if (add == null)
            {
                _done = true;
                Plugin.L.LogWarning("[map] listShowIcon 上取不到 Add(int)，跳过真解锁");
                return;
            }

            int added = 0;
            for (int i = 0; i < Icons.Length; i++)
            {
                int id = Icons[i];
                try
                {
                    if (contains != null && (bool)contains.Invoke(list, new object[] { id })) continue;
                    add.Invoke(list, new object[] { id });
                    added++;
                }
                catch (Exception e)
                {
                    if (_logs++ < 6) Plugin.L.LogWarning("[map] add " + id + " 失败: " + e.Message);
                }
            }

            _done = true;
            Plugin.L.LogInfo("[map] 大地图真解锁：listShowIcon +" + added + "（目标 " + Icons.Length + " 个）");
        }

        /// <summary>从 UIWorldMapManager / MapManager 里反射找 SaveObjectMapManager（字段名随版本变，按类型名匹配）。</summary>
        private static object FindSaveObject()
        {
            object[] roots = new object[2];
            try { roots[0] = UIWorldMapManager.Instance; } catch { }
            try { roots[1] = MapManager.Instance; } catch { }

            foreach (object root in roots)
            {
                if (root == null) continue;
                object hit = Search(root, 0);
                if (hit != null) return hit;
            }
            return null;
        }

        private static object Search(object root, int depth)
        {
            if (root == null || depth > 2) return null;
            Type t = root.GetType();
            FieldInfo[] fs;
            try { fs = t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic); }
            catch { return null; }

            foreach (FieldInfo f in fs)
            {
                object v;
                try { v = f.GetValue(root); } catch { continue; }
                if (v == null) continue;
                string n;
                try { n = v.GetType().Name; } catch { continue; }
                if (n == "SaveObjectMapManager") return v;
            }
            foreach (FieldInfo f in fs)
            {
                object v;
                try { v = f.GetValue(root); } catch { continue; }
                if (v == null) continue;
                object hit = Search(v, depth + 1);
                if (hit != null) return hit;
            }
            return null;
        }

        private static object GetMember(object obj, string name)
        {
            Type t = obj.GetType();
            FieldInfo f = t.GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (f != null) { try { return f.GetValue(obj); } catch { return null; } }
            PropertyInfo p = t.GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (p != null) { try { return p.GetValue(obj); } catch { return null; } }
            return null;
        }
    }
}
