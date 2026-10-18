using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Doozy.Engine.Events;

[Serializable]
public class GameObjectEvent : UnityEvent<GameObject>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static GameObjectEvent()
	{
		Il2CppClassPointerStore<GameObjectEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Events", "GameObjectEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEvent>.NativeClassPtr, 100669335);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750212, XrefRangeEnd = 750215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObjectEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameObjectEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
