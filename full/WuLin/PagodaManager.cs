using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class PagodaManager : MonoSingleton<PagodaManager>
{
	public class BossPot : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_start;

		private static readonly System.IntPtr NativeFieldInfoPtr_pot;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start)) = num;
			}
		}

		public unsafe List<string> pot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pot);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static BossPot()
		{
			Il2CppClassPointerStore<BossPot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "BossPot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossPot>.NativeClassPtr);
			NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossPot>.NativeClassPtr, "start");
			NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossPot>.NativeClassPtr, "pot");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossPot>.NativeClassPtr, 100687879);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BossPot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossPot>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BossPot(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_AddProName;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BATTLE_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_SEED;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnBattleEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaStageBattle0;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaStageBattle1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaStageBattle2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaBossPot;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaMinionPot;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaBossBuffPot;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaNpcAddProCount0;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaNpcAddProValue0;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaNpcAddProCount1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaNpcAddProValue1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaNpcAddProCount2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaNpcAddProValue2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaAddBuffCount1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaAddBuffCount2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaPlayerBuffToSelf;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaPlayerBuffToNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaPrizeBuffNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaScoreDiff0;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaScoreDiff1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaScoreDiff2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaScorePer;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaScoreStageMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigPagodaDefaultScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurDiffculty;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsViewed_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordViewed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadConfig_Private_Void_byref_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadConfig_Private_Void_byref_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadConfig_Private_Void_byref_List_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initConfig_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBattleID_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSeed_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PauseSeed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueSeed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateEnemy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBossPot_Private_List_1_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitEmptySelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDifficulties_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectDiffculty_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayerPrizeSelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectPlayerPrize_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrizeScore_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeScore_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCoin_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMinionInstance_Public_GameCharacterInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBossInstance_Public_GameCharacterInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTempDiffData_Public_Void_GameCharacterInstance_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurStageNpc_Public_Void_byref_List_1_GameCharacterInstance_byref_List_1_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartBattle_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBattleEndEvent_Public_Void_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBattleEvent_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreatePrize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStage_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnablePlayerPrize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisablePlayerPrize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterBattleEvent_b__59_0_Private_Void_Il2CppReferenceArray_1_Object_0;

	public unsafe Il2CppStringArray AddProName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddProName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddProName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe SaveObjectContainer<SaveObjectPagoda> dataContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SaveObjectContainer<SaveObjectPagoda>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)saveObjectContainer));
		}
	}

	public unsafe static int MAX_BATTLE_COUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_BATTLE_COUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_BATTLE_COUNT, (void*)(&num));
		}
	}

	public unsafe static int DEFAULT_SEED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SEED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SEED, (void*)(&num));
		}
	}

	public unsafe Il2CppSystem.Action<bool> OnBattleEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnBattleEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnBattleEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe List<string> ConfigPagodaStageBattle0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaStageBattle0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaStageBattle0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> ConfigPagodaStageBattle1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaStageBattle1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaStageBattle1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> ConfigPagodaStageBattle2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaStageBattle2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaStageBattle2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BossPot> ConfigPagodaBossPot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaBossPot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BossPot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaBossPot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> ConfigPagodaMinionPot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaMinionPot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaMinionPot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ConfigPagodaBossBuffPot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaBossBuffPot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaBossBuffPot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int ConfigPagodaNpcAddProCount0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProCount0);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProCount0)) = num;
		}
	}

	public unsafe int ConfigPagodaNpcAddProValue0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProValue0);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProValue0)) = num;
		}
	}

	public unsafe int ConfigPagodaNpcAddProCount1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProCount1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProCount1)) = num;
		}
	}

	public unsafe int ConfigPagodaNpcAddProValue1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProValue1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProValue1)) = num;
		}
	}

	public unsafe int ConfigPagodaNpcAddProCount2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProCount2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProCount2)) = num;
		}
	}

	public unsafe int ConfigPagodaNpcAddProValue2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProValue2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaNpcAddProValue2)) = num;
		}
	}

	public unsafe int ConfigPagodaAddBuffCount1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaAddBuffCount1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaAddBuffCount1)) = num;
		}
	}

	public unsafe int ConfigPagodaAddBuffCount2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaAddBuffCount2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaAddBuffCount2)) = num;
		}
	}

	public unsafe List<int> ConfigPagodaPlayerBuffToSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaPlayerBuffToSelf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaPlayerBuffToSelf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ConfigPagodaPlayerBuffToNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaPlayerBuffToNpc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaPlayerBuffToNpc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int ConfigPagodaPrizeBuffNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaPrizeBuffNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaPrizeBuffNum)) = num;
		}
	}

	public unsafe float ConfigPagodaScoreDiff0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreDiff0);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreDiff0)) = num;
		}
	}

	public unsafe float ConfigPagodaScoreDiff1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreDiff1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreDiff1)) = num;
		}
	}

	public unsafe float ConfigPagodaScoreDiff2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreDiff2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreDiff2)) = num;
		}
	}

	public unsafe float ConfigPagodaScorePer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScorePer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScorePer)) = num;
		}
	}

	public unsafe float ConfigPagodaScoreStageMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreStageMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaScoreStageMax)) = num;
		}
	}

	public unsafe int ConfigPagodaDefaultScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaDefaultScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigPagodaDefaultScore)) = num;
		}
	}

	public unsafe int CurDiffculty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurDiffculty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurDiffculty)) = num;
		}
	}

	static PagodaManager()
	{
		Il2CppClassPointerStore<PagodaManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "PagodaManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr);
		NativeFieldInfoPtr_AddProName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "AddProName");
		NativeFieldInfoPtr_dataContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "dataContainer");
		NativeFieldInfoPtr_MAX_BATTLE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "MAX_BATTLE_COUNT");
		NativeFieldInfoPtr_DEFAULT_SEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "DEFAULT_SEED");
		NativeFieldInfoPtr_OnBattleEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "OnBattleEnd");
		NativeFieldInfoPtr_ConfigPagodaStageBattle0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaStageBattle0");
		NativeFieldInfoPtr_ConfigPagodaStageBattle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaStageBattle1");
		NativeFieldInfoPtr_ConfigPagodaStageBattle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaStageBattle2");
		NativeFieldInfoPtr_ConfigPagodaBossPot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaBossPot");
		NativeFieldInfoPtr_ConfigPagodaMinionPot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaMinionPot");
		NativeFieldInfoPtr_ConfigPagodaBossBuffPot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaBossBuffPot");
		NativeFieldInfoPtr_ConfigPagodaNpcAddProCount0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaNpcAddProCount0");
		NativeFieldInfoPtr_ConfigPagodaNpcAddProValue0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaNpcAddProValue0");
		NativeFieldInfoPtr_ConfigPagodaNpcAddProCount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaNpcAddProCount1");
		NativeFieldInfoPtr_ConfigPagodaNpcAddProValue1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaNpcAddProValue1");
		NativeFieldInfoPtr_ConfigPagodaNpcAddProCount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaNpcAddProCount2");
		NativeFieldInfoPtr_ConfigPagodaNpcAddProValue2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaNpcAddProValue2");
		NativeFieldInfoPtr_ConfigPagodaAddBuffCount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaAddBuffCount1");
		NativeFieldInfoPtr_ConfigPagodaAddBuffCount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaAddBuffCount2");
		NativeFieldInfoPtr_ConfigPagodaPlayerBuffToSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaPlayerBuffToSelf");
		NativeFieldInfoPtr_ConfigPagodaPlayerBuffToNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaPlayerBuffToNpc");
		NativeFieldInfoPtr_ConfigPagodaPrizeBuffNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaPrizeBuffNum");
		NativeFieldInfoPtr_ConfigPagodaScoreDiff0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaScoreDiff0");
		NativeFieldInfoPtr_ConfigPagodaScoreDiff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaScoreDiff1");
		NativeFieldInfoPtr_ConfigPagodaScoreDiff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaScoreDiff2");
		NativeFieldInfoPtr_ConfigPagodaScorePer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaScorePer");
		NativeFieldInfoPtr_ConfigPagodaScoreStageMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaScoreStageMax");
		NativeFieldInfoPtr_ConfigPagodaDefaultScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "ConfigPagodaDefaultScore");
		NativeFieldInfoPtr_CurDiffculty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, "CurDiffculty");
		NativeMethodInfoPtr_IsViewed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676664);
		NativeMethodInfoPtr_RecordViewed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676665);
		NativeMethodInfoPtr_LoadConfig_Private_Void_byref_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676666);
		NativeMethodInfoPtr_LoadConfig_Private_Void_byref_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676667);
		NativeMethodInfoPtr_LoadConfig_Private_Void_byref_List_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676668);
		NativeMethodInfoPtr_initConfig_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676669);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676670);
		NativeMethodInfoPtr_Clear_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676671);
		NativeMethodInfoPtr_CreateBattleID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676672);
		NativeMethodInfoPtr_InitSeed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676673);
		NativeMethodInfoPtr_PauseSeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676674);
		NativeMethodInfoPtr_ContinueSeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676675);
		NativeMethodInfoPtr_CreateEnemy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676676);
		NativeMethodInfoPtr_GetBossPot_Private_List_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676677);
		NativeMethodInfoPtr_InitEmptySelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676678);
		NativeMethodInfoPtr_CreateDifficulties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676679);
		NativeMethodInfoPtr_SelectDiffculty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676680);
		NativeMethodInfoPtr_CreatePlayerPrizeSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676681);
		NativeMethodInfoPtr_SelectPlayerPrize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676682);
		NativeMethodInfoPtr_PrizeScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676683);
		NativeMethodInfoPtr_ChangeScore_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676684);
		NativeMethodInfoPtr_ChangeCoin_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676685);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676686);
		NativeMethodInfoPtr_CreateMinionInstance_Public_GameCharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676687);
		NativeMethodInfoPtr_CreateBossInstance_Public_GameCharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676688);
		NativeMethodInfoPtr_AddTempDiffData_Public_Void_GameCharacterInstance_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676689);
		NativeMethodInfoPtr_GetCurStageNpc_Public_Void_byref_List_1_GameCharacterInstance_byref_List_1_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676690);
		NativeMethodInfoPtr_StartBattle_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676691);
		NativeMethodInfoPtr_SetBattleEndEvent_Public_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676692);
		NativeMethodInfoPtr_RegisterBattleEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676693);
		NativeMethodInfoPtr_CreateStage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676694);
		NativeMethodInfoPtr_TryCreatePrize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676695);
		NativeMethodInfoPtr_SetStage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676696);
		NativeMethodInfoPtr_EnablePlayerPrize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676697);
		NativeMethodInfoPtr_DisablePlayerPrize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676698);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676699);
		NativeMethodInfoPtr__RegisterBattleEvent_b__59_0_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr, 100676701);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 932508, RefRangeEnd = 932510, XrefRangeStart = 932508, XrefRangeEnd = 932508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsViewed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsViewed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 932510, RefRangeEnd = 932511, XrefRangeStart = 932510, XrefRangeEnd = 932510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordViewed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordViewed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 932519, RefRangeEnd = 932524, XrefRangeStart = 932511, XrefRangeEnd = 932519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadConfig(out float outValue, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref outValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadConfig_Private_Void_byref_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 932532, RefRangeEnd = 932536, XrefRangeStart = 932524, XrefRangeEnd = 932532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadConfig(out int outValue, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref outValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadConfig_Private_Void_byref_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 932558, RefRangeEnd = 932564, XrefRangeStart = 932536, XrefRangeEnd = 932558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadConfig(out List<int> outList, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadConfig_Private_Void_byref_List_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num2 = num;
		outList = ((num2 == 0) ? null : new List<int>(num2));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 932746, RefRangeEnd = 932747, XrefRangeStart = 932564, XrefRangeEnd = 932746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initConfig()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initConfig_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932747, XrefRangeEnd = 932771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932771, XrefRangeEnd = 932783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear(Il2CppReferenceArray<Il2CppSystem.Object> paras = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 932834, RefRangeEnd = 932836, XrefRangeStart = 932783, XrefRangeEnd = 932834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateBattleID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBattleID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 932838, RefRangeEnd = 932840, XrefRangeStart = 932836, XrefRangeEnd = 932838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitSeed(int seed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSeed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 932847, RefRangeEnd = 932850, XrefRangeStart = 932840, XrefRangeEnd = 932847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PauseSeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseSeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932850, XrefRangeEnd = 932851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueSeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueSeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 932935, RefRangeEnd = 932937, XrefRangeStart = 932851, XrefRangeEnd = 932935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateEnemy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateEnemy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 932955, RefRangeEnd = 932956, XrefRangeStart = 932937, XrefRangeEnd = 932955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetBossPot(int stageNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stageNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBossPot_Private_List_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933034, RefRangeEnd = 933035, XrefRangeStart = 932956, XrefRangeEnd = 933034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitEmptySelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitEmptySelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933144, RefRangeEnd = 933145, XrefRangeStart = 933035, XrefRangeEnd = 933144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateDifficulties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDifficulties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933200, RefRangeEnd = 933201, XrefRangeStart = 933145, XrefRangeEnd = 933200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectDiffculty(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectDiffculty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933236, RefRangeEnd = 933237, XrefRangeStart = 933201, XrefRangeEnd = 933236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreatePlayerPrizeSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePlayerPrizeSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933241, RefRangeEnd = 933242, XrefRangeStart = 933237, XrefRangeEnd = 933241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectPlayerPrize(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectPlayerPrize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933242, XrefRangeEnd = 933268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrizeScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrizeScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933268, XrefRangeEnd = 933282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeScore(int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeScore_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933282, XrefRangeEnd = 933290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeCoin(int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCoin_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 933308, RefRangeEnd = 933310, XrefRangeStart = 933290, XrefRangeEnd = 933308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(bool isScoreZero = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isScoreZero);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 933360, RefRangeEnd = 933362, XrefRangeStart = 933310, XrefRangeEnd = 933360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance CreateMinionInstance(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMinionInstance_Public_GameCharacterInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 933421, RefRangeEnd = 933423, XrefRangeStart = 933362, XrefRangeEnd = 933421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance CreateBossInstance(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBossInstance_Public_GameCharacterInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933467, RefRangeEnd = 933468, XrefRangeStart = 933423, XrefRangeEnd = 933467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTempDiffData(GameCharacterInstance npc, bool isBoss, int diffIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBoss;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &diffIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTempDiffData_Public_Void_GameCharacterInstance_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933536, RefRangeEnd = 933537, XrefRangeStart = 933468, XrefRangeEnd = 933536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCurStageNpc(out List<GameCharacterInstance> boss, out List<GameCharacterInstance> minions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		byte* num2 = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurStageNpc_Public_Void_byref_List_1_GameCharacterInstance_byref_List_1_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num4 = num;
		boss = ((num4 == 0) ? null : new List<GameCharacterInstance>(num4));
		nint num5 = num3;
		minions = ((num5 == 0) ? null : new List<GameCharacterInstance>(num5));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 933587, RefRangeEnd = 933588, XrefRangeStart = 933537, XrefRangeEnd = 933587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartBattle(int diffcuty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&diffcuty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartBattle_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 73196, RefRangeEnd = 73201, XrefRangeStart = 73196, XrefRangeEnd = 73201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBattleEndEvent(Il2CppSystem.Action<bool> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBattleEndEvent_Public_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933588, XrefRangeEnd = 933608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterBattleEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBattleEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933608, XrefRangeEnd = 933610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933610, XrefRangeEnd = 933615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryCreatePrize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreatePrize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetStage(int stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933615, XrefRangeEnd = 933623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnablePlayerPrize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnablePlayerPrize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933623, XrefRangeEnd = 933633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisablePlayerPrize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisablePlayerPrize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933633, XrefRangeEnd = 933689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PagodaManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PagodaManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933689, XrefRangeEnd = 933718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterBattleEvent_b__59_0(Il2CppReferenceArray<Il2CppSystem.Object> param)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterBattleEvent_b__59_0_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PagodaManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
