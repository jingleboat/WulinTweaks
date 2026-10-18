using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class SlgLeaderCustomManager : MonoSingleton<SlgLeaderCustomManager>
{
	private static readonly IntPtr NativeFieldInfoPtr__TotalPoints_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__CurPoints_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Leader_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ItemPack_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__SelectableBgTraitDatas_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__SelectableTraitDatas_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TraitSelected_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__SelectedBgIndex_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__PropPointCost_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__MainPropDictAdditionDict_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_playerAltAvatar;

	private static readonly IntPtr NativeFieldInfoPtr_playerAltAvatars;

	private static readonly IntPtr NativeFieldInfoPtr__PlayerAltAvatarIndex_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_TotalPoints_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_TotalPoints_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CurPoints_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CurPoints_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Leader_Public_get_GameCharacterInstance_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Leader_Private_set_Void_GameCharacterInstance_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ItemPack_Public_get_GameItemPack_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ItemPack_Private_set_Void_GameItemPack_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SelectableBgTraitDatas_Public_get_List_1_TraitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SelectableBgTraitDatas_Private_set_Void_List_1_TraitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SelectableTraitDatas_Public_get_List_1_TraitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SelectableTraitDatas_Private_set_Void_List_1_TraitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TraitSelected_Public_get_List_1_TraitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_TraitSelected_Private_set_Void_List_1_TraitData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SelectedBgIndex_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SelectedBgIndex_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PropPointCost_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_PropPointCost_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MainPropDictAdditionDict_Public_get_Dictionary_2_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_MainPropDictAdditionDict_Private_set_Void_Dictionary_2_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerAltAvatarIndex_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_PlayerAltAvatarIndex_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitData_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SwitchTrait_Public_Void_TraitData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SelectBgTrait_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CouldPropChange_Public_Boolean_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMainPropModify_Public_Void_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ConfirmLeader_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerAltAvatar_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyTrait_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CountPoints_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int _TotalPoints_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalPoints_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalPoints_k__BackingField)) = num;
		}
	}

	public unsafe int _CurPoints_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurPoints_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurPoints_k__BackingField)) = num;
		}
	}

	public unsafe GameCharacterInstance _Leader_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Leader_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Leader_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	public unsafe GameItemPack _ItemPack_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ItemPack_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ItemPack_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe List<TraitData> _SelectableBgTraitDatas_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectableBgTraitDatas_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectableBgTraitDatas_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<TraitData> _SelectableTraitDatas_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectableTraitDatas_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectableTraitDatas_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<TraitData> _TraitSelected_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TraitSelected_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TraitSelected_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int _SelectedBgIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectedBgIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectedBgIndex_k__BackingField)) = num;
		}
	}

	public unsafe int _PropPointCost_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PropPointCost_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PropPointCost_k__BackingField)) = num;
		}
	}

	public unsafe Dictionary<string, int> _MainPropDictAdditionDict_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MainPropDictAdditionDict_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MainPropDictAdditionDict_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe string playerAltAvatar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAltAvatar);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAltAvatar)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> playerAltAvatars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAltAvatars);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAltAvatars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int _PlayerAltAvatarIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAltAvatarIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAltAvatarIndex_k__BackingField)) = num;
		}
	}

	public unsafe int TotalPoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68154, RefRangeEnd = 68157, XrefRangeStart = 68154, XrefRangeEnd = 68157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TotalPoints_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int CurPoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 68133, RefRangeEnd = 68139, XrefRangeStart = 68133, XrefRangeEnd = 68139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurPoints_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GameCharacterInstance Leader
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Leader_Public_get_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Leader_Private_set_Void_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GameItemPack ItemPack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemPack_Public_get_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 73196, RefRangeEnd = 73201, XrefRangeStart = 73196, XrefRangeEnd = 73201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ItemPack_Private_set_Void_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<TraitData> SelectableBgTraitDatas
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18873, RefRangeEnd = 18874, XrefRangeStart = 18873, XrefRangeEnd = 18874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SelectableBgTraitDatas_Public_get_List_1_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SelectableBgTraitDatas_Private_set_Void_List_1_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<TraitData> SelectableTraitDatas
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SelectableTraitDatas_Public_get_List_1_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SelectableTraitDatas_Private_set_Void_List_1_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<TraitData> TraitSelected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TraitSelected_Public_get_List_1_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<TraitData>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TraitSelected_Private_set_Void_List_1_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int SelectedBgIndex
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 73513, RefRangeEnd = 73520, XrefRangeStart = 73513, XrefRangeEnd = 73520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SelectedBgIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SelectedBgIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int PropPointCost
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PropPointCost_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PropPointCost_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<string, int> MainPropDictAdditionDict
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 56998, RefRangeEnd = 57011, XrefRangeStart = 56998, XrefRangeEnd = 57011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MainPropDictAdditionDict_Public_get_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MainPropDictAdditionDict_Private_set_Void_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int PlayerAltAvatarIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAltAvatarIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlayerAltAvatarIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SlgLeaderCustomManager()
	{
		Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SlgLeaderCustomManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr);
		NativeFieldInfoPtr__TotalPoints_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<TotalPoints>k__BackingField");
		NativeFieldInfoPtr__CurPoints_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<CurPoints>k__BackingField");
		NativeFieldInfoPtr__Leader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<Leader>k__BackingField");
		NativeFieldInfoPtr__ItemPack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<ItemPack>k__BackingField");
		NativeFieldInfoPtr__SelectableBgTraitDatas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<SelectableBgTraitDatas>k__BackingField");
		NativeFieldInfoPtr__SelectableTraitDatas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<SelectableTraitDatas>k__BackingField");
		NativeFieldInfoPtr__TraitSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<TraitSelected>k__BackingField");
		NativeFieldInfoPtr__SelectedBgIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<SelectedBgIndex>k__BackingField");
		NativeFieldInfoPtr__PropPointCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<PropPointCost>k__BackingField");
		NativeFieldInfoPtr__MainPropDictAdditionDict_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<MainPropDictAdditionDict>k__BackingField");
		NativeFieldInfoPtr_playerAltAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "playerAltAvatar");
		NativeFieldInfoPtr_playerAltAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "playerAltAvatars");
		NativeFieldInfoPtr__PlayerAltAvatarIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, "<PlayerAltAvatarIndex>k__BackingField");
		NativeMethodInfoPtr_get_TotalPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679462);
		NativeMethodInfoPtr_set_TotalPoints_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679463);
		NativeMethodInfoPtr_get_CurPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679464);
		NativeMethodInfoPtr_set_CurPoints_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679465);
		NativeMethodInfoPtr_get_Leader_Public_get_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679466);
		NativeMethodInfoPtr_set_Leader_Private_set_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679467);
		NativeMethodInfoPtr_get_ItemPack_Public_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679468);
		NativeMethodInfoPtr_set_ItemPack_Private_set_Void_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679469);
		NativeMethodInfoPtr_get_SelectableBgTraitDatas_Public_get_List_1_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679470);
		NativeMethodInfoPtr_set_SelectableBgTraitDatas_Private_set_Void_List_1_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679471);
		NativeMethodInfoPtr_get_SelectableTraitDatas_Public_get_List_1_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679472);
		NativeMethodInfoPtr_set_SelectableTraitDatas_Private_set_Void_List_1_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679473);
		NativeMethodInfoPtr_get_TraitSelected_Public_get_List_1_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679474);
		NativeMethodInfoPtr_set_TraitSelected_Private_set_Void_List_1_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679475);
		NativeMethodInfoPtr_get_SelectedBgIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679476);
		NativeMethodInfoPtr_set_SelectedBgIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679477);
		NativeMethodInfoPtr_get_PropPointCost_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679478);
		NativeMethodInfoPtr_set_PropPointCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679479);
		NativeMethodInfoPtr_get_MainPropDictAdditionDict_Public_get_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679480);
		NativeMethodInfoPtr_set_MainPropDictAdditionDict_Private_set_Void_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679481);
		NativeMethodInfoPtr_get_PlayerAltAvatarIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679482);
		NativeMethodInfoPtr_set_PlayerAltAvatarIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679483);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679484);
		NativeMethodInfoPtr_InitData_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679485);
		NativeMethodInfoPtr_SwitchTrait_Public_Void_TraitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679486);
		NativeMethodInfoPtr_SelectBgTrait_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679487);
		NativeMethodInfoPtr_CouldPropChange_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679488);
		NativeMethodInfoPtr_SetMainPropModify_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679489);
		NativeMethodInfoPtr_ConfirmLeader_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679490);
		NativeMethodInfoPtr_SetPlayerAltAvatar_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679491);
		NativeMethodInfoPtr_ApplyTrait_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679492);
		NativeMethodInfoPtr_CountPoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679493);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr, 100679494);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003970, XrefRangeEnd = 1003973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1004039, RefRangeEnd = 1004040, XrefRangeStart = 1003973, XrefRangeEnd = 1004039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitData(int factionId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&factionId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitData_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004040, XrefRangeEnd = 1004050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchTrait(TraitData traitData, bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traitData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isOn;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchTrait_Public_Void_TraitData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004050, XrefRangeEnd = 1004051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectBgTrait(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectBgTrait_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1004069, RefRangeEnd = 1004074, XrefRangeStart = 1004051, XrefRangeEnd = 1004069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldPropChange(string key, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldPropChange_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004074, XrefRangeEnd = 1004080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMainPropModify(string key, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMainPropModify_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1004110, RefRangeEnd = 1004111, XrefRangeStart = 1004080, XrefRangeEnd = 1004110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmLeader()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfirmLeader_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1004116, RefRangeEnd = 1004117, XrefRangeStart = 1004111, XrefRangeEnd = 1004116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerAltAvatar(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerAltAvatar_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1004161, RefRangeEnd = 1004166, XrefRangeStart = 1004117, XrefRangeEnd = 1004161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTrait()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTrait_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1004197, RefRangeEnd = 1004200, XrefRangeStart = 1004166, XrefRangeEnd = 1004197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CountPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountPoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004200, XrefRangeEnd = 1004229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgLeaderCustomManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgLeaderCustomManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgLeaderCustomManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
