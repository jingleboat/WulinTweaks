using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using XNode;

namespace WuLin.StateMachine;

public static class DllStoryHappenDelegate : Il2CppSystem.Object
{
	[ObfuscatedName("WuLin.StateMachine.DllStoryHappenDelegate+<>c__DisplayClass16_0")]
	public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ItemPrizeSelectNodeOnActiveAction_b__0_Internal_Void_Int32_0;

		public unsafe ItemPrizeSelectNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemPrizeSelectNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemPrizeSelectNode));
			}
		}

		static __c__DisplayClass16_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass16_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, 100688981);
			NativeMethodInfoPtr__ItemPrizeSelectNodeOnActiveAction_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, 100688982);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass16_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039079, XrefRangeEnd = 1039080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ItemPrizeSelectNodeOnActiveAction_b__0(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ItemPrizeSelectNodeOnActiveAction_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass16_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllStoryHappenDelegate+<>c__DisplayClass20_0")]
	public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RestoreRelationNodeOnActiveAction_b__0_Internal_Void_Il2CppReferenceArray_1_Object_0;

		public unsafe RestoreRelationNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RestoreRelationNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)restoreRelationNode));
			}
		}

		static __c__DisplayClass20_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass20_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, 100688983);
			NativeMethodInfoPtr__RestoreRelationNodeOnActiveAction_b__0_Internal_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, 100688984);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass20_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039080, XrefRangeEnd = 1039105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RestoreRelationNodeOnActiveAction_b__0(Il2CppReferenceArray<Il2CppSystem.Object> param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RestoreRelationNodeOnActiveAction_b__0_Internal_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass20_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllStoryHappenDelegate+<>c__DisplayClass21_0")]
	public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowUIBondsNodeOnActiveAction_b__0_Internal_Void_Il2CppReferenceArray_1_Object_0;

		public unsafe ShowUIBondsNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowUIBondsNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showUIBondsNode));
			}
		}

		static __c__DisplayClass21_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass21_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100688985);
			NativeMethodInfoPtr__ShowUIBondsNodeOnActiveAction_b__0_Internal_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100688986);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass21_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039105, XrefRangeEnd = 1039130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowUIBondsNodeOnActiveAction_b__0(Il2CppReferenceArray<Il2CppSystem.Object> param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowUIBondsNodeOnActiveAction_b__0_Internal_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass21_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllStoryHappenDelegate+<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TutorialNodeOnActiveAction_b__0_Internal_Void_0;

		public unsafe TutorialNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TutorialNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tutorialNode));
			}
		}

		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100688987);
			NativeMethodInfoPtr__TutorialNodeOnActiveAction_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100688988);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass27_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039130, XrefRangeEnd = 1039135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TutorialNodeOnActiveAction_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TutorialNodeOnActiveAction_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass27_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewsNodeOnActiveAction_Private_Static_Void_AddNewsNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTipNodeOnActiveAction_Private_Static_Void_AddTipNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AffectionActiveNodeOnActiveAction_Private_Static_Void_AffectionActiveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AuctionNodeOnActiveAction_Private_Static_Void_AuctionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AuctionResetItemNodeOnActiveAction_Private_Static_Void_AuctionResetItemNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceTextDialogNodeOnActiveAction_Private_Static_Node_ChoiceTextDialogNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompetitionFightNodeOnActiveAction_Private_Static_Void_CompetitionFightNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CustomFightNodeOnActiveAction_Private_Static_Void_CustomFightNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DuelFightNodeOnActiveAction_Private_Static_Void_DuelFightNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayVideoNodeOnActiveAction_Private_Static_Void_PlayVideoNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FightNodeOnActiveAction_Private_Static_Void_FightNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HoldNodeHoldAction_Private_Static_Void_HoldNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HoldNodeTrySendResultAction_Private_Static_Void_HoldNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HoldNodeContinueAction_Private_Static_Void_HoldNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemPrizeSelectNodeOnSelectOk_Private_Static_Void_ItemPrizeSelectNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemPrizeSelectNodeOnActiveAction_Private_Static_Void_ItemPrizeSelectNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NoteActiveNodeOnActiveAction_Private_Static_Void_NoteActiveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomNodeOnActiveAction_Private_Static_Node_RandomNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStringNodeOnActiveAction_Private_Static_Void_RemoveStringNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreRelationNodeOnActiveAction_Private_Static_Void_RestoreRelationNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowUIBondsNodeOnActiveAction_Private_Static_Void_ShowUIBondsNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SicBoNodeOnActiveAction_Private_Static_Void_SicBoNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SolveRiddlesNodeOnActiveAction_Private_Static_Void_SolveRiddlesNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryScenarioNodeOnActiveAction_Private_Static_Void_StoryScenarioNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeLimitCancelNodeOnActiveAction_Private_Static_Void_TimeLimitCancelNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeLimitNodeOnActiveAction_Private_Static_Void_TimeLimitNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TutorialNodeOnActiveAction_Private_Static_Void_TutorialNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteHearsayNodeOnActiveAction_Private_Static_Void_WriteHearsayNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteStringNodeOnActiveAction_Private_Static_Void_WriteStringNode_0;

	static DllStoryHappenDelegate()
	{
		Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "DllStoryHappenDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681116);
		NativeMethodInfoPtr_AddNewsNodeOnActiveAction_Private_Static_Void_AddNewsNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681117);
		NativeMethodInfoPtr_AddTipNodeOnActiveAction_Private_Static_Void_AddTipNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681118);
		NativeMethodInfoPtr_AffectionActiveNodeOnActiveAction_Private_Static_Void_AffectionActiveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681119);
		NativeMethodInfoPtr_AuctionNodeOnActiveAction_Private_Static_Void_AuctionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681120);
		NativeMethodInfoPtr_AuctionResetItemNodeOnActiveAction_Private_Static_Void_AuctionResetItemNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681121);
		NativeMethodInfoPtr_ChoiceTextDialogNodeOnActiveAction_Private_Static_Node_ChoiceTextDialogNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681122);
		NativeMethodInfoPtr_CompetitionFightNodeOnActiveAction_Private_Static_Void_CompetitionFightNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681123);
		NativeMethodInfoPtr_CustomFightNodeOnActiveAction_Private_Static_Void_CustomFightNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681124);
		NativeMethodInfoPtr_DuelFightNodeOnActiveAction_Private_Static_Void_DuelFightNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681125);
		NativeMethodInfoPtr_PlayVideoNodeOnActiveAction_Private_Static_Void_PlayVideoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681126);
		NativeMethodInfoPtr_FightNodeOnActiveAction_Private_Static_Void_FightNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681127);
		NativeMethodInfoPtr_HoldNodeHoldAction_Private_Static_Void_HoldNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681128);
		NativeMethodInfoPtr_HoldNodeTrySendResultAction_Private_Static_Void_HoldNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681129);
		NativeMethodInfoPtr_HoldNodeContinueAction_Private_Static_Void_HoldNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681130);
		NativeMethodInfoPtr_ItemPrizeSelectNodeOnSelectOk_Private_Static_Void_ItemPrizeSelectNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681131);
		NativeMethodInfoPtr_ItemPrizeSelectNodeOnActiveAction_Private_Static_Void_ItemPrizeSelectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681132);
		NativeMethodInfoPtr_NoteActiveNodeOnActiveAction_Private_Static_Void_NoteActiveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681133);
		NativeMethodInfoPtr_RandomNodeOnActiveAction_Private_Static_Node_RandomNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681134);
		NativeMethodInfoPtr_RemoveStringNodeOnActiveAction_Private_Static_Void_RemoveStringNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681135);
		NativeMethodInfoPtr_RestoreRelationNodeOnActiveAction_Private_Static_Void_RestoreRelationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681136);
		NativeMethodInfoPtr_ShowUIBondsNodeOnActiveAction_Private_Static_Void_ShowUIBondsNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681137);
		NativeMethodInfoPtr_SicBoNodeOnActiveAction_Private_Static_Void_SicBoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681138);
		NativeMethodInfoPtr_SolveRiddlesNodeOnActiveAction_Private_Static_Void_SolveRiddlesNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681139);
		NativeMethodInfoPtr_StoryScenarioNodeOnActiveAction_Private_Static_Void_StoryScenarioNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681140);
		NativeMethodInfoPtr_TimeLimitCancelNodeOnActiveAction_Private_Static_Void_TimeLimitCancelNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681141);
		NativeMethodInfoPtr_TimeLimitNodeOnActiveAction_Private_Static_Void_TimeLimitNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681142);
		NativeMethodInfoPtr_TutorialNodeOnActiveAction_Private_Static_Void_TutorialNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681143);
		NativeMethodInfoPtr_WriteHearsayNodeOnActiveAction_Private_Static_Void_WriteHearsayNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681144);
		NativeMethodInfoPtr_WriteStringNodeOnActiveAction_Private_Static_Void_WriteStringNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllStoryHappenDelegate>.NativeClassPtr, 100681145);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039361, RefRangeEnd = 1039362, XrefRangeStart = 1039135, XrefRangeEnd = 1039361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039362, XrefRangeEnd = 1039370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddNewsNodeOnActiveAction(AddNewsNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewsNodeOnActiveAction_Private_Static_Void_AddNewsNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039370, XrefRangeEnd = 1039382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddTipNodeOnActiveAction(AddTipNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTipNodeOnActiveAction_Private_Static_Void_AddTipNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039382, XrefRangeEnd = 1039397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AffectionActiveNodeOnActiveAction(AffectionActiveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AffectionActiveNodeOnActiveAction_Private_Static_Void_AffectionActiveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039397, XrefRangeEnd = 1039415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AuctionNodeOnActiveAction(AuctionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AuctionNodeOnActiveAction_Private_Static_Void_AuctionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039415, XrefRangeEnd = 1039423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AuctionResetItemNodeOnActiveAction(AuctionResetItemNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AuctionResetItemNodeOnActiveAction_Private_Static_Void_AuctionResetItemNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039423, XrefRangeEnd = 1039452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Node ChoiceTextDialogNodeOnActiveAction(ChoiceTextDialogNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChoiceTextDialogNodeOnActiveAction_Private_Static_Node_ChoiceTextDialogNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Node>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039452, XrefRangeEnd = 1039479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompetitionFightNodeOnActiveAction(CompetitionFightNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompetitionFightNodeOnActiveAction_Private_Static_Void_CompetitionFightNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039479, XrefRangeEnd = 1039539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CustomFightNodeOnActiveAction(CustomFightNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CustomFightNodeOnActiveAction_Private_Static_Void_CustomFightNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039539, XrefRangeEnd = 1039575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DuelFightNodeOnActiveAction(DuelFightNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DuelFightNodeOnActiveAction_Private_Static_Void_DuelFightNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039575, XrefRangeEnd = 1039605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayVideoNodeOnActiveAction(PlayVideoNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayVideoNodeOnActiveAction_Private_Static_Void_PlayVideoNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039605, XrefRangeEnd = 1039645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FightNodeOnActiveAction(FightNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FightNodeOnActiveAction_Private_Static_Void_FightNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039645, XrefRangeEnd = 1039656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HoldNodeHoldAction(HoldNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HoldNodeHoldAction_Private_Static_Void_HoldNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039656, XrefRangeEnd = 1039667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HoldNodeTrySendResultAction(HoldNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HoldNodeTrySendResultAction_Private_Static_Void_HoldNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039667, XrefRangeEnd = 1039675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HoldNodeContinueAction(HoldNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HoldNodeContinueAction_Private_Static_Void_HoldNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039698, RefRangeEnd = 1039699, XrefRangeStart = 1039675, XrefRangeEnd = 1039698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ItemPrizeSelectNodeOnSelectOk(ItemPrizeSelectNode self, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemPrizeSelectNodeOnSelectOk_Private_Static_Void_ItemPrizeSelectNode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039699, XrefRangeEnd = 1039780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ItemPrizeSelectNodeOnActiveAction(ItemPrizeSelectNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemPrizeSelectNodeOnActiveAction_Private_Static_Void_ItemPrizeSelectNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039780, XrefRangeEnd = 1039792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NoteActiveNodeOnActiveAction(NoteActiveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NoteActiveNodeOnActiveAction_Private_Static_Void_NoteActiveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039792, XrefRangeEnd = 1039821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Node RandomNodeOnActiveAction(RandomNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomNodeOnActiveAction_Private_Static_Node_RandomNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Node>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039821, XrefRangeEnd = 1039829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveStringNodeOnActiveAction(RemoveStringNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveStringNodeOnActiveAction_Private_Static_Void_RemoveStringNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039829, XrefRangeEnd = 1039866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RestoreRelationNodeOnActiveAction(RestoreRelationNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreRelationNodeOnActiveAction_Private_Static_Void_RestoreRelationNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039866, XrefRangeEnd = 1039904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowUIBondsNodeOnActiveAction(ShowUIBondsNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowUIBondsNodeOnActiveAction_Private_Static_Void_ShowUIBondsNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039904, XrefRangeEnd = 1039922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SicBoNodeOnActiveAction(SicBoNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SicBoNodeOnActiveAction_Private_Static_Void_SicBoNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039922, XrefRangeEnd = 1039944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SolveRiddlesNodeOnActiveAction(SolveRiddlesNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SolveRiddlesNodeOnActiveAction_Private_Static_Void_SolveRiddlesNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039944, XrefRangeEnd = 1039965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoryScenarioNodeOnActiveAction(StoryScenarioNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryScenarioNodeOnActiveAction_Private_Static_Void_StoryScenarioNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039965, XrefRangeEnd = 1039977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TimeLimitCancelNodeOnActiveAction(TimeLimitCancelNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeLimitCancelNodeOnActiveAction_Private_Static_Void_TimeLimitCancelNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039977, XrefRangeEnd = 1039995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TimeLimitNodeOnActiveAction(TimeLimitNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeLimitNodeOnActiveAction_Private_Static_Void_TimeLimitNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039995, XrefRangeEnd = 1040061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TutorialNodeOnActiveAction(TutorialNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialNodeOnActiveAction_Private_Static_Void_TutorialNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040061, XrefRangeEnd = 1040069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteHearsayNodeOnActiveAction(WriteHearsayNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteHearsayNodeOnActiveAction_Private_Static_Void_WriteHearsayNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040069, XrefRangeEnd = 1040077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteStringNodeOnActiveAction(WriteStringNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteStringNodeOnActiveAction_Private_Static_Void_WriteStringNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DllStoryHappenDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
