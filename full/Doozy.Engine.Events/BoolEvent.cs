using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

namespace Doozy.Engine.Events;

[Serializable]
public class BoolEvent : UnityEvent<bool>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BoolEvent()
	{
		Il2CppClassPointerStore<BoolEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Events", "BoolEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEvent>.NativeClassPtr, 100669334);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 750211, RefRangeEnd = 750212, XrefRangeStart = 750208, XrefRangeEnd = 750211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoolEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BoolEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
