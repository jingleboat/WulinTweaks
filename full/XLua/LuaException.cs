using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua;

[System.Serializable]
public class LuaException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static LuaException()
	{
		Il2CppClassPointerStore<LuaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "LuaException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaException>.NativeClassPtr, 100664799);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 696350, RefRangeEnd = 696352, XrefRangeStart = 696346, XrefRangeEnd = 696350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LuaException(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LuaException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
