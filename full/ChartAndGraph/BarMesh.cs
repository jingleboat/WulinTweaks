using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ChartAndGraph;

public class BarMesh : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m2DStrechMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m3DStretchMesh;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StrechMesh3D_Public_Static_get_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StrechMesh2D_Public_Static_get_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update2DMeshUv_Public_Static_Void_Mesh_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate2DMesh_Public_Static_Mesh_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteRect_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteTringle_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update3DMeshUv_Public_Static_Void_Mesh_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate3DMesh_Public_Static_Mesh_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Mesh m2DStrechMesh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m2DStrechMesh, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m2DStrechMesh, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe static Mesh m3DStretchMesh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m3DStretchMesh, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m3DStretchMesh, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe static Mesh StrechMesh3D
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752403, XrefRangeEnd = 752412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StrechMesh3D_Public_Static_get_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
	}

	public unsafe static Mesh StrechMesh2D
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752412, XrefRangeEnd = 752421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StrechMesh2D_Public_Static_get_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
	}

	static BarMesh()
	{
		Il2CppClassPointerStore<BarMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "BarMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarMesh>.NativeClassPtr);
		NativeFieldInfoPtr_m2DStrechMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, "m2DStrechMesh");
		NativeFieldInfoPtr_m3DStretchMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, "m3DStretchMesh");
		NativeMethodInfoPtr_get_StrechMesh3D_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669631);
		NativeMethodInfoPtr_get_StrechMesh2D_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669632);
		NativeMethodInfoPtr_Update2DMeshUv_Public_Static_Void_Mesh_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669633);
		NativeMethodInfoPtr_Generate2DMesh_Public_Static_Mesh_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669634);
		NativeMethodInfoPtr_WriteRect_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669635);
		NativeMethodInfoPtr_WriteTringle_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669636);
		NativeMethodInfoPtr_Update3DMeshUv_Public_Static_Void_Mesh_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669637);
		NativeMethodInfoPtr_Generate3DMesh_Public_Static_Mesh_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669638);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarMesh>.NativeClassPtr, 100669639);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 752434, RefRangeEnd = 752435, XrefRangeStart = 752421, XrefRangeEnd = 752434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update2DMeshUv(Mesh m, float maxV)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxV;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update2DMeshUv_Public_Static_Void_Mesh_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 752453, RefRangeEnd = 752455, XrefRangeStart = 752435, XrefRangeEnd = 752453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh Generate2DMesh(float maxV)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxV);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate2DMesh_Public_Static_Mesh_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static void WriteRect(Il2CppStructArray<int> tringles, int tringleIndex, int a, int b, int c, int d, bool flip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tringles);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tringleIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &flip;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteRect_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void WriteTringle(Il2CppStructArray<int> tringles, int tringleIndex, int a, int b, int c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tringles);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tringleIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteTringle_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 752490, RefRangeEnd = 752491, XrefRangeStart = 752455, XrefRangeEnd = 752490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update3DMeshUv(Mesh m, float maxV)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxV;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update3DMeshUv_Public_Static_Void_Mesh_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 752509, RefRangeEnd = 752511, XrefRangeStart = 752491, XrefRangeEnd = 752509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh Generate3DMesh(float maxV)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxV);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Generate3DMesh_Public_Static_Mesh_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarMesh>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BarMesh(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
