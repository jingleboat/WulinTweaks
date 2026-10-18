using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Pathfinding;

public static class PathPool : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetPath_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetPath_Public_Static_T_0, Il2CppClassPointerStore<PathPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_pool;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCreated;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pool_Public_Static_Void_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalCreated_Public_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSize_Public_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_Static_T_0;

	public unsafe static Dictionary<Il2CppSystem.Type, Stack<Path>> pool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Stack<Path>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, int> totalCreated
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_totalCreated, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_totalCreated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static PathPool()
	{
		Il2CppClassPointerStore<PathPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "PathPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPool>.NativeClassPtr);
		NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPool>.NativeClassPtr, "pool");
		NativeFieldInfoPtr_totalCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPool>.NativeClassPtr, "totalCreated");
		NativeMethodInfoPtr_Pool_Public_Static_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPool>.NativeClassPtr, 100682686);
		NativeMethodInfoPtr_GetTotalCreated_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPool>.NativeClassPtr, 100682687);
		NativeMethodInfoPtr_GetSize_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPool>.NativeClassPtr, 100682688);
		NativeMethodInfoPtr_GetPath_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPool>.NativeClassPtr, 100682689);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065431, RefRangeEnd = 1065432, XrefRangeStart = 1065394, XrefRangeEnd = 1065431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Pool(Path path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pool_Public_Static_Void_Path_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1065439, RefRangeEnd = 1065446, XrefRangeStart = 1065432, XrefRangeEnd = 1065439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTotalCreated(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalCreated_Public_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1065454, RefRangeEnd = 1065461, XrefRangeStart = 1065446, XrefRangeEnd = 1065454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSize(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSize_Public_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1065524, RefRangeEnd = 1065535, XrefRangeStart = 1065461, XrefRangeEnd = 1065524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetPath<T>() where T : Path, new()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetPath_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	public PathPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
