using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Pathfinding;

public class INavmeshHolder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Abstract_Virtual_New_Int3_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetVertexInGraphSpace_Public_Abstract_Virtual_New_Int3_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetVertexArrayIndex_Public_Abstract_Virtual_New_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTileCoordinates_Public_Abstract_Virtual_New_Void_Int32_byref_Int32_byref_Int32_0;

	static INavmeshHolder()
	{
		Il2CppClassPointerStore<INavmeshHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "INavmeshHolder");
		NativeMethodInfoPtr_GetVertex_Public_Abstract_Virtual_New_Int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavmeshHolder>.NativeClassPtr, 100683381);
		NativeMethodInfoPtr_GetVertexInGraphSpace_Public_Abstract_Virtual_New_Int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavmeshHolder>.NativeClassPtr, 100683382);
		NativeMethodInfoPtr_GetVertexArrayIndex_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavmeshHolder>.NativeClassPtr, 100683383);
		NativeMethodInfoPtr_GetTileCoordinates_Public_Abstract_Virtual_New_Void_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavmeshHolder>.NativeClassPtr, 100683384);
	}

	[CallerCount(0)]
	public unsafe virtual Int3 GetVertex(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetVertex_Public_Abstract_Virtual_New_Int3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Int3 GetVertexInGraphSpace(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetVertexInGraphSpace_Public_Abstract_Virtual_New_Int3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetVertexArrayIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetVertexArrayIndex_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void GetTileCoordinates(int tileIndex, out int x, out int z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&tileIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref x);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref z);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTileCoordinates_Public_Abstract_Virtual_New_Void_Int32_byref_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public INavmeshHolder(IntPtr pointer)
		: base(pointer)
	{
	}
}
