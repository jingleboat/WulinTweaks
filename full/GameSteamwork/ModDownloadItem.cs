using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Steamworks;
using UnityEngine;

namespace GameSteamwork;

public class ModDownloadItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TitleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionLong;

	private static readonly System.IntPtr NativeFieldInfoPtr_ModIconURL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemURL;

	private static readonly System.IntPtr NativeFieldInfoPtr_PublishId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Downloads;

	private static readonly System.IntPtr NativeFieldInfoPtr_Hot;

	private static readonly System.IntPtr NativeFieldInfoPtr_NeedUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_Installed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tags;

	private static readonly System.IntPtr NativeFieldInfoPtr_VotesDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_VotesUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_Score;

	private static readonly System.IntPtr NativeFieldInfoPtr_selfVote;

	private static readonly System.IntPtr NativeFieldInfoPtr_CreatorName;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastUpdateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_FileSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_CreateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mod;

	private static readonly System.IntPtr NativeFieldInfoPtr_texture2D;

	private static readonly System.IntPtr NativeFieldInfoPtr__queryVote;

	private static readonly System.IntPtr NativeFieldInfoPtr_mFuncVoteResult;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_String_String_UInt64_Int32_Int32_Boolean_TmodFile_Int32_Int32_Single_String_String_UInt32_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLongDesc_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDependenciesRecursive_Public_Void_ModDownloadItem_byref_HashSet_1_ModDownloadItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVoteResult_Public_Void_Action_1_ModDownloadItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUserItemVoteResult_Private_Void_GetUserItemVoteResult_t_Boolean_0;

	public unsafe string TitleName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TitleName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TitleName)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe string DescriptionLong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionLong);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionLong)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ModIconURL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModIconURL);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModIconURL)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ItemURL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemURL);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemURL)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ulong PublishId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PublishId);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PublishId)) = num;
		}
	}

	public unsafe int Downloads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Downloads);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Downloads)) = num;
		}
	}

	public unsafe int Hot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hot);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hot)) = num;
		}
	}

	public unsafe bool NeedUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedUpdate)) = flag;
		}
	}

	public unsafe bool Installed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Installed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Installed)) = flag;
		}
	}

	public unsafe List<string> Tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int VotesDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VotesDown);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VotesDown)) = num;
		}
	}

	public unsafe int VotesUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VotesUp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VotesUp)) = num;
		}
	}

	public unsafe float Score
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Score);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Score)) = num;
		}
	}

	public unsafe int selfVote
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfVote);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfVote)) = num;
		}
	}

	public unsafe string CreatorName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreatorName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreatorName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe uint LastUpdateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUpdateTime);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUpdateTime)) = num;
		}
	}

	public unsafe int FileSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileSize)) = num;
		}
	}

	public unsafe uint CreateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateTime);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateTime)) = num;
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

	public unsafe Texture2D texture2D
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture2D);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture2D)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe CallResult<GetUserItemVoteResult_t> _queryVote
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queryVote);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CallResult<GetUserItemVoteResult_t>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queryVote)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callResult));
		}
	}

	public unsafe Il2CppSystem.Action<ModDownloadItem> mFuncVoteResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFuncVoteResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ModDownloadItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFuncVoteResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static ModDownloadItem()
	{
		Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameSteamwork", "ModDownloadItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr);
		NativeFieldInfoPtr_TitleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "TitleName");
		NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Description");
		NativeFieldInfoPtr_DescriptionLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "DescriptionLong");
		NativeFieldInfoPtr_ModIconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "ModIconURL");
		NativeFieldInfoPtr_ItemURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "ItemURL");
		NativeFieldInfoPtr_PublishId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "PublishId");
		NativeFieldInfoPtr_Downloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Downloads");
		NativeFieldInfoPtr_Hot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Hot");
		NativeFieldInfoPtr_NeedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "NeedUpdate");
		NativeFieldInfoPtr_Installed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Installed");
		NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Tags");
		NativeFieldInfoPtr_VotesDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "VotesDown");
		NativeFieldInfoPtr_VotesUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "VotesUp");
		NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Score");
		NativeFieldInfoPtr_selfVote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "selfVote");
		NativeFieldInfoPtr_CreatorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "CreatorName");
		NativeFieldInfoPtr_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "LastUpdateTime");
		NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "FileSize");
		NativeFieldInfoPtr_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "CreateTime");
		NativeFieldInfoPtr_Mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "Mod");
		NativeFieldInfoPtr_texture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "texture2D");
		NativeFieldInfoPtr__queryVote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "_queryVote");
		NativeFieldInfoPtr_mFuncVoteResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, "mFuncVoteResult");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_String_String_UInt64_Int32_Int32_Boolean_TmodFile_Int32_Int32_Single_String_String_UInt32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_GetLongDesc_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_GetDependenciesRecursive_Public_Void_ModDownloadItem_byref_HashSet_1_ModDownloadItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_GetVoteResult_Public_Void_Action_1_ModDownloadItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_OnUserItemVoteResult_Private_Void_GetUserItemVoteResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr, 100664626);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693795, RefRangeEnd = 693796, XrefRangeStart = 693773, XrefRangeEnd = 693795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModDownloadItem(string titleName, string description, List<string> tags, string modIconURL, ulong publishId, int downloads, int hot, bool needUpdate, TmodFile mod, int votesDown, int votesUp, float score, string itemUrl, string creatorName, uint lastUpdateTime, int fileSize, uint createTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModDownloadItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(titleName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(modIconURL);
		*(ulong**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &publishId;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &downloads;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hot;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &needUpdate;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mod);
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &votesDown;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &votesUp;
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &score;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(itemUrl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(creatorName);
		*(uint**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastUpdateTime;
		*(int**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileSize;
		*(uint**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &createTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_String_String_UInt64_Int32_Int32_Boolean_TmodFile_Int32_Int32_Single_String_String_UInt32_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693800, RefRangeEnd = 693801, XrefRangeStart = 693796, XrefRangeEnd = 693800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLongDesc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLongDesc_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDependenciesRecursive(ModDownloadItem item, ref HashSet<ModDownloadItem> set)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDependenciesRecursive_Public_Void_ModDownloadItem_byref_HashSet_1_ModDownloadItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		set = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<ModDownloadItem>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693809, RefRangeEnd = 693810, XrefRangeStart = 693801, XrefRangeEnd = 693809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVoteResult(Il2CppSystem.Action<ModDownloadItem> funcResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)funcResult);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVoteResult_Public_Void_Action_1_ModDownloadItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693810, XrefRangeEnd = 693815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserItemVoteResult(GetUserItemVoteResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pCallback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUserItemVoteResult_Private_Void_GetUserItemVoteResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModDownloadItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
