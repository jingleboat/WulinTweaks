using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Doozy.Integrations.Playmaker;

public class PlaymakerEventDispatcher : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PlaymakerEventDispatcher()
	{
		Il2CppClassPointerStore<PlaymakerEventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Integrations.Playmaker", "PlaymakerEventDispatcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymakerEventDispatcher>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymakerEventDispatcher>.NativeClassPtr, 100667280);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlaymakerEventDispatcher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymakerEventDispatcher>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlaymakerEventDispatcher(IntPtr pointer)
		: base(pointer)
	{
	}
}
