using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RewiredConsts;

public static class Layout : Il2CppSystem.Object
{
	public static class Joystick : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Default;

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

		static Joystick()
		{
			Il2CppClassPointerStore<Joystick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Layout>.NativeClassPtr, "Joystick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Joystick>.NativeClassPtr);
			NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Joystick>.NativeClassPtr, "Default");
		}

		public Joystick(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class Keyboard : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Default;

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

		static Keyboard()
		{
			Il2CppClassPointerStore<Keyboard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Layout>.NativeClassPtr, "Keyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyboard>.NativeClassPtr);
			NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "Default");
		}

		public Keyboard(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class Mouse : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Default;

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

		static Mouse()
		{
			Il2CppClassPointerStore<Mouse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Layout>.NativeClassPtr, "Mouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mouse>.NativeClassPtr);
			NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "Default");
		}

		public Mouse(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class CustomController : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Default;

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

		static CustomController()
		{
			Il2CppClassPointerStore<CustomController>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Layout>.NativeClassPtr, "CustomController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController>.NativeClassPtr);
			NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "Default");
		}

		public CustomController(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	static Layout()
	{
		Il2CppClassPointerStore<Layout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RewiredConsts", "Layout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Layout>.NativeClassPtr);
	}

	public Layout(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
