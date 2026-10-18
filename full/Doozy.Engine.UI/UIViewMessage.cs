using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.UI;

[Serializable]
public class UIViewMessage : Message
{
	private static readonly IntPtr NativeFieldInfoPtr_View;

	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIView_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIView_UIViewBehaviorType_0;

	public unsafe UIView View
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_View);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_View)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIView));
		}
	}

	public unsafe UIViewBehaviorType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(UIViewBehaviorType*)num;
		}
		set
		{
			*(UIViewBehaviorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = uIViewBehaviorType;
		}
	}

	static UIViewMessage()
	{
		Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIViewMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr);
		NativeFieldInfoPtr_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr, "View");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_UIView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr, 100668030);
		NativeMethodInfoPtr__ctor_Public_Void_UIView_UIViewBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr, 100668031);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735465, XrefRangeEnd = 735469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIViewMessage(UIView view)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735473, RefRangeEnd = 735475, XrefRangeStart = 735469, XrefRangeEnd = 735473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIViewMessage(UIView view, UIViewBehaviorType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIViewMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		*(UIViewBehaviorType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIView_UIViewBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIViewMessage(IntPtr pointer)
		: base(pointer)
	{
	}
}
