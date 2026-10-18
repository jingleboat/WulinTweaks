using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public static class DynamicModifierHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_modifierConditionCheckActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifierElementIsStageActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifierActionDoActionActions;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetModifier_Public_Static_DynamicModifier_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckModifierCondition_Public_Static_Boolean_ModifierCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifierElementIsStage_Public_Static_Boolean_ModifierElement_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifierActionDoAction_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	public unsafe static Dictionary<Il2CppSystem.Type, IModifierConditionCheck> modifierConditionCheckActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_modifierConditionCheckActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, IModifierConditionCheck>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_modifierConditionCheckActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, IModifierElementIsStage> modifierElementIsStageActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_modifierElementIsStageActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, IModifierElementIsStage>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_modifierElementIsStageActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, IModifierActionDoAction> modifierActionDoActionActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_modifierActionDoActionActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, IModifierActionDoAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_modifierActionDoActionActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static DynamicModifierHelper()
	{
		Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DynamicModifierHelper");
		NativeFieldInfoPtr_modifierConditionCheckActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, "modifierConditionCheckActions");
		NativeFieldInfoPtr_modifierElementIsStageActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, "modifierElementIsStageActions");
		NativeFieldInfoPtr_modifierActionDoActionActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, "modifierActionDoActionActions");
		NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, 100671682);
		NativeMethodInfoPtr_GetModifier_Public_Static_DynamicModifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, 100671683);
		NativeMethodInfoPtr_CheckModifierCondition_Public_Static_Boolean_ModifierCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, 100671684);
		NativeMethodInfoPtr_ModifierElementIsStage_Public_Static_Boolean_ModifierElement_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, 100671685);
		NativeMethodInfoPtr_ModifierActionDoAction_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierHelper>.NativeClassPtr, 100671686);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791908, XrefRangeEnd = 792085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 792138, RefRangeEnd = 792144, XrefRangeStart = 792085, XrefRangeEnd = 792138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DynamicModifier GetModifier(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetModifier_Public_Static_DynamicModifier_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicModifier>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 792157, RefRangeEnd = 792159, XrefRangeStart = 792144, XrefRangeEnd = 792157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckModifierCondition(ModifierCondition condition, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckModifierCondition_Public_Static_Boolean_ModifierCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 792193, RefRangeEnd = 792194, XrefRangeStart = 792159, XrefRangeEnd = 792193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ModifierElementIsStage(ModifierElement element, DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifierElementIsStage_Public_Static_Boolean_ModifierElement_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 792207, RefRangeEnd = 792208, XrefRangeStart = 792194, XrefRangeEnd = 792207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ModifierActionDoAction(ModifierAction action, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifierActionDoAction_Public_Static_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DynamicModifierHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
