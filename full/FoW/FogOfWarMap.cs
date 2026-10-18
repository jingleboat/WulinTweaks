using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace FoW;

public class FogOfWarMap : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_resolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_plane;

	private static readonly System.IntPtr NativeFieldInfoPtr_physics;

	private static readonly System.IntPtr NativeFieldInfoPtr_filterMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_multithreaded;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FogOfWarTeam_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_FogOfWarTeam_0;

	public unsafe Vector2Int resolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution)) = vector2Int;
		}
	}

	public unsafe float size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = num;
		}
	}

	public unsafe Vector2 offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
		}
	}

	public unsafe float pixelSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelSize)) = num;
		}
	}

	public unsafe int pixelCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelCount)) = num;
		}
	}

	public unsafe FogOfWarPlane plane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plane);
			return *(FogOfWarPlane*)num;
		}
		set
		{
			*(FogOfWarPlane*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plane)) = fogOfWarPlane;
		}
	}

	public unsafe FogOfWarPhysics physics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physics);
			return *(FogOfWarPhysics*)num;
		}
		set
		{
			*(FogOfWarPhysics*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physics)) = fogOfWarPhysics;
		}
	}

	public unsafe FilterMode filterMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterMode);
			return *(FilterMode*)num;
		}
		set
		{
			*(FilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterMode)) = filterMode;
		}
	}

	public unsafe bool multithreaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multithreaded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multithreaded)) = flag;
		}
	}

	static FogOfWarMap()
	{
		Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarMap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr);
		NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "resolution");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "size");
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "offset");
		NativeFieldInfoPtr_pixelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "pixelSize");
		NativeFieldInfoPtr_pixelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "pixelCount");
		NativeFieldInfoPtr_plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "plane");
		NativeFieldInfoPtr_physics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "physics");
		NativeFieldInfoPtr_filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "filterMode");
		NativeFieldInfoPtr_multithreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, "multithreaded");
		NativeMethodInfoPtr__ctor_Public_Void_FogOfWarTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, 100666955);
		NativeMethodInfoPtr_Set_Public_Void_FogOfWarTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr, 100666956);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721248, XrefRangeEnd = 721249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarMap(FogOfWarTeam fow)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarMap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FogOfWarTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Set(FogOfWarTeam fow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_FogOfWarTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarMap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
