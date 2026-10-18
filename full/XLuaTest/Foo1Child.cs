using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace XLuaTest;

public class Foo1Child : Foo1Parent
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Foo1Child()
	{
		Il2CppClassPointerStore<Foo1Child>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "Foo1Child");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Foo1Child>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foo1Child>.NativeClassPtr, 100665361);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Foo1Child()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Foo1Child>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Foo1Child(IntPtr pointer)
		: base(pointer)
	{
	}
}
