using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using WuLin;

public class SingleIdAuctionHistory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidTreasures;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastActivateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastActivateDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastActivateItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastActivateTreasure;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<int> InvalidTreasures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InvalidTreasures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InvalidTreasures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int LastActivateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateTime)) = num;
		}
	}

	public unsafe int LastActivateDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateDay)) = num;
		}
	}

	public unsafe List<GameItemInstance> LastActivateItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameItemInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameItemInstance LastActivateTreasure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateTreasure);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastActivateTreasure)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance));
		}
	}

	public unsafe bool IsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActive)) = flag;
		}
	}

	static SingleIdAuctionHistory()
	{
		Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SingleIdAuctionHistory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr);
		NativeFieldInfoPtr_InvalidTreasures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, "InvalidTreasures");
		NativeFieldInfoPtr_LastActivateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, "LastActivateTime");
		NativeFieldInfoPtr_LastActivateDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, "LastActivateDay");
		NativeFieldInfoPtr_LastActivateItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, "LastActivateItems");
		NativeFieldInfoPtr_LastActivateTreasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, "LastActivateTreasure");
		NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, "IsActive");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr, 100664003);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 680554, RefRangeEnd = 680556, XrefRangeStart = 680541, XrefRangeEnd = 680554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SingleIdAuctionHistory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleIdAuctionHistory>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SingleIdAuctionHistory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
