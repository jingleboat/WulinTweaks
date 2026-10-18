using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace SoftMasking;

public class GlobalMaterialReplacerAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static GlobalMaterialReplacerAttribute()
	{
		Il2CppClassPointerStore<GlobalMaterialReplacerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SoftMasking", "GlobalMaterialReplacerAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMaterialReplacerAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMaterialReplacerAttribute>.NativeClassPtr, 100665496);
	}

	[CallerCount(458)]
	[CachedScanResults(RefRangeStart = 26910, RefRangeEnd = 27368, XrefRangeStart = 26910, XrefRangeEnd = 27368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalMaterialReplacerAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalMaterialReplacerAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GlobalMaterialReplacerAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
