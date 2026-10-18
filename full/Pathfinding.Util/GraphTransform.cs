using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding.Util;

public class GraphTransform : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_identity;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyTranslational;

	private static readonly System.IntPtr NativeFieldInfoPtr_isXY;

	private static readonly System.IntPtr NativeFieldInfoPtr_isXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_matrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_up;

	private static readonly System.IntPtr NativeFieldInfoPtr_translation;

	private static readonly System.IntPtr NativeFieldInfoPtr_i3translation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_identityTransform;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldUpAtGraphPosition_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatrixIsTranslational_Private_Static_Boolean_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_Void_Il2CppStructArray_1_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_Void_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransform_Public_Virtual_Final_New_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransform_Public_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransform_Public_Void_Il2CppStructArray_1_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_GraphTransform_GraphTransform_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_GraphTransform_Matrix4x4_GraphTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_Bounds_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransform_Public_Bounds_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToPlane_Private_Virtual_Final_New_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToPlane_Private_Virtual_Final_New_Vector2_Vector3_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToWorld_Private_Virtual_Final_New_Vector3_Vector2_Single_0;

	public unsafe bool identity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identity)) = flag;
		}
	}

	public unsafe bool onlyTranslational
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyTranslational);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyTranslational)) = flag;
		}
	}

	public unsafe bool isXY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXY)) = flag;
		}
	}

	public unsafe bool isXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXZ);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isXZ)) = flag;
		}
	}

	public unsafe Matrix4x4 matrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrix)) = matrix4x;
		}
	}

	public unsafe Matrix4x4 inverseMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseMatrix)) = matrix4x;
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

	public unsafe Vector3 translation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translation)) = vector;
		}
	}

	public unsafe Int3 i3translation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i3translation);
			return *(Int3*)num;
		}
		set
		{
			*(Int3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i3translation)) = @int;
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = quaternion;
		}
	}

	public unsafe Quaternion inverseRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseRotation)) = quaternion;
		}
	}

	public unsafe static GraphTransform identityTransform
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_identityTransform, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_identityTransform, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphTransform));
		}
	}

	static GraphTransform()
	{
		Il2CppClassPointerStore<GraphTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "GraphTransform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr);
		NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "identity");
		NativeFieldInfoPtr_onlyTranslational = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "onlyTranslational");
		NativeFieldInfoPtr_isXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "isXY");
		NativeFieldInfoPtr_isXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "isXZ");
		NativeFieldInfoPtr_matrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "matrix");
		NativeFieldInfoPtr_inverseMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "inverseMatrix");
		NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "up");
		NativeFieldInfoPtr_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "translation");
		NativeFieldInfoPtr_i3translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "i3translation");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_inverseRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "inverseRotation");
		NativeFieldInfoPtr_identityTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, "identityTransform");
		NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684328);
		NativeMethodInfoPtr_WorldUpAtGraphPosition_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684329);
		NativeMethodInfoPtr_MatrixIsTranslational_Private_Static_Boolean_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684330);
		NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684331);
		NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684332);
		NativeMethodInfoPtr_Transform_Public_Void_Il2CppStructArray_1_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684333);
		NativeMethodInfoPtr_Transform_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684334);
		NativeMethodInfoPtr_InverseTransform_Public_Virtual_Final_New_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684335);
		NativeMethodInfoPtr_InverseTransform_Public_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684336);
		NativeMethodInfoPtr_InverseTransform_Public_Void_Il2CppStructArray_1_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684337);
		NativeMethodInfoPtr_op_Multiply_Public_Static_GraphTransform_GraphTransform_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684338);
		NativeMethodInfoPtr_op_Multiply_Public_Static_GraphTransform_Matrix4x4_GraphTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684339);
		NativeMethodInfoPtr_Transform_Public_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684340);
		NativeMethodInfoPtr_InverseTransform_Public_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684341);
		NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToPlane_Private_Virtual_Final_New_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684342);
		NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToPlane_Private_Virtual_Final_New_Vector2_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684343);
		NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToWorld_Private_Virtual_Final_New_Vector3_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr, 100684344);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1084006, RefRangeEnd = 1084017, XrefRangeStart = 1083983, XrefRangeEnd = 1084006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphTransform(Matrix4x4 matrix)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphTransform>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector3 WorldUpAtGraphPosition(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldUpAtGraphPosition_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084024, RefRangeEnd = 1084025, XrefRangeStart = 1084017, XrefRangeEnd = 1084024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatrixIsTranslational(Matrix4x4 matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatrixIsTranslational_Private_Static_Boolean_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 1084026, RefRangeEnd = 1084073, XrefRangeStart = 1084025, XrefRangeEnd = 1084026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector3 Transform(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1084074, RefRangeEnd = 1084077, XrefRangeStart = 1084073, XrefRangeEnd = 1084074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 TransformVector(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1084080, RefRangeEnd = 1084085, XrefRangeStart = 1084077, XrefRangeEnd = 1084080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Transform(Il2CppStructArray<Int3> arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Transform_Public_Void_Il2CppStructArray_1_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084086, RefRangeEnd = 1084087, XrefRangeStart = 1084085, XrefRangeEnd = 1084086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Transform(Il2CppStructArray<Vector3> arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Transform_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1084088, RefRangeEnd = 1084122, XrefRangeStart = 1084087, XrefRangeEnd = 1084088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector3 InverseTransform(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransform_Public_Virtual_Final_New_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084127, RefRangeEnd = 1084128, XrefRangeStart = 1084122, XrefRangeEnd = 1084127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3 InverseTransform(Int3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransform_Public_Int3_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084131, RefRangeEnd = 1084132, XrefRangeStart = 1084128, XrefRangeEnd = 1084131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InverseTransform(Il2CppStructArray<Int3> arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransform_Public_Void_Il2CppStructArray_1_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1084137, RefRangeEnd = 1084140, XrefRangeStart = 1084132, XrefRangeEnd = 1084137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphTransform operator *(GraphTransform lhs, Matrix4x4 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_GraphTransform_GraphTransform_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084145, RefRangeEnd = 1084146, XrefRangeStart = 1084140, XrefRangeEnd = 1084145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphTransform operator *(Matrix4x4 lhs, GraphTransform rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_GraphTransform_Matrix4x4_GraphTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphTransform>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1084190, RefRangeEnd = 1084193, XrefRangeStart = 1084146, XrefRangeEnd = 1084190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Bounds Transform(Bounds bounds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Transform_Public_Bounds_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1084237, RefRangeEnd = 1084243, XrefRangeStart = 1084193, XrefRangeEnd = 1084237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Bounds InverseTransform(Bounds bounds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransform_Public_Bounds_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084243, XrefRangeEnd = 1084244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector2 Pathfinding_Util_IMovementPlane_ToPlane(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToPlane_Private_Virtual_Final_New_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084244, XrefRangeEnd = 1084245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector2 Pathfinding_Util_IMovementPlane_ToPlane(Vector3 point, out float elevation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&point);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref elevation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToPlane_Private_Virtual_Final_New_Vector2_Vector3_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084245, XrefRangeEnd = 1084246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector3 Pathfinding_Util_IMovementPlane_ToWorld(Vector2 point, float elevation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&point);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &elevation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pathfinding_Util_IMovementPlane_ToWorld_Private_Virtual_Final_New_Vector3_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GraphTransform(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
