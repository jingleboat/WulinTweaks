#!/usr/bin/env python3
"""Disassemble functions in a PE (GameAssembly.dll) by RVA, annotated with
Il2CppDumper method names (rva_map.txt).

Usage:
    python x64dis.py <dll> <name> <rva_hex> [nbytes]
    python x64dis.py <dll> --batch funcs.txt [-o out.txt]
funcs.txt lines:  name rva_hex [nbytes]
"""
import sys, struct
from capstone import Cs, CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_INTEL

SYMS = {}


def load_syms(path):
    if not path:
        return
    try:
        for line in open(path, encoding="utf-8", errors="replace"):
            parts = line.split(None, 1)
            if len(parts) == 2:
                SYMS[int(parts[0], 16)] = parts[1].strip()
    except FileNotFoundError:
        pass


def name_at(rva):
    return SYMS.get(rva)


def load_pe(path):
    data = open(path, "rb").read()
    e = struct.unpack_from("<I", data, 0x3C)[0]
    assert data[e:e + 4] == b"PE\0\0"
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


def dis(data, sections, rva, nbytes, out):
    off = rva_off(sections, rva)
    if off is None:
        out.write("  <rva 0x%X unmapped>\n" % rva)
        return
    md = Cs(CS_ARCH_X86, CS_MODE_64)
    md.syntax = CS_OPT_SYNTAX_INTEL
    md.detail = True
    code = data[off:off + nbytes]
    for ins in md.disasm(code, rva):
        note = ""
        if ins.mnemonic in ("call", "jmp", "je", "jne", "jg", "jl", "jge", "jle", "ja", "jb",
                            "jae", "jbe", "js", "jns", "jz", "jnz") and ins.op_str.startswith("0x"):
            t = int(ins.op_str, 16)
            n = name_at(t)
            if n:
                note = "   ; -> %s" % n
        elif ins.mnemonic == "lea" and "rip +" in ins.op_str:
            # compute rip-relative target
            try:
                disp = int(ins.op_str.split("rip + ")[1].split("]")[0], 16)
                t = ins.address + ins.size + disp
                n = name_at(t)
                if n:
                    note = "   ; = %s (0x%X)" % (n, t)
            except Exception:
                pass
        out.write("  %08X  %-20s %-6s %s%s\n" % (ins.address, ins.bytes.hex(), ins.mnemonic, ins.op_str, note))


def main():
    dll = sys.argv[1]
    load_syms(sys.argv[-1] if sys.argv[-1].endswith(".txt") and len(sys.argv) > 4 else "wulin-mod/tools/rva_map.txt")
    data, base, sections = load_pe(dll)
    if sys.argv[2] == "--batch":
        spec = sys.argv[3]
        outpath = None
        if "-o" in sys.argv:
            outpath = sys.argv[sys.argv.index("-o") + 1]
        fh = open(outpath, "w", encoding="utf-8") if outpath else sys.stdout
        for line in open(spec, encoding="utf-8"):
            line = line.strip()
            if not line or line.startswith("#"):
                continue
            p = line.split()
            nm, rva = p[0], int(p[1], 16)
            nb = int(p[2]) if len(p) > 2 else 600
            fh.write("\n===== %s  RVA 0x%X  (%d bytes) =====\n" % (nm, rva, nb))
            dis(data, sections, rva, nb, fh)
        if outpath:
            fh.close()
            print("wrote " + outpath)
    else:
        nm, rva = sys.argv[2], int(sys.argv[3], 16)
        nb = int(sys.argv[4]) if len(sys.argv) > 4 else 600
        print("===== %s RVA 0x%X =====" % (nm, rva))
        dis(data, sections, rva, nb, sys.stdout)


if __name__ == "__main__":
    main()
