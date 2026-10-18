using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.Soundy;

[Serializable]
public class SoundySettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_database;

	private static readonly IntPtr NativeFieldInfoPtr_AUTO_KILL_IDLE_CONTROLLERS_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MIN;

	private static readonly IntPtr NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MAX;

	private static readonly IntPtr NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MIN;

	private static readonly IntPtr NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MAX;

	private static readonly IntPtr NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MIN;

	private static readonly IntPtr NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MAX;

	private static readonly IntPtr NativeFieldInfoPtr_AutoKillIdleControllers;

	private static readonly IntPtr NativeFieldInfoPtr_ControllerIdleKillDuration;

	private static readonly IntPtr NativeFieldInfoPtr_IdleCheckInterval;

	private static readonly IntPtr NativeFieldInfoPtr_MinimumNumberOfControllers;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SoundySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_Static_get_SoundyDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetComponent_Public_Void_SoundyPooler_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UndoRecord_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string FILE_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static SoundySettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SoundySettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundySettings));
		}
	}

	public unsafe SoundyDatabase database
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_database);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_database)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundyDatabase));
		}
	}

	public unsafe static bool AUTO_KILL_IDLE_CONTROLLERS_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTO_KILL_IDLE_CONTROLLERS_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTO_KILL_IDLE_CONTROLLERS_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static float CONTROLLER_IDLE_KILL_DURATION_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static float CONTROLLER_IDLE_KILL_DURATION_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MIN, (void*)(&num));
		}
	}

	public unsafe static float CONTROLLER_IDLE_KILL_DURATION_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MAX, (void*)(&num));
		}
	}

	public unsafe static float IDLE_CHECK_INTERVAL_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static float IDLE_CHECK_INTERVAL_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MIN, (void*)(&num));
		}
	}

	public unsafe static float IDLE_CHECK_INTERVAL_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MAX, (void*)(&num));
		}
	}

	public unsafe static int MINIMUM_NUMBER_OF_CONTROLLERS_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static int MINIMUM_NUMBER_OF_CONTROLLERS_MIN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MIN, (void*)(&num));
		}
	}

	public unsafe static int MINIMUM_NUMBER_OF_CONTROLLERS_MAX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MAX, (void*)(&num));
		}
	}

	public unsafe bool AutoKillIdleControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoKillIdleControllers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoKillIdleControllers)) = flag;
		}
	}

	public unsafe float ControllerIdleKillDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerIdleKillDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerIdleKillDuration)) = num;
		}
	}

	public unsafe float IdleCheckInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdleCheckInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdleCheckInterval)) = num;
		}
	}

	public unsafe int MinimumNumberOfControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumNumberOfControllers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumNumberOfControllers)) = num;
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745360, XrefRangeEnd = 745364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static SoundySettings Instance
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 745381, RefRangeEnd = 745397, XrefRangeStart = 745364, XrefRangeEnd = 745381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SoundySettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundySettings>(intPtr) : null;
		}
	}

	public unsafe static SoundyDatabase Database
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 745413, RefRangeEnd = 745423, XrefRangeStart = 745397, XrefRangeEnd = 745413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Database_Public_Static_get_SoundyDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyDatabase>(intPtr) : null;
		}
	}

	static SoundySettings()
	{
		Il2CppClassPointerStore<SoundySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Soundy", "SoundySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "database");
		NativeFieldInfoPtr_AUTO_KILL_IDLE_CONTROLLERS_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "AUTO_KILL_IDLE_CONTROLLERS_DEFAULT_VALUE");
		NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "CONTROLLER_IDLE_KILL_DURATION_DEFAULT_VALUE");
		NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "CONTROLLER_IDLE_KILL_DURATION_MIN");
		NativeFieldInfoPtr_CONTROLLER_IDLE_KILL_DURATION_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "CONTROLLER_IDLE_KILL_DURATION_MAX");
		NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "IDLE_CHECK_INTERVAL_DEFAULT_VALUE");
		NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "IDLE_CHECK_INTERVAL_MIN");
		NativeFieldInfoPtr_IDLE_CHECK_INTERVAL_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "IDLE_CHECK_INTERVAL_MAX");
		NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "MINIMUM_NUMBER_OF_CONTROLLERS_DEFAULT_VALUE");
		NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "MINIMUM_NUMBER_OF_CONTROLLERS_MIN");
		NativeFieldInfoPtr_MINIMUM_NUMBER_OF_CONTROLLERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "MINIMUM_NUMBER_OF_CONTROLLERS_MAX");
		NativeFieldInfoPtr_AutoKillIdleControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "AutoKillIdleControllers");
		NativeFieldInfoPtr_ControllerIdleKillDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "ControllerIdleKillDuration");
		NativeFieldInfoPtr_IdleCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "IdleCheckInterval");
		NativeFieldInfoPtr_MinimumNumberOfControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, "MinimumNumberOfControllers");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668777);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SoundySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668778);
		NativeMethodInfoPtr_get_Database_Public_Static_get_SoundyDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668779);
		NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668780);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668781);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668782);
		NativeMethodInfoPtr_ResetComponent_Public_Void_SoundyPooler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668783);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668784);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668785);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr, 100668786);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745423, XrefRangeEnd = 745433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateDatabase()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745433, XrefRangeEnd = 745437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetComponent(SoundyPooler pooler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pooler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetComponent_Public_Void_SoundyPooler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745437, XrefRangeEnd = 745441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDirty(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745441, XrefRangeEnd = 745445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UndoRecord(string undoMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecord_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745445, XrefRangeEnd = 745446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundySettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundySettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SoundySettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
