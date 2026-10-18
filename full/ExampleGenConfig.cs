using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public static class ExampleGenConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LuaCallCSharp;

	private static readonly System.IntPtr NativeFieldInfoPtr_CSharpCallLua;

	private static readonly System.IntPtr NativeFieldInfoPtr_BlackList;

	public unsafe static List<Il2CppSystem.Type> LuaCallCSharp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LuaCallCSharp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LuaCallCSharp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

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

	public unsafe static List<List<string>> BlackList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BlackList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BlackList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ExampleGenConfig()
	{
		Il2CppClassPointerStore<ExampleGenConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExampleGenConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleGenConfig>.NativeClassPtr);
		NativeFieldInfoPtr_LuaCallCSharp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleGenConfig>.NativeClassPtr, "LuaCallCSharp");
		NativeFieldInfoPtr_CSharpCallLua = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleGenConfig>.NativeClassPtr, "CSharpCallLua");
		NativeFieldInfoPtr_BlackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleGenConfig>.NativeClassPtr, "BlackList");
	}

	public ExampleGenConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
