using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Doozy.Engine.SceneManagement;

[Serializable]
public class ActiveSceneChangedEvent : UnityEvent<Scene, Scene>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ActiveSceneChangedEvent()
	{
		Il2CppClassPointerStore<ActiveSceneChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.SceneManagement", "ActiveSceneChangedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveSceneChangedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSceneChangedEvent>.NativeClassPtr, 100668798);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 745708, RefRangeEnd = 745709, XrefRangeStart = 745705, XrefRangeEnd = 745708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveSceneChangedEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveSceneChangedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActiveSceneChangedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
