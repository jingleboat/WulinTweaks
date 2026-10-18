using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.Settings;

[Serializable]
public class DoozySettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_SelectedLanguage;

	private static readonly IntPtr NativeFieldInfoPtr_AutoDisableUIInteractions;

	private static readonly IntPtr NativeFieldInfoPtr_DebugBackButton;

	private static readonly IntPtr NativeFieldInfoPtr_DebugGameEventListener;

	private static readonly IntPtr NativeFieldInfoPtr_DebugGameEventManager;

	private static readonly IntPtr NativeFieldInfoPtr_DebugGestureListener;

	private static readonly IntPtr NativeFieldInfoPtr_DebugGraphController;

	private static readonly IntPtr NativeFieldInfoPtr_DebugKeyToGameEvent;

	private static readonly IntPtr NativeFieldInfoPtr_DebugOrientationDetector;

	private static readonly IntPtr NativeFieldInfoPtr_DebugProgressor;

	private static readonly IntPtr NativeFieldInfoPtr_DebugProgressorGroup;

	private static readonly IntPtr NativeFieldInfoPtr_DebugSceneDirector;

	private static readonly IntPtr NativeFieldInfoPtr_DebugSceneLoader;

	private static readonly IntPtr NativeFieldInfoPtr_DebugSoundyController;

	private static readonly IntPtr NativeFieldInfoPtr_DebugSoundyManager;

	private static readonly IntPtr NativeFieldInfoPtr_DebugSoundyPooler;

	private static readonly IntPtr NativeFieldInfoPtr_DebugTouchDetector;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIButton;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIButtonListener;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUICanvas;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIDrawer;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIDrawerListener;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIPopup;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIPopupManager;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIToggle;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIView;

	private static readonly IntPtr NativeFieldInfoPtr_DebugUIViewListener;

	private static readonly IntPtr NativeFieldInfoPtr_DOTweenDetected;

	private static readonly IntPtr NativeFieldInfoPtr_DoozyUIVersion3Detected;

	private static readonly IntPtr NativeFieldInfoPtr_DoozyUIVersion2Detected;

	private static readonly IntPtr NativeFieldInfoPtr_MasterAudioDetected;

	private static readonly IntPtr NativeFieldInfoPtr_PlaymakerDetected;

	private static readonly IntPtr NativeFieldInfoPtr_TextMeshProDetected;

	private static readonly IntPtr NativeFieldInfoPtr_IgnoreUnityTimescale;

	private static readonly IntPtr NativeFieldInfoPtr_SpeedBasedAnimations;

	private static readonly IntPtr NativeFieldInfoPtr_UseBackButton;

	private static readonly IntPtr NativeFieldInfoPtr_UseMasterAudio;

	private static readonly IntPtr NativeFieldInfoPtr_UseOrientationDetector;

	private static readonly IntPtr NativeFieldInfoPtr_UsePlaymaker;

	private static readonly IntPtr NativeFieldInfoPtr_UseTextMeshPro;

	private static readonly IntPtr NativeFieldInfoPtr_AssetDatabaseSaveAssetsNeeded;

	private static readonly IntPtr NativeFieldInfoPtr_AssetDatabaseRefreshNeeded;

	private static readonly IntPtr NativeFieldInfoPtr_MAILTO;

	private static readonly IntPtr NativeFieldInfoPtr_SUPPORT_EMAIL_ADDRESS;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_DISCORD_INVITE;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_FACEBOOK;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_TWITTER;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION_GETTING_STARTED;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_FAQ;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_LEARN;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_SUPPORT_REQUEST;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_DOTWEEN;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_MICROSOFT_DOT_NET_API;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_UNITY_MANUAL;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_WEBSITE_UNITY_SCRIPTING_API;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_YOUTUBE_CHANNEL;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_YOUTUBE_VIDEOS;

	private static readonly IntPtr NativeFieldInfoPtr_LINK_ZENDESK_TICKET;

	private static readonly IntPtr NativeFieldInfoPtr_DOOZYUI_ABOUT;

	private static readonly IntPtr NativeFieldInfoPtr_SOUNDY_VERSION;

	private static readonly IntPtr NativeFieldInfoPtr_SOUNDY_ABOUT;

	private static readonly IntPtr NativeFieldInfoPtr_TOUCHY_VERSION;

	private static readonly IntPtr NativeFieldInfoPtr_TOUCHY_ABOUT;

	private static readonly IntPtr NativeFieldInfoPtr_NODY_VERSION;

	private static readonly IntPtr NativeFieldInfoPtr_NODY_ABOUT;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DoozySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SaveAndRefreshAssetDatabase_Public_Void_0;

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

	public unsafe static DoozySettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DoozySettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doozySettings));
		}
	}

	public unsafe Language SelectedLanguage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedLanguage);
			return *(Language*)num;
		}
		set
		{
			*(Language*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedLanguage)) = language;
		}
	}

	public unsafe bool AutoDisableUIInteractions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoDisableUIInteractions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoDisableUIInteractions)) = flag;
		}
	}

	public unsafe bool DebugBackButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugBackButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugBackButton)) = flag;
		}
	}

	public unsafe bool DebugGameEventListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGameEventListener);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGameEventListener)) = flag;
		}
	}

	public unsafe bool DebugGameEventManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGameEventManager);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGameEventManager)) = flag;
		}
	}

	public unsafe bool DebugGestureListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGestureListener);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGestureListener)) = flag;
		}
	}

	public unsafe bool DebugGraphController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGraphController);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugGraphController)) = flag;
		}
	}

	public unsafe bool DebugKeyToGameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugKeyToGameEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugKeyToGameEvent)) = flag;
		}
	}

	public unsafe bool DebugOrientationDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugOrientationDetector);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugOrientationDetector)) = flag;
		}
	}

	public unsafe bool DebugProgressor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugProgressor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugProgressor)) = flag;
		}
	}

	public unsafe bool DebugProgressorGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugProgressorGroup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugProgressorGroup)) = flag;
		}
	}

	public unsafe bool DebugSceneDirector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSceneDirector);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSceneDirector)) = flag;
		}
	}

	public unsafe bool DebugSceneLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSceneLoader);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSceneLoader)) = flag;
		}
	}

	public unsafe bool DebugSoundyController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSoundyController);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSoundyController)) = flag;
		}
	}

	public unsafe bool DebugSoundyManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSoundyManager);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSoundyManager)) = flag;
		}
	}

	public unsafe bool DebugSoundyPooler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSoundyPooler);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugSoundyPooler)) = flag;
		}
	}

	public unsafe bool DebugTouchDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugTouchDetector);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugTouchDetector)) = flag;
		}
	}

	public unsafe bool DebugUIButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIButton)) = flag;
		}
	}

	public unsafe bool DebugUIButtonListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIButtonListener);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIButtonListener)) = flag;
		}
	}

	public unsafe bool DebugUICanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUICanvas);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUICanvas)) = flag;
		}
	}

	public unsafe bool DebugUIDrawer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIDrawer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIDrawer)) = flag;
		}
	}

	public unsafe bool DebugUIDrawerListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIDrawerListener);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIDrawerListener)) = flag;
		}
	}

	public unsafe bool DebugUIPopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIPopup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIPopup)) = flag;
		}
	}

	public unsafe bool DebugUIPopupManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIPopupManager);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIPopupManager)) = flag;
		}
	}

	public unsafe bool DebugUIToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIToggle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIToggle)) = flag;
		}
	}

	public unsafe bool DebugUIView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIView);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIView)) = flag;
		}
	}

	public unsafe bool DebugUIViewListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIViewListener);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugUIViewListener)) = flag;
		}
	}

	public unsafe bool DOTweenDetected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DOTweenDetected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DOTweenDetected)) = flag;
		}
	}

	public unsafe bool DoozyUIVersion3Detected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoozyUIVersion3Detected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoozyUIVersion3Detected)) = flag;
		}
	}

	public unsafe bool DoozyUIVersion2Detected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoozyUIVersion2Detected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoozyUIVersion2Detected)) = flag;
		}
	}

	public unsafe bool MasterAudioDetected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MasterAudioDetected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MasterAudioDetected)) = flag;
		}
	}

	public unsafe bool PlaymakerDetected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlaymakerDetected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlaymakerDetected)) = flag;
		}
	}

	public unsafe bool TextMeshProDetected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextMeshProDetected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextMeshProDetected)) = flag;
		}
	}

	public unsafe bool IgnoreUnityTimescale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreUnityTimescale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreUnityTimescale)) = flag;
		}
	}

	public unsafe bool SpeedBasedAnimations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedBasedAnimations);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedBasedAnimations)) = flag;
		}
	}

	public unsafe bool UseBackButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseBackButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseBackButton)) = flag;
		}
	}

	public unsafe bool UseMasterAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMasterAudio);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMasterAudio)) = flag;
		}
	}

	public unsafe bool UseOrientationDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseOrientationDetector);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseOrientationDetector)) = flag;
		}
	}

	public unsafe bool UsePlaymaker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UsePlaymaker);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UsePlaymaker)) = flag;
		}
	}

	public unsafe bool UseTextMeshPro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseTextMeshPro);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseTextMeshPro)) = flag;
		}
	}

	public unsafe bool AssetDatabaseSaveAssetsNeeded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetDatabaseSaveAssetsNeeded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetDatabaseSaveAssetsNeeded)) = flag;
		}
	}

	public unsafe bool AssetDatabaseRefreshNeeded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetDatabaseRefreshNeeded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetDatabaseRefreshNeeded)) = flag;
		}
	}

	public unsafe static string MAILTO
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAILTO, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAILTO, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SUPPORT_EMAIL_ADDRESS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUPPORT_EMAIL_ADDRESS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUPPORT_EMAIL_ADDRESS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_DISCORD_INVITE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_DISCORD_INVITE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_DISCORD_INVITE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_FACEBOOK
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_FACEBOOK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_FACEBOOK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_TWITTER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_TWITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_TWITTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOOZYUI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOOZYUI_DOCUMENTATION
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOOZYUI_DOCUMENTATION_GETTING_STARTED
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION_GETTING_STARTED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION_GETTING_STARTED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOOZYUI_FAQ
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_FAQ, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_FAQ, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOOZYUI_LEARN
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_LEARN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_LEARN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOOZYUI_SUPPORT_REQUEST
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_SUPPORT_REQUEST, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_SUPPORT_REQUEST, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_DOTWEEN
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_DOTWEEN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_DOTWEEN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_MICROSOFT_DOT_NET_API
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_MICROSOFT_DOT_NET_API, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_MICROSOFT_DOT_NET_API, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_UNITY_MANUAL
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_UNITY_MANUAL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_UNITY_MANUAL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_WEBSITE_UNITY_SCRIPTING_API
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_WEBSITE_UNITY_SCRIPTING_API, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_WEBSITE_UNITY_SCRIPTING_API, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_YOUTUBE_CHANNEL
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_YOUTUBE_CHANNEL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_YOUTUBE_CHANNEL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_YOUTUBE_VIDEOS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_YOUTUBE_VIDEOS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_YOUTUBE_VIDEOS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LINK_ZENDESK_TICKET
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LINK_ZENDESK_TICKET, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LINK_ZENDESK_TICKET, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DOOZYUI_ABOUT
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOOZYUI_ABOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOOZYUI_ABOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUNDY_VERSION
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDY_VERSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDY_VERSION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUNDY_ABOUT
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDY_ABOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDY_ABOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TOUCHY_VERSION
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOUCHY_VERSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOUCHY_VERSION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TOUCHY_ABOUT
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOUCHY_ABOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOUCHY_ABOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NODY_VERSION
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NODY_VERSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NODY_VERSION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NODY_ABOUT
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NODY_ABOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NODY_ABOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745460, XrefRangeEnd = 745464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static DoozySettings Instance
	{
		[CallerCount(212)]
		[CachedScanResults(RefRangeStart = 745481, RefRangeEnd = 745693, XrefRangeStart = 745464, XrefRangeEnd = 745481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_DoozySettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DoozySettings>(intPtr) : null;
		}
	}

	static DoozySettings()
	{
		Il2CppClassPointerStore<DoozySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Settings", "DoozySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_SelectedLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "SelectedLanguage");
		NativeFieldInfoPtr_AutoDisableUIInteractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "AutoDisableUIInteractions");
		NativeFieldInfoPtr_DebugBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugBackButton");
		NativeFieldInfoPtr_DebugGameEventListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugGameEventListener");
		NativeFieldInfoPtr_DebugGameEventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugGameEventManager");
		NativeFieldInfoPtr_DebugGestureListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugGestureListener");
		NativeFieldInfoPtr_DebugGraphController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugGraphController");
		NativeFieldInfoPtr_DebugKeyToGameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugKeyToGameEvent");
		NativeFieldInfoPtr_DebugOrientationDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugOrientationDetector");
		NativeFieldInfoPtr_DebugProgressor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugProgressor");
		NativeFieldInfoPtr_DebugProgressorGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugProgressorGroup");
		NativeFieldInfoPtr_DebugSceneDirector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugSceneDirector");
		NativeFieldInfoPtr_DebugSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugSceneLoader");
		NativeFieldInfoPtr_DebugSoundyController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugSoundyController");
		NativeFieldInfoPtr_DebugSoundyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugSoundyManager");
		NativeFieldInfoPtr_DebugSoundyPooler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugSoundyPooler");
		NativeFieldInfoPtr_DebugTouchDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugTouchDetector");
		NativeFieldInfoPtr_DebugUIButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIButton");
		NativeFieldInfoPtr_DebugUIButtonListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIButtonListener");
		NativeFieldInfoPtr_DebugUICanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUICanvas");
		NativeFieldInfoPtr_DebugUIDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIDrawer");
		NativeFieldInfoPtr_DebugUIDrawerListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIDrawerListener");
		NativeFieldInfoPtr_DebugUIPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIPopup");
		NativeFieldInfoPtr_DebugUIPopupManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIPopupManager");
		NativeFieldInfoPtr_DebugUIToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIToggle");
		NativeFieldInfoPtr_DebugUIView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIView");
		NativeFieldInfoPtr_DebugUIViewListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DebugUIViewListener");
		NativeFieldInfoPtr_DOTweenDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DOTweenDetected");
		NativeFieldInfoPtr_DoozyUIVersion3Detected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DoozyUIVersion3Detected");
		NativeFieldInfoPtr_DoozyUIVersion2Detected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DoozyUIVersion2Detected");
		NativeFieldInfoPtr_MasterAudioDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "MasterAudioDetected");
		NativeFieldInfoPtr_PlaymakerDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "PlaymakerDetected");
		NativeFieldInfoPtr_TextMeshProDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "TextMeshProDetected");
		NativeFieldInfoPtr_IgnoreUnityTimescale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "IgnoreUnityTimescale");
		NativeFieldInfoPtr_SpeedBasedAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "SpeedBasedAnimations");
		NativeFieldInfoPtr_UseBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "UseBackButton");
		NativeFieldInfoPtr_UseMasterAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "UseMasterAudio");
		NativeFieldInfoPtr_UseOrientationDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "UseOrientationDetector");
		NativeFieldInfoPtr_UsePlaymaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "UsePlaymaker");
		NativeFieldInfoPtr_UseTextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "UseTextMeshPro");
		NativeFieldInfoPtr_AssetDatabaseSaveAssetsNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "AssetDatabaseSaveAssetsNeeded");
		NativeFieldInfoPtr_AssetDatabaseRefreshNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "AssetDatabaseRefreshNeeded");
		NativeFieldInfoPtr_MAILTO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "MAILTO");
		NativeFieldInfoPtr_SUPPORT_EMAIL_ADDRESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "SUPPORT_EMAIL_ADDRESS");
		NativeFieldInfoPtr_LINK_DISCORD_INVITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_DISCORD_INVITE");
		NativeFieldInfoPtr_LINK_FACEBOOK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_FACEBOOK");
		NativeFieldInfoPtr_LINK_TWITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_TWITTER");
		NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOOZYUI");
		NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOOZYUI_DOCUMENTATION");
		NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_DOCUMENTATION_GETTING_STARTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOOZYUI_DOCUMENTATION_GETTING_STARTED");
		NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_FAQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOOZYUI_FAQ");
		NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_LEARN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOOZYUI_LEARN");
		NativeFieldInfoPtr_LINK_WEBSITE_DOOZYUI_SUPPORT_REQUEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOOZYUI_SUPPORT_REQUEST");
		NativeFieldInfoPtr_LINK_WEBSITE_DOTWEEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_DOTWEEN");
		NativeFieldInfoPtr_LINK_WEBSITE_MICROSOFT_DOT_NET_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_MICROSOFT_DOT_NET_API");
		NativeFieldInfoPtr_LINK_WEBSITE_UNITY_MANUAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_UNITY_MANUAL");
		NativeFieldInfoPtr_LINK_WEBSITE_UNITY_SCRIPTING_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_WEBSITE_UNITY_SCRIPTING_API");
		NativeFieldInfoPtr_LINK_YOUTUBE_CHANNEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_YOUTUBE_CHANNEL");
		NativeFieldInfoPtr_LINK_YOUTUBE_VIDEOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_YOUTUBE_VIDEOS");
		NativeFieldInfoPtr_LINK_ZENDESK_TICKET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "LINK_ZENDESK_TICKET");
		NativeFieldInfoPtr_DOOZYUI_ABOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "DOOZYUI_ABOUT");
		NativeFieldInfoPtr_SOUNDY_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "SOUNDY_VERSION");
		NativeFieldInfoPtr_SOUNDY_ABOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "SOUNDY_ABOUT");
		NativeFieldInfoPtr_TOUCHY_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "TOUCHY_VERSION");
		NativeFieldInfoPtr_TOUCHY_ABOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "TOUCHY_ABOUT");
		NativeFieldInfoPtr_NODY_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "NODY_VERSION");
		NativeFieldInfoPtr_NODY_ABOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, "NODY_ABOUT");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, 100668792);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_DoozySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, 100668793);
		NativeMethodInfoPtr_SaveAndRefreshAssetDatabase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, 100668794);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, 100668795);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, 100668796);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr, 100668797);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveAndRefreshAssetDatabase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAndRefreshAssetDatabase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745693, XrefRangeEnd = 745697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745697, XrefRangeEnd = 745704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745704, XrefRangeEnd = 745705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoozySettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoozySettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoozySettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
