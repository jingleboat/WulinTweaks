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

public static class ListPool<T> : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pool;

	private static readonly System.IntPtr NativeFieldInfoPtr_largePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_inPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCapacitySearchLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_LargeThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLargePoolSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_Claim_Public_Static_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindCandidate_Private_Static_Int32_List_1_List_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Claim_Public_Static_List_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Warmup_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_byref_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSize_Public_Static_Int32_0;

	public unsafe static List<List<T>> pool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<T>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<List<T>> largePool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_largePool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<T>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_largePool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static HashSet<List<T>> inPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<List<T>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static int MaxCapacitySearchLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxCapacitySearchLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxCapacitySearchLength, (void*)(&num));
		}
	}

	public unsafe static int LargeThreshold
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LargeThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LargeThreshold, (void*)(&num));
		}
	}

	public unsafe static int MaxLargePoolSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxLargePoolSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxLargePoolSize, (void*)(&num));
		}
	}

	static ListPool()
	{
		Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr);
		NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "pool");
		NativeFieldInfoPtr_largePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "largePool");
		NativeFieldInfoPtr_inPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "inPool");
		NativeFieldInfoPtr_MaxCapacitySearchLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "MaxCapacitySearchLength");
		NativeFieldInfoPtr_LargeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "LargeThreshold");
		NativeFieldInfoPtr_MaxLargePoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, "MaxLargePoolSize");
		NativeMethodInfoPtr_Claim_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684278);
		NativeMethodInfoPtr_FindCandidate_Private_Static_Int32_List_1_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684279);
		NativeMethodInfoPtr_Claim_Public_Static_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684280);
		NativeMethodInfoPtr_Warmup_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684281);
		NativeMethodInfoPtr_Release_Public_Static_Void_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684282);
		NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684283);
		NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684284);
		NativeMethodInfoPtr_GetSize_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100684285);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 1083164, RefRangeEnd = 1083211, XrefRangeStart = 1083108, XrefRangeEnd = 1083164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T> Claim()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Claim_Public_Static_List_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083211, XrefRangeEnd = 1083228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindCandidate(List<List<T>> pool, int capacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pool);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCandidate_Private_Static_Int32_List_1_List_1_T_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 1083303, RefRangeEnd = 1083335, XrefRangeStart = 1083228, XrefRangeEnd = 1083303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T> Claim(int capacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Claim_Public_Static_List_1_T_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083335, XrefRangeEnd = 1083371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Warmup(int count, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Warmup_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 1083380, RefRangeEnd = 1083434, XrefRangeStart = 1083371, XrefRangeEnd = 1083380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(ref List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_byref_List_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1083489, RefRangeEnd = 1083494, XrefRangeStart = 1083434, XrefRangeEnd = 1083489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083494, XrefRangeEnd = 1083517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ListPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
