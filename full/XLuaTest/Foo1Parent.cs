using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLuaTest;

public class Foo1Parent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Foo1Parent()
	{
		Il2CppClassPointerStore<Foo1Parent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "Foo1Parent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Foo1Parent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foo1Parent>.NativeClassPtr, 100665359);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Foo1Parent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Foo1Parent>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Foo1Parent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
