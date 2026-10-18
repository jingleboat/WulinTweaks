using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using WuLin;
using WuLin.GameFrameworks;

public class NpcSightManager : GTSingleton<NpcSightManager>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isSight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ViewDic;

	private static readonly System.IntPtr NativeFieldInfoPtr_ObjDic;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteDic;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcDirDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcNewViewDic;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenLightRange;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DataDic_Public_get_Dictionary_2_String_NpcViewData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddViewCube_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Private_List_1_Vector3Int_NpcViewData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateView_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewToTurn_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToTurnList_Private_List_1_Vector3Int_Role_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PosToTransform_Public_List_1_Vector3_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Borderline_Public_Void_Int32_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBorder_Private_Int32_Vector3Int_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WhoIsSeen_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSightByRole_Public_HashSet_1_Vector3Int_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoleBySightPoint_Public_HashSet_1_Role_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInRoleSight_Public_Boolean_Role_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTileDistance_Public_Int32_Role_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchStealth_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchStealth_Public_Void_Role_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAllNpcsSight_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowNpcSight_Private_Void_Role_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StealthEventStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StealthEventStop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSightRange_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNpcRange_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDayNightSwitched_Private_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isSight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSight)) = flag;
		}
	}

	public unsafe Dictionary<Role, ViewOfSight> ViewDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ViewDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Role, ViewOfSight>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ViewDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Role, NpcView> ObjDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ObjDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Role, NpcView>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ObjDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Sprite> spriteDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Sprite>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Role, TileDirection> NpcDirDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcDirDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Role, TileDirection>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcDirDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Role, List<Vector3Int>> NpcNewViewDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNewViewDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Role, List<Vector3Int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNewViewDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static float OpenLightRange
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OpenLightRange, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OpenLightRange, (void*)(&num));
		}
	}

	public unsafe Dictionary<string, NpcViewData> DataDic
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681648, XrefRangeEnd = 681652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DataDic_Public_get_Dictionary_2_String_NpcViewData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, NpcViewData>>(intPtr) : null;
		}
	}

	static NpcSightManager()
	{
		Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NpcSightManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr);
		NativeFieldInfoPtr_isSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "isSight");
		NativeFieldInfoPtr_ViewDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "ViewDic");
		NativeFieldInfoPtr_ObjDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "ObjDic");
		NativeFieldInfoPtr_spriteDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "spriteDic");
		NativeFieldInfoPtr_NpcDirDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "NpcDirDict");
		NativeFieldInfoPtr_NpcNewViewDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "NpcNewViewDic");
		NativeFieldInfoPtr_OpenLightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, "OpenLightRange");
		NativeMethodInfoPtr_get_DataDic_Public_get_Dictionary_2_String_NpcViewData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_Remove_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_AddViewCube_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_LoadData_Private_List_1_Vector3Int_NpcViewData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_CreateView_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_ViewToTurn_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_ReturnToTurnList_Private_List_1_Vector3Int_Role_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_PosToTransform_Public_List_1_Vector3_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_Borderline_Public_Void_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_IsBorder_Private_Int32_Vector3Int_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_WhoIsSeen_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_GetSightByRole_Public_HashSet_1_Vector3Int_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_GetRoleBySightPoint_Public_HashSet_1_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_IsInRoleSight_Public_Boolean_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_GetTileDistance_Public_Int32_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_SwitchStealth_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_SwitchStealth_Public_Void_Role_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_ShowAllNpcsSight_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_ShowNpcSight_Private_Void_Role_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_StealthEventStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664058);
		NativeMethodInfoPtr_StealthEventStop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_IsSightRange_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_IsNpcRange_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_OnDayNightSwitched_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr, 100664063);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681652, XrefRangeEnd = 681679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 681711, RefRangeEnd = 681713, XrefRangeStart = 681679, XrefRangeEnd = 681711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(Role role)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 681769, RefRangeEnd = 681771, XrefRangeStart = 681713, XrefRangeEnd = 681769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddViewCube(Role npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddViewCube_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 681787, RefRangeEnd = 681790, XrefRangeStart = 681771, XrefRangeEnd = 681787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> LoadData(NpcViewData view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Private_List_1_Vector3Int_NpcViewData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681790, XrefRangeEnd = 681802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateView(Role npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateView_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 681842, RefRangeEnd = 681844, XrefRangeStart = 681802, XrefRangeEnd = 681842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ViewToTurn(Role role)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewToTurn_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 681855, RefRangeEnd = 681858, XrefRangeStart = 681844, XrefRangeEnd = 681855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> ReturnToTurnList(Role role, List<Vector3Int> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnToTurnList_Private_List_1_Vector3Int_Role_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681858, XrefRangeEnd = 681888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3> PosToTransform(List<Vector3Int> List)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)List);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PosToTransform_Public_List_1_Vector3_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681888, XrefRangeEnd = 681902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Borderline(int type, GameObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Borderline_Public_Void_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681902, XrefRangeEnd = 681935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IsBorder(Vector3Int pos, List<Vector3Int> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBorder_Private_Int32_Vector3Int_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 681986, RefRangeEnd = 681988, XrefRangeStart = 681935, XrefRangeEnd = 681986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WhoIsSeen(Role role)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WhoIsSeen_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 682058, RefRangeEnd = 682059, XrefRangeStart = 681988, XrefRangeEnd = 682058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Vector3Int> GetSightByRole(Role npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSightByRole_Public_HashSet_1_Vector3Int_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 682084, RefRangeEnd = 682085, XrefRangeStart = 682059, XrefRangeEnd = 682084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Role> GetRoleBySightPoint(Vector3Int point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoleBySightPoint_Public_HashSet_1_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Role>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 682133, RefRangeEnd = 682135, XrefRangeStart = 682085, XrefRangeEnd = 682133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInRoleSight(Role role, Vector3Int point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInRoleSight_Public_Boolean_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 682159, RefRangeEnd = 682168, XrefRangeStart = 682135, XrefRangeEnd = 682159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTileDistance(Role role, Vector3Int point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTileDistance_Public_Int32_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 682182, RefRangeEnd = 682184, XrefRangeStart = 682168, XrefRangeEnd = 682182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchStealth(bool open)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&open);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchStealth_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 682185, RefRangeEnd = 682190, XrefRangeStart = 682184, XrefRangeEnd = 682185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchStealth(Role role, bool open)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &open;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchStealth_Public_Void_Role_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 682216, RefRangeEnd = 682218, XrefRangeStart = 682190, XrefRangeEnd = 682216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAllNpcsSight(bool open)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&open);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowAllNpcsSight_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 682229, RefRangeEnd = 682234, XrefRangeStart = 682218, XrefRangeEnd = 682229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowNpcSight(Role role, bool open)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &open;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowNpcSight_Private_Void_Role_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682234, XrefRangeEnd = 682248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StealthEventStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StealthEventStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 682262, RefRangeEnd = 682263, XrefRangeStart = 682248, XrefRangeEnd = 682262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StealthEventStop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StealthEventStop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 682304, RefRangeEnd = 682306, XrefRangeStart = 682263, XrefRangeEnd = 682304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IsSightRange(Role role)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSightRange_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682306, XrefRangeEnd = 682357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IsNpcRange(Role player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNpcRange_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682357, XrefRangeEnd = 682413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDayNightSwitched(Il2CppReferenceArray<Il2CppSystem.Object> param)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDayNightSwitched_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682413, XrefRangeEnd = 682449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcSightManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcSightManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NpcSightManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
