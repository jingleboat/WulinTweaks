using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Pathfinding.Util;

public static class ObjectPoolSimple<T> : Il2CppSystem.Object where T : class, new()
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pool;

	private static readonly System.IntPtr NativeFieldInfoPtr_inPool;

	private static readonly System.IntPtr NativeMethodInfoPtr_Claim_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSize_Public_Static_Int32_0;

	public unsafe static List<T> pool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static HashSet<T> inPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<T>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static ObjectPoolSimple()
	{
		Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "ObjectPoolSimple`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr);
		NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr, "pool");
		NativeFieldInfoPtr_inPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr, "inPool");
		NativeMethodInfoPtr_Claim_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr, 100684292);
		NativeMethodInfoPtr_Release_Public_Static_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr, 100684293);
		NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr, 100684294);
		NativeMethodInfoPtr_GetSize_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolSimple<T>>.NativeClassPtr, 100684295);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1083638, RefRangeEnd = 1083640, XrefRangeStart = 1083585, XrefRangeEnd = 1083638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Claim()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Claim_Public_Static_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1083663, RefRangeEnd = 1083665, XrefRangeStart = 1083640, XrefRangeEnd = 1083663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083665, XrefRangeEnd = 1083688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 309382, RefRangeEnd = 309395, XrefRangeStart = 309382, XrefRangeEnd = 309395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSize_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ObjectPoolSimple(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
