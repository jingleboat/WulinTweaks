using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WuLin;

public class ControllerIconTipsItem : MonoBehaviour
{
	public enum ColorStyle
	{
		Default,
		Dark
	}

	private static readonly IntPtr NativeFieldInfoPtr_actionIcons;

	private static readonly IntPtr NativeFieldInfoPtr_iconRoot;

	private static readonly IntPtr NativeFieldInfoPtr_iconPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_orText;

	private static readonly IntPtr NativeFieldInfoPtr_iconLayoutTf;

	private static readonly IntPtr NativeFieldInfoPtr_contentTf;

	private static readonly IntPtr NativeFieldInfoPtr_isUseForSide;

	private static readonly IntPtr NativeFieldInfoPtr_cachedIcon;

	private static readonly IntPtr NativeFieldInfoPtr_actionKey;

	private static readonly IntPtr NativeFieldInfoPtr_actoionName;

	private static readonly IntPtr NativeFieldInfoPtr_anchorLeftWidth;

	private static readonly IntPtr NativeFieldInfoPtr_anchorRightWidth;

	private static readonly IntPtr NativeFieldInfoPtr_m_CahcedControllerKey;

	private static readonly IntPtr NativeFieldInfoPtr_m_CachedLanguage;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_List_1_RewiredActionIcons_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ModifyActionKey_Public_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateSize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadControllerIcon_Private_Sprite_RewiredActionIcons_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetColorStyle_Public_Void_ColorStyle_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<InputManager.RewiredActionIcons> actionIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionIcons);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InputManager.RewiredActionIcons>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionIcons)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject iconRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconRoot);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconRoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Image iconPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshProUGUI orText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe RectTransform iconLayoutTf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconLayoutTf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconLayoutTf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform contentTf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentTf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentTf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe bool isUseForSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseForSide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseForSide)) = flag;
		}
	}

	public unsafe List<MaskableGraphic> cachedIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MaskableGraphic>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string actionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe TextMeshProUGUI actoionName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actoionName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actoionName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe float anchorLeftWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorLeftWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorLeftWidth)) = num;
		}
	}

	public unsafe float anchorRightWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorRightWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorRightWidth)) = num;
		}
	}

	public unsafe InputManager.ControllerType m_CahcedControllerKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CahcedControllerKey);
			return *(InputManager.ControllerType*)num;
		}
		set
		{
			*(InputManager.ControllerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CahcedControllerKey)) = controllerType;
		}
	}

	public unsafe SystemLanguage m_CachedLanguage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedLanguage);
			return *(SystemLanguage*)num;
		}
		set
		{
			*(SystemLanguage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedLanguage)) = systemLanguage;
		}
	}

	static ControllerIconTipsItem()
	{
		Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ControllerIconTipsItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr);
		NativeFieldInfoPtr_actionIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "actionIcons");
		NativeFieldInfoPtr_iconRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "iconRoot");
		NativeFieldInfoPtr_iconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "iconPrefab");
		NativeFieldInfoPtr_orText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "orText");
		NativeFieldInfoPtr_iconLayoutTf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "iconLayoutTf");
		NativeFieldInfoPtr_contentTf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "contentTf");
		NativeFieldInfoPtr_isUseForSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "isUseForSide");
		NativeFieldInfoPtr_cachedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "cachedIcon");
		NativeFieldInfoPtr_actionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "actionKey");
		NativeFieldInfoPtr_actoionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "actoionName");
		NativeFieldInfoPtr_anchorLeftWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "anchorLeftWidth");
		NativeFieldInfoPtr_anchorRightWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "anchorRightWidth");
		NativeFieldInfoPtr_m_CahcedControllerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "m_CahcedControllerKey");
		NativeFieldInfoPtr_m_CachedLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, "m_CachedLanguage");
		NativeMethodInfoPtr_Init_Public_Void_List_1_RewiredActionIcons_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678175);
		NativeMethodInfoPtr_ModifyActionKey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678176);
		NativeMethodInfoPtr_Refresh_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678177);
		NativeMethodInfoPtr_CalculateSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678178);
		NativeMethodInfoPtr_LoadControllerIcon_Private_Sprite_RewiredActionIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678179);
		NativeMethodInfoPtr_SetColorStyle_Public_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678180);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr, 100678181);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973032, XrefRangeEnd = 973039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(List<InputManager.RewiredActionIcons> actionIcons, string actionKey, bool isUseForSide = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionIcons);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionKey);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &isUseForSide;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_List_1_RewiredActionIcons_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 973040, RefRangeEnd = 973041, XrefRangeStart = 973039, XrefRangeEnd = 973040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ModifyActionKey(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyActionKey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 973136, RefRangeEnd = 973140, XrefRangeStart = 973041, XrefRangeEnd = 973136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Refresh(bool forceRefresh = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&forceRefresh);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 973161, RefRangeEnd = 973162, XrefRangeStart = 973140, XrefRangeEnd = 973161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 973208, RefRangeEnd = 973209, XrefRangeStart = 973162, XrefRangeEnd = 973208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite LoadControllerIcon(InputManager.RewiredActionIcons rewiredActionIcons)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&rewiredActionIcons);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerIcon_Private_Sprite_RewiredActionIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973209, XrefRangeEnd = 973210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColorStyle(ColorStyle colorStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&colorStyle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorStyle_Public_Void_ColorStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973210, XrefRangeEnd = 973217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllerIconTipsItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerIconTipsItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ControllerIconTipsItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
