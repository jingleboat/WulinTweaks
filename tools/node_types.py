#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""列出 ModEditor.zip 剧情节点「类型」（m_Script guid+fileID）及其序列化字段。

用途：不依赖 class 名也能认出节点类型 —— 每种类型的字段集合是稳定的，
配合 m_Name（编辑器里的默认名就是节点中文名）就能对上号。

用法：
    python node_types.py            # 所有类型
    python node_types.py 水         # 只看节点名含「水」的类型
"""
import collections
import re
import sys
import zipfile

ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"
NAME_RE = re.compile(r'm_Name: "(.*?)"')
SCRIPT_RE = re.compile(r"m_Script: \{fileID: (-?\d+), guid: ([0-9a-f]+)")
SKIP = {"m_ObjectHideFlags", "m_CorrespondingSourceObject", "m_PrefabInstance", "m_PrefabAsset",
        "m_GameObject", "m_Enabled", "m_EditorHideFlags", "m_Script", "m_Name",
        "m_EditorClassIdentifier", "graph", "position", "ports", "keys", "values"}


def unesc(s):
    try:
        return s.encode("latin1").decode("unicode_escape")
    except Exception:
        return s


def main():
    filt = sys.argv[1] if len(sys.argv) > 1 else None
    z = zipfile.ZipFile(ZIP)
    types = collections.defaultdict(lambda: {"names": collections.Counter(), "fields": set(), "n": 0})
    for n in z.namelist():
        if not (n.startswith("Assets/GameRes/Scenario/") and n.endswith(".asset")):
            continue
        raw = z.read(n).decode("utf-8", "replace")
        parts = re.split(r"^--- !u!114 &(-?\d+).*$", raw, flags=re.M)
        for i in range(1, len(parts), 2):
            body = parts[i + 1]
            sc = SCRIPT_RE.search(body)
            if not sc:
                continue
            key = sc.group(1) + "/" + sc.group(2)[:8]
            t = types[key]
            t["n"] += 1
            m = NAME_RE.search(body)
            if m:
                t["names"][unesc(m.group(1))] += 1
            for fm in re.finditer(r"^  ([A-Za-z_][A-Za-z0-9_]*):", body, flags=re.M):
                if fm.group(1) not in SKIP:
                    t["fields"].add(fm.group(1))
    for key, t in sorted(types.items(), key=lambda kv: -kv[1]["n"]):
        nm = t["names"].most_common(1)[0][0] if t["names"] else "?"
        if filt and filt not in nm:
            continue
        print("%-26s n=%-6d %-22s %s" % (key, t["n"], nm, ",".join(sorted(t["fields"]))))


if __name__ == "__main__":
    main()
