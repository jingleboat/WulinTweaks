using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class StoryGroupNoteData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TableIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextName;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphDataList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int TableIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TableIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TableIndex)) = num;
		}
	}

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

	public unsafe List<GraphUIData> graphDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GraphUIData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static StoryGroupNoteData()
	{
		Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "StoryGroupNoteData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr);
		NativeFieldInfoPtr_TableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr, "TableIndex");
		NativeFieldInfoPtr_TextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr, "TextName");
		NativeFieldInfoPtr_graphDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr, "graphDataList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr, 100673909);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 854819, RefRangeEnd = 854820, XrefRangeStart = 854810, XrefRangeEnd = 854819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StoryGroupNoteData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoryGroupNoteData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StoryGroupNoteData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
