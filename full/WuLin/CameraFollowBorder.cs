using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace WuLin;

public class CameraFollowBorder : MonoBehaviour
{
	public enum CameraSimulationRes
	{
		R1024_768,
		R1920_1080,
		R2560_1080,
		R4096_2160,
		R3440_1440
	}

	private static readonly IntPtr NativeFieldInfoPtr_showCameraBorder;

	private static readonly IntPtr NativeFieldInfoPtr_xMin;

	private static readonly IntPtr NativeFieldInfoPtr_yMin;

	private static readonly IntPtr NativeFieldInfoPtr_xMax;

	private static readonly IntPtr NativeFieldInfoPtr_yMax;

	private static readonly IntPtr NativeFieldInfoPtr_noScrolling;

	private static readonly IntPtr NativeFieldInfoPtr_anchorTile;

	private static readonly IntPtr NativeFieldInfoPtr_showCameraRendererRect;

	private static readonly IntPtr NativeFieldInfoPtr_cameraRendererCenter;

	private static readonly IntPtr NativeFieldInfoPtr_cameraSimulationRes;

	private static readonly IntPtr NativeFieldInfoPtr_showMapArea;

	private static readonly IntPtr NativeFieldInfoPtr_mMapWidth;

	private static readonly IntPtr NativeFieldInfoPtr_mMapHeight;

	private static readonly IntPtr NativeFieldInfoPtr_instance;

	private static readonly IntPtr NativeFieldInfoPtr_cachedTileMap;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CameraFollowBorder_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CachedTileMap_Public_get_Tilemap_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CameraTarget_Private_Tilemap_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool showCameraBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCameraBorder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCameraBorder)) = flag;
		}
	}

	public unsafe int xMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMin)) = num;
		}
	}

	public unsafe int yMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMin)) = num;
		}
	}

	public unsafe int xMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMax)) = num;
		}
	}

	public unsafe int yMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMax)) = num;
		}
	}

	public unsafe bool noScrolling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noScrolling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noScrolling)) = flag;
		}
	}

	public unsafe Vector3Int anchorTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorTile);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorTile)) = vector3Int;
		}
	}

	public unsafe bool showCameraRendererRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCameraRendererRect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCameraRendererRect)) = flag;
		}
	}

	public unsafe Vector2Int cameraRendererCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraRendererCenter);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraRendererCenter)) = vector2Int;
		}
	}

	public unsafe CameraSimulationRes cameraSimulationRes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSimulationRes);
			return *(CameraSimulationRes*)num;
		}
		set
		{
			*(CameraSimulationRes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSimulationRes)) = cameraSimulationRes;
		}
	}

	public unsafe bool showMapArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMapArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMapArea)) = flag;
		}
	}

	public unsafe int mMapWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMapWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMapWidth)) = num;
		}
	}

	public unsafe int mMapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMapHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMapHeight)) = num;
		}
	}

	public unsafe static CameraFollowBorder instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CameraFollowBorder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraFollowBorder));
		}
	}

	public unsafe Tilemap cachedTileMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTileMap);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedTileMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap));
		}
	}

	public unsafe static CameraFollowBorder Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873566, XrefRangeEnd = 873568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CameraFollowBorder_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CameraFollowBorder>(intPtr) : null;
		}
	}

	public unsafe Tilemap CachedTileMap
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CachedTileMap_Public_get_Tilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
	}

	static CameraFollowBorder()
	{
		Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "CameraFollowBorder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr);
		NativeFieldInfoPtr_showCameraBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "showCameraBorder");
		NativeFieldInfoPtr_xMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "xMin");
		NativeFieldInfoPtr_yMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "yMin");
		NativeFieldInfoPtr_xMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "xMax");
		NativeFieldInfoPtr_yMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "yMax");
		NativeFieldInfoPtr_noScrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "noScrolling");
		NativeFieldInfoPtr_anchorTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "anchorTile");
		NativeFieldInfoPtr_showCameraRendererRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "showCameraRendererRect");
		NativeFieldInfoPtr_cameraRendererCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "cameraRendererCenter");
		NativeFieldInfoPtr_cameraSimulationRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "cameraSimulationRes");
		NativeFieldInfoPtr_showMapArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "showMapArea");
		NativeFieldInfoPtr_mMapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "mMapWidth");
		NativeFieldInfoPtr_mMapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "mMapHeight");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_cachedTileMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, "cachedTileMap");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CameraFollowBorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674570);
		NativeMethodInfoPtr_get_CachedTileMap_Public_get_Tilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674571);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674572);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674573);
		NativeMethodInfoPtr_CameraTarget_Private_Tilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674574);
		NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674575);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr, 100674576);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873568, XrefRangeEnd = 873575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873575, XrefRangeEnd = 873578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873587, RefRangeEnd = 873589, XrefRangeStart = 873578, XrefRangeEnd = 873587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Tilemap CameraTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraTarget_Private_Tilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873589, XrefRangeEnd = 873668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873668, XrefRangeEnd = 873670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraFollowBorder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraFollowBorder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CameraFollowBorder(IntPtr pointer)
		: base(pointer)
	{
	}
}
