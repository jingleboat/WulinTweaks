using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using Pathfinding.RVO.Sampled;
using UnityEngine;

namespace Pathfinding.RVO;

public class Simulator : Il2CppSystem.Object
{
	public class WorkerContext : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_vos;

		private static readonly System.IntPtr NativeFieldInfoPtr_KeepCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_bestPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_bestSizes;

		private static readonly System.IntPtr NativeFieldInfoPtr_bestScores;

		private static readonly System.IntPtr NativeFieldInfoPtr_samplePos;

		private static readonly System.IntPtr NativeFieldInfoPtr_sampleSize;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Agent.VOBuffer vos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Agent.VOBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vOBuffer));
			}
		}

		public unsafe static int KeepCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeepCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeepCount, (void*)(&num));
			}
		}

		public unsafe Il2CppStructArray<Vector2> bestPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestPos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<float> bestSizes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestSizes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestSizes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<float> bestScores
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestScores);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestScores)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Vector2> samplePos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samplePos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samplePos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<float> sampleSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleSize);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleSize)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static WorkerContext()
		{
			Il2CppClassPointerStore<WorkerContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "WorkerContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr);
			NativeFieldInfoPtr_vos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "vos");
			NativeFieldInfoPtr_KeepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "KeepCount");
			NativeFieldInfoPtr_bestPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "bestPos");
			NativeFieldInfoPtr_bestSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "bestSizes");
			NativeFieldInfoPtr_bestScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "bestScores");
			NativeFieldInfoPtr_samplePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "samplePos");
			NativeFieldInfoPtr_sampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, "sampleSize");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr, 100689580);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081443, RefRangeEnd = 1081444, XrefRangeStart = 1081426, XrefRangeEnd = 1081443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkerContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkerContext>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WorkerContext(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Worker : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_start;

		private static readonly System.IntPtr NativeFieldInfoPtr_end;

		private static readonly System.IntPtr NativeFieldInfoPtr_runFlag;

		private static readonly System.IntPtr NativeFieldInfoPtr_waitFlag;

		private static readonly System.IntPtr NativeFieldInfoPtr_simulator;

		private static readonly System.IntPtr NativeFieldInfoPtr_task;

		private static readonly System.IntPtr NativeFieldInfoPtr_terminate;

		private static readonly System.IntPtr NativeFieldInfoPtr_context;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Simulator_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WaitOne_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Terminate_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_0;

		public unsafe int start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start)) = num;
			}
		}

		public unsafe int end
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end)) = num;
			}
		}

		public unsafe ManualResetEventSlim runFlag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runFlag);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runFlag)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manualResetEventSlim));
			}
		}

		public unsafe ManualResetEventSlim waitFlag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitFlag);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitFlag)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manualResetEventSlim));
			}
		}

		public unsafe Simulator simulator
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulator);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Simulator>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simulator));
			}
		}

		public unsafe int task
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_task);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_task)) = num;
			}
		}

		public unsafe bool terminate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terminate);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terminate)) = flag;
			}
		}

		public unsafe WorkerContext context
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorkerContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)workerContext));
			}
		}

		static Worker()
		{
			Il2CppClassPointerStore<Worker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "Worker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Worker>.NativeClassPtr);
			NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "start");
			NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "end");
			NativeFieldInfoPtr_runFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "runFlag");
			NativeFieldInfoPtr_waitFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "waitFlag");
			NativeFieldInfoPtr_simulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "simulator");
			NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "task");
			NativeFieldInfoPtr_terminate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "terminate");
			NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Worker>.NativeClassPtr, "context");
			NativeMethodInfoPtr__ctor_Public_Void_Simulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Worker>.NativeClassPtr, 100689581);
			NativeMethodInfoPtr_Execute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Worker>.NativeClassPtr, 100689582);
			NativeMethodInfoPtr_WaitOne_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Worker>.NativeClassPtr, 100689583);
			NativeMethodInfoPtr_Terminate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Worker>.NativeClassPtr, 100689584);
			NativeMethodInfoPtr_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Worker>.NativeClassPtr, 100689585);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081488, RefRangeEnd = 1081489, XrefRangeStart = 1081444, XrefRangeEnd = 1081488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Worker(Simulator sim)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Worker>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sim);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Simulator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081492, RefRangeEnd = 1081494, XrefRangeStart = 1081489, XrefRangeEnd = 1081492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&task);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1081495, RefRangeEnd = 1081499, XrefRangeStart = 1081494, XrefRangeEnd = 1081495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitOne()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitOne_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081503, RefRangeEnd = 1081504, XrefRangeStart = 1081499, XrefRangeEnd = 1081503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Terminate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Terminate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081504, XrefRangeEnd = 1081527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Worker(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_doubleBuffering;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredDeltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_workers;

	private static readonly System.IntPtr NativeFieldInfoPtr_agents;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacles;

	private static readonly System.IntPtr NativeFieldInfoPtr__Quadtree_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_doUpdateObstacles;

	private static readonly System.IntPtr NativeFieldInfoPtr_doCleanObstacles;

	private static readonly System.IntPtr NativeFieldInfoPtr_symmetryBreakingBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_coroutineWorkerContext;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Quadtree_Public_get_RVOQuadtree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Quadtree_Private_set_Void_RVOQuadtree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Multithreading_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DesiredDeltaTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DesiredDeltaTime_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAgents_Public_List_1_Agent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObstacles_Public_List_1_ObstacleVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_MovementPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAgents_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAgent_Public_IAgent_IAgent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAgent_Public_IAgent_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAgent_Public_IAgent_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAgent_Public_Void_IAgent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_ObstacleVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Il2CppStructArray_1_Vector3_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Il2CppStructArray_1_Vector3_Single_Matrix4x4_RVOLayer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateObstacle_Public_Void_ObstacleVertex_Il2CppStructArray_1_Vector3_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleCleanObstacles_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanObstacles_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveObstacle_Public_Void_ObstacleVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateObstacles_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildQuadtree_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockUntilSimulationStepIsDone_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreCalculation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanAndUpdateObstaclesIfNecessary_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	public unsafe bool doubleBuffering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doubleBuffering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doubleBuffering)) = flag;
		}
	}

	public unsafe float desiredDeltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredDeltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredDeltaTime)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<Worker> workers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Worker>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe List<Agent> agents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Agent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ObstacleVertex> obstacles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObstacleVertex>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RVOQuadtree _Quadtree_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Quadtree_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RVOQuadtree>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Quadtree_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rVOQuadtree));
		}
	}

	public unsafe float deltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime)) = num;
		}
	}

	public unsafe float lastStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStep);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStep)) = num;
		}
	}

	public unsafe bool doUpdateObstacles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doUpdateObstacles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doUpdateObstacles)) = flag;
		}
	}

	public unsafe bool doCleanObstacles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doCleanObstacles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doCleanObstacles)) = flag;
		}
	}

	public unsafe float symmetryBreakingBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_symmetryBreakingBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_symmetryBreakingBias)) = num;
		}
	}

	public unsafe MovementPlane movementPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementPlane);
			return *(MovementPlane*)num;
		}
		set
		{
			*(MovementPlane*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementPlane)) = movementPlane;
		}
	}

	public unsafe WorkerContext coroutineWorkerContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coroutineWorkerContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorkerContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coroutineWorkerContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)workerContext));
		}
	}

	public unsafe RVOQuadtree Quadtree
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 18887, RefRangeEnd = 18905, XrefRangeStart = 18887, XrefRangeEnd = 18905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Quadtree_Public_get_RVOQuadtree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RVOQuadtree>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Quadtree_Private_set_Void_RVOQuadtree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float DeltaTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool Multithreading
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081527, RefRangeEnd = 1081528, XrefRangeStart = 1081527, XrefRangeEnd = 1081527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Multithreading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float DesiredDeltaTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DesiredDeltaTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081532, RefRangeEnd = 1081533, XrefRangeStart = 1081528, XrefRangeEnd = 1081532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DesiredDeltaTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Simulator()
	{
		Il2CppClassPointerStore<Simulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.RVO", "Simulator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simulator>.NativeClassPtr);
		NativeFieldInfoPtr_doubleBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "doubleBuffering");
		NativeFieldInfoPtr_desiredDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "desiredDeltaTime");
		NativeFieldInfoPtr_workers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "workers");
		NativeFieldInfoPtr_agents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "agents");
		NativeFieldInfoPtr_obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "obstacles");
		NativeFieldInfoPtr__Quadtree_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "<Quadtree>k__BackingField");
		NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "deltaTime");
		NativeFieldInfoPtr_lastStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "lastStep");
		NativeFieldInfoPtr_doUpdateObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "doUpdateObstacles");
		NativeFieldInfoPtr_doCleanObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "doCleanObstacles");
		NativeFieldInfoPtr_symmetryBreakingBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "symmetryBreakingBias");
		NativeFieldInfoPtr_movementPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "movementPlane");
		NativeFieldInfoPtr_coroutineWorkerContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simulator>.NativeClassPtr, "coroutineWorkerContext");
		NativeMethodInfoPtr_get_Quadtree_Public_get_RVOQuadtree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684086);
		NativeMethodInfoPtr_set_Quadtree_Private_set_Void_RVOQuadtree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684087);
		NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684088);
		NativeMethodInfoPtr_get_Multithreading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684089);
		NativeMethodInfoPtr_get_DesiredDeltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684090);
		NativeMethodInfoPtr_set_DesiredDeltaTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684091);
		NativeMethodInfoPtr_GetAgents_Public_List_1_Agent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684092);
		NativeMethodInfoPtr_GetObstacles_Public_List_1_ObstacleVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684093);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_MovementPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684094);
		NativeMethodInfoPtr_ClearAgents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684095);
		NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684096);
		NativeMethodInfoPtr_AddAgent_Public_IAgent_IAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684097);
		NativeMethodInfoPtr_AddAgent_Public_IAgent_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684098);
		NativeMethodInfoPtr_AddAgent_Public_IAgent_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684099);
		NativeMethodInfoPtr_RemoveAgent_Public_Void_IAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684100);
		NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_ObstacleVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684101);
		NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Il2CppStructArray_1_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684102);
		NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Il2CppStructArray_1_Vector3_Single_Matrix4x4_RVOLayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684103);
		NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684104);
		NativeMethodInfoPtr_UpdateObstacle_Public_Void_ObstacleVertex_Il2CppStructArray_1_Vector3_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684105);
		NativeMethodInfoPtr_ScheduleCleanObstacles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684106);
		NativeMethodInfoPtr_CleanObstacles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684107);
		NativeMethodInfoPtr_RemoveObstacle_Public_Void_ObstacleVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684108);
		NativeMethodInfoPtr_UpdateObstacles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684109);
		NativeMethodInfoPtr_BuildQuadtree_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684110);
		NativeMethodInfoPtr_BlockUntilSimulationStepIsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684111);
		NativeMethodInfoPtr_PreCalculation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684112);
		NativeMethodInfoPtr_CleanAndUpdateObstaclesIfNecessary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684113);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simulator>.NativeClassPtr, 100684114);
	}

	[CallerCount(0)]
	public unsafe List<Agent> GetAgents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAgents_Public_List_1_Agent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Agent>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 18874, RefRangeEnd = 18877, XrefRangeStart = 18874, XrefRangeEnd = 18877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ObstacleVertex> GetObstacles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObstacles_Public_List_1_ObstacleVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObstacleVertex>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081566, RefRangeEnd = 1081567, XrefRangeStart = 1081533, XrefRangeEnd = 1081566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Simulator(int workers, bool doubleBuffering, MovementPlane movementPlane)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simulator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&workers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &doubleBuffering;
		*(MovementPlane**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &movementPlane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_MovementPlane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081576, RefRangeEnd = 1081577, XrefRangeStart = 1081567, XrefRangeEnd = 1081576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAgents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAgents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081579, RefRangeEnd = 1081580, XrefRangeStart = 1081577, XrefRangeEnd = 1081579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1081587, RefRangeEnd = 1081590, XrefRangeStart = 1081580, XrefRangeEnd = 1081587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAgent AddAgent(IAgent agent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAgent_Public_IAgent_IAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAgent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081590, XrefRangeEnd = 1081595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAgent AddAgent(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAgent_Public_IAgent_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAgent>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1081600, RefRangeEnd = 1081606, XrefRangeStart = 1081595, XrefRangeEnd = 1081600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAgent AddAgent(Vector2 position, float elevationCoordinate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &elevationCoordinate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAgent_Public_IAgent_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAgent>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081612, RefRangeEnd = 1081613, XrefRangeStart = 1081606, XrefRangeEnd = 1081612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAgent(IAgent agent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAgent_Public_Void_IAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081617, RefRangeEnd = 1081618, XrefRangeStart = 1081613, XrefRangeEnd = 1081617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleVertex AddObstacle(ObstacleVertex v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_ObstacleVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleVertex>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081620, RefRangeEnd = 1081622, XrefRangeStart = 1081618, XrefRangeEnd = 1081620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleVertex AddObstacle(Il2CppStructArray<Vector3> vertices, float height, bool cycle = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cycle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Il2CppStructArray_1_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleVertex>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081633, RefRangeEnd = 1081635, XrefRangeStart = 1081622, XrefRangeEnd = 1081633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleVertex AddObstacle(Il2CppStructArray<Vector3> vertices, float height, Matrix4x4 matrix, RVOLayer layer = RVOLayer.DefaultObstacle, bool cycle = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		*(RVOLayer**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cycle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Il2CppStructArray_1_Vector3_Single_Matrix4x4_RVOLayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleVertex>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081635, XrefRangeEnd = 1081647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObstacleVertex AddObstacle(Vector3 a, Vector3 b, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObstacle_Public_ObstacleVertex_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObstacleVertex>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081655, RefRangeEnd = 1081657, XrefRangeStart = 1081647, XrefRangeEnd = 1081655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateObstacle(ObstacleVertex obstacle, Il2CppStructArray<Vector3> vertices, Matrix4x4 matrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obstacle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateObstacle_Public_Void_ObstacleVertex_Il2CppStructArray_1_Vector3_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ScheduleCleanObstacles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleCleanObstacles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanObstacles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanObstacles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081661, RefRangeEnd = 1081663, XrefRangeStart = 1081657, XrefRangeEnd = 1081661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveObstacle(ObstacleVertex v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveObstacle_Public_Void_ObstacleVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123739, RefRangeEnd = 123740, XrefRangeStart = 123739, XrefRangeEnd = 123740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateObstacles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateObstacles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1081686, RefRangeEnd = 1081689, XrefRangeStart = 1081663, XrefRangeEnd = 1081686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildQuadtree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildQuadtree_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1081691, RefRangeEnd = 1081699, XrefRangeStart = 1081689, XrefRangeEnd = 1081691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlockUntilSimulationStepIsDone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockUntilSimulationStepIsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081704, RefRangeEnd = 1081706, XrefRangeStart = 1081699, XrefRangeEnd = 1081704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreCalculation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreCalculation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void CleanAndUpdateObstaclesIfNecessary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanAndUpdateObstaclesIfNecessary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081748, RefRangeEnd = 1081749, XrefRangeStart = 1081706, XrefRangeEnd = 1081748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Simulator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
