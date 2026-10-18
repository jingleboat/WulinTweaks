using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding;

public static class AstarMath : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MapTo_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatBytesBinary_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bit_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToColor_Public_Static_Color_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_0;

	static AstarMath()
	{
		Il2CppClassPointerStore<AstarMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "AstarMath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarMath>.NativeClassPtr);
		NativeMethodInfoPtr_MapTo_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarMath>.NativeClassPtr, 100682457);
		NativeMethodInfoPtr_FormatBytesBinary_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarMath>.NativeClassPtr, 100682458);
		NativeMethodInfoPtr_Bit_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarMath>.NativeClassPtr, 100682459);
		NativeMethodInfoPtr_IntToColor_Public_Static_Color_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarMath>.NativeClassPtr, 100682460);
		NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarMath>.NativeClassPtr, 100682461);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061777, XrefRangeEnd = 1061779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float MapTo(float startMin, float startMax, float targetMin, float targetMax, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&startMin);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startMax;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMin;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMax;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapTo_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061799, RefRangeEnd = 1061800, XrefRangeStart = 1061779, XrefRangeEnd = 1061799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatBytesBinary(int bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatBytesBinary_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int Bit(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bit_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061801, RefRangeEnd = 1061802, XrefRangeStart = 1061800, XrefRangeEnd = 1061801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color IntToColor(int i, float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToColor_Public_Static_Color_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1061812, RefRangeEnd = 1061819, XrefRangeStart = 1061802, XrefRangeEnd = 1061812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color HSVToRGB(float h, float s, float v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&h);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &s;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public AstarMath(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
