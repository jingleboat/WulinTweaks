using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

namespace WuLin;

public class FactionBuyItemList : GenericItemListDisplayer<FactionBuyItem, FactionGoodItem>
{
	private static readonly IntPtr NativeMethodInfoPtr_get_ScrollRect_Public_get_ScrollRect_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowList_Public_Virtual_Void_List_1_FactionGoodItem_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ScrollRect ScrollRect
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922227, XrefRangeEnd = 922232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScrollRect_Public_get_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr) : null;
		}
	}

	static FactionBuyItemList()
	{
		Il2CppClassPointerStore<FactionBuyItemList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "FactionBuyItemList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionBuyItemList>.NativeClassPtr);
		NativeMethodInfoPtr_get_ScrollRect_Public_get_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionBuyItemList>.NativeClassPtr, 100676332);
		NativeMethodInfoPtr_ShowList_Public_Virtual_Void_List_1_FactionGoodItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionBuyItemList>.NativeClassPtr, 100676333);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionBuyItemList>.NativeClassPtr, 100676334);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922232, XrefRangeEnd = 922253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ShowList(List<FactionGoodItem> datas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datas);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShowList_Public_Virtual_Void_List_1_FactionGoodItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922253, XrefRangeEnd = 922256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionBuyItemList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionBuyItemList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FactionBuyItemList(IntPtr pointer)
		: base(pointer)
	{
	}
}
