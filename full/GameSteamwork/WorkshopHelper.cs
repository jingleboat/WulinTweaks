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
using Newtonsoft.Json;
using Steamworks;

namespace GameSteamwork;

public class WorkshopHelper : Il2CppSystem.Object
{
	public sealed class SteamWorkshopItem : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Title;

		private static readonly System.IntPtr NativeFieldInfoPtr_Description;

		private static readonly System.IntPtr NativeFieldInfoPtr_Tags;

		private static readonly System.IntPtr NativeFieldInfoPtr_ContentFolderPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_PreviewImagePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;

		private static readonly System.IntPtr NativeFieldInfoPtr_BuildData;

		public unsafe string Title
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Title)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string Description
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppStringArray Tags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tags);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe string ContentFolderPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContentFolderPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContentFolderPath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string PreviewImagePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewImagePath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewImagePath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppSystem.Nullable<ERemoteStoragePublishedFileVisibility> Visibility
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility);
				return new Il2CppSystem.Nullable<ERemoteStoragePublishedFileVisibility>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ERemoteStoragePublishedFileVisibility>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ERemoteStoragePublishedFileVisibility>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NameValueCollection BuildData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameValueCollection));
			}
		}

		static SteamWorkshopItem()
		{
			Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "SteamWorkshopItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr);
			NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "Title");
			NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "Description");
			NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "Tags");
			NativeFieldInfoPtr_ContentFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "ContentFolderPath");
			NativeFieldInfoPtr_PreviewImagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "PreviewImagePath");
			NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "Visibility");
			NativeFieldInfoPtr_BuildData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "BuildData");
		}

		public SteamWorkshopItem(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SteamWorkshopItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr))
		{
		}
	}

	public class ModSubscribedFinder : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__ModPaths_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ModPaths_Public_get_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ModPaths_Private_set_Void_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetListOfSubscribedItemsPaths_Public_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Boolean_WorkshopIssueReporter_0;

		public unsafe List<string> _ModPaths_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ModPaths_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ModPaths_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> ModPaths
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 13952, RefRangeEnd = 13960, XrefRangeStart = 13952, XrefRangeEnd = 13960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ModPaths_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 13960, RefRangeEnd = 13981, XrefRangeStart = 13960, XrefRangeEnd = 13981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ModPaths_Private_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static ModSubscribedFinder()
		{
			Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "ModSubscribedFinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr);
			NativeFieldInfoPtr__ModPaths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr, "<ModPaths>k__BackingField");
			NativeMethodInfoPtr_get_ModPaths_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr, 100684873);
			NativeMethodInfoPtr_set_ModPaths_Private_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr, 100684874);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr, 100684875);
			NativeMethodInfoPtr_GetListOfSubscribedItemsPaths_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr, 100684876);
			NativeMethodInfoPtr_Refresh_Public_Boolean_WorkshopIssueReporter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr, 100684877);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693968, XrefRangeEnd = 693975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModSubscribedFinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModSubscribedFinder>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694011, RefRangeEnd = 694012, XrefRangeStart = 693975, XrefRangeEnd = 694011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetListOfSubscribedItemsPaths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListOfSubscribedItemsPaths_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694050, RefRangeEnd = 694051, XrefRangeStart = 694012, XrefRangeEnd = 694050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Refresh(WorkshopIssueReporter issueReporter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)issueReporter);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Boolean_WorkshopIssueReporter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public ModSubscribedFinder(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ModSelfModFinder : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__ModPaths_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ModPaths_Public_get_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ModPaths_Private_set_Void_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetListOfSelfModsPaths_Public_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Boolean_WorkshopIssueReporter_0;

		public unsafe List<string> _ModPaths_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ModPaths_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ModPaths_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> ModPaths
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 13952, RefRangeEnd = 13960, XrefRangeStart = 13952, XrefRangeEnd = 13960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ModPaths_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 13960, RefRangeEnd = 13981, XrefRangeStart = 13960, XrefRangeEnd = 13981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ModPaths_Private_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static ModSelfModFinder()
		{
			Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "ModSelfModFinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr);
			NativeFieldInfoPtr__ModPaths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr, "<ModPaths>k__BackingField");
			NativeMethodInfoPtr_get_ModPaths_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr, 100684878);
			NativeMethodInfoPtr_set_ModPaths_Private_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr, 100684879);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr, 100684880);
			NativeMethodInfoPtr_GetListOfSelfModsPaths_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr, 100684881);
			NativeMethodInfoPtr_Refresh_Public_Boolean_WorkshopIssueReporter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr, 100684882);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694051, XrefRangeEnd = 694058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModSelfModFinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModSelfModFinder>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694058, XrefRangeEnd = 694073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetListOfSelfModsPaths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListOfSelfModsPaths_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694125, RefRangeEnd = 694126, XrefRangeStart = 694073, XrefRangeEnd = 694125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Refresh(WorkshopIssueReporter issueReporter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)issueReporter);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Boolean_WorkshopIssueReporter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public ModSelfModFinder(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class APublisherInstance : Il2CppSystem.Object
	{
		public sealed class FinishedPublishingAction : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_APublisherInstance_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_APublisherInstance_Boolean_AsyncCallback_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

			static FinishedPublishingAction()
			{
				Il2CppClassPointerStore<FinishedPublishingAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "FinishedPublishingAction");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishedPublishingAction>.NativeClassPtr, 100689700);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_APublisherInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishedPublishingAction>.NativeClassPtr, 100689701);
				NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_APublisherInstance_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishedPublishingAction>.NativeClassPtr, 100689702);
				NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishedPublishingAction>.NativeClassPtr, 100689703);
			}

			[CallerCount(4489)]
			[CachedScanResults(RefRangeStart = 20323, RefRangeEnd = 24812, XrefRangeStart = 20323, XrefRangeEnd = 24812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FinishedPublishingAction(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishedPublishingAction>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 486610, RefRangeEnd = 486615, XrefRangeStart = 486610, XrefRangeEnd = 486615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Invoke(APublisherInstance instance, bool result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
				*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_APublisherInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694126, XrefRangeEnd = 694130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(APublisherInstance instance, bool result, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
				*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_APublisherInstance_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 24842, RefRangeEnd = 24846, XrefRangeStart = 24842, XrefRangeEnd = 24846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public FinishedPublishingAction(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public static implicit operator FinishedPublishingAction(System.Action<APublisherInstance, bool> P_0)
			{
				return DelegateSupport.ConvertDelegate<FinishedPublishingAction>((System.Delegate)P_0);
			}

			public static FinishedPublishingAction operator +(FinishedPublishingAction P_0, FinishedPublishingAction P_1)
			{
				return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<FinishedPublishingAction>();
			}

			public static FinishedPublishingAction operator -(FinishedPublishingAction P_0, FinishedPublishingAction P_1)
			{
				object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<FinishedPublishingAction>();
				}
				return (FinishedPublishingAction)obj;
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__publicity;

		private static readonly System.IntPtr NativeFieldInfoPtr__entryData;

		private static readonly System.IntPtr NativeFieldInfoPtr__publishedFileID;

		private static readonly System.IntPtr NativeFieldInfoPtr__updateHandle;

		private static readonly System.IntPtr NativeFieldInfoPtr__createItemHook;

		private static readonly System.IntPtr NativeFieldInfoPtr__updateItemHook;

		private static readonly System.IntPtr NativeFieldInfoPtr__endAction;

		private static readonly System.IntPtr NativeFieldInfoPtr__issueReporter;

		private static readonly System.IntPtr NativeFieldInfoPtr_Mod;

		private static readonly System.IntPtr NativeFieldInfoPtr_SerializerSettings;

		private static readonly System.IntPtr NativeMethodInfoPtr_PublishContent_Public_Void_TmodFile_FinishedPublishingAction_WorkshopIssueReporter_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetVisibility_Private_ERemoteStoragePublishedFileVisibility_VisibleType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateItem_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateItemResult_Private_Void_CreateItemResult_t_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateItem_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateItemResult_Private_Void_SubmitItemUpdateResult_t_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryGetProgress_Public_Boolean_byref_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe PublishSettings.VisibleType _publicity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__publicity);
				return *(PublishSettings.VisibleType*)num;
			}
			set
			{
				*(PublishSettings.VisibleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__publicity)) = visibleType;
			}
		}

		public unsafe SteamWorkshopItem _entryData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entryData);
				return new SteamWorkshopItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entryData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamWorkshopItem)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe PublishedFileId_t _publishedFileID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__publishedFileID);
				return *(PublishedFileId_t*)num;
			}
			set
			{
				*(PublishedFileId_t*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__publishedFileID)) = publishedFileId_t;
			}
		}

		public unsafe UGCUpdateHandle_t _updateHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateHandle);
				return *(UGCUpdateHandle_t*)num;
			}
			set
			{
				*(UGCUpdateHandle_t*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateHandle)) = uGCUpdateHandle_t;
			}
		}

		public unsafe CallResult<CreateItemResult_t> _createItemHook
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__createItemHook);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CallResult<CreateItemResult_t>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__createItemHook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callResult));
			}
		}

		public unsafe CallResult<SubmitItemUpdateResult_t> _updateItemHook
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateItemHook);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CallResult<SubmitItemUpdateResult_t>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateItemHook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callResult));
			}
		}

		public unsafe FinishedPublishingAction _endAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__endAction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FinishedPublishingAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__endAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)finishedPublishingAction));
			}
		}

		public unsafe WorkshopIssueReporter _issueReporter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__issueReporter);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorkshopIssueReporter>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__issueReporter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)workshopIssueReporter));
			}
		}

		public unsafe TmodFile Mod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mod);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TmodFile>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mod)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tmodFile));
			}
		}

		public unsafe static JsonSerializerSettings SerializerSettings
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SerializerSettings, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<JsonSerializerSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SerializerSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jsonSerializerSettings));
			}
		}

		static APublisherInstance()
		{
			Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "APublisherInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr);
			NativeFieldInfoPtr__publicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_publicity");
			NativeFieldInfoPtr__entryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_entryData");
			NativeFieldInfoPtr__publishedFileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_publishedFileID");
			NativeFieldInfoPtr__updateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_updateHandle");
			NativeFieldInfoPtr__createItemHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_createItemHook");
			NativeFieldInfoPtr__updateItemHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_updateItemHook");
			NativeFieldInfoPtr__endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_endAction");
			NativeFieldInfoPtr__issueReporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "_issueReporter");
			NativeFieldInfoPtr_Mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "Mod");
			NativeFieldInfoPtr_SerializerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, "SerializerSettings");
			NativeMethodInfoPtr_PublishContent_Public_Void_TmodFile_FinishedPublishingAction_WorkshopIssueReporter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684883);
			NativeMethodInfoPtr_GetVisibility_Private_ERemoteStoragePublishedFileVisibility_VisibleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684884);
			NativeMethodInfoPtr_CreateItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684885);
			NativeMethodInfoPtr_CreateItemResult_Private_Void_CreateItemResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684886);
			NativeMethodInfoPtr_UpdateItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684887);
			NativeMethodInfoPtr_UpdateItemResult_Private_Void_SubmitItemUpdateResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684888);
			NativeMethodInfoPtr_TryGetProgress_Public_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684889);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr, 100684890);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694174, RefRangeEnd = 694175, XrefRangeStart = 694130, XrefRangeEnd = 694174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublishContent(TmodFile mod, FinishedPublishingAction endAction, WorkshopIssueReporter issueReporter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mod);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endAction);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)issueReporter);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PublishContent_Public_Void_TmodFile_FinishedPublishingAction_WorkshopIssueReporter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe ERemoteStoragePublishedFileVisibility GetVisibility(PublishSettings.VisibleType publicityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&publicityId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVisibility_Private_ERemoteStoragePublishedFileVisibility_VisibleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ERemoteStoragePublishedFileVisibility*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694175, XrefRangeEnd = 694189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694189, XrefRangeEnd = 694200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateItemResult(CreateItemResult_t param, bool bIOFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&param);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItemResult_Private_Void_CreateItemResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694296, RefRangeEnd = 694297, XrefRangeStart = 694200, XrefRangeEnd = 694296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694297, XrefRangeEnd = 694332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateItemResult(SubmitItemUpdateResult_t param, bool bIOFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&param);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateItemResult_Private_Void_SubmitItemUpdateResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694338, RefRangeEnd = 694339, XrefRangeStart = 694332, XrefRangeEnd = 694338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetProgress(out float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref progress);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetProgress_Public_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe APublisherInstance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<APublisherInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public APublisherInstance(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class QueryHelper : Il2CppSystem.Object
	{
		public class AQueryInstance : Il2CppSystem.Object
		{
			[ObfuscatedName("GameSteamwork.WorkshopHelper+QueryHelper+AQueryInstance+<>c__DisplayClass9_0")]
			public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_metadata;

				private static readonly System.IntPtr NativeFieldInfoPtr_id;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__ProcessPageResult_b__0_Internal_Boolean_String_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__ProcessPageResult_b__1_Internal_Boolean_TmodFile_0;

				public unsafe NameValueCollection metadata
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metadata);
						System.IntPtr intPtr = *(System.IntPtr*)num;
						return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr) : null;
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metadata)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameValueCollection));
					}
				}

				public unsafe PublishedFileId_t id
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
						return *(PublishedFileId_t*)num;
					}
					set
					{
						*(PublishedFileId_t*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = publishedFileId_t;
					}
				}

				static __c__DisplayClass9_0()
				{
					Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "<>c__DisplayClass9_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr);
					NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "metadata");
					NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "id");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100689794);
					NativeMethodInfoPtr__ProcessPageResult_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100689795);
					NativeMethodInfoPtr__ProcessPageResult_b__1_Internal_Boolean_TmodFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100689796);
				}

				[CallerCount(2961)]
				[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass9_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr))
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				[CallerCount(0)]
				public unsafe bool _ProcessPageResult_b__0(string k)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(k);
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProcessPageResult_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
				}

				[CallerCount(0)]
				public unsafe bool _ProcessPageResult_b__1(TmodFile m)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProcessPageResult_b__1_Internal_Boolean_TmodFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
				}

				public __c__DisplayClass9_0(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			[System.Serializable]
			[ObfuscatedName("GameSteamwork.WorkshopHelper+QueryHelper+AQueryInstance+<>c")]
			public sealed class __c : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr___9;

				private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__FastQueryItem_b__11_0_Internal_UInt64_PublishedFileId_t_0;

				public unsafe static __c __9
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
					}
				}

				public unsafe static Il2CppSystem.Func<PublishedFileId_t, ulong> __9__11_0
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<PublishedFileId_t, ulong>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__11_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
					}
				}

				static __c()
				{
					Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
					NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
					NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__11_0");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100689798);
					NativeMethodInfoPtr__FastQueryItem_b__11_0_Internal_UInt64_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100689799);
				}

				[CallerCount(2961)]
				[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 59865, RefRangeEnd = 59866, XrefRangeStart = 59865, XrefRangeEnd = 59866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ulong _FastQueryItem_b__11_0(PublishedFileId_t x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = (nint)(&x);
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FastQueryItem_b__11_0_Internal_UInt64_PublishedFileId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
				}

				public __c(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr__queryHook;

			private static readonly System.IntPtr NativeFieldInfoPtr__primaryUGCHandle;

			private static readonly System.IntPtr NativeFieldInfoPtr__primaryQueryResult;

			private static readonly System.IntPtr NativeFieldInfoPtr__queryReturnCount;

			private static readonly System.IntPtr NativeFieldInfoPtr__nextCursor;

			private static readonly System.IntPtr NativeFieldInfoPtr_ugcChildren;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_OnWorkshopQueryInitialized_Private_Void_SteamUGCQueryCompleted_t_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_QueryAllWorkshopItems_Public_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_ProcessPageResult_Private_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseWorkshopQuery_Private_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_FastQueryItem_Internal_SteamUGCDetails_t_UInt64_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SearchByInternalName_Internal_Boolean_String_byref_SteamUGCDetails_t_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_TryRunQuery_Internal_Boolean_SteamAPICall_t_0;

			public unsafe CallResult<SteamUGCQueryCompleted_t> _queryHook
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queryHook);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CallResult<SteamUGCQueryCompleted_t>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queryHook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callResult));
				}
			}

			public unsafe UGCQueryHandle_t _primaryUGCHandle
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryUGCHandle);
					return *(UGCQueryHandle_t*)num;
				}
				set
				{
					*(UGCQueryHandle_t*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryUGCHandle)) = uGCQueryHandle_t;
				}
			}

			public unsafe EResult _primaryQueryResult
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryQueryResult);
					return *(EResult*)num;
				}
				set
				{
					*(EResult*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryQueryResult)) = eResult;
				}
			}

			public unsafe uint _queryReturnCount
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queryReturnCount);
					return *(uint*)num;
				}
				set
				{
					*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queryReturnCount)) = num;
				}
			}

			public unsafe string _nextCursor
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextCursor);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextCursor)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe List<ulong> ugcChildren
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ugcChildren);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ugcChildren)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
				}
			}

			static AQueryInstance()
			{
				Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "AQueryInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr);
				NativeFieldInfoPtr__queryHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "_queryHook");
				NativeFieldInfoPtr__primaryUGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "_primaryUGCHandle");
				NativeFieldInfoPtr__primaryQueryResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "_primaryQueryResult");
				NativeFieldInfoPtr__queryReturnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "_queryReturnCount");
				NativeFieldInfoPtr__nextCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "_nextCursor");
				NativeFieldInfoPtr_ugcChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, "ugcChildren");
				NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689704);
				NativeMethodInfoPtr_OnWorkshopQueryInitialized_Private_Void_SteamUGCQueryCompleted_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689705);
				NativeMethodInfoPtr_QueryAllWorkshopItems_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689706);
				NativeMethodInfoPtr_ProcessPageResult_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689707);
				NativeMethodInfoPtr_ReleaseWorkshopQuery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689708);
				NativeMethodInfoPtr_FastQueryItem_Internal_SteamUGCDetails_t_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689709);
				NativeMethodInfoPtr_SearchByInternalName_Internal_Boolean_String_byref_SteamUGCDetails_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689710);
				NativeMethodInfoPtr_TryRunQuery_Internal_Boolean_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr, 100689711);
			}

			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 694357, RefRangeEnd = 694364, XrefRangeStart = 694339, XrefRangeEnd = 694357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AQueryInstance()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AQueryInstance>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694364, XrefRangeEnd = 694371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnWorkshopQueryInitialized(SteamUGCQueryCompleted_t pCallback, bool bIOFailure)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pCallback));
				*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWorkshopQueryInitialized_Private_Void_SteamUGCQueryCompleted_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 694395, RefRangeEnd = 694397, XrefRangeStart = 694371, XrefRangeEnd = 694395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool QueryAllWorkshopItems()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryAllWorkshopItems_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 694475, RefRangeEnd = 694476, XrefRangeStart = 694397, XrefRangeEnd = 694475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ProcessPageResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessPageResult_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694476, XrefRangeEnd = 694480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ReleaseWorkshopQuery()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseWorkshopQuery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 694517, RefRangeEnd = 694521, XrefRangeStart = 694480, XrefRangeEnd = 694517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SteamUGCDetails_t FastQueryItem(ulong publishedId, bool queryChildren = false)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&publishedId);
				*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryChildren;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastQueryItem_Internal_SteamUGCDetails_t_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new SteamUGCDetails_t(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694521, XrefRangeEnd = 694529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool SearchByInternalName(string modName, out SteamUGCDetails_t itemDetails)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(modName);
				byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
				nint num2 = 0;
				*(nint**)num = &num2;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchByInternalName_Internal_Boolean_String_byref_SteamUGCDetails_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				nint num3 = num2;
				itemDetails = ((num3 == 0) ? null : new SteamUGCDetails_t(num3));
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 694545, RefRangeEnd = 694550, XrefRangeStart = 694529, XrefRangeEnd = 694545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryRunQuery(SteamAPICall_t query)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&query);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryRunQuery_Internal_Boolean_SteamAPICall_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public AQueryInstance(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("GameSteamwork.WorkshopHelper+QueryHelper+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_publishID;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FindModDownloadItem_b__0_Internal_Boolean_ModDownloadItem_0;

			public unsafe ulong publishID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publishID);
					return *(ulong*)num;
				}
				set
				{
					*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publishID)) = num;
				}
			}

			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
				NativeFieldInfoPtr_publishID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "publishID");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100689712);
				NativeMethodInfoPtr__FindModDownloadItem_b__0_Internal_Boolean_ModDownloadItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100689713);
			}

			[CallerCount(2961)]
			[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _FindModDownloadItem_b__0(ModDownloadItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindModDownloadItem_b__0_Internal_Boolean_ModDownloadItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass5_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_QueryPagingConst;

		private static readonly System.IntPtr NativeFieldInfoPtr_IncompleteModCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_HiddenModCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_TotalItemsQueried;

		private static readonly System.IntPtr NativeFieldInfoPtr_Items;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindModDownloadItem_Public_Static_ModDownloadItem_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalItemsQueried_Public_Static_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_QueryWorkshop_Internal_Static_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HandleError_Internal_Static_Boolean_EResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Internal_Static_String_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamOwner_Internal_Static_UInt64_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDependencies_Private_Static_List_1_UInt64_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDependenciesRecursive_Internal_Static_Void_UInt64_byref_HashSet_1_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPublishIdByInternalName_Internal_Static_Boolean_String_byref_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckWorkshopConnection_Internal_Static_Boolean_0;

		public unsafe static int QueryPagingConst
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QueryPagingConst, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QueryPagingConst, (void*)(&num));
			}
		}

		public unsafe static int IncompleteModCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IncompleteModCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IncompleteModCount, (void*)(&num));
			}
		}

		public unsafe static int HiddenModCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HiddenModCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HiddenModCount, (void*)(&num));
			}
		}

		public unsafe static uint TotalItemsQueried
		{
			get
			{
				Unsafe.SkipInit(out uint result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TotalItemsQueried, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TotalItemsQueried, (void*)(&num));
			}
		}

		public unsafe static List<ModDownloadItem> Items
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Items, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ModDownloadItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Items, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static QueryHelper()
		{
			Il2CppClassPointerStore<QueryHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "QueryHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr);
			NativeFieldInfoPtr_QueryPagingConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "QueryPagingConst");
			NativeFieldInfoPtr_IncompleteModCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "IncompleteModCount");
			NativeFieldInfoPtr_HiddenModCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "HiddenModCount");
			NativeFieldInfoPtr_TotalItemsQueried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "TotalItemsQueried");
			NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, "Items");
			NativeMethodInfoPtr_FindModDownloadItem_Public_Static_ModDownloadItem_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684892);
			NativeMethodInfoPtr_GetTotalItemsQueried_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684893);
			NativeMethodInfoPtr_QueryWorkshop_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684894);
			NativeMethodInfoPtr_HandleError_Internal_Static_Boolean_EResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684895);
			NativeMethodInfoPtr_GetDescription_Internal_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684896);
			NativeMethodInfoPtr_GetSteamOwner_Internal_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684897);
			NativeMethodInfoPtr_GetDependencies_Private_Static_List_1_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684898);
			NativeMethodInfoPtr_GetDependenciesRecursive_Internal_Static_Void_UInt64_byref_HashSet_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684899);
			NativeMethodInfoPtr_GetPublishIdByInternalName_Internal_Static_Boolean_String_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684900);
			NativeMethodInfoPtr_CheckWorkshopConnection_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100684901);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 694570, RefRangeEnd = 694572, XrefRangeStart = 694550, XrefRangeEnd = 694570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ModDownloadItem FindModDownloadItem(ulong publishID)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&publishID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindModDownloadItem_Public_Static_ModDownloadItem_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModDownloadItem>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694572, XrefRangeEnd = 694576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTotalItemsQueried()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalItemsQueried_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694591, RefRangeEnd = 694592, XrefRangeStart = 694576, XrefRangeEnd = 694591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueryWorkshop()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryWorkshop_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe static bool HandleError(EResult eResult)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&eResult);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleError_Internal_Static_Boolean_EResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694598, RefRangeEnd = 694599, XrefRangeStart = 694592, XrefRangeEnd = 694598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDescription(ulong publishedId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&publishedId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescription_Internal_Static_String_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 694604, RefRangeEnd = 694607, XrefRangeStart = 694599, XrefRangeEnd = 694604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetSteamOwner(ulong publishedId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&publishedId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamOwner_Internal_Static_UInt64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694607, XrefRangeEnd = 694612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ulong> GetDependencies(ulong publishedId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&publishedId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDependencies_Private_Static_List_1_UInt64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694640, RefRangeEnd = 694641, XrefRangeStart = 694612, XrefRangeEnd = 694640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDependenciesRecursive(ulong publishedId, ref HashSet<ulong> set)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&publishedId);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDependenciesRecursive_Internal_Static_Void_UInt64_byref_HashSet_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			set = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<ulong>(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694641, XrefRangeEnd = 694654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetPublishIdByInternalName(string internalName, out ulong publishId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(internalName);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref publishId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPublishIdByInternalName_Internal_Static_Boolean_String_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694654, XrefRangeEnd = 694679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckWorkshopConnection()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckWorkshopConnection_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public QueryHelper(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_TagsCollection;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisApp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ManifestFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MetadataKeys;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkshopFolder_Public_Static_String_AppId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AWorkshopTagsCollection TagsCollection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TagsCollection, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AWorkshopTagsCollection>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TagsCollection, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aWorkshopTagsCollection));
		}
	}

	public unsafe static AppId_t thisApp
	{
		get
		{
			Unsafe.SkipInit(out AppId_t result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_thisApp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_thisApp, (void*)(&appId_t));
		}
	}

	public unsafe static string ManifestFileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ManifestFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ManifestFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray MetadataKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MetadataKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MetadataKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static WorkshopHelper()
	{
		Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameSteamwork", "WorkshopHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr);
		NativeFieldInfoPtr_TagsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "TagsCollection");
		NativeFieldInfoPtr_thisApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "thisApp");
		NativeFieldInfoPtr_ManifestFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "ManifestFileName");
		NativeFieldInfoPtr_MetadataKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, "MetadataKeys");
		NativeMethodInfoPtr_GetWorkshopFolder_Public_Static_String_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, 100664639);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr, 100664640);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 694697, RefRangeEnd = 694702, XrefRangeStart = 694679, XrefRangeEnd = 694697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWorkshopFolder(AppId_t app)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&app);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorkshopFolder_Public_Static_String_AppId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorkshopHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorkshopHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
