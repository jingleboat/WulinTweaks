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

public static class KongfuAreaDataExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaByDir_Public_Static_List_1_Vector3Int_KongfuAreaData_TileDirection_TileDirection_byref_List_1_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreEffectPos_Public_Static_Vector3Int_KongfuAreaData_TileDirection_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChargeLength_Public_Static_Int32_KongfuAreaData_0;

	static KongfuAreaDataExt()
	{
		Il2CppClassPointerStore<KongfuAreaDataExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "KongfuAreaDataExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KongfuAreaDataExt>.NativeClassPtr);
		NativeMethodInfoPtr_GetAreaByDir_Public_Static_List_1_Vector3Int_KongfuAreaData_TileDirection_TileDirection_byref_List_1_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KongfuAreaDataExt>.NativeClassPtr, 100671586);
		NativeMethodInfoPtr_GetPreEffectPos_Public_Static_Vector3Int_KongfuAreaData_TileDirection_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KongfuAreaDataExt>.NativeClassPtr, 100671587);
		NativeMethodInfoPtr_GetChargeLength_Public_Static_Int32_KongfuAreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KongfuAreaDataExt>.NativeClassPtr, 100671588);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 785576, RefRangeEnd = 785579, XrefRangeStart = 785545, XrefRangeEnd = 785576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3Int> GetAreaByDir(this KongfuAreaData self, TileDirection fromDirction, TileDirection toDirection, ref List<float> delays, bool calculateDelay = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(TileDirection**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromDirction;
		*(TileDirection**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toDirection;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)delays);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &calculateDelay;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaByDir_Public_Static_List_1_Vector3Int_KongfuAreaData_TileDirection_TileDirection_byref_List_1_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		delays = ((intPtr4 == (System.IntPtr)0) ? null : new List<float>(intPtr4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 785584, RefRangeEnd = 785585, XrefRangeStart = 785579, XrefRangeEnd = 785584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int GetPreEffectPos(this KongfuAreaData self, TileDirection fromDirction, TileDirection toDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(TileDirection**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromDirction;
		*(TileDirection**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreEffectPos_Public_Static_Vector3Int_KongfuAreaData_TileDirection_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int GetChargeLength(this KongfuAreaData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChargeLength_Public_Static_Int32_KongfuAreaData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public KongfuAreaDataExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
