#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""统计「剧情分支展开」在队侧 region 里，写人物数据的节点用的是**按 id** 还是**按队位**。

为什么关键：
  - 按 id（mode/selectionMode = 0）：拿不到实例就 no-op，或者补建实例 —— 最坏是"效果没发生"。
  - 按队位（= 1）：Index 指向队伍第几个人。原版在队侧只在"她真在队"时播，Index 有意义；
    mod 放宽/展平后在"她不在队"时也播 → Index 指到**别人**身上 → 写到错的人。
    这类是 mod 独占的风险，原版不会有。

用法：
    python audit_region_writes.py
    python audit_region_writes.py --json out.json
"""
import argparse
import collections
import json
import os
import re
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import scan_flattenable as S

REGION_CAP = 2000

# 写人物数据 / 按人操作的动作类节点（编辑器默认名）
WRITE_NODES = {
    "伙伴邀请或离队", "改变NPC关系值", "增减buff/debuff", "改变角色属性",
    "改变队伍属性", "获得/扣除NPC背包物品", "获得/扣除玩家背包物品",
    "更新NPC离队位置", "改变NPC钱数", "改变NPC货币", "改变NPC势力",
    "改变NPC实战经验", "改变当前生命值", "改变当前内力值",
    "改变形象", "改变玩家形象", "改变立绘", "改变玩家立绘",
    "强制NPC死亡", "指定NPC死亡", "激活NPC情缘", "获得武功或绝学",
    "修改NPC位置", "NPC入客栈",
}


def top_int(body, names):
    """取 `  name: 12` 形式的整数值（可能是字段名或 enum 名）。"""
    for n in names:
        m = re.search(r'^\s{2}' + re.escape(n) + r':\s*(-?\d+)\s*$', body, re.M)
        if m:
            return int(m.group(1))
    return None


def top_str(body, name):
    m = re.search(r'^\s{2}' + re.escape(name) + r':\s*(.*)$', body, re.M)
    return S.yaml_unquote(m.group(1)) if m else None


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=S.DEFAULT_ZIP)
    ap.add_argument("--json")
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(S.STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()

    stat = collections.defaultdict(lambda: collections.Counter())   # 节点名 -> {mode: 次数}
    detail = collections.defaultdict(list)                          # 节点名 -> [(图, pid, mode)]
    pairs_expandable = 0

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
            s, st = {start}, [start]
            while st:
                n = st.pop()
                for t in outs.get(n, ()):
                    if t not in s:
                        s.add(t)
                        st.append(t)
            return s

        for p in uniq:
            g0, g1 = p["zero_gate"], p["one_gate"]
            region = (reach(g0) - reach(g1)) - {g0, g1}
            if not region or len(region) > REGION_CAP:
                continue
            exits = [(n, t) for n in region for t in outs.get(n, ()) if t not in region and t != g1]
            if not exits:
                continue
            pairs_expandable += 1

            for fid in region:
                body = g.nodes.get(fid) or ""
                nm = S.yaml_unquote(S.top_field(body, "m_Name") or "")
                if nm not in WRITE_NODES:
                    continue
                mode = top_int(body, ("mode", "selectionMode"))
                stat[nm][mode if mode is not None else "缺失"] += 1
                detail[nm].append((name, p["pid"], mode))

    print("会被展平的门对：%d 个\n" % pairs_expandable)
    print("%-24s %-14s %s" % ("节点", "mode 分布", "含义"))
    print("-" * 90)
    for nm in sorted(stat, key=lambda x: -sum(stat[x].values())):
        c = stat[nm]
        dist = "  ".join("%s=%d" % (k, v) for k, v in sorted(c.items(), key=lambda x: str(x[0])))
        desc = []
        if c.get(0):
            desc.append("按 id %d" % c[0])
        if c.get(1):
            desc.append("★按队位 %d" % c[1])
        if c.get("缺失"):
            desc.append("未取值 %d" % c["缺失"])
        print("%-24s %-14s %s" % (nm, dist, " / ".join(desc)))

    # 按队位的明细（mod 独占风险集中在这里）
    risky = [(nm, lst) for nm, lst in detail.items()
             if any(m == 1 for _, _, m in lst)]
    print("\n" + "=" * 90)
    print("走「按队位(index)」的实例明细（这些在原版只在真在队时播，Index 才有意义）：")
    if not risky:
        print("  （无）")
    for nm, lst in sorted(risky):
        one = [x for x in lst if x[2] == 1]
        print("  %-22s %d 个实例，涉及 %d 张图" % (nm, len(one), len({x[0] for x in one})))
        for gn, pid, _ in one[:6]:
            print("      %-18s pid=%s" % (gn, pid))
        if len(one) > 6:
            print("      …其余 %d 个" % (len(one) - 6))

    if args.json:
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump({"pairs_expandable": pairs_expandable,
                       "by_node": {k: {str(a): b for a, b in v.items()} for k, v in stat.items()},
                       "detail": {k: v for k, v in detail.items()}}, f, ensure_ascii=False, indent=2)
        print("\n已写入 %s" % args.json)


if __name__ == "__main__":
    main()
