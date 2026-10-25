#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""在 PC 版 ModEditor.zip 的剧情资产里找「水/泳/浴」相关节点，并按图聚合。

用途：确认哪些剧情图里出现了入水相关节点（例如 10075 的个人事件），
以及这些节点实际用的是哪个脚本类（m_Script guid+fileID）。

用法：
    python find_water_nodes.py            # 列所有含 水/泳/浴 的节点标签
    python find_water_nodes.py 10075      # 只看图名含 10075 的
"""
import sys
import zipfile
import re

ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"
NAME_RE = re.compile(r'm_Name: "(.*?)"')
SCRIPT_RE = re.compile(r"m_Script: \{fileID: (-?\d+), guid: ([0-9a-f]+)")
GRAPH_RE = re.compile(r"^--- !u!114 &(-?\d+)", re.M)


def unesc(s):
    try:
        return s.encode("latin1").decode("unicode_escape")
    except Exception:
        return s


def main():
    filt = sys.argv[1] if len(sys.argv) > 1 else None
    z = zipfile.ZipFile(ZIP)
    hits = {}
    for n in z.namelist():
        if not (n.startswith("Assets/GameRes/Scenario/") and n.endswith(".asset")):
            continue
        if filt and filt not in n:
            continue
        raw = z.read(n).decode("utf-8", "replace")
        # 一个 .asset 里可能有多个节点文档，逐文档处理
        parts = re.split(r"^--- !u!114 &(-?\d+).*$", raw, flags=re.M)
        for i in range(1, len(parts), 2):
            body = parts[i + 1]
            m = NAME_RE.search(body)
            if not m:
                continue
            nm = unesc(m.group(1))
            if not any(k in nm for k in ("水", "泳", "浴")):
                continue
            sc = SCRIPT_RE.search(body)
            key = (nm, sc.group(1) + "/" + sc.group(2) if sc else "?")
            hits.setdefault(key, []).append(n)
    for (nm, sc), files in sorted(hits.items()):
        print("%-24s %-22s %3d  %s" % (nm, sc, len(files), ", ".join(sorted(set(files))[:5])))


if __name__ == "__main__":
    main()
