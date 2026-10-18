using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using WuLin.StateMachine;

namespace WuLin;

public class BattleActorAIBehaviourMostPowerfulKungfu : BattleActorAIBehaviourBasic
{
	private static readonly IntPtr NativeFieldInfoPtr_sortMethod;

	private static readonly IntPtr NativeMethodInfoPtr_CheckExt_Public_Virtual_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TargetSortMethod sortMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortMethod);
			return *(TargetSortMethod*)num;
		}
		set
		{
			*(TargetSortMethod*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortMethod)) = targetSortMethod;
		}
	}

	static BattleActorAIBehaviourMostPowerfulKungfu()
	{
		Il2CppClassPointerStore<BattleActorAIBehaviourMostPowerfulKungfu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActorAIBehaviourMostPowerfulKungfu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorAIBehaviourMostPowerfulKungfu>.NativeClassPtr);
		NativeFieldInfoPtr_sortMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourMostPowerfulKungfu>.NativeClassPtr, "sortMethod");
		NativeMethodInfoPtr_CheckExt_Public_Virtual_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourMostPowerfulKungfu>.NativeClassPtr, 100671100);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourMostPowerfulKungfu>.NativeClassPtr, 100671101);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771651, XrefRangeEnd = 771806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CheckExt(ActiveActorStateMachineData activeActorStateMachineData, ref Vector3Int movePos, ref KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref movePos);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckExt_Public_Virtual_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 771635, RefRangeEnd = 771639, XrefRangeStart = 771635, XrefRangeEnd = 771639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorAIBehaviourMostPowerfulKungfu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorAIBehaviourMostPowerfulKungfu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleActorAIBehaviourMostPowerfulKungfu(IntPtr pointer)
		: base(pointer)
	{
	}
}
