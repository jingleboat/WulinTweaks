using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.UI;

public static class ButtonExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractive_Public_Static_Void_Button_Boolean_0;

	static ButtonExt()
	{
		Il2CppClassPointerStore<ButtonExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ButtonExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonExt>.NativeClassPtr);
		NativeMethodInfoPtr_SetInteractive_Public_Static_Void_Button_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonExt>.NativeClassPtr, 100663954);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 673889, RefRangeEnd = 673890, XrefRangeStart = 673879, XrefRangeEnd = 673889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInteractive(this Button self, bool active)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &active;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInteractive_Public_Static_Void_Button_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ButtonExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
