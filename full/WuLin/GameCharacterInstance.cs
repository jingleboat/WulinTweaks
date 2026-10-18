using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

[System.Serializable]
public class GameCharacterInstance : Il2CppSystem.Object
{
	public enum EquipingCheckResult
	{
		Ok = 0,
		ItemInvalid = 1,
		PropNotMatch = 2,
		KungfuMaxLevel = 3,
		CharacterMaxKungfuCount = 4,
		SlgModeAlreadyLearnt = 10
	}

	public class ExpSpecifyTarget : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_useBuffMultiply;

		private static readonly System.IntPtr NativeFieldInfoPtr_isLevelOnly;

		private static readonly System.IntPtr NativeFieldInfoPtr_specifyKungfuInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_zeroExpLogic;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool useBuffMultiply
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuffMultiply);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuffMultiply)) = flag;
			}
		}

		public unsafe bool isLevelOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLevelOnly);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLevelOnly)) = flag;
			}
		}

		public unsafe KungfuInstance specifyKungfuInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specifyKungfuInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specifyKungfuInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
			}
		}

		public unsafe bool zeroExpLogic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zeroExpLogic);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zeroExpLogic)) = flag;
			}
		}

		static ExpSpecifyTarget()
		{
			Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "ExpSpecifyTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr);
			NativeFieldInfoPtr_useBuffMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr, "useBuffMultiply");
			NativeFieldInfoPtr_isLevelOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr, "isLevelOnly");
			NativeFieldInfoPtr_specifyKungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr, "specifyKungfuInstance");
			NativeFieldInfoPtr_zeroExpLogic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr, "zeroExpLogic");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr, 100686597);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpSpecifyTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpSpecifyTarget>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ExpSpecifyTarget(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum PortraitType
	{
		Scenario,
		TeamPanel,
		Small,
		SpAttack,
		BondAttack,
		BondsUIHead
	}

	[System.Flags]
	public enum FinalPropSource
	{
		None = 0,
		Origin = 2,
		Addition = 4,
		Kungfu = 8,
		Buff = 0x10,
		Global = 0x20,
		Equip = 0x40,
		Tmp = 0x80,
		All = Origin | Addition | Kungfu | Buff | Global | Equip | Tmp
	}

	public enum EquipPenaltyType
	{
		Weapon,
		Armor
	}

	public enum RelationModifySource
	{
		Default,
		Gift,
		FactionLeader,
		Console,
		Trade,
		Buff,
		Story,
		PlayerAction,
		levelup
	}

	public enum ItemUsageChceckResult
	{
		OK,
		CantUse,
		CompareDataNotMatched,
		NotValid
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_BACKPACK_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasZzPointRedDot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TemporaryPropsIsDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EquipPropDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DirtyPropComputeNow;

	private static readonly System.IntPtr NativeFieldInfoPtr_altAvatar;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuRemoved;

	private static readonly System.IntPtr NativeFieldInfoPtr__ActivedUniqueKungfuId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsSitting_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsBathing_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__SittingPos_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__buffLib_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__teamMateBuffLib_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPropReCaculated;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastBuffTickByQuarter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgettableEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFrightenedByStealAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__Traits_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RespawnDurationByQuarter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_respawnTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_realRespawnTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__HasTeached_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isNobody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_templete;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_templeteUid;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isAlive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_surName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_givenName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_overrideTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_egoState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_valueState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_avatar;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_avatarChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_portait;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_portaitChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_interForceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originProps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_additionProps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_kungfuModifiedProps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_equipModifiedProps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_temporaryProps;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_activedInternalKungfu;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_activedInternalKunfuId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TeamMemberState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SlgModeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_backPack;

	private static readonly System.IntPtr NativeFieldInfoPtr_dropOnDeadBackPack;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealBackPack;

	private static readonly System.IntPtr NativeFieldInfoPtr_relationShip;

	private static readonly System.IntPtr NativeFieldInfoPtr_bonds;

	private static readonly System.IntPtr NativeFieldInfoPtr_killsById;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipSlotBuffCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_curMapId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_targetMapId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_curPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_targetPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RespawnMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RespawnPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dir;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_factionJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsTourist;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedTempleteHashcode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KungfuPropDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TeamLeaderPropDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedPropsWithoutLogWhileModified;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionMoralPropBondariesEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempEnvConfigInited;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpHpVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpAtkVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpAtkVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDefVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDefVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpLitVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpEpVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpEpVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDodgeVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDodgeVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpCirtVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpCirtVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpParryVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDStrikeVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDStrikeVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpDStrikeVal3;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpPecVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharPropTmpCounterVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_Basic;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_DexProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_BattlePowerProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_LightProp1;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_LightProp2;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_LevelProp1;

	private static readonly System.IntPtr NativeFieldInfoPtr_BattleActionRec_LevelProp2;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpHpVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpHpVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpAtkVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpAtkVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpEpVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpEpVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpActionVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpActionVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpActionVal3;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpCritVal1;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropTmpCritVal2;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropHit;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropDodge;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlgCharPropParry;

	private static readonly System.IntPtr NativeFieldInfoPtr_GrowDay_Money;

	private static readonly System.IntPtr NativeFieldInfoPtr_GrowDay_Exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_GrowDay_SkillLv;

	private static readonly System.IntPtr NativeFieldInfoPtr_GrowDay_SkillGet;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InstanceId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TempleteUid_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TempleteName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Templete_Public_get_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SurName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SurName_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GivenName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_GivenName_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasOverrideName_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EgoState_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueState_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AdditionValues_Public_get_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginValues_Public_get_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KungfuModifiedProps_Public_get_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldComputeTempPropNow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TemporaryProps_Public_get_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EquipModifiedProps_Public_get_Dictionary_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Level_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Exp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalExpToLevelUp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CouldGetMoreExp_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Avatar_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Portait_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FullName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FullNameWithTitle_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUsingStangerName_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RealFullName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RealFullNameWithTitle_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgUniqueName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Info_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InterForceType_Public_get_InterForceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Sex_Public_get_CharacterSex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCoward_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KungfuInstances_Public_get_List_1_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurHp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurEp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActivedInternalKungfuId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActivedUniqueKungfuId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ActivedUniqueKungfuId_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActivedInternalKungfu_Public_get_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BackPack_Public_get_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DropOnDeadBackPack_Public_get_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StealBackPack_Public_get_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RelationShip_Public_get_Dictionary_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RepLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RealRepLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RepExp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurMapId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetMapId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurPos_Public_get_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPos_Public_get_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Dir_Public_get_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimState_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSitting_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSitting_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBathing_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsBathing_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SittingPos_Public_get_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SittingPos_Private_set_Void_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TeamMemberState_Public_get_TeamMemberState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgFactionInstance_Public_get_Dlc1FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JobData_Public_get_FactionJobData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Faction_Public_get_FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FactionData_Public_get_FactionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_buffLib_Public_get_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_buffLib_Private_set_Void_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_teamMateBuffLib_Public_get_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_teamMateBuffLib_Private_set_Void_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onBuffChanged_Public_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onBuffChanged_Public_set_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastBuffTickByQuarter_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lastBuffTickByQuarter_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFrightened_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsParalyze_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsForbiddenMove_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsIgnoreSoV_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBattleStun_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Traits_Public_get_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Traits_Private_set_Void_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RespawnDurationByQuarter_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RespawnDurationByQuarter_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasTeached_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HasTeached_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EquipSlot_Public_get_Dictionary_2_ItemType_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CouldJoinAsPet_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMainCharacter_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCurrentPet_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PetExtendData_Public_get_CharacterPetExtendData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTourist_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsJoinedTeamOnce_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNobody_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RedDotName_Kungfu_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RedDotName_WuDao_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCharacter_Public_Void_CharacterPoolData_Int32_FactionJobData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StroyCheckConditionFromCharaInit_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCharacterFromLoadedData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheNewlyCreatedData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBackPack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyCharacterFrom_Public_Void_GameCharacterInstance_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionJob_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionJob_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionJob_Public_Void_FactionJobData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMapPosConfig_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeaveCurrentFaction_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshFactionJobBuff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLivingExp_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSurName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGivenName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAvatar_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPortait_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldEquiping_Public_EquipingCheckResult_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalKungfuSlotsLeft_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldLearnKungfu_Public_EquipingCheckResult_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPropRequire_Public_Boolean_KeyWithValues_FinalPropSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPropRequire_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_FinalPropSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleExpOnKilled_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleExp_Public_Int32_Int32_Boolean_Boolean_ExpSpecifyTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleExp_Public_Int32_Int32_byref_List_1_KungfuLevelUpInfo_byref_CharacterLevelUpInfo_ExpSpecifyTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_KungfuData_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnKungfuLevelup_Public_Void_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKungfu_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKungfu_Public_Void_KungfuInstance_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReportKungfuLevelupToStroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SqushBattlePower_Public_Int32_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMapId_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPos_Public_Void_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDir_Public_Void_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimState_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSitting_Public_Void_Boolean_InteractiveObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBathing_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsTourist_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPortrait_Public_Sprite_PortraitType_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPortrait_Public_Sprite_byref_String_PortraitType_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeaponSetIndex_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyOriginPropsFromTemplete_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBasePropRandomly_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateRandomOriginValues_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeKungfuProp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEquipDataFromTemplete_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixPortaitAndAvatar_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixLevel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixBackPackFromOldLoad_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixKungfu_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixNpcBuff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixNpcTrait_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasKungfuBuff_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyKungfuBuff_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasProp_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalProp_Public_Int32_String_FinalPropSource_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalPropAsDecimal_Public_Decimal_String_FinalPropSource_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuBuffedValue_Public_Decimal_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterRealPropAsDecimal_Public_Decimal_String_FinalPropSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterPropBySelfAndEquip_Private_Void_String_byref_Decimal_byref_Decimal_FinalPropSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyValueByPropAsBuff_Public_Int32_String_Int32_FinalPropSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyValueByPropAsBuff_Public_Decimal_String_Decimal_FinalPropSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalPropAsRate_Public_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAdditionPropWithLog_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeOriginProp_Public_Void_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAdditionProp_Public_Decimal_String_Decimal_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMainPropExp_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeLevelWithLog_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeEgoStateWithLog_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeValueStateWithLog_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAdditionProp_Public_Void_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClampedAdditionValue_Public_Decimal_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharacterMoralPropBondariesEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveInternalKungfu_Public_Void_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveUniqueKungfu_Public_Void_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalKungku_Public_List_1_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOuternalKungku_Public_List_1_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuByUName_Public_KungfuInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuById_Public_KungfuInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuMaxCd_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitWeaponEquipingByType_Public_Void_ItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnEquipItem_Public_Boolean_ItemType_Boolean_Boolean_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EquipItem_Public_Boolean_GameItemInstance_Boolean_Boolean_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipingWeaponType_Public_ItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasEquiping_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipingItem_Public_GameItemInstance_ItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeEquipProp_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDeathLoot_Public_GameItemPack_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveRamdomLootToPack_Public_List_1_Int32_Int32_Int32_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DropEquipAsLootToPack_Public_Void_ItemType_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PutTeammateBonusIntoPack_Public_Void_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPropRelateBuff_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAllPropRelateBuff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTemporyaryPropDirty_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeTemporyaryProps_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipPenalty_Public_Single_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEquipPenalty_Public_Single_EquipPenaltyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTeamMemberState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixNullTeamMemberState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTeamMemberState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyHp_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyEp_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHp_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEp_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullyRecover_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Respawn_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CouldAutoRespawn_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlive_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNewlyRespawn_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericProp_Public_Decimal_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCompare_Public_Boolean_CompareData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCompares_Public_Boolean_Il2CppReferenceArray_1_CompareData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelation_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyRelation_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRelation_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKnowPlayer_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationWithPlayer_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFameWithFaction_Public_Decimal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFameDataWithFaction_Public_FactionFameData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelationOffsetWithPlayer_Public_Int32_Int32_RelationModifySource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyRelationWithPlayer_Public_Void_Int32_RelationModifySource_Boolean_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPurchaseRelation_Public_Void_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextRelationTheshold_Public_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTalkingContentByTemplete_Public_NpcTalkingContent_String_Action_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTalkingByTemplete_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTalkingByTempleteJob_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WillBeEnemyInInstantBattle_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAgainestFactionRight_Public_Boolean_AreaOwnerData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAgainestPrivateRight_Public_Boolean_AreaOwnerData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsItemFond_Public_Boolean_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsItemFond_Public_Boolean_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyRelationForLevelup_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckModifyRelationByMoralChange_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldUseItem_Public_ItemUsageChceckResult_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Void_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Void_String_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Void_ItemData_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_Int32_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_String_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_BuffData_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshBuffRedDots_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearBuffRedDots_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInitBuff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyNpcBuff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffEndEffect_Public_Void_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuffTeammateEffect_Public_Void_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBuffTeammateEffect_Public_Void_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyPropFromBuff_Public_Void_Il2CppReferenceArray_1_KeyWithValues_CharacterBuffSource_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyClearBuffTag_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffTickByQuarter_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeBuffCheck_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElixirBuff_Public_List_1_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestBuff_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickupPack_Public_Void_GameItemPack_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllTrait_Public_List_1_TraitData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTrait_Public_TraitData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTraits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTraits_Public_GameItemPack_List_1_TraitData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditionTraitWithBuffOnly_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAdditionTraitWithBuffOnly_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationDataWithPlayer_Public_FriendlyData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RelationStr_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RelationStrWithDM_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RelationStrShort_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RelationStrShortWithDM_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationStr_Public_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTraits_Public_Void_Il2CppStringArray_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRoamingVal_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoamingVal_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBattleVal_Public_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleValTotal_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForgettableEvent_Public_ForgettableEvents_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldTeach_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTeached_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldLearnAbility_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AbilityLevelUp_Public_Boolean_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAbilityLevelMaxed_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityLevelUpCost_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProtectFaction_Public_Boolean_FactionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProtectFaction_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProtectCharacter_Public_Boolean_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProtectCharacter_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBond_Public_Void_Int32_BondType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBond_Public_Void_Int32_BondType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyBond_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasBond_Public_Boolean_Int32_BondType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBond_Public_BondType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOppssiteBond_Private_BondType_BondType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharactersByBondType_Public_HashSet_1_GameCharacterInstance_BondType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyZzPoints_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetZzPoints_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountZzPoint_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAllocateZzPoint_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllJmBuffNames_Public_HashSet_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoApplyJmBuff_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgModeState_Public_get_SlgModeState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgModeFactionJobId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SlgModeFactionJobId_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgModeFactionJobTemplete_Public_get_DLCFactionJob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgLevelDataTemplete_Public_get_DLCCharacterLevelExtendData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgWage_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgTraitPointsTotal_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgTraitPointsCost_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SlgTraitPointsLeft_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgModeInitCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSlgModeJobForCurrentTurn_Public_Void_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSlgMoodOnTurnStart_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSlgMoodOnTurnEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLeaveMapPos_Public_Void_Int32_Vector3Int_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitCharacter_b__252_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__StroyCheckConditionFromCharaInit_b__253_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__StroyCheckConditionFromCharaInit_b__253_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitCharacterFromLoadedData_b__254_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__CheckCompare_b__413_0_Private_Decimal_String_0;

	public unsafe static int DEFAULT_BACKPACK_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BACKPACK_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BACKPACK_SIZE, (void*)(&num));
		}
	}

	public unsafe bool HasZzPointRedDot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasZzPointRedDot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasZzPointRedDot)) = flag;
		}
	}

	public unsafe bool m_TemporaryPropsIsDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemporaryPropsIsDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemporaryPropsIsDirty)) = flag;
		}
	}

	public unsafe bool m_EquipPropDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EquipPropDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EquipPropDirty)) = flag;
		}
	}

	public unsafe bool m_DirtyPropComputeNow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DirtyPropComputeNow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DirtyPropComputeNow)) = flag;
		}
	}

	public unsafe string altAvatar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_altAvatar);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_altAvatar)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<int, int> kungfuRemoved
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuRemoved);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuRemoved)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int _ActivedUniqueKungfuId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ActivedUniqueKungfuId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ActivedUniqueKungfuId_k__BackingField)) = num;
		}
	}

	public unsafe bool _IsSitting_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSitting_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSitting_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsBathing_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsBathing_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsBathing_k__BackingField)) = flag;
		}
	}

	public unsafe Vector3Int _SittingPos_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SittingPos_k__BackingField);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SittingPos_k__BackingField)) = vector3Int;
		}
	}

	public unsafe BuffLib _buffLib_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buffLib_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buffLib_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffLib));
		}
	}

	public unsafe BuffLib _teamMateBuffLib_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamMateBuffLib_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__teamMateBuffLib_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffLib));
		}
	}

	public unsafe Il2CppSystem.Action onPropReCaculated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPropReCaculated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPropReCaculated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe int _lastBuffTickByQuarter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastBuffTickByQuarter_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastBuffTickByQuarter_k__BackingField)) = num;
		}
	}

	public unsafe ForgettableEvents forgettableEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgettableEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForgettableEvents>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgettableEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forgettableEvents));
		}
	}

	public unsafe bool IsFrightenedByStealAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFrightenedByStealAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFrightenedByStealAction)) = flag;
		}
	}

	public unsafe List<int> _Traits_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Traits_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Traits_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int _RespawnDurationByQuarter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RespawnDurationByQuarter_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RespawnDurationByQuarter_k__BackingField)) = num;
		}
	}

	public unsafe int respawnTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnTime)) = num;
		}
	}

	public unsafe Il2CppSystem.Decimal realRespawnTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realRespawnTime);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realRespawnTime)) = obj;
		}
	}

	public unsafe bool _HasTeached_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasTeached_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasTeached_k__BackingField)) = flag;
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> m_isNobody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isNobody);
			return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isNobody), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_instanceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_instanceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_instanceId)) = num;
		}
	}

	public unsafe CharacterPoolData templete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterPoolData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData));
		}
	}

	public unsafe int m_templeteUid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_templeteUid);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_templeteUid)) = num;
		}
	}

	public unsafe bool m_isValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isValid)) = flag;
		}
	}

	public unsafe bool m_isAlive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isAlive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isAlive)) = flag;
		}
	}

	public unsafe string m_surName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_surName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_surName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string m_givenName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_givenName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_givenName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string m_overrideTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_overrideTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_overrideTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int m_egoState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_egoState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_egoState)) = num;
		}
	}

	public unsafe int m_valueState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_valueState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_valueState)) = num;
		}
	}

	public unsafe int m_level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_level)) = num;
		}
	}

	public unsafe int m_exp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_exp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_exp)) = num;
		}
	}

	public unsafe string m_avatar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_avatar);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_avatar)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool m_avatarChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_avatarChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_avatarChanged)) = flag;
		}
	}

	public unsafe string m_portait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_portait);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_portait)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool m_portaitChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_portaitChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_portaitChanged)) = flag;
		}
	}

	public unsafe InterForceType m_interForceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_interForceType);
			return *(InterForceType*)num;
		}
		set
		{
			*(InterForceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_interForceType)) = interForceType;
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> m_originProps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originProps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originProps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> m_additionProps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_additionProps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_additionProps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> m_kungfuModifiedProps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_kungfuModifiedProps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_kungfuModifiedProps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> m_equipModifiedProps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_equipModifiedProps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_equipModifiedProps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> m_temporaryProps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_temporaryProps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_temporaryProps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<KungfuInstance> kungfuInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe KungfuInstance activedInternalKungfu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activedInternalKungfu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activedInternalKungfu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
		}
	}

	public unsafe int m_activedInternalKunfuId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_activedInternalKunfuId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_activedInternalKunfuId)) = num;
		}
	}

	public unsafe TeamMemberState m_TeamMemberState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TeamMemberState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TeamMemberState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TeamMemberState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)teamMemberState));
		}
	}

	public unsafe SlgModeState m_SlgModeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SlgModeState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgModeState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SlgModeState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgModeState));
		}
	}

	public unsafe GameItemPack backPack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backPack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backPack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe GameItemPack dropOnDeadBackPack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropOnDeadBackPack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropOnDeadBackPack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe GameItemPack stealBackPack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealBackPack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealBackPack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe Dictionary<int, int> relationShip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relationShip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relationShip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, BondType> bonds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, BondType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, int> killsById
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killsById);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killsById)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<ItemType, GameItemInstance> equipSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipSlot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemType, GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipSlot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<ItemType, int> equipSlotBuffCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipSlotBuffCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipSlotBuffCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int m_curMapId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_curMapId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_curMapId)) = num;
		}
	}

	public unsafe int m_targetMapId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetMapId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetMapId)) = num;
		}
	}

	public unsafe Vector3Int m_curPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_curPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_curPos)) = vector3Int;
		}
	}

	public unsafe Vector3Int m_targetPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetPos)) = vector3Int;
		}
	}

	public unsafe int m_RespawnMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RespawnMap);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RespawnMap)) = num;
		}
	}

	public unsafe Vector3Int m_RespawnPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RespawnPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RespawnPos)) = vector3Int;
		}
	}

	public unsafe TileDirection m_dir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dir);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dir)) = tileDirection;
		}
	}

	public unsafe int m_AnimState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimState)) = num;
		}
	}

	public unsafe int m_factionJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_factionJob);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_factionJob)) = num;
		}
	}

	public unsafe bool m_IsTourist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsTourist);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsTourist)) = flag;
		}
	}

	public unsafe int m_CachedTempleteHashcode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedTempleteHashcode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedTempleteHashcode)) = num;
		}
	}

	public unsafe bool m_KungfuPropDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KungfuPropDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KungfuPropDirty)) = flag;
		}
	}

	public unsafe bool m_TeamLeaderPropDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TeamLeaderPropDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TeamLeaderPropDirty)) = flag;
		}
	}

	public unsafe List<string> cachedPropsWithoutLogWhileModified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedPropsWithoutLogWhileModified);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedPropsWithoutLogWhileModified)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool m_AdditionMoralPropBondariesEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionMoralPropBondariesEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionMoralPropBondariesEnabled)) = flag;
		}
	}

	public unsafe static bool TempEnvConfigInited
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempEnvConfigInited, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempEnvConfigInited, (void*)(&flag));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpHpVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpHpVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpHpVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpAtkVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpAtkVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpAtkVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpAtkVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpAtkVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpAtkVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDefVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDefVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDefVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDefVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDefVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDefVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpLitVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpLitVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpLitVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpEpVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpEpVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpEpVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpEpVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpEpVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpEpVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDodgeVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDodgeVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDodgeVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDodgeVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDodgeVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDodgeVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpCirtVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpCirtVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpCirtVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpCirtVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpCirtVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpCirtVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpParryVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpParryVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpParryVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDStrikeVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDStrikeVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDStrikeVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDStrikeVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDStrikeVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDStrikeVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpDStrikeVal3
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpDStrikeVal3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpDStrikeVal3, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpPecVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpPecVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpPecVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal CharPropTmpCounterVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharPropTmpCounterVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharPropTmpCounterVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_Basic
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_Basic, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_Basic, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_DexProp
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_DexProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_DexProp, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_BattlePowerProp
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_BattlePowerProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_BattlePowerProp, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_LightProp1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_LightProp1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_LightProp1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_LightProp2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_LightProp2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_LightProp2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_LevelProp1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_LevelProp1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_LevelProp1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal BattleActionRec_LevelProp2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BattleActionRec_LevelProp2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BattleActionRec_LevelProp2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpHpVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpHpVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpHpVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpHpVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpHpVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpHpVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpAtkVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpAtkVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpAtkVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpAtkVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpAtkVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpAtkVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpEpVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpEpVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpEpVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpEpVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpEpVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpEpVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpActionVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpActionVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpActionVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpActionVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpActionVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpActionVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpActionVal3
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpActionVal3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpActionVal3, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpCritVal1
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpCritVal1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpCritVal1, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropTmpCritVal2
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropTmpCritVal2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropTmpCritVal2, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropHit
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropHit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropHit, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropDodge
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropDodge, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropDodge, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal SlgCharPropParry
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlgCharPropParry, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlgCharPropParry, (void*)(&obj));
		}
	}

	public unsafe int GrowDay_Money
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_Money);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_Money)) = num;
		}
	}

	public unsafe int GrowDay_Exp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_Exp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_Exp)) = num;
		}
	}

	public unsafe int GrowDay_SkillLv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_SkillLv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_SkillLv)) = num;
		}
	}

	public unsafe int GrowDay_SkillGet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_SkillGet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrowDay_SkillGet)) = num;
		}
	}

	public unsafe int hash
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int InstanceId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InstanceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int TempleteUid
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TempleteUid_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string TempleteName
	{
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 803142, RefRangeEnd = 803176, XrefRangeStart = 803142, XrefRangeEnd = 803142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TempleteName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe CharacterPoolData Templete
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Templete_Public_get_CharacterPoolData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterPoolData>(intPtr) : null;
		}
	}

	public unsafe bool IsValid
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsAlive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string SurName
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803188, RefRangeEnd = 803193, XrefRangeStart = 803176, XrefRangeEnd = 803188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SurName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SurName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string GivenName
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803205, RefRangeEnd = 803210, XrefRangeStart = 803193, XrefRangeEnd = 803205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GivenName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GivenName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string Title
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 803226, RefRangeEnd = 803227, XrefRangeStart = 803210, XrefRangeEnd = 803226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool HasOverrideName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 803228, RefRangeEnd = 803229, XrefRangeStart = 803227, XrefRangeEnd = 803228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasOverrideName_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int EgoState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EgoState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int ValueState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ValueState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> AdditionValues
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AdditionValues_Public_get_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> OriginValues
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OriginValues_Public_get_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> KungfuModifiedProps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KungfuModifiedProps_Public_get_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
	}

	public unsafe bool ShouldComputeTempPropNow
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldComputeTempPropNow_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> TemporaryProps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TemporaryProps_Public_get_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Decimal> EquipModifiedProps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EquipModifiedProps_Public_get_Dictionary_2_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
		}
	}

	public unsafe int Level
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Level_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int Exp
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Exp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int TotalExpToLevelUp
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 803237, RefRangeEnd = 803253, XrefRangeStart = 803229, XrefRangeEnd = 803237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalExpToLevelUp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool CouldGetMoreExp
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 803261, RefRangeEnd = 803262, XrefRangeStart = 803253, XrefRangeEnd = 803261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CouldGetMoreExp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string Avatar
	{
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 803267, RefRangeEnd = 803345, XrefRangeStart = 803262, XrefRangeEnd = 803267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Avatar_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string Portait
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 803346, RefRangeEnd = 803347, XrefRangeStart = 803345, XrefRangeEnd = 803346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Portait_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string FullName
	{
		[CallerCount(166)]
		[CachedScanResults(RefRangeStart = 803361, RefRangeEnd = 803527, XrefRangeStart = 803347, XrefRangeEnd = 803361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string FullNameWithTitle
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 803534, RefRangeEnd = 803548, XrefRangeStart = 803527, XrefRangeEnd = 803534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullNameWithTitle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool IsUsingStangerName
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 803550, RefRangeEnd = 803553, XrefRangeStart = 803548, XrefRangeEnd = 803550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUsingStangerName_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string RealFullName
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 803563, RefRangeEnd = 803570, XrefRangeStart = 803553, XrefRangeEnd = 803563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RealFullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string RealFullNameWithTitle
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803580, RefRangeEnd = 803585, XrefRangeStart = 803570, XrefRangeEnd = 803580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RealFullNameWithTitle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string SlgUniqueName
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 803599, RefRangeEnd = 803601, XrefRangeStart = 803585, XrefRangeEnd = 803599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgUniqueName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string Info
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803601, XrefRangeEnd = 803612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Info_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe InterForceType InterForceType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InterForceType_Public_get_InterForceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(InterForceType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe CharacterSex Sex
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 803615, RefRangeEnd = 803637, XrefRangeStart = 803612, XrefRangeEnd = 803615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Sex_Public_get_CharacterSex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(CharacterSex*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsCoward
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 803637, RefRangeEnd = 803659, XrefRangeStart = 803637, XrefRangeEnd = 803637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCoward_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<KungfuInstance> KungfuInstances
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KungfuInstances_Public_get_List_1_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
		}
	}

	public unsafe int CurHp
	{
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 803681, RefRangeEnd = 803720, XrefRangeStart = 803659, XrefRangeEnd = 803681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurHp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int CurEp
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 803733, RefRangeEnd = 803756, XrefRangeStart = 803720, XrefRangeEnd = 803733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurEp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int ActivedInternalKungfuId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActivedInternalKungfuId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int ActivedUniqueKungfuId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActivedUniqueKungfuId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ActivedUniqueKungfuId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe KungfuInstance ActivedInternalKungfu
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActivedInternalKungfu_Public_get_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
		}
	}

	public unsafe GameItemPack BackPack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BackPack_Public_get_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
	}

	public unsafe GameItemPack DropOnDeadBackPack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DropOnDeadBackPack_Public_get_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
	}

	public unsafe GameItemPack StealBackPack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StealBackPack_Public_get_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
	}

	public unsafe Dictionary<int, int> RelationShip
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RelationShip_Public_get_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
	}

	public unsafe int RepLevel
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 803759, RefRangeEnd = 803776, XrefRangeStart = 803756, XrefRangeEnd = 803759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RepLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int RealRepLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 803779, RefRangeEnd = 803782, XrefRangeStart = 803776, XrefRangeEnd = 803779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RealRepLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int RepExp
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 803785, RefRangeEnd = 803786, XrefRangeStart = 803782, XrefRangeEnd = 803785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RepExp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int CurMapId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int TargetMapId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector3Int CurPos
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurPos_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector3Int TargetPos
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetPos_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe TileDirection Dir
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Dir_Public_get_TileDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int AnimState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnimState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsSitting
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsSitting_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsBathing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsBathing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125375, RefRangeEnd = 125376, XrefRangeStart = 125375, XrefRangeEnd = 125376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsBathing_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3Int SittingPos
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SittingPos_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SittingPos_Private_set_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe TeamMemberState TeamMemberState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TeamMemberState_Public_get_TeamMemberState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TeamMemberState>(intPtr) : null;
		}
	}

	public unsafe Dlc1FactionInstance SlgFactionInstance
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 803790, RefRangeEnd = 803815, XrefRangeStart = 803786, XrefRangeEnd = 803790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgFactionInstance_Public_get_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dlc1FactionInstance>(intPtr) : null;
		}
	}

	public unsafe FactionJobData JobData
	{
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 803823, RefRangeEnd = 803872, XrefRangeStart = 803815, XrefRangeEnd = 803823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JobData_Public_get_FactionJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionJobData>(intPtr) : null;
		}
	}

	public unsafe FactionInstance Faction
	{
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 803885, RefRangeEnd = 803987, XrefRangeStart = 803872, XrefRangeEnd = 803885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Faction_Public_get_FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionInstance>(intPtr) : null;
		}
	}

	public unsafe FactionData FactionData
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 803992, RefRangeEnd = 804002, XrefRangeStart = 803987, XrefRangeEnd = 803992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FactionData_Public_get_FactionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionData>(intPtr) : null;
		}
	}

	public unsafe BuffLib buffLib
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 18831, RefRangeEnd = 18845, XrefRangeStart = 18831, XrefRangeEnd = 18845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_buffLib_Public_get_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20198, RefRangeEnd = 20199, XrefRangeStart = 20198, XrefRangeEnd = 20199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_buffLib_Private_set_Void_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe BuffLib teamMateBuffLib
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28448, RefRangeEnd = 28449, XrefRangeStart = 28448, XrefRangeEnd = 28449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_teamMateBuffLib_Public_get_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_teamMateBuffLib_Private_set_Void_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Action onBuffChanged
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 804002, RefRangeEnd = 804006, XrefRangeStart = 804002, XrefRangeEnd = 804002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onBuffChanged_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 804006, RefRangeEnd = 804010, XrefRangeStart = 804006, XrefRangeEnd = 804006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onBuffChanged_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int lastBuffTickByQuarter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastBuffTickByQuarter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68154, RefRangeEnd = 68157, XrefRangeStart = 68154, XrefRangeEnd = 68157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastBuffTickByQuarter_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsFrightened
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsFrightened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsParalyze
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 804013, RefRangeEnd = 804043, XrefRangeStart = 804010, XrefRangeEnd = 804013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsParalyze_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsForbiddenMove
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 804046, RefRangeEnd = 804064, XrefRangeStart = 804043, XrefRangeEnd = 804046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsForbiddenMove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsIgnoreSoV
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 804067, RefRangeEnd = 804070, XrefRangeStart = 804064, XrefRangeEnd = 804067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsIgnoreSoV_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsBattleStun
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 804073, RefRangeEnd = 804077, XrefRangeStart = 804070, XrefRangeEnd = 804073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsBattleStun_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<int> Traits
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18873, RefRangeEnd = 18874, XrefRangeStart = 18873, XrefRangeEnd = 18874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Traits_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Traits_Private_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int RespawnDurationByQuarter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RespawnDurationByQuarter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RespawnDurationByQuarter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool HasTeached
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasTeached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HasTeached_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<ItemType, GameItemInstance> EquipSlot
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EquipSlot_Public_get_Dictionary_2_ItemType_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemType, GameItemInstance>>(intPtr) : null;
		}
	}

	public unsafe bool CouldJoinAsPet
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 804078, RefRangeEnd = 804092, XrefRangeStart = 804077, XrefRangeEnd = 804078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CouldJoinAsPet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsMainCharacter
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804092, XrefRangeEnd = 804104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsMainCharacter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsCurrentPet
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804104, XrefRangeEnd = 804111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCurrentPet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe CharacterPetExtendData PetExtendData
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 804119, RefRangeEnd = 804133, XrefRangeStart = 804111, XrefRangeEnd = 804119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PetExtendData_Public_get_CharacterPetExtendData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterPetExtendData>(intPtr) : null;
		}
	}

	public unsafe bool IsTourist
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsTourist_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsJoinedTeamOnce
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 804133, RefRangeEnd = 804134, XrefRangeStart = 804133, XrefRangeEnd = 804133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsJoinedTeamOnce_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsNobody
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 804167, RefRangeEnd = 804171, XrefRangeStart = 804134, XrefRangeEnd = 804167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNobody_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string RedDotName_Kungfu
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 804175, RefRangeEnd = 804177, XrefRangeStart = 804171, XrefRangeEnd = 804175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RedDotName_Kungfu_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string RedDotName_WuDao
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 804181, RefRangeEnd = 804183, XrefRangeStart = 804177, XrefRangeEnd = 804181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RedDotName_WuDao_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool CouldAutoRespawn
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 809901, RefRangeEnd = 809903, XrefRangeStart = 809900, XrefRangeEnd = 809901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CouldAutoRespawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool WillBeEnemyInInstantBattle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 810888, RefRangeEnd = 810889, XrefRangeStart = 810849, XrefRangeEnd = 810888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WillBeEnemyInInstantBattle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string RelationStr
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 812008, RefRangeEnd = 812012, XrefRangeStart = 812007, XrefRangeEnd = 812008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RelationStr_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string RelationStrWithDM
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 812013, RefRangeEnd = 812014, XrefRangeStart = 812012, XrefRangeEnd = 812013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RelationStrWithDM_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string RelationStrShort
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 812015, RefRangeEnd = 812017, XrefRangeStart = 812014, XrefRangeEnd = 812015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RelationStrShort_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string RelationStrShortWithDM
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 812018, RefRangeEnd = 812019, XrefRangeStart = 812017, XrefRangeEnd = 812018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RelationStrShortWithDM_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe SlgModeState SlgModeState
	{
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 812859, RefRangeEnd = 812898, XrefRangeStart = 812851, XrefRangeEnd = 812859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgModeState_Public_get_SlgModeState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgModeState>(intPtr) : null;
		}
	}

	public unsafe int SlgModeFactionJobId
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 812899, RefRangeEnd = 812912, XrefRangeStart = 812898, XrefRangeEnd = 812899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgModeFactionJobId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 812937, RefRangeEnd = 812939, XrefRangeStart = 812912, XrefRangeEnd = 812937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SlgModeFactionJobId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe DLCFactionJob SlgModeFactionJobTemplete
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 812948, RefRangeEnd = 812957, XrefRangeStart = 812939, XrefRangeEnd = 812948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgModeFactionJobTemplete_Public_get_DLCFactionJob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCFactionJob>(intPtr) : null;
		}
	}

	public unsafe DLCCharacterLevelExtendData SlgLevelDataTemplete
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 812965, RefRangeEnd = 812971, XrefRangeStart = 812957, XrefRangeEnd = 812965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgLevelDataTemplete_Public_get_DLCCharacterLevelExtendData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCCharacterLevelExtendData>(intPtr) : null;
		}
	}

	public unsafe int SlgWage
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 812978, RefRangeEnd = 812982, XrefRangeStart = 812971, XrefRangeEnd = 812978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgWage_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int SlgTraitPointsTotal
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 812986, RefRangeEnd = 812988, XrefRangeStart = 812982, XrefRangeEnd = 812986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgTraitPointsTotal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int SlgTraitPointsCost
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 812988, XrefRangeEnd = 813003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgTraitPointsCost_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int SlgTraitPointsLeft
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 813022, RefRangeEnd = 813024, XrefRangeStart = 813003, XrefRangeEnd = 813022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlgTraitPointsLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static GameCharacterInstance()
	{
		Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameCharacterInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_BACKPACK_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "DEFAULT_BACKPACK_SIZE");
		NativeFieldInfoPtr_HasZzPointRedDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "HasZzPointRedDot");
		NativeFieldInfoPtr_m_TemporaryPropsIsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_TemporaryPropsIsDirty");
		NativeFieldInfoPtr_m_EquipPropDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_EquipPropDirty");
		NativeFieldInfoPtr_m_DirtyPropComputeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_DirtyPropComputeNow");
		NativeFieldInfoPtr_altAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "altAvatar");
		NativeFieldInfoPtr_kungfuRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "kungfuRemoved");
		NativeFieldInfoPtr__ActivedUniqueKungfuId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<ActivedUniqueKungfuId>k__BackingField");
		NativeFieldInfoPtr__IsSitting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<IsSitting>k__BackingField");
		NativeFieldInfoPtr__IsBathing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<IsBathing>k__BackingField");
		NativeFieldInfoPtr__SittingPos_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<SittingPos>k__BackingField");
		NativeFieldInfoPtr__buffLib_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<buffLib>k__BackingField");
		NativeFieldInfoPtr__teamMateBuffLib_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<teamMateBuffLib>k__BackingField");
		NativeFieldInfoPtr_onPropReCaculated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "onPropReCaculated");
		NativeFieldInfoPtr__lastBuffTickByQuarter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<lastBuffTickByQuarter>k__BackingField");
		NativeFieldInfoPtr_forgettableEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "forgettableEvents");
		NativeFieldInfoPtr_IsFrightenedByStealAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "IsFrightenedByStealAction");
		NativeFieldInfoPtr__Traits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<Traits>k__BackingField");
		NativeFieldInfoPtr__RespawnDurationByQuarter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<RespawnDurationByQuarter>k__BackingField");
		NativeFieldInfoPtr_respawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "respawnTime");
		NativeFieldInfoPtr_realRespawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "realRespawnTime");
		NativeFieldInfoPtr__HasTeached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "<HasTeached>k__BackingField");
		NativeFieldInfoPtr_m_isNobody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_isNobody");
		NativeFieldInfoPtr_m_instanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_instanceId");
		NativeFieldInfoPtr_templete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "templete");
		NativeFieldInfoPtr_m_templeteUid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_templeteUid");
		NativeFieldInfoPtr_m_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_isValid");
		NativeFieldInfoPtr_m_isAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_isAlive");
		NativeFieldInfoPtr_m_surName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_surName");
		NativeFieldInfoPtr_m_givenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_givenName");
		NativeFieldInfoPtr_m_overrideTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_overrideTitle");
		NativeFieldInfoPtr_m_egoState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_egoState");
		NativeFieldInfoPtr_m_valueState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_valueState");
		NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_level");
		NativeFieldInfoPtr_m_exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_exp");
		NativeFieldInfoPtr_m_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_avatar");
		NativeFieldInfoPtr_m_avatarChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_avatarChanged");
		NativeFieldInfoPtr_m_portait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_portait");
		NativeFieldInfoPtr_m_portaitChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_portaitChanged");
		NativeFieldInfoPtr_m_interForceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_interForceType");
		NativeFieldInfoPtr_m_originProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_originProps");
		NativeFieldInfoPtr_m_additionProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_additionProps");
		NativeFieldInfoPtr_m_kungfuModifiedProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_kungfuModifiedProps");
		NativeFieldInfoPtr_m_equipModifiedProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_equipModifiedProps");
		NativeFieldInfoPtr_m_temporaryProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_temporaryProps");
		NativeFieldInfoPtr_kungfuInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "kungfuInstances");
		NativeFieldInfoPtr_activedInternalKungfu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "activedInternalKungfu");
		NativeFieldInfoPtr_m_activedInternalKunfuId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_activedInternalKunfuId");
		NativeFieldInfoPtr_m_TeamMemberState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_TeamMemberState");
		NativeFieldInfoPtr_m_SlgModeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_SlgModeState");
		NativeFieldInfoPtr_backPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "backPack");
		NativeFieldInfoPtr_dropOnDeadBackPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "dropOnDeadBackPack");
		NativeFieldInfoPtr_stealBackPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "stealBackPack");
		NativeFieldInfoPtr_relationShip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "relationShip");
		NativeFieldInfoPtr_bonds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "bonds");
		NativeFieldInfoPtr_killsById = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "killsById");
		NativeFieldInfoPtr_equipSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "equipSlot");
		NativeFieldInfoPtr_equipSlotBuffCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "equipSlotBuffCache");
		NativeFieldInfoPtr_m_curMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_curMapId");
		NativeFieldInfoPtr_m_targetMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_targetMapId");
		NativeFieldInfoPtr_m_curPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_curPos");
		NativeFieldInfoPtr_m_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_targetPos");
		NativeFieldInfoPtr_m_RespawnMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_RespawnMap");
		NativeFieldInfoPtr_m_RespawnPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_RespawnPos");
		NativeFieldInfoPtr_m_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_dir");
		NativeFieldInfoPtr_m_AnimState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_AnimState");
		NativeFieldInfoPtr_m_factionJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_factionJob");
		NativeFieldInfoPtr_m_IsTourist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_IsTourist");
		NativeFieldInfoPtr_m_CachedTempleteHashcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_CachedTempleteHashcode");
		NativeFieldInfoPtr_m_KungfuPropDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_KungfuPropDirty");
		NativeFieldInfoPtr_m_TeamLeaderPropDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_TeamLeaderPropDirty");
		NativeFieldInfoPtr_cachedPropsWithoutLogWhileModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "cachedPropsWithoutLogWhileModified");
		NativeFieldInfoPtr_m_AdditionMoralPropBondariesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "m_AdditionMoralPropBondariesEnabled");
		NativeFieldInfoPtr_TempEnvConfigInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "TempEnvConfigInited");
		NativeFieldInfoPtr_CharPropTmpHpVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpHpVal1");
		NativeFieldInfoPtr_CharPropTmpAtkVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpAtkVal1");
		NativeFieldInfoPtr_CharPropTmpAtkVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpAtkVal2");
		NativeFieldInfoPtr_CharPropTmpDefVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDefVal1");
		NativeFieldInfoPtr_CharPropTmpDefVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDefVal2");
		NativeFieldInfoPtr_CharPropTmpLitVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpLitVal1");
		NativeFieldInfoPtr_CharPropTmpEpVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpEpVal1");
		NativeFieldInfoPtr_CharPropTmpEpVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpEpVal2");
		NativeFieldInfoPtr_CharPropTmpDodgeVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDodgeVal1");
		NativeFieldInfoPtr_CharPropTmpDodgeVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDodgeVal2");
		NativeFieldInfoPtr_CharPropTmpCirtVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpCirtVal1");
		NativeFieldInfoPtr_CharPropTmpCirtVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpCirtVal2");
		NativeFieldInfoPtr_CharPropTmpParryVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpParryVal1");
		NativeFieldInfoPtr_CharPropTmpDStrikeVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDStrikeVal1");
		NativeFieldInfoPtr_CharPropTmpDStrikeVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDStrikeVal2");
		NativeFieldInfoPtr_CharPropTmpDStrikeVal3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpDStrikeVal3");
		NativeFieldInfoPtr_CharPropTmpPecVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpPecVal1");
		NativeFieldInfoPtr_CharPropTmpCounterVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "CharPropTmpCounterVal1");
		NativeFieldInfoPtr_BattleActionRec_Basic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_Basic");
		NativeFieldInfoPtr_BattleActionRec_DexProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_DexProp");
		NativeFieldInfoPtr_BattleActionRec_BattlePowerProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_BattlePowerProp");
		NativeFieldInfoPtr_BattleActionRec_LightProp1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_LightProp1");
		NativeFieldInfoPtr_BattleActionRec_LightProp2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_LightProp2");
		NativeFieldInfoPtr_BattleActionRec_LevelProp1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_LevelProp1");
		NativeFieldInfoPtr_BattleActionRec_LevelProp2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "BattleActionRec_LevelProp2");
		NativeFieldInfoPtr_SlgCharPropTmpHpVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpHpVal1");
		NativeFieldInfoPtr_SlgCharPropTmpHpVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpHpVal2");
		NativeFieldInfoPtr_SlgCharPropTmpAtkVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpAtkVal1");
		NativeFieldInfoPtr_SlgCharPropTmpAtkVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpAtkVal2");
		NativeFieldInfoPtr_SlgCharPropTmpEpVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpEpVal1");
		NativeFieldInfoPtr_SlgCharPropTmpEpVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpEpVal2");
		NativeFieldInfoPtr_SlgCharPropTmpActionVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpActionVal1");
		NativeFieldInfoPtr_SlgCharPropTmpActionVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpActionVal2");
		NativeFieldInfoPtr_SlgCharPropTmpActionVal3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpActionVal3");
		NativeFieldInfoPtr_SlgCharPropTmpCritVal1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpCritVal1");
		NativeFieldInfoPtr_SlgCharPropTmpCritVal2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropTmpCritVal2");
		NativeFieldInfoPtr_SlgCharPropHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropHit");
		NativeFieldInfoPtr_SlgCharPropDodge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropDodge");
		NativeFieldInfoPtr_SlgCharPropParry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "SlgCharPropParry");
		NativeFieldInfoPtr_GrowDay_Money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "GrowDay_Money");
		NativeFieldInfoPtr_GrowDay_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "GrowDay_Exp");
		NativeFieldInfoPtr_GrowDay_SkillLv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "GrowDay_SkillLv");
		NativeFieldInfoPtr_GrowDay_SkillGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, "GrowDay_SkillGet");
		NativeMethodInfoPtr_get_hash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672179);
		NativeMethodInfoPtr_get_InstanceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672180);
		NativeMethodInfoPtr_get_TempleteUid_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672181);
		NativeMethodInfoPtr_get_TempleteName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672182);
		NativeMethodInfoPtr_get_Templete_Public_get_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672183);
		NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672184);
		NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672185);
		NativeMethodInfoPtr_get_SurName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672186);
		NativeMethodInfoPtr_set_SurName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672187);
		NativeMethodInfoPtr_get_GivenName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672188);
		NativeMethodInfoPtr_set_GivenName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672189);
		NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672190);
		NativeMethodInfoPtr_get_HasOverrideName_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672191);
		NativeMethodInfoPtr_get_EgoState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672192);
		NativeMethodInfoPtr_get_ValueState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672193);
		NativeMethodInfoPtr_get_AdditionValues_Public_get_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672194);
		NativeMethodInfoPtr_get_OriginValues_Public_get_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672195);
		NativeMethodInfoPtr_get_KungfuModifiedProps_Public_get_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672196);
		NativeMethodInfoPtr_get_ShouldComputeTempPropNow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672197);
		NativeMethodInfoPtr_get_TemporaryProps_Public_get_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672198);
		NativeMethodInfoPtr_get_EquipModifiedProps_Public_get_Dictionary_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672199);
		NativeMethodInfoPtr_get_Level_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672200);
		NativeMethodInfoPtr_get_Exp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672201);
		NativeMethodInfoPtr_get_TotalExpToLevelUp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672202);
		NativeMethodInfoPtr_get_CouldGetMoreExp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672203);
		NativeMethodInfoPtr_get_Avatar_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672204);
		NativeMethodInfoPtr_get_Portait_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672205);
		NativeMethodInfoPtr_get_FullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672206);
		NativeMethodInfoPtr_get_FullNameWithTitle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672207);
		NativeMethodInfoPtr_get_IsUsingStangerName_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672208);
		NativeMethodInfoPtr_get_RealFullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672209);
		NativeMethodInfoPtr_get_RealFullNameWithTitle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672210);
		NativeMethodInfoPtr_get_SlgUniqueName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672211);
		NativeMethodInfoPtr_get_Info_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672212);
		NativeMethodInfoPtr_get_InterForceType_Public_get_InterForceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672213);
		NativeMethodInfoPtr_get_Sex_Public_get_CharacterSex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672214);
		NativeMethodInfoPtr_get_IsCoward_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672215);
		NativeMethodInfoPtr_get_KungfuInstances_Public_get_List_1_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672216);
		NativeMethodInfoPtr_get_CurHp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672217);
		NativeMethodInfoPtr_get_CurEp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672218);
		NativeMethodInfoPtr_get_ActivedInternalKungfuId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672219);
		NativeMethodInfoPtr_get_ActivedUniqueKungfuId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672220);
		NativeMethodInfoPtr_set_ActivedUniqueKungfuId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672221);
		NativeMethodInfoPtr_get_ActivedInternalKungfu_Public_get_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672222);
		NativeMethodInfoPtr_get_BackPack_Public_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672223);
		NativeMethodInfoPtr_get_DropOnDeadBackPack_Public_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672224);
		NativeMethodInfoPtr_get_StealBackPack_Public_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672225);
		NativeMethodInfoPtr_get_RelationShip_Public_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672226);
		NativeMethodInfoPtr_get_RepLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672227);
		NativeMethodInfoPtr_get_RealRepLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672228);
		NativeMethodInfoPtr_get_RepExp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672229);
		NativeMethodInfoPtr_get_CurMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672230);
		NativeMethodInfoPtr_get_TargetMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672231);
		NativeMethodInfoPtr_get_CurPos_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672232);
		NativeMethodInfoPtr_get_TargetPos_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672233);
		NativeMethodInfoPtr_get_Dir_Public_get_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672234);
		NativeMethodInfoPtr_get_AnimState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672235);
		NativeMethodInfoPtr_get_IsSitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672236);
		NativeMethodInfoPtr_set_IsSitting_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672237);
		NativeMethodInfoPtr_get_IsBathing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672238);
		NativeMethodInfoPtr_set_IsBathing_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672239);
		NativeMethodInfoPtr_get_SittingPos_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672240);
		NativeMethodInfoPtr_set_SittingPos_Private_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672241);
		NativeMethodInfoPtr_get_TeamMemberState_Public_get_TeamMemberState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672242);
		NativeMethodInfoPtr_get_SlgFactionInstance_Public_get_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672243);
		NativeMethodInfoPtr_get_JobData_Public_get_FactionJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672244);
		NativeMethodInfoPtr_get_Faction_Public_get_FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672245);
		NativeMethodInfoPtr_get_FactionData_Public_get_FactionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672246);
		NativeMethodInfoPtr_get_buffLib_Public_get_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672247);
		NativeMethodInfoPtr_set_buffLib_Private_set_Void_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672248);
		NativeMethodInfoPtr_get_teamMateBuffLib_Public_get_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672249);
		NativeMethodInfoPtr_set_teamMateBuffLib_Private_set_Void_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672250);
		NativeMethodInfoPtr_get_onBuffChanged_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672251);
		NativeMethodInfoPtr_set_onBuffChanged_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672252);
		NativeMethodInfoPtr_get_lastBuffTickByQuarter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672253);
		NativeMethodInfoPtr_set_lastBuffTickByQuarter_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672254);
		NativeMethodInfoPtr_get_IsFrightened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672255);
		NativeMethodInfoPtr_get_IsParalyze_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672256);
		NativeMethodInfoPtr_get_IsForbiddenMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672257);
		NativeMethodInfoPtr_get_IsIgnoreSoV_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672258);
		NativeMethodInfoPtr_get_IsBattleStun_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672259);
		NativeMethodInfoPtr_get_Traits_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672260);
		NativeMethodInfoPtr_set_Traits_Private_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672261);
		NativeMethodInfoPtr_get_RespawnDurationByQuarter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672262);
		NativeMethodInfoPtr_set_RespawnDurationByQuarter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672263);
		NativeMethodInfoPtr_get_HasTeached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672264);
		NativeMethodInfoPtr_set_HasTeached_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672265);
		NativeMethodInfoPtr_get_EquipSlot_Public_get_Dictionary_2_ItemType_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672266);
		NativeMethodInfoPtr_get_CouldJoinAsPet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672267);
		NativeMethodInfoPtr_get_IsMainCharacter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672268);
		NativeMethodInfoPtr_get_IsCurrentPet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672269);
		NativeMethodInfoPtr_get_PetExtendData_Public_get_CharacterPetExtendData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672270);
		NativeMethodInfoPtr_get_IsTourist_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672271);
		NativeMethodInfoPtr_get_IsJoinedTeamOnce_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672272);
		NativeMethodInfoPtr_get_IsNobody_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672273);
		NativeMethodInfoPtr_get_RedDotName_Kungfu_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672274);
		NativeMethodInfoPtr_get_RedDotName_WuDao_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672275);
		NativeMethodInfoPtr_InitCharacter_Public_Void_CharacterPoolData_Int32_FactionJobData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672276);
		NativeMethodInfoPtr_StroyCheckConditionFromCharaInit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672277);
		NativeMethodInfoPtr_InitCharacterFromLoadedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672278);
		NativeMethodInfoPtr_CacheNewlyCreatedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672279);
		NativeMethodInfoPtr_InitBackPack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672280);
		NativeMethodInfoPtr_CopyCharacterFrom_Public_Void_GameCharacterInstance_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672281);
		NativeMethodInfoPtr_SetFactionJob_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672282);
		NativeMethodInfoPtr_SetFactionJob_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672283);
		NativeMethodInfoPtr_SetFactionJob_Public_Void_FactionJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672284);
		NativeMethodInfoPtr_UpdateMapPosConfig_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672285);
		NativeMethodInfoPtr_LeaveCurrentFaction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672286);
		NativeMethodInfoPtr_RefreshFactionJobBuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672287);
		NativeMethodInfoPtr_GetLivingExp_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672288);
		NativeMethodInfoPtr_SetSurName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672289);
		NativeMethodInfoPtr_SetGivenName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672290);
		NativeMethodInfoPtr_SetAvatar_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672291);
		NativeMethodInfoPtr_SetPortait_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672292);
		NativeMethodInfoPtr_CouldEquiping_Public_EquipingCheckResult_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672293);
		NativeMethodInfoPtr_NormalKungfuSlotsLeft_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672294);
		NativeMethodInfoPtr_CouldLearnKungfu_Public_EquipingCheckResult_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672295);
		NativeMethodInfoPtr_CheckPropRequire_Public_Boolean_KeyWithValues_FinalPropSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672296);
		NativeMethodInfoPtr_CheckPropRequire_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_FinalPropSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672297);
		NativeMethodInfoPtr_GetLocName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672298);
		NativeMethodInfoPtr_GetBattleExpOnKilled_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672299);
		NativeMethodInfoPtr_GetBattleExp_Public_Int32_Int32_Boolean_Boolean_ExpSpecifyTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672300);
		NativeMethodInfoPtr_GetBattleExp_Public_Int32_Int32_byref_List_1_KungfuLevelUpInfo_byref_CharacterLevelUpInfo_ExpSpecifyTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672301);
		NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672302);
		NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672303);
		NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_KungfuData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672304);
		NativeMethodInfoPtr_OnKungfuLevelup_Public_Void_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672305);
		NativeMethodInfoPtr_RemoveKungfu_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672306);
		NativeMethodInfoPtr_RemoveKungfu_Public_Void_KungfuInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672307);
		NativeMethodInfoPtr_ReportKungfuLevelupToStroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672308);
		NativeMethodInfoPtr_SqushBattlePower_Public_Int32_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672309);
		NativeMethodInfoPtr_SetMapId_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672310);
		NativeMethodInfoPtr_SetPos_Public_Void_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672311);
		NativeMethodInfoPtr_SetDir_Public_Void_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672312);
		NativeMethodInfoPtr_SetAnimState_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672313);
		NativeMethodInfoPtr_SetSitting_Public_Void_Boolean_InteractiveObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672314);
		NativeMethodInfoPtr_SetBathing_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672315);
		NativeMethodInfoPtr_SetIsTourist_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672316);
		NativeMethodInfoPtr_GetPortrait_Public_Sprite_PortraitType_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672317);
		NativeMethodInfoPtr_GetPortrait_Public_Sprite_byref_String_PortraitType_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672318);
		NativeMethodInfoPtr_GetWeaponSetIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672319);
		NativeMethodInfoPtr_ApplyOriginPropsFromTemplete_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672320);
		NativeMethodInfoPtr_GenerateBasePropRandomly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672321);
		NativeMethodInfoPtr_AllocateRandomOriginValues_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672322);
		NativeMethodInfoPtr_ComputeKungfuProp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672323);
		NativeMethodInfoPtr_ApplyEquipDataFromTemplete_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672324);
		NativeMethodInfoPtr_FixPortaitAndAvatar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672325);
		NativeMethodInfoPtr_FixLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672326);
		NativeMethodInfoPtr_FixBackPackFromOldLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672327);
		NativeMethodInfoPtr_FixKungfu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672328);
		NativeMethodInfoPtr_FixNpcBuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672329);
		NativeMethodInfoPtr_FixNpcTrait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672330);
		NativeMethodInfoPtr_HasKungfuBuff_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672331);
		NativeMethodInfoPtr_ApplyKungfuBuff_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672332);
		NativeMethodInfoPtr_HasProp_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672333);
		NativeMethodInfoPtr_GetFinalProp_Public_Int32_String_FinalPropSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672334);
		NativeMethodInfoPtr_GetFinalPropAsDecimal_Public_Decimal_String_FinalPropSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672335);
		NativeMethodInfoPtr_GetKungfuBuffedValue_Public_Decimal_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672336);
		NativeMethodInfoPtr_GetCharacterRealPropAsDecimal_Public_Decimal_String_FinalPropSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672337);
		NativeMethodInfoPtr_GetCharacterPropBySelfAndEquip_Private_Void_String_byref_Decimal_byref_Decimal_FinalPropSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672338);
		NativeMethodInfoPtr_ModifyValueByPropAsBuff_Public_Int32_String_Int32_FinalPropSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672339);
		NativeMethodInfoPtr_ModifyValueByPropAsBuff_Public_Decimal_String_Decimal_FinalPropSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672340);
		NativeMethodInfoPtr_GetFinalPropAsRate_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672341);
		NativeMethodInfoPtr_ChangeAdditionPropWithLog_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672342);
		NativeMethodInfoPtr_ChangeOriginProp_Public_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672343);
		NativeMethodInfoPtr_ChangeAdditionProp_Public_Decimal_String_Decimal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672344);
		NativeMethodInfoPtr_CheckMainPropExp_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672345);
		NativeMethodInfoPtr_ChangeLevelWithLog_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672346);
		NativeMethodInfoPtr_ChangeEgoStateWithLog_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672347);
		NativeMethodInfoPtr_ChangeValueStateWithLog_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672348);
		NativeMethodInfoPtr_SetAdditionProp_Public_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672349);
		NativeMethodInfoPtr_GetClampedAdditionValue_Public_Decimal_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672350);
		NativeMethodInfoPtr_SetCharacterMoralPropBondariesEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672351);
		NativeMethodInfoPtr_SetActiveInternalKungfu_Public_Void_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672352);
		NativeMethodInfoPtr_SetActiveUniqueKungfu_Public_Void_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672353);
		NativeMethodInfoPtr_GetInternalKungku_Public_List_1_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672354);
		NativeMethodInfoPtr_GetOuternalKungku_Public_List_1_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672355);
		NativeMethodInfoPtr_GetKungfuByUName_Public_KungfuInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672356);
		NativeMethodInfoPtr_GetKungfuById_Public_KungfuInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672357);
		NativeMethodInfoPtr_GetKungfuMaxCd_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672358);
		NativeMethodInfoPtr_InitWeaponEquipingByType_Public_Void_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672359);
		NativeMethodInfoPtr_UnEquipItem_Public_Boolean_ItemType_Boolean_Boolean_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672360);
		NativeMethodInfoPtr_EquipItem_Public_Boolean_GameItemInstance_Boolean_Boolean_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672361);
		NativeMethodInfoPtr_GetEquipingWeaponType_Public_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672362);
		NativeMethodInfoPtr_HasEquiping_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672363);
		NativeMethodInfoPtr_GetEquipingItem_Public_GameItemInstance_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672364);
		NativeMethodInfoPtr_ComputeEquipProp_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672365);
		NativeMethodInfoPtr_CreateDeathLoot_Public_GameItemPack_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672366);
		NativeMethodInfoPtr_GiveRamdomLootToPack_Public_List_1_Int32_Int32_Int32_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672367);
		NativeMethodInfoPtr_DropEquipAsLootToPack_Public_Void_ItemType_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672368);
		NativeMethodInfoPtr_PutTeammateBonusIntoPack_Public_Void_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672369);
		NativeMethodInfoPtr_CheckPropRelateBuff_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672370);
		NativeMethodInfoPtr_CheckAllPropRelateBuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672371);
		NativeMethodInfoPtr_SetTemporyaryPropDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672372);
		NativeMethodInfoPtr_ComputeTemporyaryProps_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672373);
		NativeMethodInfoPtr_GetEquipPenalty_Public_Single_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672374);
		NativeMethodInfoPtr_GetEquipPenalty_Public_Single_EquipPenaltyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672375);
		NativeMethodInfoPtr_InitTeamMemberState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672376);
		NativeMethodInfoPtr_FixNullTeamMemberState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672377);
		NativeMethodInfoPtr_RemoveTeamMemberState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672378);
		NativeMethodInfoPtr_ModifyHp_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672379);
		NativeMethodInfoPtr_ModifyEp_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672380);
		NativeMethodInfoPtr_SetHp_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672381);
		NativeMethodInfoPtr_SetEp_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672382);
		NativeMethodInfoPtr_FullyRecover_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672383);
		NativeMethodInfoPtr_Respawn_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672384);
		NativeMethodInfoPtr_get_CouldAutoRespawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672385);
		NativeMethodInfoPtr_SetAlive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672386);
		NativeMethodInfoPtr_IsNewlyRespawn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672387);
		NativeMethodInfoPtr_GetGenericProp_Public_Decimal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672388);
		NativeMethodInfoPtr_CheckCompare_Public_Boolean_CompareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672389);
		NativeMethodInfoPtr_CheckCompares_Public_Boolean_Il2CppReferenceArray_1_CompareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672390);
		NativeMethodInfoPtr_GetRelation_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672391);
		NativeMethodInfoPtr_ModifyRelation_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672392);
		NativeMethodInfoPtr_SetRelation_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672393);
		NativeMethodInfoPtr_IsKnowPlayer_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672394);
		NativeMethodInfoPtr_GetRelationWithPlayer_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672395);
		NativeMethodInfoPtr_GetFameWithFaction_Public_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672396);
		NativeMethodInfoPtr_GetFameDataWithFaction_Public_FactionFameData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672397);
		NativeMethodInfoPtr_CalculateRelationOffsetWithPlayer_Public_Int32_Int32_RelationModifySource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672398);
		NativeMethodInfoPtr_ModifyRelationWithPlayer_Public_Void_Int32_RelationModifySource_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672399);
		NativeMethodInfoPtr_ApplyPurchaseRelation_Public_Void_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672400);
		NativeMethodInfoPtr_GetNextRelationTheshold_Public_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672401);
		NativeMethodInfoPtr_GetTalkingContentByTemplete_Public_NpcTalkingContent_String_Action_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672402);
		NativeMethodInfoPtr_GetTalkingByTemplete_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672403);
		NativeMethodInfoPtr_GetTalkingByTempleteJob_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672404);
		NativeMethodInfoPtr_get_WillBeEnemyInInstantBattle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672405);
		NativeMethodInfoPtr_IsAgainestFactionRight_Public_Boolean_AreaOwnerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672406);
		NativeMethodInfoPtr_IsAgainestPrivateRight_Public_Boolean_AreaOwnerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672407);
		NativeMethodInfoPtr_IsItemFond_Public_Boolean_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672408);
		NativeMethodInfoPtr_IsItemFond_Public_Boolean_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672409);
		NativeMethodInfoPtr_ModifyRelationForLevelup_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672410);
		NativeMethodInfoPtr_CheckModifyRelationByMoralChange_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672411);
		NativeMethodInfoPtr_CouldUseItem_Public_ItemUsageChceckResult_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672412);
		NativeMethodInfoPtr_UseItem_Public_Void_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672413);
		NativeMethodInfoPtr_UseItem_Public_Void_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672414);
		NativeMethodInfoPtr_UseItem_Public_Void_ItemData_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672415);
		NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_Int32_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672416);
		NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_String_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672417);
		NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_BuffData_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672418);
		NativeMethodInfoPtr_RefreshBuffRedDots_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672419);
		NativeMethodInfoPtr_ClearBuffRedDots_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672420);
		NativeMethodInfoPtr_ApplyInitBuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672421);
		NativeMethodInfoPtr_ApplyNpcBuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672422);
		NativeMethodInfoPtr_BuffEndEffect_Public_Void_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672423);
		NativeMethodInfoPtr_ApplyBuffTeammateEffect_Public_Void_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672424);
		NativeMethodInfoPtr_RemoveBuffTeammateEffect_Public_Void_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672425);
		NativeMethodInfoPtr_ModifyPropFromBuff_Public_Void_Il2CppReferenceArray_1_KeyWithValues_CharacterBuffSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672426);
		NativeMethodInfoPtr_ApplyClearBuffTag_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672427);
		NativeMethodInfoPtr_BuffTickByQuarter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672428);
		NativeMethodInfoPtr_TimeBuffCheck_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672429);
		NativeMethodInfoPtr_GetElixirBuff_Public_List_1_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672430);
		NativeMethodInfoPtr_TestBuff_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672431);
		NativeMethodInfoPtr_PickupPack_Public_Void_GameItemPack_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672432);
		NativeMethodInfoPtr_GetAllTrait_Public_List_1_TraitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672433);
		NativeMethodInfoPtr_GetTrait_Public_TraitData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672434);
		NativeMethodInfoPtr_ClearTraits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672435);
		NativeMethodInfoPtr_SetTraits_Public_GameItemPack_List_1_TraitData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672436);
		NativeMethodInfoPtr_GetAdditionTraitWithBuffOnly_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672437);
		NativeMethodInfoPtr_RemoveAdditionTraitWithBuffOnly_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672438);
		NativeMethodInfoPtr_GetRelationDataWithPlayer_Public_FriendlyData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672439);
		NativeMethodInfoPtr_get_RelationStr_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672440);
		NativeMethodInfoPtr_get_RelationStrWithDM_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672441);
		NativeMethodInfoPtr_get_RelationStrShort_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672442);
		NativeMethodInfoPtr_get_RelationStrShortWithDM_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672443);
		NativeMethodInfoPtr_GetRelationStr_Public_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672444);
		NativeMethodInfoPtr_SetTraits_Public_Void_Il2CppStringArray_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672445);
		NativeMethodInfoPtr_ChangeRoamingVal_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672446);
		NativeMethodInfoPtr_GetRoamingVal_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672447);
		NativeMethodInfoPtr_SetBattleVal_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672448);
		NativeMethodInfoPtr_GetBattleValTotal_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672449);
		NativeMethodInfoPtr_GetForgettableEvent_Public_ForgettableEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672450);
		NativeMethodInfoPtr_CouldTeach_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672451);
		NativeMethodInfoPtr_SetTeached_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672452);
		NativeMethodInfoPtr_CouldLearnAbility_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672453);
		NativeMethodInfoPtr_AbilityLevelUp_Public_Boolean_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672454);
		NativeMethodInfoPtr_IsAbilityLevelMaxed_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672455);
		NativeMethodInfoPtr_GetAbilityLevelUpCost_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672456);
		NativeMethodInfoPtr_IsProtectFaction_Public_Boolean_FactionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672457);
		NativeMethodInfoPtr_IsProtectFaction_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672458);
		NativeMethodInfoPtr_IsProtectCharacter_Public_Boolean_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672459);
		NativeMethodInfoPtr_IsProtectCharacter_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672460);
		NativeMethodInfoPtr_SetBond_Public_Void_Int32_BondType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672461);
		NativeMethodInfoPtr_RemoveBond_Public_Void_Int32_BondType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672462);
		NativeMethodInfoPtr_HasAnyBond_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672463);
		NativeMethodInfoPtr_HasBond_Public_Boolean_Int32_BondType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672464);
		NativeMethodInfoPtr_GetBond_Public_BondType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672465);
		NativeMethodInfoPtr_GetOppssiteBond_Private_BondType_BondType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672466);
		NativeMethodInfoPtr_GetCharactersByBondType_Public_HashSet_1_GameCharacterInstance_BondType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672467);
		NativeMethodInfoPtr_ModifyZzPoints_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672468);
		NativeMethodInfoPtr_ResetZzPoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672469);
		NativeMethodInfoPtr_CountZzPoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672470);
		NativeMethodInfoPtr_AutoAllocateZzPoint_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672471);
		NativeMethodInfoPtr_GetAllJmBuffNames_Public_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672472);
		NativeMethodInfoPtr_AutoApplyJmBuff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672473);
		NativeMethodInfoPtr_get_SlgModeState_Public_get_SlgModeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672474);
		NativeMethodInfoPtr_get_SlgModeFactionJobId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672475);
		NativeMethodInfoPtr_set_SlgModeFactionJobId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672476);
		NativeMethodInfoPtr_get_SlgModeFactionJobTemplete_Public_get_DLCFactionJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672477);
		NativeMethodInfoPtr_get_SlgLevelDataTemplete_Public_get_DLCCharacterLevelExtendData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672478);
		NativeMethodInfoPtr_get_SlgWage_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672479);
		NativeMethodInfoPtr_get_SlgTraitPointsTotal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672480);
		NativeMethodInfoPtr_get_SlgTraitPointsCost_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672481);
		NativeMethodInfoPtr_get_SlgTraitPointsLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672482);
		NativeMethodInfoPtr_SlgModeInitCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672483);
		NativeMethodInfoPtr_SetSlgModeJobForCurrentTurn_Public_Void_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672484);
		NativeMethodInfoPtr_CheckSlgMoodOnTurnStart_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672485);
		NativeMethodInfoPtr_CheckSlgMoodOnTurnEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672486);
		NativeMethodInfoPtr_SetLeaveMapPos_Public_Void_Int32_Vector3Int_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672487);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672488);
		NativeMethodInfoPtr__InitCharacter_b__252_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672490);
		NativeMethodInfoPtr__StroyCheckConditionFromCharaInit_b__253_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672491);
		NativeMethodInfoPtr__StroyCheckConditionFromCharaInit_b__253_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672492);
		NativeMethodInfoPtr__InitCharacterFromLoadedData_b__254_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672493);
		NativeMethodInfoPtr__CheckCompare_b__413_0_Private_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr, 100672494);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804347, RefRangeEnd = 804348, XrefRangeStart = 804183, XrefRangeEnd = 804347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitCharacter(CharacterPoolData characterPoolData, int instanceId, FactionJobData factionJobData, int equipCraftLevel = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionJobData);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &equipCraftLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCharacter_Public_Void_CharacterPoolData_Int32_FactionJobData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804416, RefRangeEnd = 804418, XrefRangeStart = 804348, XrefRangeEnd = 804416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StroyCheckConditionFromCharaInit(bool isInit = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isInit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StroyCheckConditionFromCharaInit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804655, RefRangeEnd = 804657, XrefRangeStart = 804418, XrefRangeEnd = 804655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitCharacterFromLoadedData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCharacterFromLoadedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804657, RefRangeEnd = 804658, XrefRangeStart = 804657, XrefRangeEnd = 804657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheNewlyCreatedData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheNewlyCreatedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804677, RefRangeEnd = 804679, XrefRangeStart = 804658, XrefRangeEnd = 804677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitBackPack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBackPack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804705, RefRangeEnd = 804706, XrefRangeStart = 804679, XrefRangeEnd = 804705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyCharacterFrom(GameCharacterInstance other, bool keepPos = true, bool keepTemplete = false, bool keepJob = true, bool keepName = false, bool keepAliveState = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepPos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepTemplete;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepJob;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepName;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepAliveState;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyCharacterFrom_Public_Void_GameCharacterInstance_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 804715, RefRangeEnd = 804719, XrefRangeStart = 804706, XrefRangeEnd = 804715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFactionJob(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionJob_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804719, XrefRangeEnd = 804728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFactionJob(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionJob_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804764, RefRangeEnd = 804766, XrefRangeStart = 804728, XrefRangeEnd = 804764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFactionJob(FactionJobData factionJobData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionJobData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionJob_Public_Void_FactionJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804774, RefRangeEnd = 804776, XrefRangeStart = 804766, XrefRangeEnd = 804774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMapPosConfig()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMapPosConfig_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804804, RefRangeEnd = 804805, XrefRangeStart = 804776, XrefRangeEnd = 804804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveCurrentFaction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaveCurrentFaction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804813, RefRangeEnd = 804815, XrefRangeStart = 804805, XrefRangeEnd = 804813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshFactionJobBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshFactionJobBuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804827, RefRangeEnd = 804829, XrefRangeStart = 804815, XrefRangeEnd = 804827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLivingExp(int exp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&exp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLivingExp_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 804837, RefRangeEnd = 804841, XrefRangeStart = 804829, XrefRangeEnd = 804837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSurName(string surName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(surName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSurName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 804849, RefRangeEnd = 804853, XrefRangeStart = 804841, XrefRangeEnd = 804849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGivenName(string givenName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(givenName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGivenName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 804860, RefRangeEnd = 804866, XrefRangeStart = 804853, XrefRangeEnd = 804860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvatar(string avatar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAvatar_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 804869, RefRangeEnd = 804872, XrefRangeStart = 804866, XrefRangeEnd = 804869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPortait(string portait)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(portait);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPortait_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 804875, RefRangeEnd = 804879, XrefRangeStart = 804872, XrefRangeEnd = 804875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EquipingCheckResult CouldEquiping(GameItemInstance item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldEquiping_Public_EquipingCheckResult_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EquipingCheckResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804898, RefRangeEnd = 804899, XrefRangeStart = 804879, XrefRangeEnd = 804898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int NormalKungfuSlotsLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalKungfuSlotsLeft_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 804960, RefRangeEnd = 804967, XrefRangeStart = 804899, XrefRangeEnd = 804960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EquipingCheckResult CouldLearnKungfu(string kungfuName, bool checkCount = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(kungfuName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldLearnKungfu_Public_EquipingCheckResult_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EquipingCheckResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 804976, RefRangeEnd = 804979, XrefRangeStart = 804967, XrefRangeEnd = 804976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckPropRequire(KeyWithValues keyWithValues, FinalPropSource propSource = FinalPropSource.All)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(FinalPropSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &propSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPropRequire_Public_Boolean_KeyWithValues_FinalPropSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 804989, RefRangeEnd = 804992, XrefRangeStart = 804979, XrefRangeEnd = 804989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckPropRequire(Il2CppReferenceArray<KeyWithValues> keyWithValues, FinalPropSource propSource = FinalPropSource.All)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(FinalPropSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &propSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPropRequire_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_FinalPropSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1064)]
	[CachedScanResults(RefRangeStart = 12051, RefRangeEnd = 13115, XrefRangeStart = 12051, XrefRangeEnd = 13115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocName(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805032, RefRangeEnd = 805034, XrefRangeStart = 804992, XrefRangeEnd = 805032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBattleExpOnKilled(int otherRelateLevel = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherRelateLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBattleExpOnKilled_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 805171, RefRangeEnd = 805189, XrefRangeStart = 805034, XrefRangeEnd = 805171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBattleExp(int exp, bool hasLevelupInfo = true, bool hasExpGetInfo = true, ExpSpecifyTarget expSpecifyTarget = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&exp);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLevelupInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasExpGetInfo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expSpecifyTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBattleExp_Public_Int32_Int32_Boolean_Boolean_ExpSpecifyTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805233, RefRangeEnd = 805234, XrefRangeStart = 805189, XrefRangeEnd = 805233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBattleExp(int exp, ref List<GameLogManager.KungfuLevelUpInfo> levelUpKungfus, ref GameLogManager.CharacterLevelUpInfo levelUpInfo, ExpSpecifyTarget expSpecifyTarget = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&exp);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)levelUpKungfus);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)levelUpInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expSpecifyTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBattleExp_Public_Int32_Int32_byref_List_1_KungfuLevelUpInfo_byref_CharacterLevelUpInfo_ExpSpecifyTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		levelUpKungfus = ((intPtr4 == (System.IntPtr)0) ? null : new List<GameLogManager.KungfuLevelUpInfo>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 805243, RefRangeEnd = 805248, XrefRangeStart = 805234, XrefRangeEnd = 805243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuInstance InstantLearnKungfu(int kungfuId, int level, bool hasLog = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&kungfuId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 805257, RefRangeEnd = 805262, XrefRangeStart = 805248, XrefRangeEnd = 805257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuInstance InstantLearnKungfu(string kungfuName, int level, bool hasLog = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(kungfuName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 805331, RefRangeEnd = 805337, XrefRangeStart = 805262, XrefRangeEnd = 805331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuInstance InstantLearnKungfu(KungfuData kungfuData, int level, bool hasLog = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantLearnKungfu_Public_KungfuInstance_KungfuData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 805351, RefRangeEnd = 805355, XrefRangeStart = 805337, XrefRangeEnd = 805351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnKungfuLevelup(KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnKungfuLevelup_Public_Void_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805372, RefRangeEnd = 805373, XrefRangeStart = 805355, XrefRangeEnd = 805372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveKungfu(int kungfuId, bool hasLog = true, bool refreshPropNow = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&kungfuId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshPropNow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveKungfu_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 805413, RefRangeEnd = 805416, XrefRangeStart = 805373, XrefRangeEnd = 805413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveKungfu(KungfuInstance kungfuInstance, bool hasLog = true, bool refreshPropNow = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshPropNow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveKungfu_Public_Void_KungfuInstance_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805416, XrefRangeEnd = 805436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportKungfuLevelupToStroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportKungfuLevelupToStroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805459, RefRangeEnd = 805460, XrefRangeStart = 805436, XrefRangeEnd = 805459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SqushBattlePower(GameCharacterInstance victim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)victim);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SqushBattlePower_Public_Int32_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 805460, RefRangeEnd = 805494, XrefRangeStart = 805460, XrefRangeEnd = 805460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMapId(int mapId, bool alsoChangeTarget = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mapId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoChangeTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMapId_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 805494, RefRangeEnd = 805528, XrefRangeStart = 805494, XrefRangeEnd = 805494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPos(Vector3Int pos, bool alsoChangeTarget = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoChangeTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPos_Public_Void_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetDir(TileDirection tileDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDir_Public_Void_TileDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetAnimState(int animStateHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animStateHash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimState_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 805535, RefRangeEnd = 805540, XrefRangeStart = 805528, XrefRangeEnd = 805535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSitting(bool isSitting, InteractiveObject seat = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isSitting);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)seat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSitting_Public_Void_Boolean_InteractiveObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125375, RefRangeEnd = 125376, XrefRangeStart = 125375, XrefRangeEnd = 125376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBathing(bool isBathing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isBathing);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBathing_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetIsTourist(bool isTourist)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isTourist);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsTourist_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 805544, RefRangeEnd = 805579, XrefRangeStart = 805540, XrefRangeEnd = 805544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetPortrait(PortraitType portraitType = PortraitType.Scenario, string emotion = null, string variant = null, bool fallbackSilhouette = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&portraitType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(emotion);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(variant);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallbackSilhouette;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPortrait_Public_Sprite_PortraitType_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 805583, RefRangeEnd = 805588, XrefRangeStart = 805579, XrefRangeEnd = 805583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetPortrait(ref string rtnPath, PortraitType portraitType = PortraitType.Scenario, string emotion = null, string variant = null, bool fallbackSilhouette = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(rtnPath);
		*ptr = (nint)(&intPtr);
		*(PortraitType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &portraitType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(emotion);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(variant);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallbackSilhouette;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPortrait_Public_Sprite_byref_String_PortraitType_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		rtnPath = IL2CPP.Il2CppStringToManaged(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 805590, RefRangeEnd = 805605, XrefRangeStart = 805588, XrefRangeEnd = 805590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWeaponSetIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeaponSetIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 805831, RefRangeEnd = 805835, XrefRangeStart = 805605, XrefRangeEnd = 805831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyOriginPropsFromTemplete(bool isTeammate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isTeammate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyOriginPropsFromTemplete_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805865, RefRangeEnd = 805867, XrefRangeStart = 805835, XrefRangeEnd = 805865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateBasePropRandomly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBasePropRandomly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805948, RefRangeEnd = 805950, XrefRangeStart = 805867, XrefRangeEnd = 805948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateRandomOriginValues(int rndChaPts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rndChaPts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateRandomOriginValues_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 805995, RefRangeEnd = 806004, XrefRangeStart = 805950, XrefRangeEnd = 805995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeKungfuProp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeKungfuProp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 806060, RefRangeEnd = 806062, XrefRangeStart = 806004, XrefRangeEnd = 806060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyEquipDataFromTemplete(int craftLevel = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&craftLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyEquipDataFromTemplete_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 806063, RefRangeEnd = 806067, XrefRangeStart = 806062, XrefRangeEnd = 806063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixPortaitAndAvatar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixPortaitAndAvatar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 806068, RefRangeEnd = 806070, XrefRangeStart = 806067, XrefRangeEnd = 806068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 806078, RefRangeEnd = 806080, XrefRangeStart = 806070, XrefRangeEnd = 806078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixBackPackFromOldLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixBackPackFromOldLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 806161, RefRangeEnd = 806162, XrefRangeStart = 806080, XrefRangeEnd = 806161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixKungfu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixKungfu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 806166, RefRangeEnd = 806167, XrefRangeStart = 806162, XrefRangeEnd = 806166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixNpcBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixNpcBuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 806168, RefRangeEnd = 806169, XrefRangeStart = 806167, XrefRangeEnd = 806168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixNpcTrait()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixNpcTrait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 806179, RefRangeEnd = 806180, XrefRangeStart = 806169, XrefRangeEnd = 806179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasKungfuBuff(string kungfuIdOrName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(kungfuIdOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasKungfuBuff_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 806191, RefRangeEnd = 806194, XrefRangeStart = 806180, XrefRangeEnd = 806191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyKungfuBuff(string kungfuIdOrName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(kungfuIdOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyKungfuBuff_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806194, XrefRangeEnd = 806213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasProp(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasProp_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(447)]
	[CachedScanResults(RefRangeStart = 806218, RefRangeEnd = 806665, XrefRangeStart = 806213, XrefRangeEnd = 806218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFinalProp(string key, FinalPropSource finalPropSource = FinalPropSource.All, bool hasMinMaxClamp = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(FinalPropSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPropSource;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasMinMaxClamp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalProp_Public_Int32_String_FinalPropSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(58)]
	[CachedScanResults(RefRangeStart = 806838, RefRangeEnd = 806896, XrefRangeStart = 806665, XrefRangeEnd = 806838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetFinalPropAsDecimal(string key, FinalPropSource finalPropSource = FinalPropSource.All, bool hasMinMaxClamp = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(FinalPropSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPropSource;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasMinMaxClamp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalPropAsDecimal_Public_Decimal_String_FinalPropSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 806906, RefRangeEnd = 806908, XrefRangeStart = 806896, XrefRangeEnd = 806906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetKungfuBuffedValue(string key, Il2CppSystem.Decimal origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuBuffedValue_Public_Decimal_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 806913, RefRangeEnd = 806926, XrefRangeStart = 806908, XrefRangeEnd = 806913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetCharacterRealPropAsDecimal(string key, FinalPropSource finalPropSource = FinalPropSource.All)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(FinalPropSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPropSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterRealPropAsDecimal_Public_Decimal_String_FinalPropSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 806994, RefRangeEnd = 806996, XrefRangeStart = 806926, XrefRangeEnd = 806994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCharacterPropBySelfAndEquip(string key, ref Il2CppSystem.Decimal selfVal, ref Il2CppSystem.Decimal equipVal, FinalPropSource finalPropSource = FinalPropSource.All)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref selfVal);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref equipVal);
		*(FinalPropSource**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPropSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterPropBySelfAndEquip_Private_Void_String_byref_Decimal_byref_Decimal_FinalPropSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 807002, RefRangeEnd = 807042, XrefRangeStart = 806996, XrefRangeEnd = 807002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ModifyValueByPropAsBuff(string key, int origin, FinalPropSource finalPropSource = FinalPropSource.All)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(FinalPropSource**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPropSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyValueByPropAsBuff_Public_Int32_String_Int32_FinalPropSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 807061, RefRangeEnd = 807086, XrefRangeStart = 807042, XrefRangeEnd = 807061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal ModifyValueByPropAsBuff(string key, Il2CppSystem.Decimal origin, FinalPropSource finalPropSource = FinalPropSource.All)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(FinalPropSource**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPropSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyValueByPropAsBuff_Public_Decimal_String_Decimal_FinalPropSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 807107, RefRangeEnd = 807111, XrefRangeStart = 807086, XrefRangeEnd = 807107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFinalPropAsRate(string key, int decNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalPropAsRate_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 807224, RefRangeEnd = 807262, XrefRangeStart = 807111, XrefRangeEnd = 807224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAdditionPropWithLog(string key, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAdditionPropWithLog_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807262, XrefRangeEnd = 807278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeOriginProp(string key, Il2CppSystem.Decimal value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeOriginProp_Public_Void_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 807484, RefRangeEnd = 807514, XrefRangeStart = 807278, XrefRangeEnd = 807484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal ChangeAdditionProp(string key, Il2CppSystem.Decimal value, bool hasModifier = true, bool isPreview = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasModifier;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPreview;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAdditionProp_Public_Decimal_String_Decimal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 807606, RefRangeEnd = 807607, XrefRangeStart = 807514, XrefRangeEnd = 807606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckMainPropExp(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMainPropExp_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 807656, RefRangeEnd = 807661, XrefRangeStart = 807607, XrefRangeEnd = 807656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeLevelWithLog(int value, bool useCap = true, bool hasLog = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCap;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeLevelWithLog_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807661, XrefRangeEnd = 807688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeEgoStateWithLog(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeEgoStateWithLog_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 807715, RefRangeEnd = 807716, XrefRangeStart = 807688, XrefRangeEnd = 807715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeValueStateWithLog(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeValueStateWithLog_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 807732, RefRangeEnd = 807753, XrefRangeStart = 807716, XrefRangeEnd = 807732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAdditionProp(string key, Il2CppSystem.Decimal value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAdditionProp_Public_Void_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 807805, RefRangeEnd = 807807, XrefRangeStart = 807753, XrefRangeEnd = 807805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetClampedAdditionValue(string key, Il2CppSystem.Decimal value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClampedAdditionValue_Public_Decimal_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 807838, RefRangeEnd = 807842, XrefRangeStart = 807807, XrefRangeEnd = 807838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCharacterMoralPropBondariesEnabled(bool isEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isEnabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharacterMoralPropBondariesEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 807852, RefRangeEnd = 807863, XrefRangeStart = 807842, XrefRangeEnd = 807852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveInternalKungfu(KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveInternalKungfu_Public_Void_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 807863, RefRangeEnd = 807866, XrefRangeStart = 807863, XrefRangeEnd = 807863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveUniqueKungfu(KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveUniqueKungfu_Public_Void_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 807889, RefRangeEnd = 807891, XrefRangeStart = 807866, XrefRangeEnd = 807889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<KungfuInstance> GetInternalKungku()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInternalKungku_Public_List_1_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 807914, RefRangeEnd = 807915, XrefRangeStart = 807891, XrefRangeEnd = 807914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<KungfuInstance> GetOuternalKungku()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOuternalKungku_Public_List_1_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 807932, RefRangeEnd = 807933, XrefRangeStart = 807915, XrefRangeEnd = 807932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuInstance GetKungfuByUName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuByUName_Public_KungfuInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 807949, RefRangeEnd = 807955, XrefRangeStart = 807933, XrefRangeEnd = 807949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuInstance GetKungfuById(int kungfuUid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&kungfuUid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuById_Public_KungfuInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 807966, RefRangeEnd = 807970, XrefRangeStart = 807955, XrefRangeEnd = 807966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetKungfuMaxCd(int kungfuTempleteId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&kungfuTempleteId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuMaxCd_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 807988, RefRangeEnd = 807996, XrefRangeStart = 807970, XrefRangeEnd = 807988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitWeaponEquipingByType(ItemType itemType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitWeaponEquipingByType_Public_Void_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 808030, RefRangeEnd = 808051, XrefRangeStart = 807996, XrefRangeEnd = 808030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UnEquipItem(ItemType itemType, bool needRecomputeProp = true, bool returnItemToPack = true, GameItemPack pack = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&itemType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needRecomputeProp;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnItemToPack;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnEquipItem_Public_Boolean_ItemType_Boolean_Boolean_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 808149, RefRangeEnd = 808174, XrefRangeStart = 808051, XrefRangeEnd = 808149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool EquipItem(GameItemInstance gameItemInstance, bool needRecomputeProp = true, bool returnItemToPack = true, GameItemPack pack = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needRecomputeProp;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnItemToPack;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EquipItem_Public_Boolean_GameItemInstance_Boolean_Boolean_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 808189, RefRangeEnd = 808193, XrefRangeStart = 808174, XrefRangeEnd = 808189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemType GetEquipingWeaponType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquipingWeaponType_Public_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 808214, RefRangeEnd = 808216, XrefRangeStart = 808193, XrefRangeEnd = 808214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasEquiping(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasEquiping_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(75)]
	[CachedScanResults(RefRangeStart = 808220, RefRangeEnd = 808295, XrefRangeStart = 808216, XrefRangeEnd = 808220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance GetEquipingItem(ItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquipingItem_Public_GameItemInstance_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 808511, RefRangeEnd = 808517, XrefRangeStart = 808295, XrefRangeEnd = 808511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeEquipProp(bool setTempPropDirty = true, bool forceApplyBuffs = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&setTempPropDirty);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceApplyBuffs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeEquipProp_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 808567, RefRangeEnd = 808568, XrefRangeStart = 808517, XrefRangeEnd = 808567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack CreateDeathLoot(GameCharacterInstance deathDealer, bool hasDeathDrop = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deathDealer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasDeathDrop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDeathLoot_Public_GameItemPack_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 808607, RefRangeEnd = 808609, XrefRangeStart = 808568, XrefRangeEnd = 808607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GiveRamdomLootToPack(int min, int max, GameItemPack gameItemPack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&min);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveRamdomLootToPack_Public_List_1_Int32_Int32_Int32_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 808640, RefRangeEnd = 808643, XrefRangeStart = 808609, XrefRangeEnd = 808640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DropEquipAsLootToPack(ItemType slot, GameItemPack pack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&slot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DropEquipAsLootToPack_Public_Void_ItemType_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 808681, RefRangeEnd = 808683, XrefRangeStart = 808643, XrefRangeEnd = 808681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PutTeammateBonusIntoPack(GameItemPack pack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PutTeammateBonusIntoPack_Public_Void_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 808723, RefRangeEnd = 808726, XrefRangeStart = 808683, XrefRangeEnd = 808723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckPropRelateBuff(string prop)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prop);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPropRelateBuff_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 808785, RefRangeEnd = 808790, XrefRangeStart = 808726, XrefRangeEnd = 808785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAllPropRelateBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAllPropRelateBuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 808798, RefRangeEnd = 808816, XrefRangeStart = 808790, XrefRangeEnd = 808798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTemporyaryPropDirty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTemporyaryPropDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 809489, RefRangeEnd = 809535, XrefRangeStart = 808816, XrefRangeEnd = 809489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeTemporyaryProps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeTemporyaryProps_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 809579, RefRangeEnd = 809587, XrefRangeStart = 809535, XrefRangeEnd = 809579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetEquipPenalty(GameItemInstance gameItemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquipPenalty_Public_Single_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 809587, XrefRangeEnd = 809590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetEquipPenalty(EquipPenaltyType equipPenaltyType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&equipPenaltyType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquipPenalty_Public_Single_EquipPenaltyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 809593, RefRangeEnd = 809595, XrefRangeStart = 809590, XrefRangeEnd = 809593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InitTeamMemberState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTeamMemberState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 809600, RefRangeEnd = 809601, XrefRangeStart = 809595, XrefRangeEnd = 809600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FixNullTeamMemberState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixNullTeamMemberState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void RemoveTeamMemberState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTeamMemberState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 809614, RefRangeEnd = 809618, XrefRangeStart = 809601, XrefRangeEnd = 809614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyHp(int offset, int minValue = int.MinValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyHp_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 809631, RefRangeEnd = 809637, XrefRangeStart = 809618, XrefRangeEnd = 809631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyEp(int offset, int minValue = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyEp_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 809729, RefRangeEnd = 809732, XrefRangeStart = 809637, XrefRangeEnd = 809729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHp(int hp, int minValue = int.MinValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hp);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHp_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 809812, RefRangeEnd = 809815, XrefRangeStart = 809732, XrefRangeEnd = 809812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEp(int ep, int minValue = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ep);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEp_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 809834, RefRangeEnd = 809843, XrefRangeStart = 809815, XrefRangeEnd = 809834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FullyRecover(bool setDirty = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setDirty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullyRecover_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 809896, RefRangeEnd = 809900, XrefRangeStart = 809843, XrefRangeEnd = 809896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Respawn(bool setRespawnedTime = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setRespawnedTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Respawn_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 809957, RefRangeEnd = 809961, XrefRangeStart = 809903, XrefRangeEnd = 809957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAlive(bool isAlive, bool respawnAfterDeath = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isAlive);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &respawnAfterDeath;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 809968, RefRangeEnd = 809969, XrefRangeStart = 809961, XrefRangeEnd = 809968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsNewlyRespawn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNewlyRespawn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 810035, RefRangeEnd = 810039, XrefRangeStart = 809969, XrefRangeEnd = 810035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetGenericProp(string key, bool lossyProp = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lossyProp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericProp_Public_Decimal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810039, XrefRangeEnd = 810048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckCompare(CompareData compareData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compareData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCompare_Public_Boolean_CompareData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810048, XrefRangeEnd = 810059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckCompares(Il2CppReferenceArray<CompareData> compareDatas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compareDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCompares_Public_Boolean_Il2CppReferenceArray_1_CompareData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810059, XrefRangeEnd = 810063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRelation(int otherId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelation_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 810088, RefRangeEnd = 810091, XrefRangeStart = 810063, XrefRangeEnd = 810088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyRelation(int otherId, int relationOffset, bool alsoSetOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&otherId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relationOffset;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoSetOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyRelation_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 810095, RefRangeEnd = 810098, XrefRangeStart = 810091, XrefRangeEnd = 810095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRelation(int otherId, int relation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRelation_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 810134, RefRangeEnd = 810143, XrefRangeStart = 810098, XrefRangeEnd = 810134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKnowPlayer(bool checkDynamicModifier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkDynamicModifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKnowPlayer_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(64)]
	[CachedScanResults(RefRangeStart = 810190, RefRangeEnd = 810254, XrefRangeStart = 810143, XrefRangeEnd = 810190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRelationWithPlayer(bool checkDynamicModifier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkDynamicModifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationWithPlayer_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 810283, RefRangeEnd = 810287, XrefRangeStart = 810254, XrefRangeEnd = 810283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetFameWithFaction(bool checkDynamicModifier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkDynamicModifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFameWithFaction_Public_Decimal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 810300, RefRangeEnd = 810301, XrefRangeStart = 810287, XrefRangeEnd = 810300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionFameData GetFameDataWithFaction(bool checkDynamicModifier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkDynamicModifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFameDataWithFaction_Public_FactionFameData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionFameData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 810396, RefRangeEnd = 810397, XrefRangeStart = 810301, XrefRangeEnd = 810396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalculateRelationOffsetWithPlayer(int relationOffset, RelationModifySource relationModifySource = RelationModifySource.Default)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&relationOffset);
		*(RelationModifySource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relationModifySource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelationOffsetWithPlayer_Public_Int32_Int32_RelationModifySource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 810571, RefRangeEnd = 810604, XrefRangeStart = 810397, XrefRangeEnd = 810571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyRelationWithPlayer(int relationOffset, RelationModifySource relationModifySource = RelationModifySource.Default, bool hasLog = true, bool alsoAffectFaction = true, string logKey = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&relationOffset);
		*(RelationModifySource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relationModifySource;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoAffectFaction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(logKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyRelationWithPlayer_Public_Void_Int32_RelationModifySource_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810604, XrefRangeEnd = 810655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPurchaseRelation(int price, bool isPersonalShop, int rarityLevel = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&price);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPersonalShop;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rarityLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPurchaseRelation_Public_Void_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 810667, RefRangeEnd = 810669, XrefRangeStart = 810655, XrefRangeEnd = 810667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyWithValues GetNextRelationTheshold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextRelationTheshold_Public_KeyWithValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyWithValues>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 810682, RefRangeEnd = 810729, XrefRangeStart = 810669, XrefRangeEnd = 810682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcTalkingContent GetTalkingContentByTemplete(string key, Il2CppSystem.Action action = null, Il2CppReferenceArray<Il2CppSystem.Object> formater = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formater);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTalkingContentByTemplete_Public_NpcTalkingContent_String_Action_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTalkingContent>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 810829, RefRangeEnd = 810832, XrefRangeStart = 810729, XrefRangeEnd = 810829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTalkingByTemplete(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTalkingByTemplete_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 810848, RefRangeEnd = 810849, XrefRangeStart = 810832, XrefRangeEnd = 810848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTalkingByTempleteJob(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTalkingByTempleteJob_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 810899, RefRangeEnd = 810901, XrefRangeStart = 810889, XrefRangeEnd = 810899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAgainestFactionRight(AreaOwnerCell.AreaOwnerData areaState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAgainestFactionRight_Public_Boolean_AreaOwnerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 810925, RefRangeEnd = 810927, XrefRangeStart = 810901, XrefRangeEnd = 810925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAgainestPrivateRight(AreaOwnerCell.AreaOwnerData areaState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAgainestPrivateRight_Public_Boolean_AreaOwnerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 810938, RefRangeEnd = 810942, XrefRangeStart = 810927, XrefRangeEnd = 810938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsItemFond(GameItemInstance gameItemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsItemFond_Public_Boolean_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 810957, RefRangeEnd = 810959, XrefRangeStart = 810942, XrefRangeEnd = 810957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsItemFond(ItemData itemData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsItemFond_Public_Boolean_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810959, XrefRangeEnd = 810985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyRelationForLevelup(int levelups, bool hasLog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&levelups);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyRelationForLevelup_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811048, RefRangeEnd = 811049, XrefRangeStart = 810985, XrefRangeEnd = 811048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckModifyRelationByMoralChange(string moralKey, int modifyValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(moralKey);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &modifyValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckModifyRelationByMoralChange_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 811078, RefRangeEnd = 811084, XrefRangeStart = 811049, XrefRangeEnd = 811078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemUsageChceckResult CouldUseItem(ItemData itemData, bool showLogIfNotOK = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showLogIfNotOK;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldUseItem_Public_ItemUsageChceckResult_ItemData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ItemUsageChceckResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811084, XrefRangeEnd = 811093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseItem(int itemId, bool isInBattle = false, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&itemId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isInBattle;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Void_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811093, XrefRangeEnd = 811102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseItem(string itemName, bool isInBattle = false, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isInBattle;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Void_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 811195, RefRangeEnd = 811199, XrefRangeStart = 811102, XrefRangeEnd = 811195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseItem(ItemData itemData, bool isInBattle = false, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isInBattle;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Void_ItemData_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 811208, RefRangeEnd = 811220, XrefRangeStart = 811199, XrefRangeEnd = 811208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance ApplyBuff(int id, CharacterBuffSource characterBuffSource = CharacterBuffSource.Default, int count = 1, Il2CppStructArray<Il2CppSystem.Decimal> overrideValue = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(CharacterBuffSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterBuffSource;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_Int32_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 811229, RefRangeEnd = 811260, XrefRangeStart = 811220, XrefRangeEnd = 811229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance ApplyBuff(string key, CharacterBuffSource characterBuffSource = CharacterBuffSource.Default, int count = 1, Il2CppStructArray<Il2CppSystem.Decimal> overrideValue = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(CharacterBuffSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterBuffSource;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_String_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 811293, RefRangeEnd = 811306, XrefRangeStart = 811260, XrefRangeEnd = 811293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance ApplyBuff(BuffData buffData, CharacterBuffSource characterBuffSource = CharacterBuffSource.Default, int count = 1, Il2CppStructArray<Il2CppSystem.Decimal> overrideValue = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		*(CharacterBuffSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterBuffSource;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_BuffData_CharacterBuffSource_Int32_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshBuffRedDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshBuffRedDots_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811306, XrefRangeEnd = 811345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearBuffRedDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearBuffRedDots_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811345, XrefRangeEnd = 811347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyInitBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyInitBuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 811415, RefRangeEnd = 811422, XrefRangeStart = 811347, XrefRangeEnd = 811415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyNpcBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyNpcBuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811427, RefRangeEnd = 811428, XrefRangeStart = 811422, XrefRangeEnd = 811427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffEndEffect(BuffInstance buffInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffEndEffect_Public_Void_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 811452, RefRangeEnd = 811454, XrefRangeStart = 811428, XrefRangeEnd = 811452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyBuffTeammateEffect(BuffInstance buffInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuffTeammateEffect_Public_Void_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811476, RefRangeEnd = 811477, XrefRangeStart = 811454, XrefRangeEnd = 811476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBuffTeammateEffect(BuffData buffData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBuffTeammateEffect_Public_Void_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 811709, RefRangeEnd = 811711, XrefRangeStart = 811477, XrefRangeEnd = 811709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyPropFromBuff(Il2CppReferenceArray<KeyWithValues> allKeyWithValues, CharacterBuffSource characterBuffSource = CharacterBuffSource.Default, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allKeyWithValues);
		*(CharacterBuffSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterBuffSource;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyPropFromBuff_Public_Void_Il2CppReferenceArray_1_KeyWithValues_CharacterBuffSource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 811713, RefRangeEnd = 811747, XrefRangeStart = 811711, XrefRangeEnd = 811713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyClearBuffTag(string tag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyClearBuffTag_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 811773, RefRangeEnd = 811775, XrefRangeStart = 811747, XrefRangeEnd = 811773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffTickByQuarter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffTickByQuarter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811775, XrefRangeEnd = 811783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TimeBuffCheck(bool checkRegister = true, bool checkUnregister = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&checkRegister);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkUnregister;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeBuffCheck_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811783, XrefRangeEnd = 811815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BuffInstance> GetElixirBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetElixirBuff_Public_List_1_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuffInstance>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811815, XrefRangeEnd = 811816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestBuff(string buffKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buffKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestBuff_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 811832, RefRangeEnd = 811835, XrefRangeStart = 811816, XrefRangeEnd = 811832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PickupPack(GameItemPack pack, bool hasLog = false, bool isImportant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pack);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isImportant;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickupPack_Public_Void_GameItemPack_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 811866, RefRangeEnd = 811875, XrefRangeStart = 811835, XrefRangeEnd = 811866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<TraitData> GetAllTrait(bool includeHidden = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeHidden);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllTrait_Public_List_1_TraitData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811875, XrefRangeEnd = 811885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TraitData GetTrait(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTrait_Public_TraitData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TraitData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811885, XrefRangeEnd = 811894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTraits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTraits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 811955, RefRangeEnd = 811958, XrefRangeStart = 811894, XrefRangeEnd = 811955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack SetTraits(List<TraitData> newTraits, bool addItemInstant = true, bool equipWeapon = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTraits);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addItemInstant;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &equipWeapon;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTraits_Public_GameItemPack_List_1_TraitData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811958, XrefRangeEnd = 811976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetAdditionTraitWithBuffOnly(int traitId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&traitId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdditionTraitWithBuffOnly_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811976, XrefRangeEnd = 811995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveAdditionTraitWithBuffOnly(int traitId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&traitId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAdditionTraitWithBuffOnly_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 812004, RefRangeEnd = 812007, XrefRangeStart = 811995, XrefRangeEnd = 812004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendlyData GetRelationDataWithPlayer(bool checkDynamicModifier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkDynamicModifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationDataWithPlayer_Public_FriendlyData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FriendlyData>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 812053, RefRangeEnd = 812057, XrefRangeStart = 812019, XrefRangeEnd = 812053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRelationStr(bool isShort, bool checkDynamicModifier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isShort);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkDynamicModifier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationStr_Public_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 812078, RefRangeEnd = 812081, XrefRangeStart = 812057, XrefRangeEnd = 812078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTraits(Il2CppStringArray traits, bool addItemInstant = true, bool epuipWeapon = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traits);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addItemInstant;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &epuipWeapon;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTraits_Public_Void_Il2CppStringArray_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812088, RefRangeEnd = 812089, XrefRangeStart = 812081, XrefRangeEnd = 812088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeRoamingVal(string key, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRoamingVal_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812094, RefRangeEnd = 812095, XrefRangeStart = 812089, XrefRangeEnd = 812094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRoamingVal(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoamingVal_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812103, RefRangeEnd = 812105, XrefRangeStart = 812095, XrefRangeEnd = 812103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetBattleVal(string key, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBattleVal_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812108, RefRangeEnd = 812110, XrefRangeStart = 812105, XrefRangeEnd = 812108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBattleValTotal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBattleValTotal_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 812124, RefRangeEnd = 812128, XrefRangeStart = 812110, XrefRangeEnd = 812124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForgettableEvents GetForgettableEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForgettableEvent_Public_ForgettableEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForgettableEvents>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812138, RefRangeEnd = 812139, XrefRangeStart = 812128, XrefRangeEnd = 812138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldTeach()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldTeach_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 730398, RefRangeEnd = 730400, XrefRangeStart = 730398, XrefRangeEnd = 730400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTeached()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTeached_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812141, RefRangeEnd = 812142, XrefRangeStart = 812139, XrefRangeEnd = 812141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldLearnAbility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldLearnAbility_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812237, RefRangeEnd = 812239, XrefRangeStart = 812142, XrefRangeEnd = 812237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AbilityLevelUp(string key, bool hasLog = true, bool hasCost = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AbilityLevelUp_Public_Boolean_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 812255, RefRangeEnd = 812262, XrefRangeStart = 812239, XrefRangeEnd = 812255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAbilityLevelMaxed(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAbilityLevelMaxed_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 812282, RefRangeEnd = 812287, XrefRangeStart = 812262, XrefRangeEnd = 812282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAbilityLevelUpCost(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbilityLevelUpCost_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 812291, RefRangeEnd = 812294, XrefRangeStart = 812287, XrefRangeEnd = 812291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProtectFaction(FactionData faction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)faction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProtectFaction_Public_Boolean_FactionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812303, RefRangeEnd = 812304, XrefRangeStart = 812294, XrefRangeEnd = 812303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProtectFaction(string factionNameOrId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(factionNameOrId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProtectFaction_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 812311, RefRangeEnd = 812315, XrefRangeStart = 812304, XrefRangeEnd = 812311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProtectCharacter(CharacterPoolData character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProtectCharacter_Public_Boolean_CharacterPoolData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812324, RefRangeEnd = 812325, XrefRangeStart = 812315, XrefRangeEnd = 812324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProtectCharacter(string charaNameOrId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charaNameOrId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProtectCharacter_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 812371, RefRangeEnd = 812375, XrefRangeStart = 812325, XrefRangeEnd = 812371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBond(int other, BondType bondType, bool alsoSetOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&other);
		*(BondType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bondType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoSetOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBond_Public_Void_Int32_BondType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812404, RefRangeEnd = 812406, XrefRangeStart = 812375, XrefRangeEnd = 812404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBond(int other, BondType bondType, bool alsoRemoveOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&other);
		*(BondType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bondType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoRemoveOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBond_Public_Void_Int32_BondType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812407, RefRangeEnd = 812409, XrefRangeStart = 812406, XrefRangeEnd = 812407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasAnyBond()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAnyBond_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 812413, RefRangeEnd = 812430, XrefRangeStart = 812409, XrefRangeEnd = 812413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasBond(int other, BondType bondType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&other);
		*(BondType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bondType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasBond_Public_Boolean_Int32_BondType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812434, RefRangeEnd = 812436, XrefRangeStart = 812430, XrefRangeEnd = 812434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BondType GetBond(int other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBond_Public_BondType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(BondType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 812474, RefRangeEnd = 812477, XrefRangeStart = 812436, XrefRangeEnd = 812474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BondType GetOppssiteBond(BondType bondType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bondType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOppssiteBond_Private_BondType_BondType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(BondType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 812509, RefRangeEnd = 812515, XrefRangeStart = 812477, XrefRangeEnd = 812509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<GameCharacterInstance> GetCharactersByBondType(BondType bondType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bondType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharactersByBondType_Public_HashSet_1_GameCharacterInstance_BondType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameCharacterInstance>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812559, RefRangeEnd = 812561, XrefRangeStart = 812515, XrefRangeEnd = 812559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyZzPoints(string propStr, int point = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyZzPoints_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 812605, RefRangeEnd = 812607, XrefRangeStart = 812561, XrefRangeEnd = 812605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetZzPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetZzPoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 812652, RefRangeEnd = 812658, XrefRangeStart = 812607, XrefRangeEnd = 812652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CountZzPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountZzPoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 812700, RefRangeEnd = 812705, XrefRangeStart = 812658, XrefRangeEnd = 812700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAllocateZzPoint(bool checkIsTeammate = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkIsTeammate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAllocateZzPoint_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 812739, RefRangeEnd = 812740, XrefRangeStart = 812705, XrefRangeEnd = 812739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<string> GetAllJmBuffNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllJmBuffNames_Public_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 812847, RefRangeEnd = 812851, XrefRangeStart = 812740, XrefRangeEnd = 812847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoApplyJmBuff(bool checkIsTeammate = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkIsTeammate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoApplyJmBuff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 813052, RefRangeEnd = 813053, XrefRangeStart = 813024, XrefRangeEnd = 813052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgModeInitCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgModeInitCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 813076, RefRangeEnd = 813089, XrefRangeStart = 813053, XrefRangeEnd = 813076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSlgModeJobForCurrentTurn(SlgActionType job)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&job);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSlgModeJobForCurrentTurn_Public_Void_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 813116, RefRangeEnd = 813118, XrefRangeStart = 813089, XrefRangeEnd = 813116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckSlgMoodOnTurnStart(bool turnAddOne = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&turnAddOne);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSlgMoodOnTurnStart_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 813160, RefRangeEnd = 813161, XrefRangeStart = 813118, XrefRangeEnd = 813160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckSlgMoodOnTurnEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSlgMoodOnTurnEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 813171, RefRangeEnd = 813172, XrefRangeStart = 813161, XrefRangeEnd = 813171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLeaveMapPos(int mapId, Vector3Int pos, TileDirection dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&mapId);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(TileDirection**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLeaveMapPos_Public_Void_Int32_Vector3Int_TileDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 813249, RefRangeEnd = 813251, XrefRangeStart = 813172, XrefRangeEnd = 813249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCharacterInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813251, XrefRangeEnd = 813271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitCharacter_b__252_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitCharacter_b__252_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813271, XrefRangeEnd = 813291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _StroyCheckConditionFromCharaInit_b__253_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StroyCheckConditionFromCharaInit_b__253_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813291, XrefRangeEnd = 813325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _StroyCheckConditionFromCharaInit_b__253_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StroyCheckConditionFromCharaInit_b__253_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813325, XrefRangeEnd = 813345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitCharacterFromLoadedData_b__254_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitCharacterFromLoadedData_b__254_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813345, XrefRangeEnd = 813346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal _CheckCompare_b__413_0(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckCompare_b__413_0_Private_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GameCharacterInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
