using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Doozy.Engine.UI;

[System.Serializable]
public class UIPopupQueueData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Popup;

	private static readonly System.IntPtr NativeFieldInfoPtr_PopupName;

	private static readonly System.IntPtr NativeFieldInfoPtr_InstantAction;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIPopup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UIPopup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_UIPopup_0;

	public unsafe UIPopup Popup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Popup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Popup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPopup));
		}
	}

	public unsafe string PopupName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool InstantAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantAction)) = flag;
		}
	}

	static UIPopupQueueData()
	{
		Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIPopupQueueData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr);
		NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr, "Popup");
		NativeFieldInfoPtr_PopupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr, "PopupName");
		NativeFieldInfoPtr_InstantAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr, "InstantAction");
		NativeMethodInfoPtr__ctor_Public_Void_UIPopup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr, 100667872);
		NativeMethodInfoPtr__ctor_Public_Void_String_UIPopup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr, 100667873);
		NativeMethodInfoPtr_Show_Public_UIPopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr, 100667874);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733186, XrefRangeEnd = 733187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopupQueueData(UIPopup popup, bool instantAction = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instantAction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIPopup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733187, XrefRangeEnd = 733188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopupQueueData(string popupName, UIPopup popup, bool instantAction = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupQueueData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &instantAction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_UIPopup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733188, XrefRangeEnd = 733193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopup Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_UIPopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr) : null;
	}

	public UIPopupQueueData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
