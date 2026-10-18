using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public class GiftingWithNpcManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr__npc_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_npc_Public_Static_get_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_npc_Private_Static_set_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartGifting_Public_Static_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PredictRelationOffset_Public_Static_Int32_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmGifting_Public_Static_Void_GameItemInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndGifting_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoNpcResponse_Private_Static_Void_String_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe static GameCharacterInstance npc
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891897, XrefRangeEnd = 891899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_npc_Public_Static_get_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891899, XrefRangeEnd = 891901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_npc_Private_Static_set_Void_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GiftingWithNpcManager()
	{
		Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GiftingWithNpcManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr);
		NativeFieldInfoPtr__npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, "<npc>k__BackingField");
		NativeMethodInfoPtr_get_npc_Public_Static_get_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675145);
		NativeMethodInfoPtr_set_npc_Private_Static_set_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675146);
		NativeMethodInfoPtr_StartGifting_Public_Static_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675147);
		NativeMethodInfoPtr_PredictRelationOffset_Public_Static_Int32_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675148);
		NativeMethodInfoPtr_ConfirmGifting_Public_Static_Void_GameItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675149);
		NativeMethodInfoPtr_EndGifting_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675150);
		NativeMethodInfoPtr_DoNpcResponse_Private_Static_Void_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675151);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr, 100675152);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 891919, RefRangeEnd = 891920, XrefRangeStart = 891901, XrefRangeEnd = 891919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartGifting(GameCharacterInstance other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartGifting_Public_Static_Void_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 891933, RefRangeEnd = 891934, XrefRangeStart = 891920, XrefRangeEnd = 891933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PredictRelationOffset(GameItemInstance gameItemInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PredictRelationOffset_Public_Static_Int32_GameItemInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 892071, RefRangeEnd = 892074, XrefRangeStart = 891934, XrefRangeEnd = 892071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfirmGifting(GameItemInstance gameItemInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfirmGifting_Public_Static_Void_GameItemInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892074, XrefRangeEnd = 892088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndGifting()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndGifting_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892088, XrefRangeEnd = 892103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoNpcResponse(string response, Il2CppSystem.Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(response);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoNpcResponse_Private_Static_Void_String_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GiftingWithNpcManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiftingWithNpcManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GiftingWithNpcManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
