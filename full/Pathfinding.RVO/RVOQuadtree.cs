using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Pathfinding.RVO.Sampled;
using UnityEngine;

namespace Pathfinding.RVO;

public class RVOQuadtree : Il2CppSystem.Object
{
	public sealed class Node : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_child00;

		private static readonly System.IntPtr NativeFieldInfoPtr_linkedList;

		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Agent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Distribute_Public_Void_Il2CppReferenceArray_1_Node_Rect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateMaxSpeed_Public_Single_Il2CppReferenceArray_1_Node_Int32_0;

		public unsafe int child00
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_child00);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_child00)) = num;
			}
		}

		public unsafe Agent linkedList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkedList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Agent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkedList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent));
			}
		}

		public unsafe byte count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = b;
			}
		}

		public unsafe float maxSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
			}
		}

		static Node()
		{
			Il2CppClassPointerStore<Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "Node");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node>.NativeClassPtr);
			NativeFieldInfoPtr_child00 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "child00");
			NativeFieldInfoPtr_linkedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "linkedList");
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "count");
			NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "maxSpeed");
			NativeMethodInfoPtr_Add_Public_Void_Agent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node>.NativeClassPtr, 100689586);
			NativeMethodInfoPtr_Distribute_Public_Void_Il2CppReferenceArray_1_Node_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node>.NativeClassPtr, 100689587);
			NativeMethodInfoPtr_CalculateMaxSpeed_Public_Single_Il2CppReferenceArray_1_Node_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node>.NativeClassPtr, 100689588);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081749, RefRangeEnd = 1081750, XrefRangeStart = 1081749, XrefRangeEnd = 1081749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Agent agent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Agent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081751, RefRangeEnd = 1081752, XrefRangeStart = 1081750, XrefRangeEnd = 1081751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Distribute(Il2CppReferenceArray<Node> nodes, Rect r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
			*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distribute_Public_Void_Il2CppReferenceArray_1_Node_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1081766, RefRangeEnd = 1081771, XrefRangeStart = 1081752, XrefRangeEnd = 1081766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateMaxSpeed(Il2CppReferenceArray<Node> nodes, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateMaxSpeed_Public_Single_Il2CppReferenceArray_1_Node_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
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

	public sealed class QuadtreeQuery : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_p;

		private static readonly System.IntPtr NativeFieldInfoPtr_speed;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeHorizon;

		private static readonly System.IntPtr NativeFieldInfoPtr_agentRadius;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxRadius;

		private static readonly System.IntPtr NativeFieldInfoPtr_agent;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

		private static readonly System.IntPtr NativeMethodInfoPtr_QueryRec_Public_Void_Int32_Rect_0;

		public unsafe Vector2 p
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p)) = vector;
			}
		}

		public unsafe float speed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
			}
		}

		public unsafe float timeHorizon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeHorizon);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeHorizon)) = num;
			}
		}

		public unsafe float agentRadius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agentRadius);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agentRadius)) = num;
			}
		}

		public unsafe float maxRadius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRadius);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRadius)) = num;
			}
		}

		public unsafe Agent agent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Agent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent));
			}
		}

		public unsafe Il2CppReferenceArray<Node> nodes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Node>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static QuadtreeQuery()
		{
			Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "QuadtreeQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr);
			NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "p");
			NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "speed");
			NativeFieldInfoPtr_timeHorizon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "timeHorizon");
			NativeFieldInfoPtr_agentRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "agentRadius");
			NativeFieldInfoPtr_maxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "maxRadius");
			NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "agent");
			NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, "nodes");
			NativeMethodInfoPtr_QueryRec_Public_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr, 100689589);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1081802, RefRangeEnd = 1081807, XrefRangeStart = 1081771, XrefRangeEnd = 1081802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueryRec(int i, Rect r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryRec_Public_Void_Int32_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public QuadtreeQuery(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public QuadtreeQuery()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadtreeQuery>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_LeafSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_filledNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_bounds;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBounds_Public_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeIndex_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_Void_Agent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSpeeds_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Query_Public_Void_Vector2_Single_Single_Single_Agent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugDraw_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugDrawRec_Private_Void_Int32_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe float maxRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRadius)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<Node> nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Node>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int filledNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filledNodes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filledNodes)) = num;
		}
	}

	public unsafe Rect bounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds)) = rect;
		}
	}

	static RVOQuadtree()
	{
		Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.RVO", "RVOQuadtree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr);
		NativeFieldInfoPtr_LeafSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "LeafSize");
		NativeFieldInfoPtr_maxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "maxRadius");
		NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "nodes");
		NativeFieldInfoPtr_filledNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "filledNodes");
		NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, "bounds");
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684115);
		NativeMethodInfoPtr_SetBounds_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684116);
		NativeMethodInfoPtr_GetNodeIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684117);
		NativeMethodInfoPtr_Insert_Public_Void_Agent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684118);
		NativeMethodInfoPtr_CalculateSpeeds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684119);
		NativeMethodInfoPtr_Query_Public_Void_Vector2_Single_Single_Single_Agent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684120);
		NativeMethodInfoPtr_DebugDraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684121);
		NativeMethodInfoPtr_DebugDrawRec_Private_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684122);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr, 100684123);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081807, RefRangeEnd = 1081808, XrefRangeStart = 1081807, XrefRangeEnd = 1081807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetBounds(Rect r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBounds_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081812, RefRangeEnd = 1081813, XrefRangeStart = 1081808, XrefRangeEnd = 1081812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNodeIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081835, RefRangeEnd = 1081836, XrefRangeStart = 1081813, XrefRangeEnd = 1081835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Insert(Agent agent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Insert_Public_Void_Agent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081840, RefRangeEnd = 1081841, XrefRangeStart = 1081836, XrefRangeEnd = 1081840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSpeeds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSpeeds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081842, RefRangeEnd = 1081843, XrefRangeStart = 1081841, XrefRangeEnd = 1081842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, Agent agent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&p);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeHorizon;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &agentRadius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Query_Public_Void_Vector2_Single_Single_Single_Agent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081843, XrefRangeEnd = 1081844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugDraw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugDraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1081894, RefRangeEnd = 1081899, XrefRangeStart = 1081844, XrefRangeEnd = 1081894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugDrawRec(int i, Rect r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugDrawRec_Private_Void_Int32_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081903, RefRangeEnd = 1081904, XrefRangeStart = 1081899, XrefRangeEnd = 1081903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RVOQuadtree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RVOQuadtree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RVOQuadtree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
