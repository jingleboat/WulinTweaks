using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Pathfinding;

public class PathNNConstraint : NNConstraint
{
	private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_PathNNConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetStart_Public_Virtual_New_Void_GraphNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public new unsafe static PathNNConstraint Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067152, XrefRangeEnd = 1067156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_PathNNConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PathNNConstraint>(intPtr) : null;
		}
	}

	static PathNNConstraint()
	{
		Il2CppClassPointerStore<PathNNConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "PathNNConstraint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathNNConstraint>.NativeClassPtr);
		NativeMethodInfoPtr_get_Default_Public_Static_get_PathNNConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathNNConstraint>.NativeClassPtr, 100682923);
		NativeMethodInfoPtr_SetStart_Public_Virtual_New_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathNNConstraint>.NativeClassPtr, 100682924);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathNNConstraint>.NativeClassPtr, 100682925);
	}

	[CallerCount(0)]
	public unsafe virtual void SetStart(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetStart_Public_Virtual_New_Void_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067156, XrefRangeEnd = 1067157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PathNNConstraint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathNNConstraint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PathNNConstraint(IntPtr pointer)
		: base(pointer)
	{
	}
}
