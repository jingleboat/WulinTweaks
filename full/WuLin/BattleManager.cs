using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using WuLin.StateMachine;

namespace WuLin;

public class BattleManager : MonoSingleton<BattleManager>
{
	public class BattleOffendAction : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_offendValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_includeActor;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludeActor;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		public unsafe int offendValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offendValue);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offendValue)) = num;
			}
		}

		public unsafe HashSet<BattleActor> includeActor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeActor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		public unsafe HashSet<BattleActor> excludeActor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeActor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static BattleOffendAction()
		{
			Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "BattleOffendAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr);
			NativeFieldInfoPtr_offendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr, "offendValue");
			NativeFieldInfoPtr_includeActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr, "includeActor");
			NativeFieldInfoPtr_excludeActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr, "excludeActor");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr, 100686102);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 775377, RefRangeEnd = 775384, XrefRangeStart = 775366, XrefRangeEnd = 775377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleOffendAction(int offendValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleOffendAction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&offendValue);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BattleOffendAction(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DamageGuard : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_guardian;

		private static readonly System.IntPtr NativeFieldInfoPtr_guardTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_guardRate;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleActor_BattleActor_Single_0;

		public unsafe BattleActor guardian
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardian);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardian)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		public unsafe BattleActor guardTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardTarget);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		public unsafe float guardRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardRate)) = num;
			}
		}

		static DamageGuard()
		{
			Il2CppClassPointerStore<DamageGuard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "DamageGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageGuard>.NativeClassPtr);
			NativeFieldInfoPtr_guardian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageGuard>.NativeClassPtr, "guardian");
			NativeFieldInfoPtr_guardTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageGuard>.NativeClassPtr, "guardTarget");
			NativeFieldInfoPtr_guardRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageGuard>.NativeClassPtr, "guardRate");
			NativeMethodInfoPtr__ctor_Public_Void_BattleActor_BattleActor_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageGuard>.NativeClassPtr, 100686103);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 775385, RefRangeEnd = 775386, XrefRangeStart = 775384, XrefRangeEnd = 775385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DamageGuard(BattleActor guardian, BattleActor guardTarget, float guardRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageGuard>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guardian);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guardTarget);
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &guardRate;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleActor_BattleActor_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DamageGuard(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdditionalActionData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_additionalActionType;

		private static readonly System.IntPtr NativeFieldInfoPtr_actor;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalActionAdditionData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe AdditionalActionType additionalActionType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalActionType);
				return *(AdditionalActionType*)num;
			}
			set
			{
				*(AdditionalActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalActionType)) = additionalActionType;
			}
		}

		public unsafe BattleActor actor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		public unsafe AdditionalActionAdditionData additionalActionAdditionData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalActionAdditionData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdditionalActionAdditionData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalActionAdditionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalActionAdditionData));
			}
		}

		static AdditionalActionData()
		{
			Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "AdditionalActionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr);
			NativeFieldInfoPtr_additionalActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr, "additionalActionType");
			NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr, "actor");
			NativeFieldInfoPtr_additionalActionAdditionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr, "additionalActionAdditionData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr, 100686104);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditionalActionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalActionData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdditionalActionData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AdditionalActionAdditionData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static AdditionalActionAdditionData()
		{
			Il2CppClassPointerStore<AdditionalActionAdditionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "AdditionalActionAdditionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalActionAdditionData>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalActionAdditionData>.NativeClassPtr, 100686105);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditionalActionAdditionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalActionAdditionData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdditionalActionAdditionData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CounterAttackActionAdditionData : AdditionalActionAdditionData
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_counterTarget;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe BattleActor counterTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterTarget);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		static CounterAttackActionAdditionData()
		{
			Il2CppClassPointerStore<CounterAttackActionAdditionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "CounterAttackActionAdditionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterAttackActionAdditionData>.NativeClassPtr);
			NativeFieldInfoPtr_kungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterAttackActionAdditionData>.NativeClassPtr, "kungfuInstance");
			NativeFieldInfoPtr_counterTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterAttackActionAdditionData>.NativeClassPtr, "counterTarget");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterAttackActionAdditionData>.NativeClassPtr, 100686106);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterAttackActionAdditionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterAttackActionAdditionData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CounterAttackActionAdditionData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleManager+<>c__DisplayClass245_0")]
	public sealed class __c__DisplayClass245_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actionBattleFieldEvent;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ActorActionBattleFieldEvent actionBattleFieldEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionBattleFieldEvent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorActionBattleFieldEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionBattleFieldEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorActionBattleFieldEvent));
			}
		}

		static __c__DisplayClass245_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<>c__DisplayClass245_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr);
			NativeFieldInfoPtr_actionBattleFieldEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr, "actionBattleFieldEvent");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr, 100686107);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass245_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleManager+<>c__DisplayClass245_1")]
	public sealed class __c__DisplayClass245_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_curAllie;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__0_Internal_Void_0;

		public unsafe BattleActor curAllie
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curAllie);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curAllie)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		static __c__DisplayClass245_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<>c__DisplayClass245_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr);
			NativeFieldInfoPtr_curAllie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr, "curAllie");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr, 100686108);
			NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr, 100686109);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775386, XrefRangeEnd = 775415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CheckAllieAndTeammateReactionInInstantBattle_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass245_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleManager+<>c__DisplayClass245_2")]
	public sealed class __c__DisplayClass245_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_curTeammate;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass245_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__2_Internal_Void_0;

		public unsafe BattleActor curTeammate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curTeammate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curTeammate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		public unsafe __c__DisplayClass245_0 field_Public___c__DisplayClass245_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass245_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass245_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass245_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass245_));
			}
		}

		static __c__DisplayClass245_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<>c__DisplayClass245_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr);
			NativeFieldInfoPtr_curTeammate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, "curTeammate");
			NativeFieldInfoPtr_field_Public___c__DisplayClass245_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, 100686110);
			NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, 100686111);
			NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, 100686112);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775415, XrefRangeEnd = 775437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CheckAllieAndTeammateReactionInInstantBattle_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775437, XrefRangeEnd = 775444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CheckAllieAndTeammateReactionInInstantBattle_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckAllieAndTeammateReactionInInstantBattle_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass245_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleManager+<IEBattleStart>d__250")]
	public sealed class _IEBattleStart_d__250 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe BattleManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleManager>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleManager));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _IEBattleStart_d__250()
		{
			Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<IEBattleStart>d__250");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, 100686113);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, 100686114);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, 100686115);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, 100686116);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, 100686117);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr, 100686118);
		}

		[CallerCount(575)]
		[CachedScanResults(RefRangeStart = 19473, RefRangeEnd = 20048, XrefRangeStart = 19473, XrefRangeEnd = 20048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _IEBattleStart_d__250(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_IEBattleStart_d__250>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775444, XrefRangeEnd = 775489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775489, XrefRangeEnd = 775494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _IEBattleStart_d__250(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleManager+<DelayRefreshBattleCard>d__289")]
	public sealed class _DelayRefreshBattleCard_d__289 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _DelayRefreshBattleCard_d__289()
		{
			Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<DelayRefreshBattleCard>d__289");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, "<>2__current");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, 100686119);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, 100686120);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, 100686121);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, 100686122);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, 100686123);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr, 100686124);
		}

		[CallerCount(575)]
		[CachedScanResults(RefRangeStart = 19473, RefRangeEnd = 20048, XrefRangeStart = 19473, XrefRangeEnd = 20048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DelayRefreshBattleCard_d__289(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_DelayRefreshBattleCard_d__289>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775494, XrefRangeEnd = 775498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775498, XrefRangeEnd = 775503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _DelayRefreshBattleCard_d__289(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.BattleManager+<>c__DisplayClass307_0")]
	public sealed class __c__DisplayClass307_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_counterPirorDict;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetCounterActorFromPotentialActors_b__0_Internal_Int32_BattleActor_BattleActor_0;

		public unsafe Dictionary<BattleActor, int> counterPirorDict
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterPirorDict);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterPirorDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static __c__DisplayClass307_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass307_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<>c__DisplayClass307_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass307_0>.NativeClassPtr);
			NativeFieldInfoPtr_counterPirorDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass307_0>.NativeClassPtr, "counterPirorDict");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass307_0>.NativeClassPtr, 100686125);
			NativeMethodInfoPtr__GetCounterActorFromPotentialActors_b__0_Internal_Int32_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass307_0>.NativeClassPtr, 100686126);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass307_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass307_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775503, XrefRangeEnd = 775509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetCounterActorFromPotentialActors_b__0(BattleActor x, BattleActor y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetCounterActorFromPotentialActors_b__0_Internal_Int32_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass307_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__IsQuickBattle_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsQuickBattleWithoutUi_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerIsRetreated_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerRetreatingData_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerRetreatingDir_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleFinishResult_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_customWinLoseConditionMatched;

	private static readonly System.IntPtr NativeFieldInfoPtr__curBattleMode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isStoryBattle_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__specialBattleBgm_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedActorGoNeedDestroy_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleFieldDataScriptObject;

	private static readonly System.IntPtr NativeFieldInfoPtr__actorNotHaveImportantAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_battlePreparePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleRetreatPoses;

	private static readonly System.IntPtr NativeFieldInfoPtr_battlePreparePosDirDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_charactersInPrepare;

	private static readonly System.IntPtr NativeFieldInfoPtr_deadActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_escapedActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleStageSM;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSmDebugOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_victroyConditions;

	private static readonly System.IntPtr NativeFieldInfoPtr_loseConditions;

	private static readonly System.IntPtr NativeFieldInfoPtr_customVictroyConditions;

	private static readonly System.IntPtr NativeFieldInfoPtr_customLoseCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBattleFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleMapId;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNoPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleActorsOnField;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTeamCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultCharacterInPredefinedBattle_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedCharatcerInPredefinedBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr_couldRetreatInInstantBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr__instantBattleZone_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_instantBattleRetreatPoses;

	private static readonly System.IntPtr NativeFieldInfoPtr__instantBattleOffendedFaction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__newAlertZoneThisTurn_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__newInBattleActorThisTurn_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleActorsDamagedByAllie_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleActorsDamagedAfterThisAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleActorBuffAfterCurAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__newOffendActionThisTurn_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__newJoinEnemyOrAllieActorThisTurn_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__newOffendChangeActorThisTurn_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__offendedCharacterBeforeBattle_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__offendedFactionBeforeBattle_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_duelTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_duelMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFriendlyDuel;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleAuraDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedValidAura;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBattleAuraDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_useAdvancedAi;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleActorAiDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeActorStateMachineData;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleTeamDict;

	private static readonly System.IntPtr NativeFieldInfoPtr__timeTickTotal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__relativePlayerAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionRecSpeedModify;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicineUsageLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleDebuffRec_SealFactor1_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleDebuffRec_SealFactor2_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleDebuffRec_BlindFactor1_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleDebuffRec_BlindFactor2_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__kungfuSense_HigherFactor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__kungfuSense_LowerFactor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__kungfuSense_Dealer_High_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__kungfuSense_Dealer_Low_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__kungfuSense_Target_High_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__kungfuSense_Target_Low_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__battleNegLevelOffsetFactor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_additionalActionDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAdditionalActionData;

	private static readonly System.IntPtr NativeFieldInfoPtr_potentialCounterActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedCharacterToActorDict;

	private static readonly System.IntPtr NativeFieldInfoPtr__oneTimeDamageGuard_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTestBattle_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsQuickBattle_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsQuickBattle_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsQuickBattleWithoutUi_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsQuickBattleWithoutUi_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerIsRetreated_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerIsRetreated_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerRetreatingData_Public_Static_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerRetreatingData_Private_Static_set_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerRetreatingDir_Public_Static_get_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerRetreatingDir_Private_Static_set_Void_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleFinishResult_Public_Static_get_BattleFinishResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleFinishResult_Private_Static_set_Void_BattleFinishResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_curBattleMode_Public_Static_get_BattleMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_curBattleMode_Private_Static_set_Void_BattleMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isStoryBattle_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isStoryBattle_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_specialBattleBgm_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_specialBattleBgm_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cachedActorGoNeedDestroy_Public_Static_get_List_1_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cachedActorGoNeedDestroy_Private_Static_set_Void_List_1_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actorNotHaveImportantAction_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_actorNotHaveImportantAction_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasFormationPhase_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BattleTeamDic_Public_get_Dictionary_2_BattleTeamEnum_BattleTeam_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActorInAction_Public_get_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveActorStateMachineData_Public_get_ActiveActorStateMachineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultCharacterInPredefinedBattle_Public_get_List_1_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultCharacterInPredefinedBattle_Private_set_Void_List_1_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instantBattleZone_Public_get_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instantBattleZone_Private_set_Void_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instantBattleOffendedFaction_Public_Static_get_HashSet_1_FactionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instantBattleOffendedFaction_Private_Static_set_Void_HashSet_1_FactionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_newAlertZoneThisTurn_Public_get_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_newAlertZoneThisTurn_Private_set_Void_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_newInBattleActorThisTurn_Public_get_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_newInBattleActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleActorsDamagedByAllie_Public_get_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleActorsDamagedByAllie_Private_set_Void_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleActorsDamagedAfterThisAction_Public_get_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleActorsDamagedAfterThisAction_Private_set_Void_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleActorBuffAfterCurAction_Public_get_Dictionary_2_BattleActor_HashSet_1_KeyValuePair_2_BuffData_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleActorBuffAfterCurAction_Private_set_Void_Dictionary_2_BattleActor_HashSet_1_KeyValuePair_2_BuffData_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_newOffendActionThisTurn_Public_get_Dictionary_2_String_BattleOffendAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_newOffendActionThisTurn_Private_set_Void_Dictionary_2_String_BattleOffendAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_newJoinEnemyOrAllieActorThisTurn_Public_get_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_newJoinEnemyOrAllieActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_newOffendChangeActorThisTurn_Public_get_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_newOffendChangeActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offendedCharacterBeforeBattle_Public_Static_get_List_1_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_offendedCharacterBeforeBattle_Private_Static_set_Void_List_1_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offendedFactionBeforeBattle_Public_Static_get_List_1_FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_offendedFactionBeforeBattle_Private_Static_set_Void_List_1_FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldPetJoinFight_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeTickTotal_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeTickTotal_Private_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_relativePlayerAction_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_relativePlayerAction_Private_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleDebuffRec_SealFactor1_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleDebuffRec_SealFactor1_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleDebuffRec_SealFactor2_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleDebuffRec_SealFactor2_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleDebuffRec_BlindFactor1_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleDebuffRec_BlindFactor1_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleDebuffRec_BlindFactor2_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleDebuffRec_BlindFactor2_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kungfuSense_HigherFactor_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_kungfuSense_HigherFactor_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kungfuSense_LowerFactor_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_kungfuSense_LowerFactor_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kungfuSense_Dealer_High_Public_get_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_kungfuSense_Dealer_High_Private_set_Void_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kungfuSense_Dealer_Low_Public_get_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_kungfuSense_Dealer_Low_Private_set_Void_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kungfuSense_Target_High_Public_get_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_kungfuSense_Target_High_Private_set_Void_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kungfuSense_Target_Low_Public_get_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_kungfuSense_Target_Low_Private_set_Void_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_battleNegLevelOffsetFactor_Public_get_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_battleNegLevelOffsetFactor_Private_set_Void_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantSurrender_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActorByCharacterInstance_Public_BattleActor_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActorByCharacterId_Public_BattleActor_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBattleActorsActionRec_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllBlockTileForActor_Public_List_1_Vector3Int_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAllieTileForActor_Public_List_1_Vector3Int_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllActorInAreaByKungfuEffected_Public_List_1_BattleActor_List_1_Vector3Int_BattleActor_KungfuInstance_byref_List_1_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllActorInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuidingsInAttackArea_Public_List_1_DamagicalBuildingKit_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllEnemiesInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAlliesInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckActorInArea_Public_Boolean_ICollection_1_Vector3Int_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllBattleActors_Public_List_1_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllEnemies_Public_List_1_BattleActor_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAllies_Public_List_1_BattleActor_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllTeamMember_Public_List_1_BattleActor_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActorByTeam_Public_List_1_BattleActor_BattleTeamEnum_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActorOnTile_Public_BattleActor_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFriend_Public_Boolean_BattleActor_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEmptyTilesFromNearToFar_Public_HashSet_1_Vector3Int_Vector3Int_Int32_Int32_Int32_ICollection_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEmptyTileByDist_Public_HashSet_1_Vector3Int_Vector3Int_Int32_Int32_ICollection_1_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTilesFromPosRecursively_Public_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNoSeatBlock_Public_Boolean_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterActiorsListByAwake_Public_List_1_BattleActor_List_1_BattleActor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBattleActorDead_Public_Void_BattleActor_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPerformComplete_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushEventToBattleStageSM_Public_Void_StateMachineDataTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveActiveActorTo_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchTeamInBattle_Public_Void_BattleActor_BattleTeamEnum_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBuffAfterAction_Public_Void_BattleActor_String_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBuffAfterAction_Public_Void_BattleActor_BuffData_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CastActionForActiveActor_Public_Void_KungfuActionCastData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateActionFromCastData_Public_ActorActionBattleFieldEvent_KungfuActionCastData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveActorOnFormationPhase_Public_Void_BattleActor_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveActorImmediate_Public_Void_BattleActor_Vector3Int_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActorImmediate_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPetOnFieldWithPlayerInPerdifinedBattle_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBattleTeam_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBattleStateChange_Private_Void_StateNode_StateNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAI_Public_BattleActorAI_NpcBattleTactics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAI_Public_BattleActorAI_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAllieAndTeammateReactionInInstantBattle_Public_Void_ActorActionBattleFieldEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckBattleResult_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstEmptyPreparePos_Public_Nullable_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestEmptyPreparePos_Public_Nullable_1_Vector3Int_Vector3Int_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IEBattleStart_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BattleComplete_Public_Void_BattleFinishResult_BattleFinishCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeaveBattleImmediately_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeaveBattle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestoyCachedActorGameObject_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchTimeScale_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBattleActor_Public_BattleActor_BattleActorCreateInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBattleActor_Private_BattleActor_BattleTeamEnum_GameCharacterInstance_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBattleActor_Private_BattleActor_BattleActorCreateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPredefinedBattleFieldData_Public_Void_BattleFieldData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBattleActorCreateInfo_Private_BattleActorCreateInfo_GameCharacterInstance_KeyWithValues_BattleTeamEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCharacterCouldJoinIInPredefinedBattle_Public_Boolean_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFormationAcceptableInPredefinedBattle_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedCharacterInPredefinedBattle_Public_Static_Void_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyCompetitionBattle_Public_Void_CompetitionConfig_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharacterAggresiveInNextBattle_Public_Static_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionAggresiveInNextBattle_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionAggresiveInNextBattle_Public_Static_Void_FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsStoryBattle_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInstantBattleData_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeBattleZone_Public_Void_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBattleZone_Public_Boolean_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAdditionAwakeActor_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAdditionEnemyOrAllie_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwakeActorRecursively_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActorInBattleReactEvent_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBattleFieldAllieDamgeActorEvent_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BattleZoneExtend_Public_ActorInBattleReactEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldPlayerTeamRetreatInInstantMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldSingleCharacterRetreat_Public_Boolean_BattleActor_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQuickBattle_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySlgInvasionBattleData_Public_Void_Dlc1InvasionBattleData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySlgUniversalBattle_Public_Void_Dlc1UniversalBattleData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryBreakSeatAndStandUp_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryStandFromSeat_Public_Boolean_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryLeaveBathWater_Public_Boolean_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllRetreatPos_Public_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBattleView_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelayRefreshBattleCard_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshAllAura_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmittingAura_Public_Boolean_BattleActor_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oneTimeDamageGuard_Public_get_List_1_DamageGuard_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_oneTimeDamageGuard_Private_set_Void_List_1_DamageGuard_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterOneTimeDamageGuard_Public_Void_BattleActor_BattleActor_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearOneTimeDamageGuard_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageGuardByTarget_Public_List_1_DamageGuard_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentAdditionActionType_Public_Boolean_AdditionalActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAdditionAction_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAdditionActionIntoList_Public_Void_BattleActor_AdditionalActionType_AdditionalActionAdditionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPotentialCounterActor_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCounterActorFromPotentialActors_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTest_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool _IsQuickBattle_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__IsQuickBattle_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__IsQuickBattle_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static bool _IsQuickBattleWithoutUi_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__IsQuickBattleWithoutUi_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__IsQuickBattleWithoutUi_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static bool _playerIsRetreated_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__playerIsRetreated_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__playerIsRetreated_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStructArray<int> _playerRetreatingData_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__playerRetreatingData_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__playerRetreatingData_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static TileDirection _playerRetreatingDir_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out TileDirection result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__playerRetreatingDir_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__playerRetreatingDir_k__BackingField, (void*)(&tileDirection));
		}
	}

	public unsafe static BattleFinishResult _battleFinishResult_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out BattleFinishResult result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__battleFinishResult_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__battleFinishResult_k__BackingField, (void*)(&battleFinishResult));
		}
	}

	public unsafe static int customWinLoseConditionMatched
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_customWinLoseConditionMatched, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_customWinLoseConditionMatched, (void*)(&num));
		}
	}

	public unsafe static BattleMode _curBattleMode_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out BattleMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__curBattleMode_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__curBattleMode_k__BackingField, (void*)(&battleMode));
		}
	}

	public unsafe static bool _isStoryBattle_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isStoryBattle_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isStoryBattle_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static string _specialBattleBgm_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__specialBattleBgm_k__BackingField, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__specialBattleBgm_k__BackingField, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<GameObject> _cachedActorGoNeedDestroy_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__cachedActorGoNeedDestroy_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__cachedActorGoNeedDestroy_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleFieldDataScriptObject battleFieldDataScriptObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleFieldDataScriptObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleFieldDataScriptObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleFieldDataScriptObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldDataScriptObject));
		}
	}

	public unsafe bool _actorNotHaveImportantAction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actorNotHaveImportantAction_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actorNotHaveImportantAction_k__BackingField)) = flag;
		}
	}

	public unsafe List<Vector3Int> battlePreparePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePreparePos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePreparePos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3Int> battleRetreatPoses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleRetreatPoses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleRetreatPoses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<Vector3Int, TileDirection> battlePreparePosDirDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePreparePosDirDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, TileDirection>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePreparePosDirDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static HashSet<GameCharacterInstance> charactersInPrepare
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_charactersInPrepare, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameCharacterInstance>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_charactersInPrepare, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<BattleActor> deadActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BattleActor> escapedActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapedActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapedActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe StateMachineInstance battleStageSM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleStageSM);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateMachineInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleStageSM)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineInstance));
		}
	}

	public unsafe bool isSmDebugOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSmDebugOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSmDebugOn)) = flag;
		}
	}

	public unsafe List<BattleFinishCondition> victroyConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victroyConditions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleFinishCondition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victroyConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BattleFinishCondition> loseConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseConditions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleFinishCondition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BattleFinishCondition> customVictroyConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customVictroyConditions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleFinishCondition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customVictroyConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BattleFinishCondition> customLoseCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customLoseCondition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleFinishCondition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customLoseCondition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool isBattleFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBattleFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBattleFinished)) = flag;
		}
	}

	public unsafe int battleMapId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleMapId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleMapId)) = num;
		}
	}

	public unsafe bool isNoPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNoPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNoPlayer)) = flag;
		}
	}

	public unsafe List<BattleActorCreateInfo> battleActorsOnField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorsOnField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActorCreateInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorsOnField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameCharacterInstance> playerTeamCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTeamCharacters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTeamCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameCharacterInstance> _defaultCharacterInPredefinedBattle_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultCharacterInPredefinedBattle_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultCharacterInPredefinedBattle_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<int> selectedCharatcerInPredefinedBattle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selectedCharatcerInPredefinedBattle, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selectedCharatcerInPredefinedBattle, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool couldRetreatInInstantBattle
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_couldRetreatInInstantBattle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_couldRetreatInInstantBattle, (void*)(&flag));
		}
	}

	public unsafe HashSet<Vector3Int> _instantBattleZone_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__instantBattleZone_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__instantBattleZone_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Vector3Int> instantBattleRetreatPoses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instantBattleRetreatPoses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instantBattleRetreatPoses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static HashSet<FactionData> _instantBattleOffendedFaction_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instantBattleOffendedFaction_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<FactionData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instantBattleOffendedFaction_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Vector3Int> _newAlertZoneThisTurn_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newAlertZoneThisTurn_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newAlertZoneThisTurn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleActor> _newInBattleActorThisTurn_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newInBattleActorThisTurn_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newInBattleActorThisTurn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleActor> _battleActorsDamagedByAllie_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleActorsDamagedByAllie_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleActorsDamagedByAllie_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleActor> _battleActorsDamagedAfterThisAction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleActorsDamagedAfterThisAction_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleActorsDamagedAfterThisAction_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<BattleActor, HashSet<KeyValuePair<BuffData, BattleActor>>> _battleActorBuffAfterCurAction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleActorBuffAfterCurAction_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, HashSet<KeyValuePair<BuffData, BattleActor>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleActorBuffAfterCurAction_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, BattleOffendAction> _newOffendActionThisTurn_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newOffendActionThisTurn_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, BattleOffendAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newOffendActionThisTurn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<BattleActor> _newJoinEnemyOrAllieActorThisTurn_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newJoinEnemyOrAllieActorThisTurn_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newJoinEnemyOrAllieActorThisTurn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleActor> _newOffendChangeActorThisTurn_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newOffendChangeActorThisTurn_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newOffendChangeActorThisTurn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static List<GameCharacterInstance> _offendedCharacterBeforeBattle_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__offendedCharacterBeforeBattle_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__offendedCharacterBeforeBattle_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<FactionInstance> _offendedFactionBeforeBattle_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__offendedFactionBeforeBattle_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionInstance>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__offendedFactionBeforeBattle_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static GameCharacterInstance duelTarget
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_duelTarget, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_duelTarget, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	public unsafe static int duelMember
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_duelMember, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_duelMember, (void*)(&num));
		}
	}

	public unsafe static bool isFriendlyDuel
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isFriendlyDuel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isFriendlyDuel, (void*)(&flag));
		}
	}

	public unsafe Dictionary<BattleActor, HashSet<BattleAuraInstance>> battleAuraDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleAuraDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, HashSet<BattleAuraInstance>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleAuraDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<BattleAuraInstance, BattleActor> cachedValidAura
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedValidAura);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleAuraInstance, BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedValidAura)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool isBattleAuraDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBattleAuraDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBattleAuraDirty)) = flag;
		}
	}

	public unsafe bool useAdvancedAi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAdvancedAi);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAdvancedAi)) = flag;
		}
	}

	public unsafe Dictionary<NpcBattleTactics, BattleActorAI> battleActorAiDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorAiDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NpcBattleTactics, BattleActorAI>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorAiDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static BattleManager instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleManager));
		}
	}

	public unsafe BattleActor selectedActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedActor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe ActiveActorStateMachineData activeActorStateMachineData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeActorStateMachineData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveActorStateMachineData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeActorStateMachineData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData));
		}
	}

	public unsafe static Dictionary<BattleTeamEnum, BattleTeam> battleTeamDict
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_battleTeamDict, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleTeamEnum, BattleTeam>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_battleTeamDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static float _timeTickTotal_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__timeTickTotal_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__timeTickTotal_k__BackingField, (void*)(&num));
		}
	}

	public unsafe static float _relativePlayerAction_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__relativePlayerAction_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__relativePlayerAction_k__BackingField, (void*)(&num));
		}
	}

	public unsafe float actionRecSpeedModify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionRecSpeedModify);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionRecSpeedModify)) = num;
		}
	}

	public unsafe int medicineUsageLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicineUsageLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicineUsageLimit)) = num;
		}
	}

	public unsafe float _battleDebuffRec_SealFactor1_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_SealFactor1_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_SealFactor1_k__BackingField)) = num;
		}
	}

	public unsafe float _battleDebuffRec_SealFactor2_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_SealFactor2_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_SealFactor2_k__BackingField)) = num;
		}
	}

	public unsafe float _battleDebuffRec_BlindFactor1_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_BlindFactor1_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_BlindFactor1_k__BackingField)) = num;
		}
	}

	public unsafe float _battleDebuffRec_BlindFactor2_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_BlindFactor2_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleDebuffRec_BlindFactor2_k__BackingField)) = num;
		}
	}

	public unsafe int _kungfuSense_HigherFactor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_HigherFactor_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_HigherFactor_k__BackingField)) = num;
		}
	}

	public unsafe int _kungfuSense_LowerFactor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_LowerFactor_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_LowerFactor_k__BackingField)) = num;
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> _kungfuSense_Dealer_High_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Dealer_High_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Dealer_High_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> _kungfuSense_Dealer_Low_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Dealer_Low_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Dealer_Low_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> _kungfuSense_Target_High_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Target_High_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Target_High_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> _kungfuSense_Target_Low_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Target_Low_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kungfuSense_Target_Low_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppSystem.Decimal _battleNegLevelOffsetFactor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleNegLevelOffsetFactor_k__BackingField);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__battleNegLevelOffsetFactor_k__BackingField)) = obj;
		}
	}

	public unsafe List<AdditionalActionData> additionalActionDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalActionDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AdditionalActionData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalActionDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AdditionalActionData currentAdditionalActionData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAdditionalActionData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdditionalActionData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAdditionalActionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalActionData));
		}
	}

	public unsafe List<BattleActor> potentialCounterActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialCounterActors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialCounterActors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<GameCharacterInstance, BattleActor> m_CachedCharacterToActorDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCharacterToActorDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameCharacterInstance, BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCharacterToActorDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<DamageGuard> _oneTimeDamageGuard_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oneTimeDamageGuard_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DamageGuard>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oneTimeDamageGuard_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool IsTestBattle
	{
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsTestBattle_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static bool IsQuickBattle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775509, XrefRangeEnd = 775513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsQuickBattle_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775513, XrefRangeEnd = 775517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsQuickBattle_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool IsQuickBattleWithoutUi
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775517, XrefRangeEnd = 775521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsQuickBattleWithoutUi_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775521, XrefRangeEnd = 775525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsQuickBattleWithoutUi_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool playerIsRetreated
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775525, XrefRangeEnd = 775529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerIsRetreated_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775529, XrefRangeEnd = 775533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerIsRetreated_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static Il2CppStructArray<int> playerRetreatingData
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775533, XrefRangeEnd = 775537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerRetreatingData_Public_Static_get_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775537, XrefRangeEnd = 775541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerRetreatingData_Private_Static_set_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static TileDirection playerRetreatingDir
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775541, XrefRangeEnd = 775545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerRetreatingDir_Public_Static_get_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775545, XrefRangeEnd = 775549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerRetreatingDir_Private_Static_set_Void_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static BattleFinishResult battleFinishResult
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775549, XrefRangeEnd = 775553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleFinishResult_Public_Static_get_BattleFinishResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(BattleFinishResult*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775553, XrefRangeEnd = 775557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleFinishResult_Private_Static_set_Void_BattleFinishResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static BattleMode curBattleMode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775557, XrefRangeEnd = 775561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_curBattleMode_Public_Static_get_BattleMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(BattleMode*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775561, XrefRangeEnd = 775565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_curBattleMode_Private_Static_set_Void_BattleMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool isStoryBattle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775565, XrefRangeEnd = 775569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isStoryBattle_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775569, XrefRangeEnd = 775573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isStoryBattle_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static string specialBattleBgm
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775573, XrefRangeEnd = 775577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_specialBattleBgm_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775577, XrefRangeEnd = 775581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_specialBattleBgm_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static List<GameObject> cachedActorGoNeedDestroy
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775581, XrefRangeEnd = 775585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cachedActorGoNeedDestroy_Public_Static_get_List_1_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775585, XrefRangeEnd = 775589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cachedActorGoNeedDestroy_Private_Static_set_Void_List_1_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool actorNotHaveImportantAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actorNotHaveImportantAction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actorNotHaveImportantAction_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool HasFormationPhase
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 775625, RefRangeEnd = 775628, XrefRangeStart = 775589, XrefRangeEnd = 775625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasFormationPhase_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Dictionary<BattleTeamEnum, BattleTeam> BattleTeamDic
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775628, XrefRangeEnd = 775632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BattleTeamDic_Public_get_Dictionary_2_BattleTeamEnum_BattleTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleTeamEnum, BattleTeam>>(intPtr) : null;
		}
	}

	public unsafe BattleActor ActorInAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActorInAction_Public_get_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
	}

	public unsafe ActiveActorStateMachineData ActiveActorStateMachineData
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveActorStateMachineData_Public_get_ActiveActorStateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveActorStateMachineData>(intPtr) : null;
		}
	}

	public unsafe List<GameCharacterInstance> defaultCharacterInPredefinedBattle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34427, RefRangeEnd = 34428, XrefRangeStart = 34427, XrefRangeEnd = 34428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultCharacterInPredefinedBattle_Public_get_List_1_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultCharacterInPredefinedBattle_Private_set_Void_List_1_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<Vector3Int> instantBattleZone
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instantBattleZone_Public_get_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instantBattleZone_Private_set_Void_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static HashSet<FactionData> instantBattleOffendedFaction
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775632, XrefRangeEnd = 775636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instantBattleOffendedFaction_Public_Static_get_HashSet_1_FactionData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<FactionData>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775636, XrefRangeEnd = 775640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instantBattleOffendedFaction_Private_Static_set_Void_HashSet_1_FactionData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<Vector3Int> newAlertZoneThisTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_newAlertZoneThisTurn_Public_get_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_newAlertZoneThisTurn_Private_set_Void_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<BattleActor> newInBattleActorThisTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_newInBattleActorThisTurn_Public_get_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_newInBattleActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<BattleActor> battleActorsDamagedByAllie
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleActorsDamagedByAllie_Public_get_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleActorsDamagedByAllie_Private_set_Void_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<BattleActor> battleActorsDamagedAfterThisAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleActorsDamagedAfterThisAction_Public_get_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleActorsDamagedAfterThisAction_Private_set_Void_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<BattleActor, HashSet<KeyValuePair<BuffData, BattleActor>>> battleActorBuffAfterCurAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleActorBuffAfterCurAction_Public_get_Dictionary_2_BattleActor_HashSet_1_KeyValuePair_2_BuffData_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, HashSet<KeyValuePair<BuffData, BattleActor>>>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleActorBuffAfterCurAction_Private_set_Void_Dictionary_2_BattleActor_HashSet_1_KeyValuePair_2_BuffData_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<string, BattleOffendAction> newOffendActionThisTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_newOffendActionThisTurn_Public_get_Dictionary_2_String_BattleOffendAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, BattleOffendAction>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_newOffendActionThisTurn_Private_set_Void_Dictionary_2_String_BattleOffendAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<BattleActor> newJoinEnemyOrAllieActorThisTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_newJoinEnemyOrAllieActorThisTurn_Public_get_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_newJoinEnemyOrAllieActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<BattleActor> newOffendChangeActorThisTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_newOffendChangeActorThisTurn_Public_get_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_newOffendChangeActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static List<GameCharacterInstance> offendedCharacterBeforeBattle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775640, XrefRangeEnd = 775644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offendedCharacterBeforeBattle_Public_Static_get_List_1_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775644, XrefRangeEnd = 775648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offendedCharacterBeforeBattle_Private_Static_set_Void_List_1_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static List<FactionInstance> offendedFactionBeforeBattle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775648, XrefRangeEnd = 775652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offendedFactionBeforeBattle_Public_Static_get_List_1_FactionInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionInstance>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775652, XrefRangeEnd = 775656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offendedFactionBeforeBattle_Private_Static_set_Void_List_1_FactionInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool ShouldPetJoinFight
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 775664, RefRangeEnd = 775666, XrefRangeStart = 775656, XrefRangeEnd = 775664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldPetJoinFight_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static float timeTickTotal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775666, XrefRangeEnd = 775670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeTickTotal_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775670, XrefRangeEnd = 775674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeTickTotal_Private_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static float relativePlayerAction
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775674, XrefRangeEnd = 775678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_relativePlayerAction_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775678, XrefRangeEnd = 775682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_relativePlayerAction_Private_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float battleDebuffRec_SealFactor1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleDebuffRec_SealFactor1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleDebuffRec_SealFactor1_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float battleDebuffRec_SealFactor2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleDebuffRec_SealFactor2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleDebuffRec_SealFactor2_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float battleDebuffRec_BlindFactor1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleDebuffRec_BlindFactor1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleDebuffRec_BlindFactor1_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float battleDebuffRec_BlindFactor2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleDebuffRec_BlindFactor2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleDebuffRec_BlindFactor2_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int kungfuSense_HigherFactor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kungfuSense_HigherFactor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_kungfuSense_HigherFactor_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int kungfuSense_LowerFactor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kungfuSense_LowerFactor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_kungfuSense_LowerFactor_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> kungfuSense_Dealer_High
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kungfuSense_Dealer_High_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_kungfuSense_Dealer_High_Private_set_Void_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> kungfuSense_Dealer_Low
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kungfuSense_Dealer_Low_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_kungfuSense_Dealer_Low_Private_set_Void_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> kungfuSense_Target_High
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kungfuSense_Target_High_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_kungfuSense_Target_High_Private_set_Void_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> kungfuSense_Target_Low
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kungfuSense_Target_Low_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_kungfuSense_Target_Low_Private_set_Void_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Decimal battleNegLevelOffsetFactor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_battleNegLevelOffsetFactor_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_battleNegLevelOffsetFactor_Private_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<DamageGuard> oneTimeDamageGuard
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oneTimeDamageGuard_Public_get_List_1_DamageGuard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DamageGuard>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_oneTimeDamageGuard_Private_set_Void_List_1_DamageGuard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static BattleManager()
	{
		Il2CppClassPointerStore<BattleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleManager>.NativeClassPtr);
		NativeFieldInfoPtr__IsQuickBattle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<IsQuickBattle>k__BackingField");
		NativeFieldInfoPtr__IsQuickBattleWithoutUi_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<IsQuickBattleWithoutUi>k__BackingField");
		NativeFieldInfoPtr__playerIsRetreated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<playerIsRetreated>k__BackingField");
		NativeFieldInfoPtr__playerRetreatingData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<playerRetreatingData>k__BackingField");
		NativeFieldInfoPtr__playerRetreatingDir_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<playerRetreatingDir>k__BackingField");
		NativeFieldInfoPtr__battleFinishResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleFinishResult>k__BackingField");
		NativeFieldInfoPtr_customWinLoseConditionMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "customWinLoseConditionMatched");
		NativeFieldInfoPtr__curBattleMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<curBattleMode>k__BackingField");
		NativeFieldInfoPtr__isStoryBattle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<isStoryBattle>k__BackingField");
		NativeFieldInfoPtr__specialBattleBgm_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<specialBattleBgm>k__BackingField");
		NativeFieldInfoPtr__cachedActorGoNeedDestroy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<cachedActorGoNeedDestroy>k__BackingField");
		NativeFieldInfoPtr_battleFieldDataScriptObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleFieldDataScriptObject");
		NativeFieldInfoPtr__actorNotHaveImportantAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<actorNotHaveImportantAction>k__BackingField");
		NativeFieldInfoPtr_battlePreparePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battlePreparePos");
		NativeFieldInfoPtr_battleRetreatPoses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleRetreatPoses");
		NativeFieldInfoPtr_battlePreparePosDirDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battlePreparePosDirDict");
		NativeFieldInfoPtr_charactersInPrepare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "charactersInPrepare");
		NativeFieldInfoPtr_deadActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "deadActors");
		NativeFieldInfoPtr_escapedActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "escapedActors");
		NativeFieldInfoPtr_battleStageSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleStageSM");
		NativeFieldInfoPtr_isSmDebugOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "isSmDebugOn");
		NativeFieldInfoPtr_victroyConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "victroyConditions");
		NativeFieldInfoPtr_loseConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "loseConditions");
		NativeFieldInfoPtr_customVictroyConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "customVictroyConditions");
		NativeFieldInfoPtr_customLoseCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "customLoseCondition");
		NativeFieldInfoPtr_isBattleFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "isBattleFinished");
		NativeFieldInfoPtr_battleMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleMapId");
		NativeFieldInfoPtr_isNoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "isNoPlayer");
		NativeFieldInfoPtr_battleActorsOnField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleActorsOnField");
		NativeFieldInfoPtr_playerTeamCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "playerTeamCharacters");
		NativeFieldInfoPtr__defaultCharacterInPredefinedBattle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<defaultCharacterInPredefinedBattle>k__BackingField");
		NativeFieldInfoPtr_selectedCharatcerInPredefinedBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "selectedCharatcerInPredefinedBattle");
		NativeFieldInfoPtr_couldRetreatInInstantBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "couldRetreatInInstantBattle");
		NativeFieldInfoPtr__instantBattleZone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<instantBattleZone>k__BackingField");
		NativeFieldInfoPtr_instantBattleRetreatPoses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "instantBattleRetreatPoses");
		NativeFieldInfoPtr__instantBattleOffendedFaction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<instantBattleOffendedFaction>k__BackingField");
		NativeFieldInfoPtr__newAlertZoneThisTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<newAlertZoneThisTurn>k__BackingField");
		NativeFieldInfoPtr__newInBattleActorThisTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<newInBattleActorThisTurn>k__BackingField");
		NativeFieldInfoPtr__battleActorsDamagedByAllie_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleActorsDamagedByAllie>k__BackingField");
		NativeFieldInfoPtr__battleActorsDamagedAfterThisAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleActorsDamagedAfterThisAction>k__BackingField");
		NativeFieldInfoPtr__battleActorBuffAfterCurAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleActorBuffAfterCurAction>k__BackingField");
		NativeFieldInfoPtr__newOffendActionThisTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<newOffendActionThisTurn>k__BackingField");
		NativeFieldInfoPtr__newJoinEnemyOrAllieActorThisTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<newJoinEnemyOrAllieActorThisTurn>k__BackingField");
		NativeFieldInfoPtr__newOffendChangeActorThisTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<newOffendChangeActorThisTurn>k__BackingField");
		NativeFieldInfoPtr__offendedCharacterBeforeBattle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<offendedCharacterBeforeBattle>k__BackingField");
		NativeFieldInfoPtr__offendedFactionBeforeBattle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<offendedFactionBeforeBattle>k__BackingField");
		NativeFieldInfoPtr_duelTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "duelTarget");
		NativeFieldInfoPtr_duelMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "duelMember");
		NativeFieldInfoPtr_isFriendlyDuel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "isFriendlyDuel");
		NativeFieldInfoPtr_battleAuraDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleAuraDict");
		NativeFieldInfoPtr_cachedValidAura = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "cachedValidAura");
		NativeFieldInfoPtr_isBattleAuraDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "isBattleAuraDirty");
		NativeFieldInfoPtr_useAdvancedAi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "useAdvancedAi");
		NativeFieldInfoPtr_battleActorAiDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleActorAiDict");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_selectedActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "selectedActor");
		NativeFieldInfoPtr_activeActorStateMachineData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "activeActorStateMachineData");
		NativeFieldInfoPtr_battleTeamDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "battleTeamDict");
		NativeFieldInfoPtr__timeTickTotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<timeTickTotal>k__BackingField");
		NativeFieldInfoPtr__relativePlayerAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<relativePlayerAction>k__BackingField");
		NativeFieldInfoPtr_actionRecSpeedModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "actionRecSpeedModify");
		NativeFieldInfoPtr_medicineUsageLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "medicineUsageLimit");
		NativeFieldInfoPtr__battleDebuffRec_SealFactor1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleDebuffRec_SealFactor1>k__BackingField");
		NativeFieldInfoPtr__battleDebuffRec_SealFactor2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleDebuffRec_SealFactor2>k__BackingField");
		NativeFieldInfoPtr__battleDebuffRec_BlindFactor1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleDebuffRec_BlindFactor1>k__BackingField");
		NativeFieldInfoPtr__battleDebuffRec_BlindFactor2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleDebuffRec_BlindFactor2>k__BackingField");
		NativeFieldInfoPtr__kungfuSense_HigherFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<kungfuSense_HigherFactor>k__BackingField");
		NativeFieldInfoPtr__kungfuSense_LowerFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<kungfuSense_LowerFactor>k__BackingField");
		NativeFieldInfoPtr__kungfuSense_Dealer_High_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<kungfuSense_Dealer_High>k__BackingField");
		NativeFieldInfoPtr__kungfuSense_Dealer_Low_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<kungfuSense_Dealer_Low>k__BackingField");
		NativeFieldInfoPtr__kungfuSense_Target_High_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<kungfuSense_Target_High>k__BackingField");
		NativeFieldInfoPtr__kungfuSense_Target_Low_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<kungfuSense_Target_Low>k__BackingField");
		NativeFieldInfoPtr__battleNegLevelOffsetFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<battleNegLevelOffsetFactor>k__BackingField");
		NativeFieldInfoPtr_additionalActionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "additionalActionDatas");
		NativeFieldInfoPtr_currentAdditionalActionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "currentAdditionalActionData");
		NativeFieldInfoPtr_potentialCounterActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "potentialCounterActors");
		NativeFieldInfoPtr_m_CachedCharacterToActorDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "m_CachedCharacterToActorDict");
		NativeFieldInfoPtr__oneTimeDamageGuard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, "<oneTimeDamageGuard>k__BackingField");
		NativeMethodInfoPtr_get_IsTestBattle_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671300);
		NativeMethodInfoPtr_get_IsQuickBattle_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671301);
		NativeMethodInfoPtr_set_IsQuickBattle_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671302);
		NativeMethodInfoPtr_get_IsQuickBattleWithoutUi_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671303);
		NativeMethodInfoPtr_set_IsQuickBattleWithoutUi_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671304);
		NativeMethodInfoPtr_get_playerIsRetreated_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671305);
		NativeMethodInfoPtr_set_playerIsRetreated_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671306);
		NativeMethodInfoPtr_get_playerRetreatingData_Public_Static_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671307);
		NativeMethodInfoPtr_set_playerRetreatingData_Private_Static_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671308);
		NativeMethodInfoPtr_get_playerRetreatingDir_Public_Static_get_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671309);
		NativeMethodInfoPtr_set_playerRetreatingDir_Private_Static_set_Void_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671310);
		NativeMethodInfoPtr_get_battleFinishResult_Public_Static_get_BattleFinishResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671311);
		NativeMethodInfoPtr_set_battleFinishResult_Private_Static_set_Void_BattleFinishResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671312);
		NativeMethodInfoPtr_get_curBattleMode_Public_Static_get_BattleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671313);
		NativeMethodInfoPtr_set_curBattleMode_Private_Static_set_Void_BattleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671314);
		NativeMethodInfoPtr_get_isStoryBattle_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671315);
		NativeMethodInfoPtr_set_isStoryBattle_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671316);
		NativeMethodInfoPtr_get_specialBattleBgm_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671317);
		NativeMethodInfoPtr_set_specialBattleBgm_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671318);
		NativeMethodInfoPtr_get_cachedActorGoNeedDestroy_Public_Static_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671319);
		NativeMethodInfoPtr_set_cachedActorGoNeedDestroy_Private_Static_set_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671320);
		NativeMethodInfoPtr_get_actorNotHaveImportantAction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671321);
		NativeMethodInfoPtr_set_actorNotHaveImportantAction_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671322);
		NativeMethodInfoPtr_get_HasFormationPhase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671323);
		NativeMethodInfoPtr_get_BattleTeamDic_Public_get_Dictionary_2_BattleTeamEnum_BattleTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671324);
		NativeMethodInfoPtr_get_ActorInAction_Public_get_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671325);
		NativeMethodInfoPtr_get_ActiveActorStateMachineData_Public_get_ActiveActorStateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671326);
		NativeMethodInfoPtr_get_defaultCharacterInPredefinedBattle_Public_get_List_1_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671327);
		NativeMethodInfoPtr_set_defaultCharacterInPredefinedBattle_Private_set_Void_List_1_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671328);
		NativeMethodInfoPtr_get_instantBattleZone_Public_get_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671329);
		NativeMethodInfoPtr_set_instantBattleZone_Private_set_Void_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671330);
		NativeMethodInfoPtr_get_instantBattleOffendedFaction_Public_Static_get_HashSet_1_FactionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671331);
		NativeMethodInfoPtr_set_instantBattleOffendedFaction_Private_Static_set_Void_HashSet_1_FactionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671332);
		NativeMethodInfoPtr_get_newAlertZoneThisTurn_Public_get_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671333);
		NativeMethodInfoPtr_set_newAlertZoneThisTurn_Private_set_Void_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671334);
		NativeMethodInfoPtr_get_newInBattleActorThisTurn_Public_get_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671335);
		NativeMethodInfoPtr_set_newInBattleActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671336);
		NativeMethodInfoPtr_get_battleActorsDamagedByAllie_Public_get_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671337);
		NativeMethodInfoPtr_set_battleActorsDamagedByAllie_Private_set_Void_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671338);
		NativeMethodInfoPtr_get_battleActorsDamagedAfterThisAction_Public_get_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671339);
		NativeMethodInfoPtr_set_battleActorsDamagedAfterThisAction_Private_set_Void_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671340);
		NativeMethodInfoPtr_get_battleActorBuffAfterCurAction_Public_get_Dictionary_2_BattleActor_HashSet_1_KeyValuePair_2_BuffData_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671341);
		NativeMethodInfoPtr_set_battleActorBuffAfterCurAction_Private_set_Void_Dictionary_2_BattleActor_HashSet_1_KeyValuePair_2_BuffData_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671342);
		NativeMethodInfoPtr_get_newOffendActionThisTurn_Public_get_Dictionary_2_String_BattleOffendAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671343);
		NativeMethodInfoPtr_set_newOffendActionThisTurn_Private_set_Void_Dictionary_2_String_BattleOffendAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671344);
		NativeMethodInfoPtr_get_newJoinEnemyOrAllieActorThisTurn_Public_get_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671345);
		NativeMethodInfoPtr_set_newJoinEnemyOrAllieActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671346);
		NativeMethodInfoPtr_get_newOffendChangeActorThisTurn_Public_get_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671347);
		NativeMethodInfoPtr_set_newOffendChangeActorThisTurn_Private_set_Void_HashSet_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671348);
		NativeMethodInfoPtr_get_offendedCharacterBeforeBattle_Public_Static_get_List_1_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671349);
		NativeMethodInfoPtr_set_offendedCharacterBeforeBattle_Private_Static_set_Void_List_1_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671350);
		NativeMethodInfoPtr_get_offendedFactionBeforeBattle_Public_Static_get_List_1_FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671351);
		NativeMethodInfoPtr_set_offendedFactionBeforeBattle_Private_Static_set_Void_List_1_FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671352);
		NativeMethodInfoPtr_get_ShouldPetJoinFight_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671353);
		NativeMethodInfoPtr_get_timeTickTotal_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671354);
		NativeMethodInfoPtr_set_timeTickTotal_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671355);
		NativeMethodInfoPtr_get_relativePlayerAction_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671356);
		NativeMethodInfoPtr_set_relativePlayerAction_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671357);
		NativeMethodInfoPtr_get_battleDebuffRec_SealFactor1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671358);
		NativeMethodInfoPtr_set_battleDebuffRec_SealFactor1_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671359);
		NativeMethodInfoPtr_get_battleDebuffRec_SealFactor2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671360);
		NativeMethodInfoPtr_set_battleDebuffRec_SealFactor2_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671361);
		NativeMethodInfoPtr_get_battleDebuffRec_BlindFactor1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671362);
		NativeMethodInfoPtr_set_battleDebuffRec_BlindFactor1_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671363);
		NativeMethodInfoPtr_get_battleDebuffRec_BlindFactor2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671364);
		NativeMethodInfoPtr_set_battleDebuffRec_BlindFactor2_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671365);
		NativeMethodInfoPtr_get_kungfuSense_HigherFactor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671366);
		NativeMethodInfoPtr_set_kungfuSense_HigherFactor_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671367);
		NativeMethodInfoPtr_get_kungfuSense_LowerFactor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671368);
		NativeMethodInfoPtr_set_kungfuSense_LowerFactor_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671369);
		NativeMethodInfoPtr_get_kungfuSense_Dealer_High_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671370);
		NativeMethodInfoPtr_set_kungfuSense_Dealer_High_Private_set_Void_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671371);
		NativeMethodInfoPtr_get_kungfuSense_Dealer_Low_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671372);
		NativeMethodInfoPtr_set_kungfuSense_Dealer_Low_Private_set_Void_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671373);
		NativeMethodInfoPtr_get_kungfuSense_Target_High_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671374);
		NativeMethodInfoPtr_set_kungfuSense_Target_High_Private_set_Void_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671375);
		NativeMethodInfoPtr_get_kungfuSense_Target_Low_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671376);
		NativeMethodInfoPtr_set_kungfuSense_Target_Low_Private_set_Void_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671377);
		NativeMethodInfoPtr_get_battleNegLevelOffsetFactor_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671378);
		NativeMethodInfoPtr_set_battleNegLevelOffsetFactor_Private_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671379);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671380);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671381);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671382);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671383);
		NativeMethodInfoPtr_InstantSurrender_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671384);
		NativeMethodInfoPtr_GetActorByCharacterInstance_Public_BattleActor_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671385);
		NativeMethodInfoPtr_GetActorByCharacterId_Public_BattleActor_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671386);
		NativeMethodInfoPtr_OnBattleActorsActionRec_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671387);
		NativeMethodInfoPtr_GetAllBlockTileForActor_Public_List_1_Vector3Int_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671388);
		NativeMethodInfoPtr_GetAllAllieTileForActor_Public_List_1_Vector3Int_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671389);
		NativeMethodInfoPtr_GetAllActorInAreaByKungfuEffected_Public_List_1_BattleActor_List_1_Vector3Int_BattleActor_KungfuInstance_byref_List_1_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671390);
		NativeMethodInfoPtr_GetAllActorInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671391);
		NativeMethodInfoPtr_GetBuidingsInAttackArea_Public_List_1_DamagicalBuildingKit_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671392);
		NativeMethodInfoPtr_GetAllEnemiesInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671393);
		NativeMethodInfoPtr_GetAllAlliesInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671394);
		NativeMethodInfoPtr_CheckActorInArea_Public_Boolean_ICollection_1_Vector3Int_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671395);
		NativeMethodInfoPtr_GetAllBattleActors_Public_List_1_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671396);
		NativeMethodInfoPtr_GetAllEnemies_Public_List_1_BattleActor_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671397);
		NativeMethodInfoPtr_GetAllAllies_Public_List_1_BattleActor_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671398);
		NativeMethodInfoPtr_GetAllTeamMember_Public_List_1_BattleActor_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671399);
		NativeMethodInfoPtr_GetActorByTeam_Public_List_1_BattleActor_BattleTeamEnum_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671400);
		NativeMethodInfoPtr_GetActorOnTile_Public_BattleActor_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671401);
		NativeMethodInfoPtr_IsFriend_Public_Boolean_BattleActor_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671402);
		NativeMethodInfoPtr_GetEmptyTilesFromNearToFar_Public_HashSet_1_Vector3Int_Vector3Int_Int32_Int32_Int32_ICollection_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671403);
		NativeMethodInfoPtr_GetEmptyTileByDist_Public_HashSet_1_Vector3Int_Vector3Int_Int32_Int32_ICollection_1_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671404);
		NativeMethodInfoPtr_GetTilesFromPosRecursively_Public_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671405);
		NativeMethodInfoPtr_IsNoSeatBlock_Public_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671406);
		NativeMethodInfoPtr_FilterActiorsListByAwake_Public_List_1_BattleActor_List_1_BattleActor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671407);
		NativeMethodInfoPtr_OnBattleActorDead_Public_Void_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671408);
		NativeMethodInfoPtr_OnPerformComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671409);
		NativeMethodInfoPtr_PushEventToBattleStageSM_Public_Void_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671410);
		NativeMethodInfoPtr_MoveActiveActorTo_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671411);
		NativeMethodInfoPtr_SwitchTeamInBattle_Public_Void_BattleActor_BattleTeamEnum_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671412);
		NativeMethodInfoPtr_RegisterBuffAfterAction_Public_Void_BattleActor_String_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671413);
		NativeMethodInfoPtr_RegisterBuffAfterAction_Public_Void_BattleActor_BuffData_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671414);
		NativeMethodInfoPtr_CastActionForActiveActor_Public_Void_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671415);
		NativeMethodInfoPtr_CreateActionFromCastData_Public_ActorActionBattleFieldEvent_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671416);
		NativeMethodInfoPtr_MoveActorOnFormationPhase_Public_Void_BattleActor_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671417);
		NativeMethodInfoPtr_MoveActorImmediate_Public_Void_BattleActor_Vector3Int_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671418);
		NativeMethodInfoPtr_RemoveActorImmediate_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671419);
		NativeMethodInfoPtr_CheckPetOnFieldWithPlayerInPerdifinedBattle_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671420);
		NativeMethodInfoPtr_InitBattleTeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671421);
		NativeMethodInfoPtr_OnBattleStateChange_Private_Void_StateNode_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671422);
		NativeMethodInfoPtr_GetAI_Public_BattleActorAI_NpcBattleTactics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671423);
		NativeMethodInfoPtr_GetAI_Public_BattleActorAI_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671424);
		NativeMethodInfoPtr_CheckAllieAndTeammateReactionInInstantBattle_Public_Void_ActorActionBattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671425);
		NativeMethodInfoPtr_CheckBattleResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671426);
		NativeMethodInfoPtr_GetFirstEmptyPreparePos_Public_Nullable_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671427);
		NativeMethodInfoPtr_GetNearestEmptyPreparePos_Public_Nullable_1_Vector3Int_Vector3Int_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671428);
		NativeMethodInfoPtr_BattleStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671429);
		NativeMethodInfoPtr_IEBattleStart_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671430);
		NativeMethodInfoPtr_BattleComplete_Public_Void_BattleFinishResult_BattleFinishCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671431);
		NativeMethodInfoPtr_LeaveBattleImmediately_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671432);
		NativeMethodInfoPtr_LeaveBattle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671433);
		NativeMethodInfoPtr_DestoyCachedActorGameObject_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671434);
		NativeMethodInfoPtr_SwitchTimeScale_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671435);
		NativeMethodInfoPtr_CreateBattleActor_Public_BattleActor_BattleActorCreateInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671436);
		NativeMethodInfoPtr_InitBattleActor_Private_BattleActor_BattleTeamEnum_GameCharacterInstance_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671437);
		NativeMethodInfoPtr_InitBattleActor_Private_BattleActor_BattleActorCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671438);
		NativeMethodInfoPtr_ApplyPredefinedBattleFieldData_Public_Void_BattleFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671439);
		NativeMethodInfoPtr_CreateBattleActorCreateInfo_Private_BattleActorCreateInfo_GameCharacterInstance_KeyWithValues_BattleTeamEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671440);
		NativeMethodInfoPtr_IsCharacterCouldJoinIInPredefinedBattle_Public_Boolean_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671441);
		NativeMethodInfoPtr_IsFormationAcceptableInPredefinedBattle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671442);
		NativeMethodInfoPtr_SetSelectedCharacterInPredefinedBattle_Public_Static_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671443);
		NativeMethodInfoPtr_ApplyCompetitionBattle_Public_Void_CompetitionConfig_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671444);
		NativeMethodInfoPtr_SetCharacterAggresiveInNextBattle_Public_Static_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671445);
		NativeMethodInfoPtr_SetFactionAggresiveInNextBattle_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671446);
		NativeMethodInfoPtr_SetFactionAggresiveInNextBattle_Public_Static_Void_FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671447);
		NativeMethodInfoPtr_SetIsStoryBattle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671448);
		NativeMethodInfoPtr_ApplyInstantBattleData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671449);
		NativeMethodInfoPtr_MergeBattleZone_Public_Void_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671450);
		NativeMethodInfoPtr_IsBattleZone_Public_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671451);
		NativeMethodInfoPtr_SetAdditionAwakeActor_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671452);
		NativeMethodInfoPtr_SetAdditionEnemyOrAllie_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671453);
		NativeMethodInfoPtr_AwakeActorRecursively_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671454);
		NativeMethodInfoPtr_OnActorInBattleReactEvent_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671455);
		NativeMethodInfoPtr_OnBattleFieldAllieDamgeActorEvent_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671456);
		NativeMethodInfoPtr_BattleZoneExtend_Public_ActorInBattleReactEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671457);
		NativeMethodInfoPtr_CouldPlayerTeamRetreatInInstantMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671458);
		NativeMethodInfoPtr_CouldSingleCharacterRetreat_Public_Boolean_BattleActor_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671459);
		NativeMethodInfoPtr_SetQuickBattle_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671460);
		NativeMethodInfoPtr_ApplySlgInvasionBattleData_Public_Void_Dlc1InvasionBattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671461);
		NativeMethodInfoPtr_ApplySlgUniversalBattle_Public_Void_Dlc1UniversalBattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671462);
		NativeMethodInfoPtr_TryBreakSeatAndStandUp_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671463);
		NativeMethodInfoPtr_TryStandFromSeat_Public_Boolean_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671464);
		NativeMethodInfoPtr_TryLeaveBathWater_Public_Boolean_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671465);
		NativeMethodInfoPtr_GetAllRetreatPos_Public_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671466);
		NativeMethodInfoPtr_InitBattleView_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671467);
		NativeMethodInfoPtr_DelayRefreshBattleCard_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671468);
		NativeMethodInfoPtr_RefreshAllAura_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671469);
		NativeMethodInfoPtr_IsEmittingAura_Public_Boolean_BattleActor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671470);
		NativeMethodInfoPtr_get_oneTimeDamageGuard_Public_get_List_1_DamageGuard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671471);
		NativeMethodInfoPtr_set_oneTimeDamageGuard_Private_set_Void_List_1_DamageGuard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671472);
		NativeMethodInfoPtr_RegisterOneTimeDamageGuard_Public_Void_BattleActor_BattleActor_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671473);
		NativeMethodInfoPtr_ClearOneTimeDamageGuard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671474);
		NativeMethodInfoPtr_GetDamageGuardByTarget_Public_List_1_DamageGuard_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671475);
		NativeMethodInfoPtr_IsCurrentAdditionActionType_Public_Boolean_AdditionalActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671476);
		NativeMethodInfoPtr_IsAdditionAction_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671477);
		NativeMethodInfoPtr_AddAdditionActionIntoList_Public_Void_BattleActor_AdditionalActionType_AdditionalActionAdditionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671478);
		NativeMethodInfoPtr_RegisterPotentialCounterActor_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671479);
		NativeMethodInfoPtr_GetCounterActorFromPotentialActors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671480);
		NativeMethodInfoPtr_DoTest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671481);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleManager>.NativeClassPtr, 100671482);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775682, XrefRangeEnd = 775780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775780, XrefRangeEnd = 775840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775840, XrefRangeEnd = 775875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775875, XrefRangeEnd = 775928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstantSurrender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantSurrender_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 775941, RefRangeEnd = 775960, XrefRangeStart = 775928, XrefRangeEnd = 775941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor GetActorByCharacterInstance(GameCharacterInstance gameCharacterInstance, bool includeDeadAndEscape = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDeadAndEscape;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActorByCharacterInstance_Public_BattleActor_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775960, XrefRangeEnd = 775980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor GetActorByCharacterId(int instanceId, bool includeDeadAndEscape = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instanceId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDeadAndEscape;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActorByCharacterId_Public_BattleActor_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775980, XrefRangeEnd = 776123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBattleActorsActionRec(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBattleActorsActionRec_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776137, RefRangeEnd = 776139, XrefRangeStart = 776123, XrefRangeEnd = 776137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> GetAllBlockTileForActor(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBlockTileForActor_Public_List_1_Vector3Int_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776153, RefRangeEnd = 776155, XrefRangeStart = 776139, XrefRangeEnd = 776153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> GetAllAllieTileForActor(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAllieTileForActor_Public_List_1_Vector3Int_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776211, RefRangeEnd = 776213, XrefRangeStart = 776155, XrefRangeEnd = 776211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllActorInAreaByKungfuEffected(List<Vector3Int> area, BattleActor caster, KungfuInstance kungfuInstance, out List<BattleActor> ignoredNeutral, bool useIgnoreRule = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useIgnoreRule;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllActorInAreaByKungfuEffected_Public_List_1_BattleActor_List_1_Vector3Int_BattleActor_KungfuInstance_byref_List_1_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		ignoredNeutral = ((num3 == 0) ? null : new List<BattleActor>(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 776223, RefRangeEnd = 776228, XrefRangeStart = 776213, XrefRangeEnd = 776223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllActorInArea(ICollection<Vector3Int> area)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllActorInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776249, RefRangeEnd = 776251, XrefRangeStart = 776228, XrefRangeEnd = 776249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DamagicalBuildingKit> GetBuidingsInAttackArea(List<Vector3Int> area)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuidingsInAttackArea_Public_List_1_DamagicalBuildingKit_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DamagicalBuildingKit>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 776285, RefRangeEnd = 776288, XrefRangeStart = 776251, XrefRangeEnd = 776285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllEnemiesInArea(ICollection<Vector3Int> area, BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllEnemiesInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776288, XrefRangeEnd = 776298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllAlliesInArea(ICollection<Vector3Int> area, BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAlliesInArea_Public_List_1_BattleActor_ICollection_1_Vector3Int_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776298, XrefRangeEnd = 776301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckActorInArea(ICollection<Vector3Int> area, BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckActorInArea_Public_Boolean_ICollection_1_Vector3Int_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 776330, RefRangeEnd = 776349, XrefRangeStart = 776301, XrefRangeEnd = 776330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllBattleActors(bool includeDeadAndEscaped = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeDeadAndEscaped);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBattleActors_Public_List_1_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 776379, RefRangeEnd = 776386, XrefRangeStart = 776349, XrefRangeEnd = 776379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllEnemies(BattleActor actor, bool neutralIsAggressive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &neutralIsAggressive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllEnemies_Public_List_1_BattleActor_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 776410, RefRangeEnd = 776414, XrefRangeStart = 776386, XrefRangeEnd = 776410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllAllies(BattleActor actor, bool includeSelf = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAllies_Public_List_1_BattleActor_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776414, XrefRangeEnd = 776417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetAllTeamMember(BattleActor actor, bool includeSelf = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllTeamMember_Public_List_1_BattleActor_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 776439, RefRangeEnd = 776469, XrefRangeStart = 776417, XrefRangeEnd = 776439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> GetActorByTeam(BattleTeamEnum battleTeamEnum, BattleActor actor = null, bool includeSelf = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&battleTeamEnum);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActorByTeam_Public_List_1_BattleActor_BattleTeamEnum_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 776565, RefRangeEnd = 776572, XrefRangeStart = 776469, XrefRangeEnd = 776565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor GetActorOnTile(Vector3Int tile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tile);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActorOnTile_Public_BattleActor_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 776574, RefRangeEnd = 776582, XrefRangeStart = 776572, XrefRangeEnd = 776574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFriend(BattleActor x, BattleActor y, bool neutralAsFriend = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &neutralAsFriend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFriend_Public_Boolean_BattleActor_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 776611, RefRangeEnd = 776614, XrefRangeStart = 776582, XrefRangeEnd = 776611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Vector3Int> GetEmptyTilesFromNearToFar(Vector3Int center, int minDist, int maxDist, int needTilesCounts, ICollection<Vector3Int> additionBlock = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&center);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDist;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDist;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &needTilesCounts;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEmptyTilesFromNearToFar_Public_HashSet_1_Vector3Int_Vector3Int_Int32_Int32_Int32_ICollection_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776727, RefRangeEnd = 776729, XrefRangeStart = 776614, XrefRangeEnd = 776727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Vector3Int> GetEmptyTileByDist(Vector3Int center, int minDist, int maxDist, ICollection<Vector3Int> additionBlock = null, bool canSwim = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&center);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDist;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDist;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionBlock);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &canSwim;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEmptyTileByDist_Public_HashSet_1_Vector3Int_Vector3Int_Int32_Int32_ICollection_1_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776739, RefRangeEnd = 776740, XrefRangeStart = 776729, XrefRangeEnd = 776739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTilesFromPosRecursively(int movePoint, Vector3Int pos, ref Dictionary<Vector3Int, int> area, bool seatIsOk = false, bool canSwim = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&movePoint);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &seatIsOk;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &canSwim;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTilesFromPosRecursively_Public_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		area = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Vector3Int, int>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776740, XrefRangeEnd = 776747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsNoSeatBlock(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNoSeatBlock_Public_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776763, RefRangeEnd = 776764, XrefRangeStart = 776747, XrefRangeEnd = 776763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BattleActor> FilterActiorsListByAwake(List<BattleActor> source, bool isAwake)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isAwake;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterActiorsListByAwake_Public_List_1_BattleActor_List_1_BattleActor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776776, RefRangeEnd = 776777, XrefRangeStart = 776764, XrefRangeEnd = 776776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBattleActorDead(BattleActor deadActor, BattleActor dealerActor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deadActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBattleActorDead_Public_Void_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776804, RefRangeEnd = 776805, XrefRangeStart = 776777, XrefRangeEnd = 776804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPerformComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPerformComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776805, XrefRangeEnd = 776808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushEventToBattleStageSM(StateMachineDataTypes stateMachineDataTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stateMachineDataTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushEventToBattleStageSM_Public_Void_StateMachineDataTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776882, RefRangeEnd = 776883, XrefRangeStart = 776808, XrefRangeEnd = 776882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveActiveActorTo(Vector3Int pos, Il2CppStructArray<Vector3Int> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveActiveActorTo_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 776920, RefRangeEnd = 776925, XrefRangeStart = 776883, XrefRangeEnd = 776920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchTeamInBattle(BattleActor actor, BattleTeamEnum targetTeam, bool activeInstantBattleRule = true, bool changeRelation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(BattleTeamEnum**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetTeam;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeInstantBattleRule;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeRelation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchTeamInBattle_Public_Void_BattleActor_BattleTeamEnum_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776953, RefRangeEnd = 776955, XrefRangeStart = 776925, XrefRangeEnd = 776953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterBuffAfterAction(BattleActor actor, string buffName, BattleActor caster)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(buffName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBuffAfterAction_Public_Void_BattleActor_String_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776976, RefRangeEnd = 776977, XrefRangeStart = 776955, XrefRangeEnd = 776976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterBuffAfterAction(BattleActor actor, BuffData buffData, BattleActor caster)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caster);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBuffAfterAction_Public_Void_BattleActor_BuffData_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 777345, RefRangeEnd = 777354, XrefRangeStart = 776977, XrefRangeEnd = 777345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CastActionForActiveActor(KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CastActionForActiveActor_Public_Void_KungfuActionCastData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777354, XrefRangeEnd = 777637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorActionBattleFieldEvent CreateActionFromCastData(KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateActionFromCastData_Public_ActorActionBattleFieldEvent_KungfuActionCastData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorActionBattleFieldEvent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777637, XrefRangeEnd = 777674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveActorOnFormationPhase(BattleActor actor, Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveActorOnFormationPhase_Public_Void_BattleActor_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777674, XrefRangeEnd = 777694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveActorImmediate(BattleActor battleActor, Vector3Int pos, TileDirection dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(TileDirection**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveActorImmediate_Public_Void_BattleActor_Vector3Int_TileDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 777721, RefRangeEnd = 777725, XrefRangeStart = 777694, XrefRangeEnd = 777721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveActorImmediate(BattleActor battleActor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActorImmediate_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 777813, RefRangeEnd = 777815, XrefRangeStart = 777725, XrefRangeEnd = 777813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckPetOnFieldWithPlayerInPerdifinedBattle(bool joinOrLeaveIfNeed = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&joinOrLeaveIfNeed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPetOnFieldWithPlayerInPerdifinedBattle_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777815, XrefRangeEnd = 777852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitBattleTeam()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBattleTeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777852, XrefRangeEnd = 777863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBattleStateChange(StateNode from, StateNode to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBattleStateChange_Private_Void_StateNode_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 777872, RefRangeEnd = 777876, XrefRangeStart = 777863, XrefRangeEnd = 777872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorAI GetAI(NpcBattleTactics npcBattleTactics)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcBattleTactics);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAI_Public_BattleActorAI_NpcBattleTactics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorAI>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 777879, RefRangeEnd = 777880, XrefRangeStart = 777876, XrefRangeEnd = 777879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorAI GetAI(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAI_Public_BattleActorAI_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActorAI>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778066, RefRangeEnd = 778067, XrefRangeStart = 777880, XrefRangeEnd = 778066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAllieAndTeammateReactionInInstantBattle(ActorActionBattleFieldEvent actionBattleFieldEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionBattleFieldEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAllieAndTeammateReactionInInstantBattle_Public_Void_ActorActionBattleFieldEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778108, RefRangeEnd = 778109, XrefRangeStart = 778067, XrefRangeEnd = 778108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckBattleResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckBattleResult_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778129, RefRangeEnd = 778130, XrefRangeStart = 778109, XrefRangeEnd = 778129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<Vector3Int> GetFirstEmptyPreparePos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstEmptyPreparePos_Public_Nullable_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<Vector3Int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778158, RefRangeEnd = 778159, XrefRangeStart = 778130, XrefRangeEnd = 778158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<Vector3Int> GetNearestEmptyPreparePos(Vector3Int pos, HashSet<Vector3Int> additionOccupiedPoses = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionOccupiedPoses);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestEmptyPreparePos_Public_Nullable_1_Vector3Int_Vector3Int_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<Vector3Int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778165, RefRangeEnd = 778166, XrefRangeStart = 778159, XrefRangeEnd = 778165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BattleStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778166, XrefRangeEnd = 778170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator IEBattleStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IEBattleStart_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 778246, RefRangeEnd = 778249, XrefRangeStart = 778170, XrefRangeEnd = 778246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleComplete(BattleFinishResult result, BattleFinishCondition effectiveCondition = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectiveCondition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BattleComplete_Public_Void_BattleFinishResult_BattleFinishCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 778322, RefRangeEnd = 778325, XrefRangeStart = 778249, XrefRangeEnd = 778322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveBattleImmediately()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaveBattleImmediately_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 778451, RefRangeEnd = 778453, XrefRangeStart = 778325, XrefRangeEnd = 778451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveBattle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaveBattle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 778494, RefRangeEnd = 778498, XrefRangeStart = 778453, XrefRangeEnd = 778494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestoyCachedActorGameObject()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestoyCachedActorGameObject_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778507, RefRangeEnd = 778508, XrefRangeStart = 778498, XrefRangeEnd = 778507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchTimeScale(int speedLv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speedLv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchTimeScale_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 778561, RefRangeEnd = 778567, XrefRangeStart = 778508, XrefRangeEnd = 778561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor CreateBattleActor(BattleActorCreateInfo info, bool showOnMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showOnMap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBattleActor_Public_BattleActor_BattleActorCreateInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 778567, XrefRangeEnd = 778568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor InitBattleActor(BattleTeamEnum battleTeamEnum, GameCharacterInstance gameCharacterInstance, Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&battleTeamEnum);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(Vector3Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBattleActor_Private_BattleActor_BattleTeamEnum_GameCharacterInstance_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 778652, RefRangeEnd = 778654, XrefRangeStart = 778568, XrefRangeEnd = 778652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActor InitBattleActor(BattleActorCreateInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBattleActor_Private_BattleActor_BattleActorCreateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 778907, RefRangeEnd = 778908, XrefRangeStart = 778654, XrefRangeEnd = 778907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPredefinedBattleFieldData(BattleFieldData battleFieldData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPredefinedBattleFieldData_Public_Void_BattleFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 778913, RefRangeEnd = 778919, XrefRangeStart = 778908, XrefRangeEnd = 778913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorCreateInfo CreateBattleActorCreateInfo(GameCharacterInstance gameCharacterInstance, KeyWithValues pos, BattleTeamEnum team)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pos);
		*(BattleTeamEnum**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &team;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBattleActorCreateInfo_Private_BattleActorCreateInfo_GameCharacterInstance_KeyWithValues_BattleTeamEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BattleActorCreateInfo(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 778954, RefRangeEnd = 778956, XrefRangeStart = 778919, XrefRangeEnd = 778954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCharacterCouldJoinIInPredefinedBattle(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCharacterCouldJoinIInPredefinedBattle_Public_Boolean_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779070, RefRangeEnd = 779071, XrefRangeStart = 778956, XrefRangeEnd = 779070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFormationAcceptableInPredefinedBattle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFormationAcceptableInPredefinedBattle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 779076, RefRangeEnd = 779078, XrefRangeStart = 779071, XrefRangeEnd = 779076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSelectedCharacterInPredefinedBattle(List<int> instanceIds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instanceIds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedCharacterInPredefinedBattle_Public_Static_Void_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779078, XrefRangeEnd = 779157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyCompetitionBattle(CompetitionConfig config, GameCharacterInstance enemy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enemy);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyCompetitionBattle_Public_Void_CompetitionConfig_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 779178, RefRangeEnd = 779180, XrefRangeStart = 779157, XrefRangeEnd = 779178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCharacterAggresiveInNextBattle(GameCharacterInstance gameCharacterInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharacterAggresiveInNextBattle_Public_Static_Void_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779213, RefRangeEnd = 779214, XrefRangeStart = 779180, XrefRangeEnd = 779213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFactionAggresiveInNextBattle(int factionId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&factionId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionAggresiveInNextBattle_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779214, XrefRangeEnd = 779236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFactionAggresiveInNextBattle(FactionInstance factionInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionAggresiveInNextBattle_Public_Static_Void_FactionInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779244, RefRangeEnd = 779245, XrefRangeStart = 779236, XrefRangeEnd = 779244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsStoryBattle(bool fromStory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fromStory);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsStoryBattle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779422, RefRangeEnd = 779423, XrefRangeStart = 779245, XrefRangeEnd = 779422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyInstantBattleData(bool isDuel = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isDuel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyInstantBattleData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 779528, RefRangeEnd = 779530, XrefRangeStart = 779423, XrefRangeEnd = 779528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeBattleZone(HashSet<Vector3Int> zone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeBattleZone_Public_Void_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779530, XrefRangeEnd = 779541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBattleZone(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBattleZone_Public_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779548, RefRangeEnd = 779549, XrefRangeStart = 779541, XrefRangeEnd = 779548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAdditionAwakeActor(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAdditionAwakeActor_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779585, RefRangeEnd = 779586, XrefRangeStart = 779549, XrefRangeEnd = 779585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAdditionEnemyOrAllie(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAdditionEnemyOrAllie_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779633, RefRangeEnd = 779634, XrefRangeStart = 779586, XrefRangeEnd = 779633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwakeActorRecursively()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AwakeActorRecursively_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779634, XrefRangeEnd = 779641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActorInBattleReactEvent(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActorInBattleReactEvent_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779641, XrefRangeEnd = 779647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBattleFieldAllieDamgeActorEvent(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBattleFieldAllieDamgeActorEvent_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779888, RefRangeEnd = 779889, XrefRangeStart = 779647, XrefRangeEnd = 779888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorInBattleReactEvent BattleZoneExtend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BattleZoneExtend_Public_ActorInBattleReactEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorInBattleReactEvent>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 779912, RefRangeEnd = 779913, XrefRangeStart = 779889, XrefRangeEnd = 779912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldPlayerTeamRetreatInInstantMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldPlayerTeamRetreatInInstantMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 779984, RefRangeEnd = 779987, XrefRangeStart = 779913, XrefRangeEnd = 779984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldSingleCharacterRetreat(BattleActor battleActor, Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldSingleCharacterRetreat_Public_Boolean_BattleActor_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779987, XrefRangeEnd = 779999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetQuickBattle(bool withoutUi = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&withoutUi);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQuickBattle_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779999, XrefRangeEnd = 780165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySlgInvasionBattleData(Dlc1InvasionBattleData dlc1InvasionBattleData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1InvasionBattleData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySlgInvasionBattleData_Public_Void_Dlc1InvasionBattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780165, XrefRangeEnd = 780311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySlgUniversalBattle(Dlc1UniversalBattleData CurBattleData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)CurBattleData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySlgUniversalBattle_Public_Void_Dlc1UniversalBattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 780384, RefRangeEnd = 780385, XrefRangeStart = 780311, XrefRangeEnd = 780384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryBreakSeatAndStandUp(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryBreakSeatAndStandUp_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 780526, RefRangeEnd = 780531, XrefRangeStart = 780385, XrefRangeEnd = 780526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryStandFromSeat(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryStandFromSeat_Public_Boolean_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 780586, RefRangeEnd = 780589, XrefRangeStart = 780531, XrefRangeEnd = 780586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryLeaveBathWater(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLeaveBathWater_Public_Boolean_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780589, XrefRangeEnd = 780654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> GetAllRetreatPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllRetreatPos_Public_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 780880, RefRangeEnd = 780884, XrefRangeStart = 780654, XrefRangeEnd = 780880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitBattleView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBattleView_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780884, XrefRangeEnd = 780888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DelayRefreshBattleCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelayRefreshBattleCard_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 780979, RefRangeEnd = 780982, XrefRangeStart = 780888, XrefRangeEnd = 780979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshAllAura()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshAllAura_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781002, RefRangeEnd = 781003, XrefRangeStart = 780982, XrefRangeEnd = 781002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEmittingAura(BattleActor actor, string auraName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(auraName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmittingAura_Public_Boolean_BattleActor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781012, RefRangeEnd = 781013, XrefRangeStart = 781003, XrefRangeEnd = 781012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterOneTimeDamageGuard(BattleActor guardian, BattleActor guardTarget, float guardRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guardian);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guardTarget);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &guardRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterOneTimeDamageGuard_Public_Void_BattleActor_BattleActor_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781017, RefRangeEnd = 781018, XrefRangeStart = 781013, XrefRangeEnd = 781017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearOneTimeDamageGuard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearOneTimeDamageGuard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781038, RefRangeEnd = 781039, XrefRangeStart = 781018, XrefRangeEnd = 781038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DamageGuard> GetDamageGuardByTarget(BattleActor target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDamageGuardByTarget_Public_List_1_DamageGuard_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DamageGuard>>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 781039, RefRangeEnd = 781049, XrefRangeStart = 781039, XrefRangeEnd = 781039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCurrentAdditionActionType(AdditionalActionType additionalActionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&additionalActionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCurrentAdditionActionType_Public_Boolean_AdditionalActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsAdditionAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAdditionAction_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 781067, RefRangeEnd = 781069, XrefRangeStart = 781049, XrefRangeEnd = 781067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAdditionActionIntoList(BattleActor actor, AdditionalActionType additionalActionType, AdditionalActionAdditionData additionalActionAdditionData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(AdditionalActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &additionalActionType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalActionAdditionData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAdditionActionIntoList_Public_Void_BattleActor_AdditionalActionType_AdditionalActionAdditionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781075, RefRangeEnd = 781076, XrefRangeStart = 781069, XrefRangeEnd = 781075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterPotentialCounterActor(BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterPotentialCounterActor_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781159, RefRangeEnd = 781160, XrefRangeStart = 781076, XrefRangeEnd = 781159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCounterActorFromPotentialActors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCounterActorFromPotentialActors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781169, RefRangeEnd = 781170, XrefRangeStart = 781160, XrefRangeEnd = 781169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781170, XrefRangeEnd = 781402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
