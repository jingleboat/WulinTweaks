using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RewiredConsts;

public static class Player : Il2CppSystem.Object
{
	private static readonly global::System.IntPtr NativeFieldInfoPtr_System;

	private static readonly global::System.IntPtr NativeFieldInfoPtr_Player0;

	public unsafe static int System
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_System, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_System, (void*)(&num));
		}
	}

	public unsafe static int Player0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Player0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Player0, (void*)(&num));
		}
	}

	static Player()
	{
		Il2CppClassPointerStore<Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RewiredConsts", "Player");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player>.NativeClassPtr);
		NativeFieldInfoPtr_System = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "System");
		NativeFieldInfoPtr_Player0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Player0");
	}

	public Player(global::System.IntPtr pointer)
		: base(pointer)
	{
	}
}
