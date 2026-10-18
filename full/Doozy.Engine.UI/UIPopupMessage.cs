using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.UI;

[Serializable]
public class UIPopupMessage : Message
{
	private static readonly IntPtr NativeFieldInfoPtr_Popup;

	private static readonly IntPtr NativeFieldInfoPtr_AnimationType;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIPopup_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIPopup_AnimationType_0;

	public unsafe UIPopup Popup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Popup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Popup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPopup));
		}
	}

	public unsafe AnimationType AnimationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationType);
			return *(AnimationType*)num;
		}
		set
		{
			*(AnimationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationType)) = animationType;
		}
	}

	static UIPopupMessage()
	{
		Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIPopupMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr);
		NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr, "Popup");
		NativeFieldInfoPtr_AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr, "AnimationType");
		NativeMethodInfoPtr__ctor_Public_Void_UIPopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr, 100667870);
		NativeMethodInfoPtr__ctor_Public_Void_UIPopup_AnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr, 100667871);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733177, XrefRangeEnd = 733181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopupMessage(UIPopup popup)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIPopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 733185, RefRangeEnd = 733186, XrefRangeStart = 733181, XrefRangeEnd = 733185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopupMessage(UIPopup popup, AnimationType animationType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(AnimationType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &animationType;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIPopup_AnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIPopupMessage(IntPtr pointer)
		: base(pointer)
	{
	}
}
