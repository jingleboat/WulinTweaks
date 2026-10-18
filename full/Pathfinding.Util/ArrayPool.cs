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

public static class ArrayPool<T> : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MaximumExactArrayLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_pool;

	private static readonly System.IntPtr NativeFieldInfoPtr_exactPool;

	private static readonly System.IntPtr NativeMethodInfoPtr_Claim_Public_Static_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClaimWithExactLength_Public_Static_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_byref_Il2CppArrayBase_1_T_Boolean_0;

	public unsafe static int MaximumExactArrayLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaximumExactArrayLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaximumExactArrayLength, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<Stack<Il2CppArrayBase<T>>> pool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Stack<Il2CppArrayBase<T>>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Stack<Il2CppArrayBase<T>>> exactPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_exactPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Stack<Il2CppArrayBase<T>>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_exactPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static ArrayPool()
	{
		Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "ArrayPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr);
		NativeFieldInfoPtr_MaximumExactArrayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, "MaximumExactArrayLength");
		NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, "pool");
		NativeFieldInfoPtr_exactPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, "exactPool");
		NativeMethodInfoPtr_Claim_Public_Static_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100684263);
		NativeMethodInfoPtr_ClaimWithExactLength_Public_Static_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100684264);
		NativeMethodInfoPtr_Release_Public_Static_Void_byref_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100684265);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082877, RefRangeEnd = 1082878, XrefRangeStart = 1082818, XrefRangeEnd = 1082877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> Claim(int minimumLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&minimumLength);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Claim_Public_Static_Il2CppArrayBase_1_T_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082907, RefRangeEnd = 1082909, XrefRangeStart = 1082878, XrefRangeEnd = 1082907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ClaimWithExactLength(int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&length);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClaimWithExactLength_Public_Static_Il2CppArrayBase_1_T_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082992, RefRangeEnd = 1082993, XrefRangeStart = 1082909, XrefRangeEnd = 1082992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(ref Il2CppArrayBase<T> array, bool allowNonPowerOfTwo = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowNonPowerOfTwo;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_byref_Il2CppArrayBase_1_T_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	public ArrayPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
