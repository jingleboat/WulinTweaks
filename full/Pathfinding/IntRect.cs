using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct IntRect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xmin;

	private static readonly System.IntPtr NativeFieldInfoPtr_ymin;

	private static readonly System.IntPtr NativeFieldInfoPtr_xmax;

	private static readonly System.IntPtr NativeFieldInfoPtr_ymax;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Min_Public_get_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Max_Public_get_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Width_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Height_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Area_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntRect_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntRect_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Intersection_Public_Static_IntRect_IntRect_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Intersects_Public_Static_Boolean_IntRect_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Union_Public_Static_IntRect_IntRect_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandToContain_Public_IntRect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Expand_Public_IntRect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugDraw_Public_Void_GraphTransform_Color_0;

	[FieldOffset(0)]
	public int xmin;

	[FieldOffset(4)]
	public int ymin;

	[FieldOffset(8)]
	public int xmax;

	[FieldOffset(12)]
	public int ymax;

	public unsafe Int2 Min
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Min_Public_get_Int2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Int2 Max
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Max_Public_get_Int2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int Width
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1067335, RefRangeEnd = 1067343, XrefRangeStart = 1067335, XrefRangeEnd = 1067335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Width_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int Height
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1067343, RefRangeEnd = 1067349, XrefRangeStart = 1067343, XrefRangeEnd = 1067343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Height_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int Area
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Area_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static IntRect()
	{
		Il2CppClassPointerStore<IntRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "IntRect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntRect>.NativeClassPtr);
		NativeFieldInfoPtr_xmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "xmin");
		NativeFieldInfoPtr_ymin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "ymin");
		NativeFieldInfoPtr_xmax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "xmax");
		NativeFieldInfoPtr_ymax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "ymax");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682952);
		NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682953);
		NativeMethodInfoPtr_get_Min_Public_get_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682954);
		NativeMethodInfoPtr_get_Max_Public_get_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682955);
		NativeMethodInfoPtr_get_Width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682956);
		NativeMethodInfoPtr_get_Height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682957);
		NativeMethodInfoPtr_get_Area_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682958);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682959);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntRect_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682960);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntRect_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682961);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682962);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682963);
		NativeMethodInfoPtr_Intersection_Public_Static_IntRect_IntRect_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682964);
		NativeMethodInfoPtr_Intersects_Public_Static_Boolean_IntRect_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682965);
		NativeMethodInfoPtr_Union_Public_Static_IntRect_IntRect_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682966);
		NativeMethodInfoPtr_ExpandToContain_Public_IntRect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682967);
		NativeMethodInfoPtr_Expand_Public_IntRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682968);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682969);
		NativeMethodInfoPtr_DebugDraw_Public_Void_GraphTransform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100682970);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 1067301, RefRangeEnd = 1067333, XrefRangeStart = 1067301, XrefRangeEnd = 1067301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntRect(int xmin, int ymin, int xmax, int ymax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xmin);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ymin;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &xmax;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ymax;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1067333, RefRangeEnd = 1067335, XrefRangeStart = 1067333, XrefRangeEnd = 1067333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1067349, RefRangeEnd = 1067357, XrefRangeStart = 1067349, XrefRangeEnd = 1067349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067357, RefRangeEnd = 1067358, XrefRangeStart = 1067357, XrefRangeEnd = 1067357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(IntRect a, IntRect b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(IntRect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntRect_IntRect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(IntRect a, IntRect b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(IntRect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntRect_IntRect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067358, XrefRangeEnd = 1067361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1067368, RefRangeEnd = 1067388, XrefRangeStart = 1067361, XrefRangeEnd = 1067368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntRect Intersection(IntRect a, IntRect b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(IntRect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Intersection_Public_Static_IntRect_IntRect_IntRect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IntRect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067388, RefRangeEnd = 1067389, XrefRangeStart = 1067388, XrefRangeEnd = 1067388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Intersects(IntRect a, IntRect b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(IntRect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Intersects_Public_Static_Boolean_IntRect_IntRect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067396, RefRangeEnd = 1067397, XrefRangeStart = 1067389, XrefRangeEnd = 1067396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntRect Union(IntRect a, IntRect b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(IntRect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Union_Public_Static_IntRect_IntRect_IntRect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IntRect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1067404, RefRangeEnd = 1067410, XrefRangeStart = 1067397, XrefRangeEnd = 1067404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntRect ExpandToContain(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandToContain_Public_IntRect_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IntRect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1067410, RefRangeEnd = 1067412, XrefRangeStart = 1067410, XrefRangeEnd = 1067410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntRect Expand(int range)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&range);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Expand_Public_IntRect_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IntRect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067412, XrefRangeEnd = 1067480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067480, XrefRangeEnd = 1067491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugDraw(GraphTransform transform, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugDraw_Public_Void_GraphTransform_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntRect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
