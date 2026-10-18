using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding.Util;

public static class MovementUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ClampVelocity_Public_Static_Vector2_Vector2_Single_Single_Boolean_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAccelerationToReachPoint_Public_Static_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_0;

	static MovementUtilities()
	{
		Il2CppClassPointerStore<MovementUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Util", "MovementUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovementUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_ClampVelocity_Public_Static_Vector2_Vector2_Single_Single_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementUtilities>.NativeClassPtr, 100684287);
		NativeMethodInfoPtr_CalculateAccelerationToReachPoint_Public_Static_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementUtilities>.NativeClassPtr, 100684288);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1083528, RefRangeEnd = 1083530, XrefRangeStart = 1083517, XrefRangeEnd = 1083528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ClampVelocity(Vector2 velocity, float maxSpeed, float slowdownFactor, bool slowWhenNotFacingTarget, Vector2 forward)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&velocity);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSpeed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &slowdownFactor;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &slowWhenNotFacingTarget;
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forward;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampVelocity_Public_Static_Vector2_Vector2_Single_Single_Boolean_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1083546, RefRangeEnd = 1083548, XrefRangeStart = 1083530, XrefRangeEnd = 1083546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 CalculateAccelerationToReachPoint(Vector2 deltaPosition, Vector2 targetVelocity, Vector2 currentVelocity, float forwardsAcceleration, float rotationSpeed, float maxSpeed, Vector2 forwardsVector)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&deltaPosition);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetVelocity;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentVelocity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forwardsAcceleration;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationSpeed;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSpeed;
		*(Vector2**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &forwardsVector;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateAccelerationToReachPoint_Public_Static_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public MovementUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
