using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class SaveObjectDynamicData : SaveObjectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_storedDatas;

	private static readonly IntPtr NativeFieldInfoPtr_cachedInjectedDatas;

	private static readonly IntPtr NativeMethodInfoPtr_get_GlobalStoredData_Public_get_List_1_BaseDataStorageClass_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_GlobalStoredData_Public_set_Void_List_1_BaseDataStorageClass_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_InjectAllGlobalData_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InjectDataFromExternal_Public_Void_BaseDataStorageClass_0;

	private static readonly IntPtr NativeMethodInfoPtr_InjectData_Private_Void_BaseDataStorageClass_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveAllData_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveData_Public_Void_BaseDataStorageClass_0;

	private static readonly IntPtr NativeMethodInfoPtr_MoveDataFromLocalToGlobal_Public_Void_BaseDataStorageClass_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_MoveDataFromGlobalToLocal_Public_Void_BaseDataStorageClass_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<BaseDataStorageClass> storedDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedDatas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BaseDataStorageClass>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<BaseDataClass, HashSet<BaseDataStorageClass>> cachedInjectedDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedInjectedDatas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BaseDataClass, HashSet<BaseDataStorageClass>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedInjectedDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<BaseDataStorageClass> GlobalStoredData
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 846636, RefRangeEnd = 846654, XrefRangeStart = 846609, XrefRangeEnd = 846636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GlobalStoredData_Public_get_List_1_BaseDataStorageClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BaseDataStorageClass>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846654, XrefRangeEnd = 846670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GlobalStoredData_Public_set_Void_List_1_BaseDataStorageClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SaveObjectDynamicData()
	{
		Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectDynamicData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr);
		NativeFieldInfoPtr_storedDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, "storedDatas");
		NativeFieldInfoPtr_cachedInjectedDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, "cachedInjectedDatas");
		NativeMethodInfoPtr_get_GlobalStoredData_Public_get_List_1_BaseDataStorageClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673573);
		NativeMethodInfoPtr_set_GlobalStoredData_Public_set_Void_List_1_BaseDataStorageClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673574);
		NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673575);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673576);
		NativeMethodInfoPtr_InjectAllGlobalData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673577);
		NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673578);
		NativeMethodInfoPtr_InjectDataFromExternal_Public_Void_BaseDataStorageClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673579);
		NativeMethodInfoPtr_InjectData_Private_Void_BaseDataStorageClass_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673580);
		NativeMethodInfoPtr_RemoveAllData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673581);
		NativeMethodInfoPtr_RemoveData_Public_Void_BaseDataStorageClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673582);
		NativeMethodInfoPtr_MoveDataFromLocalToGlobal_Public_Void_BaseDataStorageClass_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673583);
		NativeMethodInfoPtr_MoveDataFromGlobalToLocal_Public_Void_BaseDataStorageClass_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673584);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr, 100673585);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846670, XrefRangeEnd = 846681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HashSet<GameDlcMode> GetValidSaveModes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameDlcMode>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846681, XrefRangeEnd = 846719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 846734, RefRangeEnd = 846736, XrefRangeStart = 846719, XrefRangeEnd = 846734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InjectAllGlobalData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InjectAllGlobalData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846736, XrefRangeEnd = 846747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 846759, RefRangeEnd = 846760, XrefRangeStart = 846747, XrefRangeEnd = 846759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InjectDataFromExternal(BaseDataStorageClass data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InjectDataFromExternal_Public_Void_BaseDataStorageClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 846789, RefRangeEnd = 846794, XrefRangeStart = 846760, XrefRangeEnd = 846789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InjectData(BaseDataStorageClass data, bool isFromGlobal = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isFromGlobal;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InjectData_Private_Void_BaseDataStorageClass_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 846834, RefRangeEnd = 846835, XrefRangeStart = 846794, XrefRangeEnd = 846834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 846881, RefRangeEnd = 846882, XrefRangeStart = 846835, XrefRangeEnd = 846881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveData(BaseDataStorageClass data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveData_Public_Void_BaseDataStorageClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 846903, RefRangeEnd = 846905, XrefRangeStart = 846882, XrefRangeEnd = 846903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveDataFromLocalToGlobal(BaseDataStorageClass data, bool backupLocal = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &backupLocal;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveDataFromLocalToGlobal_Public_Void_BaseDataStorageClass_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 846942, RefRangeEnd = 846944, XrefRangeStart = 846905, XrefRangeEnd = 846942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveDataFromGlobalToLocal(BaseDataStorageClass data, bool backupGlobal = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &backupGlobal;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveDataFromGlobalToLocal_Public_Void_BaseDataStorageClass_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846944, XrefRangeEnd = 846957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectDynamicData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectDynamicData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectDynamicData(IntPtr pointer)
		: base(pointer)
	{
	}
}
