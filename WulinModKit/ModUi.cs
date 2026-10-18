using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WulinModKit
{
    /// <summary>
    /// 自建 UGUI 面板。
    /// 不用自建 MonoBehaviour（IL2CPP 注入的组件收不到 Update/OnGUI 消息），
    /// 也不用 UnityEvent 的 AddListener（IL2CPP 下委托转换会失败），
    /// 点击靠 UpdateTick 里手工做 RectTransform 命中检测。
    /// </summary>
    internal static class ModUi
    {
        private static bool _created;
        private static bool _visible = true;
        private static GameObject _canvasGo;
        private static GameObject _panel;
        private static Font _font;

        private class RowItem
        {
            public RectTransform Rt;
            public Text Txt;
            public Func<bool> Get;
            public Action<bool> Set;
            public string Label;
        }

        private static readonly List<RowItem> _rows = new List<RowItem>();
        private static string _keyRaw;
        private static KeyCode _key;

        internal static void TryCreate()
        {
            if (_created) return;
            _created = true;

            try { Create(); }
            catch (Exception e) { ModKit.Err("ui create", e); }
        }

        private static void Create()
        {
            try
            {
                _font = Font.CreateDynamicFontFromOSFont(
                    new[] { "Microsoft YaHei", "SimHei", "SimSun" }, 14);
            }
            catch { _font = null; }

            _canvasGo = new GameObject("WulinModKitCanvas");
            UnityEngine.Object.DontDestroyOnLoad(_canvasGo);

            var canvas = _canvasGo.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 30000;

            var scaler = _canvasGo.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            scaler.matchWidthOrHeight = 0.5f;

            _canvasGo.AddComponent<GraphicRaycaster>();

            _panel = new GameObject("Panel");
            _panel.transform.SetParent(_canvasGo.transform, false);

            var prt = _panel.AddComponent<RectTransform>();
            prt.anchorMin = new Vector2(0f, 1f);
            prt.anchorMax = new Vector2(0f, 1f);
            prt.pivot = new Vector2(0f, 1f);
            prt.anchoredPosition = new Vector2(20f, -20f);
            prt.sizeDelta = new Vector2(330f, 0f);

            var bg = _panel.AddComponent<Image>();
            bg.color = new Color(0f, 0f, 0f, 0.85f);

            var vlg = _panel.AddComponent<VerticalLayoutGroup>();
            vlg.padding = new RectOffset(12, 12, 10, 10);
            vlg.spacing = 4f;
            vlg.childControlWidth = true;
            vlg.childControlHeight = false;
            vlg.childForceExpandWidth = true;
            vlg.childForceExpandHeight = false;

            var fitter = _panel.AddComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            Header("[1] 场景高亮");
            Row("可交互物常亮", () => Plugin.AlwaysHighlight.Value, v =>
            {
                Plugin.AlwaysHighlight.Value = v;
                if (v) ModKit.ForceHighlightNow();
                else ModKit.ClearHighlights();
            });
            Row("地面物品只亮可拾取", () => Plugin.MiscRequirePickable.Value,
                v => Plugin.MiscRequirePickable.Value = v);

            Header("[2] 地图");
            Row("大地图地区与地点全解锁", () => Plugin.UnlockWorldMap.Value,
                v => Plugin.UnlockWorldMap.Value = v);
            Row("马车地图全解锁", () => Plugin.UnlockCabMap.Value,
                v => Plugin.UnlockCabMap.Value = v);

            Header("[3] 剧情");
            Row("忽略队伍角色条件", () => Plugin.IgnoreTeamCondition.Value, v =>
            {
                Plugin.IgnoreTeamCondition.Value = v;
                if (v) ModKit.ForceIgnoreTeamCondition();
                else ModKit.RestoreTeamCondition();
            });

            Footer("热键 " + Plugin.UiToggleKey.Value + "（配置文件可改）");

            Plugin.L.LogInfo("[WulinModKit] UI created (self canvas), font=" + (_font != null));
        }

        private static Text NewText(GameObject parent, string content, Color color, int size)
        {
            var go = new GameObject("txt");
            go.transform.SetParent(parent.transform, false);

            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = Vector2.zero;
            rt.anchorMax = Vector2.one;
            rt.offsetMin = new Vector2(8f, 0f);
            rt.offsetMax = new Vector2(-8f, 0f);

            var t = go.AddComponent<Text>();
            t.text = content;
            t.alignment = TextAnchor.MiddleLeft;
            t.color = color;
            t.fontSize = size;
            t.horizontalOverflow = HorizontalWrapMode.Overflow;
            if (_font != null) t.font = _font;
            return t;
        }

        private static void Header(string text)
        {
            var go = new GameObject("hdr");
            go.transform.SetParent(_panel.transform, false);
            go.AddComponent<RectTransform>();
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 22f;
            NewText(go, text, new Color(1f, 0.85f, 0.4f), 14);
        }

        private static void Footer(string text)
        {
            var go = new GameObject("ftr");
            go.transform.SetParent(_panel.transform, false);
            go.AddComponent<RectTransform>();
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 18f;
            NewText(go, text, new Color(0.7f, 0.7f, 0.7f), 11);
        }

        private static void Row(string label, Func<bool> get, Action<bool> set)
        {
            var go = new GameObject("row");
            go.transform.SetParent(_panel.transform, false);

            var rt = go.AddComponent<RectTransform>();
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 26f;

            var img = go.AddComponent<Image>();
            img.color = new Color(0.16f, 0.16f, 0.16f, 0.9f);

            string content = (get() ? "[√] " : "[  ] ") + label;
            var txt = NewText(go, content, Color.white, 14);

            _rows.Add(new RowItem { Rt = rt, Txt = txt, Get = get, Set = set, Label = label });
        }

        /// <summary>由 RoamingManager.Update 每帧驱动</summary>
        internal static void UpdateTick()
        {
            try
            {
                if (Input.GetKeyDown(ParseKey(Plugin.UiToggleKey.Value)))
                {
                    _visible = !_visible;
                    if (_panel != null) _panel.SetActive(_visible);
                }
            }
            catch (Exception e) { ModKit.Err("ui hotkey", e); }

            if (!_visible) return;

            try
            {
                if (!Input.GetMouseButtonDown(0)) return;
                var m = Input.mousePosition;
                var mp = new Vector2(m.x, m.y);

                for (int i = 0; i < _rows.Count; i++)
                {
                    var r = _rows[i];
                    if (r.Rt == null) continue;
                    if (!RectTransformUtility.RectangleContainsScreenPoint(r.Rt, mp, null)) continue;

                    bool nv = !r.Get();
                    r.Set(nv);
                    if (r.Txt != null) r.Txt.text = (nv ? "[√] " : "[  ] ") + r.Label;
                    break;
                }
            }
            catch (Exception e) { ModKit.Err("ui click", e); }
        }

        private static KeyCode ParseKey(string raw)
        {
            if (raw == _keyRaw) return _key;
            _keyRaw = raw;
            _key = Enum.TryParse<KeyCode>(raw, true, out var k) ? k : KeyCode.BackQuote;
            return _key;
        }
    }
}
