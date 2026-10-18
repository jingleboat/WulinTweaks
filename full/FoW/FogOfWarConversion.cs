using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace FoW;

public static class FogOfWarConversion : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToFogPlane_Public_Static_Vector2_Vector3_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToFogPlane3_Public_Static_Vector3_Vector3_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformFogPlaneForward_Public_Static_Vector2_Transform_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FogSizeToWorldSize_Public_Static_Vector2_Vector2_Vector2Int_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldSizeToFogSize_Public_Static_Vector2_Vector2_Vector2Int_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FogToWorld_Public_Static_Vector2_Vector2_Vector2_Vector2Int_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToFog_Public_Static_Vector2_Vector2_Vector2_Vector2Int_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToFog_Public_Static_Vector2_Vector3_FogOfWarPlane_Vector2_Vector2Int_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FogPlaneToWorld_Public_Static_Vector3_Vector3_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FogPlaneToWorld_Public_Static_Vector3_Single_Single_Single_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnapToNearestFogPixel_Public_Static_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnapWorldPositionToNearestFogPixel_Public_Static_Vector3_FogOfWarTeam_Vector2_0;

	static FogOfWarConversion()
	{
		Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarConversion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr);
		NativeMethodInfoPtr_WorldToFogPlane_Public_Static_Vector2_Vector3_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666902);
		NativeMethodInfoPtr_WorldToFogPlane3_Public_Static_Vector3_Vector3_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666903);
		NativeMethodInfoPtr_TransformFogPlaneForward_Public_Static_Vector2_Transform_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666904);
		NativeMethodInfoPtr_FogSizeToWorldSize_Public_Static_Vector2_Vector2_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666905);
		NativeMethodInfoPtr_WorldSizeToFogSize_Public_Static_Vector2_Vector2_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666906);
		NativeMethodInfoPtr_FogToWorld_Public_Static_Vector2_Vector2_Vector2_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666907);
		NativeMethodInfoPtr_WorldToFog_Public_Static_Vector2_Vector2_Vector2_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666908);
		NativeMethodInfoPtr_WorldToFog_Public_Static_Vector2_Vector3_FogOfWarPlane_Vector2_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666909);
		NativeMethodInfoPtr_FogPlaneToWorld_Public_Static_Vector3_Vector3_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666910);
		NativeMethodInfoPtr_FogPlaneToWorld_Public_Static_Vector3_Single_Single_Single_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666911);
		NativeMethodInfoPtr_SnapToNearestFogPixel_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666912);
		NativeMethodInfoPtr_SnapWorldPositionToNearestFogPixel_Public_Static_Vector3_FogOfWarTeam_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarConversion>.NativeClassPtr, 100666913);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 720787, RefRangeEnd = 720799, XrefRangeStart = 720780, XrefRangeEnd = 720787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 WorldToFogPlane(Vector3 position, FogOfWarPlane plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToFogPlane_Public_Static_Vector2_Vector3_FogOfWarPlane_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720806, RefRangeEnd = 720807, XrefRangeStart = 720799, XrefRangeEnd = 720806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 WorldToFogPlane3(Vector3 position, FogOfWarPlane plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToFogPlane3_Public_Static_Vector3_Vector3_FogOfWarPlane_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 720814, RefRangeEnd = 720819, XrefRangeStart = 720807, XrefRangeEnd = 720814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 TransformFogPlaneForward(Transform transform, FogOfWarPlane plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformFogPlaneForward_Public_Static_Vector2_Transform_FogOfWarPlane_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720820, RefRangeEnd = 720821, XrefRangeStart = 720819, XrefRangeEnd = 720820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 FogSizeToWorldSize(Vector2 fpos, Vector2Int resolution, float size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&fpos);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolution;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FogSizeToWorldSize_Public_Static_Vector2_Vector2_Vector2Int_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720821, XrefRangeEnd = 720822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 WorldSizeToFogSize(Vector2 wpos, Vector2Int resolution, float size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&wpos);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolution;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldSizeToFogSize_Public_Static_Vector2_Vector2_Vector2Int_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720822, XrefRangeEnd = 720823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 FogToWorld(Vector2 fpos, Vector2 offset, Vector2Int resolution, float size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fpos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(Vector2Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolution;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FogToWorld_Public_Static_Vector2_Vector2_Vector2_Vector2Int_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 720825, RefRangeEnd = 720836, XrefRangeStart = 720823, XrefRangeEnd = 720825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 WorldToFog(Vector2 wpos, Vector2 offset, Vector2Int resolution, float size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&wpos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(Vector2Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolution;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToFog_Public_Static_Vector2_Vector2_Vector2_Vector2Int_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720838, RefRangeEnd = 720839, XrefRangeStart = 720836, XrefRangeEnd = 720838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 WorldToFog(Vector3 wpos, FogOfWarPlane plane, Vector2 offset, Vector2Int resolution, float size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&wpos);
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(Vector2Int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolution;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToFog_Public_Static_Vector2_Vector3_FogOfWarPlane_Vector2_Vector2Int_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720849, RefRangeEnd = 720850, XrefRangeStart = 720839, XrefRangeEnd = 720849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 FogPlaneToWorld(Vector3 fpos, FogOfWarPlane plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&fpos);
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FogPlaneToWorld_Public_Static_Vector3_Vector3_FogOfWarPlane_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720860, RefRangeEnd = 720861, XrefRangeStart = 720850, XrefRangeEnd = 720860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 FogPlaneToWorld(float x, float y, float z, FogOfWarPlane plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FogPlaneToWorld_Public_Static_Vector3_Single_Single_Single_FogOfWarPlane_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 720863, RefRangeEnd = 720865, XrefRangeStart = 720861, XrefRangeEnd = 720863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 SnapToNearestFogPixel(Vector2 fogpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fogpos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnapToNearestFogPixel_Public_Static_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720869, RefRangeEnd = 720870, XrefRangeStart = 720865, XrefRangeEnd = 720869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 SnapWorldPositionToNearestFogPixel(FogOfWarTeam fow, Vector2 worldpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldpos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnapWorldPositionToNearestFogPixel_Public_Static_Vector3_FogOfWarTeam_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public FogOfWarConversion(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
