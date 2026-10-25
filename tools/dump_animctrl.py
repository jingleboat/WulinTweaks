#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""检查角色 AnimatorController 里有没有「水中/Bath」状态。

游戏里每个角色形象（= 角色池 avatarR 的数字，例如 178）对应一个 AnimatorController，
名字就是那个数字。日志实测：叶银瓶的 ctrl="178"，叶云的 ctrl="177"。
本脚本从 chara_assets_all.bundle 里把这些 controller 找出来，打印它们的 state/clip 名单，
并标出是否含 Bath 系列（BBathIdle / ZBathWalk ...）。

用法：
    python dump_animctrl.py            # 列出所有含 Bath 的 controller
    python dump_animctrl.py 177 178    # 只看这两个形象的完整 state 名单
"""
import gzip
import re
import sys

import UnityPy

BUNDLE = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\aa\StandaloneWindows64\chara_assets_all.bundle"


def main():
    wants = [a for a in sys.argv[1:] if a.isdigit()]
    raw = open(BUNDLE, "rb").read()
    if raw[:2] == b"\x1f\x8b":
        raw = gzip.decompress(raw)
    env = UnityPy.load(raw)
    print("objects:", len(env.objects))

    rows = []
    for obj in env.objects:
        if obj.type.name != "AnimatorController":
            continue
        try:
            ac = obj.read()
        except Exception:
            continue
        name = getattr(ac, "m_Name", "?")
        # 状态机：m_AnimatorLayers -> stateMachine -> m_ChildStates / m_ChildStateMachines
        names = set()

        def walk(sm, depth=0):
            if sm is None or depth > 6:
                return
            try:
                for st in getattr(sm, "m_ChildStates", []) or []:
                    s = getattr(st, "m_State", None) or (st[1] if isinstance(st, tuple) else None)
                    nm = getattr(s, "m_Name", None)
                    if nm:
                        names.add(nm)
                for sub in getattr(sm, "m_ChildStateMachines", []) or []:
                    s2 = getattr(sub, "m_StateMachine", None) or (sub[1] if isinstance(sub, tuple) else None)
                    walk(s2, depth + 1)
            except Exception:
                pass

        try:
            for layer in getattr(ac, "m_AnimatorLayers", []) or []:
                sm = getattr(layer, "m_StateMachine", None)
                if sm is None and isinstance(layer, tuple):
                    sm = layer[1]
                walk(sm)
        except Exception:
            pass

        # 参数
        params = set()
        try:
            for p in getattr(ac, "m_AnimatorParameters", []) or []:
                nm = getattr(p, "m_Name", None)
                if nm:
                    params.add(nm)
        except Exception:
            pass

        bath = sorted(n for n in names if "bath" in n.lower())
        rows.append((name, len(names), bath, params, sorted(names)))

    print("AnimatorController 数:", len(rows))
    rows.sort(key=lambda r: (len(r[2]) == 0, r[0]))
    for name, n, bath, params, allnames in rows:
        if wants and name not in wants:
            continue
        flag = ("含Bath(%d)" % len(bath)) if bath else "*** 无 Bath ***"
        print("  ctrl %-10s states=%-4d %-16s params=%s" % (name, n, flag, ",".join(sorted(params))[:60]))
        if wants:
            print("      状态:", ", ".join(allnames))
            if bath:
                print("      Bath:", ", ".join(bath))
    hit = [r for r in rows if r[2]]
    print("含 Bath 的 controller: %d / %d" % (len(hit), len(rows)))


if __name__ == "__main__":
    main()
