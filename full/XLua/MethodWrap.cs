using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace XLua;

public class MethodWrap : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_methodName;

	private static readonly System.IntPtr NativeFieldInfoPtr_overloads;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceCheck;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_OverloadMethodWrap_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Call_Public_Int32_IntPtr_0;

	public unsafe string methodName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<OverloadMethodWrap> overloads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overloads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OverloadMethodWrap>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overloads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool forceCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCheck)) = flag;
		}
	}

	static MethodWrap()
	{
		Il2CppClassPointerStore<MethodWrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "MethodWrap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr);
		NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr, "methodName");
		NativeFieldInfoPtr_overloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr, "overloads");
		NativeFieldInfoPtr_forceCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr, "forceCheck");
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_OverloadMethodWrap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr, 100664838);
		NativeMethodInfoPtr_Call_Public_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr, 100664839);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697002, XrefRangeEnd = 697009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MethodWrap(string methodName, List<OverloadMethodWrap> overloads, bool forceCheck)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodWrap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overloads);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceCheck;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_OverloadMethodWrap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697009, XrefRangeEnd = 697028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public MethodWrap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
