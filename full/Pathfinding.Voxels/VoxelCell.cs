using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding.Voxels;

public sealed class VoxelCell : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_firstSpan;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpan_Public_Void_UInt32_UInt32_Int32_Int32_0;

	public unsafe VoxelSpan firstSpan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpan);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VoxelSpan>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpan)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)voxelSpan));
		}
	}

	static VoxelCell()
	{
		Il2CppClassPointerStore<VoxelCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Voxels", "VoxelCell");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoxelCell>.NativeClassPtr);
		NativeFieldInfoPtr_firstSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelCell>.NativeClassPtr, "firstSpan");
		NativeMethodInfoPtr_AddSpan_Public_Void_UInt32_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoxelCell>.NativeClassPtr, 100683883);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078112, XrefRangeEnd = 1078124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpan(uint bottom, uint top, int area, int voxelWalkableClimb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&bottom);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &voxelWalkableClimb;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpan_Public_Void_UInt32_UInt32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VoxelCell(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public VoxelCell()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoxelCell>.NativeClassPtr))
	{
	}
}
