using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class SaveObjectPlayerTeam : SaveObjectBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mapId;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_loyalToFactionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_confirmedRedDotSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTeamInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPet;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPetState;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPetAdventureRtnTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastBuffTickByQuarter;

	private static readonly System.IntPtr NativeFieldInfoPtr__teamBuffLib_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__teamLeaderBuffLib_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastStaminaTickByQuarter;

	private static readonly System.IntPtr NativeFieldInfoPtr_storedStaminaOdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMoodCheckedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextMoodAutoDec;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextMoodStaminaDec;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPetStuffedCheckTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_learntRecipes;

	private static readonly System.IntPtr NativeFieldInfoPtr__teamProps_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_tilesRoamingToday;

	private static readonly System.IntPtr NativeFieldInfoPtr_expGainedToday;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRoamingDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_tilesRoamingTodayForMapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_expGainedTodayForMapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedPlayerHudTextForPlayerCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterRelationModifyByTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionFameModifyByTraits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_teamBuffLib_Public_get_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_teamBuffLib_Private_set_Void_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_teamLeaderBuffLib_Public_get_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_teamLeaderBuffLib_Private_set_Void_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_teamProps_Public_get_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_teamProps_Private_set_Void_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SamplePlayerPos_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInventoryItemChanged_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInventoryItemGet_Public_Void_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInventoryItemLost_Public_Void_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInventoryItemModify_Public_Void_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInventoryCurrencyChanged_Public_Void_CurrencyType_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffTickByQuarter_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoamingATile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int mapId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapId)) = num;
		}
	}

	public unsafe Vector3Int teamPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamPos)) = vector3Int;
		}
	}

	public unsafe TileDirection teamDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamDir);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamDir)) = tileDirection;
		}
	}

	public unsafe int loyalToFactionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loyalToFactionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loyalToFactionID)) = num;
		}
	}

	public unsafe List<int> playerTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTeam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTeam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<int> confirmedRedDotSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmedRedDotSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmedRedDotSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe GameItemPack playerTeamInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTeamInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTeamInventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe int playerPet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPet)) = num;
		}
	}

	public unsafe PlayerTeamManager.PlayerPetState playerPetState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPetState);
			return *(PlayerTeamManager.PlayerPetState*)num;
		}
		set
		{
			*(PlayerTeamManager.PlayerPetState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPetState)) = playerPetState;
		}
	}

	public unsafe int playerPetAdventureRtnTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPetAdventureRtnTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPetAdventureRtnTime)) = num;
		}
	}

	public unsafe int lastBuffTickByQuarter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBuffTickByQuarter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBuffTickByQuarter)) = num;
		}
	}

	public unsafe BuffLib _teamBuffLib_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamBuffLib_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamBuffLib_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffLib));
		}
	}

	public unsafe BuffLib _teamLeaderBuffLib_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamLeaderBuffLib_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamLeaderBuffLib_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffLib));
		}
	}

	public unsafe int lastStaminaTickByQuarter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStaminaTickByQuarter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStaminaTickByQuarter)) = num;
		}
	}

	public unsafe Il2CppSystem.Decimal storedStaminaOdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedStaminaOdd);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedStaminaOdd)) = obj;
		}
	}

	public unsafe int lastMoodCheckedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMoodCheckedTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMoodCheckedTime)) = num;
		}
	}

	public unsafe int nextMoodAutoDec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMoodAutoDec);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMoodAutoDec)) = num;
		}
	}

	public unsafe int nextMoodStaminaDec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMoodStaminaDec);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMoodStaminaDec)) = num;
		}
	}

	public unsafe int lastPetStuffedCheckTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPetStuffedCheckTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPetStuffedCheckTime)) = num;
		}
	}

	public unsafe List<int> learntRecipes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_learntRecipes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_learntRecipes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> _teamProps_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamProps_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamProps_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int tilesRoamingToday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tilesRoamingToday);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tilesRoamingToday)) = num;
		}
	}

	public unsafe int expGainedToday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expGainedToday);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expGainedToday)) = num;
		}
	}

	public unsafe int lastRoamingDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRoamingDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRoamingDay)) = num;
		}
	}

	public unsafe int tilesRoamingTodayForMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tilesRoamingTodayForMapping);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tilesRoamingTodayForMapping)) = num;
		}
	}

	public unsafe int expGainedTodayForMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expGainedTodayForMapping);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expGainedTodayForMapping)) = num;
		}
	}

	public unsafe List<string> cachedPlayerHudTextForPlayerCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedPlayerHudTextForPlayerCreate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedPlayerHudTextForPlayerCreate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ShortcutItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, int> characterRelationModifyByTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterRelationModifyByTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterRelationModifyByTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, int> factionFameModifyByTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionFameModifyByTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionFameModifyByTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe BuffLib teamBuffLib
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_teamBuffLib_Public_get_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_teamBuffLib_Private_set_Void_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe BuffLib teamLeaderBuffLib
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_teamLeaderBuffLib_Public_get_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_teamLeaderBuffLib_Private_set_Void_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> teamProps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_teamProps_Public_get_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_teamProps_Private_set_Void_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SaveObjectPlayerTeam()
	{
		Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectPlayerTeam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr);
		NativeFieldInfoPtr_mapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "mapId");
		NativeFieldInfoPtr_teamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "teamPos");
		NativeFieldInfoPtr_teamDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "teamDir");
		NativeFieldInfoPtr_loyalToFactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "loyalToFactionID");
		NativeFieldInfoPtr_playerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "playerTeam");
		NativeFieldInfoPtr_confirmedRedDotSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "confirmedRedDotSet");
		NativeFieldInfoPtr_playerTeamInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "playerTeamInventory");
		NativeFieldInfoPtr_playerPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "playerPet");
		NativeFieldInfoPtr_playerPetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "playerPetState");
		NativeFieldInfoPtr_playerPetAdventureRtnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "playerPetAdventureRtnTime");
		NativeFieldInfoPtr_lastBuffTickByQuarter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "lastBuffTickByQuarter");
		NativeFieldInfoPtr__teamBuffLib_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "<teamBuffLib>k__BackingField");
		NativeFieldInfoPtr__teamLeaderBuffLib_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "<teamLeaderBuffLib>k__BackingField");
		NativeFieldInfoPtr_lastStaminaTickByQuarter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "lastStaminaTickByQuarter");
		NativeFieldInfoPtr_storedStaminaOdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "storedStaminaOdd");
		NativeFieldInfoPtr_lastMoodCheckedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "lastMoodCheckedTime");
		NativeFieldInfoPtr_nextMoodAutoDec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "nextMoodAutoDec");
		NativeFieldInfoPtr_nextMoodStaminaDec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "nextMoodStaminaDec");
		NativeFieldInfoPtr_lastPetStuffedCheckTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "lastPetStuffedCheckTime");
		NativeFieldInfoPtr_learntRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "learntRecipes");
		NativeFieldInfoPtr__teamProps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "<teamProps>k__BackingField");
		NativeFieldInfoPtr_tilesRoamingToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "tilesRoamingToday");
		NativeFieldInfoPtr_expGainedToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "expGainedToday");
		NativeFieldInfoPtr_lastRoamingDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "lastRoamingDay");
		NativeFieldInfoPtr_tilesRoamingTodayForMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "tilesRoamingTodayForMapping");
		NativeFieldInfoPtr_expGainedTodayForMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "expGainedTodayForMapping");
		NativeFieldInfoPtr_cachedPlayerHudTextForPlayerCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "cachedPlayerHudTextForPlayerCreate");
		NativeFieldInfoPtr_ShortcutItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "ShortcutItems");
		NativeFieldInfoPtr_characterRelationModifyByTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "characterRelationModifyByTraits");
		NativeFieldInfoPtr_factionFameModifyByTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, "factionFameModifyByTraits");
		NativeMethodInfoPtr_get_teamBuffLib_Public_get_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673703);
		NativeMethodInfoPtr_set_teamBuffLib_Private_set_Void_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673704);
		NativeMethodInfoPtr_get_teamLeaderBuffLib_Public_get_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673705);
		NativeMethodInfoPtr_set_teamLeaderBuffLib_Private_set_Void_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673706);
		NativeMethodInfoPtr_get_teamProps_Public_get_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673707);
		NativeMethodInfoPtr_set_teamProps_Private_set_Void_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673708);
		NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673709);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673710);
		NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673711);
		NativeMethodInfoPtr_SamplePlayerPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673712);
		NativeMethodInfoPtr_OnInventoryItemChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673713);
		NativeMethodInfoPtr_OnInventoryItemGet_Public_Void_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673714);
		NativeMethodInfoPtr_OnInventoryItemLost_Public_Void_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673715);
		NativeMethodInfoPtr_OnInventoryItemModify_Public_Void_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673716);
		NativeMethodInfoPtr_OnInventoryCurrencyChanged_Public_Void_CurrencyType_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673717);
		NativeMethodInfoPtr_BuffTickByQuarter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673718);
		NativeMethodInfoPtr_RoamingATile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673719);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr, 100673720);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848975, XrefRangeEnd = 849008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Save(bool sync = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sync);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849008, XrefRangeEnd = 849012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849012, XrefRangeEnd = 849056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 849085, RefRangeEnd = 849088, XrefRangeStart = 849056, XrefRangeEnd = 849085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SamplePlayerPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SamplePlayerPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849088, XrefRangeEnd = 849149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInventoryItemChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInventoryItemChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849149, XrefRangeEnd = 849174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInventoryItemGet(GameItemInstance gameItemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInventoryItemGet_Public_Void_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849174, XrefRangeEnd = 849178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInventoryItemLost(GameItemInstance gameItemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInventoryItemLost_Public_Void_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849178, XrefRangeEnd = 849182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInventoryItemModify(GameItemInstance gameItemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInventoryItemModify_Public_Void_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849182, XrefRangeEnd = 849223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInventoryCurrencyChanged(CurrencyType type, long newVal, long changed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVal;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInventoryCurrencyChanged_Public_Void_CurrencyType_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 849237, RefRangeEnd = 849238, XrefRangeStart = 849223, XrefRangeEnd = 849237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffTickByQuarter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffTickByQuarter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 849322, RefRangeEnd = 849323, XrefRangeStart = 849238, XrefRangeEnd = 849322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RoamingATile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoamingATile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849323, XrefRangeEnd = 849377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectPlayerTeam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectPlayerTeam>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectPlayerTeam(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
