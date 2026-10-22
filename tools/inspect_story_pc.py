#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
在 **PC 版** 的剧情资产上做静态结构检查（离线，不需要开游戏）。

数据源：<游戏目录>\\Wulin_Data\\StreamingAssets\\ModEditor\\ModEditor.zip
       其中 Assets/GameRes/Story/<图名>.asset 是 XNode 剧情图（Unity YAML）

用法：
    python inspect_story_pc.py                      # 默认查 R10049-2（剧情分支展开的目标图）
    python inspect_story_pc.py R10049-1             # 查任意图
    python inspect_story_pc.py R10049-2 --ladder    # 只打印门梯（可能很长）
    python inspect_story_pc.py R10049-2 --pid 10008 # 查某个 partnerID 出现在哪些门

为什么要有这个脚本：
    「剧情分支展开」在 PC 侧只认一张图、5 个 ScenarioKey、5 组 partnerID 门。
    改代码之前先用它把假设核一遍，比开游戏试错快得多（手机端就是靠这个省了无数轮）。
"""
import argparse
import collections
import os
import re
import sys
import zipfile

DEFAULT_ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"

# 「剧情分支展开」的目标图规格（与 BranchFlatten.cs 里的常量保持一致）
FLAT_GRAPH = "R10049-2"
FLAT_START = "R10049-2_2_1"
FLAT_CHAIN = ["R10049-2_2_2", "R10049-2_2_3", "R10049-2_2_4",
              "R10049-2_2_5", "R10049-2_2_6"]
FLAT_PIDS = [10084, 10083, 10078, 10053, 10008]
FLAT_GATE_PID = 10008


# ---------------------------------------------------------------- YAML 解析
def split_docs(raw):
    """按 Unity 的 --- !u!<class> &<fileID> 切文档。"""
    parts = re.split(r"^--- !u!\d+ &(-?\d+).*$", raw, flags=re.M)
    return {int(parts[i]): parts[i + 1] for i in range(1, len(parts), 2)}


def top_field(body, name):
    """取 2 空格缩进的顶层字段（XNode 的序列化字段都在这一层）。"""
    m = re.search(r"^  " + re.escape(name) + r":(.*)$", body, flags=re.M)
    return m.group(1).strip() if m else None


def ports_of(body):
    """{端口名: [(对端端口名, 对端节点 fileID), ...]}

    XNode 的 ports 是 NodePortDictionary（keys/values 两个平行 List + 每项的
    connections 列表）。注意：**运行期 keys/values 会被 ClearSerialize 清空**，
    所以游戏里不能靠这两个 List，只有离线读 YAML 时才看得到。
    """
    lines = body.splitlines()
    out = collections.OrderedDict()
    try:
        start = next(i for i, l in enumerate(lines) if re.match(r"^  ports:\s*$", l))
    except StopIteration:
        return out
    in_values = False
    cur = None
    i = start + 1
    while i < len(lines):
        l = lines[i]
        if re.match(r"^  \S", l):
            break
        if re.match(r"^    values:\s*$", l):
            in_values = True
        elif re.match(r"^    keys:\s*$", l):
            in_values = False
        elif in_values and re.match(r"^    - _fieldName: ", l):
            cur = l.split(":", 1)[1].strip()
            out[cur] = []
        elif in_values and re.match(r"^      - fieldName: ", l):
            pf = l.split(":", 1)[1].strip()
            nd = None
            for j in range(i + 1, min(i + 4, len(lines))):
                m = re.match(r"^        node: \{fileID: (-?\d+)\}", lines[j])
                if m:
                    nd = int(m.group(1))
                    break
            out[cur].append((pf, nd))
        i += 1
    return out


class Graph(object):
    def __init__(self, raw):
        self.nodes = split_docs(raw)
        self.scen = {}          # ScenarioKey -> fileID
        self.pslug = {}         # fileID -> (partnerID, Negate)
        self.gate = {}          # 门 fileID -> 条件节点 fileID
        self.gate_of = {}       # (pid, neg) -> 门 fileID

        # 第一遍：把所有节点的身份收齐（门要引用条件节点，条件节点可能排在后面）
        for fid, body in self.nodes.items():
            sk = top_field(body, "ScenarioKey")
            if sk:
                self.scen[sk.strip('"')] = fid
            pid = top_field(body, "partnerID")
            if pid is not None:
                self.pslug[fid] = (int(pid), (top_field(body, "Negate") or "0").strip())

        # 第二遍：门 → 条件节点 → (pid, neg)
        for fid, body in self.nodes.items():
            cons = ports_of(body).get("conditionPort")
            if not cons:
                continue
            cfid = cons[0][1]
            if cfid in self.pslug:
                self.gate[fid] = cfid
                self.gate_of[self.pslug[cfid]] = fid

    def label(self, fid):
        b = self.nodes.get(fid)
        if b is None:
            return "<%s 不在图里>" % fid
        sk = top_field(b, "ScenarioKey")
        if sk:
            return sk.strip('"')
        if fid in self.gate:
            pid, neg = self.pslug[self.gate[fid]]
            return "门[%d/N%s]" % (pid, neg)
        return (top_field(b, "m_Name") or "?").replace('"', "")

    def outs(self, fid):
        """有向出边：[(对端端口名, 对端节点)]"""
        b = self.nodes.get(fid)
        if b is None:
            return []
        return [(pf, nd) for pn, c in ports_of(b).items() if pn == "OutPort" for pf, nd in c]


# ---------------------------------------------------------------- 检查
def check_flat(g):
    print("")
    print("=== 「剧情分支展开」规格核对（%s）===" % FLAT_GRAPH)
    ok = True

    def mark(good, text):
        nonlocal ok
        ok = ok and good
        print("   %s %s" % ("✅" if good else "❌", text))

    mark(FLAT_START in g.scen, "起点 %s 存在" % FLAT_START)
    for k in FLAT_CHAIN:
        mark(k in g.scen, "讲解节点 %s 存在" % k)
    for pid in FLAT_PIDS:
        a, b = g.gate_of.get((pid, "0")), g.gate_of.get((pid, "1"))
        mark(a is not None and b is not None, "%d 的 Negate=0/1 门都在" % pid)

    gate_last = g.gate_of.get((FLAT_GATE_PID, "1"))
    loose = [f for f, cfid in g.gate.items()
             if g.pslug[cfid] == (FLAT_GATE_PID, "1")]
    mark(gate_last is not None and len(loose) == 1,
         "兜底门 (%d, Negate=1) 唯一 → %s（候选 %d 个）" % (FLAT_GATE_PID, gate_last, len(loose)))

    for k in FLAT_CHAIN:
        fid = g.scen.get(k)
        if not fid:
            continue
        outs = g.outs(fid)
        tgt = outs[0][1] if outs else None
        mark(len(outs) == 1 and tgt == g.scen.get("R10049-2_2_9"),
             "%s 的 OutPort 当前只有 1 条连线且指向 _2_9（正是要改的）" % k)

    if gate_last:
        outs = g.outs(gate_last)
        mark(len(outs) >= 1, "兜底门有出边（改连后靠它往外走）：%s"
             % ", ".join(g.label(n) for _, n in outs))
        mark("InPort" in ports_of(g.nodes[gate_last]), "兜底门有 InPort（改连的落点）")
        cfid = g.gate.get(gate_last)
        mark("stateIn" in ports_of(g.nodes[cfid]), "兜底条件的条件节点有 stateIn 端口")

    print("")
    print("=== 模拟展开后的走线（只按图结构推）===")
    ids = [g.scen.get(k) for k in FLAT_CHAIN]
    for i, k in enumerate(FLAT_CHAIN):
        to = ids[i + 1] if i + 1 < len(FLAT_CHAIN) else gate_last
        print("   %-16s → %s" % (k, g.label(to) if to else "缺失"))
    if gate_last:
        print("   %-16s → %s" % ("兜底门(之后)", ", ".join(g.label(n) for _, n in g.outs(gate_last))))
    print("")
    print("结论：", "规格全部对得上" if ok else "有对不上的项，先别改代码")
    return ok


def print_ladder(g):
    print("")
    print("=== 门梯（从起点沿 OutPort 走）===")
    starts = [f for f, b in g.nodes.items()
              if (top_field(b, "ScenarioKey") or "").strip('"') == FLAT_START]
    if not starts:
        print("   找不到起点", FLAT_START)
        return
    seen = set()

    def walk(fid, depth):
        if depth > 10 or fid is None:
            return
        key = (fid, depth)
        if key in seen:
            return
        seen.add(key)
        outs = g.outs(fid)
        print("  " * depth + "└→ " + g.label(fid) + "  (出边 %d)" % len(outs))
        for _, nd in outs:
            walk(nd, depth + 1)

    walk(starts[0], 0)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("graph", nargs="?", default=FLAT_GRAPH)
    ap.add_argument("--zip", default=DEFAULT_ZIP)
    ap.add_argument("--ladder", action="store_true", help="打印整条门梯")
    ap.add_argument("--pid", type=int, help="查这个 partnerID 出现在哪些门")
    args = ap.parse_args()

    if not os.path.exists(args.zip):
        sys.exit("找不到 ModEditor.zip：%s\n用 --zip 指定" % args.zip)

    entry = "Assets/GameRes/Story/%s.asset" % args.graph
    with zipfile.ZipFile(args.zip) as z:
        try:
            raw = z.read(entry).decode("utf-8", errors="replace")
        except KeyError:
            sys.exit("资产里没有 %s" % entry)

    g = Graph(raw)
    print("图 %s：%d 个节点，%d 个带 ScenarioKey，%d 个门，%d 组 (pid,negate)"
          % (args.graph, len(g.nodes), len(g.scen), len(g.gate), len(g.gate_of)))

    if args.pid is not None:
        print("")
        for (pid, neg), fid in sorted(g.gate_of.items()):
            if pid == args.pid:
                print("   %d/N%s 门=%s  出 -> %s" % (pid, neg, fid,
                      ", ".join(g.label(n) for _, n in g.outs(fid))))
    elif args.ladder:
        print_ladder(g)
    elif args.graph == FLAT_GRAPH:
        check_flat(g)
    else:
        print_ladder(g)


if __name__ == "__main__":
    main()
