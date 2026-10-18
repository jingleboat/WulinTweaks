using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Pathfinding;
using UnityEngine;

namespace WuLin;

public class PlayerInteractiveTraversalProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_blocksHash;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0;

	public unsafe List<int> blocksHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocksHash);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocksHash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static PlayerInteractiveTraversalProvider()
	{
		Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "PlayerInteractiveTraversalProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr);
		NativeFieldInfoPtr_blocksHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr, "blocksHash");
		NativeMethodInfoPtr__ctor_Public_Void_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr, 100673524);
		NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr, 100673525);
		NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr, 100673526);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 845693, RefRangeEnd = 845695, XrefRangeStart = 845659, XrefRangeEnd = 845693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInteractiveTraversalProvider(List<Vector3Int> poses = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInteractiveTraversalProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poses);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845695, XrefRangeEnd = 845705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool CanTraverse(Path path, GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual uint GetTraversalCost(Path path, GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public PlayerInteractiveTraversalProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
