using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public class RecastBBTree : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_root;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryInBounds_Public_Void_Rect_List_1_RecastMeshObj_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryBoxInBounds_Private_Void_RecastBBTreeBox_Rect_List_1_RecastMeshObj_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_RecastMeshObj_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBox_Private_RecastBBTreeBox_RecastBBTreeBox_RecastMeshObj_Rect_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_Void_RecastMeshObj_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectIntersectsRect_Private_Static_Boolean_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpansionRequired_Private_Static_Single_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandToContain_Private_Static_Rect_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectArea_Private_Static_Single_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RecastBBTreeBox root
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_root);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RecastBBTreeBox>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_root)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recastBBTreeBox));
		}
	}

	static RecastBBTree()
	{
		Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "RecastBBTree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr);
		NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, "root");
		NativeMethodInfoPtr_QueryInBounds_Public_Void_Rect_List_1_RecastMeshObj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683536);
		NativeMethodInfoPtr_QueryBoxInBounds_Private_Void_RecastBBTreeBox_Rect_List_1_RecastMeshObj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683537);
		NativeMethodInfoPtr_Remove_Public_Boolean_RecastMeshObj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683538);
		NativeMethodInfoPtr_RemoveBox_Private_RecastBBTreeBox_RecastBBTreeBox_RecastMeshObj_Rect_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683539);
		NativeMethodInfoPtr_Insert_Public_Void_RecastMeshObj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683540);
		NativeMethodInfoPtr_RectIntersectsRect_Private_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683541);
		NativeMethodInfoPtr_ExpansionRequired_Private_Static_Single_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683542);
		NativeMethodInfoPtr_ExpandToContain_Private_Static_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683543);
		NativeMethodInfoPtr_RectArea_Private_Static_Single_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683544);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr, 100683545);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073263, XrefRangeEnd = 1073264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueryInBounds(Rect bounds, List<RecastMeshObj> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bounds);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryInBounds_Public_Void_Rect_List_1_RecastMeshObj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1073287, RefRangeEnd = 1073291, XrefRangeStart = 1073264, XrefRangeEnd = 1073287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueryBoxInBounds(RecastBBTreeBox box, Rect bounds, List<RecastMeshObj> boxes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bounds;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boxes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryBoxInBounds_Private_Void_RecastBBTreeBox_Rect_List_1_RecastMeshObj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073291, XrefRangeEnd = 1073302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Remove(RecastMeshObj mesh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Boolean_RecastMeshObj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1073320, RefRangeEnd = 1073324, XrefRangeStart = 1073302, XrefRangeEnd = 1073320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RecastBBTreeBox RemoveBox(RecastBBTreeBox c, RecastMeshObj mesh, Rect bounds, ref bool found)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bounds;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref found);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBox_Private_RecastBBTreeBox_RecastBBTreeBox_RecastMeshObj_Rect_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RecastBBTreeBox>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073362, RefRangeEnd = 1073363, XrefRangeStart = 1073324, XrefRangeEnd = 1073362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Insert(RecastMeshObj mesh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Insert_Public_Void_RecastMeshObj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073363, XrefRangeEnd = 1073371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RectIntersectsRect(Rect r, Rect r2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&r);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectIntersectsRect_Private_Static_Boolean_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073385, RefRangeEnd = 1073387, XrefRangeStart = 1073371, XrefRangeEnd = 1073385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ExpansionRequired(Rect r, Rect r2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&r);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpansionRequired_Private_Static_Single_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073400, RefRangeEnd = 1073401, XrefRangeStart = 1073387, XrefRangeEnd = 1073400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect ExpandToContain(Rect r, Rect r2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&r);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandToContain_Private_Static_Rect_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073401, XrefRangeEnd = 1073403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RectArea(Rect r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectArea_Private_Static_Single_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RecastBBTree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecastBBTree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RecastBBTree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
