using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Pathfinding;

public class EndingConditionProximity : ABPathEndingCondition
{
	private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ABPath_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0;

	public unsafe float maxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance)) = num;
		}
	}

	static EndingConditionProximity()
	{
		Il2CppClassPointerStore<EndingConditionProximity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "EndingConditionProximity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndingConditionProximity>.NativeClassPtr);
		NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndingConditionProximity>.NativeClassPtr, "maxDistance");
		NativeMethodInfoPtr__ctor_Public_Void_ABPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndingConditionProximity>.NativeClassPtr, 100683787);
		NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndingConditionProximity>.NativeClassPtr, 100683788);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076561, XrefRangeEnd = 1076562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EndingConditionProximity(ABPath p, float maxDistance)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndingConditionProximity>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ABPath_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076562, XrefRangeEnd = 1076564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool TargetFound(PathNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public EndingConditionProximity(IntPtr pointer)
		: base(pointer)
	{
	}
}
