using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace WuLin;

public class GatewayBuildingKit : BaseBuildingKit
{
	private static readonly IntPtr NativeFieldInfoPtr_TargetMapID;

	private static readonly IntPtr NativeFieldInfoPtr_TargetCellPos;

	private static readonly IntPtr NativeFieldInfoPtr_DirectionKeepMoving;

	private static readonly IntPtr NativeFieldInfoPtr_isTriggerImmediate;

	private static readonly IntPtr NativeFieldInfoPtr_TargetDir;

	private static readonly IntPtr NativeFieldInfoPtr_KeepMovingOffsetZ;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int TargetMapID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetMapID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetMapID)) = num;
		}
	}

	public unsafe Vector3Int TargetCellPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetCellPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetCellPos)) = vector3Int;
		}
	}

	public unsafe TileDirection DirectionKeepMoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionKeepMoving);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionKeepMoving)) = tileDirection;
		}
	}

	public unsafe bool isTriggerImmediate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTriggerImmediate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTriggerImmediate)) = flag;
		}
	}

	public unsafe TileDirection TargetDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetDir);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetDir)) = tileDirection;
		}
	}

	public unsafe int KeepMovingOffsetZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeepMovingOffsetZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeepMovingOffsetZ)) = num;
		}
	}

	static GatewayBuildingKit()
	{
		Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GatewayBuildingKit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr);
		NativeFieldInfoPtr_TargetMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, "TargetMapID");
		NativeFieldInfoPtr_TargetCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, "TargetCellPos");
		NativeFieldInfoPtr_DirectionKeepMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, "DirectionKeepMoving");
		NativeFieldInfoPtr_isTriggerImmediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, "isTriggerImmediate");
		NativeFieldInfoPtr_TargetDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, "TargetDir");
		NativeFieldInfoPtr_KeepMovingOffsetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, "KeepMovingOffsetZ");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr, 100674745);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 877193, RefRangeEnd = 877195, XrefRangeStart = 877191, XrefRangeEnd = 877193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GatewayBuildingKit()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GatewayBuildingKit>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GatewayBuildingKit(IntPtr pointer)
		: base(pointer)
	{
	}
}
