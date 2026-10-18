using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class SaveObjectSlgData : SaveObjectBase
{
	public class ChronicleData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeFieldInfoPtr_paras;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChronicleType_Il2CppStructArray_1_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFormattedInfo_Private_String_ChronicleType_Il2CppStringArray_0;

		public unsafe ChronicleType type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(ChronicleType*)num;
			}
			set
			{
				*(ChronicleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = chronicleType;
			}
		}

		public unsafe int time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
			}
		}

		public unsafe Il2CppStructArray<int> paras
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paras);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paras)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static ChronicleData()
		{
			Il2CppClassPointerStore<ChronicleData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "ChronicleData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, "type");
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, "time");
			NativeFieldInfoPtr_paras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, "paras");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, 100688669);
			NativeMethodInfoPtr__ctor_Public_Void_ChronicleType_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, 100688670);
			NativeMethodInfoPtr_GetInfo_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, 100688671);
			NativeMethodInfoPtr_GetFormattedInfo_Private_String_ChronicleType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr, 100688672);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChronicleData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1010433, RefRangeEnd = 1010434, XrefRangeStart = 1010425, XrefRangeEnd = 1010433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChronicleData(ChronicleType type, [Optional] Il2CppStructArray<int> paras)
		{
			if (paras == null)
			{
				paras = new Il2CppStructArray<int>(0L);
			}
			this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChronicleData>.NativeClassPtr));
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&type);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ChronicleType_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1010582, RefRangeEnd = 1010583, XrefRangeStart = 1010434, XrefRangeEnd = 1010582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1010597, RefRangeEnd = 1010600, XrefRangeStart = 1010583, XrefRangeEnd = 1010597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFormattedInfo(ChronicleType type, [Optional] Il2CppStringArray paras)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected Obj, but got Unknown
			if (paras == null)
			{
				paras = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&type);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormattedInfo_Private_String_ChronicleType_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public ChronicleData(ChronicleType type, params int[] paras)
			: this(type, new Il2CppStructArray<int>(paras))
		{
		}

		public string GetFormattedInfo(ChronicleType type, params string[] paras)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected Obj, but got Unknown
			return GetFormattedInfo(type, new Il2CppStringArray(paras));
		}

		public ChronicleData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ChronicleType
	{
		MemberAdd = 0,
		MemberPromoted = 1,
		MemberLeaved = 2,
		ProvinceAdd = 10,
		ProvinceLost = 11,
		FactionEnemy = 20,
		FactionDefeated = 21,
		FactionTrading = 22,
		FactionTradingEnd = 23,
		FactionAllie = 24,
		FactionAllieEnd = 25,
		GameWin = 30,
		GameLose = 31
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_slgGameScript;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffcult;

	private static readonly System.IntPtr NativeFieldInfoPtr_turns;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSaveTurn;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFaction;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionActionOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_dlc1FactionInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_dlc1ProvinceInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_storyData;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskData;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterMarket;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCurrencyReceive;

	private static readonly System.IntPtr NativeFieldInfoPtr_chronicleDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedProvinces;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticProvinces;

	private static readonly System.IntPtr NativeFieldInfoPtr_customKungfuIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCurrencyReceive_Public_Void_GameItemPack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCurrencyReceive_Public_Void_CurrencyType_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterChronicleData_Public_Void_ChronicleType_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dlc1SlgManager.SlgGameScript slgGameScript
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgGameScript);
			return *(Dlc1SlgManager.SlgGameScript*)num;
		}
		set
		{
			*(Dlc1SlgManager.SlgGameScript*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slgGameScript)) = slgGameScript;
		}
	}

	public unsafe int diffcult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffcult);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffcult)) = num;
		}
	}

	public unsafe int turns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turns);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turns)) = num;
		}
	}

	public unsafe int lastSaveTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSaveTurn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSaveTurn)) = num;
		}
	}

	public unsafe int playerFaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFaction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFaction)) = num;
		}
	}

	public unsafe List<int> factionActionOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionActionOrder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionActionOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, Dlc1FactionInstance> dlc1FactionInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc1FactionInstances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Dlc1FactionInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc1FactionInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Dlc1ProvinceInstance> dlc1ProvinceInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc1ProvinceInstances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Dlc1ProvinceInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc1ProvinceInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe SlgStoryData storyData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storyData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgStoryData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storyData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgStoryData));
		}
	}

	public unsafe SlgTaskData taskData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgTaskData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgTaskData));
		}
	}

	public unsafe HashSet<int> characterMarket
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterMarket);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterMarket)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<CurrencyType, long> totalCurrencyReceive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCurrencyReceive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CurrencyType, long>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCurrencyReceive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<ChronicleData> chronicleDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chronicleDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChronicleData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chronicleDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<int> unlockedProvinces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedProvinces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedProvinces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> staticProvinces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticProvinces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticProvinces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe int customKungfuIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customKungfuIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customKungfuIndex)) = num;
		}
	}

	static SaveObjectSlgData()
	{
		Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectSlgData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr);
		NativeFieldInfoPtr_slgGameScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "slgGameScript");
		NativeFieldInfoPtr_diffcult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "diffcult");
		NativeFieldInfoPtr_turns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "turns");
		NativeFieldInfoPtr_lastSaveTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "lastSaveTurn");
		NativeFieldInfoPtr_playerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "playerFaction");
		NativeFieldInfoPtr_factionActionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "factionActionOrder");
		NativeFieldInfoPtr_dlc1FactionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "dlc1FactionInstances");
		NativeFieldInfoPtr_dlc1ProvinceInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "dlc1ProvinceInstances");
		NativeFieldInfoPtr_storyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "storyData");
		NativeFieldInfoPtr_taskData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "taskData");
		NativeFieldInfoPtr_characterMarket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "characterMarket");
		NativeFieldInfoPtr_totalCurrencyReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "totalCurrencyReceive");
		NativeFieldInfoPtr_chronicleDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "chronicleDatas");
		NativeFieldInfoPtr_unlockedProvinces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "unlockedProvinces");
		NativeFieldInfoPtr_staticProvinces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "staticProvinces");
		NativeFieldInfoPtr_customKungfuIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, "customKungfuIndex");
		NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, 100679712);
		NativeMethodInfoPtr_RegisterCurrencyReceive_Public_Void_GameItemPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, 100679713);
		NativeMethodInfoPtr_RegisterCurrencyReceive_Public_Void_CurrencyType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, 100679714);
		NativeMethodInfoPtr_RegisterChronicleData_Public_Void_ChronicleType_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, 100679715);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr, 100679716);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010600, XrefRangeEnd = 1010609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HashSet<GameDlcMode> GetValidSaveModes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValidSaveModes_Public_Virtual_HashSet_1_GameDlcMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameDlcMode>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1010640, RefRangeEnd = 1010641, XrefRangeStart = 1010609, XrefRangeEnd = 1010640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCurrencyReceive(GameItemPack gameItemPack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemPack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCurrencyReceive_Public_Void_GameItemPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010641, XrefRangeEnd = 1010650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCurrencyReceive(CurrencyType currencyType, long amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currencyType);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCurrencyReceive_Public_Void_CurrencyType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1010658, RefRangeEnd = 1010667, XrefRangeStart = 1010650, XrefRangeEnd = 1010658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterChronicleData(ChronicleType type, [Optional] Il2CppStructArray<int> paras)
	{
		if (paras == null)
		{
			paras = new Il2CppStructArray<int>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterChronicleData_Public_Void_ChronicleType_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010667, XrefRangeEnd = 1010714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectSlgData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectSlgData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public void RegisterChronicleData(ChronicleType type, params int[] paras)
	{
		RegisterChronicleData(type, new Il2CppStructArray<int>(paras));
	}

	public SaveObjectSlgData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
