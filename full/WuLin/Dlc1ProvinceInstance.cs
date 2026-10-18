using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class Dlc1ProvinceInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr__ownerFaction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__stable_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedNeiborProvinces;

	private static readonly System.IntPtr NativeFieldInfoPtr_guardsStates;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ownerFaction_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ownerFaction_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stable_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stable_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCProvince_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Templete_Public_get_DLCProvince_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerFactionInstance_Public_get_Dlc1FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOwnerFaction_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRealIncomeData_Public_Dictionary_2_CurrencyType_Int64_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIncome_Public_GameItemPack_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeiborProvinceIds_Public_HashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNeiborProvinces_Public_List_1_Dlc1ProvinceInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyStable_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGuardsCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGuardStateByIndex_Public_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterPoolDataByIndex_Public_CharacterPoolData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGuardInstanceByIndex_Public_GameCharacterInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyGuardState_Public_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearGuardState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GuardsRec_Public_Void_Single_0;

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe int _ownerFaction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ownerFaction_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ownerFaction_k__BackingField)) = num;
		}
	}

	public unsafe int _stable_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stable_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stable_k__BackingField)) = num;
		}
	}

	public unsafe List<Dlc1ProvinceInstance> cachedNeiborProvinces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedNeiborProvinces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedNeiborProvinces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, Vector2> guardsStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardsStates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guardsStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int ownerFaction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ownerFaction_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20048, RefRangeEnd = 20050, XrefRangeStart = 20048, XrefRangeEnd = 20050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ownerFaction_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int stable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stable_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17061, RefRangeEnd = 17063, XrefRangeStart = 17061, XrefRangeEnd = 17063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stable_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe DLCProvince Templete
	{
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 989606, RefRangeEnd = 989647, XrefRangeStart = 989598, XrefRangeEnd = 989606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Templete_Public_get_DLCProvince_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCProvince>(intPtr) : null;
		}
	}

	public unsafe Dlc1FactionInstance OwnerFactionInstance
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 989655, RefRangeEnd = 989680, XrefRangeStart = 989647, XrefRangeEnd = 989655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OwnerFactionInstance_Public_get_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dlc1FactionInstance>(intPtr) : null;
		}
	}

	static Dlc1ProvinceInstance()
	{
		Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "Dlc1ProvinceInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, "id");
		NativeFieldInfoPtr__ownerFaction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, "<ownerFaction>k__BackingField");
		NativeFieldInfoPtr__stable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, "<stable>k__BackingField");
		NativeFieldInfoPtr_cachedNeiborProvinces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, "cachedNeiborProvinces");
		NativeFieldInfoPtr_guardsStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, "guardsStates");
		NativeMethodInfoPtr_get_ownerFaction_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678991);
		NativeMethodInfoPtr_set_ownerFaction_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678992);
		NativeMethodInfoPtr_get_stable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678993);
		NativeMethodInfoPtr_set_stable_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678994);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678995);
		NativeMethodInfoPtr__ctor_Public_Void_DLCProvince_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678996);
		NativeMethodInfoPtr_get_Templete_Public_get_DLCProvince_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678997);
		NativeMethodInfoPtr_get_OwnerFactionInstance_Public_get_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678998);
		NativeMethodInfoPtr_SetOwnerFaction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100678999);
		NativeMethodInfoPtr_GetRealIncomeData_Public_Dictionary_2_CurrencyType_Int64_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679000);
		NativeMethodInfoPtr_GetIncome_Public_GameItemPack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679001);
		NativeMethodInfoPtr_GetAllNeiborProvinceIds_Public_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679002);
		NativeMethodInfoPtr_GetAllNeiborProvinces_Public_List_1_Dlc1ProvinceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679003);
		NativeMethodInfoPtr_ModifyStable_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679004);
		NativeMethodInfoPtr_GetGuardsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679005);
		NativeMethodInfoPtr_GetGuardStateByIndex_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679006);
		NativeMethodInfoPtr_GetCharacterPoolDataByIndex_Public_CharacterPoolData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679007);
		NativeMethodInfoPtr_GetGuardInstanceByIndex_Public_GameCharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679008);
		NativeMethodInfoPtr_ApplyGuardState_Public_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679009);
		NativeMethodInfoPtr_ClearGuardState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679010);
		NativeMethodInfoPtr_GuardsRec_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr, 100679011);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 989590, RefRangeEnd = 989591, XrefRangeStart = 989583, XrefRangeEnd = 989590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1ProvinceInstance()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989591, XrefRangeEnd = 989598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1ProvinceInstance(DLCProvince dLCProvince)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1ProvinceInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCProvince);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DLCProvince_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 989698, RefRangeEnd = 989701, XrefRangeStart = 989680, XrefRangeEnd = 989698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOwnerFaction(int factionId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&factionId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOwnerFaction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 989814, RefRangeEnd = 989820, XrefRangeStart = 989701, XrefRangeEnd = 989814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<CurrencyType, long> GetRealIncomeData(bool getSpecial = false, bool multipyByStable = true, bool usePlayerBuffBonus = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&getSpecial);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &multipyByStable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePlayerBuffBonus;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRealIncomeData_Public_Dictionary_2_CurrencyType_Int64_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 989914, RefRangeEnd = 989915, XrefRangeStart = 989820, XrefRangeEnd = 989914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemPack GetIncome(int turnNum = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&turnNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIncome_Public_GameItemPack_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 989951, RefRangeEnd = 989956, XrefRangeStart = 989915, XrefRangeEnd = 989951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<int> GetAllNeiborProvinceIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeiborProvinceIds_Public_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 989998, RefRangeEnd = 990000, XrefRangeStart = 989956, XrefRangeEnd = 989998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Dlc1ProvinceInstance> GetAllNeiborProvinces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNeiborProvinces_Public_List_1_Dlc1ProvinceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dlc1ProvinceInstance>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 990001, RefRangeEnd = 990004, XrefRangeStart = 990000, XrefRangeEnd = 990001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyStable(int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyStable_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 990029, RefRangeEnd = 990034, XrefRangeStart = 990004, XrefRangeEnd = 990029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGuardsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGuardsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 990042, RefRangeEnd = 990046, XrefRangeStart = 990034, XrefRangeEnd = 990042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetGuardStateByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGuardStateByIndex_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 990084, RefRangeEnd = 990085, XrefRangeStart = 990046, XrefRangeEnd = 990084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterPoolData GetCharacterPoolDataByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterPoolDataByIndex_Public_CharacterPoolData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterPoolData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 990097, RefRangeEnd = 990099, XrefRangeStart = 990085, XrefRangeEnd = 990097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCharacterInstance GetGuardInstanceByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGuardInstanceByIndex_Public_GameCharacterInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990099, XrefRangeEnd = 990116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyGuardState(GameCharacterInstance gameCharacterInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyGuardState_Public_Void_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 990120, RefRangeEnd = 990121, XrefRangeStart = 990116, XrefRangeEnd = 990120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearGuardState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearGuardState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 990162, RefRangeEnd = 990163, XrefRangeStart = 990121, XrefRangeEnd = 990162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GuardsRec(float recRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&recRate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GuardsRec_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Dlc1ProvinceInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
