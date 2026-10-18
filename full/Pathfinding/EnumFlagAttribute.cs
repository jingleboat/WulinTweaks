using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Pathfinding;

public class EnumFlagAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static EnumFlagAttribute()
	{
		Il2CppClassPointerStore<EnumFlagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "EnumFlagAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumFlagAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumFlagAttribute>.NativeClassPtr, 100683677);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 57331, RefRangeEnd = 57368, XrefRangeStart = 57331, XrefRangeEnd = 57368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EnumFlagAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumFlagAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EnumFlagAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
