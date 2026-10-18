using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;

public static class DropdownExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_AddOptions_Public_Static_Void_TMP_Dropdown_List_1_String_Boolean_0;

	static DropdownExt()
	{
		Il2CppClassPointerStore<DropdownExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DropdownExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownExt>.NativeClassPtr);
		NativeMethodInfoPtr_AddOptions_Public_Static_Void_TMP_Dropdown_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownExt>.NativeClassPtr, 100663960);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 673980, RefRangeEnd = 673981, XrefRangeStart = 673972, XrefRangeEnd = 673980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddOptions(this TMP_Dropdown dropdown, List<string> options, bool isLoc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dropdown);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLoc;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOptions_Public_Static_Void_TMP_Dropdown_List_1_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DropdownExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
