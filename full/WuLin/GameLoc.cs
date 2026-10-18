using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using WuLin.GameFrameworks;

namespace WuLin;

public class GameLoc : GTSingleton<GameLoc>
{
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_LANGUAGE;

	private static readonly IntPtr NativeFieldInfoPtr_onLanguageChange;

	private static readonly IntPtr NativeFieldInfoPtr_LocDataFromFile;

	private static readonly IntPtr NativeFieldInfoPtr_gameLanguage;

	private static readonly IntPtr NativeMethodInfoPtr_get_LocDataScriptObject_Public_get_LocDataScriptObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GameLanguage_Public_get_SystemLanguage_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Public_Void_SystemLanguage_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasLocString_Public_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLocData_Public_LocData_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsLatin_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLocString_Public_String_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLocStringByFile_Public_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static SystemLanguage DEFAULT_LANGUAGE
	{
		get
		{
			Unsafe.SkipInit(out SystemLanguage result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_LANGUAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_LANGUAGE, (void*)(&systemLanguage));
		}
	}

	public unsafe UnityAction onLanguageChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onLanguageChange);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onLanguageChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityAction));
		}
	}

	public unsafe Dictionary<string, FileLocItem> LocDataFromFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocDataFromFile);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, FileLocItem>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocDataFromFile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe SystemLanguage gameLanguage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLanguage);
			return *(SystemLanguage*)num;
		}
		set
		{
			*(SystemLanguage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLanguage)) = systemLanguage;
		}
	}

	public unsafe LocDataScriptObject LocDataScriptObject
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 820961, RefRangeEnd = 820968, XrefRangeStart = 820955, XrefRangeEnd = 820961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocDataScriptObject_Public_get_LocDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LocDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe SystemLanguage GameLanguage
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 820972, RefRangeEnd = 820974, XrefRangeStart = 820968, XrefRangeEnd = 820972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameLanguage_Public_get_SystemLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(SystemLanguage*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static GameLoc()
	{
		Il2CppClassPointerStore<GameLoc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameLoc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLoc>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_LANGUAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, "DEFAULT_LANGUAGE");
		NativeFieldInfoPtr_onLanguageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, "onLanguageChange");
		NativeFieldInfoPtr_LocDataFromFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, "LocDataFromFile");
		NativeFieldInfoPtr_gameLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, "gameLanguage");
		NativeMethodInfoPtr_get_LocDataScriptObject_Public_get_LocDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672796);
		NativeMethodInfoPtr_get_GameLanguage_Public_get_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672797);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672798);
		NativeMethodInfoPtr_SetLanguage_Public_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672799);
		NativeMethodInfoPtr_HasLocString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672800);
		NativeMethodInfoPtr_GetLocData_Public_LocData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672801);
		NativeMethodInfoPtr_IsLatin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672802);
		NativeMethodInfoPtr_GetLocString_Public_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672803);
		NativeMethodInfoPtr_GetLocStringByFile_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672804);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLoc>.NativeClassPtr, 100672805);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLanguage(SystemLanguage language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLanguage_Public_Void_SystemLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(58)]
	[CachedScanResults(RefRangeStart = 820984, RefRangeEnd = 821042, XrefRangeStart = 820974, XrefRangeEnd = 820984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasLocString(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasLocString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 821052, RefRangeEnd = 821057, XrefRangeStart = 821042, XrefRangeEnd = 821052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocData GetLocData(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocData_Public_LocData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LocData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 821061, RefRangeEnd = 821063, XrefRangeStart = 821057, XrefRangeEnd = 821061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLatin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLatin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1063)]
	[CachedScanResults(RefRangeStart = 821116, RefRangeEnd = 822179, XrefRangeStart = 821063, XrefRangeEnd = 821116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocString(string key, bool enableSplit = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &enableSplit;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocString_Public_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 822225, RefRangeEnd = 822230, XrefRangeStart = 822179, XrefRangeEnd = 822225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocStringByFile(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocStringByFile_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822230, XrefRangeEnd = 822236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameLoc()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLoc>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameLoc(IntPtr pointer)
		: base(pointer)
	{
	}
}
