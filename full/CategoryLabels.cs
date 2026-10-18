using System;
using System.Runtime.CompilerServices;
using ChartAndGraph;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class CategoryLabels : AlignedItemLabels
{
	public enum ChartCategoryLabelOptions
	{
		All,
		FirstOnly
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleLabels;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VisibleLabels_Public_get_ChartCategoryLabelOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_VisibleLabels_Public_set_Void_ChartCategoryLabelOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__get_Assign_b__6_0_Private_Void_IInternalUse_Boolean_0;

	public unsafe ChartCategoryLabelOptions visibleLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLabels);
			return *(ChartCategoryLabelOptions*)num;
		}
		set
		{
			*(ChartCategoryLabelOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLabels)) = chartCategoryLabelOptions;
		}
	}

	public unsafe ChartCategoryLabelOptions VisibleLabels
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VisibleLabels_Public_get_ChartCategoryLabelOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ChartCategoryLabelOptions*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_VisibleLabels_Public_set_Void_ChartCategoryLabelOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe override Il2CppSystem.Action<IInternalUse, bool> Assign
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670623, XrefRangeEnd = 670631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<IInternalUse, bool>>(intPtr) : null;
		}
	}

	static CategoryLabels()
	{
		Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CategoryLabels");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr);
		NativeFieldInfoPtr_visibleLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr, "visibleLabels");
		NativeMethodInfoPtr_get_VisibleLabels_Public_get_ChartCategoryLabelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr, 100663703);
		NativeMethodInfoPtr_set_VisibleLabels_Public_set_Void_ChartCategoryLabelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr, 100663704);
		NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr, 100663705);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr, 100663706);
		NativeMethodInfoPtr__get_Assign_b__6_0_Private_Void_IInternalUse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr, 100663707);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670631, XrefRangeEnd = 670632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CategoryLabels()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryLabels>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670632, XrefRangeEnd = 670641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _get_Assign_b__6_0(IInternalUse x, bool clear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_Assign_b__6_0_Private_Void_IInternalUse_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CategoryLabels(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
