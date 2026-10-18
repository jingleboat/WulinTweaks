using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class SaveObjectBase : SerializedScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_m_saveFile;

	private static readonly IntPtr NativeFieldInfoPtr_isSyncing;

	private static readonly IntPtr NativeFieldInfoPtr_unixTimeStamp;

	private static readonly IntPtr NativeFieldInfoPtr_stampUtcDateTime;

	private static readonly IntPtr NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_New_HashSet_1_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_New_Void_SaveObjectBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sync_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsGlobal_Public_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSaveFileName_Protected_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ES3File m_saveFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_saveFile);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ES3File>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_saveFile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eS3File));
		}
	}

	public unsafe bool isSyncing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSyncing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSyncing)) = flag;
		}
	}

	public unsafe long unixTimeStamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unixTimeStamp);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unixTimeStamp)) = num;
		}
	}

	public unsafe string stampUtcDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stampUtcDateTime);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stampUtcDateTime)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SaveObjectBase()
	{
		Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr);
		NativeFieldInfoPtr_m_saveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, "m_saveFile");
		NativeFieldInfoPtr_isSyncing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, "isSyncing");
		NativeFieldInfoPtr_unixTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, "unixTimeStamp");
		NativeFieldInfoPtr_stampUtcDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, "stampUtcDateTime");
		NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_New_HashSet_1_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673547);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_New_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673548);
		NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673549);
		NativeMethodInfoPtr_Save_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673550);
		NativeMethodInfoPtr_Sync_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673551);
		NativeMethodInfoPtr_IsGlobal_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673552);
		NativeMethodInfoPtr_GetSaveFileName_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673553);
		NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673554);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr, 100673555);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845809, XrefRangeEnd = 845818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual HashSet<GameDlcMode> GetValidSaveModes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_New_HashSet_1_GameDlcMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameDlcMode>>(intPtr) : null;
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 845946, RefRangeEnd = 845966, XrefRangeStart = 845818, XrefRangeEnd = 845946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_New_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 846004, RefRangeEnd = 846015, XrefRangeStart = 845966, XrefRangeEnd = 846004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Save(bool sync = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&sync);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Save_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846015, XrefRangeEnd = 846074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Sync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Sync_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsGlobal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsGlobal_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 846106, RefRangeEnd = 846114, XrefRangeStart = 846074, XrefRangeEnd = 846106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSaveFileName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSaveFileName_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 846135, RefRangeEnd = 846137, XrefRangeStart = 846114, XrefRangeEnd = 846135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(70)]
	[CachedScanResults(RefRangeStart = 378729, RefRangeEnd = 378799, XrefRangeStart = 378729, XrefRangeEnd = 378799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
