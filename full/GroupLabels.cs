using System;
using System.Runtime.CompilerServices;
using ChartAndGraph;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class GroupLabels : ItemLabelsBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_alignment;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_GroupLabelAlignment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Alignment_Public_set_Void_GroupLabelAlignment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__get_Assign_b__5_0_Private_Void_IInternalUse_Boolean_0;

	public unsafe GroupLabelAlignment alignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignment);
			return *(GroupLabelAlignment*)num;
		}
		set
		{
			*(GroupLabelAlignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignment)) = groupLabelAlignment;
		}
	}

	public unsafe GroupLabelAlignment Alignment
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Alignment_Public_get_GroupLabelAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(GroupLabelAlignment*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Alignment_Public_set_Void_GroupLabelAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe override Il2CppSystem.Action<IInternalUse, bool> Assign
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670641, XrefRangeEnd = 670649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static GroupLabels()
	{
		Il2CppClassPointerStore<GroupLabels>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GroupLabels");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr);
		NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr, "alignment");
		NativeMethodInfoPtr_get_Alignment_Public_get_GroupLabelAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_set_Alignment_Public_set_Void_GroupLabelAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr, 100663710);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr, 100663711);
		NativeMethodInfoPtr__get_Assign_b__5_0_Private_Void_IInternalUse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr, 100663712);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 670650, RefRangeEnd = 670652, XrefRangeStart = 670649, XrefRangeEnd = 670650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GroupLabels()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupLabels>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670652, XrefRangeEnd = 670661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _get_Assign_b__5_0(IInternalUse x, bool clear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_Assign_b__5_0_Private_Void_IInternalUse_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GroupLabels(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
