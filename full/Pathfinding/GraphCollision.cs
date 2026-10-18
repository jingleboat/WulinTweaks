using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding;

[System.Serializable]
public class GraphCollision : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_diameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_collisionOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_rayDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_mask;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_thickRaycast;

	private static readonly System.IntPtr NativeFieldInfoPtr_thickRaycastDiameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_unwalkableWhenNoGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_use2D;

	private static readonly System.IntPtr NativeFieldInfoPtr_collisionCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_up;

	private static readonly System.IntPtr NativeFieldInfoPtr_upheight;

	private static readonly System.IntPtr NativeFieldInfoPtr_contactFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_dummyArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalRaycastRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_RaycastErrorMargin;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_GraphTransform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeight_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeight_Public_Vector3_Vector3_byref_RaycastHit_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHeightAll_Public_Il2CppStructArray_1_RaycastHit_Vector3_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSettingsCompatibility_Public_Void_GraphSerializationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ColliderType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ColliderType*)num;
		}
		set
		{
			*(ColliderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = colliderType;
		}
	}

	public unsafe float diameter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diameter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diameter)) = num;
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

	public unsafe float collisionOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionOffset)) = num;
		}
	}

	public unsafe RayDirection rayDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayDirection);
			return *(RayDirection*)num;
		}
		set
		{
			*(RayDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayDirection)) = rayDirection;
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

	public unsafe LayerMask heightMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMask)) = layerMask;
		}
	}

	public unsafe float fromHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromHeight)) = num;
		}
	}

	public unsafe bool thickRaycast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickRaycast);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickRaycast)) = flag;
		}
	}

	public unsafe float thickRaycastDiameter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickRaycastDiameter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickRaycastDiameter)) = num;
		}
	}

	public unsafe bool unwalkableWhenNoGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unwalkableWhenNoGround);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unwalkableWhenNoGround)) = flag;
		}
	}

	public unsafe bool use2D
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use2D);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use2D)) = flag;
		}
	}

	public unsafe bool collisionCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionCheck)) = flag;
		}
	}

	public unsafe bool heightCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightCheck)) = flag;
		}
	}

	public unsafe Vector3 up
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up)) = vector;
		}
	}

	public unsafe Vector3 upheight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upheight);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upheight)) = vector;
		}
	}

	public unsafe ContactFilter2D contactFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactFilter);
			return *(ContactFilter2D*)num;
		}
		set
		{
			*(ContactFilter2D*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactFilter)) = contactFilter2D;
		}
	}

	public unsafe static Il2CppReferenceArray<Collider2D> dummyArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dummyArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dummyArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe float finalRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalRadius)) = num;
		}
	}

	public unsafe float finalRaycastRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalRaycastRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalRaycastRadius)) = num;
		}
	}

	public unsafe static float RaycastErrorMargin
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RaycastErrorMargin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RaycastErrorMargin, (void*)(&num));
		}
	}

	public unsafe Il2CppStructArray<RaycastHit> hitBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static GraphCollision()
	{
		Il2CppClassPointerStore<GraphCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "GraphCollision");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "type");
		NativeFieldInfoPtr_diameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "diameter");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "height");
		NativeFieldInfoPtr_collisionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "collisionOffset");
		NativeFieldInfoPtr_rayDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "rayDirection");
		NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "mask");
		NativeFieldInfoPtr_heightMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "heightMask");
		NativeFieldInfoPtr_fromHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "fromHeight");
		NativeFieldInfoPtr_thickRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "thickRaycast");
		NativeFieldInfoPtr_thickRaycastDiameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "thickRaycastDiameter");
		NativeFieldInfoPtr_unwalkableWhenNoGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "unwalkableWhenNoGround");
		NativeFieldInfoPtr_use2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "use2D");
		NativeFieldInfoPtr_collisionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "collisionCheck");
		NativeFieldInfoPtr_heightCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "heightCheck");
		NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "up");
		NativeFieldInfoPtr_upheight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "upheight");
		NativeFieldInfoPtr_contactFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "contactFilter");
		NativeFieldInfoPtr_dummyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "dummyArray");
		NativeFieldInfoPtr_finalRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "finalRadius");
		NativeFieldInfoPtr_finalRaycastRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "finalRaycastRadius");
		NativeFieldInfoPtr_RaycastErrorMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "RaycastErrorMargin");
		NativeFieldInfoPtr_hitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, "hitBuffer");
		NativeMethodInfoPtr_Initialize_Public_Void_GraphTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683082);
		NativeMethodInfoPtr_Check_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683083);
		NativeMethodInfoPtr_CheckHeight_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683084);
		NativeMethodInfoPtr_CheckHeight_Public_Vector3_Vector3_byref_RaycastHit_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683085);
		NativeMethodInfoPtr_CheckHeightAll_Public_Il2CppStructArray_1_RaycastHit_Vector3_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683086);
		NativeMethodInfoPtr_DeserializeSettingsCompatibility_Public_Void_GraphSerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683087);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr, 100683088);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068225, RefRangeEnd = 1068227, XrefRangeStart = 1068220, XrefRangeEnd = 1068225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(GraphTransform transform, float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_GraphTransform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068237, RefRangeEnd = 1068239, XrefRangeStart = 1068227, XrefRangeEnd = 1068237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Check(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068239, XrefRangeEnd = 1068240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 CheckHeight(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeight_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068247, RefRangeEnd = 1068249, XrefRangeStart = 1068240, XrefRangeEnd = 1068247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 CheckHeight(Vector3 position, out RaycastHit hit, out bool walkable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hit);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref walkable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeight_Public_Vector3_Vector3_byref_RaycastHit_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068255, RefRangeEnd = 1068257, XrefRangeStart = 1068249, XrefRangeEnd = 1068255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<RaycastHit> CheckHeightAll(Vector3 position, out int numHits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref numHits);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHeightAll_Public_Il2CppStructArray_1_RaycastHit_Vector3_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068259, RefRangeEnd = 1068260, XrefRangeStart = 1068257, XrefRangeEnd = 1068259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeSettingsCompatibility_Public_Void_GraphSerializationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068265, RefRangeEnd = 1068266, XrefRangeStart = 1068260, XrefRangeEnd = 1068265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphCollision()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphCollision>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GraphCollision(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
