using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace SoftMasking.Extensions;

public static class MaterialOps : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsSoftMask_Public_Static_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasDefaultUIShader_Public_Static_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasDefaultETC1UIShader_Public_Static_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_Material_String_Boolean_0;

	static MaterialOps()
	{
		Il2CppClassPointerStore<MaterialOps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SoftMasking.Extensions", "MaterialOps");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOps>.NativeClassPtr);
		NativeMethodInfoPtr_SupportsSoftMask_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOps>.NativeClassPtr, 100665613);
		NativeMethodInfoPtr_HasDefaultUIShader_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOps>.NativeClassPtr, 100665614);
		NativeMethodInfoPtr_HasDefaultETC1UIShader_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOps>.NativeClassPtr, 100665615);
		NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_Material_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOps>.NativeClassPtr, 100665616);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 709415, RefRangeEnd = 709416, XrefRangeStart = 709411, XrefRangeEnd = 709415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsSoftMask(this Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsSoftMask_Public_Static_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 709424, RefRangeEnd = 709426, XrefRangeStart = 709416, XrefRangeEnd = 709424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasDefaultUIShader(this Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasDefaultUIShader_Public_Static_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 709434, RefRangeEnd = 709435, XrefRangeStart = 709426, XrefRangeEnd = 709434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasDefaultETC1UIShader(this Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasDefaultETC1UIShader_Public_Static_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 313693, RefRangeEnd = 313720, XrefRangeStart = 313693, XrefRangeEnd = 313720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableKeyword(this Material mat, string keyword, bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(keyword);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_Material_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialOps(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
