using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.GameFrameworks;

public class PoolTag_UIModItemShop : PoolAnalysis
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PoolTag_UIModItemShop()
	{
		Il2CppClassPointerStore<PoolTag_UIModItemShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.GameFrameworks", "PoolTag_UIModItemShop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolTag_UIModItemShop>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolTag_UIModItemShop>.NativeClassPtr, 100680743);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030821, XrefRangeEnd = 1030829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolTag_UIModItemShop()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolTag_UIModItemShop>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PoolTag_UIModItemShop(IntPtr pointer)
		: base(pointer)
	{
	}
}
