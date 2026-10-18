using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class BattleActorCheckTempPropCondition_Check : AModifierConditionCheck<BattleActorCheckTempPropCondition>
{
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Boolean_BattleActorCheckTempPropCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BattleActorCheckTempPropCondition_Check()
	{
		Il2CppClassPointerStore<BattleActorCheckTempPropCondition_Check>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActorCheckTempPropCondition_Check");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorCheckTempPropCondition_Check>.NativeClassPtr);
		NativeMethodInfoPtr_Run_Public_Virtual_Boolean_BattleActorCheckTempPropCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorCheckTempPropCondition_Check>.NativeClassPtr, 100671758);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorCheckTempPropCondition_Check>.NativeClassPtr, 100671759);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793041, XrefRangeEnd = 793047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Run(BattleActorCheckTempPropCondition condition, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)condition);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &stage;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Run_Public_Virtual_Boolean_BattleActorCheckTempPropCondition_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793047, XrefRangeEnd = 793050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorCheckTempPropCondition_Check()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorCheckTempPropCondition_Check>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleActorCheckTempPropCondition_Check(IntPtr pointer)
		: base(pointer)
	{
	}
}
