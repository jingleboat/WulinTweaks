using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class DynamicModifierMingDingAction_DoAction : AModifierActionDoAction<DynamicModifierMingDingAction>
{
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_DynamicModifierMingDingAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DynamicModifierMingDingAction_DoAction()
	{
		Il2CppClassPointerStore<DynamicModifierMingDingAction_DoAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DynamicModifierMingDingAction_DoAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicModifierMingDingAction_DoAction>.NativeClassPtr);
		NativeMethodInfoPtr_Run_Public_Virtual_Void_DynamicModifierMingDingAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierMingDingAction_DoAction>.NativeClassPtr, 100671727);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierMingDingAction_DoAction>.NativeClassPtr, 100671728);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792655, XrefRangeEnd = 792702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Run(DynamicModifierMingDingAction action, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &stage;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Run_Public_Virtual_Void_DynamicModifierMingDingAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792702, XrefRangeEnd = 792705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicModifierMingDingAction_DoAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicModifierMingDingAction_DoAction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DynamicModifierMingDingAction_DoAction(IntPtr pointer)
		: base(pointer)
	{
	}
}
