using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

[Serializable]
public class SimpleSmoothModifier : MonoModifier
{
	public enum SmoothType
	{
		Simple,
		Bezier,
		OffsetSimple,
		CurvedNonuniform
	}

	private static readonly IntPtr NativeFieldInfoPtr_smoothType;

	private static readonly IntPtr NativeFieldInfoPtr_subdivisions;

	private static readonly IntPtr NativeFieldInfoPtr_iterations;

	private static readonly IntPtr NativeFieldInfoPtr_strength;

	private static readonly IntPtr NativeFieldInfoPtr_uniformLength;

	private static readonly IntPtr NativeFieldInfoPtr_maxSegmentLength;

	private static readonly IntPtr NativeFieldInfoPtr_bezierTangentLength;

	private static readonly IntPtr NativeFieldInfoPtr_offset;

	private static readonly IntPtr NativeFieldInfoPtr_factor;

	private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0;

	private static readonly IntPtr NativeMethodInfoPtr_CurvedNonuniform_Public_List_1_Vector3_List_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPointOnCubic_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SmoothOffsetSimple_Public_List_1_Vector3_List_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_SmoothSimple_Public_List_1_Vector3_List_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_SmoothBezier_Public_List_1_Vector3_List_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SmoothType smoothType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothType);
			return *(SmoothType*)num;
		}
		set
		{
			*(SmoothType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothType)) = smoothType;
		}
	}

	public unsafe int subdivisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisions);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisions)) = num;
		}
	}

	public unsafe int iterations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iterations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iterations)) = num;
		}
	}

	public unsafe float strength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strength)) = num;
		}
	}

	public unsafe bool uniformLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformLength);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformLength)) = flag;
		}
	}

	public unsafe float maxSegmentLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSegmentLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSegmentLength)) = num;
		}
	}

	public unsafe float bezierTangentLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bezierTangentLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bezierTangentLength)) = num;
		}
	}

	public unsafe float offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = num;
		}
	}

	public unsafe float factor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factor)) = num;
		}
	}

	public unsafe override int Order
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static SimpleSmoothModifier()
	{
		Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "SimpleSmoothModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr);
		NativeFieldInfoPtr_smoothType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "smoothType");
		NativeFieldInfoPtr_subdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "subdivisions");
		NativeFieldInfoPtr_iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "iterations");
		NativeFieldInfoPtr_strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "strength");
		NativeFieldInfoPtr_uniformLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "uniformLength");
		NativeFieldInfoPtr_maxSegmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "maxSegmentLength");
		NativeFieldInfoPtr_bezierTangentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "bezierTangentLength");
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "offset");
		NativeFieldInfoPtr_factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, "factor");
		NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683602);
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683603);
		NativeMethodInfoPtr_CurvedNonuniform_Public_List_1_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683604);
		NativeMethodInfoPtr_GetPointOnCubic_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683605);
		NativeMethodInfoPtr_SmoothOffsetSimple_Public_List_1_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683606);
		NativeMethodInfoPtr_SmoothSimple_Public_List_1_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683607);
		NativeMethodInfoPtr_SmoothBezier_Public_List_1_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683608);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr, 100683609);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074571, XrefRangeEnd = 1074586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply(Path p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074627, RefRangeEnd = 1074628, XrefRangeStart = 1074586, XrefRangeEnd = 1074627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3> CurvedNonuniform(List<Vector3> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurvedNonuniform_Public_List_1_Vector3_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetPointOnCubic(Vector3 a, Vector3 b, Vector3 tan1, Vector3 tan2, float t)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &tan1;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &tan2;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &t;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointOnCubic_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074687, RefRangeEnd = 1074688, XrefRangeStart = 1074628, XrefRangeEnd = 1074687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3> SmoothOffsetSimple(List<Vector3> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothOffsetSimple_Public_List_1_Vector3_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074742, RefRangeEnd = 1074743, XrefRangeStart = 1074688, XrefRangeEnd = 1074742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3> SmoothSimple(List<Vector3> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothSimple_Public_List_1_Vector3_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074771, RefRangeEnd = 1074772, XrefRangeStart = 1074743, XrefRangeEnd = 1074771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3> SmoothBezier(List<Vector3> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothBezier_Public_List_1_Vector3_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074772, XrefRangeEnd = 1074773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleSmoothModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleSmoothModifier>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SimpleSmoothModifier(IntPtr pointer)
		: base(pointer)
	{
	}
}
