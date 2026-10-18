using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;
using WuLin.StateMachine;

namespace WuLin;

public class AdvancedBattleActorAIBehaviour : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Final_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static AdvancedBattleActorAIBehaviour()
	{
		Il2CppClassPointerStore<AdvancedBattleActorAIBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "AdvancedBattleActorAIBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedBattleActorAIBehaviour>.NativeClassPtr);
		NativeMethodInfoPtr_Check_Public_Virtual_Final_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedBattleActorAIBehaviour>.NativeClassPtr, 100671110);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedBattleActorAIBehaviour>.NativeClassPtr, 100671111);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772018, XrefRangeEnd = 772069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Check(ActiveActorStateMachineData activeActorStateMachineData, ref Vector3Int movePos, ref KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref movePos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Virtual_Final_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdvancedBattleActorAIBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedBattleActorAIBehaviour>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AdvancedBattleActorAIBehaviour(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
