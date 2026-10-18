using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class FiefUnsharedData : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("WuLin.FiefUnsharedData+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Init_b__16_0_Internal_Int32_FiefScorePrizeConfig_FiefScorePrizeConfig_0;

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

		public unsafe static Il2CppSystem.Comparison<FiefScorePrizeConfig> __9__16_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<FiefScorePrizeConfig>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__16_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__16_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686927);
			NativeMethodInfoPtr__Init_b__16_0_Internal_Int32_FiefScorePrizeConfig_FiefScorePrizeConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686928);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847571, XrefRangeEnd = 847573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _Init_b__16_0(FiefScorePrizeConfig x, FiefScorePrizeConfig y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Init_b__16_0_Internal_Int32_FiefScorePrizeConfig_FiefScorePrizeConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_BACK_MT_BUILDING_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPrivateFief;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefName;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefOpened;

	private static readonly System.IntPtr NativeFieldInfoPtr_takenKungfuBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_takenItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_workingCharDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterToWorkingPosDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_activedBuildingBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_backMtResCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefCouldTeleportLeave;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefTeleportLeaveMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefTeleportLeavePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsInited;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveIdToBuildingIdDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefAddCharacter_Public_Boolean_Int32_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefRemoveCharacter_Public_Boolean_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefCaculateBuildingScore_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountBackMtResIncome_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFiefBuildingBonusChange_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefGetAllCharactersByBuildingIdRaw_Public_List_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefGetAllCharactersByBuildingId_Public_List_1_GameCharacterInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFiefKungfuBookTaken_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFiefItemTaken_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int BACK_MT_BUILDING_ID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BACK_MT_BUILDING_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BACK_MT_BUILDING_ID, (void*)(&num));
		}
	}

	public unsafe bool isPrivateFief
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrivateFief);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrivateFief)) = flag;
		}
	}

	public unsafe string fiefName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool fiefOpened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefOpened);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefOpened)) = flag;
		}
	}

	public unsafe List<int> takenKungfuBook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takenKungfuBook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takenKungfuBook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> takenItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takenItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takenItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, List<int>> workingCharDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingCharDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingCharDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, int> characterToWorkingPosDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterToWorkingPosDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterToWorkingPosDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, List<FiefScorePrizeConfig>> buildingBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<FiefScorePrizeConfig>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingBonus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, int> activedBuildingBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activedBuildingBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activedBuildingBonus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int backMtResCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backMtResCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backMtResCount)) = num;
		}
	}

	public unsafe bool fiefCouldTeleportLeave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefCouldTeleportLeave);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefCouldTeleportLeave)) = flag;
		}
	}

	public unsafe int fiefTeleportLeaveMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefTeleportLeaveMap);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefTeleportLeaveMap)) = num;
		}
	}

	public unsafe Vector3Int fiefTeleportLeavePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefTeleportLeavePos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefTeleportLeavePos)) = vector3Int;
		}
	}

	public unsafe bool m_IsInited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsInited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsInited)) = flag;
		}
	}

	public unsafe Dictionary<int, int> saveIdToBuildingIdDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveIdToBuildingIdDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveIdToBuildingIdDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static FiefUnsharedData()
	{
		Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "FiefUnsharedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr);
		NativeFieldInfoPtr_BACK_MT_BUILDING_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "BACK_MT_BUILDING_ID");
		NativeFieldInfoPtr_isPrivateFief = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "isPrivateFief");
		NativeFieldInfoPtr_fiefName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "fiefName");
		NativeFieldInfoPtr_fiefOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "fiefOpened");
		NativeFieldInfoPtr_takenKungfuBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "takenKungfuBook");
		NativeFieldInfoPtr_takenItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "takenItems");
		NativeFieldInfoPtr_workingCharDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "workingCharDict");
		NativeFieldInfoPtr_characterToWorkingPosDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "characterToWorkingPosDict");
		NativeFieldInfoPtr_buildingBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "buildingBonus");
		NativeFieldInfoPtr_activedBuildingBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "activedBuildingBonus");
		NativeFieldInfoPtr_backMtResCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "backMtResCount");
		NativeFieldInfoPtr_fiefCouldTeleportLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "fiefCouldTeleportLeave");
		NativeFieldInfoPtr_fiefTeleportLeaveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "fiefTeleportLeaveMap");
		NativeFieldInfoPtr_fiefTeleportLeavePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "fiefTeleportLeavePos");
		NativeFieldInfoPtr_m_IsInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "m_IsInited");
		NativeFieldInfoPtr_saveIdToBuildingIdDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, "saveIdToBuildingIdDict");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673616);
		NativeMethodInfoPtr_FiefAddCharacter_Public_Boolean_Int32_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673617);
		NativeMethodInfoPtr_FiefRemoveCharacter_Public_Boolean_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673618);
		NativeMethodInfoPtr_FiefCaculateBuildingScore_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673619);
		NativeMethodInfoPtr_CountBackMtResIncome_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673620);
		NativeMethodInfoPtr_IsFiefBuildingBonusChange_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673621);
		NativeMethodInfoPtr_FiefGetAllCharactersByBuildingIdRaw_Public_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673622);
		NativeMethodInfoPtr_FiefGetAllCharactersByBuildingId_Public_List_1_GameCharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673623);
		NativeMethodInfoPtr_IsFiefKungfuBookTaken_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673624);
		NativeMethodInfoPtr_IsFiefItemTaken_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673625);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr, 100673626);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847711, RefRangeEnd = 847712, XrefRangeStart = 847573, XrefRangeEnd = 847711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847739, RefRangeEnd = 847740, XrefRangeStart = 847712, XrefRangeEnd = 847739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FiefAddCharacter(int buildingId, GameCharacterInstance gameCharacterInstance, bool calculateBonus = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buildingId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &calculateBonus;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefAddCharacter_Public_Boolean_Int32_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847764, RefRangeEnd = 847766, XrefRangeStart = 847740, XrefRangeEnd = 847764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FiefRemoveCharacter(GameCharacterInstance gameCharacterInstance, bool calculateBonus = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &calculateBonus;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefRemoveCharacter_Public_Boolean_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847766, XrefRangeEnd = 847774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FiefCaculateBuildingScore(int buildingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefCaculateBuildingScore_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 847801, RefRangeEnd = 847804, XrefRangeStart = 847774, XrefRangeEnd = 847801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CountBackMtResIncome()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountBackMtResIncome_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847828, RefRangeEnd = 847829, XrefRangeStart = 847804, XrefRangeEnd = 847828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFiefBuildingBonusChange(int buildingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFiefBuildingBonusChange_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847841, RefRangeEnd = 847842, XrefRangeStart = 847829, XrefRangeEnd = 847841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> FiefGetAllCharactersByBuildingIdRaw(int buildingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefGetAllCharactersByBuildingIdRaw_Public_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847882, RefRangeEnd = 847884, XrefRangeStart = 847842, XrefRangeEnd = 847882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameCharacterInstance> FiefGetAllCharactersByBuildingId(int buildingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefGetAllCharactersByBuildingId_Public_List_1_GameCharacterInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847888, RefRangeEnd = 847890, XrefRangeStart = 847884, XrefRangeEnd = 847888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFiefKungfuBookTaken(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFiefKungfuBookTaken_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847894, RefRangeEnd = 847896, XrefRangeStart = 847890, XrefRangeEnd = 847894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFiefItemTaken(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFiefItemTaken_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847935, RefRangeEnd = 847937, XrefRangeStart = 847896, XrefRangeEnd = 847935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FiefUnsharedData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FiefUnsharedData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FiefUnsharedData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
