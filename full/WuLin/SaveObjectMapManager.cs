using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class SaveObjectMapManager : SaveObjectBase
{
	public class BuildingData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_HP;

		private static readonly System.IntPtr NativeFieldInfoPtr_HiddenItemsPicked;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightState;

		private static readonly System.IntPtr NativeFieldInfoPtr_brokenByStory;

		private static readonly System.IntPtr NativeFieldInfoPtr_RepairByStory;

		private static readonly System.IntPtr NativeFieldInfoPtr_MiningRevertEndTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_MiningNum;

		private static readonly System.IntPtr NativeFieldInfoPtr_BitPicked;

		private static readonly System.IntPtr NativeFieldInfoPtr_BitPickedSpe;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMiningNum_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetMiningNum_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3Int Pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Pos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Pos)) = vector3Int;
			}
		}

		public unsafe int HP
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HP);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HP)) = num;
			}
		}

		public unsafe bool HiddenItemsPicked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HiddenItemsPicked);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HiddenItemsPicked)) = flag;
			}
		}

		public unsafe int lightState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightState);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightState)) = num;
			}
		}

		public unsafe bool brokenByStory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenByStory);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenByStory)) = flag;
			}
		}

		public unsafe bool RepairByStory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairByStory);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairByStory)) = flag;
			}
		}

		public unsafe int MiningRevertEndTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiningRevertEndTime);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiningRevertEndTime)) = num;
			}
		}

		public unsafe int MiningNum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiningNum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiningNum)) = num;
			}
		}

		public unsafe int BitPicked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitPicked);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitPicked)) = num;
			}
		}

		public unsafe int BitPickedSpe
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitPickedSpe);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitPickedSpe)) = num;
			}
		}

		static BuildingData()
		{
			Il2CppClassPointerStore<BuildingData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "BuildingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingData>.NativeClassPtr);
			NativeFieldInfoPtr_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "Pos");
			NativeFieldInfoPtr_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "HP");
			NativeFieldInfoPtr_HiddenItemsPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "HiddenItemsPicked");
			NativeFieldInfoPtr_lightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "lightState");
			NativeFieldInfoPtr_brokenByStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "brokenByStory");
			NativeFieldInfoPtr_RepairByStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "RepairByStory");
			NativeFieldInfoPtr_MiningRevertEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "MiningRevertEndTime");
			NativeFieldInfoPtr_MiningNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "MiningNum");
			NativeFieldInfoPtr_BitPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "BitPicked");
			NativeFieldInfoPtr_BitPickedSpe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, "BitPickedSpe");
			NativeMethodInfoPtr_GetMiningNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, 100686932);
			NativeMethodInfoPtr_SetMiningNum_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, 100686933);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingData>.NativeClassPtr, 100686934);
		}

		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 555860, RefRangeEnd = 555880, XrefRangeStart = 555860, XrefRangeEnd = 555880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMiningNum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMiningNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 848481, RefRangeEnd = 848485, XrefRangeStart = 848481, XrefRangeEnd = 848481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMiningNum(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMiningNum_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 848487, RefRangeEnd = 848489, XrefRangeStart = 848485, XrefRangeEnd = 848487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BuildingData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MiscItemData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ShowByStory;

		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerTakeOff;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightState;

		private static readonly System.IntPtr NativeFieldInfoPtr_PickAtTime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int ShowByStory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowByStory);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowByStory)) = num;
			}
		}

		public unsafe bool PlayerTakeOff
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerTakeOff);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerTakeOff)) = flag;
			}
		}

		public unsafe int lightState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightState);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightState)) = num;
			}
		}

		public unsafe int PickAtTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PickAtTime);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PickAtTime)) = num;
			}
		}

		static MiscItemData()
		{
			Il2CppClassPointerStore<MiscItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MiscItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr);
			NativeFieldInfoPtr_ShowByStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr, "ShowByStory");
			NativeFieldInfoPtr_PlayerTakeOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr, "PlayerTakeOff");
			NativeFieldInfoPtr_lightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr, "lightState");
			NativeFieldInfoPtr_PickAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr, "PickAtTime");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr, 100686935);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MiscItemData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiscItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MiscItemData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class GatewayData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Open;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool Open
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Open);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Open)) = flag;
			}
		}

		static GatewayData()
		{
			Il2CppClassPointerStore<GatewayData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "GatewayData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GatewayData>.NativeClassPtr);
			NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GatewayData>.NativeClassPtr, "Open");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GatewayData>.NativeClassPtr, 100686936);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GatewayData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GatewayData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GatewayData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DoorData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Open;

		private static readonly System.IntPtr NativeFieldInfoPtr_ForceLockState;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool Open
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Open);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Open)) = flag;
			}
		}

		public unsafe bool ForceLockState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceLockState);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceLockState)) = flag;
			}
		}

		static DoorData()
		{
			Il2CppClassPointerStore<DoorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "DoorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorData>.NativeClassPtr);
			NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorData>.NativeClassPtr, "Open");
			NativeFieldInfoPtr_ForceLockState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorData>.NativeClassPtr, "ForceLockState");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorData>.NativeClassPtr, 100686937);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DoorData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class RuntimeMiscData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_itemClone;

		private static readonly System.IntPtr NativeFieldInfoPtr_parentSaveID;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameItemInstance itemClone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemClone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemClone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance));
			}
		}

		public unsafe int parentSaveID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentSaveID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentSaveID)) = num;
			}
		}

		public unsafe Vector3 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
			}
		}

		static RuntimeMiscData()
		{
			Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "RuntimeMiscData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr);
			NativeFieldInfoPtr_itemClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr, "itemClone");
			NativeFieldInfoPtr_parentSaveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr, "parentSaveID");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr, "offset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr, 100686938);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 715726, RefRangeEnd = 715730, XrefRangeStart = 715726, XrefRangeEnd = 715730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeMiscData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeMiscData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RuntimeMiscData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MapData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_BuildingList;

		private static readonly System.IntPtr NativeFieldInfoPtr_MiscItemList;

		private static readonly System.IntPtr NativeFieldInfoPtr_DoorList;

		private static readonly System.IntPtr NativeFieldInfoPtr_GatewayList;

		private static readonly System.IntPtr NativeFieldInfoPtr_runtimeSaveID;

		private static readonly System.IntPtr NativeFieldInfoPtr_RuntimeMiscDataList;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Dictionary<int, BuildingData> BuildingList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildingList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, BuildingData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildingList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Dictionary<int, MiscItemData> MiscItemList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiscItemList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, MiscItemData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiscItemList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Dictionary<int, DoorData> DoorList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoorList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, DoorData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoorList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Dictionary<int, GatewayData> GatewayList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GatewayList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, GatewayData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GatewayList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe int runtimeSaveID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runtimeSaveID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runtimeSaveID)) = num;
			}
		}

		public unsafe Dictionary<int, RuntimeMiscData> RuntimeMiscDataList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RuntimeMiscDataList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RuntimeMiscData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RuntimeMiscDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static MapData()
		{
			Il2CppClassPointerStore<MapData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MapData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapData>.NativeClassPtr);
			NativeFieldInfoPtr_BuildingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "BuildingList");
			NativeFieldInfoPtr_MiscItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "MiscItemList");
			NativeFieldInfoPtr_DoorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "DoorList");
			NativeFieldInfoPtr_GatewayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "GatewayList");
			NativeFieldInfoPtr_runtimeSaveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "runtimeSaveID");
			NativeFieldInfoPtr_RuntimeMiscDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "RuntimeMiscDataList");
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapData>.NativeClassPtr, 100686939);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapData>.NativeClassPtr, 100686940);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848489, XrefRangeEnd = 848502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 848533, RefRangeEnd = 848535, XrefRangeStart = 848502, XrefRangeEnd = 848533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MapData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MapNpcData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_factionID;

		private static readonly System.IntPtr NativeFieldInfoPtr_jobID;

		private static readonly System.IntPtr NativeFieldInfoPtr_npcID;

		private static readonly System.IntPtr NativeFieldInfoPtr_templeteOrInstanceID;

		private static readonly System.IntPtr NativeFieldInfoPtr_curListIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_direction;

		private static readonly System.IntPtr NativeFieldInfoPtr_stayTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_isUnitQuarter;

		private static readonly System.IntPtr NativeFieldInfoPtr_workingPlace;

		private static readonly System.IntPtr NativeFieldInfoPtr_mTimeCallID;

		private static readonly System.IntPtr NativeFieldInfoPtr_retryTimes;

		private static readonly System.IntPtr NativeFieldInfoPtr_role;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsWorkingPlace_Public_Boolean_Vector3Int_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCurPos_Public_Void_byref_Vector3Int_byref_Vector2Int_byref_Boolean_byref_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetNextPos_Public_Void_byref_Vector3Int_byref_Vector2Int_byref_Boolean_byref_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int mapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapID)) = num;
			}
		}

		public unsafe int factionID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionID)) = num;
			}
		}

		public unsafe int jobID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobID)) = num;
			}
		}

		public unsafe int npcID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcID)) = num;
			}
		}

		public unsafe int templeteOrInstanceID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templeteOrInstanceID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templeteOrInstanceID)) = num;
			}
		}

		public unsafe int curListIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curListIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curListIndex)) = num;
			}
		}

		public unsafe List<Vector3Int> pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> direction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Vector2Int> stayTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stayTime);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stayTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<bool> isUnitQuarter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnitQuarter);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<bool>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnitQuarter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<bool> workingPlace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingPlace);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<bool>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workingPlace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int mTimeCallID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTimeCallID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mTimeCallID)) = num;
			}
		}

		public unsafe int retryTimes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retryTimes);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retryTimes)) = num;
			}
		}

		public unsafe GameObject role
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_role);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_role)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		static MapNpcData()
		{
			Il2CppClassPointerStore<MapNpcData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MapNpcData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr);
			NativeFieldInfoPtr_mapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "mapID");
			NativeFieldInfoPtr_factionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "factionID");
			NativeFieldInfoPtr_jobID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "jobID");
			NativeFieldInfoPtr_npcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "npcID");
			NativeFieldInfoPtr_templeteOrInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "templeteOrInstanceID");
			NativeFieldInfoPtr_curListIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "curListIndex");
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "direction");
			NativeFieldInfoPtr_stayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "stayTime");
			NativeFieldInfoPtr_isUnitQuarter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "isUnitQuarter");
			NativeFieldInfoPtr_workingPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "workingPlace");
			NativeFieldInfoPtr_mTimeCallID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "mTimeCallID");
			NativeFieldInfoPtr_retryTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "retryTimes");
			NativeFieldInfoPtr_role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, "role");
			NativeMethodInfoPtr_IsWorkingPlace_Public_Boolean_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, 100686941);
			NativeMethodInfoPtr_GetCurPos_Public_Void_byref_Vector3Int_byref_Vector2Int_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, 100686942);
			NativeMethodInfoPtr_GetNextPos_Public_Void_byref_Vector3Int_byref_Vector2Int_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, 100686943);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr, 100686944);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 848550, RefRangeEnd = 848551, XrefRangeStart = 848535, XrefRangeEnd = 848550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWorkingPlace(Vector3Int check, int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&check);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorkingPlace_Public_Boolean_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 848562, RefRangeEnd = 848564, XrefRangeStart = 848551, XrefRangeEnd = 848562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCurPos(out Vector3Int outPos, out Vector2Int ouTime, out bool isWorkingPlace, out bool unitQuarter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)Unsafe.AsPointer(ref outPos);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ouTime);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isWorkingPlace);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref unitQuarter);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurPos_Public_Void_byref_Vector3Int_byref_Vector2Int_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 848575, RefRangeEnd = 848576, XrefRangeStart = 848564, XrefRangeEnd = 848575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNextPos(out Vector3Int outPos, out Vector2Int ouTime, out bool isWorkingPlace, out bool unitQuarter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)Unsafe.AsPointer(ref outPos);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ouTime);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isWorkingPlace);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref unitQuarter);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextPos_Public_Void_byref_Vector3Int_byref_Vector2Int_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 848605, RefRangeEnd = 848608, XrefRangeStart = 848576, XrefRangeEnd = 848605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapNpcData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapNpcData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MapNpcData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MarkOffsetPos : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_markMapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_markOffsetPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_isStandOn;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int markMapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markMapID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markMapID)) = num;
			}
		}

		public unsafe Vector2 markOffsetPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markOffsetPos);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markOffsetPos)) = vector;
			}
		}

		public unsafe bool isStandOn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStandOn);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStandOn)) = flag;
			}
		}

		static MarkOffsetPos()
		{
			Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MarkOffsetPos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr);
			NativeFieldInfoPtr_markMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr, "markMapID");
			NativeFieldInfoPtr_markOffsetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr, "markOffsetPos");
			NativeFieldInfoPtr_isStandOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr, "isStandOn");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr, 100686945);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 848610, RefRangeEnd = 848613, XrefRangeStart = 848608, XrefRangeEnd = 848610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarkOffsetPos()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarkOffsetPos>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MarkOffsetPos(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class WorldmapIconData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_worldMapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_graphName;

		private static readonly System.IntPtr NativeFieldInfoPtr_saveID;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetMap;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int worldMapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldMapID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldMapID)) = num;
			}
		}

		public unsafe string graphName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int saveID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveID)) = num;
			}
		}

		public unsafe int targetMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMap);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMap)) = num;
			}
		}

		static WorldmapIconData()
		{
			Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "WorldmapIconData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr);
			NativeFieldInfoPtr_worldMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr, "worldMapID");
			NativeFieldInfoPtr_graphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr, "graphName");
			NativeFieldInfoPtr_saveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr, "saveID");
			NativeFieldInfoPtr_targetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr, "targetMap");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr, 100686946);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 848616, RefRangeEnd = 848617, XrefRangeStart = 848613, XrefRangeEnd = 848616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldmapIconData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldmapIconData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WorldmapIconData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MapDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_MapNpcDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_MapNpcExtraDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_listWorldMapEnable;

	private static readonly System.IntPtr NativeFieldInfoPtr_listMarkOffsetPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_listShowIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_listTaskIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_oldPlayerCell;

	private static readonly System.IntPtr NativeFieldInfoPtr_expMoveDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlayingFirework;

	private static readonly System.IntPtr NativeFieldInfoPtr_needFirework;

	private static readonly System.IntPtr NativeFieldInfoPtr_listIconByStory;

	private static readonly System.IntPtr NativeFieldInfoPtr_CabIconShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_CabIconForceHide;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldmapStoryIcon_Public_WorldmapIconData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldmapStoryIcon_Public_Boolean_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveWorldmapStoryIcon_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateMapData_Public_MapData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMapData_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<int, MapData> MapDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, MapData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Dictionary<int, MapNpcData>> MapNpcDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapNpcDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<int, MapNpcData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapNpcDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, List<MapNpcData>> MapNpcExtraDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapNpcExtraDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<MapNpcData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapNpcExtraDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<int> listWorldMapEnable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listWorldMapEnable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listWorldMapEnable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, MarkOffsetPos> listMarkOffsetPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listMarkOffsetPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, MarkOffsetPos>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listMarkOffsetPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<int> listShowIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listShowIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listShowIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> listTaskIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listTaskIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listTaskIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector3Int oldPlayerCell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldPlayerCell);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldPlayerCell)) = vector3Int;
		}
	}

	public unsafe float expMoveDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expMoveDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expMoveDistance)) = num;
		}
	}

	public unsafe bool isPlayingFirework
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayingFirework);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayingFirework)) = flag;
		}
	}

	public unsafe int needFirework
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needFirework);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needFirework)) = num;
		}
	}

	public unsafe List<WorldmapIconData> listIconByStory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listIconByStory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldmapIconData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listIconByStory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> CabIconShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CabIconShow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CabIconShow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> CabIconForceHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CabIconForceHide);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CabIconForceHide)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SaveObjectMapManager()
	{
		Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectMapManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr);
		NativeFieldInfoPtr_MapDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MapDataList");
		NativeFieldInfoPtr_MapNpcDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MapNpcDataList");
		NativeFieldInfoPtr_MapNpcExtraDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "MapNpcExtraDataList");
		NativeFieldInfoPtr_listWorldMapEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "listWorldMapEnable");
		NativeFieldInfoPtr_listMarkOffsetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "listMarkOffsetPos");
		NativeFieldInfoPtr_listShowIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "listShowIcon");
		NativeFieldInfoPtr_listTaskIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "listTaskIcon");
		NativeFieldInfoPtr_oldPlayerCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "oldPlayerCell");
		NativeFieldInfoPtr_expMoveDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "expMoveDistance");
		NativeFieldInfoPtr_isPlayingFirework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "isPlayingFirework");
		NativeFieldInfoPtr_needFirework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "needFirework");
		NativeFieldInfoPtr_listIconByStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "listIconByStory");
		NativeFieldInfoPtr_CabIconShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "CabIconShow");
		NativeFieldInfoPtr_CabIconForceHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, "CabIconForceHide");
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673676);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673677);
		NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673678);
		NativeMethodInfoPtr_GetWorldmapStoryIcon_Public_WorldmapIconData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673679);
		NativeMethodInfoPtr_AddWorldmapStoryIcon_Public_Boolean_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673680);
		NativeMethodInfoPtr_RemoveWorldmapStoryIcon_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673681);
		NativeMethodInfoPtr_GetOrCreateMapData_Public_MapData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673682);
		NativeMethodInfoPtr_RemoveMapData_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673683);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr, 100673684);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 848639, RefRangeEnd = 848640, XrefRangeStart = 848617, XrefRangeEnd = 848639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848640, XrefRangeEnd = 848649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Save(bool sync = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sync);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 848665, RefRangeEnd = 848667, XrefRangeStart = 848649, XrefRangeEnd = 848665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldmapIconData GetWorldmapStoryIcon(int worldMapID, int targetMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&worldMapID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldmapStoryIcon_Public_WorldmapIconData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldmapIconData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 848675, RefRangeEnd = 848676, XrefRangeStart = 848667, XrefRangeEnd = 848675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddWorldmapStoryIcon(int worldMapID, string graphName, int saveID, int targetMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&worldMapID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(graphName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveID;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWorldmapStoryIcon_Public_Boolean_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 848680, RefRangeEnd = 848681, XrefRangeStart = 848676, XrefRangeEnd = 848680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveWorldmapStoryIcon(int worldMapID, int targetMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&worldMapID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveWorldmapStoryIcon_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 848694, RefRangeEnd = 848724, XrefRangeStart = 848681, XrefRangeEnd = 848694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapData GetOrCreateMapData(int mapID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateMapData_Public_MapData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 848730, RefRangeEnd = 848731, XrefRangeStart = 848724, XrefRangeEnd = 848730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveMapData(int mapID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMapData_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848731, XrefRangeEnd = 848785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectMapManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectMapManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectMapManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
