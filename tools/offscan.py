#!/usr/bin/env python3
"""Scan a PE image for [reg+disp32] accesses to a given struct offset and
report the containing functions (nearest Il2CppDumper symbol)."""
import sys, struct, bisect

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
    disp = int(sys.argv[2], 16)          # e.g. 0x150
    syms = {}
    for line in open(sys.argv[3], encoding="utf-8", errors="replace"):
        p = line.split(None, 1)
        if len(p) == 2:
            syms[int(p[0], 16)] = p[1].strip()
    keys = sorted(syms)
    data, base, sections = load_pe(dll)

    def off_to_rva(off):
        for nm, va, vsize, rawptr, rawsize in sections:
            if rawptr <= off < rawptr + rawsize:
                return va + (off - rawptr)
        return None

    needle = struct.pack("<I", disp)
    hits = []
    for i in range(len(data) - 7):
        if data[i + 3:i + 7] != needle:
            continue
        b0, b1, modrm = data[i], data[i + 1], data[i + 2]
        # REX.W + 89/8B (mov), mod=10 (disp32), rm != 100 (SIB) and rm != 101 (rip-rel)
        if b0 not in (0x48, 0x49, 0x4C, 0x4D):
            continue
        if b1 not in (0x89, 0x8B, 0x3B, 0x39):
            continue
        if (modrm & 0xC0) != 0x80:
            continue
        if (modrm & 0x07) in (4, 5):
            continue
        rva = off_to_rva(i)
        if rva is None:
            continue
        hits.append((rva, b1, modrm))

    print("offset 0x%X : %d hits" % (disp, len(hits)))
    seen = set()
    for rva, op, modrm in hits:
        i = bisect.bisect_right(keys, rva) - 1
        owner = syms.get(keys[i], "?") if i >= 0 and keys[i] <= rva else "?"
        kind = "STORE" if op == 0x89 else ("LOAD" if op == 0x8B else "CMP")
        key = (owner, kind)
        if key in seen:
            continue
        seen.add(key)
        print("  0x%08X  %-6s  %s" % (rva, kind, owner))

if __name__ == "__main__":
    main()
