using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using XLua.LuaDLL;

namespace XLua.TemplateEngine;

public class LuaTemplate : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_templateCompileFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr_templateExecuteFunction;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComposeCode_Public_Static_String_List_1_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Public_Static_LuaFunction_LuaEnv_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_String_LuaFunction_LuaTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_String_LuaFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenLib_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static lua_CSFunction templateCompileFunction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_templateCompileFunction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_templateCompileFunction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe static lua_CSFunction templateExecuteFunction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_templateExecuteFunction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_templateExecuteFunction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	static LuaTemplate()
	{
		Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.TemplateEngine", "LuaTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_templateCompileFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, "templateCompileFunction");
		NativeFieldInfoPtr_templateExecuteFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, "templateExecuteFunction");
		NativeMethodInfoPtr_ComposeCode_Public_Static_String_List_1_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665080);
		NativeMethodInfoPtr_Compile_Public_Static_LuaFunction_LuaEnv_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665081);
		NativeMethodInfoPtr_Execute_Public_Static_String_LuaFunction_LuaTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665082);
		NativeMethodInfoPtr_Execute_Public_Static_String_LuaFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665083);
		NativeMethodInfoPtr_Compile_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665084);
		NativeMethodInfoPtr_Execute_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665085);
		NativeMethodInfoPtr_OpenLib_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665086);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr, 100665087);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 703887, RefRangeEnd = 703889, XrefRangeStart = 703848, XrefRangeEnd = 703887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ComposeCode(List<Chunk> chunks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunks);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComposeCode_Public_Static_String_List_1_Chunk_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703889, XrefRangeEnd = 703902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LuaFunction Compile(LuaEnv luaenv, string snippet)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luaenv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(snippet);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Public_Static_LuaFunction_LuaEnv_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LuaFunction>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703902, XrefRangeEnd = 703913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Execute(LuaFunction compiledTemplate, LuaTable parameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compiledTemplate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Static_String_LuaFunction_LuaTable_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703913, XrefRangeEnd = 703920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Execute(LuaFunction compiledTemplate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compiledTemplate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Static_String_LuaFunction_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703920, XrefRangeEnd = 703950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compile(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703950, XrefRangeEnd = 703955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Execute(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703955, XrefRangeEnd = 703974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenLib(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenLib_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LuaTemplate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LuaTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
