using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ChartAndGraph.DataSource;

public class ChartDataColumn : ChartDataItemBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static ChartDataColumn()
	{
		Il2CppClassPointerStore<ChartDataColumn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph.DataSource", "ChartDataColumn");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartDataColumn>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataColumn>.NativeClassPtr, 100670748);
	}

	[CallerCount(171)]
	[CachedScanResults(RefRangeStart = 27398, RefRangeEnd = 27569, XrefRangeStart = 27398, XrefRangeEnd = 27569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartDataColumn(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartDataColumn>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartDataColumn(IntPtr pointer)
		: base(pointer)
	{
	}
}
