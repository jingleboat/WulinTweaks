#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
扫描 PC 端**全部**剧情图，找出「剧情分支展开」能套用的位置，并输出可直接用的参数表。

背景（详见 E:\\笔记\\2026-10-23-交接-分支展开移植到PC.md）：
  原版「某角色是否在队」的条件是互补兄弟门对（Negate=0 / Negate=1），引擎按顺序问、
  第一个满足的就被走 —— 也就是 if/else。讲解类剧情的出口直接连到汇合点，所以另一侧
  永远不播。展开 = 把讲解链的出口改接到下一段讲解的门上，顺序播完再走兜底。

  判定「能不能展开」的关键是**门对的形状**：
    · A 类：门对里**一侧是「播放剧情」、另一侧是「直通」**（→ 另一道门/汇合点）
            —— 这种才能串起来顺序播（R10049-2 的 5 段讲解全是 A 类）
    · B 类：**两侧都是「播放剧情」** —— 两侧都播等于剧情重复，现在的设计不适用

数据源：<游戏>\\Wulin_Data\\StreamingAssets\\ModEditor\\ModEditor.zip
       里的 Assets/GameRes/Story/<图名>.asset（Unity YAML）

用法：
    python tools/scan_flattenable.py                    # 全量扫描，只列有 A 类的图
    python tools/scan_flattenable.py --min 2            # 只看 A 类 ≥2 对的图
    python tools/scan_flattenable.py --detail R10049-2   # 打印某张图的参数表（可直接填进代码）
    python tools/scan_flattenable.py --json out.json    # 机器可读输出
"""
import argparse
import collections
import json
import os
import re
import sys
import zipfile

DEFAULT_ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"
STORY_PREFIX = "Assets/GameRes/Story/"

# 哪些节点名才是「队友条件」（mod 的放宽/展平作用对象）。
#
# 认定依据：
#   「需要伙伴」 = HavePartnerCondition     （当前在队）
#   「需要角色加入」/「是否加入过队伍」 = IsJoinedTeamCondition（历史入队）
# 后者在 ModEditor 里没直接观察到（该图集里出现次数为 0），先留名备用；
# 只有这两个类会被原生 hook（CheckAllConnectNode）接管，其余带 partnerID 的节点
# 都是效果节点或触发器，不能进 cond 表。
# v272：**只认「需要伙伴」**（HavePartnerCondition）。
#
# 实现目标是「角色是否在队」这一个语义，只有它符合。
# 「需要角色加入 / 是否加入过队伍 / 需要角色加入过队伍」= IsJoinedTeamCondition（**历史入队**），
# 与「当前在队」不是同一维度；且运行时 v212 已决定它**不放宽**，
# 所以对它展平不会生效（展平依赖放宽让 G0 判真），只会白登记门表/条件表。
#
# 早期这里是 4 个名字，注释写着「后者在 ModEditor 里没直接观察到，先留名备用」——
# 运行时照抄了这个「备用」白名单 → 隐患：DLC 图里若出现「是否加入过队伍」，
# 会被误当成「在队/不在队」门对，按 Negate 互补去展平，语义完全错。
#
# 离线全库实测（伙伴/入队类条件的类名分布）：
#   需要伙伴            1546
#   队伍有空闲位置        402   （不在白名单，正确）
#   判断队伍属性满足      196   （不在白名单，正确）
#   判断NPC加入过队伍       7   （不在白名单，正确）
#   需要角色加入 / 是否加入过队伍 / 需要角色加入过队伍  → **0 次**
TEAM_COND_NAMES = {
    "需要伙伴",
}


# ---------------------------------------------------------------- YAML 小工具
def split_docs(raw):
    """按 Unity 的 --- !u!<class> &<fileID> 切文档。"""
    parts = re.split(r"^--- !u!\d+ &(-?\d+).*$", raw, flags=re.M)
    return {int(parts[i]): parts[i + 1] for i in range(1, len(parts), 2)}


def top_field(body, name):
    m = re.search(r"^  " + re.escape(name) + r":(.*)$", body, flags=re.M)
    return m.group(1).strip() if m else None


_UESC = re.compile(r"\\u([0-9a-fA-F]{4})|\\x([0-9a-fA-F]{2})|\\(.)")


def yaml_unquote(s):
    """把 YAML 双引号里的 \\uXXXX / \\n 之类还原成普通字符串。"""
    if s is None:
        return None
    s = s.strip()
    if len(s) >= 2 and s[0] == '"' and s[-1] == '"':
        s = s[1:-1]
    elif len(s) >= 2 and s[0] == "'" and s[-1] == "'":
        return s[1:-1]

    def rep(m):
        if m.group(1):
            return chr(int(m.group(1), 16))
        if m.group(2):
            return chr(int(m.group(2), 16))
        c = m.group(3)
        return {"n": "\n", "t": "\t", "r": "\r"}.get(c, c)

    return _UESC.sub(rep, s)


def ports_of(body):
    """{端口名: {'dir': 0/1, 'conns': [(对端端口名, 对端节点fileID), ...]}}

    XNode 的 ports 是 NodePortDictionary（keys/values 两个平行 List），
    每项里 _direction 0=输入 1=输出。
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
            out[cur] = {"dir": None, "conns": []}
        elif in_values and cur is not None:
            m = re.match(r"^      _direction: (\d+)", l)
            if m:
                out[cur]["dir"] = int(m.group(1))
            m = re.match(r"^      - fieldName: ", l)
            if m:
                pf = l.split(":", 1)[1].strip()
                nd = None
                for j in range(i + 1, min(i + 4, len(lines))):
                    mm = re.match(r"^        node: \{fileID: (-?\d+)\}", lines[j])
                    if mm:
                        nd = int(mm.group(1))
                        break
                out[cur]["conns"].append((pf, nd))
        i += 1
    return out


# ---------------------------------------------------------------- 图模型
class StoryGraph(object):
    def __init__(self, name, raw):
        self.name = name
        self.nodes = split_docs(raw)
        self._ports = {}
        self.scen = {}          # ScenarioKey -> fileID（「播放剧情」节点）
        self.cond = {}          # 条件节点 fileID -> dict(name, pid, neg)
        self.gate = {}          # 门 fileID -> 条件节点 fileID

        for fid, body in self.nodes.items():
            sk = top_field(body, "ScenarioKey")
            if sk:
                self.scen[yaml_unquote(sk)] = fid
            pid = top_field(body, "partnerID")
            if pid is not None:
                nm = yaml_unquote(top_field(body, "m_Name"))
                # 只有「需要伙伴」（HavePartnerCondition）才是队友条件。
                #
                # ⚠️ 2026-11-04 修正：`partnerID` 字段**不是**队友条件专属。
                # 实测 ModEditor 里带该字段的节点类型（按出现次数）：
                #   指定NPC死亡 3136 / 需要伙伴 2129 / 当与Npc交互 2013 / 改变角色属性 1960
                #   改变NPC关系值 1710 / 增减buff 1536 / 需要角色属于帮派 1223 / 需要人物属性 1221 …
                # 旧代码只看 partnerID 就收进 cond，于是「当与Npc交互」「指定NPC死亡」这些
                # 全被当成队友条件，门对统计与 region 分析都被污染
                # （实例：R10049-2-1 的 42161/42162/42163 其实是「当与Npc交互」，不是队友条件）。
                if nm not in TEAM_COND_NAMES:
                    continue
                neg = yaml_unquote(top_field(body, "Negate") or "0")
                try:
                    pid_i = int(pid)
                except ValueError:
                    pid_i = None
                self.cond[fid] = {
                    "name": nm,
                    "pid": pid_i,
                    "neg": neg,
                }

        # 门 = 有 conditionPort 端口、且它第一条连线指向一个 partnerID 条件节点的节点
        for fid, body in self.nodes.items():
            p = self.ports(fid).get("conditionPort")
            if not p or not p["conns"]:
                continue
            cid = p["conns"][0][1]
            if cid in self.cond:
                self.gate[fid] = cid

    def ports(self, fid):
        if fid not in self._ports:
            b = self.nodes.get(fid)
            self._ports[fid] = ports_of(b) if b else {}
        return self._ports[fid]

    def outs(self, fid, only=None):
        """有向出边：[对端节点 fileID]

        ⚠️ `conditionPort` 的 `_direction` 也是 1（它确实是输出口，通向条件节点），
        但它不是剧情走线，必须排除，否则「门的出边」会多出一条指向条件节点的边。
        """
        res = []
        for name, p in self.ports(fid).items():
            if only is not None:
                if name != only:
                    continue
            elif p["dir"] != 1 or name == "conditionPort":
                continue
            for _, nd in p["conns"]:
                if nd is not None:
                    res.append(nd)
        return res

    def is_story(self, fid):
        b = self.nodes.get(fid)
        return bool(b and top_field(b, "ScenarioKey") is not None)

    def scen_key(self, fid):
        b = self.nodes.get(fid)
        if not b:
            return None
        return yaml_unquote(top_field(b, "ScenarioKey"))


# ---------------------------------------------------------------- 门对识别
def find_pairs(g):
    """找互补兄弟门对，并分类 A（一侧剧情）/ B（两侧剧情）/ X（两侧都直通）。"""
    pairs = []
    for fid in g.nodes:
        for name, p in g.ports(fid).items():
            if p["dir"] != 1 or name == "conditionPort" or len(p["conns"]) != 2:
                continue
            a, b = p["conns"][0][1], p["conns"][1][1]
            if a not in g.gate or b not in g.gate:
                continue
            ca, cb = g.gate[a], g.gate[b]
            da, db = g.cond.get(ca), g.cond.get(cb)
            if not da or not db:
                continue
            if da["pid"] is None or da["pid"] != db["pid"]:
                continue
            if da["neg"] == db["neg"]:
                continue
            if da["name"] != db["name"]:
                continue

            ta, tb = g.outs(a), g.outs(b)
            ka = len(ta) == 1 and g.is_story(ta[0])
            kb = len(tb) == 1 and g.is_story(tb[0])
            kind = "A" if ka != kb else ("B" if ka and kb else "X")

            d = {
                "parent": fid,
                "parent_key": g.scen_key(fid),
                "pid": da["pid"],
                "cond": da["name"],
                "kind": kind,
                "zero_gate": a if da["neg"] == "0" else b,
                "one_gate": b if da["neg"] == "0" else a,
                "story_on_first_conn": ka,
            }
            if kind == "A":
                d["story_gate"] = a if ka else b
                d["story_node"] = ta[0] if ka else tb[0]
                d["story_key"] = g.scen_key(d["story_node"])
                d["straight_gate"] = b if ka else a
                d["straight_out"] = tb if ka else ta
            pairs.append(d)
    return pairs


def build_chain(g, pairs):
    """把 A 类门对串成链，返回最长链。

    链的连接关系是「**直通侧那道门** 就是下一对的父节点」：
        _2_1.OutPort → [门84N0(剧情), 门84N1(直通)]      ← pair1, parent=_2_1
        门84N1.OutPort → [门83N0(剧情), 门83N1(直通)]    ← pair2, parent=门84N1
        …
    """
    a_pairs = [p for p in pairs if p["kind"] == "A"]
    if not a_pairs:
        return []

    by_parent = {p["parent"]: p for p in a_pairs}
    succ = {}
    for p in a_pairs:
        gid = p["straight_gate"]
        if gid in by_parent:
            succ[p["parent"]] = gid

    has_pred = set(succ.values())
    heads = [p for p in a_pairs if p["parent"] not in has_pred]

    best = []
    for h in heads:
        chain = [h]
        seen = {h["parent"]}
        cur = h
        while cur["parent"] in succ:
            nxt_id = succ[cur["parent"]]
            if nxt_id in seen:
                break
            seen.add(nxt_id)
            cur = by_parent[nxt_id]
            chain.append(cur)
        if len(chain) > len(best):
            best = chain
    return best


def graph_report(g):
    pairs = find_pairs(g)
    chain = build_chain(g, pairs)
    a = [p for p in pairs if p["kind"] == "A"]
    b = [p for p in pairs if p["kind"] == "B"]
    rep = {
        "graph": g.name,
        "nodes": len(g.nodes),
        "scenarios": len(g.scen),
        "gates": len(g.gate),
        "pairs": len(pairs),
        "a_pairs": len(a),
        "b_pairs": len(b),
        "pids": sorted({p["pid"] for p in a}),
        "chain_len": len(chain),
    }
    if chain:
        head = chain[0]
        rep["start_key"] = head["parent_key"]
        rep["chain_keys"] = [p["story_key"] for p in chain]
        rep["last_straight_out"] = chain[-1]["straight_out"]
        rep["story_on_first_conn_all"] = all(p["story_on_first_conn"] for p in chain)
        rep["other_a_pairs"] = len(a) - len(chain)
        rep["same_shape"] = bool(
            head["parent_key"] is not None
            and rep["story_on_first_conn_all"]
            and len(chain) >= 2
        )
    else:
        rep["other_a_pairs"] = 0
        rep["same_shape"] = False
    return rep, chain


# ---------------------------------------------------------------- 入口
def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--zip", default=DEFAULT_ZIP)
    ap.add_argument("--min", type=int, default=1, help="只看 A 类门对 ≥N 的图（默认 1）")
    ap.add_argument("--detail", help="打印某张图的参数表")
    ap.add_argument("--only", help="只扫这一张图（比 --detail 快得多，不全量扫描）")
    ap.add_argument("--json", help="把完整结果写到这个 json 文件")
    ap.add_argument("--limit", type=int, default=0, help="只扫前 N 张图（调试用）")
    args = ap.parse_args()

    if not os.path.exists(args.zip):
        sys.exit("找不到 ModEditor.zip：%s\n用 --zip 指定" % args.zip)

    z = zipfile.ZipFile(args.zip)
    entries = [n for n in z.namelist()
               if n.startswith(STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]
    entries.sort()
    if args.only:
        wanted = STORY_PREFIX + args.only + ".asset"
        if wanted not in entries:
            sys.exit("资产里没有 %s" % wanted)
        entries = [wanted]
    if args.limit:
        entries = entries[:args.limit]
    print("剧情图共 %d 张，开始扫描…" % len(entries), file=sys.stderr)

    reports = []
    for i, entry in enumerate(entries, 1):
        name = entry[len(STORY_PREFIX):-len(".asset")]
        if i % 200 == 0:
            print("  …%d/%d" % (i, len(entries)), file=sys.stderr)
        try:
            raw = z.read(entry).decode("utf-8", errors="replace")
        except Exception as e:
            print("  跳过 %s: %s" % (name, e), file=sys.stderr)
            continue
        # 便宜的前置过滤：没有条件端口/伙伴条件的图不可能有门对
        if "conditionPort" not in raw or "partnerID" not in raw:
            continue
        try:
            g = StoryGraph(name, raw)
            rep, chain = graph_report(g)
        except Exception as e:
            print("  解析失败 %s: %s" % (name, e), file=sys.stderr)
            continue
        rep["_chain"] = chain
        reports.append(rep)

    if args.detail:
        hit = [r for r in reports if r["graph"] == args.detail]
        if not hit:
            sys.exit("没在扫描结果里找到 %s（可能没有任何 A 类门对）" % args.detail)
        r = hit[0]
        print("")
        print("=" * 72)
        print("图 %s   节点 %d   播放剧情 %d   门 %d   A 类 %d / B 类 %d"
              % (r["graph"], r["nodes"], r["scenarios"], r["gates"], r["a_pairs"], r["b_pairs"]))
        print("=" * 72)
        if not r["_chain"]:
            print("没有可展开的 A 类门对。")
            return
        print("可直接填进 BranchFlatten 的参数：")
        print('  GraphName   = "%s"' % r["graph"])
        print('  StartKey    = "%s"' % r.get("start_key"))
        print("  ChainKeys   = %s" % json.dumps(r.get("chain_keys"), ensure_ascii=False))
        print("  LadderSteps = %d" % r["chain_len"])
        print("  兜底门出口  = %s" % r["last_straight_out"])
        print("  同形（可直接套用现在的实现）: %s" % ("是" if r["same_shape"] else "否，需人工确认"))
        print("")
        print("展开后的播放顺序：")
        prev = r.get("start_key")
        for k in r.get("chain_keys") or []:
            print("    %-24s → %s" % (prev, k))
            prev = k
        print("    %-24s → 兜底（无伙伴）→ 汇合" % prev)
        return

    if args.json:
        out = [{k: v for k, v in r.items() if k != "_chain"} for r in reports]
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump(out, f, ensure_ascii=False, indent=1)
        print("已写 %s（%d 张图）" % (args.json, len(out)), file=sys.stderr)

    rows = [r for r in reports if r["a_pairs"] >= args.min]
    rows.sort(key=lambda r: (-r["chain_len"], -r["a_pairs"], r["graph"]))

    print("")
    print("=" * 100)
    print("有 A 类门对的图：%d 张（A 类门对 ≥%d）；其中同形可直接套用：%d 张"
          % (len(rows), args.min, sum(1 for r in rows if r["same_shape"])))
    print("=" * 100)
    print("%-28s %5s %4s %4s %4s  %-6s  %s" % ("图名", "节点", "A", "B", "链长", "同形", "涉及角色 id"))
    print("-" * 100)
    for r in rows:
        print("%-28s %5d %4d %4d %4d  %-6s  %s"
              % (r["graph"], r["nodes"], r["a_pairs"], r["b_pairs"], r["chain_len"],
                 "是" if r["same_shape"] else "否", ",".join(str(p) for p in r["pids"])[:60]))
    print("")
    print("说明：")
    print("  A 类 = 门对里一侧「播放剧情」、另一侧「直通」 → 可以串起来顺序播")
    print("  B 类 = 两侧都是「播放剧情」 → 现在的设计不适用（两侧都播会重复）")
    print("  同形 = 起点是播放剧情节点、剧情都在第 1 条连线上、所有 A 类在同一条链上")
    print("        → 可以只换 BranchFlatten 的 4 个常量")
    print("  用 --detail <图名> 看该图的参数表")


if __name__ == "__main__":
    main()
