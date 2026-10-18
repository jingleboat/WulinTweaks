using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding.RVO;

[StructLayout(LayoutKind.Explicit)]
public struct Line
{
	private static readonly System.IntPtr NativeFieldInfoPtr_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir;

	[FieldOffset(0)]
	public Vector2 point;

	[FieldOffset(8)]
	public Vector2 dir;

	static Line()
	{
		Il2CppClassPointerStore<Line>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.RVO", "Line");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Line>.NativeClassPtr);
		NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "point");
		NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "dir");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Line>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
