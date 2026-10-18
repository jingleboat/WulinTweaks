using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class GameObjectPool : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_availableObjStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_rootObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_inflationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_poolName;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectsInUse;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_GameObject_GameObject_Int32_PoolInflationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObjectToPool_Private_Void_PoolObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_populatePool_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextAvailableObject_Public_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnObjectToPool_Public_Void_PoolObject_0;

	public unsafe Stack<PoolObject> availableObjStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableObjStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<PoolObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableObjStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack));
		}
	}

	public unsafe GameObject rootObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe PoolInflationType inflationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inflationType);
			return *(PoolInflationType*)num;
		}
		set
		{
			*(PoolInflationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inflationType)) = poolInflationType;
		}
	}

	public unsafe string poolName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int objectsInUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsInUse);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsInUse)) = num;
		}
	}

	static GameObjectPool()
	{
		Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameObjectPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr);
		NativeFieldInfoPtr_availableObjStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, "availableObjStack");
		NativeFieldInfoPtr_rootObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, "rootObj");
		NativeFieldInfoPtr_inflationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, "inflationType");
		NativeFieldInfoPtr_poolName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, "poolName");
		NativeFieldInfoPtr_objectsInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, "objectsInUse");
		NativeMethodInfoPtr__ctor_Public_Void_String_GameObject_GameObject_Int32_PoolInflationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, 100663787);
		NativeMethodInfoPtr_AddObjectToPool_Private_Void_PoolObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr_populatePool_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, 100663789);
		NativeMethodInfoPtr_NextAvailableObject_Public_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, 100663790);
		NativeMethodInfoPtr_ReturnObjectToPool_Public_Void_PoolObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr, 100663791);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671513, RefRangeEnd = 671515, XrefRangeStart = 671477, XrefRangeEnd = 671513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObjectPool(string poolName, GameObject poolObjectPrefab, GameObject rootPoolObj, int initialCount, PoolInflationType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(poolName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poolObjectPrefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootPoolObj);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialCount;
		*(PoolInflationType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_GameObject_GameObject_Int32_PoolInflationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671531, RefRangeEnd = 671533, XrefRangeStart = 671515, XrefRangeEnd = 671531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddObjectToPool(PoolObject po)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)po);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObjectToPool_Private_Void_PoolObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671543, RefRangeEnd = 671545, XrefRangeStart = 671533, XrefRangeEnd = 671543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void populatePool(int initialCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_populatePool_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 671558, RefRangeEnd = 671560, XrefRangeStart = 671545, XrefRangeEnd = 671558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject NextAvailableObject(bool autoActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&autoActive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextAvailableObject_Public_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 671560, XrefRangeEnd = 671568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnObjectToPool(PoolObject po)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)po);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnObjectToPool_Public_Void_PoolObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameObjectPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
