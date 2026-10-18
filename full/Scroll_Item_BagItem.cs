using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class Scroll_Item_BagItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_uiTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr__UIItem_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UIItem_Public_get_UIItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UIItem_Private_set_Void_UIItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindTrans_Public_Scroll_Item_BagItem_Transform_0;

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

	public unsafe UIItem _UIItem_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UIItem_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UIItem_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIItem));
		}
	}

	public unsafe UIItem UIItem
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UIItem_Public_get_UIItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIItem>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UIItem_Private_set_Void_UIItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Scroll_Item_BagItem()
	{
		Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Scroll_Item_BagItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr);
		NativeFieldInfoPtr_uiTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, "uiTransform");
		NativeFieldInfoPtr__UIItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, "<UIItem>k__BackingField");
		NativeMethodInfoPtr_get_UIItem_Public_get_UIItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_set_UIItem_Private_set_Void_UIItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_BindTrans_Public_Scroll_Item_BagItem_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_DestroyWidget_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr, 100664264);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 685227, RefRangeEnd = 685228, XrefRangeStart = 685224, XrefRangeEnd = 685227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Scroll_Item_BagItem BindTrans(Transform trans)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindTrans_Public_Scroll_Item_BagItem_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll_Item_BagItem>(intPtr) : null;
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
	public unsafe Scroll_Item_BagItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroll_Item_BagItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Scroll_Item_BagItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
