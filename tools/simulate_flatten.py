#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
「剧情分支展开」的**通用规则**离线模拟器 —— 不碰游戏，只算图。

通用规则（一句话）：
    把「在队侧（Negate=0）」的**出口**改接到「不在队侧的那道门（Negate=1）」，
    再让两道门都判真 —— 于是先播在队侧的内容，再接着播不在队侧的内容。

为什么这对 A 类、B 类都成立：
    父节点的出边是 [G0(Neg=0), G1(Neg=1)]，引擎按顺序问、第一个满足的就走；
    两道都真时永远走 G0。所以只要把「G0 分支走完之后指向外面那条边」改成指向 G1，
    就等于在 G0 的内容后面接上 G1 侧的内容，而 G1 侧原样保留（它连着的是一对门还是
    汇合点都无所谓）。

「G0 分支的内容」怎么界定（关键）：
    region = reach(G0) − reach(G1) − {G0, G1}
    也就是**只有从 G0 能到、从 G1 到不了**的节点 —— 天然把汇合点和之后的东西排除掉。
    exits  = region 内所有指向 region 外的边（已指向 G1 的除外）
    动作   = 把这些 exits 全部改指 G1

本脚本做的事：对 1641 张剧情图逐张跑上面这套，输出
    · 会改哪些边（src → 旧目标 / 新目标）
    · region 大小、exit 个数
    · 风险：region 为空 / 区域重叠 / 改完出现环 / 有终点变不可达 / 区域过大
用法：
    python tools/simulate_flatten.py                    # 全量，输出汇总 + 有风险的图
    python tools/simulate_flatten.py --only R10049-2 --detail      # 单图，逐条列出要改的边
    python tools/simulate_flatten.py --min-pairs 2      # 只看门对 ≥2 的图
    python tools/simulate_flatten.py --json out.json
"""
import argparse
import collections
import json
import os
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import scan_flattenable as S          # 复用 YAML 解析与门对识别

DEFAULT_ZIP = S.DEFAULT_ZIP
STORY_PREFIX = S.STORY_PREFIX

REGION_CAP = 2000      # region 节点数上限，超过就跳过（防跑飞）


# ---------------------------------------------------------------- 图工具
class Flow(object):
    """只管「剧情走线」的有向图（输出端口，排除 conditionPort）。"""

    def __init__(self, g):
        self.g = g
        self.outs = {}
        for fid in g.nodes:
            self.outs[fid] = g.outs(fid)          # outs() 已排除 conditionPort
        self.ins = collections.defaultdict(set)
        for src, ts in self.outs.items():
            for t in ts:
                self.ins[t].add(src)

    def reach(self, start):
        """从 start 出发（含 start）能到的节点集合。"""
        seen = {start}
        stack = [start]
        while stack:
            n = stack.pop()
            for t in self.outs.get(n, ()):
                if t not in seen:
                    seen.add(t)
                    stack.append(t)
        return seen

    def entries(self):
        return [f for f in self.outs if not self.ins.get(f)]

    def terminals(self):
        return [f for f, ts in self.outs.items() if not ts]

    def cycles(self, edges=None):
        """返回存在的环（最多报 3 个），edges 缺省用原图。"""
        e = edges if edges is not None else self.outs
        WHITE, GRAY, BLACK = 0, 1, 2
        color = collections.defaultdict(int)
        found = []

        def dfs(u, path):
            if len(found) >= 3:
                return
            color[u] = GRAY
            path.append(u)
            for v in e.get(u, ()):
                if color[v] == GRAY:
                    i = path.index(v) if v in path else 0
                    found.append(path[i:] + [v])
                    if len(found) >= 3:
                        break
                elif color[v] == WHITE:
                    dfs(v, path)
            path.pop()
            color[u] = BLACK

        for n in list(e.keys()):
            if color[n] == WHITE:
                dfs(n, [])
        return found


def label(g, fid):
    """节点的人话标签。"""
    if fid is None:
        return "?"
    if g.is_story(fid):
        return g.scen_key(fid)
    c = g.cond.get(g.gate.get(fid))
    if c:
        return "门[%s/N%s]" % (c["pid"], c["neg"])
    b = g.nodes.get(fid)
    if b:
        n = S.yaml_unquote(S.top_field(b, "m_Name"))
        if n:
            return n
    return str(fid)


# ---------------------------------------------------------------- 通用规则
def plan_pair(g, fl, pair, regions_of):
    """给一对门算改线方案。

    返回里的 `notes` 是良性结论（比如"两侧内容重叠、无需改线"），
    `risk` 才是真风险（会导致改坏/改不动）。
    """
    g0, g1 = pair["zero_gate"], pair["one_gate"]
    notes = []
    risk = []

    r0 = fl.reach(g0)
    r1 = fl.reach(g1)
    region = (r0 - r1) - {g0, g1}

    if len(region) > REGION_CAP:
        return {"pair": pair, "g0": g0, "g1": g1, "region": region,
                "exits": [], "notes": notes, "risk": ["region 过大(%d)，跳过" % len(region)]}
    if not region:
        return {"pair": pair, "g0": g0, "g1": g1, "region": region,
                "exits": [], "notes": ["两侧内容重叠（region 为空），无需改线"], "risk": risk}

    exits = []
    for n in region:
        for t in fl.outs.get(n, ()):
            if t in region:
                continue
            if t == g1:
                continue                      # 已经接到 G1 了
            exits.append((n, t))

    if not exits:
        risk.append("region 没有对外出口（内容可能是个死循环）")

    # 区域重叠：两对门的独占内容相交 → 改线会互相干扰
    for other in regions_of:
        if other is pair:
            continue
        ov = region & other["_region"]
        if ov:
            risk.append("区域与 pid=%s 的门对重叠 %d 个节点" % (other["pair"]["pid"], len(ov)))

    return {"pair": pair, "g0": g0, "g1": g1, "region": region,
            "exits": exits, "notes": notes, "risk": risk}


def simulate(g, mode="all"):
    """对一张图跑通用规则。mode: all=所有门对 / a-only=只处理 A 类。"""
    fl = Flow(g)
    pairs = S.find_pairs(g)

    # 同一个 (G0,G1) 可能被多个父端口连到 → 去重；partnerID<=0 不是「需要伙伴」，丢掉
    seen = set()
    uniq = []
    for p in pairs:
        if p["pid"] is None or p["pid"] <= 0:
            continue
        key = (p["zero_gate"], p["one_gate"])
        if key in seen:
            continue
        seen.add(key)
        uniq.append(p)

    # 只处理「角色是否在队」的两种正常形状：
    #   A = 一侧剧情 / 一侧直通；B = 两侧都是剧情
    # X（两侧都不是单节点剧情）不是这种分支，别动
    if mode == "a-only":
        uniq = [p for p in uniq if p["kind"] == "A"]
    else:
        uniq = [p for p in uniq if p["kind"] in ("A", "B")]

    # 先算所有 region（重叠检测要互相看）
    regs = []
    for p in uniq:
        g0, g1 = p["zero_gate"], p["one_gate"]
        reg = (fl.reach(g0) - fl.reach(g1)) - {g0, g1}
        regs.append({"pair": p, "_region": reg})
    for r in regs:
        r["_region"] = r["_region"] if len(r["_region"]) <= REGION_CAP else set()

    plans = []
    for p in uniq:
        plans.append(plan_pair(g, fl, p, [r for r in regs if r["pair"] is not p]))

    # ---- 应用改线，做前后对比 ----
    new_edges = {k: list(v) for k, v in fl.outs.items()}
    redirects = []
    for pl in plans:
        for (src, old) in pl["exits"]:
            ts = new_edges.get(src, [])
            if old in ts:
                ts[ts.index(old)] = pl["g1"]
                redirects.append((src, old, pl["g1"]))

    risk = []
    notes = []
    for pl in plans:
        risk += pl["risk"]
        notes += pl["notes"]

    # 改完是否有环
    before_cycles = fl.cycles()
    after_cycles = fl.cycles(new_edges)
    if len(after_cycles) > len(before_cycles):
        risk.append("改线后新增环（前 %d / 后 %d）" % (len(before_cycles), len(after_cycles)))

    # 终点是否还都可达
    entries = fl.entries()
    terms = fl.terminals()

    def reach_set(e):
        seen = set(entries)
        stack = list(entries)
        while stack:
            n = stack.pop()
            for t in e.get(n, ()):
                if t not in seen:
                    seen.add(t)
                    stack.append(t)
        return seen

    rb = reach_set(fl.outs)
    ra = reach_set(new_edges)
    lost = [t for t in terms if t in rb and t not in ra]
    if lost:
        risk.append("有 %d 个终点改线后不可达" % len(lost))

    return {
        "graph": g.name,
        "nodes": len(g.nodes),
        "pairs_total": len(pairs),
        "a_pairs": sum(1 for p in pairs if p["kind"] == "A"),
        "b_pairs": sum(1 for p in pairs if p["kind"] == "B"),
        "expanded": len([pl for pl in plans if pl["exits"]]),
        "redirects": len(redirects),
        "plans": plans,
        "redirect_list": redirects,
        "risk": risk,
        "notes": notes,
        "lost_terminals": lost,
    }


# ---------------------------------------------------------------- 入口
def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=DEFAULT_ZIP)
    ap.add_argument("--mode", default="all", choices=["all", "a-only"],
                    help="all=所有门对（含 B 类）；a-only=只处理 A 类（默认 all）")
    ap.add_argument("--only", help="只跑这一张图")
    ap.add_argument("--detail", action="store_true", help="配合 --only，逐条列出要改的边")
    ap.add_argument("--min-pairs", type=int, default=1)
    ap.add_argument("--json")
    ap.add_argument("--limit", type=int, default=0)
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()
    if args.only:
        w = STORY_PREFIX + args.only + ".asset"
        if w not in entries:
            sys.exit("资产里没有 %s" % w)
        entries = [w]
    if args.limit:
        entries = entries[:args.limit]
    print("剧情图 %d 张，mode=%s …" % (len(entries), args.mode), file=sys.stderr)

    results = []
    for i, e in enumerate(entries, 1):
        name = e[len(STORY_PREFIX):-len(".asset")]
        if i % 200 == 0:
            print("  …%d/%d" % (i, len(entries)), file=sys.stderr)
        try:
            raw = z.read(e).decode("utf-8", errors="replace")
        except Exception as ex:
            print("  跳过 %s: %s" % (name, ex), file=sys.stderr)
            continue
        if "conditionPort" not in raw or "partnerID" not in raw:
            continue
        try:
            g = S.StoryGraph(name, raw)
            if len(g.gate) == 0:
                continue
            r = simulate(g, args.mode)
        except Exception as ex:
            print("  解析失败 %s: %s" % (name, ex), file=sys.stderr)
            continue
        # 单图模式下把对象留在内存里（detail 要用）
        r["_graph"] = g
        results.append(r)

    if args.only:
        if not results:
            sys.exit("没有结果（该图可能没有门）")
        r = results[0]
        g = r["_graph"]
        print("")
        print("=" * 90)
        print("图 %s   节点 %d   门对 %d（A %d / B %d）   将展开 %d 对，改线 %d 条"
              % (r["graph"], r["nodes"], r["pairs_total"], r["a_pairs"], r["b_pairs"],
                 r["expanded"], r["redirects"]))
        print("=" * 90)
        if not args.detail:
            print("风险：", "；".join(r["risk"]) if r["risk"] else "无")
            print("（加 --detail 看逐条改线）")
            return
        for pl in r["plans"]:
            p = pl["pair"]
            if not pl["exits"]:
                print("· pid=%s (%s 类) region=%d  → 无需改线%s"
                      % (p["pid"], p["kind"], len(pl["region"]),
                         ("：" + "；".join(pl["risk"])) if pl["risk"] else ""))
                continue
            print("· pid=%s (%s 类)  在队门=%s  不在队门=%s"
                  % (p["pid"], p["kind"], label(g, pl["g0"]), label(g, pl["g1"])))
            print("    region %d 个节点：%s" % (len(pl["region"]),
                  ", ".join(label(g, n) for n in list(pl["region"])[:6])
                  + (" …" if len(pl["region"]) > 6 else "")))
            for (src, old) in pl["exits"]:
                print("    改线 %-22s → 旧 %-22s ⇒ 新 %s"
                      % (label(g, src), label(g, old), label(g, pl["g1"])))
        if r["risk"]:
            print("")
            print("风险：")
            for x in r["risk"]:
                print("  ⚠", x)
        return

    if args.json:
        out = []
        for r in results:
            rr = {k: v for k, v in r.items() if k not in ("plans", "_graph")}
            rr["redirect_list"] = [[a, b, c] for a, b, c in r["redirect_list"]]
            out.append(rr)
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump(out, f, ensure_ascii=False, indent=1)
        print("已写 %s" % args.json, file=sys.stderr)

    rows = [r for r in results if r["pairs_total"] >= args.min_pairs]
    ok = [r for r in rows if not r["risk"] and r["redirects"] > 0]
    risky = [r for r in rows if r["risk"]]
    noneed = [r for r in rows if r["redirects"] == 0]

    print("")
    print("=" * 104)
    print("有门对的图 %d 张：可安全展开 %d 张（共改 %d 条边）／有风险 %d 张／无需改线 %d 张"
          % (len(rows), len(ok), sum(r["redirects"] for r in ok), len(risky), len(noneed)))
    print("=" * 104)

    print("")
    print("—— 改线最多的 25 张（无风险）——")
    print("%-24s %5s %4s %4s %4s %6s" % ("图名", "节点", "A", "B", "展开", "改线"))
    print("-" * 60)
    for r in sorted(ok, key=lambda x: -x["redirects"])[:25]:
        print("%-24s %5d %4d %4d %4d %6d"
              % (r["graph"], r["nodes"], r["a_pairs"], r["b_pairs"], r["expanded"], r["redirects"]))

    if risky:
        print("")
        print("—— 有风险的图（前 30）——")
        print("%-24s %4s %4s %s" % ("图名", "A", "B", "风险"))
        print("-" * 104)
        for r in sorted(risky, key=lambda x: -len(x["risk"]))[:30]:
            kinds = collections.Counter()
            for x in r["risk"]:
                kinds[x.split("（")[0].split("(")[0][:16]] += 1
            brief = "；".join("%s×%d" % (k, v) for k, v in kinds.most_common(3))
            print("%-24s %4d %4d %s" % (r["graph"], r["a_pairs"], r["b_pairs"], brief))

    print("")
    print("说明：")
    print("  region = reach(Neg=0 门) − reach(Neg=1 门)，即「只有在队侧能到」的节点")
    print("  exits  = region 内指向 region 外的边；把它们全改指 Neg=1 门，再让两道门判真")
    print("  风险口径：region 为空 / 区域与别的门对重叠 / 改线后新增环 / 终点变不可达 / region 过大")


if __name__ == "__main__":
    main()
