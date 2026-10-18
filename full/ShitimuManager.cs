using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Steamworks;
using TMPro;
using UnityEngine;
using WuLin;

public class ShitimuManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_s_EverInitialized;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_m_GamepadTextInputDismissed;

	private static readonly IntPtr NativeFieldInfoPtr_m_GameOverlayActivated;

	private static readonly IntPtr NativeFieldInfoPtr_ID_GAME;

	private static readonly IntPtr NativeFieldInfoPtr_ID_DLC1;

	private static readonly IntPtr NativeFieldInfoPtr_ID_DLC2;

	private static readonly IntPtr NativeFieldInfoPtr_ID_DLC3;

	private static readonly IntPtr NativeFieldInfoPtr_ID_DLC4;

	private static readonly IntPtr NativeFieldInfoPtr_ID_DLC5;

	private static readonly IntPtr NativeFieldInfoPtr_m_bInitialized;

	private static readonly IntPtr NativeFieldInfoPtr_needCheckDlc;

	private static readonly IntPtr NativeFieldInfoPtr_m_SteamAPIWarningMessageHook;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Protected_Static_get_ShitimuManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsPrePurchased_Public_Static_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PurchaseDlc_Public_Static_Void_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReportAchievementProgress_Public_Static_Void_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReportAchievementComplete_Public_Static_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSteamCurrentGameLanguage_Public_Static_SystemLanguage_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetModFilesDir_Public_Static_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsPreferJoyStick_Public_Static_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OpenVirtualKeyboard_Public_Static_Boolean_ContentType_Int32_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_OpenFloatingKeyboard_Public_Static_Boolean_ContentType_Int32_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnGamepadTextInputDismissed_Private_Static_Void_GamepadTextInputDismissed_t_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnGameOverlayActivated_Private_Static_Void_GameOverlayActivated_t_0;

	private static readonly IntPtr NativeMethodInfoPtr_GameDlcModeToUint_Public_Static_UInt32_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsDlcPurchased_Public_Static_Boolean_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsDlcPurchasedAndInstalled_Public_Static_Boolean_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDlcFileDir_Public_Static_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SteamAPIDebugTextHook_Protected_Static_Void_Int32_StringBuilder_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitOnPlayMode_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool s_EverInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EverInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EverInitialized, (void*)(&flag));
		}
	}

	public unsafe static ShitimuManager s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ShitimuManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shitimuManager));
		}
	}

	public unsafe static Callback<GamepadTextInputDismissed_t> m_GamepadTextInputDismissed
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_GamepadTextInputDismissed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Callback<GamepadTextInputDismissed_t>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_GamepadTextInputDismissed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback));
		}
	}

	public unsafe static Callback<GameOverlayActivated_t> m_GameOverlayActivated
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_GameOverlayActivated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Callback<GameOverlayActivated_t>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_GameOverlayActivated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback));
		}
	}

	public unsafe static uint ID_GAME
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GAME, (void*)(&num));
		}
	}

	public unsafe static uint ID_DLC1
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_DLC1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_DLC1, (void*)(&num));
		}
	}

	public unsafe static uint ID_DLC2
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_DLC2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_DLC2, (void*)(&num));
		}
	}

	public unsafe static uint ID_DLC3
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_DLC3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_DLC3, (void*)(&num));
		}
	}

	public unsafe static uint ID_DLC4
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_DLC4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_DLC4, (void*)(&num));
		}
	}

	public unsafe static uint ID_DLC5
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_DLC5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_DLC5, (void*)(&num));
		}
	}

	public unsafe bool m_bInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bInitialized)) = flag;
		}
	}

	public unsafe static bool needCheckDlc
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_needCheckDlc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_needCheckDlc, (void*)(&flag));
		}
	}

	public unsafe SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SteamAPIWarningMessageHook);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SteamAPIWarningMessageHook_t>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SteamAPIWarningMessageHook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamAPIWarningMessageHook_t));
		}
	}

	public unsafe static ShitimuManager Instance
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 671970, RefRangeEnd = 671977, XrefRangeStart = 671907, XrefRangeEnd = 671970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Protected_Static_get_ShitimuManager_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ShitimuManager>(intPtr) : null;
		}
	}

	public unsafe static bool Initialized
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 671981, RefRangeEnd = 671982, XrefRangeStart = 671977, XrefRangeEnd = 671981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ShitimuManager()
	{
		Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShitimuManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_EverInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "s_EverInitialized");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_m_GamepadTextInputDismissed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "m_GamepadTextInputDismissed");
		NativeFieldInfoPtr_m_GameOverlayActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "m_GameOverlayActivated");
		NativeFieldInfoPtr_ID_GAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "ID_GAME");
		NativeFieldInfoPtr_ID_DLC1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "ID_DLC1");
		NativeFieldInfoPtr_ID_DLC2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "ID_DLC2");
		NativeFieldInfoPtr_ID_DLC3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "ID_DLC3");
		NativeFieldInfoPtr_ID_DLC4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "ID_DLC4");
		NativeFieldInfoPtr_ID_DLC5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "ID_DLC5");
		NativeFieldInfoPtr_m_bInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "m_bInitialized");
		NativeFieldInfoPtr_needCheckDlc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "needCheckDlc");
		NativeFieldInfoPtr_m_SteamAPIWarningMessageHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, "m_SteamAPIWarningMessageHook");
		NativeMethodInfoPtr_get_Instance_Protected_Static_get_ShitimuManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_IsPrePurchased_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_PurchaseDlc_Public_Static_Void_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_ReportAchievementProgress_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_ReportAchievementComplete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_GetSteamCurrentGameLanguage_Public_Static_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_GetModFilesDir_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_IsPreferJoyStick_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_OpenVirtualKeyboard_Public_Static_Boolean_ContentType_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_OpenFloatingKeyboard_Public_Static_Boolean_ContentType_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_OnGamepadTextInputDismissed_Private_Static_Void_GamepadTextInputDismissed_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_OnGameOverlayActivated_Private_Static_Void_GameOverlayActivated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_GameDlcModeToUint_Public_Static_UInt32_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_IsDlcPurchased_Public_Static_Boolean_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_IsDlcPurchasedAndInstalled_Public_Static_Boolean_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_GetDlcFileDir_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_SteamAPIDebugTextHook_Protected_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_InitOnPlayMode_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr, 100663847);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672006, RefRangeEnd = 672007, XrefRangeStart = 671982, XrefRangeEnd = 672006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPrePurchased()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrePurchased_Public_Static_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672020, RefRangeEnd = 672021, XrefRangeStart = 672007, XrefRangeEnd = 672020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PurchaseDlc(GameDlcMode gameDlcMode)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&gameDlcMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PurchaseDlc_Public_Static_Void_GameDlcMode_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672031, RefRangeEnd = 672032, XrefRangeStart = 672021, XrefRangeEnd = 672031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReportAchievementProgress(string key, int value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportAchievementProgress_Public_Static_Void_String_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672043, RefRangeEnd = 672044, XrefRangeStart = 672032, XrefRangeEnd = 672043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReportAchievementComplete(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportAchievementComplete_Public_Static_Void_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 672068, RefRangeEnd = 672070, XrefRangeStart = 672044, XrefRangeEnd = 672068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SystemLanguage GetSteamCurrentGameLanguage()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamCurrentGameLanguage_Public_Static_SystemLanguage_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SystemLanguage*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672104, RefRangeEnd = 672105, XrefRangeStart = 672070, XrefRangeEnd = 672104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetModFilesDir()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetModFilesDir_Public_Static_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672114, RefRangeEnd = 672115, XrefRangeStart = 672105, XrefRangeEnd = 672114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPreferJoyStick()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPreferJoyStick_Public_Static_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672126, RefRangeEnd = 672127, XrefRangeStart = 672115, XrefRangeEnd = 672126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OpenVirtualKeyboard(TMP_InputField.ContentType type, int charCount, bool multiLine, string defaultText)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &charCount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &multiLine;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenVirtualKeyboard_Public_Static_Boolean_ContentType_Int32_Boolean_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 672138, RefRangeEnd = 672139, XrefRangeStart = 672127, XrefRangeEnd = 672138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OpenFloatingKeyboard(TMP_InputField.ContentType type, int charCount, bool multiLine, string defaultText)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &charCount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &multiLine;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenFloatingKeyboard_Public_Static_Boolean_ContentType_Int32_Boolean_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672139, XrefRangeEnd = 672174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnGamepadTextInputDismissed(GamepadTextInputDismissed_t pCallback)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pCallback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGamepadTextInputDismissed_Private_Static_Void_GamepadTextInputDismissed_t_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672174, XrefRangeEnd = 672187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnGameOverlayActivated(GameOverlayActivated_t pCallback)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pCallback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGameOverlayActivated_Private_Static_Void_GameOverlayActivated_t_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint GameDlcModeToUint(GameDlcMode gameDlcMode)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&gameDlcMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameDlcModeToUint_Public_Static_UInt32_GameDlcMode_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 672200, RefRangeEnd = 672210, XrefRangeStart = 672187, XrefRangeEnd = 672200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDlcPurchased(GameDlcMode gameDlcMode)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&gameDlcMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDlcPurchased_Public_Static_Boolean_GameDlcMode_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 672223, RefRangeEnd = 672226, XrefRangeStart = 672210, XrefRangeEnd = 672223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDlcPurchasedAndInstalled(GameDlcMode gameDlcMode)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&gameDlcMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDlcPurchasedAndInstalled_Public_Static_Boolean_GameDlcMode_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 672236, RefRangeEnd = 672238, XrefRangeStart = 672226, XrefRangeEnd = 672236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDlcFileDir()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDlcFileDir_Public_Static_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672238, XrefRangeEnd = 672242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&nSeverity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchDebugText);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPIDebugTextHook_Protected_Static_Void_Int32_StringBuilder_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672242, XrefRangeEnd = 672247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitOnPlayMode()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitOnPlayMode_Private_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672247, XrefRangeEnd = 672287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672287, XrefRangeEnd = 672305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672305, XrefRangeEnd = 672317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672317, XrefRangeEnd = 672318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672318, XrefRangeEnd = 672326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationFocus(bool focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShitimuManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShitimuManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShitimuManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
