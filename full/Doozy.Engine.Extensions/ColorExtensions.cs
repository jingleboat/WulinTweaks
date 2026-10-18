using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Extensions;

public static class ColorExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LIGHT_OFFSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_DARKER_FACTOR;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Color_Color_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorFrom256_Public_Static_Color_Color_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorFrom256_Public_Static_Color_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lighter_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Darker_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Brightness_Public_Static_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithBrightness_Public_Static_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsApproximatelyBlack_Public_Static_Boolean_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsApproximatelyWhite_Public_Static_Boolean_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invert_Public_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithAlpha_Public_Static_Color_Color_Single_0;

	public unsafe static float LIGHT_OFFSET
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIGHT_OFFSET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIGHT_OFFSET, (void*)(&num));
		}
	}

	public unsafe static float DARKER_FACTOR
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DARKER_FACTOR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DARKER_FACTOR, (void*)(&num));
		}
	}

	static ColorExtensions()
	{
		Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Extensions", "ColorExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr);
		NativeFieldInfoPtr_LIGHT_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, "LIGHT_OFFSET");
		NativeFieldInfoPtr_DARKER_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, "DARKER_FACTOR");
		NativeMethodInfoPtr_FromHex_Public_Static_Color_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669260);
		NativeMethodInfoPtr_ColorFrom256_Public_Static_Color_Color_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669261);
		NativeMethodInfoPtr_ColorFrom256_Public_Static_Color_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669262);
		NativeMethodInfoPtr_Lighter_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669263);
		NativeMethodInfoPtr_Darker_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669264);
		NativeMethodInfoPtr_Brightness_Public_Static_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669265);
		NativeMethodInfoPtr_WithBrightness_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669266);
		NativeMethodInfoPtr_IsApproximatelyBlack_Public_Static_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669267);
		NativeMethodInfoPtr_IsApproximatelyWhite_Public_Static_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669268);
		NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669269);
		NativeMethodInfoPtr_Invert_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669270);
		NativeMethodInfoPtr_WithAlpha_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100669271);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749698, XrefRangeEnd = 749709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color FromHex(this Color color, string hexValue, float alpha = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&color);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(hexValue);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromHex_Public_Static_Color_Color_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749709, XrefRangeEnd = 749710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ColorFrom256(this Color color, float r, float g, float b, float a = 255f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&color);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &g;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorFrom256_Public_Static_Color_Color_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749710, XrefRangeEnd = 749711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ColorFrom256(float r, float g, float b, float a = 255f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&r);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &g;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorFrom256_Public_Static_Color_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749711, XrefRangeEnd = 749712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Lighter(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lighter_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749712, XrefRangeEnd = 749713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Darker(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Darker_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float Brightness(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Brightness_Public_Static_Single_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749713, XrefRangeEnd = 749717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color WithBrightness(this Color color, float brightness)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &brightness;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBrightness_Public_Static_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749717, XrefRangeEnd = 749719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsApproximatelyBlack(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsApproximatelyBlack_Public_Static_Boolean_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749719, XrefRangeEnd = 749721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsApproximatelyWhite(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsApproximatelyWhite_Public_Static_Boolean_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749721, XrefRangeEnd = 749722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Opaque(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749722, XrefRangeEnd = 749723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Invert(this Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invert_Public_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color WithAlpha(this Color color, float alpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithAlpha_Public_Static_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ColorExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
