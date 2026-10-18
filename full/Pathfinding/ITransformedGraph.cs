using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Pathfinding.Util;

namespace Pathfinding;

public class ITransformedGraph : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_GraphTransform_0;

	public unsafe virtual GraphTransform transform
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_GraphTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr) : null;
		}
	}

	static ITransformedGraph()
	{
		Il2CppClassPointerStore<ITransformedGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "ITransformedGraph");
		NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_GraphTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransformedGraph>.NativeClassPtr, 100682946);
	}

	public ITransformedGraph(IntPtr pointer)
		: base(pointer)
	{
	}
}
