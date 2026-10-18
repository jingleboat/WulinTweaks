using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using XNode;

namespace WuLin.StateMachine;

public static class SlgStoryHappenDelegate : Il2CppSystem.Object
{
	[ObfuscatedName("WuLin.StateMachine.SlgStoryHappenDelegate+<>c__DisplayClass1_0")]
	public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ChangeBossNameNodeNodeOnActiveAction_b__0_Internal_Void_String_String_0;

		public unsafe ChangeBossNameNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeBossNameNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)changeBossNameNode));
			}
		}

		static __c__DisplayClass1_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass1_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100689032);
			NativeMethodInfoPtr__ChangeBossNameNodeNodeOnActiveAction_b__0_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100689033);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass1_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042507, XrefRangeEnd = 1042512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ChangeBossNameNodeNodeOnActiveAction_b__0(string a, string b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(b);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ChangeBossNameNodeNodeOnActiveAction_b__0_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass1_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.SlgStoryHappenDelegate+<>c__DisplayClass2_0")]
	public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SendLogNodeOnActiveAction_b__0_Internal_Void_0;

		public unsafe SendLogNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SendLogNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sendLogNode));
			}
		}

		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass2_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100689034);
			NativeMethodInfoPtr__SendLogNodeOnActiveAction_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100689035);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042512, XrefRangeEnd = 1042517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SendLogNodeOnActiveAction_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SendLogNodeOnActiveAction_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass2_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.SlgStoryHappenDelegate+<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateFactionNodeOnActiveAction_b__0_Internal_Void_0;

		public unsafe CreateFactionNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CreateFactionNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createFactionNode));
			}
		}

		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100689036);
			NativeMethodInfoPtr__CreateFactionNodeOnActiveAction_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100689037);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042517, XrefRangeEnd = 1042522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateFactionNodeOnActiveAction_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateFactionNodeOnActiveAction_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass3_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.SlgStoryHappenDelegate+<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ChangeFactionNameNodeOnActiveAction_b__0_Internal_Void_String_0;

		public unsafe ChangeFactionNameNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeFactionNameNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)changeFactionNameNode));
			}
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100689038);
			NativeMethodInfoPtr__ChangeFactionNameNodeOnActiveAction_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100689039);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042522, XrefRangeEnd = 1042527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ChangeFactionNameNodeOnActiveAction_b__0(string a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ChangeFactionNameNodeOnActiveAction_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass4_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.SlgStoryHappenDelegate+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTutorialNodeOnActiveAction_b__0_Internal_Void_0;

		public unsafe SlgTutorialNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgTutorialNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgTutorialNode));
			}
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100689040);
			NativeMethodInfoPtr__SlgTutorialNodeOnActiveAction_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100689041);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042527, XrefRangeEnd = 1042532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTutorialNodeOnActiveAction_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTutorialNodeOnActiveAction_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass5_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBossNameNodeNodeOnActiveAction_Private_Static_Void_ChangeBossNameNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendLogNodeOnActiveAction_Private_Static_Void_SendLogNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFactionNodeOnActiveAction_Private_Static_Void_CreateFactionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionNameNodeOnActiveAction_Private_Static_Void_ChangeFactionNameNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgTutorialNodeOnActiveAction_Private_Static_Void_SlgTutorialNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CustomFightNodeOnActiveAction_Private_Static_Void_SlgCustomFightNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DlcUniversalBattletNodeOnActiveAction_Private_Static_Void_DlcUniversalBattleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeLimitNodeOnActiveAction_Private_Static_Void_TimeLimitNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomNodeOnActiveAction_Private_Static_Node_RandomNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceTextDialogNodeOnActiveAction_Private_Static_Node_ChoiceTextDialogNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteStringNodeOnActiveAction_Private_Static_Void_WriteStringNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStringNodeOnActiveAction_Private_Static_Void_RemoveStringNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HoldNodeHoldAction_Private_Static_Void_SlgHoldNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HoldNodeTrySendResultAction_Private_Static_Void_SlgHoldNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HoldNodeContinueAction_Private_Static_Void_SlgHoldNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TaskNodeOnActiveAction_Private_Static_Void_TaskNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTaskCondition_Private_Static_Boolean_NodePort_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoryScenarioNodeOnActiveAction_Private_Static_Void_StoryScenarioNode_0;

	static SlgStoryHappenDelegate()
	{
		Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "SlgStoryHappenDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681262);
		NativeMethodInfoPtr_ChangeBossNameNodeNodeOnActiveAction_Private_Static_Void_ChangeBossNameNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681263);
		NativeMethodInfoPtr_SendLogNodeOnActiveAction_Private_Static_Void_SendLogNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681264);
		NativeMethodInfoPtr_CreateFactionNodeOnActiveAction_Private_Static_Void_CreateFactionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681265);
		NativeMethodInfoPtr_ChangeFactionNameNodeOnActiveAction_Private_Static_Void_ChangeFactionNameNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681266);
		NativeMethodInfoPtr_SlgTutorialNodeOnActiveAction_Private_Static_Void_SlgTutorialNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681267);
		NativeMethodInfoPtr_CustomFightNodeOnActiveAction_Private_Static_Void_SlgCustomFightNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681268);
		NativeMethodInfoPtr_DlcUniversalBattletNodeOnActiveAction_Private_Static_Void_DlcUniversalBattleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681269);
		NativeMethodInfoPtr_TimeLimitNodeOnActiveAction_Private_Static_Void_TimeLimitNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681270);
		NativeMethodInfoPtr_RandomNodeOnActiveAction_Private_Static_Node_RandomNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681271);
		NativeMethodInfoPtr_ChoiceTextDialogNodeOnActiveAction_Private_Static_Node_ChoiceTextDialogNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681272);
		NativeMethodInfoPtr_WriteStringNodeOnActiveAction_Private_Static_Void_WriteStringNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681273);
		NativeMethodInfoPtr_RemoveStringNodeOnActiveAction_Private_Static_Void_RemoveStringNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681274);
		NativeMethodInfoPtr_HoldNodeHoldAction_Private_Static_Void_SlgHoldNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681275);
		NativeMethodInfoPtr_HoldNodeTrySendResultAction_Private_Static_Void_SlgHoldNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681276);
		NativeMethodInfoPtr_HoldNodeContinueAction_Private_Static_Void_SlgHoldNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681277);
		NativeMethodInfoPtr_TaskNodeOnActiveAction_Private_Static_Void_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681278);
		NativeMethodInfoPtr_CheckTaskCondition_Private_Static_Boolean_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681279);
		NativeMethodInfoPtr_StoryScenarioNodeOnActiveAction_Private_Static_Void_StoryScenarioNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryHappenDelegate>.NativeClassPtr, 100681280);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042670, RefRangeEnd = 1042671, XrefRangeStart = 1042532, XrefRangeEnd = 1042670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042671, XrefRangeEnd = 1042705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeBossNameNodeNodeOnActiveAction(ChangeBossNameNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBossNameNodeNodeOnActiveAction_Private_Static_Void_ChangeBossNameNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042705, XrefRangeEnd = 1042726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendLogNodeOnActiveAction(SendLogNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendLogNodeOnActiveAction_Private_Static_Void_SendLogNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042726, XrefRangeEnd = 1042751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateFactionNodeOnActiveAction(CreateFactionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFactionNodeOnActiveAction_Private_Static_Void_CreateFactionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042751, XrefRangeEnd = 1042777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionNameNodeOnActiveAction(ChangeFactionNameNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionNameNodeOnActiveAction_Private_Static_Void_ChangeFactionNameNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042777, XrefRangeEnd = 1042808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgTutorialNodeOnActiveAction(SlgTutorialNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgTutorialNodeOnActiveAction_Private_Static_Void_SlgTutorialNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042808, XrefRangeEnd = 1042892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CustomFightNodeOnActiveAction(SlgCustomFightNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CustomFightNodeOnActiveAction_Private_Static_Void_SlgCustomFightNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042892, XrefRangeEnd = 1042929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DlcUniversalBattletNodeOnActiveAction(DlcUniversalBattleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DlcUniversalBattletNodeOnActiveAction_Private_Static_Void_DlcUniversalBattleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042929, XrefRangeEnd = 1042941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TimeLimitNodeOnActiveAction(TimeLimitNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeLimitNodeOnActiveAction_Private_Static_Void_TimeLimitNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042941, XrefRangeEnd = 1042970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042970, XrefRangeEnd = 1042999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042999, XrefRangeEnd = 1043007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteStringNodeOnActiveAction(WriteStringNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteStringNodeOnActiveAction_Private_Static_Void_WriteStringNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043007, XrefRangeEnd = 1043030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveStringNodeOnActiveAction(RemoveStringNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveStringNodeOnActiveAction_Private_Static_Void_RemoveStringNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043030, XrefRangeEnd = 1043041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HoldNodeHoldAction(SlgHoldNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HoldNodeHoldAction_Private_Static_Void_SlgHoldNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043041, XrefRangeEnd = 1043052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HoldNodeTrySendResultAction(SlgHoldNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HoldNodeTrySendResultAction_Private_Static_Void_SlgHoldNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043052, XrefRangeEnd = 1043060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HoldNodeContinueAction(SlgHoldNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HoldNodeContinueAction_Private_Static_Void_SlgHoldNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043060, XrefRangeEnd = 1043148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TaskNodeOnActiveAction(TaskNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TaskNodeOnActiveAction_Private_Static_Void_TaskNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1043175, RefRangeEnd = 1043178, XrefRangeStart = 1043148, XrefRangeEnd = 1043175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckTaskCondition(NodePort conditionPort)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conditionPort);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTaskCondition_Private_Static_Boolean_NodePort_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043178, XrefRangeEnd = 1043199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoryScenarioNodeOnActiveAction(StoryScenarioNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoryScenarioNodeOnActiveAction_Private_Static_Void_StoryScenarioNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgStoryHappenDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
