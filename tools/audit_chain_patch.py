#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""复现「链式接续补丁」（_chains 名单）到底改了哪些边、原目标是什么。

背景：展平有两条完全不同的代码路径 ——
  ① 通用规则（region 法）：算 region → 改 region 对外边 → 校验环与可达性 → 不合格整体回滚。
  ② 名单链式接续（ApplyChain，v1.11.57/58）：**不做任何校验、不回滚**，
     只把「第 i 个角色内容末端」的唯一出边，直接改指「第 i+1 个角色的在队门 G0」，
     并把两道 G0 都塞进强制放行表。

用户反馈「后来单独加了个规则之外的展平名单、额外添加了几张图，然后很多剧情就触发不了了」——
所以这里把 ② 改掉的每条边，以及**被替换掉的原目标**列出来。
原目标如果是个有副作用的节点（添加标记 / 设置变量 / 汇合 / 结束），改线后它就永远不执行了。

用法：
    python audit_chain_patch.py
    python audit_chain_patch.py --graph Role5-10
"""
import argparse
import os
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import scan_flattenable as S

# 与 BranchFlatten._chains 保持一致（PC v1.11.58 / 手机 v174）
CHAINS = {
    "M5061-5":    [10008, 10018, 10086, 10088, 10067, 10053],
    "R10005-5":   [10061, 10098],
    "R10049-2-1": [10061, 10075, 10052, 10098],
    "R10098-1":   [10075, 10005],
    "Role5-10":   [10035, 10036],
    "M5061-3":    [10005, 10098],
    "R10039-6":   [20022, 10064],
}

# Apply 里会辨认的"纯副作用"节点（命中则把 src 往后挪一格）
PASS_THROUGH = {"添加标记", "追加简介"}

SIDE_EFFECT = {
    "添加标记", "删除标记", "设置自定义变量", "写入记事本", "追加简介",
    "显隐大地图图标", "改变NPC关系值", "发生预设战斗", "强制NPC死亡",
    "获得/扣除玩家背包物品", "结束", "回主菜单", "时间流逝",
}


def node_label(g, fid):
    if fid is None:
        return "?"
    if g.is_story(fid):
        return "「播放剧情」" + (g.scen_key(fid) or "")
    body = g.nodes.get(fid) or ""
    nm = S.yaml_unquote(S.top_field(body, "m_Name") or "")
    return nm or str(fid)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=S.DEFAULT_ZIP)
    ap.add_argument("--graph")
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    want = [args.graph] if args.graph else list(CHAINS)

    grand = 0
    for gn in want:
        want_path = S.STORY_PREFIX + gn + ".asset"
        if want_path not in z.namelist():
            print("== %s ==  资产不存在" % gn)
            continue
        order = CHAINS.get(gn)
        if not order:
            print("== %s ==  不在链式名单里" % gn)
            continue

        g = S.StoryGraph(gn, z.read(want_path).decode("utf-8", errors="replace"))
        pairs = S.find_pairs(g)

        # 去重 + 只留 A/B 类（与 Apply 里一致）
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

        outs = {f: g.outs(f) for f in g.nodes}

        print("=" * 96)
        print("图 %s   链式顺序 pid=%s   门对数=%d" % (gn, order, len(uniq)))

        hit = 0
        for i in range(len(order) - 1):
            p = next((x for x in uniq if x["pid"] == order[i]), None)
            q = next((x for x in uniq if x["pid"] == order[i + 1]), None)
            if p is None or q is None:
                print("  pid %s → %s : 缺少门对，跳过" % (order[i], order[i + 1]))
                continue

            g0 = p["zero_gate"]
            fo = outs.get(g0) or []
            if not fo:
                print("  pid %s : G0 没有出边，跳过" % order[i])
                continue
            scene = fo[0]

            so = outs.get(scene) or []
            src = scene
            if len(so) == 1 and node_label(g, so[0]) in PASS_THROUGH:
                src = so[0]

            se = outs.get(src) or []
            if not se:
                print("  pid %s : 内容末端 %s 没有出边，跳过"
                      % (order[i], node_label(g, src)[:40]))
                continue

            old_tgt = se[0]
            print("  ── %s(pid %s) 的内容末端  %s" % (order[i], order[i], node_label(g, src)))
            print("      原出口 → %s" % node_label(g, old_tgt))
            print("      改指   → %s  ← %s 的在队门 G0"
                  % (node_label(g, q["zero_gate"]), order[i + 1]))
            tail = ""
            if node_label(g, old_tgt) in SIDE_EFFECT:
                tail = "   ★原目标有副作用，改线后不再执行"
            elif node_label(g, src) in SIDE_EFFECT:
                tail = "   ★被改的是副作用节点的出口"
            print("      %s" % tail if tail else "")
            hit += 1

        # 顺带看：链上每个 G0（在队门）的「不在队侧 G1」会不会被强制
        forced_g0 = [next((x["zero_gate"] for x in uniq if x["pid"] == pid), None) for pid in order]
        print("  强制放行的门（只有 G0 / 在队侧）：%d 个" % len([x for x in forced_g0 if x]))
        print("  ⚠️ ApplyChain 不加强制 G1 —— 链上角色的「不在队侧内容」不会播")
        grand += hit

    print("\n总计被链式接续改掉的边：%d 条（这些改线没有校验、没有回滚）" % grand)


if __name__ == "__main__":
    main()
