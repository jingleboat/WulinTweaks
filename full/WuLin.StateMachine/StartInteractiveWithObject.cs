using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.StateMachine;

public class StartInteractiveWithObject : ActionNode
{
	public enum InteractiveType
	{
		OpenDoor,
		OpenChest,
		SwitchLight,
		Teleport,
		GatherRes,
		OpenForgeTable,
		Bulletin,
		OpenFiefStele,
		OpenFiefTable,
		OpenFiefDevelop,
		OpenSworn
	}

	private static readonly IntPtr NativeFieldInfoPtr_interactiveType;

	private static readonly IntPtr NativeMethodInfoPtr_InvokeAction_Public_Virtual_Void_StateMachineDataContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InteractiveType interactiveType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactiveType);
			return *(InteractiveType*)num;
		}
		set
		{
			*(InteractiveType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactiveType)) = interactiveType;
		}
	}

	static StartInteractiveWithObject()
	{
		Il2CppClassPointerStore<StartInteractiveWithObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "StartInteractiveWithObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartInteractiveWithObject>.NativeClassPtr);
		NativeFieldInfoPtr_interactiveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartInteractiveWithObject>.NativeClassPtr, "interactiveType");
		NativeMethodInfoPtr_InvokeAction_Public_Virtual_Void_StateMachineDataContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartInteractiveWithObject>.NativeClassPtr, 100680822);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartInteractiveWithObject>.NativeClassPtr, 100680823);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031822, XrefRangeEnd = 1031868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InvokeAction(StateMachineDataContainer data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InvokeAction_Public_Virtual_Void_StateMachineDataContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1031215, RefRangeEnd = 1031216, XrefRangeStart = 1031215, XrefRangeEnd = 1031216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartInteractiveWithObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartInteractiveWithObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartInteractiveWithObject(IntPtr pointer)
		: base(pointer)
	{
	}
}
