using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scroll_Item_GameBoolSetting : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_uiTransform;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Toggle_Public_get_Toggle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DestText_Public_get_TextMeshProUGUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindTrans_Public_Scroll_Item_GameBoolSetting_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWidget_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform uiTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Toggle Toggle
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 685080, RefRangeEnd = 685086, XrefRangeStart = 685077, XrefRangeEnd = 685080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Toggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toggle>(intPtr) : null;
		}
	}

	public unsafe TextMeshProUGUI DestText
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685089, RefRangeEnd = 685090, XrefRangeStart = 685086, XrefRangeEnd = 685089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DestText_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
	}

	static Scroll_Item_GameBoolSetting()
	{
		Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Scroll_Item_GameBoolSetting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr);
		NativeFieldInfoPtr_uiTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr, "uiTransform");
		NativeMethodInfoPtr_get_Toggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_get_DestText_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_BindTrans_Public_Scroll_Item_GameBoolSetting_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_DestroyWidget_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr, 100664233);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 348029, RefRangeEnd = 348038, XrefRangeStart = 348029, XrefRangeEnd = 348038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Scroll_Item_GameBoolSetting BindTrans(Transform trans)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindTrans_Public_Scroll_Item_GameBoolSetting_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll_Item_GameBoolSetting>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void DestroyWidget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyWidget_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Scroll_Item_GameBoolSetting()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroll_Item_GameBoolSetting>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Scroll_Item_GameBoolSetting(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
