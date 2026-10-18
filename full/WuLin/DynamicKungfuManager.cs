using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class DynamicKungfuManager : MonoSingleton<DynamicKungfuManager>
{
	public enum CraftNewKungfuCheckResult
	{
		Ok = 0,
		DataError = 10,
		DataNotMatched = 20,
		KungfuType = 21,
		Rarity = 22,
		NotEnoughItem = 30
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_newKungfuData;

	private static readonly System.IntPtr NativeFieldInfoPtr_newKungfuBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_newKungfuOwner;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniqueNewKungfuId_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFactorByRarity_Private_Decimal_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStrByRarity_Private_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTempleteDynamic_Public_Boolean_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKungfuInstanceCouldUseForCraft_Public_Boolean_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCraftCostForNewKungfu_Public_Dictionary_2_ItemData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCraftTimeCostForNewKungfu_Public_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCraftStaCostForNewKungfu_Public_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCouldCraftNewKungfu_Public_CraftNewKungfuCheckResult_GameCharacterInstance_KungfuInstance_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CraftNewKungfu_Public_KungfuData_GameCharacterInstance_KungfuInstance_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLastNewKungfuAndSetName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveKungfuTempleteDataToGlobal_Public_Void_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveKungfuTempleteDataToLocal_Public_Void_KungfuData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllRelatedDataByKungfu_Private_List_1_BaseDataStorageClass_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe KungfuData newKungfuData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData));
		}
	}

	public unsafe ItemData newKungfuBook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuBook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuBook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData));
		}
	}

	public unsafe GameCharacterInstance newKungfuOwner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuOwner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newKungfuOwner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	static DynamicKungfuManager()
	{
		Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DynamicKungfuManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr);
		NativeFieldInfoPtr_newKungfuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, "newKungfuData");
		NativeFieldInfoPtr_newKungfuBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, "newKungfuBook");
		NativeFieldInfoPtr_newKungfuOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, "newKungfuOwner");
		NativeMethodInfoPtr_GetUniqueNewKungfuId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671990);
		NativeMethodInfoPtr_GetFactorByRarity_Private_Decimal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671991);
		NativeMethodInfoPtr_GetStrByRarity_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671992);
		NativeMethodInfoPtr_IsTempleteDynamic_Public_Boolean_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671993);
		NativeMethodInfoPtr_IsKungfuInstanceCouldUseForCraft_Public_Boolean_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671994);
		NativeMethodInfoPtr_GetCraftCostForNewKungfu_Public_Dictionary_2_ItemData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671995);
		NativeMethodInfoPtr_GetCraftTimeCostForNewKungfu_Public_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671996);
		NativeMethodInfoPtr_GetCraftStaCostForNewKungfu_Public_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671997);
		NativeMethodInfoPtr_CheckCouldCraftNewKungfu_Public_CraftNewKungfuCheckResult_GameCharacterInstance_KungfuInstance_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671998);
		NativeMethodInfoPtr_CraftNewKungfu_Public_KungfuData_GameCharacterInstance_KungfuInstance_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100671999);
		NativeMethodInfoPtr_ApplyLastNewKungfuAndSetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100672000);
		NativeMethodInfoPtr_MoveKungfuTempleteDataToGlobal_Public_Void_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100672001);
		NativeMethodInfoPtr_MoveKungfuTempleteDataToLocal_Public_Void_KungfuData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100672002);
		NativeMethodInfoPtr_GetAllRelatedDataByKungfu_Private_List_1_BaseDataStorageClass_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100672003);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr, 100672004);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796325, XrefRangeEnd = 796354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUniqueNewKungfuId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniqueNewKungfuId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796362, RefRangeEnd = 796364, XrefRangeStart = 796354, XrefRangeEnd = 796362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetFactorByRarity(string key, int rarity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rarity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFactorByRarity_Private_Decimal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796364, XrefRangeEnd = 796372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetStrByRarity(string key, int rarity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rarity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStrByRarity_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 796382, RefRangeEnd = 796389, XrefRangeStart = 796372, XrefRangeEnd = 796382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTempleteDynamic(KungfuData templete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templete);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTempleteDynamic_Public_Boolean_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796390, RefRangeEnd = 796392, XrefRangeStart = 796389, XrefRangeEnd = 796390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKungfuInstanceCouldUseForCraft(KungfuInstance kungfuInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKungfuInstanceCouldUseForCraft_Public_Boolean_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796392, XrefRangeEnd = 796398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<ItemData, int> GetCraftCostForNewKungfu(int templeteRarity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&templeteRarity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCraftCostForNewKungfu_Public_Dictionary_2_ItemData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemData, int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796401, RefRangeEnd = 796402, XrefRangeStart = 796398, XrefRangeEnd = 796401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetCraftTimeCostForNewKungfu(int templeteRarity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&templeteRarity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCraftTimeCostForNewKungfu_Public_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796405, RefRangeEnd = 796407, XrefRangeStart = 796402, XrefRangeEnd = 796405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetCraftStaCostForNewKungfu(int templeteRarity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&templeteRarity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCraftStaCostForNewKungfu_Public_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796450, RefRangeEnd = 796452, XrefRangeStart = 796407, XrefRangeEnd = 796450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CraftNewKungfuCheckResult CheckCouldCraftNewKungfu(GameCharacterInstance gameCharacterInstance, KungfuInstance kungfuInstance1, KungfuInstance kungfuInstance2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCouldCraftNewKungfu_Public_CraftNewKungfuCheckResult_GameCharacterInstance_KungfuInstance_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CraftNewKungfuCheckResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796532, RefRangeEnd = 796534, XrefRangeStart = 796452, XrefRangeEnd = 796532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuData CraftNewKungfu(GameCharacterInstance gameCharacterInstance, KungfuInstance kungfuInstance1, KungfuInstance kungfuInstance2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CraftNewKungfu_Public_KungfuData_GameCharacterInstance_KungfuInstance_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796579, RefRangeEnd = 796581, XrefRangeStart = 796534, XrefRangeEnd = 796579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyLastNewKungfuAndSetName(string kungfuName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(kungfuName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLastNewKungfuAndSetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796603, RefRangeEnd = 796604, XrefRangeStart = 796581, XrefRangeEnd = 796603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveKungfuTempleteDataToGlobal(KungfuData templete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templete);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveKungfuTempleteDataToGlobal_Public_Void_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796626, RefRangeEnd = 796627, XrefRangeStart = 796604, XrefRangeEnd = 796626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveKungfuTempleteDataToLocal(KungfuData templete, bool isCopy = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templete);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCopy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveKungfuTempleteDataToLocal_Public_Void_KungfuData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 796692, RefRangeEnd = 796694, XrefRangeStart = 796627, XrefRangeEnd = 796692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseDataStorageClass> GetAllRelatedDataByKungfu(KungfuData templete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templete);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllRelatedDataByKungfu_Private_List_1_BaseDataStorageClass_KungfuData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BaseDataStorageClass>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796694, XrefRangeEnd = 796700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicKungfuManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicKungfuManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DynamicKungfuManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
