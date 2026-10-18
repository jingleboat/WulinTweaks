using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class ActorDeadBattleFieldEvent : BattleFieldEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_deadActor;

	private static readonly IntPtr NativeFieldInfoPtr_dealerActor;

	private static readonly IntPtr NativeFieldInfoPtr_hasSecondWind;

	private static readonly IntPtr NativeFieldInfoPtr_secondWindHp;

	private static readonly IntPtr NativeFieldInfoPtr_secondWindEffect;

	private static readonly IntPtr NativeFieldInfoPtr_coin;

	private static readonly IntPtr NativeFieldInfoPtr_items;

	private static readonly IntPtr NativeFieldInfoPtr_additionInfo;

	private static readonly IntPtr NativeFieldInfoPtr_battleExp;

	private static readonly IntPtr NativeFieldInfoPtr_battlePower;

	private static readonly IntPtr NativeFieldInfoPtr_dealerLevelup;

	private static readonly IntPtr NativeMethodInfoPtr_AddItemsToDisplay_Public_Void_ItemData_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BattleActor deadActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadActor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe BattleActor dealerActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerActor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe bool hasSecondWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSecondWind);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSecondWind)) = flag;
		}
	}

	public unsafe int secondWindHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondWindHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondWindHp)) = num;
		}
	}

	public unsafe string secondWindEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondWindEffect);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondWindEffect)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe long coin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coin);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coin)) = num;
		}
	}

	public unsafe Dictionary<ItemData, int> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemData, int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<GameLogManager.SimpleLocInfo> additionInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionInfo);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameLogManager.SimpleLocInfo>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int battleExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleExp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleExp)) = num;
		}
	}

	public unsafe int battlePower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battlePower)) = num;
		}
	}

	public unsafe bool dealerLevelup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerLevelup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dealerLevelup)) = flag;
		}
	}

	static ActorDeadBattleFieldEvent()
	{
		Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ActorDeadBattleFieldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr);
		NativeFieldInfoPtr_deadActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "deadActor");
		NativeFieldInfoPtr_dealerActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "dealerActor");
		NativeFieldInfoPtr_hasSecondWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "hasSecondWind");
		NativeFieldInfoPtr_secondWindHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "secondWindHp");
		NativeFieldInfoPtr_secondWindEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "secondWindEffect");
		NativeFieldInfoPtr_coin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "coin");
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "items");
		NativeFieldInfoPtr_additionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "additionInfo");
		NativeFieldInfoPtr_battleExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "battleExp");
		NativeFieldInfoPtr_battlePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "battlePower");
		NativeFieldInfoPtr_dealerLevelup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, "dealerLevelup");
		NativeMethodInfoPtr_AddItemsToDisplay_Public_Void_ItemData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, 100671266);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr, 100671267);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 775130, RefRangeEnd = 775131, XrefRangeStart = 775118, XrefRangeEnd = 775130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddItemsToDisplay(ItemData data, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &count;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItemsToDisplay_Public_Void_ItemData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 775146, RefRangeEnd = 775148, XrefRangeStart = 775131, XrefRangeEnd = 775146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorDeadBattleFieldEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorDeadBattleFieldEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActorDeadBattleFieldEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
