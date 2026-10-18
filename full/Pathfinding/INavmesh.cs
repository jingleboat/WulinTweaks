using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Pathfinding;

public class INavmesh : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodes_Public_Abstract_Virtual_New_Void_Action_1_GraphNode_0;

	static INavmesh()
	{
		Il2CppClassPointerStore<INavmesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "INavmesh");
		NativeMethodInfoPtr_GetNodes_Public_Abstract_Virtual_New_Void_Action_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavmesh>.NativeClassPtr, 100683240);
	}

	[CallerCount(0)]
	public unsafe virtual void GetNodes(Il2CppSystem.Action<GraphNode> del)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)del);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNodes_Public_Abstract_Virtual_New_Void_Action_1_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public INavmesh(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
