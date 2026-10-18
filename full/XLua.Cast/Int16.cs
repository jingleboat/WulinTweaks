using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class Int16 : Any<short>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

	static Int16()
	{
		Il2CppClassPointerStore<Int16>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "Int16");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int16>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int16>.NativeClassPtr, 100665094);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703988, XrefRangeEnd = 703991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int16(short i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int16>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Int16(IntPtr pointer)
		: base(pointer)
	{
	}
}
