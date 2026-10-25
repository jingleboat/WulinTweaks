#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""列出某形象（AnimatorOverrideController，名字就是角色池 avatarR 的数字）覆盖了哪些动画。

背景：日志实测 animator 的 runtimeAnimatorController 名 = 形象 id（叶银瓶 178、叶云 177）。
这些是 **AnimatorOverrideController** —— 它们只把 base controller 里的 clip 换成该形象自己的，
所以"这个角色有没有水中动作"取决于它有没有覆盖 Bath 系列 clip。

用法：
    python dump_animoverride.py 177 178
    python dump_animoverride.py --grep Bath      # 所有形象里，覆盖了 Bath 的
"""
import gzip
import sys

import UnityPy

BUNDLE = r"D:\steamgame\steamapps\common\WulinSH\Wulin_Data\StreamingAssets\aa\StandaloneWindows64\chara_assets_all.bundle"


def clip_name(pptr):
    try:
        o = pptr.read() if pptr is not None else None
        return getattr(o, "m_Name", None) if o is not None else None
    except Exception:
        return None


def main():
    wants = [a for a in sys.argv[1:] if not a.startswith("--")]
    grep = None
    if "--grep" in sys.argv:
        grep = sys.argv[sys.argv.index("--grep") + 1].lower()

    raw = open(BUNDLE, "rb").read()
    if raw[:2] == b"\x1f\x8b":
        raw = gzip.decompress(raw)
    env = UnityPy.load(raw)

    total = 0
    for obj in env.objects:
        if obj.type.name != "AnimatorOverrideController":
            continue
        total += 1
        try:
            d = obj.read()
        except Exception:
            continue
        name = str(getattr(d, "m_Name", "?"))
        if wants and name not in wants:
            continue
        base = getattr(d, "m_Controller", None)
        base_name = None
        try:
            b = base.read() if base is not None else None
            base_name = getattr(b, "m_Name", None)
        except Exception:
            base_name = None
        ov = getattr(d, "m_Overrides", None) or getattr(d, "m_ClipOverrides", None) or []
        pairs = []
        for it in ov:
            try:
                orig = getattr(it, "m_OriginalClip", None)
                new = getattr(it, "m_OverrideClip", None)
                if orig is None and isinstance(it, tuple):
                    orig = it[0]
                    new = it[1]
                pairs.append((clip_name(orig), clip_name(new)))
            except Exception:
                continue
        hits = [(a, b) for a, b in pairs if (a and "bath" in a.lower()) or (b and "bath" in b.lower())]

        if grep is not None:
            if not hits:
                continue
            print("%-10s base=%-10s overrides=%-3d Bath命中: %s" % (name, base_name, len(pairs), hits))
        else:
            print("=== 形象 %s  base=%s  overrides=%d" % (name, base_name, len(pairs)))
            for a, b in pairs:
                print("    %-22s -> %s" % (a, b))
            print("    Bath 命中: %s" % (hits if hits else "无"))
    print("AnimatorOverrideController 总数:", total)


if __name__ == "__main__":
    main()
