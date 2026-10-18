using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public sealed class AICalculateValues : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_valuesDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_bonusDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_AIValueType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBonus_Public_Void_AIValueType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Single_AIValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBonus_Public_Single_AIValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalBonus_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBonusGreaterThan_Public_Boolean_AICalculateValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValueGreaterThan_Public_Boolean_AICalculateValues_AIValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValueSmallerThan_Public_Boolean_AICalculateValues_AIValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBonusGreaterThan_Public_Boolean_AICalculateValues_AIValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBonusSmallerThan_Public_Boolean_AICalculateValues_AIValueType_0;

	public unsafe Dictionary<AIValueType, float> valuesDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valuesDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AIValueType, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valuesDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<AIValueType, float> bonusDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AIValueType, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static AICalculateValues()
	{
		Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "AICalculateValues");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr);
		NativeFieldInfoPtr_valuesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, "valuesDict");
		NativeFieldInfoPtr_bonusDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, "bonusDict");
		NativeMethodInfoPtr_ClearAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671112);
		NativeMethodInfoPtr_SetValue_Public_Void_AIValueType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671113);
		NativeMethodInfoPtr_SetBonus_Public_Void_AIValueType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671114);
		NativeMethodInfoPtr_GetValue_Public_Single_AIValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671115);
		NativeMethodInfoPtr_GetBonus_Public_Single_AIValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671116);
		NativeMethodInfoPtr_GetTotalBonus_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671117);
		NativeMethodInfoPtr_IsBonusGreaterThan_Public_Boolean_AICalculateValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671118);
		NativeMethodInfoPtr_IsValueGreaterThan_Public_Boolean_AICalculateValues_AIValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671119);
		NativeMethodInfoPtr_IsValueSmallerThan_Public_Boolean_AICalculateValues_AIValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671120);
		NativeMethodInfoPtr_IsBonusGreaterThan_Public_Boolean_AICalculateValues_AIValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671121);
		NativeMethodInfoPtr_IsBonusSmallerThan_Public_Boolean_AICalculateValues_AIValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr, 100671122);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 772074, RefRangeEnd = 772075, XrefRangeStart = 772069, XrefRangeEnd = 772074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAll_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 772085, RefRangeEnd = 772089, XrefRangeStart = 772075, XrefRangeEnd = 772085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue(AIValueType aIValueType, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aIValueType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_AIValueType_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772089, XrefRangeEnd = 772099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBonus(AIValueType aIValueType, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aIValueType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBonus_Public_Void_AIValueType_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 772105, RefRangeEnd = 772107, XrefRangeStart = 772099, XrefRangeEnd = 772105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetValue(AIValueType aIValueType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aIValueType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Single_AIValueType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772107, XrefRangeEnd = 772113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBonus(AIValueType aIValueType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aIValueType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBonus_Public_Single_AIValueType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 772130, RefRangeEnd = 772132, XrefRangeStart = 772113, XrefRangeEnd = 772130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTotalBonus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalBonus_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772132, XrefRangeEnd = 772134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBonusGreaterThan(AICalculateValues other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBonusGreaterThan_Public_Boolean_AICalculateValues_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772134, XrefRangeEnd = 772144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValueGreaterThan(AICalculateValues other, AIValueType key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		*(AIValueType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValueGreaterThan_Public_Boolean_AICalculateValues_AIValueType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772144, XrefRangeEnd = 772154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValueSmallerThan(AICalculateValues other, AIValueType key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		*(AIValueType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValueSmallerThan_Public_Boolean_AICalculateValues_AIValueType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772154, XrefRangeEnd = 772164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBonusGreaterThan(AICalculateValues other, AIValueType key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		*(AIValueType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBonusGreaterThan_Public_Boolean_AICalculateValues_AIValueType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772164, XrefRangeEnd = 772174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBonusSmallerThan(AICalculateValues other, AIValueType key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		*(AIValueType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBonusSmallerThan_Public_Boolean_AICalculateValues_AIValueType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public AICalculateValues(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AICalculateValues()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AICalculateValues>.NativeClassPtr))
	{
	}
}
