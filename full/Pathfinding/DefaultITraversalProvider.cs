using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Pathfinding;

public static class DefaultITraversalProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CanTraverse_Public_Static_Boolean_Path_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTraversalCost_Public_Static_UInt32_Path_GraphNode_0;

	static DefaultITraversalProvider()
	{
		Il2CppClassPointerStore<DefaultITraversalProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "DefaultITraversalProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultITraversalProvider>.NativeClassPtr);
		NativeMethodInfoPtr_CanTraverse_Public_Static_Boolean_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultITraversalProvider>.NativeClassPtr, 100682813);
		NativeMethodInfoPtr_GetTraversalCost_Public_Static_UInt32_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultITraversalProvider>.NativeClassPtr, 100682814);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066455, XrefRangeEnd = 1066456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanTraverse(Path path, GraphNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanTraverse_Public_Static_Boolean_Path_GraphNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066456, XrefRangeEnd = 1066458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetTraversalCost(Path path, GraphNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraversalCost_Public_Static_UInt32_Path_GraphNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public DefaultITraversalProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
