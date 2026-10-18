using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin.StateMachine;

public static class DllStoryResultDelegate : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("WuLin.StateMachine.DllStoryResultDelegate+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__HunterStateNodeOnResultAction_b__8_0_Internal_Void_TalkToNpcCondition_0;

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

		public unsafe static Il2CppSystem.Action<TalkToNpcCondition> __9__8_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<TalkToNpcCondition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__8_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__8_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688990);
			NativeMethodInfoPtr__HunterStateNodeOnResultAction_b__8_0_Internal_Void_TalkToNpcCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688991);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040077, XrefRangeEnd = 1040085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HunterStateNodeOnResultAction_b__8_0(TalkToNpcCondition npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HunterStateNodeOnResultAction_b__8_0_Internal_Void_TalkToNpcCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllStoryResultDelegate+<>c__DisplayClass33_0")]
	public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ChangeItemsSelectNodeOnResultAction_b__0_Internal_Void_Int32_0;

		public unsafe ChangeItemsSelectNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeItemsSelectNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)changeItemsSelectNode));
			}
		}

		static __c__DisplayClass33_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, "<>c__DisplayClass33_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass33_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass33_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass33_0>.NativeClassPtr, 100688992);
			NativeMethodInfoPtr__ChangeItemsSelectNodeOnResultAction_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass33_0>.NativeClassPtr, 100688993);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass33_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass33_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040085, XrefRangeEnd = 1040086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ChangeItemsSelectNodeOnResultAction_b__0(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ChangeItemsSelectNodeOnResultAction_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass33_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldMapIconTopNodeOnResultAction_Private_Static_Void_WorldMapIconTopNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnLockRecipeNodeOnResultAction_Private_Static_Void_UnLockRecipeNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnLockRecipeNodeOnItemIDChangedAction_Private_Static_Void_UnLockRecipeNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldMapIconTopNodeOnWorldMapIDChangedAction_Private_Static_Void_WorldMapIconTopNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeGrowNodeOnResultAction_Private_Static_Void_TimeGrowNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryCloseNodeOnResultAction_Private_Static_Void_StoryCloseNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowLogNodeOnResultAction_Private_Static_Void_ShowLogNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HunterStateNodeOnResultAction_Private_Static_Void_HunterStateNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceNpcDeadNodeOnResultAction_Private_Static_Void_ForceNpcDeadNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionUniqueNpcDeadNodeOnResultAction_Private_Static_Void_FactionUniqueNpcDeadNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionNpcPropertyNodeOnResultAction_Private_Static_Void_FactionNpcPropertyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTeamPropertyNodeOnResultAction_Private_Static_Void_ChangeTeamPropertyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTagNumNodeOnResultAction_Private_Static_Void_ChangeTagNumNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRepNodeOnResultAction_Private_Static_Void_ChangeRepNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePropertyNodeChangeProperty_Private_Static_Void_ChangePropertyNode_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePropertyNodeOnResultAction_Private_Static_Void_ChangePropertyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePlayerPortaitNodeOnResultAction_Private_Static_Void_ChangePlayerPortaitNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePlayerAvatarNodeOnResultAction_Private_Static_Void_ChangePlayerAvatarNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePartnerNodeOnResultAction_Private_Static_Void_ChangePartnerNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcRelationNodeOnResultAction_Private_Static_Void_ChangeNpcRelationNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcMoneyNodeOnResultAction_Private_Static_Void_ChangeNpcMoneyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcItemNodeOnResultAction_Private_Static_Void_ChangeNpcItemNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcHomeNodeOnResultAction_Private_Static_Void_ChangeNpcHomeNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcFactionNodeOnResultAction_Private_Static_Void_ChangeNpcFactionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcExpNodeOnResultAction_Private_Static_Void_ChangeNpcExpNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorldMapID_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcDestinationNodeOnResultAction_Private_Static_Void_ChangeNpcDestinationNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNpcAffectionNodeOnResultAction_Private_Static_Void_ChangeNpcAffectionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMoneyNodeOnResultAction_Private_Static_Void_ChangeMoneyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeKungfuNodeOnResultAction_Private_Static_Void_ChangeKungfuNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeKungfuExpNodeOnResultAction_Private_Static_Void_ChangeKungfuExpNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeItemsSelectNodeOnSelectOk_Private_Static_Void_ChangeItemsSelectNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeItemsSelectNodeOnResultAction_Private_Static_Void_ChangeItemsSelectNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeItemNodeOnResultAction_Private_Static_Void_ChangeItemNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHpNodeModify_Private_Static_Void_ChangeHpNode_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHpNodeOnResultAction_Private_Static_Void_ChangeHpNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionNodeOnResultAction_Private_Static_Void_ChangeFactionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionFunctionNodeOnResultAction_Private_Static_Void_ChangeFactionFunctionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionFameNodeOnResultAction_Private_Static_Void_ChangeFactionFameNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeExpNodeOnResultAction_Private_Static_Void_ChangeExpNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeEpNodeModify_Private_Static_Void_ChangeEpNode_GameCharacterInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeEpNodeOnResultAction_Private_Static_Void_ChangeEpNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CabCancelNodeOnResultAction_Private_Static_Void_CabCancelNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CabIconVisibleNodeOnResultAction_Private_Static_Void_CabIconVisibleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBuffNodeOnResultAction_Private_Static_Void_ChangeBuffNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBuff_Private_Static_Void_ChangeBuffNode_GameCharacterInstance_0;

	static DllStoryResultDelegate()
	{
		Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "DllStoryResultDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681146);
		NativeMethodInfoPtr_WorldMapIconTopNodeOnResultAction_Private_Static_Void_WorldMapIconTopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681147);
		NativeMethodInfoPtr_UnLockRecipeNodeOnResultAction_Private_Static_Void_UnLockRecipeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681148);
		NativeMethodInfoPtr_UnLockRecipeNodeOnItemIDChangedAction_Private_Static_Void_UnLockRecipeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681149);
		NativeMethodInfoPtr_WorldMapIconTopNodeOnWorldMapIDChangedAction_Private_Static_Void_WorldMapIconTopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681150);
		NativeMethodInfoPtr_TimeGrowNodeOnResultAction_Private_Static_Void_TimeGrowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681151);
		NativeMethodInfoPtr_StoryCloseNodeOnResultAction_Private_Static_Void_StoryCloseNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681152);
		NativeMethodInfoPtr_ShowLogNodeOnResultAction_Private_Static_Void_ShowLogNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681153);
		NativeMethodInfoPtr_HunterStateNodeOnResultAction_Private_Static_Void_HunterStateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681154);
		NativeMethodInfoPtr_ForceNpcDeadNodeOnResultAction_Private_Static_Void_ForceNpcDeadNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681155);
		NativeMethodInfoPtr_FactionUniqueNpcDeadNodeOnResultAction_Private_Static_Void_FactionUniqueNpcDeadNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681156);
		NativeMethodInfoPtr_FactionNpcPropertyNodeOnResultAction_Private_Static_Void_FactionNpcPropertyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681157);
		NativeMethodInfoPtr_ChangeTeamPropertyNodeOnResultAction_Private_Static_Void_ChangeTeamPropertyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681158);
		NativeMethodInfoPtr_ChangeTagNumNodeOnResultAction_Private_Static_Void_ChangeTagNumNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681159);
		NativeMethodInfoPtr_ChangeRepNodeOnResultAction_Private_Static_Void_ChangeRepNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681160);
		NativeMethodInfoPtr_ChangePropertyNodeChangeProperty_Private_Static_Void_ChangePropertyNode_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681161);
		NativeMethodInfoPtr_ChangePropertyNodeOnResultAction_Private_Static_Void_ChangePropertyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681162);
		NativeMethodInfoPtr_ChangePlayerPortaitNodeOnResultAction_Private_Static_Void_ChangePlayerPortaitNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681163);
		NativeMethodInfoPtr_ChangePlayerAvatarNodeOnResultAction_Private_Static_Void_ChangePlayerAvatarNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681164);
		NativeMethodInfoPtr_ChangePartnerNodeOnResultAction_Private_Static_Void_ChangePartnerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681165);
		NativeMethodInfoPtr_ChangeNpcRelationNodeOnResultAction_Private_Static_Void_ChangeNpcRelationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681166);
		NativeMethodInfoPtr_ChangeNpcMoneyNodeOnResultAction_Private_Static_Void_ChangeNpcMoneyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681167);
		NativeMethodInfoPtr_ChangeNpcItemNodeOnResultAction_Private_Static_Void_ChangeNpcItemNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681168);
		NativeMethodInfoPtr_ChangeNpcHomeNodeOnResultAction_Private_Static_Void_ChangeNpcHomeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681169);
		NativeMethodInfoPtr_ChangeNpcFactionNodeOnResultAction_Private_Static_Void_ChangeNpcFactionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681170);
		NativeMethodInfoPtr_ChangeNpcExpNodeOnResultAction_Private_Static_Void_ChangeNpcExpNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681171);
		NativeMethodInfoPtr_IsWorldMapID_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681172);
		NativeMethodInfoPtr_ChangeNpcDestinationNodeOnResultAction_Private_Static_Void_ChangeNpcDestinationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681173);
		NativeMethodInfoPtr_ChangeNpcAffectionNodeOnResultAction_Private_Static_Void_ChangeNpcAffectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681174);
		NativeMethodInfoPtr_ChangeMoneyNodeOnResultAction_Private_Static_Void_ChangeMoneyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681175);
		NativeMethodInfoPtr_ChangeKungfuNodeOnResultAction_Private_Static_Void_ChangeKungfuNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681176);
		NativeMethodInfoPtr_ChangeKungfuExpNodeOnResultAction_Private_Static_Void_ChangeKungfuExpNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681177);
		NativeMethodInfoPtr_ChangeItemsSelectNodeOnSelectOk_Private_Static_Void_ChangeItemsSelectNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681178);
		NativeMethodInfoPtr_ChangeItemsSelectNodeOnResultAction_Private_Static_Void_ChangeItemsSelectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681179);
		NativeMethodInfoPtr_ChangeItemNodeOnResultAction_Private_Static_Void_ChangeItemNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681180);
		NativeMethodInfoPtr_ChangeHpNodeModify_Private_Static_Void_ChangeHpNode_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681181);
		NativeMethodInfoPtr_ChangeHpNodeOnResultAction_Private_Static_Void_ChangeHpNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681182);
		NativeMethodInfoPtr_ChangeFactionNodeOnResultAction_Private_Static_Void_ChangeFactionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681183);
		NativeMethodInfoPtr_ChangeFactionFunctionNodeOnResultAction_Private_Static_Void_ChangeFactionFunctionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681184);
		NativeMethodInfoPtr_ChangeFactionFameNodeOnResultAction_Private_Static_Void_ChangeFactionFameNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681185);
		NativeMethodInfoPtr_ChangeExpNodeOnResultAction_Private_Static_Void_ChangeExpNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681186);
		NativeMethodInfoPtr_ChangeEpNodeModify_Private_Static_Void_ChangeEpNode_GameCharacterInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681187);
		NativeMethodInfoPtr_ChangeEpNodeOnResultAction_Private_Static_Void_ChangeEpNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681188);
		NativeMethodInfoPtr_CabCancelNodeOnResultAction_Private_Static_Void_CabCancelNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681189);
		NativeMethodInfoPtr_CabIconVisibleNodeOnResultAction_Private_Static_Void_CabIconVisibleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681190);
		NativeMethodInfoPtr_ChangeBuffNodeOnResultAction_Private_Static_Void_ChangeBuffNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681191);
		NativeMethodInfoPtr_ChangeBuff_Private_Static_Void_ChangeBuffNode_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryResultDelegate>.NativeClassPtr, 100681192);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040408, RefRangeEnd = 1040409, XrefRangeStart = 1040086, XrefRangeEnd = 1040408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040409, XrefRangeEnd = 1040421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WorldMapIconTopNodeOnResultAction(WorldMapIconTopNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldMapIconTopNodeOnResultAction_Private_Static_Void_WorldMapIconTopNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040421, XrefRangeEnd = 1040429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnLockRecipeNodeOnResultAction(UnLockRecipeNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnLockRecipeNodeOnResultAction_Private_Static_Void_UnLockRecipeNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040429, XrefRangeEnd = 1040456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnLockRecipeNodeOnItemIDChangedAction(UnLockRecipeNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnLockRecipeNodeOnItemIDChangedAction_Private_Static_Void_UnLockRecipeNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040456, XrefRangeEnd = 1040477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WorldMapIconTopNodeOnWorldMapIDChangedAction(WorldMapIconTopNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldMapIconTopNodeOnWorldMapIDChangedAction_Private_Static_Void_WorldMapIconTopNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040477, XrefRangeEnd = 1040484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TimeGrowNodeOnResultAction(TimeGrowNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeGrowNodeOnResultAction_Private_Static_Void_TimeGrowNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040484, XrefRangeEnd = 1040508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoryCloseNodeOnResultAction(StoryCloseNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryCloseNodeOnResultAction_Private_Static_Void_StoryCloseNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040508, XrefRangeEnd = 1040521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowLogNodeOnResultAction(ShowLogNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowLogNodeOnResultAction_Private_Static_Void_ShowLogNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040521, XrefRangeEnd = 1040562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HunterStateNodeOnResultAction(HunterStateNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HunterStateNodeOnResultAction_Private_Static_Void_HunterStateNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040562, XrefRangeEnd = 1040611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForceNpcDeadNodeOnResultAction(ForceNpcDeadNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceNpcDeadNodeOnResultAction_Private_Static_Void_ForceNpcDeadNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040611, XrefRangeEnd = 1040623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FactionUniqueNpcDeadNodeOnResultAction(FactionUniqueNpcDeadNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionUniqueNpcDeadNodeOnResultAction_Private_Static_Void_FactionUniqueNpcDeadNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040623, XrefRangeEnd = 1040735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FactionNpcPropertyNodeOnResultAction(FactionNpcPropertyNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionNpcPropertyNodeOnResultAction_Private_Static_Void_FactionNpcPropertyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040735, XrefRangeEnd = 1040746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeTeamPropertyNodeOnResultAction(ChangeTeamPropertyNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTeamPropertyNodeOnResultAction_Private_Static_Void_ChangeTeamPropertyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040746, XrefRangeEnd = 1040761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeTagNumNodeOnResultAction(ChangeTagNumNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTagNumNodeOnResultAction_Private_Static_Void_ChangeTagNumNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040761, XrefRangeEnd = 1040772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeRepNodeOnResultAction(ChangeRepNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRepNodeOnResultAction_Private_Static_Void_ChangeRepNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040792, RefRangeEnd = 1040793, XrefRangeStart = 1040772, XrefRangeEnd = 1040792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangePropertyNodeChangeProperty(ChangePropertyNode self, GameCharacterInstance chara)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chara);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePropertyNodeChangeProperty_Private_Static_Void_ChangePropertyNode_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040793, XrefRangeEnd = 1040838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangePropertyNodeOnResultAction(ChangePropertyNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePropertyNodeOnResultAction_Private_Static_Void_ChangePropertyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040838, XrefRangeEnd = 1040862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangePlayerPortaitNodeOnResultAction(ChangePlayerPortaitNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePlayerPortaitNodeOnResultAction_Private_Static_Void_ChangePlayerPortaitNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040862, XrefRangeEnd = 1040889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangePlayerAvatarNodeOnResultAction(ChangePlayerAvatarNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePlayerAvatarNodeOnResultAction_Private_Static_Void_ChangePlayerAvatarNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040889, XrefRangeEnd = 1040924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangePartnerNodeOnResultAction(ChangePartnerNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePartnerNodeOnResultAction_Private_Static_Void_ChangePartnerNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040924, XrefRangeEnd = 1040943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcRelationNodeOnResultAction(ChangeNpcRelationNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcRelationNodeOnResultAction_Private_Static_Void_ChangeNpcRelationNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040943, XrefRangeEnd = 1040959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcMoneyNodeOnResultAction(ChangeNpcMoneyNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcMoneyNodeOnResultAction_Private_Static_Void_ChangeNpcMoneyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040959, XrefRangeEnd = 1040975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcItemNodeOnResultAction(ChangeNpcItemNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcItemNodeOnResultAction_Private_Static_Void_ChangeNpcItemNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040975, XrefRangeEnd = 1040983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcHomeNodeOnResultAction(ChangeNpcHomeNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcHomeNodeOnResultAction_Private_Static_Void_ChangeNpcHomeNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040983, XrefRangeEnd = 1040999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcFactionNodeOnResultAction(ChangeNpcFactionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcFactionNodeOnResultAction_Private_Static_Void_ChangeNpcFactionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040999, XrefRangeEnd = 1041020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcExpNodeOnResultAction(ChangeNpcExpNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcExpNodeOnResultAction_Private_Static_Void_ChangeNpcExpNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041020, XrefRangeEnd = 1041024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWorldMapID(int mapID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorldMapID_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041024, XrefRangeEnd = 1041205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcDestinationNodeOnResultAction(ChangeNpcDestinationNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcDestinationNodeOnResultAction_Private_Static_Void_ChangeNpcDestinationNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041205, XrefRangeEnd = 1041239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeNpcAffectionNodeOnResultAction(ChangeNpcAffectionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeNpcAffectionNodeOnResultAction_Private_Static_Void_ChangeNpcAffectionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041239, XrefRangeEnd = 1041267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeMoneyNodeOnResultAction(ChangeMoneyNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMoneyNodeOnResultAction_Private_Static_Void_ChangeMoneyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041267, XrefRangeEnd = 1041288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeKungfuNodeOnResultAction(ChangeKungfuNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeKungfuNodeOnResultAction_Private_Static_Void_ChangeKungfuNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041288, XrefRangeEnd = 1041299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeKungfuExpNodeOnResultAction(ChangeKungfuExpNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeKungfuExpNodeOnResultAction_Private_Static_Void_ChangeKungfuExpNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1041320, RefRangeEnd = 1041321, XrefRangeStart = 1041299, XrefRangeEnd = 1041320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeItemsSelectNodeOnSelectOk(ChangeItemsSelectNode self, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeItemsSelectNodeOnSelectOk_Private_Static_Void_ChangeItemsSelectNode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041321, XrefRangeEnd = 1041394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeItemsSelectNodeOnResultAction(ChangeItemsSelectNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeItemsSelectNodeOnResultAction_Private_Static_Void_ChangeItemsSelectNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041394, XrefRangeEnd = 1041406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeItemNodeOnResultAction(ChangeItemNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeItemNodeOnResultAction_Private_Static_Void_ChangeItemNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1041442, RefRangeEnd = 1041444, XrefRangeStart = 1041406, XrefRangeEnd = 1041442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeHpNodeModify(ChangeHpNode self, GameCharacterInstance chara, bool hasLog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chara);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHpNodeModify_Private_Static_Void_ChangeHpNode_GameCharacterInstance_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041444, XrefRangeEnd = 1041511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeHpNodeOnResultAction(ChangeHpNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHpNodeOnResultAction_Private_Static_Void_ChangeHpNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041511, XrefRangeEnd = 1041518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionNodeOnResultAction(ChangeFactionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionNodeOnResultAction_Private_Static_Void_ChangeFactionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041518, XrefRangeEnd = 1041526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionFunctionNodeOnResultAction(ChangeFactionFunctionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionFunctionNodeOnResultAction_Private_Static_Void_ChangeFactionFunctionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041526, XrefRangeEnd = 1041539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionFameNodeOnResultAction(ChangeFactionFameNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionFameNodeOnResultAction_Private_Static_Void_ChangeFactionFameNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041539, XrefRangeEnd = 1041547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeExpNodeOnResultAction(ChangeExpNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeExpNodeOnResultAction_Private_Static_Void_ChangeExpNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1041583, RefRangeEnd = 1041585, XrefRangeStart = 1041547, XrefRangeEnd = 1041583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeEpNodeModify(ChangeEpNode self, GameCharacterInstance chara, bool hasLog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chara);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasLog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeEpNodeModify_Private_Static_Void_ChangeEpNode_GameCharacterInstance_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041585, XrefRangeEnd = 1041652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeEpNodeOnResultAction(ChangeEpNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeEpNodeOnResultAction_Private_Static_Void_ChangeEpNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041652, XrefRangeEnd = 1041663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CabCancelNodeOnResultAction(CabCancelNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CabCancelNodeOnResultAction_Private_Static_Void_CabCancelNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041663, XrefRangeEnd = 1041675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CabIconVisibleNodeOnResultAction(CabIconVisibleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CabIconVisibleNodeOnResultAction_Private_Static_Void_CabIconVisibleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041675, XrefRangeEnd = 1041735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeBuffNodeOnResultAction(ChangeBuffNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBuffNodeOnResultAction_Private_Static_Void_ChangeBuffNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041735, XrefRangeEnd = 1041736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeBuff(ChangeBuffNode self, GameCharacterInstance partner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)partner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBuff_Private_Static_Void_ChangeBuffNode_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DllStoryResultDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
