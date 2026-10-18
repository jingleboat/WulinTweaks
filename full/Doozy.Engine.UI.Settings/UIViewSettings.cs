using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Settings;

[Serializable]
public class UIViewSettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_database;

	private static readonly IntPtr NativeFieldInfoPtr_TARGET_ORIENTATION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_BEHAVIOUR_AT_START_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_AUTO_SELECT_BUTTON_AFTER_SHOW;

	private static readonly IntPtr NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_HIDE_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_SHOW_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DISABLE_CANVAS_WHEN_HIDDEN_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DISABLE_GAME_OBJECT_WHEN_HIDDEN_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DISABLE_GRAPHIC_RAYCASTER_WHEN_HIDDEN_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW_DELAY;

	private static readonly IntPtr NativeFieldInfoPtr_DISABLE_WHEN_HIDDEN_TIME_BUFFER;

	private static readonly IntPtr NativeFieldInfoPtr_RENAME_PREFIX_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_RENAME_SUFFIX_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_TargetOrientation;

	private static readonly IntPtr NativeFieldInfoPtr_BehaviorAtStart;

	private static readonly IntPtr NativeFieldInfoPtr_CustomStartAnchoredPosition;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectAnyButtonSelectedOnHide;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectAnyButtonSelectedOnShow;

	private static readonly IntPtr NativeFieldInfoPtr_DisableCanvasWhenHidden;

	private static readonly IntPtr NativeFieldInfoPtr_DisableGameObjectWhenHidden;

	private static readonly IntPtr NativeFieldInfoPtr_DisableGraphicRaycasterWhenHidden;

	private static readonly IntPtr NativeFieldInfoPtr_UseCustomStartAnchoredPosition;

	private static readonly IntPtr NativeFieldInfoPtr_RenamePrefix;

	private static readonly IntPtr NativeFieldInfoPtr_RenameSuffix;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIViewSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetComponent_Public_Void_UIView_0;

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

	public unsafe static UIViewSettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIViewSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIViewSettings));
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

	public unsafe static TargetOrientation TARGET_ORIENTATION_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out TargetOrientation result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TARGET_ORIENTATION_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TARGET_ORIENTATION_DEFAULT_VALUE, (void*)(&targetOrientation));
		}
	}

	public unsafe static UIViewStartBehavior BEHAVIOUR_AT_START_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out UIViewStartBehavior result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BEHAVIOUR_AT_START_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BEHAVIOUR_AT_START_DEFAULT_VALUE, (void*)(&uIViewStartBehavior));
		}
	}

	public unsafe static bool DEFAULT_AUTO_HIDE_AFTER_SHOW
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_AUTO_SELECT_BUTTON_AFTER_SHOW
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_AUTO_SELECT_BUTTON_AFTER_SHOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_AUTO_SELECT_BUTTON_AFTER_SHOW, (void*)(&flag));
		}
	}

	public unsafe static bool DESELECT_ANY_BUTTON_SELECTED_ON_HIDE_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_HIDE_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_HIDE_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool DESELECT_ANY_BUTTON_SELECTED_ON_SHOW_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_SHOW_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_SHOW_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool DISABLE_CANVAS_WHEN_HIDDEN_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISABLE_CANVAS_WHEN_HIDDEN_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISABLE_CANVAS_WHEN_HIDDEN_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool DISABLE_GAME_OBJECT_WHEN_HIDDEN_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISABLE_GAME_OBJECT_WHEN_HIDDEN_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISABLE_GAME_OBJECT_WHEN_HIDDEN_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool DISABLE_GRAPHIC_RAYCASTER_WHEN_HIDDEN_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISABLE_GRAPHIC_RAYCASTER_WHEN_HIDDEN_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISABLE_GRAPHIC_RAYCASTER_WHEN_HIDDEN_DEFAULT_VALUE, (void*)(&flag));
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

	public unsafe static float DEFAULT_AUTO_HIDE_AFTER_SHOW_DELAY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW_DELAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW_DELAY, (void*)(&num));
		}
	}

	public unsafe static float DISABLE_WHEN_HIDDEN_TIME_BUFFER
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISABLE_WHEN_HIDDEN_TIME_BUFFER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISABLE_WHEN_HIDDEN_TIME_BUFFER, (void*)(&num));
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

	public unsafe TargetOrientation TargetOrientation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetOrientation);
			return *(TargetOrientation*)num;
		}
		set
		{
			*(TargetOrientation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetOrientation)) = targetOrientation;
		}
	}

	public unsafe UIViewStartBehavior BehaviorAtStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BehaviorAtStart);
			return *(UIViewStartBehavior*)num;
		}
		set
		{
			*(UIViewStartBehavior*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BehaviorAtStart)) = uIViewStartBehavior;
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

	public unsafe bool DeselectAnyButtonSelectedOnHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectAnyButtonSelectedOnHide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectAnyButtonSelectedOnHide)) = flag;
		}
	}

	public unsafe bool DeselectAnyButtonSelectedOnShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectAnyButtonSelectedOnShow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectAnyButtonSelectedOnShow)) = flag;
		}
	}

	public unsafe bool DisableCanvasWhenHidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableCanvasWhenHidden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableCanvasWhenHidden)) = flag;
		}
	}

	public unsafe bool DisableGameObjectWhenHidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableGameObjectWhenHidden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableGameObjectWhenHidden)) = flag;
		}
	}

	public unsafe bool DisableGraphicRaycasterWhenHidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableGraphicRaycasterWhenHidden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableGraphicRaycasterWhenHidden)) = flag;
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735945, XrefRangeEnd = 735949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static UIViewSettings Instance
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 735973, RefRangeEnd = 735978, XrefRangeStart = 735949, XrefRangeEnd = 735973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIViewSettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIViewSettings>(intPtr) : null;
		}
	}

	public unsafe static NamesDatabase Database
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735978, XrefRangeEnd = 736000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NamesDatabase>(intPtr) : null;
		}
	}

	static UIViewSettings()
	{
		Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Settings", "UIViewSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "database");
		NativeFieldInfoPtr_TARGET_ORIENTATION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "TARGET_ORIENTATION_DEFAULT_VALUE");
		NativeFieldInfoPtr_BEHAVIOUR_AT_START_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "BEHAVIOUR_AT_START_DEFAULT_VALUE");
		NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DEFAULT_AUTO_HIDE_AFTER_SHOW");
		NativeFieldInfoPtr_DEFAULT_AUTO_SELECT_BUTTON_AFTER_SHOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DEFAULT_AUTO_SELECT_BUTTON_AFTER_SHOW");
		NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_HIDE_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DESELECT_ANY_BUTTON_SELECTED_ON_HIDE_DEFAULT_VALUE");
		NativeFieldInfoPtr_DESELECT_ANY_BUTTON_SELECTED_ON_SHOW_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DESELECT_ANY_BUTTON_SELECTED_ON_SHOW_DEFAULT_VALUE");
		NativeFieldInfoPtr_DISABLE_CANVAS_WHEN_HIDDEN_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DISABLE_CANVAS_WHEN_HIDDEN_DEFAULT_VALUE");
		NativeFieldInfoPtr_DISABLE_GAME_OBJECT_WHEN_HIDDEN_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DISABLE_GAME_OBJECT_WHEN_HIDDEN_DEFAULT_VALUE");
		NativeFieldInfoPtr_DISABLE_GRAPHIC_RAYCASTER_WHEN_HIDDEN_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DISABLE_GRAPHIC_RAYCASTER_WHEN_HIDDEN_DEFAULT_VALUE");
		NativeFieldInfoPtr_USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "USE_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE");
		NativeFieldInfoPtr_DEFAULT_AUTO_HIDE_AFTER_SHOW_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DEFAULT_AUTO_HIDE_AFTER_SHOW_DELAY");
		NativeFieldInfoPtr_DISABLE_WHEN_HIDDEN_TIME_BUFFER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DISABLE_WHEN_HIDDEN_TIME_BUFFER");
		NativeFieldInfoPtr_RENAME_PREFIX_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "RENAME_PREFIX_DEFAULT_VALUE");
		NativeFieldInfoPtr_RENAME_SUFFIX_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "RENAME_SUFFIX_DEFAULT_VALUE");
		NativeFieldInfoPtr_CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "CUSTOM_START_ANCHORED_POSITION_DEFAULT_VALUE");
		NativeFieldInfoPtr_TargetOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "TargetOrientation");
		NativeFieldInfoPtr_BehaviorAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "BehaviorAtStart");
		NativeFieldInfoPtr_CustomStartAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "CustomStartAnchoredPosition");
		NativeFieldInfoPtr_DeselectAnyButtonSelectedOnHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DeselectAnyButtonSelectedOnHide");
		NativeFieldInfoPtr_DeselectAnyButtonSelectedOnShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DeselectAnyButtonSelectedOnShow");
		NativeFieldInfoPtr_DisableCanvasWhenHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DisableCanvasWhenHidden");
		NativeFieldInfoPtr_DisableGameObjectWhenHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DisableGameObjectWhenHidden");
		NativeFieldInfoPtr_DisableGraphicRaycasterWhenHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "DisableGraphicRaycasterWhenHidden");
		NativeFieldInfoPtr_UseCustomStartAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "UseCustomStartAnchoredPosition");
		NativeFieldInfoPtr_RenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "RenamePrefix");
		NativeFieldInfoPtr_RenameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, "RenameSuffix");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668086);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIViewSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668087);
		NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668088);
		NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668089);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668090);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668091);
		NativeMethodInfoPtr_ResetComponent_Public_Void_UIView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668092);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668093);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668094);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr, 100668095);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736000, XrefRangeEnd = 736008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateDatabase()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736008, XrefRangeEnd = 736016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736016, XrefRangeEnd = 736028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 736038, RefRangeEnd = 736039, XrefRangeStart = 736028, XrefRangeEnd = 736038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetComponent(UIView view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetComponent_Public_Void_UIView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736039, XrefRangeEnd = 736043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736043, XrefRangeEnd = 736047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736047, XrefRangeEnd = 736052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIViewSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIViewSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIViewSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
