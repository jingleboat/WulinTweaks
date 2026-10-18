using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua;

public class HotfixAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flag;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Flag_Public_get_HotfixFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HotfixFlag_0;

	public unsafe HotfixFlag flag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag);
			return *(HotfixFlag*)num;
		}
		set
		{
			*(HotfixFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag)) = hotfixFlag;
		}
	}

	public unsafe HotfixFlag Flag
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Flag_Public_get_HotfixFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(HotfixFlag*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static HotfixAttribute()
	{
		Il2CppClassPointerStore<HotfixAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "HotfixAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotfixAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotfixAttribute>.NativeClassPtr, "flag");
		NativeMethodInfoPtr_get_Flag_Public_get_HotfixFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotfixAttribute>.NativeClassPtr, 100664754);
		NativeMethodInfoPtr__ctor_Public_Void_HotfixFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotfixAttribute>.NativeClassPtr, 100664755);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 57193, RefRangeEnd = 57209, XrefRangeStart = 57193, XrefRangeEnd = 57209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotfixAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&e);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HotfixFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HotfixAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
