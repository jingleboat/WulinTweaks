using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace XLua;

public static class SysGenConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_GCOptimize_Private_Static_get_List_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AdditionalProperties_Private_Static_get_Dictionary_2_Type_List_1_String_0;

	public unsafe static List<Il2CppSystem.Type> GCOptimize
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695540, XrefRangeEnd = 695590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GCOptimize_Private_Static_get_List_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr) : null;
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, List<string>> AdditionalProperties
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695590, XrefRangeEnd = 695652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AdditionalProperties_Private_Static_get_Dictionary_2_Type_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, List<string>>>(intPtr) : null;
		}
	}

	static SysGenConfig()
	{
		Il2CppClassPointerStore<SysGenConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "SysGenConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysGenConfig>.NativeClassPtr);
		NativeMethodInfoPtr_get_GCOptimize_Private_Static_get_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysGenConfig>.NativeClassPtr, 100664757);
		NativeMethodInfoPtr_get_AdditionalProperties_Private_Static_get_Dictionary_2_Type_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysGenConfig>.NativeClassPtr, 100664758);
	}

	public SysGenConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
