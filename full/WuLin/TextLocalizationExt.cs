using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace WuLin;

public static class TextLocalizationExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalizationText_Public_Static_Void_TMP_Text_String_Il2CppStringArray_List_1_String_Func_1_String_0;

	static TextLocalizationExt()
	{
		Il2CppClassPointerStore<TextLocalizationExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "TextLocalizationExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLocalizationExt>.NativeClassPtr);
		NativeMethodInfoPtr_SetLocalizationText_Public_Static_Void_TMP_Text_String_Il2CppStringArray_List_1_String_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalizationExt>.NativeClassPtr, 100673175);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 831700, RefRangeEnd = 831725, XrefRangeStart = 831689, XrefRangeEnd = 831700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalizationText(this TMP_Text text, string key, Il2CppStringArray param = null, List<string> replacementKeys = null, Il2CppSystem.Func<string> getStringFunc = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)replacementKeys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)getStringFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizationText_Public_Static_Void_TMP_Text_String_Il2CppStringArray_List_1_String_Func_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TextLocalizationExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
