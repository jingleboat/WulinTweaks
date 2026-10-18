#!/usr/bin/env python3
"""Build RVA -> 'Namespace.Type::Method' map from Il2CppDumper dump.cs."""
import re, sys, json

RVA_RE = re.compile(r"//\s*RVA:\s*(0x[0-9A-Fa-f]+)\s+Offset:")
TYPE_RE = re.compile(r"^(?:public|internal|private|protected|sealed|abstract|static|partial|\s)*\s*(class|struct|interface|enum)\s+([\w\.`<>]+)")
NS_RE = re.compile(r"^//\s*Namespace:\s*(.*)$")

def main(dump_path, out_path):
    ns = ""
    cur_type = "?"
    pending = None
    out = {}
    with open(dump_path, encoding="utf-8", errors="replace") as f:
        for line in f:
            s = line.strip()
            if s.startswith("// Namespace:"):
                ns = s.split(":", 1)[1].strip()
                continue
            m = TYPE_RE.match(s)
            if m and "(" not in s.split("{")[0]:
                t = m.group(2)
                cur_type = (ns + "." + t) if ns else t
                continue
            m = RVA_RE.search(s)
            if m:
                pending = int(m.group(1), 16)
                continue
            if pending is not None:
                if not s or s.startswith("//") or s.startswith("["):
                    # multi-line attributes / blanks: keep waiting a little
                    if s.startswith("//"):
                        pending = None
                    continue
                # method line: name up to '('
                name = s.split("(")[0].strip()
                name = name.split()[-1] if name.split() else name
                key = "%s::%s" % (cur_type, name)
                out.setdefault(pending, key)
                pending = None
    with open(out_path, "w", encoding="utf-8") as g:
        for rva in sorted(out):
            g.write("%X %s\n" % (rva, out[rva]))
    print("wrote %d entries -> %s" % (len(out), out_path))

if __name__ == "__main__":
    main(sys.argv[1], sys.argv[2])
