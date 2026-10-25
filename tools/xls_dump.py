#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""读 ModEditor.zip 里的 xlsx 数据表（PC 版）。用法：
    python xls_dump.py 角色池.xlsx                 # 列头 + 前 10 行
    python xls_dump.py 角色池.xlsx 10075           # 只打 ID 含 10075 的行
"""
import io
import sys
import zipfile

from openpyxl import load_workbook

ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"


def main():
    name = sys.argv[1]
    needle = sys.argv[2] if len(sys.argv) > 2 else None
    z = zipfile.ZipFile(ZIP)
    cands = [n for n in z.namelist() if n.endswith("/" + name)]
    if not cands:
        print("not found:", name)
        return
    wb = load_workbook(io.BytesIO(z.read(cands[0])), data_only=True, read_only=True)
    for ws in wb.worksheets:
        print("=== sheet:", ws.title, ws.max_row, "x", ws.max_column)
        rows = list(ws.iter_rows(values_only=True))
        if not rows:
            continue
        # 找表头行：前 5 行里取列数最多的一行
        hi = max(range(min(5, len(rows))), key=lambda i: sum(1 for c in rows[i] if c not in (None, "")))
        header = ["" if c is None else str(c) for c in rows[hi]]
        print("HEADER:", " | ".join(header))
        shown = 0
        for r in rows[hi + 1:]:
            if all(c in (None, "") for c in r):
                continue
            if needle:
                if not any(needle in str(c) for c in r if c is not None):
                    continue
            if not needle and shown >= 8:
                continue
            vals = ["-" if c is None else str(c) for c in r]
            print("  ", " | ".join(vals[:60]))
            shown += 1
            if shown >= 60:
                break


if __name__ == "__main__":
    main()
