using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace XLua;

public class OverloadMethodWrap : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_translator;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetType;

	private static readonly System.IntPtr NativeFieldInfoPtr_method;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_castArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_inPosArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_outPosArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOptionalArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultValueArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_isVoid;

	private static readonly System.IntPtr NativeFieldInfoPtr_luaStackPosStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetNeeded;

	private static readonly System.IntPtr NativeFieldInfoPtr_args;

	private static readonly System.IntPtr NativeFieldInfoPtr_refPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_paramsType;

	private static readonly System.IntPtr NativeFieldInfoPtr__HasDefalutValue_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDefalutValue_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HasDefalutValue_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectTranslator_Type_MethodBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_ObjectCheckers_ObjectCasters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Call_Public_Int32_IntPtr_0;

	public unsafe ObjectTranslator translator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectTranslator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectTranslator));
		}
	}

	public unsafe Il2CppSystem.Type targetType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe MethodBase method
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)methodBase));
		}
	}

	public unsafe Il2CppReferenceArray<ObjectCheck> checkArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectCheck>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<ObjectCast> castArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_castArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectCast>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_castArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> inPosArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inPosArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inPosArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> outPosArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outPosArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outPosArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<bool> isOptionalArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOptionalArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOptionalArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppSystem.Object> defaultValueArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultValueArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultValueArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool isVoid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isVoid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isVoid)) = flag;
		}
	}

	public unsafe int luaStackPosStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luaStackPosStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luaStackPosStart)) = num;
		}
	}

	public unsafe bool targetNeeded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetNeeded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetNeeded)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppSystem.Object> args
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_args);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_args)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> refPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppSystem.Type paramsType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramsType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramsType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe bool _HasDefalutValue_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasDefalutValue_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasDefalutValue_k__BackingField)) = flag;
		}
	}

	public unsafe bool HasDefalutValue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasDefalutValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HasDefalutValue_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static OverloadMethodWrap()
	{
		Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "OverloadMethodWrap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr);
		NativeFieldInfoPtr_translator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "translator");
		NativeFieldInfoPtr_targetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "targetType");
		NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "method");
		NativeFieldInfoPtr_checkArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "checkArray");
		NativeFieldInfoPtr_castArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "castArray");
		NativeFieldInfoPtr_inPosArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "inPosArray");
		NativeFieldInfoPtr_outPosArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "outPosArray");
		NativeFieldInfoPtr_isOptionalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "isOptionalArray");
		NativeFieldInfoPtr_defaultValueArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "defaultValueArray");
		NativeFieldInfoPtr_isVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "isVoid");
		NativeFieldInfoPtr_luaStackPosStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "luaStackPosStart");
		NativeFieldInfoPtr_targetNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "targetNeeded");
		NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "args");
		NativeFieldInfoPtr_refPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "refPos");
		NativeFieldInfoPtr_paramsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "paramsType");
		NativeFieldInfoPtr__HasDefalutValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, "<HasDefalutValue>k__BackingField");
		NativeMethodInfoPtr_get_HasDefalutValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, 100664832);
		NativeMethodInfoPtr_set_HasDefalutValue_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, 100664833);
		NativeMethodInfoPtr__ctor_Public_Void_ObjectTranslator_Type_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, 100664834);
		NativeMethodInfoPtr_Init_Public_Void_ObjectCheckers_ObjectCasters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, 100664835);
		NativeMethodInfoPtr_Check_Public_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, 100664836);
		NativeMethodInfoPtr_Call_Public_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr, 100664837);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 696797, RefRangeEnd = 696798, XrefRangeStart = 696796, XrefRangeEnd = 696797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OverloadMethodWrap(ObjectTranslator translator, Il2CppSystem.Type targetType, MethodBase method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadMethodWrap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)translator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ObjectTranslator_Type_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 696950, RefRangeEnd = 696951, XrefRangeStart = 696798, XrefRangeEnd = 696950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(ObjectCheckers objCheckers, ObjectCasters objCasters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objCheckers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objCasters);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_ObjectCheckers_ObjectCasters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 696962, RefRangeEnd = 696963, XrefRangeStart = 696951, XrefRangeEnd = 696962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Check(System.IntPtr L)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697000, RefRangeEnd = 697002, XrefRangeStart = 696963, XrefRangeEnd = 697000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Call(System.IntPtr L)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Call_Public_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public OverloadMethodWrap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
