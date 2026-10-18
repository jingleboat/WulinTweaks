using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ET;

public static class WaitTypeError : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Success;

	private static readonly System.IntPtr NativeFieldInfoPtr_Destroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Timeout;

	public unsafe static int Success
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Success, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Success, (void*)(&num));
		}
	}

	public unsafe static int Destroy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Destroy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Destroy, (void*)(&num));
		}
	}

	public unsafe static int Cancel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cancel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cancel, (void*)(&num));
		}
	}

	public unsafe static int Timeout
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Timeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Timeout, (void*)(&num));
		}
	}

	static WaitTypeError()
	{
		Il2CppClassPointerStore<WaitTypeError>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ET", "WaitTypeError");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitTypeError>.NativeClassPtr);
		NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitTypeError>.NativeClassPtr, "Success");
		NativeFieldInfoPtr_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitTypeError>.NativeClassPtr, "Destroy");
		NativeFieldInfoPtr_Cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitTypeError>.NativeClassPtr, "Cancel");
		NativeFieldInfoPtr_Timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitTypeError>.NativeClassPtr, "Timeout");
	}

	public WaitTypeError(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
