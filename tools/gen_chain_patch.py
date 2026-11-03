# -*- coding: utf-8 -*-
"""为 R10049-2-1 生成「链式接续」补丁表（离线，不改游戏）。

思路（与 10-22 手写补丁同型）：
    场景_i 的出口  →  下一对的 F 门（在队门）
这样绕开 N1，不产生“接回 N1 必成环”的问题。

校验：
    ① 改线后整图是否出现新环（以改线前的环集合为基准）
    ② 每段内容场景是否仍可达
    ③ 每道 F 门是否仍可达（否则那条支线永远进不去）
"""
import zipfile, re, collections

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
GRAPH = 'R10049-2-1'

z = zipfile.ZipFile(ZIP)
raw = z.read('Assets/GameRes/Story/%s.asset' % GRAPH).decode('utf-8', 'replace')
parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
D = {parts[i]: parts[i+1] for i in range(1, len(parts), 2)}


def nm(b):
    m = re.search(r'm_Name:\s*"(.*?)"', b)
    if not m:
        return '?'
    try:
        return m.group(1).encode().decode('unicode_escape')
    except Exception:
        return m.group(1)


def ports(b):
    out = collections.defaultdict(list)
    cur = None
    inc = False
    for line in b.splitlines():
        s = line.strip()
        m = re.match(r'-?\s*_fieldName:\s*(\w+)', s)
        if m:
            cur = m.group(1); inc = False; continue
        if s.startswith('connections:'):
            inc = True; continue
        if cur and inc:
            if re.match(r'^-\s*fieldName:', s):
                continue
            m3 = re.match(r'node:\s*\{fileID:\s*(-?\d+)\}', s)
            if m3:
                out[cur].append(m3.group(1)); continue
            if s.startswith('_direction') or s.startswith('_connectionType'):
                inc = False
    return out


P = {fid: ports(b) for fid, b in D.items()}
outl = {fid: list(P[fid].get('OutPort', [])) for fid in D}


def label(fid):
    b = D.get(fid, '')
    k = re.search(r'ScenarioKey:\s*(\S+)', b)
    if k:
        return k.group(1)
    s = nm(b)
    if s == '流程判断':
        cp = P[fid].get('conditionPort') or P[fid].get('stateIn')
        if cp:
            cb = D.get(cp[0], '')
            p = re.search(r'partnerID:\s*(\d+)', cb)
            n = re.search(r'Negate:\s*(\d)', cb)
            return '门[%s/%s]' % (p.group(1) if p else '?', n.group(1) if n else '?')
    return s


# ---- 找门对 ----
gate_cond = {}
for fid, b in D.items():
    if nm(b) != '流程判断':
        continue
    cp = P[fid].get('conditionPort') or P[fid].get('stateIn')
    if cp:
        gate_cond[fid] = cp[0]

pairs = {}
for fid, cid in gate_cond.items():
    cb = D.get(cid, '')
    if nm(cb) != '需要伙伴':
        continue
    p = re.search(r'partnerID:\s*(\d+)', cb)
    q = re.search(r'Negate:\s*(\d)', cb)
    if not (p and q):
        continue
    pairs.setdefault(p.group(1), {})[q.group(1)] = fid

print('== 门对一览（%s）' % GRAPH)
ordered = []
for pid, d in pairs.items():
    F, S = d.get('0'), d.get('1')
    if not F or not S:
        continue
    succ = outl.get(F, [])
    print('   pid=%-6s F=%s(→%s)  S=%s' % (pid, label(F), [label(x) for x in succ], label(S)))
    if succ:
        ordered.append((pid, F, S, succ[0]))

# ---- 自然顺序：从入口 BFS，记录第一次遇到各 F 的先后 ----
entries = [fid for fid in D if nm(D[fid]) == '玩家进入事件']
start = entries[0] if entries else None
order = {}
if start:
    seen = {start}
    q = collections.deque([start])
    idx = 0
    while q:
        c = q.popleft()
        idx += 1
        for pid, F, S, scene in ordered:
            if c == F and pid not in order:
                order[pid] = idx
        for t in outl.get(c, []):
            if t in D and t not in seen:
                seen.add(t); q.append(t)
for pid, F, S, scene in ordered:
    order.setdefault(pid, 10 ** 9)

chain = sorted(ordered, key=lambda x: order[x[0]])
print()
print('== 推断顺序（按图遍历先后）')
for pid, F, S, scene in chain:
    print('   pid=%-6s 场景=%s  F=%s' % (pid, label(scene), label(F)))

# ---- 生成补丁表：scene_i 出口 → F_{i+1} ----
print()
print('== 补丁表（改线）')
patch = []
for i in range(len(chain) - 1):
    pid, F, S, scene = chain[i]
    npid, nF, nS, nscene = chain[i + 1]
    src = scene
    old = outl.get(src, [])
    patch.append((src, old[0] if old else None, nF, npid))
    print('   %-18s 出口 %s  →  %s   （pid=%s）' % (label(src), [label(x) for x in old], label(nF), npid))

# ---- 校验 ----
def cycles(outs):
    color = {}
    found = 0
    for root in list(D):
        if color.get(root, 0):
            continue
        stack = [(root, iter(outs.get(root, [])))]
        color[root] = 1
        while stack:
            node, it = stack[-1]
            adv = False
            for t in it:
                if t not in D:
                    continue
                c = color.get(t, 0)
                if c == 1:
                    found += 1
                    stack = []
                    break
                if c == 0:
                    color[t] = 1
                    stack.append((t, iter(outs.get(t, []))))
                    adv = True
                    break
            if not adv and stack:
                color[stack[-1][0]] = 2
                stack.pop()
    return found


def reach(outs, s):
    seen = {s}
    st = [s]
    while st:
        c = st.pop()
        for t in outs.get(c, []):
            if t in D and t not in seen:
                seen.add(t); st.append(t)
    return seen


sim = {k: list(v) for k, v in outl.items()}
for src, old, new, _ in patch:
    if old:
        sim[src] = [new if x == old else x for x in sim[src]]

cyc0, cyc1 = cycles(outl), cycles(sim)
print()
print('== 校验')
print('   改线前环数:', cyc0, ' 改线后环数:', cyc1, ' →', '通过' if cyc1 <= cyc0 else '不通过（新增环）')
r0 = reach(outl, start) if start else set()
r1 = reach(sim, start) if start else set()
missing = [label(x) for x in r0 - r1]
print('   入口可达节点: 改前 %d / 改后 %d' % (len(r0), len(r1)))
print('   丢失节点:', missing[:8] if missing else '无')
lost_F = [label(F) for pid, F, S, sc in chain if F not in r1]
print('   不可达的 F 门:', lost_F if lost_F else '无')
lost_scene = [label(sc) for pid, F, S, sc in chain if sc not in r1]
print('   不可达的场景:', lost_scene if lost_scene else '无')
