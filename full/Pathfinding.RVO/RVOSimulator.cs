using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Pathfinding.RVO;

public class RVOSimulator : VersionedMonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_desiredSimulationFPS;

	private static readonly IntPtr NativeFieldInfoPtr_workerThreads;

	private static readonly IntPtr NativeFieldInfoPtr_doubleBuffering;

	private static readonly IntPtr NativeFieldInfoPtr_symmetryBreakingBias;

	private static readonly IntPtr NativeFieldInfoPtr_movementPlane;

	private static readonly IntPtr NativeFieldInfoPtr_drawObstacles;

	private static readonly IntPtr NativeFieldInfoPtr_simulator;

	private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_RVOSimulator_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_active_Private_Static_set_Void_RVOSimulator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSimulator_Public_Simulator_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static RVOSimulator _active_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__active_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RVOSimulator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__active_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rVOSimulator));
		}
	}

	public unsafe int desiredSimulationFPS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSimulationFPS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSimulationFPS)) = num;
		}
	}

	public unsafe ThreadCount workerThreads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workerThreads);
			return *(ThreadCount*)num;
		}
		set
		{
			*(ThreadCount*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workerThreads)) = threadCount;
		}
	}

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

	public unsafe bool drawObstacles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawObstacles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawObstacles)) = flag;
		}
	}

	public unsafe Simulator simulator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulator);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Simulator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simulator));
		}
	}

	public unsafe static RVOSimulator active
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082485, XrefRangeEnd = 1082487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_active_Public_Static_get_RVOSimulator_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RVOSimulator>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082487, XrefRangeEnd = 1082489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_active_Private_Static_set_Void_RVOSimulator_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RVOSimulator()
	{
		Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.RVO", "RVOSimulator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr);
		NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "<active>k__BackingField");
		NativeFieldInfoPtr_desiredSimulationFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "desiredSimulationFPS");
		NativeFieldInfoPtr_workerThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "workerThreads");
		NativeFieldInfoPtr_doubleBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "doubleBuffering");
		NativeFieldInfoPtr_symmetryBreakingBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "symmetryBreakingBias");
		NativeFieldInfoPtr_movementPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "movementPlane");
		NativeFieldInfoPtr_drawObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "drawObstacles");
		NativeFieldInfoPtr_simulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, "simulator");
		NativeMethodInfoPtr_get_active_Public_Static_get_RVOSimulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684191);
		NativeMethodInfoPtr_set_active_Private_Static_set_Void_RVOSimulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684192);
		NativeMethodInfoPtr_GetSimulator_Public_Simulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684193);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684194);
		NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684195);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684196);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684197);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr, 100684198);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1082489, RefRangeEnd = 1082495, XrefRangeStart = 1082489, XrefRangeEnd = 1082489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Simulator GetSimulator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimulator_Public_Simulator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Simulator>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082495, XrefRangeEnd = 1082497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082497, XrefRangeEnd = 1082509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082509, XrefRangeEnd = 1082512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082512, XrefRangeEnd = 1082515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082515, XrefRangeEnd = 1082516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RVOSimulator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RVOSimulator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RVOSimulator(IntPtr pointer)
		: base(pointer)
	{
	}
}
