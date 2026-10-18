using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XLuaTest;

[StructLayout(LayoutKind.Explicit)]
public struct Pedding
{
	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	[FieldOffset(0)]
	public byte c;

	static Pedding()
	{
		Il2CppClassPointerStore<Pedding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "Pedding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pedding>.NativeClassPtr);
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pedding>.NativeClassPtr, "c");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pedding>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
