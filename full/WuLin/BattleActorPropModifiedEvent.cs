using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class BattleActorPropModifiedEvent : BattleFieldEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_modifySources;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_battleActorPropModifies;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionModify;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergePropChange_Public_Void_List_1_BattleActorPropModify_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsImportant_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasModifies_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<Il2CppSystem.Object> modifySources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifySources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifySources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BattleActor targetActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetActor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetActor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe Dictionary<BattleActor.BattleActorPropTypes, BattleActor.BattleActorPropModify> battleActorPropModifies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorPropModifies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor.BattleActorPropTypes, BattleActor.BattleActorPropModify>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorPropModifies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int actionModify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionModify);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionModify)) = num;
		}
	}

	static BattleActorPropModifiedEvent()
	{
		Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActorPropModifiedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr);
		NativeFieldInfoPtr_modifySources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, "modifySources");
		NativeFieldInfoPtr_targetActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, "targetActor");
		NativeFieldInfoPtr_battleActorPropModifies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, "battleActorPropModifies");
		NativeFieldInfoPtr_actionModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, "actionModify");
		NativeMethodInfoPtr_MergePropChange_Public_Void_List_1_BattleActorPropModify_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, 100671259);
		NativeMethodInfoPtr_IsImportant_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, 100671260);
		NativeMethodInfoPtr_HasModifies_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, 100671261);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr, 100671262);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 775062, RefRangeEnd = 775069, XrefRangeStart = 775024, XrefRangeEnd = 775062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergePropChange(List<BattleActor.BattleActorPropModify> modifies, List<int> actionModifyList = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifies);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionModifyList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergePropChange_Public_Void_List_1_BattleActorPropModify_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775069, XrefRangeEnd = 775088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsImportant()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsImportant_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 775091, RefRangeEnd = 775092, XrefRangeStart = 775088, XrefRangeEnd = 775091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasModifies()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasModifies_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 775099, RefRangeEnd = 775110, XrefRangeStart = 775092, XrefRangeEnd = 775099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleActorPropModifiedEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorPropModifiedEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleActorPropModifiedEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
