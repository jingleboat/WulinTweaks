#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""打印某张地图 prefab 的对象层级（UnityPy，单遍建树）。

用法：
    python dump_map_tree.py map_504                 # 前 3 层
    python dump_map_tree.py map_504 --depth 5
    python dump_map_tree.py map_504 --grep Swim     # 只列名字含 Swim 的节点（全深度）
"""
import gzip
import sys

import UnityPy

BUNDLE = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\aa\StandaloneWindows64\map_assets_all.bundle"


def build(env):
    tr = {}          # tr_path -> (go_path, father_path, [children])
    for obj in env.objects:
        if obj.type.name != "Transform":
            continue
        try:
            d = obj.read()
        except Exception:
            continue
        go = getattr(d, "m_GameObject", None)
        fa = getattr(d, "m_Father", None)
        kids = [getattr(k, "path_id", k) for k in getattr(d, "m_Children", [])]
        tr[obj.path_id] = (getattr(go, "path_id", None), getattr(fa, "path_id", None), kids)
    names = {}
    for obj in env.objects:
        if obj.type.name == "GameObject":
            try:
                names[obj.path_id] = obj.read().m_Name
            except Exception:
                pass
    go2tr = {g: t for t, (g, f, k) in tr.items() if g}
    return tr, names, go2tr


def main():
    needle = sys.argv[1]
    depth = 3
    grep = None
    for i, a in enumerate(sys.argv):
        if a == "--depth":
            depth = int(sys.argv[i + 1])
        if a == "--grep":
            grep = sys.argv[i + 1].lower()
    raw = gzip.decompress(open(BUNDLE, "rb").read())
    env = UnityPy.load(raw)
    tr, names, go2tr = build(env)
    print("objects=%d transforms=%d gos=%d" % (len(env.objects), len(tr), len(names)))

    def nm_tr(t):
        g = tr.get(t)
        return names.get(g[0], "?") if g else "?"

    targets = [t for t, (g, f, k) in tr.items()
               if (names.get(g) or "").lower() == needle.lower()]
    if not targets:
        targets = [t for t, (g, f, k) in tr.items()
                   if needle.lower() in (names.get(g) or "").lower() and tr[t][2]]
    print("匹配:", len(targets), [nm_tr(t) for t in targets[:4]])

    seen = 0
    for root in targets[:2]:
        out = []
        stack = [(root, 0)]
        while stack:
            t, d = stack.pop()
            n = nm_tr(t)
            kids = tr[t][2]
            if grep is None or grep in n.lower():
                out.append((d, n, len(kids)))
            if d < (999 if grep else depth):
                for k in kids:
                    if k in tr:
                        stack.append((k, d + 1))
            seen += 1
        print("=== 根 %s：列 %d 项" % (nm_tr(root), len(out)))
        for d, n, k in out[:400]:
            print("  " * d + n + ("  [%d]" % k if k else ""))


if __name__ == "__main__":
    main()
