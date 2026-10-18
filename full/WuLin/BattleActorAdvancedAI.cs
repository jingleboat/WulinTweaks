using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using WuLin.StateMachine;

namespace WuLin;

public class BattleActorAdvancedAI : SerializedScriptableObject
{
	public class AdvanceAiActionData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_piror;

		private static readonly System.IntPtr NativeFieldInfoPtr_advancedAIActionType;

		private static readonly System.IntPtr NativeFieldInfoPtr_preCheckConditions;

		private static readonly System.IntPtr NativeFieldInfoPtr_actorScoreRules;

		private static readonly System.IntPtr NativeFieldInfoPtr_minimalScoreToPass;

		private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_ActiveActorStateMachineData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPortentialActionDataFirstPass_Public_List_1_PotentialActionData_ActiveActorStateMachineData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxScorePos_Public_Boolean_PotentialActionData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetActorInArea_Public_List_1_BattleActor_Dictionary_2_Vector3Int_BattleActor_List_1_Vector3Int_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CountAiActionScore_Public_Int32_PotentialActionData_AdvanceAiActionScore_Vector3Int_List_1_BattleActor_List_1_BattleActor_List_1_BattleActor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int piror
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_piror);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_piror)) = num;
			}
		}

		public unsafe AdvancedAIActionType advancedAIActionType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedAIActionType);
				return *(AdvancedAIActionType*)num;
			}
			set
			{
				*(AdvancedAIActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedAIActionType)) = advancedAIActionType;
			}
		}

		public unsafe List<AdvanceAiActionPreCheckCondition> preCheckConditions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preCheckConditions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AdvanceAiActionPreCheckCondition>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preCheckConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<AdvanceAiActionScore> actorScoreRules
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorScoreRules);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AdvanceAiActionScore>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorScoreRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int minimalScoreToPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimalScoreToPass);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimalScoreToPass)) = num;
			}
		}

		static AdvanceAiActionData()
		{
			Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "AdvanceAiActionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr);
			NativeFieldInfoPtr_piror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, "piror");
			NativeFieldInfoPtr_advancedAIActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, "advancedAIActionType");
			NativeFieldInfoPtr_preCheckConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, "preCheckConditions");
			NativeFieldInfoPtr_actorScoreRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, "actorScoreRules");
			NativeFieldInfoPtr_minimalScoreToPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, "minimalScoreToPass");
			NativeMethodInfoPtr_Check_Public_Boolean_ActiveActorStateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, 100686013);
			NativeMethodInfoPtr_GetAllPortentialActionDataFirstPass_Public_List_1_PotentialActionData_ActiveActorStateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, 100686014);
			NativeMethodInfoPtr_GetMaxScorePos_Public_Boolean_PotentialActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, 100686015);
			NativeMethodInfoPtr_GetActorInArea_Public_List_1_BattleActor_Dictionary_2_Vector3Int_BattleActor_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, 100686016);
			NativeMethodInfoPtr_CountAiActionScore_Public_Int32_PotentialActionData_AdvanceAiActionScore_Vector3Int_List_1_BattleActor_List_1_BattleActor_List_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, 100686017);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr, 100686018);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767716, RefRangeEnd = 767717, XrefRangeStart = 767609, XrefRangeEnd = 767716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check(ActiveActorStateMachineData activeActorStateMachineData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_ActiveActorStateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767999, RefRangeEnd = 768000, XrefRangeStart = 767717, XrefRangeEnd = 767999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PotentialActionData> GetAllPortentialActionDataFirstPass(ActiveActorStateMachineData activeActorStateMachineData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPortentialActionDataFirstPass_Public_List_1_PotentialActionData_ActiveActorStateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PotentialActionData>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768139, RefRangeEnd = 768140, XrefRangeStart = 768000, XrefRangeEnd = 768139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetMaxScorePos(PotentialActionData potentialActionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)potentialActionData);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxScorePos_Public_Boolean_PotentialActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 768169, RefRangeEnd = 768172, XrefRangeStart = 768140, XrefRangeEnd = 768169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BattleActor> GetActorInArea(Dictionary<Vector3Int, BattleActor> allActors, List<Vector3Int> effectZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allActors);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectZone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActorInArea_Public_List_1_BattleActor_Dictionary_2_Vector3Int_BattleActor_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768172, XrefRangeEnd = 768176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountAiActionScore(PotentialActionData potentialActionData, AdvanceAiActionScore advanceAiActionScore, Vector3Int movePos, List<BattleActor> enemies, List<BattleActor> friends, List<BattleActor> neutrals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)potentialActionData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advanceAiActionScore);
			*(Vector3Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &movePos;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enemies);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)friends);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)neutrals);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountAiActionScore_Public_Int32_PotentialActionData_AdvanceAiActionScore_Vector3Int_List_1_BattleActor_List_1_BattleActor_List_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768176, XrefRangeEnd = 768189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvanceAiActionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvanceAiActionData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdvanceAiActionData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdvanceAiActionPreCheckCondition : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		static AdvanceAiActionPreCheckCondition()
		{
			Il2CppClassPointerStore<AdvanceAiActionPreCheckCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "AdvanceAiActionPreCheckCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvanceAiActionPreCheckCondition>.NativeClassPtr);
			NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionPreCheckCondition>.NativeClassPtr, 100686019);
			NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionPreCheckCondition>.NativeClassPtr, 100686020);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768189, XrefRangeEnd = 768195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvanceAiActionPreCheckCondition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvanceAiActionPreCheckCondition>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdvanceAiActionPreCheckCondition(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdvanceAiActionPreCheckForbiddenTeamCondition : AdvanceAiActionPreCheckCondition
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_forbiddenTeams;

		private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<BattleTeamEnum> forbiddenTeams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenTeams);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<BattleTeamEnum>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenTeams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static AdvanceAiActionPreCheckForbiddenTeamCondition()
		{
			Il2CppClassPointerStore<AdvanceAiActionPreCheckForbiddenTeamCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "AdvanceAiActionPreCheckForbiddenTeamCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvanceAiActionPreCheckForbiddenTeamCondition>.NativeClassPtr);
			NativeFieldInfoPtr_forbiddenTeams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionPreCheckForbiddenTeamCondition>.NativeClassPtr, "forbiddenTeams");
			NativeMethodInfoPtr_Check_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionPreCheckForbiddenTeamCondition>.NativeClassPtr, 100686021);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionPreCheckForbiddenTeamCondition>.NativeClassPtr, 100686022);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768195, XrefRangeEnd = 768208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Check_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768208, XrefRangeEnd = 768212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvanceAiActionPreCheckForbiddenTeamCondition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvanceAiActionPreCheckForbiddenTeamCondition>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdvanceAiActionPreCheckForbiddenTeamCondition(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdvanceAiActionScore : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_advancedAIScoreType;

		private static readonly System.IntPtr NativeFieldInfoPtr_isMulti;

		private static readonly System.IntPtr NativeFieldInfoPtr_tag;

		private static readonly System.IntPtr NativeFieldInfoPtr_score;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe AdvancedAIScoreType advancedAIScoreType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedAIScoreType);
				return *(AdvancedAIScoreType*)num;
			}
			set
			{
				*(AdvancedAIScoreType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedAIScoreType)) = advancedAIScoreType;
			}
		}

		public unsafe bool isMulti
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMulti);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMulti)) = flag;
			}
		}

		public unsafe string tag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float score
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score)) = num;
			}
		}

		static AdvanceAiActionScore()
		{
			Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "AdvanceAiActionScore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr);
			NativeFieldInfoPtr_advancedAIScoreType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr, "advancedAIScoreType");
			NativeFieldInfoPtr_isMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr, "isMulti");
			NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr, "tag");
			NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr, "score");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr, 100686023);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768212, XrefRangeEnd = 768215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvanceAiActionScore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvanceAiActionScore>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdvanceAiActionScore(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PotentialActionData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actonType;

		private static readonly System.IntPtr NativeFieldInfoPtr_allEffectArea;

		private static readonly System.IntPtr NativeFieldInfoPtr_allEffectActor;

		private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemInstance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe BattleActorActionType actonType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actonType);
				return *(BattleActorActionType*)num;
			}
			set
			{
				*(BattleActorActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actonType)) = battleActorActionType;
			}
		}

		public unsafe HashSet<Vector3Int> allEffectArea
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allEffectArea);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allEffectArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		public unsafe HashSet<BattleActor> allEffectActor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allEffectActor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allEffectActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		public unsafe KungfuInstance kungfuInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
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

		static PotentialActionData()
		{
			Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "PotentialActionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr);
			NativeFieldInfoPtr_actonType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr, "actonType");
			NativeFieldInfoPtr_allEffectArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr, "allEffectArea");
			NativeFieldInfoPtr_allEffectActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr, "allEffectActor");
			NativeFieldInfoPtr_kungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr, "kungfuInstance");
			NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr, "itemInstance");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr, 100686024);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 768228, RefRangeEnd = 768238, XrefRangeStart = 768215, XrefRangeEnd = 768228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotentialActionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotentialActionData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PotentialActionData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdvanceAiActionResult : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_movePos;

		private static readonly System.IntPtr NativeFieldInfoPtr_castPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_actonType;

		private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_advanceAiActionData;

		private static readonly System.IntPtr NativeFieldInfoPtr_totalScore;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3Int movePos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movePos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movePos)) = vector3Int;
			}
		}

		public unsafe Vector3Int castPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_castPos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_castPos)) = vector3Int;
			}
		}

		public unsafe BattleActorActionType actonType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actonType);
				return *(BattleActorActionType*)num;
			}
			set
			{
				*(BattleActorActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actonType)) = battleActorActionType;
			}
		}

		public unsafe KungfuInstance kungfuInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
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

		public unsafe AdvanceAiActionData advanceAiActionData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advanceAiActionData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdvanceAiActionData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advanceAiActionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advanceAiActionData));
			}
		}

		public unsafe int totalScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalScore);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalScore)) = num;
			}
		}

		static AdvanceAiActionResult()
		{
			Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "AdvanceAiActionResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr);
			NativeFieldInfoPtr_movePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "movePos");
			NativeFieldInfoPtr_castPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "castPos");
			NativeFieldInfoPtr_actonType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "actonType");
			NativeFieldInfoPtr_kungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "kungfuInstance");
			NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "itemInstance");
			NativeFieldInfoPtr_advanceAiActionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "advanceAiActionData");
			NativeFieldInfoPtr_totalScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, "totalScore");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr, 100686025);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768238, XrefRangeEnd = 768239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvanceAiActionResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvanceAiActionResult>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdvanceAiActionResult(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MaxScoreData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_potentialActionData;

		private static readonly System.IntPtr NativeFieldInfoPtr_totalScore;

		private static readonly System.IntPtr NativeFieldInfoPtr_movePos;

		private static readonly System.IntPtr NativeFieldInfoPtr_castOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe PotentialActionData potentialActionData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialActionData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PotentialActionData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialActionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)potentialActionData));
			}
		}

		public unsafe int totalScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalScore);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalScore)) = num;
			}
		}

		public unsafe Vector3Int movePos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movePos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movePos)) = vector3Int;
			}
		}

		public unsafe Vector3Int castOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_castOffset);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_castOffset)) = vector3Int;
			}
		}

		static MaxScoreData()
		{
			Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "MaxScoreData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr);
			NativeFieldInfoPtr_potentialActionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr, "potentialActionData");
			NativeFieldInfoPtr_totalScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr, "totalScore");
			NativeFieldInfoPtr_movePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr, "movePos");
			NativeFieldInfoPtr_castOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr, "castOffset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr, 100686026);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768239, XrefRangeEnd = 768240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaxScoreData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxScoreData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaxScoreData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum AdvancedAIActionType
	{
		EnumValueAsmResolver_002EDotNet_002EConstant = 0,
		EnumValueAsmResolver_002EDotNet_002EConstant = 1,
		EnumValueAsmResolver_002EDotNet_002EConstant = 2,
		EnumValueAsmResolver_002EDotNet_002EConstant = 50,
		EnumValueAsmResolver_002EDotNet_002EConstant = 51,
		EnumValueAsmResolver_002EDotNet_002EConstant = 52,
		EnumValueAsmResolver_002EDotNet_002EConstant = 53,
		EnumValueAsmResolver_002EDotNet_002EConstant = 54,
		EnumValueAsmResolver_002EDotNet_002EConstant = 55,
		EnumValueAsmResolver_002EDotNet_002EConstant = 56,
		EnumValueAsmResolver_002EDotNet_002EConstant = 100,
		EnumValueAsmResolver_002EDotNet_002EConstant = 101,
		EnumValueAsmResolver_002EDotNet_002EConstant = 102,
		EnumValueAsmResolver_002EDotNet_002EConstant = 103,
		EnumValueAsmResolver_002EDotNet_002EConstant = 149
	}

	public enum AdvancedAIScoreType
	{
		EnumValueAsmResolver_002EDotNet_002EConstant = 0,
		EnumValueAsmResolver_002EDotNet_002EConstant = 1,
		EnumValueAsmResolver_002EDotNet_002EConstant = 2,
		EnumValueAsmResolver_002EDotNet_002EConstant = 11,
		EnumValueAsmResolver_002EDotNet_002EConstant = 21,
		EnumValueAsmResolver_002EDotNet_002EConstant = 51
	}

	[System.Serializable]
	[ObfuscatedName("WuLin.BattleActorAdvancedAI+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortInEditor_b__11_0_Internal_Int32_AdvanceAiActionData_AdvanceAiActionData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__12_0_Internal_Int32_AdvanceAiActionData_AdvanceAiActionData_0;

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

		public unsafe static Il2CppSystem.Comparison<AdvanceAiActionData> __9__11_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<AdvanceAiActionData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__11_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<AdvanceAiActionData> __9__12_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<AdvanceAiActionData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__12_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__11_0");
			NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__12_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686028);
			NativeMethodInfoPtr__SortInEditor_b__11_0_Internal_Int32_AdvanceAiActionData_AdvanceAiActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686029);
			NativeMethodInfoPtr__Run_b__12_0_Internal_Int32_AdvanceAiActionData_AdvanceAiActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686030);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768240, XrefRangeEnd = 768242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortInEditor_b__11_0(AdvanceAiActionData x, AdvanceAiActionData y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortInEditor_b__11_0_Internal_Int32_AdvanceAiActionData_AdvanceAiActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768242, XrefRangeEnd = 768253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _Run_b__12_0(AdvanceAiActionData x, AdvanceAiActionData y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Run_b__12_0_Internal_Int32_AdvanceAiActionData_AdvanceAiActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleActorAdvancedAI+<>c__DisplayClass14_0`1")]
	public sealed class __c__DisplayClass14_0<T> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetAndCacheObject_b__0_Internal_T_0;

		public unsafe string key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass14_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass14_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass14_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0<T>>.NativeClassPtr, "key");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0<T>>.NativeClassPtr, 100686031);
			NativeMethodInfoPtr__GetAndCacheObject_b__0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0<T>>.NativeClassPtr, 100686032);
		}

		[CallerCount(185)]
		[CachedScanResults(RefRangeStart = 111000, RefRangeEnd = 111185, XrefRangeStart = 111000, XrefRangeEnd = 111185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass14_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass14_0<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768253, XrefRangeEnd = 768258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T _GetAndCacheObject_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetAndCacheObject_b__0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		public __c__DisplayClass14_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetAndCacheObject_Public_Static_T_String_Func_1_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetAndCacheObject_Public_Static_T_String_Func_1_T_Boolean_0, Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetAndCacheObject_Public_Static_T_String_Boolean_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetAndCacheObject_Public_Static_T_String_Boolean_Boolean_0, Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_HasDebugLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedObjectsForOneAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSortedThisRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_random;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeActorStateMachineData;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemPackForAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomPiror;

	private static readonly System.IntPtr NativeFieldInfoPtr_advanceAiActionDatas;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortInEditor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_ActiveActorStateMachineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAndCacheObject_Public_Static_T_String_Func_1_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAndCacheObject_Public_Static_T_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCommonCacheObject_Private_Static_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool HasDebugLog
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HasDebugLog, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HasDebugLog, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<Vector3Int, BattleActor> cachedActors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedActors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, BattleActor>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedActors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, Il2CppSystem.Decimal> cachedVal
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedVal, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedVal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, Il2CppSystem.Object> cachedObjects
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedObjects, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedObjects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static HashSet<string> cachedObjectsForOneAction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedObjectsForOneAction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedObjectsForOneAction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static List<AdvanceAiActionData> dataSortedThisRun
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dataSortedThisRun, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AdvanceAiActionData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dataSortedThisRun, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Il2CppSystem.Random random
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_random, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_random, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random));
		}
	}

	public unsafe static ActiveActorStateMachineData activeActorStateMachineData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeActorStateMachineData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveActorStateMachineData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeActorStateMachineData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData));
		}
	}

	public unsafe static GameItemPack itemPackForAction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_itemPackForAction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_itemPackForAction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe static Dictionary<AdvanceAiActionData, int> randomPiror
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_randomPiror, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AdvanceAiActionData, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_randomPiror, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<AdvanceAiActionData> advanceAiActionDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advanceAiActionDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AdvanceAiActionData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advanceAiActionDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BattleActorAdvancedAI()
	{
		Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActorAdvancedAI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr);
		NativeFieldInfoPtr_HasDebugLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "HasDebugLog");
		NativeFieldInfoPtr_cachedActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "cachedActors");
		NativeFieldInfoPtr_cachedVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "cachedVal");
		NativeFieldInfoPtr_cachedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "cachedObjects");
		NativeFieldInfoPtr_cachedObjectsForOneAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "cachedObjectsForOneAction");
		NativeFieldInfoPtr_dataSortedThisRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "dataSortedThisRun");
		NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "random");
		NativeFieldInfoPtr_activeActorStateMachineData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "activeActorStateMachineData");
		NativeFieldInfoPtr_itemPackForAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "itemPackForAction");
		NativeFieldInfoPtr_randomPiror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "randomPiror");
		NativeFieldInfoPtr_advanceAiActionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, "advanceAiActionDatas");
		NativeMethodInfoPtr_SortInEditor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, 100670975);
		NativeMethodInfoPtr_Run_Public_Void_ActiveActorStateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, 100670976);
		NativeMethodInfoPtr_GetAndCacheObject_Public_Static_T_String_Func_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, 100670977);
		NativeMethodInfoPtr_GetAndCacheObject_Public_Static_T_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, 100670978);
		NativeMethodInfoPtr_GetCommonCacheObject_Private_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, 100670979);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr, 100670980);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768258, XrefRangeEnd = 768326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortInEditor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortInEditor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 768444, RefRangeEnd = 768445, XrefRangeStart = 768326, XrefRangeEnd = 768444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Run(ActiveActorStateMachineData activeActorStateMachineData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Run_Public_Void_ActiveActorStateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768445, XrefRangeEnd = 768476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetAndCacheObject<T>(string key, Il2CppSystem.Func<T> action, bool forceReCache = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceReCache;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetAndCacheObject_Public_Static_T_String_Func_1_T_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 768490, RefRangeEnd = 768501, XrefRangeStart = 768476, XrefRangeEnd = 768490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetAndCacheObject<T>(string key, bool forceReCache = false, bool forOneAction = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceReCache;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forOneAction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetAndCacheObject_Public_Static_T_String_Boolean_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 768569, RefRangeEnd = 768570, XrefRangeStart = 768501, XrefRangeEnd = 768569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object GetCommonCacheObject(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCommonCacheObject_Private_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768570, XrefRangeEnd = 768577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorAdvancedAI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorAdvancedAI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleActorAdvancedAI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
