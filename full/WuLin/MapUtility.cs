using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class MapUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_AreaString2TilePos_Public_Static_Void_String_byref_Int32_byref_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static MapUtility()
	{
		Il2CppClassPointerStore<MapUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MapUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapUtility>.NativeClassPtr);
		NativeMethodInfoPtr_AreaString2TilePos_Public_Static_Void_String_byref_Int32_byref_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtility>.NativeClassPtr, 100674646);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtility>.NativeClassPtr, 100674647);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 875057, RefRangeEnd = 875059, XrefRangeStart = 875024, XrefRangeEnd = 875057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AreaString2TilePos(string s, out int mapID, out HashSet<Vector3Int> poslist)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mapID);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreaString2TilePos_Public_Static_Void_String_byref_Int32_byref_HashSet_1_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		poslist = ((num3 == 0) ? null : new HashSet<Vector3Int>(num3));
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapUtility>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MapUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
