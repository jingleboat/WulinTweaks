using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class UiSingletonPrefab<T> : SerializedMonoBehaviour where T : UiSingletonPrefab<T>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_uiBlockers;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTimeStopper;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInGameTimeStopper;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreBackToMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoHideOnStoryIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoClearLeftLogs;

	private static readonly System.IntPtr NativeFieldInfoPtr_mIsBlocking;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiStacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiPrefabNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHiding;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectInMemory;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourceAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyOnDisableLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCGHelper;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedDlcMode;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uIVariant_Public_Static_get_UIVariant_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_uIVariant_Public_Static_set_Void_UIVariant_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CachedCGHelper_Public_get_CanvasGroupHelper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStoryIn_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBackToMenu_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInstance_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBlock_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldShow_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsShowing_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAfterTween_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBlock_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideByMessage_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Hide_b__35_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Hide_b__35_1_Private_Void_0;

	public unsafe Il2CppStringArray uiBlockers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiBlockers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiBlockers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool isTimeStopper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTimeStopper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTimeStopper)) = flag;
		}
	}

	public unsafe bool isInGameTimeStopper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInGameTimeStopper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInGameTimeStopper)) = flag;
		}
	}

	public unsafe bool ignoreBackToMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreBackToMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreBackToMenu)) = flag;
		}
	}

	public unsafe bool autoHideOnStoryIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoHideOnStoryIn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoHideOnStoryIn)) = flag;
		}
	}

	public unsafe bool autoClearLeftLogs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClearLeftLogs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClearLeftLogs)) = flag;
		}
	}

	public unsafe bool mIsBlocking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mIsBlocking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mIsBlocking)) = flag;
		}
	}

	public unsafe static List<UiSingletonPrefab<T>> uiStacks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uiStacks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UiSingletonPrefab<T>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uiStacks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Dictionary<string, string> uiPrefabNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uiPrefabNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uiPrefabNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int drawOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawOrder);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawOrder)) = num;
		}
	}

	public unsafe bool isHiding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHiding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHiding)) = flag;
		}
	}

	public unsafe GameObject objectInMemory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectInMemory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectInMemory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe string resourceAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceAddress);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceAddress)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe GameManager.DeviceStandard destroyOnDisableLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyOnDisableLevel);
			return *(GameManager.DeviceStandard*)num;
		}
		set
		{
			*(GameManager.DeviceStandard*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyOnDisableLevel)) = deviceStandard;
		}
	}

	public unsafe static T m_instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, (void*)(&intPtr));
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
		}
		set
		{
			//IL_0052->IL0055: Incompatible stack types: I vs Ref
			//IL_0031->IL0055: Incompatible stack types: I vs Ref
			//IL_003e->IL0055: Incompatible stack types: I vs Ref
			//IL_0045->IL0055: Incompatible stack types: I vs Ref
			System.IntPtr nativeFieldInfoPtr_m_instance = NativeFieldInfoPtr_m_instance;
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = val2;
				if (val is string)
				{
					reference = ref *(T*)IL2CPP.ManagedStringToIl2Cpp(val as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null));
					reference = ref *(T*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(T*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(T*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref val2;
			}
			IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_m_instance, Unsafe.AsPointer(ref reference));
		}
	}

	public unsafe CanvasGroupHelper cachedCGHelper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCGHelper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroupHelper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCGHelper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasGroupHelper));
		}
	}

	public unsafe GameDlcMode cachedDlcMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDlcMode);
			return *(GameDlcMode*)num;
		}
		set
		{
			*(GameDlcMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDlcMode)) = gameDlcMode;
		}
	}

	public unsafe static UIVariant uIVariant
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970804, XrefRangeEnd = 970806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uIVariant_Public_Static_get_UIVariant_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIVariant>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970806, XrefRangeEnd = 970808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uIVariant_Public_Static_set_Void_UIVariant_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CanvasGroupHelper CachedCGHelper
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 970815, RefRangeEnd = 970830, XrefRangeStart = 970808, XrefRangeEnd = 970815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CachedCGHelper_Public_get_CanvasGroupHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroupHelper>(intPtr) : null;
		}
	}

	public unsafe static T Instance
	{
		[CallerCount(1129)]
		[CachedScanResults(RefRangeStart = 970891, RefRangeEnd = 972020, XrefRangeStart = 970830, XrefRangeEnd = 970891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	static UiSingletonPrefab()
	{
		Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UiSingletonPrefab`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr);
		NativeFieldInfoPtr_uiBlockers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "uiBlockers");
		NativeFieldInfoPtr_isTimeStopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "isTimeStopper");
		NativeFieldInfoPtr_isInGameTimeStopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "isInGameTimeStopper");
		NativeFieldInfoPtr_ignoreBackToMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "ignoreBackToMenu");
		NativeFieldInfoPtr_autoHideOnStoryIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "autoHideOnStoryIn");
		NativeFieldInfoPtr_autoClearLeftLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "autoClearLeftLogs");
		NativeFieldInfoPtr_mIsBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "mIsBlocking");
		NativeFieldInfoPtr_uiStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "uiStacks");
		NativeFieldInfoPtr_uiPrefabNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "uiPrefabNames");
		NativeFieldInfoPtr_drawOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "drawOrder");
		NativeFieldInfoPtr_isHiding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "isHiding");
		NativeFieldInfoPtr_objectInMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "objectInMemory");
		NativeFieldInfoPtr_resourceAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "resourceAddress");
		NativeFieldInfoPtr_destroyOnDisableLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "destroyOnDisableLevel");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "m_instance");
		NativeFieldInfoPtr_cachedCGHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "cachedCGHelper");
		NativeFieldInfoPtr_cachedDlcMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, "cachedDlcMode");
		NativeMethodInfoPtr_get_uIVariant_Public_Static_get_UIVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678138);
		NativeMethodInfoPtr_set_uIVariant_Public_Static_set_Void_UIVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678139);
		NativeMethodInfoPtr_get_CachedCGHelper_Public_get_CanvasGroupHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678140);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678141);
		NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678142);
		NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678143);
		NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678144);
		NativeMethodInfoPtr_OnStoryIn_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678145);
		NativeMethodInfoPtr_OnBackToMenu_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678146);
		NativeMethodInfoPtr_HasInstance_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678147);
		NativeMethodInfoPtr_IsBlock_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678148);
		NativeMethodInfoPtr_CouldShow_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678149);
		NativeMethodInfoPtr_IsShowing_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678150);
		NativeMethodInfoPtr_Show_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678151);
		NativeMethodInfoPtr_ShowAfterTween_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678152);
		NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678153);
		NativeMethodInfoPtr_SetBlock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678154);
		NativeMethodInfoPtr_HideByMessage_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678155);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678156);
		NativeMethodInfoPtr__Hide_b__35_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678158);
		NativeMethodInfoPtr__Hide_b__35_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr, 100678159);
	}

	[CallerCount(58)]
	[CachedScanResults(RefRangeStart = 972069, RefRangeEnd = 972127, XrefRangeStart = 972020, XrefRangeEnd = 972069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 972141, RefRangeEnd = 972146, XrefRangeStart = 972127, XrefRangeEnd = 972141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 972168, RefRangeEnd = 972173, XrefRangeStart = 972146, XrefRangeEnd = 972168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972173, XrefRangeEnd = 972177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnStoryIn(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStoryIn_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972177, XrefRangeEnd = 972181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBackToMenu(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBackToMenu_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 972194, RefRangeEnd = 972207, XrefRangeStart = 972181, XrefRangeEnd = 972194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInstance_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972211, RefRangeEnd = 972212, XrefRangeStart = 972207, XrefRangeEnd = 972211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBlock(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlock_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972212, XrefRangeEnd = 972224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CouldShow()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldShow_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(123)]
	[CachedScanResults(RefRangeStart = 972237, RefRangeEnd = 972360, XrefRangeStart = 972224, XrefRangeEnd = 972237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsShowing()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsShowing_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(94)]
	[CachedScanResults(RefRangeStart = 972384, RefRangeEnd = 972478, XrefRangeStart = 972360, XrefRangeEnd = 972384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Show(bool isInstant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isInstant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Show_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ShowAfterTween()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShowAfterTween_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(85)]
	[CachedScanResults(RefRangeStart = 972505, RefRangeEnd = 972590, XrefRangeStart = 972478, XrefRangeEnd = 972505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Hide(bool isInstant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isInstant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 972642, RefRangeEnd = 972644, XrefRangeStart = 972590, XrefRangeEnd = 972642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBlock(bool block)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&block);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBlock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972644, XrefRangeEnd = 972645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideByMessage(bool instant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideByMessage_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(112)]
	[CachedScanResults(RefRangeStart = 972649, RefRangeEnd = 972761, XrefRangeStart = 972645, XrefRangeEnd = 972649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UiSingletonPrefab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UiSingletonPrefab<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 972779, RefRangeEnd = 972787, XrefRangeStart = 972761, XrefRangeEnd = 972779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Hide_b__35_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Hide_b__35_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 972779, RefRangeEnd = 972787, XrefRangeStart = 972779, XrefRangeEnd = 972787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Hide_b__35_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Hide_b__35_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UiSingletonPrefab(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
