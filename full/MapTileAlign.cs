using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class MapTileAlign : MonoBehaviour
{
	public enum AutoPosChange
	{
		ForceCell,
		ForcePos
	}

	private static readonly IntPtr NativeFieldInfoPtr_GRID_WIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_isOwnerPerson;

	private static readonly IntPtr NativeFieldInfoPtr_FactionID;

	private static readonly IntPtr NativeFieldInfoPtr_FactionRelation;

	private static readonly IntPtr NativeFieldInfoPtr_BelongNpcID;

	private static readonly IntPtr NativeFieldInfoPtr_BelongNpcRelation;

	private static readonly IntPtr NativeFieldInfoPtr_autoPos;

	private static readonly IntPtr NativeFieldInfoPtr_m_pos;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAutoPosChange_Public_AutoPosChange_0;

	private static readonly IntPtr NativeMethodInfoPtr_PosToTransform_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRelationLimit_Public_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float GRID_WIDTH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GRID_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GRID_WIDTH, (void*)(&num));
		}
	}

	public unsafe bool isOwnerPerson
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOwnerPerson);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOwnerPerson)) = flag;
		}
	}

	public unsafe int FactionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactionID)) = num;
		}
	}

	public unsafe int FactionRelation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactionRelation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactionRelation)) = num;
		}
	}

	public unsafe int BelongNpcID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BelongNpcID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BelongNpcID)) = num;
		}
	}

	public unsafe int BelongNpcRelation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BelongNpcRelation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BelongNpcRelation)) = num;
		}
	}

	public unsafe AutoPosChange autoPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPos);
			return *(AutoPosChange*)num;
		}
		set
		{
			*(AutoPosChange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPos)) = autoPosChange;
		}
	}

	public unsafe Vector3Int m_pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pos)) = vector3Int;
		}
	}

	static MapTileAlign()
	{
		Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MapTileAlign");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr);
		NativeFieldInfoPtr_GRID_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "GRID_WIDTH");
		NativeFieldInfoPtr_isOwnerPerson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "isOwnerPerson");
		NativeFieldInfoPtr_FactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "FactionID");
		NativeFieldInfoPtr_FactionRelation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "FactionRelation");
		NativeFieldInfoPtr_BelongNpcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "BelongNpcID");
		NativeFieldInfoPtr_BelongNpcRelation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "BelongNpcRelation");
		NativeFieldInfoPtr_autoPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "autoPos");
		NativeFieldInfoPtr_m_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, "m_pos");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_GetAutoPosChange_Public_AutoPosChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_PosToTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_GetRelationLimit_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr, 100664133);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684190, XrefRangeEnd = 684208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe AutoPosChange GetAutoPosChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAutoPosChange_Public_AutoPosChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AutoPosChange*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684208, XrefRangeEnd = 684218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PosToTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PosToTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684223, RefRangeEnd = 684224, XrefRangeStart = 684218, XrefRangeEnd = 684223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> GetRelationLimit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationLimit_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 684225, RefRangeEnd = 684227, XrefRangeStart = 684224, XrefRangeEnd = 684225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapTileAlign()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTileAlign>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MapTileAlign(IntPtr pointer)
		: base(pointer)
	{
	}
}
