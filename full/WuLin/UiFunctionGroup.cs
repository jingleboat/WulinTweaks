using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class UiFunctionGroup : MonoBehaviour
{
	public enum RewiredCatagory
	{
		UI_LeftStick = 0,
		UI_RightStick = 1,
		UI_DPad = 2,
		UI_FunctionButtons = 3,
		Standard_Sticks = 100,
		Standard_Buttons = 101
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCanvasGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCanvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayingUiStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiRefDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_activedUiFunctionGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysActivedUiFunctionGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedJoystickActionCategoriesViaUiRefKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiRefKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiUniqueKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_noDefaultSelectObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultSelectObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInactiveGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAlwaysActived;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCanvasOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedSelectedObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoSelectCachedNearbyIfCachedIsInactive;

	private static readonly System.IntPtr NativeFieldInfoPtr_oldActiveRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_notCacheSelectWhenDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBecomeActiveGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBecomeInactiveGroup;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckActivedUiFunctionGroup_Public_Static_Void_UiFunctionGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckJoystickActionCategories_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBecomeActiveGroup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPreBecomeDisactiveGroup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterBecomeDisactiveGroup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControlMethodChange_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSwitchControl_Public_Void_ControlMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActiveUi_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultSelectObject_Public_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CanvasGroup cachedCanvasGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvasGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvasGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasGroup));
		}
	}

	public unsafe Canvas cachedCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas));
		}
	}

	public unsafe static List<UiFunctionGroup> displayingUiStack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displayingUiStack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UiFunctionGroup>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displayingUiStack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Dictionary<string, HashSet<UiFunctionGroup>> uiRefDict
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uiRefDict, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<UiFunctionGroup>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uiRefDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, UiFunctionGroup> uiDict
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uiDict, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, UiFunctionGroup>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uiDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static HashSet<UiFunctionGroup> activedUiFunctionGroup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activedUiFunctionGroup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<UiFunctionGroup>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activedUiFunctionGroup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static HashSet<UiFunctionGroup> alwaysActivedUiFunctionGroup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_alwaysActivedUiFunctionGroup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<UiFunctionGroup>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_alwaysActivedUiFunctionGroup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static string cachedJoystickActionCategoriesViaUiRefKey
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedJoystickActionCategoriesViaUiRefKey, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedJoystickActionCategoriesViaUiRefKey, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string uiRefKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiRefKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiRefKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string uiUniqueKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiUniqueKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiUniqueKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool noDefaultSelectObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noDefaultSelectObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noDefaultSelectObject)) = flag;
		}
	}

	public unsafe GameObject defaultSelectObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSelectObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSelectObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool isInactiveGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInactiveGroup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInactiveGroup)) = flag;
		}
	}

	public unsafe bool isAlwaysActived
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlwaysActived);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlwaysActived)) = flag;
		}
	}

	public unsafe int cachedCanvasOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvasOrder);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvasOrder)) = num;
		}
	}

	public unsafe GameObject cachedSelectedObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSelectedObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSelectedObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool autoSelectCachedNearbyIfCachedIsInactive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoSelectCachedNearbyIfCachedIsInactive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoSelectCachedNearbyIfCachedIsInactive)) = flag;
		}
	}

	public unsafe bool oldActiveRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldActiveRule);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldActiveRule)) = flag;
		}
	}

	public unsafe bool notCacheSelectWhenDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notCacheSelectWhenDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notCacheSelectWhenDisable)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action onBecomeActiveGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBecomeActiveGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBecomeActiveGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action onBecomeInactiveGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBecomeInactiveGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBecomeInactiveGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static UiFunctionGroup()
	{
		Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UiFunctionGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr);
		NativeFieldInfoPtr_cachedCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "cachedCanvasGroup");
		NativeFieldInfoPtr_cachedCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "cachedCanvas");
		NativeFieldInfoPtr_displayingUiStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "displayingUiStack");
		NativeFieldInfoPtr_uiRefDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "uiRefDict");
		NativeFieldInfoPtr_uiDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "uiDict");
		NativeFieldInfoPtr_activedUiFunctionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "activedUiFunctionGroup");
		NativeFieldInfoPtr_alwaysActivedUiFunctionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "alwaysActivedUiFunctionGroup");
		NativeFieldInfoPtr_cachedJoystickActionCategoriesViaUiRefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "cachedJoystickActionCategoriesViaUiRefKey");
		NativeFieldInfoPtr_uiRefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "uiRefKey");
		NativeFieldInfoPtr_uiUniqueKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "uiUniqueKey");
		NativeFieldInfoPtr_noDefaultSelectObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "noDefaultSelectObject");
		NativeFieldInfoPtr_defaultSelectObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "defaultSelectObject");
		NativeFieldInfoPtr_isInactiveGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "isInactiveGroup");
		NativeFieldInfoPtr_isAlwaysActived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "isAlwaysActived");
		NativeFieldInfoPtr_cachedCanvasOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "cachedCanvasOrder");
		NativeFieldInfoPtr_cachedSelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "cachedSelectedObject");
		NativeFieldInfoPtr_autoSelectCachedNearbyIfCachedIsInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "autoSelectCachedNearbyIfCachedIsInactive");
		NativeFieldInfoPtr_oldActiveRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "oldActiveRule");
		NativeFieldInfoPtr_notCacheSelectWhenDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "notCacheSelectWhenDisable");
		NativeFieldInfoPtr_onBecomeActiveGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "onBecomeActiveGroup");
		NativeFieldInfoPtr_onBecomeInactiveGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, "onBecomeInactiveGroup");
		NativeMethodInfoPtr_CheckActivedUiFunctionGroup_Public_Static_Void_UiFunctionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678848);
		NativeMethodInfoPtr_CheckJoystickActionCategories_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678849);
		NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678850);
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678851);
		NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678852);
		NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678853);
		NativeMethodInfoPtr_OnBecomeActiveGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678854);
		NativeMethodInfoPtr_OnPreBecomeDisactiveGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678855);
		NativeMethodInfoPtr_OnAfterBecomeDisactiveGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678856);
		NativeMethodInfoPtr_OnControlMethodChange_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678857);
		NativeMethodInfoPtr_OnSwitchControl_Public_Void_ControlMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678858);
		NativeMethodInfoPtr_IsActiveUi_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678859);
		NativeMethodInfoPtr_SetDefaultSelectObject_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678860);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr, 100678861);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 986693, RefRangeEnd = 986695, XrefRangeStart = 986585, XrefRangeEnd = 986693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckActivedUiFunctionGroup(UiFunctionGroup newEnabledFunctionGroup = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newEnabledFunctionGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckActivedUiFunctionGroup_Public_Static_Void_UiFunctionGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 986708, RefRangeEnd = 986709, XrefRangeStart = 986695, XrefRangeEnd = 986708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckJoystickActionCategories(string uiRefKey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uiRefKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckJoystickActionCategories_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986709, XrefRangeEnd = 986720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 986806, RefRangeEnd = 986807, XrefRangeStart = 986720, XrefRangeEnd = 986806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 986877, RefRangeEnd = 986878, XrefRangeStart = 986807, XrefRangeEnd = 986877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 986914, RefRangeEnd = 986915, XrefRangeStart = 986878, XrefRangeEnd = 986914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBecomeActiveGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBecomeActiveGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 986934, RefRangeEnd = 986935, XrefRangeStart = 986915, XrefRangeEnd = 986934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPreBecomeDisactiveGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPreBecomeDisactiveGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAfterBecomeDisactiveGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterBecomeDisactiveGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986935, XrefRangeEnd = 986943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnControlMethodChange(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnControlMethodChange_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986943, XrefRangeEnd = 986948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSwitchControl(InputManager.ControlMethod controlMethod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controlMethod);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSwitchControl_Public_Void_ControlMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 986955, RefRangeEnd = 986961, XrefRangeStart = 986948, XrefRangeEnd = 986955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActiveUi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActiveUi_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 986966, RefRangeEnd = 986998, XrefRangeStart = 986961, XrefRangeEnd = 986966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultSelectObject(GameObject defaultSelectObject, bool alsoSelect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultSelectObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoSelect;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultSelectObject_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986998, XrefRangeEnd = 986999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UiFunctionGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UiFunctionGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UiFunctionGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
