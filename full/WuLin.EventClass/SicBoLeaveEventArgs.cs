using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace WuLin.EventClass;

[StructLayout(LayoutKind.Explicit)]
public struct SicBoLeaveEventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EndType;

	[FieldOffset(0)]
	public SicBoEndType EndType;

	static SicBoLeaveEventArgs()
	{
		Il2CppClassPointerStore<SicBoLeaveEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.EventClass", "SicBoLeaveEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SicBoLeaveEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_EndType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SicBoLeaveEventArgs>.NativeClassPtr, "EndType");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SicBoLeaveEventArgs>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
