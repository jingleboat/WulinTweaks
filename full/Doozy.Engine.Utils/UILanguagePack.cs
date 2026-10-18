using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.Utils;

[Serializable]
public class UILanguagePack : LanguagePack
{
	private static readonly IntPtr NativeFieldInfoPtr_s_loadedLanguage;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_TargetLanguage;

	private static readonly IntPtr NativeFieldInfoPtr_Action;

	private static readonly IntPtr NativeFieldInfoPtr_Actions;

	private static readonly IntPtr NativeFieldInfoPtr_ActivateLoadedScenesNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_ActiveNode;

	private static readonly IntPtr NativeFieldInfoPtr_ActiveSceneChange;

	private static readonly IntPtr NativeFieldInfoPtr_AddCategory;

	private static readonly IntPtr NativeFieldInfoPtr_AddItem;

	private static readonly IntPtr NativeFieldInfoPtr_AddSounds;

	private static readonly IntPtr NativeFieldInfoPtr_AddSource;

	private static readonly IntPtr NativeFieldInfoPtr_AddSymbolToAllBuildTargetGroups;

	private static readonly IntPtr NativeFieldInfoPtr_AddToPopupQueue;

	private static readonly IntPtr NativeFieldInfoPtr_After;

	private static readonly IntPtr NativeFieldInfoPtr_AllSoundsBeforePlaying;

	private static readonly IntPtr NativeFieldInfoPtr_AllowMultipleClicks;

	private static readonly IntPtr NativeFieldInfoPtr_AllowSceneActivation;

	private static readonly IntPtr NativeFieldInfoPtr_AlternateInput;

	private static readonly IntPtr NativeFieldInfoPtr_AlternateKeyCode;

	private static readonly IntPtr NativeFieldInfoPtr_AlternateVirtualButton;

	private static readonly IntPtr NativeFieldInfoPtr_AnimateAllUIViewsWithSameCategoryAndName;

	private static readonly IntPtr NativeFieldInfoPtr_AnimateValue;

	private static readonly IntPtr NativeFieldInfoPtr_Animation;

	private static readonly IntPtr NativeFieldInfoPtr_AnimationCurve;

	private static readonly IntPtr NativeFieldInfoPtr_AnimationType;

	private static readonly IntPtr NativeFieldInfoPtr_Animator;

	private static readonly IntPtr NativeFieldInfoPtr_AnimatorEvents;

	private static readonly IntPtr NativeFieldInfoPtr_Animators;

	private static readonly IntPtr NativeFieldInfoPtr_AnotherEntryExists;

	private static readonly IntPtr NativeFieldInfoPtr_AnyGameEvent;

	private static readonly IntPtr NativeFieldInfoPtr_AnyGameEventWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_AnyScene;

	private static readonly IntPtr NativeFieldInfoPtr_AnyUIButtonWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_AnyUIDrawerWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_AnyUIViewWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_ApplicationQuit;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureConvertToGraph;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureConvertToSubGraph;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureYouWantToDeleteDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureYouWantToDeletePopupReference;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureYouWantToRemoveCategory;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureYouWantToRemoveTheEntry;

	private static readonly IntPtr NativeFieldInfoPtr_AreYouSureYouWantToResetDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_Arrow;

	private static readonly IntPtr NativeFieldInfoPtr_ArrowComponents;

	private static readonly IntPtr NativeFieldInfoPtr_AtFinish;

	private static readonly IntPtr NativeFieldInfoPtr_AtStart;

	private static readonly IntPtr NativeFieldInfoPtr_AudioClip;

	private static readonly IntPtr NativeFieldInfoPtr_AutoDisableUIInteractionsDescription;

	private static readonly IntPtr NativeFieldInfoPtr_AutoHideAfterShow;

	private static readonly IntPtr NativeFieldInfoPtr_AutoKillIdleControllers;

	private static readonly IntPtr NativeFieldInfoPtr_AutoKillIdleControllersDescription;

	private static readonly IntPtr NativeFieldInfoPtr_AutoResetSequence;

	private static readonly IntPtr NativeFieldInfoPtr_AutoSelectButtonAfterShow;

	private static readonly IntPtr NativeFieldInfoPtr_AutoSort;

	private static readonly IntPtr NativeFieldInfoPtr_AutoStartLoopAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_BackButton;

	private static readonly IntPtr NativeFieldInfoPtr_BackButtonNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Behavior;

	private static readonly IntPtr NativeFieldInfoPtr_BehaviorAtStart;

	private static readonly IntPtr NativeFieldInfoPtr_Behaviors;

	private static readonly IntPtr NativeFieldInfoPtr_BuildIndex;

	private static readonly IntPtr NativeFieldInfoPtr_ButtonCategory;

	private static readonly IntPtr NativeFieldInfoPtr_ButtonLabel;

	private static readonly IntPtr NativeFieldInfoPtr_ButtonName;

	private static readonly IntPtr NativeFieldInfoPtr_Buttons;

	private static readonly IntPtr NativeFieldInfoPtr_Cancel;

	private static readonly IntPtr NativeFieldInfoPtr_CannotAddEmptyEntry;

	private static readonly IntPtr NativeFieldInfoPtr_Canvas;

	private static readonly IntPtr NativeFieldInfoPtr_CanvasName;

	private static readonly IntPtr NativeFieldInfoPtr_Category;

	private static readonly IntPtr NativeFieldInfoPtr_CategoryIsEmpty;

	private static readonly IntPtr NativeFieldInfoPtr_Center;

	private static readonly IntPtr NativeFieldInfoPtr_CenterSelectedNodes;

	private static readonly IntPtr NativeFieldInfoPtr_Chance;

	private static readonly IntPtr NativeFieldInfoPtr_CheckingForIssues;

	private static readonly IntPtr NativeFieldInfoPtr_Clear;

	private static readonly IntPtr NativeFieldInfoPtr_ClearRecentOpenedGraphsList;

	private static readonly IntPtr NativeFieldInfoPtr_ClearRecentOpenedGraphsListDescription;

	private static readonly IntPtr NativeFieldInfoPtr_ClearSearch;

	private static readonly IntPtr NativeFieldInfoPtr_ClickAnywhere;

	private static readonly IntPtr NativeFieldInfoPtr_ClickContainer;

	private static readonly IntPtr NativeFieldInfoPtr_ClickMode;

	private static readonly IntPtr NativeFieldInfoPtr_ClickOverlay;

	private static readonly IntPtr NativeFieldInfoPtr_Close;

	private static readonly IntPtr NativeFieldInfoPtr_CloseDirection;

	private static readonly IntPtr NativeFieldInfoPtr_CloseDrawer;

	private static readonly IntPtr NativeFieldInfoPtr_CloseSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_Closed;

	private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

	private static readonly IntPtr NativeFieldInfoPtr_Compiling;

	private static readonly IntPtr NativeFieldInfoPtr_ComponentDisabled;

	private static readonly IntPtr NativeFieldInfoPtr_Connected;

	private static readonly IntPtr NativeFieldInfoPtr_ConnectionPoint;

	private static readonly IntPtr NativeFieldInfoPtr_Connections;

	private static readonly IntPtr NativeFieldInfoPtr_Container;

	private static readonly IntPtr NativeFieldInfoPtr_ContainerSize;

	private static readonly IntPtr NativeFieldInfoPtr_Continue;

	private static readonly IntPtr NativeFieldInfoPtr_ControllerIdleKillDuration;

	private static readonly IntPtr NativeFieldInfoPtr_ControllerIdleKillDurationDescription;

	private static readonly IntPtr NativeFieldInfoPtr_ControllerName;

	private static readonly IntPtr NativeFieldInfoPtr_ConvertToGraph;

	private static readonly IntPtr NativeFieldInfoPtr_ConvertToSubGraph;

	private static readonly IntPtr NativeFieldInfoPtr_Copy;

	private static readonly IntPtr NativeFieldInfoPtr_Create;

	private static readonly IntPtr NativeFieldInfoPtr_CreateAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_CreateGraph;

	private static readonly IntPtr NativeFieldInfoPtr_CreateNewCategory;

	private static readonly IntPtr NativeFieldInfoPtr_CreateNewGraph;

	private static readonly IntPtr NativeFieldInfoPtr_CreateNewGraphAsSubGraph;

	private static readonly IntPtr NativeFieldInfoPtr_CreateNode;

	private static readonly IntPtr NativeFieldInfoPtr_CreateParentAndCenterPivot;

	private static readonly IntPtr NativeFieldInfoPtr_CreateSubGraph;

	private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeScale;

	private static readonly IntPtr NativeFieldInfoPtr_Custom;

	private static readonly IntPtr NativeFieldInfoPtr_CustomName;

	private static readonly IntPtr NativeFieldInfoPtr_CustomPosition;

	private static readonly IntPtr NativeFieldInfoPtr_CustomResetValue;

	private static readonly IntPtr NativeFieldInfoPtr_CustomSortingLayer;

	private static readonly IntPtr NativeFieldInfoPtr_CustomSortingOrder;

	private static readonly IntPtr NativeFieldInfoPtr_CustomStartPosition;

	private static readonly IntPtr NativeFieldInfoPtr_Cut;

	private static readonly IntPtr NativeFieldInfoPtr_Database;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseAlreadyExists;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseHasBeenReset;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseIsEmpty;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseName;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseRefreshed;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseSorted;

	private static readonly IntPtr NativeFieldInfoPtr_Debug;

	private static readonly IntPtr NativeFieldInfoPtr_DebugMode;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultDotAnimationSpeedDescription;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultValues;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultValuesDescription;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultZoom;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultZoomDescription;

	private static readonly IntPtr NativeFieldInfoPtr_Delete;

	private static readonly IntPtr NativeFieldInfoPtr_DeleteDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_DeletePopupReference;

	private static readonly IntPtr NativeFieldInfoPtr_DeletePreset;

	private static readonly IntPtr NativeFieldInfoPtr_DeletedPopupReference;

	private static readonly IntPtr NativeFieldInfoPtr_Description;

	private static readonly IntPtr NativeFieldInfoPtr_Deselect;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectAnyButton;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectButton;

	private static readonly IntPtr NativeFieldInfoPtr_DeselectButtonAfterClick;

	private static readonly IntPtr NativeFieldInfoPtr_DestroyAfterHide;

	private static readonly IntPtr NativeFieldInfoPtr_DetectGestures;

	private static readonly IntPtr NativeFieldInfoPtr_Direction;

	private static readonly IntPtr NativeFieldInfoPtr_Disable;

	private static readonly IntPtr NativeFieldInfoPtr_DisableButtonInterval;

	private static readonly IntPtr NativeFieldInfoPtr_DisableCanvas;

	private static readonly IntPtr NativeFieldInfoPtr_DisableFunctionality;

	private static readonly IntPtr NativeFieldInfoPtr_DisableGameObject;

	private static readonly IntPtr NativeFieldInfoPtr_DisableInterval;

	private static readonly IntPtr NativeFieldInfoPtr_DisablePlugin;

	private static readonly IntPtr NativeFieldInfoPtr_Disabled;

	private static readonly IntPtr NativeFieldInfoPtr_Disconnect;

	private static readonly IntPtr NativeFieldInfoPtr_DispatchButtonClicks;

	private static readonly IntPtr NativeFieldInfoPtr_DispatchGameEvents;

	private static readonly IntPtr NativeFieldInfoPtr_DisplayTarget;

	private static readonly IntPtr NativeFieldInfoPtr_DontDestroyGameObjectOnLoad;

	private static readonly IntPtr NativeFieldInfoPtr_DotAnimationSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_Down;

	private static readonly IntPtr NativeFieldInfoPtr_DragDrawer;

	private static readonly IntPtr NativeFieldInfoPtr_DrawerName;

	private static readonly IntPtr NativeFieldInfoPtr_DropAudioClipsHere;

	private static readonly IntPtr NativeFieldInfoPtr_Duration;

	private static readonly IntPtr NativeFieldInfoPtr_Ease;

	private static readonly IntPtr NativeFieldInfoPtr_EaseType;

	private static readonly IntPtr NativeFieldInfoPtr_Effect;

	private static readonly IntPtr NativeFieldInfoPtr_Elasticity;

	private static readonly IntPtr NativeFieldInfoPtr_Email;

	private static readonly IntPtr NativeFieldInfoPtr_Empty;

	private static readonly IntPtr NativeFieldInfoPtr_Enable;

	private static readonly IntPtr NativeFieldInfoPtr_EnableFunctionality;

	private static readonly IntPtr NativeFieldInfoPtr_EnablePlugin;

	private static readonly IntPtr NativeFieldInfoPtr_EnableSupportForMasterAudio;

	private static readonly IntPtr NativeFieldInfoPtr_Enabled;

	private static readonly IntPtr NativeFieldInfoPtr_EnterCategoryName;

	private static readonly IntPtr NativeFieldInfoPtr_EnterDatabaseName;

	private static readonly IntPtr NativeFieldInfoPtr_EnterGameEventToListenFor;

	private static readonly IntPtr NativeFieldInfoPtr_EnterNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Error;

	private static readonly IntPtr NativeFieldInfoPtr_Event;

	private static readonly IntPtr NativeFieldInfoPtr_EveryLongTapWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_EverySwipeWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_EveryTapWillTriggerThisListener;

	private static readonly IntPtr NativeFieldInfoPtr_ExitNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Fade;

	private static readonly IntPtr NativeFieldInfoPtr_FadeBy;

	private static readonly IntPtr NativeFieldInfoPtr_FadeFrom;

	private static readonly IntPtr NativeFieldInfoPtr_FadeOutContainer;

	private static readonly IntPtr NativeFieldInfoPtr_FadeTo;

	private static readonly IntPtr NativeFieldInfoPtr_FixedSize;

	private static readonly IntPtr NativeFieldInfoPtr_FsmName;

	private static readonly IntPtr NativeFieldInfoPtr_Functionality;

	private static readonly IntPtr NativeFieldInfoPtr_FunctionalityDescription;

	private static readonly IntPtr NativeFieldInfoPtr_GameEvent;

	private static readonly IntPtr NativeFieldInfoPtr_GameEvents;

	private static readonly IntPtr NativeFieldInfoPtr_GameObject;

	private static readonly IntPtr NativeFieldInfoPtr_GeneralSettings;

	private static readonly IntPtr NativeFieldInfoPtr_GestureType;

	private static readonly IntPtr NativeFieldInfoPtr_GetInTouch;

	private static readonly IntPtr NativeFieldInfoPtr_GetPosition;

	private static readonly IntPtr NativeFieldInfoPtr_GetSceneBy;

	private static readonly IntPtr NativeFieldInfoPtr_GlobalListener;

	private static readonly IntPtr NativeFieldInfoPtr_GoToEnterNode;

	private static readonly IntPtr NativeFieldInfoPtr_GoToExitNode;

	private static readonly IntPtr NativeFieldInfoPtr_GoToStartNode;

	private static readonly IntPtr NativeFieldInfoPtr_Graph;

	private static readonly IntPtr NativeFieldInfoPtr_GraphHasNoNodes;

	private static readonly IntPtr NativeFieldInfoPtr_GraphId;

	private static readonly IntPtr NativeFieldInfoPtr_GraphModel;

	private static readonly IntPtr NativeFieldInfoPtr_GraphicRaycaster;

	private static readonly IntPtr NativeFieldInfoPtr_HasBeenAddedToClipboard;

	private static readonly IntPtr NativeFieldInfoPtr_Height;

	private static readonly IntPtr NativeFieldInfoPtr_Help;

	private static readonly IntPtr NativeFieldInfoPtr_HelpResources;

	private static readonly IntPtr NativeFieldInfoPtr_Hide;

	private static readonly IntPtr NativeFieldInfoPtr_HideAnimationWillNotWork;

	private static readonly IntPtr NativeFieldInfoPtr_HidePopup;

	private static readonly IntPtr NativeFieldInfoPtr_HideProgressor;

	private static readonly IntPtr NativeFieldInfoPtr_HideUIPopupBy;

	private static readonly IntPtr NativeFieldInfoPtr_HideView;

	private static readonly IntPtr NativeFieldInfoPtr_HideViews;

	private static readonly IntPtr NativeFieldInfoPtr_HowToUse;

	private static readonly IntPtr NativeFieldInfoPtr_IdleCheckInterval;

	private static readonly IntPtr NativeFieldInfoPtr_IdleCheckIntervalDescription;

	private static readonly IntPtr NativeFieldInfoPtr_IgnoreListenerPause;

	private static readonly IntPtr NativeFieldInfoPtr_IgnoreTimescale;

	private static readonly IntPtr NativeFieldInfoPtr_Image;

	private static readonly IntPtr NativeFieldInfoPtr_Images;

	private static readonly IntPtr NativeFieldInfoPtr_IncludeAudioClipNamesInSearch;

	private static readonly IntPtr NativeFieldInfoPtr_Info;

	private static readonly IntPtr NativeFieldInfoPtr_InputConnected;

	private static readonly IntPtr NativeFieldInfoPtr_InputConnections;

	private static readonly IntPtr NativeFieldInfoPtr_InputMode;

	private static readonly IntPtr NativeFieldInfoPtr_InputNotConnected;

	private static readonly IntPtr NativeFieldInfoPtr_Installed;

	private static readonly IntPtr NativeFieldInfoPtr_InstantAction;

	private static readonly IntPtr NativeFieldInfoPtr_InstantAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_Integrations;

	private static readonly IntPtr NativeFieldInfoPtr_IsNotPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_Key;

	private static readonly IntPtr NativeFieldInfoPtr_KeyCode;

	private static readonly IntPtr NativeFieldInfoPtr_Label;

	private static readonly IntPtr NativeFieldInfoPtr_Labels;

	private static readonly IntPtr NativeFieldInfoPtr_Language;

	private static readonly IntPtr NativeFieldInfoPtr_LastModified;

	private static readonly IntPtr NativeFieldInfoPtr_Left;

	private static readonly IntPtr NativeFieldInfoPtr_ListIsEmpty;

	private static readonly IntPtr NativeFieldInfoPtr_ListenForAllGameEvents;

	private static readonly IntPtr NativeFieldInfoPtr_ListenForAllUIButtons;

	private static readonly IntPtr NativeFieldInfoPtr_ListenForAllUIDrawers;

	private static readonly IntPtr NativeFieldInfoPtr_ListenForAllUIViews;

	private static readonly IntPtr NativeFieldInfoPtr_ListeningForGameEvent;

	private static readonly IntPtr NativeFieldInfoPtr_Load;

	private static readonly IntPtr NativeFieldInfoPtr_LoadBehavior;

	private static readonly IntPtr NativeFieldInfoPtr_LoadPreset;

	private static readonly IntPtr NativeFieldInfoPtr_LoadSceneBy;

	private static readonly IntPtr NativeFieldInfoPtr_LoadSceneMode;

	private static readonly IntPtr NativeFieldInfoPtr_LoadSceneNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_LoadSelectedPresetAtRuntime;

	private static readonly IntPtr NativeFieldInfoPtr_LoadedGraph;

	private static readonly IntPtr NativeFieldInfoPtr_LongTapDuration;

	private static readonly IntPtr NativeFieldInfoPtr_LongTapDurationDescription;

	private static readonly IntPtr NativeFieldInfoPtr_LoopSound;

	private static readonly IntPtr NativeFieldInfoPtr_LoopType;

	private static readonly IntPtr NativeFieldInfoPtr_LoopView;

	private static readonly IntPtr NativeFieldInfoPtr_Manual;

	private static readonly IntPtr NativeFieldInfoPtr_Max;

	private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

	private static readonly IntPtr NativeFieldInfoPtr_Min;

	private static readonly IntPtr NativeFieldInfoPtr_MinValue;

	private static readonly IntPtr NativeFieldInfoPtr_MinimumNumberOfControllers;

	private static readonly IntPtr NativeFieldInfoPtr_MinimumNumberOfControllersDescription;

	private static readonly IntPtr NativeFieldInfoPtr_MinimumSize;

	private static readonly IntPtr NativeFieldInfoPtr_MissingPrefabReference;

	private static readonly IntPtr NativeFieldInfoPtr_Move;

	private static readonly IntPtr NativeFieldInfoPtr_MoveBy;

	private static readonly IntPtr NativeFieldInfoPtr_MoveDown;

	private static readonly IntPtr NativeFieldInfoPtr_MoveFrom;

	private static readonly IntPtr NativeFieldInfoPtr_MoveTo;

	private static readonly IntPtr NativeFieldInfoPtr_MoveUp;

	private static readonly IntPtr NativeFieldInfoPtr_Multiplier;

	private static readonly IntPtr NativeFieldInfoPtr_MuteAllSounds;

	private static readonly IntPtr NativeFieldInfoPtr_Name;

	private static readonly IntPtr NativeFieldInfoPtr_New;

	private static readonly IntPtr NativeFieldInfoPtr_NewCategory;

	private static readonly IntPtr NativeFieldInfoPtr_NewCategoryNameCannotBeEmpty;

	private static readonly IntPtr NativeFieldInfoPtr_NewDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_NewPopup;

	private static readonly IntPtr NativeFieldInfoPtr_NewPreset;

	private static readonly IntPtr NativeFieldInfoPtr_NewPresetNameCannotBeEmpty;

	private static readonly IntPtr NativeFieldInfoPtr_NewSoundDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_News;

	private static readonly IntPtr NativeFieldInfoPtr_No;

	private static readonly IntPtr NativeFieldInfoPtr_NoAnimationEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_NoAnimatorFound;

	private static readonly IntPtr NativeFieldInfoPtr_NoGraphReferenced;

	private static readonly IntPtr NativeFieldInfoPtr_NoSound;

	private static readonly IntPtr NativeFieldInfoPtr_NoSoundsHaveBeenAdded;

	private static readonly IntPtr NativeFieldInfoPtr_Node;

	private static readonly IntPtr NativeFieldInfoPtr_NodeId;

	private static readonly IntPtr NativeFieldInfoPtr_NodeName;

	private static readonly IntPtr NativeFieldInfoPtr_NodeNameTooltip;

	private static readonly IntPtr NativeFieldInfoPtr_NodeState;

	private static readonly IntPtr NativeFieldInfoPtr_NodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_Nodes;

	private static readonly IntPtr NativeFieldInfoPtr_NodySettings;

	private static readonly IntPtr NativeFieldInfoPtr_NormalLoopAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_NotConnected;

	private static readonly IntPtr NativeFieldInfoPtr_NotInstalled;

	private static readonly IntPtr NativeFieldInfoPtr_NoteworthyInformation;

	private static readonly IntPtr NativeFieldInfoPtr_NumberOfLoops;

	private static readonly IntPtr NativeFieldInfoPtr_Ok;

	private static readonly IntPtr NativeFieldInfoPtr_OnAnimationFinished;

	private static readonly IntPtr NativeFieldInfoPtr_OnAnimationStart;

	private static readonly IntPtr NativeFieldInfoPtr_OnClick;

	private static readonly IntPtr NativeFieldInfoPtr_OnDeselected;

	private static readonly IntPtr NativeFieldInfoPtr_OnDoubleClick;

	private static readonly IntPtr NativeFieldInfoPtr_OnEnter;

	private static readonly IntPtr NativeFieldInfoPtr_OnEnterNode;

	private static readonly IntPtr NativeFieldInfoPtr_OnExit;

	private static readonly IntPtr NativeFieldInfoPtr_OnExitNode;

	private static readonly IntPtr NativeFieldInfoPtr_OnFixedUpdate;

	private static readonly IntPtr NativeFieldInfoPtr_OnLateUpdate;

	private static readonly IntPtr NativeFieldInfoPtr_OnLoadScene;

	private static readonly IntPtr NativeFieldInfoPtr_OnLongClick;

	private static readonly IntPtr NativeFieldInfoPtr_OnNodeFixedUpdate;

	private static readonly IntPtr NativeFieldInfoPtr_OnNodeLateUpdate;

	private static readonly IntPtr NativeFieldInfoPtr_OnNodeUpdate;

	private static readonly IntPtr NativeFieldInfoPtr_OnPointerDown;

	private static readonly IntPtr NativeFieldInfoPtr_OnPointerEnter;

	private static readonly IntPtr NativeFieldInfoPtr_OnPointerExit;

	private static readonly IntPtr NativeFieldInfoPtr_OnPointerUp;

	private static readonly IntPtr NativeFieldInfoPtr_OnSceneLoaded;

	private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

	private static readonly IntPtr NativeFieldInfoPtr_OnTrigger;

	private static readonly IntPtr NativeFieldInfoPtr_OnUpdate;

	private static readonly IntPtr NativeFieldInfoPtr_Open;

	private static readonly IntPtr NativeFieldInfoPtr_OpenControlPanel;

	private static readonly IntPtr NativeFieldInfoPtr_OpenDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_OpenDrawer;

	private static readonly IntPtr NativeFieldInfoPtr_OpenGraph;

	private static readonly IntPtr NativeFieldInfoPtr_OpenNody;

	private static readonly IntPtr NativeFieldInfoPtr_OpenSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_OpenSubGraph;

	private static readonly IntPtr NativeFieldInfoPtr_Opened;

	private static readonly IntPtr NativeFieldInfoPtr_OpenedPosition;

	private static readonly IntPtr NativeFieldInfoPtr_OperationCannotBeUndone;

	private static readonly IntPtr NativeFieldInfoPtr_OrientationDetectorDescription;

	private static readonly IntPtr NativeFieldInfoPtr_OtherReferences;

	private static readonly IntPtr NativeFieldInfoPtr_OutputAudioMixerGroup;

	private static readonly IntPtr NativeFieldInfoPtr_OutputConnected;

	private static readonly IntPtr NativeFieldInfoPtr_OutputConnections;

	private static readonly IntPtr NativeFieldInfoPtr_OutputMixerGroup;

	private static readonly IntPtr NativeFieldInfoPtr_OutputNotConnected;

	private static readonly IntPtr NativeFieldInfoPtr_Overlay;

	private static readonly IntPtr NativeFieldInfoPtr_Override;

	private static readonly IntPtr NativeFieldInfoPtr_OverrideColor;

	private static readonly IntPtr NativeFieldInfoPtr_Overview;

	private static readonly IntPtr NativeFieldInfoPtr_OverviewZoom;

	private static readonly IntPtr NativeFieldInfoPtr_ParameterName;

	private static readonly IntPtr NativeFieldInfoPtr_ParameterType;

	private static readonly IntPtr NativeFieldInfoPtr_ParticleSystem;

	private static readonly IntPtr NativeFieldInfoPtr_Paste;

	private static readonly IntPtr NativeFieldInfoPtr_PauseAllSounds;

	private static readonly IntPtr NativeFieldInfoPtr_PercentageOfScreenZeroToOne;

	private static readonly IntPtr NativeFieldInfoPtr_PitchSemitones;

	private static readonly IntPtr NativeFieldInfoPtr_Play;

	private static readonly IntPtr NativeFieldInfoPtr_PlayAnimationInZeroSeconds;

	private static readonly IntPtr NativeFieldInfoPtr_PlayMode;

	private static readonly IntPtr NativeFieldInfoPtr_PlaySound;

	private static readonly IntPtr NativeFieldInfoPtr_PleaseEnterNewName;

	private static readonly IntPtr NativeFieldInfoPtr_PopupName;

	private static readonly IntPtr NativeFieldInfoPtr_PopupPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_Portal;

	private static readonly IntPtr NativeFieldInfoPtr_PortalNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Prefix;

	private static readonly IntPtr NativeFieldInfoPtr_PresetCategory;

	private static readonly IntPtr NativeFieldInfoPtr_PresetName;

	private static readonly IntPtr NativeFieldInfoPtr_PreviewAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_Progress;

	private static readonly IntPtr NativeFieldInfoPtr_ProgressTargets;

	private static readonly IntPtr NativeFieldInfoPtr_Progressor;

	private static readonly IntPtr NativeFieldInfoPtr_Progressors;

	private static readonly IntPtr NativeFieldInfoPtr_PunchBy;

	private static readonly IntPtr NativeFieldInfoPtr_RandomDuration;

	private static readonly IntPtr NativeFieldInfoPtr_RandomNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Recent;

	private static readonly IntPtr NativeFieldInfoPtr_Refresh;

	private static readonly IntPtr NativeFieldInfoPtr_RefreshDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_RegisterInterval;

	private static readonly IntPtr NativeFieldInfoPtr_Remove;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveCategory;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveDuplicates;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveEmptyCategories;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveEmptyEntries;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveItem;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveNullEntries;

	private static readonly IntPtr NativeFieldInfoPtr_RemoveSymbolFromAllBuildTargetGroups;

	private static readonly IntPtr NativeFieldInfoPtr_RemovedDuplicateEntries;

	private static readonly IntPtr NativeFieldInfoPtr_RemovedEntriesWithNoName;

	private static readonly IntPtr NativeFieldInfoPtr_RemovedEntriesWithNullPrefabs;

	private static readonly IntPtr NativeFieldInfoPtr_RemovedEntry;

	private static readonly IntPtr NativeFieldInfoPtr_RemovedNullEntries;

	private static readonly IntPtr NativeFieldInfoPtr_Rename;

	private static readonly IntPtr NativeFieldInfoPtr_RenameCategory;

	private static readonly IntPtr NativeFieldInfoPtr_RenameCategoryDialogMessage;

	private static readonly IntPtr NativeFieldInfoPtr_RenameGameObjectTo;

	private static readonly IntPtr NativeFieldInfoPtr_RenameNodeTo;

	private static readonly IntPtr NativeFieldInfoPtr_RenamePrefix;

	private static readonly IntPtr NativeFieldInfoPtr_RenameSoundDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_RenameSoundDatabaseDialogMessage;

	private static readonly IntPtr NativeFieldInfoPtr_RenameSuffix;

	private static readonly IntPtr NativeFieldInfoPtr_RenameTo;

	private static readonly IntPtr NativeFieldInfoPtr_Reset;

	private static readonly IntPtr NativeFieldInfoPtr_ResetAnimationSettings;

	private static readonly IntPtr NativeFieldInfoPtr_ResetClosedPosition;

	private static readonly IntPtr NativeFieldInfoPtr_ResetDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_ResetOpenedPosition;

	private static readonly IntPtr NativeFieldInfoPtr_ResetPosition;

	private static readonly IntPtr NativeFieldInfoPtr_ResetRoot;

	private static readonly IntPtr NativeFieldInfoPtr_ResetTrigger;

	private static readonly IntPtr NativeFieldInfoPtr_ResetValue;

	private static readonly IntPtr NativeFieldInfoPtr_ReversedProgress;

	private static readonly IntPtr NativeFieldInfoPtr_Right;

	private static readonly IntPtr NativeFieldInfoPtr_Rotate;

	private static readonly IntPtr NativeFieldInfoPtr_RotateBy;

	private static readonly IntPtr NativeFieldInfoPtr_RotateFrom;

	private static readonly IntPtr NativeFieldInfoPtr_RotateMode;

	private static readonly IntPtr NativeFieldInfoPtr_RotateTo;

	private static readonly IntPtr NativeFieldInfoPtr_RuntimeOptions;

	private static readonly IntPtr NativeFieldInfoPtr_RuntimePreset;

	private static readonly IntPtr NativeFieldInfoPtr_Save;

	private static readonly IntPtr NativeFieldInfoPtr_SaveAs;

	private static readonly IntPtr NativeFieldInfoPtr_SavePreset;

	private static readonly IntPtr NativeFieldInfoPtr_Scale;

	private static readonly IntPtr NativeFieldInfoPtr_ScaleBy;

	private static readonly IntPtr NativeFieldInfoPtr_ScaleFrom;

	private static readonly IntPtr NativeFieldInfoPtr_ScaleTo;

	private static readonly IntPtr NativeFieldInfoPtr_Scene;

	private static readonly IntPtr NativeFieldInfoPtr_SceneActivationDelay;

	private static readonly IntPtr NativeFieldInfoPtr_SceneBuildIndex;

	private static readonly IntPtr NativeFieldInfoPtr_SceneLoad;

	private static readonly IntPtr NativeFieldInfoPtr_SceneName;

	private static readonly IntPtr NativeFieldInfoPtr_SceneUnload;

	private static readonly IntPtr NativeFieldInfoPtr_ScriptingDefineSymbol;

	private static readonly IntPtr NativeFieldInfoPtr_Search;

	private static readonly IntPtr NativeFieldInfoPtr_SearchForCategories;

	private static readonly IntPtr NativeFieldInfoPtr_SearchForDatabases;

	private static readonly IntPtr NativeFieldInfoPtr_SearchForUIPopupLinks;

	private static readonly IntPtr NativeFieldInfoPtr_Seconds;

	private static readonly IntPtr NativeFieldInfoPtr_SecondsDelay;

	private static readonly IntPtr NativeFieldInfoPtr_Select;

	private static readonly IntPtr NativeFieldInfoPtr_SelectButton;

	private static readonly IntPtr NativeFieldInfoPtr_SelectSwipeDirection;

	private static readonly IntPtr NativeFieldInfoPtr_SelectedLoopAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_Send;

	private static readonly IntPtr NativeFieldInfoPtr_SendGameEvent;

	private static readonly IntPtr NativeFieldInfoPtr_SendGameEvents;

	private static readonly IntPtr NativeFieldInfoPtr_SetActiveNode;

	private static readonly IntPtr NativeFieldInfoPtr_SetAsSoundName;

	private static readonly IntPtr NativeFieldInfoPtr_SetBoolValueTo;

	private static readonly IntPtr NativeFieldInfoPtr_SetFloatValueTo;

	private static readonly IntPtr NativeFieldInfoPtr_SetIntValueTo;

	private static readonly IntPtr NativeFieldInfoPtr_SetPosition;

	private static readonly IntPtr NativeFieldInfoPtr_SetTargetGameObject;

	private static readonly IntPtr NativeFieldInfoPtr_SetUIButtonToListenFor;

	private static readonly IntPtr NativeFieldInfoPtr_SetUIDrawerToListenFor;

	private static readonly IntPtr NativeFieldInfoPtr_SetUIViewToListenFor;

	private static readonly IntPtr NativeFieldInfoPtr_SetValue;

	private static readonly IntPtr NativeFieldInfoPtr_Settings;

	private static readonly IntPtr NativeFieldInfoPtr_Show;

	private static readonly IntPtr NativeFieldInfoPtr_ShowAnimationWillNotWork;

	private static readonly IntPtr NativeFieldInfoPtr_ShowCurveModifier;

	private static readonly IntPtr NativeFieldInfoPtr_ShowPopup;

	private static readonly IntPtr NativeFieldInfoPtr_ShowProgressor;

	private static readonly IntPtr NativeFieldInfoPtr_ShowView;

	private static readonly IntPtr NativeFieldInfoPtr_ShowViews;

	private static readonly IntPtr NativeFieldInfoPtr_Simulate;

	private static readonly IntPtr NativeFieldInfoPtr_SocialLinks;

	private static readonly IntPtr NativeFieldInfoPtr_Socket;

	private static readonly IntPtr NativeFieldInfoPtr_Sort;

	private static readonly IntPtr NativeFieldInfoPtr_SortDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_SortingSteps;

	private static readonly IntPtr NativeFieldInfoPtr_Sound;

	private static readonly IntPtr NativeFieldInfoPtr_SoundAction;

	private static readonly IntPtr NativeFieldInfoPtr_SoundDatabases;

	private static readonly IntPtr NativeFieldInfoPtr_SoundName;

	private static readonly IntPtr NativeFieldInfoPtr_SoundNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_SoundSource;

	private static readonly IntPtr NativeFieldInfoPtr_Sounds;

	private static readonly IntPtr NativeFieldInfoPtr_Soundy;

	private static readonly IntPtr NativeFieldInfoPtr_SoundyDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_SoundySettings;

	private static readonly IntPtr NativeFieldInfoPtr_SourceName;

	private static readonly IntPtr NativeFieldInfoPtr_Sources;

	private static readonly IntPtr NativeFieldInfoPtr_SpatialBlend;

	private static readonly IntPtr NativeFieldInfoPtr_Speed;

	private static readonly IntPtr NativeFieldInfoPtr_StartDelay;

	private static readonly IntPtr NativeFieldInfoPtr_StartNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_StopAllSounds;

	private static readonly IntPtr NativeFieldInfoPtr_StopAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_StopBehavior;

	private static readonly IntPtr NativeFieldInfoPtr_StopSound;

	private static readonly IntPtr NativeFieldInfoPtr_SubGraph;

	private static readonly IntPtr NativeFieldInfoPtr_SubGraphNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Suffix;

	private static readonly IntPtr NativeFieldInfoPtr_SupportEmail;

	private static readonly IntPtr NativeFieldInfoPtr_SwipeDirection;

	private static readonly IntPtr NativeFieldInfoPtr_SwipeLength;

	private static readonly IntPtr NativeFieldInfoPtr_SwipeLengthDescription;

	private static readonly IntPtr NativeFieldInfoPtr_SwitchBackNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Target;

	private static readonly IntPtr NativeFieldInfoPtr_TargetAnimator;

	private static readonly IntPtr NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnAnimatorController;

	private static readonly IntPtr NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnyParameters;

	private static readonly IntPtr NativeFieldInfoPtr_TargetCanvas;

	private static readonly IntPtr NativeFieldInfoPtr_TargetFsm;

	private static readonly IntPtr NativeFieldInfoPtr_TargetGameObject;

	private static readonly IntPtr NativeFieldInfoPtr_TargetLabel;

	private static readonly IntPtr NativeFieldInfoPtr_TargetOrientation;

	private static readonly IntPtr NativeFieldInfoPtr_TargetProgress;

	private static readonly IntPtr NativeFieldInfoPtr_TargetTimeScale;

	private static readonly IntPtr NativeFieldInfoPtr_TargetValue;

	private static readonly IntPtr NativeFieldInfoPtr_TargetVariable;

	private static readonly IntPtr NativeFieldInfoPtr_Text;

	private static readonly IntPtr NativeFieldInfoPtr_TextLabel;

	private static readonly IntPtr NativeFieldInfoPtr_TextMeshPro;

	private static readonly IntPtr NativeFieldInfoPtr_TextMeshProLabel;

	private static readonly IntPtr NativeFieldInfoPtr_Time;

	private static readonly IntPtr NativeFieldInfoPtr_TimeScaleNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleComponentBehaviors;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleLabel;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleOFF;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleON;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleProgressor;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleSettings;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleSupportForThirdPartyPlugins;

	private static readonly IntPtr NativeFieldInfoPtr_TouchySettings;

	private static readonly IntPtr NativeFieldInfoPtr_TriggerAction;

	private static readonly IntPtr NativeFieldInfoPtr_TriggerEventsAfterAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_TriggerName;

	private static readonly IntPtr NativeFieldInfoPtr_UIDrawerNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_UINodeNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_UIPopupDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_UnityEvent;

	private static readonly IntPtr NativeFieldInfoPtr_UnityEvents;

	private static readonly IntPtr NativeFieldInfoPtr_UnloadSceneNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_UnmuteAllSounds;

	private static readonly IntPtr NativeFieldInfoPtr_UnpauseAllSounds;

	private static readonly IntPtr NativeFieldInfoPtr_Up;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateContainer;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateEffect;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateOnHide;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateOnShow;

	private static readonly IntPtr NativeFieldInfoPtr_UpdatePopupName;

	private static readonly IntPtr NativeFieldInfoPtr_UpdatePopupPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateValue;

	private static readonly IntPtr NativeFieldInfoPtr_UseBackButtonDescription;

	private static readonly IntPtr NativeFieldInfoPtr_UseCustomFromAndTo;

	private static readonly IntPtr NativeFieldInfoPtr_UseMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_UsefulLinks;

	private static readonly IntPtr NativeFieldInfoPtr_Value;

	private static readonly IntPtr NativeFieldInfoPtr_Version;

	private static readonly IntPtr NativeFieldInfoPtr_Vibrato;

	private static readonly IntPtr NativeFieldInfoPtr_ViewCategory;

	private static readonly IntPtr NativeFieldInfoPtr_ViewName;

	private static readonly IntPtr NativeFieldInfoPtr_VirtualButton;

	private static readonly IntPtr NativeFieldInfoPtr_VolumeDb;

	private static readonly IntPtr NativeFieldInfoPtr_WaitFor;

	private static readonly IntPtr NativeFieldInfoPtr_WaitForAnimationToFinish;

	private static readonly IntPtr NativeFieldInfoPtr_WaitForSceneToUnload;

	private static readonly IntPtr NativeFieldInfoPtr_WaitNodeName;

	private static readonly IntPtr NativeFieldInfoPtr_Warning;

	private static readonly IntPtr NativeFieldInfoPtr_Weight;

	private static readonly IntPtr NativeFieldInfoPtr_WhenClosed;

	private static readonly IntPtr NativeFieldInfoPtr_WhenUIDrawerIsClosed;

	private static readonly IntPtr NativeFieldInfoPtr_WhenUIPopupIsHiddenDisable;

	private static readonly IntPtr NativeFieldInfoPtr_WhenUIViewIsHiddenDisable;

	private static readonly IntPtr NativeFieldInfoPtr_WholeNumbers;

	private static readonly IntPtr NativeFieldInfoPtr_Width;

	private static readonly IntPtr NativeFieldInfoPtr_X;

	private static readonly IntPtr NativeFieldInfoPtr_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Yes;

	private static readonly IntPtr NativeFieldInfoPtr_YouAreResponsibleToUpdateYourCode;

	private static readonly IntPtr NativeFieldInfoPtr_YouCanOnlyAddPrefabsToDatabase;

	private static readonly IntPtr NativeFieldInfoPtr_YouTube;

	private static readonly IntPtr NativeFieldInfoPtr_MissingTargetFsmMessage;

	private static readonly IntPtr NativeFieldInfoPtr_SelectListenerToActivateMessage;

	private static readonly IntPtr NativeFieldInfoPtr_HowToUsePlaymakerEventDispatcherMessage;

	private static readonly IntPtr NativeFieldInfoPtr_MissingDrawerNameTitle;

	private static readonly IntPtr NativeFieldInfoPtr_MissingDrawerNameMessage;

	private static readonly IntPtr NativeFieldInfoPtr_MissingGameEventTitle;

	private static readonly IntPtr NativeFieldInfoPtr_MissingGameEventMessage;

	private static readonly IntPtr NativeFieldInfoPtr_MissingSceneNameTitle;

	private static readonly IntPtr NativeFieldInfoPtr_MissingSceneNameMessage;

	private static readonly IntPtr NativeFieldInfoPtr_WrongSceneBuildIndexTitle;

	private static readonly IntPtr NativeFieldInfoPtr_WrongSceneBuildIndexMessage;

	private static readonly IntPtr NativeFieldInfoPtr_DoubleClickNodeToOpenSubGraphMessage;

	private static readonly IntPtr NativeFieldInfoPtr_DuplicateNodeMessage;

	private static readonly IntPtr NativeFieldInfoPtr_DuplicateNodeTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NoGraphReferencedMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NoGraphReferencedTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NoSourceConnectedMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NoSourceConnectedTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NoSubGraphReferencedMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NoSubGraphReferencedTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NoTargetConnectedMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NoTargetConnectedTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NotConnectedMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NotConnectedTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NotListeningForAnyGameEventMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NotListeningForAnyGameEventTitle;

	private static readonly IntPtr NativeFieldInfoPtr_NotSendingAnyGameEventMessage;

	private static readonly IntPtr NativeFieldInfoPtr_NotSendingAnyGameEventTitle;

	private static readonly IntPtr NativeFieldInfoPtr_ProgressTargetAnimatorParameterInfo;

	private static readonly IntPtr NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphMessage;

	private static readonly IntPtr NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphTitle;

	private static readonly IntPtr NativeFieldInfoPtr_ReferencedGraphIsSubGraphMessage;

	private static readonly IntPtr NativeFieldInfoPtr_ReferencedGraphIsSubGraphTitle;

	private static readonly IntPtr NativeFieldInfoPtr_SomeProgressTargetsGetUpdatedOnlyInPlayMode;

	private static readonly IntPtr NativeFieldInfoPtr_SupportForMasterAudioNotEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_SupportForPlaymakerNotEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_SupportForTextMeshProNotEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_ThisClassShouldBeExtended;

	private static readonly IntPtr NativeFieldInfoPtr_UnnamedNodeMessage;

	private static readonly IntPtr NativeFieldInfoPtr_UnnamedNodeTitle;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UILanguagePack_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Language s_loadedLanguage
	{
		get
		{
			Unsafe.SkipInit(out Language result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_loadedLanguage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_loadedLanguage, (void*)(&language));
		}
	}

	public unsafe static UILanguagePack s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UILanguagePack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uILanguagePack));
		}
	}

	public unsafe Language TargetLanguage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetLanguage);
			return *(Language*)num;
		}
		set
		{
			*(Language*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetLanguage)) = language;
		}
	}

	public unsafe string Action
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Action);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Action)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Actions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Actions);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Actions)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ActivateLoadedScenesNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActivateLoadedScenesNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActivateLoadedScenesNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ActiveNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ActiveSceneChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveSceneChange);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveSceneChange)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AddCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AddItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddItem);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AddSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AddSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSource);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AddSymbolToAllBuildTargetGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSymbolToAllBuildTargetGroups);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSymbolToAllBuildTargetGroups)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AddToPopupQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddToPopupQueue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddToPopupQueue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string After
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_After);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_After)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AllSoundsBeforePlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllSoundsBeforePlaying);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllSoundsBeforePlaying)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AllowMultipleClicks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowMultipleClicks);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowMultipleClicks)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AllowSceneActivation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowSceneActivation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowSceneActivation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AlternateInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternateInput);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternateInput)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AlternateKeyCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternateKeyCode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternateKeyCode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AlternateVirtualButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternateVirtualButton);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternateVirtualButton)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnimateAllUIViewsWithSameCategoryAndName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimateAllUIViewsWithSameCategoryAndName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimateAllUIViewsWithSameCategoryAndName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnimateValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimateValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimateValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Animation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnimationCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationCurve);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationCurve)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnimationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Animator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animator);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animator)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnimatorEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimatorEvents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimatorEvents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Animators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animators);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animators)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnotherEntryExists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnotherEntryExists);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnotherEntryExists)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnyGameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyGameEvent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyGameEvent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnyGameEventWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyGameEventWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyGameEventWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnyScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyScene);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyScene)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnyUIButtonWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyUIButtonWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyUIButtonWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnyUIDrawerWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyUIDrawerWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyUIDrawerWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AnyUIViewWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyUIViewWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnyUIViewWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ApplicationQuit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ApplicationQuit);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ApplicationQuit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureConvertToGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureConvertToGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureConvertToGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureConvertToSubGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureConvertToSubGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureConvertToSubGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureYouWantToDeleteDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToDeleteDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToDeleteDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureYouWantToDeletePopupReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToDeletePopupReference);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToDeletePopupReference)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureYouWantToRemoveCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToRemoveCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToRemoveCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureYouWantToRemoveTheEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToRemoveTheEntry);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToRemoveTheEntry)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AreYouSureYouWantToResetDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToResetDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreYouSureYouWantToResetDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Arrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Arrow);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Arrow)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ArrowComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ArrowComponents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ArrowComponents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AtFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtFinish);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtFinish)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AtStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtStart);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtStart)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AudioClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioClip);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioClip)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoDisableUIInteractionsDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoDisableUIInteractionsDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoDisableUIInteractionsDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoHideAfterShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoHideAfterShow);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoHideAfterShow)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoKillIdleControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoKillIdleControllers);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoKillIdleControllers)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoKillIdleControllersDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoKillIdleControllersDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoKillIdleControllersDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoResetSequence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoResetSequence);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoResetSequence)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoSelectButtonAfterShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSelectButtonAfterShow);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSelectButtonAfterShow)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoSort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSort);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSort)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AutoStartLoopAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoStartLoopAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoStartLoopAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string BackButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackButton);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackButton)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string BackButtonNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackButtonNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackButtonNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Behavior
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Behavior);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Behavior)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string BehaviorAtStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BehaviorAtStart);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BehaviorAtStart)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Behaviors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Behaviors);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Behaviors)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string BuildIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildIndex);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildIndex)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ButtonCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ButtonName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Buttons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Buttons);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Buttons)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Cancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cancel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cancel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CannotAddEmptyEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CannotAddEmptyEntry);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CannotAddEmptyEntry)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Canvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Canvas);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Canvas)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe string Category
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Category);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Category)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CategoryIsEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryIsEmpty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryIsEmpty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Center
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Center);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Center)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CenterSelectedNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CenterSelectedNodes);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CenterSelectedNodes)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Chance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Chance);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Chance)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CheckingForIssues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CheckingForIssues);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CheckingForIssues)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Clear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Clear);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Clear)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClearRecentOpenedGraphsList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearRecentOpenedGraphsList);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearRecentOpenedGraphsList)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClearRecentOpenedGraphsListDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearRecentOpenedGraphsListDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearRecentOpenedGraphsListDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClearSearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearSearch);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearSearch)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClickAnywhere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickAnywhere);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickAnywhere)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClickContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickContainer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickContainer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClickMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClickOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickOverlay);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClickOverlay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Close
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Close);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Close)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CloseDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseDirection);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseDirection)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CloseDrawer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseDrawer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseDrawer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CloseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseSpeed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CloseSpeed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Closed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Closed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Closed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ClosedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosedPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosedPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Compiling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Compiling);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Compiling)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ComponentDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ComponentDisabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ComponentDisabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Connected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Connected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Connected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ConnectionPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPoint);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPoint)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Connections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Connections);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Connections)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Container
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Container);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Container)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ContainerSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContainerSize);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContainerSize)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Continue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Continue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Continue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ControllerIdleKillDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerIdleKillDuration);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerIdleKillDuration)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ControllerIdleKillDurationDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerIdleKillDurationDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerIdleKillDurationDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ControllerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ControllerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ConvertToGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConvertToGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConvertToGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ConvertToSubGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConvertToSubGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConvertToSubGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Copy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Copy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Copy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Create
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Create);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Create)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateNewCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNewCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNewCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateNewGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNewGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNewGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateNewGraphAsSubGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNewGraphAsSubGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNewGraphAsSubGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateParentAndCenterPivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateParentAndCenterPivot);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateParentAndCenterPivot)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CreateSubGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateSubGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateSubGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CurrentTimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentTimeScale);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentTimeScale)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Custom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Custom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Custom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CustomName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CustomPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CustomResetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomResetValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomResetValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CustomSortingLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomSortingLayer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomSortingLayer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CustomSortingOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomSortingOrder);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomSortingOrder)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CustomStartPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomStartPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomStartPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Cut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cut);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cut)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Database
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Database);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Database)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseAlreadyExists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseAlreadyExists);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseAlreadyExists)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseHasBeenReset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseHasBeenReset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseHasBeenReset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseIsEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseIsEmpty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseIsEmpty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseRefreshed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseRefreshed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseRefreshed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseSorted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseSorted);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseSorted)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Debug);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Debug)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DebugMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DefaultDotAnimationSpeedDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultDotAnimationSpeedDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultDotAnimationSpeedDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DefaultValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultValues);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultValues)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DefaultValuesDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultValuesDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultValuesDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DefaultZoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultZoom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultZoom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DefaultZoomDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultZoomDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultZoomDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Delete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Delete);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Delete)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeleteDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeleteDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeleteDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeletePopupReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeletePopupReference);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeletePopupReference)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeletePreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeletePreset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeletePreset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeletedPopupReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeletedPopupReference);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeletedPopupReference)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Deselect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Deselect);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Deselect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeselectAnyButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectAnyButton);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectAnyButton)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeselectButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButton);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButton)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DeselectButtonAfterClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButtonAfterClick);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButtonAfterClick)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DestroyAfterHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DestroyAfterHide);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DestroyAfterHide)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DetectGestures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetectGestures);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetectGestures)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Disable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Disable);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Disable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisableButtonInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableButtonInterval);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableButtonInterval)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisableCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableCanvas);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableCanvas)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisableFunctionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableFunctionality);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableFunctionality)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisableGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableGameObject);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableGameObject)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisableInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableInterval);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableInterval)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisablePlugin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisablePlugin);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisablePlugin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Disabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Disabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Disconnect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Disconnect);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Disconnect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DispatchButtonClicks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DispatchButtonClicks);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DispatchButtonClicks)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DispatchGameEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DispatchGameEvents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DispatchGameEvents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisplayTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayTarget);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayTarget)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DontDestroyGameObjectOnLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DontDestroyGameObjectOnLoad);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DontDestroyGameObjectOnLoad)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DotAnimationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DotAnimationSpeed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DotAnimationSpeed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Down
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Down);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Down)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DragDrawer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragDrawer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragDrawer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DrawerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawerName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DropAudioClipsHere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropAudioClipsHere);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropAudioClipsHere)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Ease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ease);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ease)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EaseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EaseType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EaseType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Effect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Effect);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Effect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Elasticity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Elasticity);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Elasticity)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Email
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Email);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Email)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Empty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Empty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Empty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Enable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enable);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnableFunctionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableFunctionality);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableFunctionality)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnablePlugin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnablePlugin);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnablePlugin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnableSupportForMasterAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableSupportForMasterAudio);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableSupportForMasterAudio)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnterCategoryName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterCategoryName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterCategoryName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnterDatabaseName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterDatabaseName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterDatabaseName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnterGameEventToListenFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterGameEventToListenFor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterGameEventToListenFor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EnterNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Error
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Error);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Error)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Event
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Event);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Event)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EveryLongTapWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EveryLongTapWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EveryLongTapWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EverySwipeWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EverySwipeWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EverySwipeWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EveryTapWillTriggerThisListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EveryTapWillTriggerThisListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EveryTapWillTriggerThisListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ExitNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExitNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExitNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Fade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fade);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fade)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FadeBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FadeFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeFrom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FadeOutContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOutContainer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOutContainer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FadeTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FixedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedSize);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedSize)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FsmName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FsmName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FsmName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Functionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Functionality);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Functionality)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string FunctionalityDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FunctionalityDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FunctionalityDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameEvent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameEvent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GameEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameEvents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameEvents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameObject);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameObject)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GeneralSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GeneralSettings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GeneralSettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GestureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GestureType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GestureType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GetInTouch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetInTouch);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetInTouch)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GetSceneBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetSceneBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetSceneBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GlobalListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GlobalListener);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GlobalListener)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GoToEnterNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoToEnterNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoToEnterNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GoToExitNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoToExitNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoToExitNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GoToStartNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoToStartNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoToStartNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Graph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Graph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Graph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GraphHasNoNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphHasNoNodes);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphHasNoNodes)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GraphId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GraphModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphModel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphModel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GraphicRaycaster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphicRaycaster);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphicRaycaster)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HasBeenAddedToClipboard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasBeenAddedToClipboard);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasBeenAddedToClipboard)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Height);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Height)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Help
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Help);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Help)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HelpResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HelpResources);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HelpResources)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Hide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hide);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hide)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HideAnimationWillNotWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideAnimationWillNotWork);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideAnimationWillNotWork)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HidePopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HidePopup);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HidePopup)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HideProgressor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideProgressor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideProgressor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HideUIPopupBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideUIPopupBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideUIPopupBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HideView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideView);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideView)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HideViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideViews);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideViews)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HowToUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HowToUse);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HowToUse)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string IdleCheckInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdleCheckInterval);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdleCheckInterval)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string IdleCheckIntervalDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdleCheckIntervalDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdleCheckIntervalDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string IgnoreListenerPause
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreListenerPause);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreListenerPause)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string IgnoreTimescale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreTimescale);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreTimescale)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Image
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Image);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Image)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Images
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Images);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Images)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string IncludeAudioClipNamesInSearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncludeAudioClipNamesInSearch);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncludeAudioClipNamesInSearch)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Info);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Info)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string InputConnected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputConnected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputConnected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string InputConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputConnections);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputConnections)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string InputMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string InputNotConnected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputNotConnected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputNotConnected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Installed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Installed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Installed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string InstantAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantAction);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantAction)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string InstantAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Integrations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Integrations);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Integrations)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string IsNotPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNotPrefab);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNotPrefab)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Key
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Key);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Key)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string KeyCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyCode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyCode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Label
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Label);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Label)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Labels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Labels);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Labels)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LastModified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastModified);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastModified)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Left
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Left);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Left)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ListIsEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListIsEmpty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListIsEmpty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ListenForAllGameEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllGameEvents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllGameEvents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ListenForAllUIButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllUIButtons);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllUIButtons)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ListenForAllUIDrawers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllUIDrawers);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllUIDrawers)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ListenForAllUIViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllUIViews);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenForAllUIViews)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ListeningForGameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListeningForGameEvent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListeningForGameEvent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Load
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Load);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Load)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadBehavior
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadBehavior);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadBehavior)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadPreset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadPreset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadSceneBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSceneBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSceneBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadSceneMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSceneMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSceneMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadSceneNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSceneNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSceneNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadSelectedPresetAtRuntime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSelectedPresetAtRuntime);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSelectedPresetAtRuntime)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoadedGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadedGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadedGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LongTapDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongTapDuration);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongTapDuration)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LongTapDurationDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongTapDurationDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongTapDurationDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoopSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopSound);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopSound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoopType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string LoopView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopView);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopView)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Manual
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Manual);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Manual)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Max);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Max)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MaxValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Min
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Min);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Min)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MinValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MinimumNumberOfControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumNumberOfControllers);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumNumberOfControllers)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MinimumNumberOfControllersDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumNumberOfControllersDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumNumberOfControllersDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MinimumSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumSize);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumSize)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingPrefabReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingPrefabReference);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingPrefabReference)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Move
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Move);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Move)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MoveBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MoveDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveDown);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveDown)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MoveFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveFrom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MoveTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MoveUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveUp);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveUp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Multiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Multiplier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Multiplier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MuteAllSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MuteAllSounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MuteAllSounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string New
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_New);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_New)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewCategoryNameCannotBeEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewCategoryNameCannotBeEmpty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewCategoryNameCannotBeEmpty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewPopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewPopup);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewPopup)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewPreset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewPreset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewPresetNameCannotBeEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewPresetNameCannotBeEmpty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewPresetNameCannotBeEmpty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NewSoundDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewSoundDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NewSoundDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string News
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_News);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_News)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string No
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_No);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_No)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoAnimationEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoAnimationEnabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoAnimationEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoAnimatorFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoAnimatorFound);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoAnimatorFound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoGraphReferenced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoGraphReferenced);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoGraphReferenced)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSound);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoSoundsHaveBeenAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSoundsHaveBeenAdded);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSoundsHaveBeenAdded)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Node
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Node);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Node)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NodeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NodeNameTooltip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeNameTooltip);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeNameTooltip)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NodeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeState);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeState)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeWidth);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeWidth)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Nodes);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Nodes)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NodySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodySettings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodySettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NormalLoopAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalLoopAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalLoopAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotConnected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotConnected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotConnected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotInstalled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotInstalled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotInstalled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoteworthyInformation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoteworthyInformation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoteworthyInformation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NumberOfLoops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NumberOfLoops);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NumberOfLoops)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Ok
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ok);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ok)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnAnimationFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAnimationFinished);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAnimationFinished)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnAnimationStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAnimationStart);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAnimationStart)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnClick);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnClick)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnDeselected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDeselected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDeselected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnDoubleClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDoubleClick);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDoubleClick)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnEnter);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnEnter)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnEnterNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnEnterNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnEnterNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnExit);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnExit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnExitNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnExitNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnExitNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnFixedUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnFixedUpdate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnFixedUpdate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnLateUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLateUpdate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLateUpdate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnLoadScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLoadScene);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLoadScene)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnLongClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLongClick);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLongClick)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnNodeFixedUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNodeFixedUpdate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNodeFixedUpdate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnNodeLateUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNodeLateUpdate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNodeLateUpdate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnNodeUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNodeUpdate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNodeUpdate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnPointerDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerDown);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerDown)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnPointerEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerEnter);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerEnter)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnPointerExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerExit);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerExit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnPointerUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerUp);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPointerUp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnSceneLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSceneLoaded);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSceneLoaded)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSelected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSelected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTrigger);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnUpdate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnUpdate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Open
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Open);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Open)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenControlPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenControlPanel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenControlPanel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenDrawer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenDrawer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenDrawer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenNody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenNody);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenNody)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenSpeed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenSpeed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenSubGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenSubGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenSubGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Opened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opened);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opened)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OpenedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenedPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenedPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OperationCannotBeUndone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OperationCannotBeUndone);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OperationCannotBeUndone)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OrientationDetectorDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrientationDetectorDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrientationDetectorDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OtherReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OtherReferences);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OtherReferences)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OutputAudioMixerGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputAudioMixerGroup);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputAudioMixerGroup)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OutputConnected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputConnected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputConnected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OutputConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputConnections);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputConnections)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OutputMixerGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputMixerGroup);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputMixerGroup)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OutputNotConnected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputNotConnected);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputNotConnected)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Overlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Overlay);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Overlay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Override
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Override);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Override)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OverrideColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideColor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideColor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Overview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Overview);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Overview)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OverviewZoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverviewZoom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverviewZoom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ParameterName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParameterName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParameterName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ParameterType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParameterType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParameterType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ParticleSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleSystem);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleSystem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Paste
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Paste);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Paste)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PauseAllSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PauseAllSounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PauseAllSounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PercentageOfScreenZeroToOne
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PercentageOfScreenZeroToOne);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PercentageOfScreenZeroToOne)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PitchSemitones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PitchSemitones);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PitchSemitones)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Play
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Play);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Play)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PlayAnimationInZeroSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayAnimationInZeroSeconds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayAnimationInZeroSeconds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PlayMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PlaySound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlaySound);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlaySound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PleaseEnterNewName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PleaseEnterNewName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PleaseEnterNewName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PopupName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PopupPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupPrefab);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupPrefab)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Portal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Portal);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Portal)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PortalNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PortalNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PortalNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Prefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PresetCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PresetName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PreviewAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Progress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progress);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progress)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ProgressTargets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProgressTargets);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProgressTargets)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Progressor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progressor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progressor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Progressors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progressors);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progressors)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PunchBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PunchBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PunchBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RandomDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomDuration);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomDuration)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RandomNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Recent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Recent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Recent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Refresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Refresh);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Refresh)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RefreshDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RefreshDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RefreshDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RegisterInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RegisterInterval);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RegisterInterval)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Remove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Remove);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Remove)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveDuplicates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveDuplicates);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveDuplicates)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveEmptyCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveEmptyCategories);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveEmptyCategories)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveEmptyEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveEmptyEntries);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveEmptyEntries)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveItem);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveNullEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveNullEntries);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveNullEntries)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemoveSymbolFromAllBuildTargetGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveSymbolFromAllBuildTargetGroups);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoveSymbolFromAllBuildTargetGroups)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemovedDuplicateEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedDuplicateEntries);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedDuplicateEntries)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemovedEntriesWithNoName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedEntriesWithNoName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedEntriesWithNoName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemovedEntriesWithNullPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedEntriesWithNullPrefabs);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedEntriesWithNullPrefabs)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemovedEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedEntry);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedEntry)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RemovedNullEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedNullEntries);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemovedNullEntries)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Rename
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rename);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rename)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RenameCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RenameCategoryDialogMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameCategoryDialogMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameCategoryDialogMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RenameGameObjectTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameGameObjectTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameGameObjectTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RenameNodeTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameNodeTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameNodeTo)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe string RenameSoundDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameSoundDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameSoundDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RenameSoundDatabaseDialogMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameSoundDatabaseDialogMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameSoundDatabaseDialogMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe string RenameTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenameTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Reset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Reset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Reset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetAnimationSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetAnimationSettings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetAnimationSettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetClosedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetClosedPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetClosedPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetOpenedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetOpenedPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetOpenedPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetRoot);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetRoot)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetTrigger);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ResetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ReversedProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReversedProgress);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReversedProgress)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Right
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Right);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Right)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Rotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RotateBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RotateFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateFrom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RotateMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RotateTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RuntimeOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RuntimeOptions);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RuntimeOptions)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string RuntimePreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RuntimePreset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RuntimePreset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Save
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Save);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Save)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SaveAs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveAs);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveAs)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SavePreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SavePreset);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SavePreset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ScaleBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleBy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleBy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ScaleFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleFrom);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ScaleTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Scene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scene);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scene)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SceneActivationDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneActivationDelay);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneActivationDelay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SceneBuildIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneBuildIndex);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneBuildIndex)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SceneLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneLoad);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneLoad)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SceneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SceneUnload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneUnload);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneUnload)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ScriptingDefineSymbol
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScriptingDefineSymbol);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScriptingDefineSymbol)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Search
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Search);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Search)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SearchForCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SearchForCategories);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SearchForCategories)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SearchForDatabases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SearchForDatabases);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SearchForDatabases)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SearchForUIPopupLinks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SearchForUIPopupLinks);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SearchForUIPopupLinks)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Seconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Seconds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Seconds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SecondsDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecondsDelay);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecondsDelay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Select
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Select);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Select)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SelectButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectButton);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectButton)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SelectSwipeDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectSwipeDirection);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectSwipeDirection)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SelectedLoopAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedLoopAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedLoopAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Send
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Send);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Send)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SendGameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SendGameEvent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SendGameEvent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SendGameEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SendGameEvents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SendGameEvents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetActiveNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetActiveNode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetActiveNode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetAsSoundName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetAsSoundName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetAsSoundName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetBoolValueTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetBoolValueTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetBoolValueTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetFloatValueTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetFloatValueTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetFloatValueTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetIntValueTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetIntValueTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetIntValueTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetPosition);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetTargetGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetTargetGameObject);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetTargetGameObject)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetUIButtonToListenFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetUIButtonToListenFor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetUIButtonToListenFor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetUIDrawerToListenFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetUIDrawerToListenFor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetUIDrawerToListenFor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetUIViewToListenFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetUIViewToListenFor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetUIViewToListenFor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Settings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Settings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Show
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Show);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Show)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ShowAnimationWillNotWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowAnimationWillNotWork);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowAnimationWillNotWork)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ShowCurveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowCurveModifier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowCurveModifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ShowPopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowPopup);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowPopup)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ShowProgressor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowProgressor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowProgressor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ShowView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowView);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowView)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ShowViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowViews);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowViews)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Simulate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Simulate);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Simulate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SocialLinks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocialLinks);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocialLinks)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Socket
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Socket);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Socket)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Sort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sort);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sort)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SortDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SortDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SortDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SortingSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SortingSteps);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SortingSteps)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Sound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sound);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundAction);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundAction)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundDatabases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundDatabases);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundDatabases)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundSource);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Sounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Soundy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Soundy);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Soundy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundyDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundyDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundyDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundySettings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundySettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SourceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Sources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sources);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sources)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SpatialBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpatialBlend);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpatialBlend)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string StartDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartDelay);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartDelay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string StartNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string StopAllSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopAllSounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopAllSounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string StopAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string StopBehavior
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopBehavior);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopBehavior)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string StopSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopSound);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopSound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SubGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubGraph);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubGraph)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SubGraphNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubGraphNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubGraphNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Suffix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Suffix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Suffix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SupportEmail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportEmail);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportEmail)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SwipeDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeDirection);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeDirection)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SwipeLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeLength);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeLength)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SwipeLengthDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeLengthDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeLengthDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SwitchBackNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwitchBackNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwitchBackNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Target);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Target)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetAnimator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetAnimator);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetAnimator)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetAnimatorDoesNotHaveAnAnimatorController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnAnimatorController);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnAnimatorController)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetAnimatorDoesNotHaveAnyParameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnyParameters);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnyParameters)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetCanvas);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetCanvas)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetFsm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetFsm);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetFsm)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetGameObject);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetGameObject)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetLabel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetOrientation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetOrientation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetOrientation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetProgress);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetProgress)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetTimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetTimeScale);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetTimeScale)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TargetVariable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetVariable);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetVariable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Text);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Text)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TextLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextLabel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TextMeshPro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextMeshPro);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextMeshPro)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TextMeshProLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextMeshProLabel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextMeshProLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TimeScaleNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeScaleNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeScaleNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleComponentBehaviors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleComponentBehaviors);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleComponentBehaviors)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleLabel);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleOFF
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleOFF);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleOFF)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleON)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleProgressor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleProgressor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleProgressor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleSettings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleSettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ToggleSupportForThirdPartyPlugins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleSupportForThirdPartyPlugins);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleSupportForThirdPartyPlugins)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TouchySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TouchySettings);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TouchySettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TriggerAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerAction);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerAction)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TriggerEventsAfterAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerEventsAfterAnimation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerEventsAfterAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string TriggerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UIDrawerNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIDrawerNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIDrawerNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UINodeNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UINodeNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UINodeNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UIPopupDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIPopupDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIPopupDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnityEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnityEvent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnityEvent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnityEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnityEvents);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnityEvents)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnloadSceneNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnloadSceneNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnloadSceneNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnmuteAllSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnmuteAllSounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnmuteAllSounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnpauseAllSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnpauseAllSounds);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnpauseAllSounds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Up
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Up);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Up)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdateContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateContainer);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateContainer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdateEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateEffect);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateEffect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdateOnHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateOnHide);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateOnHide)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdateOnShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateOnShow);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateOnShow)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdatePopupName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdatePopupName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdatePopupName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdatePopupPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdatePopupPrefab);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdatePopupPrefab)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UpdateValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateValue);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UseBackButtonDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseBackButtonDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseBackButtonDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UseCustomFromAndTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCustomFromAndTo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCustomFromAndTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UseMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMultiplier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMultiplier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UsefulLinks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UsefulLinks);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UsefulLinks)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Version);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Version)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Vibrato
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vibrato);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vibrato)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ViewCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ViewCategory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ViewCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ViewName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ViewName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ViewName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string VirtualButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButton);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirtualButton)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string VolumeDb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VolumeDb);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VolumeDb)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WaitFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitFor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitFor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WaitForAnimationToFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitForAnimationToFinish);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitForAnimationToFinish)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WaitForSceneToUnload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitForSceneToUnload);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitForSceneToUnload)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WaitNodeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitNodeName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitNodeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Warning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Warning);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Warning)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WhenClosed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenClosed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenClosed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WhenUIDrawerIsClosed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenUIDrawerIsClosed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenUIDrawerIsClosed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WhenUIPopupIsHiddenDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenUIPopupIsHiddenDisable);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenUIPopupIsHiddenDisable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WhenUIViewIsHiddenDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenUIViewIsHiddenDisable);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WhenUIViewIsHiddenDisable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WholeNumbers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WholeNumbers);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WholeNumbers)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Width);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Width)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_X);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_X)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Y);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Y)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Yes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Yes);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Yes)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string YouAreResponsibleToUpdateYourCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YouAreResponsibleToUpdateYourCode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YouAreResponsibleToUpdateYourCode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string YouCanOnlyAddPrefabsToDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YouCanOnlyAddPrefabsToDatabase);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YouCanOnlyAddPrefabsToDatabase)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string YouTube
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YouTube);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YouTube)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingTargetFsmMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingTargetFsmMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingTargetFsmMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SelectListenerToActivateMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectListenerToActivateMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectListenerToActivateMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string HowToUsePlaymakerEventDispatcherMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HowToUsePlaymakerEventDispatcherMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HowToUsePlaymakerEventDispatcherMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingDrawerNameTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingDrawerNameTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingDrawerNameTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingDrawerNameMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingDrawerNameMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingDrawerNameMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingGameEventTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingGameEventTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingGameEventTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingGameEventMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingGameEventMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingGameEventMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingSceneNameTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingSceneNameTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingSceneNameTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MissingSceneNameMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingSceneNameMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingSceneNameMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WrongSceneBuildIndexTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WrongSceneBuildIndexTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WrongSceneBuildIndexTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string WrongSceneBuildIndexMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WrongSceneBuildIndexMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WrongSceneBuildIndexMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DoubleClickNodeToOpenSubGraphMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoubleClickNodeToOpenSubGraphMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoubleClickNodeToOpenSubGraphMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DuplicateNodeMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DuplicateNodeMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DuplicateNodeMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DuplicateNodeTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DuplicateNodeTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DuplicateNodeTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoGraphReferencedMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoGraphReferencedMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoGraphReferencedMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoGraphReferencedTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoGraphReferencedTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoGraphReferencedTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoSourceConnectedMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSourceConnectedMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSourceConnectedMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoSourceConnectedTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSourceConnectedTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSourceConnectedTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoSubGraphReferencedMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSubGraphReferencedMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSubGraphReferencedMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoSubGraphReferencedTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSubGraphReferencedTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSubGraphReferencedTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoTargetConnectedMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoTargetConnectedMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoTargetConnectedMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NoTargetConnectedTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoTargetConnectedTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoTargetConnectedTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotConnectedMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotConnectedMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotConnectedMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotConnectedTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotConnectedTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotConnectedTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotListeningForAnyGameEventMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotListeningForAnyGameEventMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotListeningForAnyGameEventMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotListeningForAnyGameEventTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotListeningForAnyGameEventTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotListeningForAnyGameEventTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotSendingAnyGameEventMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotSendingAnyGameEventMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotSendingAnyGameEventMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string NotSendingAnyGameEventTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotSendingAnyGameEventTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotSendingAnyGameEventTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ProgressTargetAnimatorParameterInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProgressTargetAnimatorParameterInfo);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProgressTargetAnimatorParameterInfo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ReferencedGraphIsNotSubGraphMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ReferencedGraphIsNotSubGraphTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ReferencedGraphIsSubGraphMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsSubGraphMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsSubGraphMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ReferencedGraphIsSubGraphTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsSubGraphTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReferencedGraphIsSubGraphTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SomeProgressTargetsGetUpdatedOnlyInPlayMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SomeProgressTargetsGetUpdatedOnlyInPlayMode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SomeProgressTargetsGetUpdatedOnlyInPlayMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SupportForMasterAudioNotEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportForMasterAudioNotEnabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportForMasterAudioNotEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SupportForPlaymakerNotEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportForPlaymakerNotEnabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportForPlaymakerNotEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SupportForTextMeshProNotEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportForTextMeshProNotEnabled);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportForTextMeshProNotEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ThisClassShouldBeExtended
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThisClassShouldBeExtended);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThisClassShouldBeExtended)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnnamedNodeMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnnamedNodeMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnnamedNodeMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string UnnamedNodeTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnnamedNodeTitle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnnamedNodeTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static UILanguagePack Instance
	{
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 726781, RefRangeEnd = 726834, XrefRangeStart = 726759, XrefRangeEnd = 726781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UILanguagePack_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UILanguagePack>(intPtr) : null;
		}
	}

	static UILanguagePack()
	{
		Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "UILanguagePack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr);
		NativeFieldInfoPtr_s_loadedLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "s_loadedLanguage");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_TargetLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetLanguage");
		NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Action");
		NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Actions");
		NativeFieldInfoPtr_ActivateLoadedScenesNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ActivateLoadedScenesNodeName");
		NativeFieldInfoPtr_ActiveNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ActiveNode");
		NativeFieldInfoPtr_ActiveSceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ActiveSceneChange");
		NativeFieldInfoPtr_AddCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AddCategory");
		NativeFieldInfoPtr_AddItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AddItem");
		NativeFieldInfoPtr_AddSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AddSounds");
		NativeFieldInfoPtr_AddSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AddSource");
		NativeFieldInfoPtr_AddSymbolToAllBuildTargetGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AddSymbolToAllBuildTargetGroups");
		NativeFieldInfoPtr_AddToPopupQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AddToPopupQueue");
		NativeFieldInfoPtr_After = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "After");
		NativeFieldInfoPtr_AllSoundsBeforePlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AllSoundsBeforePlaying");
		NativeFieldInfoPtr_AllowMultipleClicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AllowMultipleClicks");
		NativeFieldInfoPtr_AllowSceneActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AllowSceneActivation");
		NativeFieldInfoPtr_AlternateInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AlternateInput");
		NativeFieldInfoPtr_AlternateKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AlternateKeyCode");
		NativeFieldInfoPtr_AlternateVirtualButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AlternateVirtualButton");
		NativeFieldInfoPtr_AnimateAllUIViewsWithSameCategoryAndName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnimateAllUIViewsWithSameCategoryAndName");
		NativeFieldInfoPtr_AnimateValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnimateValue");
		NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Animation");
		NativeFieldInfoPtr_AnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnimationCurve");
		NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnimationType");
		NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Animator");
		NativeFieldInfoPtr_AnimatorEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnimatorEvents");
		NativeFieldInfoPtr_Animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Animators");
		NativeFieldInfoPtr_AnotherEntryExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnotherEntryExists");
		NativeFieldInfoPtr_AnyGameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnyGameEvent");
		NativeFieldInfoPtr_AnyGameEventWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnyGameEventWillTriggerThisListener");
		NativeFieldInfoPtr_AnyScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnyScene");
		NativeFieldInfoPtr_AnyUIButtonWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnyUIButtonWillTriggerThisListener");
		NativeFieldInfoPtr_AnyUIDrawerWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnyUIDrawerWillTriggerThisListener");
		NativeFieldInfoPtr_AnyUIViewWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AnyUIViewWillTriggerThisListener");
		NativeFieldInfoPtr_ApplicationQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ApplicationQuit");
		NativeFieldInfoPtr_AreYouSureConvertToGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureConvertToGraph");
		NativeFieldInfoPtr_AreYouSureConvertToSubGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureConvertToSubGraph");
		NativeFieldInfoPtr_AreYouSureYouWantToDeleteDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureYouWantToDeleteDatabase");
		NativeFieldInfoPtr_AreYouSureYouWantToDeletePopupReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureYouWantToDeletePopupReference");
		NativeFieldInfoPtr_AreYouSureYouWantToRemoveCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureYouWantToRemoveCategory");
		NativeFieldInfoPtr_AreYouSureYouWantToRemoveTheEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureYouWantToRemoveTheEntry");
		NativeFieldInfoPtr_AreYouSureYouWantToResetDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AreYouSureYouWantToResetDatabase");
		NativeFieldInfoPtr_Arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Arrow");
		NativeFieldInfoPtr_ArrowComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ArrowComponents");
		NativeFieldInfoPtr_AtFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AtFinish");
		NativeFieldInfoPtr_AtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AtStart");
		NativeFieldInfoPtr_AudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AudioClip");
		NativeFieldInfoPtr_AutoDisableUIInteractionsDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoDisableUIInteractionsDescription");
		NativeFieldInfoPtr_AutoHideAfterShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoHideAfterShow");
		NativeFieldInfoPtr_AutoKillIdleControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoKillIdleControllers");
		NativeFieldInfoPtr_AutoKillIdleControllersDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoKillIdleControllersDescription");
		NativeFieldInfoPtr_AutoResetSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoResetSequence");
		NativeFieldInfoPtr_AutoSelectButtonAfterShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoSelectButtonAfterShow");
		NativeFieldInfoPtr_AutoSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoSort");
		NativeFieldInfoPtr_AutoStartLoopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "AutoStartLoopAnimation");
		NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "BackButton");
		NativeFieldInfoPtr_BackButtonNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "BackButtonNodeName");
		NativeFieldInfoPtr_Behavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Behavior");
		NativeFieldInfoPtr_BehaviorAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "BehaviorAtStart");
		NativeFieldInfoPtr_Behaviors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Behaviors");
		NativeFieldInfoPtr_BuildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "BuildIndex");
		NativeFieldInfoPtr_ButtonCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ButtonCategory");
		NativeFieldInfoPtr_ButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ButtonLabel");
		NativeFieldInfoPtr_ButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ButtonName");
		NativeFieldInfoPtr_Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Buttons");
		NativeFieldInfoPtr_Cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Cancel");
		NativeFieldInfoPtr_CannotAddEmptyEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CannotAddEmptyEntry");
		NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Canvas");
		NativeFieldInfoPtr_CanvasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CanvasName");
		NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Category");
		NativeFieldInfoPtr_CategoryIsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CategoryIsEmpty");
		NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Center");
		NativeFieldInfoPtr_CenterSelectedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CenterSelectedNodes");
		NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Chance");
		NativeFieldInfoPtr_CheckingForIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CheckingForIssues");
		NativeFieldInfoPtr_Clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Clear");
		NativeFieldInfoPtr_ClearRecentOpenedGraphsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClearRecentOpenedGraphsList");
		NativeFieldInfoPtr_ClearRecentOpenedGraphsListDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClearRecentOpenedGraphsListDescription");
		NativeFieldInfoPtr_ClearSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClearSearch");
		NativeFieldInfoPtr_ClickAnywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClickAnywhere");
		NativeFieldInfoPtr_ClickContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClickContainer");
		NativeFieldInfoPtr_ClickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClickMode");
		NativeFieldInfoPtr_ClickOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClickOverlay");
		NativeFieldInfoPtr_Close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Close");
		NativeFieldInfoPtr_CloseDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CloseDirection");
		NativeFieldInfoPtr_CloseDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CloseDrawer");
		NativeFieldInfoPtr_CloseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CloseSpeed");
		NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Closed");
		NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ClosedPosition");
		NativeFieldInfoPtr_Compiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Compiling");
		NativeFieldInfoPtr_ComponentDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ComponentDisabled");
		NativeFieldInfoPtr_Connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Connected");
		NativeFieldInfoPtr_ConnectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ConnectionPoint");
		NativeFieldInfoPtr_Connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Connections");
		NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Container");
		NativeFieldInfoPtr_ContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ContainerSize");
		NativeFieldInfoPtr_Continue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Continue");
		NativeFieldInfoPtr_ControllerIdleKillDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ControllerIdleKillDuration");
		NativeFieldInfoPtr_ControllerIdleKillDurationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ControllerIdleKillDurationDescription");
		NativeFieldInfoPtr_ControllerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ControllerName");
		NativeFieldInfoPtr_ConvertToGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ConvertToGraph");
		NativeFieldInfoPtr_ConvertToSubGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ConvertToSubGraph");
		NativeFieldInfoPtr_Copy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Copy");
		NativeFieldInfoPtr_Create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Create");
		NativeFieldInfoPtr_CreateAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateAnimation");
		NativeFieldInfoPtr_CreateGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateGraph");
		NativeFieldInfoPtr_CreateNewCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateNewCategory");
		NativeFieldInfoPtr_CreateNewGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateNewGraph");
		NativeFieldInfoPtr_CreateNewGraphAsSubGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateNewGraphAsSubGraph");
		NativeFieldInfoPtr_CreateNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateNode");
		NativeFieldInfoPtr_CreateParentAndCenterPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateParentAndCenterPivot");
		NativeFieldInfoPtr_CreateSubGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CreateSubGraph");
		NativeFieldInfoPtr_CurrentTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CurrentTimeScale");
		NativeFieldInfoPtr_Custom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Custom");
		NativeFieldInfoPtr_CustomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CustomName");
		NativeFieldInfoPtr_CustomPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CustomPosition");
		NativeFieldInfoPtr_CustomResetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CustomResetValue");
		NativeFieldInfoPtr_CustomSortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CustomSortingLayer");
		NativeFieldInfoPtr_CustomSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CustomSortingOrder");
		NativeFieldInfoPtr_CustomStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "CustomStartPosition");
		NativeFieldInfoPtr_Cut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Cut");
		NativeFieldInfoPtr_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Database");
		NativeFieldInfoPtr_DatabaseAlreadyExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DatabaseAlreadyExists");
		NativeFieldInfoPtr_DatabaseHasBeenReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DatabaseHasBeenReset");
		NativeFieldInfoPtr_DatabaseIsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DatabaseIsEmpty");
		NativeFieldInfoPtr_DatabaseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DatabaseName");
		NativeFieldInfoPtr_DatabaseRefreshed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DatabaseRefreshed");
		NativeFieldInfoPtr_DatabaseSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DatabaseSorted");
		NativeFieldInfoPtr_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Debug");
		NativeFieldInfoPtr_DebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DebugMode");
		NativeFieldInfoPtr_DefaultDotAnimationSpeedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DefaultDotAnimationSpeedDescription");
		NativeFieldInfoPtr_DefaultValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DefaultValues");
		NativeFieldInfoPtr_DefaultValuesDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DefaultValuesDescription");
		NativeFieldInfoPtr_DefaultZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DefaultZoom");
		NativeFieldInfoPtr_DefaultZoomDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DefaultZoomDescription");
		NativeFieldInfoPtr_Delete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Delete");
		NativeFieldInfoPtr_DeleteDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeleteDatabase");
		NativeFieldInfoPtr_DeletePopupReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeletePopupReference");
		NativeFieldInfoPtr_DeletePreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeletePreset");
		NativeFieldInfoPtr_DeletedPopupReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeletedPopupReference");
		NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Description");
		NativeFieldInfoPtr_Deselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Deselect");
		NativeFieldInfoPtr_DeselectAnyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeselectAnyButton");
		NativeFieldInfoPtr_DeselectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeselectButton");
		NativeFieldInfoPtr_DeselectButtonAfterClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DeselectButtonAfterClick");
		NativeFieldInfoPtr_DestroyAfterHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DestroyAfterHide");
		NativeFieldInfoPtr_DetectGestures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DetectGestures");
		NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Direction");
		NativeFieldInfoPtr_Disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Disable");
		NativeFieldInfoPtr_DisableButtonInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisableButtonInterval");
		NativeFieldInfoPtr_DisableCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisableCanvas");
		NativeFieldInfoPtr_DisableFunctionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisableFunctionality");
		NativeFieldInfoPtr_DisableGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisableGameObject");
		NativeFieldInfoPtr_DisableInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisableInterval");
		NativeFieldInfoPtr_DisablePlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisablePlugin");
		NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Disabled");
		NativeFieldInfoPtr_Disconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Disconnect");
		NativeFieldInfoPtr_DispatchButtonClicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DispatchButtonClicks");
		NativeFieldInfoPtr_DispatchGameEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DispatchGameEvents");
		NativeFieldInfoPtr_DisplayTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DisplayTarget");
		NativeFieldInfoPtr_DontDestroyGameObjectOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DontDestroyGameObjectOnLoad");
		NativeFieldInfoPtr_DotAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DotAnimationSpeed");
		NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Down");
		NativeFieldInfoPtr_DragDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DragDrawer");
		NativeFieldInfoPtr_DrawerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DrawerName");
		NativeFieldInfoPtr_DropAudioClipsHere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DropAudioClipsHere");
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Duration");
		NativeFieldInfoPtr_Ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Ease");
		NativeFieldInfoPtr_EaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EaseType");
		NativeFieldInfoPtr_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Effect");
		NativeFieldInfoPtr_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Elasticity");
		NativeFieldInfoPtr_Email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Email");
		NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Empty");
		NativeFieldInfoPtr_Enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Enable");
		NativeFieldInfoPtr_EnableFunctionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnableFunctionality");
		NativeFieldInfoPtr_EnablePlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnablePlugin");
		NativeFieldInfoPtr_EnableSupportForMasterAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnableSupportForMasterAudio");
		NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Enabled");
		NativeFieldInfoPtr_EnterCategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnterCategoryName");
		NativeFieldInfoPtr_EnterDatabaseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnterDatabaseName");
		NativeFieldInfoPtr_EnterGameEventToListenFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnterGameEventToListenFor");
		NativeFieldInfoPtr_EnterNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EnterNodeName");
		NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Error");
		NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Event");
		NativeFieldInfoPtr_EveryLongTapWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EveryLongTapWillTriggerThisListener");
		NativeFieldInfoPtr_EverySwipeWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EverySwipeWillTriggerThisListener");
		NativeFieldInfoPtr_EveryTapWillTriggerThisListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "EveryTapWillTriggerThisListener");
		NativeFieldInfoPtr_ExitNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ExitNodeName");
		NativeFieldInfoPtr_Fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Fade");
		NativeFieldInfoPtr_FadeBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FadeBy");
		NativeFieldInfoPtr_FadeFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FadeFrom");
		NativeFieldInfoPtr_FadeOutContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FadeOutContainer");
		NativeFieldInfoPtr_FadeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FadeTo");
		NativeFieldInfoPtr_FixedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FixedSize");
		NativeFieldInfoPtr_FsmName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FsmName");
		NativeFieldInfoPtr_Functionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Functionality");
		NativeFieldInfoPtr_FunctionalityDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "FunctionalityDescription");
		NativeFieldInfoPtr_GameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GameEvent");
		NativeFieldInfoPtr_GameEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GameEvents");
		NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GameObject");
		NativeFieldInfoPtr_GeneralSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GeneralSettings");
		NativeFieldInfoPtr_GestureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GestureType");
		NativeFieldInfoPtr_GetInTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GetInTouch");
		NativeFieldInfoPtr_GetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GetPosition");
		NativeFieldInfoPtr_GetSceneBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GetSceneBy");
		NativeFieldInfoPtr_GlobalListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GlobalListener");
		NativeFieldInfoPtr_GoToEnterNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GoToEnterNode");
		NativeFieldInfoPtr_GoToExitNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GoToExitNode");
		NativeFieldInfoPtr_GoToStartNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GoToStartNode");
		NativeFieldInfoPtr_Graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Graph");
		NativeFieldInfoPtr_GraphHasNoNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GraphHasNoNodes");
		NativeFieldInfoPtr_GraphId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GraphId");
		NativeFieldInfoPtr_GraphModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GraphModel");
		NativeFieldInfoPtr_GraphicRaycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "GraphicRaycaster");
		NativeFieldInfoPtr_HasBeenAddedToClipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HasBeenAddedToClipboard");
		NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Height");
		NativeFieldInfoPtr_Help = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Help");
		NativeFieldInfoPtr_HelpResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HelpResources");
		NativeFieldInfoPtr_Hide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Hide");
		NativeFieldInfoPtr_HideAnimationWillNotWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HideAnimationWillNotWork");
		NativeFieldInfoPtr_HidePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HidePopup");
		NativeFieldInfoPtr_HideProgressor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HideProgressor");
		NativeFieldInfoPtr_HideUIPopupBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HideUIPopupBy");
		NativeFieldInfoPtr_HideView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HideView");
		NativeFieldInfoPtr_HideViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HideViews");
		NativeFieldInfoPtr_HowToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HowToUse");
		NativeFieldInfoPtr_IdleCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "IdleCheckInterval");
		NativeFieldInfoPtr_IdleCheckIntervalDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "IdleCheckIntervalDescription");
		NativeFieldInfoPtr_IgnoreListenerPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "IgnoreListenerPause");
		NativeFieldInfoPtr_IgnoreTimescale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "IgnoreTimescale");
		NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Image");
		NativeFieldInfoPtr_Images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Images");
		NativeFieldInfoPtr_IncludeAudioClipNamesInSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "IncludeAudioClipNamesInSearch");
		NativeFieldInfoPtr_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Info");
		NativeFieldInfoPtr_InputConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "InputConnected");
		NativeFieldInfoPtr_InputConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "InputConnections");
		NativeFieldInfoPtr_InputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "InputMode");
		NativeFieldInfoPtr_InputNotConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "InputNotConnected");
		NativeFieldInfoPtr_Installed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Installed");
		NativeFieldInfoPtr_InstantAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "InstantAction");
		NativeFieldInfoPtr_InstantAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "InstantAnimation");
		NativeFieldInfoPtr_Integrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Integrations");
		NativeFieldInfoPtr_IsNotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "IsNotPrefab");
		NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Key");
		NativeFieldInfoPtr_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "KeyCode");
		NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Label");
		NativeFieldInfoPtr_Labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Labels");
		NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Language");
		NativeFieldInfoPtr_LastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LastModified");
		NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Left");
		NativeFieldInfoPtr_ListIsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ListIsEmpty");
		NativeFieldInfoPtr_ListenForAllGameEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ListenForAllGameEvents");
		NativeFieldInfoPtr_ListenForAllUIButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ListenForAllUIButtons");
		NativeFieldInfoPtr_ListenForAllUIDrawers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ListenForAllUIDrawers");
		NativeFieldInfoPtr_ListenForAllUIViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ListenForAllUIViews");
		NativeFieldInfoPtr_ListeningForGameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ListeningForGameEvent");
		NativeFieldInfoPtr_Load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Load");
		NativeFieldInfoPtr_LoadBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadBehavior");
		NativeFieldInfoPtr_LoadPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadPreset");
		NativeFieldInfoPtr_LoadSceneBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadSceneBy");
		NativeFieldInfoPtr_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadSceneMode");
		NativeFieldInfoPtr_LoadSceneNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadSceneNodeName");
		NativeFieldInfoPtr_LoadSelectedPresetAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadSelectedPresetAtRuntime");
		NativeFieldInfoPtr_LoadedGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoadedGraph");
		NativeFieldInfoPtr_LongTapDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LongTapDuration");
		NativeFieldInfoPtr_LongTapDurationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LongTapDurationDescription");
		NativeFieldInfoPtr_LoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoopSound");
		NativeFieldInfoPtr_LoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoopType");
		NativeFieldInfoPtr_LoopView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "LoopView");
		NativeFieldInfoPtr_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Manual");
		NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Max");
		NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MaxValue");
		NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Min");
		NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MinValue");
		NativeFieldInfoPtr_MinimumNumberOfControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MinimumNumberOfControllers");
		NativeFieldInfoPtr_MinimumNumberOfControllersDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MinimumNumberOfControllersDescription");
		NativeFieldInfoPtr_MinimumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MinimumSize");
		NativeFieldInfoPtr_MissingPrefabReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingPrefabReference");
		NativeFieldInfoPtr_Move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Move");
		NativeFieldInfoPtr_MoveBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MoveBy");
		NativeFieldInfoPtr_MoveDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MoveDown");
		NativeFieldInfoPtr_MoveFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MoveFrom");
		NativeFieldInfoPtr_MoveTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MoveTo");
		NativeFieldInfoPtr_MoveUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MoveUp");
		NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Multiplier");
		NativeFieldInfoPtr_MuteAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MuteAllSounds");
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_New = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "New");
		NativeFieldInfoPtr_NewCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewCategory");
		NativeFieldInfoPtr_NewCategoryNameCannotBeEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewCategoryNameCannotBeEmpty");
		NativeFieldInfoPtr_NewDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewDatabase");
		NativeFieldInfoPtr_NewPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewPopup");
		NativeFieldInfoPtr_NewPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewPreset");
		NativeFieldInfoPtr_NewPresetNameCannotBeEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewPresetNameCannotBeEmpty");
		NativeFieldInfoPtr_NewSoundDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NewSoundDatabase");
		NativeFieldInfoPtr_News = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "News");
		NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "No");
		NativeFieldInfoPtr_NoAnimationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoAnimationEnabled");
		NativeFieldInfoPtr_NoAnimatorFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoAnimatorFound");
		NativeFieldInfoPtr_NoGraphReferenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoGraphReferenced");
		NativeFieldInfoPtr_NoSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoSound");
		NativeFieldInfoPtr_NoSoundsHaveBeenAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoSoundsHaveBeenAdded");
		NativeFieldInfoPtr_Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Node");
		NativeFieldInfoPtr_NodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NodeId");
		NativeFieldInfoPtr_NodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NodeName");
		NativeFieldInfoPtr_NodeNameTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NodeNameTooltip");
		NativeFieldInfoPtr_NodeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NodeState");
		NativeFieldInfoPtr_NodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NodeWidth");
		NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Nodes");
		NativeFieldInfoPtr_NodySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NodySettings");
		NativeFieldInfoPtr_NormalLoopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NormalLoopAnimation");
		NativeFieldInfoPtr_NotConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotConnected");
		NativeFieldInfoPtr_NotInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotInstalled");
		NativeFieldInfoPtr_NoteworthyInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoteworthyInformation");
		NativeFieldInfoPtr_NumberOfLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NumberOfLoops");
		NativeFieldInfoPtr_Ok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Ok");
		NativeFieldInfoPtr_OnAnimationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnAnimationFinished");
		NativeFieldInfoPtr_OnAnimationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnAnimationStart");
		NativeFieldInfoPtr_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnClick");
		NativeFieldInfoPtr_OnDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnDeselected");
		NativeFieldInfoPtr_OnDoubleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnDoubleClick");
		NativeFieldInfoPtr_OnEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnEnter");
		NativeFieldInfoPtr_OnEnterNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnEnterNode");
		NativeFieldInfoPtr_OnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnExit");
		NativeFieldInfoPtr_OnExitNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnExitNode");
		NativeFieldInfoPtr_OnFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnFixedUpdate");
		NativeFieldInfoPtr_OnLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnLateUpdate");
		NativeFieldInfoPtr_OnLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnLoadScene");
		NativeFieldInfoPtr_OnLongClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnLongClick");
		NativeFieldInfoPtr_OnNodeFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnNodeFixedUpdate");
		NativeFieldInfoPtr_OnNodeLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnNodeLateUpdate");
		NativeFieldInfoPtr_OnNodeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnNodeUpdate");
		NativeFieldInfoPtr_OnPointerDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnPointerDown");
		NativeFieldInfoPtr_OnPointerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnPointerEnter");
		NativeFieldInfoPtr_OnPointerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnPointerExit");
		NativeFieldInfoPtr_OnPointerUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnPointerUp");
		NativeFieldInfoPtr_OnSceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnSceneLoaded");
		NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnSelected");
		NativeFieldInfoPtr_OnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnTrigger");
		NativeFieldInfoPtr_OnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OnUpdate");
		NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Open");
		NativeFieldInfoPtr_OpenControlPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenControlPanel");
		NativeFieldInfoPtr_OpenDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenDatabase");
		NativeFieldInfoPtr_OpenDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenDrawer");
		NativeFieldInfoPtr_OpenGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenGraph");
		NativeFieldInfoPtr_OpenNody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenNody");
		NativeFieldInfoPtr_OpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenSpeed");
		NativeFieldInfoPtr_OpenSubGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenSubGraph");
		NativeFieldInfoPtr_Opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Opened");
		NativeFieldInfoPtr_OpenedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OpenedPosition");
		NativeFieldInfoPtr_OperationCannotBeUndone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OperationCannotBeUndone");
		NativeFieldInfoPtr_OrientationDetectorDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OrientationDetectorDescription");
		NativeFieldInfoPtr_OtherReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OtherReferences");
		NativeFieldInfoPtr_OutputAudioMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OutputAudioMixerGroup");
		NativeFieldInfoPtr_OutputConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OutputConnected");
		NativeFieldInfoPtr_OutputConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OutputConnections");
		NativeFieldInfoPtr_OutputMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OutputMixerGroup");
		NativeFieldInfoPtr_OutputNotConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OutputNotConnected");
		NativeFieldInfoPtr_Overlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Overlay");
		NativeFieldInfoPtr_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Override");
		NativeFieldInfoPtr_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OverrideColor");
		NativeFieldInfoPtr_Overview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Overview");
		NativeFieldInfoPtr_OverviewZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "OverviewZoom");
		NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ParameterName");
		NativeFieldInfoPtr_ParameterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ParameterType");
		NativeFieldInfoPtr_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ParticleSystem");
		NativeFieldInfoPtr_Paste = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Paste");
		NativeFieldInfoPtr_PauseAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PauseAllSounds");
		NativeFieldInfoPtr_PercentageOfScreenZeroToOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PercentageOfScreenZeroToOne");
		NativeFieldInfoPtr_PitchSemitones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PitchSemitones");
		NativeFieldInfoPtr_Play = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Play");
		NativeFieldInfoPtr_PlayAnimationInZeroSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PlayAnimationInZeroSeconds");
		NativeFieldInfoPtr_PlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PlayMode");
		NativeFieldInfoPtr_PlaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PlaySound");
		NativeFieldInfoPtr_PleaseEnterNewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PleaseEnterNewName");
		NativeFieldInfoPtr_PopupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PopupName");
		NativeFieldInfoPtr_PopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PopupPrefab");
		NativeFieldInfoPtr_Portal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Portal");
		NativeFieldInfoPtr_PortalNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PortalNodeName");
		NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Prefix");
		NativeFieldInfoPtr_PresetCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PresetCategory");
		NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PresetName");
		NativeFieldInfoPtr_PreviewAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PreviewAnimation");
		NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Progress");
		NativeFieldInfoPtr_ProgressTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ProgressTargets");
		NativeFieldInfoPtr_Progressor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Progressor");
		NativeFieldInfoPtr_Progressors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Progressors");
		NativeFieldInfoPtr_PunchBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "PunchBy");
		NativeFieldInfoPtr_RandomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RandomDuration");
		NativeFieldInfoPtr_RandomNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RandomNodeName");
		NativeFieldInfoPtr_Recent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Recent");
		NativeFieldInfoPtr_Refresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Refresh");
		NativeFieldInfoPtr_RefreshDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RefreshDatabase");
		NativeFieldInfoPtr_RegisterInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RegisterInterval");
		NativeFieldInfoPtr_Remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Remove");
		NativeFieldInfoPtr_RemoveCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveCategory");
		NativeFieldInfoPtr_RemoveDuplicates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveDuplicates");
		NativeFieldInfoPtr_RemoveEmptyCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveEmptyCategories");
		NativeFieldInfoPtr_RemoveEmptyEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveEmptyEntries");
		NativeFieldInfoPtr_RemoveItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveItem");
		NativeFieldInfoPtr_RemoveNullEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveNullEntries");
		NativeFieldInfoPtr_RemoveSymbolFromAllBuildTargetGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemoveSymbolFromAllBuildTargetGroups");
		NativeFieldInfoPtr_RemovedDuplicateEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemovedDuplicateEntries");
		NativeFieldInfoPtr_RemovedEntriesWithNoName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemovedEntriesWithNoName");
		NativeFieldInfoPtr_RemovedEntriesWithNullPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemovedEntriesWithNullPrefabs");
		NativeFieldInfoPtr_RemovedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemovedEntry");
		NativeFieldInfoPtr_RemovedNullEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RemovedNullEntries");
		NativeFieldInfoPtr_Rename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Rename");
		NativeFieldInfoPtr_RenameCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameCategory");
		NativeFieldInfoPtr_RenameCategoryDialogMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameCategoryDialogMessage");
		NativeFieldInfoPtr_RenameGameObjectTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameGameObjectTo");
		NativeFieldInfoPtr_RenameNodeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameNodeTo");
		NativeFieldInfoPtr_RenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenamePrefix");
		NativeFieldInfoPtr_RenameSoundDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameSoundDatabase");
		NativeFieldInfoPtr_RenameSoundDatabaseDialogMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameSoundDatabaseDialogMessage");
		NativeFieldInfoPtr_RenameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameSuffix");
		NativeFieldInfoPtr_RenameTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RenameTo");
		NativeFieldInfoPtr_Reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Reset");
		NativeFieldInfoPtr_ResetAnimationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetAnimationSettings");
		NativeFieldInfoPtr_ResetClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetClosedPosition");
		NativeFieldInfoPtr_ResetDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetDatabase");
		NativeFieldInfoPtr_ResetOpenedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetOpenedPosition");
		NativeFieldInfoPtr_ResetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetPosition");
		NativeFieldInfoPtr_ResetRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetRoot");
		NativeFieldInfoPtr_ResetTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetTrigger");
		NativeFieldInfoPtr_ResetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ResetValue");
		NativeFieldInfoPtr_ReversedProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ReversedProgress");
		NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Right");
		NativeFieldInfoPtr_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Rotate");
		NativeFieldInfoPtr_RotateBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RotateBy");
		NativeFieldInfoPtr_RotateFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RotateFrom");
		NativeFieldInfoPtr_RotateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RotateMode");
		NativeFieldInfoPtr_RotateTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RotateTo");
		NativeFieldInfoPtr_RuntimeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RuntimeOptions");
		NativeFieldInfoPtr_RuntimePreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "RuntimePreset");
		NativeFieldInfoPtr_Save = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Save");
		NativeFieldInfoPtr_SaveAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SaveAs");
		NativeFieldInfoPtr_SavePreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SavePreset");
		NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Scale");
		NativeFieldInfoPtr_ScaleBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ScaleBy");
		NativeFieldInfoPtr_ScaleFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ScaleFrom");
		NativeFieldInfoPtr_ScaleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ScaleTo");
		NativeFieldInfoPtr_Scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Scene");
		NativeFieldInfoPtr_SceneActivationDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SceneActivationDelay");
		NativeFieldInfoPtr_SceneBuildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SceneBuildIndex");
		NativeFieldInfoPtr_SceneLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SceneLoad");
		NativeFieldInfoPtr_SceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SceneName");
		NativeFieldInfoPtr_SceneUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SceneUnload");
		NativeFieldInfoPtr_ScriptingDefineSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ScriptingDefineSymbol");
		NativeFieldInfoPtr_Search = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Search");
		NativeFieldInfoPtr_SearchForCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SearchForCategories");
		NativeFieldInfoPtr_SearchForDatabases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SearchForDatabases");
		NativeFieldInfoPtr_SearchForUIPopupLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SearchForUIPopupLinks");
		NativeFieldInfoPtr_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Seconds");
		NativeFieldInfoPtr_SecondsDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SecondsDelay");
		NativeFieldInfoPtr_Select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Select");
		NativeFieldInfoPtr_SelectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SelectButton");
		NativeFieldInfoPtr_SelectSwipeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SelectSwipeDirection");
		NativeFieldInfoPtr_SelectedLoopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SelectedLoopAnimation");
		NativeFieldInfoPtr_Send = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Send");
		NativeFieldInfoPtr_SendGameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SendGameEvent");
		NativeFieldInfoPtr_SendGameEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SendGameEvents");
		NativeFieldInfoPtr_SetActiveNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetActiveNode");
		NativeFieldInfoPtr_SetAsSoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetAsSoundName");
		NativeFieldInfoPtr_SetBoolValueTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetBoolValueTo");
		NativeFieldInfoPtr_SetFloatValueTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetFloatValueTo");
		NativeFieldInfoPtr_SetIntValueTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetIntValueTo");
		NativeFieldInfoPtr_SetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetPosition");
		NativeFieldInfoPtr_SetTargetGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetTargetGameObject");
		NativeFieldInfoPtr_SetUIButtonToListenFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetUIButtonToListenFor");
		NativeFieldInfoPtr_SetUIDrawerToListenFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetUIDrawerToListenFor");
		NativeFieldInfoPtr_SetUIViewToListenFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetUIViewToListenFor");
		NativeFieldInfoPtr_SetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SetValue");
		NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Settings");
		NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Show");
		NativeFieldInfoPtr_ShowAnimationWillNotWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ShowAnimationWillNotWork");
		NativeFieldInfoPtr_ShowCurveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ShowCurveModifier");
		NativeFieldInfoPtr_ShowPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ShowPopup");
		NativeFieldInfoPtr_ShowProgressor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ShowProgressor");
		NativeFieldInfoPtr_ShowView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ShowView");
		NativeFieldInfoPtr_ShowViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ShowViews");
		NativeFieldInfoPtr_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Simulate");
		NativeFieldInfoPtr_SocialLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SocialLinks");
		NativeFieldInfoPtr_Socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Socket");
		NativeFieldInfoPtr_Sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Sort");
		NativeFieldInfoPtr_SortDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SortDatabase");
		NativeFieldInfoPtr_SortingSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SortingSteps");
		NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Sound");
		NativeFieldInfoPtr_SoundAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundAction");
		NativeFieldInfoPtr_SoundDatabases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundDatabases");
		NativeFieldInfoPtr_SoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundName");
		NativeFieldInfoPtr_SoundNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundNodeName");
		NativeFieldInfoPtr_SoundSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundSource");
		NativeFieldInfoPtr_Sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Sounds");
		NativeFieldInfoPtr_Soundy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Soundy");
		NativeFieldInfoPtr_SoundyDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundyDatabase");
		NativeFieldInfoPtr_SoundySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SoundySettings");
		NativeFieldInfoPtr_SourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SourceName");
		NativeFieldInfoPtr_Sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Sources");
		NativeFieldInfoPtr_SpatialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SpatialBlend");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_StartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "StartDelay");
		NativeFieldInfoPtr_StartNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "StartNodeName");
		NativeFieldInfoPtr_StopAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "StopAllSounds");
		NativeFieldInfoPtr_StopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "StopAnimation");
		NativeFieldInfoPtr_StopBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "StopBehavior");
		NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "StopSound");
		NativeFieldInfoPtr_SubGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SubGraph");
		NativeFieldInfoPtr_SubGraphNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SubGraphNodeName");
		NativeFieldInfoPtr_Suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Suffix");
		NativeFieldInfoPtr_SupportEmail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SupportEmail");
		NativeFieldInfoPtr_SwipeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SwipeDirection");
		NativeFieldInfoPtr_SwipeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SwipeLength");
		NativeFieldInfoPtr_SwipeLengthDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SwipeLengthDescription");
		NativeFieldInfoPtr_SwitchBackNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SwitchBackNodeName");
		NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Target");
		NativeFieldInfoPtr_TargetAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetAnimator");
		NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnAnimatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetAnimatorDoesNotHaveAnAnimatorController");
		NativeFieldInfoPtr_TargetAnimatorDoesNotHaveAnyParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetAnimatorDoesNotHaveAnyParameters");
		NativeFieldInfoPtr_TargetCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetCanvas");
		NativeFieldInfoPtr_TargetFsm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetFsm");
		NativeFieldInfoPtr_TargetGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetGameObject");
		NativeFieldInfoPtr_TargetLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetLabel");
		NativeFieldInfoPtr_TargetOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetOrientation");
		NativeFieldInfoPtr_TargetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetProgress");
		NativeFieldInfoPtr_TargetTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetTimeScale");
		NativeFieldInfoPtr_TargetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetValue");
		NativeFieldInfoPtr_TargetVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TargetVariable");
		NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Text");
		NativeFieldInfoPtr_TextLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TextLabel");
		NativeFieldInfoPtr_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TextMeshPro");
		NativeFieldInfoPtr_TextMeshProLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TextMeshProLabel");
		NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Time");
		NativeFieldInfoPtr_TimeScaleNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TimeScaleNodeName");
		NativeFieldInfoPtr_ToggleComponentBehaviors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleComponentBehaviors");
		NativeFieldInfoPtr_ToggleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleLabel");
		NativeFieldInfoPtr_ToggleOFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleOFF");
		NativeFieldInfoPtr_ToggleON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleON");
		NativeFieldInfoPtr_ToggleProgressor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleProgressor");
		NativeFieldInfoPtr_ToggleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleSettings");
		NativeFieldInfoPtr_ToggleSupportForThirdPartyPlugins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ToggleSupportForThirdPartyPlugins");
		NativeFieldInfoPtr_TouchySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TouchySettings");
		NativeFieldInfoPtr_TriggerAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TriggerAction");
		NativeFieldInfoPtr_TriggerEventsAfterAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TriggerEventsAfterAnimation");
		NativeFieldInfoPtr_TriggerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "TriggerName");
		NativeFieldInfoPtr_UIDrawerNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UIDrawerNodeName");
		NativeFieldInfoPtr_UINodeNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UINodeNodeName");
		NativeFieldInfoPtr_UIPopupDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UIPopupDatabase");
		NativeFieldInfoPtr_UnityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnityEvent");
		NativeFieldInfoPtr_UnityEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnityEvents");
		NativeFieldInfoPtr_UnloadSceneNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnloadSceneNodeName");
		NativeFieldInfoPtr_UnmuteAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnmuteAllSounds");
		NativeFieldInfoPtr_UnpauseAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnpauseAllSounds");
		NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Up");
		NativeFieldInfoPtr_UpdateContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdateContainer");
		NativeFieldInfoPtr_UpdateEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdateEffect");
		NativeFieldInfoPtr_UpdateOnHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdateOnHide");
		NativeFieldInfoPtr_UpdateOnShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdateOnShow");
		NativeFieldInfoPtr_UpdatePopupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdatePopupName");
		NativeFieldInfoPtr_UpdatePopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdatePopupPrefab");
		NativeFieldInfoPtr_UpdateValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UpdateValue");
		NativeFieldInfoPtr_UseBackButtonDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UseBackButtonDescription");
		NativeFieldInfoPtr_UseCustomFromAndTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UseCustomFromAndTo");
		NativeFieldInfoPtr_UseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UseMultiplier");
		NativeFieldInfoPtr_UsefulLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UsefulLinks");
		NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Value");
		NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Version");
		NativeFieldInfoPtr_Vibrato = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Vibrato");
		NativeFieldInfoPtr_ViewCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ViewCategory");
		NativeFieldInfoPtr_ViewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ViewName");
		NativeFieldInfoPtr_VirtualButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "VirtualButton");
		NativeFieldInfoPtr_VolumeDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "VolumeDb");
		NativeFieldInfoPtr_WaitFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WaitFor");
		NativeFieldInfoPtr_WaitForAnimationToFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WaitForAnimationToFinish");
		NativeFieldInfoPtr_WaitForSceneToUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WaitForSceneToUnload");
		NativeFieldInfoPtr_WaitNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WaitNodeName");
		NativeFieldInfoPtr_Warning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Warning");
		NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Weight");
		NativeFieldInfoPtr_WhenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WhenClosed");
		NativeFieldInfoPtr_WhenUIDrawerIsClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WhenUIDrawerIsClosed");
		NativeFieldInfoPtr_WhenUIPopupIsHiddenDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WhenUIPopupIsHiddenDisable");
		NativeFieldInfoPtr_WhenUIViewIsHiddenDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WhenUIViewIsHiddenDisable");
		NativeFieldInfoPtr_WholeNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WholeNumbers");
		NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Width");
		NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "X");
		NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Y");
		NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "Yes");
		NativeFieldInfoPtr_YouAreResponsibleToUpdateYourCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "YouAreResponsibleToUpdateYourCode");
		NativeFieldInfoPtr_YouCanOnlyAddPrefabsToDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "YouCanOnlyAddPrefabsToDatabase");
		NativeFieldInfoPtr_YouTube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "YouTube");
		NativeFieldInfoPtr_MissingTargetFsmMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingTargetFsmMessage");
		NativeFieldInfoPtr_SelectListenerToActivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SelectListenerToActivateMessage");
		NativeFieldInfoPtr_HowToUsePlaymakerEventDispatcherMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "HowToUsePlaymakerEventDispatcherMessage");
		NativeFieldInfoPtr_MissingDrawerNameTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingDrawerNameTitle");
		NativeFieldInfoPtr_MissingDrawerNameMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingDrawerNameMessage");
		NativeFieldInfoPtr_MissingGameEventTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingGameEventTitle");
		NativeFieldInfoPtr_MissingGameEventMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingGameEventMessage");
		NativeFieldInfoPtr_MissingSceneNameTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingSceneNameTitle");
		NativeFieldInfoPtr_MissingSceneNameMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "MissingSceneNameMessage");
		NativeFieldInfoPtr_WrongSceneBuildIndexTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WrongSceneBuildIndexTitle");
		NativeFieldInfoPtr_WrongSceneBuildIndexMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "WrongSceneBuildIndexMessage");
		NativeFieldInfoPtr_DoubleClickNodeToOpenSubGraphMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DoubleClickNodeToOpenSubGraphMessage");
		NativeFieldInfoPtr_DuplicateNodeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DuplicateNodeMessage");
		NativeFieldInfoPtr_DuplicateNodeTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "DuplicateNodeTitle");
		NativeFieldInfoPtr_NoGraphReferencedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoGraphReferencedMessage");
		NativeFieldInfoPtr_NoGraphReferencedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoGraphReferencedTitle");
		NativeFieldInfoPtr_NoSourceConnectedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoSourceConnectedMessage");
		NativeFieldInfoPtr_NoSourceConnectedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoSourceConnectedTitle");
		NativeFieldInfoPtr_NoSubGraphReferencedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoSubGraphReferencedMessage");
		NativeFieldInfoPtr_NoSubGraphReferencedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoSubGraphReferencedTitle");
		NativeFieldInfoPtr_NoTargetConnectedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoTargetConnectedMessage");
		NativeFieldInfoPtr_NoTargetConnectedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NoTargetConnectedTitle");
		NativeFieldInfoPtr_NotConnectedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotConnectedMessage");
		NativeFieldInfoPtr_NotConnectedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotConnectedTitle");
		NativeFieldInfoPtr_NotListeningForAnyGameEventMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotListeningForAnyGameEventMessage");
		NativeFieldInfoPtr_NotListeningForAnyGameEventTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotListeningForAnyGameEventTitle");
		NativeFieldInfoPtr_NotSendingAnyGameEventMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotSendingAnyGameEventMessage");
		NativeFieldInfoPtr_NotSendingAnyGameEventTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "NotSendingAnyGameEventTitle");
		NativeFieldInfoPtr_ProgressTargetAnimatorParameterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ProgressTargetAnimatorParameterInfo");
		NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ReferencedGraphIsNotSubGraphMessage");
		NativeFieldInfoPtr_ReferencedGraphIsNotSubGraphTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ReferencedGraphIsNotSubGraphTitle");
		NativeFieldInfoPtr_ReferencedGraphIsSubGraphMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ReferencedGraphIsSubGraphMessage");
		NativeFieldInfoPtr_ReferencedGraphIsSubGraphTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ReferencedGraphIsSubGraphTitle");
		NativeFieldInfoPtr_SomeProgressTargetsGetUpdatedOnlyInPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SomeProgressTargetsGetUpdatedOnlyInPlayMode");
		NativeFieldInfoPtr_SupportForMasterAudioNotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SupportForMasterAudioNotEnabled");
		NativeFieldInfoPtr_SupportForPlaymakerNotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SupportForPlaymakerNotEnabled");
		NativeFieldInfoPtr_SupportForTextMeshProNotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "SupportForTextMeshProNotEnabled");
		NativeFieldInfoPtr_ThisClassShouldBeExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "ThisClassShouldBeExtended");
		NativeFieldInfoPtr_UnnamedNodeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnnamedNodeMessage");
		NativeFieldInfoPtr_UnnamedNodeTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, "UnnamedNodeTitle");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UILanguagePack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, 100667425);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr, 100667426);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726834, XrefRangeEnd = 728091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UILanguagePack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILanguagePack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UILanguagePack(IntPtr pointer)
		: base(pointer)
	{
	}
}
