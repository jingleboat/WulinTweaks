using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class News : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Issue;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomIdsDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_PropRankType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PropRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_FactionsNeedWanted;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompetitionIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompetitionResults;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanShowIntroduction_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomId_Public_Void_NewsType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRandomId_Public_Void_NewsType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomIdPairs_Public_Enumerator_NewsType_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomIds_Public_List_1_Int32_NewsType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEvent_Public_Void_NewsType_EventNewsItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEvent_Public_Void_NewsType_EventNewsItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventItems_Public_List_1_EventNewsItem_NewsType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompetitionCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompetitionId_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompetitionResult_Public_List_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCompetition_Public_Void_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int Issue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Issue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Issue)) = num;
		}
	}

	public unsafe Dictionary<NewsType, List<int>> randomIdsDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomIdsDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewsType, List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomIdsDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<NewsType, List<EventNewsItem>> eventDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewsType, List<EventNewsItem>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe string PropRankType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PropRankType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PropRankType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<int> PropRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PropRank);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PropRank)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FactionInstance> FactionsNeedWanted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactionsNeedWanted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactionsNeedWanted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool HasRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasRead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasRead)) = flag;
		}
	}

	public unsafe int RepLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepLevel)) = num;
		}
	}

	public unsafe List<int> CompetitionIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompetitionIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompetitionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<int>> CompetitionResults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompetitionResults);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompetitionResults)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static News()
	{
		Il2CppClassPointerStore<News>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "News");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<News>.NativeClassPtr);
		NativeFieldInfoPtr_Issue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "Issue");
		NativeFieldInfoPtr_randomIdsDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "randomIdsDict");
		NativeFieldInfoPtr_eventDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "eventDict");
		NativeFieldInfoPtr_PropRankType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "PropRankType");
		NativeFieldInfoPtr_PropRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "PropRank");
		NativeFieldInfoPtr_FactionsNeedWanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "FactionsNeedWanted");
		NativeFieldInfoPtr_HasRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "HasRead");
		NativeFieldInfoPtr_RepLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "RepLevel");
		NativeFieldInfoPtr_CompetitionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "CompetitionIds");
		NativeFieldInfoPtr_CompetitionResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<News>.NativeClassPtr, "CompetitionResults");
		NativeMethodInfoPtr_CanShowIntroduction_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675074);
		NativeMethodInfoPtr_AddRandomId_Public_Void_NewsType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675075);
		NativeMethodInfoPtr_RemoveRandomId_Public_Void_NewsType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675076);
		NativeMethodInfoPtr_GetRandomIdPairs_Public_Enumerator_NewsType_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675077);
		NativeMethodInfoPtr_GetRandomIds_Public_List_1_Int32_NewsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675078);
		NativeMethodInfoPtr_AddEvent_Public_Void_NewsType_EventNewsItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675079);
		NativeMethodInfoPtr_RemoveEvent_Public_Void_NewsType_EventNewsItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675080);
		NativeMethodInfoPtr_GetEventItems_Public_List_1_EventNewsItem_NewsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675081);
		NativeMethodInfoPtr_GetCompetitionCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675082);
		NativeMethodInfoPtr_GetCompetitionId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675083);
		NativeMethodInfoPtr_GetCompetitionResult_Public_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675084);
		NativeMethodInfoPtr_AddCompetition_Public_Void_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675085);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<News>.NativeClassPtr, 100675086);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749133, RefRangeEnd = 749134, XrefRangeStart = 749133, XrefRangeEnd = 749134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanShowIntroduction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanShowIntroduction_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890462, RefRangeEnd = 890464, XrefRangeStart = 890438, XrefRangeEnd = 890462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRandomId(NewsType newsType, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newsType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRandomId_Public_Void_NewsType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890484, RefRangeEnd = 890485, XrefRangeStart = 890464, XrefRangeEnd = 890484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRandomId(NewsType newsType, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newsType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRandomId_Public_Void_NewsType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890488, RefRangeEnd = 890489, XrefRangeStart = 890485, XrefRangeEnd = 890488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<NewsType, List<int>>.Enumerator GetRandomIdPairs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomIdPairs_Public_Enumerator_NewsType_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Dictionary<NewsType, List<int>>.Enumerator(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 890492, RefRangeEnd = 890495, XrefRangeStart = 890489, XrefRangeEnd = 890492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetRandomIds(NewsType newsType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newsType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomIds_Public_List_1_Int32_NewsType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 890510, RefRangeEnd = 890513, XrefRangeStart = 890495, XrefRangeEnd = 890510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEvent(NewsType newsType, EventNewsItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newsType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEvent_Public_Void_NewsType_EventNewsItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 890513, XrefRangeEnd = 890523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEvent(NewsType newsType, EventNewsItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newsType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEvent_Public_Void_NewsType_EventNewsItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 890526, RefRangeEnd = 890529, XrefRangeStart = 890523, XrefRangeEnd = 890526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<EventNewsItem> GetEventItems(NewsType newsType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newsType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventItems_Public_List_1_EventNewsItem_NewsType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EventNewsItem>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890530, RefRangeEnd = 890531, XrefRangeStart = 890529, XrefRangeEnd = 890530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCompetitionCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompetitionCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890533, RefRangeEnd = 890534, XrefRangeStart = 890531, XrefRangeEnd = 890533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCompetitionId(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompetitionId_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890536, RefRangeEnd = 890537, XrefRangeStart = 890534, XrefRangeEnd = 890536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetCompetitionResult(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompetitionResult_Public_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890556, RefRangeEnd = 890557, XrefRangeStart = 890537, XrefRangeEnd = 890556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCompetition(int tid, List<int> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCompetition_Public_Void_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890580, RefRangeEnd = 890581, XrefRangeStart = 890557, XrefRangeEnd = 890580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe News()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<News>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public News(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
