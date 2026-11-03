# -*- coding: utf-8 -*-
"""统计三项数据（离线，不碰游戏）：
  1. 剧情图里有多少张含「回环」（走线图上的环）
  2. 每个 pid 在同一张图里的条件条数分布
  3. 同一 pid 在同一张图里出现「多条 Negate=0」的图有多少（relax key 用 (图,pid) 会冲突）
  4. 顺带：每张图的「需要伙伴」门对数分布（决定 relax 额度粒度是否够）
"""
import os, sys, collections, json

sys.path.insert(0, os.path.join(os.path.dirname(os.path.abspath(__file__))))
TOOLS = r"C:\Users\User\Documents\deepseek-harness\default-workspace\wulin-mod\tools"
sys.path.insert(0, TOOLS)
import zipfile
import scan_flattenable as S

ZIP = S.DEFAULT_ZIP
STORY_PREFIX = S.STORY_PREFIX

z = zipfile.ZipFile(ZIP)
names = [n for n in z.namelist()
         if n.startswith(STORY_PREFIX) and n.endswith(".asset")
         and n[len(STORY_PREFIX):].count("/") == 0]

total_graphs = 0
graphs_with_cycle = 0
cycle_examples = []
pid_cond_count = collections.Counter()          # pid -> 该图内条件条数（按图取样，取最大）
multi_neg0_graphs = []                          # 同一 pid 多条 Negate=0
pair_count_dist = collections.Counter()         # 每图「需要伙伴」门对数
need_partner_graphs = 0
pid_neg0_multi = collections.Counter()

for n in names:
    try:
        raw = z.read(n).decode("utf-8", "replace")
        g = S.StoryGraph(n.split("/")[-1][:-6], raw)
    except Exception:
        continue
    total_graphs += 1

    # ---- 走线图 & 环检测 ----
    outs = {fid: [t for t in g.outs(fid)] for fid in g.nodes}
    # 三色 DFS 检测环
    color = {}
    has_cycle = False
    for root in list(g.nodes):
        if color.get(root, 0) != 0:
            continue
        stack = [(root, iter(outs.get(root, [])))]
        color[root] = 1
        while stack:
            node, it = stack[-1]
            advanced = False
            for t in it:
                c = color.get(t, 0)
                if c == 1:
                    has_cycle = True
                    stack = []
                    break
                if c == 0:
                    color[t] = 1
                    stack.append((t, iter(outs.get(t, []))))
                    advanced = True
                    break
            if not advanced and stack:
                color[stack[-1][0]] = 2
                stack.pop()
            if has_cycle:
                break
        if has_cycle:
            break
    if has_cycle:
        graphs_with_cycle += 1
        if len(cycle_examples) < 10:
            cycle_examples.append(n.split("/")[-1][:-6])

    # ---- 条件统计（只看「需要伙伴」）----
    per_pid = collections.defaultdict(lambda: [0, 0])   # pid -> [neg0, neg1]
    for fid in g.nodes:
        for c in g.conditions(fid) if hasattr(g, "conditions") else []:
            pass
    # 用 scan_flattenable 现成的门对识别更稳
    try:
        pairs = S.find_pairs(g)
    except Exception:
        pairs = []
    if pairs:
        need_partner_graphs += 1
        pair_count_dist[len(pairs)] += 1
    for p in pairs:
        pid = p.get("pid")
        if pid is None:
            continue
        per_pid[pid][0] += 1        # 先按"对数"记在 neg0 位，稍后单独统计多重
    for pid, v in per_pid.items():
        pid_cond_count[v[0]] += 1
        if v[0] > 1:
            pid_neg0_multi[pid] += 1
            if len(multi_neg0_graphs) < 15:
                multi_neg0_graphs.append((n.split("/")[-1][:-6], pid, v[0]))

print("剧情图总数:", total_graphs)
print("含回环的图:", graphs_with_cycle, "  例:", cycle_examples)
print("含「需要伙伴」门对的图:", need_partner_graphs)
print()
print("每图门对数量分布（前 12）:")
for k, v in sorted(pair_count_dist.items())[:12]:
    print("   %2d 对 : %d 张图" % (k, v))
print()
print("同一 pid 在同一图里出现多对门的情况（前 15）:")
for gname, pid, cnt in multi_neg0_graphs:
    print("   %-14s pid=%-8d 门对=%d" % (gname, pid, cnt))
print("   合计涉及 pid 数:", len(pid_neg0_multi))
