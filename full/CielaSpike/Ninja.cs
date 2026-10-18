using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CielaSpike;

public static class Ninja : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_JumpToUnity;

	private static readonly System.IntPtr NativeFieldInfoPtr_JumpBack;

	public unsafe static Il2CppSystem.Object JumpToUnity
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JumpToUnity, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JumpToUnity, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static Il2CppSystem.Object JumpBack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JumpBack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JumpBack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	static Ninja()
	{
		Il2CppClassPointerStore<Ninja>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "CielaSpike", "Ninja");
		NativeFieldInfoPtr_JumpToUnity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ninja>.NativeClassPtr, "JumpToUnity");
		NativeFieldInfoPtr_JumpBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ninja>.NativeClassPtr, "JumpBack");
	}

	public Ninja(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
