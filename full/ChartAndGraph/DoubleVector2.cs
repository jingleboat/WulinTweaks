using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ChartAndGraph;

[StructLayout(LayoutKind.Explicit)]
public struct DoubleVector2
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDoubleVector3_Public_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;

	[FieldOffset(0)]
	public double x;

	[FieldOffset(8)]
	public double y;

	static DoubleVector2()
	{
		Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "DoubleVector2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr, "y");
		NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr, 100669894);
		NativeMethodInfoPtr_ToDoubleVector3_Public_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr, 100669895);
		NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr, 100669896);
	}

	[CallerCount(0)]
	public unsafe DoubleVector2(Vector2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 754603, RefRangeEnd = 754605, XrefRangeStart = 754603, XrefRangeEnd = 754603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleVector3 ToDoubleVector3()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDoubleVector3_Public_DoubleVector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 754605, RefRangeEnd = 754612, XrefRangeStart = 754605, XrefRangeEnd = 754605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleVector2(double _x, double _y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_x);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DoubleVector2>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
