using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Doozy.Engine.Touchy;

public static class TouchHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_lastSimulatedTouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_touches;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouches_Public_Static_List_1_Touch_0;

	public unsafe static SimulatedTouch s_lastSimulatedTouch
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_lastSimulatedTouch, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SimulatedTouch>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_lastSimulatedTouch, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simulatedTouch));
		}
	}

	public unsafe static List<Touch> s_touches
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_touches, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_touches, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static TouchHelper()
	{
		Il2CppClassPointerStore<TouchHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Touchy", "TouchHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchHelper>.NativeClassPtr);
		NativeFieldInfoPtr_s_lastSimulatedTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchHelper>.NativeClassPtr, "s_lastSimulatedTouch");
		NativeFieldInfoPtr_s_touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchHelper>.NativeClassPtr, "s_touches");
		NativeMethodInfoPtr_GetTouches_Public_Static_List_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchHelper>.NativeClassPtr, 100668604);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 742727, RefRangeEnd = 742728, XrefRangeStart = 742668, XrefRangeEnd = 742727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Touch> GetTouches()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouches_Public_Static_List_1_Touch_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr) : null;
	}

	public TouchHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
