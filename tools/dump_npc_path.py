#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""在指定的 UnityFS bundle 里找 MapNpcPathData（每张图的官方 NPC 点位表），打印某张图的点位。

MapNpcPathData（SerializedScriptableObject）:
    data : Dictionary<int, List<MapNpcPath>>
MapNpcPath:
    npcID | factionID + jobID | isAutoCreate | respawnTime | listPosData[]
PosData:
    pos(Vector2Int) | dir | timeLimit(Vector2Int) | isWorkingPlace | isUnitQuarter

用法：
    python dump_npc_path.py <bundle 路径>            # 只报有没有、有哪些 mapID
    python dump_npc_path.py <bundle 路径> 504        # 打印 504 的点位
    python dump_npc_path.py <bundle 路径> 504 water_mask.h   # 顺带标出是否水域格
"""
import sys

import UnityPy
from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator

INTEROP = r"D:\steamgame\steamapps\common\WulinSH\BepInEx\interop"


def looks_like(tree):
    d = tree.get("data") if isinstance(tree, dict) else None
    if not isinstance(d, list) or not d:
        return False
    f = d[0]
    if not (isinstance(f, dict) and "first" in f and "second" in f):
        return False
    sec = f["second"]
    return isinstance(sec, list) and sec and isinstance(sec[0], dict) and "listPosData" in sec[0]


def load_water(path, mapid):
    import re
    try:
        t = open(path, encoding="utf-8").read()
    except FileNotFoundError:
        return None
    m = re.search(r"WM_%d\[\d+\] = \{(.*?)\};" % mapid, t, re.S)
    if not m:
        return None
    keys = [int(h, 16) for h in re.findall(r"0x([0-9a-fA-F]{16})LL", m.group(1))]
    return set(((k & 0xFFFFFFFF), (k >> 32)) for k in keys)


def main():
    bundle = sys.argv[1]
    want = int(sys.argv[2]) if len(sys.argv) > 2 and sys.argv[2].isdigit() else None
    water = load_water(sys.argv[3], want) if len(sys.argv) > 3 and want else None

    gen = TypeTreeGenerator("2020.3.13f1")
    gen.load_local_dll_folder(INTEROP)
    raw = open(bundle, "rb").read()
    if raw[:2] == b"\x1f\x8b":          # 本作有些 bundle 是 gzip 外套
        import gzip
        raw = gzip.decompress(raw)
    env = UnityPy.load(raw)
    env.typetree_generator = gen
    print("objects:", len(env.objects))

    found = None
    for obj in env.objects:
        if obj.type.name != "MonoBehaviour":
            continue
        try:
            tree = obj.read_typetree()
        except Exception:
            continue
        if looks_like(tree):
            found = (obj.path_id, tree)
            break

    if not found:
        print("这个 bundle 里没有 MapNpcPathData")
        return
    pid, tree = found
    data = tree["data"]
    maps = sorted(p["first"] for p in data)
    print("找到 MapNpcPathData path_id=%s，图数=%d" % (pid, len(maps)))
    print("mapID:", maps)
    if want is None:
        return

    for pair in data:
        if pair["first"] != want:
            continue
        paths = pair["second"]
        print("== map %d：%d 条 MapNpcPath" % (want, len(paths)))
        for mp in paths:
            print("  npcID=%s faction=%s job=%s auto=%s respawn=%s"
                  % (mp.get("npcID"), mp.get("factionID"), mp.get("jobID"),
                     mp.get("isAutoCreate"), mp.get("respawnTime")))
            for pd in mp.get("listPosData") or []:
                pos = pd.get("pos") or {}
                x, y = pos.get("x"), pos.get("y")
                tl = pd.get("timeLimit") or {}
                mark = ""
                if water is not None:
                    mark = "  <== 水域格" if (x, y) in water else ""
                print("      (%s,%s) dir=%s time=(%s..%s) work=%s unit=%s%s"
                      % (x, y, pd.get("dir"), tl.get("x"), tl.get("y"),
                         pd.get("isWorkingPlace"), pd.get("isUnitQuarter"), mark))


if __name__ == "__main__":
    main()
