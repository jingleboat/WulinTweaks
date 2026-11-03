#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""审计「剧情分支展开」会在「在队侧」强制播放什么内容。

问题：展平把在队侧内容的出口改接到不在队门、并让两道门无条件判真，
      于是**人不在队时**在队侧也会播。如果在队侧节点是写人物数据的
      （结缘 / 武功 / buff / 关系值 / 队伍），且该角色此时可能没有活实例，
      写入可能落到临时实例上 —— 这就是要审计的暴露面。

做法：对每张图跑同一套门对识别 + region 计算（与 simulate_flatten 一致），
      只统计**真正会被展平**的对（region 非空、不超上限、有对外出口），
      把 region 里每个节点的 m_Name（= 编辑器节点中文名）汇总。

用法：
    python audit_flatten_side.py               # 汇总 + 命中清单
    python audit_flatten_side.py --json out.json
    python audit_flatten_side.py --graph R10049-2
"""
import argparse
import collections
import json
import os
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import scan_flattenable as S

REGION_CAP = 2000        # 与 BranchFlatten.MaxRegion / simulate_flatten.REGION_CAP 对齐

# 会写人物数据的节点名关键词（按编辑器节点中文名匹配）
WRITE_PAT = [
    ("情缘/结缘", ("情缘", "结缘", "Bonds", "bond")),
    ("武功/绝学", ("武功", "绝学", "功法")),
    ("buff", ("buff", "Buff", "增益", "减益")),
    ("关系值", ("关系值", "好感")),
    ("队伍", ("队伍", "伙伴", "入队", "离队", "邀请", "队友")),
    ("属性/数值", ("属性", "数值", "经验", "银两", "物品", "道具")),
]


def write_kind(nodename):
    n = nodename or ""
    for kind, pats in WRITE_PAT:
        for p in pats:
            if p in n:
                return kind
    return None


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=S.DEFAULT_ZIP)
    ap.add_argument("--json")
    ap.add_argument("--graph")
    ap.add_argument("--limit", type=int, default=0)
    args = ap.parse_args()

    if not os.path.exists(args.zip):
        sys.exit("找不到 ModEditor.zip：%s" % args.zip)

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(S.STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()
    if args.graph:
        want = S.STORY_PREFIX + args.graph + ".asset"
        if want not in entries:
            sys.exit("资产里没有 %s" % want)
        entries = [want]
    if args.limit:
        entries = entries[:args.limit]

    print("扫描 %d 张剧情图…" % len(entries), file=sys.stderr)

    type_counter = collections.Counter()          # 节点名 -> 出现在多少个"会被展平的 region"里
    write_counter = collections.Counter()         # 写类节点名 -> 次数
    write_kind_counter = collections.Counter()    # 分类 -> 次数
    graph_with_write = collections.OrderedDict()  # 图名 -> [(pid, [写节点名...])]
    stats = {"graphs": 0, "graphs_with_pairs": 0, "pairs_total": 0,
             "pairs_expandable": 0, "pairs_region_empty": 0,
             "pairs_no_exit": 0, "regions_nodes": 0}

    for entry in entries:
        name = entry[len(S.STORY_PREFIX):-len(".asset")]
        try:
            raw = z.read(entry).decode("utf-8", errors="replace")
        except Exception:
            continue
        if "conditionPort" not in raw:
            continue
        stats["graphs"] += 1
        try:
            g = S.StoryGraph(name, raw)
            pairs = S.find_pairs(g)
        except Exception as e:
            print("  跳过 %s: %s" % (name, e), file=sys.stderr)
            continue
        if not pairs:
            continue
        stats["graphs_with_pairs"] += 1

        # 去重（同 (G0,G1) 多父端口）+ 丢 pid<=0 + 只留 A/B 类（与 simulate_flatten 一致）
        seen = set()
        uniq = []
        for p in pairs:
            if p.get("pid") is None or p["pid"] <= 0:
                continue
            key = (p["zero_gate"], p["one_gate"])
            if key in seen:
                continue
            seen.add(key)
            if p.get("kind") not in ("A", "B"):
                continue
            uniq.append(p)
        if not uniq:
            continue

        outs = {fid: g.outs(fid) for fid in g.nodes}

        def reach(start):
            s = {start}
            st = [start]
            while st:
                n = st.pop()
                for t in outs.get(n, ()):
                    if t not in s:
                        s.add(t)
                        st.append(t)
            return s

        regions = []
        for p in uniq:
            g0, g1 = p["zero_gate"], p["one_gate"]
            regions.append((p, (reach(g0) - reach(g1)) - {g0, g1}))

        for p, region in regions:
            stats["pairs_total"] += 1
            if not region:
                stats["pairs_region_empty"] += 1
                continue
            if len(region) > REGION_CAP:
                stats["pairs_region_empty"] += 1
                continue
            g1 = p["one_gate"]
            exits = []
            for n in region:
                for t in outs.get(n, ()):
                    if t in region or t == g1:
                        continue
                    exits.append((n, t))
            if not exits:
                stats["pairs_no_exit"] += 1
                continue

            stats["pairs_expandable"] += 1
            stats["regions_nodes"] += len(region)

            names = []
            for fid in region:
                body = g.nodes.get(fid) or ""
                nm = S.yaml_unquote(S.top_field(body, "m_Name") or "")
                if g.is_story(fid):
                    nm = "「播放剧情」 " + (g.scen_key(fid) or "")
                names.append(nm or str(fid))
            for nm in set(names):
                type_counter[nm] += 1

            hits = []
            for nm in names:
                k = write_kind(nm)
                if k:
                    hits.append((k, nm))
            if hits:
                for k, nm in hits:
                    write_counter[nm] += 1
                    write_kind_counter[k] += 1
                graph_with_write.setdefault(name, []).append(
                    (p["pid"], sorted(set(nm for _, nm in hits))))

    # ---------------- 输出 ----------------
    print()
    print("=" * 72)
    print("图 %d 张（含门对 %d 张）；门对 %d 个" %
          (stats["graphs"], stats["graphs_with_pairs"], stats["pairs_total"]))
    print("  会被展平（改线的）门对：%d 个，覆盖 %d 个节点" %
          (stats["pairs_expandable"], stats["regions_nodes"]))
    print("  region 为空/过大：%d 个；region 没有对外出口：%d 个" %
          (stats["pairs_region_empty"], stats["pairs_no_exit"]))
    print()
    print("在队侧 region 里出现最多的节点名（Top 30）：")
    for nm, c in type_counter.most_common(30):
        print("  %5d  %s" % (c, nm[:90]))
    print()
    print("=" * 72)
    print("写人物数据类节点（按分类）：")
    if not write_kind_counter:
        print("  （无命中）")
    for k, c in write_kind_counter.most_common():
        print("  %5d  %s" % (c, k))
    print()
    print("命中节点名明细（Top 40）：")
    for nm, c in write_counter.most_common(40):
        print("  %5d  %-10s %s" % (c, write_kind(nm), nm[:80]))
    print()
    print("=" * 72)
    print("受影响的图（%d 张，只列前 40）：" % len(graph_with_write))
    for gn, lst in list(graph_with_write.items())[:40]:
        pids = ",".join(str(x) for x, _ in lst)
        names = sorted(set(n for _, ns in lst for n in ns))
        print("  %-16s pid=%-22s %s" % (gn, pids, " / ".join(names)[:120]))

    if args.json:
        payload = {
            "stats": stats,
            "node_names": dict(type_counter),
            "write_nodes": dict(write_counter),
            "write_kinds": dict(write_kind_counter),
            "graphs": {k: [{"pid": x, "nodes": ns} for x, ns in v]
                       for k, v in graph_with_write.items()},
        }
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump(payload, f, ensure_ascii=False, indent=2)
        print("\n结果已写入 %s" % args.json)


if __name__ == "__main__":
    main()
