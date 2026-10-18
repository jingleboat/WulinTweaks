using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class FiefSharedData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_KUNGFU_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ITEM_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingLevelDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuBooks;

	private static readonly System.IntPtr NativeFieldInfoPtr_items;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefIdleStrForRes;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefIdleTimeForRes;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefNoMoreIdleIncoming;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsInited;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefGetBuildingLevelData_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefSetBuildingLevelData_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefStoreKungfuBook_Public_Boolean_Int32_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefGetKungfuBook_Public_GameItemInstance_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefStoreItem_Public_Boolean_Int32_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiefGetItem_Public_GameItemInstance_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MAX_KUNGFU_COUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_KUNGFU_COUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_KUNGFU_COUNT, (void*)(&num));
		}
	}

	public unsafe static int MAX_ITEM_COUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ITEM_COUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ITEM_COUNT, (void*)(&num));
		}
	}

	public unsafe Dictionary<int, int> buildingLevelDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingLevelDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingLevelDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<GameItemInstance> kungfuBooks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuBooks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuBooks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameItemInstance> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameItemPack fiefStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe int fiefIdleStrForRes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefIdleStrForRes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefIdleStrForRes)) = num;
		}
	}

	public unsafe double fiefIdleTimeForRes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefIdleTimeForRes);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefIdleTimeForRes)) = num;
		}
	}

	public unsafe bool fiefNoMoreIdleIncoming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefNoMoreIdleIncoming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefNoMoreIdleIncoming)) = flag;
		}
	}

	public unsafe bool m_IsInited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsInited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsInited)) = flag;
		}
	}

	static FiefSharedData()
	{
		Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "FiefSharedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_KUNGFU_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "MAX_KUNGFU_COUNT");
		NativeFieldInfoPtr_MAX_ITEM_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "MAX_ITEM_COUNT");
		NativeFieldInfoPtr_buildingLevelDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "buildingLevelDict");
		NativeFieldInfoPtr_kungfuBooks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "kungfuBooks");
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "items");
		NativeFieldInfoPtr_fiefStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "fiefStorage");
		NativeFieldInfoPtr_fiefIdleStrForRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "fiefIdleStrForRes");
		NativeFieldInfoPtr_fiefIdleTimeForRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "fiefIdleTimeForRes");
		NativeFieldInfoPtr_fiefNoMoreIdleIncoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "fiefNoMoreIdleIncoming");
		NativeFieldInfoPtr_m_IsInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, "m_IsInited");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673608);
		NativeMethodInfoPtr_FiefGetBuildingLevelData_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673609);
		NativeMethodInfoPtr_FiefSetBuildingLevelData_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673610);
		NativeMethodInfoPtr_FiefStoreKungfuBook_Public_Boolean_Int32_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673611);
		NativeMethodInfoPtr_FiefGetKungfuBook_Public_GameItemInstance_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673612);
		NativeMethodInfoPtr_FiefStoreItem_Public_Boolean_Int32_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673613);
		NativeMethodInfoPtr_FiefGetItem_Public_GameItemInstance_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673614);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr, 100673615);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847447, RefRangeEnd = 847448, XrefRangeStart = 847383, XrefRangeEnd = 847447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847452, RefRangeEnd = 847453, XrefRangeStart = 847448, XrefRangeEnd = 847452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FiefGetBuildingLevelData(int buildingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buildingId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefGetBuildingLevelData_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847457, RefRangeEnd = 847458, XrefRangeStart = 847453, XrefRangeEnd = 847457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FiefSetBuildingLevelData(int buildingId, int buildingLevelDataId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buildingId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buildingLevelDataId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefSetBuildingLevelData_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847511, RefRangeEnd = 847512, XrefRangeStart = 847458, XrefRangeEnd = 847511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FiefStoreKungfuBook(int index, KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefStoreKungfuBook_Public_Boolean_Int32_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847524, RefRangeEnd = 847525, XrefRangeStart = 847512, XrefRangeEnd = 847524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance FiefGetKungfuBook(int index, bool alsoWithDraw = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoWithDraw;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefGetKungfuBook_Public_GameItemInstance_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847537, RefRangeEnd = 847538, XrefRangeStart = 847525, XrefRangeEnd = 847537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FiefStoreItem(int index, GameItemInstance item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefStoreItem_Public_Boolean_Int32_GameItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847551, RefRangeEnd = 847552, XrefRangeStart = 847538, XrefRangeEnd = 847551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemInstance FiefGetItem(int index, bool alsoWithDraw = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoWithDraw;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiefGetItem_Public_GameItemInstance_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847569, RefRangeEnd = 847571, XrefRangeStart = 847552, XrefRangeEnd = 847569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FiefSharedData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FiefSharedData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FiefSharedData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
