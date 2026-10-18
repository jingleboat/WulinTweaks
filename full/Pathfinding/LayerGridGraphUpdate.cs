using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Pathfinding;

public class LayerGridGraphUpdate : GraphUpdateObject
{
	private static readonly IntPtr NativeFieldInfoPtr_recalculateNodes;

	private static readonly IntPtr NativeFieldInfoPtr_preserveExistingNodes;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool recalculateNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalculateNodes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalculateNodes)) = flag;
		}
	}

	public unsafe bool preserveExistingNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preserveExistingNodes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preserveExistingNodes)) = flag;
		}
	}

	static LayerGridGraphUpdate()
	{
		Il2CppClassPointerStore<LayerGridGraphUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "LayerGridGraphUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerGridGraphUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_recalculateNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerGridGraphUpdate>.NativeClassPtr, "recalculateNodes");
		NativeFieldInfoPtr_preserveExistingNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerGridGraphUpdate>.NativeClassPtr, "preserveExistingNodes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerGridGraphUpdate>.NativeClassPtr, 100683239);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069505, XrefRangeEnd = 1069506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LayerGridGraphUpdate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayerGridGraphUpdate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LayerGridGraphUpdate(IntPtr pointer)
		: base(pointer)
	{
	}
}
