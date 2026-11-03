# -*- coding: utf-8 -*-
"""输出 4 张 PASS 图的链式 pid 顺序（C 表）"""
import zipfile, re, collections

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
PRE = 'Assets/GameRes/Story/'
GRAPHS = ['M5061-5', 'R10005-5', 'R10049-2-1', 'R10098-1']
z = zipfile.ZipFile(ZIP)


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


def reach(outs, D, s):
    seen = {s}
    st = [s]
    while st:
        c = st.pop()
        for t in outs.get(c, []):
            if t in D and t not in seen:
                seen.add(t); st.append(t)
    return seen


print('static const FLAT_CHAIN_T k_chains[] = {')
for g in GRAPHS:
    raw = z.read(PRE + g + '.asset').decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
    D = {parts[i]: parts[i + 1] for i in range(1, len(parts), 2)}
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
    items = []
    for pid, d in pairs.items():
        F, S = d.get('0'), d.get('1')
        if not F or not S:
            continue
        if reach(outl, D, F) - reach(outl, D, S) - {F, S}:
            continue                      # A 类
        sc = outl.get(F, [None])[0]
        if not sc:
            continue
        k = re.search(r'ScenarioKey:\s*(\S+)', D.get(sc, ''))
        if not k:
            continue
        seq = tuple(int(x) for x in re.findall(r'\d+', k.group(1)))
        items.append((seq, int(pid), k.group(1)))
    items.sort()
    pids = [it[1] for it in items]
    var = 'k_chain_' + re.sub(r'[^0-9A-Za-z]', '_', g)
    print('    static const int %s[] = { %s };   // %s 顺序: %s' % (
        var, ', '.join(str(x) for x in pids), g, ' → '.join(str(x) for x in pids)))
    print('    { "%s", %s, %d },' % (g, var, len(pids)))
print('};')
