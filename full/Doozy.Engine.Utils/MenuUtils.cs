using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Doozy.Engine.Utils;

public static class MenuUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_LISTENERS_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_MANAGERS_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NODY_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ORIENTATION_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYMAKER_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROGRESS_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SCENE_MANAGEMENT_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SOUNDY_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOUCHY_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_MENU_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_INPUT_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_INPUT_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButton_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToGameEvent_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Listeners_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Listeners_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventListener_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButtonListener_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerListener_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIViewListener_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Managers_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Managers_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventManager_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopupManager_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Nody_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Nody_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphController_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Graph_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_Graph_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_HiddenNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseNodeOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultNodeOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActivateLoadedScenesNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActivateLoadedScenesNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ApplicationQuitNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ApplicationQuitNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButtonNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackButtonNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnterNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnterNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExitNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExitNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEventNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadSceneNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadSceneNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_PortalNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_PortalNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_RandomNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_RandomNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubGraphNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubGraphNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_SwitchBackNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_SwitchBackNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeScaleNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeScaleNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawerNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UINode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UINode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UINode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UINode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnloadSceneNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnloadSceneNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitNode_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitNode_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Orientation_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Orientation_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrientationDetector_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Playmaker_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Playmaker_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaymakerEventDispatcher_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progress_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progress_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progressor_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressorGroup_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progress_Targets_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progress_Targets_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetAnimator_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetImage_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetText_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTargetTextMeshPro_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneManagement_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneManagement_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneLoader_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneDirector_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Soundy_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Soundy_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundyManager_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_Touchy_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Touchy_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_GestureListener_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchDetector_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_AddComponentMenu_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_MenuItem_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICanvas_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIDrawer_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIImage_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIPopup_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIView_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_GameObject_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_AddComponentMenu_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_AddComponentMenu_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_MenuItem_Priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIToggle_YouTube;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoozyWindow_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoozyWindow_OpenShortcut;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoozyWindow_MenuItem_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodyWindow_MenuItem_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodyWindow_OpenShortcut;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodyWindow_MenuItem_Order;

	public unsafe static int INPUT_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int LISTENERS_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LISTENERS_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LISTENERS_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int MANAGERS_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MANAGERS_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MANAGERS_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int NODY_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NODY_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NODY_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int ORIENTATION_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ORIENTATION_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ORIENTATION_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int PLAYMAKER_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYMAKER_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYMAKER_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int PROGRESS_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROGRESS_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROGRESS_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int SCENE_MANAGEMENT_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SCENE_MANAGEMENT_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SCENE_MANAGEMENT_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int SOUNDY_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDY_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDY_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int TOUCHY_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOUCHY_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOUCHY_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static int UI_MENU_ORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_MENU_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_MENU_ORDER, (void*)(&num));
		}
	}

	public unsafe static string UI_INPUT_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_INPUT_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_INPUT_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UI_INPUT_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_INPUT_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_INPUT_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BackButton_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BackButton_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int BackButton_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string BackButton_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int BackButton_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string BackButton_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BackButton_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButton_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButton_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KeyToGameEvent_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KeyToGameEvent_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int KeyToGameEvent_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string KeyToGameEvent_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int KeyToGameEvent_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string KeyToGameEvent_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KeyToGameEvent_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyToGameEvent_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyToGameEvent_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Listeners_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Listeners_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Listeners_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Listeners_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Listeners_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Listeners_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventListener_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventListener_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GameEventListener_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string GameEventListener_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GameEventListener_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string GameEventListener_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventListener_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventListener_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventListener_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIButtonListener_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIButtonListener_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIButtonListener_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIButtonListener_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIButtonListener_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIButtonListener_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIButtonListener_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButtonListener_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButtonListener_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawerListener_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawerListener_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIDrawerListener_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIDrawerListener_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIDrawerListener_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIDrawerListener_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawerListener_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerListener_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerListener_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIViewListener_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIViewListener_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIViewListener_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIViewListener_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIViewListener_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIViewListener_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIViewListener_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIViewListener_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIViewListener_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Managers_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Managers_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Managers_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Managers_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Managers_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Managers_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventManager_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventManager_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GameEventManager_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string GameEventManager_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GameEventManager_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string GameEventManager_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventManager_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventManager_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventManager_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPopupManager_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPopupManager_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIPopupManager_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIPopupManager_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIPopupManager_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIPopupManager_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPopupManager_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopupManager_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopupManager_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Nody_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nody_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nody_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Nody_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nody_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nody_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GraphController_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GraphController_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GraphController_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string GraphController_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GraphController_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string GraphController_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GraphController_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphController_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphController_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Graph_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Graph_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Graph_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Graph_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Graph_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Graph_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HiddenNode
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HiddenNode, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HiddenNode, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int BaseNodeOrder
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaseNodeOrder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaseNodeOrder, (void*)(&num));
		}
	}

	public unsafe static int DefaultNodeOrder
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultNodeOrder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultNodeOrder, (void*)(&num));
		}
	}

	public unsafe static string ActivateLoadedScenesNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ActivateLoadedScenesNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ActivateLoadedScenesNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ActivateLoadedScenesNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActivateLoadedScenesNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ApplicationQuitNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ApplicationQuitNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ApplicationQuitNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ApplicationQuitNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ApplicationQuitNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ApplicationQuitNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ApplicationQuitNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ApplicationQuitNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BackButtonNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int BackButtonNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string BackButtonNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButtonNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButtonNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BackButtonNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackButtonNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackButtonNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EnterNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnterNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnterNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EnterNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnterNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnterNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ExitNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExitNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExitNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ExitNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExitNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExitNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GameEventNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string GameEventNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GameEventNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameEventNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameEventNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LoadSceneNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int LoadSceneNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string LoadSceneNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LoadSceneNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LoadSceneNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LoadSceneNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LoadSceneNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LoadSceneNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PortalNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int PortalNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string PortalNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PortalNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PortalNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PortalNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PortalNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PortalNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RandomNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int RandomNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string RandomNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RandomNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RandomNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RandomNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RandomNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RandomNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SoundNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SoundNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string SoundNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SoundNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string StartNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string StartNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SubGraphNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SubGraphNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string SubGraphNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SubGraphNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SubGraphNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SubGraphNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SubGraphNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SubGraphNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SwitchBackNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SwitchBackNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string SwitchBackNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SwitchBackNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SwitchBackNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SwitchBackNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SwitchBackNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SwitchBackNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TimeScaleNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int TimeScaleNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string TimeScaleNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeScaleNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeScaleNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TimeScaleNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeScaleNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeScaleNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawerNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIDrawerNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIDrawerNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawerNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawerNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawerNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UINode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UINode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UINode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UINode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UINode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UINode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UINode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UINode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UINode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UINode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UINode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UINode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UnloadSceneNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UnloadSceneNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UnloadSceneNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnloadSceneNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnloadSceneNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UnloadSceneNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnloadSceneNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnloadSceneNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WaitNode_CreateNodeMenu_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int WaitNode_CreateNodeMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string WaitNode_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitNode_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitNode_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WaitNode_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitNode_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitNode_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Orientation_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Orientation_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Orientation_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Orientation_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Orientation_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Orientation_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OrientationDetector_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OrientationDetector_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int OrientationDetector_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string OrientationDetector_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int OrientationDetector_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string OrientationDetector_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OrientationDetector_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrientationDetector_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrientationDetector_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Playmaker_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Playmaker_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Playmaker_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Playmaker_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Playmaker_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Playmaker_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlaymakerEventDispatcher_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlaymakerEventDispatcher_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int PlaymakerEventDispatcher_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string PlaymakerEventDispatcher_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int PlaymakerEventDispatcher_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string PlaymakerEventDispatcher_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlaymakerEventDispatcher_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlaymakerEventDispatcher_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progress_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progress_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progress_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progress_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progress_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progress_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progressor_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progressor_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int Progressor_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string Progressor_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int Progressor_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string Progressor_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progressor_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progressor_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progressor_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressorGroup_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressorGroup_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressorGroup_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ProgressorGroup_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressorGroup_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string ProgressorGroup_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressorGroup_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressorGroup_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressorGroup_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progress_Targets_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progress_Targets_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progress_Targets_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Progress_Targets_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Progress_Targets_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Progress_Targets_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetAnimator_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetAnimator_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetAnimator_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetAnimator_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetAnimator_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetAnimator_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetAnimator_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetAnimator_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetAnimator_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetImage_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetImage_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetImage_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetImage_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetImage_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetImage_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetImage_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetImage_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetImage_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetText_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetText_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetText_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetText_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetText_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetText_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetText_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetText_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetText_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetTextMeshPro_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetTextMeshPro_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetTextMeshPro_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetTextMeshPro_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int ProgressTargetTextMeshPro_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string ProgressTargetTextMeshPro_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ProgressTargetTextMeshPro_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProgressTargetTextMeshPro_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneManagement_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneManagement_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneManagement_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneManagement_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneManagement_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneManagement_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneLoader_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneLoader_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SceneLoader_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string SceneLoader_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SceneLoader_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string SceneLoader_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneLoader_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneLoader_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneLoader_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneDirector_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneDirector_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SceneDirector_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string SceneDirector_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SceneDirector_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string SceneDirector_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SceneDirector_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SceneDirector_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SceneDirector_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Soundy_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Soundy_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Soundy_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Soundy_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Soundy_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Soundy_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SoundyManager_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SoundyManager_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SoundyManager_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string SoundyManager_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int SoundyManager_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string SoundyManager_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SoundyManager_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundyManager_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundyManager_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Touchy_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Touchy_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Touchy_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Touchy_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Touchy_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Touchy_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GestureListener_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GestureListener_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GestureListener_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string GestureListener_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int GestureListener_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string GestureListener_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GestureListener_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GestureListener_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GestureListener_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TouchDetector_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TouchDetector_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int TouchDetector_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string TouchDetector_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int TouchDetector_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string TouchDetector_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TouchDetector_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TouchDetector_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TouchDetector_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UI_AddComponentMenu_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_AddComponentMenu_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_AddComponentMenu_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UI_MenuItem_Path
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_MenuItem_Path, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_MenuItem_Path, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIButton_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIButton_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIButton_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIButton_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIButton_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIButton_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIButton_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICanvas_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICanvas_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UICanvas_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UICanvas_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UICanvas_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UICanvas_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UICanvas_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICanvas_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICanvas_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawer_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawer_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIDrawer_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIDrawer_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIDrawer_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIDrawer_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIDrawer_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIDrawer_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIDrawer_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIImage_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIImage_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIImage_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIImage_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIImage_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIImage_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIImage_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIImage_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIImage_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPopup_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPopup_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIPopup_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIPopup_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIPopup_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIPopup_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIPopup_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIPopup_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIPopup_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIView_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIView_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIView_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIView_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIView_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIView_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIView_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIView_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIView_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIToggle_GameObject_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_GameObject_Name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_GameObject_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIToggle_AddComponentMenu_MenuName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_AddComponentMenu_MenuName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_AddComponentMenu_MenuName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIToggle_AddComponentMenu_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_AddComponentMenu_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_AddComponentMenu_Order, (void*)(&num));
		}
	}

	public unsafe static string UIToggle_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int UIToggle_MenuItem_Priority
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_MenuItem_Priority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_MenuItem_Priority, (void*)(&num));
		}
	}

	public unsafe static string UIToggle_Manual
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_Manual, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_Manual, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UIToggle_YouTube
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIToggle_YouTube, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIToggle_YouTube, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DoozyWindow_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoozyWindow_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoozyWindow_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DoozyWindow_OpenShortcut
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoozyWindow_OpenShortcut, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoozyWindow_OpenShortcut, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int DoozyWindow_MenuItem_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoozyWindow_MenuItem_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoozyWindow_MenuItem_Order, (void*)(&num));
		}
	}

	public unsafe static string NodyWindow_MenuItem_ItemName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NodyWindow_MenuItem_ItemName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NodyWindow_MenuItem_ItemName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NodyWindow_OpenShortcut
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NodyWindow_OpenShortcut, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NodyWindow_OpenShortcut, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int NodyWindow_MenuItem_Order
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NodyWindow_MenuItem_Order, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NodyWindow_MenuItem_Order, (void*)(&num));
		}
	}

	static MenuUtils()
	{
		Il2CppClassPointerStore<MenuUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "MenuUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr);
		NativeFieldInfoPtr_INPUT_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "INPUT_MENU_ORDER");
		NativeFieldInfoPtr_LISTENERS_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "LISTENERS_MENU_ORDER");
		NativeFieldInfoPtr_MANAGERS_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "MANAGERS_MENU_ORDER");
		NativeFieldInfoPtr_NODY_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "NODY_MENU_ORDER");
		NativeFieldInfoPtr_ORIENTATION_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ORIENTATION_MENU_ORDER");
		NativeFieldInfoPtr_PLAYMAKER_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PLAYMAKER_MENU_ORDER");
		NativeFieldInfoPtr_PROGRESS_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PROGRESS_MENU_ORDER");
		NativeFieldInfoPtr_SCENE_MANAGEMENT_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SCENE_MANAGEMENT_MENU_ORDER");
		NativeFieldInfoPtr_SOUNDY_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SOUNDY_MENU_ORDER");
		NativeFieldInfoPtr_TOUCHY_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TOUCHY_MENU_ORDER");
		NativeFieldInfoPtr_UI_MENU_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UI_MENU_ORDER");
		NativeFieldInfoPtr_UI_INPUT_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UI_INPUT_AddComponentMenu_Path");
		NativeFieldInfoPtr_UI_INPUT_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UI_INPUT_MenuItem_Path");
		NativeFieldInfoPtr_BackButton_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_GameObject_Name");
		NativeFieldInfoPtr_BackButton_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_BackButton_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_AddComponentMenu_Order");
		NativeFieldInfoPtr_BackButton_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_MenuItem_ItemName");
		NativeFieldInfoPtr_BackButton_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_MenuItem_Priority");
		NativeFieldInfoPtr_BackButton_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_Manual");
		NativeFieldInfoPtr_BackButton_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButton_YouTube");
		NativeFieldInfoPtr_KeyToGameEvent_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_GameObject_Name");
		NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_KeyToGameEvent_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_AddComponentMenu_Order");
		NativeFieldInfoPtr_KeyToGameEvent_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_MenuItem_ItemName");
		NativeFieldInfoPtr_KeyToGameEvent_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_MenuItem_Priority");
		NativeFieldInfoPtr_KeyToGameEvent_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_Manual");
		NativeFieldInfoPtr_KeyToGameEvent_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "KeyToGameEvent_YouTube");
		NativeFieldInfoPtr_Listeners_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Listeners_AddComponentMenu_Path");
		NativeFieldInfoPtr_Listeners_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Listeners_MenuItem_Path");
		NativeFieldInfoPtr_GameEventListener_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_GameObject_Name");
		NativeFieldInfoPtr_GameEventListener_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_GameEventListener_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_AddComponentMenu_Order");
		NativeFieldInfoPtr_GameEventListener_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_MenuItem_ItemName");
		NativeFieldInfoPtr_GameEventListener_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_MenuItem_Priority");
		NativeFieldInfoPtr_GameEventListener_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_Manual");
		NativeFieldInfoPtr_GameEventListener_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventListener_YouTube");
		NativeFieldInfoPtr_UIButtonListener_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_GameObject_Name");
		NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIButtonListener_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIButtonListener_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_MenuItem_ItemName");
		NativeFieldInfoPtr_UIButtonListener_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_MenuItem_Priority");
		NativeFieldInfoPtr_UIButtonListener_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_Manual");
		NativeFieldInfoPtr_UIButtonListener_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButtonListener_YouTube");
		NativeFieldInfoPtr_UIDrawerListener_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_GameObject_Name");
		NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIDrawerListener_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIDrawerListener_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_MenuItem_ItemName");
		NativeFieldInfoPtr_UIDrawerListener_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_MenuItem_Priority");
		NativeFieldInfoPtr_UIDrawerListener_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_Manual");
		NativeFieldInfoPtr_UIDrawerListener_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerListener_YouTube");
		NativeFieldInfoPtr_UIViewListener_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_GameObject_Name");
		NativeFieldInfoPtr_UIViewListener_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIViewListener_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIViewListener_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_MenuItem_ItemName");
		NativeFieldInfoPtr_UIViewListener_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_MenuItem_Priority");
		NativeFieldInfoPtr_UIViewListener_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_Manual");
		NativeFieldInfoPtr_UIViewListener_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIViewListener_YouTube");
		NativeFieldInfoPtr_Managers_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Managers_AddComponentMenu_Path");
		NativeFieldInfoPtr_Managers_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Managers_MenuItem_Path");
		NativeFieldInfoPtr_GameEventManager_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_GameObject_Name");
		NativeFieldInfoPtr_GameEventManager_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_GameEventManager_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_AddComponentMenu_Order");
		NativeFieldInfoPtr_GameEventManager_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_MenuItem_ItemName");
		NativeFieldInfoPtr_GameEventManager_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_MenuItem_Priority");
		NativeFieldInfoPtr_GameEventManager_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_Manual");
		NativeFieldInfoPtr_GameEventManager_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventManager_YouTube");
		NativeFieldInfoPtr_UIPopupManager_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_GameObject_Name");
		NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIPopupManager_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIPopupManager_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_MenuItem_ItemName");
		NativeFieldInfoPtr_UIPopupManager_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_MenuItem_Priority");
		NativeFieldInfoPtr_UIPopupManager_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_Manual");
		NativeFieldInfoPtr_UIPopupManager_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopupManager_YouTube");
		NativeFieldInfoPtr_Nody_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Nody_AddComponentMenu_Path");
		NativeFieldInfoPtr_Nody_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Nody_MenuItem_Path");
		NativeFieldInfoPtr_GraphController_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_GameObject_Name");
		NativeFieldInfoPtr_GraphController_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_GraphController_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_AddComponentMenu_Order");
		NativeFieldInfoPtr_GraphController_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_MenuItem_ItemName");
		NativeFieldInfoPtr_GraphController_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_MenuItem_Priority");
		NativeFieldInfoPtr_GraphController_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_Manual");
		NativeFieldInfoPtr_GraphController_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GraphController_YouTube");
		NativeFieldInfoPtr_Graph_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Graph_Manual");
		NativeFieldInfoPtr_Graph_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Graph_YouTube");
		NativeFieldInfoPtr_HiddenNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "HiddenNode");
		NativeFieldInfoPtr_BaseNodeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BaseNodeOrder");
		NativeFieldInfoPtr_DefaultNodeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "DefaultNodeOrder");
		NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ActivateLoadedScenesNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_ActivateLoadedScenesNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ActivateLoadedScenesNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_ActivateLoadedScenesNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ActivateLoadedScenesNode_Manual");
		NativeFieldInfoPtr_ActivateLoadedScenesNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ActivateLoadedScenesNode_YouTube");
		NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ApplicationQuitNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_ApplicationQuitNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ApplicationQuitNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_ApplicationQuitNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ApplicationQuitNode_Manual");
		NativeFieldInfoPtr_ApplicationQuitNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ApplicationQuitNode_YouTube");
		NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButtonNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_BackButtonNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButtonNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_BackButtonNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButtonNode_Manual");
		NativeFieldInfoPtr_BackButtonNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "BackButtonNode_YouTube");
		NativeFieldInfoPtr_EnterNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "EnterNode_Manual");
		NativeFieldInfoPtr_EnterNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "EnterNode_YouTube");
		NativeFieldInfoPtr_ExitNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ExitNode_Manual");
		NativeFieldInfoPtr_ExitNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ExitNode_YouTube");
		NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_GameEventNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_GameEventNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventNode_Manual");
		NativeFieldInfoPtr_GameEventNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GameEventNode_YouTube");
		NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "LoadSceneNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_LoadSceneNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "LoadSceneNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_LoadSceneNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "LoadSceneNode_Manual");
		NativeFieldInfoPtr_LoadSceneNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "LoadSceneNode_YouTube");
		NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PortalNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_PortalNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PortalNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_PortalNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PortalNode_Manual");
		NativeFieldInfoPtr_PortalNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PortalNode_YouTube");
		NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "RandomNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_RandomNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "RandomNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_RandomNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "RandomNode_Manual");
		NativeFieldInfoPtr_RandomNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "RandomNode_YouTube");
		NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_SoundNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_SoundNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundNode_Manual");
		NativeFieldInfoPtr_SoundNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundNode_YouTube");
		NativeFieldInfoPtr_StartNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "StartNode_Manual");
		NativeFieldInfoPtr_StartNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "StartNode_YouTube");
		NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SubGraphNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_SubGraphNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SubGraphNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_SubGraphNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SubGraphNode_Manual");
		NativeFieldInfoPtr_SubGraphNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SubGraphNode_YouTube");
		NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SwitchBackNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_SwitchBackNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SwitchBackNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_SwitchBackNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SwitchBackNode_Manual");
		NativeFieldInfoPtr_SwitchBackNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SwitchBackNode_YouTube");
		NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TimeScaleNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_TimeScaleNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TimeScaleNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_TimeScaleNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TimeScaleNode_Manual");
		NativeFieldInfoPtr_TimeScaleNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TimeScaleNode_YouTube");
		NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_UIDrawerNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_UIDrawerNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerNode_Manual");
		NativeFieldInfoPtr_UIDrawerNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawerNode_YouTube");
		NativeFieldInfoPtr_UINode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UINode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_UINode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UINode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_UINode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UINode_Manual");
		NativeFieldInfoPtr_UINode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UINode_YouTube");
		NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UnloadSceneNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_UnloadSceneNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UnloadSceneNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_UnloadSceneNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UnloadSceneNode_Manual");
		NativeFieldInfoPtr_UnloadSceneNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UnloadSceneNode_YouTube");
		NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "WaitNode_CreateNodeMenu_Name");
		NativeFieldInfoPtr_WaitNode_CreateNodeMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "WaitNode_CreateNodeMenu_Order");
		NativeFieldInfoPtr_WaitNode_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "WaitNode_Manual");
		NativeFieldInfoPtr_WaitNode_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "WaitNode_YouTube");
		NativeFieldInfoPtr_Orientation_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Orientation_AddComponentMenu_Path");
		NativeFieldInfoPtr_Orientation_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Orientation_MenuItem_Path");
		NativeFieldInfoPtr_OrientationDetector_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_GameObject_Name");
		NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_OrientationDetector_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_AddComponentMenu_Order");
		NativeFieldInfoPtr_OrientationDetector_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_MenuItem_ItemName");
		NativeFieldInfoPtr_OrientationDetector_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_MenuItem_Priority");
		NativeFieldInfoPtr_OrientationDetector_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_Manual");
		NativeFieldInfoPtr_OrientationDetector_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "OrientationDetector_YouTube");
		NativeFieldInfoPtr_Playmaker_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Playmaker_AddComponentMenu_Path");
		NativeFieldInfoPtr_Playmaker_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Playmaker_MenuItem_Path");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_GameObject_Name");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_AddComponentMenu_Order");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_MenuItem_ItemName");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_MenuItem_Priority");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_Manual");
		NativeFieldInfoPtr_PlaymakerEventDispatcher_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "PlaymakerEventDispatcher_YouTube");
		NativeFieldInfoPtr_Progress_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progress_AddComponentMenu_Path");
		NativeFieldInfoPtr_Progress_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progress_MenuItem_Path");
		NativeFieldInfoPtr_Progressor_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_GameObject_Name");
		NativeFieldInfoPtr_Progressor_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_Progressor_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_AddComponentMenu_Order");
		NativeFieldInfoPtr_Progressor_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_MenuItem_ItemName");
		NativeFieldInfoPtr_Progressor_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_MenuItem_Priority");
		NativeFieldInfoPtr_Progressor_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_Manual");
		NativeFieldInfoPtr_Progressor_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progressor_YouTube");
		NativeFieldInfoPtr_ProgressorGroup_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_GameObject_Name");
		NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_ProgressorGroup_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_AddComponentMenu_Order");
		NativeFieldInfoPtr_ProgressorGroup_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_MenuItem_ItemName");
		NativeFieldInfoPtr_ProgressorGroup_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_MenuItem_Priority");
		NativeFieldInfoPtr_ProgressorGroup_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_Manual");
		NativeFieldInfoPtr_ProgressorGroup_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressorGroup_YouTube");
		NativeFieldInfoPtr_Progress_Targets_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progress_Targets_AddComponentMenu_Path");
		NativeFieldInfoPtr_Progress_Targets_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Progress_Targets_MenuItem_Path");
		NativeFieldInfoPtr_ProgressTargetAnimator_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_GameObject_Name");
		NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_ProgressTargetAnimator_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_AddComponentMenu_Order");
		NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_MenuItem_ItemName");
		NativeFieldInfoPtr_ProgressTargetAnimator_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_MenuItem_Priority");
		NativeFieldInfoPtr_ProgressTargetAnimator_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_Manual");
		NativeFieldInfoPtr_ProgressTargetAnimator_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetAnimator_YouTube");
		NativeFieldInfoPtr_ProgressTargetImage_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_GameObject_Name");
		NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_ProgressTargetImage_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_AddComponentMenu_Order");
		NativeFieldInfoPtr_ProgressTargetImage_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_MenuItem_ItemName");
		NativeFieldInfoPtr_ProgressTargetImage_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_MenuItem_Priority");
		NativeFieldInfoPtr_ProgressTargetImage_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_Manual");
		NativeFieldInfoPtr_ProgressTargetImage_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetImage_YouTube");
		NativeFieldInfoPtr_ProgressTargetText_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_GameObject_Name");
		NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_ProgressTargetText_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_AddComponentMenu_Order");
		NativeFieldInfoPtr_ProgressTargetText_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_MenuItem_ItemName");
		NativeFieldInfoPtr_ProgressTargetText_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_MenuItem_Priority");
		NativeFieldInfoPtr_ProgressTargetText_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_Manual");
		NativeFieldInfoPtr_ProgressTargetText_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetText_YouTube");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_GameObject_Name");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_AddComponentMenu_Order");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_MenuItem_ItemName");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_MenuItem_Priority");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_Manual");
		NativeFieldInfoPtr_ProgressTargetTextMeshPro_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "ProgressTargetTextMeshPro_YouTube");
		NativeFieldInfoPtr_SceneManagement_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneManagement_AddComponentMenu_Path");
		NativeFieldInfoPtr_SceneManagement_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneManagement_MenuItem_Path");
		NativeFieldInfoPtr_SceneLoader_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_GameObject_Name");
		NativeFieldInfoPtr_SceneLoader_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_SceneLoader_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_AddComponentMenu_Order");
		NativeFieldInfoPtr_SceneLoader_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_MenuItem_ItemName");
		NativeFieldInfoPtr_SceneLoader_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_MenuItem_Priority");
		NativeFieldInfoPtr_SceneLoader_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_Manual");
		NativeFieldInfoPtr_SceneLoader_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneLoader_YouTube");
		NativeFieldInfoPtr_SceneDirector_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_GameObject_Name");
		NativeFieldInfoPtr_SceneDirector_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_SceneDirector_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_AddComponentMenu_Order");
		NativeFieldInfoPtr_SceneDirector_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_MenuItem_ItemName");
		NativeFieldInfoPtr_SceneDirector_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_MenuItem_Priority");
		NativeFieldInfoPtr_SceneDirector_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_Manual");
		NativeFieldInfoPtr_SceneDirector_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SceneDirector_YouTube");
		NativeFieldInfoPtr_Soundy_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Soundy_AddComponentMenu_Path");
		NativeFieldInfoPtr_Soundy_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Soundy_MenuItem_Path");
		NativeFieldInfoPtr_SoundyManager_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_GameObject_Name");
		NativeFieldInfoPtr_SoundyManager_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_SoundyManager_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_AddComponentMenu_Order");
		NativeFieldInfoPtr_SoundyManager_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_MenuItem_ItemName");
		NativeFieldInfoPtr_SoundyManager_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_MenuItem_Priority");
		NativeFieldInfoPtr_SoundyManager_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_Manual");
		NativeFieldInfoPtr_SoundyManager_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "SoundyManager_YouTube");
		NativeFieldInfoPtr_Touchy_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Touchy_AddComponentMenu_Path");
		NativeFieldInfoPtr_Touchy_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "Touchy_MenuItem_Path");
		NativeFieldInfoPtr_GestureListener_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_GameObject_Name");
		NativeFieldInfoPtr_GestureListener_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_GestureListener_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_AddComponentMenu_Order");
		NativeFieldInfoPtr_GestureListener_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_MenuItem_ItemName");
		NativeFieldInfoPtr_GestureListener_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_MenuItem_Priority");
		NativeFieldInfoPtr_GestureListener_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_Manual");
		NativeFieldInfoPtr_GestureListener_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "GestureListener_YouTube");
		NativeFieldInfoPtr_TouchDetector_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_GameObject_Name");
		NativeFieldInfoPtr_TouchDetector_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_TouchDetector_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_AddComponentMenu_Order");
		NativeFieldInfoPtr_TouchDetector_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_MenuItem_ItemName");
		NativeFieldInfoPtr_TouchDetector_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_MenuItem_Priority");
		NativeFieldInfoPtr_TouchDetector_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_Manual");
		NativeFieldInfoPtr_TouchDetector_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "TouchDetector_YouTube");
		NativeFieldInfoPtr_UI_AddComponentMenu_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UI_AddComponentMenu_Path");
		NativeFieldInfoPtr_UI_MenuItem_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UI_MenuItem_Path");
		NativeFieldInfoPtr_UIButton_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_GameObject_Name");
		NativeFieldInfoPtr_UIButton_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIButton_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIButton_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_MenuItem_ItemName");
		NativeFieldInfoPtr_UIButton_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_MenuItem_Priority");
		NativeFieldInfoPtr_UIButton_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_Manual");
		NativeFieldInfoPtr_UIButton_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIButton_YouTube");
		NativeFieldInfoPtr_UICanvas_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_GameObject_Name");
		NativeFieldInfoPtr_UICanvas_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UICanvas_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_AddComponentMenu_Order");
		NativeFieldInfoPtr_UICanvas_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_MenuItem_ItemName");
		NativeFieldInfoPtr_UICanvas_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_MenuItem_Priority");
		NativeFieldInfoPtr_UICanvas_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_Manual");
		NativeFieldInfoPtr_UICanvas_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UICanvas_YouTube");
		NativeFieldInfoPtr_UIDrawer_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_GameObject_Name");
		NativeFieldInfoPtr_UIDrawer_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIDrawer_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIDrawer_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_MenuItem_ItemName");
		NativeFieldInfoPtr_UIDrawer_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_MenuItem_Priority");
		NativeFieldInfoPtr_UIDrawer_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_Manual");
		NativeFieldInfoPtr_UIDrawer_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIDrawer_YouTube");
		NativeFieldInfoPtr_UIImage_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_GameObject_Name");
		NativeFieldInfoPtr_UIImage_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIImage_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIImage_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_MenuItem_ItemName");
		NativeFieldInfoPtr_UIImage_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_MenuItem_Priority");
		NativeFieldInfoPtr_UIImage_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_Manual");
		NativeFieldInfoPtr_UIImage_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIImage_YouTube");
		NativeFieldInfoPtr_UIPopup_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_GameObject_Name");
		NativeFieldInfoPtr_UIPopup_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIPopup_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIPopup_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_MenuItem_ItemName");
		NativeFieldInfoPtr_UIPopup_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_MenuItem_Priority");
		NativeFieldInfoPtr_UIPopup_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_Manual");
		NativeFieldInfoPtr_UIPopup_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIPopup_YouTube");
		NativeFieldInfoPtr_UIView_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_GameObject_Name");
		NativeFieldInfoPtr_UIView_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIView_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIView_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_MenuItem_ItemName");
		NativeFieldInfoPtr_UIView_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_MenuItem_Priority");
		NativeFieldInfoPtr_UIView_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_Manual");
		NativeFieldInfoPtr_UIView_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIView_YouTube");
		NativeFieldInfoPtr_UIToggle_GameObject_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_GameObject_Name");
		NativeFieldInfoPtr_UIToggle_AddComponentMenu_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_AddComponentMenu_MenuName");
		NativeFieldInfoPtr_UIToggle_AddComponentMenu_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_AddComponentMenu_Order");
		NativeFieldInfoPtr_UIToggle_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_MenuItem_ItemName");
		NativeFieldInfoPtr_UIToggle_MenuItem_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_MenuItem_Priority");
		NativeFieldInfoPtr_UIToggle_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_Manual");
		NativeFieldInfoPtr_UIToggle_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "UIToggle_YouTube");
		NativeFieldInfoPtr_DoozyWindow_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "DoozyWindow_MenuItem_ItemName");
		NativeFieldInfoPtr_DoozyWindow_OpenShortcut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "DoozyWindow_OpenShortcut");
		NativeFieldInfoPtr_DoozyWindow_MenuItem_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "DoozyWindow_MenuItem_Order");
		NativeFieldInfoPtr_NodyWindow_MenuItem_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "NodyWindow_MenuItem_ItemName");
		NativeFieldInfoPtr_NodyWindow_OpenShortcut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "NodyWindow_OpenShortcut");
		NativeFieldInfoPtr_NodyWindow_MenuItem_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuUtils>.NativeClassPtr, "NodyWindow_MenuItem_Order");
	}

	public MenuUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
