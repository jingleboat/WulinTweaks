using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ChartAndGraph;

[Serializable]
public class ChartSubDivisionInfo : ChartDivisionInfo
{
	private static readonly IntPtr NativeMethodInfoPtr_ValidateTotal_Protected_Virtual_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ChartSubDivisionInfo()
	{
		Il2CppClassPointerStore<ChartSubDivisionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartSubDivisionInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartSubDivisionInfo>.NativeClassPtr);
		NativeMethodInfoPtr_ValidateTotal_Protected_Virtual_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSubDivisionInfo>.NativeClassPtr, 100669511);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSubDivisionInfo>.NativeClassPtr, 100669512);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751272, XrefRangeEnd = 751273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float ValidateTotal(float total)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&total);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ValidateTotal_Protected_Virtual_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 751270, RefRangeEnd = 751272, XrefRangeStart = 751270, XrefRangeEnd = 751272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartSubDivisionInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartSubDivisionInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartSubDivisionInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
