using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ChartAndGraph;

[Serializable]
public class ChartMainDivisionInfo : ChartDivisionInfo
{
	private static readonly IntPtr NativeMethodInfoPtr_get_Messure_Public_get_DivisionMessure_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Messure_Public_set_Void_DivisionMessure_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UnitsPerDivision_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_UnitsPerDivision_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DivisionMessure Messure
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Messure_Public_get_DivisionMessure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DivisionMessure*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Messure_Public_set_Void_DivisionMessure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float UnitsPerDivision
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnitsPerDivision_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UnitsPerDivision_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ChartMainDivisionInfo()
	{
		Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartMainDivisionInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr);
		NativeMethodInfoPtr_get_Messure_Public_get_DivisionMessure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr, 100669506);
		NativeMethodInfoPtr_set_Messure_Public_set_Void_DivisionMessure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr, 100669507);
		NativeMethodInfoPtr_get_UnitsPerDivision_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr, 100669508);
		NativeMethodInfoPtr_set_UnitsPerDivision_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr, 100669509);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr, 100669510);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 751270, RefRangeEnd = 751272, XrefRangeStart = 751269, XrefRangeEnd = 751270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartMainDivisionInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartMainDivisionInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartMainDivisionInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
