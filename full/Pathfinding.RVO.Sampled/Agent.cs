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

namespace Pathfinding.RVO.Sampled;

public class Agent : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct VO
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_line1;

		private static readonly System.IntPtr NativeFieldInfoPtr_line2;

		private static readonly System.IntPtr NativeFieldInfoPtr_dir1;

		private static readonly System.IntPtr NativeFieldInfoPtr_dir2;

		private static readonly System.IntPtr NativeFieldInfoPtr_cutoffLine;

		private static readonly System.IntPtr NativeFieldInfoPtr_cutoffDir;

		private static readonly System.IntPtr NativeFieldInfoPtr_circleCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_colliding;

		private static readonly System.IntPtr NativeFieldInfoPtr_radius;

		private static readonly System.IntPtr NativeFieldInfoPtr_weightFactor;

		private static readonly System.IntPtr NativeFieldInfoPtr_weightBonus;

		private static readonly System.IntPtr NativeFieldInfoPtr_segmentStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_segmentEnd;

		private static readonly System.IntPtr NativeFieldInfoPtr_segment;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Single_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SegmentObstacle_Public_Static_VO_Vector2_Vector2_Vector2_Single_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SignedDistanceFromLine_Public_Static_Single_Vector2_Vector2_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ScaledGradient_Public_Vector2_Vector2_byref_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Gradient_Public_Vector2_Vector2_byref_Single_0;

		[FieldOffset(0)]
		public Vector2 line1;

		[FieldOffset(8)]
		public Vector2 line2;

		[FieldOffset(16)]
		public Vector2 dir1;

		[FieldOffset(24)]
		public Vector2 dir2;

		[FieldOffset(32)]
		public Vector2 cutoffLine;

		[FieldOffset(40)]
		public Vector2 cutoffDir;

		[FieldOffset(48)]
		public Vector2 circleCenter;

		[FieldOffset(56)]
		[MarshalAs(UnmanagedType.U1)]
		public bool colliding;

		[FieldOffset(60)]
		public float radius;

		[FieldOffset(64)]
		public float weightFactor;

		[FieldOffset(68)]
		public float weightBonus;

		[FieldOffset(72)]
		public Vector2 segmentStart;

		[FieldOffset(80)]
		public Vector2 segmentEnd;

		[FieldOffset(88)]
		[MarshalAs(UnmanagedType.U1)]
		public bool segment;

		static VO()
		{
			Il2CppClassPointerStore<VO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Agent>.NativeClassPtr, "VO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VO>.NativeClassPtr);
			NativeFieldInfoPtr_line1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "line1");
			NativeFieldInfoPtr_line2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "line2");
			NativeFieldInfoPtr_dir1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "dir1");
			NativeFieldInfoPtr_dir2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "dir2");
			NativeFieldInfoPtr_cutoffLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "cutoffLine");
			NativeFieldInfoPtr_cutoffDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "cutoffDir");
			NativeFieldInfoPtr_circleCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "circleCenter");
			NativeFieldInfoPtr_colliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "colliding");
			NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "radius");
			NativeFieldInfoPtr_weightFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "weightFactor");
			NativeFieldInfoPtr_weightBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "weightBonus");
			NativeFieldInfoPtr_segmentStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "segmentStart");
			NativeFieldInfoPtr_segmentEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "segmentEnd");
			NativeFieldInfoPtr_segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VO>.NativeClassPtr, "segment");
			NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VO>.NativeClassPtr, 100689594);
			NativeMethodInfoPtr_SegmentObstacle_Public_Static_VO_Vector2_Vector2_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VO>.NativeClassPtr, 100689595);
			NativeMethodInfoPtr_SignedDistanceFromLine_Public_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VO>.NativeClassPtr, 100689596);
			NativeMethodInfoPtr_ScaledGradient_Public_Vector2_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VO>.NativeClassPtr, 100689597);
			NativeMethodInfoPtr_Gradient_Public_Vector2_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VO>.NativeClassPtr, 100689598);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1082561, RefRangeEnd = 1082562, XrefRangeStart = 1082537, XrefRangeEnd = 1082561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VO(Vector2 center, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&center);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inverseDt;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inverseDeltaTime;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_Single_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1082587, RefRangeEnd = 1082588, XrefRangeStart = 1082562, XrefRangeEnd = 1082587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VO SegmentObstacle(Vector2 segmentStart, Vector2 segmentEnd, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&segmentStart);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &segmentEnd;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inverseDt;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &inverseDeltaTime;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SegmentObstacle_Public_Static_VO_Vector2_Vector2_Vector2_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(VO*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1082588, RefRangeEnd = 1082589, XrefRangeStart = 1082588, XrefRangeEnd = 1082588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedDistanceFromLine(Vector2 a, Vector2 dir, Vector2 p)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&a);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SignedDistanceFromLine_Public_Static_Single_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1082590, RefRangeEnd = 1082591, XrefRangeStart = 1082589, XrefRangeEnd = 1082590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ScaledGradient(Vector2 p, out float weight)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&p);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref weight);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaledGradient_Public_Vector2_Vector2_byref_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1082596, RefRangeEnd = 1082598, XrefRangeStart = 1082591, XrefRangeEnd = 1082596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Gradient(Vector2 p, out float weight)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&p);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref weight);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Gradient_Public_Vector2_Vector2_byref_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VO>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class VOBuffer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_buffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_length;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_VO_0;

		public unsafe Il2CppStructArray<VO> buffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<VO>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int length
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length)) = num;
			}
		}

		static VOBuffer()
		{
			Il2CppClassPointerStore<VOBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Agent>.NativeClassPtr, "VOBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr, "buffer");
			NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr, "length");
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr, 100689599);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr, 100689600);
			NativeMethodInfoPtr_Add_Public_Void_VO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr, 100689601);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 359324, RefRangeEnd = 359329, XrefRangeStart = 359324, XrefRangeEnd = 359329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1082602, RefRangeEnd = 1082604, XrefRangeStart = 1082598, XrefRangeEnd = 1082602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VOBuffer(int n)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VOBuffer>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&n);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1082608, RefRangeEnd = 1082610, XrefRangeStart = 1082604, XrefRangeEnd = 1082608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(VO vo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&vo);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_VO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public VOBuffer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_agentTimeHorizon;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacleTimeHorizon;

	private static readonly System.IntPtr NativeFieldInfoPtr_locked;

	private static readonly System.IntPtr NativeFieldInfoPtr_layer;

	private static readonly System.IntPtr NativeFieldInfoPtr_collidesWith;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxNeighbours;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_elevationCoordinate;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredTargetPointInVelocitySpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextTargetPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextDesiredSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextMaxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_collisionNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_manuallyControlled;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugDraw;

	private static readonly System.IntPtr NativeFieldInfoPtr__Position_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ElevationCoordinate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CalculatedTargetPoint_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CalculatedSpeed_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Locked_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Radius_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Height_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AgentTimeHorizon_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ObstacleTimeHorizon_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MaxNeighbours_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NeighbourCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Layer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CollidesWith_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Priority_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PreCalculationCallback_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_next;

	private static readonly System.IntPtr NativeFieldInfoPtr_calculatedSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_calculatedTargetPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_simulator;

	private static readonly System.IntPtr NativeFieldInfoPtr_neighbours;

	private static readonly System.IntPtr NativeFieldInfoPtr_neighbourDists;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstaclesBuffered;

	private static readonly System.IntPtr NativeFieldInfoPtr_obstacles;

	private static readonly System.IntPtr NativeFieldInfoPtr_DesiredVelocityWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_WallWeight;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ElevationCoordinate_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ElevationCoordinate_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CalculatedTargetPoint_Public_Virtual_Final_New_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CalculatedTargetPoint_Private_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CalculatedSpeed_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CalculatedSpeed_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Locked_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Locked_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Radius_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Radius_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Height_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AgentTimeHorizon_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AgentTimeHorizon_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ObstacleTimeHorizon_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ObstacleTimeHorizon_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxNeighbours_Public_Virtual_Final_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxNeighbours_Public_Virtual_Final_New_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NeighbourCount_Public_Virtual_Final_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NeighbourCount_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Layer_Public_Virtual_Final_New_get_RVOLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Layer_Public_Virtual_Final_New_set_Void_RVOLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CollidesWith_Public_Virtual_Final_New_get_RVOLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CollidesWith_Public_Virtual_Final_New_set_Void_RVOLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugDraw_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DebugDraw_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Priority_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PreCalculationCallback_Private_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PreCalculationCallback_Public_Virtual_Final_New_set_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Virtual_Final_New_Void_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCollisionNormal_Public_Virtual_Final_New_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSetVelocity_Public_Virtual_Final_New_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NeighbourObstacles_Public_Virtual_Final_New_get_List_1_ObstacleVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BufferSwitch_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreCalculation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostCalculation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNeighbours_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sqr_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertAgentNeighbour_Internal_Single_Agent_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXZ_Private_Static_Vector3_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToXZ_Private_Static_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To2D_Private_Vector2_Vector3_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawVO_Private_Static_Void_Vector2_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateVelocity_Internal_Void_WorkerContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rainbow_Private_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateObstacleVOs_Private_Void_VOBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNeighbourAgentVOs_Private_Void_VOBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GradientDescent_Private_Vector2_VOBuffer_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasDesiredVelocity_Private_Static_Boolean_VOBuffer_byref_Vector2_byref_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateGradient_Private_Vector2_VOBuffer_Vector2_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trace_Private_Vector2_VOBuffer_Vector2_byref_Single_0;

	public unsafe float radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
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

	public unsafe float desiredSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSpeed)) = num;
		}
	}

	public unsafe float maxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
		}
	}

	public unsafe float agentTimeHorizon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agentTimeHorizon);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agentTimeHorizon)) = num;
		}
	}

	public unsafe float obstacleTimeHorizon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleTimeHorizon);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacleTimeHorizon)) = num;
		}
	}

	public unsafe bool locked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locked)) = flag;
		}
	}

	public unsafe RVOLayer layer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer);
			return *(RVOLayer*)num;
		}
		set
		{
			*(RVOLayer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer)) = rVOLayer;
		}
	}

	public unsafe RVOLayer collidesWith
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collidesWith);
			return *(RVOLayer*)num;
		}
		set
		{
			*(RVOLayer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collidesWith)) = rVOLayer;
		}
	}

	public unsafe int maxNeighbours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNeighbours);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNeighbours)) = num;
		}
	}

	public unsafe Vector2 position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = vector;
		}
	}

	public unsafe float elevationCoordinate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevationCoordinate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevationCoordinate)) = num;
		}
	}

	public unsafe Vector2 currentVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVelocity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVelocity)) = vector;
		}
	}

	public unsafe Vector2 desiredTargetPointInVelocitySpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredTargetPointInVelocitySpace);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredTargetPointInVelocitySpace)) = vector;
		}
	}

	public unsafe Vector2 desiredVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredVelocity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredVelocity)) = vector;
		}
	}

	public unsafe Vector2 nextTargetPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextTargetPoint);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextTargetPoint)) = vector;
		}
	}

	public unsafe float nextDesiredSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextDesiredSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextDesiredSpeed)) = num;
		}
	}

	public unsafe float nextMaxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMaxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMaxSpeed)) = num;
		}
	}

	public unsafe Vector2 collisionNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionNormal);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionNormal)) = vector;
		}
	}

	public unsafe bool manuallyControlled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manuallyControlled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manuallyControlled)) = flag;
		}
	}

	public unsafe bool debugDraw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDraw);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDraw)) = flag;
		}
	}

	public unsafe Vector2 _Position_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Position_k__BackingField);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Position_k__BackingField)) = vector;
		}
	}

	public unsafe float _ElevationCoordinate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElevationCoordinate_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElevationCoordinate_k__BackingField)) = num;
		}
	}

	public unsafe Vector2 _CalculatedTargetPoint_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CalculatedTargetPoint_k__BackingField);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CalculatedTargetPoint_k__BackingField)) = vector;
		}
	}

	public unsafe float _CalculatedSpeed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CalculatedSpeed_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CalculatedSpeed_k__BackingField)) = num;
		}
	}

	public unsafe bool _Locked_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Locked_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Locked_k__BackingField)) = flag;
		}
	}

	public unsafe float _Radius_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Radius_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Radius_k__BackingField)) = num;
		}
	}

	public unsafe float _Height_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Height_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Height_k__BackingField)) = num;
		}
	}

	public unsafe float _AgentTimeHorizon_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AgentTimeHorizon_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AgentTimeHorizon_k__BackingField)) = num;
		}
	}

	public unsafe float _ObstacleTimeHorizon_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ObstacleTimeHorizon_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ObstacleTimeHorizon_k__BackingField)) = num;
		}
	}

	public unsafe int _MaxNeighbours_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxNeighbours_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxNeighbours_k__BackingField)) = num;
		}
	}

	public unsafe int _NeighbourCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NeighbourCount_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NeighbourCount_k__BackingField)) = num;
		}
	}

	public unsafe RVOLayer _Layer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Layer_k__BackingField);
			return *(RVOLayer*)num;
		}
		set
		{
			*(RVOLayer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Layer_k__BackingField)) = rVOLayer;
		}
	}

	public unsafe RVOLayer _CollidesWith_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CollidesWith_k__BackingField);
			return *(RVOLayer*)num;
		}
		set
		{
			*(RVOLayer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CollidesWith_k__BackingField)) = rVOLayer;
		}
	}

	public unsafe float _Priority_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Priority_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Priority_k__BackingField)) = num;
		}
	}

	public unsafe Il2CppSystem.Action _PreCalculationCallback_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PreCalculationCallback_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PreCalculationCallback_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Agent next
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Agent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent));
		}
	}

	public unsafe float calculatedSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedSpeed)) = num;
		}
	}

	public unsafe Vector2 calculatedTargetPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedTargetPoint);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedTargetPoint)) = vector;
		}
	}

	public unsafe Simulator simulator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Simulator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simulator));
		}
	}

	public unsafe List<Agent> neighbours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neighbours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Agent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neighbours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> neighbourDists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neighbourDists);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neighbourDists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ObstacleVertex> obstaclesBuffered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstaclesBuffered);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObstacleVertex>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstaclesBuffered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ObstacleVertex> obstacles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObstacleVertex>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obstacles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static float DesiredVelocityWeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DesiredVelocityWeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DesiredVelocityWeight, (void*)(&num));
		}
	}

	public unsafe static float WallWeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WallWeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WallWeight, (void*)(&num));
		}
	}

	public unsafe virtual Vector2 Position
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float ElevationCoordinate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ElevationCoordinate_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ElevationCoordinate_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual Vector2 CalculatedTargetPoint
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CalculatedTargetPoint_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CalculatedTargetPoint_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float CalculatedSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CalculatedSpeed_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CalculatedSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual bool Locked
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Locked_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Locked_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float Radius
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Radius_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Radius_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float Height
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Height_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float AgentTimeHorizon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AgentTimeHorizon_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AgentTimeHorizon_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float ObstacleTimeHorizon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ObstacleTimeHorizon_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ObstacleTimeHorizon_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual int MaxNeighbours
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxNeighbours_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxNeighbours_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual int NeighbourCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NeighbourCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NeighbourCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual RVOLayer Layer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Layer_Public_Virtual_Final_New_get_RVOLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(RVOLayer*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Layer_Public_Virtual_Final_New_set_Void_RVOLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual RVOLayer CollidesWith
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CollidesWith_Public_Virtual_Final_New_get_RVOLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(RVOLayer*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CollidesWith_Public_Virtual_Final_New_set_Void_RVOLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual bool DebugDraw
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugDraw_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082610, XrefRangeEnd = 1082612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DebugDraw_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual float Priority
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Priority_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Action PreCalculationCallback
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PreCalculationCallback_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PreCalculationCallback_Public_Virtual_Final_New_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual List<ObstacleVertex> NeighbourObstacles
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 26795, RefRangeEnd = 26824, XrefRangeStart = 26795, XrefRangeEnd = 26824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NeighbourObstacles_Public_Virtual_Final_New_get_List_1_ObstacleVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObstacleVertex>>(intPtr) : null;
		}
	}

	static Agent()
	{
		Il2CppClassPointerStore<Agent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.RVO.Sampled", "Agent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Agent>.NativeClassPtr);
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "height");
		NativeFieldInfoPtr_desiredSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "desiredSpeed");
		NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "maxSpeed");
		NativeFieldInfoPtr_agentTimeHorizon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "agentTimeHorizon");
		NativeFieldInfoPtr_obstacleTimeHorizon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "obstacleTimeHorizon");
		NativeFieldInfoPtr_locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "locked");
		NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "layer");
		NativeFieldInfoPtr_collidesWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "collidesWith");
		NativeFieldInfoPtr_maxNeighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "maxNeighbours");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "position");
		NativeFieldInfoPtr_elevationCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "elevationCoordinate");
		NativeFieldInfoPtr_currentVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "currentVelocity");
		NativeFieldInfoPtr_desiredTargetPointInVelocitySpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "desiredTargetPointInVelocitySpace");
		NativeFieldInfoPtr_desiredVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "desiredVelocity");
		NativeFieldInfoPtr_nextTargetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "nextTargetPoint");
		NativeFieldInfoPtr_nextDesiredSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "nextDesiredSpeed");
		NativeFieldInfoPtr_nextMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "nextMaxSpeed");
		NativeFieldInfoPtr_collisionNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "collisionNormal");
		NativeFieldInfoPtr_manuallyControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "manuallyControlled");
		NativeFieldInfoPtr_debugDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "debugDraw");
		NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<Position>k__BackingField");
		NativeFieldInfoPtr__ElevationCoordinate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<ElevationCoordinate>k__BackingField");
		NativeFieldInfoPtr__CalculatedTargetPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<CalculatedTargetPoint>k__BackingField");
		NativeFieldInfoPtr__CalculatedSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<CalculatedSpeed>k__BackingField");
		NativeFieldInfoPtr__Locked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<Locked>k__BackingField");
		NativeFieldInfoPtr__Radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<Radius>k__BackingField");
		NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<Height>k__BackingField");
		NativeFieldInfoPtr__AgentTimeHorizon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<AgentTimeHorizon>k__BackingField");
		NativeFieldInfoPtr__ObstacleTimeHorizon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<ObstacleTimeHorizon>k__BackingField");
		NativeFieldInfoPtr__MaxNeighbours_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<MaxNeighbours>k__BackingField");
		NativeFieldInfoPtr__NeighbourCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<NeighbourCount>k__BackingField");
		NativeFieldInfoPtr__Layer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<Layer>k__BackingField");
		NativeFieldInfoPtr__CollidesWith_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<CollidesWith>k__BackingField");
		NativeFieldInfoPtr__Priority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<Priority>k__BackingField");
		NativeFieldInfoPtr__PreCalculationCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "<PreCalculationCallback>k__BackingField");
		NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "next");
		NativeFieldInfoPtr_calculatedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "calculatedSpeed");
		NativeFieldInfoPtr_calculatedTargetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "calculatedTargetPoint");
		NativeFieldInfoPtr_simulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "simulator");
		NativeFieldInfoPtr_neighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "neighbours");
		NativeFieldInfoPtr_neighbourDists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "neighbourDists");
		NativeFieldInfoPtr_obstaclesBuffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "obstaclesBuffered");
		NativeFieldInfoPtr_obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "obstacles");
		NativeFieldInfoPtr_DesiredVelocityWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "DesiredVelocityWeight");
		NativeFieldInfoPtr_WallWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Agent>.NativeClassPtr, "WallWeight");
		NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684206);
		NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684207);
		NativeMethodInfoPtr_get_ElevationCoordinate_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684208);
		NativeMethodInfoPtr_set_ElevationCoordinate_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684209);
		NativeMethodInfoPtr_get_CalculatedTargetPoint_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684210);
		NativeMethodInfoPtr_set_CalculatedTargetPoint_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684211);
		NativeMethodInfoPtr_get_CalculatedSpeed_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684212);
		NativeMethodInfoPtr_set_CalculatedSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684213);
		NativeMethodInfoPtr_get_Locked_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684214);
		NativeMethodInfoPtr_set_Locked_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684215);
		NativeMethodInfoPtr_get_Radius_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684216);
		NativeMethodInfoPtr_set_Radius_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684217);
		NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684218);
		NativeMethodInfoPtr_set_Height_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684219);
		NativeMethodInfoPtr_get_AgentTimeHorizon_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684220);
		NativeMethodInfoPtr_set_AgentTimeHorizon_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684221);
		NativeMethodInfoPtr_get_ObstacleTimeHorizon_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684222);
		NativeMethodInfoPtr_set_ObstacleTimeHorizon_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684223);
		NativeMethodInfoPtr_get_MaxNeighbours_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684224);
		NativeMethodInfoPtr_set_MaxNeighbours_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684225);
		NativeMethodInfoPtr_get_NeighbourCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684226);
		NativeMethodInfoPtr_set_NeighbourCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684227);
		NativeMethodInfoPtr_get_Layer_Public_Virtual_Final_New_get_RVOLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684228);
		NativeMethodInfoPtr_set_Layer_Public_Virtual_Final_New_set_Void_RVOLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684229);
		NativeMethodInfoPtr_get_CollidesWith_Public_Virtual_Final_New_get_RVOLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684230);
		NativeMethodInfoPtr_set_CollidesWith_Public_Virtual_Final_New_set_Void_RVOLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684231);
		NativeMethodInfoPtr_get_DebugDraw_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684232);
		NativeMethodInfoPtr_set_DebugDraw_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684233);
		NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684234);
		NativeMethodInfoPtr_set_Priority_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684235);
		NativeMethodInfoPtr_get_PreCalculationCallback_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684236);
		NativeMethodInfoPtr_set_PreCalculationCallback_Public_Virtual_Final_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684237);
		NativeMethodInfoPtr_SetTarget_Public_Virtual_Final_New_Void_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684238);
		NativeMethodInfoPtr_SetCollisionNormal_Public_Virtual_Final_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684239);
		NativeMethodInfoPtr_ForceSetVelocity_Public_Virtual_Final_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684240);
		NativeMethodInfoPtr_get_NeighbourObstacles_Public_Virtual_Final_New_get_List_1_ObstacleVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684241);
		NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684242);
		NativeMethodInfoPtr_BufferSwitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684243);
		NativeMethodInfoPtr_PreCalculation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684244);
		NativeMethodInfoPtr_PostCalculation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684245);
		NativeMethodInfoPtr_CalculateNeighbours_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684246);
		NativeMethodInfoPtr_Sqr_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684247);
		NativeMethodInfoPtr_InsertAgentNeighbour_Internal_Single_Agent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684248);
		NativeMethodInfoPtr_FromXZ_Private_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684249);
		NativeMethodInfoPtr_ToXZ_Private_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684250);
		NativeMethodInfoPtr_To2D_Private_Vector2_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684251);
		NativeMethodInfoPtr_DrawVO_Private_Static_Void_Vector2_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684252);
		NativeMethodInfoPtr_CalculateVelocity_Internal_Void_WorkerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684253);
		NativeMethodInfoPtr_Rainbow_Private_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684254);
		NativeMethodInfoPtr_GenerateObstacleVOs_Private_Void_VOBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684255);
		NativeMethodInfoPtr_GenerateNeighbourAgentVOs_Private_Void_VOBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684256);
		NativeMethodInfoPtr_GradientDescent_Private_Vector2_VOBuffer_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684257);
		NativeMethodInfoPtr_BiasDesiredVelocity_Private_Static_Boolean_VOBuffer_byref_Vector2_byref_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684258);
		NativeMethodInfoPtr_EvaluateGradient_Private_Vector2_VOBuffer_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684259);
		NativeMethodInfoPtr_Trace_Private_Vector2_VOBuffer_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Agent>.NativeClassPtr, 100684260);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082612, XrefRangeEnd = 1082618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&targetPoint);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &desiredSpeed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSpeed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTarget_Public_Virtual_Final_New_Void_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetCollisionNormal(Vector2 normal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCollisionNormal_Public_Virtual_Final_New_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082618, XrefRangeEnd = 1082619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ForceSetVelocity(Vector2 velocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&velocity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSetVelocity_Public_Virtual_Final_New_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082648, RefRangeEnd = 1082650, XrefRangeStart = 1082619, XrefRangeEnd = 1082648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Agent(Vector2 pos, float elevationCoordinate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Agent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &elevationCoordinate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082655, RefRangeEnd = 1082657, XrefRangeStart = 1082650, XrefRangeEnd = 1082655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BufferSwitch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BufferSwitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082658, RefRangeEnd = 1082659, XrefRangeStart = 1082657, XrefRangeEnd = 1082658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreCalculation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreCalculation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1082659, RefRangeEnd = 1082662, XrefRangeStart = 1082659, XrefRangeEnd = 1082659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostCalculation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostCalculation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082670, RefRangeEnd = 1082672, XrefRangeStart = 1082662, XrefRangeEnd = 1082670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateNeighbours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateNeighbours_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082672, RefRangeEnd = 1082673, XrefRangeStart = 1082672, XrefRangeEnd = 1082672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Sqr(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sqr_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082673, XrefRangeEnd = 1082700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InsertAgentNeighbour(Agent agent, float rangeSq)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)agent);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeSq;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertAgentNeighbour_Internal_Single_Agent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector3 FromXZ(Vector2 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXZ_Private_Static_Vector3_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector2 ToXZ(Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToXZ_Private_Static_Vector2_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector2 To2D(Vector3 p, out float elevation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref elevation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To2D_Private_Vector2_Vector3_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082723, RefRangeEnd = 1082724, XrefRangeStart = 1082700, XrefRangeEnd = 1082723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawVO(Vector2 circleCenter, float radius, Vector2 origin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&circleCenter);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVO_Private_Static_Void_Vector2_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082738, RefRangeEnd = 1082740, XrefRangeStart = 1082724, XrefRangeEnd = 1082738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateVelocity(Simulator.WorkerContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateVelocity_Internal_Void_WorkerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082740, XrefRangeEnd = 1082741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Rainbow(float v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rainbow_Private_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082757, RefRangeEnd = 1082758, XrefRangeStart = 1082741, XrefRangeEnd = 1082757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateObstacleVOs(VOBuffer vos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateObstacleVOs_Private_Void_VOBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082773, RefRangeEnd = 1082774, XrefRangeStart = 1082758, XrefRangeEnd = 1082773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateNeighbourAgentVOs(VOBuffer vos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateNeighbourAgentVOs_Private_Void_VOBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082787, RefRangeEnd = 1082788, XrefRangeStart = 1082774, XrefRangeEnd = 1082787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GradientDescent(VOBuffer vos, Vector2 sampleAround1, Vector2 sampleAround2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleAround1;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleAround2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GradientDescent_Private_Vector2_VOBuffer_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082793, RefRangeEnd = 1082794, XrefRangeStart = 1082788, XrefRangeEnd = 1082793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool BiasDesiredVelocity(VOBuffer vos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vos);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref desiredVelocity);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref targetPointInVelocitySpace);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxBiasRadians;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasDesiredVelocity_Private_Static_Boolean_VOBuffer_byref_Vector2_byref_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082802, RefRangeEnd = 1082803, XrefRangeStart = 1082794, XrefRangeEnd = 1082802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 EvaluateGradient(VOBuffer vos, Vector2 p, out float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateGradient_Private_Vector2_VOBuffer_Vector2_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1082816, RefRangeEnd = 1082818, XrefRangeStart = 1082803, XrefRangeEnd = 1082816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 Trace(VOBuffer vos, Vector2 p, out float score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref score);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trace_Private_Vector2_VOBuffer_Vector2_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Agent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
