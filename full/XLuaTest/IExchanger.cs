using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLuaTest;

public class IExchanger : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_exchange_Public_Abstract_Virtual_New_Void_Array_0;

	static IExchanger()
	{
		Il2CppClassPointerStore<IExchanger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "IExchanger");
		NativeMethodInfoPtr_exchange_Public_Abstract_Virtual_New_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExchanger>.NativeClassPtr, 100665283);
	}

	[CallerCount(0)]
	public unsafe virtual void exchange(Il2CppSystem.Array arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_exchange_Public_Abstract_Virtual_New_Void_Array_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IExchanger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
