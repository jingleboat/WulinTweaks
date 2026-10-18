using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Pathfinding.Voxels;

[StructLayout(LayoutKind.Explicit)]
public struct CompactVoxelCell
{
	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

	[FieldOffset(0)]
	public uint index;

	[FieldOffset(4)]
	public uint count;

	static CompactVoxelCell()
	{
		Il2CppClassPointerStore<CompactVoxelCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Voxels", "CompactVoxelCell");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompactVoxelCell>.NativeClassPtr);
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVoxelCell>.NativeClassPtr, "index");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVoxelCell>.NativeClassPtr, "count");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompactVoxelCell>.NativeClassPtr, 100683884);
	}

	[CallerCount(98)]
	[CachedScanResults(RefRangeStart = 42244, RefRangeEnd = 42342, XrefRangeStart = 42244, XrefRangeEnd = 42342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompactVoxelCell(uint i, uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CompactVoxelCell>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
