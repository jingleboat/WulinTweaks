using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class GameItemManager : MonoSingleton<GameItemManager>
{
	private static readonly IntPtr NativeFieldInfoPtr__typeTireDict_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_isUsingItem;

	private static readonly IntPtr NativeMethodInfoPtr_get_typeTireDict_Public_Static_get_Dictionary_2_Int32_HashSet_1_ItemType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_typeTireDict_Private_Static_set_Void_Dictionary_2_Int32_HashSet_1_ItemType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemTypesByTire_Public_Static_HashSet_1_ItemType_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Dictionary<int, HashSet<ItemType>> _typeTireDict_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__typeTireDict_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, HashSet<ItemType>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__typeTireDict_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static bool isUsingItem
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isUsingItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isUsingItem, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<int, HashSet<ItemType>> typeTireDict
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816703, XrefRangeEnd = 816707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeTireDict_Public_Static_get_Dictionary_2_Int32_HashSet_1_ItemType_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, HashSet<ItemType>>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816707, XrefRangeEnd = 816711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_typeTireDict_Private_Static_set_Void_Dictionary_2_Int32_HashSet_1_ItemType_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GameItemManager()
	{
		Il2CppClassPointerStore<GameItemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameItemManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr);
		NativeFieldInfoPtr__typeTireDict_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, "<typeTireDict>k__BackingField");
		NativeFieldInfoPtr_isUsingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, "isUsingItem");
		NativeMethodInfoPtr_get_typeTireDict_Public_Static_get_Dictionary_2_Int32_HashSet_1_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, 100672629);
		NativeMethodInfoPtr_set_typeTireDict_Private_Static_set_Void_Dictionary_2_Int32_HashSet_1_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, 100672630);
		NativeMethodInfoPtr_GetItemTypesByTire_Public_Static_HashSet_1_ItemType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, 100672631);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, 100672632);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr, 100672633);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 816808, RefRangeEnd = 816810, XrefRangeStart = 816711, XrefRangeEnd = 816808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<ItemType> GetItemTypesByTire(int tire)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&tire);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemTypesByTire_Public_Static_HashSet_1_ItemType_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ItemType>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816810, XrefRangeEnd = 816823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816823, XrefRangeEnd = 816829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameItemManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameItemManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameItemManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
