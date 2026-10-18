using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct UIItemData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PosId;

	[FieldOffset(0)]
	public int PosId;

	static UIItemData()
	{
		Il2CppClassPointerStore<UIItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIItemData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIItemData>.NativeClassPtr);
		NativeFieldInfoPtr_PosId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIItemData>.NativeClassPtr, "PosId");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIItemData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
