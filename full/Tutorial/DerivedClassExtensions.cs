using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Tutorial;

public static class DerivedClassExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSomeData_Public_Static_Int32_DerivedClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSomeBaseData_Public_Static_Int32_BaseClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenericMethodOfString_Public_Static_Void_DerivedClass_0;

	static DerivedClassExtensions()
	{
		Il2CppClassPointerStore<DerivedClassExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tutorial", "DerivedClassExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DerivedClassExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetSomeData_Public_Static_Int32_DerivedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerivedClassExtensions>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_GetSomeBaseData_Public_Static_Int32_BaseClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerivedClassExtensions>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_GenericMethodOfString_Public_Static_Void_DerivedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerivedClassExtensions>.NativeClassPtr, 100664701);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695359, XrefRangeEnd = 695367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSomeData(this DerivedClass obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSomeData_Public_Static_Int32_DerivedClass_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695367, XrefRangeEnd = 695375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSomeBaseData(this BaseClass obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSomeBaseData_Public_Static_Int32_BaseClass_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695375, XrefRangeEnd = 695379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenericMethodOfString(this DerivedClass obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenericMethodOfString_Public_Static_Void_DerivedClass_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DerivedClassExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
