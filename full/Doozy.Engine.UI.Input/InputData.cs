using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.UI.Input;

[System.Serializable]
public class InputData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ENABLE_ALTERNATE_INPUTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_INPUT_MODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE_ALT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME_ALT;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableAlternateInputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyCodeAlt;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirtualButtonName;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirtualButtonNameAlt;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	public unsafe static bool DEFAULT_ENABLE_ALTERNATE_INPUTS
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ENABLE_ALTERNATE_INPUTS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ENABLE_ALTERNATE_INPUTS, (void*)(&flag));
		}
	}

	public unsafe static InputMode DEFAULT_INPUT_MODE
	{
		get
		{
			Unsafe.SkipInit(out InputMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_INPUT_MODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_INPUT_MODE, (void*)(&inputMode));
		}
	}

	public unsafe static KeyCode DEFAULT_ON_CLICK_KEY_CODE
	{
		get
		{
			Unsafe.SkipInit(out KeyCode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE, (void*)(&keyCode));
		}
	}

	public unsafe static KeyCode DEFAULT_ON_CLICK_KEY_CODE_ALT
	{
		get
		{
			Unsafe.SkipInit(out KeyCode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE_ALT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE_ALT, (void*)(&keyCode));
		}
	}

	public unsafe static string DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME_ALT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME_ALT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME_ALT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe string VirtualButtonName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string VirtualButtonNameAlt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonNameAlt);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButtonNameAlt)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static InputData()
	{
		Il2CppClassPointerStore<InputData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Input", "InputData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputData>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_ENABLE_ALTERNATE_INPUTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "DEFAULT_ENABLE_ALTERNATE_INPUTS");
		NativeFieldInfoPtr_DEFAULT_INPUT_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "DEFAULT_INPUT_MODE");
		NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "DEFAULT_ON_CLICK_KEY_CODE");
		NativeFieldInfoPtr_DEFAULT_ON_CLICK_KEY_CODE_ALT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "DEFAULT_ON_CLICK_KEY_CODE_ALT");
		NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME");
		NativeFieldInfoPtr_DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME_ALT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "DEFAULT_ON_CLICK_VIRTUAL_BUTTON_NAME_ALT");
		NativeFieldInfoPtr_EnableAlternateInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "EnableAlternateInputs");
		NativeFieldInfoPtr_InputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "InputMode");
		NativeFieldInfoPtr_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "KeyCode");
		NativeFieldInfoPtr_KeyCodeAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "KeyCodeAlt");
		NativeFieldInfoPtr_VirtualButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "VirtualButtonName");
		NativeFieldInfoPtr_VirtualButtonNameAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "VirtualButtonNameAlt");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputData>.NativeClassPtr, 100668254);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputData>.NativeClassPtr, 100668255);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 737459, RefRangeEnd = 737466, XrefRangeStart = 737454, XrefRangeEnd = 737459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737466, XrefRangeEnd = 737470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InputData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
