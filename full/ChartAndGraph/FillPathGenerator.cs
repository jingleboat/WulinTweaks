using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ChartAndGraph;

public class FillPathGenerator : SmoothPathGenerator
{
	private static readonly IntPtr NativeFieldInfoPtr_WithTop;

	private static readonly IntPtr NativeFieldInfoPtr_MatchLine;

	private static readonly IntPtr NativeFieldInfoPtr_mGraphBottom;

	private static readonly IntPtr NativeFieldInfoPtr_mGraphTop;

	private static readonly IntPtr NativeFieldInfoPtr_StretchFill;

	private static readonly IntPtr NativeFieldInfoPtr_mTmpTringle;

	private static readonly IntPtr NativeFieldInfoPtr_mTmpUv;

	private static readonly IntPtr NativeFieldInfoPtr_mVertices;

	private static readonly IntPtr NativeFieldInfoPtr_mHasParent;

	private static readonly IntPtr NativeFieldInfoPtr_mParentJointSmoothing;

	private static readonly IntPtr NativeFieldInfoPtr_mParentJointSize;

	private static readonly IntPtr NativeMethodInfoPtr_get_JointSizeLink_Protected_Virtual_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_JointSmoothingLink_Protected_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLineSmoothing_Public_Void_Boolean_Int32_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetStrechFill_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetGraphBounds_Public_Void_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteVector_Private_Int32_Vector3_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddTringles_Private_Void_List_1_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Generator_Public_Virtual_Void_Il2CppStructArray_1_Vector3_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool WithTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WithTop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WithTop)) = flag;
		}
	}

	public unsafe bool MatchLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MatchLine);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MatchLine)) = flag;
		}
	}

	public unsafe float mGraphBottom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGraphBottom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGraphBottom)) = num;
		}
	}

	public unsafe float mGraphTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGraphTop);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGraphTop)) = num;
		}
	}

	public unsafe bool StretchFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StretchFill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StretchFill)) = flag;
		}
	}

	public unsafe List<int> mTmpTringle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTmpTringle);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTmpTringle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector2> mTmpUv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTmpUv);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTmpUv)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3> mVertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mVertices);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mVertices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool mHasParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHasParent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHasParent)) = flag;
		}
	}

	public unsafe int mParentJointSmoothing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mParentJointSmoothing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mParentJointSmoothing)) = num;
		}
	}

	public unsafe float mParentJointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mParentJointSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mParentJointSize)) = num;
		}
	}

	public unsafe override float JointSizeLink
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_JointSizeLink_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override int JointSmoothingLink
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_JointSmoothingLink_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static FillPathGenerator()
	{
		Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "FillPathGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_WithTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "WithTop");
		NativeFieldInfoPtr_MatchLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "MatchLine");
		NativeFieldInfoPtr_mGraphBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mGraphBottom");
		NativeFieldInfoPtr_mGraphTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mGraphTop");
		NativeFieldInfoPtr_StretchFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "StretchFill");
		NativeFieldInfoPtr_mTmpTringle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mTmpTringle");
		NativeFieldInfoPtr_mTmpUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mTmpUv");
		NativeFieldInfoPtr_mVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mVertices");
		NativeFieldInfoPtr_mHasParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mHasParent");
		NativeFieldInfoPtr_mParentJointSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mParentJointSmoothing");
		NativeFieldInfoPtr_mParentJointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, "mParentJointSize");
		NativeMethodInfoPtr_get_JointSizeLink_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670339);
		NativeMethodInfoPtr_get_JointSmoothingLink_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670340);
		NativeMethodInfoPtr_SetLineSmoothing_Public_Void_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670341);
		NativeMethodInfoPtr_SetStrechFill_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670342);
		NativeMethodInfoPtr_SetGraphBounds_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670343);
		NativeMethodInfoPtr_WriteVector_Private_Int32_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670344);
		NativeMethodInfoPtr_AddTringles_Private_Void_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670345);
		NativeMethodInfoPtr_Generator_Public_Virtual_Void_Il2CppStructArray_1_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670346);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr, 100670347);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759616, RefRangeEnd = 759618, XrefRangeStart = 759616, XrefRangeEnd = 759616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLineSmoothing(bool hasParent, int jointSmoothing, float jointSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&hasParent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &jointSmoothing;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &jointSize;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLineSmoothing_Public_Void_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetStrechFill(bool strech)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&strech);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStrechFill_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759618, RefRangeEnd = 759619, XrefRangeStart = 759618, XrefRangeEnd = 759618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGraphBounds(float bottom, float top)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&bottom);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &top;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGraphBounds_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 759663, RefRangeEnd = 759667, XrefRangeStart = 759619, XrefRangeEnd = 759663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int WriteVector(Vector3 position, float thickness, float u)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &thickness;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &u;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteVector_Private_Int32_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759716, RefRangeEnd = 759717, XrefRangeStart = 759667, XrefRangeEnd = 759716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTringles(List<int> tringles, int from, int to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tringles);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &to;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTringles_Private_Void_List_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759717, XrefRangeEnd = 759798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Generator(Il2CppStructArray<Vector3> path, float thickness, bool closed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &thickness;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &closed;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generator_Public_Virtual_Void_Il2CppStructArray_1_Vector3_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759798, XrefRangeEnd = 759817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FillPathGenerator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FillPathGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FillPathGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}
