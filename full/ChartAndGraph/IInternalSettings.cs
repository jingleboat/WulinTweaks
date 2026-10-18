using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace ChartAndGraph;

public class IInternalSettings : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_add_InternalOnDataUpdate_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_InternalOnDataUpdate_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_InternalOnDataChanged_Public_Abstract_Virtual_New_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_InternalOnDataChanged_Public_Abstract_Virtual_New_rem_Void_EventHandler_0;

	static IInternalSettings()
	{
		Il2CppClassPointerStore<IInternalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "IInternalSettings");
		NativeMethodInfoPtr_add_InternalOnDataUpdate_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalSettings>.NativeClassPtr, 100670219);
		NativeMethodInfoPtr_remove_InternalOnDataUpdate_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalSettings>.NativeClassPtr, 100670220);
		NativeMethodInfoPtr_add_InternalOnDataChanged_Public_Abstract_Virtual_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalSettings>.NativeClassPtr, 100670221);
		NativeMethodInfoPtr_remove_InternalOnDataChanged_Public_Abstract_Virtual_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalSettings>.NativeClassPtr, 100670222);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_InternalOnDataUpdate(Il2CppSystem.EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_InternalOnDataUpdate_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_InternalOnDataUpdate(Il2CppSystem.EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_InternalOnDataUpdate_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_InternalOnDataChanged(Il2CppSystem.EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_InternalOnDataChanged_Public_Abstract_Virtual_New_add_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_InternalOnDataChanged(Il2CppSystem.EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_InternalOnDataChanged_Public_Abstract_Virtual_New_rem_Void_EventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInternalSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
