using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace XLua;

public static class HotfixDelegateBridge : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_xlua_get_hotfix_flag_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_DelegateBridge_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_Int32_DelegateBridge_0;

	static HotfixDelegateBridge()
	{
		Il2CppClassPointerStore<HotfixDelegateBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "HotfixDelegateBridge");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotfixDelegateBridge>.NativeClassPtr);
		NativeMethodInfoPtr_xlua_get_hotfix_flag_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotfixDelegateBridge>.NativeClassPtr, 100664729);
		NativeMethodInfoPtr_Get_Public_Static_DelegateBridge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotfixDelegateBridge>.NativeClassPtr, 100664730);
		NativeMethodInfoPtr_Set_Public_Static_Void_Int32_DelegateBridge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotfixDelegateBridge>.NativeClassPtr, 100664731);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695425, XrefRangeEnd = 695429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool xlua_get_hotfix_flag(int idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_xlua_get_hotfix_flag_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695429, XrefRangeEnd = 695433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DelegateBridge Get(int idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_DelegateBridge_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DelegateBridge>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695433, XrefRangeEnd = 695453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Set(int idx, DelegateBridge val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Static_Void_Int32_DelegateBridge_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HotfixDelegateBridge(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
