# -*- coding: utf-8 -*-
"""批量生成「链式接续」补丁表（B/C 类图），离线校验。

规则（关键，与 10-22 手写补丁同型）：
    把「某角色内容末端」的出口 → 下一对的 F 门（在队门）
    不接回本对的 N1，因此不会回到原处成环。

"内容末端"的判定：
    从 F 的后继出发，沿单出口经过**纯副作用节点**（添加标记/追加简介/时间流逝）往下，
    取最后一条离开该串的边作为改写源 —— 这样标记类节点仍会被执行，不会被跳过。

顺序判定：
    ① 若所有内容场景的 ScenarioKey 数字序列可比较 → 按数字排序
    ② 否则按入口 BFS 首次遇到各 F 的先后
"""
import zipfile, re, collections, sys, io, json

ZIP = r'D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip'
PRE = 'Assets/GameRes/Story/'
PASS_THRU = ('添加标记', '追加简介', '时间流逝')
TARGET_GRAPHS = ['A15015-1', 'DBZX-9', 'DNJH-1', 'DNJH-7-3', 'Day-2020-6', 'Fame-5', 'M1100-13', 'M2155-6',
                 'M2190-2', 'M5029-1', 'M5061-2', 'M5061-3', 'M5061-5', 'R10003-5', 'R10005-5', 'R10005-8',
                 'R10007-2', 'R10007-4', 'R10008-1', 'R10008-3', 'R10008-6', 'R10039-6', 'R10049-10',
                 'R10049-11', 'R10049-2-1', 'R10052-2', 'R10054-4', 'R10061-4', 'R10079-1', 'R10084-2',
                 'R10098-1', 'R10099-9', 'R20004-5', 'R20006-3', 'Role3-1', 'Role3-23', 'Role5-10',
                 'Role5-15-2', 'School-2030-2', 'School-2070-B']

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


def cycles(D, outs):
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
                    found += 1; stack = []; break
                if c == 0:
                    color[t] = 1; stack.append((t, iter(outs.get(t, [])))); adv = True; break
            if not adv and stack:
                color[stack[-1][0]] = 2; stack.pop()
    return found


def reach(D, outs, s):
    seen = {s}
    st = [s]
    while st:
        c = st.pop()
        for t in outs.get(c, []):
            if t in D and t not in seen:
                seen.add(t); st.append(t)
    return seen


results = []
for g in TARGET_GRAPHS:
    path = PRE + g + '.asset'
    if path not in z.namelist():
        results.append((g, 0, 0, 'SKIP', '图不存在'))
        continue
    raw = z.read(path).decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*$', raw, flags=re.M)
    D = {parts[i]: parts[i+1] for i in range(1, len(parts), 2)}
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
        rF, rS = reach(D, outl, F), reach(D, outl, S)
        old = rF - rS - {F, S}
        if old:
            continue                        # A 类，已有算法覆盖，不在本表
        succ = outl.get(F, [])
        if not succ:
            items.append((pid, F, S, None, None))
            continue
        # 找内容末端：沿纯副作用节点往下
        cur = succ[0]; prev = None
        steps = 0
        while steps < 6:
            steps += 1
            if nm(D.get(cur, '')) in PASS_THRU:
                nx = outl.get(cur, [])
                if len(nx) == 1:
                    prev = cur; cur = nx[0]; continue
            break
        src = prev if prev else succ[0]
        items.append((pid, F, S, succ[0], src))

    items = [it for it in items if it[3]]
    if len(items) < 2:
        results.append((g, len(items), 0, 'SKIP', 'B/C 对不足 2 个，无需串接'))
        continue

    # 排序：优先场景编号
    def skey(sc):
        k = re.search(r'ScenarioKey:\s*(\S+)', D.get(sc, ''))
        if not k:
            return None
        return tuple(int(x) for x in re.findall(r'\d+', k.group(1)))
    keys = [skey(it[3]) for it in items]
    if all(k is not None for k in keys) and len(set(keys)) == len(keys):
        items.sort(key=lambda t: skey(t[3]))
        how = '场景编号'
    else:
        results.append((g, len(items), 0, 'SKIP', '场景编号不可比，需人工定序'))
        continue

    patch = []
    for i in range(len(items) - 1):
        pid, F, S, sc, src = items[i]
        npid, nF, nS, nsc, nsrc = items[i + 1]
        edges = outl.get(src, [])
        if len(edges) != 1:
            patch = None; break
        patch.append((src, edges[0], nF, npid))
    if patch is None:
        results.append((g, len(items), 0, 'SKIP', '内容末端出口不唯一'))
        continue

    sim = {k: list(v) for k, v in outl.items()}
    for src, oldt, newt, _ in patch:
        sim[src] = [newt if x == oldt else x for x in sim[src]]
    cyc0, cyc1 = cycles(D, outl), cycles(D, sim)
    # 校验：每个内容场景与每道 F 门在改后仍可达（从图内任意 F 出发）
    ok = cyc1 <= cyc0
    detail = '改线 %d 条；环 %d→%d' % (len(patch), cyc0, cyc1)
    if ok:
        for pid, F, S, sc, src in items:
            if sc not in reach(D, sim, F):
                ok = False; detail += '；场景不可达:' + lab(sc); break
    results.append((g, len(items), len(patch), 'PASS' if ok else 'FAIL', detail + '；排序=' + how))
    if ok and g == 'R10049-2-1':
        print('== R10049-2-1 补丁表 ==')
        for pid, F, S, sc, src in items:
            print('   pid=%-6s 内容=%-8s 末端=%s' % (pid, lab(sc), lab(src)))
        for src, oldt, newt, npid in patch:
            print('   PATCH %-8s → %-12s  (到 pid=%s)' % (lab(src), lab(newt), npid))
        print()

print('%-18s %4s %4s %-6s %s' % ('图', '对数', '改线', '结果', '说明'))
pass_n = fail_n = skip_n = 0
for g, np_, npatch, st, det in results:
    print('%-18s %4d %4d %-6s %s' % (g, np_, npatch, st, det))
    if st == 'PASS': pass_n += 1
    elif st == 'FAIL': fail_n += 1
    else: skip_n += 1
print()
print('汇总: PASS=%d  FAIL=%d  SKIP=%d  合计=%d' % (pass_n, fail_n, skip_n, len(results)))

# ---- 输出可直接粘贴的 C 表 ----
print()
print('// ==== 可直接粘贴到 flatten.cpp 的链式表（PASS 的图） ====')
first = True
for g, np_, npatch, st, det in results:
    if st != 'PASS':
        continue
    # 重新取该图的 pid 顺序
    path = PRE + g + '.asset'
    raw = z.read(path).decode('utf-8', 'replace')
    parts = re.split(r'^--- !u!114 &(-?\d+).*\$', raw, flags=re.M)
    D = {parts[i]: parts[i+1] for i in range(1, len(parts), 2)}
    P2 = {fid: ports(b) for fid, b in D.items()}
    outl2 = {fid: list(P2[fid].get('OutPort', [])) for fid in D}
    def nm2(b):
        m = re.search(r'm_Name:\s*"(.*?)"', b)
        if not m: return '?'
        try: return m.group(1).encode().decode('unicode_escape')
        except Exception: return m.group(1)
    gc2 = {}
    for fid, b in D.items():
        if nm2(b) != '流程判断': continue
        cp = P2[fid].get('conditionPort') or P2[fid].get('stateIn')
        if cp: gc2[fid] = cp[0]
    pairs2 = {}
    for fid, cid in gc2.items():
        cb = D.get(cid, '')
        if nm2(cb) != '需要伙伴': continue
        p = re.search(r'partnerID:\s*(\d+)', cb); q = re.search(r'Negate:\s*(\d)', cb)
        if p and q: pairs2.setdefault(p.group(1), {})[q.group(1)] = fid
    items2 = []
    for pid, d in pairs2.items():
        F, S = d.get('0'), d.get('1')
        if not F or not S: continue
        rF, rS = reach(D, outl2, F), reach(D, outl2, S)
        if rF - rS - {F, S}: continue
        sc = outl2.get(F, [None])[0]
        if sc: items2.append((pid, F, S, sc))
    def sk2(sc):
        k = re.search(r'ScenarioKey:\s*(\S+)', D.get(sc, ''))
        return tuple(int(x) for x in re.findall(r'\d+', k.group(1))) if k else None
    if any(sk2(it[3]) is None for it in items2): continue
    items2.sort(key=lambda t: sk2(t[3]))
    pids = [int(it[0]) for it in items2]
    var = 'k_chain_' + g.replace('-', '_').replace('.', '_')
    print('static const int %s[] = { %s };' % (var, ', '.join(str(x) for x in pids)))
    print('    { "%s", %s, %d },' % (g, var, len(pids)))
print('// ==== end ====')
