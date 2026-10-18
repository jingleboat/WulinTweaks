using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class FiefData : SerializedScriptableObject
{
	public class CostItemConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_itemID;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemNum;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int itemID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemID)) = num;
			}
		}

		public unsafe int itemNum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemNum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemNum)) = num;
			}
		}

		static CostItemConfig()
		{
			Il2CppClassPointerStore<CostItemConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefData>.NativeClassPtr, "CostItemConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CostItemConfig>.NativeClassPtr);
			NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostItemConfig>.NativeClassPtr, "itemID");
			NativeFieldInfoPtr_itemNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostItemConfig>.NativeClassPtr, "itemNum");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostItemConfig>.NativeClassPtr, 100687251);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CostItemConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CostItemConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CostItemConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class FiefBuilding : Il2CppSystem.Object
	{
		public class LevelConfig : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_costMoney;

			private static readonly System.IntPtr NativeFieldInfoPtr_costItemConfig;

			private static readonly System.IntPtr NativeFieldInfoPtr_costNeedNpcID;

			private static readonly System.IntPtr NativeFieldInfoPtr_maxNpcCount;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe int costMoney
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costMoney);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costMoney)) = num;
				}
			}

			public unsafe List<CostItemConfig> costItemConfig
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costItemConfig);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CostItemConfig>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costItemConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
				}
			}

			public unsafe int costNeedNpcID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costNeedNpcID);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costNeedNpcID)) = num;
				}
			}

			public unsafe int maxNpcCount
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNpcCount);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNpcCount)) = num;
				}
			}

			static LevelConfig()
			{
				Il2CppClassPointerStore<LevelConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "LevelConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr);
				NativeFieldInfoPtr_costMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr, "costMoney");
				NativeFieldInfoPtr_costItemConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr, "costItemConfig");
				NativeFieldInfoPtr_costNeedNpcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr, "costNeedNpcID");
				NativeFieldInfoPtr_maxNpcCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr, "maxNpcCount");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr, 100689754);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866793, XrefRangeEnd = 866800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LevelConfig()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelConfig>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public LevelConfig(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class MiningConfig : LevelConfig
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_unlockInteractiveSaveID;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe int unlockInteractiveSaveID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockInteractiveSaveID);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockInteractiveSaveID)) = num;
				}
			}

			static MiningConfig()
			{
				Il2CppClassPointerStore<MiningConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "MiningConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiningConfig>.NativeClassPtr);
				NativeFieldInfoPtr_unlockInteractiveSaveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiningConfig>.NativeClassPtr, "unlockInteractiveSaveID");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiningConfig>.NativeClassPtr, 100689755);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MiningConfig()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiningConfig>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public MiningConfig(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class ScorePrize : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_targetScore;

			private static readonly System.IntPtr NativeFieldInfoPtr_buffID;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe int targetScore
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetScore);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetScore)) = num;
				}
			}

			public unsafe int buffID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffID);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffID)) = num;
				}
			}

			static ScorePrize()
			{
				Il2CppClassPointerStore<ScorePrize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "ScorePrize");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScorePrize>.NativeClassPtr);
				NativeFieldInfoPtr_targetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScorePrize>.NativeClassPtr, "targetScore");
				NativeFieldInfoPtr_buffID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScorePrize>.NativeClassPtr, "buffID");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScorePrize>.NativeClassPtr, 100689756);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 695163, RefRangeEnd = 695164, XrefRangeStart = 695163, XrefRangeEnd = 695164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScorePrize()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScorePrize>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public ScorePrize(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class ScoreNpcBest : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_npc;

			private static readonly System.IntPtr NativeFieldInfoPtr_GainRatio;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe Il2CppStructArray<int> npc
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npc);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
				}
			}

			public unsafe float GainRatio
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GainRatio);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GainRatio)) = num;
				}
			}

			static ScoreNpcBest()
			{
				Il2CppClassPointerStore<ScoreNpcBest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "ScoreNpcBest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScoreNpcBest>.NativeClassPtr);
				NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreNpcBest>.NativeClassPtr, "npc");
				NativeFieldInfoPtr_GainRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreNpcBest>.NativeClassPtr, "GainRatio");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreNpcBest>.NativeClassPtr, 100689757);
			}

			[CallerCount(2961)]
			[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScoreNpcBest()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScoreNpcBest>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public ScoreNpcBest(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_fiefBuildingType;

		private static readonly System.IntPtr NativeFieldInfoPtr_toMapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_toPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_toDir;

		private static readonly System.IntPtr NativeFieldInfoPtr_levelConfig;

		private static readonly System.IntPtr NativeFieldInfoPtr_scoreProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_scorePer;

		private static readonly System.IntPtr NativeFieldInfoPtr_scoreConfig;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FiefBuildingType fiefBuildingType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefBuildingType);
				return *(FiefBuildingType*)num;
			}
			set
			{
				*(FiefBuildingType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiefBuildingType)) = fiefBuildingType;
			}
		}

		public unsafe int toMapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toMapID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toMapID)) = num;
			}
		}

		public unsafe Vector3 toPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toPos)) = vector;
			}
		}

		public unsafe TileDirection toDir
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toDir);
				return *(TileDirection*)num;
			}
			set
			{
				*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toDir)) = tileDirection;
			}
		}

		public unsafe List<LevelConfig> levelConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelConfig);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LevelConfig>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string scoreProperty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreProperty);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreProperty)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int scorePer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scorePer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scorePer)) = num;
			}
		}

		public unsafe List<ScorePrize> scoreConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreConfig);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScorePrize>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static FiefBuilding()
		{
			Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FiefData>.NativeClassPtr, "FiefBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr);
			NativeFieldInfoPtr_fiefBuildingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "fiefBuildingType");
			NativeFieldInfoPtr_toMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "toMapID");
			NativeFieldInfoPtr_toPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "toPos");
			NativeFieldInfoPtr_toDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "toDir");
			NativeFieldInfoPtr_levelConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "levelConfig");
			NativeFieldInfoPtr_scoreProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "scoreProperty");
			NativeFieldInfoPtr_scorePer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "scorePer");
			NativeFieldInfoPtr_scoreConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, "scoreConfig");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr, 100687252);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866800, XrefRangeEnd = 866816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FiefBuilding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FiefBuilding>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FiefBuilding(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_listBuilding;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<FiefBuilding> listBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listBuilding);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FiefBuilding>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listBuilding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static FiefData()
	{
		Il2CppClassPointerStore<FiefData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "FiefData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FiefData>.NativeClassPtr);
		NativeFieldInfoPtr_listBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FiefData>.NativeClassPtr, "listBuilding");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FiefData>.NativeClassPtr, 100674367);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866816, XrefRangeEnd = 866823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FiefData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FiefData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FiefData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
