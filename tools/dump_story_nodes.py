#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""打印 ModEditor.zip 里某张剧情图（或某个 NPC 的全部图）的节点清单。

节点资产：Assets/GameRes/Scenario/<图名>_<序号>.asset，每个文档一个 XNode 节点，
m_Name 是节点自定义名（默认等于节点类型的中文名），m_Script 的 guid+fileID 标识类。

用法：
    python dump_story_nodes.py R10075-0          # 打印这张图的全部节点
    python dump_story_nodes.py 10075             # 打印图名含 10075 的所有图的节点名
"""
import collections
import re
import sys
import zipfile

ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"
NAME_RE = re.compile(r'm_Name: "(.*?)"')
SCRIPT_RE = re.compile(r"m_Script: \{fileID: (-?\d+), guid: ([0-9a-f]+)")
# 常用字段（XNode 序列化在顶层 2 空格缩进）
FIELDS = ("partnerID", "partnerName", "Negate", "mapID", "storyName", "text", "dialogContent",
          "npcID", "targetPos", "pos", "movePoint", "durationSecond", "command", "buffID")


def unesc(s):
    try:
        return s.encode("latin1").decode("unicode_escape")
    except Exception:
        return s


def docs(raw):
    parts = re.split(r"^--- !u!114 &(-?\d+).*$", raw, flags=re.M)
    out = []
    for i in range(1, len(parts), 2):
        out.append((int(parts[i]), parts[i + 1]))
    return out


def main():
    filt = sys.argv[1]
    z = zipfile.ZipFile(ZIP)
    files = sorted(n for n in z.namelist()
                   if n.startswith("Assets/GameRes/Scenario/") and n.endswith(".asset") and filt in n)
    print("files:", len(files))
    per_graph = collections.OrderedDict()
    for n in files:
        raw = z.read(n).decode("utf-8", "replace")
        for fid, body in docs(raw):
            m = NAME_RE.search(body)
            if not m:
                continue
            nm = unesc(m.group(1))
            sc = SCRIPT_RE.search(body)
            key = sc.group(1) + "/" + sc.group(2) if sc else "?"
            extra = []
            for f in FIELDS:
                mm = re.search(r"^  " + f + r":(.*)$", body, flags=re.M)
                if mm:
                    v = mm.group(1).strip()
                    if v and v not in ("0", "[]", '""'):
                        extra.append(f + "=" + v[:40])
            per_graph.setdefault(n.rsplit("/", 1)[-1], []).append((fid, nm, key, extra))
    for fn, nodes in per_graph.items():
        print("\n===== " + fn + "  (%d nodes)" % len(nodes))
        for fid, nm, key, extra in nodes:
            print("  %-22s %-20s %s" % (nm, key, " ".join(extra)))


if __name__ == "__main__":
    main()
