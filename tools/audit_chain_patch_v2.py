#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""模拟 v1.11.65 重写后的链式接续（**改用 region 判据**），并验收。

正确判据：成员 p 的「独占内容」= reach(G0) − reach(G1) − {G0,G1}（与展平 region 法同一个算
法）。只改这些独占内容的**对外出口**，把它们接到下一对的在队门 G0。
于是 region 内所有节点（时间流逝 / 添加标记 / 追加简介 / 关系值 …）照常执行，
丢掉的只是"原来出口之后那段共用收尾"——那正是串接想要的效果。

region 为空 = 这个角色根本没有独占内容 → 放宽不会改变后续走向 → **不需要也不应该串**。
这类对交给"未接管禁止放宽"（no_relax_add）兜底：不放宽 → 走原版直通 → 后面的角色照样轮得到。

验收：
  1. 不该有副作用节点被跳过（region 内一律保留）
  2. region 空的对要明确报"不串"，不能假装串了
  3. 串完以后每个下一对的门 G0 都拿到了连接

用法：
    python audit_chain_patch_v2.py
"""
import os
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import scan_flattenable as S

CHAINS = {
    "M5061-5":    [10008, 10018, 10086, 10088, 10067, 10053],
    "R10005-5":   [10061, 10098],
    "R10049-2-1": [10061, 10075, 10052, 10098],
    "R10098-1":   [10075, 10005],
    "Role5-10":   [10035, 10036],
    "M5061-3":    [10005, 10098],
    "R10039-6":   [20022, 10064],
}

REGION_CAP = 512
MUST_KEEP = {
    "时间流逝", "添加标记", "删除标记", "设置自定义变量", "写入记事本", "追加简介",
    "改变NPC关系值", "改变NPC好感", "增减buff/debuff", "改变角色属性",
    "发生预设战斗", "强制NPC死亡", "获得/扣除玩家背包物品", "获得/扣除NPC背包物品",
}


def label(g, fid):
    if g.is_story(fid):
        return "播放剧情 " + (g.scen_key(fid) or "")
    body = g.nodes.get(fid) or ""
    return S.yaml_unquote(S.top_field(body, "m_Name") or "") or str(fid)


def main():
    z = zipfile.ZipFile(S.DEFAULT_ZIP)
    tot_chain = tot_skip = 0
    lost = []

    for gn, order in CHAINS.items():
        path = S.STORY_PREFIX + gn + ".asset"
        if path not in z.namelist():
            print("== %s == 资产不存在" % gn)
            continue
        g = S.StoryGraph(gn, z.read(path).decode("utf-8", errors="replace"))
        pairs = S.find_pairs(g)
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

        def reach(start):
            r, st = {start}, [start]
            while st:
                n = st.pop()
                for t in outs.get(n, ()):
                    if t not in r:
                        r.add(t)
                        st.append(t)
            return r

        print("=" * 94)
        print("图 %s   顺序 %s   门对 %d" % (gn, order, len(uniq)))

        for i in range(len(order) - 1):
            p = next((x for x in uniq if x["pid"] == order[i]), None)
            q = next((x for x in uniq if x["pid"] == order[i + 1]), None)
            if p is None or q is None:
                print("  pid %s → %s : 名单里的 pid 找不到门对 → 该图不串（名单失效）"
                      % (order[i], order[i + 1]))
                tot_skip += 1
                continue

            g0, g1 = p["zero_gate"], p["one_gate"]
            region = (reach(g0) - reach(g1)) - {g0, g1}
            if not region:
                print("  pid %s → %s : region 为空（无独占内容）→ 不串，交给「未接管禁止放宽」兜底"
                      % (order[i], order[i + 1]))
                tot_skip += 1
                continue
            if len(region) > REGION_CAP:
                print("  pid %s → %s : region 过大(%d) → 不串" % (order[i], order[i + 1], len(region)))
                tot_skip += 1
                continue

            exits = [(n, t) for n in region for t in outs.get(n, ())
                     if t not in region and t != g1]
            if not exits:
                print("  pid %s → %s : 独占内容没有对外出口 → 不串" % (order[i], order[i + 1]))
                tot_skip += 1
                continue

            names = sorted({label(g, x) for x in region})
            print("  pid %s → %s  串接 %d 条出口 → %s 的在队门"
                  % (order[i], order[i + 1], len(exits), order[i + 1]))
            print("      独占内容 %d 个节点（全部保留执行）：%s"
                  % (len(region), "、".join(names[:8]) + ("…" if len(names) > 8 else "")))
            for src, tgt in exits:
                print("      %s 的出口  %s  ⟶ pid %s 的在队门"
                      % (label(g, src), label(g, tgt), order[i + 1]))
                if label(g, tgt) in MUST_KEEP:
                    lost.append((gn, order[i], label(g, tgt)))
            tot_chain += 1

    print("\n" + "=" * 94)
    print("串接 %d 条，不串 %d 条" % (tot_chain, tot_skip))
    if lost:
        print("⚠ 被跳过的对外目标里有副作用节点 %d 处（这些是 region *外* 的共用收尾）：" % len(lost))
        for gn, pid, nm in lost:
            print("   %-14s pid=%-7s 跳过=%s" % (gn, pid, nm))
        print("   注：串接的目的就是不再回到共用收尾，这一跳是设计意图；")
        print("       但如果该收尾里含全局状态（时间流逝等），需要人工确认是否可接受。")
    else:
        print("✓ 没有任何副作用节点被跳过")


if __name__ == "__main__":
    main()
