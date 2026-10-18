using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public static class GameObjectPoolHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_poolDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitPool_Public_Static_Void_String_Int32_PoolInflationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitPoolFormGamObject_Public_Static_Void_GameObject_Int32_PoolInflationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectFromPool_Public_Static_GameObject_GameObject_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectFromPool_Public_Static_GameObject_String_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnObjectToPool_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnTransformToPool_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObjectByResType_Public_Static_GameObject_String_0;

	public unsafe static Dictionary<string, GameObjectPool> poolDict
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_poolDict, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, GameObjectPool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_poolDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static GameObjectPoolHelper()
	{
		Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameObjectPoolHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr);
		NativeFieldInfoPtr_poolDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, "poolDict");
		NativeMethodInfoPtr_InitPool_Public_Static_Void_String_Int32_PoolInflationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663792);
		NativeMethodInfoPtr_InitPoolFormGamObject_Public_Static_Void_GameObject_Int32_PoolInflationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663793);
		NativeMethodInfoPtr_GetObjectFromPool_Public_Static_GameObject_GameObject_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663794);
		NativeMethodInfoPtr_GetObjectFromPool_Public_Static_GameObject_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663795);
		NativeMethodInfoPtr_ReturnObjectToPool_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663796);
		NativeMethodInfoPtr_ReturnTransformToPool_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663797);
		NativeMethodInfoPtr_GetGameObjectByResType_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPoolHelper>.NativeClassPtr, 100663798);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671630, RefRangeEnd = 671632, XrefRangeStart = 671568, XrefRangeEnd = 671630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitPool(string poolName, int size, PoolInflationType type = PoolInflationType.DOUBLE)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(poolName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(PoolInflationType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPool_Public_Static_Void_String_Int32_PoolInflationType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671682, RefRangeEnd = 671684, XrefRangeStart = 671632, XrefRangeEnd = 671682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitPoolFormGamObject(GameObject pb, int size, PoolInflationType type = PoolInflationType.DOUBLE)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pb);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(PoolInflationType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPoolFormGamObject_Public_Static_Void_GameObject_Int32_PoolInflationType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 671707, RefRangeEnd = 671708, XrefRangeStart = 671684, XrefRangeEnd = 671707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetObjectFromPool(GameObject prefab, bool autoActive = true, int autoCreate = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoActive;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoCreate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectFromPool_Public_Static_GameObject_GameObject_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671730, RefRangeEnd = 671732, XrefRangeStart = 671708, XrefRangeEnd = 671730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetObjectFromPool(string poolName, bool autoActive = true, int autoCreate = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(poolName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoActive;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoCreate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectFromPool_Public_Static_GameObject_String_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671754, RefRangeEnd = 671756, XrefRangeStart = 671732, XrefRangeEnd = 671754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReturnObjectToPool(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnObjectToPool_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 671765, RefRangeEnd = 671766, XrefRangeStart = 671756, XrefRangeEnd = 671765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReturnTransformToPool(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnTransformToPool_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 671766, XrefRangeEnd = 671775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetGameObjectByResType(string poolName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(poolName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameObjectByResType_Public_Static_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	public GameObjectPoolHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
