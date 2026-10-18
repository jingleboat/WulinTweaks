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
using UnityEngine.UI;

namespace ChartAndGraph;

public class ChartCommon : Il2CppSystem.Object
{
	public class IntComparer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static IntComparer()
		{
			Il2CppClassPointerStore<IntComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, "IntComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntComparer>.NativeClassPtr);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntComparer>.NativeClassPtr, 100685878);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntComparer>.NativeClassPtr, 100685879);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntComparer>.NativeClassPtr, 100685880);
		}

		[CallerCount(0)]
		public unsafe virtual bool Equals(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&x);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(int obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntComparer>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IntComparer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_EnsureComponent_Internal_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnsureComponent_Internal_Static_T_GameObject_0, Il2CppClassPointerStore<ChartCommon>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr__DefaultIntComparer_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothLerp_Internal_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCanvasChartItem_Internal_Static_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateChartItem_Internal_Static_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideObject_Internal_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAutoLength_Internal_Static_Single_AnyChart_ChartOrientation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAutoDepth_Internal_Static_Single_AnyChart_ChartOrientation_ChartDivisionInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAutoLength_Internal_Static_Single_AnyChart_ChartOrientation_ChartDivisionInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Perpendicular_Internal_Static_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SegmentIntersection_Internal_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromPolarRadians_Internal_Static_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromPolar_Internal_Static_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixRect_Internal_Static_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultMaterial_Internal_Static_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SafeAssignMaterial_Internal_Static_Boolean_Renderer_Material_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanMesh_Internal_Static_Void_Mesh_byref_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInEditMode_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SafeDestroy_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateVertex_Internal_Static_UIVertex_Vector3_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateVertex_Internal_Static_UIVertex_Vector3_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTiling_Internal_Static_Single_MaterialTiling_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixBillboardText_Internal_Static_Void_ItemLabelsBase_BillboardText_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureComponent_Internal_Static_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DotProduct_Private_Static_Single_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CrossProduct_Private_Static_Single_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SegmentPointSqrDistance_Internal_Static_Single_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBillboardText_Internal_Static_BillboardText_BillboardText_Transform_String_Single_Single_Single_Single_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBillboardText_Internal_Static_BillboardText_BillboardText_Text_Transform_String_Single_Single_Single_Single_Transform_Boolean_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultIntComparer_Public_Static_get_IEqualityComparer_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultIntComparer_Private_Static_set_Void_IEqualityComparer_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Material mDefaultMaterial
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mDefaultMaterial, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mDefaultMaterial, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe static IEqualityComparer<int> _DefaultIntComparer_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DefaultIntComparer_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEqualityComparer<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DefaultIntComparer_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equalityComparer));
		}
	}

	public unsafe static Material DefaultMaterial
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753676, XrefRangeEnd = 753700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultMaterial_Internal_Static_get_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
	}

	public unsafe static bool IsInEditMode
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 753764, RefRangeEnd = 753771, XrefRangeStart = 753763, XrefRangeEnd = 753764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsInEditMode_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static IEqualityComparer<int> DefaultIntComparer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753983, XrefRangeEnd = 753987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultIntComparer_Public_Static_get_IEqualityComparer_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEqualityComparer<int>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753987, XrefRangeEnd = 753991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DefaultIntComparer_Private_Static_set_Void_IEqualityComparer_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ChartCommon()
	{
		Il2CppClassPointerStore<ChartCommon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartCommon");
		NativeFieldInfoPtr_mDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, "mDefaultMaterial");
		NativeFieldInfoPtr__DefaultIntComparer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, "<DefaultIntComparer>k__BackingField");
		NativeMethodInfoPtr_SmoothLerp_Internal_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669749);
		NativeMethodInfoPtr_CreateCanvasChartItem_Internal_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669750);
		NativeMethodInfoPtr_CreateChartItem_Internal_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669751);
		NativeMethodInfoPtr_HideObject_Internal_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669752);
		NativeMethodInfoPtr_GetAutoLength_Internal_Static_Single_AnyChart_ChartOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669753);
		NativeMethodInfoPtr_GetAutoDepth_Internal_Static_Single_AnyChart_ChartOrientation_ChartDivisionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669754);
		NativeMethodInfoPtr_GetAutoLength_Internal_Static_Single_AnyChart_ChartOrientation_ChartDivisionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669755);
		NativeMethodInfoPtr_Perpendicular_Internal_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669756);
		NativeMethodInfoPtr_SegmentIntersection_Internal_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669757);
		NativeMethodInfoPtr_FromPolarRadians_Internal_Static_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669758);
		NativeMethodInfoPtr_FromPolar_Internal_Static_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669759);
		NativeMethodInfoPtr_FixRect_Internal_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669760);
		NativeMethodInfoPtr_get_DefaultMaterial_Internal_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669761);
		NativeMethodInfoPtr_SafeAssignMaterial_Internal_Static_Boolean_Renderer_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669762);
		NativeMethodInfoPtr_CleanMesh_Internal_Static_Void_Mesh_byref_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669763);
		NativeMethodInfoPtr_get_IsInEditMode_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669764);
		NativeMethodInfoPtr_SafeDestroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669765);
		NativeMethodInfoPtr_CreateVertex_Internal_Static_UIVertex_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669766);
		NativeMethodInfoPtr_CreateVertex_Internal_Static_UIVertex_Vector3_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669767);
		NativeMethodInfoPtr_GetTiling_Internal_Static_Single_MaterialTiling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669768);
		NativeMethodInfoPtr_FixBillboardText_Internal_Static_Void_ItemLabelsBase_BillboardText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669769);
		NativeMethodInfoPtr_EnsureComponent_Internal_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669770);
		NativeMethodInfoPtr_DotProduct_Private_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669771);
		NativeMethodInfoPtr_CrossProduct_Private_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669772);
		NativeMethodInfoPtr_SegmentPointSqrDistance_Internal_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669773);
		NativeMethodInfoPtr_UpdateBillboardText_Internal_Static_BillboardText_BillboardText_Transform_String_Single_Single_Single_Single_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669774);
		NativeMethodInfoPtr_CreateBillboardText_Internal_Static_BillboardText_BillboardText_Text_Transform_String_Single_Single_Single_Single_Transform_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669775);
		NativeMethodInfoPtr_get_DefaultIntComparer_Public_Static_get_IEqualityComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669776);
		NativeMethodInfoPtr_set_DefaultIntComparer_Private_Static_set_Void_IEqualityComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669777);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr, 100669778);
	}

	[CallerCount(0)]
	public unsafe static float SmoothLerp(float from, float to, float factor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &factor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothLerp_Internal_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 753573, RefRangeEnd = 753579, XrefRangeStart = 753554, XrefRangeEnd = 753573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateCanvasChartItem()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCanvasChartItem_Internal_Static_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 753586, RefRangeEnd = 753593, XrefRangeStart = 753579, XrefRangeEnd = 753586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateChartItem()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateChartItem_Internal_Static_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 753602, RefRangeEnd = 753628, XrefRangeStart = 753593, XrefRangeEnd = 753602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideObject(GameObject obj, bool hideMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideObject_Internal_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753633, RefRangeEnd = 753634, XrefRangeStart = 753628, XrefRangeEnd = 753633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAutoLength(AnyChart parent, ChartOrientation orientation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(ChartOrientation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &orientation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAutoLength_Internal_Static_Single_AnyChart_ChartOrientation_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753637, RefRangeEnd = 753639, XrefRangeStart = 753634, XrefRangeEnd = 753637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAutoDepth(AnyChart parent, ChartOrientation orientation, ChartDivisionInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(ChartOrientation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &orientation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAutoDepth_Internal_Static_Single_AnyChart_ChartOrientation_ChartDivisionInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 753642, RefRangeEnd = 753645, XrefRangeStart = 753639, XrefRangeEnd = 753642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAutoLength(AnyChart parent, ChartOrientation orientation, ChartDivisionInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(ChartOrientation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &orientation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAutoLength_Internal_Static_Single_AnyChart_ChartOrientation_ChartDivisionInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector2 Perpendicular(Vector2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Perpendicular_Internal_Static_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753653, RefRangeEnd = 753654, XrefRangeStart = 753645, XrefRangeEnd = 753653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SegmentIntersection(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2, out Vector2 intersection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&a1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a2;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b1;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &b2;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref intersection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SegmentIntersection_Internal_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753656, RefRangeEnd = 753657, XrefRangeStart = 753654, XrefRangeEnd = 753656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 FromPolarRadians(float angleDeg, float radius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&angleDeg);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromPolarRadians_Internal_Static_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 753659, RefRangeEnd = 753665, XrefRangeStart = 753657, XrefRangeEnd = 753659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 FromPolar(float angleDeg, float radius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&angleDeg);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromPolar_Internal_Static_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 753672, RefRangeEnd = 753676, XrefRangeStart = 753665, XrefRangeEnd = 753672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect FixRect(Rect r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixRect_Internal_Static_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753740, RefRangeEnd = 753741, XrefRangeStart = 753700, XrefRangeEnd = 753740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SafeAssignMaterial(Renderer renderer, Material material, Material defualt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defualt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SafeAssignMaterial_Internal_Static_Boolean_Renderer_Material_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 753752, RefRangeEnd = 753763, XrefRangeStart = 753741, XrefRangeEnd = 753752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanMesh(Mesh newMesh, ref Mesh cleanMesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMesh);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cleanMesh);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanMesh_Internal_Static_Void_Mesh_byref_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		cleanMesh = ((intPtr4 == (System.IntPtr)0) ? null : new Mesh(intPtr4));
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 753783, RefRangeEnd = 753807, XrefRangeStart = 753771, XrefRangeEnd = 753783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SafeDestroy(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SafeDestroy_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 753813, RefRangeEnd = 753825, XrefRangeStart = 753807, XrefRangeEnd = 753813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIVertex CreateVertex(Vector3 pos, Vector2 uv)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uv;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVertex_Internal_Static_UIVertex_Vector3_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(UIVertex*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 753828, RefRangeEnd = 753836, XrefRangeStart = 753825, XrefRangeEnd = 753828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIVertex CreateVertex(Vector3 pos, Vector2 uv, float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uv;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVertex_Internal_Static_UIVertex_Vector3_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(UIVertex*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753836, RefRangeEnd = 753838, XrefRangeStart = 753836, XrefRangeEnd = 753836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetTiling(MaterialTiling tiling)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tiling);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTiling_Internal_Static_Single_MaterialTiling_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753842, RefRangeEnd = 753843, XrefRangeStart = 753838, XrefRangeEnd = 753842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FixBillboardText(ItemLabelsBase labels, BillboardText text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)labels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixBillboardText_Internal_Static_Void_ItemLabelsBase_BillboardText_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 753847, RefRangeEnd = 753858, XrefRangeStart = 753843, XrefRangeEnd = 753847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T EnsureComponent<T>(GameObject obj) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnsureComponent_Internal_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	public unsafe static float DotProduct(Vector2 a, Vector2 b, Vector2 c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DotProduct_Private_Static_Single_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float CrossProduct(Vector2 a, Vector2 b, Vector2 c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CrossProduct_Private_Static_Single_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753866, RefRangeEnd = 753867, XrefRangeStart = 753858, XrefRangeEnd = 753866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SegmentPointSqrDistance(Vector2 a, Vector2 b, Vector2 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SegmentPointSqrDistance_Internal_Static_Single_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753867, XrefRangeEnd = 753889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BillboardText UpdateBillboardText(BillboardText billboardText, Transform parentTransform, string text, float x, float y, float z, float angle, Transform relativeFrom, bool hideHirarechy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)billboardText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeFrom);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideHirarechy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBillboardText_Internal_Static_BillboardText_BillboardText_Transform_String_Single_Single_Single_Single_Transform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BillboardText>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 753971, RefRangeEnd = 753983, XrefRangeStart = 753889, XrefRangeEnd = 753971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BillboardText CreateBillboardText(BillboardText item, Text prefab, Transform parentTransform, string text, float x, float y, float z, float angle, Transform relativeFrom, bool hideHirarechy, int fontSize, float sharpness)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeFrom);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideHirarechy;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontSize;
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharpness;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBillboardText_Internal_Static_BillboardText_BillboardText_Text_Transform_String_Single_Single_Single_Single_Transform_Boolean_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BillboardText>(intPtr) : null;
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartCommon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartCommon>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartCommon(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
