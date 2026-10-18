using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Doozy.Engine.Nody.Attributes;

public class NodeMenu : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MenuName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddSeparatorAfter;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddSeparatorBefore;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_Boolean_0;

	public unsafe string MenuName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MenuName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MenuName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int Order
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Order);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Order)) = num;
		}
	}

	public unsafe bool AddSeparatorAfter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSeparatorAfter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSeparatorAfter)) = flag;
		}
	}

	public unsafe bool AddSeparatorBefore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSeparatorBefore);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSeparatorBefore)) = flag;
		}
	}

	static NodeMenu()
	{
		Il2CppClassPointerStore<NodeMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Nody.Attributes", "NodeMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr);
		NativeFieldInfoPtr_MenuName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr, "MenuName");
		NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr, "Order");
		NativeFieldInfoPtr_AddSeparatorAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr, "AddSeparatorAfter");
		NativeFieldInfoPtr_AddSeparatorBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr, "AddSeparatorBefore");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr, 100669258);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749670, XrefRangeEnd = 749671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NodeMenu(string menuName, int order, bool addSeparatorAfter = false, bool addSeparatorBefore = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeMenu>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &order;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &addSeparatorAfter;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &addSeparatorBefore;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NodeMenu(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
