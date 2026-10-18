using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.UI;

namespace WuLin;

public static class ImageLocalizationExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalizationImageWithKey_Public_Static_Void_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalizationImageWithPath_Public_Static_Void_Image_String_0;

	static ImageLocalizationExt()
	{
		Il2CppClassPointerStore<ImageLocalizationExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ImageLocalizationExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageLocalizationExt>.NativeClassPtr);
		NativeMethodInfoPtr_SetLocalizationImageWithKey_Public_Static_Void_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLocalizationExt>.NativeClassPtr, 100673176);
		NativeMethodInfoPtr_SetLocalizationImageWithPath_Public_Static_Void_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLocalizationExt>.NativeClassPtr, 100673177);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831725, XrefRangeEnd = 831736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalizationImageWithKey(this Image image, string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizationImageWithKey_Public_Static_Void_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 831747, RefRangeEnd = 831749, XrefRangeStart = 831736, XrefRangeEnd = 831747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalizationImageWithPath(this Image image, string chinesePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(chinesePath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizationImageWithPath_Public_Static_Void_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImageLocalizationExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
