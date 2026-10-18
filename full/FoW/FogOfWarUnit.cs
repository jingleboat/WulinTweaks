using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace FoW;

public class FogOfWarUnit : MonoBehaviour
{
	private sealed class MethodInfoStoreGeneric_GetShapeFromCache_Private_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetShapeFromCache_Private_T_0, Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_team;

	private static readonly System.IntPtr NativeFieldInfoPtr_brightness;

	private static readonly System.IntPtr NativeFieldInfoPtr_shapeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_absoluteOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_boxSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_circleRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_innerRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_texture;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotateToForward;

	private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr__meshVertices;

	private static readonly System.IntPtr NativeFieldInfoPtr__meshIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOfSightMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOfSightRaycastCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOfSightPenetration;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOfSightRaycastAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOfSightRaycastOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOfSightSeeOutsideRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_multithreading;

	private static readonly System.IntPtr NativeFieldInfoPtr__multithreadRaycasts;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellBased;

	private static readonly System.IntPtr NativeFieldInfoPtr_snapToPixelCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr__distances;

	private static readonly System.IntPtr NativeFieldInfoPtr__visibleCells;

	private static readonly System.IntPtr NativeFieldInfoPtr__transform;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedShape;

	private static readonly System.IntPtr NativeFieldInfoPtr__registeredUnits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_registeredUnits_Public_Static_get_List_1_FogOfWarUnit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupMultithreadRaycasts_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRaycastAngles_Private_Void_byref_Single_byref_Single_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLineOfSight2D_Private_Boolean_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLineOfSight3D_Private_Boolean_Vector3_Single_Single_LayerMask_Vector3_Vector3_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLineOfSight_Private_Il2CppStructArray_1_Single_FogOfWarPhysics_Vector3_FogOfWarPlane_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sign_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLineOfSightCells_Private_Il2CppStructArray_1_Boolean_FogOfWarTeam_FogOfWarPhysics_Vector3_Single_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillShape_Private_Void_FogOfWarTeam_FogOfWarShape_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShapeFromCache_Private_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShape_Private_FogOfWarShape_FogOfWarTeam_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShape_Public_FogOfWarShape_FogOfWarTeam_FogOfWarPhysics_FogOfWarPlane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrayRaycastGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int team
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_team);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_team)) = num;
		}
	}

	public unsafe float brightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightness)) = num;
		}
	}

	public unsafe FogOfWarShapeType shapeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeType);
			return *(FogOfWarShapeType*)num;
		}
		set
		{
			*(FogOfWarShapeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeType)) = fogOfWarShapeType;
		}
	}

	public unsafe bool absoluteOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_absoluteOffset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_absoluteOffset)) = flag;
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

	public unsafe Vector2 boxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boxSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boxSize)) = vector;
		}
	}

	public unsafe float circleRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_circleRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_circleRadius)) = num;
		}
	}

	public unsafe float innerRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innerRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innerRadius)) = num;
		}
	}

	public unsafe float angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
		}
	}

	public unsafe Texture2D texture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe bool rotateToForward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateToForward);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateToForward)) = flag;
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

	public unsafe Mesh _lastMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Il2CppStructArray<Vector3> _meshVertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshVertices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshVertices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> _meshIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshIndices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe LayerMask lineOfSightMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightMask)) = layerMask;
		}
	}

	public unsafe int lineOfSightRaycastCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightRaycastCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightRaycastCount)) = num;
		}
	}

	public unsafe float lineOfSightPenetration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightPenetration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightPenetration)) = num;
		}
	}

	public unsafe float lineOfSightRaycastAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightRaycastAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightRaycastAngle)) = num;
		}
	}

	public unsafe float lineOfSightRaycastOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightRaycastOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightRaycastOffset)) = num;
		}
	}

	public unsafe bool lineOfSightSeeOutsideRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightSeeOutsideRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOfSightSeeOutsideRange)) = flag;
		}
	}

	public unsafe bool multithreading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multithreading);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multithreading)) = flag;
		}
	}

	public unsafe FogOfWarUnitRaycasts _multithreadRaycasts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__multithreadRaycasts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarUnitRaycasts>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__multithreadRaycasts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogOfWarUnitRaycasts));
		}
	}

	public unsafe bool cellBased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellBased);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellBased)) = flag;
		}
	}

	public unsafe bool snapToPixelCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snapToPixelCenter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snapToPixelCenter)) = flag;
		}
	}

	public unsafe Il2CppStructArray<float> _distances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__distances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__distances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<bool> _visibleCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__visibleCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__visibleCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Transform _transform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe FogOfWarShape _cachedShape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedShape);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarShape>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedShape)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogOfWarShape));
		}
	}

	public unsafe static List<FogOfWarUnit> _registeredUnits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__registeredUnits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FogOfWarUnit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__registeredUnits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<FogOfWarUnit> registeredUnits
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722051, XrefRangeEnd = 722055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_registeredUnits_Public_Static_get_List_1_FogOfWarUnit_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FogOfWarUnit>>(intPtr) : null;
		}
	}

	static FogOfWarUnit()
	{
		Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarUnit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr);
		NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "team");
		NativeFieldInfoPtr_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "brightness");
		NativeFieldInfoPtr_shapeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "shapeType");
		NativeFieldInfoPtr_absoluteOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "absoluteOffset");
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "offset");
		NativeFieldInfoPtr_boxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "boxSize");
		NativeFieldInfoPtr_circleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "circleRadius");
		NativeFieldInfoPtr_innerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "innerRadius");
		NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "angle");
		NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "texture");
		NativeFieldInfoPtr_rotateToForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "rotateToForward");
		NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "mesh");
		NativeFieldInfoPtr__lastMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_lastMesh");
		NativeFieldInfoPtr__meshVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_meshVertices");
		NativeFieldInfoPtr__meshIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_meshIndices");
		NativeFieldInfoPtr_lineOfSightMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "lineOfSightMask");
		NativeFieldInfoPtr_lineOfSightRaycastCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "lineOfSightRaycastCount");
		NativeFieldInfoPtr_lineOfSightPenetration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "lineOfSightPenetration");
		NativeFieldInfoPtr_lineOfSightRaycastAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "lineOfSightRaycastAngle");
		NativeFieldInfoPtr_lineOfSightRaycastOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "lineOfSightRaycastOffset");
		NativeFieldInfoPtr_lineOfSightSeeOutsideRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "lineOfSightSeeOutsideRange");
		NativeFieldInfoPtr_multithreading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "multithreading");
		NativeFieldInfoPtr__multithreadRaycasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_multithreadRaycasts");
		NativeFieldInfoPtr_cellBased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "cellBased");
		NativeFieldInfoPtr_snapToPixelCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "snapToPixelCenter");
		NativeFieldInfoPtr__distances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_distances");
		NativeFieldInfoPtr__visibleCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_visibleCells");
		NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_transform");
		NativeFieldInfoPtr__cachedShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_cachedShape");
		NativeFieldInfoPtr__registeredUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, "_registeredUnits");
		NativeMethodInfoPtr_get_registeredUnits_Public_Static_get_List_1_FogOfWarUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667071);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667072);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667073);
		NativeMethodInfoPtr_CleanupMultithreadRaycasts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667074);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667075);
		NativeMethodInfoPtr_CalculateRaycastAngles_Private_Void_byref_Single_byref_Single_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667076);
		NativeMethodInfoPtr_CalculateLineOfSight2D_Private_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_CalculateLineOfSight3D_Private_Boolean_Vector3_Single_Single_LayerMask_Vector3_Vector3_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr_CalculateLineOfSight_Private_Il2CppStructArray_1_Single_FogOfWarPhysics_Vector3_FogOfWarPlane_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr_Sign_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667080);
		NativeMethodInfoPtr_CalculateLineOfSightCells_Private_Il2CppStructArray_1_Boolean_FogOfWarTeam_FogOfWarPhysics_Vector3_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr_FillShape_Private_Void_FogOfWarTeam_FogOfWarShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr_GetShapeFromCache_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667083);
		NativeMethodInfoPtr_CreateShape_Private_FogOfWarShape_FogOfWarTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr_GetShape_Public_FogOfWarShape_FogOfWarTeam_FogOfWarPhysics_FogOfWarPlane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667085);
		NativeMethodInfoPtr_DrayRaycastGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667087);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr, 100667088);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722055, XrefRangeEnd = 722056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722056, XrefRangeEnd = 722068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722074, RefRangeEnd = 722075, XrefRangeStart = 722068, XrefRangeEnd = 722074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupMultithreadRaycasts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupMultithreadRaycasts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722075, XrefRangeEnd = 722088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722091, RefRangeEnd = 722092, XrefRangeStart = 722088, XrefRangeEnd = 722091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateRaycastAngles(out float angle, out float raycastoffset, FogOfWarPlane plane)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref angle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raycastoffset);
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRaycastAngles_Private_Void_byref_Single_byref_Single_FogOfWarPlane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722113, RefRangeEnd = 722114, XrefRangeStart = 722092, XrefRangeEnd = 722113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CalculateLineOfSight2D(Vector2 eye, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eye);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLineOfSight2D_Private_Boolean_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722162, RefRangeEnd = 722163, XrefRangeStart = 722114, XrefRangeEnd = 722162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CalculateLineOfSight3D(Vector3 eye, float radius, float penetration, LayerMask layermask, Vector3 up, Vector3 forward, FogOfWarPlane plane)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&eye);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &penetration;
		*(LayerMask**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layermask;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forward;
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLineOfSight3D_Private_Boolean_Vector3_Single_Single_LayerMask_Vector3_Vector3_FogOfWarPlane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722176, RefRangeEnd = 722177, XrefRangeStart = 722163, XrefRangeEnd = 722176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> CalculateLineOfSight(FogOfWarPhysics physicsmode, Vector3 eyepos, FogOfWarPlane plane, float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&physicsmode);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eyepos;
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLineOfSight_Private_Il2CppStructArray_1_Single_FogOfWarPhysics_Vector3_FogOfWarPlane_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722178, RefRangeEnd = 722180, XrefRangeStart = 722177, XrefRangeEnd = 722178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Sign(float v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sign_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722210, RefRangeEnd = 722211, XrefRangeStart = 722180, XrefRangeEnd = 722210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<bool> CalculateLineOfSightCells(FogOfWarTeam fow, FogOfWarPhysics physicsmode, Vector3 eyepos, float distance, out int visiblecellswidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		*(FogOfWarPhysics**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &physicsmode;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eyepos;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref visiblecellswidth);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLineOfSightCells_Private_Il2CppStructArray_1_Boolean_FogOfWarTeam_FogOfWarPhysics_Vector3_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722221, RefRangeEnd = 722222, XrefRangeStart = 722211, XrefRangeEnd = 722221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillShape(FogOfWarTeam fow, FogOfWarShape shape)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillShape_Private_Void_FogOfWarTeam_FogOfWarShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722225, RefRangeEnd = 722227, XrefRangeStart = 722222, XrefRangeEnd = 722225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetShapeFromCache<T>() where T : FogOfWarShape, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetShapeFromCache_Private_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722262, RefRangeEnd = 722263, XrefRangeStart = 722227, XrefRangeEnd = 722262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarShape CreateShape(FogOfWarTeam fow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShape_Private_FogOfWarShape_FogOfWarTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarShape>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722267, RefRangeEnd = 722268, XrefRangeStart = 722263, XrefRangeEnd = 722267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarShape GetShape(FogOfWarTeam fow, FogOfWarPhysics physics, FogOfWarPlane plane)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		*(FogOfWarPhysics**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &physics;
		*(FogOfWarPlane**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShape_Public_FogOfWarShape_FogOfWarTeam_FogOfWarPhysics_FogOfWarPlane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarShape>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722289, RefRangeEnd = 722290, XrefRangeStart = 722268, XrefRangeEnd = 722289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrayRaycastGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrayRaycastGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722290, XrefRangeEnd = 722306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmosSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722306, XrefRangeEnd = 722309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarUnit()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarUnit>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarUnit(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
