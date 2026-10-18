using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Pathfinding.Voxels;

[StructLayout(LayoutKind.Explicit)]
public struct CompactVoxelSpan
{
	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_con;

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_reg;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConnection_Public_Void_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConnection_Public_Int32_Int32_0;

	[FieldOffset(0)]
	public ushort y;

	[FieldOffset(4)]
	public uint con;

	[FieldOffset(8)]
	public uint h;

	[FieldOffset(12)]
	public int reg;

	static CompactVoxelSpan()
	{
		Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Voxels", "CompactVoxelSpan");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr);
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, "y");
		NativeFieldInfoPtr_con = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, "con");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, "h");
		NativeFieldInfoPtr_reg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, "reg");
		NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, 100683885);
		NativeMethodInfoPtr_SetConnection_Public_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, 100683886);
		NativeMethodInfoPtr_GetConnection_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, 100683887);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078124, RefRangeEnd = 1078125, XrefRangeStart = 1078124, XrefRangeEnd = 1078124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompactVoxelSpan(ushort bottom, uint height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bottom);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078125, RefRangeEnd = 1078126, XrefRangeStart = 1078125, XrefRangeEnd = 1078125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConnection(int dir, uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dir);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConnection_Public_Void_Int32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 1078126, RefRangeEnd = 1078170, XrefRangeStart = 1078126, XrefRangeEnd = 1078126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetConnection(int dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConnection_Public_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CompactVoxelSpan>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
