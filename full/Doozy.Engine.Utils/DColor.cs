using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Utils;

[System.Serializable]
public class DColor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_UNNAMED_COLOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Light;

	private static readonly System.IntPtr NativeFieldInfoPtr_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dark;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightColor_Private_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDarkColor_Private_Static_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DColor_0;

	public unsafe static string UNNAMED_COLOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UNNAMED_COLOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UNNAMED_COLOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ColorName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color Light
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Light);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Light)) = color;
		}
	}

	public unsafe Color Normal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Normal);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Normal)) = color;
		}
	}

	public unsafe Color Dark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dark);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dark)) = color;
		}
	}

	static DColor()
	{
		Il2CppClassPointerStore<DColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "DColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DColor>.NativeClassPtr);
		NativeFieldInfoPtr_UNNAMED_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DColor>.NativeClassPtr, "UNNAMED_COLOR");
		NativeFieldInfoPtr_ColorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DColor>.NativeClassPtr, "ColorName");
		NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DColor>.NativeClassPtr, "Light");
		NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DColor>.NativeClassPtr, "Normal");
		NativeFieldInfoPtr_Dark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DColor>.NativeClassPtr, "Dark");
		NativeMethodInfoPtr_GetLightColor_Private_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667364);
		NativeMethodInfoPtr_GetDarkColor_Private_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667365);
		NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667366);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667367);
		NativeMethodInfoPtr__ctor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667368);
		NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667369);
		NativeMethodInfoPtr__ctor_Public_Void_String_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667370);
		NativeMethodInfoPtr__ctor_Public_Void_DColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DColor>.NativeClassPtr, 100667371);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726058, XrefRangeEnd = 726064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetLightColor(Color normalColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normalColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightColor_Private_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726064, XrefRangeEnd = 726070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetDarkColor(Color normalColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normalColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDarkColor_Private_Static_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726070, XrefRangeEnd = 726086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DColor(Color normal)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726086, XrefRangeEnd = 726090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DColor(string colorName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(colorName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726090, XrefRangeEnd = 726104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DColor(string colorName, Color normal)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(colorName);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726104, XrefRangeEnd = 726110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DColor(Color light, Color normal, Color dark)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&light);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dark;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726110, XrefRangeEnd = 726111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DColor(string colorName, Color light, Color normal, Color dark)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(colorName);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &light;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dark;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726111, XrefRangeEnd = 726115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DColor(DColor dColor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DColor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
