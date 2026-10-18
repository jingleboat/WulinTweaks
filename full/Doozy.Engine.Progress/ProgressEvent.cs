using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

namespace Doozy.Engine.Progress;

[Serializable]
public class ProgressEvent : UnityEvent<float>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ProgressEvent()
	{
		Il2CppClassPointerStore<ProgressEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Progress", "ProgressEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressEvent>.NativeClassPtr, 100668864);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 746535, RefRangeEnd = 746545, XrefRangeStart = 746532, XrefRangeEnd = 746535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProgressEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ProgressEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
