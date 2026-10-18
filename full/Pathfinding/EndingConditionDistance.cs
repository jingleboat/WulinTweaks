using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Pathfinding;

public class EndingConditionDistance : PathEndingCondition
{
	private static readonly IntPtr NativeFieldInfoPtr_maxGScore;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Path_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0;

	public unsafe int maxGScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxGScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxGScore)) = num;
		}
	}

	static EndingConditionDistance()
	{
		Il2CppClassPointerStore<EndingConditionDistance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "EndingConditionDistance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndingConditionDistance>.NativeClassPtr);
		NativeFieldInfoPtr_maxGScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndingConditionDistance>.NativeClassPtr, "maxGScore");
		NativeMethodInfoPtr__ctor_Public_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndingConditionDistance>.NativeClassPtr, 100683717);
		NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndingConditionDistance>.NativeClassPtr, 100683718);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1076000, RefRangeEnd = 1076002, XrefRangeStart = 1075999, XrefRangeEnd = 1076000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EndingConditionDistance(Path p, int maxGScore)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndingConditionDistance>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &maxGScore;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
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

	public EndingConditionDistance(IntPtr pointer)
		: base(pointer)
	{
	}
}
