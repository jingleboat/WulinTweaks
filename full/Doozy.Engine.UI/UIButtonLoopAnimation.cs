using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.UI;

[System.Serializable]
public class UIButtonLoopAnimation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Animation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPlaying;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoopAnimationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadSelectedPresetAtRuntime;

	private static readonly System.IntPtr NativeFieldInfoPtr_PresetCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_PresetName;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ButtonLoopAnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPreset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPreset_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_ButtonLoopAnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_RectTransform_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_RectTransform_0;

	public unsafe UIAnimation Animation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAnimation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimation));
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

	public unsafe bool IsPlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlaying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlaying)) = flag;
		}
	}

	public unsafe ButtonLoopAnimationType LoopAnimationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopAnimationType);
			return *(ButtonLoopAnimationType*)num;
		}
		set
		{
			*(ButtonLoopAnimationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopAnimationType)) = buttonLoopAnimationType;
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

	static UIButtonLoopAnimation()
	{
		Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIButtonLoopAnimation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr);
		NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "Animation");
		NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "Enabled");
		NativeFieldInfoPtr_IsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "IsPlaying");
		NativeFieldInfoPtr_LoopAnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "LoopAnimationType");
		NativeFieldInfoPtr_LoadSelectedPresetAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "LoadSelectedPresetAtRuntime");
		NativeFieldInfoPtr_PresetCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "PresetCategory");
		NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, "PresetName");
		NativeMethodInfoPtr__ctor_Public_Void_ButtonLoopAnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, 100667583);
		NativeMethodInfoPtr_LoadPreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, 100667584);
		NativeMethodInfoPtr_LoadPreset_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, 100667585);
		NativeMethodInfoPtr_Reset_Public_Void_ButtonLoopAnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, 100667586);
		NativeMethodInfoPtr_Start_Public_Void_RectTransform_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, 100667587);
		NativeMethodInfoPtr_Stop_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr, 100667588);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 729809, RefRangeEnd = 729811, XrefRangeStart = 729804, XrefRangeEnd = 729809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonLoopAnimation(ButtonLoopAnimationType loopAnimationType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonLoopAnimation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loopAnimationType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ButtonLoopAnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 729818, RefRangeEnd = 729820, XrefRangeStart = 729811, XrefRangeEnd = 729818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPreset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729820, XrefRangeEnd = 729827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729827, XrefRangeEnd = 729831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(ButtonLoopAnimationType loopAnimationType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loopAnimationType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_ButtonLoopAnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 729838, RefRangeEnd = 729840, XrefRangeStart = 729831, XrefRangeEnd = 729838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start(RectTransform target, Vector3 startPosition, Vector3 startRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startRotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_RectTransform_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 729844, RefRangeEnd = 729846, XrefRangeStart = 729840, XrefRangeEnd = 729844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop(RectTransform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIButtonLoopAnimation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
