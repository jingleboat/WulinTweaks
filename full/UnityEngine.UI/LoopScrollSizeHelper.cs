using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI;

public class LoopScrollSizeHelper : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetItemsSize_Public_Abstract_Virtual_New_Vector2_Int32_0;

	static LoopScrollSizeHelper()
	{
		Il2CppClassPointerStore<LoopScrollSizeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI", "LoopScrollSizeHelper");
		NativeMethodInfoPtr_GetItemsSize_Public_Abstract_Virtual_New_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopScrollSizeHelper>.NativeClassPtr, 100666835);
	}

	[CallerCount(0)]
	public unsafe virtual Vector2 GetItemsSize(int itemsCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&itemsCount);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemsSize_Public_Abstract_Virtual_New_Vector2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public LoopScrollSizeHelper(IntPtr pointer)
		: base(pointer)
	{
	}
}
