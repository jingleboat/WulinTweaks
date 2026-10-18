using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace WuLin;

public static class MD5Helper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FileMD5_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringMD5_Public_Static_String_String_0;

	static MD5Helper()
	{
		Il2CppClassPointerStore<MD5Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MD5Helper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5Helper>.NativeClassPtr);
		NativeMethodInfoPtr_FileMD5_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5Helper>.NativeClassPtr, 100678820);
		NativeMethodInfoPtr_StringMD5_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5Helper>.NativeClassPtr, 100678821);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986085, XrefRangeEnd = 986102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FileMD5(string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileMD5_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986102, XrefRangeEnd = 986115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StringMD5(string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringMD5_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public MD5Helper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
