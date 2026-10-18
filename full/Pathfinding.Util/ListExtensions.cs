using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Pathfinding.Util;

public static class ListExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ToArrayFromPool_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToArrayFromPool_Public_Static_Il2CppArrayBase_1_T_List_1_T_0, Il2CppClassPointerStore<ListExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ClearFast_Public_Static_Void_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ClearFast_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<ListExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArrayFromPool_Public_Static_Il2CppArrayBase_1_T_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFast_Public_Static_Void_List_1_T_0;

	static ListExtensions()
	{
		Il2CppClassPointerStore<ListExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "ListExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_ToArrayFromPool_Public_Static_Il2CppArrayBase_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListExtensions>.NativeClassPtr, 100684267);
		NativeMethodInfoPtr_ClearFast_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListExtensions>.NativeClassPtr, 100684268);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082998, RefRangeEnd = 1083000, XrefRangeStart = 1082993, XrefRangeEnd = 1082998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ToArrayFromPool<T>(this List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToArrayFromPool_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1083001, RefRangeEnd = 1083014, XrefRangeStart = 1083000, XrefRangeEnd = 1083001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearFast<T>(this List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ClearFast_Public_Static_Void_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ListExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
