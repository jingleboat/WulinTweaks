#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""用 UnityPy + 游戏自己的 interop DLL 生成 TypeTree，读 config bundle 里的 MapNpcPathData。

用法：
    python dump_npc_path.py            # 列出有点位的 mapID
    python dump_npc_path.py 504        # 打印 504 的点位（含是否水域格）
    python dump_npc_path.py 504 --water wulin-apk/native/src/water_mask.h

MapNpcPath : npcID | factionID + jobID | isAutoCreate | respawnTime | listPosData[]
PosData    : pos(Vector2Int) | dir | timeLimit(Vector2Int) | isWorkingPlace | isUnitQuarter
"""
import re
import sys

import UnityPy
from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator

BUNDLE = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\aa\StandaloneWindows64\config_assets_all.bundle"
INTEROP = r"D:\steamgame\steamapps\common\WulinSH\BepInEx\interop"


def load_water(path, mapid):
    t = open(path, encoding="utf-8").read()
    m = re.search(r"WM_%d\[\d+\] = \{(.*?)\};" % mapid, t, re.S)
    if not m:
        return None
    keys = [int(h, 16) for h in re.findall(r"0x([0-9a-fA-F]{16})LL", m.group(1))]
    return set(((k & 0xFFFFFFFF), (k >> 32)) for k in keys)


def main():
    want = int(sys.argv[1]) if len(sys.argv) > 1 and sys.argv[1].isdigit() else None
    water = None
    if "--water" in sys.argv:
        water = load_water(sys.argv[sys.argv.index("--water") + 1], want)

    gen = TypeTreeGenerator("2020.3.13f1")
    gen.load_local_dll_folder(INTEROP)
    env = UnityPy.load(BUNDLE)
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
        if not isinstance(tree, dict):
            continue
        d = tree.get("data")
        if isinstance(d, list) and d and isinstance(d[0], dict) and "first" in d[0]:
            nxt = d[0].get("second")
            if isinstance(nxt, list) and nxt and isinstance(nxt[0], dict) and "listPosData" in nxt[0]:
                found = (obj.path_id, tree)
                break
    if not found:
        print("没找到 MapNpcPathData（typetree 里没有 listPosData 字段的资产）")
        return
    pid, tree = found
    data = tree["data"]
    maps = sorted(p["first"] for p in data)
    print("MapNpcPathData path_id=%s，图数=%d" % (pid, len(maps)))
    if want is None:
        print("mapID:", maps[:80])
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
                w = ""
                if water is not None:
                    w = "  <== 水域格" if (x, y) in water else ""
                print("      (%s,%s) dir=%s time=(%s..%s) work=%s unit=%s%s"
                      % (x, y, pd.get("dir"), tl.get("x"), tl.get("y"),
                         pd.get("isWorkingPlace"), pd.get("isUnitQuarter"), w))


if __name__ == "__main__":
    main()
