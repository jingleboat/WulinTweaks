using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace WuLin.EventClass;

[StructLayout(LayoutKind.Explicit)]
public struct AuctionLeaveEventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EndType;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEntered;

	[FieldOffset(0)]
	public AuctionEndType EndType;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsEntered;

	static AuctionLeaveEventArgs()
	{
		Il2CppClassPointerStore<AuctionLeaveEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.EventClass", "AuctionLeaveEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuctionLeaveEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_EndType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionLeaveEventArgs>.NativeClassPtr, "EndType");
		NativeFieldInfoPtr_IsEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionLeaveEventArgs>.NativeClassPtr, "IsEntered");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AuctionLeaveEventArgs>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
