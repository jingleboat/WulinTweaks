using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using XLua.LuaDLL;

namespace XLua;

public class StaticLuaCallbacks : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GcMeta;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToStringMeta;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnumAndMeta;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnumOrMeta;

	private static readonly System.IntPtr NativeFieldInfoPtr_StaticCSFunctionWraper;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixCSFunctionWraper;

	private static readonly System.IntPtr NativeFieldInfoPtr_DelegateCtor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumAnd_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumOr_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StaticCSFunction_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixCSFunction_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelegateCall_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LuaGC_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelegateCombine_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelegateRemove_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryPrimitiveArrayGet_Private_Static_Boolean_Type_IntPtr_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayIndexer_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryPrimitiveArraySet_Public_Static_Boolean_Type_IntPtr_Object_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayNewIndexer_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayLength_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MetaFuncIndex_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Panic_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Print_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSocketCore_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCS_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBuiltinLib_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromResource_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromStreamingAssetsPath_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromCustomLoaders_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssembly_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportType_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportGenericType_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cast_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getType_Private_Static_Type_IntPtr_ObjectTranslator_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XLuaAccess_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XLuaPrivateAccessible_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XLuaMetatableOperation_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelegateConstructor_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFunction_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenericMethodWraper_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericMethod_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseCsObject_Public_Static_Int32_IntPtr_0;

	public unsafe lua_CSFunction GcMeta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GcMeta);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GcMeta)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe lua_CSFunction ToStringMeta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToStringMeta);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToStringMeta)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe lua_CSFunction EnumAndMeta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnumAndMeta);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnumAndMeta)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe lua_CSFunction EnumOrMeta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnumOrMeta);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnumOrMeta)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe lua_CSFunction StaticCSFunctionWraper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticCSFunctionWraper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticCSFunctionWraper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe lua_CSFunction FixCSFunctionWraper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixCSFunctionWraper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixCSFunctionWraper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	public unsafe lua_CSFunction DelegateCtor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DelegateCtor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<lua_CSFunction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DelegateCtor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lua_CSFunction2));
		}
	}

	static StaticLuaCallbacks()
	{
		Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "StaticLuaCallbacks");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr);
		NativeFieldInfoPtr_GcMeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "GcMeta");
		NativeFieldInfoPtr_ToStringMeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "ToStringMeta");
		NativeFieldInfoPtr_EnumAndMeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "EnumAndMeta");
		NativeFieldInfoPtr_EnumOrMeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "EnumOrMeta");
		NativeFieldInfoPtr_StaticCSFunctionWraper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "StaticCSFunctionWraper");
		NativeFieldInfoPtr_FixCSFunctionWraper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "FixCSFunctionWraper");
		NativeFieldInfoPtr_DelegateCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, "DelegateCtor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_EnumAnd_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_EnumOr_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_StaticCSFunction_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_FixCSFunction_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_DelegateCall_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_LuaGC_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_ToString_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_DelegateCombine_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_DelegateRemove_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_tryPrimitiveArrayGet_Private_Static_Boolean_Type_IntPtr_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_ArrayIndexer_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_TryPrimitiveArraySet_Public_Static_Boolean_Type_IntPtr_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_ArrayNewIndexer_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_ArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_MetaFuncIndex_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_Panic_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_Print_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_LoadSocketCore_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_LoadCS_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_LoadBuiltinLib_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_LoadFromResource_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_LoadFromStreamingAssetsPath_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_LoadFromCustomLoaders_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_LoadAssembly_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr_ImportType_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr_ImportGenericType_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr_Cast_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr_getType_Private_Static_Type_IntPtr_ObjectTranslator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr_XLuaAccess_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr_XLuaPrivateAccessible_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr_XLuaMetatableOperation_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr_DelegateConstructor_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr_ToFunction_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr_GenericMethodWraper_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr_GetGenericMethod_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr_ReleaseCsObject_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr, 100665021);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700429, RefRangeEnd = 700430, XrefRangeStart = 700392, XrefRangeEnd = 700429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StaticLuaCallbacks()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticLuaCallbacks>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700430, XrefRangeEnd = 700461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int EnumAnd(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumAnd_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700461, XrefRangeEnd = 700492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int EnumOr(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumOr_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700492, XrefRangeEnd = 700505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int StaticCSFunction(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StaticCSFunction_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700505, XrefRangeEnd = 700517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FixCSFunction(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixCSFunction_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700517, XrefRangeEnd = 700535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DelegateCall(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelegateCall_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700535, XrefRangeEnd = 700545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LuaGC(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LuaGC_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700545, XrefRangeEnd = 700562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToString(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700562, XrefRangeEnd = 700586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DelegateCombine(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelegateCombine_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700586, XrefRangeEnd = 700612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DelegateRemove(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelegateRemove_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700765, RefRangeEnd = 700766, XrefRangeStart = 700612, XrefRangeEnd = 700765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool tryPrimitiveArrayGet(Il2CppSystem.Type type, System.IntPtr L, Il2CppSystem.Object obj, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &L;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryPrimitiveArrayGet_Private_Static_Boolean_Type_IntPtr_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700766, XrefRangeEnd = 700813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ArrayIndexer(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayIndexer_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 701008, RefRangeEnd = 701010, XrefRangeStart = 700813, XrefRangeEnd = 701008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryPrimitiveArraySet(Il2CppSystem.Type type, System.IntPtr L, Il2CppSystem.Object obj, int array_idx, int obj_idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &L;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &array_idx;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &obj_idx;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPrimitiveArraySet_Public_Static_Boolean_Type_IntPtr_Object_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701010, XrefRangeEnd = 701057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ArrayNewIndexer(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayNewIndexer_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701057, XrefRangeEnd = 701070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ArrayLength(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayLength_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701070, XrefRangeEnd = 701091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MetaFuncIndex(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MetaFuncIndex_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701091, XrefRangeEnd = 701099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Panic(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Panic_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701099, XrefRangeEnd = 701134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Print(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Print_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701134, XrefRangeEnd = 701135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadSocketCore(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSocketCore_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701135, XrefRangeEnd = 701140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadCS(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCS_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701140, XrefRangeEnd = 701158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadBuiltinLib(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBuiltinLib_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701158, XrefRangeEnd = 701194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFromResource(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromResource_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701194, XrefRangeEnd = 701234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFromStreamingAssetsPath(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromStreamingAssetsPath_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701234, XrefRangeEnd = 701272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFromCustomLoaders(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromCustomLoaders_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701272, XrefRangeEnd = 701292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadAssembly(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssembly_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701292, XrefRangeEnd = 701316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ImportType(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportType_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701316, XrefRangeEnd = 701361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ImportGenericType(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportGenericType_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701361, XrefRangeEnd = 701393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Cast(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cast_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 701404, RefRangeEnd = 701411, XrefRangeStart = 701393, XrefRangeEnd = 701404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type getType(System.IntPtr L, ObjectTranslator translator, int idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&L);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)translator);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getType_Private_Static_Type_IntPtr_ObjectTranslator_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701411, XrefRangeEnd = 701459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int XLuaAccess(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XLuaAccess_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701459, XrefRangeEnd = 701482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int XLuaPrivateAccessible(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XLuaPrivateAccessible_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701482, XrefRangeEnd = 701519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int XLuaMetatableOperation(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XLuaMetatableOperation_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701519, XrefRangeEnd = 701543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DelegateConstructor(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelegateConstructor_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701543, XrefRangeEnd = 701571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToFunction(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFunction_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701571, XrefRangeEnd = 701614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GenericMethodWraper(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenericMethodWraper_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701614, XrefRangeEnd = 701651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGenericMethod(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericMethod_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701651, XrefRangeEnd = 701660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReleaseCsObject(System.IntPtr L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseCsObject_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public StaticLuaCallbacks(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
