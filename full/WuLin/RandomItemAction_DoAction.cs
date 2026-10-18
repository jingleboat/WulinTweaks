using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class RandomItemAction_DoAction : AModifierActionDoAction<RandomItemAction>
{
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_RandomItemAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RandomItemAction_DoAction()
	{
		Il2CppClassPointerStore<RandomItemAction_DoAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "RandomItemAction_DoAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomItemAction_DoAction>.NativeClassPtr);
		NativeMethodInfoPtr_Run_Public_Virtual_Void_RandomItemAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomItemAction_DoAction>.NativeClassPtr, 100671711);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomItemAction_DoAction>.NativeClassPtr, 100671712);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792447, XrefRangeEnd = 792497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Run(RandomItemAction action, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &stage;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Run_Public_Virtual_Void_RandomItemAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792497, XrefRangeEnd = 792500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RandomItemAction_DoAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomItemAction_DoAction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RandomItemAction_DoAction(IntPtr pointer)
		: base(pointer)
	{
	}
}
