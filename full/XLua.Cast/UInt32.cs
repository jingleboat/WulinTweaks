using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class UInt32 : Any<uint>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

	static UInt32()
	{
		Il2CppClassPointerStore<UInt32>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "UInt32");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UInt32>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt32>.NativeClassPtr, 100665097);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703997, XrefRangeEnd = 704000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UInt32(uint i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UInt32>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UInt32(IntPtr pointer)
		: base(pointer)
	{
	}
}
