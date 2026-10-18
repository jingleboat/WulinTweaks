using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Base;
using Doozy.Engine.UI.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Settings;

[Serializable]
public class UIButtonSettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_database;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SINGLE_CLICK_MODE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ALLOW_MULTIPLE_CLICKS;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON_AFTER_CLICK;

	private static readonly IntPtr NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BUTTON_HEIGHT;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BUTTON_WIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_DOUBLE_CLICK_REGISTER_INTERVAL;

	private static readonly IntPtr NativeFieldInfoPtr_LONG_CLICK_REGISTER_INTERVAL;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_RENAME_PREFIX;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_RENAME_SUFFIX;

	private static readonly IntPtr NativeFieldInfoPtr_InputMode;

	private static readonly IntPtr NativeFieldInfoPtr_KeyCode;

	private static readonly IntPtr NativeFieldInfoPtr_KeyCodeAlt;

	private static readonly IntPtr NativeFieldInfoPtr_ClickMode;

	private static readonly IntPtr NativeFieldInfoPtr_AllowMultipleClicks;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectButtonAfterClick;

	private static readonly IntPtr NativeFieldInfoPtr_EnableAlternateInputs;

	private static readonly IntPtr NativeFieldInfoPtr_ShowNormalLoopAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnButtonDeselected;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnButtonSelected;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnClick;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnDoubleClick;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnLongClick;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnPointerDown;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnPointerEnter;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnPointerExit;

	private static readonly IntPtr NativeFieldInfoPtr_ShowOnPointerUp;

	private static readonly IntPtr NativeFieldInfoPtr_ShowSelectedLoopAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_DisableButtonBetweenClicksInterval;

	private static readonly IntPtr NativeFieldInfoPtr_RenamePrefix;

	private static readonly IntPtr NativeFieldInfoPtr_RenameSuffix;

	private static readonly IntPtr NativeFieldInfoPtr_VirtualButtonName;

	private static readonly IntPtr NativeFieldInfoPtr_VirtualButtonNameAlt;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIButtonSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetComponent_Public_Void_UIButton_0;

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

	public unsafe static UIButtonSettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButtonSettings));
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

	public unsafe static SingleClickMode DEFAULT_SINGLE_CLICK_MODE
	{
		get
		{
			Unsafe.SkipInit(out SingleClickMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SINGLE_CLICK_MODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SINGLE_CLICK_MODE, (void*)(&singleClickMode));
		}
	}

	public unsafe static bool DEFAULT_ALLOW_MULTIPLE_CLICKS
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ALLOW_MULTIPLE_CLICKS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ALLOW_MULTIPLE_CLICKS, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_DESELECT_BUTTON_AFTER_CLICK
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON_AFTER_CLICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON_AFTER_CLICK, (void*)(&flag));
		}
	}

	public unsafe static float BETWEEN_CLICKS_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL, (void*)(&num));
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

	public unsafe static float DOUBLE_CLICK_REGISTER_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOUBLE_CLICK_REGISTER_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOUBLE_CLICK_REGISTER_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float LONG_CLICK_REGISTER_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LONG_CLICK_REGISTER_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LONG_CLICK_REGISTER_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static string DEFAULT_RENAME_PREFIX
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_RENAME_PREFIX, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_RENAME_PREFIX, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DEFAULT_RENAME_SUFFIX
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_RENAME_SUFFIX, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_RENAME_SUFFIX, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe SingleClickMode ClickMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickMode);
			return *(SingleClickMode*)num;
		}
		set
		{
			*(SingleClickMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickMode)) = singleClickMode;
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

	public unsafe bool ShowNormalLoopAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowNormalLoopAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowNormalLoopAnimation)) = flag;
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

	public unsafe bool ShowOnDoubleClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnDoubleClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnDoubleClick)) = flag;
		}
	}

	public unsafe bool ShowOnLongClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnLongClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnLongClick)) = flag;
		}
	}

	public unsafe bool ShowOnPointerDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerDown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerDown)) = flag;
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

	public unsafe bool ShowOnPointerUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerUp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowOnPointerUp)) = flag;
		}
	}

	public unsafe bool ShowSelectedLoopAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowSelectedLoopAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowSelectedLoopAnimation)) = flag;
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735499, XrefRangeEnd = 735503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static UIButtonSettings Instance
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 735520, RefRangeEnd = 735525, XrefRangeStart = 735503, XrefRangeEnd = 735520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIButtonSettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButtonSettings>(intPtr) : null;
		}
	}

	public unsafe static NamesDatabase Database
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735525, XrefRangeEnd = 735536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NamesDatabase>(intPtr) : null;
		}
	}

	static UIButtonSettings()
	{
		Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Settings", "UIButtonSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "database");
		NativeFieldInfoPtr_DEFAULT_SINGLE_CLICK_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_SINGLE_CLICK_MODE");
		NativeFieldInfoPtr_DEFAULT_ALLOW_MULTIPLE_CLICKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_ALLOW_MULTIPLE_CLICKS");
		NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON_AFTER_CLICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_DESELECT_BUTTON_AFTER_CLICK");
		NativeFieldInfoPtr_BETWEEN_CLICKS_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "BETWEEN_CLICKS_DISABLE_INTERVAL");
		NativeFieldInfoPtr_DEFAULT_BUTTON_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_BUTTON_HEIGHT");
		NativeFieldInfoPtr_DEFAULT_BUTTON_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_BUTTON_WIDTH");
		NativeFieldInfoPtr_DOUBLE_CLICK_REGISTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DOUBLE_CLICK_REGISTER_INTERVAL");
		NativeFieldInfoPtr_LONG_CLICK_REGISTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "LONG_CLICK_REGISTER_INTERVAL");
		NativeFieldInfoPtr_DEFAULT_RENAME_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_RENAME_PREFIX");
		NativeFieldInfoPtr_DEFAULT_RENAME_SUFFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DEFAULT_RENAME_SUFFIX");
		NativeFieldInfoPtr_InputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "InputMode");
		NativeFieldInfoPtr_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "KeyCode");
		NativeFieldInfoPtr_KeyCodeAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "KeyCodeAlt");
		NativeFieldInfoPtr_ClickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ClickMode");
		NativeFieldInfoPtr_AllowMultipleClicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "AllowMultipleClicks");
		NativeFieldInfoPtr_DeselectButtonAfterClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DeselectButtonAfterClick");
		NativeFieldInfoPtr_EnableAlternateInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "EnableAlternateInputs");
		NativeFieldInfoPtr_ShowNormalLoopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowNormalLoopAnimation");
		NativeFieldInfoPtr_ShowOnButtonDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnButtonDeselected");
		NativeFieldInfoPtr_ShowOnButtonSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnButtonSelected");
		NativeFieldInfoPtr_ShowOnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnClick");
		NativeFieldInfoPtr_ShowOnDoubleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnDoubleClick");
		NativeFieldInfoPtr_ShowOnLongClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnLongClick");
		NativeFieldInfoPtr_ShowOnPointerDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnPointerDown");
		NativeFieldInfoPtr_ShowOnPointerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnPointerEnter");
		NativeFieldInfoPtr_ShowOnPointerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnPointerExit");
		NativeFieldInfoPtr_ShowOnPointerUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowOnPointerUp");
		NativeFieldInfoPtr_ShowSelectedLoopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "ShowSelectedLoopAnimation");
		NativeFieldInfoPtr_DisableButtonBetweenClicksInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "DisableButtonBetweenClicksInterval");
		NativeFieldInfoPtr_RenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "RenamePrefix");
		NativeFieldInfoPtr_RenameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "RenameSuffix");
		NativeFieldInfoPtr_VirtualButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "VirtualButtonName");
		NativeFieldInfoPtr_VirtualButtonNameAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, "VirtualButtonNameAlt");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668037);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIButtonSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668038);
		NativeMethodInfoPtr_get_Database_Public_Static_get_NamesDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668039);
		NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668040);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668041);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668042);
		NativeMethodInfoPtr_ResetComponent_Public_Void_UIButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668043);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668044);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668045);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr, 100668046);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735536, XrefRangeEnd = 735541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateDatabase()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDatabase_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735541, XrefRangeEnd = 735549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735549, XrefRangeEnd = 735561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 735608, RefRangeEnd = 735609, XrefRangeStart = 735561, XrefRangeEnd = 735608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetComponent(UIButton button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetComponent_Public_Void_UIButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735609, XrefRangeEnd = 735613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735613, XrefRangeEnd = 735617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735617, XrefRangeEnd = 735626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIButtonSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
