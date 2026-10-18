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
public class Move : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_From;

	private static readonly System.IntPtr NativeFieldInfoPtr_To;

	private static readonly System.IntPtr NativeFieldInfoPtr_By;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomFromAndTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_Vibrato;

	private static readonly System.IntPtr NativeFieldInfoPtr_Elasticity;

	private static readonly System.IntPtr NativeFieldInfoPtr_NumberOfLoops;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoopType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_EaseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ease;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_Duration;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Boolean_Vector3_Vector3_Vector3_Boolean_Int32_Single_Int32_LoopType_Direction_Vector3_EaseType_Ease_AnimationCurve_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_AnimationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Move_0;

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

	public unsafe Vector3 From
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_From);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_From)) = vector;
		}
	}

	public unsafe Vector3 To
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_To);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_To)) = vector;
		}
	}

	public unsafe Vector3 By
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_By);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_By)) = vector;
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

	public unsafe int Vibrato
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vibrato);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vibrato)) = num;
		}
	}

	public unsafe float Elasticity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Elasticity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Elasticity)) = num;
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

	public unsafe Direction Direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction);
			return *(Direction*)num;
		}
		set
		{
			*(Direction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction)) = direction;
		}
	}

	public unsafe Vector3 CustomPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomPosition)) = vector;
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
		[CachedScanResults(RefRangeStart = 739322, RefRangeEnd = 739323, XrefRangeStart = 739322, XrefRangeEnd = 739322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static Move()
	{
		Il2CppClassPointerStore<Move>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Animation", "Move");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Move>.NativeClassPtr);
		NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "AnimationType");
		NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "Enabled");
		NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "From");
		NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "To");
		NativeFieldInfoPtr_By = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "By");
		NativeFieldInfoPtr_UseCustomFromAndTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "UseCustomFromAndTo");
		NativeFieldInfoPtr_Vibrato = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "Vibrato");
		NativeFieldInfoPtr_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "Elasticity");
		NativeFieldInfoPtr_NumberOfLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "NumberOfLoops");
		NativeFieldInfoPtr_LoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "LoopType");
		NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "Direction");
		NativeFieldInfoPtr_CustomPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "CustomPosition");
		NativeFieldInfoPtr_EaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "EaseType");
		NativeFieldInfoPtr_Ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "Ease");
		NativeFieldInfoPtr_AnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "AnimationCurve");
		NativeFieldInfoPtr_StartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "StartDelay");
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Move>.NativeClassPtr, "Duration");
		NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100668397);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100668398);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Boolean_Vector3_Vector3_Vector3_Boolean_Int32_Single_Int32_LoopType_Direction_Vector3_EaseType_Ease_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100668399);
		NativeMethodInfoPtr_Reset_Public_Void_AnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100668400);
		NativeMethodInfoPtr_Copy_Public_Move_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Move>.NativeClassPtr, 100668401);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 739332, RefRangeEnd = 739336, XrefRangeStart = 739323, XrefRangeEnd = 739332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Move(AnimationType animationType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739336, XrefRangeEnd = 739342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Move(AnimationType animationType, bool enabled, Vector3 from, Vector3 to, Vector3 by, bool useCustomFromAndTo, int vibrato, float elasticity, int numberOfLoops, LoopType loopType, Direction direction, Vector3 customPosition, EaseType easeType, Ease ease, AnimationCurve animationCurve, float startDelay, float duration)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Move>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = (nint)(&animationType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &by;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCustomFromAndTo;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &vibrato;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &elasticity;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &numberOfLoops;
		*(LoopType**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopType;
		*(Direction**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(Vector3**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &customPosition;
		*(EaseType**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &easeType;
		*(Ease**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &ease;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve);
		*(float**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &startDelay;
		*(float**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Boolean_Vector3_Vector3_Vector3_Boolean_Int32_Single_Int32_LoopType_Direction_Vector3_EaseType_Ease_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739342, XrefRangeEnd = 739350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 739359, RefRangeEnd = 739360, XrefRangeStart = 739350, XrefRangeEnd = 739359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Move Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Move_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Move>(intPtr) : null;
	}

	public Move(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
