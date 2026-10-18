using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

public static class ObjectHelper : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<ObjectHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

	static ObjectHelper()
	{
		Il2CppClassPointerStore<ObjectHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObjectHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHelper>.NativeClassPtr);
		NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHelper>.NativeClassPtr, 100664601);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 489661, RefRangeEnd = 489675, XrefRangeStart = 489661, XrefRangeEnd = 489675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Swap<T>(ref T t1, ref T t2)
	{
		//IL_0058: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got VT
		//IL_0056->IL0056: Incompatible stack types: Obj vs VT
		//IL_0069->IL0069: Incompatible stack types: Obj vs VT
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref t1));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref t2));
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		Unsafe.As<T, object>(ref t1) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		Unsafe.As<T, object>(ref t2) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false) : ((object)null));
	}

	public ObjectHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
