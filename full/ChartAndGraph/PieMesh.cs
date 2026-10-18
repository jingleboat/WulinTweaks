using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ChartAndGraph;

public class PieMesh : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Generate3dMesh_Public_Static_Void_WorldSpaceChartMesh_Single_Single_Single_Single_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate2dPath_Public_Static_Void_List_1_Vector2_List_1_Int32_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate2dMesh_Public_Static_Void_IChartMesh_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PieMesh()
	{
		Il2CppClassPointerStore<PieMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "PieMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PieMesh>.NativeClassPtr);
		NativeMethodInfoPtr_Generate3dMesh_Public_Static_Void_WorldSpaceChartMesh_Single_Single_Single_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMesh>.NativeClassPtr, 100670486);
		NativeMethodInfoPtr_Generate2dPath_Public_Static_Void_List_1_Vector2_List_1_Int32_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMesh>.NativeClassPtr, 100670487);
		NativeMethodInfoPtr_Generate2dMesh_Public_Static_Void_IChartMesh_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMesh>.NativeClassPtr, 100670488);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMesh>.NativeClassPtr, 100670489);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760945, RefRangeEnd = 760946, XrefRangeStart = 760895, XrefRangeEnd = 760945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Generate3dMesh(WorldSpaceChartMesh mesh, float startAngle, float angleSpan, float radius, float innerRadius, int segments, float outerDepth, float innerDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startAngle;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &angleSpan;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRadius;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &segments;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &outerDepth;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate3dMesh_Public_Static_Void_WorldSpaceChartMesh_Single_Single_Single_Single_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760946, XrefRangeEnd = 760977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Generate2dPath(List<Vector2> path, List<int> tringles, float startAngle, float angleSpan, float radius, float innerRadius, int segments)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tringles);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startAngle;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &angleSpan;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRadius;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &segments;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate2dPath_Public_Static_Void_List_1_Vector2_List_1_Int32_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 760993, RefRangeEnd = 760998, XrefRangeStart = 760977, XrefRangeEnd = 760993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Generate2dMesh(IChartMesh mesh, float startAngle, float angleSpan, float radius, float innerRadius, int segments)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startAngle;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &angleSpan;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerRadius;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &segments;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate2dMesh_Public_Static_Void_IChartMesh_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PieMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PieMesh>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PieMesh(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
