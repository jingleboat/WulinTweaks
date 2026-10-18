using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Pathfinding;

public class PointKDTree : Il2CppSystem.Object
{
	public sealed class Node : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeFieldInfoPtr_split;

		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeFieldInfoPtr_splitAxis;

		public unsafe Il2CppReferenceArray<GraphNode> data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphNode>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int split
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_split);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_split)) = num;
			}
		}

		public unsafe ushort count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
			}
		}

		public unsafe byte splitAxis
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitAxis);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitAxis)) = b;
			}
		}

		static Node()
		{
			Il2CppClassPointerStore<Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "Node");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "data");
			NativeFieldInfoPtr_split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "split");
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "count");
			NativeFieldInfoPtr_splitAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "splitAxis");
		}

		public Node(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Node()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node>.NativeClassPtr))
		{
		}
	}

	public class CompareX : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static CompareX()
		{
			Il2CppClassPointerStore<CompareX>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "CompareX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareX>.NativeClassPtr);
			NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareX>.NativeClassPtr, 100689501);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareX>.NativeClassPtr, 100689502);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073091, XrefRangeEnd = 1073093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(GraphNode lhs, GraphNode rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareX>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompareX(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CompareY : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static CompareY()
		{
			Il2CppClassPointerStore<CompareY>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "CompareY");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareY>.NativeClassPtr);
			NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareY>.NativeClassPtr, 100689503);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareY>.NativeClassPtr, 100689504);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(GraphNode lhs, GraphNode rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareY()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareY>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompareY(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CompareZ : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static CompareZ()
		{
			Il2CppClassPointerStore<CompareZ>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "CompareZ");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareZ>.NativeClassPtr);
			NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareZ>.NativeClassPtr, 100689505);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareZ>.NativeClassPtr, 100689506);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073093, XrefRangeEnd = 1073095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(GraphNode lhs, GraphNode rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_GraphNode_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareZ()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareZ>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompareZ(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_LeafSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeafArraySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_tree;

	private static readonly System.IntPtr NativeFieldInfoPtr_numNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrayCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_comparers;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rebuild_Public_Void_Il2CppReferenceArray_1_GraphNode_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateList_Private_Il2CppReferenceArray_1_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Size_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectAndClear_Private_Void_Int32_List_1_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxAllowedSize_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rebalance_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureSize_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Build_Private_Void_Int32_List_1_GraphNode_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Void_GraphNode_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearest_Public_GraphNode_Int3_NNConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestInternal_Private_Void_Int32_Int3_NNConstraint_byref_GraphNode_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestConnection_Public_GraphNode_Int3_NNConstraint_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestConnectionInternal_Private_Void_Int32_Int3_NNConstraint_byref_GraphNode_byref_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInRange_Public_Void_Int3_Int64_List_1_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInRangeInternal_Private_Void_Int32_Int3_Int64_List_1_GraphNode_0;

	public unsafe static int LeafSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LeafSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LeafSize, (void*)(&num));
		}
	}

	public unsafe static int LeafArraySize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LeafArraySize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LeafArraySize, (void*)(&num));
		}
	}

	public unsafe Il2CppReferenceArray<Node> tree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Node>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int numNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numNodes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numNodes)) = num;
		}
	}

	public unsafe List<GraphNode> largeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GraphNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Stack<Il2CppReferenceArray<GraphNode>> arrayCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrayCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<Il2CppReferenceArray<GraphNode>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrayCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack));
		}
	}

	public unsafe static Il2CppReferenceArray<IComparer<GraphNode>> comparers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_comparers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IComparer<GraphNode>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_comparers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static PointKDTree()
	{
		Il2CppClassPointerStore<PointKDTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "PointKDTree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr);
		NativeFieldInfoPtr_LeafSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "LeafSize");
		NativeFieldInfoPtr_LeafArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "LeafArraySize");
		NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "tree");
		NativeFieldInfoPtr_numNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "numNodes");
		NativeFieldInfoPtr_largeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "largeList");
		NativeFieldInfoPtr_arrayCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "arrayCache");
		NativeFieldInfoPtr_comparers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, "comparers");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683518);
		NativeMethodInfoPtr_Add_Public_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683519);
		NativeMethodInfoPtr_Rebuild_Public_Void_Il2CppReferenceArray_1_GraphNode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683520);
		NativeMethodInfoPtr_GetOrCreateList_Private_Il2CppReferenceArray_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683521);
		NativeMethodInfoPtr_Size_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683522);
		NativeMethodInfoPtr_CollectAndClear_Private_Void_Int32_List_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683523);
		NativeMethodInfoPtr_MaxAllowedSize_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683524);
		NativeMethodInfoPtr_Rebalance_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683525);
		NativeMethodInfoPtr_EnsureSize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683526);
		NativeMethodInfoPtr_Build_Private_Void_Int32_List_1_GraphNode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683527);
		NativeMethodInfoPtr_Add_Private_Void_GraphNode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683528);
		NativeMethodInfoPtr_GetNearest_Public_GraphNode_Int3_NNConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683529);
		NativeMethodInfoPtr_GetNearestInternal_Private_Void_Int32_Int3_NNConstraint_byref_GraphNode_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683530);
		NativeMethodInfoPtr_GetNearestConnection_Public_GraphNode_Int3_NNConstraint_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683531);
		NativeMethodInfoPtr_GetNearestConnectionInternal_Private_Void_Int32_Int3_NNConstraint_byref_GraphNode_byref_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683532);
		NativeMethodInfoPtr_GetInRange_Public_Void_Int3_Int64_List_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683533);
		NativeMethodInfoPtr_GetInRangeInternal_Private_Void_Int32_Int3_Int64_List_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr, 100683534);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073112, RefRangeEnd = 1073114, XrefRangeStart = 1073095, XrefRangeEnd = 1073112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PointKDTree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointKDTree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073114, XrefRangeEnd = 1073115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073125, RefRangeEnd = 1073126, XrefRangeStart = 1073115, XrefRangeEnd = 1073125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rebuild(Il2CppReferenceArray<GraphNode> nodes, int start, int end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rebuild_Public_Void_Il2CppReferenceArray_1_GraphNode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073134, RefRangeEnd = 1073135, XrefRangeStart = 1073126, XrefRangeEnd = 1073134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<GraphNode> GetOrCreateList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateList_Private_Il2CppReferenceArray_1_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphNode>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073135, RefRangeEnd = 1073137, XrefRangeStart = 1073135, XrefRangeEnd = 1073135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Size(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Size_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1073152, RefRangeEnd = 1073155, XrefRangeStart = 1073137, XrefRangeEnd = 1073152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectAndClear(int index, List<GraphNode> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectAndClear_Private_Void_Int32_List_1_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073155, XrefRangeEnd = 1073159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MaxAllowedSize(int numNodes, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&numNodes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxAllowedSize_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073159, XrefRangeEnd = 1073166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rebalance(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rebalance_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073166, XrefRangeEnd = 1073174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureSize(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureSize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1073211, RefRangeEnd = 1073216, XrefRangeStart = 1073174, XrefRangeEnd = 1073211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Build(int index, List<GraphNode> nodes, int start, int end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Build_Private_Void_Int32_List_1_GraphNode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073235, RefRangeEnd = 1073237, XrefRangeStart = 1073216, XrefRangeEnd = 1073235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(GraphNode point, int index, int depth = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Private_Void_GraphNode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073237, XrefRangeEnd = 1073238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphNode GetNearest(Int3 point, NNConstraint constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&point);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearest_Public_GraphNode_Int3_NNConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1073241, RefRangeEnd = 1073245, XrefRangeStart = 1073238, XrefRangeEnd = 1073241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetNearestInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&index);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)best);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bestSqrDist);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestInternal_Private_Void_Int32_Int3_NNConstraint_byref_GraphNode_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		best = ((intPtr4 == (System.IntPtr)0) ? null : new GraphNode(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073245, XrefRangeEnd = 1073246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphNode GetNearestConnection(Int3 point, NNConstraint constraint, long maximumSqrConnectionLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&point);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maximumSqrConnectionLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestConnection_Public_GraphNode_Int3_NNConstraint_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1073250, RefRangeEnd = 1073254, XrefRangeStart = 1073246, XrefRangeEnd = 1073250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetNearestConnectionInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist, long distanceThresholdOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&index);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)best);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bestSqrDist);
		*(long**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &distanceThresholdOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestConnectionInternal_Private_Void_Int32_Int3_NNConstraint_byref_GraphNode_byref_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		best = ((intPtr4 == (System.IntPtr)0) ? null : new GraphNode(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073255, RefRangeEnd = 1073256, XrefRangeStart = 1073254, XrefRangeEnd = 1073255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInRange(Int3 point, long sqrRadius, List<GraphNode> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&point);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sqrRadius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInRange_Public_Void_Int3_Int64_List_1_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1073260, RefRangeEnd = 1073263, XrefRangeStart = 1073256, XrefRangeEnd = 1073260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInRangeInternal(int index, Int3 point, long sqrRadius, List<GraphNode> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&index);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sqrRadius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInRangeInternal_Private_Void_Int32_Int3_Int64_List_1_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PointKDTree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
