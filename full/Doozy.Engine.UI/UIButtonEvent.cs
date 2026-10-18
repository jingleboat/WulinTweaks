using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

namespace Doozy.Engine.UI;

[Serializable]
public class UIButtonEvent : UnityEvent<UIButton>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static UIButtonEvent()
	{
		Il2CppClassPointerStore<UIButtonEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIButtonEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonEvent>.NativeClassPtr, 100667572);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729653, XrefRangeEnd = 729656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIButtonEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
