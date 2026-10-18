using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding;

public sealed class AstarWorkItem : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_init;

	private static readonly System.IntPtr NativeFieldInfoPtr_initWithContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_update;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateWithContext;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_IWorkItemContext_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Func_2_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_IWorkItemContext_Func_3_IWorkItemContext_Boolean_Boolean_0;

	public unsafe Il2CppSystem.Action init
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_init);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_init)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<IWorkItemContext> initWithContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initWithContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<IWorkItemContext>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initWithContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Func<bool, bool> update
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_update);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_update)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<IWorkItemContext, bool, bool> updateWithContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateWithContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<IWorkItemContext, bool, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateWithContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	static AstarWorkItem()
	{
		Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "AstarWorkItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr);
		NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, "init");
		NativeFieldInfoPtr_initWithContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, "initWithContext");
		NativeFieldInfoPtr_update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, "update");
		NativeFieldInfoPtr_updateWithContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, "updateWithContext");
		NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, 100682729);
		NativeMethodInfoPtr__ctor_Public_Void_Func_3_IWorkItemContext_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, 100682730);
		NativeMethodInfoPtr__ctor_Public_Void_Action_Func_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, 100682731);
		NativeMethodInfoPtr__ctor_Public_Void_Action_1_IWorkItemContext_Func_3_IWorkItemContext_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr, 100682732);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1065974, RefRangeEnd = 1065979, XrefRangeStart = 1065974, XrefRangeEnd = 1065974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstarWorkItem(Il2CppSystem.Func<bool, bool> update)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)update);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Func_2_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1065979, RefRangeEnd = 1065983, XrefRangeStart = 1065979, XrefRangeEnd = 1065979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstarWorkItem(Il2CppSystem.Func<IWorkItemContext, bool, bool> update)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)update);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Func_3_IWorkItemContext_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1065983, RefRangeEnd = 1065989, XrefRangeStart = 1065983, XrefRangeEnd = 1065983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstarWorkItem(Il2CppSystem.Action init, Il2CppSystem.Func<bool, bool> update = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)init);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)update);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_Func_2_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065989, RefRangeEnd = 1065990, XrefRangeStart = 1065989, XrefRangeEnd = 1065989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstarWorkItem(Il2CppSystem.Action<IWorkItemContext> init, Il2CppSystem.Func<IWorkItemContext, bool, bool> update = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)init);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)update);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_1_IWorkItemContext_Func_3_IWorkItemContext_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AstarWorkItem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AstarWorkItem()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarWorkItem>.NativeClassPtr))
	{
	}
}
