using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class ActorDamageBattleFieldEvent : BattleFieldEvent
{
	public enum DamageFlag
	{
		None = 0,
		Dodge = 1,
		Resist = 2,
		Cirt = 4,
		Parry = 8,
		InstaKill = 0x10,
		DamageNear = 0x20,
		DamageRtn = 0x40,
		IsFlank = 0x80,
		IsBackStab = 0x100,
		DamageTransfer = 0x200
	}

	private static readonly IntPtr NativeFieldInfoPtr_defaultActorDamageDelay;

	private static readonly IntPtr NativeFieldInfoPtr_dealerActor;

	private static readonly IntPtr NativeFieldInfoPtr_targetActor;

	private static readonly IntPtr NativeFieldInfoPtr_hasShake;

	private static readonly IntPtr NativeFieldInfoPtr_damageFlag;

	private static readonly IntPtr NativeFieldInfoPtr_battleActorPropModifies;

	private static readonly IntPtr NativeFieldInfoPtr_actionModify;

	private static readonly IntPtr NativeFieldInfoPtr_internalEventBeforeHit;

	private static readonly IntPtr NativeFieldInfoPtr_internalEventAfterHit;

	private static readonly IntPtr NativeFieldInfoPtr_internalDefBonusKungfu;

	private static readonly IntPtr NativeFieldInfoPtr_textdelay;

	private static readonly IntPtr NativeFieldInfoPtr_damageReason;

	private static readonly IntPtr NativeFieldInfoPtr_minimalDelay;

	private static readonly IntPtr NativeMethodInfoPtr_get_isDodged_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isDodged_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isResist_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isResist_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isCirted_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isCirted_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isParry_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isParry_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isInstaKill_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isInstaKill_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_hasDamageNear_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hasDamageNear_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_hasDamageRtn_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hasDamageRtn_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_hasDamageTransfer_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hasDamageTransfer_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isFlank_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isFlank_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isBackStab_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isBackStab_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_MergePropChange_Public_Void_List_1_BattleActorPropModify_List_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetFlag_Public_Void_DamageFlag_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_DamageFlag_0;

	public unsafe static float defaultActorDamageDelay
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultActorDamageDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultActorDamageDelay, (void*)(&num));
		}
	}

	public unsafe BattleActor dealerActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerActor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe BattleActor targetActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetActor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe bool hasShake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasShake);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasShake)) = flag;
		}
	}

	public unsafe DamageFlag damageFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageFlag);
			return *(DamageFlag*)num;
		}
		set
		{
			*(DamageFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageFlag)) = damageFlag;
		}
	}

	public unsafe Dictionary<BattleActor.BattleActorPropTypes, BattleActor.BattleActorPropModify> battleActorPropModifies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorPropModifies);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor.BattleActorPropTypes, BattleActor.BattleActorPropModify>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorPropModifies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int actionModify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionModify);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionModify)) = num;
		}
	}

	public unsafe InternalKungfuEffectEvent internalEventBeforeHit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventBeforeHit);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InternalKungfuEffectEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventBeforeHit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalKungfuEffectEvent));
		}
	}

	public unsafe InternalKungfuEffectEvent internalEventAfterHit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventAfterHit);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InternalKungfuEffectEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalEventAfterHit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalKungfuEffectEvent));
		}
	}

	public unsafe KungfuInstance internalDefBonusKungfu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalDefBonusKungfu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalDefBonusKungfu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
		}
	}

	public unsafe float textdelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textdelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textdelay)) = num;
		}
	}

	public unsafe BattleDamageReason damageReason
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageReason);
			return *(BattleDamageReason*)num;
		}
		set
		{
			*(BattleDamageReason*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageReason)) = battleDamageReason;
		}
	}

	public unsafe float minimalDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimalDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimalDelay)) = num;
		}
	}

	public unsafe bool isDodged
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774923, RefRangeEnd = 774926, XrefRangeStart = 774923, XrefRangeEnd = 774923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDodged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774926, RefRangeEnd = 774928, XrefRangeStart = 774926, XrefRangeEnd = 774926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isDodged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isResist
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774928, RefRangeEnd = 774929, XrefRangeStart = 774928, XrefRangeEnd = 774928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isResist_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774929, RefRangeEnd = 774930, XrefRangeStart = 774929, XrefRangeEnd = 774929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isResist_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isCirted
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 774930, RefRangeEnd = 774935, XrefRangeStart = 774930, XrefRangeEnd = 774930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCirted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774935, RefRangeEnd = 774936, XrefRangeStart = 774935, XrefRangeEnd = 774935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isCirted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isParry
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 774936, RefRangeEnd = 774941, XrefRangeStart = 774936, XrefRangeEnd = 774936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isParry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774941, RefRangeEnd = 774942, XrefRangeStart = 774941, XrefRangeEnd = 774941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isParry_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isInstaKill
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774942, RefRangeEnd = 774945, XrefRangeStart = 774942, XrefRangeEnd = 774942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isInstaKill_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774945, RefRangeEnd = 774947, XrefRangeStart = 774945, XrefRangeEnd = 774945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isInstaKill_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool hasDamageNear
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDamageNear_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774947, RefRangeEnd = 774948, XrefRangeStart = 774947, XrefRangeEnd = 774947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasDamageNear_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool hasDamageRtn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDamageRtn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774948, RefRangeEnd = 774949, XrefRangeStart = 774948, XrefRangeEnd = 774948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasDamageRtn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool hasDamageTransfer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDamageTransfer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774949, RefRangeEnd = 774950, XrefRangeStart = 774949, XrefRangeEnd = 774949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasDamageTransfer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isFlank
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774950, RefRangeEnd = 774951, XrefRangeStart = 774950, XrefRangeEnd = 774950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isFlank_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isFlank_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isBackStab
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774951, RefRangeEnd = 774952, XrefRangeStart = 774951, XrefRangeEnd = 774951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isBackStab_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isBackStab_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ActorDamageBattleFieldEvent()
	{
		Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ActorDamageBattleFieldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr);
		NativeFieldInfoPtr_defaultActorDamageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "defaultActorDamageDelay");
		NativeFieldInfoPtr_dealerActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "dealerActor");
		NativeFieldInfoPtr_targetActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "targetActor");
		NativeFieldInfoPtr_hasShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "hasShake");
		NativeFieldInfoPtr_damageFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "damageFlag");
		NativeFieldInfoPtr_battleActorPropModifies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "battleActorPropModifies");
		NativeFieldInfoPtr_actionModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "actionModify");
		NativeFieldInfoPtr_internalEventBeforeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "internalEventBeforeHit");
		NativeFieldInfoPtr_internalEventAfterHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "internalEventAfterHit");
		NativeFieldInfoPtr_internalDefBonusKungfu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "internalDefBonusKungfu");
		NativeFieldInfoPtr_textdelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "textdelay");
		NativeFieldInfoPtr_damageReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "damageReason");
		NativeFieldInfoPtr_minimalDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, "minimalDelay");
		NativeMethodInfoPtr_get_isDodged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671230);
		NativeMethodInfoPtr_set_isDodged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671231);
		NativeMethodInfoPtr_get_isResist_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671232);
		NativeMethodInfoPtr_set_isResist_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671233);
		NativeMethodInfoPtr_get_isCirted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671234);
		NativeMethodInfoPtr_set_isCirted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671235);
		NativeMethodInfoPtr_get_isParry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671236);
		NativeMethodInfoPtr_set_isParry_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671237);
		NativeMethodInfoPtr_get_isInstaKill_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671238);
		NativeMethodInfoPtr_set_isInstaKill_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671239);
		NativeMethodInfoPtr_get_hasDamageNear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671240);
		NativeMethodInfoPtr_set_hasDamageNear_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671241);
		NativeMethodInfoPtr_get_hasDamageRtn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671242);
		NativeMethodInfoPtr_set_hasDamageRtn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671243);
		NativeMethodInfoPtr_get_hasDamageTransfer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671244);
		NativeMethodInfoPtr_set_hasDamageTransfer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671245);
		NativeMethodInfoPtr_get_isFlank_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671246);
		NativeMethodInfoPtr_set_isFlank_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671247);
		NativeMethodInfoPtr_get_isBackStab_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671248);
		NativeMethodInfoPtr_set_isBackStab_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671249);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671250);
		NativeMethodInfoPtr_MergePropChange_Public_Void_List_1_BattleActorPropModify_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671251);
		NativeMethodInfoPtr_SetFlag_Public_Void_DamageFlag_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671252);
		NativeMethodInfoPtr_HasFlag_Public_Boolean_DamageFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr, 100671253);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 774957, RefRangeEnd = 774963, XrefRangeStart = 774952, XrefRangeEnd = 774957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorDamageBattleFieldEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorDamageBattleFieldEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 775001, RefRangeEnd = 775008, XrefRangeStart = 774963, XrefRangeEnd = 775001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergePropChange(List<BattleActor.BattleActorPropModify> modifies, List<int> actionModifyList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifies);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionModifyList);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergePropChange_Public_Void_List_1_BattleActorPropModify_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 775008, RefRangeEnd = 775010, XrefRangeStart = 775008, XrefRangeEnd = 775008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFlag(DamageFlag mask, bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&mask);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlag_Public_Void_DamageFlag_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool HasFlag(DamageFlag flag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&flag);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlag_Public_Boolean_DamageFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ActorDamageBattleFieldEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
