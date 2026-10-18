using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class SByte : Any<sbyte>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_0;

	static SByte()
	{
		Il2CppClassPointerStore<SByte>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "SByte");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SByte>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByte>.NativeClassPtr, 100665092);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703982, XrefRangeEnd = 703985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SByte(sbyte i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByte>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SByte(IntPtr pointer)
		: base(pointer)
	{
	}
}
