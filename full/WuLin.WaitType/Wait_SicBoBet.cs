using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace WuLin.WaitType;

[StructLayout(LayoutKind.Explicit)]
public struct Wait_SicBoBet
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Error_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Error_Public_Virtual_Final_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Error_Public_Virtual_Final_New_set_Void_Int32_0;

	[FieldOffset(0)]
	public int _Error_k__BackingField;

	public unsafe virtual int Error
	{
		[CallerCount(125)]
		[CachedScanResults(RefRangeStart = 32397, RefRangeEnd = 32522, XrefRangeStart = 32397, XrefRangeEnd = 32522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Error_Public_Virtual_Final_New_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 32305, RefRangeEnd = 32343, XrefRangeStart = 32305, XrefRangeEnd = 32343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Error_Public_Virtual_Final_New_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Wait_SicBoBet()
	{
		Il2CppClassPointerStore<Wait_SicBoBet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.WaitType", "Wait_SicBoBet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wait_SicBoBet>.NativeClassPtr);
		NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wait_SicBoBet>.NativeClassPtr, "<Error>k__BackingField");
		NativeMethodInfoPtr_get_Error_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wait_SicBoBet>.NativeClassPtr, 100681505);
		NativeMethodInfoPtr_set_Error_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wait_SicBoBet>.NativeClassPtr, 100681506);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Wait_SicBoBet>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
