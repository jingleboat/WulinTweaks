# -*- coding: utf-8 -*-
"""B 类门对（region=0 但入口独占）的「链式接续」可行性统计。

对每一对：
  1. 找 F(N0) 的入口独占后继 s0（入度=1 且唯一前驱是 F）
  2. 沿单出口走到汇合点 t（t ∈ Reach(S) 或 入度(t) > 1）
  3. 模拟把「prev → t」改指为「prev → S」
  4. 校验两条：
       ① 无环：S 不能回到 prev
       ② 不丢内容：t 仍可从 S 到达
  结论：两条都过 → 可静态展开；否则 → 不可（记录原因）
"""
import zipfile, re, collections

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
PREFIX = 'Assets/GameRes/Story/'
z = zipfile.ZipFile(ZIP)
names = [n for n in z.namelist() if n.startswith(PREFIX) and n.endswith('.asset') and n[len(PREFIX):].count('/') == 0]


def nm(b):
    m = re.search(r'm_Name:\s*"(.*?)"', b)
    if not m:
        return '?'
    try:
        return m.group(1).encode().decode('unicode_escape')
    except Exception:
        return m.group(1)


def parse_ports(b):
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


def reach(outs, D, s):
    seen = {s}
    st = [s]
    while st:
        c = st.pop()
        for t in outs.get(c, []):
            if t in D and t not in seen:
                seen.add(t); st.append(t)
    return seen


stat = collections.Counter()
details = []

for n in names:
    g = n[len(PREFIX):-len('.asset')]
    raw = z.read(n).decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
    D = {parts[i]: parts[i+1] for i in range(1, len(parts), 2)}
    if len(D) < 4:
        continue
    P = {fid: parse_ports(b) for fid, b in D.items()}
    outs = {fid: list(P[fid].get('OutPort', [])) for fid in D}
    ins = collections.defaultdict(list)
    for f, ts in outs.items():
        for t in ts:
            if t in D:
                ins[t].append(f)

    gate_cond = {}
    for fid, b in D.items():
        if nm(b) != '流程判断':
            continue
        cp = P[fid].get('conditionPort') or P[fid].get('stateIn')
        if cp:
            gate_cond[fid] = cp[0]

    seen_pids = {}
    for fid, cid in gate_cond.items():
        cb = D.get(cid, '')
        if nm(cb) != '需要伙伴':
            continue
        p = re.search(r'partnerID:\s*(\d+)', cb)
        nq = re.search(r'Negate:\s*(\d)', cb)
        if not p or not nq:
            continue
        pid, neg = p.group(1), nq.group(1)
        if neg == '0':
            seen_pids.setdefault(pid, {})['F'] = fid
        else:
            seen_pids.setdefault(pid, {})['S'] = fid

    for pid, d in seen_pids.items():
        F, S = d.get('F'), d.get('S')
        if not F or not S:
            continue
        rF, rS = reach(outs, D, F), reach(outs, D, S)
        old = rF - rS - {F, S}
        if old:
            continue          # A 类，不在本次统计范围
        # B 类判定
        cand = None
        for s0 in outs.get(F, []):
            if s0 not in D:
                continue
            if len(ins[s0]) == 1 and ins[s0][0] == F:
                cur, prev, steps = s0, F, 0
                while steps < 12:
                    steps += 1
                    nx = outs.get(cur, [])
                    if len(nx) != 1:
                        break
                    t = nx[0]
                    if t in rS or len(ins[t]) > 1:
                        cand = (prev, cur, t)
                        break
                    prev, cur = cur, t
                if cand:
                    break
        if not cand:
            stat['C_shared'] += 1
            continue
        prev, cur, t = cand
        # 模拟改线 prev→S
        sim = {k: list(v) for k, v in outs.items()}
        sim[prev] = [S if x == t else x for x in sim[prev]]
        rS2 = reach(sim, D, S)
        cycle = prev in rS2            # ① 改后 S 能回到 prev → 成环
        keep = t in rS2                # ② 汇合点仍可达
        if cycle and keep:
            stat['B_cycle'] += 1
            details.append((g, pid, '成环'))
        elif cycle and not keep:
            stat['B_cycle_lose'] += 1
            details.append((g, pid, '成环且丢汇合点'))
        elif not keep:
            stat['B_lose_merge'] += 1
            details.append((g, pid, '丢汇合点'))
        else:
            stat['B_ok'] += 1

print('B 类（region=0 且入口独占）链式接续可行性：')
print('   可安全展开 :', stat['B_ok'])
print('   会成环     :', stat['B_cycle'])
print('   成环且丢点 :', stat['B_cycle_lose'])
print('   丢汇合点   :', stat['B_lose_merge'])
print('   实为共享   :', stat['C_shared'])
tot = stat['B_ok'] + stat['B_cycle'] + stat['B_cycle_lose'] + stat['B_lose_merge']
if tot:
    print('   合计 B 类 =', tot, ' 可展开占比 = %.1f%%' % (100.0 * stat['B_ok'] / tot))
print()
print('不可安全展开的明细（前 20）:')
for g, pid, why in details[:20]:
    print('   %-18s pid=%-7s %s' % (g, pid, why))
