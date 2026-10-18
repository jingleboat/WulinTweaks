using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.U2D;

namespace WuLin;

public class CameraFollowTarget : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_followTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideFollowTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeFollowTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFollowSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBattleMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFollowDistNonBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFollowDistBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr_disablePixelPerfectOnMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ppFix;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedPPCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedCamreraPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedFollowTargetPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedCameraToActorOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_virtualFollowTargetRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_virtualFollowTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_virtualFollowTargetMoveTweener;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugMode;

	private static readonly System.IntPtr NativeFieldInfoPtr__newState;

	private static readonly System.IntPtr NativeFieldInfoPtr__setBattlePos;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastPerform;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPos;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CameraFollowTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideFollowTarget_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideFollowTarget_Public_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraOverrideFollowTarget_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraOverrideVirtualFollowTarget_Public_Void_Transform_Single_Ease_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraOverrideVirtualFollowPos_Public_Void_Vector3Int_Single_Ease_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraOverrideVirtualFollowPos_Public_Void_Vector3_Single_Ease_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateVirtualFollowTarget_Private_Void_Transform_Vector3_Single_Ease_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearOverrideTarget_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraFollowTargetInBattle_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoSnap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraMove_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnJoyStickBattleStage_Private_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CamMoveDebug_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static CameraFollowTarget instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraFollowTarget>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraFollowTarget));
		}
	}

	public unsafe Transform followTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform overrideFollowTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFollowTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFollowTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform relativeFollowTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeFollowTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeFollowTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe float maxFollowSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFollowSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFollowSpeed)) = num;
		}
	}

	public unsafe bool isBattleMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBattleMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBattleMode)) = flag;
		}
	}

	public unsafe float maxFollowDistNonBattle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFollowDistNonBattle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFollowDistNonBattle)) = num;
		}
	}

	public unsafe float maxFollowDistBattle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFollowDistBattle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFollowDistBattle)) = num;
		}
	}

	public unsafe bool disablePixelPerfectOnMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disablePixelPerfectOnMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disablePixelPerfectOnMove)) = flag;
		}
	}

	public unsafe int m_ppFix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ppFix);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ppFix)) = num;
		}
	}

	public unsafe PixelPerfectCamera cachedPPCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedPPCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PixelPerfectCamera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedPPCamera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pixelPerfectCamera));
		}
	}

	public unsafe Vector3 m_CachedCamreraPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCamreraPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCamreraPos)) = vector;
		}
	}

	public unsafe Vector3 m_CachedFollowTargetPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedFollowTargetPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedFollowTargetPos)) = vector;
		}
	}

	public unsafe Vector3 m_CachedCameraToActorOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCameraToActorOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCameraToActorOffset)) = vector;
		}
	}

	public unsafe Transform virtualFollowTargetRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualFollowTargetRoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualFollowTargetRoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform virtualFollowTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualFollowTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualFollowTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Tweener virtualFollowTargetMoveTweener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualFollowTargetMoveTweener);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tweener>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualFollowTargetMoveTweener)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tweener));
		}
	}

	public unsafe bool debugMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMode)) = flag;
		}
	}

	public unsafe JoyStickBattleControl.JoyStickBattleStage _newState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newState);
			return *(JoyStickBattleControl.JoyStickBattleStage*)num;
		}
		set
		{
			*(JoyStickBattleControl.JoyStickBattleStage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newState)) = joyStickBattleStage;
		}
	}

	public unsafe bool _setBattlePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__setBattlePos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__setBattlePos)) = flag;
		}
	}

	public unsafe bool _lastPerform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPerform);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPerform)) = flag;
		}
	}

	public unsafe Vector3 lastPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPos)) = vector;
		}
	}

	public unsafe static CameraFollowTarget Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873121, XrefRangeEnd = 873123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CameraFollowTarget_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraFollowTarget>(intPtr) : null;
		}
	}

	public unsafe Transform OverrideFollowTarget
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18874, RefRangeEnd = 18877, XrefRangeStart = 18874, XrefRangeEnd = 18877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OverrideFollowTarget_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 873124, RefRangeEnd = 873129, XrefRangeStart = 873123, XrefRangeEnd = 873124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OverrideFollowTarget_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static CameraFollowTarget()
	{
		Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "CameraFollowTarget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_followTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "followTarget");
		NativeFieldInfoPtr_overrideFollowTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "overrideFollowTarget");
		NativeFieldInfoPtr_relativeFollowTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "relativeFollowTarget");
		NativeFieldInfoPtr_maxFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "maxFollowSpeed");
		NativeFieldInfoPtr_isBattleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "isBattleMode");
		NativeFieldInfoPtr_maxFollowDistNonBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "maxFollowDistNonBattle");
		NativeFieldInfoPtr_maxFollowDistBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "maxFollowDistBattle");
		NativeFieldInfoPtr_disablePixelPerfectOnMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "disablePixelPerfectOnMove");
		NativeFieldInfoPtr_m_ppFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "m_ppFix");
		NativeFieldInfoPtr_cachedPPCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "cachedPPCamera");
		NativeFieldInfoPtr_m_CachedCamreraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "m_CachedCamreraPos");
		NativeFieldInfoPtr_m_CachedFollowTargetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "m_CachedFollowTargetPos");
		NativeFieldInfoPtr_m_CachedCameraToActorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "m_CachedCameraToActorOffset");
		NativeFieldInfoPtr_virtualFollowTargetRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "virtualFollowTargetRoot");
		NativeFieldInfoPtr_virtualFollowTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "virtualFollowTarget");
		NativeFieldInfoPtr_virtualFollowTargetMoveTweener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "virtualFollowTargetMoveTweener");
		NativeFieldInfoPtr_debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "debugMode");
		NativeFieldInfoPtr__newState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "_newState");
		NativeFieldInfoPtr__setBattlePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "_setBattlePos");
		NativeFieldInfoPtr__lastPerform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "_lastPerform");
		NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, "lastPos");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CameraFollowTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674547);
		NativeMethodInfoPtr_get_OverrideFollowTarget_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674548);
		NativeMethodInfoPtr_set_OverrideFollowTarget_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674549);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674550);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674551);
		NativeMethodInfoPtr_SetCameraOverrideFollowTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674552);
		NativeMethodInfoPtr_SetCameraOverrideVirtualFollowTarget_Public_Void_Transform_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674553);
		NativeMethodInfoPtr_SetCameraOverrideVirtualFollowPos_Public_Void_Vector3Int_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674554);
		NativeMethodInfoPtr_SetCameraOverrideVirtualFollowPos_Public_Void_Vector3_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674555);
		NativeMethodInfoPtr_CreateVirtualFollowTarget_Private_Void_Transform_Vector3_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674556);
		NativeMethodInfoPtr_ClearOverrideTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674557);
		NativeMethodInfoPtr_SetCameraFollowTargetInBattle_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674558);
		NativeMethodInfoPtr_DoSnap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674559);
		NativeMethodInfoPtr_CameraMove_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674560);
		NativeMethodInfoPtr_OnJoyStickBattleStage_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674561);
		NativeMethodInfoPtr_CamMoveDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674562);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr, 100674563);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873129, XrefRangeEnd = 873154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873154, XrefRangeEnd = 873168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 873176, RefRangeEnd = 873180, XrefRangeStart = 873168, XrefRangeEnd = 873176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraOverrideFollowTarget(Transform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraOverrideFollowTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873180, XrefRangeEnd = 873194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraOverrideVirtualFollowTarget(Transform target, float followSpeed, Ease ease = Ease.Linear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &followSpeed;
		*(Ease**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ease;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraOverrideVirtualFollowTarget_Public_Void_Transform_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873210, RefRangeEnd = 873212, XrefRangeStart = 873194, XrefRangeEnd = 873210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraOverrideVirtualFollowPos(Vector3Int pos, float followSpeed, Ease ease = Ease.Linear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &followSpeed;
		*(Ease**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ease;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraOverrideVirtualFollowPos_Public_Void_Vector3Int_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873221, RefRangeEnd = 873222, XrefRangeStart = 873212, XrefRangeEnd = 873221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraOverrideVirtualFollowPos(Vector3 worldPos, float followSpeed, Ease ease = Ease.Linear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&worldPos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &followSpeed;
		*(Ease**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ease;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraOverrideVirtualFollowPos_Public_Void_Vector3_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873252, RefRangeEnd = 873255, XrefRangeStart = 873222, XrefRangeEnd = 873252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateVirtualFollowTarget(Transform parent, Vector3 pos, float followSpeed, Ease ease = Ease.Linear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &followSpeed;
		*(Ease**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ease;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVirtualFollowTarget_Private_Void_Transform_Vector3_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 873256, RefRangeEnd = 873260, XrefRangeStart = 873255, XrefRangeEnd = 873256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearOverrideTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearOverrideTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 873268, RefRangeEnd = 873274, XrefRangeStart = 873260, XrefRangeEnd = 873268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraFollowTargetInBattle(Transform tf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tf);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraFollowTargetInBattle_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 873277, RefRangeEnd = 873284, XrefRangeStart = 873274, XrefRangeEnd = 873277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoSnap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoSnap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873491, RefRangeEnd = 873493, XrefRangeStart = 873284, XrefRangeEnd = 873491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CameraMove(float deltaDist)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaDist);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraMove_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873493, XrefRangeEnd = 873496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnJoyStickBattleStage(Il2CppReferenceArray<Il2CppSystem.Object> arg0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnJoyStickBattleStage_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873527, RefRangeEnd = 873528, XrefRangeStart = 873496, XrefRangeEnd = 873527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CamMoveDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CamMoveDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873528, XrefRangeEnd = 873529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraFollowTarget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraFollowTarget>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CameraFollowTarget(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
