using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ChartAndGraph;

[System.Serializable]
public class ChartAdancedSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_FractionDigits;

	private static readonly System.IntPtr NativeFieldInfoPtr_ValueFractionDigits;

	private static readonly System.IntPtr NativeFieldInfoPtr_AxisFractionDigits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ChartAdancedSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InnerFormat_Private_String_String_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFormat_Private_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatFractionDigits_Public_String_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ChartAdancedSettings mInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartAdancedSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chartAdancedSettings));
		}
	}

	public unsafe static Il2CppStringArray FractionDigits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FractionDigits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FractionDigits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int ValueFractionDigits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueFractionDigits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueFractionDigits)) = num;
		}
	}

	public unsafe int AxisFractionDigits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AxisFractionDigits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AxisFractionDigits)) = num;
		}
	}

	public unsafe static ChartAdancedSettings Instance
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 753505, RefRangeEnd = 753519, XrefRangeStart = 753493, XrefRangeEnd = 753505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_ChartAdancedSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartAdancedSettings>(intPtr) : null;
		}
	}

	static ChartAdancedSettings()
	{
		Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartAdancedSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr);
		NativeFieldInfoPtr_mInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, "mInstance");
		NativeFieldInfoPtr_FractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, "FractionDigits");
		NativeFieldInfoPtr_ValueFractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, "ValueFractionDigits");
		NativeFieldInfoPtr_AxisFractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, "AxisFractionDigits");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_ChartAdancedSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, 100669742);
		NativeMethodInfoPtr_InnerFormat_Private_String_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, 100669743);
		NativeMethodInfoPtr_getFormat_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, 100669744);
		NativeMethodInfoPtr_FormatFractionDigits_Public_String_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, 100669745);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr, 100669746);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753524, RefRangeEnd = 753525, XrefRangeStart = 753519, XrefRangeEnd = 753524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InnerFormat(string format, double val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InnerFormat_Private_String_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753525, XrefRangeEnd = 753530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getFormat(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFormat_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 753539, RefRangeEnd = 753553, XrefRangeStart = 753530, XrefRangeEnd = 753539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatFractionDigits(int digits, double val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&digits);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatFractionDigits_Public_String_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753553, XrefRangeEnd = 753554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartAdancedSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartAdancedSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartAdancedSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
