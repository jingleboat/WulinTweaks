using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XLuaTest;

[StructLayout(LayoutKind.Explicit)]
public struct MyStruct
{
	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_e;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	[FieldOffset(0)]
	public int a;

	[FieldOffset(4)]
	public int b;

	[FieldOffset(8)]
	public Il2CppSystem.Decimal c;

	[FieldOffset(24)]
	public Pedding e;

	static MyStruct()
	{
		Il2CppClassPointerStore<MyStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "MyStruct");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyStruct>.NativeClassPtr);
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyStruct>.NativeClassPtr, "a");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyStruct>.NativeClassPtr, "b");
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyStruct>.NativeClassPtr, "c");
		NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyStruct>.NativeClassPtr, "e");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyStruct>.NativeClassPtr, 100665258);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 705599, RefRangeEnd = 705602, XrefRangeStart = 705595, XrefRangeEnd = 705599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyStruct(int p1, int p2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MyStruct>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
