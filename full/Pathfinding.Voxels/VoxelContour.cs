using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding.Voxels;

public sealed class VoxelContour : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nverts;

	private static readonly System.IntPtr NativeFieldInfoPtr_verts;

	private static readonly System.IntPtr NativeFieldInfoPtr_rverts;

	private static readonly System.IntPtr NativeFieldInfoPtr_reg;

	private static readonly System.IntPtr NativeFieldInfoPtr_area;

	public unsafe int nverts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nverts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nverts)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> verts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> rverts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rverts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rverts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int reg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reg)) = num;
		}
	}

	public unsafe int area
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_area);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_area)) = num;
		}
	}

	static VoxelContour()
	{
		Il2CppClassPointerStore<VoxelContour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Voxels", "VoxelContour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr);
		NativeFieldInfoPtr_nverts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr, "nverts");
		NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr, "verts");
		NativeFieldInfoPtr_rverts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr, "rverts");
		NativeFieldInfoPtr_reg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr, "reg");
		NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr, "area");
	}

	public VoxelContour(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public VoxelContour()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoxelContour>.NativeClassPtr))
	{
	}
}
