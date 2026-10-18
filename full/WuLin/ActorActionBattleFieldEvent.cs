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

public class ActorActionBattleFieldEvent : BattleFieldEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dealerActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_assistActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_posOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectActorInArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectDamageOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_splshAffectActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoredSameFactionActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortedBattleActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuActionCastData;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalEventBeforeAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_propModifiedWhenAttacked;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalEventAfterAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalAtkBonusKungfu;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuMoveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_activedKungfuBuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_extendEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_additionActorsNeedCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleIsFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMegaBlow;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDualStrike;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCounterAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuAtomicEffectList;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceRetreating;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFullTeamRetreating;

	private static readonly System.IntPtr NativeFieldInfoPtr_allDamageEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChargeAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackEffectFinalTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackEffectPlayedTiles;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsImportant_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortEffectedActors_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterExtendEvent_Public_Void_Object_BattleFieldEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterActorNeedCheck_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDeadForAllExtendEvent_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndRemoveTheLastDamageEvent_Public_Boolean_ActorDamageBattleFieldEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeMaxDelay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectDelay_Public_Single_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySplashAffectActors_Public_Void_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isSplashAffectActor_Public_Boolean_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SortEffectedActors_b__34_0_Private_Int32_BattleActor_BattleActor_0;

	public unsafe BattleActor dealerActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerActor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe BattleActor assistActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assistActor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assistActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe Vector3Int posOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posOffset);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posOffset)) = vector3Int;
		}
	}

	public unsafe List<Vector3Int> effectArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<Vector3Int, float> effectDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectDelay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectDelay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float maxDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDelay)) = num;
		}
	}

	public unsafe Dictionary<BattleActor, float> targetActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int effectActorInArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectActorInArea);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectActorInArea)) = num;
		}
	}

	public unsafe Il2CppSystem.Decimal effectDamageOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectDamageOffset);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectDamageOffset)) = obj;
		}
	}

	public unsafe HashSet<BattleActor> splshAffectActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splshAffectActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splshAffectActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleActor> ignoredSameFactionActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoredSameFactionActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoredSameFactionActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<BattleActor> sortedBattleActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedBattleActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedBattleActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe KungfuActionCastData kungfuActionCastData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuActionCastData);
			return new KungfuActionCastData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuActionCastData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuActionCastData)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InternalKungfuEffectEvent internalEventBeforeAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventBeforeAttack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalKungfuEffectEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventBeforeAttack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalKungfuEffectEvent));
		}
	}

	public unsafe BattleActorPropModifiedEvent propModifiedWhenAttacked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propModifiedWhenAttacked);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorPropModifiedEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propModifiedWhenAttacked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActorPropModifiedEvent));
		}
	}

	public unsafe InternalKungfuEffectEvent internalEventAfterAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventAfterAttack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalKungfuEffectEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventAfterAttack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalKungfuEffectEvent));
		}
	}

	public unsafe KungfuInstance internalAtkBonusKungfu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalAtkBonusKungfu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalAtkBonusKungfu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
		}
	}

	public unsafe KungfuMoveData kungfuMoveData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuMoveData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuMoveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuMoveData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuMoveData));
		}
	}

	public unsafe HashSet<BuffInstance> activedKungfuBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activedKungfuBuff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BuffInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activedKungfuBuff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Object, BattleFieldEvent> extendEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Object, BattleFieldEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<BattleActor> additionActorsNeedCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionActorsNeedCheck);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionActorsNeedCheck)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool battleIsFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleIsFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleIsFinished)) = flag;
		}
	}

	public unsafe bool isMegaBlow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMegaBlow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMegaBlow)) = flag;
		}
	}

	public unsafe bool isDualStrike
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDualStrike);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDualStrike)) = flag;
		}
	}

	public unsafe bool isCounterAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCounterAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCounterAttack)) = flag;
		}
	}

	public unsafe KungfuAtomicEffectList kungfuAtomicEffectList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuAtomicEffectList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuAtomicEffectList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuAtomicEffectList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuAtomicEffectList));
		}
	}

	public unsafe bool forceRetreating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceRetreating);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceRetreating)) = flag;
		}
	}

	public unsafe bool forceFullTeamRetreating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFullTeamRetreating);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFullTeamRetreating)) = flag;
		}
	}

	public unsafe HashSet<ActorDamageBattleFieldEvent> allDamageEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allDamageEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ActorDamageBattleFieldEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allDamageEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe bool isChargeAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChargeAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChargeAttack)) = flag;
		}
	}

	public unsafe Vector3Int changeTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeTarget);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeTarget)) = vector3Int;
		}
	}

	public unsafe float attackEffectFinalTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackEffectFinalTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackEffectFinalTime)) = num;
		}
	}

	public unsafe HashSet<Vector3Int> attackEffectPlayedTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackEffectPlayedTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackEffectPlayedTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static ActorActionBattleFieldEvent()
	{
		Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ActorActionBattleFieldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr);
		NativeFieldInfoPtr_dealerActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "dealerActor");
		NativeFieldInfoPtr_assistActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "assistActor");
		NativeFieldInfoPtr_posOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "posOffset");
		NativeFieldInfoPtr_effectArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "effectArea");
		NativeFieldInfoPtr_effectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "effectDelay");
		NativeFieldInfoPtr_maxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "maxDelay");
		NativeFieldInfoPtr_targetActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "targetActors");
		NativeFieldInfoPtr_effectActorInArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "effectActorInArea");
		NativeFieldInfoPtr_effectDamageOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "effectDamageOffset");
		NativeFieldInfoPtr_splshAffectActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "splshAffectActors");
		NativeFieldInfoPtr_ignoredSameFactionActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "ignoredSameFactionActors");
		NativeFieldInfoPtr_sortedBattleActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "sortedBattleActors");
		NativeFieldInfoPtr_kungfuActionCastData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "kungfuActionCastData");
		NativeFieldInfoPtr_internalEventBeforeAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "internalEventBeforeAttack");
		NativeFieldInfoPtr_propModifiedWhenAttacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "propModifiedWhenAttacked");
		NativeFieldInfoPtr_internalEventAfterAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "internalEventAfterAttack");
		NativeFieldInfoPtr_internalAtkBonusKungfu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "internalAtkBonusKungfu");
		NativeFieldInfoPtr_kungfuMoveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "kungfuMoveData");
		NativeFieldInfoPtr_activedKungfuBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "activedKungfuBuff");
		NativeFieldInfoPtr_extendEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "extendEvents");
		NativeFieldInfoPtr_additionActorsNeedCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "additionActorsNeedCheck");
		NativeFieldInfoPtr_battleIsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "battleIsFinished");
		NativeFieldInfoPtr_isMegaBlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "isMegaBlow");
		NativeFieldInfoPtr_isDualStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "isDualStrike");
		NativeFieldInfoPtr_isCounterAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "isCounterAttack");
		NativeFieldInfoPtr_kungfuAtomicEffectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "kungfuAtomicEffectList");
		NativeFieldInfoPtr_forceRetreating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "forceRetreating");
		NativeFieldInfoPtr_forceFullTeamRetreating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "forceFullTeamRetreating");
		NativeFieldInfoPtr_allDamageEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "allDamageEvents");
		NativeFieldInfoPtr_isChargeAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "isChargeAttack");
		NativeFieldInfoPtr_changeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "changeTarget");
		NativeFieldInfoPtr_attackEffectFinalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "attackEffectFinalTime");
		NativeFieldInfoPtr_attackEffectPlayedTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, "attackEffectPlayedTiles");
		NativeMethodInfoPtr_IsImportant_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671218);
		NativeMethodInfoPtr_SortEffectedActors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671219);
		NativeMethodInfoPtr_RegisterExtendEvent_Public_Void_Object_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671220);
		NativeMethodInfoPtr_RegisterActorNeedCheck_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671221);
		NativeMethodInfoPtr_CheckDeadForAllExtendEvent_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671222);
		NativeMethodInfoPtr_CheckAndRemoveTheLastDamageEvent_Public_Boolean_ActorDamageBattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671223);
		NativeMethodInfoPtr_ComputeMaxDelay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671224);
		NativeMethodInfoPtr_GetEffectDelay_Public_Single_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671225);
		NativeMethodInfoPtr_ApplySplashAffectActors_Public_Void_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671226);
		NativeMethodInfoPtr_isSplashAffectActor_Public_Boolean_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671227);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671228);
		NativeMethodInfoPtr__SortEffectedActors_b__34_0_Private_Int32_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr, 100671229);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774647, XrefRangeEnd = 774653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsImportant()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsImportant_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774674, RefRangeEnd = 774675, XrefRangeStart = 774653, XrefRangeEnd = 774674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortEffectedActors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortEffectedActors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 774692, RefRangeEnd = 774713, XrefRangeStart = 774675, XrefRangeEnd = 774692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterExtendEvent(Il2CppSystem.Object obj, BattleFieldEvent battleFieldEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterExtendEvent_Public_Void_Object_BattleFieldEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 774719, RefRangeEnd = 774722, XrefRangeStart = 774713, XrefRangeEnd = 774719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterActorNeedCheck(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterActorNeedCheck_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774788, RefRangeEnd = 774789, XrefRangeStart = 774722, XrefRangeEnd = 774788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDeadForAllExtendEvent(BattleActor dealerActor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDeadForAllExtendEvent_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774796, RefRangeEnd = 774797, XrefRangeStart = 774789, XrefRangeEnd = 774796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckAndRemoveTheLastDamageEvent(ActorDamageBattleFieldEvent damageEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndRemoveTheLastDamageEvent_Public_Boolean_ActorDamageBattleFieldEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774814, RefRangeEnd = 774815, XrefRangeStart = 774797, XrefRangeEnd = 774814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeMaxDelay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeMaxDelay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 774821, RefRangeEnd = 774824, XrefRangeStart = 774815, XrefRangeEnd = 774821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetEffectDelay(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEffectDelay_Public_Single_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774851, RefRangeEnd = 774852, XrefRangeStart = 774824, XrefRangeEnd = 774851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySplashAffectActors(HashSet<BattleActor> actors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actors);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySplashAffectActors_Public_Void_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774853, RefRangeEnd = 774854, XrefRangeStart = 774852, XrefRangeEnd = 774853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isSplashAffectActor(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSplashAffectActor_Public_Boolean_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 774891, RefRangeEnd = 774892, XrefRangeStart = 774854, XrefRangeEnd = 774891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorActionBattleFieldEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorActionBattleFieldEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774892, XrefRangeEnd = 774923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _SortEffectedActors_b__34_0(BattleActor x, BattleActor y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortEffectedActors_b__34_0_Private_Int32_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ActorActionBattleFieldEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
