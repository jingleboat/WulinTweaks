using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin.StateMachine;

public static class SlgStoryConditionDelegate : Il2CppSystem.Object
{
	[ObfuscatedName("WuLin.StateMachine.SlgStoryConditionDelegate+<>c__DisplayClass14_0")]
	public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_playerFaction;

		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RelationCountConditionCheckAllConnectNode_b__0_Internal_Boolean_KeyValuePair_2_Int32_Dlc1FactionInstance_0;

		public unsafe int playerFaction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFaction);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFaction)) = num;
			}
		}

		public unsafe RelationCountCondition self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RelationCountCondition>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relationCountCondition));
			}
		}

		static __c__DisplayClass14_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, "<>c__DisplayClass14_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr);
			NativeFieldInfoPtr_playerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, "playerFaction");
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100689030);
			NativeMethodInfoPtr__RelationCountConditionCheckAllConnectNode_b__0_Internal_Boolean_KeyValuePair_2_Int32_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100689031);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass14_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041839, XrefRangeEnd = 1041840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RelationCountConditionCheckAllConnectNode_b__0(KeyValuePair<int, Dlc1FactionInstance> a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RelationCountConditionCheckAllConnectNode_b__0_Internal_Boolean_KeyValuePair_2_Int32_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass14_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTagNumConditionCheckAllConnectNode_Private_Static_Boolean_CheckTagNumCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTagNumConditionCheckExtra_Private_Static_Boolean_CheckTagNumCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTagNumConditionCompareValue_Private_Static_Boolean_CheckTagNumCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgMainUIConditionCheckAllConnectNode_Private_Static_Boolean_SlgMainUICondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionDeadByPlayerConditionCheckExtra_Private_Static_Boolean_FactionDeadByPlayerCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionDeadByPlayerConditionCheckAllConnectNode_Private_Static_Boolean_FactionDeadByPlayerCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgHaveItemInBagConditionCheckExtra_Private_Static_Boolean_SlgHaveItemInBagCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgHaveItemInBagConditionCheckAllConnectNode_Private_Static_Boolean_SlgHaveItemInBagCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionFameConditionCheckExtra_Private_Static_Boolean_SlgFactionFameCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionFameConditionCheckAllConnectNode_Private_Static_Boolean_SlgFactionFameCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GuardLevelConditionCheckExtra_Private_Static_Boolean_GuardLevelCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrencyConditionCheckExtra_Private_Static_Boolean_CurrencyCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgHavePartnerConditionCheckAllConnectNode_Private_Static_Boolean_SlgHavePartnerCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelationCountConditionCheckAllConnectNode_Private_Static_Boolean_RelationCountCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareValue_Private_Static_Boolean_Int32_Int32_CompareType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgHavePartnerConditionCheckExtra_Private_Static_Boolean_SlgHavePartnerCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionKungfuConditionCheckAllConnectNode_Private_Static_Boolean_FactionKungfuCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionKungfuConditionCheckExtra_Private_Static_Boolean_FactionKungfuCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionAliveConditionCheckAllConnectNode_Private_Static_Boolean_FactionAliveCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveFactionConditionCheckAllConnectNode_Private_Static_Boolean_SlgHaveFactionCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStringConditionCheckExtra_Private_Static_Boolean_CheckStringCondition_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStringConditionCheckAllConnectNode_Private_Static_Boolean_CheckStringCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrencyConditionCheckAllConnectNode_Private_Static_Boolean_CurrencyCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnConditionCheckAllConnectNode_Private_Static_Boolean_TurnCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TechUnlockConditionCheckAllConnectNode_Private_Static_Boolean_TechUnlockCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProvinceConditionCheckAllConnectNode_Private_Static_Boolean_ProvinceCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProvinceCountConditionCheckAllConnectNode_Private_Static_Boolean_ProvinceCountCondition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GuardLevelConditionCheckAllConnectNode_Private_Static_Boolean_GuardLevelCondition_0;

	static SlgStoryConditionDelegate()
	{
		Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "SlgStoryConditionDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681222);
		NativeMethodInfoPtr_CheckTagNumConditionCheckAllConnectNode_Private_Static_Boolean_CheckTagNumCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681223);
		NativeMethodInfoPtr_CheckTagNumConditionCheckExtra_Private_Static_Boolean_CheckTagNumCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681224);
		NativeMethodInfoPtr_CheckTagNumConditionCompareValue_Private_Static_Boolean_CheckTagNumCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681225);
		NativeMethodInfoPtr_SlgMainUIConditionCheckAllConnectNode_Private_Static_Boolean_SlgMainUICondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681226);
		NativeMethodInfoPtr_FactionDeadByPlayerConditionCheckExtra_Private_Static_Boolean_FactionDeadByPlayerCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681227);
		NativeMethodInfoPtr_FactionDeadByPlayerConditionCheckAllConnectNode_Private_Static_Boolean_FactionDeadByPlayerCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681228);
		NativeMethodInfoPtr_SlgHaveItemInBagConditionCheckExtra_Private_Static_Boolean_SlgHaveItemInBagCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681229);
		NativeMethodInfoPtr_SlgHaveItemInBagConditionCheckAllConnectNode_Private_Static_Boolean_SlgHaveItemInBagCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681230);
		NativeMethodInfoPtr_FactionFameConditionCheckExtra_Private_Static_Boolean_SlgFactionFameCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681231);
		NativeMethodInfoPtr_FactionFameConditionCheckAllConnectNode_Private_Static_Boolean_SlgFactionFameCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681232);
		NativeMethodInfoPtr_GuardLevelConditionCheckExtra_Private_Static_Boolean_GuardLevelCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681233);
		NativeMethodInfoPtr_CurrencyConditionCheckExtra_Private_Static_Boolean_CurrencyCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681234);
		NativeMethodInfoPtr_SlgHavePartnerConditionCheckAllConnectNode_Private_Static_Boolean_SlgHavePartnerCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681235);
		NativeMethodInfoPtr_RelationCountConditionCheckAllConnectNode_Private_Static_Boolean_RelationCountCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681236);
		NativeMethodInfoPtr_CompareValue_Private_Static_Boolean_Int32_Int32_CompareType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681237);
		NativeMethodInfoPtr_SlgHavePartnerConditionCheckExtra_Private_Static_Boolean_SlgHavePartnerCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681238);
		NativeMethodInfoPtr_FactionKungfuConditionCheckAllConnectNode_Private_Static_Boolean_FactionKungfuCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681239);
		NativeMethodInfoPtr_FactionKungfuConditionCheckExtra_Private_Static_Boolean_FactionKungfuCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681240);
		NativeMethodInfoPtr_FactionAliveConditionCheckAllConnectNode_Private_Static_Boolean_FactionAliveCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681241);
		NativeMethodInfoPtr_HaveFactionConditionCheckAllConnectNode_Private_Static_Boolean_SlgHaveFactionCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681242);
		NativeMethodInfoPtr_CheckStringConditionCheckExtra_Private_Static_Boolean_CheckStringCondition_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681243);
		NativeMethodInfoPtr_CheckStringConditionCheckAllConnectNode_Private_Static_Boolean_CheckStringCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681244);
		NativeMethodInfoPtr_CurrencyConditionCheckAllConnectNode_Private_Static_Boolean_CurrencyCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681245);
		NativeMethodInfoPtr_TurnConditionCheckAllConnectNode_Private_Static_Boolean_TurnCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681246);
		NativeMethodInfoPtr_TechUnlockConditionCheckAllConnectNode_Private_Static_Boolean_TechUnlockCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681247);
		NativeMethodInfoPtr_ProvinceConditionCheckAllConnectNode_Private_Static_Boolean_ProvinceCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681248);
		NativeMethodInfoPtr_ProvinceCountConditionCheckAllConnectNode_Private_Static_Boolean_ProvinceCountCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681249);
		NativeMethodInfoPtr_GuardLevelConditionCheckAllConnectNode_Private_Static_Boolean_GuardLevelCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryConditionDelegate>.NativeClassPtr, 100681250);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1041989, RefRangeEnd = 1041990, XrefRangeStart = 1041840, XrefRangeEnd = 1041989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041990, XrefRangeEnd = 1041999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckTagNumConditionCheckAllConnectNode(CheckTagNumCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTagNumConditionCheckAllConnectNode_Private_Static_Boolean_CheckTagNumCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041999, XrefRangeEnd = 1042002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckTagNumConditionCheckExtra(CheckTagNumCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTagNumConditionCheckExtra_Private_Static_Boolean_CheckTagNumCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042002, XrefRangeEnd = 1042011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckTagNumConditionCompareValue(CheckTagNumCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTagNumConditionCompareValue_Private_Static_Boolean_CheckTagNumCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042011, XrefRangeEnd = 1042018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SlgMainUIConditionCheckAllConnectNode(SlgMainUICondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgMainUIConditionCheckAllConnectNode_Private_Static_Boolean_SlgMainUICondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042018, XrefRangeEnd = 1042022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionDeadByPlayerConditionCheckExtra(FactionDeadByPlayerCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionDeadByPlayerConditionCheckExtra_Private_Static_Boolean_FactionDeadByPlayerCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042022, XrefRangeEnd = 1042036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionDeadByPlayerConditionCheckAllConnectNode(FactionDeadByPlayerCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionDeadByPlayerConditionCheckAllConnectNode_Private_Static_Boolean_FactionDeadByPlayerCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042036, XrefRangeEnd = 1042040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SlgHaveItemInBagConditionCheckExtra(SlgHaveItemInBagCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgHaveItemInBagConditionCheckExtra_Private_Static_Boolean_SlgHaveItemInBagCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042040, XrefRangeEnd = 1042048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SlgHaveItemInBagConditionCheckAllConnectNode(SlgHaveItemInBagCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgHaveItemInBagConditionCheckAllConnectNode_Private_Static_Boolean_SlgHaveItemInBagCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042048, XrefRangeEnd = 1042051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionFameConditionCheckExtra(SlgFactionFameCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionFameConditionCheckExtra_Private_Static_Boolean_SlgFactionFameCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042051, XrefRangeEnd = 1042066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionFameConditionCheckAllConnectNode(SlgFactionFameCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionFameConditionCheckAllConnectNode_Private_Static_Boolean_SlgFactionFameCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042066, XrefRangeEnd = 1042072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GuardLevelConditionCheckExtra(GuardLevelCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GuardLevelConditionCheckExtra_Private_Static_Boolean_GuardLevelCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042072, XrefRangeEnd = 1042077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CurrencyConditionCheckExtra(CurrencyCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrencyConditionCheckExtra_Private_Static_Boolean_CurrencyCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042077, XrefRangeEnd = 1042093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SlgHavePartnerConditionCheckAllConnectNode(SlgHavePartnerCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgHavePartnerConditionCheckAllConnectNode_Private_Static_Boolean_SlgHavePartnerCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042093, XrefRangeEnd = 1042121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RelationCountConditionCheckAllConnectNode(RelationCountCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelationCountConditionCheckAllConnectNode_Private_Static_Boolean_RelationCountCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool CompareValue(int checkValue, int targetValue, CheckTagNumCondition.CompareType compareType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&checkValue);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetValue;
		*(CheckTagNumCondition.CompareType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &compareType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareValue_Private_Static_Boolean_Int32_Int32_CompareType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042121, XrefRangeEnd = 1042124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SlgHavePartnerConditionCheckExtra(SlgHavePartnerCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgHavePartnerConditionCheckExtra_Private_Static_Boolean_SlgHavePartnerCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042124, XrefRangeEnd = 1042147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionKungfuConditionCheckAllConnectNode(FactionKungfuCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionKungfuConditionCheckAllConnectNode_Private_Static_Boolean_FactionKungfuCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042147, XrefRangeEnd = 1042152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionKungfuConditionCheckExtra(FactionKungfuCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionKungfuConditionCheckExtra_Private_Static_Boolean_FactionKungfuCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042152, XrefRangeEnd = 1042186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FactionAliveConditionCheckAllConnectNode(FactionAliveCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionAliveConditionCheckAllConnectNode_Private_Static_Boolean_FactionAliveCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042186, XrefRangeEnd = 1042193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HaveFactionConditionCheckAllConnectNode(SlgHaveFactionCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveFactionConditionCheckAllConnectNode_Private_Static_Boolean_SlgHaveFactionCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042193, XrefRangeEnd = 1042198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckStringConditionCheckExtra(CheckStringCondition self, Il2CppReferenceArray<Il2CppSystem.Object> extra)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extra);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStringConditionCheckExtra_Private_Static_Boolean_CheckStringCondition_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042198, XrefRangeEnd = 1042205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckStringConditionCheckAllConnectNode(CheckStringCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStringConditionCheckAllConnectNode_Private_Static_Boolean_CheckStringCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042205, XrefRangeEnd = 1042213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CurrencyConditionCheckAllConnectNode(CurrencyCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrencyConditionCheckAllConnectNode_Private_Static_Boolean_CurrencyCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042213, XrefRangeEnd = 1042220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TurnConditionCheckAllConnectNode(TurnCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnConditionCheckAllConnectNode_Private_Static_Boolean_TurnCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042220, XrefRangeEnd = 1042230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TechUnlockConditionCheckAllConnectNode(TechUnlockCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TechUnlockConditionCheckAllConnectNode_Private_Static_Boolean_TechUnlockCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042230, XrefRangeEnd = 1042248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProvinceConditionCheckAllConnectNode(ProvinceCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProvinceConditionCheckAllConnectNode_Private_Static_Boolean_ProvinceCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042248, XrefRangeEnd = 1042264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProvinceCountConditionCheckAllConnectNode(ProvinceCountCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProvinceCountConditionCheckAllConnectNode_Private_Static_Boolean_ProvinceCountCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042264, XrefRangeEnd = 1042292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GuardLevelConditionCheckAllConnectNode(GuardLevelCondition self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GuardLevelConditionCheckAllConnectNode_Private_Static_Boolean_GuardLevelCondition_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public SlgStoryConditionDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
