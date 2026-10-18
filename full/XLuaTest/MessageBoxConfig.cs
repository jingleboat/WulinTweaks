using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace XLuaTest;

public static class MessageBoxConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CSharpCallLua;

	public unsafe static List<Il2CppSystem.Type> CSharpCallLua
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CSharpCallLua, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CSharpCallLua, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MessageBoxConfig()
	{
		Il2CppClassPointerStore<MessageBoxConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "MessageBoxConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBoxConfig>.NativeClassPtr);
		NativeFieldInfoPtr_CSharpCallLua = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBoxConfig>.NativeClassPtr, "CSharpCallLua");
	}

	public MessageBoxConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
