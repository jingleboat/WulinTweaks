#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""解析 PC GameAssembly.dll 里某个调用点前加载的字符串字面量。

用法：
    python x64strings.py <dll> <code_rva_hex> [back=80]

思路：il2cpp 里字符串字面量在代码中通常是
    mov reg, qword ptr [rip + X]   ; X 处是 metadata usage 槽（指向 String_t）
少数情况用 lea。本脚本在调用点前 back 字节内找所有 rip 相对引用，
把引用目标按「槽里放指针」再解一次，最终按 String_t 布局读出 utf16 文本。
"""
import struct
import sys

from capstone import Cs, CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_INTEL


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


def rva_off(sections, rva):
    for nm, va, vsize, rawptr, rawsize in sections:
        if va <= rva < va + max(vsize, rawsize):
            return rawptr + (rva - va)
    return None


def read_string(data, sections, rva):
    """把 rva 当成 String_t 读；不行就把 rva 处当指针再读一次。"""
    cands = []
    for depth in (0, 1):
        cur = rva
        for _ in range(depth):
            off = rva_off(sections, cur)
            if off is None:
                cur = None
                break
            cur = struct.unpack_from("<Q", data, off)[0]
            if cur < 0x1000:
                cur = None
                break
        if cur is None:
            continue
        off = rva_off(sections, cur)
        if off is None:
            continue
        try:
            ln = struct.unpack_from("<i", data, off + 0x10)[0]
            if 0 < ln <= 200:
                s = data[off + 0x14: off + 0x14 + ln * 2].decode("utf-16-le", "replace")
                if s and all(31 < ord(c) < 0xFFFD for c in s):
                    cands.append((depth, s))
        except Exception:
            pass
    return cands


def main():
    dll = sys.argv[1]
    rva = int(sys.argv[2], 16)
    back = int(sys.argv[3]) if len(sys.argv) > 3 else 80
    data, base, sections = load_pe(dll)
    off = rva_off(sections, rva)
    md = Cs(CS_ARCH_X86, CS_MODE_64)
    md.syntax = CS_OPT_SYNTAX_INTEL
    for ins in md.disasm(data[off - back:off + 8], rva - back):
        ops = ins.op_str
        if "rip +" not in ops:
            continue
        try:
            disp = int(ops.split("rip + ")[1].split("]")[0], 16)
        except Exception:
            continue
        tgt = ins.address + ins.size + disp
        res = read_string(data, sections, tgt)
        print("%08X %-8s %-34s -> %08X %s" % (ins.address, ins.mnemonic, ops, tgt, res))


if __name__ == "__main__":
    main()
