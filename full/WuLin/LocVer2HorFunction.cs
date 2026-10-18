using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace WuLin;

public class LocVer2HorFunction : LocalizationFunction
{
	private static readonly IntPtr NativeFieldInfoPtr_ChineseSizeDelta;

	private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_LocalizationComponent_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplyLanguage_Public_Virtual_Void_SystemLanguage_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRefreshText_Public_Virtual_Void_SystemLanguage_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 ChineseSizeDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChineseSizeDelta);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChineseSizeDelta)) = vector;
		}
	}

	static LocVer2HorFunction()
	{
		Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "LocVer2HorFunction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr);
		NativeFieldInfoPtr_ChineseSizeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr, "ChineseSizeDelta");
		NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_LocalizationComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr, 100673165);
		NativeMethodInfoPtr_OnApplyLanguage_Public_Virtual_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr, 100673166);
		NativeMethodInfoPtr_OnRefreshText_Public_Virtual_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr, 100673167);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr, 100673168);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831539, XrefRangeEnd = 831553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831553, XrefRangeEnd = 831572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnApplyLanguage(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnApplyLanguage_Public_Virtual_Void_SystemLanguage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831572, XrefRangeEnd = 831585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRefreshText(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRefreshText_Public_Virtual_Void_SystemLanguage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocVer2HorFunction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocVer2HorFunction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LocVer2HorFunction(IntPtr pointer)
		: base(pointer)
	{
	}
}
