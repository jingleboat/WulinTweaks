#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""UnityPy 打开 PC 的 map_assets_all.bundle（gzip 外套），列出所有 Tilemap 的格子坐标。

- 无参数：列出 tiles>=20 的 Tilemap（名字 / 格子数 / x,y 范围）
- 参数 = 格子数：只细看那一张（打印坐标集合概况）
- 附加 --parent：尝试打印该 Tilemap 所在的 prefab 根名（map_XXXX）
"""
import collections
import gzip
import sys

import UnityPy

BUNDLE = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\aa\StandaloneWindows64\map_assets_all.bundle"


def tiles_of(tm):
    out = []
    for t in tm.m_Tiles:
        pos = t[0] if isinstance(t, tuple) else t.m_Position
        out.append((pos.x, pos.y, pos.z))
    return out


def main():
    want = None
    for a in sys.argv[1:]:
        if a.isdigit():
            want = int(a)
    raw = gzip.decompress(open(BUNDLE, "rb").read())
    env = UnityPy.load(raw)

    gonames = {}
    for obj in env.objects:
        if obj.type.name == "GameObject":
            try:
                gonames[obj.path_id] = obj.read().m_Name
            except Exception:
                pass

    hits = []
    for obj in env.objects:
        if obj.type.name != "Tilemap":
            continue
        try:
            tm = obj.read()
            if not tm.m_Tiles:
                continue
            coords = tiles_of(tm)
        except Exception:
            continue
        go = getattr(tm, "m_GameObject", None)
        pid = getattr(go, "path_id", None)
        nm = gonames.get(pid, "?")
        hits.append((nm, len(coords), coords, pid))

    hits.sort(key=lambda x: -x[1])
    print("tilemaps(非空):", len(hits))
    for nm, n, coords, pid in hits:
        if n < 20:
            continue
        xs = [c[0] for c in coords]
        ys = [c[1] for c in coords]
        zs = set(c[2] for c in coords)
        print("  %-22s tiles=%-5d x %d..%d y %d..%d z=%s go=%s"
              % (nm, n, min(xs), max(xs), min(ys), max(ys), sorted(zs)[:4], pid))
        if want is not None and n == want:
            rows = collections.Counter(c[1] for c in coords)
            print("     y 行分布:", sorted(rows.items())[:40])
            print("     set(前30):", sorted(set((c[0], c[1]) for c in coords))[:30])


if __name__ == "__main__":
    main()
