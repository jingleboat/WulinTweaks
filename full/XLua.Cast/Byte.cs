using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class Byte : Any<byte>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

	static Byte()
	{
		Il2CppClassPointerStore<Byte>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "Byte");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Byte>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Byte>.NativeClassPtr, 100665091);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703979, XrefRangeEnd = 703982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Byte(byte i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Byte>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Byte(IntPtr pointer)
		: base(pointer)
	{
	}
}
