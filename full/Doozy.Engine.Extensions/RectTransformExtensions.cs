using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Extensions;

public static class RectTransformExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_RectTransform_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FullScreen_Public_Static_Void_RectTransform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Center_Public_Static_Void_RectTransform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnchoredPosition3D_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetLocalPosition_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetLocalScaleToOne_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnchorMinToZero_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnchorMinToCenter_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnchorMaxToOne_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnchorMaxToCenter_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CenterPivot_Public_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SizeDeltaToZero_Public_Static_Void_RectTransform_0;

	static RectTransformExtensions()
	{
		Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Extensions", "RectTransformExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Copy_Public_Static_Void_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669313);
		NativeMethodInfoPtr_FullScreen_Public_Static_Void_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669314);
		NativeMethodInfoPtr_Center_Public_Static_Void_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669315);
		NativeMethodInfoPtr_ResetAnchoredPosition3D_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669316);
		NativeMethodInfoPtr_ResetLocalPosition_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669317);
		NativeMethodInfoPtr_ResetLocalScaleToOne_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669318);
		NativeMethodInfoPtr_AnchorMinToZero_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669319);
		NativeMethodInfoPtr_AnchorMinToCenter_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669320);
		NativeMethodInfoPtr_AnchorMaxToOne_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669321);
		NativeMethodInfoPtr_AnchorMaxToCenter_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669322);
		NativeMethodInfoPtr_CenterPivot_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669323);
		NativeMethodInfoPtr_SizeDeltaToZero_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100669324);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 750102, RefRangeEnd = 750107, XrefRangeStart = 750090, XrefRangeEnd = 750102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(this RectTransform target, RectTransform from)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_RectTransform_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 750122, RefRangeEnd = 750129, XrefRangeStart = 750107, XrefRangeEnd = 750122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FullScreen(this RectTransform target, bool resetScaleToOne)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resetScaleToOne;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullScreen_Public_Static_Void_RectTransform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 750138, RefRangeEnd = 750140, XrefRangeStart = 750129, XrefRangeEnd = 750138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Center(this RectTransform target, bool resetScaleToOne)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resetScaleToOne;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Center_Public_Static_Void_RectTransform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750140, XrefRangeEnd = 750142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAnchoredPosition3D(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAnchoredPosition3D_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750142, XrefRangeEnd = 750144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetLocalPosition(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetLocalPosition_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750144, XrefRangeEnd = 750146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetLocalScaleToOne(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetLocalScaleToOne_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750146, XrefRangeEnd = 750149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AnchorMinToZero(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnchorMinToZero_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750149, XrefRangeEnd = 750151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AnchorMinToCenter(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnchorMinToCenter_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750151, XrefRangeEnd = 750154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AnchorMaxToOne(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnchorMaxToOne_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750154, XrefRangeEnd = 750156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AnchorMaxToCenter(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnchorMaxToCenter_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750156, XrefRangeEnd = 750158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CenterPivot(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CenterPivot_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750158, XrefRangeEnd = 750161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SizeDeltaToZero(this RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SizeDeltaToZero_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RectTransformExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
