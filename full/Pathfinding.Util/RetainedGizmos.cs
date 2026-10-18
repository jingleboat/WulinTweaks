using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding.Util;

public class RetainedGizmos : Il2CppSystem.Object
{
	public sealed class Hasher : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hash;

		private static readonly System.IntPtr NativeFieldInfoPtr_includePathSearchInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_includeAreaInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddHash_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HashNode_Public_Void_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Hash_Public_get_UInt64_0;

		public unsafe ulong hash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash);
				return *(ulong*)num;
			}
			set
			{
				*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash)) = num;
			}
		}

		public unsafe bool includePathSearchInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includePathSearchInfo);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includePathSearchInfo)) = flag;
			}
		}

		public unsafe bool includeAreaInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeAreaInfo);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeAreaInfo)) = flag;
			}
		}

		public unsafe PathHandler debugData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathHandler>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathHandler));
			}
		}

		public unsafe ulong Hash
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28437, RefRangeEnd = 28438, XrefRangeStart = 28437, XrefRangeEnd = 28438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Hash_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static Hasher()
		{
			Il2CppClassPointerStore<Hasher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "Hasher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hasher>.NativeClassPtr);
			NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hasher>.NativeClassPtr, "hash");
			NativeFieldInfoPtr_includePathSearchInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hasher>.NativeClassPtr, "includePathSearchInfo");
			NativeFieldInfoPtr_includeAreaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hasher>.NativeClassPtr, "includeAreaInfo");
			NativeFieldInfoPtr_debugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hasher>.NativeClassPtr, "debugData");
			NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hasher>.NativeClassPtr, 100689623);
			NativeMethodInfoPtr_AddHash_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hasher>.NativeClassPtr, 100689624);
			NativeMethodInfoPtr_HashNode_Public_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hasher>.NativeClassPtr, 100689625);
			NativeMethodInfoPtr_get_Hash_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hasher>.NativeClassPtr, 100689626);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1085479, RefRangeEnd = 1085483, XrefRangeStart = 1085473, XrefRangeEnd = 1085479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hasher(AstarPath active)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hasher>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)active);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AstarPath_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1085483, RefRangeEnd = 1085491, XrefRangeStart = 1085483, XrefRangeEnd = 1085483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHash(int hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&hash);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHash_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1085495, RefRangeEnd = 1085498, XrefRangeStart = 1085491, XrefRangeEnd = 1085495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HashNode(GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HashNode_Public_Void_GraphNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Hasher(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Hasher()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hasher>.NativeClassPtr))
		{
		}
	}

	public class Builder : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lines;

		private static readonly System.IntPtr NativeFieldInfoPtr_lineColors;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshes;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Void_RetainedGizmos_Il2CppStructArray_1_Vector3_List_1_Int32_Il2CppStructArray_1_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Void_GraphTransform_Bounds_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Void_Vector3_Vector3_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Void_RetainedGizmos_Hasher_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitMeshes_Private_Void_RetainedGizmos_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitLines_Private_Void_RetainedGizmos_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Pathfinding_Util_IAstarPooledObject_OnEnterPool_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Vector3> lines
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Color32> lineColors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineColors);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineColors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Mesh> meshes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Mesh>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static Builder()
		{
			Il2CppClassPointerStore<Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "Builder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Builder>.NativeClassPtr);
			NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "lines");
			NativeFieldInfoPtr_lineColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "lineColors");
			NativeFieldInfoPtr_meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "meshes");
			NativeMethodInfoPtr_DrawMesh_Public_Void_RetainedGizmos_Il2CppStructArray_1_Vector3_List_1_Int32_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689627);
			NativeMethodInfoPtr_DrawWireCube_Public_Void_GraphTransform_Bounds_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689628);
			NativeMethodInfoPtr_DrawLine_Public_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689629);
			NativeMethodInfoPtr_Submit_Public_Void_RetainedGizmos_Hasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689630);
			NativeMethodInfoPtr_SubmitMeshes_Private_Void_RetainedGizmos_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689631);
			NativeMethodInfoPtr_SubmitLines_Private_Void_RetainedGizmos_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689632);
			NativeMethodInfoPtr_Pathfinding_Util_IAstarPooledObject_OnEnterPool_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689633);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100689634);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1085507, RefRangeEnd = 1085509, XrefRangeStart = 1085498, XrefRangeEnd = 1085507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMesh(RetainedGizmos gizmos, Il2CppStructArray<Vector3> vertices, List<int> triangles, Il2CppStructArray<Color> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gizmos);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)triangles);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMesh_Public_Void_RetainedGizmos_Il2CppStructArray_1_Vector3_List_1_Int32_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1085667, RefRangeEnd = 1085669, XrefRangeStart = 1085509, XrefRangeEnd = 1085667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWireCube(GraphTransform tr, Bounds bounds, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tr);
			*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bounds;
			*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireCube_Public_Void_GraphTransform_Bounds_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1085681, RefRangeEnd = 1085693, XrefRangeStart = 1085669, XrefRangeEnd = 1085681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&start);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
			*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Public_Void_Vector3_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1085704, RefRangeEnd = 1085707, XrefRangeStart = 1085693, XrefRangeEnd = 1085704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit(RetainedGizmos gizmos, Hasher hasher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gizmos);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hasher));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Submit_Public_Void_RetainedGizmos_Hasher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085707, XrefRangeEnd = 1085717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitMeshes(RetainedGizmos gizmos, ulong hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gizmos);
			*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hash;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitMeshes_Private_Void_RetainedGizmos_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085824, RefRangeEnd = 1085825, XrefRangeStart = 1085717, XrefRangeEnd = 1085824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitLines(RetainedGizmos gizmos, ulong hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gizmos);
			*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hash;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitLines_Private_Void_RetainedGizmos_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085825, XrefRangeEnd = 1085835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pathfinding_Util_IAstarPooledObject_OnEnterPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pathfinding_Util_IAstarPooledObject_OnEnterPool_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085835, XrefRangeEnd = 1085854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Builder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Builder>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Builder(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class MeshWithHash : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hash;

		private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_lines;

		public unsafe ulong hash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash);
				return *(ulong*)num;
			}
			set
			{
				*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash)) = num;
			}
		}

		public unsafe Mesh mesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe bool lines
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines)) = flag;
			}
		}

		static MeshWithHash()
		{
			Il2CppClassPointerStore<MeshWithHash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "MeshWithHash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshWithHash>.NativeClassPtr);
			NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWithHash>.NativeClassPtr, "hash");
			NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWithHash>.NativeClassPtr, "mesh");
			NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWithHash>.NativeClassPtr, "lines");
		}

		public MeshWithHash(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public MeshWithHash()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshWithHash>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_meshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_usedHashes;

	private static readonly System.IntPtr NativeFieldInfoPtr_existingHashes;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineMaterial;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleFrameGizmoHelper_Public_GraphGizmoHelper_AstarPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGizmoHelper_Public_GraphGizmoHelper_AstarPath_Hasher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PoolMesh_Private_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMesh_Private_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCachedMesh_Public_Boolean_Hasher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Boolean_Hasher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawExisting_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeDraw_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedMeshes_Private_Void_List_1_MeshWithHash_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<MeshWithHash> meshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshWithHash>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<ulong> usedHashes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedHashes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedHashes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<ulong> existingHashes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existingHashes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existingHashes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Stack<Mesh> cachedMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<Mesh>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack));
		}
	}

	public unsafe Material surfaceMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material lineMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	static RetainedGizmos()
	{
		Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "RetainedGizmos");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr);
		NativeFieldInfoPtr_meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "meshes");
		NativeFieldInfoPtr_usedHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "usedHashes");
		NativeFieldInfoPtr_existingHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "existingHashes");
		NativeFieldInfoPtr_cachedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "cachedMeshes");
		NativeFieldInfoPtr_surfaceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "surfaceMaterial");
		NativeFieldInfoPtr_lineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, "lineMaterial");
		NativeMethodInfoPtr_GetSingleFrameGizmoHelper_Public_GraphGizmoHelper_AstarPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684418);
		NativeMethodInfoPtr_GetGizmoHelper_Public_GraphGizmoHelper_AstarPath_Hasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684419);
		NativeMethodInfoPtr_PoolMesh_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684420);
		NativeMethodInfoPtr_GetMesh_Private_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684421);
		NativeMethodInfoPtr_HasCachedMesh_Public_Boolean_Hasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684422);
		NativeMethodInfoPtr_Draw_Public_Boolean_Hasher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684423);
		NativeMethodInfoPtr_DrawExisting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684424);
		NativeMethodInfoPtr_FinalizeDraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684425);
		NativeMethodInfoPtr_ClearCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684426);
		NativeMethodInfoPtr_RemoveUnusedMeshes_Private_Void_List_1_MeshWithHash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684427);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr, 100684428);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085867, RefRangeEnd = 1085869, XrefRangeStart = 1085854, XrefRangeEnd = 1085867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphGizmoHelper GetSingleFrameGizmoHelper(AstarPath active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)active);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSingleFrameGizmoHelper_Public_GraphGizmoHelper_AstarPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphGizmoHelper>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1085873, RefRangeEnd = 1085876, XrefRangeStart = 1085869, XrefRangeEnd = 1085873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphGizmoHelper GetGizmoHelper(AstarPath active, Hasher hasher)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)active);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hasher));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGizmoHelper_Public_GraphGizmoHelper_AstarPath_Hasher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphGizmoHelper>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085876, XrefRangeEnd = 1085881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PoolMesh(Mesh mesh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PoolMesh_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085888, RefRangeEnd = 1085890, XrefRangeStart = 1085881, XrefRangeEnd = 1085888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mesh GetMesh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMesh_Private_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085890, XrefRangeEnd = 1085894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCachedMesh(Hasher hasher)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hasher));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCachedMesh_Public_Boolean_Hasher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1085901, RefRangeEnd = 1085906, XrefRangeStart = 1085894, XrefRangeEnd = 1085901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Draw(Hasher hasher)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hasher));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Boolean_Hasher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085913, RefRangeEnd = 1085914, XrefRangeStart = 1085906, XrefRangeEnd = 1085913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawExisting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawExisting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085947, RefRangeEnd = 1085948, XrefRangeStart = 1085914, XrefRangeEnd = 1085947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinalizeDraw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizeDraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085961, RefRangeEnd = 1085962, XrefRangeStart = 1085948, XrefRangeEnd = 1085961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085987, RefRangeEnd = 1085989, XrefRangeStart = 1085962, XrefRangeEnd = 1085987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveUnusedMeshes(List<MeshWithHash> meshList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUnusedMeshes_Private_Void_List_1_MeshWithHash_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086012, RefRangeEnd = 1086013, XrefRangeStart = 1085989, XrefRangeEnd = 1086012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RetainedGizmos()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetainedGizmos>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RetainedGizmos(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
