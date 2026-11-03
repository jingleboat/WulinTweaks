#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""把剧情图里节点的**编辑器默认名**（中文）映射到 **运行时类名**，并给出证据。

为什么需要：审计「哪些节点按具体人物 id 操作」时手里有两套资料 ——
  ① 剧情资产（ModEditor.zip）：节点实例的中文默认名 + 它被序列化出来的字段名；
  ② IL2CPP dump（dump.cs）：每个类的公开字段。
中文名不带类型信息，只能靠**字段集合签名**去和类对上。为了区分
（`mode`/`Index`/`partnerID` 这种到处都有的字段区分力弱），打分用 IDF 加权：
某个字段被越少的类声明，命中它加分越多。

用法：
    python map_node_names.py                    # 全部节点名
    python map_node_names.py 伙伴邀请           # 只匹配名字含该串的
    python map_node_names.py --detail 伙伴邀请   # 打印命中字段明细
"""
import collections
import math
import os
import re
import sys
import zipfile

HERE = os.path.dirname(os.path.abspath(__file__))
APK = os.path.normpath(os.path.join(HERE, "..", "..", "wulin-apk"))
DUMP = os.path.join(APK, "dumpout-intl", "dump.cs")

ZIP = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\ModEditor\ModEditor.zip"
STORY_PREFIX = "Assets/GameRes/Story/"

COMMON = {
    "m_ObjectHideFlags", "m_CorrespondingSourceObject", "m_PrefabInstance", "m_PrefabAsset",
    "m_GameObject", "m_Enabled", "m_EditorHideFlags", "m_Script", "m_Name",
    "m_EditorClassIdentifier", "graph", "position", "ports", "keys", "values",
    "node", "name",
}


def decode_name(s):
    if s is None:
        return None
    s = s.strip()
    for q in ("'", '"'):
        if len(s) >= 2 and s[0] == q and s[-1] == q:
            s = s[1:-1]
            break
    if "\\u" in s:
        try:
            s = s.encode("latin1", "backslashreplace").decode("unicode_escape")
        except Exception:
            pass
    return s or None


def split_docs(raw):
    parts = re.split(r"^--- !u!(\d+) &(-?\d+).*$", raw, flags=re.M)
    docs = {}
    for i in range(1, len(parts), 3):
        docs[int(parts[i + 1])] = parts[i + 2]
    return docs


def field_names(body):
    out = set()
    for m in re.finditer(r"^\s{2}(\w+):", body, re.M):
        k = m.group(1)
        if k not in COMMON:
            out.add(k)
    return out


def name_of(body):
    m = re.search(r'^\s{2}m_Name:\s*(.*)$', body, re.M)
    return decode_name(m.group(1)) if m else None


def class_fields():
    """dump.cs 里每个类的**全部**字段（含 private/protected —— 序列化不看可访问性，
    而 private 字段恰恰是区分力最强的，例如 ChangePartnerNode.partnerName）。"""
    src = open(DUMP, encoding="utf-8", errors="replace").read()
    best = {}
    for m in re.finditer(r'^(?:public|internal)\s+(?:sealed\s+|abstract\s+)?class\s+(\w+)\s*:\s*([\w\.]+)'
                         r'[^\n]*\n\s*\{', src, re.M):
        name, base = m.group(1), m.group(2)
        tail = src[m.end(): m.end() + 30000]
        cut = tail.find("\n\t// Methods")
        if cut < 0:
            cut = tail.find("\n}")
        body = tail[:cut if cut > 0 else 4000]
        f = {x for x in re.findall(r'^\s*(?:public|private|protected|internal)\s+[\w\.<>\[\], ]+\s+(\w+);',
                                   body, re.M) if x != "value__"}
        if name not in best or len(f) > len(best[name][0]):
            best[name] = (f, base)
    return best


def main():
    argv = [a for a in sys.argv[1:] if not a.startswith("--")]
    detail = "--detail" in sys.argv
    filt = argv[0] if argv else None

    if not os.path.exists(ZIP):
        sys.exit("找不到 ModEditor.zip")

    classes = class_fields()
    node_classes = {k: v[0] for k, v in classes.items()
                    if v[1].endswith(("BaseNode", "Node")) or "Node" in k}

    # IDF：字段被越少类声明，区分力越强
    df = collections.Counter()
    for cf in node_classes.values():
        for f in cf:
            df[f] += 1
    N = max(1, len(node_classes))
    idf = {f: math.log(1.0 + N / (1.0 + c)) for f, c in df.items()}

    z = zipfile.ZipFile(ZIP)
    entries = [n for n in z.namelist()
               if n.startswith(STORY_PREFIX) and n.endswith(".asset") and n.count("/") == 3]

    sig = collections.defaultdict(lambda: {"fields": set(), "n": 0})
    for e in entries:
        raw = z.read(e).decode("utf-8", errors="replace")
        for fid, body in split_docs(raw).items():
            nm = name_of(body)
            if not nm or "m_Script" not in body:
                continue
            fs = field_names(body)
            if not fs:
                continue
            sig[nm]["fields"] |= fs
            sig[nm]["n"] += 1

    print("节点默认名 %d 个（来自 %d 张剧情图的节点实例），候选节点类 %d 个\n"
          % (len(sig), len(entries), len(node_classes)))

    rows = []
    for nm in sorted(sig):
        if filt and filt not in nm:
            continue
        fs = sig[nm]["fields"]
        scored = []
        for cls, cf in node_classes.items():
            inter = fs & cf
            if not inter:
                continue
            # 序列化字段里除了私有成员，还可能有 Unity 端口引用的临时键，
            # 所以先按「命中数」排，命中数相同再按 IDF 分与缺失字段数排。
            score = sum(idf.get(f, 0.0) for f in inter)
            missing = len(fs - cf)
            scored.append((len(inter), -missing, score, cls, inter, fs - cf))
        scored.sort(key=lambda x: (-x[0], -x[1], -x[2], x[3]))
        if not scored:
            rows.append((nm, "（无候选）", 0, 0, 0, "", sig[nm]["n"]))
            continue
        top = scored[0]
        second = scored[1] if len(scored) > 1 else None
        gap = (top[0] - second[0]) if second else 99
        mark = "✓" if (second is None or gap >= 1) else "?"
        rows.append((nm, top[3], top[0], len(fs), top[2],
                     mark + ("  次优=%s(%d)" % (second[3], second[0]) if (second and mark == "?") else ""),
                     sig[nm]["n"]))
        if detail:
            print("【%s】→ %s   命中 %d/%d 字段" % (nm, top[3], top[0], len(fs)))
            print("     命中字段  : %s" % ", ".join(sorted(top[4])))
            print("     该类型多出: %s" % (", ".join(sorted(top[5])) or "无"))
            if second:
                print("     次优      : %s 命中 %d  %s"
                      % (second[3], second[0], ", ".join(sorted(second[4]))))
            print()

    print("%-24s %-28s %-7s %-6s %s" % ("默认名", "类名", "命中/总", "唯一?", "备注"))
    print("-" * 104)
    for nm, cls, hit, tot, sc, note, n in rows:
        print("%-24s %-28s %-7s %-6s %s" % (nm, cls, "%d/%d" % (hit, tot), note[:5], note[5:].strip()))


if __name__ == "__main__":
    main()
