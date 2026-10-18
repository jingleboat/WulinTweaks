using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Pathfinding.Util;

public static class Memory : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0, Il2CppClassPointerStore<Memory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Memory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ShrinkArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ShrinkArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Memory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<Memory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShrinkArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

	static Memory()
	{
		Il2CppClassPointerStore<Memory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "Memory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Memory>.NativeClassPtr);
		NativeMethodInfoPtr_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory>.NativeClassPtr, 100684382);
		NativeMethodInfoPtr_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory>.NativeClassPtr, 100684383);
		NativeMethodInfoPtr_ShrinkArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory>.NativeClassPtr, 100684384);
		NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory>.NativeClassPtr, 100684385);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085203, RefRangeEnd = 1085204, XrefRangeStart = 1085195, XrefRangeEnd = 1085203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemSet<T>(Il2CppArrayBase<T> array, T value, int byteSize) where T : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085212, RefRangeEnd = 1085213, XrefRangeStart = 1085204, XrefRangeEnd = 1085212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemSet<T>(Il2CppArrayBase<T> array, T value, int totalSize, int byteSize) where T : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalSize;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MemSet_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085220, RefRangeEnd = 1085221, XrefRangeStart = 1085213, XrefRangeEnd = 1085220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ShrinkArray<T>(Il2CppArrayBase<T> arr, int newLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ShrinkArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 489661, RefRangeEnd = 489675, XrefRangeStart = 489661, XrefRangeEnd = 489675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Swap<T>(ref T a, ref T b)
	{
		//IL_0058: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got VT
		//IL_0056->IL0056: Incompatible stack types: Obj vs VT
		//IL_0069->IL0069: Incompatible stack types: Obj vs VT
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref a));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref b));
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		Unsafe.As<T, object>(ref a) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		Unsafe.As<T, object>(ref b) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false) : ((object)null));
	}

	public Memory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
