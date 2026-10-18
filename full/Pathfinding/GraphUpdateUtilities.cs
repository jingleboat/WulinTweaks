using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Pathfinding;

public static class GraphUpdateUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGraphsNoBlock_Public_Static_Boolean_GraphUpdateObject_GraphNode_GraphNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGraphsNoBlock_Public_Static_Boolean_GraphUpdateObject_List_1_GraphNode_Boolean_0;

	static GraphUpdateUtilities()
	{
		Il2CppClassPointerStore<GraphUpdateUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "GraphUpdateUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphUpdateUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_UpdateGraphsNoBlock_Public_Static_Boolean_GraphUpdateObject_GraphNode_GraphNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateUtilities>.NativeClassPtr, 100683826);
		NativeMethodInfoPtr_UpdateGraphsNoBlock_Public_Static_Boolean_GraphUpdateObject_List_1_GraphNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUpdateUtilities>.NativeClassPtr, 100683827);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077289, XrefRangeEnd = 1077304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UpdateGraphsNoBlock(GraphUpdateObject guo, GraphNode node1, GraphNode node2, bool alwaysRevert = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node2);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &alwaysRevert;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGraphsNoBlock_Public_Static_Boolean_GraphUpdateObject_GraphNode_GraphNode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077333, RefRangeEnd = 1077334, XrefRangeStart = 1077304, XrefRangeEnd = 1077333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UpdateGraphsNoBlock(GraphUpdateObject guo, List<GraphNode> nodes, bool alwaysRevert = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alwaysRevert;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGraphsNoBlock_Public_Static_Boolean_GraphUpdateObject_List_1_GraphNode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GraphUpdateUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
