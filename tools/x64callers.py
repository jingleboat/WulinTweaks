#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""找一个函数在 GameAssembly.dll 里的调用点（x64 直接 call rel32）。

用法：
    python x64callers.py <dll> <target_rva_hex> [symtab]

输出：每个调用点地址 + 最近的已知符号（rva_map.txt 里 <= 该地址的最近一个符号）。
局限：只认 `E8 rel32` 直接调用；虚调用/间接调用看不到；数据区可能误报，
      所以只把「落在已知函数体内且距函数头不远」的结果当线索用。
"""
import struct
import sys


def load_syms(path):
    syms = {}
    try:
        for line in open(path, encoding="utf-8", errors="replace"):
            p = line.split(None, 1)
            if len(p) == 2:
                try:
                    syms[int(p[0], 16)] = p[1].strip()
                except ValueError:
                    pass
    except FileNotFoundError:
        pass
    return syms


def load_pe(path):
    data = open(path, "rb").read()
    e = struct.unpack_from("<I", data, 0x3C)[0]
    coff = e + 4
    nsec = struct.unpack_from("<H", data, coff + 2)[0]
    opt_size = struct.unpack_from("<H", data, coff + 16)[0]
    opt = coff + 20
    magic = struct.unpack_from("<H", data, opt)[0]
    base = struct.unpack_from("<Q", data, opt + 24)[0] if magic == 0x20B else struct.unpack_from("<I", data, opt + 28)[0]
    sec = opt + opt_size
    sections = []
    for i in range(nsec):
        o = sec + i * 40
        nm = data[o:o + 8].rstrip(b"\0").decode("latin1")
        vsize, va, rawsize, rawptr = struct.unpack_from("<IIII", data, o + 8)
        sections.append((nm, va, vsize, rawptr, rawsize))
    return data, base, sections


def main():
    dll = sys.argv[1]
    target = int(sys.argv[2], 16)
    symtab = sys.argv[3] if len(sys.argv) > 3 else "wulin-mod/tools/rva_map.txt"
    syms = load_syms(symtab)
    keys = sorted(syms)
    data, base, sections = load_pe(dll)

    import bisect

    def owner(addr):
        i = bisect.bisect_right(keys, addr) - 1
        if i < 0:
            return None, 0
        return syms[keys[i]], addr - keys[i]

    found = []
    for nm, va, vsize, rawptr, rawsize in sections:
        if nm not in (".text", "il2cpp"):
            continue
        blob = data[rawptr:rawptr + rawsize]
        for i in range(len(blob) - 5):
            if blob[i] != 0xE8:
                continue
            rel = struct.unpack_from("<i", blob, i + 1)[0]
            src = va + i
            if src + 5 + rel == target:
                found.append(src)
    print("target 0x%X  callers %d" % (target, len(found)))
    for a in sorted(found):
        nm, off = owner(a)
        print("  0x%08X  %s +0x%X" % (a, nm, off))


if __name__ == "__main__":
    main()
