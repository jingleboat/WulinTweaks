using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Tutorial;

public class BaseClass : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BSF;

	private static readonly System.IntPtr NativeFieldInfoPtr__BMF_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_BSFunc_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BMFunc_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BMF_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BMF_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int BSF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BSF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BSF, (void*)(&num));
		}
	}

	public unsafe int _BMF_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BMF_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BMF_k__BackingField)) = num;
		}
	}

	public unsafe int BMF
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BMF_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57209, RefRangeEnd = 57214, XrefRangeStart = 57209, XrefRangeEnd = 57214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BMF_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static BaseClass()
	{
		Il2CppClassPointerStore<BaseClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tutorial", "BaseClass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseClass>.NativeClassPtr);
		NativeFieldInfoPtr_BSF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, "BSF");
		NativeFieldInfoPtr__BMF_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, "<BMF>k__BackingField");
		NativeMethodInfoPtr_BSFunc_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, 100664675);
		NativeMethodInfoPtr_BMFunc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, 100664676);
		NativeMethodInfoPtr_get_BMF_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, 100664677);
		NativeMethodInfoPtr_set_BMF_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, 100664678);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClass>.NativeClassPtr, 100664679);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695139, XrefRangeEnd = 695153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BSFunc()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BSFunc_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695153, XrefRangeEnd = 695161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BMFunc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BMFunc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseClass()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseClass>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BaseClass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
