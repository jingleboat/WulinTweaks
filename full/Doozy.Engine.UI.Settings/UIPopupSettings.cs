using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Settings;

[Serializable]
public class UIPopupSettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_database;

	private static readonly IntPtr NativeFieldInfoPtr_DISPLAY_ON_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_VISIBILITY_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_ADD_TO_POPUP_QUEUE_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_AUTO_SELECT_BUTTON_AFTER_SHOW_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_CUSTOM_CANVAS_NAME_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DESTROY_AFTER_HIDE_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_HIDE_ON_BACK_BUTTON_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_HIDE_ON_CLICK_ANYWHERE_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_HIDE_ON_CLICK_CONTAINER_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_HIDE_ON_CLICK_OVERLAY_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_UPDATE_HIDE_PROGRESSOR_ON_SHOW_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_UPDATE_SHOW_PROGRESSOR_ON_HIDE_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_USE_OVERLAY_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DELAY_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DISABLE_WHEN_HIDDEN_TIME_BUFFER;

	private static readonly IntPtr NativeFieldInfoPtr_DisplayTarget;

	private static readonly IntPtr NativeFieldInfoPtr_AddToPopupQueue;

	private static readonly IntPtr NativeFieldInfoPtr_AutoHideAfterShow;

	private static readonly IntPtr NativeFieldInfoPtr_AutoSelectButtonAfterShow;

	private static readonly IntPtr NativeFieldInfoPtr_CustomCanvasName;

	private static readonly IntPtr NativeFieldInfoPtr_DestroyAfterHide;

	private static readonly IntPtr NativeFieldInfoPtr_HideOnBackButton;

	private static readonly IntPtr NativeFieldInfoPtr_HideOnClickAnywhere;

	private static readonly IntPtr NativeFieldInfoPtr_HideOnClickContainer;

	private static readonly IntPtr NativeFieldInfoPtr_HideOnClickOverlay;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateHideProgressorOnShow;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateShowProgressorOnHide;

	private static readonly IntPtr NativeFieldInfoPtr_UseOverlay;

	private static readonly IntPtr NativeFieldInfoPtr_AutoHideAfterShowDelay;

	private static readonly IntPtr NativeFieldInfoPtr_CanvasName;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIPopupSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_Static_get_UIPopupDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetComponent_Public_Void_UIPopup_0;

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

	public unsafe static UIPopupSettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPopupSettings));
		}
	}

	public unsafe UIPopupDatabase database
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_database);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_database)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPopupDatabase));
		}
	}

	public unsafe static PopupDisplayOn DISPLAY_ON_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out PopupDisplayOn result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISPLAY_ON_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISPLAY_ON_DEFAULT_VALUE, (void*)(&popupDisplayOn));
		}
	}

	public unsafe static VisibilityState VISIBILITY_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out VisibilityState result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VISIBILITY_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VISIBILITY_DEFAULT_VALUE, (void*)(&visibilityState));
		}
	}

	public unsafe static bool ADD_TO_POPUP_QUEUE_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ADD_TO_POPUP_QUEUE_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ADD_TO_POPUP_QUEUE_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool AUTO_HIDE_AFTER_SHOW_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool AUTO_SELECT_BUTTON_AFTER_SHOW_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTO_SELECT_BUTTON_AFTER_SHOW_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTO_SELECT_BUTTON_AFTER_SHOW_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool CUSTOM_CANVAS_NAME_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CUSTOM_CANVAS_NAME_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CUSTOM_CANVAS_NAME_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool DESTROY_AFTER_HIDE_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESTROY_AFTER_HIDE_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESTROY_AFTER_HIDE_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool HIDE_ON_BACK_BUTTON_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIDE_ON_BACK_BUTTON_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIDE_ON_BACK_BUTTON_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool HIDE_ON_CLICK_ANYWHERE_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIDE_ON_CLICK_ANYWHERE_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIDE_ON_CLICK_ANYWHERE_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool HIDE_ON_CLICK_CONTAINER_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIDE_ON_CLICK_CONTAINER_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIDE_ON_CLICK_CONTAINER_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool HIDE_ON_CLICK_OVERLAY_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIDE_ON_CLICK_OVERLAY_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIDE_ON_CLICK_OVERLAY_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool UPDATE_HIDE_PROGRESSOR_ON_SHOW_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_HIDE_PROGRESSOR_ON_SHOW_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_HIDE_PROGRESSOR_ON_SHOW_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool UPDATE_SHOW_PROGRESSOR_ON_HIDE_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_SHOW_PROGRESSOR_ON_HIDE_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_SHOW_PROGRESSOR_ON_HIDE_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool USE_OVERLAY_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_OVERLAY_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_OVERLAY_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static float AUTO_HIDE_AFTER_SHOW_DELAY_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DELAY_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DELAY_DEFAULT_VALUE, (void*)(&num));
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

	public unsafe PopupDisplayOn DisplayTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayTarget);
			return *(PopupDisplayOn*)num;
		}
		set
		{
			*(PopupDisplayOn*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayTarget)) = popupDisplayOn;
		}
	}

	public unsafe bool AddToPopupQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddToPopupQueue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddToPopupQueue)) = flag;
		}
	}

	public unsafe bool AutoHideAfterShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoHideAfterShow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoHideAfterShow)) = flag;
		}
	}

	public unsafe bool AutoSelectButtonAfterShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSelectButtonAfterShow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSelectButtonAfterShow)) = flag;
		}
	}

	public unsafe bool CustomCanvasName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomCanvasName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomCanvasName)) = flag;
		}
	}

	public unsafe bool DestroyAfterHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DestroyAfterHide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DestroyAfterHide)) = flag;
		}
	}

	public unsafe bool HideOnBackButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnBackButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnBackButton)) = flag;
		}
	}

	public unsafe bool HideOnClickAnywhere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnClickAnywhere);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnClickAnywhere)) = flag;
		}
	}

	public unsafe bool HideOnClickContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnClickContainer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnClickContainer)) = flag;
		}
	}

	public unsafe bool HideOnClickOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnClickOverlay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOnClickOverlay)) = flag;
		}
	}

	public unsafe bool UpdateHideProgressorOnShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateHideProgressorOnShow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateHideProgressorOnShow)) = flag;
		}
	}

	public unsafe bool UpdateShowProgressorOnHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateShowProgressorOnHide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateShowProgressorOnHide)) = flag;
		}
	}

	public unsafe bool UseOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseOverlay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseOverlay)) = flag;
		}
	}

	public unsafe float AutoHideAfterShowDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoHideAfterShowDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoHideAfterShowDelay)) = num;
		}
	}

	public unsafe string CanvasName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanvasName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanvasName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735794, XrefRangeEnd = 735798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static UIPopupSettings Instance
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 735815, RefRangeEnd = 735823, XrefRangeStart = 735798, XrefRangeEnd = 735815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIPopupSettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupSettings>(intPtr) : null;
		}
	}

	public unsafe static UIPopupDatabase Database
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 732691, RefRangeEnd = 732694, XrefRangeStart = 732691, XrefRangeEnd = 732694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Database_Public_Static_get_UIPopupDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupDatabase>(intPtr) : null;
		}
	}

	static UIPopupSettings()
	{
		Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Settings", "UIPopupSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "database");
		NativeFieldInfoPtr_DISPLAY_ON_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "DISPLAY_ON_DEFAULT_VALUE");
		NativeFieldInfoPtr_VISIBILITY_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "VISIBILITY_DEFAULT_VALUE");
		NativeFieldInfoPtr_ADD_TO_POPUP_QUEUE_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "ADD_TO_POPUP_QUEUE_DEFAULT_VALUE");
		NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AUTO_HIDE_AFTER_SHOW_DEFAULT_VALUE");
		NativeFieldInfoPtr_AUTO_SELECT_BUTTON_AFTER_SHOW_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AUTO_SELECT_BUTTON_AFTER_SHOW_DEFAULT_VALUE");
		NativeFieldInfoPtr_CUSTOM_CANVAS_NAME_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "CUSTOM_CANVAS_NAME_DEFAULT_VALUE");
		NativeFieldInfoPtr_DESTROY_AFTER_HIDE_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "DESTROY_AFTER_HIDE_DEFAULT_VALUE");
		NativeFieldInfoPtr_HIDE_ON_BACK_BUTTON_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HIDE_ON_BACK_BUTTON_DEFAULT_VALUE");
		NativeFieldInfoPtr_HIDE_ON_CLICK_ANYWHERE_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HIDE_ON_CLICK_ANYWHERE_DEFAULT_VALUE");
		NativeFieldInfoPtr_HIDE_ON_CLICK_CONTAINER_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HIDE_ON_CLICK_CONTAINER_DEFAULT_VALUE");
		NativeFieldInfoPtr_HIDE_ON_CLICK_OVERLAY_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HIDE_ON_CLICK_OVERLAY_DEFAULT_VALUE");
		NativeFieldInfoPtr_UPDATE_HIDE_PROGRESSOR_ON_SHOW_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "UPDATE_HIDE_PROGRESSOR_ON_SHOW_DEFAULT_VALUE");
		NativeFieldInfoPtr_UPDATE_SHOW_PROGRESSOR_ON_HIDE_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "UPDATE_SHOW_PROGRESSOR_ON_HIDE_DEFAULT_VALUE");
		NativeFieldInfoPtr_USE_OVERLAY_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "USE_OVERLAY_DEFAULT_VALUE");
		NativeFieldInfoPtr_AUTO_HIDE_AFTER_SHOW_DELAY_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AUTO_HIDE_AFTER_SHOW_DELAY_DEFAULT_VALUE");
		NativeFieldInfoPtr_DISABLE_WHEN_HIDDEN_TIME_BUFFER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "DISABLE_WHEN_HIDDEN_TIME_BUFFER");
		NativeFieldInfoPtr_DisplayTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "DisplayTarget");
		NativeFieldInfoPtr_AddToPopupQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AddToPopupQueue");
		NativeFieldInfoPtr_AutoHideAfterShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AutoHideAfterShow");
		NativeFieldInfoPtr_AutoSelectButtonAfterShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AutoSelectButtonAfterShow");
		NativeFieldInfoPtr_CustomCanvasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "CustomCanvasName");
		NativeFieldInfoPtr_DestroyAfterHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "DestroyAfterHide");
		NativeFieldInfoPtr_HideOnBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HideOnBackButton");
		NativeFieldInfoPtr_HideOnClickAnywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HideOnClickAnywhere");
		NativeFieldInfoPtr_HideOnClickContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HideOnClickContainer");
		NativeFieldInfoPtr_HideOnClickOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "HideOnClickOverlay");
		NativeFieldInfoPtr_UpdateHideProgressorOnShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "UpdateHideProgressorOnShow");
		NativeFieldInfoPtr_UpdateShowProgressorOnHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "UpdateShowProgressorOnHide");
		NativeFieldInfoPtr_UseOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "UseOverlay");
		NativeFieldInfoPtr_AutoHideAfterShowDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "AutoHideAfterShowDelay");
		NativeFieldInfoPtr_CanvasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, "CanvasName");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668068);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIPopupSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668069);
		NativeMethodInfoPtr_get_Database_Public_Static_get_UIPopupDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668070);
		NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668071);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668072);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668073);
		NativeMethodInfoPtr_ResetComponent_Public_Void_UIPopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668074);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668075);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668076);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr, 100668077);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735823, XrefRangeEnd = 735833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateDatabase()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735833, XrefRangeEnd = 735837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735837, XrefRangeEnd = 735845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 735865, RefRangeEnd = 735866, XrefRangeStart = 735845, XrefRangeEnd = 735865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetComponent(UIPopup popup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetComponent_Public_Void_UIPopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735866, XrefRangeEnd = 735870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735870, XrefRangeEnd = 735874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735874, XrefRangeEnd = 735879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopupSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIPopupSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
