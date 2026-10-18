using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public class Funnel : Il2CppSystem.Object
{
	public sealed class FunnelPortals : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_left;

		private static readonly System.IntPtr NativeFieldInfoPtr_right;

		public unsafe List<Vector3> left
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Vector3> right
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static FunnelPortals()
		{
			Il2CppClassPointerStore<FunnelPortals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Funnel>.NativeClassPtr, "FunnelPortals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunnelPortals>.NativeClassPtr);
			NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelPortals>.NativeClassPtr, "left");
			NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelPortals>.NativeClassPtr, "right");
		}

		public FunnelPortals(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FunnelPortals()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunnelPortals>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PathPart
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_startIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_endIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_startPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_endPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_isLink;

		[FieldOffset(0)]
		public int startIndex;

		[FieldOffset(4)]
		public int endIndex;

		[FieldOffset(8)]
		public Vector3 startPoint;

		[FieldOffset(20)]
		public Vector3 endPoint;

		[FieldOffset(32)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isLink;

		static PathPart()
		{
			Il2CppClassPointerStore<PathPart>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Funnel>.NativeClassPtr, "PathPart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPart>.NativeClassPtr);
			NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPart>.NativeClassPtr, "startIndex");
			NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPart>.NativeClassPtr, "endIndex");
			NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPart>.NativeClassPtr, "startPoint");
			NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPart>.NativeClassPtr, "endPoint");
			NativeFieldInfoPtr_isLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPart>.NativeClassPtr, "isLink");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathPart>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitIntoParts_Public_Static_List_1_PathPart_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructFunnelPortals_Public_Static_FunnelPortals_List_1_GraphNode_PathPart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShrinkPortals_Public_Static_Void_FunnelPortals_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnwrapHelper_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_byref_Quaternion_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unwrap_Public_Static_Void_FunnelPortals_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixFunnel_Private_Static_Int32_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToXZ_Protected_Static_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXZ_Protected_Static_Vector3_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RightOrColinear_Protected_Static_Boolean_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeftOrColinear_Protected_Static_Boolean_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Calculate_Public_Static_List_1_Vector3_FunnelPortals_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Calculate_Private_Static_Void_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Int32_Int32_List_1_Int32_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Funnel()
	{
		Il2CppClassPointerStore<Funnel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "Funnel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Funnel>.NativeClassPtr);
		NativeMethodInfoPtr_SplitIntoParts_Public_Static_List_1_PathPart_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683813);
		NativeMethodInfoPtr_ConstructFunnelPortals_Public_Static_FunnelPortals_List_1_GraphNode_PathPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683814);
		NativeMethodInfoPtr_ShrinkPortals_Public_Static_Void_FunnelPortals_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683815);
		NativeMethodInfoPtr_UnwrapHelper_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683816);
		NativeMethodInfoPtr_Unwrap_Public_Static_Void_FunnelPortals_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683817);
		NativeMethodInfoPtr_FixFunnel_Private_Static_Int32_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683818);
		NativeMethodInfoPtr_ToXZ_Protected_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683819);
		NativeMethodInfoPtr_FromXZ_Protected_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683820);
		NativeMethodInfoPtr_RightOrColinear_Protected_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683821);
		NativeMethodInfoPtr_LeftOrColinear_Protected_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683822);
		NativeMethodInfoPtr_Calculate_Public_Static_List_1_Vector3_FunnelPortals_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683823);
		NativeMethodInfoPtr_Calculate_Private_Static_Void_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Int32_Int32_List_1_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683824);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Funnel>.NativeClassPtr, 100683825);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077096, RefRangeEnd = 1077097, XrefRangeStart = 1077031, XrefRangeEnd = 1077096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PathPart> SplitIntoParts(Path path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitIntoParts_Public_Static_List_1_PathPart_Path_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PathPart>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077139, RefRangeEnd = 1077140, XrefRangeStart = 1077097, XrefRangeEnd = 1077139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FunnelPortals ConstructFunnelPortals(List<GraphNode> nodes, PathPart part)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodes);
		*(PathPart**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &part;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructFunnelPortals_Public_Static_FunnelPortals_List_1_GraphNode_PathPart_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FunnelPortals(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077140, XrefRangeEnd = 1077155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShrinkPortals(FunnelPortals portals, float shrink)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)portals));
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shrink;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShrinkPortals_Public_Static_Void_FunnelPortals_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1077162, RefRangeEnd = 1077164, XrefRangeStart = 1077155, XrefRangeEnd = 1077162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UnwrapHelper(Vector3 portalStart, Vector3 portalEnd, Vector3 prevPoint, Vector3 nextPoint, ref Quaternion mRot, ref Vector3 mOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&portalStart);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &portalEnd;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prevPoint;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextPoint;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mRot);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mOffset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnwrapHelper_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_byref_Quaternion_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077198, RefRangeEnd = 1077199, XrefRangeStart = 1077164, XrefRangeEnd = 1077198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unwrap(FunnelPortals funnel, Il2CppStructArray<Vector2> left, Il2CppStructArray<Vector2> right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)funnel));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unwrap_Public_Static_Void_FunnelPortals_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077199, RefRangeEnd = 1077200, XrefRangeStart = 1077199, XrefRangeEnd = 1077199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FixFunnel(Il2CppStructArray<Vector2> left, Il2CppStructArray<Vector2> right, int numPortals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numPortals;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixFunnel_Private_Static_Int32_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector2 ToXZ(Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToXZ_Protected_Static_Vector2_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector3 FromXZ(Vector2 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXZ_Protected_Static_Vector3_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool RightOrColinear(Vector2 a, Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RightOrColinear_Protected_Static_Boolean_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool LeftOrColinear(Vector2 a, Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeftOrColinear_Protected_Static_Boolean_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077268, RefRangeEnd = 1077269, XrefRangeStart = 1077200, XrefRangeEnd = 1077268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3> Calculate(FunnelPortals funnel, bool unwrap, bool splitAtEveryPortal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)funnel));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unwrap;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitAtEveryPortal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Calculate_Public_Static_List_1_Vector3_FunnelPortals_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1077288, RefRangeEnd = 1077289, XrefRangeStart = 1077269, XrefRangeEnd = 1077288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Calculate(Il2CppStructArray<Vector2> left, Il2CppStructArray<Vector2> right, int numPortals, int startIndex, List<int> funnelPath, int maxCorners, out bool lastCorner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numPortals;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)funnelPath);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCorners;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lastCorner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Calculate_Private_Static_Void_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_Int32_Int32_List_1_Int32_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Funnel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Funnel>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Funnel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
