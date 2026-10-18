using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin.StateMachine;

public static class DllScenarioDelegate : Il2CppSystem.Object
{
	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass6_0")]
	public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__3_Internal_Void_Int32_Il2CppReferenceArray_1_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__4_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__5_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__6_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__2_Internal_Void_0;

		public unsafe SlgTalkMessageNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlgTalkMessageNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slgTalkMessageNode));
			}
		}

		static __c__DisplayClass6_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass6_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688944);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__3_Internal_Void_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688945);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688946);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688947);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688948);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688949);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688950);
			NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100688951);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass6_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033814, XrefRangeEnd = 1033815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__3(int timeID, Il2CppReferenceArray<Il2CppSystem.Object> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&timeID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__3_Internal_Void_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SlgTalkMessageNodeOnPlay_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SlgTalkMessageNodeOnPlay_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass6_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass7_0")]
	public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__0_Internal_Void_Int32_Il2CppReferenceArray_1_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__2_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__3_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__4_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__5_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__6_Internal_Void_0;

		public unsafe TalkMessageNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TalkMessageNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)talkMessageNode));
			}
		}

		static __c__DisplayClass7_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass7_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688952);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__0_Internal_Void_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688953);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688954);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688955);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688956);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688957);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688958);
			NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100688959);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass7_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033815, XrefRangeEnd = 1033816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__0(int timeID, Il2CppReferenceArray<Il2CppSystem.Object> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&timeID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__0_Internal_Void_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TalkMessageNodeOnPlay_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TalkMessageNodeOnPlay_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass7_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass11_0")]
	public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowBlackSideNodeOnPlay_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowBlackSideNodeOnPlay_b__1_Internal_Void_0;

		public unsafe ShowBlackSideNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowBlackSideNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showBlackSideNode));
			}
		}

		static __c__DisplayClass11_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass11_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100688960);
			NativeMethodInfoPtr__ShowBlackSideNodeOnPlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100688961);
			NativeMethodInfoPtr__ShowBlackSideNodeOnPlay_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100688962);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass11_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowBlackSideNodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowBlackSideNodeOnPlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowBlackSideNodeOnPlay_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowBlackSideNodeOnPlay_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass11_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass14_0")]
	public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ScreenDarkerNodeOnPlay_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ScreenDarkerNodeOnPlay_b__1_Internal_Void_0;

		public unsafe ScreenDarkerNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenDarkerNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenDarkerNode));
			}
		}

		static __c__DisplayClass14_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass14_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100688963);
			NativeMethodInfoPtr__ScreenDarkerNodeOnPlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100688964);
			NativeMethodInfoPtr__ScreenDarkerNodeOnPlay_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100688965);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass14_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenDarkerNodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ScreenDarkerNodeOnPlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenDarkerNodeOnPlay_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ScreenDarkerNodeOnPlay_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass14_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass19_0")]
	public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveRoleNodeOnPlay_b__0_Internal_Void_0;

		public unsafe RemoveRoleNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RemoveRoleNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)removeRoleNode));
			}
		}

		static __c__DisplayClass19_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass19_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100688966);
			NativeMethodInfoPtr__RemoveRoleNodeOnPlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100688967);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RemoveRoleNodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveRoleNodeOnPlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass19_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass23_0")]
	public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlayEffectNodeOnPlay_b__0_Internal_Void_0;

		public unsafe PlayEffectNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayEffectNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playEffectNode));
			}
		}

		static __c__DisplayClass23_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass23_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, 100688968);
			NativeMethodInfoPtr__PlayEffectNodeOnPlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, 100688969);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass23_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033816, XrefRangeEnd = 1033817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayEffectNodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlayEffectNodeOnPlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass23_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass24_0")]
	public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlayActionNodeOnPlay_b__0_Internal_Void_EAnimatorStage_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlayActionNodeOnPlay_b__1_Internal_Void_EAnimatorStage_0;

		public unsafe PlayActionNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayActionNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playActionNode));
			}
		}

		static __c__DisplayClass24_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass24_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100688970);
			NativeMethodInfoPtr__PlayActionNodeOnPlay_b__0_Internal_Void_EAnimatorStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100688971);
			NativeMethodInfoPtr__PlayActionNodeOnPlay_b__1_Internal_Void_EAnimatorStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100688972);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass24_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033817, XrefRangeEnd = 1033825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayActionNodeOnPlay_b__0(RoleAniManager.EAnimatorStage state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlayActionNodeOnPlay_b__0_Internal_Void_EAnimatorStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033825, XrefRangeEnd = 1033833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayActionNodeOnPlay_b__1(RoleAniManager.EAnimatorStage state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlayActionNodeOnPlay_b__1_Internal_Void_EAnimatorStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass24_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass36_0")]
	public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kit;

		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__0_Internal_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__1_Internal_Void_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__2_Internal_Void_0;

		public unsafe GearBuildKit kit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kit);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GearBuildKit>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gearBuildKit));
			}
		}

		public unsafe MapBuildingMoveNode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapBuildingMoveNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapBuildingMoveNode));
			}
		}

		static __c__DisplayClass36_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass36_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr);
			NativeFieldInfoPtr_kit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, "kit");
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, 100688973);
			NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, 100688974);
			NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, 100688975);
			NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, 100688976);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass36_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033833, XrefRangeEnd = 1033834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 _MapBuildingMoveNodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033834, XrefRangeEnd = 1033835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _MapBuildingMoveNodeOnPlay_b__1(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033835, XrefRangeEnd = 1033837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _MapBuildingMoveNodeOnPlay_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MapBuildingMoveNodeOnPlay_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass36_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.StateMachine.DllScenarioDelegate+<>c__DisplayClass43_0")]
	public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_self;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GameEngingUINodeOnPlay_b__0_Internal_Void_0;

		public unsafe GameEngingUINode self
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameEngingUINode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEngingUINode));
			}
		}

		static __c__DisplayClass43_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, "<>c__DisplayClass43_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr);
			NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, "self");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, 100688977);
			NativeMethodInfoPtr__GameEngingUINodeOnPlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, 100688978);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass43_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GameEngingUINodeOnPlay_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GameEngingUINodeOnPlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass43_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldMapMoveNodeOnPlay_Private_Static_Void_WorldMapMoveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeatherRainNodeOnPlay_Private_Static_Void_WeatherRainNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeatherSnowNodeOnPlay_Private_Static_Void_WeatherSnowNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeaponActionNodeOnPlay_Private_Static_Void_WeaponActionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgTalkMessageNodeSkip_Private_Static_Void_SlgTalkMessageNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgTalkMessageNodeOnPlay_Private_Static_Void_SlgTalkMessageNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TalkMessageNodeOnPlay_Private_Static_Void_TalkMessageNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TalkMessageNodeSkip_Private_Static_Void_TalkMessageNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUselessInfoFromLog_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SoundNodeOnPlay_Private_Static_Void_SoundNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowBlackSideNodeOnPlay_Private_Static_Void_ShowBlackSideNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowBlackSideNodeSkip_Private_Static_Void_ShowBlackSideNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShakeScreenNodeOnPlay_Private_Static_Void_ShakeScreenNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenDarkerNodeOnPlay_Private_Static_Void_ScreenDarkerNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenDarkerNodeSkip_Private_Static_Void_ScreenDarkerNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleEnableNodeOnPlay_Private_Static_Void_ScheduleEnableNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleNodeOnPlay_Private_Static_Void_ScheduleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RevertNpcNameNodeOnPlay_Private_Static_Void_RevertNpcNameNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRoleNodeOnPlay_Private_Static_Void_RemoveRoleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRoleNodeSkip_Private_Static_Void_RemoveRoleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerVisibleNodeOnPlay_Private_Static_Void_PlayerVisibleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerStealthNodeOnPlay_Private_Static_Void_PlayerStealthNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayEffectNodeOnPlay_Private_Static_Void_PlayEffectNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayActionNodeOnPlay_Private_Static_Void_PlayActionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayActionNodeSkip_Private_Static_Void_PlayActionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NpcHeadNameNodeOnPlay_Private_Static_Void_NpcHeadNameNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MusicNodeOnPlay_Private_Static_Void_MusicNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveNodeRevertSpeed_Private_Static_Void_MoveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveNodeSkip_Private_Static_Void_MoveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveNodeOnComplated_Private_Static_Void_MoveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveNodeOnPlay_Private_Static_Void_MoveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapMiscItemVisibleNodeOnPlay_Private_Static_Void_MapMiscItemVisibleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapLightSwitchNodeOnPlay_Private_Static_Void_MapLightSwitchNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapGateWayVisibleNodeOnPlay_Private_Static_Void_MapGateWayVisibleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapDoorNodeOnPlay_Private_Static_Void_MapDoorNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapBuildingMoveNodeOnPlay_Private_Static_Void_MapBuildingMoveNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAndResetPos_Private_Static_Void_MapBuildingMoveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapBuildingHpNodeOnPlay_Private_Static_Void_MapBuildingHpNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JumpToDestinationNodeOnPlay_Private_Static_Void_JumpToDestinationNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameEngingUINodeOnComplated_Private_Static_Void_GameEngingUINode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameEngingUINodeSkip_Private_Static_Void_GameEngingUINode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameEngingUINodeOnPlay_Private_Static_Void_GameEngingUINode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlockScareNodeOnPlay_Private_Static_Void_FlockScareNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorldMapID_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgEnterMapNodeOnPlay_Private_Static_Void_SlgEnterMapNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterMapNodeOnPlay_Private_Static_Void_EnterMapNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterMapNodeStartTeleport_Private_Static_Void_EnterMapNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectionNodeOnPlay_Private_Static_Void_DirectionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRoleNodeOnPlay_Private_Static_Void_CreateRoleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyRoleNodeOnPlay_Private_Static_Void_CopyRoleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraScaleNodeOnPlay_Private_Static_Void_CameraScaleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraScaleNodeSkip_Private_Static_Void_CameraScaleNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveBaseNodeOnComplated_Private_Static_Void_ActiveBaseNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgActiveBaseNodeOnComplated_Private_Static_Void_ActiveBaseNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraFollowNodeSkip_Private_Static_Void_CameraFollowNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraFollowNodeOnPlay_Private_Static_Void_CameraFollowNode_0;

	static DllScenarioDelegate()
	{
		Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "DllScenarioDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680939);
		NativeMethodInfoPtr_WorldMapMoveNodeOnPlay_Private_Static_Void_WorldMapMoveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680940);
		NativeMethodInfoPtr_WeatherRainNodeOnPlay_Private_Static_Void_WeatherRainNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680941);
		NativeMethodInfoPtr_WeatherSnowNodeOnPlay_Private_Static_Void_WeatherSnowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680942);
		NativeMethodInfoPtr_WeaponActionNodeOnPlay_Private_Static_Void_WeaponActionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680943);
		NativeMethodInfoPtr_SlgTalkMessageNodeSkip_Private_Static_Void_SlgTalkMessageNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680944);
		NativeMethodInfoPtr_SlgTalkMessageNodeOnPlay_Private_Static_Void_SlgTalkMessageNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680945);
		NativeMethodInfoPtr_TalkMessageNodeOnPlay_Private_Static_Void_TalkMessageNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680946);
		NativeMethodInfoPtr_TalkMessageNodeSkip_Private_Static_Void_TalkMessageNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680947);
		NativeMethodInfoPtr_RemoveUselessInfoFromLog_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680948);
		NativeMethodInfoPtr_SoundNodeOnPlay_Private_Static_Void_SoundNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680949);
		NativeMethodInfoPtr_ShowBlackSideNodeOnPlay_Private_Static_Void_ShowBlackSideNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680950);
		NativeMethodInfoPtr_ShowBlackSideNodeSkip_Private_Static_Void_ShowBlackSideNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680951);
		NativeMethodInfoPtr_ShakeScreenNodeOnPlay_Private_Static_Void_ShakeScreenNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680952);
		NativeMethodInfoPtr_ScreenDarkerNodeOnPlay_Private_Static_Void_ScreenDarkerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680953);
		NativeMethodInfoPtr_ScreenDarkerNodeSkip_Private_Static_Void_ScreenDarkerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680954);
		NativeMethodInfoPtr_ScheduleEnableNodeOnPlay_Private_Static_Void_ScheduleEnableNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680955);
		NativeMethodInfoPtr_ScheduleNodeOnPlay_Private_Static_Void_ScheduleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680956);
		NativeMethodInfoPtr_RevertNpcNameNodeOnPlay_Private_Static_Void_RevertNpcNameNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680957);
		NativeMethodInfoPtr_RemoveRoleNodeOnPlay_Private_Static_Void_RemoveRoleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680958);
		NativeMethodInfoPtr_RemoveRoleNodeSkip_Private_Static_Void_RemoveRoleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680959);
		NativeMethodInfoPtr_PlayerVisibleNodeOnPlay_Private_Static_Void_PlayerVisibleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680960);
		NativeMethodInfoPtr_PlayerStealthNodeOnPlay_Private_Static_Void_PlayerStealthNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680961);
		NativeMethodInfoPtr_PlayEffectNodeOnPlay_Private_Static_Void_PlayEffectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680962);
		NativeMethodInfoPtr_PlayActionNodeOnPlay_Private_Static_Void_PlayActionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680963);
		NativeMethodInfoPtr_PlayActionNodeSkip_Private_Static_Void_PlayActionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680964);
		NativeMethodInfoPtr_NpcHeadNameNodeOnPlay_Private_Static_Void_NpcHeadNameNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680965);
		NativeMethodInfoPtr_MusicNodeOnPlay_Private_Static_Void_MusicNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680966);
		NativeMethodInfoPtr_MoveNodeRevertSpeed_Private_Static_Void_MoveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680967);
		NativeMethodInfoPtr_MoveNodeSkip_Private_Static_Void_MoveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680968);
		NativeMethodInfoPtr_MoveNodeOnComplated_Private_Static_Void_MoveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680969);
		NativeMethodInfoPtr_MoveNodeOnPlay_Private_Static_Void_MoveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680970);
		NativeMethodInfoPtr_MapMiscItemVisibleNodeOnPlay_Private_Static_Void_MapMiscItemVisibleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680971);
		NativeMethodInfoPtr_MapLightSwitchNodeOnPlay_Private_Static_Void_MapLightSwitchNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680972);
		NativeMethodInfoPtr_MapGateWayVisibleNodeOnPlay_Private_Static_Void_MapGateWayVisibleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680973);
		NativeMethodInfoPtr_MapDoorNodeOnPlay_Private_Static_Void_MapDoorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680974);
		NativeMethodInfoPtr_MapBuildingMoveNodeOnPlay_Private_Static_Void_MapBuildingMoveNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680975);
		NativeMethodInfoPtr_HideAndResetPos_Private_Static_Void_MapBuildingMoveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680976);
		NativeMethodInfoPtr_MapBuildingHpNodeOnPlay_Private_Static_Void_MapBuildingHpNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680977);
		NativeMethodInfoPtr_JumpToDestinationNodeOnPlay_Private_Static_Void_JumpToDestinationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680978);
		NativeMethodInfoPtr_GameEngingUINodeOnComplated_Private_Static_Void_GameEngingUINode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680979);
		NativeMethodInfoPtr_GameEngingUINodeSkip_Private_Static_Void_GameEngingUINode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680980);
		NativeMethodInfoPtr_GetString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680981);
		NativeMethodInfoPtr_GameEngingUINodeOnPlay_Private_Static_Void_GameEngingUINode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680982);
		NativeMethodInfoPtr_FlockScareNodeOnPlay_Private_Static_Void_FlockScareNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680983);
		NativeMethodInfoPtr_IsWorldMapID_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680984);
		NativeMethodInfoPtr_SlgEnterMapNodeOnPlay_Private_Static_Void_SlgEnterMapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680985);
		NativeMethodInfoPtr_EnterMapNodeOnPlay_Private_Static_Void_EnterMapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680986);
		NativeMethodInfoPtr_EnterMapNodeStartTeleport_Private_Static_Void_EnterMapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680987);
		NativeMethodInfoPtr_DirectionNodeOnPlay_Private_Static_Void_DirectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680988);
		NativeMethodInfoPtr_CreateRoleNodeOnPlay_Private_Static_Void_CreateRoleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680989);
		NativeMethodInfoPtr_CopyRoleNodeOnPlay_Private_Static_Void_CopyRoleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680990);
		NativeMethodInfoPtr_CameraScaleNodeOnPlay_Private_Static_Void_CameraScaleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680991);
		NativeMethodInfoPtr_CameraScaleNodeSkip_Private_Static_Void_CameraScaleNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680992);
		NativeMethodInfoPtr_ActiveBaseNodeOnComplated_Private_Static_Void_ActiveBaseNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680993);
		NativeMethodInfoPtr_SlgActiveBaseNodeOnComplated_Private_Static_Void_ActiveBaseNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680994);
		NativeMethodInfoPtr_CameraFollowNodeSkip_Private_Static_Void_CameraFollowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680995);
		NativeMethodInfoPtr_CameraFollowNodeOnPlay_Private_Static_Void_CameraFollowNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllScenarioDelegate>.NativeClassPtr, 100680996);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1034322, RefRangeEnd = 1034324, XrefRangeStart = 1033837, XrefRangeEnd = 1034322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034324, XrefRangeEnd = 1034335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WorldMapMoveNodeOnPlay(WorldMapMoveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldMapMoveNodeOnPlay_Private_Static_Void_WorldMapMoveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034335, XrefRangeEnd = 1034349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WeatherRainNodeOnPlay(WeatherRainNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeatherRainNodeOnPlay_Private_Static_Void_WeatherRainNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034349, XrefRangeEnd = 1034361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WeatherSnowNodeOnPlay(WeatherSnowNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeatherSnowNodeOnPlay_Private_Static_Void_WeatherSnowNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034361, XrefRangeEnd = 1034369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WeaponActionNodeOnPlay(WeaponActionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeaponActionNodeOnPlay_Private_Static_Void_WeaponActionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034369, XrefRangeEnd = 1034486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgTalkMessageNodeSkip(SlgTalkMessageNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgTalkMessageNodeSkip_Private_Static_Void_SlgTalkMessageNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034486, XrefRangeEnd = 1034553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgTalkMessageNodeOnPlay(SlgTalkMessageNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgTalkMessageNodeOnPlay_Private_Static_Void_SlgTalkMessageNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034553, XrefRangeEnd = 1034656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TalkMessageNodeOnPlay(TalkMessageNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TalkMessageNodeOnPlay_Private_Static_Void_TalkMessageNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034656, XrefRangeEnd = 1034884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TalkMessageNodeSkip(TalkMessageNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TalkMessageNodeSkip_Private_Static_Void_TalkMessageNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1034892, RefRangeEnd = 1034895, XrefRangeStart = 1034884, XrefRangeEnd = 1034892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RemoveUselessInfoFromLog(string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUselessInfoFromLog_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034895, XrefRangeEnd = 1034905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SoundNodeOnPlay(SoundNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SoundNodeOnPlay_Private_Static_Void_SoundNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034905, XrefRangeEnd = 1034923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowBlackSideNodeOnPlay(ShowBlackSideNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowBlackSideNodeOnPlay_Private_Static_Void_ShowBlackSideNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034923, XrefRangeEnd = 1034929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowBlackSideNodeSkip(ShowBlackSideNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowBlackSideNodeSkip_Private_Static_Void_ShowBlackSideNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034929, XrefRangeEnd = 1034933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShakeScreenNodeOnPlay(ShakeScreenNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShakeScreenNodeOnPlay_Private_Static_Void_ShakeScreenNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034933, XrefRangeEnd = 1034951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenDarkerNodeOnPlay(ScreenDarkerNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenDarkerNodeOnPlay_Private_Static_Void_ScreenDarkerNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034951, XrefRangeEnd = 1034968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenDarkerNodeSkip(ScreenDarkerNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenDarkerNodeSkip_Private_Static_Void_ScreenDarkerNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034968, XrefRangeEnd = 1034996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleEnableNodeOnPlay(ScheduleEnableNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleEnableNodeOnPlay_Private_Static_Void_ScheduleEnableNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034996, XrefRangeEnd = 1035030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleNodeOnPlay(ScheduleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleNodeOnPlay_Private_Static_Void_ScheduleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035030, XrefRangeEnd = 1035077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RevertNpcNameNodeOnPlay(RevertNpcNameNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RevertNpcNameNodeOnPlay_Private_Static_Void_RevertNpcNameNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035077, XrefRangeEnd = 1035168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveRoleNodeOnPlay(RemoveRoleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRoleNodeOnPlay_Private_Static_Void_RemoveRoleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035168, XrefRangeEnd = 1035301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveRoleNodeSkip(RemoveRoleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRoleNodeSkip_Private_Static_Void_RemoveRoleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035301, XrefRangeEnd = 1035318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayerVisibleNodeOnPlay(PlayerVisibleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerVisibleNodeOnPlay_Private_Static_Void_PlayerVisibleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035318, XrefRangeEnd = 1035341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayerStealthNodeOnPlay(PlayerStealthNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerStealthNodeOnPlay_Private_Static_Void_PlayerStealthNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035341, XrefRangeEnd = 1035358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayEffectNodeOnPlay(PlayEffectNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayEffectNodeOnPlay_Private_Static_Void_PlayEffectNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035358, XrefRangeEnd = 1035386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayActionNodeOnPlay(PlayActionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayActionNodeOnPlay_Private_Static_Void_PlayActionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035386, XrefRangeEnd = 1035445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayActionNodeSkip(PlayActionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayActionNodeSkip_Private_Static_Void_PlayActionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035445, XrefRangeEnd = 1035464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NpcHeadNameNodeOnPlay(NpcHeadNameNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NpcHeadNameNodeOnPlay_Private_Static_Void_NpcHeadNameNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035464, XrefRangeEnd = 1035482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MusicNodeOnPlay(MusicNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MusicNodeOnPlay_Private_Static_Void_MusicNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1035491, RefRangeEnd = 1035493, XrefRangeStart = 1035482, XrefRangeEnd = 1035491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveNodeRevertSpeed(MoveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNodeRevertSpeed_Private_Static_Void_MoveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035493, XrefRangeEnd = 1035611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveNodeSkip(MoveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNodeSkip_Private_Static_Void_MoveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035611, XrefRangeEnd = 1035643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveNodeOnComplated(MoveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNodeOnComplated_Private_Static_Void_MoveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035643, XrefRangeEnd = 1035785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveNodeOnPlay(MoveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNodeOnPlay_Private_Static_Void_MoveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035785, XrefRangeEnd = 1035811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapMiscItemVisibleNodeOnPlay(MapMiscItemVisibleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapMiscItemVisibleNodeOnPlay_Private_Static_Void_MapMiscItemVisibleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035811, XrefRangeEnd = 1035853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapLightSwitchNodeOnPlay(MapLightSwitchNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapLightSwitchNodeOnPlay_Private_Static_Void_MapLightSwitchNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035853, XrefRangeEnd = 1035914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapGateWayVisibleNodeOnPlay(MapGateWayVisibleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapGateWayVisibleNodeOnPlay_Private_Static_Void_MapGateWayVisibleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035914, XrefRangeEnd = 1035954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapDoorNodeOnPlay(MapDoorNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapDoorNodeOnPlay_Private_Static_Void_MapDoorNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035954, XrefRangeEnd = 1036013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapBuildingMoveNodeOnPlay(MapBuildingMoveNode self, bool skip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skip;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapBuildingMoveNodeOnPlay_Private_Static_Void_MapBuildingMoveNode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1036061, RefRangeEnd = 1036062, XrefRangeStart = 1036013, XrefRangeEnd = 1036061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAndResetPos(MapBuildingMoveNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAndResetPos_Private_Static_Void_MapBuildingMoveNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036062, XrefRangeEnd = 1036124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapBuildingHpNodeOnPlay(MapBuildingHpNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapBuildingHpNodeOnPlay_Private_Static_Void_MapBuildingHpNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036124, XrefRangeEnd = 1036312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void JumpToDestinationNodeOnPlay(JumpToDestinationNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JumpToDestinationNodeOnPlay_Private_Static_Void_JumpToDestinationNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036312, XrefRangeEnd = 1036323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GameEngingUINodeOnComplated(GameEngingUINode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameEngingUINodeOnComplated_Private_Static_Void_GameEngingUINode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036323, XrefRangeEnd = 1036344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GameEngingUINodeSkip(GameEngingUINode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameEngingUINodeSkip_Private_Static_Void_GameEngingUINode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1036361, RefRangeEnd = 1036366, XrefRangeStart = 1036344, XrefRangeEnd = 1036361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetString_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036366, XrefRangeEnd = 1036428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GameEngingUINodeOnPlay(GameEngingUINode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameEngingUINodeOnPlay_Private_Static_Void_GameEngingUINode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036428, XrefRangeEnd = 1036432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlockScareNodeOnPlay(FlockScareNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlockScareNodeOnPlay_Private_Static_Void_FlockScareNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036432, XrefRangeEnd = 1036436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036436, XrefRangeEnd = 1036465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgEnterMapNodeOnPlay(SlgEnterMapNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgEnterMapNodeOnPlay_Private_Static_Void_SlgEnterMapNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036465, XrefRangeEnd = 1036477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnterMapNodeOnPlay(EnterMapNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterMapNodeOnPlay_Private_Static_Void_EnterMapNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1036562, RefRangeEnd = 1036563, XrefRangeStart = 1036477, XrefRangeEnd = 1036562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnterMapNodeStartTeleport(EnterMapNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterMapNodeStartTeleport_Private_Static_Void_EnterMapNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036563, XrefRangeEnd = 1036667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DirectionNodeOnPlay(DirectionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectionNodeOnPlay_Private_Static_Void_DirectionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036667, XrefRangeEnd = 1036751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRoleNodeOnPlay(CreateRoleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRoleNodeOnPlay_Private_Static_Void_CreateRoleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036751, XrefRangeEnd = 1036784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyRoleNodeOnPlay(CopyRoleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyRoleNodeOnPlay_Private_Static_Void_CopyRoleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036784, XrefRangeEnd = 1036796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CameraScaleNodeOnPlay(CameraScaleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraScaleNodeOnPlay_Private_Static_Void_CameraScaleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036796, XrefRangeEnd = 1036808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CameraScaleNodeSkip(CameraScaleNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraScaleNodeSkip_Private_Static_Void_CameraScaleNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1036827, RefRangeEnd = 1036829, XrefRangeStart = 1036808, XrefRangeEnd = 1036827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ActiveBaseNodeOnComplated(ActiveBaseNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveBaseNodeOnComplated_Private_Static_Void_ActiveBaseNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036829, XrefRangeEnd = 1036848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgActiveBaseNodeOnComplated(ActiveBaseNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgActiveBaseNodeOnComplated_Private_Static_Void_ActiveBaseNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036848, XrefRangeEnd = 1036863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CameraFollowNodeSkip(CameraFollowNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraFollowNodeSkip_Private_Static_Void_CameraFollowNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036863, XrefRangeEnd = 1036881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CameraFollowNodeOnPlay(CameraFollowNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraFollowNodeOnPlay_Private_Static_Void_CameraFollowNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DllScenarioDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
