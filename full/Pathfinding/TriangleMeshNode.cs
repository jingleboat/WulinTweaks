using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding;

public class TriangleMeshNode : MeshNode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_v0;

	private static readonly System.IntPtr NativeFieldInfoPtr_v1;

	private static readonly System.IntPtr NativeFieldInfoPtr_v2;

	private static readonly System.IntPtr NativeFieldInfoPtr__navmeshHolders;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockObject;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNavmeshHolder_Public_Static_INavmeshHolder_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNavmeshHolder_Public_Static_Void_Int32_INavmeshHolder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePositionFromVertices_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexArrayIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertices_Public_Void_byref_Int3_byref_Int3_byref_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVerticesInGraphSpace_Public_Void_byref_Int3_byref_Int3_byref_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertex_Public_Virtual_Int3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexInGraphSpace_Public_Int3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexCount_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnNode_Public_Virtual_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnNodeXZInGraphSpace_Internal_Int3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnNodeXZ_Public_Virtual_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPointInGraphSpace_Public_Virtual_Boolean_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRecursiveG_Public_Virtual_Void_Path_PathNode_PathHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Path_PathNode_PathHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SharedEdge_Public_Int32_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPortal_Public_Virtual_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPortal_Public_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SurfaceArea_Public_Virtual_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomPointOnSurface_Public_Virtual_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeNode_Public_Virtual_Void_GraphSerializationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeNode_Public_Virtual_Void_GraphSerializationContext_0;

	public unsafe int v0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v0);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v0)) = num;
		}
	}

	public unsafe int v1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v1)) = num;
		}
	}

	public unsafe int v2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2)) = num;
		}
	}

	public unsafe static Il2CppReferenceArray<INavmeshHolder> _navmeshHolders
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__navmeshHolders, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<INavmeshHolder>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__navmeshHolders, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppSystem.Object lockObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lockObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lockObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	static TriangleMeshNode()
	{
		Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "TriangleMeshNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr);
		NativeFieldInfoPtr_v0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, "v0");
		NativeFieldInfoPtr_v1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, "v1");
		NativeFieldInfoPtr_v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, "v2");
		NativeFieldInfoPtr__navmeshHolders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, "_navmeshHolders");
		NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, "lockObject");
		NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683385);
		NativeMethodInfoPtr_GetNavmeshHolder_Public_Static_INavmeshHolder_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683386);
		NativeMethodInfoPtr_SetNavmeshHolder_Public_Static_Void_Int32_INavmeshHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683387);
		NativeMethodInfoPtr_UpdatePositionFromVertices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683388);
		NativeMethodInfoPtr_GetVertexIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683389);
		NativeMethodInfoPtr_GetVertexArrayIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683390);
		NativeMethodInfoPtr_GetVertices_Public_Void_byref_Int3_byref_Int3_byref_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683391);
		NativeMethodInfoPtr_GetVerticesInGraphSpace_Public_Void_byref_Int3_byref_Int3_byref_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683392);
		NativeMethodInfoPtr_GetVertex_Public_Virtual_Int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683393);
		NativeMethodInfoPtr_GetVertexInGraphSpace_Public_Int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683394);
		NativeMethodInfoPtr_GetVertexCount_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683395);
		NativeMethodInfoPtr_ClosestPointOnNode_Public_Virtual_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683396);
		NativeMethodInfoPtr_ClosestPointOnNodeXZInGraphSpace_Internal_Int3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683397);
		NativeMethodInfoPtr_ClosestPointOnNodeXZ_Public_Virtual_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683398);
		NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683399);
		NativeMethodInfoPtr_ContainsPointInGraphSpace_Public_Virtual_Boolean_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683400);
		NativeMethodInfoPtr_UpdateRecursiveG_Public_Virtual_Void_Path_PathNode_PathHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683401);
		NativeMethodInfoPtr_Open_Public_Virtual_Void_Path_PathNode_PathHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683402);
		NativeMethodInfoPtr_SharedEdge_Public_Int32_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683403);
		NativeMethodInfoPtr_GetPortal_Public_Virtual_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683404);
		NativeMethodInfoPtr_GetPortal_Public_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683405);
		NativeMethodInfoPtr_SurfaceArea_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683406);
		NativeMethodInfoPtr_RandomPointOnSurface_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683407);
		NativeMethodInfoPtr_SerializeNode_Public_Virtual_Void_GraphSerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683408);
		NativeMethodInfoPtr_DeserializeNode_Public_Virtual_Void_GraphSerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr, 100683409);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1065070, RefRangeEnd = 1065073, XrefRangeStart = 1065070, XrefRangeEnd = 1065073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TriangleMeshNode(AstarPath astar)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriangleMeshNode>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)astar);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1071046, RefRangeEnd = 1071056, XrefRangeStart = 1071042, XrefRangeEnd = 1071046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static INavmeshHolder GetNavmeshHolder(uint graphIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&graphIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNavmeshHolder_Public_Static_INavmeshHolder_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INavmeshHolder>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1071078, RefRangeEnd = 1071083, XrefRangeStart = 1071056, XrefRangeEnd = 1071078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetNavmeshHolder(int graphIndex, INavmeshHolder graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graphIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNavmeshHolder_Public_Static_Void_Int32_INavmeshHolder_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1071087, RefRangeEnd = 1071091, XrefRangeStart = 1071083, XrefRangeEnd = 1071087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePositionFromVertices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePositionFromVertices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1071091, RefRangeEnd = 1071107, XrefRangeStart = 1071091, XrefRangeEnd = 1071091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetVertexIndex(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071107, XrefRangeEnd = 1071119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetVertexArrayIndex(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexArrayIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1071131, RefRangeEnd = 1071136, XrefRangeStart = 1071119, XrefRangeEnd = 1071131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVertices(out Int3 v0, out Int3 v1, out Int3 v2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref v0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertices_Public_Void_byref_Int3_byref_Int3_byref_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1071148, RefRangeEnd = 1071152, XrefRangeStart = 1071136, XrefRangeEnd = 1071148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVerticesInGraphSpace(out Int3 v0, out Int3 v1, out Int3 v2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref v0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVerticesInGraphSpace_Public_Void_byref_Int3_byref_Int3_byref_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071152, XrefRangeEnd = 1071162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Int3 GetVertex(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetVertex_Public_Virtual_Int3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1071172, RefRangeEnd = 1071187, XrefRangeStart = 1071162, XrefRangeEnd = 1071172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3 GetVertexInGraphSpace(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexInGraphSpace_Public_Int3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26824, RefRangeEnd = 26826, XrefRangeStart = 26824, XrefRangeEnd = 26826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetVertexCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetVertexCount_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071187, XrefRangeEnd = 1071195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Vector3 ClosestPointOnNode(Vector3 p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClosestPointOnNode_Public_Virtual_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071222, RefRangeEnd = 1071223, XrefRangeStart = 1071195, XrefRangeEnd = 1071222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3 ClosestPointOnNodeXZInGraphSpace(Vector3 p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosestPointOnNodeXZInGraphSpace_Internal_Int3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071223, XrefRangeEnd = 1071231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Vector3 ClosestPointOnNodeXZ(Vector3 p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClosestPointOnNodeXZ_Public_Virtual_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071231, XrefRangeEnd = 1071241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ContainsPoint(Vector3 p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071241, XrefRangeEnd = 1071242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ContainsPointInGraphSpace(Int3 p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ContainsPointInGraphSpace_Public_Virtual_Boolean_Int3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071242, XrefRangeEnd = 1071246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateRecursiveG_Public_Virtual_Void_Path_PathNode_PathHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071246, XrefRangeEnd = 1071254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Open(Path path, PathNode pathNode, PathHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Open_Public_Virtual_Void_Path_PathNode_PathHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071255, RefRangeEnd = 1071256, XrefRangeStart = 1071254, XrefRangeEnd = 1071255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SharedEdge(GraphNode other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SharedEdge_Public_Int32_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071256, XrefRangeEnd = 1071257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool GetPortal(GraphNode toNode, List<Vector3> left, List<Vector3> right, bool backwards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &backwards;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPortal_Public_Virtual_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071317, RefRangeEnd = 1071318, XrefRangeStart = 1071257, XrefRangeEnd = 1071317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPortal(GraphNode toNode, List<Vector3> left, List<Vector3> right, bool backwards, out int aIndex, out int bIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &backwards;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aIndex);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPortal_Public_Boolean_GraphNode_List_1_Vector3_List_1_Vector3_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071318, XrefRangeEnd = 1071334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float SurfaceArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SurfaceArea_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071334, XrefRangeEnd = 1071357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Vector3 RandomPointOnSurface()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RandomPointOnSurface_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071357, XrefRangeEnd = 1071359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SerializeNode(GraphSerializationContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SerializeNode_Public_Virtual_Void_GraphSerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071359, XrefRangeEnd = 1071360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DeserializeNode(GraphSerializationContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeserializeNode_Public_Virtual_Void_GraphSerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TriangleMeshNode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
