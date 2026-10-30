#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""复核「结缘图」名单：扫 PC 版全部剧情图，找出含指定节点类型的图。

背景（README「放宽的范围：结缘图跳过」）：
  TeamRule.IsBondGraph() 运行时靠 `il2cpp_class_get_name` 读节点类名，
  命中 `ShowUIBondsNode` 即判为结缘图 → 不放宽（那类图收尾会写人物数据）。
  扫不了时退回写死的 12 张图名表 (_knownBond)。
  本脚本就是那份表 / 那个类名的离线复核依据。

数据源：<游戏>\\Wulin_Data\\StreamingAssets\\ModEditor\\ModEditor.zip
       里的 Assets/GameRes/Story/<图名>.asset（Unity YAML，每文档一个 XNode 节点）

判定方式：剧情节点在 asset 里是 MonoBehaviour，`m_Script` 的 guid 指向
  ModShare.Runtime.dll（8ca77eba…），`m_Name` 是编辑器里的默认节点名。
  「结缘界面」这个默认名 → 运行时类 ShowUIBondsNode，字段 = SaveID / IsSaveNode / partnerID。

用法：
    python tools/find_bond_graphs.py                 # 默认查「结缘界面」
    python tools/find_bond_graphs.py 激活NPC情缘      # 查别的节点类型
    python tools/find_bond_graphs.py --all           # 各类型命中图数排行
"""
import argparse
import collections
import re
import sys
import zipfile

DEFAULT_ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"
PREFIX = "Assets/GameRes/Story/"
NAME_RE = re.compile(r'm_Name: "(.*?)"')
SCRIPT_RE = re.compile(r"m_Script: \{fileID: (-?\d+), guid: ([0-9a-f]+)")
PARTNER_RE = re.compile(r"^  partnerID:(.*)$", re.M)

# 与 TeamRule._knownBond 保持一致（扫描失败时的兜底名单）
KNOWN_BOND = ["R10008-5", "R10009-6", "R10039-9", "R10052-3", "R10056-4", "R10064-6",
              "R10081-3", "R10084-5", "R10092-4", "R10108-3", "R20025-11", "R20063-2"]


def unesc(s):
    try:
        return s.encode("latin1").decode("unicode_escape")
    except Exception:
        return s


def iter_graphs(z):
    """yield (图名, [(节点名, partnerID 或 None), ...])"""
    files = sorted(n for n in z.namelist() if n.startswith(PREFIX) and n.endswith(".asset"))
    for n in files:
        gname = n[len(PREFIX):-len(".asset")]
        raw = z.read(n).decode("utf-8", "replace")
        parts = re.split(r"^--- !u!\d+ &(-?\d+).*$", raw, flags=re.M)
        nodes = []
        for i in range(1, len(parts), 2):
            body = parts[i + 1]
            m = NAME_RE.search(body)
            if not m:
                continue
            pid = None
            if SCRIPT_RE.search(body):
                pm = PARTNER_RE.search(body)
                if pm:
                    pid = pm.group(1).strip()
            nodes.append((unesc(m.group(1)), pid))
        yield gname, nodes


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("node", nargs="?", default="结缘界面", help="节点默认名（默认「结缘界面」）")
    ap.add_argument("--zip", default=DEFAULT_ZIP)
    ap.add_argument("--all", action="store_true", help="各节点类型的命中图数排行")
    args = ap.parse_args()

    z = zipfile.ZipFile(args.zip)
    if args.all:
        cnt = collections.Counter()
        for _, nodes in iter_graphs(z):
            for nm in set(x[0] for x in nodes):
                cnt[nm] += 1
        for nm, c in cnt.most_common():
            print("%-24s %d 张图" % (nm, c))
        return

    hits = []
    for gname, nodes in iter_graphs(z):
        for nm, pid in nodes:
            if nm == args.node:
                hits.append((gname, pid))
                break
    print("节点「%s」命中 %d 张图：" % (args.node, len(hits)))
    for g, pid in sorted(hits):
        print("  %-12s partnerID=%s" % (g, pid))

    if args.node == "结缘界面":
        got, want = set(g for g, _ in hits), set(KNOWN_BOND)
        if got == want:
            print("\n✅ 与 TeamRule._knownBond 完全一致（%d 张）" % len(want))
        else:
            print("\n⚠️ 与 _knownBond 不一致：多出 %s，缺少 %s"
                  % (sorted(got - want), sorted(want - got)))
            sys.exit(1)


if __name__ == "__main__":
    main()
