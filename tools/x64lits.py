#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""把某函数里所有 rip 相对引用（lea/mov）指向的地址解析成字符串，用于反推字面量。

用法：
    python x64lits.py <dll> <rva_hex> <nbytes>

说明：il2cpp 里的字符串字面量是 String_t：0x00 klass / 0x08 monitor / 0x10 length / 0x14 utf16 字符。
本脚本对每个引用点同时尝试：① 当 String_t 读 utf16（+0x14）；② 当 C 字符串读；③ 当 char* 数组读。
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


def try_string(data, sections, rva):
    off = rva_off(sections, rva)
    if off is None:
        return None
    out = []
    # String_t
    try:
        ln = struct.unpack_from("<i", data, off + 0x10)[0]
        if 0 < ln < 200:
            s = data[off + 0x14: off + 0x14 + ln * 2].decode("utf-16-le", "replace")
            if s.isprintable():
                out.append("String_t(%d)=%r" % (ln, s))
    except Exception:
        pass
    # C string
    try:
        raw = data[off: off + 120].split(b"\0")[0]
        if raw and all(32 <= b < 127 or b >= 0x80 for b in raw):
            out.append("Cstr=%r" % raw.decode("utf-8", "replace"))
    except Exception:
        pass
    return out


def main():
    dll = sys.argv[1]
    rva = int(sys.argv[2], 16)
    nb = int(sys.argv[3]) if len(sys.argv) > 3 else 1200
    data, base, sections = load_pe(dll)
    off = rva_off(sections, rva)
    md = Cs(CS_ARCH_X86, CS_MODE_64)
    md.syntax = CS_OPT_SYNTAX_INTEL
    for ins in md.disasm(data[off:off + nb], rva):
        ops = ins.op_str
        if "rip +" in ops:
            try:
                disp = int(ops.split("rip + ")[1].split("]")[0], 16)
            except Exception:
                continue
            tgt = ins.address + ins.size + disp
            res = try_string(data, sections, tgt)
            print("%08X %-8s %-40s -> %08X %s" % (ins.address, ins.mnemonic, ops, tgt, res if res else ""))


if __name__ == "__main__":
    main()
