using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Pathfinding.Voxels;

[StructLayout(LayoutKind.Explicit)]
public struct LinkedVoxelSpan
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bottom;

	private static readonly System.IntPtr NativeFieldInfoPtr_top;

	private static readonly System.IntPtr NativeFieldInfoPtr_next;

	private static readonly System.IntPtr NativeFieldInfoPtr_area;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Int32_Int32_0;

	[FieldOffset(0)]
	public uint bottom;

	[FieldOffset(4)]
	public uint top;

	[FieldOffset(8)]
	public int next;

	[FieldOffset(12)]
	public int area;

	static LinkedVoxelSpan()
	{
		Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Voxels", "LinkedVoxelSpan");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr);
		NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, "bottom");
		NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, "top");
		NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, "next");
		NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, "area");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, 100683875);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, 100683876);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078084, RefRangeEnd = 1078085, XrefRangeStart = 1078084, XrefRangeEnd = 1078084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LinkedVoxelSpan(uint bottom, uint top, int area)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&bottom);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078085, RefRangeEnd = 1078087, XrefRangeStart = 1078085, XrefRangeEnd = 1078085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LinkedVoxelSpan(uint bottom, uint top, int area, int next)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&bottom);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &next;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinkedVoxelSpan>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
