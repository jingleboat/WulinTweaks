using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class LogItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Content;

	private static readonly System.IntPtr NativeFieldInfoPtr_LogType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string Content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Content);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Content)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe LogItemType LogType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LogType);
			return *(LogItemType*)num;
		}
		set
		{
			*(LogItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LogType)) = logItemType;
		}
	}

	static LogItem()
	{
		Il2CppClassPointerStore<LogItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LogItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogItem>.NativeClassPtr);
		NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogItem>.NativeClassPtr, "Content");
		NativeFieldInfoPtr_LogType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogItem>.NativeClassPtr, "LogType");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogItem>.NativeClassPtr, 100664203);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LogItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
