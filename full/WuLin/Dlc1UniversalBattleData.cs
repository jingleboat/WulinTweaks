using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class Dlc1UniversalBattleData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_battleField;

	private static readonly System.IntPtr NativeFieldInfoPtr_isQuickBattle;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasBlackScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipPreparePhase;

	private static readonly System.IntPtr NativeFieldInfoPtr_recycleMapAfterBattleFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_overridePlayerTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideAllieTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideEnemyTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr__BattleFieldData_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BattleFieldData_Public_get_BattleFieldData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BattleFieldData_Private_set_Void_BattleFieldData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	public unsafe string battleField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleField)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isQuickBattle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isQuickBattle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isQuickBattle)) = flag;
		}
	}

	public unsafe bool hasBlackScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBlackScreen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBlackScreen)) = flag;
		}
	}

	public unsafe bool skipPreparePhase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipPreparePhase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipPreparePhase)) = flag;
		}
	}

	public unsafe bool recycleMapAfterBattleFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recycleMapAfterBattleFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recycleMapAfterBattleFinished)) = flag;
		}
	}

	public unsafe List<GameCharacterInstance> overridePlayerTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridePlayerTeam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridePlayerTeam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameCharacterInstance> overrideAllieTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAllieTeam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAllieTeam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameCharacterInstance> overrideEnemyTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEnemyTeam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameCharacterInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEnemyTeam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleFieldData _BattleFieldData_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BattleFieldData_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleFieldData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BattleFieldData_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleFieldData));
		}
	}

	public unsafe BattleFieldData BattleFieldData
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 18825, RefRangeEnd = 18831, XrefRangeStart = 18825, XrefRangeEnd = 18831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BattleFieldData_Public_get_BattleFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleFieldData>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20199, RefRangeEnd = 20200, XrefRangeStart = 20199, XrefRangeEnd = 20200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BattleFieldData_Private_set_Void_BattleFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Dlc1UniversalBattleData()
	{
		Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "Dlc1UniversalBattleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr);
		NativeFieldInfoPtr_battleField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "battleField");
		NativeFieldInfoPtr_isQuickBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "isQuickBattle");
		NativeFieldInfoPtr_hasBlackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "hasBlackScreen");
		NativeFieldInfoPtr_skipPreparePhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "skipPreparePhase");
		NativeFieldInfoPtr_recycleMapAfterBattleFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "recycleMapAfterBattleFinished");
		NativeFieldInfoPtr_overridePlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "overridePlayerTeam");
		NativeFieldInfoPtr_overrideAllieTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "overrideAllieTeam");
		NativeFieldInfoPtr_overrideEnemyTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "overrideEnemyTeam");
		NativeFieldInfoPtr__BattleFieldData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, "<BattleFieldData>k__BackingField");
		NativeMethodInfoPtr_get_BattleFieldData_Public_get_BattleFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, 100679026);
		NativeMethodInfoPtr_set_BattleFieldData_Private_set_Void_BattleFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, 100679027);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, 100679028);
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, 100679029);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr, 100679030);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 990248, RefRangeEnd = 990250, XrefRangeStart = 990247, XrefRangeEnd = 990248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1UniversalBattleData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 990251, RefRangeEnd = 990252, XrefRangeStart = 990250, XrefRangeEnd = 990251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1UniversalBattleData(string battleField, bool isQuickBattle = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1UniversalBattleData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(battleField);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isQuickBattle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990252, XrefRangeEnd = 990260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Dlc1UniversalBattleData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
