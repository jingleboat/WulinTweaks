using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding.Voxels;

public class Voxelize : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inputMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_voxelWalkableClimb;

	private static readonly System.IntPtr NativeFieldInfoPtr_voxelWalkableHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_minRegionSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxEdgeLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_relevantGraphSurfaceMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_voxelArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_countourSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_transform;

	private static readonly System.IntPtr NativeFieldInfoPtr__transformVoxel2Graph_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_depth;

	private static readonly System.IntPtr NativeFieldInfoPtr_voxelOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxRegions;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnwalkableArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_BorderReg;

	private static readonly System.IntPtr NativeFieldInfoPtr_RC_BORDER_VERTEX;

	private static readonly System.IntPtr NativeFieldInfoPtr_RC_AREA_BORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_VERTEX_BUCKET_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_RC_CONTOUR_TESS_WALL_EDGES;

	private static readonly System.IntPtr NativeFieldInfoPtr_RC_CONTOUR_TESS_AREA_EDGES;

	private static readonly System.IntPtr NativeFieldInfoPtr_RC_CONTOUR_TESS_TILE_EDGES;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContourRegMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellScale;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildContours_Public_Void_Single_Int32_VoxelContourSet_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestIndices_Private_Void_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseContours_Private_Static_Void_VoxelContourSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeContours_Public_Static_Boolean_byref_VoxelContour_byref_VoxelContour_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimplifyContour_Public_Void_List_1_Int32_List_1_Int32_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WalkContour_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_UInt16_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCornerHeight_Public_Int32_Int32_Int32_Int32_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDegenerateSegments_Public_Void_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcAreaOfPolygon2D_Public_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ileft_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Diagonal_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InCone_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Left_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeftOn_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collinear_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Area2_Public_Static_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Diagonalie_Private_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Xorb_Public_Static_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntersectProp_Public_Static_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Between_Private_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Intersect_Private_Static_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vequal_Private_Static_Boolean_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prev_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildPolyMesh_Public_Void_VoxelContourSet_Int32_byref_VoxelMesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Triangulate_Private_Int32_Int32_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_transformVoxel2Graph_Public_get_GraphTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_transformVoxel2Graph_Private_set_Void_GraphTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompactSpanToVector_Public_Vector3_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VectorToIndex_Public_Void_Vector3_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VoxelizeInput_Public_Void_GraphTransform_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugDrawSpans_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildCompactField_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildVoxelConnections_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Private_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VoxelToWorld_Public_Vector3_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VoxelToWorldInt3_Public_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPosWithoutOffset_Private_Vector3_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPosition_Private_Vector3_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ErodeWalkableArea_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildDistanceField_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ErodeVoxels_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterLowHeightSpans_Public_Void_UInt32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterLedges_Public_Void_UInt32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloodRegion_Public_Boolean_Int32_Int32_Int32_UInt32_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Int3_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkRectWithRegion_Public_Void_Int32_Int32_Int32_Int32_UInt16_Il2CppStructArray_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDistanceField_Public_UInt16_Il2CppStructArray_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BoxBlur_Public_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildRegions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_union_find_find_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_union_find_union_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterSmallRegions_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_0;

	public unsafe List<RasterizationMesh> inputMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RasterizationMesh>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int voxelWalkableClimb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelWalkableClimb);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelWalkableClimb)) = num;
		}
	}

	public unsafe uint voxelWalkableHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelWalkableHeight);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelWalkableHeight)) = num;
		}
	}

	public unsafe float cellSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSize)) = num;
		}
	}

	public unsafe float cellHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellHeight)) = num;
		}
	}

	public unsafe int minRegionSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRegionSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRegionSize)) = num;
		}
	}

	public unsafe int borderSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borderSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borderSize)) = num;
		}
	}

	public unsafe float maxEdgeLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxEdgeLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxEdgeLength)) = num;
		}
	}

	public unsafe float maxSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlope);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlope)) = num;
		}
	}

	public unsafe RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relevantGraphSurfaceMode);
			return *(RecastGraph.RelevantGraphSurfaceMode*)num;
		}
		set
		{
			*(RecastGraph.RelevantGraphSurfaceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relevantGraphSurfaceMode)) = relevantGraphSurfaceMode;
		}
	}

	public unsafe Bounds forcedBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedBounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedBounds)) = bounds;
		}
	}

	public unsafe VoxelArea voxelArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VoxelArea>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)voxelArea));
		}
	}

	public unsafe VoxelContourSet countourSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countourSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VoxelContourSet>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countourSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)voxelContourSet));
		}
	}

	public unsafe GraphTransform transform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphTransform));
		}
	}

	public unsafe GraphTransform _transformVoxel2Graph_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transformVoxel2Graph_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transformVoxel2Graph_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphTransform));
		}
	}

	public unsafe int width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = num;
		}
	}

	public unsafe int depth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth)) = num;
		}
	}

	public unsafe Vector3 voxelOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelOffset)) = vector;
		}
	}

	public unsafe static uint NotConnected
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotConnected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotConnected, (void*)(&num));
		}
	}

	public unsafe static int MaxLayers
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxLayers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxLayers, (void*)(&num));
		}
	}

	public unsafe static int MaxRegions
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxRegions, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxRegions, (void*)(&num));
		}
	}

	public unsafe static int UnwalkableArea
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnwalkableArea, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnwalkableArea, (void*)(&num));
		}
	}

	public unsafe static ushort BorderReg
	{
		get
		{
			Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BorderReg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BorderReg, (void*)(&num));
		}
	}

	public unsafe static int RC_BORDER_VERTEX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RC_BORDER_VERTEX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RC_BORDER_VERTEX, (void*)(&num));
		}
	}

	public unsafe static int RC_AREA_BORDER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RC_AREA_BORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RC_AREA_BORDER, (void*)(&num));
		}
	}

	public unsafe static int VERTEX_BUCKET_COUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VERTEX_BUCKET_COUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VERTEX_BUCKET_COUNT, (void*)(&num));
		}
	}

	public unsafe static int RC_CONTOUR_TESS_WALL_EDGES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RC_CONTOUR_TESS_WALL_EDGES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RC_CONTOUR_TESS_WALL_EDGES, (void*)(&num));
		}
	}

	public unsafe static int RC_CONTOUR_TESS_AREA_EDGES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RC_CONTOUR_TESS_AREA_EDGES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RC_CONTOUR_TESS_AREA_EDGES, (void*)(&num));
		}
	}

	public unsafe static int RC_CONTOUR_TESS_TILE_EDGES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RC_CONTOUR_TESS_TILE_EDGES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RC_CONTOUR_TESS_TILE_EDGES, (void*)(&num));
		}
	}

	public unsafe static int ContourRegMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ContourRegMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ContourRegMask, (void*)(&num));
		}
	}

	public unsafe Vector3 cellScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellScale)) = vector;
		}
	}

	public unsafe GraphTransform transformVoxel2Graph
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18873, RefRangeEnd = 18874, XrefRangeStart = 18873, XrefRangeEnd = 18874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transformVoxel2Graph_Public_get_GraphTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_transformVoxel2Graph_Private_set_Void_GraphTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Voxelize()
	{
		Il2CppClassPointerStore<Voxelize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Voxels", "Voxelize");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Voxelize>.NativeClassPtr);
		NativeFieldInfoPtr_inputMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "inputMeshes");
		NativeFieldInfoPtr_voxelWalkableClimb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "voxelWalkableClimb");
		NativeFieldInfoPtr_voxelWalkableHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "voxelWalkableHeight");
		NativeFieldInfoPtr_cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "cellSize");
		NativeFieldInfoPtr_cellHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "cellHeight");
		NativeFieldInfoPtr_minRegionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "minRegionSize");
		NativeFieldInfoPtr_borderSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "borderSize");
		NativeFieldInfoPtr_maxEdgeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "maxEdgeLength");
		NativeFieldInfoPtr_maxSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "maxSlope");
		NativeFieldInfoPtr_relevantGraphSurfaceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "relevantGraphSurfaceMode");
		NativeFieldInfoPtr_forcedBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "forcedBounds");
		NativeFieldInfoPtr_voxelArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "voxelArea");
		NativeFieldInfoPtr_countourSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "countourSet");
		NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "transform");
		NativeFieldInfoPtr__transformVoxel2Graph_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "<transformVoxel2Graph>k__BackingField");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "width");
		NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "depth");
		NativeFieldInfoPtr_voxelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "voxelOffset");
		NativeFieldInfoPtr_NotConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "NotConnected");
		NativeFieldInfoPtr_MaxLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "MaxLayers");
		NativeFieldInfoPtr_MaxRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "MaxRegions");
		NativeFieldInfoPtr_UnwalkableArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "UnwalkableArea");
		NativeFieldInfoPtr_BorderReg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "BorderReg");
		NativeFieldInfoPtr_RC_BORDER_VERTEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "RC_BORDER_VERTEX");
		NativeFieldInfoPtr_RC_AREA_BORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "RC_AREA_BORDER");
		NativeFieldInfoPtr_VERTEX_BUCKET_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "VERTEX_BUCKET_COUNT");
		NativeFieldInfoPtr_RC_CONTOUR_TESS_WALL_EDGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "RC_CONTOUR_TESS_WALL_EDGES");
		NativeFieldInfoPtr_RC_CONTOUR_TESS_AREA_EDGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "RC_CONTOUR_TESS_AREA_EDGES");
		NativeFieldInfoPtr_RC_CONTOUR_TESS_TILE_EDGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "RC_CONTOUR_TESS_TILE_EDGES");
		NativeFieldInfoPtr_ContourRegMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "ContourRegMask");
		NativeFieldInfoPtr_cellScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, "cellScale");
		NativeMethodInfoPtr_BuildContours_Public_Void_Single_Int32_VoxelContourSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683889);
		NativeMethodInfoPtr_GetClosestIndices_Private_Void_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683890);
		NativeMethodInfoPtr_ReleaseContours_Private_Static_Void_VoxelContourSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683891);
		NativeMethodInfoPtr_MergeContours_Public_Static_Boolean_byref_VoxelContour_byref_VoxelContour_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683892);
		NativeMethodInfoPtr_SimplifyContour_Public_Void_List_1_Int32_List_1_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683893);
		NativeMethodInfoPtr_WalkContour_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_UInt16_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683894);
		NativeMethodInfoPtr_GetCornerHeight_Public_Int32_Int32_Int32_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683895);
		NativeMethodInfoPtr_RemoveDegenerateSegments_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683896);
		NativeMethodInfoPtr_CalcAreaOfPolygon2D_Public_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683897);
		NativeMethodInfoPtr_Ileft_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683898);
		NativeMethodInfoPtr_Diagonal_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683899);
		NativeMethodInfoPtr_InCone_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683900);
		NativeMethodInfoPtr_Left_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683901);
		NativeMethodInfoPtr_LeftOn_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683902);
		NativeMethodInfoPtr_Collinear_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683903);
		NativeMethodInfoPtr_Area2_Public_Static_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683904);
		NativeMethodInfoPtr_Diagonalie_Private_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683905);
		NativeMethodInfoPtr_Xorb_Public_Static_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683906);
		NativeMethodInfoPtr_IntersectProp_Public_Static_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683907);
		NativeMethodInfoPtr_Between_Private_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683908);
		NativeMethodInfoPtr_Intersect_Private_Static_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683909);
		NativeMethodInfoPtr_Vequal_Private_Static_Boolean_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683910);
		NativeMethodInfoPtr_Prev_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683911);
		NativeMethodInfoPtr_Next_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683912);
		NativeMethodInfoPtr_BuildPolyMesh_Public_Void_VoxelContourSet_Int32_byref_VoxelMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683913);
		NativeMethodInfoPtr_Triangulate_Private_Int32_Int32_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683914);
		NativeMethodInfoPtr_get_transformVoxel2Graph_Public_get_GraphTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683915);
		NativeMethodInfoPtr_set_transformVoxel2Graph_Private_set_Void_GraphTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683916);
		NativeMethodInfoPtr_CompactSpanToVector_Public_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683917);
		NativeMethodInfoPtr_VectorToIndex_Public_Void_Vector3_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683918);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683919);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683920);
		NativeMethodInfoPtr_VoxelizeInput_Public_Void_GraphTransform_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683921);
		NativeMethodInfoPtr_DebugDrawSpans_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683922);
		NativeMethodInfoPtr_BuildCompactField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683923);
		NativeMethodInfoPtr_BuildVoxelConnections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683924);
		NativeMethodInfoPtr_DrawLine_Private_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683925);
		NativeMethodInfoPtr_VoxelToWorld_Public_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683926);
		NativeMethodInfoPtr_VoxelToWorldInt3_Public_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683927);
		NativeMethodInfoPtr_ConvertPosWithoutOffset_Private_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683928);
		NativeMethodInfoPtr_ConvertPosition_Private_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683929);
		NativeMethodInfoPtr_ErodeWalkableArea_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683930);
		NativeMethodInfoPtr_BuildDistanceField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683931);
		NativeMethodInfoPtr_ErodeVoxels_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683932);
		NativeMethodInfoPtr_FilterLowHeightSpans_Public_Void_UInt32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683933);
		NativeMethodInfoPtr_FilterLedges_Public_Void_UInt32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683934);
		NativeMethodInfoPtr_FloodRegion_Public_Boolean_Int32_Int32_Int32_UInt32_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Int3_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683935);
		NativeMethodInfoPtr_MarkRectWithRegion_Public_Void_Int32_Int32_Int32_Int32_UInt16_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683936);
		NativeMethodInfoPtr_CalculateDistanceField_Public_UInt16_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683937);
		NativeMethodInfoPtr_BoxBlur_Public_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683938);
		NativeMethodInfoPtr_BuildRegions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683939);
		NativeMethodInfoPtr_union_find_find_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683940);
		NativeMethodInfoPtr_union_find_union_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683941);
		NativeMethodInfoPtr_FilterSmallRegions_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voxelize>.NativeClassPtr, 100683942);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078295, RefRangeEnd = 1078296, XrefRangeStart = 1078171, XrefRangeEnd = 1078295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildContours(float maxError, int maxEdgeLength, VoxelContourSet cset, int buildFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&maxError);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxEdgeLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cset);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buildFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildContours_Public_Void_Single_Int32_VoxelContourSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078298, RefRangeEnd = 1078299, XrefRangeStart = 1078296, XrefRangeEnd = 1078298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetClosestIndices(Il2CppStructArray<int> vertsa, int nvertsa, Il2CppStructArray<int> vertsb, int nvertsb, ref int ia, ref int ib)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertsa);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nvertsa;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertsb);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nvertsb;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ia);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ib);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestIndices_Private_Void_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078299, XrefRangeEnd = 1078311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseContours(VoxelContourSet cset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseContours_Private_Static_Void_VoxelContourSet_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078326, RefRangeEnd = 1078327, XrefRangeStart = 1078311, XrefRangeEnd = 1078326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MergeContours(ref VoxelContour ca, ref VoxelContour cb, int ia, int ib)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ca);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cb);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ia;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ib;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeContours_Public_Static_Boolean_byref_VoxelContour_byref_VoxelContour_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078502, RefRangeEnd = 1078503, XrefRangeStart = 1078327, XrefRangeEnd = 1078502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SimplifyContour(List<int> verts, List<int> simplified, float maxError, int maxEdgeLenght, int buildFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simplified);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxError;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxEdgeLenght;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &buildFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimplifyContour_Public_Void_List_1_Int32_List_1_Int32_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078529, RefRangeEnd = 1078530, XrefRangeStart = 1078503, XrefRangeEnd = 1078529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WalkContour(int x, int z, int i, Il2CppStructArray<ushort> flags, List<int> verts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)flags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WalkContour_Public_Void_Int32_Int32_Int32_Il2CppStructArray_1_UInt16_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078557, RefRangeEnd = 1078558, XrefRangeStart = 1078530, XrefRangeEnd = 1078557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCornerHeight(int x, int z, int i, int dir, ref bool isBorderVertex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isBorderVertex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCornerHeight_Public_Int32_Int32_Int32_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078572, RefRangeEnd = 1078573, XrefRangeStart = 1078558, XrefRangeEnd = 1078572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDegenerateSegments(List<int> simplified)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simplified);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDegenerateSegments_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078573, RefRangeEnd = 1078575, XrefRangeStart = 1078573, XrefRangeEnd = 1078573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalcAreaOfPolygon2D(Il2CppStructArray<int> verts, int nverts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nverts;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcAreaOfPolygon2D_Public_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078575, RefRangeEnd = 1078577, XrefRangeStart = 1078575, XrefRangeEnd = 1078575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Ileft(int a, int b, int c, Il2CppStructArray<int> va, Il2CppStructArray<int> vb, Il2CppStructArray<int> vc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)va);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ileft_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078580, RefRangeEnd = 1078582, XrefRangeStart = 1078577, XrefRangeEnd = 1078580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Diagonal(int i, int j, int n, Il2CppStructArray<int> verts, Il2CppStructArray<int> indices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Diagonal_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078584, RefRangeEnd = 1078586, XrefRangeStart = 1078582, XrefRangeEnd = 1078584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InCone(int i, int j, int n, Il2CppStructArray<int> verts, Il2CppStructArray<int> indices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InCone_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078586, XrefRangeEnd = 1078587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Left(int a, int b, int c, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Left_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078587, XrefRangeEnd = 1078588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LeftOn(int a, int b, int c, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeftOn_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078588, XrefRangeEnd = 1078589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Collinear(int a, int b, int c, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collinear_Public_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1078589, RefRangeEnd = 1078609, XrefRangeStart = 1078589, XrefRangeEnd = 1078589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Area2(int a, int b, int c, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Area2_Public_Static_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078614, RefRangeEnd = 1078616, XrefRangeStart = 1078609, XrefRangeEnd = 1078614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Diagonalie(int i, int j, int n, Il2CppStructArray<int> verts, Il2CppStructArray<int> indices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Diagonalie_Private_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool Xorb(bool x, bool y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Xorb_Public_Static_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078616, XrefRangeEnd = 1078622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IntersectProp(int a, int b, int c, int d, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntersectProp_Public_Static_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1078626, RefRangeEnd = 1078630, XrefRangeStart = 1078622, XrefRangeEnd = 1078626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Between(int a, int b, int c, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Between_Private_Static_Boolean_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078643, RefRangeEnd = 1078644, XrefRangeStart = 1078630, XrefRangeEnd = 1078643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Intersect(int a, int b, int c, int d, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Intersect_Private_Static_Boolean_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1078644, RefRangeEnd = 1078648, XrefRangeStart = 1078644, XrefRangeEnd = 1078644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Vequal(int a, int b, Il2CppStructArray<int> verts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vequal_Private_Static_Boolean_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int Prev(int i, int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prev_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int Next(int i, int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Next_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078708, RefRangeEnd = 1078709, XrefRangeStart = 1078648, XrefRangeEnd = 1078708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildPolyMesh(VoxelContourSet cset, int nvp, out VoxelMesh mesh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nvp;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildPolyMesh_Public_Void_VoxelContourSet_Int32_byref_VoxelMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		mesh = ((num3 == 0) ? null : new VoxelMesh(num3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078722, RefRangeEnd = 1078723, XrefRangeStart = 1078709, XrefRangeEnd = 1078722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Triangulate(int n, Il2CppStructArray<int> verts, ref Il2CppStructArray<int> indices, ref Il2CppStructArray<int> tris)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&n);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tris);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Triangulate_Private_Int32_Int32_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		indices = ((intPtr5 == (System.IntPtr)0) ? null : new Il2CppStructArray<int>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		tris = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<int>(intPtr6));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	public unsafe Vector3 CompactSpanToVector(int x, int z, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompactSpanToVector_Public_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078723, XrefRangeEnd = 1078725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VectorToIndex(Vector3 p, out int x, out int z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref x);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref z);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VectorToIndex_Public_Void_Vector3_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1078728, RefRangeEnd = 1078730, XrefRangeStart = 1078725, XrefRangeEnd = 1078728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Voxelize(float ch, float cs, float walkableClimb, float walkableHeight, float maxSlope, float maxEdgeLength)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Voxelize>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&ch);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cs;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &walkableClimb;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &walkableHeight;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSlope;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxEdgeLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078736, RefRangeEnd = 1078737, XrefRangeStart = 1078730, XrefRangeEnd = 1078736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078859, RefRangeEnd = 1078860, XrefRangeStart = 1078737, XrefRangeEnd = 1078859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VoxelizeInput(GraphTransform graphTransform, Bounds graphSpaceBounds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphTransform);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphSpaceBounds;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VoxelizeInput_Public_Void_GraphTransform_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078860, XrefRangeEnd = 1078874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugDrawSpans()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugDrawSpans_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078893, RefRangeEnd = 1078894, XrefRangeStart = 1078874, XrefRangeEnd = 1078893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildCompactField()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildCompactField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078913, RefRangeEnd = 1078914, XrefRangeStart = 1078894, XrefRangeEnd = 1078913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildVoxelConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildVoxelConnections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078914, XrefRangeEnd = 1078918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawLine(int a, int b, Il2CppStructArray<int> indices, Il2CppStructArray<int> verts, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Private_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector3 VoxelToWorld(int x, int y, int z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VoxelToWorld_Public_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078918, XrefRangeEnd = 1078925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3 VoxelToWorldInt3(Int3 voxelPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&voxelPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VoxelToWorldInt3_Public_Int3_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3 ConvertPosWithoutOffset(int x, int y, int z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertPosWithoutOffset_Private_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3 ConvertPosition(int x, int z, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertPosition_Private_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078934, RefRangeEnd = 1078935, XrefRangeStart = 1078925, XrefRangeEnd = 1078934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ErodeWalkableArea(int radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&radius);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ErodeWalkableArea_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078946, RefRangeEnd = 1078947, XrefRangeStart = 1078935, XrefRangeEnd = 1078946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildDistanceField()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildDistanceField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078947, XrefRangeEnd = 1078959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ErodeVoxels(int radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&radius);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ErodeVoxels_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078961, RefRangeEnd = 1078962, XrefRangeStart = 1078959, XrefRangeEnd = 1078961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FilterLowHeightSpans(uint voxelWalkableHeight, float cs, float ch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&voxelWalkableHeight);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cs;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterLowHeightSpans_Public_Void_UInt32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078980, RefRangeEnd = 1078981, XrefRangeStart = 1078962, XrefRangeEnd = 1078980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FilterLedges(uint voxelWalkableHeight, int voxelWalkableClimb, float cs, float ch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&voxelWalkableHeight);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &voxelWalkableClimb;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cs;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterLedges_Public_Void_UInt32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1078989, RefRangeEnd = 1078990, XrefRangeStart = 1078981, XrefRangeEnd = 1078989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FloodRegion(int x, int z, int i, uint level, ushort r, Il2CppStructArray<ushort> srcReg, Il2CppStructArray<ushort> srcDist, Il2CppStructArray<Int3> stack, Il2CppStructArray<int> flags = null, Il2CppStructArray<bool> closed = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(ushort**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcReg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcDist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)flags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)closed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloodRegion_Public_Boolean_Int32_Int32_Int32_UInt32_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Int3_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1078990, RefRangeEnd = 1078993, XrefRangeStart = 1078990, XrefRangeEnd = 1078990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkRectWithRegion(int minx, int maxx, int minz, int maxz, ushort region, Il2CppStructArray<ushort> srcReg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&minx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minz;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxz;
		*(ushort**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &region;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcReg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkRectWithRegion_Public_Void_Int32_Int32_Int32_Int32_UInt16_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079024, RefRangeEnd = 1079026, XrefRangeStart = 1078993, XrefRangeEnd = 1079024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort CalculateDistanceField(Il2CppStructArray<ushort> src)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDistanceField_Public_UInt16_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079034, RefRangeEnd = 1079035, XrefRangeStart = 1079026, XrefRangeEnd = 1079034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<ushort> BoxBlur(Il2CppStructArray<ushort> src, Il2CppStructArray<ushort> dst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BoxBlur_Public_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079146, RefRangeEnd = 1079147, XrefRangeStart = 1079035, XrefRangeEnd = 1079146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildRegions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildRegions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1079148, RefRangeEnd = 1079157, XrefRangeStart = 1079147, XrefRangeEnd = 1079148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int union_find_find(Il2CppStructArray<int> arr, int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_union_find_find_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079161, RefRangeEnd = 1079162, XrefRangeStart = 1079157, XrefRangeEnd = 1079161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void union_find_union(Il2CppStructArray<int> arr, int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_union_find_union_Private_Static_Void_Il2CppStructArray_1_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079200, RefRangeEnd = 1079201, XrefRangeStart = 1079162, XrefRangeEnd = 1079200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FilterSmallRegions(Il2CppStructArray<ushort> reg, int minRegionSize, int maxRegions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minRegionSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRegions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterSmallRegions_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Voxelize(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
