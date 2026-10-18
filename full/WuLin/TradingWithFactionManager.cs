using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class TradingWithFactionManager : MonoSingleton<TradingWithFactionManager>
{
	public enum ShopCurrencyType
	{
		Coin,
		FactionTribute,
		Item
	}

	[ObfuscatedName("WuLin.TradingWithFactionManager+<>c__DisplayClass13_0")]
	public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_list;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BuyWithCurrentTarget_b__0_Internal_Void_0;

		public unsafe List<FactionGoodItem> list
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionGoodItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static __c__DisplayClass13_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "<>c__DisplayClass13_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr);
			NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, "list");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, 100687441);
			NativeMethodInfoPtr__BuyWithCurrentTarget_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, 100687442);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass13_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892323, XrefRangeEnd = 892331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BuyWithCurrentTarget_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BuyWithCurrentTarget_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass13_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_curFaction;

	private static readonly System.IntPtr NativeFieldInfoPtr_curFactionJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_curCharacter;

	private static readonly System.IntPtr NativeFieldInfoPtr_curFactionFame;

	private static readonly System.IntPtr NativeFieldInfoPtr_curTreasury;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPersonalStore;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasBuy;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSell;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopCurrencyType;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopTokenId;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstGoodData;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTradingTarget_Public_Static_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCoinTypesInSpecialShop_Public_Static_List_1_FactionGoodsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyWithCurrentTarget_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SellWithCurrentTarget_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyItem_Public_Static_Void_FactionGoodItem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxCountCanBuy_Public_Static_Int32_FactionGoodItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SellItem_Public_Static_Void_GameItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSellUnitPrice_Public_Static_Int32_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxCountCanSell_Public_Static_Int32_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndBuy_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSell_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTradingExpToPlayer_Private_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static FactionInstance curFaction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curFaction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionInstance>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curFaction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance));
		}
	}

	public unsafe static FactionJobData curFactionJob
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curFactionJob, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionJobData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curFactionJob, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionJobData));
		}
	}

	public unsafe static GameCharacterInstance curCharacter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curCharacter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curCharacter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	public unsafe static FactionFameData curFactionFame
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curFactionFame, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionFameData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curFactionFame, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionFameData));
		}
	}

	public unsafe static GameItemPack curTreasury
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curTreasury, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curTreasury, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe static bool isPersonalStore
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPersonalStore, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPersonalStore, (void*)(&flag));
		}
	}

	public unsafe static bool hasBuy
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasBuy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasBuy, (void*)(&flag));
		}
	}

	public unsafe static bool hasSell
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasSell, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasSell, (void*)(&flag));
		}
	}

	public unsafe static ShopCurrencyType shopCurrencyType
	{
		get
		{
			Unsafe.SkipInit(out ShopCurrencyType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shopCurrencyType, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shopCurrencyType, (void*)(&shopCurrencyType));
		}
	}

	public unsafe static int shopTokenId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shopTokenId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shopTokenId, (void*)(&num));
		}
	}

	public unsafe static FactionGoodsData firstGoodData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_firstGoodData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionGoodsData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_firstGoodData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionGoodsData));
		}
	}

	static TradingWithFactionManager()
	{
		Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "TradingWithFactionManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr);
		NativeFieldInfoPtr_curFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "curFaction");
		NativeFieldInfoPtr_curFactionJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "curFactionJob");
		NativeFieldInfoPtr_curCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "curCharacter");
		NativeFieldInfoPtr_curFactionFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "curFactionFame");
		NativeFieldInfoPtr_curTreasury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "curTreasury");
		NativeFieldInfoPtr_isPersonalStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "isPersonalStore");
		NativeFieldInfoPtr_hasBuy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "hasBuy");
		NativeFieldInfoPtr_hasSell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "hasSell");
		NativeFieldInfoPtr_shopCurrencyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "shopCurrencyType");
		NativeFieldInfoPtr_shopTokenId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "shopTokenId");
		NativeFieldInfoPtr_firstGoodData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, "firstGoodData");
		NativeMethodInfoPtr_SetTradingTarget_Public_Static_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675161);
		NativeMethodInfoPtr_GetCoinTypesInSpecialShop_Public_Static_List_1_FactionGoodsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675162);
		NativeMethodInfoPtr_BuyWithCurrentTarget_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675163);
		NativeMethodInfoPtr_SellWithCurrentTarget_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675164);
		NativeMethodInfoPtr_BuyItem_Public_Static_Void_FactionGoodItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675165);
		NativeMethodInfoPtr_GetMaxCountCanBuy_Public_Static_Int32_FactionGoodItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675166);
		NativeMethodInfoPtr_SellItem_Public_Static_Void_GameItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675167);
		NativeMethodInfoPtr_GetSellUnitPrice_Public_Static_Int32_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675168);
		NativeMethodInfoPtr_GetMaxCountCanSell_Public_Static_Int32_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675169);
		NativeMethodInfoPtr_EndBuy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675170);
		NativeMethodInfoPtr_EndSell_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675171);
		NativeMethodInfoPtr_ApplyTradingExpToPlayer_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675172);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr, 100675173);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892391, RefRangeEnd = 892394, XrefRangeStart = 892331, XrefRangeEnd = 892391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTradingTarget(GameCharacterInstance gameCharacterInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTradingTarget_Public_Static_Void_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 892438, RefRangeEnd = 892439, XrefRangeStart = 892394, XrefRangeEnd = 892438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<FactionGoodsData> GetCoinTypesInSpecialShop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCoinTypesInSpecialShop_Public_Static_List_1_FactionGoodsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionGoodsData>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 892568, RefRangeEnd = 892570, XrefRangeStart = 892439, XrefRangeEnd = 892568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuyWithCurrentTarget(bool instantOpenUi = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instantOpenUi);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyWithCurrentTarget_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 892605, RefRangeEnd = 892606, XrefRangeStart = 892570, XrefRangeEnd = 892605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SellWithCurrentTarget()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellWithCurrentTarget_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892652, RefRangeEnd = 892655, XrefRangeStart = 892606, XrefRangeEnd = 892652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuyItem(FactionGoodItem factionGoodItem, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionGoodItem);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyItem_Public_Static_Void_FactionGoodItem_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892690, RefRangeEnd = 892693, XrefRangeStart = 892655, XrefRangeEnd = 892690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxCountCanBuy(FactionGoodItem factionGoodItem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionGoodItem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxCountCanBuy_Public_Static_Int32_FactionGoodItem_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892716, RefRangeEnd = 892719, XrefRangeStart = 892693, XrefRangeEnd = 892716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SellItem(GameItemInstance gameItemInstance, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellItem_Public_Static_Void_GameItemInstance_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892765, RefRangeEnd = 892768, XrefRangeStart = 892719, XrefRangeEnd = 892765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSellUnitPrice(GameItemInstance gameItemInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSellUnitPrice_Public_Static_Int32_GameItemInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892779, RefRangeEnd = 892782, XrefRangeStart = 892768, XrefRangeEnd = 892779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxCountCanSell(GameItemInstance gameItemInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxCountCanSell_Public_Static_Int32_GameItemInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 892821, RefRangeEnd = 892822, XrefRangeStart = 892782, XrefRangeEnd = 892821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndBuy()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndBuy_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 892861, RefRangeEnd = 892863, XrefRangeStart = 892822, XrefRangeEnd = 892861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndSell()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSell_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892863, XrefRangeEnd = 892898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyTradingExpToPlayer(int coin, bool isBuy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&coin);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBuy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTradingExpToPlayer_Private_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892898, XrefRangeEnd = 892904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TradingWithFactionManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradingWithFactionManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TradingWithFactionManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
