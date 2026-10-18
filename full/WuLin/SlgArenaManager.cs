using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class SlgArenaManager : MonoSingleton<SlgArenaManager>
{
	public class SlgArenaRoundData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_roundCompleted;

		private static readonly System.IntPtr NativeFieldInfoPtr_slgResultData;

		private static readonly System.IntPtr NativeFieldInfoPtr_completedVersusDataForLastRound;

		private static readonly System.IntPtr NativeFieldInfoPtr_pendingVersusDataForThisRound;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsArenaFinished_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsRoundOver_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetNextVersus_Internal_SlgVersusData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int roundCompleted
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundCompleted);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundCompleted)) = num;
			}
		}

		public unsafe SlgResultData slgResultData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgResultData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgResultData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgResultData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgResultData));
			}
		}

		public unsafe List<SlgVersusData> completedVersusDataForLastRound
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedVersusDataForLastRound);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SlgVersusData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedVersusDataForLastRound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<SlgVersusData> pendingVersusDataForThisRound
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingVersusDataForThisRound);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SlgVersusData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingVersusDataForThisRound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool IsArenaFinished
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 995643, RefRangeEnd = 995646, XrefRangeStart = 995643, XrefRangeEnd = 995643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsArenaFinished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static SlgArenaRoundData()
		{
			Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "SlgArenaRoundData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr);
			NativeFieldInfoPtr_roundCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, "roundCompleted");
			NativeFieldInfoPtr_slgResultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, "slgResultData");
			NativeFieldInfoPtr_completedVersusDataForLastRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, "completedVersusDataForLastRound");
			NativeFieldInfoPtr_pendingVersusDataForThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, "pendingVersusDataForThisRound");
			NativeMethodInfoPtr_get_IsArenaFinished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, 100688565);
			NativeMethodInfoPtr_IsRoundOver_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, 100688566);
			NativeMethodInfoPtr_GetNextVersus_Internal_SlgVersusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, 100688567);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr, 100688568);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 995662, RefRangeEnd = 995665, XrefRangeStart = 995646, XrefRangeEnd = 995662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRoundOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRoundOver_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995681, RefRangeEnd = 995682, XrefRangeStart = 995665, XrefRangeEnd = 995681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlgVersusData GetNextVersus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextVersus_Internal_SlgVersusData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgVersusData>(intPtr) : null;
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlgArenaRoundData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgArenaRoundData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SlgArenaRoundData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SlgResultData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_firstPlace;

		private static readonly System.IntPtr NativeFieldInfoPtr_secondPlace;

		private static readonly System.IntPtr NativeFieldInfoPtr_thirdPlaces;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameCharacterInstance firstPlace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPlace);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPlace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe GameCharacterInstance secondPlace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondPlace);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondPlace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe GameCharacterInstance thirdPlaces
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdPlaces);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdPlaces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		static SlgResultData()
		{
			Il2CppClassPointerStore<SlgResultData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "SlgResultData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgResultData>.NativeClassPtr);
			NativeFieldInfoPtr_firstPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgResultData>.NativeClassPtr, "firstPlace");
			NativeFieldInfoPtr_secondPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgResultData>.NativeClassPtr, "secondPlace");
			NativeFieldInfoPtr_thirdPlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgResultData>.NativeClassPtr, "thirdPlaces");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgResultData>.NativeClassPtr, 100688569);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlgResultData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgResultData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SlgResultData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SlgVersusData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fighterOne;

		private static readonly System.IntPtr NativeFieldInfoPtr_fighterTwo;

		private static readonly System.IntPtr NativeFieldInfoPtr_winner;

		private static readonly System.IntPtr NativeFieldInfoPtr_loser;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameCharacterInstance_GameCharacterInstance_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerInvolved_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		public unsafe GameCharacterInstance fighterOne
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fighterOne);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fighterOne)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe GameCharacterInstance fighterTwo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fighterTwo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fighterTwo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe GameCharacterInstance winner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winner);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe GameCharacterInstance loser
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loser);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		static SlgVersusData()
		{
			Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "SlgVersusData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr);
			NativeFieldInfoPtr_fighterOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, "fighterOne");
			NativeFieldInfoPtr_fighterTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, "fighterTwo");
			NativeFieldInfoPtr_winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, "winner");
			NativeFieldInfoPtr_loser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, "loser");
			NativeMethodInfoPtr__ctor_Public_Void_GameCharacterInstance_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, 100688570);
			NativeMethodInfoPtr_IsPlayerInvolved_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, 100688571);
			NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr, 100688572);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995692, RefRangeEnd = 995693, XrefRangeStart = 995682, XrefRangeEnd = 995692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlgVersusData(GameCharacterInstance fighterOne, GameCharacterInstance fighterTwo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgVersusData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fighterOne);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fighterTwo);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameCharacterInstance_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 995701, RefRangeEnd = 995704, XrefRangeStart = 995693, XrefRangeEnd = 995701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerInvolved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayerInvolved_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 500526, RefRangeEnd = 500545, XrefRangeStart = 500526, XrefRangeEnd = 500545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public SlgVersusData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__CurVersusData_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_allCharacterDataBeforeArenaStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_roundData;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultData;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRunning;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_callBack;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurVersusData_Public_get_SlgVersusData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CurVersusData_Private_set_Void_SlgVersusData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSlgArena_Public_SlgArenaRoundData_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunARound_Public_Void_Action_1_SlgArenaRoundData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFighter_Private_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunNextFight_Private_Void_SlgVersusData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFightComplete_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPersons_Public_List_1_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundDataProcess_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RunARound_b__12_0_Private_Void_Il2CppReferenceArray_1_Object_0;

	public unsafe SlgVersusData _CurVersusData_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurVersusData_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgVersusData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurVersusData_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgVersusData));
		}
	}

	public unsafe Dictionary<GameCharacterInstance, Vector2Int> allCharacterDataBeforeArenaStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allCharacterDataBeforeArenaStarted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameCharacterInstance, Vector2Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allCharacterDataBeforeArenaStarted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe SlgArenaRoundData roundData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgArenaRoundData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgArenaRoundData));
		}
	}

	public unsafe SlgResultData resultData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgResultData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgResultData));
		}
	}

	public unsafe bool isRunning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRunning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRunning)) = flag;
		}
	}

	public unsafe bool isFighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFighting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFighting)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<SlgArenaRoundData> callBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callBack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SlgArenaRoundData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callBack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe SlgVersusData CurVersusData
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurVersusData_Public_get_SlgVersusData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgVersusData>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurVersusData_Private_set_Void_SlgVersusData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SlgArenaManager()
	{
		Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SlgArenaManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr);
		NativeFieldInfoPtr__CurVersusData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "<CurVersusData>k__BackingField");
		NativeFieldInfoPtr_allCharacterDataBeforeArenaStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "allCharacterDataBeforeArenaStarted");
		NativeFieldInfoPtr_roundData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "roundData");
		NativeFieldInfoPtr_resultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "resultData");
		NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "isRunning");
		NativeFieldInfoPtr_isFighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "isFighting");
		NativeFieldInfoPtr_callBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, "callBack");
		NativeMethodInfoPtr_get_CurVersusData_Public_get_SlgVersusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679181);
		NativeMethodInfoPtr_set_CurVersusData_Private_set_Void_SlgVersusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679182);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679183);
		NativeMethodInfoPtr_InitSlgArena_Public_SlgArenaRoundData_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679184);
		NativeMethodInfoPtr_RunARound_Public_Void_Action_1_SlgArenaRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679185);
		NativeMethodInfoPtr_AddFighter_Private_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679186);
		NativeMethodInfoPtr_RunNextFight_Private_Void_SlgVersusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679187);
		NativeMethodInfoPtr_OnFightComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679188);
		NativeMethodInfoPtr_GetAllPersons_Public_List_1_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679189);
		NativeMethodInfoPtr_RoundDataProcess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679190);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679191);
		NativeMethodInfoPtr__RunARound_b__12_0_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr, 100679192);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995704, XrefRangeEnd = 995737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 995799, RefRangeEnd = 995801, XrefRangeStart = 995737, XrefRangeEnd = 995799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgArenaRoundData InitSlgArena(GameCharacterInstance playerFighter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerFighter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSlgArena_Public_SlgArenaRoundData_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgArenaRoundData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 995821, RefRangeEnd = 995822, XrefRangeStart = 995801, XrefRangeEnd = 995821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunARound(Il2CppSystem.Action<SlgArenaRoundData> callBack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callBack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunARound_Public_Void_Action_1_SlgArenaRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 995828, RefRangeEnd = 995829, XrefRangeStart = 995822, XrefRangeEnd = 995828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFighter(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFighter_Private_Void_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 995906, RefRangeEnd = 995907, XrefRangeStart = 995829, XrefRangeEnd = 995906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunNextFight(SlgVersusData slgVersusData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgVersusData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunNextFight_Private_Void_SlgVersusData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 995920, RefRangeEnd = 995921, XrefRangeStart = 995907, XrefRangeEnd = 995920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFightComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFightComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 995930, RefRangeEnd = 995931, XrefRangeStart = 995921, XrefRangeEnd = 995930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameCharacterInstance> GetAllPersons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPersons_Public_List_1_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 995994, RefRangeEnd = 995997, XrefRangeStart = 995931, XrefRangeEnd = 995994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RoundDataProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundDataProcess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995997, XrefRangeEnd = 996003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgArenaManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgArenaManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996003, XrefRangeEnd = 996004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RunARound_b__12_0(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RunARound_b__12_0_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgArenaManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
