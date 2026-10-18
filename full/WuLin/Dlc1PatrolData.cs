using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class Dlc1PatrolData : Dlc1DelayAction
{
	private static readonly IntPtr NativeFieldInfoPtr_provinceId;

	private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int provinceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_provinceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_provinceId)) = num;
		}
	}

	static Dlc1PatrolData()
	{
		Il2CppClassPointerStore<Dlc1PatrolData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "Dlc1PatrolData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dlc1PatrolData>.NativeClassPtr);
		NativeFieldInfoPtr_provinceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1PatrolData>.NativeClassPtr, "provinceId");
		NativeMethodInfoPtr_Invoke_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1PatrolData>.NativeClassPtr, 100679021);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1PatrolData>.NativeClassPtr, 100679022);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990226, XrefRangeEnd = 990234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Invoke_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 990235, RefRangeEnd = 990239, XrefRangeStart = 990234, XrefRangeEnd = 990235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1PatrolData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1PatrolData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Dlc1PatrolData(IntPtr pointer)
		: base(pointer)
	{
	}
}
