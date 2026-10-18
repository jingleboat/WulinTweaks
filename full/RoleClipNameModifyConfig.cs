using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class RoleClipNameModifyConfig : SerializedScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_nameModifyConfigDict;

	private static readonly IntPtr NativeFieldInfoPtr_sitRoleList;

	private static readonly IntPtr NativeFieldInfoPtr_CachedSitRoleList;

	private static readonly IntPtr NativeFieldInfoPtr_washRoleList;

	private static readonly IntPtr NativeFieldInfoPtr_CachedWashRoleList;

	private static readonly IntPtr NativeFieldInfoPtr_animForImport;

	private static readonly IntPtr NativeMethodInfoPtr_get_SitRoleList_Public_Static_get_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_WashRoleList_Public_Static_get_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddDataINConfigDic_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNameModifies_Public_List_1_String_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ExportConfigStr_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ImportConfigStr_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<string, List<string>> nameModifyConfigDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameModifyConfigDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<string>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameModifyConfigDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<string> sitRoleList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitRoleList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitRoleList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> CachedSitRoleList
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CachedSitRoleList, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CachedSitRoleList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> washRoleList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washRoleList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washRoleList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> CachedWashRoleList
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CachedWashRoleList, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CachedWashRoleList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TextAsset animForImport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animForImport);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animForImport)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textAsset));
		}
	}

	public unsafe static List<string> SitRoleList
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673371, RefRangeEnd = 673374, XrefRangeStart = 673350, XrefRangeEnd = 673371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SitRoleList_Public_Static_get_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
	}

	public unsafe static List<string> WashRoleList
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673395, RefRangeEnd = 673396, XrefRangeStart = 673374, XrefRangeEnd = 673395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WashRoleList_Public_Static_get_List_1_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
	}

	static RoleClipNameModifyConfig()
	{
		Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoleClipNameModifyConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr);
		NativeFieldInfoPtr_nameModifyConfigDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, "nameModifyConfigDict");
		NativeFieldInfoPtr_sitRoleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, "sitRoleList");
		NativeFieldInfoPtr_CachedSitRoleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, "CachedSitRoleList");
		NativeFieldInfoPtr_washRoleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, "washRoleList");
		NativeFieldInfoPtr_CachedWashRoleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, "CachedWashRoleList");
		NativeFieldInfoPtr_animForImport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, "animForImport");
		NativeMethodInfoPtr_get_SitRoleList_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_get_WashRoleList_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_AddDataINConfigDic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_GetNameModifies_Public_List_1_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_ExportConfigStr_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_ImportConfigStr_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr, 100663922);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673396, XrefRangeEnd = 673460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDataINConfigDic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDataINConfigDic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673460, XrefRangeEnd = 673493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetNameModifies(string templeteName, string charaName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(templeteName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(charaName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNameModifies_Public_List_1_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673493, XrefRangeEnd = 673532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExportConfigStr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportConfigStr_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673532, XrefRangeEnd = 673554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportConfigStr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportConfigStr_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673554, XrefRangeEnd = 673565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoleClipNameModifyConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoleClipNameModifyConfig>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoleClipNameModifyConfig(IntPtr pointer)
		: base(pointer)
	{
	}
}
