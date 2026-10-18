using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine;

[System.Serializable]
public class MColor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_M50;

	private static readonly System.IntPtr NativeFieldInfoPtr_M100;

	private static readonly System.IntPtr NativeFieldInfoPtr_M200;

	private static readonly System.IntPtr NativeFieldInfoPtr_M300;

	private static readonly System.IntPtr NativeFieldInfoPtr_M400;

	private static readonly System.IntPtr NativeFieldInfoPtr_M500;

	private static readonly System.IntPtr NativeFieldInfoPtr_M600;

	private static readonly System.IntPtr NativeFieldInfoPtr_M700;

	private static readonly System.IntPtr NativeFieldInfoPtr_M800;

	private static readonly System.IntPtr NativeFieldInfoPtr_M900;

	private static readonly System.IntPtr NativeFieldInfoPtr_A100;

	private static readonly System.IntPtr NativeFieldInfoPtr_A200;

	private static readonly System.IntPtr NativeFieldInfoPtr_A400;

	private static readonly System.IntPtr NativeFieldInfoPtr_A700;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_String_String_String_String_String_String_0;

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color M50
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M50);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M50)) = color;
		}
	}

	public unsafe Color M100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M100);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M100)) = color;
		}
	}

	public unsafe Color M200
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M200);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M200)) = color;
		}
	}

	public unsafe Color M300
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M300);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M300)) = color;
		}
	}

	public unsafe Color M400
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M400);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M400)) = color;
		}
	}

	public unsafe Color M500
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M500);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M500)) = color;
		}
	}

	public unsafe Color M600
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M600);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M600)) = color;
		}
	}

	public unsafe Color M700
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M700);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M700)) = color;
		}
	}

	public unsafe Color M800
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M800);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M800)) = color;
		}
	}

	public unsafe Color M900
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M900);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_M900)) = color;
		}
	}

	public unsafe Color A100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A100);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A100)) = color;
		}
	}

	public unsafe Color A200
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A200);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A200)) = color;
		}
	}

	public unsafe Color A400
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A400);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A400)) = color;
		}
	}

	public unsafe Color A700
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A700);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A700)) = color;
		}
	}

	static MColor()
	{
		Il2CppClassPointerStore<MColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine", "MColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MColor>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_M50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M50");
		NativeFieldInfoPtr_M100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M100");
		NativeFieldInfoPtr_M200 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M200");
		NativeFieldInfoPtr_M300 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M300");
		NativeFieldInfoPtr_M400 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M400");
		NativeFieldInfoPtr_M500 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M500");
		NativeFieldInfoPtr_M600 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M600");
		NativeFieldInfoPtr_M700 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M700");
		NativeFieldInfoPtr_M800 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M800");
		NativeFieldInfoPtr_M900 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "M900");
		NativeFieldInfoPtr_A100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "A100");
		NativeFieldInfoPtr_A200 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "A200");
		NativeFieldInfoPtr_A400 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "A400");
		NativeFieldInfoPtr_A700 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MColor>.NativeClassPtr, "A700");
		NativeMethodInfoPtr__ctor_Public_Void_String_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MColor>.NativeClassPtr, 100667334);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MColor>.NativeClassPtr, 100667335);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725391, XrefRangeEnd = 725392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MColor(string name, Color m50, Color m100, Color m200, Color m300, Color m400, Color m500, Color m600, Color m700, Color m800, Color m900, Color a100, Color a200, Color a400, Color a700)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[15];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &m50;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &m100;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &m200;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &m300;
		*(Color**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &m400;
		*(Color**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &m500;
		*(Color**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &m600;
		*(Color**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &m700;
		*(Color**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &m800;
		*(Color**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &m900;
		*(Color**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &a100;
		*(Color**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &a200;
		*(Color**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &a400;
		*(Color**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &a700;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725392, XrefRangeEnd = 725407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MColor(string name, string m50Hex, string m100Hex, string m200Hex, string m300Hex, string m400Hex, string m500Hex, string m600Hex, string m700Hex, string m800Hex, string m900Hex, string a100Hex, string a200Hex, string a400Hex, string a700Hex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[15];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m50Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m100Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m200Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m300Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m400Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m500Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m600Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m700Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m800Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(m900Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(a100Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(a200Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(a400Hex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(a700Hex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MColor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
