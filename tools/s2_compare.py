# -*- coding: utf-8 -*-
"""S2：对比「手写 5 条链式改线」与「当前通用改线」在 R10049-2 上的走线差异。

模型说明（必须显式声明，避免把假设当事实）：
  · 引擎取边模型 = **按 OutPort 连接顺序，第一个“可用”的就被选**
    其中：目标是非门节点（播放剧情/时间流逝/追加简介…）视为可用；
          目标是门（流程判断）且该门被强制放行（放宽/展平）视为可用。
  · 条件类的真实真假无法离线得知 → 本脚本只做**结构对比**，
    不声称复现真实语义；凡涉及“条件真假”的地方一律标注为模型假设。
"""
import zipfile, re, collections, sys

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
GRAPH = 'R10049-2'

z = zipfile.ZipFile(ZIP)
raw = z.read('Assets/GameRes/Story/%s.asset' % GRAPH).decode('utf-8', 'replace')
parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
D = {parts[i]: parts[i + 1] for i in range(1, len(parts), 2)}


def nm(b):
    m = re.search(r'm_Name:\s*"(.*?)"', b)
    if not m:
        return '?'
    try:
        return m.group(1).encode().decode('unicode_escape')
    except Exception:
        return m.group(1)


def ports(b):
    r = collections.defaultdict(list)
    for m in re.finditer(r'fieldName:\s*(\w+)\s*\n\s*node:\s*\{fileID:\s*(-?\d+)\}', b):
        r[m.group(1)].append(m.group(2))
    return r


def label(fid):
    b = D.get(fid, '')
    n = nm(b)
    k = re.search(r'ScenarioKey:\s*(\S+)', b)
    return '%s%s' % (n, ('[' + k.group(1).split('_', 1)[-1] + ']') if k else '')


def out(fid):
    return ports(D.get(fid, '')).get('OutPort') or []


def is_gate(fid):
    return nm(D.get(fid, '')) == '流程判断'


# ---- 找每个场景 / 关键节点 ----
bykey = {}
for fid, b in D.items():
    k = re.search(r'ScenarioKey:\s*(\S+)', b)
    if k:
        bykey[k.group(1)] = fid

# ---- 条件 → 门 的映射（用 stateIn 或 conditionPort）----
cond_of_gate = {}
for fid, b in D.items():
    if nm(b) != '流程判断':
        continue
    for key in ('conditionPort', 'stateIn'):
        c = ports(b).get(key)
        if c:
            cond_of_gate[fid] = c[0]
            break


def cond_info(gate):
    c = cond_of_gate.get(gate)
    b = D.get(c, '')
    pid = re.search(r'partnerID:\s*(\d+)', b)
    neg = re.search(r'Negate:\s*(\d+)', b)
    return (nm(b), int(pid.group(1)) if pid else 0, int(neg.group(1)) if neg else 0)


def gate_by(pid, neg):
    for g in cond_of_gate:
        t, p, n = cond_info(g)
        if t == '需要伙伴' and p == pid and n == neg:
            return g
    return None


# ================= 配置 A：手写 5 条链式改线 =================
def rewire(edges, src_key, tgt_gate):
    """把 bykey[src_key] 的 OutPort 第一条连接改指 tgt_gate"""
    src = bykey.get(src_key)
    if not src or not tgt_gate:
        return False
    edges[src] = [tgt_gate]
    return True


def build_edges():
    return {fid: list(out(fid)) for fid in D}


HAND = [
    ('R10049-2_2_2', (10083, 0)),
    ('R10049-2_2_3', (10078, 0)),
    ('R10049-2_2_4', (10053, 0)),
    ('R10049-2_2_5', (10008, 0)),
    ('R10049-2_2_6', (10008, 1)),
]

EA = build_edges()
okA = 0
for key, (pid, neg) in HAND:
    g = gate_by(pid, neg)
    if rewire(EA, key, g):
        okA += 1

# ================= 配置 B：当前通用改线（region/exits → Second） =================
def build_pairs():
    """严格按“同一 OutPort 恰好两条连线、两个目标都是门、pid 相同、Negate 互补”"""
    res = []
    for fid in D:
        op = out(fid)
        if len(op) != 2:
            continue
        a, b = op
        if not (is_gate(a) and is_gate(b)):
            continue
        ca, cb = cond_info(a), cond_info(b)
        if ca[0] != '需要伙伴' or cb[0] != '需要伙伴':
            continue
        if ca[1] != cb[1] or ca[2] == cb[2]:
            continue
        res.append((fid, a, b, ca[1]))
    return res


def reach(start, edges):
    seen = {start}
    st = [start]
    while st:
        c = st.pop()
        for t in edges.get(c, []):
            if t in D and t not in seen:
                seen.add(t)
                st.append(t)
    return seen


EB = build_edges()
pairsB = build_pairs()
rewiredB = 0
for src, g_first, g_second, pid in pairsB:
    r_first = reach(g_first, EB)
    r_second = reach(g_second, EB)
    region = (r_first - r_second) - {g_first, g_second}
    if not region:
        continue
    for node in region:
        nf = EB.get(node, [])
        EB[node] = [g_second if t not in region else t for t in nf]
        rewiredB += 1

# ================= 走线模拟（按连接顺序取第一个“可用”）=================
def walk(edges, start_key, forced_gates, steps=40):
    cur = bykey.get(start_key)
    seq = []
    seen_state = collections.Counter()
    while cur and steps > 0:
        steps -= 1
        seq.append(label(cur))
        seen_state[cur] += 1
        if seen_state[cur] > 3:          # 防环
            seq.append('<循环>')
            break
        nxt = None
        for t in edges.get(cur, []):
            if is_gate(t) and t not in forced_gates:
                continue                  # 未被强制放行的门：按“不可用”处理（模型假设）
            nxt = t
            break
        cur = nxt
    return seq


allgates = set(cond_of_gate.keys())
cfgA = walk(EA, 'R10049-2_1', allgates)
cfgB = walk(EB, 'R10049-2_1', allgates)

# 原版（未经任何改线）：门只在“条件为真”时可用 → 这里用“门店全放行”的上界模型
EV = build_edges()
cfgV = walk(EV, 'R10049-2_1', allgates)

print('图 =', GRAPH)
print('严格兄弟对 =', len(pairsB), '  B 配置改线条数 =', rewiredB, '  A 配置手写改线 =', okA, '条')
print()
for name, seq in (('① 原版结构(门全放行上界)', cfgV), ('② 配置A 手写链式改线', cfgA), ('③ 配置B 通用改线', cfgB)):
    print(name)
    print('   ', ' → '.join(seq))
    print()
print('历史对照：')
print('   2026-10-22 实际: _1 → _2_1 → _2_2 → _2_3 → _2_4 → _2_5 → _2_6 → _2_8 → _2_9 → _8_0 → _8_1 → _3_0 → _3_2 → _3_2_2 → _3_3 → _3_4')
print('   v166 实际     : _1 … _2_6 → _2_8 → _2_9 → _8_0 → _8_2 → _3_0 → _3_1 → 停')
