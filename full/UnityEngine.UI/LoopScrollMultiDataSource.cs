using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI;

public class LoopScrollMultiDataSource : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Abstract_Virtual_New_Void_Transform_Int32_0;

	static LoopScrollMultiDataSource()
	{
		Il2CppClassPointerStore<LoopScrollMultiDataSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI", "LoopScrollMultiDataSource");
		NativeMethodInfoPtr_ProvideData_Public_Abstract_Virtual_New_Void_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopScrollMultiDataSource>.NativeClassPtr, 100666695);
	}

	[CallerCount(0)]
	public unsafe virtual void ProvideData(Transform transform, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProvideData_Public_Abstract_Virtual_New_Void_Transform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LoopScrollMultiDataSource(IntPtr pointer)
		: base(pointer)
	{
	}
}
