# -*- coding: utf-8 -*-
"""离线验证：region=0 的门对里，'放宽后会不会通向下一批门对' 能否区分
   链式型（放宽有益）与 危险型（放宽有害，如 R10049-2-1 的 10061）。
"""
import zipfile, re, collections

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
PRE = 'Assets/GameRes/Story/'
z = zipfile.ZipFile(ZIP)
names = [n for n in z.namelist() if n.startswith(PRE) and n.endswith('.asset') and n[len(PRE):].count('/') == 0]


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


def reach(outs, D, s, cap=400):
    seen = {s}
    st = [s]
    while st and len(seen) < cap:
        c = st.pop()
        for t in outs.get(c, []):
            if t in D and t not in seen:
                seen.add(t); st.append(t)
    return seen


chain_graphs = []
danger_graphs = []
stats = collections.Counter()
detail = []

for n in names:
    g = n[len(PRE):-len('.asset')]
    raw = z.read(n).decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
    D = {parts[i]: parts[i + 1] for i in range(1, len(parts), 2)}
    if len(D) < 4:
        continue
    P = {fid: ports(b) for fid, b in D.items()}
    outl = {fid: list(P[fid].get('OutPort', [])) for fid in D}

    gc = {}
    for fid, b in D.items():
        if nm(b) != '流程判断':
            continue
        cp = P[fid].get('conditionPort') or P[fid].get('stateIn')
        if cp:
            gc[fid] = cp[0]

    pairs = {}
    for fid, cid in gc.items():
        cb = D.get(cid, '')
        if nm(cb) != '需要伙伴':
            continue
        p = re.search(r'partnerID:\s*(\d+)', cb)
        q = re.search(r'Negate:\s*(\d)', cb)
        if p and q:
            pairs.setdefault(p.group(1), {})[q.group(1)] = fid

    bc = []
    for pid, d in pairs.items():
        F, S = d.get('0'), d.get('1')
        if not F or not S:
            continue
        if reach(outl, D, F) - reach(outl, D, S) - {F, S}:
            continue
        bc.append((pid, F, S))
    if not bc:
        continue

    for pid, F, S in bc:
        succ = outl.get(F, [])
        if not succ:
            stats['no_succ'] += 1
            continue
        r = reach(outl, D, succ[0])
        others = [q for q, qF, qS in bc if q != pid and qF in r]
        if others:
            stats['chain_like'] += 1
            chain_graphs.append(g)
            detail.append((g, pid, '链式→' + ','.join(others)))
        else:
            stats['dead_end'] += 1
            danger_graphs.append(g)
            detail.append((g, pid, '死支'))

print('=== 分类结果 ===')
print('  能到达下一批门对（链式型）:', stats['chain_like'])
print('  到不了（死支型）          :', stats['dead_end'])
print('  无后继                    :', stats['no_succ'])
print()
uniq_chain = sorted(set(chain_graphs))
uniq_dead = sorted(set(danger_graphs))
print('链式型图 (%d):' % len(uniq_chain), uniq_chain[:25])
print()
print('死支型图 (%d):' % len(uniq_dead), uniq_dead[:25])
print()
print('=== 关键样本核对 ===')
for g in ('M2155-6', 'Role5-15-2', 'R10049-2-1', 'M5061-5', 'R10005-5', 'R10098-1'):
    tags = [d for d in detail if d[0] == g]
    print('  %-12s %s' % (g, tags[:6] if tags else '（无 B/C 对）'))
