using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Settings;

[Serializable]
public class UIToggleSettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_ALLOW_MULTIPLE_CLICKS_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DESELECT_BUTTON_AFTER_CLICK_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BUTTON_HEIGHT;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BUTTON_WIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_InputMode;

	private static readonly IntPtr NativeFieldInfoPtr_KeyCode;

	private static readonly IntPtr NativeFieldInfoPtr_KeyCodeAlt;

	private static readonly IntPtr NativeFieldInfoPtr_AllowMultipleClicks;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectButtonAfterClick;

	private static readonly IntPtr NativeFieldInfoPtr_EnableAlternateInputs;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnButtonDeselected;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnButtonSelected;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnClick;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnPointerEnter;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnPointerExit;

	private static readonly IntPtr NativeFieldInfoPtr_DisableButtonBetweenClicksInterval;

	private static readonly IntPtr NativeFieldInfoPtr_VirtualButtonName;

	private static readonly IntPtr NativeFieldInfoPtr_VirtualButtonNameAlt;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIToggleSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetComponent_Public_Void_UIToggle_0;

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

	public unsafe static UIToggleSettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIToggleSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIToggleSettings));
		}
	}

	public unsafe static bool ALLOW_MULTIPLE_CLICKS_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALLOW_MULTIPLE_CLICKS_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALLOW_MULTIPLE_CLICKS_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static bool DESELECT_BUTTON_AFTER_CLICK_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESELECT_BUTTON_AFTER_CLICK_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESELECT_BUTTON_AFTER_CLICK_DEFAULT_VALUE, (void*)(&flag));
		}
	}

	public unsafe static float BETWEEN_CLICKS_DISABLE_INTERVAL_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_BUTTON_HEIGHT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BUTTON_HEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BUTTON_HEIGHT, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_BUTTON_WIDTH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BUTTON_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BUTTON_WIDTH, (void*)(&num));
		}
	}

	public unsafe InputMode InputMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputMode);
			return *(InputMode*)num;
		}
		set
		{
			*(InputMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputMode)) = inputMode;
		}
	}

	public unsafe KeyCode KeyCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyCode);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyCode)) = keyCode;
		}
	}

	public unsafe KeyCode KeyCodeAlt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyCodeAlt);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyCodeAlt)) = keyCode;
		}
	}

	public unsafe bool AllowMultipleClicks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowMultipleClicks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowMultipleClicks)) = flag;
		}
	}

	public unsafe bool DeselectButtonAfterClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButtonAfterClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButtonAfterClick)) = flag;
		}
	}

	public unsafe bool EnableAlternateInputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableAlternateInputs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableAlternateInputs)) = flag;
		}
	}

	public unsafe bool ShowOnButtonDeselected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnButtonDeselected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnButtonDeselected)) = flag;
		}
	}

	public unsafe bool ShowOnButtonSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnButtonSelected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnButtonSelected)) = flag;
		}
	}

	public unsafe bool ShowOnClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnClick)) = flag;
		}
	}

	public unsafe bool ShowOnPointerEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerEnter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerEnter)) = flag;
		}
	}

	public unsafe bool ShowOnPointerExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerExit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerExit)) = flag;
		}
	}

	public unsafe float DisableButtonBetweenClicksInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableButtonBetweenClicksInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableButtonBetweenClicksInterval)) = num;
		}
	}

	public unsafe string VirtualButtonName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string VirtualButtonNameAlt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonNameAlt);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonNameAlt)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735879, XrefRangeEnd = 735883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static UIToggleSettings Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735883, XrefRangeEnd = 735900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIToggleSettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIToggleSettings>(intPtr) : null;
		}
	}

	static UIToggleSettings()
	{
		Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Settings", "UIToggleSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_ALLOW_MULTIPLE_CLICKS_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "ALLOW_MULTIPLE_CLICKS_DEFAULT_VALUE");
		NativeFieldInfoPtr_DESELECT_BUTTON_AFTER_CLICK_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "DESELECT_BUTTON_AFTER_CLICK_DEFAULT_VALUE");
		NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "BETWEEN_CLICKS_DISABLE_INTERVAL_DEFAULT_VALUE");
		NativeFieldInfoPtr_DEFAULT_BUTTON_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "DEFAULT_BUTTON_HEIGHT");
		NativeFieldInfoPtr_DEFAULT_BUTTON_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "DEFAULT_BUTTON_WIDTH");
		NativeFieldInfoPtr_InputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "InputMode");
		NativeFieldInfoPtr_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "KeyCode");
		NativeFieldInfoPtr_KeyCodeAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "KeyCodeAlt");
		NativeFieldInfoPtr_AllowMultipleClicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "AllowMultipleClicks");
		NativeFieldInfoPtr_DeselectButtonAfterClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "DeselectButtonAfterClick");
		NativeFieldInfoPtr_EnableAlternateInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "EnableAlternateInputs");
		NativeFieldInfoPtr_ShowOnButtonDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "ShowOnButtonDeselected");
		NativeFieldInfoPtr_ShowOnButtonSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "ShowOnButtonSelected");
		NativeFieldInfoPtr_ShowOnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "ShowOnClick");
		NativeFieldInfoPtr_ShowOnPointerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "ShowOnPointerEnter");
		NativeFieldInfoPtr_ShowOnPointerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "ShowOnPointerExit");
		NativeFieldInfoPtr_DisableButtonBetweenClicksInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "DisableButtonBetweenClicksInterval");
		NativeFieldInfoPtr_VirtualButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "VirtualButtonName");
		NativeFieldInfoPtr_VirtualButtonNameAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, "VirtualButtonNameAlt");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668078);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIToggleSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668079);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668080);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668081);
		NativeMethodInfoPtr_ResetComponent_Public_Void_UIToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668082);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668083);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668084);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr, 100668085);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735900, XrefRangeEnd = 735904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735904, XrefRangeEnd = 735912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735912, XrefRangeEnd = 735932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetComponent(UIToggle toggle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetComponent_Public_Void_UIToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735932, XrefRangeEnd = 735936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735936, XrefRangeEnd = 735940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735940, XrefRangeEnd = 735945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIToggleSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIToggleSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIToggleSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
