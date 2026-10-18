using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public static class Polygon : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cached_Int3_int_dict;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Int3_Int3_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Int2_Int2_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Il2CppStructArray_1_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Il2CppStructArray_1_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SampleYCoordinateInTriangle_Public_Static_Int32_Int3_Int3_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvexHullXZ_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnTriangle_Public_Static_Vector2_Vector2_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnTriangleXZ_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnTriangle_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompressMesh_Public_Static_Void_List_1_Int3_List_1_Int32_byref_Il2CppStructArray_1_Int3_byref_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceContours_Public_Static_Void_Dictionary_2_Int32_Int32_HashSet_1_Int32_Action_2_List_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subdivide_Public_Static_Void_List_1_Vector3_List_1_Vector3_Int32_0;

	public unsafe static Dictionary<Int3, int> cached_Int3_int_dict
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cached_Int3_int_dict, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Int3, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cached_Int3_int_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static Polygon()
	{
		Il2CppClassPointerStore<Polygon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "Polygon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Polygon>.NativeClassPtr);
		NativeFieldInfoPtr_cached_Int3_int_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "cached_Int3_int_dict");
		NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682462);
		NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Int3_Int3_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682463);
		NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Int2_Int2_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682464);
		NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Il2CppStructArray_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682465);
		NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682466);
		NativeMethodInfoPtr_SampleYCoordinateInTriangle_Public_Static_Int32_Int3_Int3_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682467);
		NativeMethodInfoPtr_ConvexHullXZ_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682468);
		NativeMethodInfoPtr_ClosestPointOnTriangle_Public_Static_Vector2_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682469);
		NativeMethodInfoPtr_ClosestPointOnTriangleXZ_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682470);
		NativeMethodInfoPtr_ClosestPointOnTriangle_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682471);
		NativeMethodInfoPtr_CompressMesh_Public_Static_Void_List_1_Int3_List_1_Int32_byref_Il2CppStructArray_1_Int3_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682472);
		NativeMethodInfoPtr_TraceContours_Public_Static_Void_Dictionary_2_Int32_Int32_HashSet_1_Int32_Action_2_List_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682473);
		NativeMethodInfoPtr_Subdivide_Public_Static_Void_List_1_Vector3_List_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100682474);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061819, XrefRangeEnd = 1061823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsPointXZ(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061823, XrefRangeEnd = 1061827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsPointXZ(Int3 a, Int3 b, Int3 c, Int3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Int3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Int3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Int3_Int3_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061827, XrefRangeEnd = 1061831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsPoint(Int2 a, Int2 b, Int2 c, Int2 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Int2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Int2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Int2_Int2_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061831, XrefRangeEnd = 1061832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsPoint(Il2CppStructArray<Vector2> polyPoints, Vector2 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)polyPoints);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Il2CppStructArray_1_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061833, RefRangeEnd = 1061834, XrefRangeStart = 1061832, XrefRangeEnd = 1061833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsPointXZ(Il2CppStructArray<Vector3> polyPoints, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)polyPoints);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsPointXZ_Public_Static_Boolean_Il2CppStructArray_1_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061844, RefRangeEnd = 1061846, XrefRangeStart = 1061834, XrefRangeEnd = 1061844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SampleYCoordinateInTriangle(Int3 p1, Int3 p2, Int3 p3, Int3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&p1);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Int3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		*(Int3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SampleYCoordinateInTriangle_Public_Static_Int32_Int3_Int3_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1061874, RefRangeEnd = 1061878, XrefRangeStart = 1061846, XrefRangeEnd = 1061874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> ConvexHullXZ(Il2CppStructArray<Vector3> points)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)points);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvexHullXZ_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061878, XrefRangeEnd = 1061883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ClosestPointOnTriangle(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosestPointOnTriangle_Public_Static_Vector2_Vector2_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061889, RefRangeEnd = 1061891, XrefRangeStart = 1061883, XrefRangeEnd = 1061889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 ClosestPointOnTriangleXZ(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosestPointOnTriangleXZ_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061897, RefRangeEnd = 1061898, XrefRangeStart = 1061891, XrefRangeEnd = 1061897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 ClosestPointOnTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosestPointOnTriangle_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061953, RefRangeEnd = 1061955, XrefRangeStart = 1061898, XrefRangeEnd = 1061953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompressMesh(List<Int3> vertices, List<int> triangles, out Il2CppStructArray<Int3> outVertices, out Il2CppStructArray<int> outTriangles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)triangles);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompressMesh_Public_Static_Void_List_1_Int3_List_1_Int32_byref_Il2CppStructArray_1_Int3_byref_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num5 = num2;
		outVertices = ((num5 == 0) ? null : new Il2CppStructArray<Int3>((System.IntPtr)num5));
		nint num6 = num4;
		outTriangles = ((num6 == 0) ? null : new Il2CppStructArray<int>((System.IntPtr)num6));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062005, RefRangeEnd = 1062006, XrefRangeStart = 1061955, XrefRangeEnd = 1062005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceContours(Dictionary<int, int> outline, HashSet<int> hasInEdge, Il2CppSystem.Action<List<int>, bool> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outline);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hasInEdge);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceContours_Public_Static_Void_Dictionary_2_Int32_Int32_HashSet_1_Int32_Action_2_List_1_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1062018, RefRangeEnd = 1062020, XrefRangeStart = 1062006, XrefRangeEnd = 1062018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Subdivide(List<Vector3> points, List<Vector3> result, int subSegments)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)points);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &subSegments;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subdivide_Public_Static_Void_List_1_Vector3_List_1_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Polygon(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
