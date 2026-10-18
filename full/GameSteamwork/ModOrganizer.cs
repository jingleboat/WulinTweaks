using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameSteamwork;

public static class ModOrganizer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WorkshopFileFinder;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelfModFileFinder;

	private static readonly System.IntPtr NativeFieldInfoPtr_modsDirCache;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindWorkshopMods_Public_Static_List_1_TmodFile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMods_Public_Static_List_1_TmodFile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__FindMods_Private_Static_List_1_TmodFile_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttemptLoadMod_Private_Static_Boolean_String_byref_List_1_TmodFile_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteModFromShop_Public_Static_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteModFromLocal_Public_Static_Void_TmodFile_0;

	public unsafe static WorkshopHelper.ModSubscribedFinder WorkshopFileFinder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorkshopFileFinder, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorkshopHelper.ModSubscribedFinder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorkshopFileFinder, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modSubscribedFinder));
		}
	}

	public unsafe static WorkshopHelper.ModSelfModFinder SelfModFileFinder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelfModFileFinder, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorkshopHelper.ModSelfModFinder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelfModFileFinder, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modSelfModFinder));
		}
	}

	public unsafe static Dictionary<string, TmodFile> modsDirCache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_modsDirCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, TmodFile>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_modsDirCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static ModOrganizer()
	{
		Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameSteamwork", "ModOrganizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr);
		NativeFieldInfoPtr_WorkshopFileFinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, "WorkshopFileFinder");
		NativeFieldInfoPtr_SelfModFileFinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, "SelfModFileFinder");
		NativeFieldInfoPtr_modsDirCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, "modsDirCache");
		NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr_FindWorkshopMods_Public_Static_List_1_TmodFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664628);
		NativeMethodInfoPtr_FindMods_Public_Static_List_1_TmodFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr__FindMods_Private_Static_List_1_TmodFile_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_AttemptLoadMod_Private_Static_Boolean_String_byref_List_1_TmodFile_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_DeleteModFromShop_Public_Static_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_DeleteModFromLocal_Public_Static_Void_TmodFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModOrganizer>.NativeClassPtr, 100664633);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693823, RefRangeEnd = 693824, XrefRangeStart = 693815, XrefRangeEnd = 693823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693828, RefRangeEnd = 693829, XrefRangeStart = 693824, XrefRangeEnd = 693828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<TmodFile> FindWorkshopMods()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindWorkshopMods_Public_Static_List_1_TmodFile_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TmodFile>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693833, RefRangeEnd = 693834, XrefRangeStart = 693829, XrefRangeEnd = 693833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<TmodFile> FindMods()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMods_Public_Static_List_1_TmodFile_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TmodFile>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 693888, RefRangeEnd = 693890, XrefRangeStart = 693834, XrefRangeEnd = 693888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<TmodFile> _FindMods(bool ignoreModsFolder = false, bool ignoreWorkshop = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ignoreModsFolder);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreWorkshop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindMods_Private_Static_List_1_TmodFile_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TmodFile>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 693916, RefRangeEnd = 693918, XrefRangeStart = 693890, XrefRangeEnd = 693916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AttemptLoadMod(string projectPath, ref List<TmodFile> mods, bool isWorkShop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(projectPath);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mods);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWorkShop;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttemptLoadMod_Private_Static_Boolean_String_byref_List_1_TmodFile_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		mods = ((intPtr4 == (System.IntPtr)0) ? null : new List<TmodFile>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693922, RefRangeEnd = 693923, XrefRangeStart = 693918, XrefRangeEnd = 693922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteModFromShop(ulong PublishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&PublishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteModFromShop_Public_Static_Void_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693929, RefRangeEnd = 693930, XrefRangeStart = 693923, XrefRangeEnd = 693929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteModFromLocal(TmodFile tmod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tmod);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteModFromLocal_Public_Static_Void_TmodFile_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModOrganizer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
