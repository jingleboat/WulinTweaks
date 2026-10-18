using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class SaveObjectGame : SaveObjectBase
{
	public class SaveFileError : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_errorHappensDateTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameVerision;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		public unsafe string filePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string errorHappensDateTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorHappensDateTime);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorHappensDateTime)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string gameVerision
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVerision);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVerision)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static SaveFileError()
		{
			Il2CppClassPointerStore<SaveFileError>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "SaveFileError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr);
			NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr, "filePath");
			NativeFieldInfoPtr_errorHappensDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr, "errorHappensDateTime");
			NativeFieldInfoPtr_gameVerision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr, "gameVerision");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr, 100686923);
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr, 100686924);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveFileError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 847055, RefRangeEnd = 847056, XrefRangeStart = 847042, XrefRangeEnd = 847055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveFileError(string filePath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileError>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SaveFileError(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ModUseLog : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_modKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_modApplyTime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		public unsafe string modKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modKeys);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modKeys)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string modApplyTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modApplyTime);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modApplyTime)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static ModUseLog()
		{
			Il2CppClassPointerStore<ModUseLog>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "ModUseLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModUseLog>.NativeClassPtr);
			NativeFieldInfoPtr_modKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModUseLog>.NativeClassPtr, "modKeys");
			NativeFieldInfoPtr_modApplyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModUseLog>.NativeClassPtr, "modApplyTime");
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModUseLog>.NativeClassPtr, 100686925);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 847062, RefRangeEnd = 847063, XrefRangeStart = 847056, XrefRangeEnd = 847062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModUseLog(string modKeys)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModUseLog>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(modKeys);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ModUseLog(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueNumDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleAuto;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleFastforward;

	private static readonly System.IntPtr NativeFieldInfoPtr_isStealthMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOnWorldMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalPlayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_miscIntDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_miscFloatDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_miscStringDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_customDiffDataSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_latestSaveFileErrors;

	private static readonly System.IntPtr NativeFieldInfoPtr_latestModLogs;

	private static readonly System.IntPtr NativeFieldInfoPtr_historyDlcs;

	private static readonly System.IntPtr NativeFieldInfoPtr_enabledDlcs;

	private static readonly System.IntPtr NativeFieldInfoPtr_pernamentFunctionMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_temporyFunctionMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalGameFunctionMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_privateFiefSharedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiefUnsharedData;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniqueInteger_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateUniqueInteger_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGameFunctionMask_Public_Void_String_GameFunctionMask_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterGameFunctionMask_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFinalGameFunctionMask_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasGameFunctionMask_Public_Boolean_GameFunctionMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReportSaveFileError_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckModUsage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDlcs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<string, int> uniqueNumDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueNumDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueNumDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool battleAuto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleAuto);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleAuto)) = flag;
		}
	}

	public unsafe bool battleFastforward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleFastforward);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleFastforward)) = flag;
		}
	}

	public unsafe bool isStealthMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStealthMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStealthMode)) = flag;
		}
	}

	public unsafe bool isOnWorldMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOnWorldMap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOnWorldMap)) = flag;
		}
	}

	public unsafe double totalPlayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalPlayTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalPlayTime)) = num;
		}
	}

	public unsafe Dictionary<string, int> miscIntDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscIntDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscIntDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, float> miscFloatDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscFloatDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscFloatDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, string> miscStringDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscStringDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscStringDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameManager.CustomDiffDataSettings customDiffDataSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDiffDataSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameManager.CustomDiffDataSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDiffDataSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customDiffDataSettings));
		}
	}

	public unsafe List<SaveFileError> latestSaveFileErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_latestSaveFileErrors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SaveFileError>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_latestSaveFileErrors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ModUseLog> latestModLogs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_latestModLogs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ModUseLog>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_latestModLogs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<GameDlcMode, bool> historyDlcs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_historyDlcs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameDlcMode, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_historyDlcs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<GameDlcMode, bool> enabledDlcs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabledDlcs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameDlcMode, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabledDlcs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, GameFunctionMask> pernamentFunctionMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pernamentFunctionMasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, GameFunctionMask>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pernamentFunctionMasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, GameFunctionMask> temporyFunctionMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temporyFunctionMasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, GameFunctionMask>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temporyFunctionMasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameFunctionMask finalGameFunctionMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalGameFunctionMask);
			return *(GameFunctionMask*)num;
		}
		set
		{
			*(GameFunctionMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalGameFunctionMask)) = gameFunctionMask;
		}
	}

	public unsafe FiefSharedData privateFiefSharedData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_privateFiefSharedData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FiefSharedData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_privateFiefSharedData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fiefSharedData));
		}
	}

	public unsafe FiefUnsharedData fiefUnsharedData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefUnsharedData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FiefUnsharedData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefUnsharedData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fiefUnsharedData));
		}
	}

	static SaveObjectGame()
	{
		Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr);
		NativeFieldInfoPtr_uniqueNumDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "uniqueNumDict");
		NativeFieldInfoPtr_battleAuto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "battleAuto");
		NativeFieldInfoPtr_battleFastforward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "battleFastforward");
		NativeFieldInfoPtr_isStealthMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "isStealthMode");
		NativeFieldInfoPtr_isOnWorldMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "isOnWorldMap");
		NativeFieldInfoPtr_totalPlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "totalPlayTime");
		NativeFieldInfoPtr_miscIntDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "miscIntDict");
		NativeFieldInfoPtr_miscFloatDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "miscFloatDict");
		NativeFieldInfoPtr_miscStringDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "miscStringDict");
		NativeFieldInfoPtr_customDiffDataSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "customDiffDataSettings");
		NativeFieldInfoPtr_latestSaveFileErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "latestSaveFileErrors");
		NativeFieldInfoPtr_latestModLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "latestModLogs");
		NativeFieldInfoPtr_historyDlcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "historyDlcs");
		NativeFieldInfoPtr_enabledDlcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "enabledDlcs");
		NativeFieldInfoPtr_pernamentFunctionMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "pernamentFunctionMasks");
		NativeFieldInfoPtr_temporyFunctionMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "temporyFunctionMasks");
		NativeFieldInfoPtr_finalGameFunctionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "finalGameFunctionMask");
		NativeFieldInfoPtr_privateFiefSharedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "privateFiefSharedData");
		NativeFieldInfoPtr_fiefUnsharedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, "fiefUnsharedData");
		NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673596);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673597);
		NativeMethodInfoPtr_GetUniqueInteger_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673598);
		NativeMethodInfoPtr_GenerateUniqueInteger_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673599);
		NativeMethodInfoPtr_RegisterGameFunctionMask_Public_Void_String_GameFunctionMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673600);
		NativeMethodInfoPtr_UnregisterGameFunctionMask_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673601);
		NativeMethodInfoPtr_UpdateFinalGameFunctionMask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673602);
		NativeMethodInfoPtr_HasGameFunctionMask_Public_Boolean_GameFunctionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673603);
		NativeMethodInfoPtr_ReportSaveFileError_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673604);
		NativeMethodInfoPtr_CheckModUsage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673605);
		NativeMethodInfoPtr_CheckDlcs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673606);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr, 100673607);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847063, XrefRangeEnd = 847074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HashSet<GameDlcMode> GetValidSaveModes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameDlcMode>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847074, XrefRangeEnd = 847086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847096, RefRangeEnd = 847097, XrefRangeStart = 847086, XrefRangeEnd = 847096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUniqueInteger(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniqueInteger_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847112, RefRangeEnd = 847113, XrefRangeStart = 847097, XrefRangeEnd = 847112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateUniqueInteger(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateUniqueInteger_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847127, RefRangeEnd = 847128, XrefRangeStart = 847113, XrefRangeEnd = 847127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterGameFunctionMask(string key, GameFunctionMask mask, bool isPernament = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(GameFunctionMask**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPernament;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGameFunctionMask_Public_Void_String_GameFunctionMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847135, RefRangeEnd = 847136, XrefRangeStart = 847128, XrefRangeEnd = 847135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterGameFunctionMask(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterGameFunctionMask_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 847175, RefRangeEnd = 847177, XrefRangeStart = 847136, XrefRangeEnd = 847175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFinalGameFunctionMask()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFinalGameFunctionMask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool HasGameFunctionMask(GameFunctionMask mask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasGameFunctionMask_Public_Boolean_GameFunctionMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847206, RefRangeEnd = 847207, XrefRangeStart = 847177, XrefRangeEnd = 847206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportSaveFileError(string filePath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportSaveFileError_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847233, RefRangeEnd = 847234, XrefRangeStart = 847207, XrefRangeEnd = 847233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckModUsage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckModUsage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 847323, RefRangeEnd = 847324, XrefRangeStart = 847234, XrefRangeEnd = 847323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDlcs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDlcs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847324, XrefRangeEnd = 847383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectGame>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectGame(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
