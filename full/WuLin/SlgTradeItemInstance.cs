using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public class SlgTradeItemInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Templete;

	private static readonly System.IntPtr NativeFieldInfoPtr_TraderTemplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSellItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCostItem;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCTradeItem_Dlc1FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Stock_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSellIcon_Public_Sprite_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSellAmount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSellItem_Public_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSellCurrencyType_Public_CurrencyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCostIcon_Public_Sprite_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCostAmount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCostItem_Public_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCostCurrencyType_Public_CurrencyType_0;

	public unsafe DLCTradeItem Templete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Templete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCTradeItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Templete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCTradeItem));
		}
	}

	public unsafe DLCTrader TraderTemplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TraderTemplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCTrader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TraderTemplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCTrader));
		}
	}

	public unsafe Dlc1FactionInstance factionInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dlc1FactionInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1FactionInstance));
		}
	}

	public unsafe bool isSellItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSellItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSellItem)) = flag;
		}
	}

	public unsafe bool isCostItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCostItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCostItem)) = flag;
		}
	}

	public unsafe int Stock
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1003881, RefRangeEnd = 1003888, XrefRangeStart = 1003875, XrefRangeEnd = 1003881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Stock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static SlgTradeItemInstance()
	{
		Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SlgTradeItemInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr);
		NativeFieldInfoPtr_Templete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, "Templete");
		NativeFieldInfoPtr_TraderTemplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, "TraderTemplete");
		NativeFieldInfoPtr_factionInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, "factionInstance");
		NativeFieldInfoPtr_isSellItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, "isSellItem");
		NativeFieldInfoPtr_isCostItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, "isCostItem");
		NativeMethodInfoPtr__ctor_Public_Void_DLCTradeItem_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679452);
		NativeMethodInfoPtr_get_Stock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679453);
		NativeMethodInfoPtr_GetSellIcon_Public_Sprite_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679454);
		NativeMethodInfoPtr_GetSellAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679455);
		NativeMethodInfoPtr_GetSellItem_Public_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679456);
		NativeMethodInfoPtr_GetSellCurrencyType_Public_CurrencyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679457);
		NativeMethodInfoPtr_GetCostIcon_Public_Sprite_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679458);
		NativeMethodInfoPtr_GetCostAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679459);
		NativeMethodInfoPtr_GetCostItem_Public_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679460);
		NativeMethodInfoPtr_GetCostCurrencyType_Public_CurrencyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr, 100679461);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003874, RefRangeEnd = 1003875, XrefRangeStart = 1003864, XrefRangeEnd = 1003874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgTradeItemInstance(DLCTradeItem dLCTradeItem, Dlc1FactionInstance factionInstance)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgTradeItemInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCTradeItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DLCTradeItem_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003907, RefRangeEnd = 1003908, XrefRangeStart = 1003888, XrefRangeEnd = 1003907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetSellIcon(bool isSmallIcon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSmallIcon);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSellIcon_Public_Sprite_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1003911, RefRangeEnd = 1003913, XrefRangeStart = 1003908, XrefRangeEnd = 1003911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSellAmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSellAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1003920, RefRangeEnd = 1003926, XrefRangeStart = 1003913, XrefRangeEnd = 1003920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData GetSellItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSellItem_Public_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003927, RefRangeEnd = 1003928, XrefRangeStart = 1003926, XrefRangeEnd = 1003927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurrencyType GetSellCurrencyType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSellCurrencyType_Public_CurrencyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CurrencyType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003947, RefRangeEnd = 1003948, XrefRangeStart = 1003928, XrefRangeEnd = 1003947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetCostIcon(bool isSmallIcon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSmallIcon);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCostIcon_Public_Sprite_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1003951, RefRangeEnd = 1003957, XrefRangeStart = 1003948, XrefRangeEnd = 1003951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCostAmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCostAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1003964, RefRangeEnd = 1003967, XrefRangeStart = 1003957, XrefRangeEnd = 1003964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemData GetCostItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCostItem_Public_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1003968, RefRangeEnd = 1003970, XrefRangeStart = 1003967, XrefRangeEnd = 1003968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurrencyType GetCostCurrencyType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCostCurrencyType_Public_CurrencyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CurrencyType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public SlgTradeItemInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
