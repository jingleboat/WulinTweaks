using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace WuLin;

public class LocFontSizeFunction : LocalizationFunction
{
	private static readonly IntPtr NativeFieldInfoPtr_ChineseFontSize;

	private static readonly IntPtr NativeFieldInfoPtr_EnglishFontSize;

	private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_LocalizationComponent_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplyLanguage_Public_Virtual_Void_SystemLanguage_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float ChineseFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChineseFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChineseFontSize)) = num;
		}
	}

	public unsafe float EnglishFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnglishFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnglishFontSize)) = num;
		}
	}

	static LocFontSizeFunction()
	{
		Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "LocFontSizeFunction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr);
		NativeFieldInfoPtr_ChineseFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr, "ChineseFontSize");
		NativeFieldInfoPtr_EnglishFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr, "EnglishFontSize");
		NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_LocalizationComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr, 100673162);
		NativeMethodInfoPtr_OnApplyLanguage_Public_Virtual_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr, 100673163);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr, 100673164);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831532, XrefRangeEnd = 831535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnAwake(LocalizationComponent localizationComponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localizationComponent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_LocalizationComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831535, XrefRangeEnd = 831539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnApplyLanguage(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnApplyLanguage_Public_Virtual_Void_SystemLanguage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocFontSizeFunction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocFontSizeFunction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LocFontSizeFunction(IntPtr pointer)
		: base(pointer)
	{
	}
}
