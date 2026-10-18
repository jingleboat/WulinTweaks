using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ChartAndGraph;

public class AlignedItemLabels : ItemLabelsBase
{
	private static readonly IntPtr NativeFieldInfoPtr_alignment;

	private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_ChartLabelAlignment_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Public_set_Void_ChartLabelAlignment_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe ChartLabelAlignment alignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignment);
			return *(ChartLabelAlignment*)num;
		}
		set
		{
			*(ChartLabelAlignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignment)) = chartLabelAlignment;
		}
	}

	public unsafe ChartLabelAlignment Alignment
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Alignment_Public_get_ChartLabelAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ChartLabelAlignment*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Alignment_Public_set_Void_ChartLabelAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static AlignedItemLabels()
	{
		Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "AlignedItemLabels");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr);
		NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr, "alignment");
		NativeMethodInfoPtr_get_Alignment_Public_get_ChartLabelAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr, 100670664);
		NativeMethodInfoPtr_set_Alignment_Public_set_Void_ChartLabelAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr, 100670665);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr, 100670666);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 670650, RefRangeEnd = 670652, XrefRangeStart = 670650, XrefRangeEnd = 670652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AlignedItemLabels()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlignedItemLabels>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AlignedItemLabels(IntPtr pointer)
		: base(pointer)
	{
	}
}
