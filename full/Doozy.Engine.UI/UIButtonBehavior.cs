using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Events;
using Doozy.Engine.UI.Animation;
using Doozy.Engine.UI.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Doozy.Engine.UI;

[System.Serializable]
public class UIButtonBehavior : Il2CppSystem.Object
{
	[ObfuscatedName("Doozy.Engine.UI.UIButtonBehavior+<InvokeCallbacks>d__63")]
	public sealed class _InvokeCallbacks_d__63 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_animation;

		private static readonly System.IntPtr NativeFieldInfoPtr_onStartCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteCallback;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe UIAnimation animation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animation);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAnimation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimation));
			}
		}

		public unsafe UnityAction onStartCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStartCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStartCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityAction));
			}
		}

		public unsafe UnityAction onCompleteCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityAction));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _InvokeCallbacks_d__63()
		{
			Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "<InvokeCallbacks>d__63");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, "animation");
			NativeFieldInfoPtr_onStartCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, "onStartCallback");
			NativeFieldInfoPtr_onCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, "onCompleteCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, 100685494);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, 100685495);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, 100685496);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, 100685497);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, 100685498);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr, 100685499);
		}

		[CallerCount(575)]
		[CachedScanResults(RefRangeStart = 19473, RefRangeEnd = 20048, XrefRangeStart = 19473, XrefRangeEnd = 20048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _InvokeCallbacks_d__63(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_InvokeCallbacks_d__63>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729478, XrefRangeEnd = 729480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729480, XrefRangeEnd = 729485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _InvokeCallbacks_d__63(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_BUTTON_ANIMATION_TYPE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ENABLED;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_LOAD_SELECTED_PRESET_AT_RUNTIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_READY;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_SELECT_BUTTON;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_TRIGGER_EVENTS_AFTER_ANIMATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_BUTTON_DESELECTED_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_BUTTON_SELECTED_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_CLICK_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_DOUBLE_CLICK_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_LONG_CLICK_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_POINTER_DOWN_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_POINTER_ENTER_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_POINTER_EXIT_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON_POINTER_UP_DISABLE_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_Animators;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonAnimationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeselectButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadSelectedPresetAtRuntime;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_PresetCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_PresetName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PunchAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ready;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_StateAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_TriggerEventsAfterAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_behaviorType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultPresetCategory_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultPresetName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimatorsCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BehaviorType_Public_get_UIButtonBehaviorType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasAnimation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasAnimators_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasAnimatorEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEffect_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasGameEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPunchAnimation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasStateAnimation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasUnityEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIButtonBehaviorType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationTotalDuration_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPreset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPreset_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayAnimation_Public_Void_UIButton_Boolean_UnityAction_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_UIButtonBehaviorType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCallbacks_Private_Static_IEnumerator_UIAnimation_UnityAction_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationType_Public_Static_AnimationType_ButtonAnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultDisableInterval_Public_Static_Single_UIButtonBehaviorType_0;

	public unsafe static ButtonAnimationType DEFAULT_BUTTON_ANIMATION_TYPE
	{
		get
		{
			Unsafe.SkipInit(out ButtonAnimationType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BUTTON_ANIMATION_TYPE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BUTTON_ANIMATION_TYPE, (void*)(&buttonAnimationType));
		}
	}

	public unsafe static bool DEFAULT_DESELECT_BUTTON
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_ENABLED
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ENABLED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ENABLED, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_LOAD_SELECTED_PRESET_AT_RUNTIME
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_LOAD_SELECTED_PRESET_AT_RUNTIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_LOAD_SELECTED_PRESET_AT_RUNTIME, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_READY
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_READY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_READY, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_SELECT_BUTTON
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SELECT_BUTTON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SELECT_BUTTON, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_TRIGGER_EVENTS_AFTER_ANIMATION
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_TRIGGER_EVENTS_AFTER_ANIMATION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_TRIGGER_EVENTS_AFTER_ANIMATION, (void*)(&flag));
		}
	}

	public unsafe static float ON_BUTTON_DESELECTED_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_BUTTON_DESELECTED_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_BUTTON_DESELECTED_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_BUTTON_SELECTED_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_BUTTON_SELECTED_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_BUTTON_SELECTED_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_CLICK_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_CLICK_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_CLICK_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_DOUBLE_CLICK_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_DOUBLE_CLICK_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_DOUBLE_CLICK_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_LONG_CLICK_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_LONG_CLICK_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_LONG_CLICK_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_POINTER_DOWN_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_POINTER_DOWN_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_POINTER_DOWN_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_POINTER_ENTER_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_POINTER_ENTER_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_POINTER_ENTER_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_POINTER_EXIT_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_POINTER_EXIT_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_POINTER_EXIT_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static float ON_POINTER_UP_DISABLE_INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON_POINTER_UP_DISABLE_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON_POINTER_UP_DISABLE_INTERVAL, (void*)(&num));
		}
	}

	public unsafe List<AnimatorEvent> Animators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animators);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AnimatorEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animators)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ButtonAnimationType ButtonAnimationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonAnimationType);
			return *(ButtonAnimationType*)num;
		}
		set
		{
			*(ButtonAnimationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonAnimationType)) = buttonAnimationType;
		}
	}

	public unsafe bool DeselectButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeselectButton)) = flag;
		}
	}

	public unsafe float DisableInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableInterval)) = num;
		}
	}

	public unsafe bool Enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enabled)) = flag;
		}
	}

	public unsafe bool LoadSelectedPresetAtRuntime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSelectedPresetAtRuntime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadSelectedPresetAtRuntime)) = flag;
		}
	}

	public unsafe UIAction OnTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTrigger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTrigger)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAction));
		}
	}

	public unsafe string PresetCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetCategory);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string PresetName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresetName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe UIAnimation PunchAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PunchAnimation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAnimation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PunchAnimation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimation));
		}
	}

	public unsafe bool Ready
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ready);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ready)) = flag;
		}
	}

	public unsafe bool SelectButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectButton)) = flag;
		}
	}

	public unsafe UIAnimation StateAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StateAnimation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAnimation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StateAnimation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimation));
		}
	}

	public unsafe bool TriggerEventsAfterAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerEventsAfterAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TriggerEventsAfterAnimation)) = flag;
		}
	}

	public unsafe UIButtonBehaviorType m_behaviorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_behaviorType);
			return *(UIButtonBehaviorType*)num;
		}
		set
		{
			*(UIButtonBehaviorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_behaviorType)) = uIButtonBehaviorType;
		}
	}

	public unsafe static string DefaultPresetCategory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729485, XrefRangeEnd = 729487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultPresetCategory_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string DefaultPresetName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729487, XrefRangeEnd = 729489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultPresetName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe int AnimatorsCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729489, XrefRangeEnd = 729490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnimatorsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe UIButtonBehaviorType BehaviorType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BehaviorType_Public_get_UIButtonBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(UIButtonBehaviorType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasAnimation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729490, XrefRangeEnd = 729491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasAnimation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasAnimators
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasAnimators_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasAnimatorEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729491, XrefRangeEnd = 729493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasAnimatorEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasEffect
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729493, XrefRangeEnd = 729495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasEffect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasGameEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729495, XrefRangeEnd = 729497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasGameEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasPunchAnimation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729497, XrefRangeEnd = 729498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasPunchAnimation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasSound
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729498, XrefRangeEnd = 729500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasStateAnimation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729500, XrefRangeEnd = 729501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasStateAnimation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasUnityEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729501, XrefRangeEnd = 729503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasUnityEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UIButtonBehavior()
	{
		Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIButtonBehavior");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_BUTTON_ANIMATION_TYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_BUTTON_ANIMATION_TYPE");
		NativeFieldInfoPtr_DEFAULT_DESELECT_BUTTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_DESELECT_BUTTON");
		NativeFieldInfoPtr_DEFAULT_ENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_ENABLED");
		NativeFieldInfoPtr_DEFAULT_LOAD_SELECTED_PRESET_AT_RUNTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_LOAD_SELECTED_PRESET_AT_RUNTIME");
		NativeFieldInfoPtr_DEFAULT_READY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_READY");
		NativeFieldInfoPtr_DEFAULT_SELECT_BUTTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_SELECT_BUTTON");
		NativeFieldInfoPtr_DEFAULT_TRIGGER_EVENTS_AFTER_ANIMATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DEFAULT_TRIGGER_EVENTS_AFTER_ANIMATION");
		NativeFieldInfoPtr_ON_BUTTON_DESELECTED_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_BUTTON_DESELECTED_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_BUTTON_SELECTED_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_BUTTON_SELECTED_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_CLICK_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_CLICK_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_DOUBLE_CLICK_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_DOUBLE_CLICK_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_LONG_CLICK_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_LONG_CLICK_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_POINTER_DOWN_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_POINTER_DOWN_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_POINTER_ENTER_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_POINTER_ENTER_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_POINTER_EXIT_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_POINTER_EXIT_DISABLE_INTERVAL");
		NativeFieldInfoPtr_ON_POINTER_UP_DISABLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ON_POINTER_UP_DISABLE_INTERVAL");
		NativeFieldInfoPtr_Animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "Animators");
		NativeFieldInfoPtr_ButtonAnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "ButtonAnimationType");
		NativeFieldInfoPtr_DeselectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DeselectButton");
		NativeFieldInfoPtr_DisableInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "DisableInterval");
		NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "Enabled");
		NativeFieldInfoPtr_LoadSelectedPresetAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "LoadSelectedPresetAtRuntime");
		NativeFieldInfoPtr_OnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "OnTrigger");
		NativeFieldInfoPtr_PresetCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "PresetCategory");
		NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "PresetName");
		NativeFieldInfoPtr_PunchAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "PunchAnimation");
		NativeFieldInfoPtr_Ready = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "Ready");
		NativeFieldInfoPtr_SelectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "SelectButton");
		NativeFieldInfoPtr_StateAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "StateAnimation");
		NativeFieldInfoPtr_TriggerEventsAfterAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "TriggerEventsAfterAnimation");
		NativeFieldInfoPtr_m_behaviorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, "m_behaviorType");
		NativeMethodInfoPtr_get_DefaultPresetCategory_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667550);
		NativeMethodInfoPtr_get_DefaultPresetName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667551);
		NativeMethodInfoPtr_get_AnimatorsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667552);
		NativeMethodInfoPtr_get_BehaviorType_Public_get_UIButtonBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667553);
		NativeMethodInfoPtr_get_HasAnimation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667554);
		NativeMethodInfoPtr_get_HasAnimators_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667555);
		NativeMethodInfoPtr_get_HasAnimatorEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667556);
		NativeMethodInfoPtr_get_HasEffect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667557);
		NativeMethodInfoPtr_get_HasGameEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667558);
		NativeMethodInfoPtr_get_HasPunchAnimation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667559);
		NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667560);
		NativeMethodInfoPtr_get_HasStateAnimation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667561);
		NativeMethodInfoPtr_get_HasUnityEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667562);
		NativeMethodInfoPtr__ctor_Public_Void_UIButtonBehaviorType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667563);
		NativeMethodInfoPtr_GetAnimationTotalDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667564);
		NativeMethodInfoPtr_LoadPreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667565);
		NativeMethodInfoPtr_LoadPreset_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667566);
		NativeMethodInfoPtr_PlayAnimation_Public_Void_UIButton_Boolean_UnityAction_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667567);
		NativeMethodInfoPtr_Reset_Public_Void_UIButtonBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667568);
		NativeMethodInfoPtr_InvokeCallbacks_Private_Static_IEnumerator_UIAnimation_UnityAction_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667569);
		NativeMethodInfoPtr_GetAnimationType_Public_Static_AnimationType_ButtonAnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667570);
		NativeMethodInfoPtr_GetDefaultDisableInterval_Public_Static_Single_UIButtonBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr, 100667571);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 729527, RefRangeEnd = 729540, XrefRangeStart = 729503, XrefRangeEnd = 729527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonBehavior(UIButtonBehaviorType behaviorType, bool enabled = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonBehavior>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&behaviorType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIButtonBehaviorType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 729542, RefRangeEnd = 729543, XrefRangeStart = 729540, XrefRangeEnd = 729542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAnimationTotalDuration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimationTotalDuration_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 729551, RefRangeEnd = 729560, XrefRangeStart = 729543, XrefRangeEnd = 729551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPreset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729560, XrefRangeEnd = 729568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPreset(string presetCategory, string presetName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(presetCategory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(presetName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPreset_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 729624, RefRangeEnd = 729625, XrefRangeStart = 729568, XrefRangeEnd = 729624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayAnimation(UIButton button, bool withSound = true, UnityAction onStartCallback = null, UnityAction onCompleteCallback = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSound;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onStartCallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onCompleteCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayAnimation_Public_Void_UIButton_Boolean_UnityAction_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729625, XrefRangeEnd = 729648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(UIButtonBehaviorType behaviorType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&behaviorType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_UIButtonBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 729652, RefRangeEnd = 729653, XrefRangeStart = 729648, XrefRangeEnd = 729652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator InvokeCallbacks(UIAnimation animation, UnityAction onStartCallback, UnityAction onCompleteCallback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onStartCallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onCompleteCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeCallbacks_Private_Static_IEnumerator_UIAnimation_UnityAction_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static AnimationType GetAnimationType(ButtonAnimationType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimationType_Public_Static_AnimationType_ButtonAnimationType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float GetDefaultDisableInterval(UIButtonBehaviorType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultDisableInterval_Public_Static_Single_UIButtonBehaviorType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public UIButtonBehavior(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
