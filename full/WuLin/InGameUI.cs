using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public class InGameUI : MonoSingleton<InGameUI>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_actorTextPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_textWithBgPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_instantKillPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuNameTextPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_spKungfuNameTextPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcTalkingBubble;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcEmojiBubble;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerIconTipsGroup;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateText_Public_ActorText_Vector3_String_Color_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextWithBg_Public_TextWithBg_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstantKillText_Public_InGameUiElement_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateKungfuText_Public_KungfuNameText_Vector3_String_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpKungfuText_Public_TextWithBg_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTalkingBubble_Public_NpcTalkingBubble_ActorViewElemenetAdapator_NpcTalkingContent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateEmojiBubble_Public_EmojiBubble_ActorViewElemenetAdapator_String_Action_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControllerIconTipsGroupPos_Public_Void_ViewElemenetAdapator_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActorText actorTextPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorTextPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorText>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorTextPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorText));
		}
	}

	public unsafe TextWithBg textWithBgPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textWithBgPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWithBg>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textWithBgPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textWithBg));
		}
	}

	public unsafe InGameUiElement instantKillPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instantKillPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InGameUiElement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instantKillPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inGameUiElement));
		}
	}

	public unsafe KungfuNameText kungfuNameTextPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuNameTextPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuNameText>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuNameTextPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuNameText));
		}
	}

	public unsafe TextWithBg spKungfuNameTextPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spKungfuNameTextPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWithBg>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spKungfuNameTextPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textWithBg));
		}
	}

	public unsafe NpcTalkingBubble npcTalkingBubble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcTalkingBubble);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTalkingBubble>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcTalkingBubble)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcTalkingBubble));
		}
	}

	public unsafe EmojiBubble npcEmojiBubble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcEmojiBubble);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EmojiBubble>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcEmojiBubble)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)emojiBubble));
		}
	}

	public unsafe ControllerIconTipsGroup controllerIconTipsGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerIconTipsGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerIconTipsGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerIconTipsGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerIconTipsGroup));
		}
	}

	static InGameUI()
	{
		Il2CppClassPointerStore<InGameUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "InGameUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameUI>.NativeClassPtr);
		NativeFieldInfoPtr_actorTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "actorTextPrefab");
		NativeFieldInfoPtr_textWithBgPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "textWithBgPrefab");
		NativeFieldInfoPtr_instantKillPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "instantKillPrefab");
		NativeFieldInfoPtr_kungfuNameTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "kungfuNameTextPrefab");
		NativeFieldInfoPtr_spKungfuNameTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "spKungfuNameTextPrefab");
		NativeFieldInfoPtr_npcTalkingBubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "npcTalkingBubble");
		NativeFieldInfoPtr_npcEmojiBubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "npcEmojiBubble");
		NativeFieldInfoPtr_controllerIconTipsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, "controllerIconTipsGroup");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670809);
		NativeMethodInfoPtr_CreateText_Public_ActorText_Vector3_String_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670810);
		NativeMethodInfoPtr_CreateTextWithBg_Public_TextWithBg_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670811);
		NativeMethodInfoPtr_CreateInstantKillText_Public_InGameUiElement_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670812);
		NativeMethodInfoPtr_CreateKungfuText_Public_KungfuNameText_Vector3_String_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670813);
		NativeMethodInfoPtr_CreateSpKungfuText_Public_TextWithBg_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670814);
		NativeMethodInfoPtr_CreateTalkingBubble_Public_NpcTalkingBubble_ActorViewElemenetAdapator_NpcTalkingContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670815);
		NativeMethodInfoPtr_CreateEmojiBubble_Public_EmojiBubble_ActorViewElemenetAdapator_String_Action_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670816);
		NativeMethodInfoPtr_SetControllerIconTipsGroupPos_Public_Void_ViewElemenetAdapator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670817);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameUI>.NativeClassPtr, 100670818);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764021, XrefRangeEnd = 764028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 764040, RefRangeEnd = 764042, XrefRangeStart = 764028, XrefRangeEnd = 764040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorText CreateText(Vector3 pos, string text, Color color, float sizeRate, bool showMegaBlow = false, bool useUnscaledTime = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeRate;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &showMegaBlow;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUnscaledTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateText_Public_ActorText_Vector3_String_Color_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorText>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 764052, RefRangeEnd = 764053, XrefRangeStart = 764042, XrefRangeEnd = 764052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextWithBg CreateTextWithBg(Vector3 pos, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTextWithBg_Public_TextWithBg_Vector3_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWithBg>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764053, XrefRangeEnd = 764066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameUiElement CreateInstantKillText(Vector3 pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstantKillText_Public_InGameUiElement_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InGameUiElement>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 764076, RefRangeEnd = 764077, XrefRangeStart = 764066, XrefRangeEnd = 764076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KungfuNameText CreateKungfuText(Vector3 pos, string kungfuName, Color kungfuNameColor, string kungfuMoveName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(kungfuName);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &kungfuNameColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(kungfuMoveName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateKungfuText_Public_KungfuNameText_Vector3_String_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuNameText>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764077, XrefRangeEnd = 764087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextWithBg CreateSpKungfuText(Vector3 pos, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSpKungfuText_Public_TextWithBg_Vector3_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWithBg>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 764100, RefRangeEnd = 764102, XrefRangeStart = 764087, XrefRangeEnd = 764100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcTalkingBubble CreateTalkingBubble(ActorViewElemenetAdapator adapator, NpcTalkingContent content)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adapator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTalkingBubble_Public_NpcTalkingBubble_ActorViewElemenetAdapator_NpcTalkingContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTalkingBubble>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 764113, RefRangeEnd = 764114, XrefRangeStart = 764102, XrefRangeEnd = 764113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EmojiBubble CreateEmojiBubble(ActorViewElemenetAdapator adapator, string emoName, Il2CppSystem.Action hideFunc, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adapator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(emoName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hideFunc);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateEmojiBubble_Public_EmojiBubble_ActorViewElemenetAdapator_String_Action_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EmojiBubble>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 764139, RefRangeEnd = 764142, XrefRangeStart = 764114, XrefRangeEnd = 764139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetControllerIconTipsGroupPos(ViewElemenetAdapator viewElemenetAdapator, bool couldSwitch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewElemenetAdapator);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &couldSwitch;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControllerIconTipsGroupPos_Public_Void_ViewElemenetAdapator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764142, XrefRangeEnd = 764148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InGameUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
