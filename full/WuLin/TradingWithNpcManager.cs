using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public class TradingWithNpcManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerItemValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFondItemValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcItemValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcFondItemValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasTrading;

	private static readonly System.IntPtr NativeFieldInfoPtr__npc_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerTradingZone_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__npcTradingZone_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_npc_Public_Static_get_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_npc_Private_Static_set_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerTradingZone_Public_Static_get_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerTradingZone_Private_Static_set_Void_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_npcTradingZone_Public_Static_get_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_npcTradingZone_Private_Static_set_Void_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartTrading_Public_Static_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelTrading_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmTrading_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValueOffset_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppSystem.Decimal playerItemValue
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerItemValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerItemValue, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal playerFondItemValue
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerFondItemValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerFondItemValue, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal npcItemValue
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_npcItemValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_npcItemValue, (void*)(&obj));
		}
	}

	public unsafe static Il2CppSystem.Decimal npcFondItemValue
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_npcFondItemValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_npcFondItemValue, (void*)(&obj));
		}
	}

	public unsafe static bool hasTrading
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasTrading, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasTrading, (void*)(&flag));
		}
	}

	public unsafe static GameCharacterInstance _npc_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__npc_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__npc_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	public unsafe static GameItemPack _playerTradingZone_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__playerTradingZone_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__playerTradingZone_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe static GameItemPack _npcTradingZone_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__npcTradingZone_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__npcTradingZone_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack));
		}
	}

	public unsafe static GameCharacterInstance npc
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892904, XrefRangeEnd = 892908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_npc_Public_Static_get_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892908, XrefRangeEnd = 892912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_npc_Private_Static_set_Void_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static GameItemPack playerTradingZone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892912, XrefRangeEnd = 892916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerTradingZone_Public_Static_get_GameItemPack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892916, XrefRangeEnd = 892920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerTradingZone_Private_Static_set_Void_GameItemPack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static GameItemPack npcTradingZone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892920, XrefRangeEnd = 892924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_npcTradingZone_Public_Static_get_GameItemPack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemPack>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892924, XrefRangeEnd = 892928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_npcTradingZone_Private_Static_set_Void_GameItemPack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static TradingWithNpcManager()
	{
		Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "TradingWithNpcManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr);
		NativeFieldInfoPtr_playerItemValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "playerItemValue");
		NativeFieldInfoPtr_playerFondItemValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "playerFondItemValue");
		NativeFieldInfoPtr_npcItemValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "npcItemValue");
		NativeFieldInfoPtr_npcFondItemValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "npcFondItemValue");
		NativeFieldInfoPtr_hasTrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "hasTrading");
		NativeFieldInfoPtr__npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "<npc>k__BackingField");
		NativeFieldInfoPtr__playerTradingZone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "<playerTradingZone>k__BackingField");
		NativeFieldInfoPtr__npcTradingZone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, "<npcTradingZone>k__BackingField");
		NativeMethodInfoPtr_get_npc_Public_Static_get_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675175);
		NativeMethodInfoPtr_set_npc_Private_Static_set_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675176);
		NativeMethodInfoPtr_get_playerTradingZone_Public_Static_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675177);
		NativeMethodInfoPtr_set_playerTradingZone_Private_Static_set_Void_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675178);
		NativeMethodInfoPtr_get_npcTradingZone_Public_Static_get_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675179);
		NativeMethodInfoPtr_set_npcTradingZone_Private_Static_set_Void_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675180);
		NativeMethodInfoPtr_StartTrading_Public_Static_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675181);
		NativeMethodInfoPtr_CancelTrading_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675182);
		NativeMethodInfoPtr_ConfirmTrading_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675183);
		NativeMethodInfoPtr_ValueOffset_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675184);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr, 100675185);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 892996, RefRangeEnd = 892998, XrefRangeStart = 892928, XrefRangeEnd = 892996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartTrading(GameCharacterInstance other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartTrading_Public_Static_Void_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 893063, RefRangeEnd = 893065, XrefRangeStart = 892998, XrefRangeEnd = 893063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CancelTrading()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelTrading_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 893138, RefRangeEnd = 893139, XrefRangeStart = 893065, XrefRangeEnd = 893138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfirmTrading()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfirmTrading_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 893189, RefRangeEnd = 893191, XrefRangeStart = 893139, XrefRangeEnd = 893189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ValueOffset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValueOffset_Public_Static_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TradingWithNpcManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradingWithNpcManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TradingWithNpcManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
