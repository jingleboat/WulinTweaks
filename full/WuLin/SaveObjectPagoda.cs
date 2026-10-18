using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class SaveObjectPagoda : SaveObjectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_CurStage;

	private static readonly IntPtr NativeFieldInfoPtr_RandomSeed;

	private static readonly IntPtr NativeFieldInfoPtr_SeedState;

	private static readonly IntPtr NativeFieldInfoPtr_Battles;

	private static readonly IntPtr NativeFieldInfoPtr_ListMinion;

	private static readonly IntPtr NativeFieldInfoPtr_ListBoss;

	private static readonly IntPtr NativeFieldInfoPtr_ListMinionProTotal;

	private static readonly IntPtr NativeFieldInfoPtr_ListAddProSelection;

	private static readonly IntPtr NativeFieldInfoPtr_ListBossBuffTotal;

	private static readonly IntPtr NativeFieldInfoPtr_ListBossBuffSelection;

	private static readonly IntPtr NativeFieldInfoPtr_CurPrizeBuffID;

	private static readonly IntPtr NativeFieldInfoPtr_CurPrizeToSelf;

	private static readonly IntPtr NativeFieldInfoPtr_ListPrizeSelection;

	private static readonly IntPtr NativeFieldInfoPtr_CurScore;

	private static readonly IntPtr NativeFieldInfoPtr_HistoryBestStage;

	private static readonly IntPtr NativeFieldInfoPtr_HistoryBestScore;

	private static readonly IntPtr NativeFieldInfoPtr_IsViewed;

	private static readonly IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int CurStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurStage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurStage)) = num;
		}
	}

	public unsafe int RandomSeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomSeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomSeed)) = num;
		}
	}

	public unsafe UnityEngine.Random.State SeedState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeedState);
			return *(UnityEngine.Random.State*)num;
		}
		set
		{
			*(UnityEngine.Random.State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeedState)) = state;
		}
	}

	public unsafe List<string> Battles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Battles);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Battles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<string>> ListMinion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListMinion);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListMinion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<string>> ListBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListBoss);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListBoss)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, int> ListMinionProTotal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListMinionProTotal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListMinionProTotal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Dictionary<string, int>> ListAddProSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListAddProSelection);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Dictionary<string, int>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListAddProSelection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ListBossBuffTotal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListBossBuffTotal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListBossBuffTotal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<int>> ListBossBuffSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListBossBuffSelection);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListBossBuffSelection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int CurPrizeBuffID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurPrizeBuffID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurPrizeBuffID)) = num;
		}
	}

	public unsafe bool CurPrizeToSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurPrizeToSelf);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurPrizeToSelf)) = flag;
		}
	}

	public unsafe List<int> ListPrizeSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListPrizeSelection);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListPrizeSelection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int CurScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurScore)) = num;
		}
	}

	public unsafe int HistoryBestStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HistoryBestStage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HistoryBestStage)) = num;
		}
	}

	public unsafe int HistoryBestScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HistoryBestScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HistoryBestScore)) = num;
		}
	}

	public unsafe bool IsViewed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsViewed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsViewed)) = flag;
		}
	}

	static SaveObjectPagoda()
	{
		Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectPagoda");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr);
		NativeFieldInfoPtr_CurStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "CurStage");
		NativeFieldInfoPtr_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "RandomSeed");
		NativeFieldInfoPtr_SeedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "SeedState");
		NativeFieldInfoPtr_Battles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "Battles");
		NativeFieldInfoPtr_ListMinion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListMinion");
		NativeFieldInfoPtr_ListBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListBoss");
		NativeFieldInfoPtr_ListMinionProTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListMinionProTotal");
		NativeFieldInfoPtr_ListAddProSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListAddProSelection");
		NativeFieldInfoPtr_ListBossBuffTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListBossBuffTotal");
		NativeFieldInfoPtr_ListBossBuffSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListBossBuffSelection");
		NativeFieldInfoPtr_CurPrizeBuffID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "CurPrizeBuffID");
		NativeFieldInfoPtr_CurPrizeToSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "CurPrizeToSelf");
		NativeFieldInfoPtr_ListPrizeSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "ListPrizeSelection");
		NativeFieldInfoPtr_CurScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "CurScore");
		NativeFieldInfoPtr_HistoryBestStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "HistoryBestStage");
		NativeFieldInfoPtr_HistoryBestScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "HistoryBestScore");
		NativeFieldInfoPtr_IsViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, "IsViewed");
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, 100673701);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr, 100673702);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848930, XrefRangeEnd = 848975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectPagoda()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectPagoda>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectPagoda(IntPtr pointer)
		: base(pointer)
	{
	}
}
