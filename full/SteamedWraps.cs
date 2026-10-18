using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.Specialized;
using Steamworks;

public static class SteamedWraps : Il2CppSystem.Object
{
	public sealed class ItemInstallInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_installPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdatedTime;

		public unsafe string installPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installPath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe uint lastUpdatedTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdatedTime);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdatedTime)) = num;
			}
		}

		static ItemInstallInfo()
		{
			Il2CppClassPointerStore<ItemInstallInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, "ItemInstallInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstallInfo>.NativeClassPtr);
			NativeFieldInfoPtr_installPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstallInfo>.NativeClassPtr, "installPath");
			NativeFieldInfoPtr_lastUpdatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstallInfo>.NativeClassPtr, "lastUpdatedTime");
		}

		public ItemInstallInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ItemInstallInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstallInfo>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaytimePagingConst;

	private static readonly System.IntPtr NativeFieldInfoPtr_deletedItems;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseWorkshopHandle_Public_Static_Void_UGCQueryHandle_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchItemDetails_Public_Static_SteamUGCDetails_t_UGCQueryHandle_t_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchItemDependencies_Public_Static_Il2CppStructArray_1_PublishedFileId_t_UGCQueryHandle_t_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyQueryHandle_Private_Static_Void_byref_UGCQueryHandle_t_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterByTags_Private_Static_Void_byref_UGCQueryHandle_t_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterByInternalName_Private_Static_Void_byref_UGCQueryHandle_t_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSingleItemQuery_Public_Static_SteamAPICall_t_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateModBrowserQuery_Public_Static_SteamAPICall_t_String_List_1_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchPlayTimeStats_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_UInt64_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchPreviewImageUrl_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchTagName_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchMetadata_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_NameValueCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceCallbacks_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGameExitCleanup_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkshopItemState_Public_Static_UInt32_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstallInfo_Public_Static_ItemInstallInfo_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UninstallWorkshopItem_Public_Static_Void_PublishedFileId_t_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupACF_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UninstallACF_Private_Static_Void_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorkshopItemDownloading_Public_Static_Boolean_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorkshopItemInstalled_Public_Static_Boolean_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorkshopItemInstalledOrMiss_Public_Static_Boolean_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoesWorkshopItemNeedUpdate_Public_Static_Int32_PublishedFileId_t_0;

	public unsafe static int PlaytimePagingConst
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaytimePagingConst, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaytimePagingConst, (void*)(&num));
		}
	}

	public unsafe static List<PublishedFileId_t> deletedItems
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deletedItems, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PublishedFileId_t>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deletedItems, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SteamedWraps()
	{
		Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamedWraps");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr);
		NativeFieldInfoPtr_PlaytimePagingConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, "PlaytimePagingConst");
		NativeFieldInfoPtr_deletedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, "deletedItems");
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_ReleaseWorkshopHandle_Public_Static_Void_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_FetchItemDetails_Public_Static_SteamUGCDetails_t_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_FetchItemDependencies_Public_Static_Il2CppStructArray_1_PublishedFileId_t_UGCQueryHandle_t_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_ModifyQueryHandle_Private_Static_Void_byref_UGCQueryHandle_t_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_FilterByTags_Private_Static_Void_byref_UGCQueryHandle_t_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_FilterByInternalName_Private_Static_Void_byref_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_GenerateSingleItemQuery_Public_Static_SteamAPICall_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_GenerateModBrowserQuery_Public_Static_SteamAPICall_t_String_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_FetchPlayTimeStats_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_FetchPreviewImageUrl_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_FetchTagName_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_FetchMetadata_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_NameValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_ForceCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_OnGameExitCleanup_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_GetWorkshopItemState_Public_Static_UInt32_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_GetInstallInfo_Public_Static_ItemInstallInfo_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_UninstallWorkshopItem_Public_Static_Void_PublishedFileId_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_CleanupACF_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_UninstallACF_Private_Static_Void_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_IsWorkshopItemDownloading_Public_Static_Boolean_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_IsWorkshopItemInstalled_Public_Static_Boolean_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_IsWorkshopItemInstalledOrMiss_Public_Static_Boolean_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_DoesWorkshopItemNeedUpdate_Public_Static_Int32_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamedWraps>.NativeClassPtr, 100664163);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684234, RefRangeEnd = 684238, XrefRangeStart = 684233, XrefRangeEnd = 684234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseWorkshopHandle(UGCQueryHandle_t handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseWorkshopHandle_Public_Static_Void_UGCQueryHandle_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684239, RefRangeEnd = 684243, XrefRangeStart = 684238, XrefRangeEnd = 684239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SteamUGCDetails_t FetchItemDetails(UGCQueryHandle_t handle, uint index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchItemDetails_Public_Static_SteamUGCDetails_t_UGCQueryHandle_t_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new SteamUGCDetails_t(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684247, RefRangeEnd = 684248, XrefRangeStart = 684243, XrefRangeEnd = 684247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<PublishedFileId_t> FetchItemDependencies(UGCQueryHandle_t handle, uint index, uint numChildren)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numChildren;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchItemDependencies_Public_Static_Il2CppStructArray_1_PublishedFileId_t_UGCQueryHandle_t_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684248, XrefRangeEnd = 684253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ModifyQueryHandle(ref UGCQueryHandle_t qHandle, bool returnChildInfo = false, bool returnLongDesc = false, bool returnKeyValueTags = false, bool returnPlaytimeStats = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref qHandle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnChildInfo;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnLongDesc;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnKeyValueTags;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnPlaytimeStats;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyQueryHandle_Private_Static_Void_byref_UGCQueryHandle_t_Boolean_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684268, RefRangeEnd = 684269, XrefRangeStart = 684253, XrefRangeEnd = 684268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FilterByTags(ref UGCQueryHandle_t qHandle, List<string> tags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref qHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tags);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterByTags_Private_Static_Void_byref_UGCQueryHandle_t_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684269, XrefRangeEnd = 684272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FilterByInternalName(ref UGCQueryHandle_t qHandle, string internalName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref qHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(internalName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterByInternalName_Private_Static_Void_byref_UGCQueryHandle_t_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684287, RefRangeEnd = 684288, XrefRangeStart = 684272, XrefRangeEnd = 684287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SteamAPICall_t GenerateSingleItemQuery(ulong publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSingleItemQuery_Public_Static_SteamAPICall_t_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SteamAPICall_t*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684304, RefRangeEnd = 684308, XrefRangeStart = 684288, XrefRangeEnd = 684304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SteamAPICall_t GenerateModBrowserQuery(string queryCursor, List<string> tags = null, string internalName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(queryCursor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(internalName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateModBrowserQuery_Public_Static_SteamAPICall_t_String_List_1_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SteamAPICall_t*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684310, RefRangeEnd = 684311, XrefRangeStart = 684308, XrefRangeEnd = 684310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FetchPlayTimeStats(UGCQueryHandle_t handle, uint index, out ulong hot, out ulong downloads)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&handle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hot);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref downloads);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchPlayTimeStats_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684312, RefRangeEnd = 684313, XrefRangeStart = 684311, XrefRangeEnd = 684312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FetchPreviewImageUrl(UGCQueryHandle_t handle, uint index, out string modIconUrl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchPreviewImageUrl_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		modIconUrl = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684324, RefRangeEnd = 684325, XrefRangeStart = 684313, XrefRangeEnd = 684324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FetchTagName(UGCQueryHandle_t handle, uint index, out List<string> tags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchTagName_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		tags = ((num3 == 0) ? null : new List<string>(num3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684332, RefRangeEnd = 684333, XrefRangeStart = 684325, XrefRangeEnd = 684332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FetchMetadata(UGCQueryHandle_t handle, uint index, out NameValueCollection metadata)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchMetadata_Public_Static_Void_UGCQueryHandle_t_UInt32_byref_NameValueCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		metadata = ((num3 == 0) ? null : new NameValueCollection(num3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684335, RefRangeEnd = 684336, XrefRangeStart = 684333, XrefRangeEnd = 684335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForceCallbacks()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceCallbacks_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684336, XrefRangeEnd = 684337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopPlaytimeTracking()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnGameExitCleanup()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGameExitCleanup_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684337, XrefRangeEnd = 684338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetWorkshopItemState(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorkshopItemState_Public_Static_UInt32_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684338, XrefRangeEnd = 684339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ItemInstallInfo GetInstallInfo(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstallInfo_Public_Static_ItemInstallInfo_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ItemInstallInfo(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 684347, RefRangeEnd = 684349, XrefRangeStart = 684339, XrefRangeEnd = 684347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UninstallWorkshopItem(PublishedFileId_t publishId, string installPath = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&publishId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(installPath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UninstallWorkshopItem_Public_Static_Void_PublishedFileId_t_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684349, XrefRangeEnd = 684370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupACF()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupACF_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684402, RefRangeEnd = 684403, XrefRangeStart = 684370, XrefRangeEnd = 684402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UninstallACF(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UninstallACF_Private_Static_Void_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 684407, RefRangeEnd = 684409, XrefRangeStart = 684403, XrefRangeEnd = 684407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWorkshopItemDownloading(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorkshopItemDownloading_Public_Static_Boolean_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684409, XrefRangeEnd = 684413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWorkshopItemInstalled(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorkshopItemInstalled_Public_Static_Boolean_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684417, RefRangeEnd = 684418, XrefRangeStart = 684413, XrefRangeEnd = 684417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWorkshopItemInstalledOrMiss(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorkshopItemInstalledOrMiss_Public_Static_Boolean_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 684422, RefRangeEnd = 684424, XrefRangeStart = 684418, XrefRangeEnd = 684422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DoesWorkshopItemNeedUpdate(PublishedFileId_t publishId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoesWorkshopItemNeedUpdate_Public_Static_Int32_PublishedFileId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public SteamedWraps(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
