using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace XLua;

public class DelegateBridgeBase : LuaBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_firstKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_bindTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_errorFuncRef;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_LuaEnv_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDelegate_Public_Boolean_Type_byref_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDelegate_Public_Void_Type_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegateByType_Public_Virtual_New_Delegate_Type_0;

	public unsafe Il2CppSystem.Type firstKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstKey);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe Il2CppSystem.Delegate firstValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Delegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstValue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, Il2CppSystem.Delegate> bindTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindTo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Il2CppSystem.Delegate>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int errorFuncRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorFuncRef);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorFuncRef)) = num;
		}
	}

	static DelegateBridgeBase()
	{
		Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "DelegateBridgeBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr);
		NativeFieldInfoPtr_firstKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, "firstKey");
		NativeFieldInfoPtr_firstValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, "firstValue");
		NativeFieldInfoPtr_bindTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, "bindTo");
		NativeFieldInfoPtr_errorFuncRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, "errorFuncRef");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_LuaEnv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_TryGetDelegate_Public_Boolean_Type_byref_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr_AddDelegate_Public_Void_Type_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, 100664727);
		NativeMethodInfoPtr_GetDelegateByType_Public_Virtual_New_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr, 100664728);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 695404, RefRangeEnd = 695405, XrefRangeStart = 695403, XrefRangeEnd = 695404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DelegateBridgeBase(int reference, LuaEnv luaenv)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateBridgeBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luaenv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_LuaEnv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695405, XrefRangeEnd = 695414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetDelegate(Il2CppSystem.Type key, out Il2CppSystem.Delegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetDelegate_Public_Boolean_Type_byref_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		value = ((num3 == 0) ? null : new Il2CppSystem.Delegate(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 695424, RefRangeEnd = 695425, XrefRangeStart = 695414, XrefRangeEnd = 695424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDelegate(Il2CppSystem.Type key, Il2CppSystem.Delegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDelegate_Public_Void_Type_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 26795, RefRangeEnd = 26824, XrefRangeStart = 26795, XrefRangeEnd = 26824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Delegate GetDelegateByType(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDelegateByType_Public_Virtual_New_Delegate_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Delegate>(intPtr) : null;
	}

	public DelegateBridgeBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
