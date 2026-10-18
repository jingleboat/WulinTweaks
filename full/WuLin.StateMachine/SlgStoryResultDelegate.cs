using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin.StateMachine;

public static class SlgStoryResultDelegate : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgChangeBuffNodeOnResultAction_Private_Static_Void_SlgChangeBuffNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBuff_Private_Static_Void_SlgChangeBuffNode_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTagNumNodeOnResultAction_Private_Static_Void_ChangeTagNumNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceAttackNodeOnResultAction_Private_Static_Void_ForceAttackNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgChangeItemNodeOnResultAction_Private_Static_Void_SlgChangeItemNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgEndUINodeOnResultAction_Private_Static_Void_SlgEndUINode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgGameEndingNodeOnResultAction_Private_Static_Void_SlgGameEndingNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProvinceLockNodeOnResultAction_Private_Static_Void_ProvinceLockNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProvinceOwnerLockNodeOnResultAction_Private_Static_Void_ProvinceOwnerLockNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionFameNodeOnResultAction_Private_Static_Void_SlgChangeFactionFameNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlgChangeNpcFactionNodeOnResultAction_Private_Static_Void_SlgChangeNpcFactionNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCurrencyNodeOnResultAction_Private_Static_Void_ChangeCurrencyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionLockRelationNodeOnResultAction_Private_Static_Void_FactionLockRelationNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionUnFreezeNodeOnResultAction_Private_Static_Void_FactionUnFreezeNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NpcToStoreNodeOnResultAction_Private_Static_Void_NpcToStoreNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLostProvinceNodeOnResultAction_Private_Static_Void_AddLostProvinceNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionBuffNodeOnResultAction_Private_Static_Void_FactionBuffNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionKungfuNodeOnResultAction_Private_Static_Void_ChangeFactionKungfuNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFactionItemNodeOnResultAction_Private_Static_Void_ChangeFactionItemNode_0;

	static SlgStoryResultDelegate()
	{
		Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "SlgStoryResultDelegate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681281);
		NativeMethodInfoPtr_SlgChangeBuffNodeOnResultAction_Private_Static_Void_SlgChangeBuffNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681282);
		NativeMethodInfoPtr_ChangeBuff_Private_Static_Void_SlgChangeBuffNode_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681283);
		NativeMethodInfoPtr_ChangeTagNumNodeOnResultAction_Private_Static_Void_ChangeTagNumNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681284);
		NativeMethodInfoPtr_ForceAttackNodeOnResultAction_Private_Static_Void_ForceAttackNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681285);
		NativeMethodInfoPtr_SlgChangeItemNodeOnResultAction_Private_Static_Void_SlgChangeItemNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681286);
		NativeMethodInfoPtr_SlgEndUINodeOnResultAction_Private_Static_Void_SlgEndUINode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681287);
		NativeMethodInfoPtr_SlgGameEndingNodeOnResultAction_Private_Static_Void_SlgGameEndingNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681288);
		NativeMethodInfoPtr_ProvinceLockNodeOnResultAction_Private_Static_Void_ProvinceLockNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681289);
		NativeMethodInfoPtr_ProvinceOwnerLockNodeOnResultAction_Private_Static_Void_ProvinceOwnerLockNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681290);
		NativeMethodInfoPtr_ChangeFactionFameNodeOnResultAction_Private_Static_Void_SlgChangeFactionFameNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681291);
		NativeMethodInfoPtr_SlgChangeNpcFactionNodeOnResultAction_Private_Static_Void_SlgChangeNpcFactionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681292);
		NativeMethodInfoPtr_ChangeCurrencyNodeOnResultAction_Private_Static_Void_ChangeCurrencyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681293);
		NativeMethodInfoPtr_FactionLockRelationNodeOnResultAction_Private_Static_Void_FactionLockRelationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681294);
		NativeMethodInfoPtr_FactionUnFreezeNodeOnResultAction_Private_Static_Void_FactionUnFreezeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681295);
		NativeMethodInfoPtr_NpcToStoreNodeOnResultAction_Private_Static_Void_NpcToStoreNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681296);
		NativeMethodInfoPtr_AddLostProvinceNodeOnResultAction_Private_Static_Void_AddLostProvinceNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681297);
		NativeMethodInfoPtr_FactionBuffNodeOnResultAction_Private_Static_Void_FactionBuffNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681298);
		NativeMethodInfoPtr_ChangeFactionKungfuNodeOnResultAction_Private_Static_Void_ChangeFactionKungfuNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681299);
		NativeMethodInfoPtr_ChangeFactionItemNodeOnResultAction_Private_Static_Void_ChangeFactionItemNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgStoryResultDelegate>.NativeClassPtr, 100681300);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043347, RefRangeEnd = 1043348, XrefRangeStart = 1043199, XrefRangeEnd = 1043347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043348, XrefRangeEnd = 1043385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgChangeBuffNodeOnResultAction(SlgChangeBuffNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgChangeBuffNodeOnResultAction_Private_Static_Void_SlgChangeBuffNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043385, XrefRangeEnd = 1043386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeBuff(SlgChangeBuffNode self, GameCharacterInstance partner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)partner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBuff_Private_Static_Void_SlgChangeBuffNode_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043386, XrefRangeEnd = 1043401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeTagNumNodeOnResultAction(ChangeTagNumNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTagNumNodeOnResultAction_Private_Static_Void_ChangeTagNumNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043401, XrefRangeEnd = 1043445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForceAttackNodeOnResultAction(ForceAttackNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceAttackNodeOnResultAction_Private_Static_Void_ForceAttackNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043445, XrefRangeEnd = 1043458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgChangeItemNodeOnResultAction(SlgChangeItemNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgChangeItemNodeOnResultAction_Private_Static_Void_SlgChangeItemNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043458, XrefRangeEnd = 1043466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgEndUINodeOnResultAction(SlgEndUINode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgEndUINodeOnResultAction_Private_Static_Void_SlgEndUINode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043466, XrefRangeEnd = 1043481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgGameEndingNodeOnResultAction(SlgGameEndingNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgGameEndingNodeOnResultAction_Private_Static_Void_SlgGameEndingNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043481, XrefRangeEnd = 1043489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProvinceLockNodeOnResultAction(ProvinceLockNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProvinceLockNodeOnResultAction_Private_Static_Void_ProvinceLockNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043489, XrefRangeEnd = 1043497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProvinceOwnerLockNodeOnResultAction(ProvinceOwnerLockNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProvinceOwnerLockNodeOnResultAction_Private_Static_Void_ProvinceOwnerLockNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043497, XrefRangeEnd = 1043516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionFameNodeOnResultAction(SlgChangeFactionFameNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionFameNodeOnResultAction_Private_Static_Void_SlgChangeFactionFameNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043516, XrefRangeEnd = 1043538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlgChangeNpcFactionNodeOnResultAction(SlgChangeNpcFactionNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlgChangeNpcFactionNodeOnResultAction_Private_Static_Void_SlgChangeNpcFactionNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043538, XrefRangeEnd = 1043562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeCurrencyNodeOnResultAction(ChangeCurrencyNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCurrencyNodeOnResultAction_Private_Static_Void_ChangeCurrencyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043562, XrefRangeEnd = 1043582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FactionLockRelationNodeOnResultAction(FactionLockRelationNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionLockRelationNodeOnResultAction_Private_Static_Void_FactionLockRelationNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043582, XrefRangeEnd = 1043590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FactionUnFreezeNodeOnResultAction(FactionUnFreezeNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionUnFreezeNodeOnResultAction_Private_Static_Void_FactionUnFreezeNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043590, XrefRangeEnd = 1043628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NpcToStoreNodeOnResultAction(NpcToStoreNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NpcToStoreNodeOnResultAction_Private_Static_Void_NpcToStoreNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043628, XrefRangeEnd = 1043644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddLostProvinceNodeOnResultAction(AddLostProvinceNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLostProvinceNodeOnResultAction_Private_Static_Void_AddLostProvinceNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043644, XrefRangeEnd = 1043676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FactionBuffNodeOnResultAction(FactionBuffNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionBuffNodeOnResultAction_Private_Static_Void_FactionBuffNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043676, XrefRangeEnd = 1043692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionKungfuNodeOnResultAction(ChangeFactionKungfuNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionKungfuNodeOnResultAction_Private_Static_Void_ChangeFactionKungfuNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043692, XrefRangeEnd = 1043713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFactionItemNodeOnResultAction(ChangeFactionItemNode self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFactionItemNodeOnResultAction_Private_Static_Void_ChangeFactionItemNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgStoryResultDelegate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
