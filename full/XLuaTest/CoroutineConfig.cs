using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace XLuaTest;

public static class CoroutineConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_LuaCallCSharp_Public_Static_get_List_1_Type_0;

	public unsafe static List<Il2CppSystem.Type> LuaCallCSharp
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705863, XrefRangeEnd = 705883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LuaCallCSharp_Public_Static_get_List_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr) : null;
		}
	}

	static CoroutineConfig()
	{
		Il2CppClassPointerStore<CoroutineConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "CoroutineConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineConfig>.NativeClassPtr);
		NativeMethodInfoPtr_get_LuaCallCSharp_Public_Static_get_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineConfig>.NativeClassPtr, 100665298);
	}

	public CoroutineConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
