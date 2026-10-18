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

public static class DynamicModifierExt : Il2CppSystem.Object
{
	[ObfuscatedName("WuLin.DynamicModifierExt+<>c__DisplayClass2_0")]
	public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameCharacterInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_relateBuff;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DoCalculate_b__0_Internal_Decimal_String_0;

		public unsafe DynamicModifierSimpleEval self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicModifierSimpleEval>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicModifierSimpleEval));
			}
		}

		public unsafe GameCharacterInstance gameCharacterInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameCharacterInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameCharacterInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe BuffInstance relateBuff
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relateBuff);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relateBuff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance));
			}
		}

		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, "<>c__DisplayClass2_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "self");
			NativeFieldInfoPtr_gameCharacterInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "gameCharacterInstance");
			NativeFieldInfoPtr_relateBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "relateBuff");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100686426);
			NativeMethodInfoPtr__DoCalculate_b__0_Internal_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100686427);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790810, XrefRangeEnd = 790811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Decimal _DoCalculate_b__0(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DoCalculate_b__0_Internal_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass2_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowActiveInfo_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInfo_Public_Static_SimpleLocInfo_ModifierAction_GameCharacterInstance_BuffInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoCalculate_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvalConverter_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_BuffInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniqueCharaAndPropById_Public_Static_GameCharacterInstance_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterProp_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterNoRateProp_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountActor_Public_Static_Int32_DynamicModifierSimpleEval_BattleActor_ICollection_1_BattleActor_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleActor_Public_Static_BattleActor_DynamicModifierCharacter_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacter_Public_Static_GameCharacterInstance_DynamicModifierCharacter_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Static_Boolean_ModifierCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsStage_Public_Static_Boolean_ModifierElement_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAction_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoEval_Public_Static_Void_BuffModifier_GameCharacterInstance_BuffInstance_byref_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTrigger_Public_Static_Void_DynamicModifierGiveBonusAction_GameCharacterInstance_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateActorSummonEvent_Public_Static_Void_DynamicModifierSummonActorActionData_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyShield_Public_Static_DamageTransferResult_DamageTransfer_BattleActor_BattleActor_Int32_0;

	static DynamicModifierExt()
	{
		Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DynamicModifierExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr);
		NativeMethodInfoPtr_ShowActiveInfo_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671657);
		NativeMethodInfoPtr_GetActiveInfo_Public_Static_SimpleLocInfo_ModifierAction_GameCharacterInstance_BuffInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671658);
		NativeMethodInfoPtr_DoCalculate_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671659);
		NativeMethodInfoPtr_EvalConverter_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_BuffInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671660);
		NativeMethodInfoPtr_GetUniqueCharaAndPropById_Public_Static_GameCharacterInstance_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671661);
		NativeMethodInfoPtr_GetCharacterProp_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671662);
		NativeMethodInfoPtr_GetCharacterNoRateProp_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671663);
		NativeMethodInfoPtr_CountActor_Public_Static_Int32_DynamicModifierSimpleEval_BattleActor_ICollection_1_BattleActor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671664);
		NativeMethodInfoPtr_GetBattleActor_Public_Static_BattleActor_DynamicModifierCharacter_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671665);
		NativeMethodInfoPtr_GetCharacter_Public_Static_GameCharacterInstance_DynamicModifierCharacter_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671666);
		NativeMethodInfoPtr_Check_Public_Static_Boolean_ModifierCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671667);
		NativeMethodInfoPtr_IsStage_Public_Static_Boolean_ModifierElement_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671668);
		NativeMethodInfoPtr_DoAction_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671669);
		NativeMethodInfoPtr_DoEval_Public_Static_Void_BuffModifier_GameCharacterInstance_BuffInstance_byref_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671670);
		NativeMethodInfoPtr_OnTrigger_Public_Static_Void_DynamicModifierGiveBonusAction_GameCharacterInstance_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671671);
		NativeMethodInfoPtr_GenerateActorSummonEvent_Public_Static_Void_DynamicModifierSummonActorActionData_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671672);
		NativeMethodInfoPtr_ApplyShield_Public_Static_DamageTransferResult_DamageTransfer_BattleActor_BattleActor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierExt>.NativeClassPtr, 100671673);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 790828, RefRangeEnd = 790832, XrefRangeStart = 790811, XrefRangeEnd = 790828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowActiveInfo(this ModifierAction self, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowActiveInfo_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 790846, RefRangeEnd = 790848, XrefRangeStart = 790832, XrefRangeEnd = 790846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameLogManager.SimpleLocInfo GetActiveInfo(this ModifierAction self, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInfo_Public_Static_SimpleLocInfo_ModifierAction_GameCharacterInstance_BuffInstance_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new GameLogManager.SimpleLocInfo(pointer);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 790868, RefRangeEnd = 790875, XrefRangeStart = 790848, XrefRangeEnd = 790868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Decimal DoCalculate(this DynamicModifierSimpleEval self, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoCalculate_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_BuffInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 791308, RefRangeEnd = 791309, XrefRangeStart = 790875, XrefRangeEnd = 791308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Decimal EvalConverter(this DynamicModifierSimpleEval self, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvalConverter_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_BuffInstance_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 791321, RefRangeEnd = 791324, XrefRangeStart = 791309, XrefRangeEnd = 791321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameCharacterInstance GetUniqueCharaAndPropById(string raw, ref string prop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(raw);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(prop);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniqueCharaAndPropById_Public_Static_GameCharacterInstance_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		prop = IL2CPP.Il2CppStringToManaged(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 791330, RefRangeEnd = 791332, XrefRangeStart = 791324, XrefRangeEnd = 791330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Decimal GetCharacterProp(this DynamicModifierSimpleEval self, GameCharacterInstance gameCharacterInstance, string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterProp_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 791338, RefRangeEnd = 791340, XrefRangeStart = 791332, XrefRangeEnd = 791338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Decimal GetCharacterNoRateProp(this DynamicModifierSimpleEval self, GameCharacterInstance gameCharacterInstance, string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterNoRateProp_Public_Static_Decimal_DynamicModifierSimpleEval_GameCharacterInstance_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791340, XrefRangeEnd = 791453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CountActor(this DynamicModifierSimpleEval self, BattleActor selfActor, ICollection<BattleActor> collections, string condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selfActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collections);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(condition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountActor_Public_Static_Int32_DynamicModifierSimpleEval_BattleActor_ICollection_1_BattleActor_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 791460, RefRangeEnd = 791468, XrefRangeStart = 791453, XrefRangeEnd = 791460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BattleActor GetBattleActor(this DynamicModifierCharacter self, GameCharacterInstance owner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBattleActor_Public_Static_BattleActor_DynamicModifierCharacter_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 791479, RefRangeEnd = 791484, XrefRangeStart = 791468, XrefRangeEnd = 791479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameCharacterInstance GetCharacter(this DynamicModifierCharacter self, GameCharacterInstance owner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacter_Public_Static_GameCharacterInstance_DynamicModifierCharacter_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791484, XrefRangeEnd = 791488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Check(this ModifierCondition condition, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Static_Boolean_ModifierCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791488, XrefRangeEnd = 791492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsStage(this ModifierElement element, DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStage_Public_Static_Boolean_ModifierElement_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 791496, RefRangeEnd = 791498, XrefRangeStart = 791492, XrefRangeEnd = 791496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoAction(this ModifierAction action, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAction_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 791514, RefRangeEnd = 791515, XrefRangeStart = 791498, XrefRangeEnd = 791514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoEval(this DynamicModifierModifyBuffAction.BuffModifier buffModifier, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, ref Il2CppStructArray<Il2CppSystem.Decimal> buffValues)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffModifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffValues);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoEval_Public_Static_Void_BuffModifier_GameCharacterInstance_BuffInstance_byref_Il2CppStructArray_1_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		buffValues = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Il2CppSystem.Decimal>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 791543, RefRangeEnd = 791544, XrefRangeStart = 791515, XrefRangeEnd = 791543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnTrigger(this DynamicModifierGiveBonusAction action, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTrigger_Public_Static_Void_DynamicModifierGiveBonusAction_GameCharacterInstance_BuffInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 791687, RefRangeEnd = 791688, XrefRangeStart = 791544, XrefRangeEnd = 791687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenerateActorSummonEvent(this DynamicModifierSummonActorAction.DynamicModifierSummonActorActionData self, BattleActor battleActor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateActorSummonEvent_Public_Static_Void_DynamicModifierSummonActorActionData_BattleActor_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 791795, RefRangeEnd = 791796, XrefRangeStart = 791688, XrefRangeEnd = 791795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BattleActor.DamageTransferResult ApplyShield(this DamageTransfer self, BattleActor dealerActor, BattleActor targetActor, int originDamage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dealerActor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetActor);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &originDamage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyShield_Public_Static_DamageTransferResult_DamageTransfer_BattleActor_BattleActor_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BattleActor.DamageTransferResult(pointer);
	}

	public DynamicModifierExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
