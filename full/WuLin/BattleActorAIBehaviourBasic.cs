using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using WuLin.StateMachine;

namespace WuLin;

public class BattleActorAIBehaviourBasic : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("WuLin.BattleActorAIBehaviourBasic+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortTarget_b__12_0_Internal_Int32_BattleActor_BattleActor_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<BattleActor> __9__12_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<BattleActor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__12_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__12_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686078);
			NativeMethodInfoPtr__SortTarget_b__12_0_Internal_Int32_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686079);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771465, XrefRangeEnd = 771468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortTarget_b__12_0(BattleActor x, BattleActor y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortTarget_b__12_0_Internal_Int32_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_excuteRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_aITargetMoveStg;

	private static readonly System.IntPtr NativeFieldInfoPtr_aIMoveStg;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedMoveRelatePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedMoveRelateActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedSortedMovePosesList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedAiTraversalProvider;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckExt_Public_Abstract_Virtual_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheSortedMovePosesList_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchPosAndActorByStg_Protected_Void_AIPosStg_byref_Vector3Int_byref_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortTarget_Protected_Void_TargetSortMethod_byref_List_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortKungfuInstance_Protected_Void_KungfuSortMethod_byref_List_1_KungfuInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortTile_Protected_Void_TileSortStg_byref_List_1_Vector3Int_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__FetchPosAndActorByStg_b__11_0_Private_Int32_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SortTarget_b__12_1_Private_Int32_BattleActor_BattleActor_0;

	public unsafe float excuteRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excuteRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excuteRate)) = num;
		}
	}

	public unsafe AIPosStg aITargetMoveStg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aITargetMoveStg);
			return *(AIPosStg*)num;
		}
		set
		{
			*(AIPosStg*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aITargetMoveStg)) = aIPosStg;
		}
	}

	public unsafe TileSortStg aIMoveStg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aIMoveStg);
			return *(TileSortStg*)num;
		}
		set
		{
			*(TileSortStg*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aIMoveStg)) = tileSortStg;
		}
	}

	public unsafe BattleActor m_cachedActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedActor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe Vector3Int m_cachedMoveRelatePosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedMoveRelatePosition);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedMoveRelatePosition)) = vector3Int;
		}
	}

	public unsafe BattleActor m_cachedMoveRelateActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedMoveRelateActor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedMoveRelateActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe List<Vector3Int> m_cachedSortedMovePosesList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedSortedMovePosesList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedSortedMovePosesList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleAiTraversalProvider m_cachedAiTraversalProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedAiTraversalProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleAiTraversalProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedAiTraversalProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleAiTraversalProvider));
		}
	}

	static BattleActorAIBehaviourBasic()
	{
		Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActorAIBehaviourBasic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr);
		NativeFieldInfoPtr_excuteRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "excuteRate");
		NativeFieldInfoPtr_aITargetMoveStg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "aITargetMoveStg");
		NativeFieldInfoPtr_aIMoveStg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "aIMoveStg");
		NativeFieldInfoPtr_m_cachedActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "m_cachedActor");
		NativeFieldInfoPtr_m_cachedMoveRelatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "m_cachedMoveRelatePosition");
		NativeFieldInfoPtr_m_cachedMoveRelateActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "m_cachedMoveRelateActor");
		NativeFieldInfoPtr_m_cachedSortedMovePosesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "m_cachedSortedMovePosesList");
		NativeFieldInfoPtr_m_cachedAiTraversalProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, "m_cachedAiTraversalProvider");
		NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671090);
		NativeMethodInfoPtr_CheckExt_Public_Abstract_Virtual_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671091);
		NativeMethodInfoPtr_CacheSortedMovePosesList_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671092);
		NativeMethodInfoPtr_FetchPosAndActorByStg_Protected_Void_AIPosStg_byref_Vector3Int_byref_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671093);
		NativeMethodInfoPtr_SortTarget_Protected_Void_TargetSortMethod_byref_List_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671094);
		NativeMethodInfoPtr_SortKungfuInstance_Protected_Void_KungfuSortMethod_byref_List_1_KungfuInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671095);
		NativeMethodInfoPtr_SortTile_Protected_Void_TileSortStg_byref_List_1_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671096);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671097);
		NativeMethodInfoPtr__FetchPosAndActorByStg_b__11_0_Private_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671098);
		NativeMethodInfoPtr__SortTarget_b__12_1_Private_Int32_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr, 100671099);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771468, XrefRangeEnd = 771487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Check(ActiveActorStateMachineData activeActorStateMachineData, ref Vector3Int movePos, ref KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref movePos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool CheckExt(ActiveActorStateMachineData activeActorStateMachineData, ref Vector3Int movePos, ref KungfuActionCastData kungfuActionCastData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeActorStateMachineData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref movePos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kungfuActionCastData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckExt_Public_Abstract_Virtual_New_Boolean_ActiveActorStateMachineData_byref_Vector3Int_byref_KungfuActionCastData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771513, RefRangeEnd = 771514, XrefRangeStart = 771487, XrefRangeEnd = 771513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheSortedMovePosesList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheSortedMovePosesList_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771567, RefRangeEnd = 771568, XrefRangeStart = 771514, XrefRangeEnd = 771567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FetchPosAndActorByStg(AIPosStg aIPosStg, ref Vector3Int pos, ref BattleActor relateActor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&aIPosStg);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relateActor);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchPosAndActorByStg_Protected_Void_AIPosStg_byref_Vector3Int_byref_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		relateActor = ((intPtr4 == (System.IntPtr)0) ? null : new BattleActor(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771568, XrefRangeEnd = 771594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortTarget(TargetSortMethod targetSortMethod, ref List<BattleActor> actors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetSortMethod);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actors);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortTarget_Protected_Void_TargetSortMethod_byref_List_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		actors = ((intPtr4 == (System.IntPtr)0) ? null : new List<BattleActor>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771621, RefRangeEnd = 771622, XrefRangeStart = 771594, XrefRangeEnd = 771621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortKungfuInstance(KungfuSortMethod kungfuSortMethod, ref List<KungfuInstance> kungfuInstances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&kungfuSortMethod);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstances);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortKungfuInstance_Protected_Void_KungfuSortMethod_byref_List_1_KungfuInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		kungfuInstances = ((intPtr4 == (System.IntPtr)0) ? null : new List<KungfuInstance>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771622, XrefRangeEnd = 771634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortTile(TileSortStg tileSortStg, ref List<Vector3Int> tiles, Vector3Int actorPos, Vector3Int relatePos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&tileSortStg);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tiles);
		*(System.IntPtr**)num = &intPtr;
		*(Vector3Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actorPos;
		*(Vector3Int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &relatePos;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortTile_Protected_Void_TileSortStg_byref_List_1_Vector3Int_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		tiles = ((intPtr4 == (System.IntPtr)0) ? null : new List<Vector3Int>(intPtr4));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 771635, RefRangeEnd = 771639, XrefRangeStart = 771634, XrefRangeEnd = 771635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorAIBehaviourBasic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorAIBehaviourBasic>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771639, XrefRangeEnd = 771645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _FetchPosAndActorByStg_b__11_0(Vector3Int x, Vector3Int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FetchPosAndActorByStg_b__11_0_Private_Int32_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771645, XrefRangeEnd = 771651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _SortTarget_b__12_1(BattleActor x, BattleActor y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortTarget_b__12_1_Private_Int32_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BattleActorAIBehaviourBasic(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
