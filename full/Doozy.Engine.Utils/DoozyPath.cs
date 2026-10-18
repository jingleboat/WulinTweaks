using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Doozy.Engine.Utils;

[Serializable]
public class DoozyPath : ScriptableObject
{
	public enum ComponentName
	{
		Soundy,
		UIButton,
		UICanvas,
		UIDrawer,
		UIPopup,
		UIView
	}

	private static readonly IntPtr NativeFieldInfoPtr_ASSETS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_DATA;

	private static readonly IntPtr NativeFieldInfoPtr_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_DOOZY;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE;

	private static readonly IntPtr NativeFieldInfoPtr_FONTS;

	private static readonly IntPtr NativeFieldInfoPtr_GUI;

	private static readonly IntPtr NativeFieldInfoPtr_IMAGES;

	private static readonly IntPtr NativeFieldInfoPtr_INTERNAL;

	private static readonly IntPtr NativeFieldInfoPtr_NODY;

	private static readonly IntPtr NativeFieldInfoPtr_RESOURCES;

	private static readonly IntPtr NativeFieldInfoPtr_SETTINGS;

	private static readonly IntPtr NativeFieldInfoPtr_SKINS;

	private static readonly IntPtr NativeFieldInfoPtr_SOUNDY;

	private static readonly IntPtr NativeFieldInfoPtr_TEMPLATES;

	private static readonly IntPtr NativeFieldInfoPtr_TOUCHY;

	private static readonly IntPtr NativeFieldInfoPtr_UI;

	private static readonly IntPtr NativeFieldInfoPtr_UIBUTTON;

	private static readonly IntPtr NativeFieldInfoPtr_UICANVAS;

	private static readonly IntPtr NativeFieldInfoPtr_UIDRAWER;

	private static readonly IntPtr NativeFieldInfoPtr_UIPOPUP;

	private static readonly IntPtr NativeFieldInfoPtr_UITOGGLE;

	private static readonly IntPtr NativeFieldInfoPtr_UIVIEW;

	private static readonly IntPtr NativeFieldInfoPtr_UTILS;

	private static readonly IntPtr NativeFieldInfoPtr_UIANIMATIONS;

	private static readonly IntPtr NativeFieldInfoPtr_HIDE;

	private static readonly IntPtr NativeFieldInfoPtr_LOOP;

	private static readonly IntPtr NativeFieldInfoPtr_PUNCH;

	private static readonly IntPtr NativeFieldInfoPtr_SHOW;

	private static readonly IntPtr NativeFieldInfoPtr_STATE;

	private static readonly IntPtr NativeFieldInfoPtr_SOUNDY_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_UIBUTTON_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_UICANVAS_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_UIDRAWER_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_UIPOPUP_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_UIVIEW_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_DOOZY_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_FONTS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_GUI_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_IMAGES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_INTERNAL_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_SETTINGS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_SKINS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_NODY_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_NODY_IMAGES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_NODY_SKINS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_NODY_SETTINGS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_EDITOR_NODY_UTILS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_NODY_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_NODY_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_SOUNDY_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_SOUNDY_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_TOUCHY_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_TOUCHY_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_SOUNDY_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIBUTTON_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UICANVAS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIDRAWER_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIPOPUP_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIVIEW_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_UI_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_UI_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIANIMATIONS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_HIDE_UIANIMATIONS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_LOOP_UIANIMATIONS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_PUNCH_UIANIMATIONS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_SHOW_UIANIMATIONS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_STATE_UIANIMATIONS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIBUTTON_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIBUTTON_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UICANVAS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UICANVAS_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIDRAWER_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIDRAWER_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIPOPUP_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIPOPUP_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIVIEW_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UIVIEW_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UITOGGLE_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_UITOGGLE_RESOURCES_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_ENGINE_UTILS_PATH;

	private static readonly IntPtr NativeFieldInfoPtr_s_basePath;

	private static readonly IntPtr NativeMethodInfoPtr_GetDataPath_Public_Static_String_ComponentName_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BasePath_Public_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateMissingFolders_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string ASSETS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ASSETS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ASSETS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DATA
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DATA, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DATA, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DOOZY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOOZY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOOZY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FONTS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FONTS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FONTS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GUI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GUI, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GUI, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string IMAGES
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IMAGES, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IMAGES, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INTERNAL
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERNAL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERNAL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NODY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NODY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NODY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RESOURCES
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RESOURCES, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RESOURCES, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SETTINGS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SETTINGS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SKINS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKINS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKINS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUNDY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TEMPLATES
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEMPLATES, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEMPLATES, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TOUCHY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOUCHY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOUCHY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIBUTTON
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIBUTTON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIBUTTON, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICANVAS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICANVAS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICANVAS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDRAWER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDRAWER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDRAWER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPOPUP
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPOPUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPOPUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UITOGGLE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UITOGGLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UITOGGLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIVIEW
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIVIEW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIVIEW, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UTILS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UTILS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UTILS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIANIMATIONS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIANIMATIONS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIANIMATIONS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HIDE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIDE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIDE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOOP
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOOP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOOP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PUNCH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PUNCH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PUNCH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHOW
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHOW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHOW, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STATE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUNDY_DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDY_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDY_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIBUTTON_DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIBUTTON_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIBUTTON_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICANVAS_DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICANVAS_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICANVAS_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDRAWER_DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDRAWER_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDRAWER_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPOPUP_DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPOPUP_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPOPUP_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIVIEW_DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIVIEW_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIVIEW_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DOOZY_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOOZY_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOOZY_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_FONTS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_FONTS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_FONTS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_GUI_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_GUI_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_GUI_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_IMAGES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_IMAGES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_IMAGES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_INTERNAL_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_INTERNAL_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_INTERNAL_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_SETTINGS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_SETTINGS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_SETTINGS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_SKINS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_SKINS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_SKINS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_NODY_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_NODY_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_NODY_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_NODY_IMAGES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_NODY_IMAGES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_NODY_IMAGES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_NODY_SKINS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_NODY_SKINS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_NODY_SKINS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_NODY_SETTINGS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_NODY_SETTINGS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_NODY_SETTINGS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EDITOR_NODY_UTILS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_NODY_UTILS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_NODY_UTILS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_NODY_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_NODY_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_NODY_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_NODY_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_NODY_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_NODY_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_SOUNDY_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_SOUNDY_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_SOUNDY_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_SOUNDY_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_SOUNDY_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_SOUNDY_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_TOUCHY_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_TOUCHY_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_TOUCHY_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_TOUCHY_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_TOUCHY_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_TOUCHY_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_SOUNDY_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_SOUNDY_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_SOUNDY_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_UIBUTTON_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIBUTTON_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIBUTTON_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_UICANVAS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UICANVAS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UICANVAS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_UIDRAWER_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIDRAWER_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIDRAWER_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_UIPOPUP_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIPOPUP_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIPOPUP_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_RESOURCES_DATA_UIVIEW_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIVIEW_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIVIEW_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_UI_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_UI_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_UI_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_UI_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_UI_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_UI_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIANIMATIONS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIANIMATIONS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIANIMATIONS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HIDE_UIANIMATIONS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIDE_UIANIMATIONS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIDE_UIANIMATIONS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOOP_UIANIMATIONS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOOP_UIANIMATIONS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOOP_UIANIMATIONS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PUNCH_UIANIMATIONS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PUNCH_UIANIMATIONS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PUNCH_UIANIMATIONS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHOW_UIANIMATIONS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHOW_UIANIMATIONS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHOW_UIANIMATIONS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STATE_UIANIMATIONS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATE_UIANIMATIONS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATE_UIANIMATIONS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIBUTTON_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIBUTTON_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIBUTTON_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIBUTTON_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIBUTTON_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIBUTTON_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICANVAS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICANVAS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICANVAS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICANVAS_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICANVAS_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICANVAS_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDRAWER_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDRAWER_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDRAWER_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDRAWER_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDRAWER_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDRAWER_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPOPUP_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPOPUP_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPOPUP_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPOPUP_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPOPUP_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPOPUP_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIVIEW_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIVIEW_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIVIEW_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIVIEW_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIVIEW_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIVIEW_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UITOGGLE_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UITOGGLE_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UITOGGLE_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UITOGGLE_RESOURCES_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UITOGGLE_RESOURCES_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UITOGGLE_RESOURCES_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENGINE_UTILS_PATH
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGINE_UTILS_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGINE_UTILS_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string s_basePath
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_basePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_basePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BasePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726133, XrefRangeEnd = 726135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BasePath_Public_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static DoozyPath()
	{
		Il2CppClassPointerStore<DoozyPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "DoozyPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr);
		NativeFieldInfoPtr_ASSETS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ASSETS_PATH");
		NativeFieldInfoPtr_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "DATA");
		NativeFieldInfoPtr_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "DATABASE");
		NativeFieldInfoPtr_DOOZY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "DOOZY");
		NativeFieldInfoPtr_EDITOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR");
		NativeFieldInfoPtr_ENGINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE");
		NativeFieldInfoPtr_FONTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "FONTS");
		NativeFieldInfoPtr_GUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "GUI");
		NativeFieldInfoPtr_IMAGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "IMAGES");
		NativeFieldInfoPtr_INTERNAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "INTERNAL");
		NativeFieldInfoPtr_NODY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "NODY");
		NativeFieldInfoPtr_RESOURCES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "RESOURCES");
		NativeFieldInfoPtr_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "SETTINGS");
		NativeFieldInfoPtr_SKINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "SKINS");
		NativeFieldInfoPtr_SOUNDY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "SOUNDY");
		NativeFieldInfoPtr_TEMPLATES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "TEMPLATES");
		NativeFieldInfoPtr_TOUCHY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "TOUCHY");
		NativeFieldInfoPtr_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UI");
		NativeFieldInfoPtr_UIBUTTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIBUTTON");
		NativeFieldInfoPtr_UICANVAS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UICANVAS");
		NativeFieldInfoPtr_UIDRAWER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIDRAWER");
		NativeFieldInfoPtr_UIPOPUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIPOPUP");
		NativeFieldInfoPtr_UITOGGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UITOGGLE");
		NativeFieldInfoPtr_UIVIEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIVIEW");
		NativeFieldInfoPtr_UTILS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UTILS");
		NativeFieldInfoPtr_UIANIMATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIANIMATIONS");
		NativeFieldInfoPtr_HIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "HIDE");
		NativeFieldInfoPtr_LOOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "LOOP");
		NativeFieldInfoPtr_PUNCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "PUNCH");
		NativeFieldInfoPtr_SHOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "SHOW");
		NativeFieldInfoPtr_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "STATE");
		NativeFieldInfoPtr_SOUNDY_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "SOUNDY_DATABASE");
		NativeFieldInfoPtr_UIBUTTON_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIBUTTON_DATABASE");
		NativeFieldInfoPtr_UICANVAS_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UICANVAS_DATABASE");
		NativeFieldInfoPtr_UIDRAWER_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIDRAWER_DATABASE");
		NativeFieldInfoPtr_UIPOPUP_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIPOPUP_DATABASE");
		NativeFieldInfoPtr_UIVIEW_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIVIEW_DATABASE");
		NativeFieldInfoPtr_DOOZY_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "DOOZY_PATH");
		NativeFieldInfoPtr_EDITOR_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_PATH");
		NativeFieldInfoPtr_ENGINE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_PATH");
		NativeFieldInfoPtr_EDITOR_FONTS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_FONTS_PATH");
		NativeFieldInfoPtr_EDITOR_GUI_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_GUI_PATH");
		NativeFieldInfoPtr_EDITOR_IMAGES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_IMAGES_PATH");
		NativeFieldInfoPtr_EDITOR_INTERNAL_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_INTERNAL_PATH");
		NativeFieldInfoPtr_EDITOR_SETTINGS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_SETTINGS_PATH");
		NativeFieldInfoPtr_EDITOR_SKINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_SKINS_PATH");
		NativeFieldInfoPtr_EDITOR_NODY_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_NODY_PATH");
		NativeFieldInfoPtr_EDITOR_NODY_IMAGES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_NODY_IMAGES_PATH");
		NativeFieldInfoPtr_EDITOR_NODY_SKINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_NODY_SKINS_PATH");
		NativeFieldInfoPtr_EDITOR_NODY_SETTINGS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_NODY_SETTINGS_PATH");
		NativeFieldInfoPtr_EDITOR_NODY_UTILS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "EDITOR_NODY_UTILS_PATH");
		NativeFieldInfoPtr_ENGINE_NODY_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_NODY_PATH");
		NativeFieldInfoPtr_ENGINE_NODY_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_NODY_RESOURCES_PATH");
		NativeFieldInfoPtr_ENGINE_SOUNDY_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_SOUNDY_PATH");
		NativeFieldInfoPtr_ENGINE_SOUNDY_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_SOUNDY_RESOURCES_PATH");
		NativeFieldInfoPtr_ENGINE_TOUCHY_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_TOUCHY_PATH");
		NativeFieldInfoPtr_ENGINE_TOUCHY_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_TOUCHY_RESOURCES_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_SOUNDY_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_SOUNDY_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIBUTTON_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_UIBUTTON_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UICANVAS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_UICANVAS_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIDRAWER_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_UIDRAWER_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIPOPUP_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_UIPOPUP_PATH");
		NativeFieldInfoPtr_ENGINE_RESOURCES_DATA_UIVIEW_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_RESOURCES_DATA_UIVIEW_PATH");
		NativeFieldInfoPtr_ENGINE_UI_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_UI_PATH");
		NativeFieldInfoPtr_ENGINE_UI_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_UI_RESOURCES_PATH");
		NativeFieldInfoPtr_UIANIMATIONS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIANIMATIONS_RESOURCES_PATH");
		NativeFieldInfoPtr_HIDE_UIANIMATIONS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "HIDE_UIANIMATIONS_RESOURCES_PATH");
		NativeFieldInfoPtr_LOOP_UIANIMATIONS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "LOOP_UIANIMATIONS_RESOURCES_PATH");
		NativeFieldInfoPtr_PUNCH_UIANIMATIONS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "PUNCH_UIANIMATIONS_RESOURCES_PATH");
		NativeFieldInfoPtr_SHOW_UIANIMATIONS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "SHOW_UIANIMATIONS_RESOURCES_PATH");
		NativeFieldInfoPtr_STATE_UIANIMATIONS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "STATE_UIANIMATIONS_RESOURCES_PATH");
		NativeFieldInfoPtr_UIBUTTON_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIBUTTON_PATH");
		NativeFieldInfoPtr_UIBUTTON_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIBUTTON_RESOURCES_PATH");
		NativeFieldInfoPtr_UICANVAS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UICANVAS_PATH");
		NativeFieldInfoPtr_UICANVAS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UICANVAS_RESOURCES_PATH");
		NativeFieldInfoPtr_UIDRAWER_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIDRAWER_PATH");
		NativeFieldInfoPtr_UIDRAWER_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIDRAWER_RESOURCES_PATH");
		NativeFieldInfoPtr_UIPOPUP_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIPOPUP_PATH");
		NativeFieldInfoPtr_UIPOPUP_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIPOPUP_RESOURCES_PATH");
		NativeFieldInfoPtr_UIVIEW_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIVIEW_PATH");
		NativeFieldInfoPtr_UIVIEW_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UIVIEW_RESOURCES_PATH");
		NativeFieldInfoPtr_UITOGGLE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UITOGGLE_PATH");
		NativeFieldInfoPtr_UITOGGLE_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "UITOGGLE_RESOURCES_PATH");
		NativeFieldInfoPtr_ENGINE_UTILS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "ENGINE_UTILS_PATH");
		NativeFieldInfoPtr_s_basePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, "s_basePath");
		NativeMethodInfoPtr_GetDataPath_Public_Static_String_ComponentName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, 100667372);
		NativeMethodInfoPtr_get_BasePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, 100667373);
		NativeMethodInfoPtr_CreateMissingFolders_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, 100667374);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr, 100667375);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 726127, RefRangeEnd = 726133, XrefRangeStart = 726115, XrefRangeEnd = 726127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDataPath(ComponentName componentName)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&componentName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataPath_Public_Static_String_ComponentName_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateMissingFolders()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMissingFolders_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(99)]
	[CachedScanResults(RefRangeStart = 224141, RefRangeEnd = 224240, XrefRangeStart = 224141, XrefRangeEnd = 224240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoozyPath()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoozyPath>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoozyPath(IntPtr pointer)
		: base(pointer)
	{
	}
}
