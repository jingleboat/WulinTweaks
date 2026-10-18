using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua;

public class LuaCallCSharpAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flag;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Flag_Public_get_GenFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GenFlag_0;

	public unsafe GenFlag flag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag);
			return *(GenFlag*)num;
		}
		set
		{
			*(GenFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag)) = genFlag;
		}
	}

	public unsafe GenFlag Flag
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Flag_Public_get_GenFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(GenFlag*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static LuaCallCSharpAttribute()
	{
		Il2CppClassPointerStore<LuaCallCSharpAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "LuaCallCSharpAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaCallCSharpAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaCallCSharpAttribute>.NativeClassPtr, "flag");
		NativeMethodInfoPtr_get_Flag_Public_get_GenFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaCallCSharpAttribute>.NativeClassPtr, 100664745);
		NativeMethodInfoPtr__ctor_Public_Void_GenFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaCallCSharpAttribute>.NativeClassPtr, 100664746);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 57193, RefRangeEnd = 57209, XrefRangeStart = 57193, XrefRangeEnd = 57209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LuaCallCSharpAttribute(GenFlag flag = GenFlag.No)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaCallCSharpAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GenFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LuaCallCSharpAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
