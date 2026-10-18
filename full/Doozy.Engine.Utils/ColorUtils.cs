using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Utils.ColorModels;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Utils;

public static class ColorUtils : Il2CppSystem.Object
{
	public enum Conversions
	{
		RGB_TO_RGB,
		HEX_TO_RGB,
		RGB_TO_HEX,
		RGB_TO_FGC,
		HSL_TO_RGB,
		RGB_TO_HSL,
		HSV_TO_RGB,
		RGB_TO_HSV,
		CMY_TO_RGB,
		RGB_TO_CMY,
		CMYK_TO_RGB,
		RGB_TO_CMYK,
		XYZ_TO_RGB,
		RGB_TO_XYZ,
		Yxy_TO_RGB,
		RGB_TO_Yxy,
		LAB_TO_RGB,
		RGB_TO_LAB
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_HUEtoRGB_Public_Static_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HSLtoRGB_Public_Static_RGB_HSL_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RGBtoHSL_Public_Static_HSL_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HSVtoRGB_Public_Static_RGB_HSV_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RGBtoHSV_Public_Static_HSV_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CMYtoRGB_Public_Static_RGB_CMY_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RGBtoCMY_Public_Static_CMY_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CMYKtoRGB_Public_Static_RGB_CMYK_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RGBtoCMYK_Public_Static_CMYK_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XYZtoRGB_Public_Static_RGB_XYZ_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RGBtoXYZ_Public_Static_XYZ_RGB_0;

	static ColorUtils()
	{
		Il2CppClassPointerStore<ColorUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "ColorUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr);
		NativeMethodInfoPtr_HUEtoRGB_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667353);
		NativeMethodInfoPtr_HSLtoRGB_Public_Static_RGB_HSL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667354);
		NativeMethodInfoPtr_RGBtoHSL_Public_Static_HSL_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667355);
		NativeMethodInfoPtr_HSVtoRGB_Public_Static_RGB_HSV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667356);
		NativeMethodInfoPtr_RGBtoHSV_Public_Static_HSV_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667357);
		NativeMethodInfoPtr_CMYtoRGB_Public_Static_RGB_CMY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667358);
		NativeMethodInfoPtr_RGBtoCMY_Public_Static_CMY_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667359);
		NativeMethodInfoPtr_CMYKtoRGB_Public_Static_RGB_CMYK_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667360);
		NativeMethodInfoPtr_RGBtoCMYK_Public_Static_CMYK_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667361);
		NativeMethodInfoPtr_XYZtoRGB_Public_Static_RGB_XYZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667362);
		NativeMethodInfoPtr_RGBtoXYZ_Public_Static_XYZ_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100667363);
	}

	[CallerCount(0)]
	public unsafe static Vector3 HUEtoRGB(float H)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&H);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HUEtoRGB_Public_Static_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725869, RefRangeEnd = 725871, XrefRangeStart = 725851, XrefRangeEnd = 725869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RGB HSLtoRGB(HSL values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HSLtoRGB_Public_Static_RGB_HSL_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725897, RefRangeEnd = 725898, XrefRangeStart = 725871, XrefRangeEnd = 725897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HSL RGBtoHSL(RGB values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RGBtoHSL_Public_Static_HSL_RGB_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HSL>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725913, RefRangeEnd = 725915, XrefRangeStart = 725898, XrefRangeEnd = 725913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RGB HSVtoRGB(HSV values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HSVtoRGB_Public_Static_RGB_HSV_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 725941, RefRangeEnd = 725948, XrefRangeStart = 725915, XrefRangeEnd = 725941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HSV RGBtoHSV(RGB values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RGBtoHSV_Public_Static_HSV_RGB_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HSV>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725959, RefRangeEnd = 725961, XrefRangeStart = 725948, XrefRangeEnd = 725959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RGB CMYtoRGB(CMY values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CMYtoRGB_Public_Static_RGB_CMY_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725972, RefRangeEnd = 725973, XrefRangeStart = 725961, XrefRangeEnd = 725972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CMY RGBtoCMY(RGB values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RGBtoCMY_Public_Static_CMY_RGB_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CMY>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725995, RefRangeEnd = 725997, XrefRangeStart = 725973, XrefRangeEnd = 725995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RGB CMYKtoRGB(CMYK values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CMYKtoRGB_Public_Static_RGB_CMYK_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726026, RefRangeEnd = 726027, XrefRangeStart = 725997, XrefRangeEnd = 726026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CMYK RGBtoCMYK(RGB values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RGBtoCMYK_Public_Static_CMYK_RGB_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CMYK>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726044, RefRangeEnd = 726046, XrefRangeStart = 726027, XrefRangeEnd = 726044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RGB XYZtoRGB(XYZ values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XYZtoRGB_Public_Static_RGB_XYZ_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726057, RefRangeEnd = 726058, XrefRangeStart = 726046, XrefRangeEnd = 726057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XYZ RGBtoXYZ(RGB values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RGBtoXYZ_Public_Static_XYZ_RGB_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XYZ>(intPtr) : null;
	}

	public ColorUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
