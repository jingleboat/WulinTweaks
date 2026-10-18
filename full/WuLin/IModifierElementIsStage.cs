using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class IModifierElementIsStage : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsStage_Public_Abstract_Virtual_New_Boolean_ModifierElement_DynamicModifierActiveStage_0;

	static IModifierElementIsStage()
	{
		Il2CppClassPointerStore<IModifierElementIsStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "IModifierElementIsStage");
		NativeMethodInfoPtr_IsStage_Public_Abstract_Virtual_New_Boolean_ModifierElement_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifierElementIsStage>.NativeClassPtr, 100671695);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsStage(ModifierElement element, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &stage;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsStage_Public_Abstract_Virtual_New_Boolean_ModifierElement_DynamicModifierActiveStage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IModifierElementIsStage(IntPtr pointer)
		: base(pointer)
	{
	}
}
