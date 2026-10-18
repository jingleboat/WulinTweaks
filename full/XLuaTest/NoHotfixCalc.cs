using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLuaTest;

public class NoHotfixCalc : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static NoHotfixCalc()
	{
		Il2CppClassPointerStore<NoHotfixCalc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "NoHotfixCalc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoHotfixCalc>.NativeClassPtr);
		NativeMethodInfoPtr_Add_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoHotfixCalc>.NativeClassPtr, 100665320);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoHotfixCalc>.NativeClassPtr, 100665321);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 695161, RefRangeEnd = 695162, XrefRangeStart = 695161, XrefRangeEnd = 695162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Add(int a, int b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoHotfixCalc()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoHotfixCalc>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NoHotfixCalc(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
