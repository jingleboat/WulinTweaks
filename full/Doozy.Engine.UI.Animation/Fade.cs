using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.UI.Animation;

[System.Serializable]
public class Fade : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_From;

	private static readonly System.IntPtr NativeFieldInfoPtr_To;

	private static readonly System.IntPtr NativeFieldInfoPtr_By;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomFromAndTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_NumberOfLoops;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoopType;

	private static readonly System.IntPtr NativeFieldInfoPtr_EaseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ease;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_Duration;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Boolean_Single_Single_Single_Boolean_Int32_LoopType_EaseType_Ease_AnimationCurve_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_AnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Fade_0;

	public unsafe AnimationType AnimationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationType);
			return *(AnimationType*)num;
		}
		set
		{
			*(AnimationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationType)) = animationType;
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

	public unsafe float From
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_From);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_From)) = num;
		}
	}

	public unsafe float To
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_To);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_To)) = num;
		}
	}

	public unsafe float By
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_By);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_By)) = num;
		}
	}

	public unsafe bool UseCustomFromAndTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCustomFromAndTo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCustomFromAndTo)) = flag;
		}
	}

	public unsafe int NumberOfLoops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NumberOfLoops);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NumberOfLoops)) = num;
		}
	}

	public unsafe LoopType LoopType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopType);
			return *(LoopType*)num;
		}
		set
		{
			*(LoopType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopType)) = loopType;
		}
	}

	public unsafe EaseType EaseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EaseType);
			return *(EaseType*)num;
		}
		set
		{
			*(EaseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EaseType)) = easeType;
		}
	}

	public unsafe Ease Ease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ease);
			return *(Ease*)num;
		}
		set
		{
			*(Ease*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ease)) = ease;
		}
	}

	public unsafe AnimationCurve AnimationCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float StartDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartDelay)) = num;
		}
	}

	public unsafe float Duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration)) = num;
		}
	}

	public unsafe float TotalDuration
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739432, RefRangeEnd = 739433, XrefRangeStart = 739432, XrefRangeEnd = 739432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Fade()
	{
		Il2CppClassPointerStore<Fade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Animation", "Fade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fade>.NativeClassPtr);
		NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "AnimationType");
		NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "Enabled");
		NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "From");
		NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "To");
		NativeFieldInfoPtr_By = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "By");
		NativeFieldInfoPtr_UseCustomFromAndTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "UseCustomFromAndTo");
		NativeFieldInfoPtr_NumberOfLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "NumberOfLoops");
		NativeFieldInfoPtr_LoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "LoopType");
		NativeFieldInfoPtr_EaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "EaseType");
		NativeFieldInfoPtr_Ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "Ease");
		NativeFieldInfoPtr_AnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "AnimationCurve");
		NativeFieldInfoPtr_StartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "StartDelay");
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fade>.NativeClassPtr, "Duration");
		NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fade>.NativeClassPtr, 100668412);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fade>.NativeClassPtr, 100668413);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Boolean_Single_Single_Single_Boolean_Int32_LoopType_EaseType_Ease_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fade>.NativeClassPtr, 100668414);
		NativeMethodInfoPtr_Reset_Public_Void_AnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fade>.NativeClassPtr, 100668415);
		NativeMethodInfoPtr_Copy_Public_Fade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fade>.NativeClassPtr, 100668416);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 739438, RefRangeEnd = 739442, XrefRangeStart = 739433, XrefRangeEnd = 739438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Fade(AnimationType animationType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fade>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739442, XrefRangeEnd = 739448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Fade(AnimationType animationType, bool enabled, float from, float to, float by, bool useCustomFromAndTo, int numberOfLoops, LoopType loopType, EaseType easeType, Ease ease, AnimationCurve animationCurve, float startDelay, float duration)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fade>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = (nint)(&animationType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &by;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCustomFromAndTo;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &numberOfLoops;
		*(LoopType**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopType;
		*(EaseType**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &easeType;
		*(Ease**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &ease;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve);
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &startDelay;
		*(float**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Boolean_Single_Single_Single_Boolean_Int32_LoopType_EaseType_Ease_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739448, XrefRangeEnd = 739452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(AnimationType animationType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_AnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 739461, RefRangeEnd = 739462, XrefRangeStart = 739452, XrefRangeEnd = 739461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Fade Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Fade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Fade>(intPtr) : null;
	}

	public Fade(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
