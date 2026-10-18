using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public static class RedDotHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveChildren_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildren_Public_Static_HashSet_1_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetRedDotsTree_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetView_Public_Static_RedDotMonoView_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasTarget_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRedDotNode_Public_Static_Void_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRedDotNode_Public_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRedDotNodeView_Public_Static_Void_String_GameObject_Vector3_Vector2_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRedDotNodeView_Public_Static_Void_String_RedDotMonoView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRedDotView_Public_Static_Void_String_byref_RedDotMonoView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideRedDotNode_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowRedDotNode_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLogicAlreadyShow_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshRedDotViewCount_Public_Static_Void_String_Int32_0;

	static RedDotHelper()
	{
		Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "RedDotHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr);
		NativeMethodInfoPtr_RemoveChildren_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675960);
		NativeMethodInfoPtr_GetChildren_Public_Static_HashSet_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675961);
		NativeMethodInfoPtr_ResetRedDotsTree_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675962);
		NativeMethodInfoPtr_GetView_Public_Static_RedDotMonoView_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675963);
		NativeMethodInfoPtr_HasTarget_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675964);
		NativeMethodInfoPtr_AddRedDotNode_Public_Static_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675965);
		NativeMethodInfoPtr_RemoveRedDotNode_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675966);
		NativeMethodInfoPtr_AddRedDotNodeView_Public_Static_Void_String_GameObject_Vector3_Vector2_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675967);
		NativeMethodInfoPtr_AddRedDotNodeView_Public_Static_Void_String_RedDotMonoView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675968);
		NativeMethodInfoPtr_RemoveRedDotView_Public_Static_Void_String_byref_RedDotMonoView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675969);
		NativeMethodInfoPtr_HideRedDotNode_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675970);
		NativeMethodInfoPtr_ShowRedDotNode_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675971);
		NativeMethodInfoPtr_IsLogicAlreadyShow_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675972);
		NativeMethodInfoPtr_RefreshRedDotViewCount_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedDotHelper>.NativeClassPtr, 100675973);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 910773, RefRangeEnd = 910774, XrefRangeStart = 910765, XrefRangeEnd = 910773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveChildren(string root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(root);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveChildren_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910774, XrefRangeEnd = 910790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<string> GetChildren(string parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildren_Public_Static_HashSet_1_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 910807, RefRangeEnd = 910808, XrefRangeStart = 910790, XrefRangeEnd = 910807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetRedDotsTree()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetRedDotsTree_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 910817, RefRangeEnd = 910819, XrefRangeStart = 910808, XrefRangeEnd = 910817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RedDotMonoView GetView(string target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetView_Public_Static_RedDotMonoView_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RedDotMonoView>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910819, XrefRangeEnd = 910829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasTarget(string target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasTarget_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 910840, RefRangeEnd = 910855, XrefRangeStart = 910829, XrefRangeEnd = 910840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRedDotNode(string parent, string target, bool isNeedShowNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isNeedShowNum;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRedDotNode_Public_Static_Void_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 910874, RefRangeEnd = 910876, XrefRangeStart = 910855, XrefRangeEnd = 910874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveRedDotNode(string target, bool isRemoveView = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isRemoveView;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRedDotNode_Public_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 910889, RefRangeEnd = 910897, XrefRangeStart = 910876, XrefRangeEnd = 910889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRedDotNodeView(string target, GameObject gameObject, Vector3 RedDotScale, Vector2 PositionOffset, Il2CppSystem.Action<bool> onStateChanged = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &RedDotScale;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &PositionOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onStateChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRedDotNodeView_Public_Static_Void_String_GameObject_Vector3_Vector2_Action_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910897, XrefRangeEnd = 910904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRedDotNodeView(string target, RedDotMonoView monoView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monoView);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRedDotNodeView_Public_Static_Void_String_RedDotMonoView_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 910911, RefRangeEnd = 910915, XrefRangeStart = 910904, XrefRangeEnd = 910911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveRedDotView(string target, out RedDotMonoView monoView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRedDotView_Public_Static_Void_String_byref_RedDotMonoView_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		monoView = ((num3 == 0) ? null : new RedDotMonoView(num3));
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 910927, RefRangeEnd = 910936, XrefRangeStart = 910915, XrefRangeEnd = 910927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HideRedDotNode(string target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideRedDotNode_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 910949, RefRangeEnd = 910953, XrefRangeStart = 910936, XrefRangeEnd = 910949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShowRedDotNode(string target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowRedDotNode_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 910967, RefRangeEnd = 910976, XrefRangeStart = 910953, XrefRangeEnd = 910967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLogicAlreadyShow(string target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLogicAlreadyShow_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910976, XrefRangeEnd = 910983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshRedDotViewCount(string target, int Count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &Count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshRedDotViewCount_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RedDotHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
