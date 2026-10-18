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
using Il2CppSystem.Reflection;
using UnityEngine;

namespace WuLin;

public class Dlc1FactionInstance : Il2CppSystem.Object
{
	public enum SlgActionResearchNewKungfuCheckResearchResult
	{
		Ok = 0,
		DataError = 10,
		DataNotMatched = 20,
		CharacterPropNotMatched = 30
	}

	[System.Serializable]
	[ObfuscatedName("WuLin.Dlc1FactionInstance+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__109_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__196_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__196_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__213_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__213_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__240_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__240_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WakeupFromSleeping_b__109_0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgActionPatrolGetProvinces_b__196_0_Internal_Int32_Dlc1InvasionBattleData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgActionPatrolGetProvinces_b__196_1_Internal_Int32_Dlc1PatrolData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgActionSupplyGetProvinces_b__213_0_Internal_Int32_Dlc1InvasionBattleData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgActionSupplyGetProvinces_b__213_1_Internal_Int32_Dlc1SupplyData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetTruceResult_b__240_0_Internal_Boolean_KungfuData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetTruceResult_b__240_1_Internal_Boolean_KungfuData_0;

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

		public unsafe static Il2CppSystem.Action __9__109_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__109_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__109_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Func<Dlc1InvasionBattleData, int> __9__196_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__196_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Dlc1InvasionBattleData, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__196_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<Dlc1PatrolData, int> __9__196_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__196_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Dlc1PatrolData, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__196_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<Dlc1InvasionBattleData, int> __9__213_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__213_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Dlc1InvasionBattleData, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__213_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<Dlc1SupplyData, int> __9__213_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__213_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Dlc1SupplyData, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__213_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<KungfuData, bool> __9__240_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__240_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KungfuData, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__240_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<KungfuData, bool> __9__240_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__240_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KungfuData, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__240_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__109_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__109_0");
			NativeFieldInfoPtr___9__196_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__196_0");
			NativeFieldInfoPtr___9__196_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__196_1");
			NativeFieldInfoPtr___9__213_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__213_0");
			NativeFieldInfoPtr___9__213_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__213_1");
			NativeFieldInfoPtr___9__240_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__240_0");
			NativeFieldInfoPtr___9__240_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__240_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688574);
			NativeMethodInfoPtr__WakeupFromSleeping_b__109_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688575);
			NativeMethodInfoPtr__SlgActionPatrolGetProvinces_b__196_0_Internal_Int32_Dlc1InvasionBattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688576);
			NativeMethodInfoPtr__SlgActionPatrolGetProvinces_b__196_1_Internal_Int32_Dlc1PatrolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688577);
			NativeMethodInfoPtr__SlgActionSupplyGetProvinces_b__213_0_Internal_Int32_Dlc1InvasionBattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688578);
			NativeMethodInfoPtr__SlgActionSupplyGetProvinces_b__213_1_Internal_Int32_Dlc1SupplyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688579);
			NativeMethodInfoPtr__GetTruceResult_b__240_0_Internal_Boolean_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688580);
			NativeMethodInfoPtr__GetTruceResult_b__240_1_Internal_Boolean_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688581);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996353, XrefRangeEnd = 996361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _WakeupFromSleeping_b__109_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WakeupFromSleeping_b__109_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int _SlgActionPatrolGetProvinces_b__196_0(Dlc1InvasionBattleData battle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battle);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgActionPatrolGetProvinces_b__196_0_Internal_Int32_Dlc1InvasionBattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _SlgActionPatrolGetProvinces_b__196_1(Dlc1PatrolData patrol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)patrol);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgActionPatrolGetProvinces_b__196_1_Internal_Int32_Dlc1PatrolData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _SlgActionSupplyGetProvinces_b__213_0(Dlc1InvasionBattleData battle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battle);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgActionSupplyGetProvinces_b__213_0_Internal_Int32_Dlc1InvasionBattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _SlgActionSupplyGetProvinces_b__213_1(Dlc1SupplyData supply)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)supply);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgActionSupplyGetProvinces_b__213_1_Internal_Int32_Dlc1SupplyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GetTruceResult_b__240_0(KungfuData kungfu)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfu);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetTruceResult_b__240_0_Internal_Boolean_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GetTruceResult_b__240_1(KungfuData kungfu)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfu);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetTruceResult_b__240_1_Internal_Boolean_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.Dlc1FactionInstance+<>c__DisplayClass112_0")]
	public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_characterId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveMember_b__0_Internal_Void_Dlc1InvasionBattleData_0;

		public unsafe int characterId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterId)) = num;
			}
		}

		static __c__DisplayClass112_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<>c__DisplayClass112_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr);
			NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "characterId");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100688582);
			NativeMethodInfoPtr__RemoveMember_b__0_Internal_Void_Dlc1InvasionBattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100688583);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass112_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996361, XrefRangeEnd = 996369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RemoveMember_b__0(Dlc1InvasionBattleData battle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battle);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveMember_b__0_Internal_Void_Dlc1InvasionBattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass112_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetDelayAction_Public_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetDelayAction_Public_List_1_T_0, Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr__avalilableTechs_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__avalilableTechReqs_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__avalilableTechGraphPos_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideName;

	private static readonly System.IntPtr NativeFieldInfoPtr_capital;

	private static readonly System.IntPtr NativeFieldInfoPtr__leader_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_provinces;

	private static readonly System.IntPtr NativeFieldInfoPtr__storyLostProvinces_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_members;

	private static readonly System.IntPtr NativeFieldInfoPtr_relations;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionStatusStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_diplomacyDataForCurrentTurn;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAlive;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSleeping;

	private static readonly System.IntPtr NativeFieldInfoPtr_eliminatedBy;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffLib;

	private static readonly System.IntPtr NativeFieldInfoPtr_additionalRecruitableMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_membersJoinedThisTurn;

	private static readonly System.IntPtr NativeFieldInfoPtr__unlockedTech_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__additionUnlockedKungfu_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__additionBuffForFaction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__additionBuffForMembers_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__unlockedKungfu_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__allocatableBuffs_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__allocatableBuffsLeft_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__currencyEachTurn_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_backPack;

	private static readonly System.IntPtr NativeFieldInfoPtr_dlc1DelayActions;

	private static readonly System.IntPtr NativeFieldInfoPtr__jobSeekers_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigMemberUsedCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_traderRefreshOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradingItemPrechased;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedTrader;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedTradeInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_humanRes;

	private static readonly System.IntPtr NativeFieldInfoPtr__overrideTech_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_slgRecruitMultipier;

	private static readonly System.IntPtr NativeFieldInfoPtr_slgRecruitUniqueReq;

	private static readonly System.IntPtr NativeFieldInfoPtr_newKungfuData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_avalilableTechs_Public_get_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_avalilableTechs_Private_set_Void_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_avalilableTechReqs_Public_get_Dictionary_2_Int32_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_avalilableTechReqs_Private_set_Void_Dictionary_2_Int32_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_avalilableTechGraphPos_Public_get_Dictionary_2_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_avalilableTechGraphPos_Private_set_Void_Dictionary_2_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leader_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leader_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_storyLostProvinces_Public_get_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_storyLostProvinces_Private_set_Void_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unlockedTech_Public_get_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_unlockedTech_Private_set_Void_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionUnlockedKungfu_Public_get_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionUnlockedKungfu_Private_set_Void_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionBuffForFaction_Public_get_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionBuffForFaction_Private_set_Void_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionBuffForMembers_Public_get_Dictionary_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionBuffForMembers_Private_set_Void_Dictionary_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unlockedKungfu_Public_get_HashSet_1_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_unlockedKungfu_Private_set_Void_HashSet_1_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allocatableBuffs_Public_get_Dictionary_2_BuffData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allocatableBuffs_Private_set_Void_Dictionary_2_BuffData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allocatableBuffsLeft_Public_get_Dictionary_2_BuffData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allocatableBuffsLeft_Private_set_Void_Dictionary_2_BuffData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currencyEachTurn_Public_get_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currencyEachTurn_Private_set_Void_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BackPack_Public_get_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_jobSeekers_Public_get_Dictionary_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_jobSeekers_Private_set_Void_Dictionary_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideTech_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideTech_Private_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Templete_Public_get_DLCFaction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxMemberCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalMemberLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Leader_Public_get_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCFaction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLoaded_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCurrencyChange_Public_Void_CurrencyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnItemChange_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDelayAction_Public_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddProvince_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStoryLostProvinces_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStoryLostProvinces_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStoryLostProvinces_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCapital_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveProvince_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WakeupFromSleeping_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNextConfigMember_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMember_Public_GameCharacterInstance_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMember_Public_GameCharacterInstance_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckProvinceConection_Public_List_1_Dlc1ProvinceInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInvalidDelayAction_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasProvince_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRelation_Public_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelation_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRelation_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRelationInRange_Public_Boolean_Int32_SlgRelationRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstNpcByHpEpLess_Public_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstNpcByActionNone_Public_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNpcListByActionNone_Public_List_1_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDelayAction_Public_Void_Dlc1DelayAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDelayAction_Public_Void_Dlc1DelayAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickForStable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickForGuards_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnIncome_Public_GameItemPack_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnWage_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeiborProvinceIds_Public_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeiborProvinces_Public_HashSet_1_Dlc1ProvinceInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeiborFactionIds_Public_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeiborFactions_Public_HashSet_1_Dlc1FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickForAllMember_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickForAllMemberAfterDecision_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffValue_Public_Decimal_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllFactionBonus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockKungfu_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockKungfu_Public_Void_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKungfu_Public_Void_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuffForMember_Public_Void_BuffData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAllUnlockedTechAfterLoaded_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAdditionBonusAfterLoad_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOverrideTechGraph_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTechGraph_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentResearchableTeches_Public_List_1_DLCTech_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTech_Public_Boolean_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostProcessingTechAdvancing_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaculateAllocatableBuffsLeft_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTraderAvailable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Void_ItemData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_BuffData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ItemData_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickupPack_Public_Void_GameItemPack_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionDiscount_Public_Decimal_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StrToKeyWithValues_Public_Static_Il2CppReferenceArray_1_KeyWithValues_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyWithValuesToCurrenciesDict_Public_Dictionary_2_CurrencyType_Int64_Il2CppReferenceArray_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrency_Public_Boolean_CurrencyType_Int64_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrency_Public_Boolean_KeyWithValues_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrency_Public_Boolean_String_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Dictionary_2_CurrencyType_Int64_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrencies_Public_Boolean_String_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostCurrency_Public_Void_CurrencyType_Int64_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostCurrency_Public_Void_KeyWithValues_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostCurrency_Public_Void_String_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostCurrencies_Public_Void_Dictionary_2_CurrencyType_Int64_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostCurrencies_Public_Void_Il2CppReferenceArray_1_KeyWithValues_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CostCurrencies_Public_Void_String_SlgActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionStatus_Public_Void_Int32_SlgFactionStatus_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFactionStatus_Public_Void_Int32_SlgFactionStatus_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentStatusDuration_Public_Int32_Int32_SlgFactionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFactionStatus_Public_SlgFactionStatus_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFactionStatus_Public_Boolean_Int32_SlgFactionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllEnemyOfAllie_Public_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllFactionByStatus_Public_HashSet_1_Int32_SlgFactionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedTradingInfomation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckRestockAtTurnStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllTraders_Public_List_1_SlgTraderInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradingItems_Public_List_1_SlgTradeItemInstance_DLCTrader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPurchaseCountMax_Public_Int32_SlgTradeItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldPurchaseItem_Public_Boolean_SlgTradeItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PurchaseItem_Public_Boolean_SlgTradeItemInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlgActionEffect_Public_Decimal_SlgActionType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionHealGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionHealGetCureChange_Public_Vector2Int_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionHealCmd_Public_Boolean_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionInvasionGetCost_Public_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionInvadedGetAllProvinces_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionInvasionGetAllProvinceAvalible_Public_HashSet_1_Dlc1ProvinceInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionInvasionIsAvalible_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionInvasionCmd_Public_Dlc1InvasionBattleData_Int32_Int32_List_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionInvasionSetDefense_Public_Void_Dlc1InvasionBattleData_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionPatrolGetProvinces_Public_List_1_Dlc1ProvinceInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionPatrolGetProvincesByRelationOffensive_Public_List_1_Dlc1ProvinceInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionPatrolGetCost_Public_Dictionary_2_CurrencyType_Int64_Dlc1ProvinceInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionPatrolCmd_Public_Dlc1PatrolData_Dlc1ProvinceInstance_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionPatrolInvoke_Public_Void_Dlc1PatrolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionStudyGetAllKungfuCouldLearnState_Public_Dictionary_2_KungfuData_EquipingCheckResult_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionStudyGetAllKungfuDataList_Public_List_1_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionStudyCouldLearnKungfu_Public_EquipingCheckResult_GameCharacterInstance_KungfuData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionStudyCmd_Public_Boolean_GameCharacterInstance_KungfuData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTrainKungfuGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTrainKungfuExpPreview_Public_Int32_GameCharacterInstance_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTrainKungfuCmd_Public_Void_GameCharacterInstance_KungfuInstance_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchIsDone_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchGetCost_Public_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchTributePreview_Public_Int32_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchCmd_Public_Boolean_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionSupplyGetProvincesByRelationOffensive_Public_List_1_Dlc1ProvinceInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionSupplyGetProvinces_Public_List_1_Dlc1ProvinceInstance_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionSupplyGetCost_Public_Dictionary_2_CurrencyType_Int64_Dlc1ProvinceInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionSupplyCmd_Public_Boolean_Dlc1ProvinceInstance_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionSupplyInvoke_Public_Void_Dlc1SupplyData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTraitCouldAlloc_Public_Boolean_GameCharacterInstance_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTraitGetAllTraitDataList_Public_List_1_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTraitAlloc_Public_Boolean_GameCharacterInstance_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionTraitRemove_Public_Boolean_GameCharacterInstance_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitTotalJobSeekerCountForNextResolve_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitResolveJobSeekersForThisTurn_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitTickAllJobSeeker_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitRemoveJobSeeker_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitCreateJobSeeker_Public_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRecruitUsingExtendData_Public_GameCharacterInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_DLCFactionJob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitGetItemCost_Public_Dictionary_2_ItemData_Int32_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitIsReachLimitThisTurn_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitAddMemberFromJobSeeker_Public_Boolean_GameCharacterInstance_DLCFactionJob_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitGetAdditionJobSeekerCost_Public_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionRecruitAddAdditionMember_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacySetCount_Public_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyGetCount_Public_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDiplomacyAction_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyTruceGetCost_Public_Dictionary_2_CurrencyType_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyTruceGetFinished_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTruceResult_Public_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyTruceWithOtherFaction_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyImproveRelationGetCost_Public_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyImproveRelationGetFinished_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyImproveRelationUsingCurrency_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyImproveRelationUsingItem_Public_Void_Int32_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyTradingWithOtherFaction_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyTradingGetIncomeFromOneFaction_Public_Dictionary_2_CurrencyType_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyTradingGetAllIncome_Public_Dictionary_2_CurrencyType_Int64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickForRelation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyAllieGetFinished_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllieResult_Public_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgDiplomacyAllieWithOtherFaction_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuIsTempleteDynnamic_Public_Boolean_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuGetCost_Public_Dictionary_2_CurrencyType_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuCheckResearch_Public_SlgActionResearchNewKungfuCheckResearchResult_GameCharacterInstance_KungfuData_KungfuData_byref_Dictionary_2_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuCmd_Public_KungfuData_GameCharacterInstance_KungfuData_KungfuData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuRenameAndApplyLast_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuDiscardLast_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionResearchNewKungfuDiscard_Private_Void_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionHumanResAddToMember_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveHumanRes_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHumanRes_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionHumanResRemoveFromMember_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActionHumanResNew_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffAllMembersHp_Public_Void_Decimal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffAllMembersEp_Public_Void_Decimal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffAllMembersMood_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuffAllProvincesStable_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__97_0_Private_Void_CurrencyType_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__97_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnLoaded_b__98_0_Private_Void_CurrencyType_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnLoaded_b__98_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetTruceResult_b__240_2_Private_Boolean_Int32_0;

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe HashSet<int> _avalilableTechs_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avalilableTechs_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avalilableTechs_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<int, HashSet<int>> _avalilableTechReqs_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avalilableTechReqs_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, HashSet<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avalilableTechReqs_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Vector2> _avalilableTechGraphPos_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avalilableTechGraphPos_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__avalilableTechGraphPos_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe string overrideName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int capital
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capital);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capital)) = num;
		}
	}

	public unsafe int _leader_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leader_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leader_k__BackingField)) = num;
		}
	}

	public unsafe List<int> provinces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_provinces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_provinces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> _storyLostProvinces_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storyLostProvinces_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storyLostProvinces_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> members
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_members);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_members)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, int> relations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, SlgFactionStatus> factionStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionStatus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, SlgFactionStatus>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, int> factionStatusStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionStatusStartTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionStatusStartTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, int> diplomacyDataForCurrentTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diplomacyDataForCurrentTurn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diplomacyDataForCurrentTurn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool isAlive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlive)) = flag;
		}
	}

	public unsafe bool isSleeping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSleeping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSleeping)) = flag;
		}
	}

	public unsafe int eliminatedBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eliminatedBy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eliminatedBy)) = num;
		}
	}

	public unsafe BuffLib buffLib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffLib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffLib)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffLib));
		}
	}

	public unsafe int additionalRecruitableMember
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalRecruitableMember);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalRecruitableMember)) = num;
		}
	}

	public unsafe int membersJoinedThisTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_membersJoinedThisTurn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_membersJoinedThisTurn)) = num;
		}
	}

	public unsafe HashSet<int> _unlockedTech_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unlockedTech_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unlockedTech_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> _additionUnlockedKungfu_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionUnlockedKungfu_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionUnlockedKungfu_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> _additionBuffForFaction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionBuffForFaction_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionBuffForFaction_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<int, int> _additionBuffForMembers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionBuffForMembers_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionBuffForMembers_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<KungfuData> _unlockedKungfu_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unlockedKungfu_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<KungfuData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unlockedKungfu_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<BuffData, int> _allocatableBuffs_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allocatableBuffs_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BuffData, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allocatableBuffs_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<BuffData, int> _allocatableBuffsLeft_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allocatableBuffsLeft_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BuffData, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allocatableBuffsLeft_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CurrencyType, long> _currencyEachTurn_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currencyEachTurn_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currencyEachTurn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
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

	public unsafe List<Dlc1DelayAction> dlc1DelayActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc1DelayActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1DelayAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc1DelayActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, int> _jobSeekers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__jobSeekers_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__jobSeekers_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int ConfigMemberUsedCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigMemberUsedCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigMemberUsedCount)) = num;
		}
	}

	public unsafe Dictionary<int, int> traderRefreshOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderRefreshOffset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traderRefreshOffset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, int> tradingItemPrechased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradingItemPrechased);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradingItemPrechased)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<SlgTraderInstance> cachedTrader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTrader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SlgTraderInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTrader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, List<SlgTradeItemInstance>> cachedTradeInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTradeInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<SlgTradeItemInstance>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTradeInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<int> humanRes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanRes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanRes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string _overrideTech_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overrideTech_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overrideTech_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> slgRecruitMultipier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgRecruitMultipier);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgRecruitMultipier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Dictionary<int, int> slgRecruitUniqueReq
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgRecruitUniqueReq);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgRecruitUniqueReq)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe KungfuData newKungfuData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData));
		}
	}

	public unsafe HashSet<int> avalilableTechs
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_avalilableTechs_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_avalilableTechs_Private_set_Void_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<int, HashSet<int>> avalilableTechReqs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_avalilableTechReqs_Public_get_Dictionary_2_Int32_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, HashSet<int>>>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31140, RefRangeEnd = 31143, XrefRangeStart = 31140, XrefRangeEnd = 31143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_avalilableTechReqs_Private_set_Void_Dictionary_2_Int32_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<int, Vector2> avalilableTechGraphPos
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18874, RefRangeEnd = 18877, XrefRangeStart = 18874, XrefRangeEnd = 18877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_avalilableTechGraphPos_Public_get_Dictionary_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2>>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40031, RefRangeEnd = 40034, XrefRangeStart = 40031, XrefRangeEnd = 40034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_avalilableTechGraphPos_Private_set_Void_Dictionary_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int leader
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leader_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 54943, RefRangeEnd = 54950, XrefRangeStart = 54943, XrefRangeEnd = 54950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leader_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<int> storyLostProvinces
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28448, RefRangeEnd = 28449, XrefRangeStart = 28448, XrefRangeEnd = 28449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_storyLostProvinces_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_storyLostProvinces_Private_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<int> unlockedTech
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 56998, RefRangeEnd = 57011, XrefRangeStart = 56998, XrefRangeEnd = 57011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unlockedTech_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_unlockedTech_Private_set_Void_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<int> additionUnlockedKungfu
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionUnlockedKungfu_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionUnlockedKungfu_Private_set_Void_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<int> additionBuffForFaction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionBuffForFaction_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionBuffForFaction_Private_set_Void_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<int, int> additionBuffForMembers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionBuffForMembers_Public_get_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionBuffForMembers_Private_set_Void_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HashSet<KungfuData> unlockedKungfu
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unlockedKungfu_Public_get_HashSet_1_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<KungfuData>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_unlockedKungfu_Private_set_Void_HashSet_1_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<BuffData, int> allocatableBuffs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allocatableBuffs_Public_get_Dictionary_2_BuffData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BuffData, int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allocatableBuffs_Private_set_Void_Dictionary_2_BuffData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<BuffData, int> allocatableBuffsLeft
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allocatableBuffsLeft_Public_get_Dictionary_2_BuffData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BuffData, int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allocatableBuffsLeft_Private_set_Void_Dictionary_2_BuffData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<CurrencyType, long> currencyEachTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currencyEachTurn_Public_get_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currencyEachTurn_Private_set_Void_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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

	public unsafe Dictionary<int, int> jobSeekers
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34427, RefRangeEnd = 34428, XrefRangeStart = 34427, XrefRangeEnd = 34428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_jobSeekers_Public_get_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_jobSeekers_Private_set_Void_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string overrideTech
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overrideTech_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideTech_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe DLCFaction Templete
	{
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 996377, RefRangeEnd = 996421, XrefRangeStart = 996369, XrefRangeEnd = 996377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Templete_Public_get_DLCFaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCFaction>(intPtr) : null;
		}
	}

	public unsafe string Name
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 996423, RefRangeEnd = 996463, XrefRangeStart = 996421, XrefRangeEnd = 996423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int MaxMemberCount
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 996498, RefRangeEnd = 996503, XrefRangeStart = 996463, XrefRangeEnd = 996498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxMemberCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int TotalMemberLevel
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996524, RefRangeEnd = 996526, XrefRangeStart = 996503, XrefRangeEnd = 996524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalMemberLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe GameCharacterInstance Leader
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 996555, RefRangeEnd = 996563, XrefRangeStart = 996526, XrefRangeEnd = 996555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Leader_Public_get_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
	}

	static Dlc1FactionInstance()
	{
		Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "Dlc1FactionInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "id");
		NativeFieldInfoPtr__avalilableTechs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<avalilableTechs>k__BackingField");
		NativeFieldInfoPtr__avalilableTechReqs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<avalilableTechReqs>k__BackingField");
		NativeFieldInfoPtr__avalilableTechGraphPos_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<avalilableTechGraphPos>k__BackingField");
		NativeFieldInfoPtr_overrideName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "overrideName");
		NativeFieldInfoPtr_capital = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "capital");
		NativeFieldInfoPtr__leader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<leader>k__BackingField");
		NativeFieldInfoPtr_provinces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "provinces");
		NativeFieldInfoPtr__storyLostProvinces_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<storyLostProvinces>k__BackingField");
		NativeFieldInfoPtr_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "members");
		NativeFieldInfoPtr_relations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "relations");
		NativeFieldInfoPtr_factionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "factionStatus");
		NativeFieldInfoPtr_factionStatusStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "factionStatusStartTime");
		NativeFieldInfoPtr_diplomacyDataForCurrentTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "diplomacyDataForCurrentTurn");
		NativeFieldInfoPtr_isAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "isAlive");
		NativeFieldInfoPtr_isSleeping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "isSleeping");
		NativeFieldInfoPtr_eliminatedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "eliminatedBy");
		NativeFieldInfoPtr_buffLib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "buffLib");
		NativeFieldInfoPtr_additionalRecruitableMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "additionalRecruitableMember");
		NativeFieldInfoPtr_membersJoinedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "membersJoinedThisTurn");
		NativeFieldInfoPtr__unlockedTech_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<unlockedTech>k__BackingField");
		NativeFieldInfoPtr__additionUnlockedKungfu_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<additionUnlockedKungfu>k__BackingField");
		NativeFieldInfoPtr__additionBuffForFaction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<additionBuffForFaction>k__BackingField");
		NativeFieldInfoPtr__additionBuffForMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<additionBuffForMembers>k__BackingField");
		NativeFieldInfoPtr__unlockedKungfu_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<unlockedKungfu>k__BackingField");
		NativeFieldInfoPtr__allocatableBuffs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<allocatableBuffs>k__BackingField");
		NativeFieldInfoPtr__allocatableBuffsLeft_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<allocatableBuffsLeft>k__BackingField");
		NativeFieldInfoPtr__currencyEachTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<currencyEachTurn>k__BackingField");
		NativeFieldInfoPtr_backPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "backPack");
		NativeFieldInfoPtr_dlc1DelayActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "dlc1DelayActions");
		NativeFieldInfoPtr__jobSeekers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<jobSeekers>k__BackingField");
		NativeFieldInfoPtr_ConfigMemberUsedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "ConfigMemberUsedCount");
		NativeFieldInfoPtr_traderRefreshOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "traderRefreshOffset");
		NativeFieldInfoPtr_tradingItemPrechased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "tradingItemPrechased");
		NativeFieldInfoPtr_cachedTrader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "cachedTrader");
		NativeFieldInfoPtr_cachedTradeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "cachedTradeInstance");
		NativeFieldInfoPtr_humanRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "humanRes");
		NativeFieldInfoPtr__overrideTech_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "<overrideTech>k__BackingField");
		NativeFieldInfoPtr_slgRecruitMultipier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "slgRecruitMultipier");
		NativeFieldInfoPtr_slgRecruitUniqueReq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "slgRecruitUniqueReq");
		NativeFieldInfoPtr_newKungfuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, "newKungfuData");
		NativeMethodInfoPtr_get_avalilableTechs_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679232);
		NativeMethodInfoPtr_set_avalilableTechs_Private_set_Void_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679233);
		NativeMethodInfoPtr_get_avalilableTechReqs_Public_get_Dictionary_2_Int32_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679234);
		NativeMethodInfoPtr_set_avalilableTechReqs_Private_set_Void_Dictionary_2_Int32_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679235);
		NativeMethodInfoPtr_get_avalilableTechGraphPos_Public_get_Dictionary_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679236);
		NativeMethodInfoPtr_set_avalilableTechGraphPos_Private_set_Void_Dictionary_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679237);
		NativeMethodInfoPtr_get_leader_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679238);
		NativeMethodInfoPtr_set_leader_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679239);
		NativeMethodInfoPtr_get_storyLostProvinces_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679240);
		NativeMethodInfoPtr_set_storyLostProvinces_Private_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679241);
		NativeMethodInfoPtr_get_unlockedTech_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679242);
		NativeMethodInfoPtr_set_unlockedTech_Private_set_Void_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679243);
		NativeMethodInfoPtr_get_additionUnlockedKungfu_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679244);
		NativeMethodInfoPtr_set_additionUnlockedKungfu_Private_set_Void_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679245);
		NativeMethodInfoPtr_get_additionBuffForFaction_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679246);
		NativeMethodInfoPtr_set_additionBuffForFaction_Private_set_Void_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679247);
		NativeMethodInfoPtr_get_additionBuffForMembers_Public_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679248);
		NativeMethodInfoPtr_set_additionBuffForMembers_Private_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679249);
		NativeMethodInfoPtr_get_unlockedKungfu_Public_get_HashSet_1_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679250);
		NativeMethodInfoPtr_set_unlockedKungfu_Private_set_Void_HashSet_1_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679251);
		NativeMethodInfoPtr_get_allocatableBuffs_Public_get_Dictionary_2_BuffData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679252);
		NativeMethodInfoPtr_set_allocatableBuffs_Private_set_Void_Dictionary_2_BuffData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679253);
		NativeMethodInfoPtr_get_allocatableBuffsLeft_Public_get_Dictionary_2_BuffData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679254);
		NativeMethodInfoPtr_set_allocatableBuffsLeft_Private_set_Void_Dictionary_2_BuffData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679255);
		NativeMethodInfoPtr_get_currencyEachTurn_Public_get_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679256);
		NativeMethodInfoPtr_set_currencyEachTurn_Private_set_Void_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679257);
		NativeMethodInfoPtr_get_BackPack_Public_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679258);
		NativeMethodInfoPtr_get_jobSeekers_Public_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679259);
		NativeMethodInfoPtr_set_jobSeekers_Private_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679260);
		NativeMethodInfoPtr_get_overrideTech_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679261);
		NativeMethodInfoPtr_set_overrideTech_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679262);
		NativeMethodInfoPtr_get_Templete_Public_get_DLCFaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679263);
		NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679264);
		NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679265);
		NativeMethodInfoPtr_get_MaxMemberCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679266);
		NativeMethodInfoPtr_get_TotalMemberLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679267);
		NativeMethodInfoPtr_get_Leader_Public_get_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679268);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679269);
		NativeMethodInfoPtr__ctor_Public_Void_DLCFaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679270);
		NativeMethodInfoPtr_OnLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679271);
		NativeMethodInfoPtr_OnCurrencyChange_Public_Void_CurrencyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679272);
		NativeMethodInfoPtr_OnItemChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679273);
		NativeMethodInfoPtr_GetDelayAction_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679274);
		NativeMethodInfoPtr_AddProvince_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679275);
		NativeMethodInfoPtr_GetStoryLostProvinces_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679276);
		NativeMethodInfoPtr_AddStoryLostProvinces_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679277);
		NativeMethodInfoPtr_RemoveStoryLostProvinces_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679278);
		NativeMethodInfoPtr_SetCapital_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679279);
		NativeMethodInfoPtr_RemoveProvince_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679280);
		NativeMethodInfoPtr_SetAlive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679281);
		NativeMethodInfoPtr_WakeupFromSleeping_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679282);
		NativeMethodInfoPtr_AddNextConfigMember_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679283);
		NativeMethodInfoPtr_AddMember_Public_GameCharacterInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679284);
		NativeMethodInfoPtr_RemoveMember_Public_GameCharacterInstance_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679285);
		NativeMethodInfoPtr_CheckProvinceConection_Public_List_1_Dlc1ProvinceInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679286);
		NativeMethodInfoPtr_RemoveInvalidDelayAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679287);
		NativeMethodInfoPtr_HasProvince_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679288);
		NativeMethodInfoPtr_ChangeRelation_Public_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679289);
		NativeMethodInfoPtr_GetRelation_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679290);
		NativeMethodInfoPtr_SetRelation_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679291);
		NativeMethodInfoPtr_IsRelationInRange_Public_Boolean_Int32_SlgRelationRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679292);
		NativeMethodInfoPtr_GetFirstNpcByHpEpLess_Public_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679293);
		NativeMethodInfoPtr_GetFirstNpcByActionNone_Public_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679294);
		NativeMethodInfoPtr_GetNpcListByActionNone_Public_List_1_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679295);
		NativeMethodInfoPtr_AddDelayAction_Public_Void_Dlc1DelayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679296);
		NativeMethodInfoPtr_RemoveDelayAction_Public_Void_Dlc1DelayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679297);
		NativeMethodInfoPtr_TickForStable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679298);
		NativeMethodInfoPtr_TickForGuards_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679299);
		NativeMethodInfoPtr_TurnIncome_Public_GameItemPack_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679300);
		NativeMethodInfoPtr_TurnWage_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679301);
		NativeMethodInfoPtr_GetAllNeiborProvinceIds_Public_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679302);
		NativeMethodInfoPtr_GetAllNeiborProvinces_Public_HashSet_1_Dlc1ProvinceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679303);
		NativeMethodInfoPtr_GetAllNeiborFactionIds_Public_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679304);
		NativeMethodInfoPtr_GetAllNeiborFactions_Public_HashSet_1_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679305);
		NativeMethodInfoPtr_TickForAllMember_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679306);
		NativeMethodInfoPtr_TickForAllMemberAfterDecision_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679307);
		NativeMethodInfoPtr_GetBuffValue_Public_Decimal_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679308);
		NativeMethodInfoPtr_ClearAllFactionBonus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679309);
		NativeMethodInfoPtr_UnlockKungfu_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679310);
		NativeMethodInfoPtr_UnlockKungfu_Public_Void_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679311);
		NativeMethodInfoPtr_RemoveKungfu_Public_Void_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679312);
		NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679313);
		NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679314);
		NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679315);
		NativeMethodInfoPtr_ApplyBuffForMember_Public_Void_BuffData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679316);
		NativeMethodInfoPtr_ApplyAllUnlockedTechAfterLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679317);
		NativeMethodInfoPtr_ApplyAdditionBonusAfterLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679318);
		NativeMethodInfoPtr_SetOverrideTechGraph_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679319);
		NativeMethodInfoPtr_InitTechGraph_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679320);
		NativeMethodInfoPtr_GetCurrentResearchableTeches_Public_List_1_DLCTech_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679321);
		NativeMethodInfoPtr_ApplyTech_Public_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679322);
		NativeMethodInfoPtr_PostProcessingTechAdvancing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679323);
		NativeMethodInfoPtr_CaculateAllocatableBuffsLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679324);
		NativeMethodInfoPtr_CheckTraderAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679325);
		NativeMethodInfoPtr_UseItem_Public_Void_ItemData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679326);
		NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_BuffData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679327);
		NativeMethodInfoPtr_RemoveItem_Public_Void_ItemData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679328);
		NativeMethodInfoPtr_PickupPack_Public_Void_GameItemPack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679329);
		NativeMethodInfoPtr_GetActionDiscount_Public_Decimal_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679330);
		NativeMethodInfoPtr_StrToKeyWithValues_Public_Static_Il2CppReferenceArray_1_KeyWithValues_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679331);
		NativeMethodInfoPtr_KeyWithValuesToCurrenciesDict_Public_Dictionary_2_CurrencyType_Int64_Il2CppReferenceArray_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679332);
		NativeMethodInfoPtr_HasCurrency_Public_Boolean_CurrencyType_Int64_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679333);
		NativeMethodInfoPtr_HasCurrency_Public_Boolean_KeyWithValues_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679334);
		NativeMethodInfoPtr_HasCurrency_Public_Boolean_String_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679335);
		NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Dictionary_2_CurrencyType_Int64_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679336);
		NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679337);
		NativeMethodInfoPtr_HasCurrencies_Public_Boolean_String_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679338);
		NativeMethodInfoPtr_CostCurrency_Public_Void_CurrencyType_Int64_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679339);
		NativeMethodInfoPtr_CostCurrency_Public_Void_KeyWithValues_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679340);
		NativeMethodInfoPtr_CostCurrency_Public_Void_String_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679341);
		NativeMethodInfoPtr_CostCurrencies_Public_Void_Dictionary_2_CurrencyType_Int64_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679342);
		NativeMethodInfoPtr_CostCurrencies_Public_Void_Il2CppReferenceArray_1_KeyWithValues_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679343);
		NativeMethodInfoPtr_CostCurrencies_Public_Void_String_SlgActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679344);
		NativeMethodInfoPtr_SetFactionStatus_Public_Void_Int32_SlgFactionStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679345);
		NativeMethodInfoPtr_RemoveFactionStatus_Public_Void_Int32_SlgFactionStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679346);
		NativeMethodInfoPtr_GetCurrentStatusDuration_Public_Int32_Int32_SlgFactionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679347);
		NativeMethodInfoPtr_GetFactionStatus_Public_SlgFactionStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679348);
		NativeMethodInfoPtr_HasFactionStatus_Public_Boolean_Int32_SlgFactionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679349);
		NativeMethodInfoPtr_GetAllEnemyOfAllie_Public_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679350);
		NativeMethodInfoPtr_GetAllFactionByStatus_Public_HashSet_1_Int32_SlgFactionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679351);
		NativeMethodInfoPtr_ClearCachedTradingInfomation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679352);
		NativeMethodInfoPtr_CheckRestockAtTurnStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679353);
		NativeMethodInfoPtr_GetAllTraders_Public_List_1_SlgTraderInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679354);
		NativeMethodInfoPtr_GetTradingItems_Public_List_1_SlgTradeItemInstance_DLCTrader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679355);
		NativeMethodInfoPtr_GetPurchaseCountMax_Public_Int32_SlgTradeItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679356);
		NativeMethodInfoPtr_CouldPurchaseItem_Public_Boolean_SlgTradeItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679357);
		NativeMethodInfoPtr_PurchaseItem_Public_Boolean_SlgTradeItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679358);
		NativeMethodInfoPtr_GetSlgActionEffect_Public_Decimal_SlgActionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679359);
		NativeMethodInfoPtr_SlgActionHealGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679360);
		NativeMethodInfoPtr_SlgActionHealGetCureChange_Public_Vector2Int_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679361);
		NativeMethodInfoPtr_SlgActionHealCmd_Public_Boolean_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679362);
		NativeMethodInfoPtr_SlgActionInvasionGetCost_Public_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679363);
		NativeMethodInfoPtr_SlgActionInvadedGetAllProvinces_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679364);
		NativeMethodInfoPtr_SlgActionInvasionGetAllProvinceAvalible_Public_HashSet_1_Dlc1ProvinceInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679365);
		NativeMethodInfoPtr_SlgActionInvasionIsAvalible_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679366);
		NativeMethodInfoPtr_SlgActionInvasionCmd_Public_Dlc1InvasionBattleData_Int32_Int32_List_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679367);
		NativeMethodInfoPtr_SlgActionInvasionSetDefense_Public_Void_Dlc1InvasionBattleData_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679368);
		NativeMethodInfoPtr_SlgActionPatrolGetProvinces_Public_List_1_Dlc1ProvinceInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679369);
		NativeMethodInfoPtr_SlgActionPatrolGetProvincesByRelationOffensive_Public_List_1_Dlc1ProvinceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679370);
		NativeMethodInfoPtr_SlgActionPatrolGetCost_Public_Dictionary_2_CurrencyType_Int64_Dlc1ProvinceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679371);
		NativeMethodInfoPtr_SlgActionPatrolCmd_Public_Dlc1PatrolData_Dlc1ProvinceInstance_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679372);
		NativeMethodInfoPtr_SlgActionPatrolInvoke_Public_Void_Dlc1PatrolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679373);
		NativeMethodInfoPtr_SlgActionStudyGetAllKungfuCouldLearnState_Public_Dictionary_2_KungfuData_EquipingCheckResult_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679374);
		NativeMethodInfoPtr_SlgActionStudyGetAllKungfuDataList_Public_List_1_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679375);
		NativeMethodInfoPtr_SlgActionStudyCouldLearnKungfu_Public_EquipingCheckResult_GameCharacterInstance_KungfuData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679376);
		NativeMethodInfoPtr_SlgActionStudyCmd_Public_Boolean_GameCharacterInstance_KungfuData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679377);
		NativeMethodInfoPtr_SlgActionTrainKungfuGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679378);
		NativeMethodInfoPtr_SlgActionTrainKungfuExpPreview_Public_Int32_GameCharacterInstance_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679379);
		NativeMethodInfoPtr_SlgActionTrainKungfuCmd_Public_Void_GameCharacterInstance_KungfuInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679380);
		NativeMethodInfoPtr_SlgActionResearchIsDone_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679381);
		NativeMethodInfoPtr_SlgActionResearchGetCost_Public_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679382);
		NativeMethodInfoPtr_SlgActionResearchTributePreview_Public_Int32_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679383);
		NativeMethodInfoPtr_SlgActionResearchCmd_Public_Boolean_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679384);
		NativeMethodInfoPtr_SlgActionSupplyGetProvincesByRelationOffensive_Public_List_1_Dlc1ProvinceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679385);
		NativeMethodInfoPtr_SlgActionSupplyGetProvinces_Public_List_1_Dlc1ProvinceInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679386);
		NativeMethodInfoPtr_SlgActionSupplyGetCost_Public_Dictionary_2_CurrencyType_Int64_Dlc1ProvinceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679387);
		NativeMethodInfoPtr_SlgActionSupplyCmd_Public_Boolean_Dlc1ProvinceInstance_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679388);
		NativeMethodInfoPtr_SlgActionSupplyInvoke_Public_Void_Dlc1SupplyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679389);
		NativeMethodInfoPtr_SlgActionTraitCouldAlloc_Public_Boolean_GameCharacterInstance_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679390);
		NativeMethodInfoPtr_SlgActionTraitGetAllTraitDataList_Public_List_1_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679391);
		NativeMethodInfoPtr_SlgActionTraitAlloc_Public_Boolean_GameCharacterInstance_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679392);
		NativeMethodInfoPtr_SlgActionTraitRemove_Public_Boolean_GameCharacterInstance_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679393);
		NativeMethodInfoPtr_SlgActionRecruitTotalJobSeekerCountForNextResolve_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679394);
		NativeMethodInfoPtr_SlgActionRecruitResolveJobSeekersForThisTurn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679395);
		NativeMethodInfoPtr_SlgActionRecruitTickAllJobSeeker_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679396);
		NativeMethodInfoPtr_SlgActionRecruitRemoveJobSeeker_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679397);
		NativeMethodInfoPtr_SlgActionRecruitCreateJobSeeker_Public_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679398);
		NativeMethodInfoPtr_CreateRecruitUsingExtendData_Public_GameCharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679399);
		NativeMethodInfoPtr_SlgActionRecruitGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_DLCFactionJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679400);
		NativeMethodInfoPtr_SlgActionRecruitGetItemCost_Public_Dictionary_2_ItemData_Int32_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679401);
		NativeMethodInfoPtr_SlgActionRecruitIsReachLimitThisTurn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679402);
		NativeMethodInfoPtr_SlgActionRecruitAddMemberFromJobSeeker_Public_Boolean_GameCharacterInstance_DLCFactionJob_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679403);
		NativeMethodInfoPtr_SlgActionRecruitGetAdditionJobSeekerCost_Public_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679404);
		NativeMethodInfoPtr_SlgActionRecruitAddAdditionMember_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679405);
		NativeMethodInfoPtr_SlgDiplomacySetCount_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679406);
		NativeMethodInfoPtr_SlgDiplomacyGetCount_Public_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679407);
		NativeMethodInfoPtr_ClearDiplomacyAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679408);
		NativeMethodInfoPtr_SlgDiplomacyTruceGetCost_Public_Dictionary_2_CurrencyType_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679409);
		NativeMethodInfoPtr_SlgDiplomacyTruceGetFinished_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679410);
		NativeMethodInfoPtr_GetTruceResult_Public_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679411);
		NativeMethodInfoPtr_SlgDiplomacyTruceWithOtherFaction_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679412);
		NativeMethodInfoPtr_SlgDiplomacyImproveRelationGetCost_Public_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679413);
		NativeMethodInfoPtr_SlgDiplomacyImproveRelationGetFinished_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679414);
		NativeMethodInfoPtr_SlgDiplomacyImproveRelationUsingCurrency_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679415);
		NativeMethodInfoPtr_SlgDiplomacyImproveRelationUsingItem_Public_Void_Int32_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679416);
		NativeMethodInfoPtr_SlgDiplomacyTradingWithOtherFaction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679417);
		NativeMethodInfoPtr_SlgDiplomacyTradingGetIncomeFromOneFaction_Public_Dictionary_2_CurrencyType_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679418);
		NativeMethodInfoPtr_SlgDiplomacyTradingGetAllIncome_Public_Dictionary_2_CurrencyType_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679419);
		NativeMethodInfoPtr_TickForRelation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679420);
		NativeMethodInfoPtr_SlgDiplomacyAllieGetFinished_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679421);
		NativeMethodInfoPtr_GetAllieResult_Public_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679422);
		NativeMethodInfoPtr_SlgDiplomacyAllieWithOtherFaction_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679423);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuIsTempleteDynnamic_Public_Boolean_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679424);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuGetCost_Public_Dictionary_2_CurrencyType_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679425);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuCheckResearch_Public_SlgActionResearchNewKungfuCheckResearchResult_GameCharacterInstance_KungfuData_KungfuData_byref_Dictionary_2_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679426);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuCmd_Public_KungfuData_GameCharacterInstance_KungfuData_KungfuData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679427);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuRenameAndApplyLast_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679428);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuDiscardLast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679429);
		NativeMethodInfoPtr_SlgActionResearchNewKungfuDiscard_Private_Void_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679430);
		NativeMethodInfoPtr_SlgActionHumanResAddToMember_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679431);
		NativeMethodInfoPtr_HaveHumanRes_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679432);
		NativeMethodInfoPtr_RemoveHumanRes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679433);
		NativeMethodInfoPtr_SlgActionHumanResRemoveFromMember_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679434);
		NativeMethodInfoPtr_SlgActionHumanResNew_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679435);
		NativeMethodInfoPtr_BuffAllMembersHp_Public_Void_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679436);
		NativeMethodInfoPtr_BuffAllMembersEp_Public_Void_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679437);
		NativeMethodInfoPtr_BuffAllMembersMood_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679438);
		NativeMethodInfoPtr_BuffAllProvincesStable_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679439);
		NativeMethodInfoPtr___ctor_b__97_0_Private_Void_CurrencyType_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679440);
		NativeMethodInfoPtr___ctor_b__97_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679441);
		NativeMethodInfoPtr__OnLoaded_b__98_0_Private_Void_CurrencyType_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679442);
		NativeMethodInfoPtr__OnLoaded_b__98_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679443);
		NativeMethodInfoPtr__GetTruceResult_b__240_2_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr, 100679444);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 996696, RefRangeEnd = 996697, XrefRangeStart = 996563, XrefRangeEnd = 996696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1FactionInstance()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 996919, RefRangeEnd = 996920, XrefRangeStart = 996697, XrefRangeEnd = 996919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1FactionInstance(DLCFaction dLCFaction)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1FactionInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DLCFaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 996974, RefRangeEnd = 996975, XrefRangeStart = 996920, XrefRangeEnd = 996974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 996995, RefRangeEnd = 996997, XrefRangeStart = 996975, XrefRangeEnd = 996995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCurrencyChange(CurrencyType currencyType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currencyType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCurrencyChange_Public_Void_CurrencyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 997017, RefRangeEnd = 997019, XrefRangeStart = 996997, XrefRangeEnd = 997017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnItemChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnItemChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 997044, RefRangeEnd = 997053, XrefRangeStart = 997019, XrefRangeEnd = 997044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<T> GetDelayAction<T>() where T : Dlc1DelayAction
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetDelayAction_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 997121, RefRangeEnd = 997124, XrefRangeStart = 997053, XrefRangeEnd = 997121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddProvince(int provinceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&provinceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddProvince_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28448, RefRangeEnd = 28449, XrefRangeStart = 28448, XrefRangeEnd = 28449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetStoryLostProvinces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStoryLostProvinces_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997130, RefRangeEnd = 997131, XrefRangeStart = 997124, XrefRangeEnd = 997130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddStoryLostProvinces(int provinceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&provinceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddStoryLostProvinces_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997131, XrefRangeEnd = 997137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveStoryLostProvinces(int provinceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&provinceID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveStoryLostProvinces_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997137, XrefRangeEnd = 997146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCapital(int provinceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&provinceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCapital_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 997390, RefRangeEnd = 997392, XrefRangeStart = 997146, XrefRangeEnd = 997390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveProvince(int provinceId, int tokenBy = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&provinceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenBy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveProvince_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997392, XrefRangeEnd = 997402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAlive(bool isAlive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isAlive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997501, RefRangeEnd = 997502, XrefRangeStart = 997402, XrefRangeEnd = 997501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WakeupFromSleeping(bool refreshOutline = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&refreshOutline);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WakeupFromSleeping_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997502, XrefRangeEnd = 997536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddNextConfigMember()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNextConfigMember_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 997589, RefRangeEnd = 997596, XrefRangeStart = 997536, XrefRangeEnd = 997589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance AddMember(int characterId, int slgFactionJob = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&characterId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slgFactionJob;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMember_Public_GameCharacterInstance_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 997758, RefRangeEnd = 997763, XrefRangeStart = 997596, XrefRangeEnd = 997758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance RemoveMember(int characterId, bool moveToMarket = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&characterId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &moveToMarket;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMember_Public_GameCharacterInstance_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 997827, RefRangeEnd = 997829, XrefRangeStart = 997763, XrefRangeEnd = 997827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Dlc1ProvinceInstance> CheckProvinceConection(bool removeNonconnectProvinces = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&removeNonconnectProvinces);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckProvinceConection_Public_List_1_Dlc1ProvinceInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 997886, RefRangeEnd = 997888, XrefRangeStart = 997829, XrefRangeEnd = 997886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveInvalidDelayAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInvalidDelayAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997888, XrefRangeEnd = 997892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasProvince(int provinceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&provinceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasProvince_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 997940, RefRangeEnd = 997948, XrefRangeStart = 997892, XrefRangeEnd = 997940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ChangeRelation(int otherFactionID, int offset, bool changeOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&otherFactionID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRelation_Public_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 997951, RefRangeEnd = 997967, XrefRangeStart = 997948, XrefRangeEnd = 997951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRelation(int otherFactionID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFactionID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelation_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 997997, RefRangeEnd = 998003, XrefRangeStart = 997967, XrefRangeEnd = 997997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRelation(int otherFactionID, int newRelation, bool changeOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&otherFactionID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newRelation;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRelation_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 998018, RefRangeEnd = 998030, XrefRangeStart = 998003, XrefRangeEnd = 998018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRelationInRange(int otherFaction, SlgRelationRange slgRelationRange)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherFaction);
		*(SlgRelationRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slgRelationRange;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRelationInRange_Public_Boolean_Int32_SlgRelationRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998061, RefRangeEnd = 998062, XrefRangeStart = 998030, XrefRangeEnd = 998061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance GetFirstNpcByHpEpLess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstNpcByHpEpLess_Public_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998062, XrefRangeEnd = 998087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance GetFirstNpcByActionNone(bool encludeStrike)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&encludeStrike);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstNpcByActionNone_Public_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998119, RefRangeEnd = 998122, XrefRangeStart = 998087, XrefRangeEnd = 998119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameCharacterInstance> GetNpcListByActionNone(bool encludeStrike)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&encludeStrike);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNpcListByActionNone_Public_List_1_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998141, RefRangeEnd = 998144, XrefRangeStart = 998122, XrefRangeEnd = 998141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDelayAction(Dlc1DelayAction dlc1DelayAction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1DelayAction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDelayAction_Public_Void_Dlc1DelayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 998162, RefRangeEnd = 998172, XrefRangeStart = 998144, XrefRangeEnd = 998162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDelayAction(Dlc1DelayAction dlc1DelayAction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1DelayAction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDelayAction_Public_Void_Dlc1DelayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998227, RefRangeEnd = 998228, XrefRangeStart = 998172, XrefRangeEnd = 998227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickForStable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickForStable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998257, RefRangeEnd = 998258, XrefRangeStart = 998228, XrefRangeEnd = 998257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickForGuards()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickForGuards_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998319, RefRangeEnd = 998321, XrefRangeStart = 998258, XrefRangeEnd = 998319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack TurnIncome(int turnNum = -1, bool addToBackPack = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&turnNum);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToBackPack;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnIncome_Public_GameItemPack_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 998355, RefRangeEnd = 998359, XrefRangeStart = 998321, XrefRangeEnd = 998355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TurnWage(bool removeFromBackPack = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&removeFromBackPack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnWage_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998404, RefRangeEnd = 998406, XrefRangeStart = 998359, XrefRangeEnd = 998404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<int> GetAllNeiborProvinceIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeiborProvinceIds_Public_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998448, RefRangeEnd = 998451, XrefRangeStart = 998406, XrefRangeEnd = 998448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Dlc1ProvinceInstance> GetAllNeiborProvinces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeiborProvinces_Public_HashSet_1_Dlc1ProvinceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998475, RefRangeEnd = 998478, XrefRangeStart = 998451, XrefRangeEnd = 998475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<int> GetAllNeiborFactionIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeiborFactionIds_Public_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998509, RefRangeEnd = 998510, XrefRangeStart = 998478, XrefRangeEnd = 998509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Dlc1FactionInstance> GetAllNeiborFactions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeiborFactions_Public_HashSet_1_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Dlc1FactionInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998597, RefRangeEnd = 998598, XrefRangeStart = 998510, XrefRangeEnd = 998597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickForAllMember()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickForAllMember_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998626, RefRangeEnd = 998627, XrefRangeStart = 998598, XrefRangeEnd = 998626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickForAllMemberAfterDecision()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickForAllMemberAfterDecision_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 998639, RefRangeEnd = 998662, XrefRangeStart = 998627, XrefRangeEnd = 998639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetBuffValue(string key, Il2CppSystem.Decimal origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffValue_Public_Decimal_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998662, XrefRangeEnd = 998684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllFactionBonus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllFactionBonus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998693, RefRangeEnd = 998694, XrefRangeStart = 998684, XrefRangeEnd = 998693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockKungfu(int kungfuId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&kungfuId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockKungfu_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 998740, RefRangeEnd = 998744, XrefRangeStart = 998694, XrefRangeEnd = 998740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockKungfu(KungfuData kungfuData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockKungfu_Public_Void_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998750, RefRangeEnd = 998751, XrefRangeStart = 998744, XrefRangeEnd = 998750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveKungfu(KungfuData kungfuData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveKungfu_Public_Void_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998751, XrefRangeEnd = 998763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyBuffForFaction(int buffId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998775, RefRangeEnd = 998777, XrefRangeStart = 998763, XrefRangeEnd = 998775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyBuffForFaction(string buffName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buffName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998777, XrefRangeEnd = 998782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyBuffForFaction(BuffData buffData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuffForFaction_Public_Void_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998821, RefRangeEnd = 998822, XrefRangeStart = 998782, XrefRangeEnd = 998821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyBuffForMember(BuffData buffData, int num = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBuffForMember_Public_Void_BuffData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998851, RefRangeEnd = 998852, XrefRangeStart = 998822, XrefRangeEnd = 998851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyAllUnlockedTechAfterLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyAllUnlockedTechAfterLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998926, RefRangeEnd = 998927, XrefRangeStart = 998852, XrefRangeEnd = 998926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyAdditionBonusAfterLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyAdditionBonusAfterLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998928, RefRangeEnd = 998930, XrefRangeStart = 998927, XrefRangeEnd = 998928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOverrideTechGraph(string overrideTech)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(overrideTech);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOverrideTechGraph_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 999046, RefRangeEnd = 999049, XrefRangeStart = 998930, XrefRangeEnd = 999046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTechGraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTechGraph_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 999092, RefRangeEnd = 999093, XrefRangeStart = 999049, XrefRangeEnd = 999092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DLCTech> GetCurrentResearchableTeches(bool checkCost = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&checkCost);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentResearchableTeches_Public_List_1_DLCTech_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DLCTech>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 999220, RefRangeEnd = 999223, XrefRangeStart = 999093, XrefRangeEnd = 999220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ApplyTech(int techId, bool hasCost = false, bool postProcessingTechAdvancing = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&techId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &postProcessingTechAdvancing;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTech_Public_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999223, XrefRangeEnd = 999229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostProcessingTechAdvancing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostProcessingTechAdvancing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 999277, RefRangeEnd = 999282, XrefRangeStart = 999229, XrefRangeEnd = 999277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaculateAllocatableBuffsLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaculateAllocatableBuffsLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 999308, RefRangeEnd = 999312, XrefRangeStart = 999282, XrefRangeEnd = 999308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckTraderAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTraderAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 999335, RefRangeEnd = 999336, XrefRangeStart = 999312, XrefRangeEnd = 999335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseItem(ItemData data, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Void_ItemData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 999417, RefRangeEnd = 999421, XrefRangeStart = 999336, XrefRangeEnd = 999417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetBuffBattleEffect(BuffData buffData, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffBattleEffect_Public_Void_BuffData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999421, XrefRangeEnd = 999440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveItem(ItemData item, int count, bool hasLogForPlayerFaction = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLogForPlayerFaction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Void_ItemData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 999592, RefRangeEnd = 999606, XrefRangeStart = 999440, XrefRangeEnd = 999592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PickupPack(GameItemPack pack, bool hasLogForPlayerFaction = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pack);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLogForPlayerFaction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickupPack_Public_Void_GameItemPack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 999623, RefRangeEnd = 999645, XrefRangeStart = 999606, XrefRangeEnd = 999623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetActionDiscount(SlgActionType action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionDiscount_Public_Decimal_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 999659, RefRangeEnd = 999679, XrefRangeStart = 999645, XrefRangeEnd = 999659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<KeyWithValues> StrToKeyWithValues(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StrToKeyWithValues_Public_Static_Il2CppReferenceArray_1_KeyWithValues_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyWithValues>>(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 999692, RefRangeEnd = 999709, XrefRangeStart = 999679, XrefRangeEnd = 999692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> KeyWithValuesToCurrenciesDict(Il2CppReferenceArray<KeyWithValues> keyWithValues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyWithValuesToCurrenciesDict_Public_Dictionary_2_CurrencyType_Int64_Il2CppReferenceArray_1_KeyWithValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 999718, RefRangeEnd = 999719, XrefRangeStart = 999709, XrefRangeEnd = 999718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrency(CurrencyType currencyType, long amount, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&currencyType);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(SlgActionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrency_Public_Boolean_CurrencyType_Int64_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 999725, RefRangeEnd = 999728, XrefRangeStart = 999719, XrefRangeEnd = 999725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrency(KeyWithValues keyWithValues, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrency_Public_Boolean_KeyWithValues_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999728, XrefRangeEnd = 999733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrency(string str, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrency_Public_Boolean_String_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999733, XrefRangeEnd = 999759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrencies(Dictionary<CurrencyType, long> currencies, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currencies);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Dictionary_2_CurrencyType_Int64_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 999762, RefRangeEnd = 999763, XrefRangeStart = 999759, XrefRangeEnd = 999762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrencies(Il2CppReferenceArray<KeyWithValues> keyWithValues, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrencies_Public_Boolean_Il2CppReferenceArray_1_KeyWithValues_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999763, XrefRangeEnd = 999775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCurrencies(string currencies, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(currencies);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrencies_Public_Boolean_String_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 999826, RefRangeEnd = 999828, XrefRangeStart = 999775, XrefRangeEnd = 999826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostCurrency(CurrencyType currencyType, long amount, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&currencyType);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(SlgActionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostCurrency_Public_Void_CurrencyType_Int64_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 999835, RefRangeEnd = 999836, XrefRangeStart = 999828, XrefRangeEnd = 999835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostCurrency(KeyWithValues keyWithValues, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostCurrency_Public_Void_KeyWithValues_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999836, XrefRangeEnd = 999841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostCurrency(string str, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostCurrency_Public_Void_String_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 999861, RefRangeEnd = 999872, XrefRangeStart = 999841, XrefRangeEnd = 999861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostCurrencies(Dictionary<CurrencyType, long> currencies, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currencies);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostCurrencies_Public_Void_Dictionary_2_CurrencyType_Int64_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999872, XrefRangeEnd = 999880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostCurrencies(Il2CppReferenceArray<KeyWithValues> keyWithValues, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostCurrencies_Public_Void_Il2CppReferenceArray_1_KeyWithValues_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999880, XrefRangeEnd = 999897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CostCurrencies(string currencies, SlgActionType actionDiscount = SlgActionType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(currencies);
		*(SlgActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionDiscount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CostCurrencies_Public_Void_String_SlgActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 999948, RefRangeEnd = 999952, XrefRangeStart = 999897, XrefRangeEnd = 999948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFactionStatus(int targetFaction, SlgFactionStatus slgFactionStatus, bool setOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&targetFaction);
		*(SlgFactionStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slgFactionStatus;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionStatus_Public_Void_Int32_SlgFactionStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1000026, RefRangeEnd = 1000030, XrefRangeStart = 999952, XrefRangeEnd = 1000026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFactionStatus(int targetFaction, SlgFactionStatus slgFactionStatus, bool setOther = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&targetFaction);
		*(SlgFactionStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slgFactionStatus;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setOther;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFactionStatus_Public_Void_Int32_SlgFactionStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000042, RefRangeEnd = 1000043, XrefRangeStart = 1000030, XrefRangeEnd = 1000042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCurrentStatusDuration(int targetFaction, SlgFactionStatus slgFactionStatus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetFaction);
		*(SlgFactionStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slgFactionStatus;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentStatusDuration_Public_Int32_Int32_SlgFactionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1000049, RefRangeEnd = 1000052, XrefRangeStart = 1000043, XrefRangeEnd = 1000049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgFactionStatus GetFactionStatus(int targetFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFactionStatus_Public_SlgFactionStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SlgFactionStatus*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1000058, RefRangeEnd = 1000065, XrefRangeStart = 1000052, XrefRangeEnd = 1000058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasFactionStatus(int targetFaction, SlgFactionStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetFaction);
		*(SlgFactionStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &status;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFactionStatus_Public_Boolean_Int32_SlgFactionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000097, RefRangeEnd = 1000098, XrefRangeStart = 1000065, XrefRangeEnd = 1000097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<int> GetAllEnemyOfAllie()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllEnemyOfAllie_Public_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1000141, RefRangeEnd = 1000150, XrefRangeStart = 1000098, XrefRangeEnd = 1000141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<int> GetAllFactionByStatus(SlgFactionStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllFactionByStatus_Public_HashSet_1_Int32_SlgFactionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000150, XrefRangeEnd = 1000154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCachedTradingInfomation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCachedTradingInfomation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000218, RefRangeEnd = 1000219, XrefRangeStart = 1000154, XrefRangeEnd = 1000218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckRestockAtTurnStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckRestockAtTurnStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1000247, RefRangeEnd = 1000251, XrefRangeStart = 1000219, XrefRangeEnd = 1000247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SlgTraderInstance> GetAllTraders()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllTraders_Public_List_1_SlgTraderInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SlgTraderInstance>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1000291, RefRangeEnd = 1000294, XrefRangeStart = 1000251, XrefRangeEnd = 1000291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SlgTradeItemInstance> GetTradingItems(DLCTrader dLCTrader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCTrader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradingItems_Public_List_1_SlgTradeItemInstance_DLCTrader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SlgTradeItemInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000304, RefRangeEnd = 1000305, XrefRangeStart = 1000294, XrefRangeEnd = 1000304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPurchaseCountMax(SlgTradeItemInstance itemInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPurchaseCountMax_Public_Int32_SlgTradeItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000324, RefRangeEnd = 1000325, XrefRangeStart = 1000305, XrefRangeEnd = 1000324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldPurchaseItem(SlgTradeItemInstance itemInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldPurchaseItem_Public_Boolean_SlgTradeItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000355, RefRangeEnd = 1000356, XrefRangeStart = 1000325, XrefRangeEnd = 1000355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PurchaseItem(SlgTradeItemInstance itemInstance, int count = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemInstance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PurchaseItem_Public_Boolean_SlgTradeItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 1000387, RefRangeEnd = 1000422, XrefRangeStart = 1000356, XrefRangeEnd = 1000387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetSlgActionEffect(SlgActionType slgActionType, string subKey = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&slgActionType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(subKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlgActionEffect_Public_Decimal_SlgActionType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000494, RefRangeEnd = 1000496, XrefRangeStart = 1000422, XrefRangeEnd = 1000494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionHealGetCost(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionHealGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000514, RefRangeEnd = 1000515, XrefRangeStart = 1000496, XrefRangeEnd = 1000514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int SlgActionHealGetCureChange(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionHealGetCureChange_Public_Vector2Int_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000543, RefRangeEnd = 1000544, XrefRangeStart = 1000515, XrefRangeEnd = 1000543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionHealCmd(GameCharacterInstance gameCharacterInstance, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionHealCmd_Public_Boolean_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000561, RefRangeEnd = 1000562, XrefRangeStart = 1000544, XrefRangeEnd = 1000561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionInvasionGetCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionInvasionGetCost_Public_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000592, RefRangeEnd = 1000593, XrefRangeStart = 1000562, XrefRangeEnd = 1000592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> SlgActionInvadedGetAllProvinces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionInvadedGetAllProvinces_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1000670, RefRangeEnd = 1000675, XrefRangeStart = 1000593, XrefRangeEnd = 1000670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Dlc1ProvinceInstance> SlgActionInvasionGetAllProvinceAvalible(bool isAttackFrom = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isAttackFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionInvasionGetAllProvinceAvalible_Public_HashSet_1_Dlc1ProvinceInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000728, RefRangeEnd = 1000729, XrefRangeStart = 1000675, XrefRangeEnd = 1000728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionInvasionIsAvalible(int fromProvince, int targetProvince)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&fromProvince);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetProvince;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionInvasionIsAvalible_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001018, RefRangeEnd = 1001020, XrefRangeStart = 1000729, XrefRangeEnd = 1001018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1InvasionBattleData SlgActionInvasionCmd(int attackFrom, int attackTo, List<int> attackCharacterIds, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&attackFrom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &attackTo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackCharacterIds);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionInvasionCmd_Public_Dlc1InvasionBattleData_Int32_Int32_List_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dlc1InvasionBattleData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001020, XrefRangeEnd = 1001053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionInvasionSetDefense(Dlc1InvasionBattleData dlc1InvasionBattleData, List<int> defenders)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1InvasionBattleData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defenders);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionInvasionSetDefense_Public_Void_Dlc1InvasionBattleData_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1001136, RefRangeEnd = 1001139, XrefRangeStart = 1001053, XrefRangeEnd = 1001136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Dlc1ProvinceInstance> SlgActionPatrolGetProvinces(int highlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&highlight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionPatrolGetProvinces_Public_List_1_Dlc1ProvinceInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001146, RefRangeEnd = 1001147, XrefRangeStart = 1001139, XrefRangeEnd = 1001146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Dlc1ProvinceInstance> SlgActionPatrolGetProvincesByRelationOffensive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionPatrolGetProvincesByRelationOffensive_Public_List_1_Dlc1ProvinceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001168, RefRangeEnd = 1001169, XrefRangeStart = 1001147, XrefRangeEnd = 1001168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionPatrolGetCost(Dlc1ProvinceInstance dlc1ProvinceInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1ProvinceInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionPatrolGetCost_Public_Dictionary_2_CurrencyType_Int64_Dlc1ProvinceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001217, RefRangeEnd = 1001218, XrefRangeStart = 1001169, XrefRangeEnd = 1001217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1PatrolData SlgActionPatrolCmd(Dlc1ProvinceInstance dlc1ProvinceInstance, GameCharacterInstance characterInstance, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1ProvinceInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInstance);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionPatrolCmd_Public_Dlc1PatrolData_Dlc1ProvinceInstance_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dlc1PatrolData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001243, RefRangeEnd = 1001244, XrefRangeStart = 1001218, XrefRangeEnd = 1001243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionPatrolInvoke(Dlc1PatrolData dlc1PatrolData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1PatrolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionPatrolInvoke_Public_Void_Dlc1PatrolData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001268, RefRangeEnd = 1001270, XrefRangeStart = 1001244, XrefRangeEnd = 1001268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<KungfuData, GameCharacterInstance.EquipingCheckResult> SlgActionStudyGetAllKungfuCouldLearnState(GameCharacterInstance gameCharacterInstance, bool checkKungfuCount = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkKungfuCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionStudyGetAllKungfuCouldLearnState_Public_Dictionary_2_KungfuData_EquipingCheckResult_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<KungfuData, GameCharacterInstance.EquipingCheckResult>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001306, RefRangeEnd = 1001307, XrefRangeStart = 1001270, XrefRangeEnd = 1001306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<KungfuData> SlgActionStudyGetAllKungfuDataList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionStudyGetAllKungfuDataList_Public_List_1_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001307, XrefRangeEnd = 1001309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance.EquipingCheckResult SlgActionStudyCouldLearnKungfu(GameCharacterInstance gameCharacterInstance, KungfuData kungfuData, bool checkKungfuCount = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkKungfuCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionStudyCouldLearnKungfu_Public_EquipingCheckResult_GameCharacterInstance_KungfuData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GameCharacterInstance.EquipingCheckResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001315, RefRangeEnd = 1001316, XrefRangeStart = 1001309, XrefRangeEnd = 1001315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionStudyCmd(GameCharacterInstance gameCharacterInstance, KungfuData kungfuData, bool useActionType = true, bool hasLog = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useActionType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionStudyCmd_Public_Boolean_GameCharacterInstance_KungfuData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001336, RefRangeEnd = 1001338, XrefRangeStart = 1001316, XrefRangeEnd = 1001336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionTrainKungfuGetCost(GameCharacterInstance gameCharacterInstance, KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTrainKungfuGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001352, RefRangeEnd = 1001354, XrefRangeStart = 1001338, XrefRangeEnd = 1001352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SlgActionTrainKungfuExpPreview(GameCharacterInstance gameCharacterInstance, KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTrainKungfuExpPreview_Public_Int32_GameCharacterInstance_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001438, RefRangeEnd = 1001439, XrefRangeStart = 1001354, XrefRangeEnd = 1001438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionTrainKungfuCmd(GameCharacterInstance gameCharacterInstance, KungfuInstance kungfuInstance, bool hasCost = false, bool hasLog = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTrainKungfuCmd_Public_Void_GameCharacterInstance_KungfuInstance_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001464, RefRangeEnd = 1001466, XrefRangeStart = 1001439, XrefRangeEnd = 1001464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionResearchIsDone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchIsDone_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001483, RefRangeEnd = 1001485, XrefRangeStart = 1001466, XrefRangeEnd = 1001483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionResearchGetCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchGetCost_Public_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1001509, RefRangeEnd = 1001512, XrefRangeStart = 1001485, XrefRangeEnd = 1001509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SlgActionResearchTributePreview(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchTributePreview_Public_Int32_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001553, RefRangeEnd = 1001554, XrefRangeStart = 1001512, XrefRangeEnd = 1001553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionResearchCmd(GameCharacterInstance gameCharacterInstance, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchCmd_Public_Boolean_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001560, RefRangeEnd = 1001561, XrefRangeStart = 1001554, XrefRangeEnd = 1001560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Dlc1ProvinceInstance> SlgActionSupplyGetProvincesByRelationOffensive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionSupplyGetProvincesByRelationOffensive_Public_List_1_Dlc1ProvinceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1001647, RefRangeEnd = 1001652, XrefRangeStart = 1001561, XrefRangeEnd = 1001647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Dlc1ProvinceInstance> SlgActionSupplyGetProvinces(float highlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&highlight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionSupplyGetProvinces_Public_List_1_Dlc1ProvinceInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001676, RefRangeEnd = 1001677, XrefRangeStart = 1001652, XrefRangeEnd = 1001676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionSupplyGetCost(Dlc1ProvinceInstance dlc1ProvinceInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1ProvinceInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionSupplyGetCost_Public_Dictionary_2_CurrencyType_Int64_Dlc1ProvinceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001716, RefRangeEnd = 1001717, XrefRangeStart = 1001677, XrefRangeEnd = 1001716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionSupplyCmd(Dlc1ProvinceInstance dlc1ProvinceInstance, GameCharacterInstance gameCharacterInstance, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1ProvinceInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionSupplyCmd_Public_Boolean_Dlc1ProvinceInstance_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001728, RefRangeEnd = 1001729, XrefRangeStart = 1001717, XrefRangeEnd = 1001728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionSupplyInvoke(Dlc1SupplyData dlc1SupplyData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dlc1SupplyData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionSupplyInvoke_Public_Void_Dlc1SupplyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001748, RefRangeEnd = 1001749, XrefRangeStart = 1001729, XrefRangeEnd = 1001748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionTraitCouldAlloc(GameCharacterInstance gameCharacterInstance, BuffData buffData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTraitCouldAlloc_Public_Boolean_GameCharacterInstance_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001788, RefRangeEnd = 1001789, XrefRangeStart = 1001749, XrefRangeEnd = 1001788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BuffData> SlgActionTraitGetAllTraitDataList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTraitGetAllTraitDataList_Public_List_1_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuffData>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001797, RefRangeEnd = 1001799, XrefRangeStart = 1001789, XrefRangeEnd = 1001797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionTraitAlloc(GameCharacterInstance gameCharacterInstance, BuffData buffData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTraitAlloc_Public_Boolean_GameCharacterInstance_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001818, RefRangeEnd = 1001819, XrefRangeStart = 1001799, XrefRangeEnd = 1001818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionTraitRemove(GameCharacterInstance gameCharacterInstance, BuffData buffData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionTraitRemove_Public_Boolean_GameCharacterInstance_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001819, XrefRangeEnd = 1001826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SlgActionRecruitTotalJobSeekerCountForNextResolve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitTotalJobSeekerCountForNextResolve_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001844, RefRangeEnd = 1001845, XrefRangeStart = 1001826, XrefRangeEnd = 1001844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionRecruitResolveJobSeekersForThisTurn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitResolveJobSeekersForThisTurn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001880, RefRangeEnd = 1001881, XrefRangeStart = 1001845, XrefRangeEnd = 1001880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionRecruitTickAllJobSeeker()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitTickAllJobSeeker_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001905, RefRangeEnd = 1001906, XrefRangeStart = 1001881, XrefRangeEnd = 1001905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionRecruitRemoveJobSeeker(int characterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&characterInstanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitRemoveJobSeeker_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001969, RefRangeEnd = 1001971, XrefRangeStart = 1001906, XrefRangeEnd = 1001969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance SlgActionRecruitCreateJobSeeker(bool isFromJobMarket = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isFromJobMarket);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitCreateJobSeeker_Public_GameCharacterInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002137, RefRangeEnd = 1002138, XrefRangeStart = 1001971, XrefRangeEnd = 1002137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance CreateRecruitUsingExtendData(string idOrName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(idOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRecruitUsingExtendData_Public_GameCharacterInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1002225, RefRangeEnd = 1002228, XrefRangeStart = 1002138, XrefRangeEnd = 1002225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionRecruitGetCost(GameCharacterInstance gameCharacterInstance, DLCFactionJob dLCFactionJob = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFactionJob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitGetCost_Public_Dictionary_2_CurrencyType_Int64_GameCharacterInstance_DLCFactionJob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1002283, RefRangeEnd = 1002289, XrefRangeStart = 1002228, XrefRangeEnd = 1002283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<ItemData, int> SlgActionRecruitGetItemCost(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitGetItemCost_Public_Dictionary_2_ItemData_Int32_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemData, int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002297, RefRangeEnd = 1002298, XrefRangeStart = 1002289, XrefRangeEnd = 1002297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionRecruitIsReachLimitThisTurn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitIsReachLimitThisTurn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002416, RefRangeEnd = 1002417, XrefRangeStart = 1002298, XrefRangeEnd = 1002416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionRecruitAddMemberFromJobSeeker(GameCharacterInstance gameCharacterInstance, DLCFactionJob dLCFactionJob, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFactionJob);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitAddMemberFromJobSeeker_Public_Boolean_GameCharacterInstance_DLCFactionJob_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1002441, RefRangeEnd = 1002444, XrefRangeStart = 1002417, XrefRangeEnd = 1002441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionRecruitGetAdditionJobSeekerCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitGetAdditionJobSeekerCost_Public_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002469, RefRangeEnd = 1002470, XrefRangeStart = 1002444, XrefRangeEnd = 1002469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionRecruitAddAdditionMember(bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hasCost);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionRecruitAddAdditionMember_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1002483, RefRangeEnd = 1002487, XrefRangeStart = 1002470, XrefRangeEnd = 1002483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgDiplomacySetCount(int otherFaction, string actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherFaction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacySetCount_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1002495, RefRangeEnd = 1002498, XrefRangeStart = 1002487, XrefRangeEnd = 1002495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SlgDiplomacyGetCount(int otherFaction, string actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherFaction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyGetCount_Public_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002502, RefRangeEnd = 1002503, XrefRangeStart = 1002498, XrefRangeEnd = 1002502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDiplomacyAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDiplomacyAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1002527, RefRangeEnd = 1002530, XrefRangeStart = 1002503, XrefRangeEnd = 1002527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgDiplomacyTruceGetCost(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyTruceGetCost_Public_Dictionary_2_CurrencyType_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002533, RefRangeEnd = 1002534, XrefRangeStart = 1002530, XrefRangeEnd = 1002533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgDiplomacyTruceGetFinished(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyTruceGetFinished_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1002660, RefRangeEnd = 1002662, XrefRangeStart = 1002534, XrefRangeEnd = 1002660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetTruceResult(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTruceResult_Public_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1002745, RefRangeEnd = 1002748, XrefRangeStart = 1002662, XrefRangeEnd = 1002745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgDiplomacyTruceWithOtherFaction(int otherFaction, bool result, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&otherFaction);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyTruceWithOtherFaction_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1002760, RefRangeEnd = 1002762, XrefRangeStart = 1002748, XrefRangeEnd = 1002760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgDiplomacyImproveRelationGetCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyImproveRelationGetCost_Public_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002765, RefRangeEnd = 1002766, XrefRangeStart = 1002762, XrefRangeEnd = 1002765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgDiplomacyImproveRelationGetFinished(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyImproveRelationGetFinished_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002795, RefRangeEnd = 1002796, XrefRangeStart = 1002766, XrefRangeEnd = 1002795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgDiplomacyImproveRelationUsingCurrency(int otherFaction, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherFaction);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyImproveRelationUsingCurrency_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002796, XrefRangeEnd = 1002806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgDiplomacyImproveRelationUsingItem(int otherFaction, ItemData itemData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherFaction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyImproveRelationUsingItem_Public_Void_Int32_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002808, RefRangeEnd = 1002809, XrefRangeStart = 1002806, XrefRangeEnd = 1002808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgDiplomacyTradingWithOtherFaction(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyTradingWithOtherFaction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1002882, RefRangeEnd = 1002884, XrefRangeStart = 1002809, XrefRangeEnd = 1002882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgDiplomacyTradingGetIncomeFromOneFaction(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyTradingGetIncomeFromOneFaction_Public_Dictionary_2_CurrencyType_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1003001, RefRangeEnd = 1003003, XrefRangeStart = 1002884, XrefRangeEnd = 1003001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgDiplomacyTradingGetAllIncome(bool addToBackPack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addToBackPack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyTradingGetAllIncome_Public_Dictionary_2_CurrencyType_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003039, RefRangeEnd = 1003040, XrefRangeStart = 1003003, XrefRangeEnd = 1003039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickForRelation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickForRelation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003043, RefRangeEnd = 1003044, XrefRangeStart = 1003040, XrefRangeEnd = 1003043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgDiplomacyAllieGetFinished(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyAllieGetFinished_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003058, RefRangeEnd = 1003059, XrefRangeStart = 1003044, XrefRangeEnd = 1003058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetAllieResult(int otherFaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&otherFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllieResult_Public_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1003064, RefRangeEnd = 1003067, XrefRangeStart = 1003059, XrefRangeEnd = 1003064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgDiplomacyAllieWithOtherFaction(int otherFaction, bool result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&otherFaction);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgDiplomacyAllieWithOtherFaction_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1003075, RefRangeEnd = 1003080, XrefRangeStart = 1003067, XrefRangeEnd = 1003075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SlgActionResearchNewKungfuIsTempleteDynnamic(KungfuData templete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templete);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuIsTempleteDynnamic_Public_Boolean_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003100, RefRangeEnd = 1003101, XrefRangeStart = 1003080, XrefRangeEnd = 1003100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> SlgActionResearchNewKungfuGetCost(int templeteRarity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&templeteRarity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuGetCost_Public_Dictionary_2_CurrencyType_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003139, RefRangeEnd = 1003140, XrefRangeStart = 1003101, XrefRangeEnd = 1003139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgActionResearchNewKungfuCheckResearchResult SlgActionResearchNewKungfuCheckResearch(GameCharacterInstance gameCharacterInstance, KungfuData kungfuTemplete1, KungfuData kungfuTemplete2, ref Dictionary<CurrencyType, long> cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuTemplete1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuTemplete2);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cost);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuCheckResearch_Public_SlgActionResearchNewKungfuCheckResearchResult_GameCharacterInstance_KungfuData_KungfuData_byref_Dictionary_2_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		cost = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<CurrencyType, long>(intPtr4));
		return *(SlgActionResearchNewKungfuCheckResearchResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003348, RefRangeEnd = 1003349, XrefRangeStart = 1003140, XrefRangeEnd = 1003348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuData SlgActionResearchNewKungfuCmd(GameCharacterInstance gameCharacterInstance, KungfuData kungfuTemplete1, KungfuData kungfuTemplete2, bool hasCost = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuTemplete1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuTemplete2);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCost;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuCmd_Public_KungfuData_GameCharacterInstance_KungfuData_KungfuData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003372, RefRangeEnd = 1003373, XrefRangeStart = 1003349, XrefRangeEnd = 1003372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionResearchNewKungfuRenameAndApplyLast(string kungfuName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(kungfuName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuRenameAndApplyLast_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003374, RefRangeEnd = 1003375, XrefRangeStart = 1003373, XrefRangeEnd = 1003374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionResearchNewKungfuDiscardLast()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuDiscardLast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003429, RefRangeEnd = 1003430, XrefRangeStart = 1003375, XrefRangeEnd = 1003429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionResearchNewKungfuDiscard(KungfuData kungfuData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionResearchNewKungfuDiscard_Private_Void_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003445, RefRangeEnd = 1003446, XrefRangeStart = 1003430, XrefRangeEnd = 1003445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionHumanResAddToMember(int instanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionHumanResAddToMember_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003450, RefRangeEnd = 1003451, XrefRangeStart = 1003446, XrefRangeEnd = 1003450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveHumanRes(int instanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveHumanRes_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003451, XrefRangeEnd = 1003464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveHumanRes(int instanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHumanRes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003478, RefRangeEnd = 1003479, XrefRangeStart = 1003464, XrefRangeEnd = 1003478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionHumanResRemoveFromMember(int instanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionHumanResRemoveFromMember_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1003526, RefRangeEnd = 1003528, XrefRangeStart = 1003479, XrefRangeEnd = 1003526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlgActionHumanResNew(int instanceId, bool refreshMoodAndHealth = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instanceId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshMoodAndHealth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActionHumanResNew_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1003562, RefRangeEnd = 1003565, XrefRangeStart = 1003528, XrefRangeEnd = 1003562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffAllMembersHp(Il2CppSystem.Decimal amount, bool byRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&amount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &byRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffAllMembersHp_Public_Void_Decimal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1003599, RefRangeEnd = 1003602, XrefRangeStart = 1003565, XrefRangeEnd = 1003599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffAllMembersEp(Il2CppSystem.Decimal amount, bool byRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&amount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &byRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffAllMembersEp_Public_Void_Decimal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003630, RefRangeEnd = 1003631, XrefRangeStart = 1003602, XrefRangeEnd = 1003630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffAllMembersMood(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffAllMembersMood_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003660, RefRangeEnd = 1003661, XrefRangeStart = 1003631, XrefRangeEnd = 1003660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuffAllProvincesStable(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuffAllProvincesStable_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003661, XrefRangeEnd = 1003662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void __ctor_b__97_0(CurrencyType type, long oldVal, long newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldVal;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__97_0_Private_Void_CurrencyType_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003662, XrefRangeEnd = 1003663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void __ctor_b__97_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__97_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnLoaded_b__98_0(CurrencyType type, long oldVal, long newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldVal;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnLoaded_b__98_0_Private_Void_CurrencyType_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnLoaded_b__98_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnLoaded_b__98_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003663, XrefRangeEnd = 1003667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _GetTruceResult_b__240_2(int province)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&province);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetTruceResult_b__240_2_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Dlc1FactionInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
