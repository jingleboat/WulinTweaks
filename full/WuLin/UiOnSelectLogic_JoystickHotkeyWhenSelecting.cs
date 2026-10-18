using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Rewired;
using UnityEngine.Events;

namespace WuLin;

public class UiOnSelectLogic_JoystickHotkeyWhenSelecting : UiOnSelectLogic
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hotkey;

	private static readonly System.IntPtr NativeFieldInfoPtr_shortPressEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressDownEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressReleaseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatPressEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInited;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPressedButNotReleased;

	private static readonly System.IntPtr NativeFieldInfoPtr_shortPressAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressDownAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressReleaseAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatPressAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventAdded;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelect_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeselect_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnSelect_b__12_0_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnSelect_b__12_1_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnSelect_b__12_2_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnSelect_b__12_3_Private_Void_InputActionEventData_0;

	public unsafe InputManager.RewiredAction hotkey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotkey);
			return *(InputManager.RewiredAction*)num;
		}
		set
		{
			*(InputManager.RewiredAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotkey)) = rewiredAction;
		}
	}

	public unsafe UnityEvent shortPressEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortPressEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortPressEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent pressDownEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressDownEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressDownEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent pressReleaseEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressReleaseEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressReleaseEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent repeatPressEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatPressEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatPressEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe bool isInited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInited)) = flag;
		}
	}

	public unsafe bool isPressedButNotReleased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPressedButNotReleased);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPressedButNotReleased)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<InputActionEventData> shortPressAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortPressAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputActionEventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortPressAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<InputActionEventData> pressDownAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressDownAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputActionEventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressDownAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<InputActionEventData> pressReleaseAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressReleaseAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputActionEventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressReleaseAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<InputActionEventData> repeatPressAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatPressAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputActionEventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatPressAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe bool eventAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventAdded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventAdded)) = flag;
		}
	}

	static UiOnSelectLogic_JoystickHotkeyWhenSelecting()
	{
		Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UiOnSelectLogic_JoystickHotkeyWhenSelecting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr);
		NativeFieldInfoPtr_hotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "hotkey");
		NativeFieldInfoPtr_shortPressEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "shortPressEvent");
		NativeFieldInfoPtr_pressDownEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "pressDownEvent");
		NativeFieldInfoPtr_pressReleaseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "pressReleaseEvent");
		NativeFieldInfoPtr_repeatPressEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "repeatPressEvent");
		NativeFieldInfoPtr_isInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "isInited");
		NativeFieldInfoPtr_isPressedButNotReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "isPressedButNotReleased");
		NativeFieldInfoPtr_shortPressAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "shortPressAction");
		NativeFieldInfoPtr_pressDownAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "pressDownAction");
		NativeFieldInfoPtr_pressReleaseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "pressReleaseAction");
		NativeFieldInfoPtr_repeatPressAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "repeatPressAction");
		NativeFieldInfoPtr_eventAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, "eventAdded");
		NativeMethodInfoPtr_OnSelect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678333);
		NativeMethodInfoPtr_OnDeselect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678334);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678335);
		NativeMethodInfoPtr__OnSelect_b__12_0_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678336);
		NativeMethodInfoPtr__OnSelect_b__12_1_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678337);
		NativeMethodInfoPtr__OnSelect_b__12_2_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678338);
		NativeMethodInfoPtr__OnSelect_b__12_3_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr, 100678339);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975003, XrefRangeEnd = 975060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnSelect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975060, XrefRangeEnd = 975072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDeselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDeselect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975072, XrefRangeEnd = 975073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UiOnSelectLogic_JoystickHotkeyWhenSelecting()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UiOnSelectLogic_JoystickHotkeyWhenSelecting>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975073, XrefRangeEnd = 975083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnSelect_b__12_0(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnSelect_b__12_0_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975083, XrefRangeEnd = 975093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnSelect_b__12_1(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnSelect_b__12_1_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975093, XrefRangeEnd = 975103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnSelect_b__12_2(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnSelect_b__12_2_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975103, XrefRangeEnd = 975113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnSelect_b__12_3(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnSelect_b__12_3_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UiOnSelectLogic_JoystickHotkeyWhenSelecting(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
