using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SoftMasking;

public static class MaskChannel : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_alpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_blue;

	private static readonly System.IntPtr NativeFieldInfoPtr_gray;

	public unsafe static Color alpha
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_alpha, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_alpha, (void*)(&color));
		}
	}

	public unsafe static Color red
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_red, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_red, (void*)(&color));
		}
	}

	public unsafe static Color green
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_green, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_green, (void*)(&color));
		}
	}

	public unsafe static Color blue
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blue, (void*)(&color));
		}
	}

	public unsafe static Color gray
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gray, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gray, (void*)(&color));
		}
	}

	static MaskChannel()
	{
		Il2CppClassPointerStore<MaskChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SoftMasking", "MaskChannel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskChannel>.NativeClassPtr);
		NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskChannel>.NativeClassPtr, "alpha");
		NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskChannel>.NativeClassPtr, "red");
		NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskChannel>.NativeClassPtr, "green");
		NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskChannel>.NativeClassPtr, "blue");
		NativeFieldInfoPtr_gray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskChannel>.NativeClassPtr, "gray");
	}

	public MaskChannel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
