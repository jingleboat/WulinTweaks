using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

namespace Doozy.Engine.Events;

[Serializable]
public class StringEvent : UnityEvent<string>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StringEvent()
	{
		Il2CppClassPointerStore<StringEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Events", "StringEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEvent>.NativeClassPtr, 100669336);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 750218, RefRangeEnd = 750219, XrefRangeStart = 750215, XrefRangeEnd = 750218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StringEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StringEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
