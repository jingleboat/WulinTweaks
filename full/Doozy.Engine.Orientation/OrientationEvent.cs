using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

namespace Doozy.Engine.Orientation;

[Serializable]
public class OrientationEvent : UnityEvent<DetectedOrientation>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static OrientationEvent()
	{
		Il2CppClassPointerStore<OrientationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Orientation", "OrientationEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrientationEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrientationEvent>.NativeClassPtr, 100668948);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747151, XrefRangeEnd = 747154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrientationEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrientationEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OrientationEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
