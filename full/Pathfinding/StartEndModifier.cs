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

[System.Serializable]
public class StartEndModifier : PathModifier
{
	public enum Exactness
	{
		SnapToNode,
		Original,
		Interpolate,
		ClosestOnNode,
		NodeConnection
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_addPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_exactStartPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_exactEndPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjustStartPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRaycasting;

	private static readonly System.IntPtr NativeFieldInfoPtr_mask;

	private static readonly System.IntPtr NativeFieldInfoPtr_useGraphRaycasting;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectionBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectionBufferAddDelegate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Snap_Private_Vector3_ABPath_Exactness_Boolean_byref_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClampedPoint_Protected_Vector3_Vector3_Vector3_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool addPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addPoints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addPoints)) = flag;
		}
	}

	public unsafe Exactness exactStartPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exactStartPoint);
			return *(Exactness*)num;
		}
		set
		{
			*(Exactness*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exactStartPoint)) = exactness;
		}
	}

	public unsafe Exactness exactEndPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exactEndPoint);
			return *(Exactness*)num;
		}
		set
		{
			*(Exactness*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exactEndPoint)) = exactness;
		}
	}

	public unsafe Il2CppSystem.Func<Vector3> adjustStartPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustStartPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustStartPoint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe bool useRaycasting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRaycasting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRaycasting)) = flag;
		}
	}

	public unsafe LayerMask mask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask)) = layerMask;
		}
	}

	public unsafe bool useGraphRaycasting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGraphRaycasting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGraphRaycasting)) = flag;
		}
	}

	public unsafe List<GraphNode> connectionBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GraphNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppSystem.Action<GraphNode> connectionBufferAddDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionBufferAddDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GraphNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionBufferAddDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe override int Order
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 26795, RefRangeEnd = 26824, XrefRangeStart = 26795, XrefRangeEnd = 26824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static StartEndModifier()
	{
		Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "StartEndModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr);
		NativeFieldInfoPtr_addPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "addPoints");
		NativeFieldInfoPtr_exactStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "exactStartPoint");
		NativeFieldInfoPtr_exactEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "exactEndPoint");
		NativeFieldInfoPtr_adjustStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "adjustStartPoint");
		NativeFieldInfoPtr_useRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "useRaycasting");
		NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "mask");
		NativeFieldInfoPtr_useGraphRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "useGraphRaycasting");
		NativeFieldInfoPtr_connectionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "connectionBuffer");
		NativeFieldInfoPtr_connectionBufferAddDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, "connectionBufferAddDelegate");
		NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, 100683610);
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, 100683611);
		NativeMethodInfoPtr_Snap_Private_Vector3_ABPath_Exactness_Boolean_byref_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, 100683612);
		NativeMethodInfoPtr_GetClampedPoint_Protected_Vector3_Vector3_Vector3_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, 100683613);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr, 100683614);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074773, XrefRangeEnd = 1074794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply(Path _p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074806, RefRangeEnd = 1074808, XrefRangeStart = 1074794, XrefRangeEnd = 1074806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 Snap(ABPath path, Exactness mode, bool start, out bool forceAddPoint, out int closestConnectionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(Exactness**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref forceAddPoint);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref closestConnectionIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Snap_Private_Vector3_ABPath_Exactness_Boolean_byref_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074808, XrefRangeEnd = 1074817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetClampedPoint(Vector3 from, Vector3 to, GraphNode hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClampedPoint_Protected_Vector3_Vector3_Vector3_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074819, RefRangeEnd = 1074820, XrefRangeStart = 1074817, XrefRangeEnd = 1074819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartEndModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartEndModifier>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartEndModifier(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
