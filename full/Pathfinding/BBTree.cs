using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding;

public class BBTree : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct BBTreeBox
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rect;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodeOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_left;

		private static readonly System.IntPtr NativeFieldInfoPtr_right;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLeaf_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntRect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IntRect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;

		[FieldOffset(0)]
		public IntRect rect;

		[FieldOffset(16)]
		public int nodeOffset;

		[FieldOffset(20)]
		public int left;

		[FieldOffset(24)]
		public int right;

		public unsafe bool IsLeaf
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 713523, RefRangeEnd = 713531, XrefRangeStart = 713523, XrefRangeEnd = 713531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLeaf_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static BBTreeBox()
		{
			Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BBTree>.NativeClassPtr, "BBTreeBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr);
			NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, "rect");
			NativeFieldInfoPtr_nodeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, "nodeOffset");
			NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, "left");
			NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, "right");
			NativeMethodInfoPtr_get_IsLeaf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, 100689486);
			NativeMethodInfoPtr__ctor_Public_Void_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, 100689487);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, 100689488);
			NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, 100689489);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072333, RefRangeEnd = 1072335, XrefRangeStart = 1072333, XrefRangeEnd = 1072333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BBTreeBox(IntRect rect)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&rect);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IntRect_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe BBTreeBox(int nodeOffset, IntRect rect)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&nodeOffset);
			*(IntRect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_IntRect_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1072337, RefRangeEnd = 1072340, XrefRangeStart = 1072335, XrefRangeEnd = 1072337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Vector3 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&point);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BBTreeBox>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tree;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_leafNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaximumLeafSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pathfinding_Util_IAstarPooledObject_OnEnterPool_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureNodeCapacity_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBox_Private_Int32_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildFrom_Public_Void_Il2CppReferenceArray_1_TriangleMeshNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitByX_Private_Static_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitByZ_Private_Static_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildFromInternal_Private_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IntRect_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NodeBounds_Private_Static_IntRect_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IntRect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawDebugRect_Private_Static_Void_IntRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawDebugNode_Private_Static_Void_TriangleMeshNode_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryClosest_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryClosestXZ_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_NNInfoInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchBoxClosestXZ_Private_Void_Int32_Vector3_byref_Single_NNConstraint_byref_NNInfoInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryClosest_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_NNInfoInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchBoxClosest_Private_Void_Int32_Vector3_byref_Single_NNConstraint_byref_NNInfoInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderedChildren_Private_Void_byref_Int32_byref_Int32_byref_Single_byref_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryInside_Public_TriangleMeshNode_Vector3_NNConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchBoxInside_Private_TriangleMeshNode_Int32_Vector3_NNConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NodeIntersectsCircle_Private_Static_Boolean_TriangleMeshNode_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectIntersectsCircle_Private_Static_Boolean_IntRect_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SquaredRectPointDistance_Private_Static_Single_IntRect_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<BBTreeBox> tree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<BBTreeBox>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<TriangleMeshNode> nodeLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TriangleMeshNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
		}
	}

	public unsafe int leafNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leafNodes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leafNodes)) = num;
		}
	}

	public unsafe static int MaximumLeafSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaximumLeafSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaximumLeafSize, (void*)(&num));
		}
	}

	public unsafe Rect Size
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072340, XrefRangeEnd = 1072341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Size_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BBTree()
	{
		Il2CppClassPointerStore<BBTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "BBTree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BBTree>.NativeClassPtr);
		NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTree>.NativeClassPtr, "tree");
		NativeFieldInfoPtr_nodeLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTree>.NativeClassPtr, "nodeLookup");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTree>.NativeClassPtr, "count");
		NativeFieldInfoPtr_leafNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTree>.NativeClassPtr, "leafNodes");
		NativeFieldInfoPtr_MaximumLeafSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BBTree>.NativeClassPtr, "MaximumLeafSize");
		NativeMethodInfoPtr_get_Size_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683469);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683470);
		NativeMethodInfoPtr_Pathfinding_Util_IAstarPooledObject_OnEnterPool_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683471);
		NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683472);
		NativeMethodInfoPtr_EnsureNodeCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683473);
		NativeMethodInfoPtr_GetBox_Private_Int32_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683474);
		NativeMethodInfoPtr_RebuildFrom_Public_Void_Il2CppReferenceArray_1_TriangleMeshNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683475);
		NativeMethodInfoPtr_SplitByX_Private_Static_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683476);
		NativeMethodInfoPtr_SplitByZ_Private_Static_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683477);
		NativeMethodInfoPtr_RebuildFromInternal_Private_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IntRect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683478);
		NativeMethodInfoPtr_NodeBounds_Private_Static_IntRect_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IntRect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683479);
		NativeMethodInfoPtr_DrawDebugRect_Private_Static_Void_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683480);
		NativeMethodInfoPtr_DrawDebugNode_Private_Static_Void_TriangleMeshNode_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683481);
		NativeMethodInfoPtr_QueryClosest_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683482);
		NativeMethodInfoPtr_QueryClosestXZ_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_NNInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683483);
		NativeMethodInfoPtr_SearchBoxClosestXZ_Private_Void_Int32_Vector3_byref_Single_NNConstraint_byref_NNInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683484);
		NativeMethodInfoPtr_QueryClosest_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_NNInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683485);
		NativeMethodInfoPtr_SearchBoxClosest_Private_Void_Int32_Vector3_byref_Single_NNConstraint_byref_NNInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683486);
		NativeMethodInfoPtr_GetOrderedChildren_Private_Void_byref_Int32_byref_Int32_byref_Single_byref_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683487);
		NativeMethodInfoPtr_QueryInside_Public_TriangleMeshNode_Vector3_NNConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683488);
		NativeMethodInfoPtr_SearchBoxInside_Private_TriangleMeshNode_Int32_Vector3_NNConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683489);
		NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683490);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683491);
		NativeMethodInfoPtr_NodeIntersectsCircle_Private_Static_Boolean_TriangleMeshNode_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683492);
		NativeMethodInfoPtr_RectIntersectsCircle_Private_Static_Boolean_IntRect_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683493);
		NativeMethodInfoPtr_SquaredRectPointDistance_Private_Static_Single_IntRect_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683494);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BBTree>.NativeClassPtr, 100683495);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072364, RefRangeEnd = 1072366, XrefRangeStart = 1072341, XrefRangeEnd = 1072364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072366, XrefRangeEnd = 1072367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Pathfinding_Util_IAstarPooledObject_OnEnterPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pathfinding_Util_IAstarPooledObject_OnEnterPool_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072377, RefRangeEnd = 1072380, XrefRangeStart = 1072367, XrefRangeEnd = 1072377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureCapacity(int c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072390, RefRangeEnd = 1072391, XrefRangeStart = 1072380, XrefRangeEnd = 1072390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureNodeCapacity(int c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureNodeCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072391, XrefRangeEnd = 1072393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBox(IntRect rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBox_Private_Int32_IntRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1072427, RefRangeEnd = 1072432, XrefRangeStart = 1072393, XrefRangeEnd = 1072427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildFrom(Il2CppReferenceArray<TriangleMeshNode> nodes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildFrom_Public_Void_Il2CppReferenceArray_1_TriangleMeshNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int SplitByX(Il2CppReferenceArray<TriangleMeshNode> nodes, Il2CppStructArray<int> permutation, int from, int to, int divider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)permutation);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &divider;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitByX_Private_Static_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int SplitByZ(Il2CppReferenceArray<TriangleMeshNode> nodes, Il2CppStructArray<int> permutation, int from, int to, int divider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)permutation);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &divider;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitByZ_Private_Static_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072440, RefRangeEnd = 1072443, XrefRangeStart = 1072432, XrefRangeEnd = 1072440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RebuildFromInternal(Il2CppReferenceArray<TriangleMeshNode> nodes, Il2CppStructArray<int> permutation, Il2CppStructArray<IntRect> nodeBounds, int from, int to, bool odd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)permutation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeBounds);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &odd;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildFromInternal_Private_Int32_Il2CppReferenceArray_1_TriangleMeshNode_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IntRect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072450, RefRangeEnd = 1072451, XrefRangeStart = 1072443, XrefRangeEnd = 1072450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntRect NodeBounds(Il2CppStructArray<int> permutation, Il2CppStructArray<IntRect> nodeBounds, int from, int to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)permutation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeBounds);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NodeBounds_Private_Static_IntRect_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IntRect_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IntRect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072451, XrefRangeEnd = 1072462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawDebugRect(IntRect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDebugRect_Private_Static_Void_IntRect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072462, XrefRangeEnd = 1072480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawDebugNode(TriangleMeshNode node, float yoffset, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yoffset;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDebugNode_Private_Static_Void_TriangleMeshNode_Single_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072480, XrefRangeEnd = 1072485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NNInfoInternal QueryClosest(Vector3 p, NNConstraint constraint, out float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryClosest_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NNInfoInternal(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072489, RefRangeEnd = 1072490, XrefRangeStart = 1072485, XrefRangeEnd = 1072489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NNInfoInternal QueryClosestXZ(Vector3 p, NNConstraint constraint, ref float distance, NNInfoInternal previous)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&p);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)previous));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryClosestXZ_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_NNInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NNInfoInternal(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072495, RefRangeEnd = 1072498, XrefRangeStart = 1072490, XrefRangeEnd = 1072495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SearchBoxClosestXZ(int boxi, Vector3 p, ref float closestSqrDist, NNConstraint constraint, ref NNInfoInternal nnInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&boxi);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref closestSqrDist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nnInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchBoxClosestXZ_Private_Void_Int32_Vector3_byref_Single_NNConstraint_byref_NNInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072502, RefRangeEnd = 1072503, XrefRangeStart = 1072498, XrefRangeEnd = 1072502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NNInfoInternal QueryClosest(Vector3 p, NNConstraint constraint, ref float distance, NNInfoInternal previous)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&p);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)previous));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryClosest_Public_NNInfoInternal_Vector3_NNConstraint_byref_Single_NNInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NNInfoInternal(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1072508, RefRangeEnd = 1072512, XrefRangeStart = 1072503, XrefRangeEnd = 1072508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SearchBoxClosest(int boxi, Vector3 p, ref float closestSqrDist, NNConstraint constraint, ref NNInfoInternal nnInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&boxi);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref closestSqrDist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nnInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchBoxClosest_Private_Void_Int32_Vector3_byref_Single_NNConstraint_byref_NNInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072512, XrefRangeEnd = 1072514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetOrderedChildren(ref int first, ref int second, out float firstDist, out float secondDist, Vector3 p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref first);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref second);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref firstDist);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref secondDist);
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrderedChildren_Private_Void_byref_Int32_byref_Int32_byref_Single_byref_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072516, RefRangeEnd = 1072517, XrefRangeStart = 1072514, XrefRangeEnd = 1072516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TriangleMeshNode QueryInside(Vector3 p, NNConstraint constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryInside_Public_TriangleMeshNode_Vector3_NNConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TriangleMeshNode>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072522, RefRangeEnd = 1072525, XrefRangeStart = 1072517, XrefRangeEnd = 1072522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TriangleMeshNode SearchBoxInside(int boxi, Vector3 p, NNConstraint constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&boxi);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchBoxInside_Private_TriangleMeshNode_Int32_Vector3_NNConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TriangleMeshNode>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072525, XrefRangeEnd = 1072528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072538, RefRangeEnd = 1072541, XrefRangeStart = 1072528, XrefRangeEnd = 1072538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos(int boxi, int depth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&boxi);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072541, XrefRangeEnd = 1072543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NodeIntersectsCircle(TriangleMeshNode node, Vector3 p, float radius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NodeIntersectsCircle_Private_Static_Boolean_TriangleMeshNode_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072543, XrefRangeEnd = 1072552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RectIntersectsCircle(IntRect r, Vector3 p, float radius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&r);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectIntersectsCircle_Private_Static_Boolean_IntRect_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1072559, RefRangeEnd = 1072568, XrefRangeStart = 1072552, XrefRangeEnd = 1072559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SquaredRectPointDistance(IntRect r, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&r);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SquaredRectPointDistance_Private_Static_Single_IntRect_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BBTree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BBTree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BBTree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
