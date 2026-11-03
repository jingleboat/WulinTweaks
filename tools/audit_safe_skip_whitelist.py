#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""统计「展平只允许绕过纯分支节点」后，还剩多少门对能改线。

背景（2026-11-04 定案）：
  展平改线的本质是「region 对外出口改指到不在队门」，**原目标被跳过**。
  如果原目标写的是存档级状态（时间流逝 / 标记 / 变量 / 人物数据…），跳过它就影响别的图。
  之前的做法是"黑名单"（列出所有写状态的节点名），但资产包不止 ModEditor.zip
  （R10136 一族 280 个资产在 aa/config_assets_all.bundle 里），黑名单必然漏。
  所以改成**白名单**：只有明确「纯分支、不写任何状态」的节点才允许被绕过。

本脚本给出白名单方案的代价：全量里还剩多少门对能改线。
  纯分支 = 流程判断 / 选项 / 注释（不写存档、不推进时间、不改人物）

用法：
    python audit_safe_skip_whitelist.py
    python audit_safe_skip_whitelist.py --json out.json
"""
import argparse
import collections
import json
import os
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import scan_flattenable as S

REGION_CAP = 2000

# 允许被绕过的：纯流程分支，不写任何存档状态
SAFE_SKIP = {"流程判断", "选项", "注释", "「播放剧情」"}


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=S.DEFAULT_ZIP)
    ap.add_argument("--json")
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(S.STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()

    total = safe_pairs = 0
    blocked = collections.Counter()      # 被拦的原因：出口目标名
    blocked_graphs = collections.Counter()
    safe_graphs = set()
    per_graph = collections.Counter()

    for entry in entries:
        name = entry[len(S.STORY_PREFIX):-len(".asset")]
        raw = z.read(entry).decode("utf-8", errors="replace")
        if "conditionPort" not in raw:
            continue
        try:
            g = S.StoryGraph(name, raw)
            pairs = S.find_pairs(g)
        except Exception:
            continue
        if not pairs:
            continue

        seen, uniq = set(), []
        for p in pairs:
            if p.get("pid") is None or p["pid"] <= 0:
                continue
            k = (p["zero_gate"], p["one_gate"])
            if k in seen:
                continue
            seen.add(k)
            if p.get("kind") not in ("A", "B"):
                continue
            uniq.append(p)
        if not uniq:
            continue

        outs = {f: g.outs(f) for f in g.nodes}

        def reach(start):
            r, st = {start}, [start]
            while st:
                n = st.pop()
                for t in outs.get(n, ()):
                    if t not in r:
                        r.add(t)
                        st.append(t)
            return r

        for p in uniq:
            g0, g1 = p["zero_gate"], p["one_gate"]
            region = (reach(g0) - reach(g1)) - {g0, g1}
            if not region or len(region) > REGION_CAP:
                continue
            exits = [(n, t) for n in region for t in outs.get(n, ())
                     if t not in region and t != g1]
            if not exits:
                continue
            total += 1

            bad = []
            for src, tgt in exits:
                body = g.nodes.get(tgt) or ""
                nm = S.yaml_unquote(S.top_field(body, "m_Name") or "") or ""
                if g.is_story(tgt):
                    nm = "「播放剧情」"
                if nm not in SAFE_SKIP:
                    bad.append(nm)
            if bad:
                blocked_graphs[name] += 1
                for nm in set(bad):
                    blocked[nm] += 1
            else:
                safe_pairs += 1
                safe_graphs.add(name)
                per_graph[name] += 1

    print("可改线的门对（region 非空 + 有对外出口）：%d" % total)
    print("  白名单下仍可改线：%d 个（%.0f%%），涉及 %d 张图"
          % (safe_pairs, 100.0 * safe_pairs / max(1, total), len(safe_graphs)))
    print("  被拦：           %d 个，涉及 %d 张图" % (total - safe_pairs, len(blocked_graphs)))
    print()
    print("被拦的原因（出口目标节点名 → 多少个门对踩到它）：")
    for nm, c in blocked.most_common(25):
        print("  %5d  %s" % (c, nm))
    print()
    print("仍可改线的图里，改线最多的前 15：")
    for nm, c in per_graph.most_common(15):
        print("  %5d  %s" % (c, nm))

    if args.json:
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump({"total": total, "safe": safe_pairs,
                       "blocked": dict(blocked),
                       "blocked_graphs": dict(blocked_graphs),
                       "safe_graphs": sorted(safe_graphs),
                       "per_graph": dict(per_graph)}, f, ensure_ascii=False, indent=2)
        print("\n已写入 %s" % args.json)


if __name__ == "__main__":
    main()
