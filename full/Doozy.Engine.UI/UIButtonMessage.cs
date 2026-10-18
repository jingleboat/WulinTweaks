using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.UI;

[Serializable]
public class UIButtonMessage : Message
{
	private static readonly IntPtr NativeFieldInfoPtr_Button;

	private static readonly IntPtr NativeFieldInfoPtr_ButtonName;

	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIButton_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIButton_UIButtonBehaviorType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UIButtonBehaviorType_0;

	public unsafe UIButton Button
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Button);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIButton>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Button)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIButton));
		}
	}

	public unsafe string ButtonName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe UIButtonBehaviorType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(UIButtonBehaviorType*)num;
		}
		set
		{
			*(UIButtonBehaviorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = uIButtonBehaviorType;
		}
	}

	static UIButtonMessage()
	{
		Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIButtonMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr);
		NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, "Button");
		NativeFieldInfoPtr_ButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, "ButtonName");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_UIButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, 100667589);
		NativeMethodInfoPtr__ctor_Public_Void_UIButton_UIButtonBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, 100667590);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, 100667591);
		NativeMethodInfoPtr__ctor_Public_Void_String_UIButtonBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr, 100667592);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729846, XrefRangeEnd = 729850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonMessage(UIButton button)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 729854, RefRangeEnd = 729855, XrefRangeStart = 729850, XrefRangeEnd = 729854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonMessage(UIButton button, UIButtonBehaviorType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
		*(UIButtonBehaviorType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIButton_UIButtonBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729855, XrefRangeEnd = 729859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonMessage(string buttonName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 729863, RefRangeEnd = 729864, XrefRangeStart = 729859, XrefRangeEnd = 729863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIButtonMessage(string buttonName, UIButtonBehaviorType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		*(UIButtonBehaviorType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_UIButtonBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIButtonMessage(IntPtr pointer)
		: base(pointer)
	{
	}
}
