using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public class LocalizationFunction : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_localizationComponent;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAwake_Public_Virtual_New_Void_LocalizationComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnApplyLanguage_Public_Abstract_Virtual_New_Void_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRefreshText_Public_Virtual_New_Void_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe LocalizationComponent localizationComponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizationComponent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalizationComponent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizationComponent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localizationComponent));
		}
	}

	static LocalizationFunction()
	{
		Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "LocalizationFunction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr);
		NativeFieldInfoPtr_localizationComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr, "localizationComponent");
		NativeMethodInfoPtr_OnAwake_Public_Virtual_New_Void_LocalizationComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr, 100673158);
		NativeMethodInfoPtr_OnApplyLanguage_Public_Abstract_Virtual_New_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr, 100673159);
		NativeMethodInfoPtr_OnRefreshText_Public_Virtual_New_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr, 100673160);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr, 100673161);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 831530, RefRangeEnd = 831532, XrefRangeStart = 831518, XrefRangeEnd = 831530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAwake(LocalizationComponent localizationComponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localizationComponent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAwake_Public_Virtual_New_Void_LocalizationComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void OnApplyLanguage(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnApplyLanguage_Public_Abstract_Virtual_New_Void_SystemLanguage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnRefreshText(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRefreshText_Public_Virtual_New_Void_SystemLanguage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalizationFunction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationFunction>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LocalizationFunction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
