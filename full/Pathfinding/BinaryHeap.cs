using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding;

public class BinaryHeap : Il2CppSystem.Object
{
	public sealed class Tuple : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_node;

		private static readonly System.IntPtr NativeFieldInfoPtr_F;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PathNode_0;

		public unsafe PathNode node
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathNode));
			}
		}

		public unsafe uint F
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_F);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_F)) = num;
			}
		}

		static Tuple()
		{
			Il2CppClassPointerStore<Tuple>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "Tuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple>.NativeClassPtr);
			NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple>.NativeClassPtr, "node");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_UInt32_PathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100689338);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1063051, RefRangeEnd = 1063055, XrefRangeStart = 1063051, XrefRangeEnd = 1063051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple(uint f, PathNode node)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tuple>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&f);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_PathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Tuple(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Tuple()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tuple>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_numberOfItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_growthFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_D;

	private static readonly System.IntPtr NativeFieldInfoPtr_SortGScores;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotInHeap;

	private static readonly System.IntPtr NativeFieldInfoPtr_heap;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundUpToNextMultipleMod1_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNode_Internal_PathNode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetF_Internal_Void_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Expand_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_PathNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecreaseKey_Private_Void_Tuple_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_PathNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rebuild_Public_Void_0;

	public unsafe int numberOfItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberOfItems);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberOfItems)) = num;
		}
	}

	public unsafe float growthFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growthFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growthFactor)) = num;
		}
	}

	public unsafe static int D
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_D, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_D, (void*)(&num));
		}
	}

	public unsafe static bool SortGScores
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SortGScores, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SortGScores, (void*)(&flag));
		}
	}

	public unsafe static ushort NotInHeap
	{
		get
		{
			Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotInHeap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotInHeap, (void*)(&num));
		}
	}

	public unsafe Il2CppReferenceArray<Tuple> heap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tuple>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool isEmpty
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1063055, RefRangeEnd = 1063066, XrefRangeStart = 1063055, XrefRangeEnd = 1063055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BinaryHeap()
	{
		Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "BinaryHeap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr);
		NativeFieldInfoPtr_numberOfItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "numberOfItems");
		NativeFieldInfoPtr_growthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "growthFactor");
		NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "D");
		NativeFieldInfoPtr_SortGScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "SortGScores");
		NativeFieldInfoPtr_NotInHeap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "NotInHeap");
		NativeFieldInfoPtr_heap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, "heap");
		NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682516);
		NativeMethodInfoPtr_RoundUpToNextMultipleMod1_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682517);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682518);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682519);
		NativeMethodInfoPtr_GetNode_Internal_PathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682520);
		NativeMethodInfoPtr_SetF_Internal_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682521);
		NativeMethodInfoPtr_Expand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682522);
		NativeMethodInfoPtr_Add_Public_Void_PathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682523);
		NativeMethodInfoPtr_DecreaseKey_Private_Void_Tuple_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682524);
		NativeMethodInfoPtr_Remove_Public_PathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682525);
		NativeMethodInfoPtr_Validate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682526);
		NativeMethodInfoPtr_Rebuild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr, 100682527);
	}

	[CallerCount(0)]
	public unsafe static int RoundUpToNextMultipleMod1(int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundUpToNextMultipleMod1_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063070, RefRangeEnd = 1063072, XrefRangeStart = 1063066, XrefRangeEnd = 1063070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BinaryHeap(int capacity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryHeap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063072, RefRangeEnd = 1063074, XrefRangeStart = 1063072, XrefRangeEnd = 1063072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063074, RefRangeEnd = 1063076, XrefRangeStart = 1063074, XrefRangeEnd = 1063074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PathNode GetNode(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNode_Internal_PathNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathNode>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063076, RefRangeEnd = 1063078, XrefRangeStart = 1063076, XrefRangeEnd = 1063076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetF(int i, uint f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &f;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetF_Internal_Void_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063094, RefRangeEnd = 1063095, XrefRangeStart = 1063078, XrefRangeEnd = 1063094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Expand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Expand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1063098, RefRangeEnd = 1063108, XrefRangeStart = 1063095, XrefRangeEnd = 1063098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(PathNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_PathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063110, RefRangeEnd = 1063111, XrefRangeStart = 1063108, XrefRangeEnd = 1063110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecreaseKey(Tuple node, ushort index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)node));
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecreaseKey_Private_Void_Tuple_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1063115, RefRangeEnd = 1063126, XrefRangeStart = 1063111, XrefRangeEnd = 1063115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PathNode Remove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_PathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathNode>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void Validate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063126, RefRangeEnd = 1063128, XrefRangeStart = 1063126, XrefRangeEnd = 1063126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rebuild()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rebuild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BinaryHeap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
