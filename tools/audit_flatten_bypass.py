#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""审计「展平改线会绕过哪些节点」—— 回答"事件触发条件跟队友无关，为什么也被影响"。

展平的规则：region = reach(G0) − reach(G1) − {G0,G1}，
          把 region 内**指向 region 外的边**全部改指 G1（不在队门）。
于是原来 region → T 的那条路变成 region → G1 → …，**T 及其下游不再被访问**
（如果 T 只有 region 这一条入边）。

如果 T 是「添加标记 / 设置自定义变量 / 写入记事本 / 播放剧情」这类节点，
依赖它的其它事件就永远不会触发 —— 这跟「角色是否在队」一点关系都没有。

用法：
    python audit_flatten_bypass.py                # 汇总：被绕过的目标节点类型
    python audit_flatten_bypass.py --json out.json
    python audit_flatten_bypass.py --graph R10049-2
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

# 这些节点一旦被绕过，往往会让别的剧情失去触发条件
SIDE_EFFECT = {
    "添加标记", "删除标记", "设置自定义变量", "写入记事本", "追加简介",
    "显隐大地图图标", "发生预设战斗", "流程判断", "播放剧情", "执行剧情",
    # 2026-11-04 补：这几类同样会写存档 / 推进全局状态，漏了它们会低估影响面
    "时间流逝", "改变NPC关系值", "强制NPC死亡", "获得/扣除玩家背包物品",
    "获得/扣除NPC背包物品", "增减buff/debuff", "改变角色属性", "改变队伍属性",
    "改变江湖历练", "改变势力关系", "改变玩家势力", "改变名声点数", "选项",
}


def top_str(body, name):
    import re
    m = re.search(r'^\s{2}' + re.escape(name) + r':\s*(.*)$', body, re.M)
    return S.yaml_unquote(m.group(1)) if m else None


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=S.DEFAULT_ZIP)
    ap.add_argument("--json")
    ap.add_argument("--graph")
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(S.STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()
    if args.graph:
        want = S.STORY_PREFIX + args.graph + ".asset"
        entries = [want] if want in entries else []

    target_type = collections.Counter()     # 被改线目标的节点类型
    orphan_type = collections.Counter()     # 改线后彻底孤立（入边全来自 region）的类型
    side_hits = collections.Counter()       # 落在"副作用"类里的
    pairs = 0
    exits_total = 0
    details = []

    for entry in entries:
        name = entry[len(S.STORY_PREFIX):-len(".asset")]
        raw = z.read(entry).decode("utf-8", errors="replace")
        if "conditionPort" not in raw:
            continue
        try:
            g = S.StoryGraph(name, raw)
            raw_pairs = S.find_pairs(g)
        except Exception:
            continue
        if not raw_pairs:
            continue

        seen, uniq = set(), []
        for p in raw_pairs:
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
        ins = collections.defaultdict(set)
        for s, ts in outs.items():
            for t in ts:
                ins[t].add(s)

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
            pairs += 1

            for src, tgt in exits:
                exits_total += 1
                body = g.nodes.get(tgt) or ""
                nm = S.yaml_unquote(S.top_field(body, "m_Name") or "") or ""
                if g.is_story(tgt):
                    nm = "「播放剧情」" + (g.scen_key(tgt) or "")
                target_type[nm] += 1

                # 该目标是否只剩 region 内的入边 → 改线后彻底走不到
                outside = [x for x in ins.get(tgt, ()) if x not in region]
                orphan = not outside
                if orphan:
                    orphan_type[nm] += 1
                if any(k in nm for k in SIDE_EFFECT):
                    if orphan:
                        side_hits[nm] += 1
                    details.append({"graph": name, "pid": p["pid"], "orphan": orphan,
                                    "from": S.yaml_unquote(S.top_field(g.nodes.get(src) or "", "m_Name") or "") or str(src),
                                    "to": nm})

    print("会改线的门对：%d 个；被改指的对外边：%d 条\n" % (pairs, exits_total))
    print("=" * 78)
    print("被改指的**目标节点**类型（全部）：")
    for nm, c in target_type.most_common(20):
        print("  %5d  %s" % (c, nm[:70]))

    print("\n" + "=" * 78)
    print("改线后**彻底走不到**的目标（入边全部来自 region）：")
    if not orphan_type:
        print("  （无）")
    for nm, c in orphan_type.most_common(20):
        mark = "  ★副作用" if any(k in nm for k in SIDE_EFFECT) else ""
        print("  %5d  %s%s" % (c, nm[:70], mark))

    print("\n" + "=" * 78)
    print("其中属于「标记 / 变量 / 战斗 / 剧情」类的（会让别的剧情失去触发条件）：%d 条" % len(details))
    seen_d = set()
    for d in details:
        k = (d["graph"], d["pid"], d["to"])
        if k in seen_d:
            continue
        seen_d.add(k)
        print("  %-16s pid=%-7s %s → %s" % (d["graph"], d["pid"], d["from"][:20], d["to"][:40]))
        if len(seen_d) >= 40:
            print("  …（共 %d 条）" % len(details))
            break

    if args.json:
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump({"pairs": pairs, "exits": exits_total,
                       "target_types": dict(target_type),
                       "orphan_types": dict(orphan_type),
                       "details": details}, f, ensure_ascii=False, indent=2)
        print("\n已写入 %s" % args.json)


if __name__ == "__main__":
    main()
