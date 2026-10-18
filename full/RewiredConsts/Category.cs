using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RewiredConsts;

public static class Category : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Default;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_LeftStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_RightStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_DPad;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_FunctionButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_Standard_Sticks;

	private static readonly System.IntPtr NativeFieldInfoPtr_Standard_Buttons;

	public unsafe static int Default
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, (void*)(&num));
		}
	}

	public unsafe static int UI_LeftStick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_LeftStick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_LeftStick, (void*)(&num));
		}
	}

	public unsafe static int UI_RightStick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_RightStick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_RightStick, (void*)(&num));
		}
	}

	public unsafe static int UI_DPad
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_DPad, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_DPad, (void*)(&num));
		}
	}

	public unsafe static int UI_FunctionButtons
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_FunctionButtons, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_FunctionButtons, (void*)(&num));
		}
	}

	public unsafe static int Standard_Sticks
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Standard_Sticks, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Standard_Sticks, (void*)(&num));
		}
	}

	public unsafe static int Standard_Buttons
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Standard_Buttons, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Standard_Buttons, (void*)(&num));
		}
	}

	static Category()
	{
		Il2CppClassPointerStore<Category>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RewiredConsts", "Category");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Category>.NativeClassPtr);
		NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "Default");
		NativeFieldInfoPtr_UI_LeftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "UI_LeftStick");
		NativeFieldInfoPtr_UI_RightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "UI_RightStick");
		NativeFieldInfoPtr_UI_DPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "UI_DPad");
		NativeFieldInfoPtr_UI_FunctionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "UI_FunctionButtons");
		NativeFieldInfoPtr_Standard_Sticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "Standard_Sticks");
		NativeFieldInfoPtr_Standard_Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Category>.NativeClassPtr, "Standard_Buttons");
	}

	public Category(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
