using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Pathfinding;

[StructLayout(LayoutKind.Explicit)]
public struct Int2
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitudeLong_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Int2_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Int2_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DotLong_Public_Static_Int64_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Int2_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Int2_Int2_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInt3XZ_Public_Static_Int2_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt3XZ_Public_Static_Int3_Int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public int x;

	[FieldOffset(4)]
	public int y;

	public unsafe long sqrMagnitudeLong
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1064593, RefRangeEnd = 1064594, XrefRangeStart = 1064593, XrefRangeEnd = 1064593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sqrMagnitudeLong_Public_get_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Int2()
	{
		Il2CppClassPointerStore<Int2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "Int2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int2>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int2>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int2>.NativeClassPtr, "y");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682613);
		NativeMethodInfoPtr_get_sqrMagnitudeLong_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682614);
		NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682615);
		NativeMethodInfoPtr_op_Addition_Public_Static_Int2_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682616);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_Int2_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682617);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682618);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682619);
		NativeMethodInfoPtr_DotLong_Public_Static_Int64_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682620);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682621);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682622);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682623);
		NativeMethodInfoPtr_Min_Public_Static_Int2_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682624);
		NativeMethodInfoPtr_Max_Public_Static_Int2_Int2_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682625);
		NativeMethodInfoPtr_FromInt3XZ_Public_Static_Int2_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682626);
		NativeMethodInfoPtr_ToInt3XZ_Public_Static_Int3_Int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682627);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2>.NativeClassPtr, 100682628);
	}

	[CallerCount(98)]
	[CachedScanResults(RefRangeStart = 42244, RefRangeEnd = 42342, XrefRangeStart = 42244, XrefRangeEnd = 42342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int2(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Int2 operator -(Int2 lhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lhs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1064594, RefRangeEnd = 1064597, XrefRangeStart = 1064594, XrefRangeEnd = 1064594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int2 operator +(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Int2_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1064597, RefRangeEnd = 1064602, XrefRangeStart = 1064597, XrefRangeEnd = 1064597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int2 operator -(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_Int2_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1064602, RefRangeEnd = 1064603, XrefRangeStart = 1064602, XrefRangeEnd = 1064602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1064603, RefRangeEnd = 1064604, XrefRangeStart = 1064603, XrefRangeEnd = 1064603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long DotLong(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DotLong_Public_Static_Int64_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064604, XrefRangeEnd = 1064607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(Int2 other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064607, XrefRangeEnd = 1064612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int2 Min(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Int2_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064612, XrefRangeEnd = 1064617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Int2 Max(Int2 a, Int2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Int2_Int2_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Int2 FromInt3XZ(Int3 o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInt3XZ_Public_Static_Int2_Int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Int3 ToInt3XZ(Int2 o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt3XZ_Public_Static_Int3_Int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064617, XrefRangeEnd = 1064658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Int2>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
