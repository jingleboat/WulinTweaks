using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.StateMachine;

public class DebugActionNode : ActionNode
{
	private static readonly IntPtr NativeFieldInfoPtr_debug;

	private static readonly IntPtr NativeMethodInfoPtr_InvokeAction_Public_Virtual_Void_StateMachineDataContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static DebugActionNode()
	{
		Il2CppClassPointerStore<DebugActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "DebugActionNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugActionNode>.NativeClassPtr);
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionNode>.NativeClassPtr, "debug");
		NativeMethodInfoPtr_InvokeAction_Public_Virtual_Void_StateMachineDataContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionNode>.NativeClassPtr, 100680927);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionNode>.NativeClassPtr, 100680928);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033780, XrefRangeEnd = 1033784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InvokeAction(StateMachineDataContainer data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeAction_Public_Virtual_Void_StateMachineDataContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033784, XrefRangeEnd = 1033787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugActionNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugActionNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DebugActionNode(IntPtr pointer)
		: base(pointer)
	{
	}
}
