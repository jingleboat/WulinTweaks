using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class RenderingCustomizeManager : MonoSingleton<RenderingCustomizeManager>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RenderingCustomizeManager()
	{
		Il2CppClassPointerStore<RenderingCustomizeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "RenderingCustomizeManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingCustomizeManager>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingCustomizeManager>.NativeClassPtr, 100673368);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839075, XrefRangeEnd = 839081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderingCustomizeManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderingCustomizeManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RenderingCustomizeManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
