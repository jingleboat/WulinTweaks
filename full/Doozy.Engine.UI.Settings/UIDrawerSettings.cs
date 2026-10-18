using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Touchy;
using Doozy.Engine.UI.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Settings;

[Serializable]
public class UIDrawerSettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_database;

	private static readonly IntPtr NativeFieldInfoPtr_CLOSE_DIRECTION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DETECT_GESTURES_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CLOSE_SPEED_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_OPEN_SPEED_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_RENAME_PREFIX_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_RENAME_SUFFIX_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CloseDirection;

	private static readonly IntPtr NativeFieldInfoPtr_CustomStartAnchoredPosition;

	private static readonly IntPtr NativeFieldInfoPtr_DetectGestures;

	private static readonly IntPtr NativeFieldInfoPtr_UseCustomStartAnchoredPosition;

	private static readonly IntPtr NativeFieldInfoPtr_CloseSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_OpenSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_RenamePrefix;

	private static readonly IntPtr NativeFieldInfoPtr_RenameSuffix;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIDrawerSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetComponent_Public_Void_UIDrawer_0;

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

	public unsafe static UIDrawerSettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIDrawerSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIDrawerSettings));
		}
	}

	public unsafe NamesDatabase database
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_database);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NamesDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_database)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)namesDatabase));
		}
	}

	public unsafe static SimpleSwipe CLOSE_DIRECTION_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out SimpleSwipe result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLOSE_DIRECTION_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLOSE_DIRECTION_DEFAULT_VALUE, (void*)(&simpleSwipe));
		}
	}

	public unsafe static bool DETECT_GESTURES_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DETECT_GESTURES_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DETECT_GESTURES_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static float CLOSE_SPEED_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLOSE_SPEED_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLOSE_SPEED_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static float OPEN_SPEED_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_SPEED_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_SPEED_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static string RENAME_PREFIX_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RENAME_PREFIX_DEFAULT_VALUE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RENAME_PREFIX_DEFAULT_VALUE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RENAME_SUFFIX_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RENAME_SUFFIX_DEFAULT_VALUE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RENAME_SUFFIX_DEFAULT_VALUE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Vector3 CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE, (void*)(&vector));
		}
	}

	public unsafe SimpleSwipe CloseDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseDirection);
			return *(SimpleSwipe*)num;
		}
		set
		{
			*(SimpleSwipe*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseDirection)) = simpleSwipe;
		}
	}

	public unsafe Vector3 CustomStartAnchoredPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomStartAnchoredPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomStartAnchoredPosition)) = vector;
		}
	}

	public unsafe bool DetectGestures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetectGestures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetectGestures)) = flag;
		}
	}

	public unsafe bool UseCustomStartAnchoredPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCustomStartAnchoredPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCustomStartAnchoredPosition)) = flag;
		}
	}

	public unsafe float CloseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseSpeed)) = num;
		}
	}

	public unsafe float OpenSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenSpeed)) = num;
		}
	}

	public unsafe string RenamePrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenamePrefix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenamePrefix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RenameSuffix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameSuffix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameSuffix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735693, XrefRangeEnd = 735697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static UIDrawerSettings Instance
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 735721, RefRangeEnd = 735726, XrefRangeStart = 735697, XrefRangeEnd = 735721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIDrawerSettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIDrawerSettings>(intPtr) : null;
		}
	}

	public unsafe static NamesDatabase Database
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735726, XrefRangeEnd = 735748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NamesDatabase>(intPtr) : null;
		}
	}

	static UIDrawerSettings()
	{
		Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Settings", "UIDrawerSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "database");
		NativeFieldInfoPtr_CLOSE_DIRECTION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "CLOSE_DIRECTION_DEFAULT_VALUE");
		NativeFieldInfoPtr_DETECT_GESTURES_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "DETECT_GESTURES_DEFAULT_VALUE");
		NativeFieldInfoPtr_USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE");
		NativeFieldInfoPtr_CLOSE_SPEED_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "CLOSE_SPEED_DEFAULT_VALUE");
		NativeFieldInfoPtr_OPEN_SPEED_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "OPEN_SPEED_DEFAULT_VALUE");
		NativeFieldInfoPtr_RENAME_PREFIX_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "RENAME_PREFIX_DEFAULT_VALUE");
		NativeFieldInfoPtr_RENAME_SUFFIX_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "RENAME_SUFFIX_DEFAULT_VALUE");
		NativeFieldInfoPtr_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE");
		NativeFieldInfoPtr_CloseDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "CloseDirection");
		NativeFieldInfoPtr_CustomStartAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "CustomStartAnchoredPosition");
		NativeFieldInfoPtr_DetectGestures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "DetectGestures");
		NativeFieldInfoPtr_UseCustomStartAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "UseCustomStartAnchoredPosition");
		NativeFieldInfoPtr_CloseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "CloseSpeed");
		NativeFieldInfoPtr_OpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "OpenSpeed");
		NativeFieldInfoPtr_RenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "RenamePrefix");
		NativeFieldInfoPtr_RenameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, "RenameSuffix");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668057);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIDrawerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668058);
		NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668059);
		NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668060);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668061);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668062);
		NativeMethodInfoPtr_ResetComponent_Public_Void_UIDrawer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668063);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668064);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668065);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr, 100668066);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735748, XrefRangeEnd = 735756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateDatabase()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735756, XrefRangeEnd = 735764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735764, XrefRangeEnd = 735776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735776, RefRangeEnd = 735777, XrefRangeStart = 735776, XrefRangeEnd = 735776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetComponent(UIDrawer drawer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)drawer);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetComponent_Public_Void_UIDrawer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735777, XrefRangeEnd = 735781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735781, XrefRangeEnd = 735785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735785, XrefRangeEnd = 735794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDrawerSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDrawerSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIDrawerSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
