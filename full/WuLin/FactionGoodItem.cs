using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

public class FactionGoodItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_factionInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionGoodData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemData_Public_get_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StockId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Stock_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerFameOrRelationCheckOk_Public_Boolean_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSinglePriceToPlayer_Public_Int32_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrencyType_Public_CurrencyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SinglePrice_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldSellByJob_Public_Boolean_FactionJobData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FactionInstance factionInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance));
		}
	}

	public unsafe GameItemInstance itemInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance));
		}
	}

	public unsafe FactionGoodsData factionGoodData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionGoodData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionGoodsData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionGoodData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionGoodsData));
		}
	}

	public unsafe ItemData ItemData
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 800501, RefRangeEnd = 800512, XrefRangeStart = 800498, XrefRangeEnd = 800501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemData_Public_get_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
	}

	public unsafe int StockId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 800516, RefRangeEnd = 800517, XrefRangeStart = 800512, XrefRangeEnd = 800516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StockId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int Stock
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 800520, RefRangeEnd = 800528, XrefRangeStart = 800517, XrefRangeEnd = 800520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe int SinglePrice
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 800578, RefRangeEnd = 800580, XrefRangeStart = 800570, XrefRangeEnd = 800578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SinglePrice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static FactionGoodItem()
	{
		Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "FactionGoodItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr);
		NativeFieldInfoPtr_factionInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, "factionInstance");
		NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, "itemInstance");
		NativeFieldInfoPtr_factionGoodData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, "factionGoodData");
		NativeMethodInfoPtr_get_ItemData_Public_get_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672088);
		NativeMethodInfoPtr_get_StockId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672089);
		NativeMethodInfoPtr_get_Stock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672090);
		NativeMethodInfoPtr_IsPlayerFameOrRelationCheckOk_Public_Boolean_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672091);
		NativeMethodInfoPtr_GetSinglePriceToPlayer_Public_Int32_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672092);
		NativeMethodInfoPtr_GetCurrencyType_Public_CurrencyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672093);
		NativeMethodInfoPtr_get_SinglePrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672094);
		NativeMethodInfoPtr_CouldSellByJob_Public_Boolean_FactionJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672095);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr, 100672096);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 800533, RefRangeEnd = 800535, XrefRangeStart = 800528, XrefRangeEnd = 800533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlayerFameOrRelationCheckOk(GameCharacterInstance dealer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayerFameOrRelationCheckOk_Public_Boolean_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 800564, RefRangeEnd = 800568, XrefRangeStart = 800535, XrefRangeEnd = 800564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSinglePriceToPlayer(GameCharacterInstance dealer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSinglePriceToPlayer_Public_Int32_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 800568, RefRangeEnd = 800570, XrefRangeStart = 800568, XrefRangeEnd = 800568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurrencyType GetCurrencyType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrencyType_Public_CurrencyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CurrencyType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800580, XrefRangeEnd = 800582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldSellByJob(FactionJobData factionJobData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionJobData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldSellByJob_Public_Boolean_FactionJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionGoodItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionGoodItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FactionGoodItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
