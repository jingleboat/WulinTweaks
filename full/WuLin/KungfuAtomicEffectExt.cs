using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public static class KungfuAtomicEffectExt : Il2CppSystem.Object
{
	public class IAtomicEffectLogic : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_DoLogic_Public_Abstract_Virtual_New_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		static IAtomicEffectLogic()
		{
			Il2CppClassPointerStore<IAtomicEffectLogic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "IAtomicEffectLogic");
			NativeMethodInfoPtr_DoLogic_Public_Abstract_Virtual_New_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAtomicEffectLogic>.NativeClassPtr, 100686378);
		}

		[CallerCount(0)]
		public unsafe virtual void DoLogic(BaseKungfuAtomicEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoLogic_Public_Abstract_Virtual_New_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		public IAtomicEffectLogic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BaseKungfuAtomicEffect_Logic<K> : Il2CppSystem.Object where K : BaseKungfuAtomicEffect
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_DoLogic_Public_Virtual_Final_New_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffect_Public_Virtual_New_Void_K_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_New_Void_K_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndLinkStandardCharacterPropModifyEvent_Public_Static_Void_BattleActor_byref_BattleFieldEvent_byref_BattleFieldEvent_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddBattleFieldEventIntoList_Public_Static_Void_BattleFieldEvent_byref_BattleFieldEvent_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDamageResult_Public_Static_Void_BattleActor_BattleActor_byref_BattleFieldEvent_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static BaseKungfuAtomicEffect_Logic()
		{
			Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "BaseKungfuAtomicEffect_Logic`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr);
			NativeMethodInfoPtr_DoLogic_Public_Virtual_Final_New_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686379);
			NativeMethodInfoPtr_InvokeEffect_Public_Virtual_New_Void_K_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686380);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_New_Void_K_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686381);
			NativeMethodInfoPtr_CreateAndLinkStandardCharacterPropModifyEvent_Public_Static_Void_BattleActor_byref_BattleFieldEvent_byref_BattleFieldEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686382);
			NativeMethodInfoPtr_AddBattleFieldEventIntoList_Public_Static_Void_BattleFieldEvent_byref_BattleFieldEvent_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686383);
			NativeMethodInfoPtr_CheckDamageResult_Public_Static_Void_BattleActor_BattleActor_byref_BattleFieldEvent_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686384);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr, 100686385);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785585, XrefRangeEnd = 785592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoLogic(BaseKungfuAtomicEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLogic_Public_Virtual_Final_New_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785592, XrefRangeEnd = 785699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeEffect(K effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			ref K reference;
			if (!typeof(K).IsValueType)
			{
				K val = effect;
				reference = ref *(K*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref effect;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffect_Public_Virtual_New_Void_K_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeEffectAfterExclude(K effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			ref K reference;
			if (!typeof(K).IsValueType)
			{
				K val = effect;
				reference = ref *(K*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref effect;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_New_Void_K_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 785711, RefRangeEnd = 785713, XrefRangeStart = 785699, XrefRangeEnd = 785711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateAndLinkStandardCharacterPropModifyEvent(BattleActor actor, ref BattleFieldEvent startEvent, ref BattleFieldEvent endEvent, bool forceAddModifyEvent = false)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startEvent);
			*(System.IntPtr**)num = &intPtr;
			byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endEvent);
			*(System.IntPtr**)num2 = &intPtr2;
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceAddModifyEvent;
			Unsafe.SkipInit(out System.IntPtr intPtr4);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAndLinkStandardCharacterPropModifyEvent_Public_Static_Void_BattleActor_byref_BattleFieldEvent_byref_BattleFieldEvent_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			System.IntPtr intPtr5 = intPtr;
			startEvent = ((intPtr5 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr5));
			System.IntPtr intPtr6 = intPtr2;
			endEvent = ((intPtr6 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr6));
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 785717, RefRangeEnd = 785726, XrefRangeStart = 785713, XrefRangeEnd = 785717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddBattleFieldEventIntoList(BattleFieldEvent curEvent, ref BattleFieldEvent startEvent, ref BattleFieldEvent endEvent)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curEvent);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startEvent);
			*(System.IntPtr**)num = &intPtr;
			byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endEvent);
			*(System.IntPtr**)num2 = &intPtr2;
			Unsafe.SkipInit(out System.IntPtr intPtr4);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBattleFieldEventIntoList_Public_Static_Void_BattleFieldEvent_byref_BattleFieldEvent_byref_BattleFieldEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			System.IntPtr intPtr5 = intPtr;
			startEvent = ((intPtr5 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr5));
			System.IntPtr intPtr6 = intPtr2;
			endEvent = ((intPtr6 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr6));
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 786107, RefRangeEnd = 786112, XrefRangeStart = 785726, XrefRangeEnd = 786107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckDamageResult(BattleActor dealerActor, BattleActor targetActor, ref BattleFieldEvent startEvent, ref BattleFieldEvent endEvent)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActor);
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startEvent);
			*(System.IntPtr**)num = &intPtr;
			byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endEvent);
			*(System.IntPtr**)num2 = &intPtr2;
			Unsafe.SkipInit(out System.IntPtr intPtr4);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDamageResult_Public_Static_Void_BattleActor_BattleActor_byref_BattleFieldEvent_byref_BattleFieldEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			System.IntPtr intPtr5 = intPtr;
			startEvent = ((intPtr5 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr5));
			System.IntPtr intPtr6 = intPtr2;
			endEvent = ((intPtr6 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr6));
		}

		[CallerCount(185)]
		[CachedScanResults(RefRangeStart = 111000, RefRangeEnd = 111185, XrefRangeStart = 111000, XrefRangeEnd = 111185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseKungfuAtomicEffect_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseKungfuAtomicEffect_Logic<K>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BaseKungfuAtomicEffect_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DefaultDamageEffect_Logic : BaseKungfuAtomicEffect_Logic<DefaultDamageEffect>
	{
		public class DamageCalculateProps : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_powerModifier;

			private static readonly System.IntPtr NativeFieldInfoPtr_atkDefModifier;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerBattleExpOffsetEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerInternalTypeEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerHoldingPower;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerFractureEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerPoisonEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerDefend;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerInjuryEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerLevelOffsetEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_hasKungfuPropEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerTecHealOffsetEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerTecPoisonOffsetEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_canTriggerMoralOffsetEffect;

			private static readonly System.IntPtr NativeFieldInfoPtr_isCirted;

			private static readonly System.IntPtr NativeFieldInfoPtr_isParry;

			private static readonly System.IntPtr NativeFieldInfoPtr_isSplashActor;

			private static readonly System.IntPtr NativeFieldInfoPtr_splashFactor;

			private static readonly System.IntPtr NativeFieldInfoPtr_dualStrikeFactor;

			private static readonly System.IntPtr NativeFieldInfoPtr_effectDamageOffset;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe float powerModifier
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerModifier);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerModifier)) = num;
				}
			}

			public unsafe float atkDefModifier
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atkDefModifier);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atkDefModifier)) = num;
				}
			}

			public unsafe bool canTriggerBattleExpOffsetEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerBattleExpOffsetEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerBattleExpOffsetEffect)) = flag;
				}
			}

			public unsafe bool canTriggerInternalTypeEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerInternalTypeEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerInternalTypeEffect)) = flag;
				}
			}

			public unsafe bool canTriggerHoldingPower
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerHoldingPower);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerHoldingPower)) = flag;
				}
			}

			public unsafe bool canTriggerFractureEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerFractureEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerFractureEffect)) = flag;
				}
			}

			public unsafe bool canTriggerPoisonEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerPoisonEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerPoisonEffect)) = flag;
				}
			}

			public unsafe bool canTriggerDefend
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerDefend);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerDefend)) = flag;
				}
			}

			public unsafe bool canTriggerInjuryEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerInjuryEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerInjuryEffect)) = flag;
				}
			}

			public unsafe bool canTriggerLevelOffsetEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerLevelOffsetEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerLevelOffsetEffect)) = flag;
				}
			}

			public unsafe bool hasKungfuPropEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasKungfuPropEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasKungfuPropEffect)) = flag;
				}
			}

			public unsafe bool canTriggerTecHealOffsetEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerTecHealOffsetEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerTecHealOffsetEffect)) = flag;
				}
			}

			public unsafe bool canTriggerTecPoisonOffsetEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerTecPoisonOffsetEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerTecPoisonOffsetEffect)) = flag;
				}
			}

			public unsafe bool canTriggerMoralOffsetEffect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerMoralOffsetEffect);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTriggerMoralOffsetEffect)) = flag;
				}
			}

			public unsafe bool isCirted
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCirted);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCirted)) = flag;
				}
			}

			public unsafe bool isParry
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isParry);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isParry)) = flag;
				}
			}

			public unsafe bool isSplashActor
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSplashActor);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSplashActor)) = flag;
				}
			}

			public unsafe float splashFactor
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splashFactor);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splashFactor)) = num;
				}
			}

			public unsafe float dualStrikeFactor
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dualStrikeFactor);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dualStrikeFactor)) = num;
				}
			}

			public unsafe float effectDamageOffset
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectDamageOffset);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectDamageOffset)) = num;
				}
			}

			static DamageCalculateProps()
			{
				Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, "DamageCalculateProps");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr);
				NativeFieldInfoPtr_powerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "powerModifier");
				NativeFieldInfoPtr_atkDefModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "atkDefModifier");
				NativeFieldInfoPtr_canTriggerBattleExpOffsetEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerBattleExpOffsetEffect");
				NativeFieldInfoPtr_canTriggerInternalTypeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerInternalTypeEffect");
				NativeFieldInfoPtr_canTriggerHoldingPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerHoldingPower");
				NativeFieldInfoPtr_canTriggerFractureEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerFractureEffect");
				NativeFieldInfoPtr_canTriggerPoisonEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerPoisonEffect");
				NativeFieldInfoPtr_canTriggerDefend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerDefend");
				NativeFieldInfoPtr_canTriggerInjuryEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerInjuryEffect");
				NativeFieldInfoPtr_canTriggerLevelOffsetEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerLevelOffsetEffect");
				NativeFieldInfoPtr_hasKungfuPropEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "hasKungfuPropEffect");
				NativeFieldInfoPtr_canTriggerTecHealOffsetEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerTecHealOffsetEffect");
				NativeFieldInfoPtr_canTriggerTecPoisonOffsetEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerTecPoisonOffsetEffect");
				NativeFieldInfoPtr_canTriggerMoralOffsetEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "canTriggerMoralOffsetEffect");
				NativeFieldInfoPtr_isCirted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "isCirted");
				NativeFieldInfoPtr_isParry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "isParry");
				NativeFieldInfoPtr_isSplashActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "isSplashActor");
				NativeFieldInfoPtr_splashFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "splashFactor");
				NativeFieldInfoPtr_dualStrikeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "dualStrikeFactor");
				NativeFieldInfoPtr_effectDamageOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, "effectDamageOffset");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr, 100689746);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 786113, RefRangeEnd = 786114, XrefRangeStart = 786112, XrefRangeEnd = 786113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DamageCalculateProps()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageCalculateProps>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public DamageCalculateProps(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class MinorDamageData : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_damageReason;

			private static readonly System.IntPtr NativeFieldInfoPtr_damage;

			private static readonly System.IntPtr NativeFieldInfoPtr_damageDealer;

			private static readonly System.IntPtr NativeFieldInfoPtr_damgeTarget;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

			public unsafe int damage
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damage);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damage)) = num;
				}
			}

			public unsafe BattleActor damageDealer
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageDealer);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageDealer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
				}
			}

			public unsafe BattleActor damgeTarget
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damgeTarget);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damgeTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
				}
			}

			static MinorDamageData()
			{
				Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, "MinorDamageData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr);
				NativeFieldInfoPtr_damageReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr, "damageReason");
				NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr, "damage");
				NativeFieldInfoPtr_damageDealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr, "damageDealer");
				NativeFieldInfoPtr_damgeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr, "damgeTarget");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr, 100689747);
			}

			[CallerCount(2961)]
			[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MinorDamageData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinorDamageData>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public MinorDamageData(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DefaultDamageEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SlgModeDamageCalculate_Public_Static_Single_BattleActor_BattleActor_KungfuInstance_DamageCalculateProps_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_StandardDamageCalculate_Public_Static_Single_BattleActor_BattleActor_KungfuInstance_DamageCalculateProps_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalMultiplyFactor_Public_Static_Single_Single_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMinorDamage_Public_Void_byref_List_1_MinorDamageData_ActorActionBattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DefaultDamageEffect_Logic()
		{
			Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "DefaultDamageEffect_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DefaultDamageEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, 100686386);
			NativeMethodInfoPtr_SlgModeDamageCalculate_Public_Static_Single_BattleActor_BattleActor_KungfuInstance_DamageCalculateProps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, 100686387);
			NativeMethodInfoPtr_StandardDamageCalculate_Public_Static_Single_BattleActor_BattleActor_KungfuInstance_DamageCalculateProps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, 100686388);
			NativeMethodInfoPtr_GetFinalMultiplyFactor_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, 100686389);
			NativeMethodInfoPtr_ApplyMinorDamage_Public_Void_byref_List_1_MinorDamageData_ActorActionBattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, 100686390);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr, 100686391);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786114, XrefRangeEnd = 787321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(DefaultDamageEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DefaultDamageEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 787396, RefRangeEnd = 787397, XrefRangeStart = 787321, XrefRangeEnd = 787396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SlgModeDamageCalculate(BattleActor dealerActor, BattleActor targetActor, KungfuInstance kungfuInstance, DamageCalculateProps damageCalculateProps)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageCalculateProps);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgModeDamageCalculate_Public_Static_Single_BattleActor_BattleActor_KungfuInstance_DamageCalculateProps_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 787746, RefRangeEnd = 787747, XrefRangeStart = 787397, XrefRangeEnd = 787746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float StandardDamageCalculate(BattleActor dealerActor, BattleActor targetActor, KungfuInstance kungfuInstance, DamageCalculateProps damageCalculateProps)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageCalculateProps);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StandardDamageCalculate_Public_Static_Single_BattleActor_BattleActor_KungfuInstance_DamageCalculateProps_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe static float GetFinalMultiplyFactor(float factor, float rawMultiply, float amountPreMultiply)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&factor);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rawMultiply;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amountPreMultiply;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalMultiplyFactor_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 787772, RefRangeEnd = 787774, XrefRangeStart = 787747, XrefRangeEnd = 787772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMinorDamage(ref List<MinorDamageData> minorDamageDatas, ActorActionBattleFieldEvent actorActionBattleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)minorDamageDatas);
			*ptr = (nint)(&intPtr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorActionBattleFieldEvent);
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMinorDamage_Public_Void_byref_List_1_MinorDamageData_ActorActionBattleFieldEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			minorDamageDatas = ((intPtr4 == (System.IntPtr)0) ? null : new List<MinorDamageData>(intPtr4));
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 787777, RefRangeEnd = 787778, XrefRangeStart = 787774, XrefRangeEnd = 787777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDamageEffect_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDamageEffect_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DefaultDamageEffect_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class InstaKillEffect_Logic : BaseKungfuAtomicEffect_Logic<InstaKillEffect>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_InstaKillEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static InstaKillEffect_Logic()
		{
			Il2CppClassPointerStore<InstaKillEffect_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "InstaKillEffect_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstaKillEffect_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_InstaKillEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstaKillEffect_Logic>.NativeClassPtr, 100686392);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstaKillEffect_Logic>.NativeClassPtr, 100686393);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787778, XrefRangeEnd = 787831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(InstaKillEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_InstaKillEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787831, XrefRangeEnd = 787834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstaKillEffect_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstaKillEffect_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InstaKillEffect_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DebugEffect_Logic : BaseKungfuAtomicEffect_Logic<DebugEffect>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DebugEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DebugEffect_Logic()
		{
			Il2CppClassPointerStore<DebugEffect_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "DebugEffect_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEffect_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DebugEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEffect_Logic>.NativeClassPtr, 100686394);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEffect_Logic>.NativeClassPtr, 100686395);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787834, XrefRangeEnd = 787839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(DebugEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DebugEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787839, XrefRangeEnd = 787842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugEffect_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEffect_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DebugEffect_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class RestEffect_Logic : BaseKungfuAtomicEffect_Logic<RestEffect>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_RestEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static RestEffect_Logic()
		{
			Il2CppClassPointerStore<RestEffect_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "RestEffect_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestEffect_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_RestEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestEffect_Logic>.NativeClassPtr, 100686396);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestEffect_Logic>.NativeClassPtr, 100686397);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787842, XrefRangeEnd = 787897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(RestEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_RestEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787897, XrefRangeEnd = 787900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RestEffect_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestEffect_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RestEffect_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DealerEffectCheckAfterAction_Logic : BaseKungfuAtomicEffect_Logic<DealerEffectCheckAfterAction>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DealerEffectCheckAfterAction_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DealerEffectCheckAfterAction_Logic()
		{
			Il2CppClassPointerStore<DealerEffectCheckAfterAction_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "DealerEffectCheckAfterAction_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerEffectCheckAfterAction_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DealerEffectCheckAfterAction_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerEffectCheckAfterAction_Logic>.NativeClassPtr, 100686398);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerEffectCheckAfterAction_Logic>.NativeClassPtr, 100686399);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787900, XrefRangeEnd = 787980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(DealerEffectCheckAfterAction effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DealerEffectCheckAfterAction_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787980, XrefRangeEnd = 787983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerEffectCheckAfterAction_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerEffectCheckAfterAction_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DealerEffectCheckAfterAction_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DamageNeutralActor_Logic : BaseKungfuAtomicEffect_Logic<DamageNeutralActor>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DamageNeutralActor_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DamageNeutralActor_Logic()
		{
			Il2CppClassPointerStore<DamageNeutralActor_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "DamageNeutralActor_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageNeutralActor_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DamageNeutralActor_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageNeutralActor_Logic>.NativeClassPtr, 100686400);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageNeutralActor_Logic>.NativeClassPtr, 100686401);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787983, XrefRangeEnd = 788123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(DamageNeutralActor effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DamageNeutralActor_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788123, XrefRangeEnd = 788126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DamageNeutralActor_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageNeutralActor_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DamageNeutralActor_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AddBuffOnSelf_Logic : BaseKungfuAtomicEffect_Logic<AddBuffOnSelf>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_AddBuffOnSelf_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static AddBuffOnSelf_Logic()
		{
			Il2CppClassPointerStore<AddBuffOnSelf_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "AddBuffOnSelf_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddBuffOnSelf_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_AddBuffOnSelf_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBuffOnSelf_Logic>.NativeClassPtr, 100686402);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBuffOnSelf_Logic>.NativeClassPtr, 100686403);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788126, XrefRangeEnd = 788191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(AddBuffOnSelf effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_AddBuffOnSelf_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788191, XrefRangeEnd = 788194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddBuffOnSelf_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddBuffOnSelf_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AddBuffOnSelf_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BuffToTargetEft_Logic : BaseKungfuAtomicEffect_Logic<BuffToTargetEft>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_BuffToTargetEft_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static BuffToTargetEft_Logic()
		{
			Il2CppClassPointerStore<BuffToTargetEft_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "BuffToTargetEft_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffToTargetEft_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_BuffToTargetEft_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffToTargetEft_Logic>.NativeClassPtr, 100686404);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffToTargetEft_Logic>.NativeClassPtr, 100686405);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788194, XrefRangeEnd = 788260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(BuffToTargetEft effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_BuffToTargetEft_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788260, XrefRangeEnd = 788263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffToTargetEft_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffToTargetEft_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BuffToTargetEft_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SklToTargetEft_Logic : BaseKungfuAtomicEffect_Logic<SklToTargetEft>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_SklToTargetEft_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectValue_Public_Int32_SklToTargetEft_BattleActor_BattleActorPropTypes_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static SklToTargetEft_Logic()
		{
			Il2CppClassPointerStore<SklToTargetEft_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "SklToTargetEft_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SklToTargetEft_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_SklToTargetEft_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SklToTargetEft_Logic>.NativeClassPtr, 100686406);
			NativeMethodInfoPtr_GetEffectValue_Public_Int32_SklToTargetEft_BattleActor_BattleActorPropTypes_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SklToTargetEft_Logic>.NativeClassPtr, 100686407);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SklToTargetEft_Logic>.NativeClassPtr, 100686408);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788263, XrefRangeEnd = 788389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(SklToTargetEft effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_SklToTargetEft_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 788408, RefRangeEnd = 788417, XrefRangeStart = 788389, XrefRangeEnd = 788408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEffectValue(SklToTargetEft effect, BattleActor dealerActor, BattleActor.BattleActorPropTypes battleActorPropTypes, Il2CppSystem.Decimal multipy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(BattleActor.BattleActorPropTypes**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &battleActorPropTypes;
			*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &multipy;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEffectValue_Public_Int32_SklToTargetEft_BattleActor_BattleActorPropTypes_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 788420, RefRangeEnd = 788421, XrefRangeStart = 788417, XrefRangeEnd = 788420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SklToTargetEft_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SklToTargetEft_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SklToTargetEft_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class UseItem_Logic : BaseKungfuAtomicEffect_Logic<UseItem>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_UseItem_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static UseItem_Logic()
		{
			Il2CppClassPointerStore<UseItem_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "UseItem_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseItem_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_UseItem_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseItem_Logic>.NativeClassPtr, 100686409);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseItem_Logic>.NativeClassPtr, 100686410);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788421, XrefRangeEnd = 788472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(UseItem effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_UseItem_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788472, XrefRangeEnd = 788475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseItem_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseItem_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public UseItem_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ChangeInternalKungfu_Logic : BaseKungfuAtomicEffect_Logic<ChangeInternalKungfu>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_ChangeInternalKungfu_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static ChangeInternalKungfu_Logic()
		{
			Il2CppClassPointerStore<ChangeInternalKungfu_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "ChangeInternalKungfu_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeInternalKungfu_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_ChangeInternalKungfu_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeInternalKungfu_Logic>.NativeClassPtr, 100686411);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeInternalKungfu_Logic>.NativeClassPtr, 100686412);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788475, XrefRangeEnd = 788504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(ChangeInternalKungfu effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_ChangeInternalKungfu_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788504, XrefRangeEnd = 788507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangeInternalKungfu_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeInternalKungfu_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ChangeInternalKungfu_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TeleportCaster_Logic : BaseKungfuAtomicEffect_Logic<TeleportCaster>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_TeleportCaster_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static TeleportCaster_Logic()
		{
			Il2CppClassPointerStore<TeleportCaster_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "TeleportCaster_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportCaster_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_TeleportCaster_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportCaster_Logic>.NativeClassPtr, 100686413);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportCaster_Logic>.NativeClassPtr, 100686414);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788507, XrefRangeEnd = 788531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(TeleportCaster effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_TeleportCaster_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788531, XrefRangeEnd = 788534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TeleportCaster_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportCaster_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TeleportCaster_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class HpPercentageDamage_Logic : BaseKungfuAtomicEffect_Logic<HpPercentageDamage>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_HpPercentageDamage_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static HpPercentageDamage_Logic()
		{
			Il2CppClassPointerStore<HpPercentageDamage_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "HpPercentageDamage_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HpPercentageDamage_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_HpPercentageDamage_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HpPercentageDamage_Logic>.NativeClassPtr, 100686415);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HpPercentageDamage_Logic>.NativeClassPtr, 100686416);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788534, XrefRangeEnd = 788579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(HpPercentageDamage effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_HpPercentageDamage_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788579, XrefRangeEnd = 788582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HpPercentageDamage_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HpPercentageDamage_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HpPercentageDamage_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DrawBack_Logic : BaseKungfuAtomicEffect_Logic<DrawBack>
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct DisPos
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_last;

			private static readonly System.IntPtr NativeFieldInfoPtr_now;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0;

			[FieldOffset(0)]
			public Vector3Int last;

			[FieldOffset(12)]
			public Vector3Int now;

			static DisPos()
			{
				Il2CppClassPointerStore<DisPos>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr, "DisPos");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisPos>.NativeClassPtr);
				NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisPos>.NativeClassPtr, "last");
				NativeFieldInfoPtr_now = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisPos>.NativeClassPtr, "now");
				NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisPos>.NativeClassPtr, 100689748);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 164699, RefRangeEnd = 164701, XrefRangeStart = 164699, XrefRangeEnd = 164701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisPos(Vector3Int a, Vector3Int b)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&a);
				*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisPos>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[ObfuscatedName("WuLin.KungfuAtomicEffectExt+DrawBack_Logic+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_dealerActor;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__InvokeEffectAfterExclude_b__0_Internal_Int32_BattleActor_BattleActor_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__InvokeEffectAfterExclude_b__1_Internal_Int32_BattleActor_BattleActor_0;

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

			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr);
				NativeFieldInfoPtr_dealerActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "dealerActor");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100689749);
				NativeMethodInfoPtr__InvokeEffectAfterExclude_b__0_Internal_Int32_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100689750);
				NativeMethodInfoPtr__InvokeEffectAfterExclude_b__1_Internal_Int32_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100689751);
			}

			[CallerCount(2961)]
			[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788582, XrefRangeEnd = 788588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InvokeEffectAfterExclude_b__0(BattleActor x, BattleActor y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InvokeEffectAfterExclude_b__0_Internal_Int32_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788588, XrefRangeEnd = 788594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InvokeEffectAfterExclude_b__1(BattleActor x, BattleActor y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InvokeEffectAfterExclude_b__1_Internal_Int32_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass1_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_RolePosList;

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DrawBack_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsBlack_Private_Boolean_Vector3Int_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Vector3Int> RolePosList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RolePosList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RolePosList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DrawBack_Logic()
		{
			Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "DrawBack_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr);
			NativeFieldInfoPtr_RolePosList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr, "RolePosList");
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DrawBack_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr, 100686417);
			NativeMethodInfoPtr_IsBlack_Private_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr, 100686418);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr, 100686419);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788594, XrefRangeEnd = 788783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(DrawBack effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_DrawBack_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 788793, RefRangeEnd = 788795, XrefRangeStart = 788783, XrefRangeEnd = 788793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBlack(Vector3Int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&pos);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlack_Private_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788795, XrefRangeEnd = 788798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawBack_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawBack_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DrawBack_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SummonHelper_Logic : BaseKungfuAtomicEffect_Logic<SummonHelper>
	{
		[ObfuscatedName("WuLin.KungfuAtomicEffectExt+SummonHelper_Logic+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_dic;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__InvokeEffectAfterExclude_b__0_Internal_Int32_Vector3Int_Vector3Int_0;

			public unsafe Dictionary<Vector3Int, float> dic
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dic);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, float>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
				}
			}

			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass0_0>.NativeClassPtr);
				NativeFieldInfoPtr_dic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass0_0>.NativeClassPtr, "dic");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass0_0>.NativeClassPtr, 100689752);
				NativeMethodInfoPtr__InvokeEffectAfterExclude_b__0_Internal_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass0_0>.NativeClassPtr, 100689753);
			}

			[CallerCount(2961)]
			[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass0_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788798, XrefRangeEnd = 788804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InvokeEffectAfterExclude_b__0(Vector3Int x, Vector3Int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&x);
				*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InvokeEffectAfterExclude_b__0_Internal_Int32_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass0_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_SummonHelper_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsCanSummon_Private_Dictionary_2_Vector3Int_Single_Dictionary_2_Vector3Int_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Helper_Private_Void_Vector3Int_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Private_Dictionary_2_Vector3Int_Single_Dictionary_2_Vector3Int_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Private_Void_Dictionary_2_Vector3Int_Single_List_1_Single_List_1_Vector3Int_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static SummonHelper_Logic()
		{
			Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "SummonHelper_Logic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr);
			NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_SummonHelper_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, 100686420);
			NativeMethodInfoPtr_IsCanSummon_Private_Dictionary_2_Vector3Int_Single_Dictionary_2_Vector3Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, 100686421);
			NativeMethodInfoPtr_Helper_Private_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, 100686422);
			NativeMethodInfoPtr_Sort_Private_Dictionary_2_Vector3Int_Single_Dictionary_2_Vector3Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, 100686423);
			NativeMethodInfoPtr_Sort_Private_Void_Dictionary_2_Vector3Int_Single_List_1_Single_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, 100686424);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr, 100686425);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788804, XrefRangeEnd = 789008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeEffectAfterExclude(SummonHelper effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeEffectAfterExclude_Public_Virtual_Void_SummonHelper_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 789043, RefRangeEnd = 789044, XrefRangeStart = 789008, XrefRangeEnd = 789043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<Vector3Int, float> IsCanSummon(Dictionary<Vector3Int, float> dic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dic);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCanSummon_Private_Dictionary_2_Vector3Int_Single_Dictionary_2_Vector3Int_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, float>>(intPtr) : null;
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Helper(Vector3Int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&pos);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Helper_Private_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789044, XrefRangeEnd = 789069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<Vector3Int, float> Sort(Dictionary<Vector3Int, float> dic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dic);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sort_Private_Dictionary_2_Vector3Int_Single_Dictionary_2_Vector3Int_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, float>>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 789098, RefRangeEnd = 789101, XrefRangeStart = 789069, XrefRangeEnd = 789098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Dictionary<Vector3Int, float> dic, List<float> list_f, List<Vector3Int> list_v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dic);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list_f);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list_v);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sort_Private_Void_Dictionary_2_Vector3Int_Single_List_1_Single_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789101, XrefRangeEnd = 789104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SummonHelper_Logic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SummonHelper_Logic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SummonHelper_Logic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_atomicEffectActionDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeEffect_Public_Static_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0;

	public unsafe static Dictionary<Il2CppSystem.Type, IAtomicEffectLogic> atomicEffectActionDict
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_atomicEffectActionDict, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, IAtomicEffectLogic>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_atomicEffectActionDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static KungfuAtomicEffectExt()
	{
		Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "KungfuAtomicEffectExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr);
		NativeFieldInfoPtr_atomicEffectActionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, "atomicEffectActionDict");
		NativeMethodInfoPtr_InvokeEffect_Public_Static_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuAtomicEffectExt>.NativeClassPtr, 100671589);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 789134, RefRangeEnd = 789135, XrefRangeStart = 789104, XrefRangeEnd = 789134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEffect(this BaseKungfuAtomicEffect effect, BattleActor dealerActor, Dictionary<BattleActor, float> targetActors, ref BattleFieldEvent battleFieldEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActors);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldEvent);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeEffect_Public_Static_Void_BaseKungfuAtomicEffect_BattleActor_Dictionary_2_BattleActor_Single_byref_BattleFieldEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		battleFieldEvent = ((intPtr4 == (System.IntPtr)0) ? null : new BattleFieldEvent(intPtr4));
	}

	public KungfuAtomicEffectExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
