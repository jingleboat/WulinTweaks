using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class StoryGroup : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TextName;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphNameList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string TextName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> graphNameList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphNameList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphNameList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static StoryGroup()
	{
		Il2CppClassPointerStore<StoryGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "StoryGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoryGroup>.NativeClassPtr);
		NativeFieldInfoPtr_TextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoryGroup>.NativeClassPtr, "TextName");
		NativeFieldInfoPtr_graphNameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoryGroup>.NativeClassPtr, "graphNameList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoryGroup>.NativeClassPtr, 100673908);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 854808, RefRangeEnd = 854810, XrefRangeStart = 854799, XrefRangeEnd = 854808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StoryGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoryGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StoryGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
