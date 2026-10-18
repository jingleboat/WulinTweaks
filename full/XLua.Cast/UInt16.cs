using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class UInt16 : Any<ushort>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

	static UInt16()
	{
		Il2CppClassPointerStore<UInt16>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "UInt16");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UInt16>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt16>.NativeClassPtr, 100665095);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703991, XrefRangeEnd = 703994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UInt16(ushort i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UInt16>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UInt16(IntPtr pointer)
		: base(pointer)
	{
	}
}
