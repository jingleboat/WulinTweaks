using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Pathfinding;

public class FloodPathConstraint : NNConstraint
{
	private static readonly IntPtr NativeFieldInfoPtr_path;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FloodPath_0;

	private static readonly IntPtr NativeMethodInfoPtr_Suitable_Public_Virtual_Boolean_GraphNode_0;

	public unsafe FloodPath path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FloodPath>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)floodPath));
		}
	}

	static FloodPathConstraint()
	{
		Il2CppClassPointerStore<FloodPathConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "FloodPathConstraint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloodPathConstraint>.NativeClassPtr);
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloodPathConstraint>.NativeClassPtr, "path");
		NativeMethodInfoPtr__ctor_Public_Void_FloodPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPathConstraint>.NativeClassPtr, 100683734);
		NativeMethodInfoPtr_Suitable_Public_Virtual_Boolean_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloodPathConstraint>.NativeClassPtr, 100683735);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076075, XrefRangeEnd = 1076082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FloodPathConstraint(FloodPath path)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloodPathConstraint>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FloodPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076082, XrefRangeEnd = 1076083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Suitable(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Suitable_Public_Virtual_Boolean_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public FloodPathConstraint(IntPtr pointer)
		: base(pointer)
	{
	}
}
