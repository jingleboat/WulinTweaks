using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Pathfinding.Util;

public class IAstarPooledObject : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterPool_Public_Abstract_Virtual_New_Void_0;

	static IAstarPooledObject()
	{
		Il2CppClassPointerStore<IAstarPooledObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "IAstarPooledObject");
		NativeMethodInfoPtr_OnEnterPool_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAstarPooledObject>.NativeClassPtr, 100684289);
	}

	[CallerCount(0)]
	public unsafe virtual void OnEnterPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEnterPool_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IAstarPooledObject(IntPtr pointer)
		: base(pointer)
	{
	}
}
