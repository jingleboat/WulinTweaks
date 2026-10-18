using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class GatewayObject : MapTileAlign
{
	public enum WulinDirection
	{
		None = 8,
		UpRight = 0,
		DownRight = 1,
		DownLeft = 2,
		UpLeft = 3
	}

	private static readonly IntPtr NativeFieldInfoPtr_SaveID;

	private static readonly IntPtr NativeFieldInfoPtr_DirectionTourist;

	private static readonly IntPtr NativeFieldInfoPtr_DirectionKeepMoving;

	private static readonly IntPtr NativeFieldInfoPtr_KeepMovingOffsetZ;

	private static readonly IntPtr NativeFieldInfoPtr_TargetMapID;

	private static readonly IntPtr NativeFieldInfoPtr_TargetCellPos;

	private static readonly IntPtr NativeFieldInfoPtr_TargetDir;

	private static readonly IntPtr NativeFieldInfoPtr_isTriggerImmediate;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int SaveID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveID)) = num;
		}
	}

	public unsafe WulinDirection DirectionTourist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionTourist);
			return *(WulinDirection*)num;
		}
		set
		{
			*(WulinDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionTourist)) = wulinDirection;
		}
	}

	public unsafe WulinDirection DirectionKeepMoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionKeepMoving);
			return *(WulinDirection*)num;
		}
		set
		{
			*(WulinDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionKeepMoving)) = wulinDirection;
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

	public unsafe WulinDirection TargetDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetDir);
			return *(WulinDirection*)num;
		}
		set
		{
			*(WulinDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetDir)) = wulinDirection;
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

	static GatewayObject()
	{
		Il2CppClassPointerStore<GatewayObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GatewayObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr);
		NativeFieldInfoPtr_SaveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "SaveID");
		NativeFieldInfoPtr_DirectionTourist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "DirectionTourist");
		NativeFieldInfoPtr_DirectionKeepMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "DirectionKeepMoving");
		NativeFieldInfoPtr_KeepMovingOffsetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "KeepMovingOffsetZ");
		NativeFieldInfoPtr_TargetMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "TargetMapID");
		NativeFieldInfoPtr_TargetCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "TargetCellPos");
		NativeFieldInfoPtr_TargetDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "TargetDir");
		NativeFieldInfoPtr_isTriggerImmediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, "isTriggerImmediate");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr, 100664120);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684125, XrefRangeEnd = 684130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GatewayObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GatewayObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GatewayObject(IntPtr pointer)
		: base(pointer)
	{
	}
}
