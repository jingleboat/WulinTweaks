using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class IModifierActionDoAction : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_DoAction_Public_Abstract_Virtual_New_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0;

	static IModifierActionDoAction()
	{
		Il2CppClassPointerStore<IModifierActionDoAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "IModifierActionDoAction");
		NativeMethodInfoPtr_DoAction_Public_Abstract_Virtual_New_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifierActionDoAction>.NativeClassPtr, 100671687);
	}

	[CallerCount(0)]
	public unsafe virtual void DoAction(ModifierAction action, GameCharacterInstance gameCharacterInstance, BuffInstance relateBuff, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateBuff);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &stage;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoAction_Public_Abstract_Virtual_New_Void_ModifierAction_GameCharacterInstance_BuffInstance_DynamicModifierActiveStage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IModifierActionDoAction(IntPtr pointer)
		: base(pointer)
	{
	}
}
