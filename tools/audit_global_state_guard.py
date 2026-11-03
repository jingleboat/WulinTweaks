#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""量化「给展平加全局状态保护」的代价：有多少门对会被跳过。

背景：展平改线的本质是「把 region 的对外出口改指到不在队门」，
      原目标被跳过。如果原目标是写**全局状态**的节点
      （时间流逝 / 标记 / 自定义变量 / 记事本 / 简介 / 关系值 / 战斗 / 死亡 / 背包 …），
      跳过它就会影响别的图 —— 这是"局部改线影响全局触发"的唯一通道。

本脚本统计：全量里有多少门对、其 exits 目标命中了全局状态节点。
      这些对就是要跳过、不改线的。剩下还能改多少，也一并给出。

用法：
    python audit_global_state_guard.py
    python audit_global_state_guard.py --json out.json
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

# 写"全局 / 存档级状态"的节点 —— 被绕过就会影响别的图
GLOBAL_STATE = {
    "时间流逝", "添加标记", "删除标记", "设置自定义变量", "写入记事本", "追加简介",
    "显隐大地图图标", "发生预设战斗", "发生单挑战斗", "发生无缝战斗", "发生比武大会战斗",
    "强制NPC死亡", "指定NPC死亡", "改变NPC关系值", "改变NPC好感",
    "获得/扣除玩家背包物品", "获得/扣除NPC背包物品", "增减buff/debuff",
    "改变角色属性", "改变队伍属性", "改变江湖历练", "改变势力关系", "改变玩家势力",
    "改变名声点数", "改变NPC势力", "改变NPC钱数", "改变NPC货币",
    "改变当前生命值", "改变当前内力值", "改变NPC实战经验", "更新NPC离队位置",
    "激活NPC情缘", "获得武功或绝学", "修改NPC位置", "NPC入客栈",
    "伙伴邀请或离队", "改变形象", "改变立绘", "改变玩家形象", "改变玩家立绘",
    "发生预设战斗", "获得物品", "失去物品",
}


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=S.DEFAULT_ZIP)
    ap.add_argument("--json")
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(S.STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()

    total_pairs = 0
    clean_pairs = 0
    unsafe_pairs = 0
    hit_counter = collections.Counter()
    unsafe_graphs = collections.Counter()
    clean_graphs = set()
    details = []

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
            total_pairs += 1

            hits = []
            for src, tgt in exits:
                body = g.nodes.get(tgt) or ""
                nm = S.yaml_unquote(S.top_field(body, "m_Name") or "") or ""
                if nm in GLOBAL_STATE:
                    hits.append(nm)
            if hits:
                unsafe_pairs += 1
                unsafe_graphs[name] += 1
                for h in set(hits):
                    hit_counter[h] += 1
                details.append({"graph": name, "pid": p["pid"],
                                "hits": sorted(set(hits)), "exits": len(exits)})
            else:
                clean_pairs += 1
                clean_graphs.add(name)

    print("展平可改线的门对（region 非空 + 有对外出口）：%d 个" % total_pairs)
    print("  会被「全局状态保护」跳过的：%d 个（%.1f%%），涉及 %d 张图"
          % (unsafe_pairs, 100.0 * unsafe_pairs / max(1, total_pairs), len(unsafe_graphs)))
    print("  仍然可以改线的：          %d 个，涉及 %d 张图" % (clean_pairs, len(clean_graphs)))
    print()
    print("被跳过的原因分布（多少个门对牵涉该节点）：")
    for nm, c in hit_counter.most_common(25):
        print("  %5d  %s" % (c, nm))
    print()
    print("受影响最多的图（前 15，括号内为被跳过的门对数）：")
    for nm, c in unsafe_graphs.most_common(15):
        print("  %5d  %s" % (c, nm))

    if args.json:
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump({"total": total_pairs, "unsafe": unsafe_pairs, "clean": clean_pairs,
                       "hits": dict(hit_counter), "graphs": dict(unsafe_graphs),
                       "details": details}, f, ensure_ascii=False, indent=2)
        print("\n已写入 %s" % args.json)


if __name__ == "__main__":
    main()
