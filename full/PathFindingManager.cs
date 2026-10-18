using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Pathfinding;
using UnityEngine;
using UnityEngine.Tilemaps;
using WuLin;
using WuLin.GameFrameworks;

public class PathFindingManager : GTSingleton<PathFindingManager>
{
	public enum EProviderType
	{
		Player,
		Npc
	}

	public class PlayerPetProvider : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_NowRole;

		private static readonly System.IntPtr NativeFieldInfoPtr_rolePos;

		private static readonly System.IntPtr NativeFieldInfoPtr_roleBackPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos1;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos2;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos3;

		private static readonly System.IntPtr NativeMethodInfoPtr_RoleBlock_Public_Void_Role_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsRoleBlock_Public_Boolean_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Block_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Role NowRole
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NowRole);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Role>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NowRole)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role));
			}
		}

		public unsafe Vector3Int rolePos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rolePos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rolePos)) = vector3Int;
			}
		}

		public unsafe Vector3Int roleBackPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roleBackPos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roleBackPos)) = vector3Int;
			}
		}

		public unsafe Vector2Int pos1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos1);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos1)) = vector2Int;
			}
		}

		public unsafe Vector2Int pos2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos2);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos2)) = vector2Int;
			}
		}

		public unsafe Vector2Int pos3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos3);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos3)) = vector2Int;
			}
		}

		static PlayerPetProvider()
		{
			Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "PlayerPetProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr);
			NativeFieldInfoPtr_NowRole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, "NowRole");
			NativeFieldInfoPtr_rolePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, "rolePos");
			NativeFieldInfoPtr_roleBackPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, "roleBackPos");
			NativeFieldInfoPtr_pos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, "pos1");
			NativeFieldInfoPtr_pos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, "pos2");
			NativeFieldInfoPtr_pos3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, "pos3");
			NativeMethodInfoPtr_RoleBlock_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, 100684731);
			NativeMethodInfoPtr_IsRoleBlock_Public_Boolean_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, 100684732);
			NativeMethodInfoPtr_Block_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, 100684733);
			NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, 100684734);
			NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, 100684735);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr, 100684736);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682779, XrefRangeEnd = 682806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RoleBlock(Role role)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoleBlock_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682806, XrefRangeEnd = 682859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRoleBlock(GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRoleBlock_Public_Boolean_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Block()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Block_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682859, XrefRangeEnd = 682860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanTraverse(Path path, GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 682860, XrefRangeEnd = 682881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint GetTraversalCost(Path path, GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 682885, RefRangeEnd = 682886, XrefRangeStart = 682881, XrefRangeEnd = 682885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPetProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPetProvider>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PlayerPetProvider(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PathFindingProvider : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_NowRole;

		private static readonly System.IntPtr NativeFieldInfoPtr_needLessTurn;

		private static readonly System.IntPtr NativeFieldInfoPtr_rolePos;

		private static readonly System.IntPtr NativeFieldInfoPtr_roleBackPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos1;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos2;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos3;

		private static readonly System.IntPtr NativeFieldInfoPtr_blockList;

		private static readonly System.IntPtr NativeFieldInfoPtr_invalidRolePos;

		private static readonly System.IntPtr NativeMethodInfoPtr_RoleBlock_Public_Void_Role_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NotRoleBlock_Public_Boolean_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Block_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Role NowRole
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NowRole);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Role>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NowRole)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role));
			}
		}

		public unsafe bool needLessTurn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needLessTurn);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needLessTurn)) = flag;
			}
		}

		public unsafe Vector3Int rolePos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rolePos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rolePos)) = vector3Int;
			}
		}

		public unsafe Vector3Int roleBackPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roleBackPos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roleBackPos)) = vector3Int;
			}
		}

		public unsafe Vector2Int pos1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos1);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos1)) = vector2Int;
			}
		}

		public unsafe Vector2Int pos2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos2);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos2)) = vector2Int;
			}
		}

		public unsafe Vector2Int pos3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos3);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos3)) = vector2Int;
			}
		}

		public unsafe ICollection<Vector3Int> blockList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
			}
		}

		public unsafe HashSet<Vector3Int> invalidRolePos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidRolePos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidRolePos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static PathFindingProvider()
		{
			Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "PathFindingProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr);
			NativeFieldInfoPtr_NowRole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "NowRole");
			NativeFieldInfoPtr_needLessTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "needLessTurn");
			NativeFieldInfoPtr_rolePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "rolePos");
			NativeFieldInfoPtr_roleBackPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "roleBackPos");
			NativeFieldInfoPtr_pos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "pos1");
			NativeFieldInfoPtr_pos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "pos2");
			NativeFieldInfoPtr_pos3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "pos3");
			NativeFieldInfoPtr_blockList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "blockList");
			NativeFieldInfoPtr_invalidRolePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, "invalidRolePos");
			NativeMethodInfoPtr_RoleBlock_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, 100684737);
			NativeMethodInfoPtr_NotRoleBlock_Public_Boolean_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, 100684738);
			NativeMethodInfoPtr_Block_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, 100684739);
			NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, 100684740);
			NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, 100684741);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr, 100684742);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 682950, RefRangeEnd = 682951, XrefRangeStart = 682886, XrefRangeEnd = 682950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RoleBlock(Role role)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoleBlock_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683003, RefRangeEnd = 683004, XrefRangeStart = 682951, XrefRangeEnd = 683003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotRoleBlock(GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotRoleBlock_Public_Boolean_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Block()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Block_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683004, XrefRangeEnd = 683007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanTraverse(Path path, GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683007, XrefRangeEnd = 683008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint GetTraversalCost(Path path, GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683018, RefRangeEnd = 683019, XrefRangeStart = 683008, XrefRangeEnd = 683018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFindingProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFindingProvider>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PathFindingProvider(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BattleTraversalProvider : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_tempBlocklist;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0;

		public unsafe List<GraphNode> tempBlocklist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempBlocklist);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GraphNode>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempBlocklist)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static BattleTraversalProvider()
		{
			Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "BattleTraversalProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr);
			NativeFieldInfoPtr_tempBlocklist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr, "tempBlocklist");
			NativeMethodInfoPtr__ctor_Public_Void_List_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr, 100684743);
			NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr, 100684744);
			NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr, 100684745);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683026, RefRangeEnd = 683027, XrefRangeStart = 683019, XrefRangeEnd = 683026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleTraversalProvider(List<GraphNode> node = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleTraversalProvider>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683027, XrefRangeEnd = 683032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanTraverse(Path path, GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanTraverse_Public_Virtual_Final_New_Boolean_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683032, XrefRangeEnd = 683048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint GetTraversalCost(Path path, GraphNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraversalCost_Public_Virtual_Final_New_UInt32_Path_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public BattleTraversalProvider(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_LandDic;

	private static readonly System.IntPtr NativeFieldInfoPtr_WalkAbleChangeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_PosDic;

	private static readonly System.IntPtr NativeFieldInfoPtr_landList;

	private static readonly System.IntPtr NativeFieldInfoPtr_C_map;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePetProvider_Public_Void_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRolePosDic_Public_Dictionary_2_Role_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRolePosList_Public_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRolePosListForPathFinding_Public_ICollection_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNotRolePosList_Public_List_1_Vector3Int_List_1_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WhoIsHere_Public_Role_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRole_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isOccupy_Public_Boolean_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitPathfindingData_Public_List_1_Vector3Int_MapEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRolePos_Public_Void_Role_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPathBolck_Public_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPathRange_Public_Void_List_1_Vector3Int_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPath_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPath_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_ITraversalProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPathOrObstruct_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewPath_Public_ABPath_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBlock_Public_Void_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBlockWalk_Public_Void_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCanWalk_Public_Void_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBlockWalk_Public_Void_List_1_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCanWalk_Public_Void_List_1_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Player player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player));
		}
	}

	public unsafe Dictionary<XAndY, Vector3Int> LandDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LandDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<XAndY, Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LandDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Vector3Int> WalkAbleChangeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkAbleChangeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkAbleChangeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleTraversalProvider cachedProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleTraversalProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleTraversalProvider));
		}
	}

	public unsafe PathFindingProvider NpcProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathFindingProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathFindingProvider));
		}
	}

	public unsafe PlayerPetProvider PetProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPetProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerPetProvider));
		}
	}

	public unsafe Dictionary<Role, Vector3Int> PosDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PosDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Role, Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PosDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Vector3Int> landList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Tilemap C_map
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_C_map);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_C_map)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap));
		}
	}

	static PathFindingManager()
	{
		Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PathFindingManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr);
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "player");
		NativeFieldInfoPtr_LandDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "LandDic");
		NativeFieldInfoPtr_WalkAbleChangeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "WalkAbleChangeList");
		NativeFieldInfoPtr_cachedProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "cachedProvider");
		NativeFieldInfoPtr_NpcProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "NpcProvider");
		NativeFieldInfoPtr_PetProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "PetProvider");
		NativeFieldInfoPtr_PosDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "PosDic");
		NativeFieldInfoPtr_landList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "landList");
		NativeFieldInfoPtr_C_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, "C_map");
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_CreatePetProvider_Public_Void_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr_GetRolePosDic_Public_Dictionary_2_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664072);
		NativeMethodInfoPtr_GetRolePosList_Public_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_GetRolePosListForPathFinding_Public_ICollection_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_GetNotRolePosList_Public_List_1_Vector3Int_List_1_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_WhoIsHere_Public_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_RemoveRole_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_isOccupy_Public_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_InitPathfindingData_Public_List_1_Vector3Int_MapEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664079);
		NativeMethodInfoPtr_UpdateRolePos_Public_Void_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_SetPathBolck_Public_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_SetPathRange_Public_Void_List_1_Vector3Int_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_FindPath_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_FindPath_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_ITraversalProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_FindPathOrObstruct_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_GetNewPath_Public_ABPath_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_SetBlock_Public_Void_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_SetBlockWalk_Public_Void_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_SetCanWalk_Public_Void_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_SetBlockWalk_Public_Void_List_1_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_SetCanWalk_Public_Void_List_1_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr, 100664092);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreatePetProvider(Npc npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePetProvider_Public_Void_Npc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 18831, RefRangeEnd = 18845, XrefRangeStart = 18831, XrefRangeEnd = 18845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<Role, Vector3Int> GetRolePosDic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRolePosDic_Public_Dictionary_2_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Role, Vector3Int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 683057, RefRangeEnd = 683059, XrefRangeStart = 683048, XrefRangeEnd = 683057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> GetRolePosList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRolePosList_Public_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 683063, RefRangeEnd = 683071, XrefRangeStart = 683059, XrefRangeEnd = 683063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ICollection<Vector3Int> GetRolePosListForPathFinding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRolePosListForPathFinding_Public_ICollection_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 683105, RefRangeEnd = 683107, XrefRangeStart = 683071, XrefRangeEnd = 683105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> GetNotRolePosList(List<Role> roleList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roleList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNotRolePosList_Public_List_1_Vector3Int_List_1_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 683135, RefRangeEnd = 683143, XrefRangeStart = 683107, XrefRangeEnd = 683135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Role WhoIsHere(Vector3Int Pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WhoIsHere_Public_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Role>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683149, RefRangeEnd = 683150, XrefRangeStart = 683143, XrefRangeEnd = 683149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRole(Role role)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRole_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683153, RefRangeEnd = 683154, XrefRangeStart = 683150, XrefRangeEnd = 683153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isOccupy(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isOccupy_Public_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 683218, RefRangeEnd = 683222, XrefRangeStart = 683154, XrefRangeEnd = 683218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector3Int> InitPathfindingData(MapEntity obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPathfindingData_Public_List_1_Vector3Int_MapEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 683299, RefRangeEnd = 683324, XrefRangeStart = 683222, XrefRangeEnd = 683299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRolePos(Role role, Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRolePos_Public_Void_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683326, RefRangeEnd = 683327, XrefRangeStart = 683324, XrefRangeEnd = 683326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPathBolck(Role role = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPathBolck_Public_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683402, RefRangeEnd = 683403, XrefRangeStart = 683327, XrefRangeEnd = 683402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPathRange(List<Vector3Int> nowlist, List<Vector3Int> falseNodelist = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nowlist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)falseNodelist);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPathRange_Public_Void_List_1_Vector3Int_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 683450, RefRangeEnd = 683453, XrefRangeStart = 683403, XrefRangeEnd = 683450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindPath(Vector3Int a, Vector3Int b, ref Il2CppStructArray<Vector3Int> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPath_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		path = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3Int>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683503, RefRangeEnd = 683504, XrefRangeStart = 683453, XrefRangeEnd = 683503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindPath(Vector3Int a, Vector3Int b, ref Il2CppStructArray<Vector3Int> path, ITraversalProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPath_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_ITraversalProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		path = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3Int>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 683550, RefRangeEnd = 683552, XrefRangeStart = 683504, XrefRangeEnd = 683550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindPathOrObstruct(Vector3Int a, Vector3Int b, ref Il2CppStructArray<Vector3Int> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPathOrObstruct_Public_Boolean_Vector3Int_Vector3Int_byref_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		path = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3Int>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683552, XrefRangeEnd = 683556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ABPath GetNewPath(Vector3 start, Vector3 end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewPath_Public_ABPath_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ABPath>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683616, RefRangeEnd = 683617, XrefRangeStart = 683556, XrefRangeEnd = 683616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBlock(List<Vector3Int> nowlist)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nowlist);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBlock_Public_Void_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683617, XrefRangeEnd = 683625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBlockWalk(Vector3Int pos, bool isLoad = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLoad;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBlockWalk_Public_Void_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683625, XrefRangeEnd = 683641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCanWalk(Vector3Int pos, bool isLoad = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLoad;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCanWalk_Public_Void_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 683670, RefRangeEnd = 683673, XrefRangeStart = 683641, XrefRangeEnd = 683670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBlockWalk(List<Vector3Int> pos, bool isLoad = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pos);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLoad;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBlockWalk_Public_Void_List_1_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 683706, RefRangeEnd = 683708, XrefRangeStart = 683673, XrefRangeEnd = 683706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCanWalk(List<Vector3Int> pos, bool isLoad = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pos);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLoad;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCanWalk_Public_Void_List_1_Vector3Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683708, XrefRangeEnd = 683744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PathFindingManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFindingManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PathFindingManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
