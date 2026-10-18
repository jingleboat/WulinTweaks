using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Pathfinding.Util;

public class Checksum : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetChecksum_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Checksum()
	{
		Il2CppClassPointerStore<Checksum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "Checksum");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Checksum>.NativeClassPtr);
		NativeMethodInfoPtr_GetChecksum_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Checksum>.NativeClassPtr, 100684380);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Checksum>.NativeClassPtr, 100684381);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1085188, RefRangeEnd = 1085195, XrefRangeStart = 1085187, XrefRangeEnd = 1085188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetChecksum(Il2CppStructArray<byte> arr, uint hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hash;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChecksum_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Checksum()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Checksum>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Checksum(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
