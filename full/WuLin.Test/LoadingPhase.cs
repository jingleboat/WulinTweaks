using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace WuLin.Test;

public class LoadingPhase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_backGroundLoadingPhaseTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_frontGroundLoaidngPhaseAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_startWaitingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskMinTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_endWaitingTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<SplashImageLoadingProgress.SplashImageLoadingTask> backGroundLoadingPhaseTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backGroundLoadingPhaseTasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SplashImageLoadingProgress.SplashImageLoadingTask>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backGroundLoadingPhaseTasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe UnityEvent frontGroundLoaidngPhaseAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontGroundLoaidngPhaseAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontGroundLoaidngPhaseAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe float startWaitingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startWaitingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startWaitingTime)) = num;
		}
	}

	public unsafe float taskMinTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskMinTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskMinTime)) = num;
		}
	}

	public unsafe float endWaitingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endWaitingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endWaitingTime)) = num;
		}
	}

	static LoadingPhase()
	{
		Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.Test", "LoadingPhase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr);
		NativeFieldInfoPtr_backGroundLoadingPhaseTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr, "backGroundLoadingPhaseTasks");
		NativeFieldInfoPtr_frontGroundLoaidngPhaseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr, "frontGroundLoaidngPhaseAction");
		NativeFieldInfoPtr_startWaitingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr, "startWaitingTime");
		NativeFieldInfoPtr_taskMinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr, "taskMinTime");
		NativeFieldInfoPtr_endWaitingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr, "endWaitingTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr, 100681590);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046150, XrefRangeEnd = 1046154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadingPhase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingPhase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LoadingPhase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
