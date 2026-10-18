using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class SaveObjectTestOne : SaveObjectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_str1;

	private static readonly IntPtr NativeFieldInfoPtr_str2;

	private static readonly IntPtr NativeFieldInfoPtr_str3;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string str1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str1);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string str2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str2);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string str3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str3);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str3)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SaveObjectTestOne()
	{
		Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectTestOne");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr);
		NativeFieldInfoPtr_str1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr, "str1");
		NativeFieldInfoPtr_str2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr, "str2");
		NativeFieldInfoPtr_str3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr, "str3");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr, 100673744);
	}

	[CallerCount(70)]
	[CachedScanResults(RefRangeStart = 378729, RefRangeEnd = 378799, XrefRangeStart = 378729, XrefRangeEnd = 378799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectTestOne()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectTestOne>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectTestOne(IntPtr pointer)
		: base(pointer)
	{
	}
}
