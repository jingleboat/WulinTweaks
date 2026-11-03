# -*- coding: utf-8 -*-
"""逐张分析剩余需要人工定序的图，输出候选顺序 + 依据。"""
import zipfile, re, collections

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
PRE = 'Assets/GameRes/Story/'
GRAPHS = ['M2155-6', 'Role5-15-2', 'R10007-4', 'Role5-10', 'M5061-3', 'R10039-6', 'School-2030-2']
PASS_THRU = ('添加标记', '追加简介', '时间流逝')
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


for g in GRAPHS:
    path = PRE + g + '.asset'
    if path not in z.namelist():
        print('== %s  （图不存在）' % g); print()
        continue
    raw = z.read(path).decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
    D = {parts[i]: parts[i + 1] for i in range(1, len(parts), 2)}
    P = {fid: ports(b) for fid, b in D.items()}
    outl = {fid: list(P[fid].get('OutPort', [])) for fid in D}

    def lab(fid):
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
        rF, rS = reach(outl, D, F), reach(outl, D, S)
        if rF - rS - {F, S}:
            continue
        succ = outl.get(F, [])
        if not succ:
            continue
        scene = succ[0]
        # 末端：沿单出口副作用节点下探
        cur, prev, steps = scene, None, 0
        while steps < 5:
            steps += 1
            if nm(D.get(cur, '')) in PASS_THRU:
                nx = outl.get(cur, [])
                if len(nx) == 1:
                    prev, cur = cur, nx[0]; continue
            break
        src = prev if prev else scene
        items.append({'pid': pid, 'F': F, 'S': S, 'scene': scene, 'src': src})

    print('== %s   （B/C 对 %d 个）' % (g, len(items)))
    for it in items:
        outs_src = outl.get(it['src'], [])
        print('   pid=%-6s 场景=%-22s 末端=%-18s 末端出口=%d → %s' % (
            it['pid'], lab(it['scene']), lab(it['src']), len(outs_src),
            [lab(x) for x in outs_src]))

    if len(items) < 2:
        print('   → 无需串接')
        print(); continue

    # 偏序：若 A 的场景能到达 B 的 F 门，则 A 在前
    n = len(items)
    before = [[False] * n for _ in range(n)]
    for i, it in enumerate(items):
        ri = reach(outl, D, it['scene'])
        for j, jt in enumerate(items):
            if i == j:
                continue
            if jt['F'] in ri:
                before[i][j] = True

    order = None
    # 拓扑排序（仅当偏序无环且能产生全序）
    indeg = [0] * n
    for i in range(n):
        for j in range(n):
            if before[i][j]:
                indeg[j] += 1
    q = [i for i in range(n) if indeg[i] == 0]
    topo = []
    while q:
        c = q.pop(0)
        topo.append(c)
        for j in range(n):
            if before[c][j]:
                indeg[j] -= 1
                if indeg[j] == 0:
                    q.append(j)
    if len(topo) == n:
        order = [items[i]['pid'] for i in topo]
        basis = '可达偏序'
    else:
        # 退回场景编号
        def skey(it):
            k = re.search(r'ScenarioKey:\s*(\S+)', D.get(it['scene'], ''))
            return tuple(int(x) for x in re.findall(r'\d+', k.group(1))) if k else None
        keys = [skey(it) for it in items]
        if all(k is not None for k in keys) and len(set(keys)) == n:
            order = [x['pid'] for _, x in sorted(zip(keys, items), key=lambda t: t[0])]
            basis = '场景编号'
        else:
            basis = None

    if order:
        print('   → 候选顺序（依据：%s）：%s' % (basis, ' → '.join(order)))
    else:
        print('   → 无法自动定序：可达偏序有环或缺编号，需要人工判断')
        for i, it in enumerate(items):
            nxt = [items[j]['pid'] for j in range(n) if before[i][j]]
            print('       %s 之后可达: %s' % (it['pid'], nxt))
    print()
