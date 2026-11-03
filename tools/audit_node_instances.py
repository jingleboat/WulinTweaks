#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""审计「剧情节点 → 具体人物实例」的取用方式。

要回答的问题只有一个：
  原版「需要伙伴」条件保证该角色在队，而在队必然有活实例。
  mod 放宽 / 展平之后，剧情会在「人不在队、甚至没有实例」时也播 ——
  此时节点自己怎么取实例，决定 mod 带来的差异是「静默 no-op」还是「补建实例」还是「取错人」。

节点的动作实现统一形如（mode 字段 = SelectionMode: ID=0 / 队中位置=1）：
    w8 = self->mode;  cbz w8, <ID 分支>
    ...GetTeamMemberByIndex(Index)...   b <汇合>
  <ID 分支>:
    pid = self->partnerID/npcID;  if (pid < 1) return;
    GetCharacter(pid)  /  GetOrCreateCharacter(pid, isPernament)

所以判定「按 id 那条路」用的是哪个 API，就是找函数里第一个 cbz 的跳转目标，
在该目标之后找人物 API 调用。

用法（全部离线，不跑游戏）：
    python audit_node_instances.py                # 汇总表
    python audit_node_instances.py --cls ChangeKungfuNode
    python audit_node_instances.py --json out.json
"""
import argparse
import json
import os
import pickle
import re
import sys

import capstone

HERE = os.path.dirname(os.path.abspath(__file__))
APK = os.path.normpath(os.path.join(HERE, "..", "..", "wulin-apk"))
DUMP = os.path.join(APK, "dumpout-intl", "dump.cs")
SO = os.path.join(APK, "libil2cpp_intl.so")
CACHE = os.path.join(HERE, "_rva2name.pkl")

RVA_BASE = 0x4000

INSTANCE_API = (
    "GetCharacterByTempleteId", "GetOrCreateCharacter", "CreateCharacter",
    "GetOrCreateNpcs", "CreateUnUniqueNpcs",
    "GetTeamMemberByIndex", "GetTeamMemberByUid", "GetCharacter",
)

PID_FIELD = re.compile(r'\b(partnerID|npcID|NpcID|npcId|characterID|CharacterID|charID|uid)\b')

_SRC = ""


def load_rva2name():
    if os.path.exists(CACHE):
        return pickle.load(open(CACHE, "rb"))
    src = open(DUMP, encoding="utf-8", errors="replace").read()
    m = {}
    for x in re.finditer(r'// RVA: (0x[0-9A-Fa-f]+) Offset: 0x[0-9A-Fa-f]+[^\n]*\n\s*([^\n]*\S)', src):
        m[int(x.group(1), 16)] = x.group(2).strip()
    pickle.dump(m, open(CACHE, "wb"))
    return m


def class_fields(name):
    """dump.cs 类体形如 { // Fields ... // Methods ... }；同名类可能多份，取字段最多的。"""
    best = []
    for m in re.finditer(r'^(?:public|internal)\s+(?:sealed\s+|abstract\s+)?class\s+'
                         + re.escape(name) + r'\b[^\n]*\n\s*\{', _SRC, re.M):
        tail = _SRC[m.end(): m.end() + 30000]
        cut = tail.find("\n\t// Methods")
        if cut < 0:
            cut = tail.find("\n}")
        body = tail[:cut if cut > 0 else 4000]
        f = [x for x in re.findall(r'^\s*public\s+[\w\.<>\[\], ]+\s+(\w+);', body, re.M)
             if x != "value__"]
        if len(f) > len(best):
            best = f
    return best


def dis(rva, end, data):
    code = data[rva - RVA_BASE: end - RVA_BASE]
    md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_ARM)
    return list(md.disasm(code, rva))


def perm_at(ins, addr):
    """GetOrCreateCharacter 第 2 实参 isPernament 在 w2；往前找最近一次给 w2 赋值。"""
    for x in reversed(ins):
        if x.address >= addr:
            continue
        if x.mnemonic == "mov" and x.op_str.startswith("w2, "):
            v = x.op_str.split(",", 1)[1].strip()
            if v in ("wzr", "#0", "#0x0"):
                return "False"
            return "True"
        if x.mnemonic in ("ldr", "ldrb") and x.op_str.startswith("w2, "):
            return "内存值"
        if addr - x.address > 0xA0:
            break
    return "?"


def id_branch(ins, rva2name):
    """第一个 cbz/cbnz 向后跳过的目标 = mode==ID 分支；返回该段内的人物 API 调用。"""
    for i, x in enumerate(ins):
        if x.mnemonic not in ("cbz", "cbnz") or not x.op_str.startswith("w"):
            continue
        try:
            tgt = int(x.op_str.split("#")[1], 16)
        except (IndexError, ValueError):
            continue
        if tgt <= x.address:
            continue
        out = []
        for y in ins[i + 1:]:
            if y.address < tgt:
                continue
            if y.address > tgt + 0x180:
                break
            if y.mnemonic == "ret":
                break
            if y.mnemonic == "bl" and y.op_str.startswith("#"):
                name = rva2name.get(int(y.op_str[1:], 16), "")
                for api in INSTANCE_API:
                    if re.search(r'\b' + api + r'\s*\(', name):
                        perm = perm_at(ins, y.address) if api == "GetOrCreateCharacter" else "-"
                        out.append((api, perm))
                        break
        if out:
            return out
    return []


def main():
    global _SRC
    ap = argparse.ArgumentParser()
    ap.add_argument("--dump", default=DUMP)
    ap.add_argument("--so", default=SO)
    ap.add_argument("--cls")
    ap.add_argument("--json")
    args = ap.parse_args()

    for p in (args.dump, args.so):
        if not os.path.exists(p):
            sys.exit("缺少 %s" % p)

    _SRC = open(args.dump, encoding="utf-8", errors="replace").read()
    rva2name = load_rva2name()
    all_rvas = sorted(rva2name)
    data = open(args.so, "rb").read()

    acts = {}
    for rva, nm in rva2name.items():
        m = re.search(r'\b(\w+?)OnResultAction\s*\(', nm)
        if m:
            acts[m.group(1)] = rva

    rows = []
    for cls, rva in sorted(acts.items()):
        if args.cls and cls != args.cls:
            continue
        fields = class_fields(cls)
        pid_fields = [f for f in fields if PID_FIELD.search(f)]

        nxt = min([r for r in all_rvas if r > rva] or [rva + 0x400])
        if nxt - rva > 0x2000:
            nxt = rva + 0x800
        ins = dis(rva, nxt, data)

        picks = []
        for x in ins:
            if x.mnemonic != "bl" or not x.op_str.startswith("#"):
                continue
            tgt = rva2name.get(int(x.op_str[1:], 16), "")
            for api in INSTANCE_API:
                if re.search(r'\b' + api + r'\s*\(', tgt):
                    perm = perm_at(ins, x.address) if api == "GetOrCreateCharacter" else "-"
                    picks.append((api, perm))
                    break

        rows.append({"class": cls, "rva": "0x%X" % rva,
                     "pid_fields": pid_fields,
                     "all_picks": picks,
                     "id_branch": id_branch(ins, rva2name),
                     "size": nxt - rva})

    def kind(r):
        if not r["all_picks"]:
            return "A 不碰具体人物（动作里拿不到人物实例）"
        idapis = {a for a, _ in r["id_branch"]}
        if "GetCharacter" in idapis:
            return "B ★按 id 取、不建 → 实例缺失就静默 no-op"
        if "GetCharacterByTempleteId" in idapis:
            return "B' ★按模板 id 取集合、不建 → 缺失即静默 no-op"
        if "GetOrCreateCharacter" in idapis:
            perms = {p for a, p in r["id_branch"] if a == "GetOrCreateCharacter"}
            if perms <= {"True", "1"}:
                return "C 按 id 取或建(永久) → 与原版等价"
            return "C' 按 id 取或建(perm=%s) → 可能临时实例" % ",".join(sorted(perms))
        if idapis & {"CreateCharacter", "GetOrCreateNpcs", "CreateUnUniqueNpcs"}:
            return "C 按 id 直接创建"
        if idapis & {"GetTeamMemberByIndex", "GetTeamMemberByUid"}:
            return "D ★按队位取 → 人不在队时越界/取错人"
        return "E 未判定 ID 分支"

    for r in rows:
        r["kind"] = kind(r)

    groups = {}
    for r in rows:
        groups.setdefault(r["kind"], []).append(r)

    print("剧情节点动作实现（*OnResultAction）：%d 个\n" % len(rows))
    for k in sorted(groups):
        lst = groups[k]
        print("=" * 100)
        print("【%s】  %d 个" % (k, len(lst)))
        for r in lst:
            pf = ",".join(sorted(set(r["pid_fields"]))) or "—"
            idb = " + ".join("%s%s" % (a, "(perm=%s)" % p if a == "GetOrCreateCharacter" else "")
                             for a, p in r["id_branch"]) or "—"
            allp = " + ".join(sorted({a for a, _ in r["all_picks"]})) or "—"
            print("  %-28s id字段=%-18s ID分支=%-40s 全量=[%s]" % (r["class"], pf, idb, allp))
        print()

    if args.json:
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump(rows, f, ensure_ascii=False, indent=2)
        print("已写入 %s" % args.json)


if __name__ == "__main__":
    main()
