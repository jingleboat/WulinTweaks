using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Pathfinding;

public class IUpdatableGraph : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_UpdateArea_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateAreaInit_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateAreaPost_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_CanUpdateAsync_Public_Abstract_Virtual_New_GraphUpdateThreading_GraphUpdateObject_0;

	static IUpdatableGraph()
	{
		Il2CppClassPointerStore<IUpdatableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "IUpdatableGraph");
		NativeMethodInfoPtr_UpdateArea_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdatableGraph>.NativeClassPtr, 100682935);
		NativeMethodInfoPtr_UpdateAreaInit_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdatableGraph>.NativeClassPtr, 100682936);
		NativeMethodInfoPtr_UpdateAreaPost_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdatableGraph>.NativeClassPtr, 100682937);
		NativeMethodInfoPtr_CanUpdateAsync_Public_Abstract_Virtual_New_GraphUpdateThreading_GraphUpdateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdatableGraph>.NativeClassPtr, 100682938);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateArea(GraphUpdateObject o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateArea_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateAreaInit(GraphUpdateObject o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateAreaInit_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateAreaPost(GraphUpdateObject o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateAreaPost_Public_Abstract_Virtual_New_Void_GraphUpdateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanUpdateAsync_Public_Abstract_Virtual_New_GraphUpdateThreading_GraphUpdateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GraphUpdateThreading*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IUpdatableGraph(IntPtr pointer)
		: base(pointer)
	{
	}
}
