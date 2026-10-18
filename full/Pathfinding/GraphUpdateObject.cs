using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public class GraphUpdateObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_updatePhysics;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetPenaltyOnPhysics;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateErosion;

	private static readonly System.IntPtr NativeFieldInfoPtr_nnConstraint;

	private static readonly System.IntPtr NativeFieldInfoPtr_addPenalty;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifyWalkability;

	private static readonly System.IntPtr NativeFieldInfoPtr_setWalkability;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifyTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_setTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackChangedNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_changedNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_backupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_backupPositionData;

	private static readonly System.IntPtr NativeFieldInfoPtr_shape;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalStage;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAGE_CREATED;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAGE_PENDING;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAGE_ABORTED;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAGE_APPLIED;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_requiresFloodFill_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stage_Public_get_GraphUpdateStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WillUpdateNode_Public_Virtual_New_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RevertFromBackup_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bounds_0;

	public unsafe Bounds bounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds)) = bounds;
		}
	}

	public unsafe bool updatePhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatePhysics);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatePhysics)) = flag;
		}
	}

	public unsafe bool resetPenaltyOnPhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetPenaltyOnPhysics);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetPenaltyOnPhysics)) = flag;
		}
	}

	public unsafe bool updateErosion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateErosion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateErosion)) = flag;
		}
	}

	public unsafe NNConstraint nnConstraint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nnConstraint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NNConstraint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nnConstraint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nNConstraint));
		}
	}

	public unsafe int addPenalty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addPenalty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addPenalty)) = num;
		}
	}

	public unsafe bool modifyWalkability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyWalkability);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyWalkability)) = flag;
		}
	}

	public unsafe bool setWalkability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setWalkability);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setWalkability)) = flag;
		}
	}

	public unsafe bool modifyTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyTag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyTag)) = flag;
		}
	}

	public unsafe int setTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setTag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setTag)) = num;
		}
	}

	public unsafe bool trackChangedNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackChangedNodes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackChangedNodes)) = flag;
		}
	}

	public unsafe List<GraphNode> changedNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changedNodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GraphNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changedNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<uint> backupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Int3> backupPositionData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupPositionData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Int3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupPositionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GraphUpdateShape shape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shape);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphUpdateShape>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shape)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphUpdateShape));
		}
	}

	public unsafe int internalStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalStage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalStage)) = num;
		}
	}

	public unsafe static int STAGE_CREATED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAGE_CREATED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAGE_CREATED, (void*)(&num));
		}
	}

	public unsafe static int STAGE_PENDING
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAGE_PENDING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAGE_PENDING, (void*)(&num));
		}
	}

	public unsafe static int STAGE_ABORTED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAGE_ABORTED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAGE_ABORTED, (void*)(&num));
		}
	}

	public unsafe static int STAGE_APPLIED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAGE_APPLIED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAGE_APPLIED, (void*)(&num));
		}
	}

	public unsafe bool requiresFloodFill
	{
		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_requiresFloodFill_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GraphUpdateStage stage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067205, RefRangeEnd = 1067206, XrefRangeStart = 1067205, XrefRangeEnd = 1067205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stage_Public_get_GraphUpdateStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(GraphUpdateStage*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static GraphUpdateObject()
	{
		Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "GraphUpdateObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr);
		NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "bounds");
		NativeFieldInfoPtr_updatePhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "updatePhysics");
		NativeFieldInfoPtr_resetPenaltyOnPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "resetPenaltyOnPhysics");
		NativeFieldInfoPtr_updateErosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "updateErosion");
		NativeFieldInfoPtr_nnConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "nnConstraint");
		NativeFieldInfoPtr_addPenalty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "addPenalty");
		NativeFieldInfoPtr_modifyWalkability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "modifyWalkability");
		NativeFieldInfoPtr_setWalkability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "setWalkability");
		NativeFieldInfoPtr_modifyTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "modifyTag");
		NativeFieldInfoPtr_setTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "setTag");
		NativeFieldInfoPtr_trackChangedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "trackChangedNodes");
		NativeFieldInfoPtr_changedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "changedNodes");
		NativeFieldInfoPtr_backupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "backupData");
		NativeFieldInfoPtr_backupPositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "backupPositionData");
		NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "shape");
		NativeFieldInfoPtr_internalStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "internalStage");
		NativeFieldInfoPtr_STAGE_CREATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "STAGE_CREATED");
		NativeFieldInfoPtr_STAGE_PENDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "STAGE_PENDING");
		NativeFieldInfoPtr_STAGE_ABORTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "STAGE_ABORTED");
		NativeFieldInfoPtr_STAGE_APPLIED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, "STAGE_APPLIED");
		NativeMethodInfoPtr_set_requiresFloodFill_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682939);
		NativeMethodInfoPtr_get_stage_Public_get_GraphUpdateStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682940);
		NativeMethodInfoPtr_WillUpdateNode_Public_Virtual_New_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682941);
		NativeMethodInfoPtr_RevertFromBackup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682942);
		NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682943);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682944);
		NativeMethodInfoPtr__ctor_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr, 100682945);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067206, XrefRangeEnd = 1067240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void WillUpdateNode(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WillUpdateNode_Public_Virtual_New_Void_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067240, XrefRangeEnd = 1067281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RevertFromBackup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RevertFromBackup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067281, XrefRangeEnd = 1067285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Apply(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067287, RefRangeEnd = 1067288, XrefRangeStart = 1067285, XrefRangeEnd = 1067287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphUpdateObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1067290, RefRangeEnd = 1067301, XrefRangeStart = 1067288, XrefRangeEnd = 1067290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphUpdateObject(Bounds b)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphUpdateObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GraphUpdateObject(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
