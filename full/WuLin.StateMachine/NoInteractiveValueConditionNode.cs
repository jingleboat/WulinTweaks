using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.StateMachine;

public class NoInteractiveValueConditionNode : StateMachineConditionNode
{
	private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static NoInteractiveValueConditionNode()
	{
		Il2CppClassPointerStore<NoInteractiveValueConditionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "NoInteractiveValueConditionNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInteractiveValueConditionNode>.NativeClassPtr);
		NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInteractiveValueConditionNode>.NativeClassPtr, 100680805);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInteractiveValueConditionNode>.NativeClassPtr, 100680806);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031578, XrefRangeEnd = 1031586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Check(StateMachineDataContainer data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoInteractiveValueConditionNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInteractiveValueConditionNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NoInteractiveValueConditionNode(IntPtr pointer)
		: base(pointer)
	{
	}
}
