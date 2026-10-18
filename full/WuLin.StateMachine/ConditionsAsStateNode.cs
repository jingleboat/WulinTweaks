using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace WuLin.StateMachine;

public class ConditionsAsStateNode : BaseStateNode
{
	private static readonly IntPtr NativeFieldInfoPtr_conditions;

	private static readonly IntPtr NativeFieldInfoPtr_JumpToState;

	private static readonly IntPtr NativeMethodInfoPtr_get_HasNoExitPort_Private_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStateNode_Public_Virtual_StateNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StateMachineConditionPort conditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StateMachineConditionPort>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineConditionPort));
		}
	}

	public unsafe string JumpToState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpToState);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpToState)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool HasNoExitPort
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033740, XrefRangeEnd = 1033745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasNoExitPort_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ConditionsAsStateNode()
	{
		Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "ConditionsAsStateNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr);
		NativeFieldInfoPtr_conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr, "conditions");
		NativeFieldInfoPtr_JumpToState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr, "JumpToState");
		NativeMethodInfoPtr_get_HasNoExitPort_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr, 100680923);
		NativeMethodInfoPtr_GetStateNode_Public_Virtual_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr, 100680924);
		NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr, 100680925);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr, 100680926);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033745, XrefRangeEnd = 1033761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override StateNode GetStateNode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStateNode_Public_Virtual_StateNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StateNode>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033761, XrefRangeEnd = 1033775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033775, XrefRangeEnd = 1033780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConditionsAsStateNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionsAsStateNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConditionsAsStateNode(IntPtr pointer)
		: base(pointer)
	{
	}
}
