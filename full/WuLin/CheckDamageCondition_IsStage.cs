using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class CheckDamageCondition_IsStage : AModifierElementIsStage<CheckDamageCondition>
{
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Boolean_CheckDamageCondition_DynamicModifierActiveStage_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CheckDamageCondition_IsStage()
	{
		Il2CppClassPointerStore<CheckDamageCondition_IsStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "CheckDamageCondition_IsStage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckDamageCondition_IsStage>.NativeClassPtr);
		NativeMethodInfoPtr_Run_Public_Virtual_Boolean_CheckDamageCondition_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckDamageCondition_IsStage>.NativeClassPtr, 100671772);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckDamageCondition_IsStage>.NativeClassPtr, 100671773);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793113, XrefRangeEnd = 793117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Run(CheckDamageCondition element, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &stage;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Run_Public_Virtual_Boolean_CheckDamageCondition_DynamicModifierActiveStage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793117, XrefRangeEnd = 793120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CheckDamageCondition_IsStage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckDamageCondition_IsStage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CheckDamageCondition_IsStage(IntPtr pointer)
		: base(pointer)
	{
	}
}
