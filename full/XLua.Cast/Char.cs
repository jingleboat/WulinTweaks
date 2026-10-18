using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLua.Cast;

public class Char : Any<char>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_0;

	static Char()
	{
		Il2CppClassPointerStore<Char>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.Cast", "Char");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Char>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100665093);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703985, XrefRangeEnd = 703988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Char(char i)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Char>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Char(IntPtr pointer)
		: base(pointer)
	{
	}
}
