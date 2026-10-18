using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class Dlc1InvasionBattleData : Dlc1DelayAction
{
	public enum InvasionBattleDataState
	{
		EngaingBattle = 0,
		DataError = 100,
		AttackProvinceChangeOwner = 110,
		DefendProvinceChangeOwner = 120,
		DefendProvinceNoOwner = 121,
		DefendProvinceNoDefender = 122,
		AttackDefendIsSame = 130
	}

	private static readonly IntPtr NativeFieldInfoPtr_attackFaction;

	private static readonly IntPtr NativeFieldInfoPtr_defendFaction;

	private static readonly IntPtr NativeFieldInfoPtr_attackAllieFaction;

	private static readonly IntPtr NativeFieldInfoPtr_defendAllieFaction;

	private static readonly IntPtr NativeFieldInfoPtr_attackFromProvince;

	private static readonly IntPtr NativeFieldInfoPtr_defendProvince;

	private static readonly IntPtr NativeFieldInfoPtr_cachedBattleFieldData;

	private static readonly IntPtr NativeFieldInfoPtr_attackAllieArmy;

	private static readonly IntPtr NativeFieldInfoPtr_defendArmy;

	private static readonly IntPtr NativeFieldInfoPtr_defendAllieArmy;

	private static readonly IntPtr NativeFieldInfoPtr_wontStartIfNoDefender;

	private static readonly IntPtr NativeFieldInfoPtr_customKey;

	private static readonly IntPtr NativeFieldInfoPtr_defenderGuardControlable;

	private static readonly IntPtr NativeFieldInfoPtr_isAttackerWin;

	private static readonly IntPtr NativeMethodInfoPtr_get_attackArmy_Public_get_List_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_attackArmy_Public_set_Void_List_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_InvasionBattleDataState_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasValidDefender_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsPlayerInvolved_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int attackFaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackFaction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackFaction)) = num;
		}
	}

	public unsafe int defendFaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendFaction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendFaction)) = num;
		}
	}

	public unsafe int attackAllieFaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAllieFaction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAllieFaction)) = num;
		}
	}

	public unsafe int defendAllieFaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendAllieFaction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendAllieFaction)) = num;
		}
	}

	public unsafe int attackFromProvince
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackFromProvince);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackFromProvince)) = num;
		}
	}

	public unsafe int defendProvince
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendProvince);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendProvince)) = num;
		}
	}

	public unsafe DLCBattleFieldData cachedBattleFieldData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBattleFieldData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DLCBattleFieldData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBattleFieldData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCBattleFieldData));
		}
	}

	public unsafe List<int> attackAllieArmy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAllieArmy);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAllieArmy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> defendArmy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendArmy);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendArmy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> defendAllieArmy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendAllieArmy);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defendAllieArmy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool wontStartIfNoDefender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wontStartIfNoDefender);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wontStartIfNoDefender)) = flag;
		}
	}

	public unsafe string customKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool defenderGuardControlable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defenderGuardControlable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defenderGuardControlable)) = flag;
		}
	}

	public unsafe bool isAttackerWin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttackerWin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttackerWin)) = flag;
		}
	}

	public unsafe List<int> attackArmy
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 13952, RefRangeEnd = 13960, XrefRangeStart = 13952, XrefRangeEnd = 13960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_attackArmy_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 13960, RefRangeEnd = 13981, XrefRangeStart = 13960, XrefRangeEnd = 13981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_attackArmy_Public_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Dlc1InvasionBattleData()
	{
		Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "Dlc1InvasionBattleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr);
		NativeFieldInfoPtr_attackFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "attackFaction");
		NativeFieldInfoPtr_defendFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "defendFaction");
		NativeFieldInfoPtr_attackAllieFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "attackAllieFaction");
		NativeFieldInfoPtr_defendAllieFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "defendAllieFaction");
		NativeFieldInfoPtr_attackFromProvince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "attackFromProvince");
		NativeFieldInfoPtr_defendProvince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "defendProvince");
		NativeFieldInfoPtr_cachedBattleFieldData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "cachedBattleFieldData");
		NativeFieldInfoPtr_attackAllieArmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "attackAllieArmy");
		NativeFieldInfoPtr_defendArmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "defendArmy");
		NativeFieldInfoPtr_defendAllieArmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "defendAllieArmy");
		NativeFieldInfoPtr_wontStartIfNoDefender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "wontStartIfNoDefender");
		NativeFieldInfoPtr_customKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "customKey");
		NativeFieldInfoPtr_defenderGuardControlable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "defenderGuardControlable");
		NativeFieldInfoPtr_isAttackerWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, "isAttackerWin");
		NativeMethodInfoPtr_get_attackArmy_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679014);
		NativeMethodInfoPtr_set_attackArmy_Public_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679015);
		NativeMethodInfoPtr_GetState_Public_InvasionBattleDataState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679016);
		NativeMethodInfoPtr_HasValidDefender_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679017);
		NativeMethodInfoPtr_IsPlayerInvolved_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679018);
		NativeMethodInfoPtr_Invoke_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679019);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr, 100679020);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990174, XrefRangeEnd = 990185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvasionBattleDataState GetState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetState_Public_InvasionBattleDataState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InvasionBattleDataState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 990188, RefRangeEnd = 990189, XrefRangeStart = 990185, XrefRangeEnd = 990188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasValidDefender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValidDefender_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 990196, RefRangeEnd = 990199, XrefRangeStart = 990189, XrefRangeEnd = 990196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlayerInvolved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayerInvolved_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990199, XrefRangeEnd = 990207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Invoke_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 990224, RefRangeEnd = 990226, XrefRangeStart = 990207, XrefRangeEnd = 990224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1InvasionBattleData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1InvasionBattleData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Dlc1InvasionBattleData(IntPtr pointer)
		: base(pointer)
	{
	}
}
