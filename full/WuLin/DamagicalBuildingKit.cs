using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class DamagicalBuildingKit : BaseBuildingKit
{
	private static readonly IntPtr NativeFieldInfoPtr_mSize;

	private static readonly IntPtr NativeFieldInfoPtr_mCenter;

	private static readonly IntPtr NativeFieldInfoPtr_mTempID;

	private static readonly IntPtr NativeFieldInfoPtr_mCanBlock;

	private static readonly IntPtr NativeFieldInfoPtr_mGroupID;

	private static readonly IntPtr NativeFieldInfoPtr_mListTilePos;

	private static readonly IntPtr NativeFieldInfoPtr_MoveToCustomCellPos;

	private static readonly IntPtr NativeFieldInfoPtr_MaxHP;

	private static readonly IntPtr NativeFieldInfoPtr_MiningMaxNum;

	private static readonly IntPtr NativeFieldInfoPtr_saveData;

	private static readonly IntPtr NativeMethodInfoPtr_ChangeHPValue_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHP_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 mSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mSize)) = vector;
		}
	}

	public unsafe Vector2 mCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCenter);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCenter)) = vector;
		}
	}

	public unsafe int mTempID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTempID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTempID)) = num;
		}
	}

	public unsafe bool mCanBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCanBlock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCanBlock)) = flag;
		}
	}

	public unsafe int mGroupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGroupID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mGroupID)) = num;
		}
	}

	public unsafe List<Vector3Int> mListTilePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mListTilePos);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mListTilePos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3Int> MoveToCustomCellPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveToCustomCellPos);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveToCustomCellPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int MaxHP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxHP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxHP)) = num;
		}
	}

	public unsafe int MiningMaxNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiningMaxNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiningMaxNum)) = num;
		}
	}

	public unsafe SaveObjectMapManager.BuildingData saveData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SaveObjectMapManager.BuildingData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingData));
		}
	}

	static DamagicalBuildingKit()
	{
		Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DamagicalBuildingKit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr);
		NativeFieldInfoPtr_mSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "mSize");
		NativeFieldInfoPtr_mCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "mCenter");
		NativeFieldInfoPtr_mTempID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "mTempID");
		NativeFieldInfoPtr_mCanBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "mCanBlock");
		NativeFieldInfoPtr_mGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "mGroupID");
		NativeFieldInfoPtr_mListTilePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "mListTilePos");
		NativeFieldInfoPtr_MoveToCustomCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "MoveToCustomCellPos");
		NativeFieldInfoPtr_MaxHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "MaxHP");
		NativeFieldInfoPtr_MiningMaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "MiningMaxNum");
		NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, "saveData");
		NativeMethodInfoPtr_ChangeHPValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, 100674746);
		NativeMethodInfoPtr_GetHP_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, 100674747);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr, 100674748);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 877195, RefRangeEnd = 877196, XrefRangeStart = 877195, XrefRangeEnd = 877195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHPValue(int nValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&nValue);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHPValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 877196, RefRangeEnd = 877206, XrefRangeStart = 877196, XrefRangeEnd = 877196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHP()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHP_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 877219, RefRangeEnd = 877220, XrefRangeStart = 877206, XrefRangeEnd = 877219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DamagicalBuildingKit()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamagicalBuildingKit>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DamagicalBuildingKit(IntPtr pointer)
		: base(pointer)
	{
	}
}
