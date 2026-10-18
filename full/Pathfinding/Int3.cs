using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding;

[StructLayout(LayoutKind.Explicit)]
public struct Int3
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_Precision;

	private static readonly System.IntPtr NativeFieldInfoPtr_FloatPrecision;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrecisionFactor;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Vector3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Int3_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Int3_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Int3_Int3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Int32_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DotLong_Public_Static_Int64_Int3_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normal2D_Public_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_costMagnitude_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitudeLong_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public int x;

	[FieldOffset(4)]
	public int y;

	[FieldOffset(8)]
	public int z;

	public unsafe static int Precision
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Precision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Precision, (void*)(&num));
		}
	}

	public unsafe static float FloatPrecision
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FloatPrecision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FloatPrecision, (void*)(&num));
		}
	}

	public unsafe static float PrecisionFactor
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrecisionFactor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrecisionFactor, (void*)(&num));
		}
	}

	public unsafe static Int3 zero
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 495176, RefRangeEnd = 495178, XrefRangeStart = 495176, XrefRangeEnd = 495178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zero_Public_Static_get_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int this[int i]
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1064435, RefRangeEnd = 1064465, XrefRangeStart = 1064435, XrefRangeEnd = 1064435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&i);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1064465, RefRangeEnd = 1064468, XrefRangeStart = 1064465, XrefRangeEnd = 1064465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float magnitude
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1064487, RefRangeEnd = 1064490, XrefRangeStart = 1064482, XrefRangeEnd = 1064487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int costMagnitude
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1064495, RefRangeEnd = 1064515, XrefRangeStart = 1064490, XrefRangeEnd = 1064495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_costMagnitude_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float sqrMagnitude
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064515, RefRangeEnd = 1064517, XrefRangeStart = 1064515, XrefRangeEnd = 1064515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe long sqrMagnitudeLong
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1064517, RefRangeEnd = 1064523, XrefRangeStart = 1064517, XrefRangeEnd = 1064517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sqrMagnitudeLong_Public_get_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Int3()
	{
		Il2CppClassPointerStore<Int3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "Int3");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int3>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int3>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int3>.NativeClassPtr, "y");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int3>.NativeClassPtr, "z");
		NativeFieldInfoPtr_Precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int3>.NativeClassPtr, "Precision");
		NativeFieldInfoPtr_FloatPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int3>.NativeClassPtr, "FloatPrecision");
		NativeFieldInfoPtr_PrecisionFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int3>.NativeClassPtr, "PrecisionFactor");
		NativeMethodInfoPtr_get_zero_Public_Static_get_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682584);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682585);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682586);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682587);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682588);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Int3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682589);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Vector3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682590);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_Int3_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682591);
		NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682592);
		NativeMethodInfoPtr_op_Addition_Public_Static_Int3_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682593);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682594);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682595);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682596);
		NativeMethodInfoPtr_op_Division_Public_Static_Int3_Int3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682597);
		NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682598);
		NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682599);
		NativeMethodInfoPtr_Angle_Public_Static_Single_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682600);
		NativeMethodInfoPtr_Dot_Public_Static_Int32_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682601);
		NativeMethodInfoPtr_DotLong_Public_Static_Int64_Int3_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682602);
		NativeMethodInfoPtr_Normal2D_Public_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682603);
		NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682604);
		NativeMethodInfoPtr_get_costMagnitude_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682605);
		NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682606);
		NativeMethodInfoPtr_get_sqrMagnitudeLong_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682607);
		NativeMethodInfoPtr_op_Implicit_Public_Static_String_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682608);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682609);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682610);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682611);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int3>.NativeClassPtr, 100682612);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064108, XrefRangeEnd = 1064114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3(Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 183696, RefRangeEnd = 183715, XrefRangeStart = 183696, XrefRangeEnd = 183715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3(int _x, int _y, int _z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 404446, RefRangeEnd = 404456, XrefRangeStart = 404446, XrefRangeEnd = 404456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1064120, RefRangeEnd = 1064185, XrefRangeStart = 1064114, XrefRangeEnd = 1064120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator Int3(Vector3 ob)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Int3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(165)]
	[CachedScanResults(RefRangeStart = 1064185, RefRangeEnd = 1064350, XrefRangeStart = 1064185, XrefRangeEnd = 1064185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator Vector3(Int3 ob)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Vector3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 1064350, RefRangeEnd = 1064394, XrefRangeStart = 1064350, XrefRangeEnd = 1064350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator -(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_Int3_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1064394, RefRangeEnd = 1064395, XrefRangeStart = 1064394, XrefRangeEnd = 1064394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator -(Int3 lhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lhs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1064395, RefRangeEnd = 1064410, XrefRangeStart = 1064395, XrefRangeEnd = 1064395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator +(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Int3_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1064410, RefRangeEnd = 1064412, XrefRangeStart = 1064410, XrefRangeEnd = 1064410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator *(Int3 lhs, int rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1064418, RefRangeEnd = 1064419, XrefRangeStart = 1064412, XrefRangeEnd = 1064418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator *(Int3 lhs, float rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1064425, RefRangeEnd = 1064426, XrefRangeStart = 1064419, XrefRangeEnd = 1064425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator *(Int3 lhs, double rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Int3_Int3_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1064432, RefRangeEnd = 1064435, XrefRangeStart = 1064426, XrefRangeEnd = 1064432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int3 operator /(Int3 lhs, float rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Division_Public_Static_Int3_Int3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1064474, RefRangeEnd = 1064477, XrefRangeStart = 1064468, XrefRangeEnd = 1064474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Angle(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Angle_Public_Static_Single_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int Dot(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Static_Int32_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1064477, RefRangeEnd = 1064480, XrefRangeStart = 1064477, XrefRangeEnd = 1064477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long DotLong(Int3 lhs, Int3 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Int3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DotLong_Public_Static_Int64_Int3_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1064480, RefRangeEnd = 1064482, XrefRangeStart = 1064480, XrefRangeEnd = 1064480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3 Normal2D()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normal2D_Public_Int3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1064524, RefRangeEnd = 1064528, XrefRangeStart = 1064523, XrefRangeEnd = 1064524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator string(Int3 obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_String_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1064582, RefRangeEnd = 1064583, XrefRangeStart = 1064528, XrefRangeEnd = 1064582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064583, XrefRangeEnd = 1064586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(Int3 other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1064586, RefRangeEnd = 1064593, XrefRangeStart = 1064586, XrefRangeEnd = 1064586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Int3>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
