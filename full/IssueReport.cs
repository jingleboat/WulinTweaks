using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class IssueReport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_timeReported;

	private static readonly System.IntPtr NativeFieldInfoPtr_reportText;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe Il2CppSystem.DateTime timeReported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeReported);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeReported)) = dateTime;
		}
	}

	public unsafe string reportText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static IssueReport()
	{
		Il2CppClassPointerStore<IssueReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IssueReport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IssueReport>.NativeClassPtr);
		NativeFieldInfoPtr_timeReported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IssueReport>.NativeClassPtr, "timeReported");
		NativeFieldInfoPtr_reportText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IssueReport>.NativeClassPtr, "reportText");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IssueReport>.NativeClassPtr, 100664138);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 684232, RefRangeEnd = 684233, XrefRangeStart = 684227, XrefRangeEnd = 684232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IssueReport(string reportText)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IssueReport>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(reportText);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IssueReport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
