using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin.StateMachine;

public class ActiveActorStateMachineData : StateMachineData
{
	private static readonly IntPtr NativeFieldInfoPtr_actor;

	private static readonly IntPtr NativeFieldInfoPtr_startPos;

	private static readonly IntPtr NativeFieldInfoPtr_totalMove;

	private static readonly IntPtr NativeFieldInfoPtr_hpBeforeAction;

	private static readonly IntPtr NativeFieldInfoPtr_epBeforeAction;

	private static readonly IntPtr NativeFieldInfoPtr_area;

	private static readonly IntPtr NativeFieldInfoPtr_avalibleKungfuInstances;

	private static readonly IntPtr NativeFieldInfoPtr_ulkFocus;

	private static readonly IntPtr NativeFieldInfoPtr_ulkDefence;

	private static readonly IntPtr NativeFieldInfoPtr_ulkSpeedEnhance;

	private static readonly IntPtr NativeFieldInfoPtr_ulkBreath;

	private static readonly IntPtr NativeFieldInfoPtr_ulkPoison;

	private static readonly IntPtr NativeFieldInfoPtr_ulkAntidote;

	private static readonly IntPtr NativeFieldInfoPtr_ulkHeal;

	private static readonly IntPtr NativeFieldInfoPtr_ulkHidWep;

	private static readonly IntPtr NativeFieldInfoPtr_ulkItem;

	private static readonly IntPtr NativeFieldInfoPtr_ulkSwitchInternal;

	private static readonly IntPtr NativeFieldInfoPtr_ulkSwitchUnique;

	private static readonly IntPtr NativeFieldInfoPtr_isAdditionActionMoveOnly;

	private static readonly IntPtr NativeFieldInfoPtr_couldAssistBondSkill;

	private static readonly IntPtr NativeFieldInfoPtr_hasAssistBondSkill;

	private static readonly IntPtr NativeFieldInfoPtr_couldUseBondSkill;

	private static readonly IntPtr NativeMethodInfoPtr_RecaculateMoveArea_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BattleActor actor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe Vector3Int startPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPos)) = vector3Int;
		}
	}

	public unsafe int totalMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalMove);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalMove)) = num;
		}
	}

	public unsafe int hpBeforeAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hpBeforeAction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hpBeforeAction)) = num;
		}
	}

	public unsafe int epBeforeAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_epBeforeAction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_epBeforeAction)) = num;
		}
	}

	public unsafe Dictionary<Vector3Int, int> area
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_area);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_area)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<KungfuInstance> avalibleKungfuInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avalibleKungfuInstances);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuInstance>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avalibleKungfuInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool ulkFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkFocus)) = flag;
		}
	}

	public unsafe bool ulkDefence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkDefence);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkDefence)) = flag;
		}
	}

	public unsafe bool ulkSpeedEnhance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkSpeedEnhance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkSpeedEnhance)) = flag;
		}
	}

	public unsafe bool ulkBreath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkBreath);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkBreath)) = flag;
		}
	}

	public unsafe bool ulkPoison
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkPoison);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkPoison)) = flag;
		}
	}

	public unsafe bool ulkAntidote
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkAntidote);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkAntidote)) = flag;
		}
	}

	public unsafe bool ulkHeal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkHeal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkHeal)) = flag;
		}
	}

	public unsafe bool ulkHidWep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkHidWep);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkHidWep)) = flag;
		}
	}

	public unsafe bool ulkItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkItem)) = flag;
		}
	}

	public unsafe bool ulkSwitchInternal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkSwitchInternal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkSwitchInternal)) = flag;
		}
	}

	public unsafe bool ulkSwitchUnique
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkSwitchUnique);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ulkSwitchUnique)) = flag;
		}
	}

	public unsafe bool isAdditionActionMoveOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAdditionActionMoveOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAdditionActionMoveOnly)) = flag;
		}
	}

	public unsafe bool couldAssistBondSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldAssistBondSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldAssistBondSkill)) = flag;
		}
	}

	public unsafe bool hasAssistBondSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasAssistBondSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasAssistBondSkill)) = flag;
		}
	}

	public unsafe bool couldUseBondSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldUseBondSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_couldUseBondSkill)) = flag;
		}
	}

	static ActiveActorStateMachineData()
	{
		Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "ActiveActorStateMachineData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr);
		NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "actor");
		NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "startPos");
		NativeFieldInfoPtr_totalMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "totalMove");
		NativeFieldInfoPtr_hpBeforeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "hpBeforeAction");
		NativeFieldInfoPtr_epBeforeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "epBeforeAction");
		NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "area");
		NativeFieldInfoPtr_avalibleKungfuInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "avalibleKungfuInstances");
		NativeFieldInfoPtr_ulkFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkFocus");
		NativeFieldInfoPtr_ulkDefence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkDefence");
		NativeFieldInfoPtr_ulkSpeedEnhance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkSpeedEnhance");
		NativeFieldInfoPtr_ulkBreath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkBreath");
		NativeFieldInfoPtr_ulkPoison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkPoison");
		NativeFieldInfoPtr_ulkAntidote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkAntidote");
		NativeFieldInfoPtr_ulkHeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkHeal");
		NativeFieldInfoPtr_ulkHidWep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkHidWep");
		NativeFieldInfoPtr_ulkItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkItem");
		NativeFieldInfoPtr_ulkSwitchInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkSwitchInternal");
		NativeFieldInfoPtr_ulkSwitchUnique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "ulkSwitchUnique");
		NativeFieldInfoPtr_isAdditionActionMoveOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "isAdditionActionMoveOnly");
		NativeFieldInfoPtr_couldAssistBondSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "couldAssistBondSkill");
		NativeFieldInfoPtr_hasAssistBondSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "hasAssistBondSkill");
		NativeFieldInfoPtr_couldUseBondSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, "couldUseBondSkill");
		NativeMethodInfoPtr_RecaculateMoveArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, 100680842);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr, 100680843);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1032639, RefRangeEnd = 1032640, XrefRangeStart = 1032604, XrefRangeEnd = 1032639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecaculateMoveArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecaculateMoveArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1032653, RefRangeEnd = 1032654, XrefRangeStart = 1032640, XrefRangeEnd = 1032653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveActorStateMachineData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveActorStateMachineData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActiveActorStateMachineData(IntPtr pointer)
		: base(pointer)
	{
	}
}
