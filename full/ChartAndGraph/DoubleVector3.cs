using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ChartAndGraph;

[StructLayout(LayoutKind.Explicit)]
public struct DoubleVector3
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToVector2_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToVector3_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDoubleVector4_Public_DoubleVector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDoubleVector2_Public_DoubleVector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normalized_Public_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_forward_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_back_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fwd_Public_Static_get_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Void_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cross_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reflect_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Double_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Double_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_DoubleVector3_DoubleVector3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Double_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Double_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_DoubleVector3_DoubleVector3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_DoubleVector3_Double_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_DoubleVector3_DoubleVector3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DoubleVector3_DoubleVector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

	[FieldOffset(0)]
	public double x;

	[FieldOffset(8)]
	public double y;

	[FieldOffset(16)]
	public double z;

	public unsafe double this[int index]
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&index);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe DoubleVector3 normalized
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754633, XrefRangeEnd = 754635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalized_Public_get_DoubleVector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe double magnitude
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754640, RefRangeEnd = 754641, XrefRangeStart = 754635, XrefRangeEnd = 754640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magnitude_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe double sqrMagnitude
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 zero
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zero_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 one
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_one_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 forward
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_forward_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 back
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_back_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 up
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_up_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 down
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_down_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 left
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_left_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 right
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_right_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static DoubleVector3 fwd
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fwd_Public_Static_get_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static DoubleVector3()
	{
		Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "DoubleVector3");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, "y");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, "z");
		NativeMethodInfoPtr_get_Item_Public_get_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669897);
		NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669898);
		NativeMethodInfoPtr_ToVector2_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669899);
		NativeMethodInfoPtr_ToVector3_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669900);
		NativeMethodInfoPtr_ToDoubleVector4_Public_DoubleVector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669901);
		NativeMethodInfoPtr_ToDoubleVector2_Public_DoubleVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669902);
		NativeMethodInfoPtr_get_normalized_Public_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669903);
		NativeMethodInfoPtr_get_magnitude_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669904);
		NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669905);
		NativeMethodInfoPtr_get_zero_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669906);
		NativeMethodInfoPtr_get_one_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669907);
		NativeMethodInfoPtr_get_forward_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669908);
		NativeMethodInfoPtr_get_back_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669909);
		NativeMethodInfoPtr_get_up_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669910);
		NativeMethodInfoPtr_get_down_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669911);
		NativeMethodInfoPtr_get_left_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669912);
		NativeMethodInfoPtr_get_right_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669913);
		NativeMethodInfoPtr_get_fwd_Public_Static_get_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669914);
		NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669915);
		NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669916);
		NativeMethodInfoPtr_Lerp_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669917);
		NativeMethodInfoPtr_LerpUnclamped_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669918);
		NativeMethodInfoPtr_MoveTowards_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669919);
		NativeMethodInfoPtr_Set_Public_Void_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669920);
		NativeMethodInfoPtr_Scale_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669921);
		NativeMethodInfoPtr_Scale_Public_Void_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669922);
		NativeMethodInfoPtr_Cross_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669923);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669924);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669925);
		NativeMethodInfoPtr_Reflect_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669926);
		NativeMethodInfoPtr_Normalize_Public_Static_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669927);
		NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669928);
		NativeMethodInfoPtr_Dot_Public_Static_Double_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669929);
		NativeMethodInfoPtr_Distance_Public_Static_Double_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669930);
		NativeMethodInfoPtr_ClampMagnitude_Public_Static_DoubleVector3_DoubleVector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669931);
		NativeMethodInfoPtr_Magnitude_Public_Static_Double_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669932);
		NativeMethodInfoPtr_SqrMagnitude_Public_Static_Double_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669933);
		NativeMethodInfoPtr_Min_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669934);
		NativeMethodInfoPtr_Max_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669935);
		NativeMethodInfoPtr_op_Addition_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669936);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669937);
		NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669938);
		NativeMethodInfoPtr_op_Multiply_Public_Static_DoubleVector3_DoubleVector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669939);
		NativeMethodInfoPtr_op_Multiply_Public_Static_DoubleVector3_Double_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669940);
		NativeMethodInfoPtr_op_Division_Public_Static_DoubleVector3_DoubleVector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669941);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669942);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DoubleVector3_DoubleVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669943);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669944);
		NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, 100669945);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754612, RefRangeEnd = 754613, XrefRangeStart = 754612, XrefRangeEnd = 754612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 ToVector2()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToVector2_Public_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 754613, RefRangeEnd = 754619, XrefRangeStart = 754613, XrefRangeEnd = 754613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ToVector3()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToVector3_Public_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 754623, RefRangeEnd = 754628, XrefRangeStart = 754619, XrefRangeEnd = 754623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleVector4 ToDoubleVector4()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDoubleVector4_Public_DoubleVector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleVector4>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 754628, RefRangeEnd = 754633, XrefRangeStart = 754628, XrefRangeEnd = 754628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleVector2 ToDoubleVector2()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDoubleVector2_Public_DoubleVector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 754641, RefRangeEnd = 754655, XrefRangeStart = 754641, XrefRangeEnd = 754641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleVector3(double x, double y, double z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 754655, RefRangeEnd = 754672, XrefRangeStart = 754655, XrefRangeEnd = 754655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleVector3(double x, double y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 754677, RefRangeEnd = 754680, XrefRangeStart = 754672, XrefRangeEnd = 754677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 Lerp(DoubleVector3 a, DoubleVector3 b, double t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lerp_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 LerpUnclamped(DoubleVector3 a, DoubleVector3 b, double t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LerpUnclamped_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754680, XrefRangeEnd = 754686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 MoveTowards(DoubleVector3 current, DoubleVector3 target, double maxDistanceDelta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&current);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistanceDelta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTowards_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 754641, RefRangeEnd = 754655, XrefRangeStart = 754641, XrefRangeEnd = 754655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(double new_x, double new_y, double new_z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&new_x);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &new_y;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &new_z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Double_Double_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 Scale(DoubleVector3 a, DoubleVector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Scale_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Scale(DoubleVector3 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scale);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Scale_Public_Void_DoubleVector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 Cross(DoubleVector3 lhs, DoubleVector3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cross_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754686, XrefRangeEnd = 754689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754689, XrefRangeEnd = 754695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 Reflect(DoubleVector3 inDirection, DoubleVector3 inNormal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inDirection);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inNormal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reflect_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754695, XrefRangeEnd = 754696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 Normalize(DoubleVector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalize_Public_Static_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754696, XrefRangeEnd = 754698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Normalize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalize_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static double Dot(DoubleVector3 lhs, DoubleVector3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Static_Double_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754698, XrefRangeEnd = 754703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Distance(DoubleVector3 a, DoubleVector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance_Public_Static_Double_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 ClampMagnitude(DoubleVector3 vector, double maxLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vector);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampMagnitude_Public_Static_DoubleVector3_DoubleVector3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 754708, RefRangeEnd = 754711, XrefRangeStart = 754703, XrefRangeEnd = 754708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Magnitude(DoubleVector3 a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Magnitude_Public_Static_Double_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static double SqrMagnitude(DoubleVector3 a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SqrMagnitude_Public_Static_Double_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754711, XrefRangeEnd = 754717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 Min(DoubleVector3 lhs, DoubleVector3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754717, XrefRangeEnd = 754723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 Max(DoubleVector3 lhs, DoubleVector3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 754723, RefRangeEnd = 754733, XrefRangeStart = 754723, XrefRangeEnd = 754723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 operator +(DoubleVector3 a, DoubleVector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 754733, RefRangeEnd = 754739, XrefRangeStart = 754733, XrefRangeEnd = 754733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 operator -(DoubleVector3 a, DoubleVector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_DoubleVector3_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 operator -(DoubleVector3 a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 754739, RefRangeEnd = 754743, XrefRangeStart = 754739, XrefRangeEnd = 754739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 operator *(DoubleVector3 a, double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_DoubleVector3_DoubleVector3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 754743, RefRangeEnd = 754749, XrefRangeStart = 754743, XrefRangeEnd = 754743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleVector3 operator *(double d, DoubleVector3 a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_DoubleVector3_Double_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DoubleVector3 operator /(DoubleVector3 a, double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Division_Public_Static_DoubleVector3_DoubleVector3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoubleVector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(DoubleVector3 lhs, DoubleVector3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(DoubleVector3 lhs, DoubleVector3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DoubleVector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DoubleVector3_DoubleVector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754749, XrefRangeEnd = 754765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754765, XrefRangeEnd = 754790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToString(string format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_String_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DoubleVector3>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
