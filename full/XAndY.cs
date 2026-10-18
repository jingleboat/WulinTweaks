using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct XAndY
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	[FieldOffset(0)]
	public int x;

	[FieldOffset(4)]
	public int y;

	static XAndY()
	{
		Il2CppClassPointerStore<XAndY>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "XAndY");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XAndY>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XAndY>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XAndY>.NativeClassPtr, "y");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XAndY>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
