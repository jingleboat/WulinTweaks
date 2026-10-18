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
using WuLin.StateMachine;

namespace WuLin;

public class BattleActor : Il2CppSystem.Object
{
	public enum KungfuAvalibleState
	{
		OK,
		EpLow,
		SpUsed,
		NoWeapon,
		AccuUniqueLow,
		PropNotMatch,
		IsCooling,
		NoBondTarget,
		NotInBondArea,
		DisposableUsed
	}

	public sealed class DamageTransferResult : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_damageAfterTransfer;

		private static readonly System.IntPtr NativeFieldInfoPtr_damageTransfered;

		private static readonly System.IntPtr NativeFieldInfoPtr_damageTransferTargets;

		public unsafe int damageAfterTransfer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageAfterTransfer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageAfterTransfer)) = num;
			}
		}

		public unsafe int damageTransfered
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageTransfered);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageTransfered)) = num;
			}
		}

		public unsafe HashSet<BattleActor> damageTransferTargets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageTransferTargets);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageTransferTargets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static DamageTransferResult()
		{
			Il2CppClassPointerStore<DamageTransferResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "DamageTransferResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageTransferResult>.NativeClassPtr);
			NativeFieldInfoPtr_damageAfterTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTransferResult>.NativeClassPtr, "damageAfterTransfer");
			NativeFieldInfoPtr_damageTransfered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTransferResult>.NativeClassPtr, "damageTransfered");
			NativeFieldInfoPtr_damageTransferTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTransferResult>.NativeClassPtr, "damageTransferTargets");
		}

		public DamageTransferResult(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DamageTransferResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageTransferResult>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public class BattleActorProp : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isInBattle;

		private static readonly System.IntPtr NativeFieldInfoPtr_curTolerance;

		private static readonly System.IntPtr NativeFieldInfoPtr_isTemporyBetrayed;

		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_ACTION;

		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACTION;

		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr_battleProps;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempBattlePropDict;

		private static readonly System.IntPtr NativeFieldInfoPtr_cachedInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PropModifyHistroy;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Move_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_EpCostRate_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionRecSpeed_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionRecSpeedWithoutNegSealEffect_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleActorCreateInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RecaculateProp_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceProp_Public_Int32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInstancePropAsDecimal_Public_Decimal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalPropAsRate_Public_String_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CostAction_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NextActionTime_Public_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HasEp_Public_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CostEp_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetProp_Public_Void_BattleActorPropTypes_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetProp_Public_Int32_BattleActorPropTypes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyProp_Public_Void_BattleActorPropTypes_Int32_BattleActor_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPropModifier_Public_Void_BattleActorPropTypes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RecordPropModify_Public_Void_BattleActorPropModify_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClampAllProp_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClampProp_Public_Void_BattleActorPropTypes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClearPropModifies_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FetchPropModifies_Public_List_1_BattleActorPropModify_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LevelupLogic_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RateAccu_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RateDodge_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RateCirt_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RateParry_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetTempProp_Public_Void_String_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyTempProp_Public_Void_String_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTempProp_Public_Decimal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericProp_Public_Decimal_String_0;

		public unsafe bool isInBattle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInBattle);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInBattle)) = flag;
			}
		}

		public unsafe int curTolerance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curTolerance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curTolerance)) = num;
			}
		}

		public unsafe bool isTemporyBetrayed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTemporyBetrayed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTemporyBetrayed)) = flag;
			}
		}

		public unsafe static int MIN_ACTION
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_ACTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_ACTION, (void*)(&num));
			}
		}

		public unsafe static int MAX_ACTION
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ACTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ACTION, (void*)(&num));
			}
		}

		public unsafe float action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action)) = num;
			}
		}

		public unsafe Dictionary<BattleActorPropTypes, int> battleProps
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleProps);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActorPropTypes, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleProps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Dictionary<string, Il2CppSystem.Decimal> tempBattlePropDict
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempBattlePropDict);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Decimal>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempBattlePropDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe BattleActorCreateInfo cachedInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedInfo);
				return new BattleActorCreateInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorCreateInfo)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe List<BattleActorPropModify> m_PropModifyHistroy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PropModifyHistroy);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActorPropModify>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PropModifyHistroy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int Move
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 768589, RefRangeEnd = 768596, XrefRangeStart = 768577, XrefRangeEnd = 768589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Move_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float EpCostRate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 768606, RefRangeEnd = 768607, XrefRangeStart = 768596, XrefRangeEnd = 768606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EpCostRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe int ActionRecSpeed
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 768611, RefRangeEnd = 768617, XrefRangeStart = 768607, XrefRangeEnd = 768611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActionRecSpeed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe int ActionRecSpeedWithoutNegSealEffect
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 768620, RefRangeEnd = 768629, XrefRangeStart = 768617, XrefRangeEnd = 768620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActionRecSpeedWithoutNegSealEffect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float RateAccu
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RateAccu_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float RateDodge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769244, XrefRangeEnd = 769255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RateDodge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float RateCirt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769255, XrefRangeEnd = 769266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RateCirt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float RateParry
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769266, XrefRangeEnd = 769269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RateParry_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static BattleActorProp()
		{
			Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "BattleActorProp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr);
			NativeFieldInfoPtr_isInBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "isInBattle");
			NativeFieldInfoPtr_curTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "curTolerance");
			NativeFieldInfoPtr_isTemporyBetrayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "isTemporyBetrayed");
			NativeFieldInfoPtr_MIN_ACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "MIN_ACTION");
			NativeFieldInfoPtr_MAX_ACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "MAX_ACTION");
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "action");
			NativeFieldInfoPtr_battleProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "battleProps");
			NativeFieldInfoPtr_tempBattlePropDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "tempBattlePropDict");
			NativeFieldInfoPtr_cachedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "cachedInfo");
			NativeFieldInfoPtr_m_PropModifyHistroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, "m_PropModifyHistroy");
			NativeMethodInfoPtr_get_Move_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686033);
			NativeMethodInfoPtr_get_EpCostRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686034);
			NativeMethodInfoPtr_get_ActionRecSpeed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686035);
			NativeMethodInfoPtr_get_ActionRecSpeedWithoutNegSealEffect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686036);
			NativeMethodInfoPtr__ctor_Public_Void_BattleActorCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686037);
			NativeMethodInfoPtr_RecaculateProp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686038);
			NativeMethodInfoPtr_GetInstanceProp_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686039);
			NativeMethodInfoPtr_GetInstancePropAsDecimal_Public_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686040);
			NativeMethodInfoPtr_GetFinalPropAsRate_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686041);
			NativeMethodInfoPtr_CostAction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686042);
			NativeMethodInfoPtr_NextActionTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686043);
			NativeMethodInfoPtr_HasEp_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686044);
			NativeMethodInfoPtr_CostEp_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686045);
			NativeMethodInfoPtr_SetProp_Public_Void_BattleActorPropTypes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686046);
			NativeMethodInfoPtr_GetProp_Public_Int32_BattleActorPropTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686047);
			NativeMethodInfoPtr_ModifyProp_Public_Void_BattleActorPropTypes_Int32_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686048);
			NativeMethodInfoPtr_RegisterPropModifier_Public_Void_BattleActorPropTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686049);
			NativeMethodInfoPtr_RecordPropModify_Public_Void_BattleActorPropModify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686050);
			NativeMethodInfoPtr_ClampAllProp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686051);
			NativeMethodInfoPtr_ClampProp_Public_Void_BattleActorPropTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686052);
			NativeMethodInfoPtr_ClearPropModifies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686053);
			NativeMethodInfoPtr_FetchPropModifies_Public_List_1_BattleActorPropModify_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686054);
			NativeMethodInfoPtr_LevelupLogic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686055);
			NativeMethodInfoPtr_get_RateAccu_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686056);
			NativeMethodInfoPtr_get_RateDodge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686057);
			NativeMethodInfoPtr_get_RateCirt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686058);
			NativeMethodInfoPtr_get_RateParry_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686059);
			NativeMethodInfoPtr_SetTempProp_Public_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686060);
			NativeMethodInfoPtr_ModifyTempProp_Public_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686061);
			NativeMethodInfoPtr_GetTempProp_Public_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686062);
			NativeMethodInfoPtr_GetGenericProp_Public_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr, 100686063);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768649, RefRangeEnd = 768650, XrefRangeStart = 768629, XrefRangeEnd = 768649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleActorProp(BattleActorCreateInfo info)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorProp>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleActorCreateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768700, RefRangeEnd = 768701, XrefRangeStart = 768650, XrefRangeEnd = 768700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecaculateProp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecaculateProp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 768702, RefRangeEnd = 768740, XrefRangeStart = 768701, XrefRangeEnd = 768702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInstanceProp(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceProp_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 768741, RefRangeEnd = 768746, XrefRangeStart = 768740, XrefRangeEnd = 768741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Decimal GetInstancePropAsDecimal(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstancePropAsDecimal_Public_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 768765, RefRangeEnd = 768774, XrefRangeStart = 768746, XrefRangeEnd = 768765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		[CallerCount(0)]
		public unsafe void CostAction(int actionCost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&actionCost);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostAction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768776, RefRangeEnd = 768777, XrefRangeStart = 768774, XrefRangeEnd = 768776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float NextActionTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextActionTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768778, RefRangeEnd = 768779, XrefRangeStart = 768777, XrefRangeEnd = 768778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasEp(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&amount);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasEp_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768779, XrefRangeEnd = 768780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CostEp(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&amount);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostEp_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768784, RefRangeEnd = 768786, XrefRangeStart = 768780, XrefRangeEnd = 768784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProp(BattleActorPropTypes key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&key);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProp_Public_Void_BattleActorPropTypes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(155)]
		[CachedScanResults(RefRangeStart = 768790, RefRangeEnd = 768945, XrefRangeStart = 768786, XrefRangeEnd = 768790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetProp(BattleActorPropTypes key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProp_Public_Int32_BattleActorPropTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 769077, RefRangeEnd = 769092, XrefRangeStart = 768945, XrefRangeEnd = 769077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ModifyProp(BattleActorPropTypes key, int value, BattleActor caster = null, bool needRecord = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&key);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &needRecord;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyProp_Public_Void_BattleActorPropTypes_Int32_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 769100, RefRangeEnd = 769102, XrefRangeStart = 769092, XrefRangeEnd = 769100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPropModifier(BattleActorPropTypes key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterPropModifier_Public_Void_BattleActorPropTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 769110, RefRangeEnd = 769112, XrefRangeStart = 769102, XrefRangeEnd = 769110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPropModify(BattleActorPropModify battleActorPropModify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorPropModify);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordPropModify_Public_Void_BattleActorPropModify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769112, XrefRangeEnd = 769140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampAllProp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAllProp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 769167, RefRangeEnd = 769169, XrefRangeStart = 769140, XrefRangeEnd = 769167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampProp(BattleActorPropTypes key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampProp_Public_Void_BattleActorPropTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 769173, RefRangeEnd = 769179, XrefRangeStart = 769169, XrefRangeEnd = 769173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPropModifies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearPropModifies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 769188, RefRangeEnd = 769207, XrefRangeStart = 769179, XrefRangeEnd = 769188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BattleActorPropModify> FetchPropModifies(bool clearCache = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&clearCache);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchPropModifies_Public_List_1_BattleActorPropModify_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActorPropModify>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769243, RefRangeEnd = 769244, XrefRangeStart = 769207, XrefRangeEnd = 769243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LevelupLogic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelupLogic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 769272, RefRangeEnd = 769287, XrefRangeStart = 769269, XrefRangeEnd = 769272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTempProp(string key, Il2CppSystem.Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTempProp_Public_Void_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769295, RefRangeEnd = 769296, XrefRangeStart = 769287, XrefRangeEnd = 769295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ModifyTempProp(string key, Il2CppSystem.Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyTempProp_Public_Void_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 769304, RefRangeEnd = 769315, XrefRangeStart = 769296, XrefRangeEnd = 769304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Decimal GetTempProp(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTempProp_Public_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769357, RefRangeEnd = 769358, XrefRangeStart = 769315, XrefRangeEnd = 769357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Decimal GetGenericProp(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericProp_Public_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public BattleActorProp(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BattleActorPropModify : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeFieldInfoPtr_oldVal;

		private static readonly System.IntPtr NativeFieldInfoPtr_newVal;

		private static readonly System.IntPtr NativeFieldInfoPtr_changed;

		private static readonly System.IntPtr NativeFieldInfoPtr_nextModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_Boolean_BattleActorPropModify_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToList_Public_List_1_BattleActorPropModify_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLastModifier_Public_BattleActorPropModify_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalChangedValue_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe BattleActorPropTypes key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				return *(BattleActorPropTypes*)num;
			}
			set
			{
				*(BattleActorPropTypes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)) = battleActorPropTypes;
			}
		}

		public unsafe int oldVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldVal);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldVal)) = num;
			}
		}

		public unsafe int newVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newVal);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newVal)) = num;
			}
		}

		public unsafe int changed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changed);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changed)) = num;
			}
		}

		public unsafe BattleActorPropModify nextModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextModifier);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorPropModify>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextModifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorPropModify));
			}
		}

		static BattleActorPropModify()
		{
			Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "BattleActorPropModify");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr);
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, "key");
			NativeFieldInfoPtr_oldVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, "oldVal");
			NativeFieldInfoPtr_newVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, "newVal");
			NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, "changed");
			NativeFieldInfoPtr_nextModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, "nextModifier");
			NativeMethodInfoPtr_Merge_Public_Boolean_BattleActorPropModify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, 100686064);
			NativeMethodInfoPtr_ToList_Public_List_1_BattleActorPropModify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, 100686065);
			NativeMethodInfoPtr_GetLastModifier_Public_BattleActorPropModify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, 100686066);
			NativeMethodInfoPtr_GetTotalChangedValue_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, 100686067);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr, 100686068);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 769362, RefRangeEnd = 769365, XrefRangeStart = 769358, XrefRangeEnd = 769362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Merge(BattleActorPropModify other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Merge_Public_Boolean_BattleActorPropModify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 769374, RefRangeEnd = 769376, XrefRangeStart = 769365, XrefRangeEnd = 769374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BattleActorPropModify> ToList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToList_Public_List_1_BattleActorPropModify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActorPropModify>>(intPtr) : null;
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 769377, RefRangeEnd = 769381, XrefRangeStart = 769376, XrefRangeEnd = 769377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleActorPropModify GetLastModifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastModifier_Public_BattleActorPropModify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorPropModify>(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe int GetTotalChangedValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalChangedValue_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleActorPropModify()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorPropModify>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BattleActorPropModify(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BattleActorBonusActionData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeFieldInfoPtr_couldMove;

		private static readonly System.IntPtr NativeFieldInfoPtr_couldUseAction;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppSystem.Object source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe bool couldMove
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldMove);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldMove)) = flag;
			}
		}

		public unsafe bool couldUseAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldUseAction);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldUseAction)) = flag;
			}
		}

		static BattleActorBonusActionData()
		{
			Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "BattleActorBonusActionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr);
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr, "source");
			NativeFieldInfoPtr_couldMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr, "couldMove");
			NativeFieldInfoPtr_couldUseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr, "couldUseAction");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr, 100686069);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleActorBonusActionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorBonusActionData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BattleActorBonusActionData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdditionAction : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isApplied;

		private static readonly System.IntPtr NativeFieldInfoPtr_weight;

		private static readonly System.IntPtr NativeFieldInfoPtr_onTriggered;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool isApplied
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isApplied);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isApplied)) = flag;
			}
		}

		public unsafe int weight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight)) = num;
			}
		}

		public unsafe Il2CppSystem.Action onTriggered
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTriggered);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTriggered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static AdditionAction()
		{
			Il2CppClassPointerStore<AdditionAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "AdditionAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionAction>.NativeClassPtr);
			NativeFieldInfoPtr_isApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionAction>.NativeClassPtr, "isApplied");
			NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionAction>.NativeClassPtr, "weight");
			NativeFieldInfoPtr_onTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionAction>.NativeClassPtr, "onTriggered");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionAction>.NativeClassPtr, 100686070);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditionAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionAction>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdditionAction(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum BattleActorPropTypes
	{
		Hp = 1,
		HpMax = 2,
		Ep = 3,
		EpMax = 4,
		NegPoison = 100,
		NegInjure = 101,
		NegSeal = 102,
		NegBleed = 103,
		NegBlind = 104,
		AccuDef = 200,
		AccuAtk = 201,
		AccuDefMax = 203,
		BattleWine = 300,
		BattleMedicine = 301
	}

	public enum BattleActorState
	{
		Normal,
		Dead
	}

	[ObfuscatedName("WuLin.BattleActor+<>c__DisplayClass103_0")]
	public sealed class __c__DisplayClass103_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_saveDataIndexDict;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetAllActiveKungfu_b__0_Internal_Int32_KungfuInstance_KungfuInstance_0;

		public unsafe Dictionary<KungfuInstance, int> saveDataIndexDict
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveDataIndexDict);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<KungfuInstance, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveDataIndexDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static __c__DisplayClass103_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass103_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<>c__DisplayClass103_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass103_0>.NativeClassPtr);
			NativeFieldInfoPtr_saveDataIndexDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass103_0>.NativeClassPtr, "saveDataIndexDict");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass103_0>.NativeClassPtr, 100686071);
			NativeMethodInfoPtr__GetAllActiveKungfu_b__0_Internal_Int32_KungfuInstance_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass103_0>.NativeClassPtr, 100686072);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass103_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass103_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769381, XrefRangeEnd = 769387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetAllActiveKungfu_b__0(KungfuInstance a, KungfuInstance b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetAllActiveKungfu_b__0_Internal_Int32_KungfuInstance_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass103_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("WuLin.BattleActor+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__139_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__162_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CheckCounterAttackCurrentActorInAction_b__139_0_Internal_Int32_KungfuInstance_KungfuInstance_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__HasUnUsedWife_b__162_0_Internal_Boolean_KungfuInstance_0;

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

		public unsafe static Il2CppSystem.Comparison<KungfuInstance> __9__139_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__139_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<KungfuInstance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__139_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<KungfuInstance> __9__162_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__162_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<KungfuInstance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__162_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__139_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__139_0");
			NativeFieldInfoPtr___9__162_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__162_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686074);
			NativeMethodInfoPtr__CheckCounterAttackCurrentActorInAction_b__139_0_Internal_Int32_KungfuInstance_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686075);
			NativeMethodInfoPtr__HasUnUsedWife_b__162_0_Internal_Boolean_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686076);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769387, XrefRangeEnd = 769388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _CheckCounterAttackCurrentActorInAction_b__139_0(KungfuInstance x, KungfuInstance y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckCounterAttackCurrentActorInAction_b__139_0_Internal_Int32_KungfuInstance_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _HasUnUsedWife_b__162_0(KungfuInstance a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HasUnUsedWife_b__162_0_Internal_Boolean_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mainActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueHasUseLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleActorProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_actorView;

	private static readonly System.IntPtr NativeFieldInfoPtr_actorPositionInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_actorDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAI;

	private static readonly System.IntPtr NativeFieldInfoPtr_killCountInBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectsCachedByPropModify;

	private static readonly System.IntPtr NativeFieldInfoPtr__ActionRecSpeedRaw_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_offendEventThisTurn;

	private static readonly System.IntPtr NativeFieldInfoPtr__hasDualStrike_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__triggeredDualStrike_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__additionAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedActionModify_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_summonMaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBetrayedTeammate;

	private static readonly System.IntPtr NativeFieldInfoPtr__aurasEffected_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffsFromAura;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleActorState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceDead;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Retreat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreezeCdThisTurn;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedAllieTiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedBlockTiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_senseDist;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedSenseZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedSenseCenterForSense;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedDirectionForSense;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedBonusActionData;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuCd;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedFriendBuffTier;

	private static readonly System.IntPtr NativeFieldInfoPtr_usedConsumedItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_oneTimeDamageTransfer;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OppositeTeam_Public_get_BattleTeamEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ServeBattleTeam_Public_get_BattleTeamEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInBattle_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsInBattle_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actorViewPos_Public_get_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actorViewDir_Public_get_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDeadOnBattle_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRetreat_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSitting_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NextActionTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionRecSpeed_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionRecSpeedRaw_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ActionRecSpeedRaw_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasDualStrike_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasDualStrike_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_triggeredDualStrike_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_triggeredDualStrike_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionAction_Public_get_AdditionAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionAction_Private_set_Void_AdditionAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cachedActionModify_Public_get_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cachedActionModify_Private_set_Void_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aurasEffected_Public_get_HashSet_1_BattleAuraInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_aurasEffected_Private_set_Void_HashSet_1_BattleAuraInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SenseDist_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleActorCreateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_byref_Dictionary_2_Vector3Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_Int32_byref_Dictionary_2_Vector3Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheAllieAndBlock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyAction_Public_Boolean_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActionTick_Public_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveActionCost_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Damage_Public_Void_Int32_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Heal_Public_Void_Int32_Int32_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyProp_Public_Void_BattleActorPropTypes_Int32_Boolean_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAlive_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Retreat_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBattleStart_Public_BattleActorPropModifiedEvent_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInternalKungfuEffectEvents_Public_InternalKungfuEffectEvent_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBattleTimeTick_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActorIsReady_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOtherActorIsReady_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestMoveArea_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceProp_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstancePropAsDecimal_Public_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitActorStateMachineData_Public_Void_ActiveActorStateMachineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllActiveKungfu_Public_List_1_KungfuInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllBasicAttacks_Public_List_1_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllInternalKungfu_Public_List_1_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKungfuAvalible_Public_Boolean_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKungfuAvalible_Public_Boolean_KungfuInstance_byref_KungfuAvalibleState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKungfuNeedRemoveWeaponToCast_Public_Boolean_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstBondKungfuTarget_Public_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseKungfu_Public_Int32_KungfuInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExpInBattle_Public_Int32_Int32_BattleFieldEvent_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GalcBattleExpByKill_Public_Int32_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Void_GameItemInstance_BattleActor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_Int32_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_String_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_BuffData_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_Int32_BattleActor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_String_BattleActor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_BuffData_BattleActor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyPropFromConfig_Public_Void_String_Decimal_Boolean_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemPack_Public_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItemUsage_Public_Void_GameItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnConsumedItemToPack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestUseItem_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFlankPos_Public_Boolean_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBackStabPos_Public_Boolean_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyKungfuCd_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuCd_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuMaxCd_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllKungfuCd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWillHarmNeutralLikeEnemy_Public_Boolean_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActorAuraChanged_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshAuraEffect_Public_Void_HashSet_1_BattleAuraInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterOneTimeDamageTransfer_Public_Void_DamageTransfer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearOneTimeDamageTransfer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCounterAttackCurrentActorInAction_Public_CounterAttackActionAdditionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsAwake_Public_Boolean_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSenseZone_Public_HashSet_1_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBattleOffend_Public_Boolean_String_BattleOffendAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearOffendHistroy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxToleranceReached_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalBattleOffend_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCoward_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatEffectEventFromCachedEffectList_Public_EffectOnActorEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAdditionAction_Public_Boolean_Int32_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriggerAdditionActionEffect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAdditionAction_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCouldDualStrike_Public_Boolean_KungfuActionCastData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDualStrike_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriggerDualStrike_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WillDualStrike_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDualStrike_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsBetrayed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyFriendBuff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasUnUsedWife_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAllInternalKungfuExp_Public_Void_0;

	public unsafe static BattleActor mainActor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainActor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainActor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe static bool uniqueHasUseLimit
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uniqueHasUseLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uniqueHasUseLimit, (void*)(&flag));
		}
	}

	public unsafe BattleTeamEnum battleTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleTeam);
			return *(BattleTeamEnum*)num;
		}
		set
		{
			*(BattleTeamEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleTeam)) = battleTeamEnum;
		}
	}

	public unsafe BattleActorProp battleActorProp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorProp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorProp>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorProp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorProp));
		}
	}

	public unsafe ActorViewElemenetAdapator actorView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorViewElemenetAdapator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorViewElemenetAdapator));
		}
	}

	public unsafe Vector3Int actorPositionInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorPositionInt);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorPositionInt)) = vector3Int;
		}
	}

	public unsafe TileDirection actorDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorDir);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorDir)) = tileDirection;
		}
	}

	public unsafe bool isAI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAI);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAI)) = flag;
		}
	}

	public unsafe Dictionary<string, int> killCountInBattle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killCountInBattle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killCountInBattle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<string> m_EffectsCachedByPropModify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EffectsCachedByPropModify);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EffectsCachedByPropModify)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int _ActionRecSpeedRaw_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ActionRecSpeedRaw_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ActionRecSpeedRaw_k__BackingField)) = num;
		}
	}

	public unsafe BattleActorCreateInfo info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			return new BattleActorCreateInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorCreateInfo)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe List<string> offendEventThisTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offendEventThisTurn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offendEventThisTurn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool _hasDualStrike_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasDualStrike_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasDualStrike_k__BackingField)) = flag;
		}
	}

	public unsafe bool _triggeredDualStrike_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__triggeredDualStrike_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__triggeredDualStrike_k__BackingField)) = flag;
		}
	}

	public unsafe AdditionAction _additionAction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionAction_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdditionAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionAction_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionAction));
		}
	}

	public unsafe List<int> _cachedActionModify_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedActionModify_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedActionModify_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleActor summonMaster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonMaster);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summonMaster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe bool isBetrayedTeammate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBetrayedTeammate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBetrayedTeammate)) = flag;
		}
	}

	public unsafe HashSet<BattleAuraInstance> _aurasEffected_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aurasEffected_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleAuraInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aurasEffected_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<BattleAuraInstance, List<BuffInstance>> buffsFromAura
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffsFromAura);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleAuraInstance, List<BuffInstance>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffsFromAura)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe BattleActorState battleActorState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorState);
			return *(BattleActorState*)num;
		}
		set
		{
			*(BattleActorState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorState)) = battleActorState;
		}
	}

	public unsafe bool m_ForceDead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceDead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceDead)) = flag;
		}
	}

	public unsafe bool m_Retreat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Retreat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Retreat)) = flag;
		}
	}

	public unsafe bool m_FreezeCdThisTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreezeCdThisTurn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreezeCdThisTurn)) = flag;
		}
	}

	public unsafe List<Vector3Int> cachedAllieTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedAllieTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedAllieTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3Int> cachedBlockTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBlockTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBlockTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int senseDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senseDist);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senseDist)) = num;
		}
	}

	public unsafe HashSet<Vector3Int> cachedSenseZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSenseZone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSenseZone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Vector3Int cachedSenseCenterForSense
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSenseCenterForSense);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSenseCenterForSense)) = vector3Int;
		}
	}

	public unsafe TileDirection cachedDirectionForSense
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDirectionForSense);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDirectionForSense)) = tileDirection;
		}
	}

	public unsafe BattleActorBonusActionData cachedBonusActionData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBonusActionData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorBonusActionData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBonusActionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorBonusActionData));
		}
	}

	public unsafe Dictionary<int, int> kungfuCd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuCd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuCd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int cachedFriendBuffTier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedFriendBuffTier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedFriendBuffTier)) = num;
		}
	}

	public unsafe Dictionary<string, int> usedConsumedItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedConsumedItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedConsumedItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<DamageTransfer> oneTimeDamageTransfer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneTimeDamageTransfer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DamageTransfer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneTimeDamageTransfer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleTeamEnum OppositeTeam
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769388, RefRangeEnd = 769389, XrefRangeStart = 769388, XrefRangeEnd = 769388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OppositeTeam_Public_get_BattleTeamEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(BattleTeamEnum*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe BattleTeamEnum ServeBattleTeam
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 769389, RefRangeEnd = 769414, XrefRangeStart = 769389, XrefRangeEnd = 769389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ServeBattleTeam_Public_get_BattleTeamEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(BattleTeamEnum*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsInBattle
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 769414, RefRangeEnd = 769428, XrefRangeStart = 769414, XrefRangeEnd = 769414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsInBattle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 769428, RefRangeEnd = 769431, XrefRangeStart = 769428, XrefRangeEnd = 769428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsInBattle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3Int actorViewPos
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769440, RefRangeEnd = 769441, XrefRangeStart = 769431, XrefRangeEnd = 769440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actorViewPos_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe TileDirection actorViewDir
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 769443, RefRangeEnd = 769446, XrefRangeStart = 769441, XrefRangeEnd = 769443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actorViewDir_Public_get_TileDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsAlive
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 769446, RefRangeEnd = 769472, XrefRangeStart = 769446, XrefRangeEnd = 769446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe bool IsDeadOnBattle
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 769472, RefRangeEnd = 769478, XrefRangeStart = 769472, XrefRangeEnd = 769472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDeadOnBattle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsRetreat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRetreat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsSitting
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 769486, RefRangeEnd = 769488, XrefRangeStart = 769478, XrefRangeEnd = 769486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float NextActionTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769490, RefRangeEnd = 769491, XrefRangeStart = 769488, XrefRangeEnd = 769490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NextActionTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int ActionRecSpeed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769491, XrefRangeEnd = 769493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActionRecSpeed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int ActionRecSpeedRaw
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31148, RefRangeEnd = 31152, XrefRangeStart = 31148, XrefRangeEnd = 31152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActionRecSpeedRaw_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ActionRecSpeedRaw_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool hasDualStrike
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDualStrike_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasDualStrike_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool triggeredDualStrike
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triggeredDualStrike_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_triggeredDualStrike_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe AdditionAction additionAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionAction_Public_get_AdditionAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdditionAction>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionAction_Private_set_Void_AdditionAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<int> cachedActionModify
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cachedActionModify_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cachedActionModify_Private_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<BattleAuraInstance> aurasEffected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aurasEffected_Public_get_HashSet_1_BattleAuraInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleAuraInstance>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aurasEffected_Private_set_Void_HashSet_1_BattleAuraInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int SenseDist
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769493, XrefRangeEnd = 769513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SenseDist_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BattleActor()
	{
		Il2CppClassPointerStore<BattleActor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActor>.NativeClassPtr);
		NativeFieldInfoPtr_mainActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "mainActor");
		NativeFieldInfoPtr_uniqueHasUseLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "uniqueHasUseLimit");
		NativeFieldInfoPtr_battleTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "battleTeam");
		NativeFieldInfoPtr_battleActorProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "battleActorProp");
		NativeFieldInfoPtr_actorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "actorView");
		NativeFieldInfoPtr_actorPositionInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "actorPositionInt");
		NativeFieldInfoPtr_actorDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "actorDir");
		NativeFieldInfoPtr_isAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "isAI");
		NativeFieldInfoPtr_killCountInBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "killCountInBattle");
		NativeFieldInfoPtr_m_EffectsCachedByPropModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "m_EffectsCachedByPropModify");
		NativeFieldInfoPtr__ActionRecSpeedRaw_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<ActionRecSpeedRaw>k__BackingField");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "info");
		NativeFieldInfoPtr_offendEventThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "offendEventThisTurn");
		NativeFieldInfoPtr__hasDualStrike_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<hasDualStrike>k__BackingField");
		NativeFieldInfoPtr__triggeredDualStrike_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<triggeredDualStrike>k__BackingField");
		NativeFieldInfoPtr__additionAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<additionAction>k__BackingField");
		NativeFieldInfoPtr__cachedActionModify_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<cachedActionModify>k__BackingField");
		NativeFieldInfoPtr_summonMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "summonMaster");
		NativeFieldInfoPtr_isBetrayedTeammate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "isBetrayedTeammate");
		NativeFieldInfoPtr__aurasEffected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "<aurasEffected>k__BackingField");
		NativeFieldInfoPtr_buffsFromAura = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "buffsFromAura");
		NativeFieldInfoPtr_battleActorState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "battleActorState");
		NativeFieldInfoPtr_m_ForceDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "m_ForceDead");
		NativeFieldInfoPtr_m_Retreat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "m_Retreat");
		NativeFieldInfoPtr_m_FreezeCdThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "m_FreezeCdThisTurn");
		NativeFieldInfoPtr_cachedAllieTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedAllieTiles");
		NativeFieldInfoPtr_cachedBlockTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedBlockTiles");
		NativeFieldInfoPtr_senseDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "senseDist");
		NativeFieldInfoPtr_cachedSenseZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedSenseZone");
		NativeFieldInfoPtr_cachedSenseCenterForSense = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedSenseCenterForSense");
		NativeFieldInfoPtr_cachedDirectionForSense = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedDirectionForSense");
		NativeFieldInfoPtr_cachedBonusActionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedBonusActionData");
		NativeFieldInfoPtr_kungfuCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "kungfuCd");
		NativeFieldInfoPtr_cachedFriendBuffTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "cachedFriendBuffTier");
		NativeFieldInfoPtr_usedConsumedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "usedConsumedItems");
		NativeFieldInfoPtr_oneTimeDamageTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, "oneTimeDamageTransfer");
		NativeMethodInfoPtr_get_OppositeTeam_Public_get_BattleTeamEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670982);
		NativeMethodInfoPtr_get_ServeBattleTeam_Public_get_BattleTeamEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670983);
		NativeMethodInfoPtr_get_IsInBattle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670984);
		NativeMethodInfoPtr_set_IsInBattle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670985);
		NativeMethodInfoPtr_get_actorViewPos_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670986);
		NativeMethodInfoPtr_get_actorViewDir_Public_get_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670987);
		NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670988);
		NativeMethodInfoPtr_get_IsDeadOnBattle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670989);
		NativeMethodInfoPtr_get_IsRetreat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670990);
		NativeMethodInfoPtr_get_IsSitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670991);
		NativeMethodInfoPtr_get_NextActionTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670992);
		NativeMethodInfoPtr_get_ActionRecSpeed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670993);
		NativeMethodInfoPtr_get_ActionRecSpeedRaw_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670994);
		NativeMethodInfoPtr_set_ActionRecSpeedRaw_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670995);
		NativeMethodInfoPtr_get_hasDualStrike_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670996);
		NativeMethodInfoPtr_set_hasDualStrike_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670997);
		NativeMethodInfoPtr_get_triggeredDualStrike_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670998);
		NativeMethodInfoPtr_set_triggeredDualStrike_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100670999);
		NativeMethodInfoPtr_get_additionAction_Public_get_AdditionAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671000);
		NativeMethodInfoPtr_set_additionAction_Private_set_Void_AdditionAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671001);
		NativeMethodInfoPtr_get_cachedActionModify_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671002);
		NativeMethodInfoPtr_set_cachedActionModify_Private_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671003);
		NativeMethodInfoPtr_get_aurasEffected_Public_get_HashSet_1_BattleAuraInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671004);
		NativeMethodInfoPtr_set_aurasEffected_Private_set_Void_HashSet_1_BattleAuraInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671005);
		NativeMethodInfoPtr_get_SenseDist_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671006);
		NativeMethodInfoPtr__ctor_Public_Void_BattleActorCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671007);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671008);
		NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_byref_Dictionary_2_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671009);
		NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_Int32_byref_Dictionary_2_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671010);
		NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671011);
		NativeMethodInfoPtr_CacheAllieAndBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671012);
		NativeMethodInfoPtr_ModifyAction_Public_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671013);
		NativeMethodInfoPtr_ActionTick_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671014);
		NativeMethodInfoPtr_ActiveActionCost_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671015);
		NativeMethodInfoPtr_MoveTo_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671016);
		NativeMethodInfoPtr_Damage_Public_Void_Int32_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671017);
		NativeMethodInfoPtr_Heal_Public_Void_Int32_Int32_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671018);
		NativeMethodInfoPtr_ModifyProp_Public_Void_BattleActorPropTypes_Int32_Boolean_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671019);
		NativeMethodInfoPtr_CheckAlive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671020);
		NativeMethodInfoPtr_Kill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671021);
		NativeMethodInfoPtr_Retreat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671022);
		NativeMethodInfoPtr_OnBattleStart_Public_BattleActorPropModifiedEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671023);
		NativeMethodInfoPtr_CreateInternalKungfuEffectEvents_Public_InternalKungfuEffectEvent_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671024);
		NativeMethodInfoPtr_OnBattleTimeTick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671025);
		NativeMethodInfoPtr_OnActorIsReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671026);
		NativeMethodInfoPtr_OnOtherActorIsReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671027);
		NativeMethodInfoPtr_TestMoveArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671028);
		NativeMethodInfoPtr_GetInstanceProp_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671029);
		NativeMethodInfoPtr_GetInstancePropAsDecimal_Public_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671030);
		NativeMethodInfoPtr_InitActorStateMachineData_Public_Void_ActiveActorStateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671031);
		NativeMethodInfoPtr_GetAllActiveKungfu_Public_List_1_KungfuInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671032);
		NativeMethodInfoPtr_GetAllBasicAttacks_Public_List_1_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671033);
		NativeMethodInfoPtr_GetAllInternalKungfu_Public_List_1_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671034);
		NativeMethodInfoPtr_IsKungfuAvalible_Public_Boolean_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671035);
		NativeMethodInfoPtr_IsKungfuAvalible_Public_Boolean_KungfuInstance_byref_KungfuAvalibleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671036);
		NativeMethodInfoPtr_IsKungfuNeedRemoveWeaponToCast_Public_Boolean_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671037);
		NativeMethodInfoPtr_GetFirstBondKungfuTarget_Public_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671038);
		NativeMethodInfoPtr_UseKungfu_Public_Int32_KungfuInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671039);
		NativeMethodInfoPtr_GetExpInBattle_Public_Int32_Int32_BattleFieldEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671040);
		NativeMethodInfoPtr_GalcBattleExpByKill_Public_Int32_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671041);
		NativeMethodInfoPtr_UseItem_Public_Void_GameItemInstance_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671042);
		NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_Int32_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671043);
		NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_String_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671044);
		NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_BuffData_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671045);
		NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_Int32_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671046);
		NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_String_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671047);
		NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_BuffData_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671048);
		NativeMethodInfoPtr_ModifyPropFromConfig_Public_Void_String_Decimal_Boolean_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671049);
		NativeMethodInfoPtr_GetItemPack_Public_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671050);
		NativeMethodInfoPtr_RegisterItemUsage_Public_Void_GameItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671051);
		NativeMethodInfoPtr_ReturnConsumedItemToPack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671052);
		NativeMethodInfoPtr_TestUseItem_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671053);
		NativeMethodInfoPtr_IsFlankPos_Public_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671054);
		NativeMethodInfoPtr_IsBackStabPos_Public_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671055);
		NativeMethodInfoPtr_ApplyKungfuCd_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671056);
		NativeMethodInfoPtr_GetKungfuCd_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671057);
		NativeMethodInfoPtr_GetKungfuMaxCd_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671058);
		NativeMethodInfoPtr_ClearAllKungfuCd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671059);
		NativeMethodInfoPtr_IsWillHarmNeutralLikeEnemy_Public_Boolean_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671060);
		NativeMethodInfoPtr_OnActorAuraChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671061);
		NativeMethodInfoPtr_RefreshAuraEffect_Public_Void_HashSet_1_BattleAuraInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671062);
		NativeMethodInfoPtr_RegisterOneTimeDamageTransfer_Public_Void_DamageTransfer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671063);
		NativeMethodInfoPtr_ClearOneTimeDamageTransfer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671064);
		NativeMethodInfoPtr_CheckCounterAttackCurrentActorInAction_Public_CounterAttackActionAdditionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671065);
		NativeMethodInfoPtr_CheckIsAwake_Public_Boolean_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671066);
		NativeMethodInfoPtr_GetSenseZone_Public_HashSet_1_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671067);
		NativeMethodInfoPtr_SetBattleOffend_Public_Boolean_String_BattleOffendAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671068);
		NativeMethodInfoPtr_ClearOffendHistroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671069);
		NativeMethodInfoPtr_MaxToleranceReached_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671070);
		NativeMethodInfoPtr_GetTotalBattleOffend_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671071);
		NativeMethodInfoPtr_IsCoward_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671072);
		NativeMethodInfoPtr_CreatEffectEventFromCachedEffectList_Public_EffectOnActorEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671073);
		NativeMethodInfoPtr_AddAdditionAction_Public_Boolean_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671074);
		NativeMethodInfoPtr_TriggerAdditionActionEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671075);
		NativeMethodInfoPtr_ClearAdditionAction_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671076);
		NativeMethodInfoPtr_CheckCouldDualStrike_Public_Boolean_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671077);
		NativeMethodInfoPtr_SetDualStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671078);
		NativeMethodInfoPtr_TriggerDualStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671079);
		NativeMethodInfoPtr_WillDualStrike_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671080);
		NativeMethodInfoPtr_ClearDualStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671081);
		NativeMethodInfoPtr_CheckIsBetrayed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671082);
		NativeMethodInfoPtr_TryApplyFriendBuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671083);
		NativeMethodInfoPtr_HasUnUsedWife_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671084);
		NativeMethodInfoPtr_AddAllInternalKungfuExp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActor>.NativeClassPtr, 100671085);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 769622, RefRangeEnd = 769629, XrefRangeStart = 769513, XrefRangeEnd = 769622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor(BattleActorCreateInfo info)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleActorCreateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769638, RefRangeEnd = 769639, XrefRangeStart = 769629, XrefRangeEnd = 769638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769639, XrefRangeEnd = 769641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckMoveAreaRecursively(ref Dictionary<Vector3Int, int> area)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_byref_Dictionary_2_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		area = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Vector3Int, int>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769641, XrefRangeEnd = 769642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckMoveAreaRecursively(int movePoint, ref Dictionary<Vector3Int, int> area)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&movePoint);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_Int32_byref_Dictionary_2_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		area = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Vector3Int, int>(intPtr4));
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 769676, RefRangeEnd = 769683, XrefRangeStart = 769642, XrefRangeEnd = 769676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckMoveAreaRecursively(int movePoint, Vector3Int curPosition, ref Dictionary<Vector3Int, int> area, bool needCacheAllieAndBlock = true, bool seatAsWalkable = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&movePoint);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &curPosition;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCacheAllieAndBlock;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &seatAsWalkable;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMoveAreaRecursively_Public_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		area = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Vector3Int, int>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769683, XrefRangeEnd = 769693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheAllieAndBlock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheAllieAndBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 769697, RefRangeEnd = 769699, XrefRangeStart = 769693, XrefRangeEnd = 769697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ModifyAction(float amount, bool cacheModify = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&amount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cacheModify;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyAction_Public_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769701, RefRangeEnd = 769702, XrefRangeStart = 769699, XrefRangeEnd = 769701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ActionTick(float tickTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tickTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActionTick_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769703, RefRangeEnd = 769704, XrefRangeStart = 769702, XrefRangeEnd = 769703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActiveActionCost(float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveActionCost_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769720, RefRangeEnd = 769721, XrefRangeStart = 769704, XrefRangeEnd = 769720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveTo(Vector3Int pos, Il2CppStructArray<Vector3Int> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTo_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 769736, RefRangeEnd = 769742, XrefRangeStart = 769721, XrefRangeEnd = 769736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Damage(int hp, BattleActor caster = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Damage_Public_Void_Int32_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769772, RefRangeEnd = 769773, XrefRangeStart = 769742, XrefRangeEnd = 769772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Heal(int hp, int ep, BattleActor caster = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hp);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ep;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Heal_Public_Void_Int32_Int32_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 769797, RefRangeEnd = 769817, XrefRangeStart = 769773, XrefRangeEnd = 769797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyProp(BattleActorPropTypes prop, int offset, bool fromBuff = false, BattleActor caster = null, bool needRecord = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&prop);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromBuff;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &needRecord;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyProp_Public_Void_BattleActorPropTypes_Int32_Boolean_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769818, RefRangeEnd = 769819, XrefRangeStart = 769817, XrefRangeEnd = 769818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAlive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAlive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 769819, RefRangeEnd = 769820, XrefRangeStart = 769819, XrefRangeEnd = 769819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Kill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Kill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 769820, RefRangeEnd = 769822, XrefRangeStart = 769820, XrefRangeEnd = 769820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Retreat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Retreat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 769969, RefRangeEnd = 769971, XrefRangeStart = 769822, XrefRangeEnd = 769969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorPropModifiedEvent OnBattleStart(bool fireEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fireEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBattleStart_Public_BattleActorPropModifiedEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorPropModifiedEvent>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 770005, RefRangeEnd = 770012, XrefRangeStart = 769971, XrefRangeEnd = 770005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InternalKungfuEffectEvent CreateInternalKungfuEffectEvents(DynamicModifier.DynamicModifierActiveStage dynamicModifierActiveStage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dynamicModifierActiveStage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInternalKungfuEffectEvents_Public_InternalKungfuEffectEvent_DynamicModifierActiveStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalKungfuEffectEvent>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770064, RefRangeEnd = 770065, XrefRangeStart = 770012, XrefRangeEnd = 770064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBattleTimeTick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBattleTimeTick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770065, RefRangeEnd = 770066, XrefRangeStart = 770065, XrefRangeEnd = 770065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActorIsReady()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActorIsReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770082, RefRangeEnd = 770083, XrefRangeStart = 770066, XrefRangeEnd = 770082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOtherActorIsReady()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOtherActorIsReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770083, XrefRangeEnd = 770104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestMoveArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestMoveArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(77)]
	[CachedScanResults(RefRangeStart = 770106, RefRangeEnd = 770183, XrefRangeStart = 770104, XrefRangeEnd = 770106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInstanceProp(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceProp_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 770184, RefRangeEnd = 770220, XrefRangeStart = 770183, XrefRangeEnd = 770184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetInstancePropAsDecimal(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstancePropAsDecimal_Public_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770323, RefRangeEnd = 770324, XrefRangeStart = 770220, XrefRangeEnd = 770323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitActorStateMachineData(ActiveActorStateMachineData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitActorStateMachineData_Public_Void_ActiveActorStateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770371, RefRangeEnd = 770373, XrefRangeStart = 770324, XrefRangeEnd = 770371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<KungfuInstance> GetAllActiveKungfu(bool containsNotAvalible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&containsNotAvalible);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllActiveKungfu_Public_List_1_KungfuInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770410, RefRangeEnd = 770411, XrefRangeStart = 770373, XrefRangeEnd = 770410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<KungfuInstance> GetAllBasicAttacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBasicAttacks_Public_List_1_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770411, XrefRangeEnd = 770434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<KungfuInstance> GetAllInternalKungfu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllInternalKungfu_Public_List_1_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 770435, RefRangeEnd = 770439, XrefRangeStart = 770434, XrefRangeEnd = 770435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKungfuAvalible(KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKungfuAvalible_Public_Boolean_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 770494, RefRangeEnd = 770502, XrefRangeStart = 770439, XrefRangeEnd = 770494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKungfuAvalible(KungfuInstance kungfuInstance, ref KungfuAvalibleState kungfuAvalibleState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref kungfuAvalibleState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKungfuAvalible_Public_Boolean_KungfuInstance_byref_KungfuAvalibleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770511, RefRangeEnd = 770512, XrefRangeStart = 770502, XrefRangeEnd = 770511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKungfuNeedRemoveWeaponToCast(KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKungfuNeedRemoveWeaponToCast_Public_Boolean_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770557, RefRangeEnd = 770559, XrefRangeStart = 770512, XrefRangeEnd = 770557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor GetFirstBondKungfuTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstBondKungfuTarget_Public_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770560, RefRangeEnd = 770561, XrefRangeStart = 770559, XrefRangeEnd = 770560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int UseKungfu(KungfuInstance kungfuInstance, bool check = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &check;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseKungfu_Public_Int32_KungfuInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 770576, RefRangeEnd = 770579, XrefRangeStart = 770561, XrefRangeEnd = 770576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetExpInBattle(int origin, BattleFieldEvent battleFieldEvent = null, bool hasKillingBonus = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasKillingBonus;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExpInBattle_Public_Int32_Int32_BattleFieldEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770579, XrefRangeEnd = 770595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GalcBattleExpByKill(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GalcBattleExpByKill_Public_Int32_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 770628, RefRangeEnd = 770633, XrefRangeStart = 770595, XrefRangeEnd = 770628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseItem(GameItemInstance gameItemInstance, BattleActor caster, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Void_GameItemInstance_BattleActor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770643, RefRangeEnd = 770645, XrefRangeStart = 770633, XrefRangeEnd = 770643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance ApplyBuff(int buffId, BattleActor caster)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buffId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_Int32_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 770655, RefRangeEnd = 770666, XrefRangeStart = 770645, XrefRangeEnd = 770655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance ApplyBuff(string buffName, BattleActor caster)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buffName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_String_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 770668, RefRangeEnd = 770672, XrefRangeStart = 770666, XrefRangeEnd = 770668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance ApplyBuff(BuffData buffData, BattleActor caster)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuff_Public_BuffInstance_BuffData_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770672, XrefRangeEnd = 770681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetBuffBattleEffect(int id, BattleActor dealer, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_Int32_BattleActor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770681, XrefRangeEnd = 770690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetBuffBattleEffect(string key, BattleActor dealer, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_String_BattleActor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 770694, RefRangeEnd = 770701, XrefRangeStart = 770690, XrefRangeEnd = 770694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetBuffBattleEffect(BuffData buffData, BattleActor dealer, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_BuffData_BattleActor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770734, RefRangeEnd = 770736, XrefRangeStart = 770701, XrefRangeEnd = 770734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyPropFromConfig(string key, Il2CppSystem.Decimal value, bool fromBuff = false, BattleActor caster = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromBuff;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyPropFromConfig_Public_Void_String_Decimal_Boolean_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770738, RefRangeEnd = 770739, XrefRangeStart = 770736, XrefRangeEnd = 770738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack GetItemPack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemPack_Public_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770739, XrefRangeEnd = 770751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterItemUsage(GameItemInstance gameItemInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterItemUsage_Public_Void_GameItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770751, XrefRangeEnd = 770772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnConsumedItemToPack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnConsumedItemToPack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770772, XrefRangeEnd = 770777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestUseItem(string itemName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestUseItem_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770798, RefRangeEnd = 770799, XrefRangeStart = 770777, XrefRangeEnd = 770798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFlankPos(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFlankPos_Public_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770819, RefRangeEnd = 770820, XrefRangeStart = 770799, XrefRangeEnd = 770819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBackStabPos(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBackStabPos_Public_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770861, RefRangeEnd = 770862, XrefRangeStart = 770820, XrefRangeEnd = 770861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyKungfuCd(int kungfuTempleteId, bool cooldDownOtherKungfu = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&kungfuTempleteId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cooldDownOtherKungfu;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyKungfuCd_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 770865, RefRangeEnd = 770870, XrefRangeStart = 770862, XrefRangeEnd = 770865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetKungfuCd(int kungfuTempleteId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&kungfuTempleteId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuCd_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770870, XrefRangeEnd = 770872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770875, RefRangeEnd = 770876, XrefRangeStart = 770872, XrefRangeEnd = 770875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllKungfuCd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllKungfuCd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770885, RefRangeEnd = 770887, XrefRangeStart = 770876, XrefRangeEnd = 770885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWillHarmNeutralLikeEnemy(BattleActor other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWillHarmNeutralLikeEnemy_Public_Boolean_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActorAuraChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActorAuraChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770983, RefRangeEnd = 770984, XrefRangeStart = 770887, XrefRangeEnd = 770983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshAuraEffect(HashSet<BattleAuraInstance> aurasEffectedNew)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aurasEffectedNew);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshAuraEffect_Public_Void_HashSet_1_BattleAuraInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770988, RefRangeEnd = 770989, XrefRangeStart = 770984, XrefRangeEnd = 770988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterOneTimeDamageTransfer(DamageTransfer shield)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shield);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterOneTimeDamageTransfer_Public_Void_DamageTransfer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770993, RefRangeEnd = 770994, XrefRangeStart = 770989, XrefRangeEnd = 770993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearOneTimeDamageTransfer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearOneTimeDamageTransfer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771080, RefRangeEnd = 771081, XrefRangeStart = 770994, XrefRangeEnd = 771080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleManager.CounterAttackActionAdditionData CheckCounterAttackCurrentActorInAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCounterAttackCurrentActorInAction_Public_CounterAttackActionAdditionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleManager.CounterAttackActionAdditionData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771086, RefRangeEnd = 771087, XrefRangeStart = 771081, XrefRangeEnd = 771086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIsAwake(HashSet<Vector3Int> alertArea)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)alertArea);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsAwake_Public_Boolean_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 771158, RefRangeEnd = 771161, XrefRangeStart = 771087, XrefRangeEnd = 771158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Vector3Int> GetSenseZone(bool forceRefresh = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceRefresh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSenseZone_Public_HashSet_1_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771187, RefRangeEnd = 771188, XrefRangeStart = 771161, XrefRangeEnd = 771187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetBattleOffend(string key, BattleManager.BattleOffendAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBattleOffend_Public_Boolean_String_BattleOffendAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771192, RefRangeEnd = 771193, XrefRangeStart = 771188, XrefRangeEnd = 771192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearOffendHistroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearOffendHistroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771196, RefRangeEnd = 771197, XrefRangeStart = 771193, XrefRangeEnd = 771196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MaxToleranceReached()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxToleranceReached_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771197, XrefRangeEnd = 771200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTotalBattleOffend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalBattleOffend_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 771202, RefRangeEnd = 771210, XrefRangeStart = 771200, XrefRangeEnd = 771202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCoward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCoward_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 771237, RefRangeEnd = 771248, XrefRangeStart = 771210, XrefRangeEnd = 771237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectOnActorEvent CreatEffectEventFromCachedEffectList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatEffectEventFromCachedEffectList_Public_EffectOnActorEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectOnActorEvent>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771259, RefRangeEnd = 771260, XrefRangeStart = 771248, XrefRangeEnd = 771259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddAdditionAction(int weight, Il2CppSystem.Action action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&weight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAdditionAction_Public_Boolean_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771272, RefRangeEnd = 771273, XrefRangeStart = 771260, XrefRangeEnd = 771272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TriggerAdditionActionEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerAdditionActionEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771273, RefRangeEnd = 771274, XrefRangeStart = 771273, XrefRangeEnd = 771273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAdditionAction(bool onlyIsApplied = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&onlyIsApplied);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAdditionAction_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771308, RefRangeEnd = 771309, XrefRangeStart = 771274, XrefRangeEnd = 771308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckCouldDualStrike(KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCouldDualStrike_Public_Boolean_KungfuActionCastData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771311, RefRangeEnd = 771312, XrefRangeStart = 771309, XrefRangeEnd = 771311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDualStrike()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDualStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void TriggerDualStrike()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerDualStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 771312, RefRangeEnd = 771314, XrefRangeStart = 771312, XrefRangeEnd = 771312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WillDualStrike()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WillDualStrike_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771314, RefRangeEnd = 771315, XrefRangeStart = 771314, XrefRangeEnd = 771314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDualStrike()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDualStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 771318, RefRangeEnd = 771320, XrefRangeStart = 771315, XrefRangeEnd = 771318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIsBetrayed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsBetrayed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 771341, RefRangeEnd = 771344, XrefRangeStart = 771320, XrefRangeEnd = 771341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryApplyFriendBuff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryApplyFriendBuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771387, RefRangeEnd = 771388, XrefRangeStart = 771344, XrefRangeEnd = 771387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasUnUsedWife()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasUnUsedWife_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771433, RefRangeEnd = 771434, XrefRangeStart = 771388, XrefRangeEnd = 771433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAllInternalKungfuExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAllInternalKungfuExp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleActor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
