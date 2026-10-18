using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public class NodeLink3Node : PointNode
{
	private static readonly IntPtr NativeFieldInfoPtr_link;

	private static readonly IntPtr NativeFieldInfoPtr_portalA;

	private static readonly IntPtr NativeFieldInfoPtr_portalB;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPortal_Public_Virtual_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOther_Public_GraphNode_GraphNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOtherInternal_Private_GraphNode_GraphNode_0;

	public unsafe NodeLink3 link
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NodeLink3>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeLink));
		}
	}

	public unsafe Vector3 portalA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_portalA);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_portalA)) = vector;
		}
	}

	public unsafe Vector3 portalB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_portalB);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_portalB)) = vector;
		}
	}

	static NodeLink3Node()
	{
		Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "NodeLink3Node");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr);
		NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, "link");
		NativeFieldInfoPtr_portalA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, "portalA");
		NativeFieldInfoPtr_portalB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, "portalB");
		NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, 100682663);
		NativeMethodInfoPtr_GetPortal_Public_Virtual_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, 100682664);
		NativeMethodInfoPtr_GetOther_Public_GraphNode_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, 100682665);
		NativeMethodInfoPtr_GetOtherInternal_Private_GraphNode_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr, 100682666);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1065070, RefRangeEnd = 1065073, XrefRangeStart = 1065069, XrefRangeEnd = 1065070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NodeLink3Node(AstarPath active)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeLink3Node>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)active);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065073, XrefRangeEnd = 1065078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &backwards;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPortal_Public_Virtual_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065081, RefRangeEnd = 1065082, XrefRangeStart = 1065078, XrefRangeEnd = 1065081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphNode GetOther(GraphNode a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOther_Public_GraphNode_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065082, RefRangeEnd = 1065083, XrefRangeStart = 1065082, XrefRangeEnd = 1065082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphNode GetOtherInternal(GraphNode a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOtherInternal_Private_GraphNode_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
	}

	public NodeLink3Node(IntPtr pointer)
		: base(pointer)
	{
	}
}
