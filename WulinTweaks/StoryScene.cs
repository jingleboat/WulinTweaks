using System;
using System.Collections.Generic;

namespace WulinTweaks
{
    /// <summary>
    /// 记录每张剧情图「最近一次播放的 ScenarioKey」。
    ///
    /// 用途：让「固定不放宽名单」除了按图名匹配，还能按 **ScenarioKey（场景节点）** 匹配 ——
    /// 写在名单里的场景键（例如 R10049-10_0_0）在它所属那张图的判定里同样生效。
    ///
    /// 取键方式：StoryScenarioNode 的 ScenarioKey 字段（PC 走 Il2CppNative 按字段名读，
    /// 手机端该字段固定偏移 0x60，与 dump.cs 一致）。
    /// </summary>
    internal static class StoryScene
    {
        private const int MaxGraphs = 512;
        private static readonly Dictionary<string, string> _last =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>最近一次播放的场景键（仅用于日志/排查，不参与跨图匹配）。</summary>
        internal static string Current;

        internal static void Record(string graph, string key)
        {
            if (string.IsNullOrEmpty(key)) return;
            Current = key;
            if (string.IsNullOrEmpty(graph)) return;
            if (_last.Count > MaxGraphs) _last.Clear();
            _last[graph] = key;
        }

        /// <summary>这张图最近播放的场景键；没有记录就返回 null（**不回退到别的图**，
        /// 否则 A 图的场景键会误伤 B 图）。</summary>
        internal static string LastOf(string graph)
        {
            if (string.IsNullOrEmpty(graph)) return null;
            return _last.TryGetValue(graph, out var k) ? k : null;
        }

        internal static void Clear() { _last.Clear(); Current = null; }
    }
}
