using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WulinTweaks
{
    /// <summary>
    /// 自建 UGUI 面板。
    /// 不用自建 MonoBehaviour（IL2CPP 注入的组件收不到 Update/OnGUI 消息），
    /// 也不用 UnityEvent 的 AddListener（IL2CPP 下委托转换会失败），
    /// 点击靠 UpdateTick 里手工做 RectTransform 命中检测。
    ///
    /// 布局：Canvas → Panel(定高，最高 MaxPanelHeight) → Viewport(RectMask2D) → Content(自动高度)。
    /// 面板高度跟着内容收缩，超过上限就裁切 + 滚轮滚动，
    /// 这样任何分辨率下面板都不会顶出屏幕。
    /// </summary>
    internal static class ModUi
    {
        private const float PanelWidth = 340f;
        private const float MaxPanelHeight = 660f;      // 1080 参考高度内一定放得下
        private const float ScrollStep = 36f;

        private static bool _created;
        private static bool _visible = false;
        private static GameObject _canvasGo;
        private static GameObject _panel;
        private static RectTransform _panelRt;
        private static RectTransform _viewRt;
        private static RectTransform _contentRt;
        private static Font _font;

        private static float _scroll;
        private static bool _layoutDirty = true;

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

            _canvasGo = new GameObject("WulinTweaksCanvas");
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

            // ---- Panel ----
            _panel = new GameObject("Panel");
            _panel.transform.SetParent(_canvasGo.transform, false);

            _panelRt = _panel.AddComponent<RectTransform>();
            _panelRt.anchorMin = new Vector2(0f, 1f);
            _panelRt.anchorMax = new Vector2(0f, 1f);
            _panelRt.pivot = new Vector2(0f, 1f);
            _panelRt.anchoredPosition = new Vector2(20f, -20f);
            _panelRt.sizeDelta = new Vector2(PanelWidth, 120f);

            var bg = _panel.AddComponent<Image>();
            bg.color = new Color(0f, 0f, 0f, 0.85f);

            // ---- Viewport（裁切 + 滚动窗口）----
            var view = new GameObject("Viewport");
            view.transform.SetParent(_panel.transform, false);
            _viewRt = view.AddComponent<RectTransform>();
            _viewRt.anchorMin = Vector2.zero;
            _viewRt.anchorMax = Vector2.one;
            _viewRt.pivot = new Vector2(0.5f, 0.5f);
            _viewRt.offsetMin = new Vector2(8f, 8f);
            _viewRt.offsetMax = new Vector2(-8f, -8f);
            view.AddComponent<RectMask2D>();

            // ---- Content（自动高度，按需滚动）----
            var content = new GameObject("Content");
            content.transform.SetParent(view.transform, false);
            _contentRt = content.AddComponent<RectTransform>();
            _contentRt.anchorMin = new Vector2(0f, 1f);
            _contentRt.anchorMax = new Vector2(1f, 1f);
            _contentRt.pivot = new Vector2(0.5f, 1f);
            _contentRt.anchoredPosition = Vector2.zero;
            _contentRt.sizeDelta = new Vector2(0f, 0f);

            var vlg = content.AddComponent<VerticalLayoutGroup>();
            vlg.padding = new RectOffset(2, 2, 2, 2);
            vlg.spacing = 3f;
            vlg.childControlWidth = true;
            vlg.childControlHeight = true;
            vlg.childForceExpandWidth = true;
            vlg.childForceExpandHeight = false;

            var fitter = content.AddComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            Header("[1] 场景高亮");
            Row("可交互物常亮", () => Plugin.AlwaysHighlight.Value, v =>
            {
                Plugin.AlwaysHighlight.Value = v;
                if (v) ModKit.ForceHighlightNow();
                else ModKit.ClearHighlights();
            });

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

            Header("[4] 易物");
            Row("作价恒占优（空手也能成交）", () => Plugin.TradeAlwaysWin.Value,
                v => Plugin.TradeAlwaysWin.Value = v);
            Row("列出必掉物＋暗取池", () => Plugin.TradePools.Value,
                v => Plugin.TradePools.Value = v);
            Row("确认时搬空 NPC", () => Plugin.TradeTakeAll.Value,
                v => Plugin.TradeTakeAll.Value = v);

            Footer("热键 " + Plugin.UiToggleKey.Value + " · 滚轮翻页");

            Relayout();

            if (_panel != null) _panel.SetActive(_visible);
            Plugin.L.LogInfo("[WulinTweaks] UI created (hidden). 按 " + Plugin.UiToggleKey.Value
                             + " 呼出面板, font=" + (_font != null));
        }

        /// <summary>内容变了之后重算面板高度与滚动范围</summary>
        private static void Relayout()
        {
            try
            {
                if (_contentRt == null || _panelRt == null) return;

                LayoutRebuilder.ForceRebuildLayoutImmediate(_contentRt);

                float ch = _contentRt.rect.height;
                float h = Mathf.Clamp(ch + 16f, 80f, MaxPanelHeight);
                _panelRt.sizeDelta = new Vector2(PanelWidth, h);

                float viewH = Mathf.Max(1f, h - 16f);
                float maxScroll = Mathf.Max(0f, ch - viewH);
                _scroll = Mathf.Clamp(_scroll, 0f, maxScroll);
                _contentRt.anchoredPosition = new Vector2(0f, _scroll);

                _layoutDirty = false;
            }
            catch (Exception e) { ModKit.Err("ui relayout", e); }
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
            go.transform.SetParent(_contentRt.transform, false);
            go.AddComponent<RectTransform>();
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 20f;
            le.preferredHeight = 20f;
            NewText(go, text, new Color(1f, 0.85f, 0.4f), 14);
            _layoutDirty = true;
        }

        private static void Footer(string text)
        {
            var go = new GameObject("ftr");
            go.transform.SetParent(_contentRt.transform, false);
            go.AddComponent<RectTransform>();
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 18f;
            le.preferredHeight = 18f;
            NewText(go, text, new Color(0.7f, 0.7f, 0.7f), 11);
            _layoutDirty = true;
        }

        private static void Row(string label, Func<bool> get, Action<bool> set)
        {
            var go = new GameObject("row");
            go.transform.SetParent(_contentRt.transform, false);

            var rt = go.AddComponent<RectTransform>();
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 24f;
            le.preferredHeight = 24f;

            var img = go.AddComponent<Image>();
            img.color = new Color(0.16f, 0.16f, 0.16f, 0.9f);

            string content = (get() ? "[√] " : "[  ] ") + label;
            var txt = NewText(go, content, Color.white, 14);

            _rows.Add(new RowItem { Rt = rt, Txt = txt, Get = get, Set = set, Label = label });
            _layoutDirty = true;
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
                    if (_visible) _layoutDirty = true;
                }
            }
            catch (Exception e) { ModKit.Err("ui hotkey", e); }

            if (!_visible) return;

            try
            {
                if (_layoutDirty) Relayout();
            }
            catch (Exception e) { ModKit.Err("ui layout tick", e); }

            try
            {
                var m = Input.mousePosition;
                var mp = new Vector2(m.x, m.y);
                bool overPanel = _panelRt != null && _viewRt != null
                                 && RectTransformUtility.RectangleContainsScreenPoint(_panelRt, mp, null)
                                 && RectTransformUtility.RectangleContainsScreenPoint(_viewRt, mp, null);

                if (overPanel)
                {
                    float wheel = Input.mouseScrollDelta.y;
                    if (Mathf.Abs(wheel) > 0.01f)
                    {
                        _scroll -= wheel * ScrollStep;
                        Relayout();
                    }
                }

                if (!Input.GetMouseButtonDown(0)) return;

                for (int i = 0; i < _rows.Count; i++)
                {
                    var r = _rows[i];
                    if (r.Rt == null) continue;
                    // 必须同时落在可视区内，否则滚出视野的条目也会被点中
                    if (_viewRt == null || !RectTransformUtility.RectangleContainsScreenPoint(_viewRt, mp, null)) continue;
                    if (!RectTransformUtility.RectangleContainsScreenPoint(r.Rt, mp, null)) continue;

                    bool nv = !r.Get();
                    r.Set(nv);
                    if (r.Txt != null) r.Txt.text = (nv ? "[√] " : "[  ] ") + r.Label;

                    // 立刻落盘，保证下次启动沿用上次状态
                    try { if (Plugin.Inst != null) Plugin.Inst.Config.Save(); }
                    catch (Exception e) { ModKit.Err("ui save cfg", e); }

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
