using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ChartAndGraph;

public class HorizontalAxis : AxisBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__get_Assign_b__1_0_Private_Void_IInternalUse_Boolean_0;

	public unsafe override Il2CppSystem.Action<IInternalUse, bool> Assign
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751273, XrefRangeEnd = 751281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static HorizontalAxis()
	{
		Il2CppClassPointerStore<HorizontalAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "HorizontalAxis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalAxis>.NativeClassPtr);
		NativeMethodInfoPtr_get_Assign_Protected_Virtual_get_Action_2_IInternalUse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalAxis>.NativeClassPtr, 100669513);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalAxis>.NativeClassPtr, 100669514);
		NativeMethodInfoPtr__get_Assign_b__1_0_Private_Void_IInternalUse_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalAxis>.NativeClassPtr, 100669515);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751281, XrefRangeEnd = 751282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorizontalAxis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalAxis>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751282, XrefRangeEnd = 751291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _get_Assign_b__1_0(IInternalUse x, bool clear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_Assign_b__1_0_Private_Void_IInternalUse_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HorizontalAxis(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
