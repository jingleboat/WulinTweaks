using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Pathfinding.Voxels;
using UnityEngine;

namespace Pathfinding.Recast;

public class RecastMeshGatherer : Il2CppSystem.Object
{
	public class CapsuleCache : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rows;

		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		private static readonly System.IntPtr NativeFieldInfoPtr_verts;

		private static readonly System.IntPtr NativeFieldInfoPtr_tris;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int rows
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rows);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rows)) = num;
			}
		}

		public unsafe float height
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
			}
		}

		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tris);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tris)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static CapsuleCache()
		{
			Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "CapsuleCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr);
			NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr, "rows");
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr, "height");
			NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr, "verts");
			NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr, "tris");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr, 100689567);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CapsuleCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CapsuleCache>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CapsuleCache(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainSampleSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_mask;

	private static readonly System.IntPtr NativeFieldInfoPtr_tagMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_colliderRasterizeDetail;

	private static readonly System.IntPtr NativeFieldInfoPtr_bounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoxColliderTris;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoxColliderVerts;

	private static readonly System.IntPtr NativeFieldInfoPtr_capsuleCache;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bounds_Int32_LayerMask_List_1_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterMeshes_Private_Static_List_1_MeshFilter_Il2CppReferenceArray_1_MeshFilter_List_1_String_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectSceneMeshes_Public_Void_List_1_RasterizationMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectRecastMeshObjs_Public_Void_List_1_RasterizationMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectTerrainMeshes_Public_Void_Boolean_Single_List_1_RasterizationMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTerrainChunks_Private_Void_Terrain_Bounds_Single_List_1_RasterizationMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilDivision_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHeightmapChunk_Private_RasterizationMesh_Il2CppObjectBase_Vector3_Vector3_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectTreeMeshes_Private_Void_Terrain_List_1_RasterizationMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectColliderMeshes_Public_Void_List_1_RasterizationMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RasterizeCollider_Private_RasterizationMesh_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RasterizeCollider_Private_RasterizationMesh_Collider_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RasterizeBoxCollider_Private_RasterizationMesh_BoxCollider_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RasterizeCapsuleCollider_Private_RasterizationMesh_Single_Single_Bounds_Matrix4x4_0;

	public unsafe int terrainSampleSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSampleSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSampleSize)) = num;
		}
	}

	public unsafe LayerMask mask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask)) = layerMask;
		}
	}

	public unsafe List<string> tagMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagMask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagMask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float colliderRasterizeDetail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderRasterizeDetail);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderRasterizeDetail)) = num;
		}
	}

	public unsafe Bounds bounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds)) = bounds;
		}
	}

	public unsafe static Il2CppStructArray<int> BoxColliderTris
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BoxColliderTris, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BoxColliderTris, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<Vector3> BoxColliderVerts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BoxColliderVerts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BoxColliderVerts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe List<CapsuleCache> capsuleCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capsuleCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CapsuleCache>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capsuleCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static RecastMeshGatherer()
	{
		Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Recast", "RecastMeshGatherer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr);
		NativeFieldInfoPtr_terrainSampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "terrainSampleSize");
		NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "mask");
		NativeFieldInfoPtr_tagMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "tagMask");
		NativeFieldInfoPtr_colliderRasterizeDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "colliderRasterizeDetail");
		NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "bounds");
		NativeFieldInfoPtr_BoxColliderTris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "BoxColliderTris");
		NativeFieldInfoPtr_BoxColliderVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "BoxColliderVerts");
		NativeFieldInfoPtr_capsuleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, "capsuleCache");
		NativeMethodInfoPtr__ctor_Public_Void_Bounds_Int32_LayerMask_List_1_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683954);
		NativeMethodInfoPtr_FilterMeshes_Private_Static_List_1_MeshFilter_Il2CppReferenceArray_1_MeshFilter_List_1_String_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683955);
		NativeMethodInfoPtr_CollectSceneMeshes_Public_Void_List_1_RasterizationMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683956);
		NativeMethodInfoPtr_CollectRecastMeshObjs_Public_Void_List_1_RasterizationMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683957);
		NativeMethodInfoPtr_CollectTerrainMeshes_Public_Void_Boolean_Single_List_1_RasterizationMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683958);
		NativeMethodInfoPtr_GenerateTerrainChunks_Private_Void_Terrain_Bounds_Single_List_1_RasterizationMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683959);
		NativeMethodInfoPtr_CeilDivision_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683960);
		NativeMethodInfoPtr_GenerateHeightmapChunk_Private_RasterizationMesh_Il2CppObjectBase_Vector3_Vector3_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683961);
		NativeMethodInfoPtr_CollectTreeMeshes_Private_Void_Terrain_List_1_RasterizationMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683962);
		NativeMethodInfoPtr_CollectColliderMeshes_Public_Void_List_1_RasterizationMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683963);
		NativeMethodInfoPtr_RasterizeCollider_Private_RasterizationMesh_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683964);
		NativeMethodInfoPtr_RasterizeCollider_Private_RasterizationMesh_Collider_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683965);
		NativeMethodInfoPtr_RasterizeBoxCollider_Private_RasterizationMesh_BoxCollider_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683966);
		NativeMethodInfoPtr_RasterizeCapsuleCollider_Private_RasterizationMesh_Single_Single_Bounds_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr, 100683967);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079271, XrefRangeEnd = 1079289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RecastMeshGatherer(Bounds bounds, int terrainSampleSize, LayerMask mask, List<string> tagMask, float colliderRasterizeDetail)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecastMeshGatherer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&bounds);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainSampleSize;
		*(LayerMask**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tagMask);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderRasterizeDetail;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Bounds_Int32_LayerMask_List_1_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079324, RefRangeEnd = 1079325, XrefRangeStart = 1079289, XrefRangeEnd = 1079324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<MeshFilter> FilterMeshes(Il2CppReferenceArray<MeshFilter> meshFilters, List<string> tagMask, LayerMask layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshFilters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tagMask);
		*(LayerMask**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterMeshes_Private_Static_List_1_MeshFilter_Il2CppReferenceArray_1_MeshFilter_List_1_String_LayerMask_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshFilter>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079400, RefRangeEnd = 1079401, XrefRangeStart = 1079325, XrefRangeEnd = 1079400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectSceneMeshes(List<RasterizationMesh> meshes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectSceneMeshes_Public_Void_List_1_RasterizationMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079520, RefRangeEnd = 1079521, XrefRangeStart = 1079401, XrefRangeEnd = 1079520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectRecastMeshObjs(List<RasterizationMesh> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectRecastMeshObjs_Public_Void_List_1_RasterizationMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079521, XrefRangeEnd = 1079530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectTerrainMeshes(bool rasterizeTrees, float desiredChunkSize, List<RasterizationMesh> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rasterizeTrees);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &desiredChunkSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectTerrainMeshes_Public_Void_Boolean_Single_List_1_RasterizationMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079557, RefRangeEnd = 1079559, XrefRangeStart = 1079530, XrefRangeEnd = 1079557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTerrainChunks(Terrain terrain, Bounds bounds, float desiredChunkSize, List<RasterizationMesh> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bounds;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &desiredChunkSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTerrainChunks_Private_Void_Terrain_Bounds_Single_List_1_RasterizationMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int CeilDivision(int lhs, int rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilDivision_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079589, RefRangeEnd = 1079590, XrefRangeStart = 1079559, XrefRangeEnd = 1079589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RasterizationMesh GenerateHeightmapChunk(Il2CppObjectBase heights, Vector3 sampleSize, Vector3 offset, int x0, int z0, int width, int depth, int stride)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(heights);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleSize;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &z0;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHeightmapChunk_Private_RasterizationMesh_Il2CppObjectBase_Vector3_Vector3_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterizationMesh>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079635, RefRangeEnd = 1079637, XrefRangeStart = 1079590, XrefRangeEnd = 1079635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectTreeMeshes(Terrain terrain, List<RasterizationMesh> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectTreeMeshes_Private_Void_Terrain_List_1_RasterizationMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079669, RefRangeEnd = 1079670, XrefRangeStart = 1079637, XrefRangeEnd = 1079669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectColliderMeshes(List<RasterizationMesh> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectColliderMeshes_Public_Void_List_1_RasterizationMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079673, RefRangeEnd = 1079675, XrefRangeStart = 1079670, XrefRangeEnd = 1079673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RasterizationMesh RasterizeCollider(Collider col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)col);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RasterizeCollider_Private_RasterizationMesh_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterizationMesh>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079730, RefRangeEnd = 1079732, XrefRangeStart = 1079675, XrefRangeEnd = 1079730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RasterizationMesh RasterizeCollider(Collider col, Matrix4x4 localToWorldMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)col);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localToWorldMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RasterizeCollider_Private_RasterizationMesh_Collider_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterizationMesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079732, XrefRangeEnd = 1079746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RasterizationMesh RasterizeBoxCollider(BoxCollider collider, Matrix4x4 localToWorldMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localToWorldMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RasterizeBoxCollider_Private_RasterizationMesh_BoxCollider_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterizationMesh>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079817, RefRangeEnd = 1079818, XrefRangeStart = 1079746, XrefRangeEnd = 1079817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RasterizationMesh RasterizeCapsuleCollider(float radius, float height, Bounds bounds, Matrix4x4 localToWorldMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&radius);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(Bounds**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bounds;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &localToWorldMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RasterizeCapsuleCollider_Private_RasterizationMesh_Single_Single_Bounds_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RasterizationMesh>(intPtr) : null;
	}

	public RecastMeshGatherer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
