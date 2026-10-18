using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.UI;

[Serializable]
public class UIDrawerMessage : Message
{
	private static readonly IntPtr NativeFieldInfoPtr_Drawer;

	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIDrawer_UIDrawerBehaviorType_0;

	public unsafe UIDrawer Drawer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Drawer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIDrawer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Drawer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIDrawer));
		}
	}

	public unsafe UIDrawerBehaviorType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(UIDrawerBehaviorType*)num;
		}
		set
		{
			*(UIDrawerBehaviorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = uIDrawerBehaviorType;
		}
	}

	static UIDrawerMessage()
	{
		Il2CppClassPointerStore<UIDrawerMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIDrawerMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDrawerMessage>.NativeClassPtr);
		NativeFieldInfoPtr_Drawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerMessage>.NativeClassPtr, "Drawer");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerMessage>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_UIDrawer_UIDrawerBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerMessage>.NativeClassPtr, 100667735);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 731319, RefRangeEnd = 731320, XrefRangeStart = 731315, XrefRangeEnd = 731319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDrawerMessage(UIDrawer drawer, UIDrawerBehaviorType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDrawerMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)drawer);
		*(UIDrawerBehaviorType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIDrawer_UIDrawerBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIDrawerMessage(IntPtr pointer)
		: base(pointer)
	{
	}
}
