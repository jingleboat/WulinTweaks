# -*- coding: utf-8 -*-
"""普查：旧判据（可达差集 region）漏掉了多少「入口独占」的门对。

对每张剧情图的每个「需要伙伴」互补门对 (F=Negate0 门, S=Negate1 门)：
  old_region = Reach(F) - Reach(S) - {F,S}
  · old_region 非空            → 旧判据可展开
  · old_region 为空，但 F 的某个后继 s0 入度=1 且唯一前驱就是 F
    且从 s0 沿单出口能走到「汇合点」→ 旧判据漏掉（链式可展开）
  其余 → 两侧真正共享，不可展开
"""
import zipfile, re, collections, sys

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
    """返回 {portName: [targets]}，按 connections 顺序（只认 _fieldName 块）"""
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


stats = collections.Counter()
per_graph = []
samples = []

for n in names:
    g = n[len(PREFIX):-len('.asset')]
    raw = z.read(n).decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
    D = {parts[i]: parts[i+1] for i in range(1, len(parts), 2)}
    if len(D) < 4:
        continue
    P = {fid: parse_ports(b) for fid, b in D.items()}
    outs = {fid: P[fid].get('OutPort', []) for fid in D}
    ins = collections.defaultdict(list)
    for f, ts in outs.items():
        for t in ts:
            if t in D:
                ins[t].append(f)

    def reach(s):
        seen = {s}
        st = [s]
        while st:
            c = st.pop()
            for t in outs.get(c, []):
                if t in D and t not in seen:
                    seen.add(t); st.append(t)
        return seen

    # 门 → 条件
    gate_cond = {}
    for fid, b in D.items():
        if nm(b) != '流程判断':
            continue
        cp = P[fid].get('conditionPort') or P[fid].get('stateIn')
        if cp:
            gate_cond[fid] = cp[0]

    pairstat = collections.Counter()
    for fid, cid in gate_cond.items():
        cb = D.get(cid, '')
        if nm(cb) != '需要伙伴':
            continue
        p = re.search(r'partnerID:\s*(\d+)', cb)
        nq = re.search(r'Negate:\s*(\d)', cb)
        if not p or not nq or nq.group(1) != '0':
            continue
        pid = p.group(1)
        # 找同 pid 的 neg=1 门
        S = None
        for g2, c2 in gate_cond.items():
            cb2 = D.get(c2, '')
            if nm(cb2) != '需要伙伴':
                continue
            p2 = re.search(r'partnerID:\s*(\d+)', cb2)
            n2 = re.search(r'Negate:\s*(\d)', cb2)
            if p2 and n2 and p2.group(1) == pid and n2.group(1) == '1':
                S = g2; break
        if S is None:
            continue
        F = fid
        rF, rS = reach(F), reach(S)
        old = rF - rS - {F, S}
        if old:
            pairstat['old_ok'] += 1
            continue
        # 入口独占检查
        chain_hit = False
        for s0 in outs.get(F, []):
            if s0 not in D:
                continue
            if len(ins[s0]) == 1 and ins[s0][0] == F:
                # 沿单出口走到汇合点（入度>1 或进入 rS）
                cur = s0
                steps = 0
                while steps < 12:
                    steps += 1
                    nx = outs.get(cur, [])
                    if len(nx) != 1:
                        break
                    t = nx[0]
                    if t in rS or len(ins[t]) > 1:
                        chain_hit = True
                        break
                    cur = t
                if chain_hit:
                    break
        if chain_hit:
            pairstat['missed_entry_exclusive'] += 1
            if len(samples) < 15:
                samples.append((g, pid))
        else:
            pairstat['really_shared'] += 1

    if pairstat:
        stats.update(pairstat)
        if pairstat['missed_entry_exclusive']:
            per_graph.append((g, dict(pairstat)))

print('扫描图数:', len(names))
print('门对统计:')
for k in ('old_ok', 'missed_entry_exclusive', 'really_shared'):
    print('   %-24s %d' % (k, stats[k]))
print()
print('被旧判据漏掉（入口独占却判 region=0）的图，前 15 个:')
for g, d in per_graph[:15]:
    print('   %-18s %s' % (g, d))
print()
print('漏掉的样例（图, pid）:')
for g, pid in samples:
    print('   %-18s pid=%s' % (g, pid))
print()
miss = stats['missed_entry_exclusive']
tot = stats['old_ok'] + miss
if tot:
    print('旧判据覆盖率: %d/%d = %.1f%%   漏掉 %d 对' % (stats['old_ok'], tot, 100.0 * stats['old_ok'] / tot, miss))
