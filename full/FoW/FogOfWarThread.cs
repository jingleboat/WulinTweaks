using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace FoW;

public class FogOfWarThread : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__state_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__threadPool_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__task_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__thread;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isWaiting_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_FogOfWarThreadState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Private_set_Void_FogOfWarThreadState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_threadPool_Public_get_FogOfWarThreadPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_threadPool_Private_set_Void_FogOfWarThreadPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_task_Public_get_FogOfWarThreadTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_task_Private_set_Void_FogOfWarThreadTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FogOfWarThreadPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadRun_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_FogOfWarThreadTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	public unsafe FogOfWarThreadState _state_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField);
			return *(FogOfWarThreadState*)num;
		}
		set
		{
			*(FogOfWarThreadState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField)) = fogOfWarThreadState;
		}
	}

	public unsafe FogOfWarThreadPool _threadPool_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__threadPool_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarThreadPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__threadPool_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogOfWarThreadPool));
		}
	}

	public unsafe FogOfWarThreadTask _task_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__task_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarThreadTask>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__task_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogOfWarThreadTask));
		}
	}

	public unsafe Thread _thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe bool isWaiting
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91281, RefRangeEnd = 91282, XrefRangeStart = 91281, XrefRangeEnd = 91282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isWaiting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe FogOfWarThreadState state
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_FogOfWarThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(FogOfWarThreadState*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57209, RefRangeEnd = 57214, XrefRangeStart = 57209, XrefRangeEnd = 57214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_state_Private_set_Void_FogOfWarThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe FogOfWarThreadPool threadPool
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_threadPool_Public_get_FogOfWarThreadPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarThreadPool>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_threadPool_Private_set_Void_FogOfWarThreadPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe FogOfWarThreadTask task
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_task_Public_get_FogOfWarThreadTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarThreadTask>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31140, RefRangeEnd = 31143, XrefRangeStart = 31140, XrefRangeEnd = 31143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_task_Private_set_Void_FogOfWarThreadTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static FogOfWarThread()
	{
		Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarThread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr);
		NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, "<state>k__BackingField");
		NativeFieldInfoPtr__threadPool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, "<threadPool>k__BackingField");
		NativeFieldInfoPtr__task_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, "<task>k__BackingField");
		NativeFieldInfoPtr__thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, "_thread");
		NativeMethodInfoPtr_get_isWaiting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667050);
		NativeMethodInfoPtr_get_state_Public_get_FogOfWarThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667051);
		NativeMethodInfoPtr_set_state_Private_set_Void_FogOfWarThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667052);
		NativeMethodInfoPtr_get_threadPool_Public_get_FogOfWarThreadPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667053);
		NativeMethodInfoPtr_set_threadPool_Private_set_Void_FogOfWarThreadPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667054);
		NativeMethodInfoPtr_get_task_Public_get_FogOfWarThreadTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667055);
		NativeMethodInfoPtr_set_task_Private_set_Void_FogOfWarThreadTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667056);
		NativeMethodInfoPtr__ctor_Public_Void_FogOfWarThreadPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667057);
		NativeMethodInfoPtr_ThreadRun_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr_Run_Public_Void_FogOfWarThreadTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667059);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr, 100667060);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721919, XrefRangeEnd = 721932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarThread(FogOfWarThreadPool pool)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarThread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pool);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FogOfWarThreadPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721932, XrefRangeEnd = 721942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThreadRun()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadRun_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721944, RefRangeEnd = 721945, XrefRangeStart = 721942, XrefRangeEnd = 721944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Run(FogOfWarThreadTask newtask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newtask);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Run_Public_Void_FogOfWarThreadTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarThread(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
