using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class Int64 : Any<long>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

	static Int64()
	{
		Il2CppClassPointerStore<Int64>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "Int64");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int64>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64>.NativeClassPtr, 100665098);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704000, XrefRangeEnd = 704003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int64(long i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int64>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Int64(IntPtr pointer)
		: base(pointer)
	{
	}
}
