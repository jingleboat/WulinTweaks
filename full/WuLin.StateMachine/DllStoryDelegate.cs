using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using XNode;

namespace WuLin.StateMachine;

public static class DllStoryDelegate : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryDefaultNodeHasLocString_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryDefaultNodeGetString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryStartPlayNodeClearHunter_Public_Static_Void_StoryStartPlayNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryStartPlayNodeOnActive_Public_Static_Void_StoryStartPlayNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueNodeContinue_Public_Static_Void_ContinueNode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSaveID_Public_Static_Boolean_ContinueNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HappenBaseNodeOnActive_Public_Static_Node_HappenBaseNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HappenBaseNodeOnItemIDChangedAction_Public_Static_Void_Int32_byref_String_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HappenBaseNodeGetStringAction_Public_Static_String_HappenBaseNode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResultBaseNodeRecordPrize_Public_Static_Void_ResultBaseNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResultBaseNodeOnFactionIDChangedAction_Public_Static_Void_Int32_byref_String_0;

	static DllStoryDelegate()
	{
		Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "DllStoryDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681104);
		NativeMethodInfoPtr_StoryDefaultNodeHasLocString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681105);
		NativeMethodInfoPtr_StoryDefaultNodeGetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681106);
		NativeMethodInfoPtr_StoryStartPlayNodeClearHunter_Public_Static_Void_StoryStartPlayNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681107);
		NativeMethodInfoPtr_StoryStartPlayNodeOnActive_Public_Static_Void_StoryStartPlayNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681108);
		NativeMethodInfoPtr_ContinueNodeContinue_Public_Static_Void_ContinueNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681109);
		NativeMethodInfoPtr_CheckSaveID_Public_Static_Boolean_ContinueNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681110);
		NativeMethodInfoPtr_HappenBaseNodeOnActive_Public_Static_Node_HappenBaseNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681111);
		NativeMethodInfoPtr_HappenBaseNodeOnItemIDChangedAction_Public_Static_Void_Int32_byref_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681112);
		NativeMethodInfoPtr_HappenBaseNodeGetStringAction_Public_Static_String_HappenBaseNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681113);
		NativeMethodInfoPtr_ResultBaseNodeRecordPrize_Public_Static_Void_ResultBaseNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681114);
		NativeMethodInfoPtr_ResultBaseNodeOnFactionIDChangedAction_Public_Static_Void_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryDelegate>.NativeClassPtr, 100681115);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038956, RefRangeEnd = 1038957, XrefRangeStart = 1038870, XrefRangeEnd = 1038956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038957, XrefRangeEnd = 1038965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StoryDefaultNodeHasLocString(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryDefaultNodeHasLocString_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038965, XrefRangeEnd = 1038982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StoryDefaultNodeGetString(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryDefaultNodeGetString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038982, XrefRangeEnd = 1038992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoryStartPlayNodeClearHunter(StoryStartPlayNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryStartPlayNodeClearHunter_Public_Static_Void_StoryStartPlayNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038992, XrefRangeEnd = 1039002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoryStartPlayNodeOnActive(StoryStartPlayNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryStartPlayNodeOnActive_Public_Static_Void_StoryStartPlayNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039002, XrefRangeEnd = 1039010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ContinueNodeContinue(ContinueNode self, string continuePort)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(continuePort);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueNodeContinue_Public_Static_Void_ContinueNode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039010, XrefRangeEnd = 1039014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckSaveID(ContinueNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSaveID_Public_Static_Boolean_ContinueNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039014, XrefRangeEnd = 1039022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Node HappenBaseNodeOnActive(HappenBaseNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HappenBaseNodeOnActive_Public_Static_Node_HappenBaseNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Node>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039022, XrefRangeEnd = 1039039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HappenBaseNodeOnItemIDChangedAction(int ItemID, out string ItemName, out Color ItemColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ItemID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ItemColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HappenBaseNodeOnItemIDChangedAction_Public_Static_Void_Int32_byref_String_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		ItemName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039039, XrefRangeEnd = 1039056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string HappenBaseNodeGetStringAction(HappenBaseNode self, string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HappenBaseNodeGetStringAction_Public_Static_String_HappenBaseNode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039056, XrefRangeEnd = 1039064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResultBaseNodeRecordPrize(ResultBaseNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResultBaseNodeRecordPrize_Public_Static_Void_ResultBaseNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039064, XrefRangeEnd = 1039079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResultBaseNodeOnFactionIDChangedAction(int FactionID, out string ItemName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&FactionID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResultBaseNodeOnFactionIDChangedAction_Public_Static_Void_Int32_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		ItemName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
	}

	public DllStoryDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
