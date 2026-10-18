using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding.WindowsStore;

public static class WindowsStoreCompatibility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeFromInfo_Public_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeInfo_Public_Static_Type_Type_0;

	static WindowsStoreCompatibility()
	{
		Il2CppClassPointerStore<WindowsStoreCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.WindowsStore", "WindowsStoreCompatibility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsStoreCompatibility>.NativeClassPtr);
		NativeMethodInfoPtr_GetTypeFromInfo_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsStoreCompatibility>.NativeClassPtr, 100684261);
		NativeMethodInfoPtr_GetTypeInfo_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsStoreCompatibility>.NativeClassPtr, 100684262);
	}

	[CallerCount(1064)]
	[CachedScanResults(RefRangeStart = 12051, RefRangeEnd = 13115, XrefRangeStart = 12051, XrefRangeEnd = 13115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetTypeFromInfo(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeFromInfo_Public_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(1064)]
	[CachedScanResults(RefRangeStart = 12051, RefRangeEnd = 13115, XrefRangeStart = 12051, XrefRangeEnd = 13115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetTypeInfo(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeInfo_Public_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	public WindowsStoreCompatibility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
