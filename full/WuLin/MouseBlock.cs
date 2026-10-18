using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class MouseBlock : UiSingletonPrefab<MouseBlock>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static MouseBlock()
	{
		Il2CppClassPointerStore<MouseBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MouseBlock");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseBlock>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBlock>.NativeClassPtr, 100675836);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 908855, XrefRangeEnd = 908861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MouseBlock()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseBlock>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MouseBlock(IntPtr pointer)
		: base(pointer)
	{
	}
}
