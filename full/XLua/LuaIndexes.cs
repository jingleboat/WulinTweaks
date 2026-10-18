using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua;

public sealed class LuaIndexes : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_LUA_REGISTRYINDEX_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LUA_REGISTRYINDEX_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int LUA_REGISTRYINDEX
	{
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 698136, RefRangeEnd = 698175, XrefRangeStart = 698131, XrefRangeEnd = 698136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LUA_REGISTRYINDEX_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698175, XrefRangeEnd = 698180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LUA_REGISTRYINDEX_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static LuaIndexes()
	{
		Il2CppClassPointerStore<LuaIndexes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "LuaIndexes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaIndexes>.NativeClassPtr);
		NativeMethodInfoPtr_get_LUA_REGISTRYINDEX_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaIndexes>.NativeClassPtr, 100664910);
		NativeMethodInfoPtr_set_LUA_REGISTRYINDEX_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaIndexes>.NativeClassPtr, 100664911);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaIndexes>.NativeClassPtr, 100664912);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LuaIndexes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaIndexes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LuaIndexes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
