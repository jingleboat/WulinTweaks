using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Doozy.Engine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct RangedFloat
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MinValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxValue;

	[FieldOffset(0)]
	public float MinValue;

	[FieldOffset(4)]
	public float MaxValue;

	static RangedFloat()
	{
		Il2CppClassPointerStore<RangedFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine", "RangedFloat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangedFloat>.NativeClassPtr);
		NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangedFloat>.NativeClassPtr, "MinValue");
		NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangedFloat>.NativeClassPtr, "MaxValue");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangedFloat>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
