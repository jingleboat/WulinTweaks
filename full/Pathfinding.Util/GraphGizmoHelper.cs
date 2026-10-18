using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding.Util;

public class GraphGizmoHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__hasher_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmos;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugData;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugPathID;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_showSearchTree;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugRoof;

	private static readonly System.IntPtr NativeFieldInfoPtr__builder_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawConnectionStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawConnectionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawConnection;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasher_Public_get_Hasher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasher_Private_set_Void_Hasher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_builder_Public_get_Builder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_builder_Private_set_Void_Builder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_AstarPath_Hasher_RetainedGizmos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnterPool_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawConnections_Public_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawConnection_Private_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NodeColor_Public_Color_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InSearchTree_Public_Static_Boolean_GraphNode_PathHandler_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireTriangle_Public_Void_Vector3_Vector3_Vector3_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTriangles_Public_Void_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireTriangles_Public_Void_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

	public unsafe RetainedGizmos.Hasher _hasher_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasher_k__BackingField);
			return new RetainedGizmos.Hasher(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RetainedGizmos.Hasher>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasher_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hasher)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RetainedGizmos.Hasher>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe RetainedGizmos gizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RetainedGizmos>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)retainedGizmos));
		}
	}

	public unsafe PathHandler debugData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathHandler));
		}
	}

	public unsafe ushort debugPathID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPathID);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPathID)) = num;
		}
	}

	public unsafe GraphDebugMode debugMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMode);
			return *(GraphDebugMode*)num;
		}
		set
		{
			*(GraphDebugMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMode)) = graphDebugMode;
		}
	}

	public unsafe bool showSearchTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSearchTree);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSearchTree)) = flag;
		}
	}

	public unsafe float debugFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFloor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFloor)) = num;
		}
	}

	public unsafe float debugRoof
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRoof);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRoof)) = num;
		}
	}

	public unsafe RetainedGizmos.Builder _builder_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__builder_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RetainedGizmos.Builder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__builder_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder));
		}
	}

	public unsafe Vector3 drawConnectionStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawConnectionStart);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawConnectionStart)) = vector;
		}
	}

	public unsafe Color drawConnectionColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawConnectionColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawConnectionColor)) = color;
		}
	}

	public unsafe Il2CppSystem.Action<GraphNode> drawConnection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawConnection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<GraphNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawConnection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe RetainedGizmos.Hasher hasher
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasher_Public_get_Hasher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RetainedGizmos.Hasher(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasher_Private_set_Void_Hasher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RetainedGizmos.Builder builder
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18905, RefRangeEnd = 18906, XrefRangeStart = 18905, XrefRangeEnd = 18906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_builder_Public_get_Builder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RetainedGizmos.Builder>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_builder_Private_set_Void_Builder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GraphGizmoHelper()
	{
		Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "GraphGizmoHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr);
		NativeFieldInfoPtr__hasher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "<hasher>k__BackingField");
		NativeFieldInfoPtr_gizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "gizmos");
		NativeFieldInfoPtr_debugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "debugData");
		NativeFieldInfoPtr_debugPathID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "debugPathID");
		NativeFieldInfoPtr_debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "debugMode");
		NativeFieldInfoPtr_showSearchTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "showSearchTree");
		NativeFieldInfoPtr_debugFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "debugFloor");
		NativeFieldInfoPtr_debugRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "debugRoof");
		NativeFieldInfoPtr__builder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "<builder>k__BackingField");
		NativeFieldInfoPtr_drawConnectionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "drawConnectionStart");
		NativeFieldInfoPtr_drawConnectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "drawConnectionColor");
		NativeFieldInfoPtr_drawConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, "drawConnection");
		NativeMethodInfoPtr_get_hasher_Public_get_Hasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684402);
		NativeMethodInfoPtr_set_hasher_Private_set_Void_Hasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684403);
		NativeMethodInfoPtr_get_builder_Public_get_Builder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684404);
		NativeMethodInfoPtr_set_builder_Private_set_Void_Builder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684405);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684406);
		NativeMethodInfoPtr_Init_Public_Void_AstarPath_Hasher_RetainedGizmos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684407);
		NativeMethodInfoPtr_OnEnterPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684408);
		NativeMethodInfoPtr_DrawConnections_Public_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684409);
		NativeMethodInfoPtr_DrawConnection_Private_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684410);
		NativeMethodInfoPtr_NodeColor_Public_Color_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684411);
		NativeMethodInfoPtr_InSearchTree_Public_Static_Boolean_GraphNode_PathHandler_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684412);
		NativeMethodInfoPtr_DrawWireTriangle_Public_Void_Vector3_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684413);
		NativeMethodInfoPtr_DrawTriangles_Public_Void_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684414);
		NativeMethodInfoPtr_DrawWireTriangles_Public_Void_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684415);
		NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684416);
		NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr, 100684417);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085407, XrefRangeEnd = 1085416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphGizmoHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphGizmoHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085424, RefRangeEnd = 1085426, XrefRangeStart = 1085416, XrefRangeEnd = 1085424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(AstarPath active, RetainedGizmos.Hasher hasher, RetainedGizmos gizmos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)active);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hasher));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gizmos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_AstarPath_Hasher_RetainedGizmos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085426, XrefRangeEnd = 1085429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEnterPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnterPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085431, RefRangeEnd = 1085433, XrefRangeStart = 1085429, XrefRangeEnd = 1085431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawConnections(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawConnections_Public_Void_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085433, XrefRangeEnd = 1085436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawConnection(GraphNode other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawConnection_Private_Void_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1085439, RefRangeEnd = 1085443, XrefRangeStart = 1085436, XrefRangeEnd = 1085439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color NodeColor(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NodeColor_Public_Color_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085444, RefRangeEnd = 1085445, XrefRangeStart = 1085443, XrefRangeEnd = 1085444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InSearchTree(GraphNode node, PathHandler handler, ushort pathID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pathID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InSearchTree_Public_Static_Boolean_GraphNode_PathHandler_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085445, XrefRangeEnd = 1085448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWireTriangle(Vector3 a, Vector3 b, Vector3 c, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireTriangle_Public_Void_Vector3_Vector3_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085463, RefRangeEnd = 1085464, XrefRangeStart = 1085448, XrefRangeEnd = 1085463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawTriangles(Il2CppStructArray<Vector3> vertices, Il2CppStructArray<Color> colors, int numTriangles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numTriangles;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTriangles_Public_Void_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085467, RefRangeEnd = 1085468, XrefRangeStart = 1085464, XrefRangeEnd = 1085467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWireTriangles(Il2CppStructArray<Vector3> vertices, Il2CppStructArray<Color> colors, int numTriangles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numTriangles;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireTriangles_Public_Void_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085468, XrefRangeEnd = 1085469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Submit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085469, XrefRangeEnd = 1085473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_IDisposable_Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GraphGizmoHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
