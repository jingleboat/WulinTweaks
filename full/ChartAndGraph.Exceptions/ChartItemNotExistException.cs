using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ChartAndGraph.Exceptions;

public class ChartItemNotExistException : ChartException
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static ChartItemNotExistException()
	{
		Il2CppClassPointerStore<ChartItemNotExistException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph.Exceptions", "ChartItemNotExistException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartItemNotExistException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemNotExistException>.NativeClassPtr, 100670745);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartItemNotExistException(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartItemNotExistException>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartItemNotExistException(IntPtr pointer)
		: base(pointer)
	{
	}
}
