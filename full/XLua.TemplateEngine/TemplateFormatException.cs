using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua.TemplateEngine;

public class TemplateFormatException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static TemplateFormatException()
	{
		Il2CppClassPointerStore<TemplateFormatException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.TemplateEngine", "TemplateFormatException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateFormatException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateFormatException>.NativeClassPtr, 100665072);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703508, XrefRangeEnd = 703512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TemplateFormatException(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateFormatException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TemplateFormatException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
