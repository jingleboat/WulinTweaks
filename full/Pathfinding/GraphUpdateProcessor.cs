using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using UnityEngine.Profiling;

namespace Pathfinding;

public class GraphUpdateProcessor : Il2CppSystem.Object
{
	public enum GraphUpdateOrder
	{
		GraphUpdate
	}

	public sealed class GUOSingle : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_order;

		private static readonly System.IntPtr NativeFieldInfoPtr_graph;

		private static readonly System.IntPtr NativeFieldInfoPtr_obj;

		public unsafe GraphUpdateOrder order
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order);
				return *(GraphUpdateOrder*)num;
			}
			set
			{
				*(GraphUpdateOrder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order)) = graphUpdateOrder;
			}
		}

		public unsafe IUpdatableGraph graph
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graph);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IUpdatableGraph>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)updatableGraph));
			}
		}

		public unsafe GraphUpdateObject obj
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphUpdateObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphUpdateObject));
			}
		}

		static GUOSingle()
		{
			Il2CppClassPointerStore<GUOSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "GUOSingle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUOSingle>.NativeClassPtr);
			NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUOSingle>.NativeClassPtr, "order");
			NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUOSingle>.NativeClassPtr, "graph");
			NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUOSingle>.NativeClassPtr, "obj");
		}

		public GUOSingle(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GUOSingle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUOSingle>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_OnGraphsUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr_astar;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphUpdateThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_anyGraphUpdateInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_asyncUpdateProfilingSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphUpdateQueueAsync;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphUpdateQueuePost;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphUpdateQueueRegular;

	private static readonly System.IntPtr NativeFieldInfoPtr_asyncGraphUpdatesComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphUpdateAsyncEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_exitAsyncThread;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnGraphsUpdated_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnGraphsUpdated_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAnyGraphUpdateQueued_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAnyGraphUpdateInProgress_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkItem_Public_AstarWorkItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableMultithreading_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableMultithreading_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToQueue_Public_Void_GraphUpdateObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueGraphUpdatesInternal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessGraphUpdates_Private_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRegularUpdates_Private_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAsyncUpdatesIfQueued_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessPostUpdates_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessGraphUpdatesAsync_Private_Void_0;

	public unsafe Il2CppSystem.Action OnGraphsUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGraphsUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGraphsUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe AstarPath astar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_astar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AstarPath>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_astar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)astarPath));
		}
	}

	public unsafe Thread graphUpdateThread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateThread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateThread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe bool anyGraphUpdateInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyGraphUpdateInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyGraphUpdateInProgress)) = flag;
		}
	}

	public unsafe CustomSampler asyncUpdateProfilingSampler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asyncUpdateProfilingSampler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asyncUpdateProfilingSampler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customSampler));
		}
	}

	public unsafe Queue<GraphUpdateObject> graphUpdateQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<GraphUpdateObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe Queue<GUOSingle> graphUpdateQueueAsync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueueAsync);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<GUOSingle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueueAsync)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe Queue<GUOSingle> graphUpdateQueuePost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueuePost);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<GUOSingle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueuePost)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe Queue<GUOSingle> graphUpdateQueueRegular
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueueRegular);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<GUOSingle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateQueueRegular)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe ManualResetEvent asyncGraphUpdatesComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asyncGraphUpdatesComplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asyncGraphUpdatesComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manualResetEvent));
		}
	}

	public unsafe AutoResetEvent graphUpdateAsyncEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateAsyncEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphUpdateAsyncEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoResetEvent));
		}
	}

	public unsafe AutoResetEvent exitAsyncThread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitAsyncThread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitAsyncThread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoResetEvent));
		}
	}

	public unsafe bool IsAnyGraphUpdateQueued
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1063325, RefRangeEnd = 1063328, XrefRangeStart = 1063324, XrefRangeEnd = 1063325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAnyGraphUpdateQueued_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsAnyGraphUpdateInProgress
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAnyGraphUpdateInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static GraphUpdateProcessor()
	{
		Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "GraphUpdateProcessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr);
		NativeFieldInfoPtr_OnGraphsUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "OnGraphsUpdated");
		NativeFieldInfoPtr_astar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "astar");
		NativeFieldInfoPtr_graphUpdateThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "graphUpdateThread");
		NativeFieldInfoPtr_anyGraphUpdateInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "anyGraphUpdateInProgress");
		NativeFieldInfoPtr_asyncUpdateProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "asyncUpdateProfilingSampler");
		NativeFieldInfoPtr_graphUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "graphUpdateQueue");
		NativeFieldInfoPtr_graphUpdateQueueAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "graphUpdateQueueAsync");
		NativeFieldInfoPtr_graphUpdateQueuePost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "graphUpdateQueuePost");
		NativeFieldInfoPtr_graphUpdateQueueRegular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "graphUpdateQueueRegular");
		NativeFieldInfoPtr_asyncGraphUpdatesComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "asyncGraphUpdatesComplete");
		NativeFieldInfoPtr_graphUpdateAsyncEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "graphUpdateAsyncEvent");
		NativeFieldInfoPtr_exitAsyncThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, "exitAsyncThread");
		NativeMethodInfoPtr_add_OnGraphsUpdated_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682548);
		NativeMethodInfoPtr_remove_OnGraphsUpdated_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682549);
		NativeMethodInfoPtr_get_IsAnyGraphUpdateQueued_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682550);
		NativeMethodInfoPtr_get_IsAnyGraphUpdateInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682551);
		NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682552);
		NativeMethodInfoPtr_GetWorkItem_Public_AstarWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682553);
		NativeMethodInfoPtr_EnableMultithreading_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682554);
		NativeMethodInfoPtr_DisableMultithreading_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682555);
		NativeMethodInfoPtr_AddToQueue_Public_Void_GraphUpdateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682556);
		NativeMethodInfoPtr_QueueGraphUpdatesInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682557);
		NativeMethodInfoPtr_ProcessGraphUpdates_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682558);
		NativeMethodInfoPtr_ProcessRegularUpdates_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682559);
		NativeMethodInfoPtr_StartAsyncUpdatesIfQueued_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682560);
		NativeMethodInfoPtr_ProcessPostUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682561);
		NativeMethodInfoPtr_ProcessGraphUpdatesAsync_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr, 100682562);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063319, RefRangeEnd = 1063320, XrefRangeStart = 1063315, XrefRangeEnd = 1063319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnGraphsUpdated(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnGraphsUpdated_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063320, XrefRangeEnd = 1063324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnGraphsUpdated(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnGraphsUpdated_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063360, RefRangeEnd = 1063361, XrefRangeStart = 1063328, XrefRangeEnd = 1063360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphUpdateProcessor(AstarPath astar)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphUpdateProcessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)astar);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063376, RefRangeEnd = 1063377, XrefRangeStart = 1063361, XrefRangeEnd = 1063376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstarWorkItem GetWorkItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorkItem_Public_AstarWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AstarWorkItem(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063397, RefRangeEnd = 1063398, XrefRangeStart = 1063377, XrefRangeEnd = 1063397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableMultithreading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableMultithreading_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063407, RefRangeEnd = 1063408, XrefRangeStart = 1063398, XrefRangeEnd = 1063407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableMultithreading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableMultithreading_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063412, RefRangeEnd = 1063414, XrefRangeStart = 1063408, XrefRangeEnd = 1063412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToQueue(GraphUpdateObject ob)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToQueue_Public_Void_GraphUpdateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063414, XrefRangeEnd = 1063457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueGraphUpdatesInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueGraphUpdatesInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063457, XrefRangeEnd = 1063458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessGraphUpdates(bool force)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessGraphUpdates_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063458, XrefRangeEnd = 1063495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessRegularUpdates(bool force)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRegularUpdates_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1063496, RefRangeEnd = 1063499, XrefRangeStart = 1063495, XrefRangeEnd = 1063496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartAsyncUpdatesIfQueued()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAsyncUpdatesIfQueued_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063499, XrefRangeEnd = 1063519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessPostUpdates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessPostUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063519, XrefRangeEnd = 1063556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessGraphUpdatesAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessGraphUpdatesAsync_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GraphUpdateProcessor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
