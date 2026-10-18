using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ChartAndGraph;

public class ChartItemGrowEffect : ChartItemEffect
{
	private static readonly IntPtr NativeFieldInfoPtr_NoOp;

	private static readonly IntPtr NativeFieldInfoPtr_GrowOp;

	private static readonly IntPtr NativeFieldInfoPtr_ShrinkOp;

	private static readonly IntPtr NativeFieldInfoPtr_GrowShrinkOp;

	private static readonly IntPtr NativeFieldInfoPtr_GrowMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_VerticalOnly;

	private static readonly IntPtr NativeFieldInfoPtr_TimeScale;

	private static readonly IntPtr NativeFieldInfoPtr_GrowEaseFunction;

	private static readonly IntPtr NativeFieldInfoPtr_ShrinkEaseFunction;

	private static readonly IntPtr NativeFieldInfoPtr_mScaleMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_mStartTime;

	private static readonly IntPtr NativeFieldInfoPtr_mStartValue;

	private static readonly IntPtr NativeFieldInfoPtr_Operation;

	private static readonly IntPtr NativeFieldInfoPtr_mDeactivateOnEnd;

	private static readonly IntPtr NativeMethodInfoPtr_get_ScaleMultiplier_Internal_Virtual_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Internal_Virtual_get_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Translation_Internal_Virtual_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_GrowAndShrink_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAnimationEnded_Public_Boolean_Single_AnimationCurve_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixEaseFunction_Private_Void_AnimationCurve_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TriggerOut_Public_Virtual_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_TriggerIn_Public_Virtual_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Grow_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Shrink_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int NoOp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoOp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoOp, (void*)(&num));
		}
	}

	public unsafe static int GrowOp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GrowOp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GrowOp, (void*)(&num));
		}
	}

	public unsafe static int ShrinkOp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShrinkOp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShrinkOp, (void*)(&num));
		}
	}

	public unsafe static int GrowShrinkOp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GrowShrinkOp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GrowShrinkOp, (void*)(&num));
		}
	}

	public unsafe float GrowMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowMultiplier)) = num;
		}
	}

	public unsafe bool VerticalOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalOnly)) = flag;
		}
	}

	public unsafe float TimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeScale)) = num;
		}
	}

	public unsafe AnimationCurve GrowEaseFunction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowEaseFunction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowEaseFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve ShrinkEaseFunction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShrinkEaseFunction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShrinkEaseFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float mScaleMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mScaleMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mScaleMultiplier)) = num;
		}
	}

	public unsafe float mStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mStartTime)) = num;
		}
	}

	public unsafe float mStartValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mStartValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mStartValue)) = num;
		}
	}

	public unsafe int Operation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Operation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Operation)) = num;
		}
	}

	public unsafe bool mDeactivateOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mDeactivateOnEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mDeactivateOnEnd)) = flag;
		}
	}

	public unsafe override Vector3 ScaleMultiplier
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ScaleMultiplier_Internal_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override Quaternion Rotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754208, XrefRangeEnd = 754209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Rotation_Internal_Virtual_get_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override Vector3 Translation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754209, XrefRangeEnd = 754210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Translation_Internal_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ChartItemGrowEffect()
	{
		Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartItemGrowEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr);
		NativeFieldInfoPtr_NoOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "NoOp");
		NativeFieldInfoPtr_GrowOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "GrowOp");
		NativeFieldInfoPtr_ShrinkOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "ShrinkOp");
		NativeFieldInfoPtr_GrowShrinkOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "GrowShrinkOp");
		NativeFieldInfoPtr_GrowMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "GrowMultiplier");
		NativeFieldInfoPtr_VerticalOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "VerticalOnly");
		NativeFieldInfoPtr_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "TimeScale");
		NativeFieldInfoPtr_GrowEaseFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "GrowEaseFunction");
		NativeFieldInfoPtr_ShrinkEaseFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "ShrinkEaseFunction");
		NativeFieldInfoPtr_mScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "mScaleMultiplier");
		NativeFieldInfoPtr_mStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "mStartTime");
		NativeFieldInfoPtr_mStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "mStartValue");
		NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "Operation");
		NativeFieldInfoPtr_mDeactivateOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, "mDeactivateOnEnd");
		NativeMethodInfoPtr_get_ScaleMultiplier_Internal_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669830);
		NativeMethodInfoPtr_get_Rotation_Internal_Virtual_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669831);
		NativeMethodInfoPtr_get_Translation_Internal_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669832);
		NativeMethodInfoPtr_GrowAndShrink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669833);
		NativeMethodInfoPtr_CheckAnimationEnded_Public_Boolean_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669834);
		NativeMethodInfoPtr_FixEaseFunction_Private_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669835);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669836);
		NativeMethodInfoPtr_TriggerOut_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669837);
		NativeMethodInfoPtr_TriggerIn_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669838);
		NativeMethodInfoPtr_Grow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669839);
		NativeMethodInfoPtr_Shrink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669840);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr, 100669841);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754210, XrefRangeEnd = 754211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GrowAndShrink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GrowAndShrink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754220, RefRangeEnd = 754221, XrefRangeStart = 754211, XrefRangeEnd = 754220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckAnimationEnded(float time, AnimationCurve curve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&time);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curve);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAnimationEnded_Public_Boolean_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixEaseFunction(AnimationCurve curve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curve);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixEaseFunction_Private_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754221, XrefRangeEnd = 754230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754230, XrefRangeEnd = 754231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void TriggerOut(bool deactivateOnEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&deactivateOnEnd);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TriggerOut_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754231, XrefRangeEnd = 754232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void TriggerIn(bool deactivateOnEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&deactivateOnEnd);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TriggerIn_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754232, XrefRangeEnd = 754233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Grow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Grow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754233, XrefRangeEnd = 754234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Shrink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shrink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754234, XrefRangeEnd = 754237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartItemGrowEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartItemGrowEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartItemGrowEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}
