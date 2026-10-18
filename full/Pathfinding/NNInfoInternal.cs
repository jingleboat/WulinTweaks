using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding;

public sealed class NNInfoInternal : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_node;

	private static readonly System.IntPtr NativeFieldInfoPtr_constrainedNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_clampedPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_constClampedPosition;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInfo_Public_Void_0;

	public unsafe GraphNode node
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphNode));
		}
	}

	public unsafe GraphNode constrainedNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainedNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainedNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphNode));
		}
	}

	public unsafe Vector3 clampedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedPosition)) = vector;
		}
	}

	public unsafe Vector3 constClampedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constClampedPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constClampedPosition)) = vector;
		}
	}

	static NNInfoInternal()
	{
		Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "NNInfoInternal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr);
		NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr, "node");
		NativeFieldInfoPtr_constrainedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr, "constrainedNode");
		NativeFieldInfoPtr_clampedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr, "clampedPosition");
		NativeFieldInfoPtr_constClampedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr, "constClampedPosition");
		NativeMethodInfoPtr__ctor_Public_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr, 100682926);
		NativeMethodInfoPtr_UpdateInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr, 100682927);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1067160, RefRangeEnd = 1067166, XrefRangeStart = 1067157, XrefRangeEnd = 1067160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NNInfoInternal(GraphNode node)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GraphNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1067172, RefRangeEnd = 1067175, XrefRangeStart = 1067166, XrefRangeEnd = 1067172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInfo_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NNInfoInternal(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NNInfoInternal()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NNInfoInternal>.NativeClassPtr))
	{
	}
}
