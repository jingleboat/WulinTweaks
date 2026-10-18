using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Pathfinding.Util;

public static class ObjectPool<T> : Il2CppSystem.Object where T : class, new()
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Claim_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_byref_T_0;

	static ObjectPool()
	{
		Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
		NativeMethodInfoPtr_Claim_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100684290);
		NativeMethodInfoPtr_Release_Public_Static_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100684291);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1083557, RefRangeEnd = 1083566, XrefRangeStart = 1083548, XrefRangeEnd = 1083557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Claim()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Claim_Public_Static_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1083579, RefRangeEnd = 1083585, XrefRangeStart = 1083566, XrefRangeEnd = 1083579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(ref T obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_byref_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		obj = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	public ObjectPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
