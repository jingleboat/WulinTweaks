using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public class FloodPath : Path
{
	private static readonly IntPtr NativeFieldInfoPtr_originalStartPoint;

	private static readonly IntPtr NativeFieldInfoPtr_startPoint;

	private static readonly IntPtr NativeFieldInfoPtr_startNode;

	private static readonly IntPtr NativeFieldInfoPtr_saveParents;

	private static readonly IntPtr NativeFieldInfoPtr_parents;

	private static readonly IntPtr NativeMethodInfoPtr_get_FloodingPath_Public_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasPathTo_Public_Boolean_GraphNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_GraphNode_GraphNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Construct_Public_Static_FloodPath_Vector3_OnPathDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_Construct_Public_Static_FloodPath_GraphNode_OnPathDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Protected_Void_Vector3_OnPathDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Protected_Void_GraphNode_OnPathDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Prepare_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateStep_Protected_Virtual_Void_Int64_0;

	public unsafe Vector3 originalStartPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalStartPoint);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalStartPoint)) = vector;
		}
	}

	public unsafe Vector3 startPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPoint);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPoint)) = vector;
		}
	}

	public unsafe GraphNode startNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startNode);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphNode));
		}
	}

	public unsafe bool saveParents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveParents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveParents)) = flag;
		}
	}

	public unsafe Dictionary<GraphNode, GraphNode> parents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GraphNode, GraphNode>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe override bool FloodingPath
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_FloodingPath_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static FloodPath()
	{
		Il2CppClassPointerStore<FloodPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "FloodPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloodPath>.NativeClassPtr);
		NativeFieldInfoPtr_originalStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, "originalStartPoint");
		NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, "startPoint");
		NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, "startNode");
		NativeFieldInfoPtr_saveParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, "saveParents");
		NativeFieldInfoPtr_parents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, "parents");
		NativeMethodInfoPtr_get_FloodingPath_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683722);
		NativeMethodInfoPtr_HasPathTo_Public_Boolean_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683723);
		NativeMethodInfoPtr_GetParent_Public_GraphNode_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683724);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683725);
		NativeMethodInfoPtr_Construct_Public_Static_FloodPath_Vector3_OnPathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683726);
		NativeMethodInfoPtr_Construct_Public_Static_FloodPath_GraphNode_OnPathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683727);
		NativeMethodInfoPtr_Setup_Protected_Void_Vector3_OnPathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683728);
		NativeMethodInfoPtr_Setup_Protected_Void_GraphNode_OnPathDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683729);
		NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683730);
		NativeMethodInfoPtr_Prepare_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683731);
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683732);
		NativeMethodInfoPtr_CalculateStep_Protected_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPath>.NativeClassPtr, 100683733);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076012, XrefRangeEnd = 1076013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasPathTo(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPathTo_Public_Boolean_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076013, XrefRangeEnd = 1076017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphNode GetParent(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Public_GraphNode_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076017, XrefRangeEnd = 1076021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FloodPath()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloodPath>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076021, XrefRangeEnd = 1076027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FloodPath Construct(Vector3 start, OnPathDelegate callback = null)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&start);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Construct_Public_Static_FloodPath_Vector3_OnPathDelegate_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FloodPath>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1076035, RefRangeEnd = 1076036, XrefRangeStart = 1076027, XrefRangeEnd = 1076035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FloodPath Construct(GraphNode start, OnPathDelegate callback = null)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Construct_Public_Static_FloodPath_GraphNode_OnPathDelegate_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FloodPath>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void Setup(Vector3 start, OnPathDelegate callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&start);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Protected_Void_Vector3_OnPathDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076036, XrefRangeEnd = 1076038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(GraphNode start, OnPathDelegate callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Protected_Void_GraphNode_OnPathDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076038, XrefRangeEnd = 1076047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076047, XrefRangeEnd = 1076056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Prepare_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076056, XrefRangeEnd = 1076065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076065, XrefRangeEnd = 1076075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CalculateStep(long targetTick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&targetTick);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculateStep_Protected_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FloodPath(IntPtr pointer)
		: base(pointer)
	{
	}
}
