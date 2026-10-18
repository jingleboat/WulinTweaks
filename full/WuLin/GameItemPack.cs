using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class GameItemPack : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("WuLin.GameItemPack+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetContentsByType_b__40_0_Internal_Int32_GameItemInstance_GameItemInstance_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<GameItemInstance> __9__40_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<GameItemInstance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__40_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__40_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686603);
			NativeMethodInfoPtr__GetContentsByType_b__40_0_Internal_Int32_GameItemInstance_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686604);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817697, XrefRangeEnd = 817700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetContentsByType_b__40_0(GameItemInstance x, GameItemInstance y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetContentsByType_b__40_0_Internal_Int32_GameItemInstance_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_onItemChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_onCurrencyChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_onSingleCurrencyChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_onItemGet;

	private static readonly System.IntPtr NativeFieldInfoPtr_onItemLost;

	private static readonly System.IntPtr NativeFieldInfoPtr_onItemModify;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_capacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_contents;

	private static readonly System.IntPtr NativeFieldInfoPtr_currencies;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsFromTemplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_onMergeIntoInventory;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Contents_Public_get_List_1_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Currencies_Public_get_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemBoxData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSpace_Public_Boolean_GameItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSpace_Public_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSpace_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSpace_Public_Boolean_ItemData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Boolean_GameItemInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Boolean_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Boolean_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Boolean_ItemData_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItemAsIndependent_Public_Boolean_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_GameItemInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_GameItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_GameItemInstance_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Boolean_GameItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Boolean_ItemData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TakeItemFromLib_Public_GameItemInstance_GameItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveItemTo_Public_Boolean_GameItemInstance_GameItemPack_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCountByType_Public_Int32_ItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCountById_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCountByUname_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContentsByType_Public_List_1_GameItemInstance_ItemType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContentsByMask_Public_List_1_GameItemInstance_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContentsByMatchOneFavTag_Public_List_1_GameItemInstance_HashSet_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanInvalidItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrency_Public_Int64_CurrencyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrencyType_Public_Static_CurrencyType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrency_Public_Boolean_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrency_Public_Boolean_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCurrency_Public_Boolean_CurrencyType_Int64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCurrency_Public_Boolean_KeyWithValues_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrency_Public_Void_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalValue_Public_Int64_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalValueWithCharacterFond_Public_Int64_GameCharacterInstance_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveCurrencyTo_Public_Boolean_CurrencyType_GameItemPack_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeInto_Public_Void_GameItemPack_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndRemoveInvalidItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportItemsFromTempleteData_Public_Void_Il2CppReferenceArray_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOnMergeIntoInventory_Public_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_Int32_GameCharacterInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_String_GameCharacterInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_GameItemInstance_GameCharacterInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_Int32_BattleActor_BattleActor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_String_BattleActor_BattleActor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_GameItemInstance_BattleActor_BattleActor_Int32_Boolean_0;

	public unsafe Il2CppSystem.Action onItemChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action onCurrencyChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCurrencyChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCurrencyChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<CurrencyType, long, long> onSingleCurrencyChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSingleCurrencyChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CurrencyType, long, long>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSingleCurrencyChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<GameItemInstance> onItemGet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemGet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemGet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<GameItemInstance> onItemLost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemLost);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemLost)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<GameItemInstance> onItemModify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemModify);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onItemModify)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe int m_capacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_capacity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_capacity)) = num;
		}
	}

	public unsafe List<GameItemInstance> contents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<CurrencyType, long> currencies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currencies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currencies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, int> itemsFromTemplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsFromTemplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsFromTemplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppSystem.Action onMergeIntoInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onMergeIntoInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onMergeIntoInventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe int Capacity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<GameItemInstance> Contents
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 817706, RefRangeEnd = 817768, XrefRangeStart = 817700, XrefRangeEnd = 817706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Contents_Public_get_List_1_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
		}
	}

	public unsafe Dictionary<CurrencyType, long> Currencies
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 817774, RefRangeEnd = 817799, XrefRangeStart = 817768, XrefRangeEnd = 817774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Currencies_Public_get_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
		}
	}

	static GameItemPack()
	{
		Il2CppClassPointerStore<GameItemPack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameItemPack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr);
		NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onItemChanged");
		NativeFieldInfoPtr_onCurrencyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onCurrencyChanged");
		NativeFieldInfoPtr_onSingleCurrencyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onSingleCurrencyChanged");
		NativeFieldInfoPtr_onItemGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onItemGet");
		NativeFieldInfoPtr_onItemLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onItemLost");
		NativeFieldInfoPtr_onItemModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onItemModify");
		NativeFieldInfoPtr_m_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "m_capacity");
		NativeFieldInfoPtr_contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "contents");
		NativeFieldInfoPtr_currencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "currencies");
		NativeFieldInfoPtr_itemsFromTemplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "itemsFromTemplete");
		NativeFieldInfoPtr_onMergeIntoInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, "onMergeIntoInventory");
		NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672676);
		NativeMethodInfoPtr_get_Contents_Public_get_List_1_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672677);
		NativeMethodInfoPtr_get_Currencies_Public_get_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672678);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672679);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672680);
		NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672681);
		NativeMethodInfoPtr_HasSpace_Public_Boolean_GameItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672682);
		NativeMethodInfoPtr_HasSpace_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672683);
		NativeMethodInfoPtr_HasSpace_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672684);
		NativeMethodInfoPtr_HasSpace_Public_Boolean_ItemData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672685);
		NativeMethodInfoPtr_AddItem_Public_Boolean_GameItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672686);
		NativeMethodInfoPtr_AddItem_Public_Boolean_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672687);
		NativeMethodInfoPtr_AddItem_Public_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672688);
		NativeMethodInfoPtr_AddItem_Public_Boolean_ItemData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672689);
		NativeMethodInfoPtr_AddItemAsIndependent_Public_Boolean_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672690);
		NativeMethodInfoPtr_GetItem_Public_GameItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672691);
		NativeMethodInfoPtr_GetItem_Public_GameItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672692);
		NativeMethodInfoPtr_GetItem_Public_GameItemInstance_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672693);
		NativeMethodInfoPtr_RemoveItem_Public_Boolean_GameItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672694);
		NativeMethodInfoPtr_RemoveItem_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672695);
		NativeMethodInfoPtr_RemoveItem_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672696);
		NativeMethodInfoPtr_RemoveItem_Public_Boolean_ItemData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672697);
		NativeMethodInfoPtr_TakeItemFromLib_Public_GameItemInstance_GameItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672698);
		NativeMethodInfoPtr_GiveItemTo_Public_Boolean_GameItemInstance_GameItemPack_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672699);
		NativeMethodInfoPtr_GetItemCountByType_Public_Int32_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672700);
		NativeMethodInfoPtr_GetItemCountById_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672701);
		NativeMethodInfoPtr_GetItemCountByUname_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672702);
		NativeMethodInfoPtr_GetContentsByType_Public_List_1_GameItemInstance_ItemType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672703);
		NativeMethodInfoPtr_GetContentsByMask_Public_List_1_GameItemInstance_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672704);
		NativeMethodInfoPtr_GetContentsByMatchOneFavTag_Public_List_1_GameItemInstance_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672705);
		NativeMethodInfoPtr_CleanInvalidItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672706);
		NativeMethodInfoPtr_GetCurrency_Public_Int64_CurrencyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672707);
		NativeMethodInfoPtr_GetCurrencyType_Public_Static_CurrencyType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672708);
		NativeMethodInfoPtr_HasCurrency_Public_Boolean_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672709);
		NativeMethodInfoPtr_HasCurrency_Public_Boolean_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672710);
		NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672711);
		NativeMethodInfoPtr_ChangeCurrency_Public_Boolean_CurrencyType_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672712);
		NativeMethodInfoPtr_ChangeCurrency_Public_Boolean_KeyWithValues_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672713);
		NativeMethodInfoPtr_ChangeCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672714);
		NativeMethodInfoPtr_SetCurrency_Public_Void_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672715);
		NativeMethodInfoPtr_GetTotalValue_Public_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672716);
		NativeMethodInfoPtr_GetTotalValueWithCharacterFond_Public_Int64_GameCharacterInstance_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672717);
		NativeMethodInfoPtr_GiveCurrencyTo_Public_Boolean_CurrencyType_GameItemPack_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672718);
		NativeMethodInfoPtr_MergeInto_Public_Void_GameItemPack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672719);
		NativeMethodInfoPtr_ClearAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672720);
		NativeMethodInfoPtr_CheckAndRemoveInvalidItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672721);
		NativeMethodInfoPtr_ImportItemsFromTempleteData_Public_Void_Il2CppReferenceArray_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672722);
		NativeMethodInfoPtr_SetOnMergeIntoInventory_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672723);
		NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_Int32_GameCharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672724);
		NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_String_GameCharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672725);
		NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_GameItemInstance_GameCharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672726);
		NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_Int32_BattleActor_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672727);
		NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_String_BattleActor_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672728);
		NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_GameItemInstance_BattleActor_BattleActor_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr, 100672729);
	}

	[CallerCount(83)]
	[CachedScanResults(RefRangeStart = 817818, RefRangeEnd = 817901, XrefRangeStart = 817799, XrefRangeEnd = 817818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 817920, RefRangeEnd = 817925, XrefRangeStart = 817901, XrefRangeEnd = 817920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack(int capacity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 817961, RefRangeEnd = 817964, XrefRangeStart = 817925, XrefRangeEnd = 817961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack(List<InteractiveObject.ItemBoxData> itemBoxDatas)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameItemPack>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemBoxDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemBoxData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 817969, RefRangeEnd = 817971, XrefRangeStart = 817964, XrefRangeEnd = 817969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSpace(GameItemInstance gameItemInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSpace_Public_Boolean_GameItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817971, XrefRangeEnd = 817986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSpace(string itemName, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSpace_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817986, XrefRangeEnd = 818001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSpace(int itemId, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&itemId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSpace_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 818004, RefRangeEnd = 818008, XrefRangeStart = 818001, XrefRangeEnd = 818004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSpace(ItemData itemData, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSpace_Public_Boolean_ItemData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 818021, RefRangeEnd = 818060, XrefRangeStart = 818008, XrefRangeEnd = 818021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddItem(GameItemInstance gameItemInstance, bool needCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCheck;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItem_Public_Boolean_GameItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 818076, RefRangeEnd = 818088, XrefRangeStart = 818060, XrefRangeEnd = 818076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddItem(string itemName, int count = 1, bool needCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCheck;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItem_Public_Boolean_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 818104, RefRangeEnd = 818122, XrefRangeStart = 818088, XrefRangeEnd = 818104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddItem(int itemId, int count = 1, bool needCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&itemId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCheck;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItem_Public_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 818189, RefRangeEnd = 818203, XrefRangeStart = 818122, XrefRangeEnd = 818189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddItem(ItemData itemData, int count = 1, bool needCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCheck;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItem_Public_Boolean_ItemData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 818212, RefRangeEnd = 818215, XrefRangeStart = 818203, XrefRangeEnd = 818212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddItemAsIndependent(GameItemInstance gameItemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItemAsIndependent_Public_Boolean_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 818230, RefRangeEnd = 818235, XrefRangeStart = 818215, XrefRangeEnd = 818230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance GetItem(string itemName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_GameItemInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 818250, RefRangeEnd = 818261, XrefRangeStart = 818235, XrefRangeEnd = 818250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance GetItem(int itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_GameItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 818284, RefRangeEnd = 818287, XrefRangeStart = 818261, XrefRangeEnd = 818284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance GetItem(ItemData itemData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_GameItemInstance_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 818311, RefRangeEnd = 818329, XrefRangeStart = 818287, XrefRangeEnd = 818311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveItem(GameItemInstance gameItemInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Boolean_GameItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818329, XrefRangeEnd = 818331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveItem(string itemName, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 818333, RefRangeEnd = 818338, XrefRangeStart = 818331, XrefRangeEnd = 818333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveItem(int itemId, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&itemId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 818340, RefRangeEnd = 818345, XrefRangeStart = 818338, XrefRangeEnd = 818340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveItem(ItemData itemData, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Boolean_ItemData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 818366, RefRangeEnd = 818370, XrefRangeStart = 818345, XrefRangeEnd = 818366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance TakeItemFromLib(GameItemInstance gameItemInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TakeItemFromLib_Public_GameItemInstance_GameItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 818390, RefRangeEnd = 818402, XrefRangeStart = 818370, XrefRangeEnd = 818390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GiveItemTo(GameItemInstance gameItemInstance, GameItemPack other, int count = 1, bool needCheckOtherSpace = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCheckOtherSpace;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveItemTo_Public_Boolean_GameItemInstance_GameItemPack_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818402, XrefRangeEnd = 818424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemCountByType(ItemType itemType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemCountByType_Public_Int32_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 818440, RefRangeEnd = 818480, XrefRangeStart = 818424, XrefRangeEnd = 818440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemCountById(int uid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemCountById_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818480, XrefRangeEnd = 818497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemCountByUname(string uName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemCountByUname_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 818546, RefRangeEnd = 818558, XrefRangeStart = 818497, XrefRangeEnd = 818546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameItemInstance> GetContentsByType(ItemType itemType, bool isSorted = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&itemType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSorted;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContentsByType_Public_List_1_GameItemInstance_ItemType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818558, XrefRangeEnd = 818589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameItemInstance> GetContentsByMask(long mask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContentsByMask_Public_List_1_GameItemInstance_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 818621, RefRangeEnd = 818625, XrefRangeStart = 818589, XrefRangeEnd = 818621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameItemInstance> GetContentsByMatchOneFavTag(HashSet<string> favTags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)favTags);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContentsByMatchOneFavTag_Public_List_1_GameItemInstance_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818625, XrefRangeEnd = 818645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanInvalidItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanInvalidItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(77)]
	[CachedScanResults(RefRangeStart = 818655, RefRangeEnd = 818732, XrefRangeStart = 818645, XrefRangeEnd = 818655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetCurrency(CurrencyType currency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currency);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrency_Public_Int64_CurrencyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 818742, RefRangeEnd = 818750, XrefRangeStart = 818732, XrefRangeEnd = 818742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CurrencyType GetCurrencyType(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrencyType_Public_Static_CurrencyType_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CurrencyType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 818751, RefRangeEnd = 818759, XrefRangeStart = 818750, XrefRangeEnd = 818751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrency(CurrencyType currency, long value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currency);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrency_Public_Boolean_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 818763, RefRangeEnd = 818764, XrefRangeStart = 818759, XrefRangeEnd = 818763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrency(KeyWithValues currency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currency);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrency_Public_Boolean_KeyWithValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818764, XrefRangeEnd = 818769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrencies(Il2CppReferenceArray<KeyWithValues> currencies)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currencies);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 818775, RefRangeEnd = 818846, XrefRangeStart = 818769, XrefRangeEnd = 818775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangeCurrency(CurrencyType currency, long value, bool canBeNeg = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&currency);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNeg;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCurrency_Public_Boolean_CurrencyType_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 818850, RefRangeEnd = 818854, XrefRangeStart = 818846, XrefRangeEnd = 818850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangeCurrency(KeyWithValues currency, bool canBeNeg = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currency);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNeg;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCurrency_Public_Boolean_KeyWithValues_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 818859, RefRangeEnd = 818862, XrefRangeStart = 818854, XrefRangeEnd = 818859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangeCurrencies(Il2CppReferenceArray<KeyWithValues> currencies, bool canBeNeg = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currencies);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNeg;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 818878, RefRangeEnd = 818888, XrefRangeStart = 818862, XrefRangeEnd = 818878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrency(CurrencyType currency, long value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currency);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrency_Public_Void_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 818910, RefRangeEnd = 818916, XrefRangeStart = 818888, XrefRangeEnd = 818910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetTotalValue(float valueRate = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalValue_Public_Int64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 818950, RefRangeEnd = 818952, XrefRangeStart = 818916, XrefRangeEnd = 818950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetTotalValueWithCharacterFond(GameCharacterInstance characterInstance, [Optional] Il2CppSystem.Decimal defaultValueRate, [Optional] Il2CppSystem.Decimal fondValueRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInstance);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValueRate;
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fondValueRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalValueWithCharacterFond_Public_Int64_GameCharacterInstance_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 818958, RefRangeEnd = 818964, XrefRangeStart = 818952, XrefRangeEnd = 818958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GiveCurrencyTo(CurrencyType currencyType, GameItemPack other, long value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&currencyType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveCurrencyTo_Public_Boolean_CurrencyType_GameItemPack_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 819037, RefRangeEnd = 819056, XrefRangeStart = 818964, XrefRangeEnd = 819037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeInto(GameItemPack other, bool needCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCheck;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeInto_Public_Void_GameItemPack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 819145, RefRangeEnd = 819153, XrefRangeStart = 819056, XrefRangeEnd = 819145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 819173, RefRangeEnd = 819175, XrefRangeStart = 819153, XrefRangeEnd = 819173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAndRemoveInvalidItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndRemoveInvalidItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 819205, RefRangeEnd = 819211, XrefRangeStart = 819175, XrefRangeEnd = 819205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportItemsFromTempleteData(Il2CppReferenceArray<KeyWithValues> keyWithValues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportItemsFromTempleteData_Public_Void_Il2CppReferenceArray_1_KeyWithValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819211, XrefRangeEnd = 819214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOnMergeIntoInventory(Il2CppSystem.Action action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnMergeIntoInventory_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819214, XrefRangeEnd = 819216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseItemOnCharacter(int id, GameCharacterInstance gameCharacterInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_Int32_GameCharacterInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819216, XrefRangeEnd = 819218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseItemOnCharacter(string name, GameCharacterInstance gameCharacterInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_String_GameCharacterInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 819227, RefRangeEnd = 819233, XrefRangeStart = 819218, XrefRangeEnd = 819227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseItemOnCharacter(GameItemInstance gameItemInstance, GameCharacterInstance gameCharacterInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItemOnCharacter_Public_Boolean_GameItemInstance_GameCharacterInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819233, XrefRangeEnd = 819242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseItemOnBattleActor(int id, BattleActor battleActor, BattleActor caster, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_Int32_BattleActor_BattleActor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819242, XrefRangeEnd = 819251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseItemOnBattleActor(string name, BattleActor battleActor, BattleActor caster, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_String_BattleActor_BattleActor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 819259, RefRangeEnd = 819260, XrefRangeStart = 819251, XrefRangeEnd = 819259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseItemOnBattleActor(GameItemInstance gameItemInstance, BattleActor battleActor, BattleActor caster, int count = 1, bool consumeItem = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &consumeItem;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItemOnBattleActor_Public_Boolean_GameItemInstance_BattleActor_BattleActor_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GameItemPack(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
