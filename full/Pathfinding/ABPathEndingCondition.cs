using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Pathfinding;

public class ABPathEndingCondition : PathEndingCondition
{
	private static readonly IntPtr NativeFieldInfoPtr_abPath;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ABPath_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0;

	public unsafe ABPath abPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abPath);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ABPath>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abPath)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aBPath));
		}
	}

	static ABPathEndingCondition()
	{
		Il2CppClassPointerStore<ABPathEndingCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "ABPathEndingCondition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABPathEndingCondition>.NativeClassPtr);
		NativeFieldInfoPtr_abPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABPathEndingCondition>.NativeClassPtr, "abPath");
		NativeMethodInfoPtr__ctor_Public_Void_ABPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABPathEndingCondition>.NativeClassPtr, 100683785);
		NativeMethodInfoPtr_TargetFound_Public_Virtual_Boolean_PathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABPathEndingCondition>.NativeClassPtr, 100683786);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1076559, RefRangeEnd = 1076561, XrefRangeStart = 1076558, XrefRangeEnd = 1076559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ABPathEndingCondition(ABPath p)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABPathEndingCondition>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ABPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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

	public ABPathEndingCondition(IntPtr pointer)
		: base(pointer)
	{
	}
}
