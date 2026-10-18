using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Doozy.Engine.Utils;

[Serializable]
public class LanguagePack : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_CURRENT_LANGUAGE_PREFS_KEY;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_LANGUAGE;

	private static readonly IntPtr NativeFieldInfoPtr_s_currentLanguage;

	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_Language_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLanguage_Public_Static_set_Void_Language_0;

	private static readonly IntPtr NativeMethodInfoPtr_SaveLanguagePreference_Private_Static_Void_Language_0;

	private static readonly IntPtr NativeMethodInfoPtr_SaveLanguagePreference_Private_Static_Void_String_Language_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string CURRENT_LANGUAGE_PREFS_KEY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CURRENT_LANGUAGE_PREFS_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CURRENT_LANGUAGE_PREFS_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Language DEFAULT_LANGUAGE
	{
		get
		{
			Unsafe.SkipInit(out Language result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_LANGUAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_LANGUAGE, (void*)(&language));
		}
	}

	public unsafe static Language s_currentLanguage
	{
		get
		{
			Unsafe.SkipInit(out Language result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_currentLanguage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_currentLanguage, (void*)(&language));
		}
	}

	public unsafe static Language CurrentLanguage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 726715, RefRangeEnd = 726716, XrefRangeStart = 726692, XrefRangeEnd = 726715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_Language_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Language*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726716, XrefRangeEnd = 726728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentLanguage_Public_Static_set_Void_Language_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static LanguagePack()
	{
		Il2CppClassPointerStore<LanguagePack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "LanguagePack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr);
		NativeFieldInfoPtr_CURRENT_LANGUAGE_PREFS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, "CURRENT_LANGUAGE_PREFS_KEY");
		NativeFieldInfoPtr_DEFAULT_LANGUAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, "DEFAULT_LANGUAGE");
		NativeFieldInfoPtr_s_currentLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, "s_currentLanguage");
		NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_Language_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, 100667416);
		NativeMethodInfoPtr_set_CurrentLanguage_Public_Static_set_Void_Language_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, 100667417);
		NativeMethodInfoPtr_SaveLanguagePreference_Private_Static_Void_Language_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, 100667418);
		NativeMethodInfoPtr_SaveLanguagePreference_Private_Static_Void_String_Language_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, 100667419);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr, 100667420);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726728, XrefRangeEnd = 726735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveLanguagePreference(Language language)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveLanguagePreference_Private_Static_Void_Language_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726735, XrefRangeEnd = 726737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveLanguagePreference(string prefsKey, Language language)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefsKey);
		*(Language**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &language;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveLanguagePreference_Private_Static_Void_String_Language_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(99)]
	[CachedScanResults(RefRangeStart = 224141, RefRangeEnd = 224240, XrefRangeStart = 224141, XrefRangeEnd = 224240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LanguagePack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguagePack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LanguagePack(IntPtr pointer)
		: base(pointer)
	{
	}
}
