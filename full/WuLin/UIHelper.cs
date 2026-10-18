using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace WuLin;

public static class UIHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEvent_Public_Static_Void_EventTrigger_EventTriggerType_UnityAction_1_BaseEventData_0;

	static UIHelper()
	{
		Il2CppClassPointerStore<UIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UIHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHelper>.NativeClassPtr);
		NativeMethodInfoPtr_RegisterEvent_Public_Static_Void_EventTrigger_EventTriggerType_UnityAction_1_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100678847);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 986573, RefRangeEnd = 986585, XrefRangeStart = 986545, XrefRangeEnd = 986573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterEvent(this EventTrigger trigger, EventTriggerType eventType, UnityAction<BaseEventData> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trigger);
		*(EventTriggerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterEvent_Public_Static_Void_EventTrigger_EventTriggerType_UnityAction_1_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
