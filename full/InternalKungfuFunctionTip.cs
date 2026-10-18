using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using WuLin;

public class InternalKungfuFunctionTip : UiSingletonPrefab<InternalKungfuFunctionTip>
{
	private static readonly IntPtr NativeFieldInfoPtr_CenterRectTransform;

	private static readonly IntPtr NativeFieldInfoPtr_TitleText;

	private static readonly IntPtr NativeFieldInfoPtr_CostText;

	private static readonly IntPtr NativeFieldInfoPtr_DescriptionText;

	private static readonly IntPtr NativeFieldInfoPtr_SklToTargetEft_Logic;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_BattleActorActionType_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetKungfuNameTag_Public_String_BattleActorActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdatePos_Public_Void_RectTransform_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RectTransform CenterRectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CenterRectTransform);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CenterRectTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe TextMeshProUGUI TitleText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TitleText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TitleText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI CostText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI DescriptionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe KungfuAtomicEffectExt.SklToTargetEft_Logic SklToTargetEft_Logic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SklToTargetEft_Logic);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<KungfuAtomicEffectExt.SklToTargetEft_Logic>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SklToTargetEft_Logic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sklToTargetEft_Logic));
		}
	}

	static InternalKungfuFunctionTip()
	{
		Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InternalKungfuFunctionTip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr);
		NativeFieldInfoPtr_CenterRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, "CenterRectTransform");
		NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, "TitleText");
		NativeFieldInfoPtr_CostText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, "CostText");
		NativeFieldInfoPtr_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, "DescriptionText");
		NativeFieldInfoPtr_SklToTargetEft_Logic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, "SklToTargetEft_Logic");
		NativeMethodInfoPtr_Init_Public_Void_BattleActorActionType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_GetKungfuNameTag_Public_String_BattleActorActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_UpdatePos_Public_Void_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr, 100664183);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684691, RefRangeEnd = 684692, XrefRangeStart = 684564, XrefRangeEnd = 684691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(BattleActorActionType battleActorActionType, Vector3 pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&battleActorActionType);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &pos;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_BattleActorActionType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 684701, RefRangeEnd = 684703, XrefRangeStart = 684692, XrefRangeEnd = 684701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetKungfuNameTag(BattleActorActionType battleActorActionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&battleActorActionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuNameTag_Public_String_BattleActorActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684774, RefRangeEnd = 684775, XrefRangeStart = 684703, XrefRangeEnd = 684774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePos(RectTransform obj, Vector2 vc2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &vc2;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePos_Public_Void_RectTransform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684775, XrefRangeEnd = 684785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InternalKungfuFunctionTip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalKungfuFunctionTip>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InternalKungfuFunctionTip(IntPtr pointer)
		: base(pointer)
	{
	}
}
