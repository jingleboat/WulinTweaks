using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding;

public class NNConstraint : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_graphMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_constrainArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_area;

	private static readonly System.IntPtr NativeFieldInfoPtr_constrainWalkability;

	private static readonly System.IntPtr NativeFieldInfoPtr_walkable;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_constrainTags;

	private static readonly System.IntPtr NativeFieldInfoPtr_tags;

	private static readonly System.IntPtr NativeFieldInfoPtr_constrainDistance;

	private static readonly System.IntPtr NativeMethodInfoPtr_SuitableGraph_Public_Virtual_New_Boolean_Int32_NavGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Suitable_Public_Virtual_New_Boolean_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_NNConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_NNConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GraphMask graphMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphMask);
			return *(GraphMask*)num;
		}
		set
		{
			*(GraphMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphMask)) = graphMask;
		}
	}

	public unsafe bool constrainArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainArea)) = flag;
		}
	}

	public unsafe int area
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_area);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_area)) = num;
		}
	}

	public unsafe bool constrainWalkability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainWalkability);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainWalkability)) = flag;
		}
	}

	public unsafe bool walkable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walkable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walkable)) = flag;
		}
	}

	public unsafe bool distanceXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceXZ);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceXZ)) = flag;
		}
	}

	public unsafe bool constrainTags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainTags);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainTags)) = flag;
		}
	}

	public unsafe int tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)) = num;
		}
	}

	public unsafe bool constrainDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainDistance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constrainDistance)) = flag;
		}
	}

	public unsafe static NNConstraint Default
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067125, RefRangeEnd = 1067127, XrefRangeStart = 1067120, XrefRangeEnd = 1067125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_NNConstraint_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NNConstraint>(intPtr) : null;
		}
	}

	public unsafe static NNConstraint None
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1067133, RefRangeEnd = 1067143, XrefRangeStart = 1067127, XrefRangeEnd = 1067133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_None_Public_Static_get_NNConstraint_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NNConstraint>(intPtr) : null;
		}
	}

	static NNConstraint()
	{
		Il2CppClassPointerStore<NNConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "NNConstraint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr);
		NativeFieldInfoPtr_graphMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "graphMask");
		NativeFieldInfoPtr_constrainArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "constrainArea");
		NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "area");
		NativeFieldInfoPtr_constrainWalkability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "constrainWalkability");
		NativeFieldInfoPtr_walkable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "walkable");
		NativeFieldInfoPtr_distanceXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "distanceXZ");
		NativeFieldInfoPtr_constrainTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "constrainTags");
		NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "tags");
		NativeFieldInfoPtr_constrainDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, "constrainDistance");
		NativeMethodInfoPtr_SuitableGraph_Public_Virtual_New_Boolean_Int32_NavGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, 100682918);
		NativeMethodInfoPtr_Suitable_Public_Virtual_New_Boolean_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, 100682919);
		NativeMethodInfoPtr_get_Default_Public_Static_get_NNConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, 100682920);
		NativeMethodInfoPtr_get_None_Public_Static_get_NNConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, 100682921);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr, 100682922);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067115, XrefRangeEnd = 1067116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool SuitableGraph(int graphIndex, NavGraph graph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graphIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SuitableGraph_Public_Virtual_New_Boolean_Int32_NavGraph_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067119, RefRangeEnd = 1067120, XrefRangeStart = 1067116, XrefRangeEnd = 1067119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Suitable(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Suitable_Public_Virtual_New_Boolean_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1067145, RefRangeEnd = 1067152, XrefRangeStart = 1067143, XrefRangeEnd = 1067145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NNConstraint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NNConstraint>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NNConstraint(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
