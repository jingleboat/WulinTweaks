using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Input;

public class BackButton : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_ENABLE_ALTERNATE_INPUTS;

	private static readonly IntPtr NativeFieldInfoPtr_BACK_BUTTON_DETECTION_DISABLE_INTERVAL;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_INPUT_MODE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE_ALT;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME_ALT;

	private static readonly IntPtr NativeFieldInfoPtr_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_applicationIsQuitting;

	private static readonly IntPtr NativeFieldInfoPtr_s_initialized;

	private static readonly IntPtr NativeFieldInfoPtr_BackButtonInputData;

	private static readonly IntPtr NativeFieldInfoPtr_DebugMode;

	private static readonly IntPtr NativeFieldInfoPtr_m_backButtonDisableLevel;

	private static readonly IntPtr NativeFieldInfoPtr_m_lastBackButtonPressTime;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_BackButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BackButtonDisabled_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CanExecuteBackButton_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddToScene_Public_Static_BackButton_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_EnableByForce_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBackButtonInputData_Private_Static_InputData_0;

	public unsafe static BackButton s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BackButton>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)backButton));
		}
	}

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

	public unsafe static float BACK_BUTTON_DETECTION_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BACK_BUTTON_DETECTION_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BACK_BUTTON_DETECTION_DISABLE_INTERVAL, (void*)(&num));
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

	public unsafe static KeyCode DEFAULT_BACK_BUTTON_KEY_CODE
	{
		get
		{
			Unsafe.SkipInit(out KeyCode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE, (void*)(&keyCode));
		}
	}

	public unsafe static KeyCode DEFAULT_BACK_BUTTON_KEY_CODE_ALT
	{
		get
		{
			Unsafe.SkipInit(out KeyCode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE_ALT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE_ALT, (void*)(&keyCode));
		}
	}

	public unsafe static string DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME_ALT
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME_ALT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME_ALT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool s_applicationIsQuitting
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_applicationIsQuitting, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_applicationIsQuitting, (void*)(&flag));
		}
	}

	public unsafe static bool s_initialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_initialized, (void*)(&flag));
		}
	}

	public unsafe InputData BackButtonInputData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackButtonInputData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackButtonInputData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputData));
		}
	}

	public unsafe bool DebugMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugMode)) = flag;
		}
	}

	public unsafe int m_backButtonDisableLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_backButtonDisableLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_backButtonDisableLevel)) = num;
		}
	}

	public unsafe double m_lastBackButtonPressTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastBackButtonPressTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastBackButtonPressTime)) = num;
		}
	}

	public unsafe static BackButton Instance
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 737329, RefRangeEnd = 737342, XrefRangeStart = 737301, XrefRangeEnd = 737329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_BackButton_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BackButton>(intPtr) : null;
		}
	}

	public unsafe bool BackButtonDisabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BackButtonDisabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool CanExecuteBackButton
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737342, XrefRangeEnd = 737343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanExecuteBackButton_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool DebugComponent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BackButton()
	{
		Il2CppClassPointerStore<BackButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Input", "BackButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackButton>.NativeClassPtr);
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_DEFAULT_ENABLE_ALTERNATE_INPUTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DEFAULT_ENABLE_ALTERNATE_INPUTS");
		NativeFieldInfoPtr_BACK_BUTTON_DETECTION_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "BACK_BUTTON_DETECTION_DISABLE_INTERVAL");
		NativeFieldInfoPtr_DEFAULT_INPUT_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DEFAULT_INPUT_MODE");
		NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DEFAULT_BACK_BUTTON_KEY_CODE");
		NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_KEY_CODE_ALT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DEFAULT_BACK_BUTTON_KEY_CODE_ALT");
		NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME");
		NativeFieldInfoPtr_DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME_ALT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DEFAULT_BACK_BUTTON_VIRTUAL_BUTTON_NAME_ALT");
		NativeFieldInfoPtr_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "NAME");
		NativeFieldInfoPtr_s_applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "s_applicationIsQuitting");
		NativeFieldInfoPtr_s_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "s_initialized");
		NativeFieldInfoPtr_BackButtonInputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "BackButtonInputData");
		NativeFieldInfoPtr_DebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "DebugMode");
		NativeFieldInfoPtr_m_backButtonDisableLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "m_backButtonDisableLevel");
		NativeFieldInfoPtr_m_lastBackButtonPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButton>.NativeClassPtr, "m_lastBackButtonPressTime");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668238);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_BackButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668239);
		NativeMethodInfoPtr_get_BackButtonDisabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668240);
		NativeMethodInfoPtr_get_CanExecuteBackButton_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668241);
		NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668242);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668243);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668244);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668245);
		NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668246);
		NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668247);
		NativeMethodInfoPtr_AddToScene_Public_Static_BackButton_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668248);
		NativeMethodInfoPtr_Disable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668249);
		NativeMethodInfoPtr_Enable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668250);
		NativeMethodInfoPtr_EnableByForce_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668251);
		NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668252);
		NativeMethodInfoPtr_GetBackButtonInputData_Private_Static_InputData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButton>.NativeClassPtr, 100668253);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BackButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737343, XrefRangeEnd = 737344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737344, XrefRangeEnd = 737373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737373, XrefRangeEnd = 737394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737394, XrefRangeEnd = 737396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 737420, RefRangeEnd = 737423, XrefRangeStart = 737396, XrefRangeEnd = 737420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737423, XrefRangeEnd = 737431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BackButton AddToScene(bool selectGameObjectAfterCreation = false)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&selectGameObjectAfterCreation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToScene_Public_Static_BackButton_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BackButton>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737431, XrefRangeEnd = 737432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disable()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disable_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737432, XrefRangeEnd = 737435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enable()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enable_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737435, XrefRangeEnd = 737436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableByForce()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableByForce_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 737444, RefRangeEnd = 737445, XrefRangeStart = 737436, XrefRangeEnd = 737444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 737452, RefRangeEnd = 737454, XrefRangeStart = 737445, XrefRangeEnd = 737452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputData GetBackButtonInputData()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBackButtonInputData_Private_Static_InputData_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputData>(intPtr) : null;
	}

	public BackButton(IntPtr pointer)
		: base(pointer)
	{
	}
}
