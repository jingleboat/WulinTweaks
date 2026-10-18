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

public class ItemModifyData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_templeteUid;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_rawRnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideBonusExt;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideEquipReq;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeEffect;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateForgeModify_Public_Static_ItemModifyData_ItemData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeBonus_Public_Void_ItemForgeData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int templeteUid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templeteUid);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templeteUid)) = num;
		}
	}

	public unsafe int forgeLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeLevel)) = num;
		}
	}

	public unsafe List<float> rawRnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawRnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawRnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KeyWithValues> overrideBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyWithValues>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBonus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KeyWithValues> overrideBonusExt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBonusExt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyWithValues>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBonusExt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KeyWithValues> overrideEquipReq
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEquipReq);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyWithValues>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEquipReq)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, KeyWithValues> forgeEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeEffect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, KeyWithValues>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static ItemModifyData()
	{
		Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ItemModifyData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr);
		NativeFieldInfoPtr_templeteUid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "templeteUid");
		NativeFieldInfoPtr_forgeLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "forgeLevel");
		NativeFieldInfoPtr_rawRnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "rawRnd");
		NativeFieldInfoPtr_overrideBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "overrideBonus");
		NativeFieldInfoPtr_overrideBonusExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "overrideBonusExt");
		NativeFieldInfoPtr_overrideEquipReq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "overrideEquipReq");
		NativeFieldInfoPtr_forgeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, "forgeEffect");
		NativeMethodInfoPtr_CreateForgeModify_Public_Static_ItemModifyData_ItemData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, 100672730);
		NativeMethodInfoPtr_ComputeBonus_Public_Void_ItemForgeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, 100672731);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr, 100672732);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 819278, RefRangeEnd = 819284, XrefRangeStart = 819260, XrefRangeEnd = 819278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ItemModifyData CreateForgeModify(ItemData itemData, int forgeLevel = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forgeLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateForgeModify_Public_Static_ItemModifyData_ItemData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemModifyData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 819432, RefRangeEnd = 819433, XrefRangeStart = 819284, XrefRangeEnd = 819432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeBonus(ItemForgeData data, int forgeLevel = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forgeLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeBonus_Public_Void_ItemForgeData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 819440, RefRangeEnd = 819441, XrefRangeStart = 819433, XrefRangeEnd = 819440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemModifyData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemModifyData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemModifyData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
