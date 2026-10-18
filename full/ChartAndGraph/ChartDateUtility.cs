using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace ChartAndGraph;

public class ChartDateUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Epoch;

	private static readonly System.IntPtr NativeMethodInfoPtr_DateToValue_Public_Static_Double_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DateToTimeString_Public_Static_String_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DateToDateString_Public_Static_String_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DateToDateTimeString_Public_Static_String_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValueToDate_Public_Static_DateTime_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppSystem.DateTime Epoch
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.DateTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Epoch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Epoch, (void*)(&dateTime));
		}
	}

	static ChartDateUtility()
	{
		Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartDateUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr);
		NativeFieldInfoPtr_Epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, "Epoch");
		NativeMethodInfoPtr_DateToValue_Public_Static_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, 100669779);
		NativeMethodInfoPtr_DateToTimeString_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, 100669780);
		NativeMethodInfoPtr_DateToDateString_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, 100669781);
		NativeMethodInfoPtr_DateToDateTimeString_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, 100669782);
		NativeMethodInfoPtr_ValueToDate_Public_Static_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, 100669783);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr, 100669784);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 754000, RefRangeEnd = 754012, XrefRangeStart = 753991, XrefRangeEnd = 754000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double DateToValue(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DateToValue_Public_Static_Double_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 754015, RefRangeEnd = 754019, XrefRangeStart = 754012, XrefRangeEnd = 754015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DateToTimeString(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DateToTimeString_Public_Static_String_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 754022, RefRangeEnd = 754026, XrefRangeStart = 754019, XrefRangeEnd = 754022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DateToDateString(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DateToDateString_Public_Static_String_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 754036, RefRangeEnd = 754040, XrefRangeStart = 754026, XrefRangeEnd = 754036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DateToDateTimeString(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DateToDateTimeString_Public_Static_String_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 754048, RefRangeEnd = 754052, XrefRangeStart = 754040, XrefRangeEnd = 754048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime ValueToDate(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValueToDate_Public_Static_DateTime_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartDateUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartDateUtility>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartDateUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
