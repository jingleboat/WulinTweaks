using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Doozy.Engine.Utils;

public static class ScriptUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_STRING_SEPARATOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_BASE64_IDENTIFIER;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeString_Public_Static_String_String_0;

	public unsafe static char STRING_SEPARATOR
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STRING_SEPARATOR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STRING_SEPARATOR, (void*)(&c));
		}
	}

	public unsafe static string BASE64_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BASE64_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BASE64_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool debug
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_debug, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_debug, (void*)(&flag));
		}
	}

	static ScriptUtils()
	{
		Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "ScriptUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr);
		NativeFieldInfoPtr_STRING_SEPARATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr, "STRING_SEPARATOR");
		NativeFieldInfoPtr_BASE64_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr, "BASE64_IDENTIFIER");
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr, "debug");
		NativeMethodInfoPtr_DecodeString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr, 100667422);
		NativeMethodInfoPtr_EncodeString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUtils>.NativeClassPtr, 100667423);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726737, XrefRangeEnd = 726747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecodeString(string data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726747, XrefRangeEnd = 726759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeString(string data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public ScriptUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
