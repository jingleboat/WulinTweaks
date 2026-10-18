using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.UI;

[Serializable]
public class UIToggleMessage : Message
{
	private static readonly IntPtr NativeFieldInfoPtr_Toggle;

	private static readonly IntPtr NativeFieldInfoPtr_ToggleState;

	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIToggleState_UIToggleBehaviorType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIToggle_UIToggleState_UIToggleBehaviorType_0;

	public unsafe UIToggle Toggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Toggle);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIToggle>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Toggle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIToggle));
		}
	}

	public unsafe UIToggleState ToggleState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleState);
			return *(UIToggleState*)num;
		}
		set
		{
			*(UIToggleState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleState)) = uIToggleState;
		}
	}

	public unsafe UIToggleBehaviorType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(UIToggleBehaviorType*)num;
		}
		set
		{
			*(UIToggleBehaviorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = uIToggleBehaviorType;
		}
	}

	static UIToggleMessage()
	{
		Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIToggleMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr);
		NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr, "Toggle");
		NativeFieldInfoPtr_ToggleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr, "ToggleState");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_UIToggleState_UIToggleBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr, 100667945);
		NativeMethodInfoPtr__ctor_Public_Void_UIToggle_UIToggleState_UIToggleBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr, 100667946);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733978, XrefRangeEnd = 733982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIToggleMessage(UIToggleState toggleState, UIToggleBehaviorType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&toggleState);
		*(UIToggleBehaviorType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIToggleState_UIToggleBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733982, XrefRangeEnd = 733986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIToggleMessage(UIToggle toggle, UIToggleState toggleState, UIToggleBehaviorType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIToggleMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggle);
		*(UIToggleState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &toggleState;
		*(UIToggleBehaviorType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIToggle_UIToggleState_UIToggleBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIToggleMessage(IntPtr pointer)
		: base(pointer)
	{
	}
}
