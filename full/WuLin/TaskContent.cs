using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using WuLin.StateMachine;

namespace WuLin;

public class TaskContent : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_prefabCondition;

	private static readonly IntPtr NativeFieldInfoPtr_txtPrize;

	private static readonly IntPtr NativeFieldInfoPtr_uiTask;

	private static readonly IntPtr NativeFieldInfoPtr_listPoolCondition;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_String_Int32_UITaskTracking_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPrizeString_Private_String_Prize_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateCondition_Public_TaskCondition_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearConditions_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject prefabCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabCondition);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabCondition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe TMP_Text txtPrize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_txtPrize);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_txtPrize)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
		}
	}

	public unsafe UITaskTracking uiTask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiTask);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UITaskTracking>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiTask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uITaskTracking));
		}
	}

	public unsafe static List<GameObject> listPoolCondition
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listPoolCondition, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listPoolCondition, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static TaskContent()
	{
		Il2CppClassPointerStore<TaskContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "TaskContent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskContent>.NativeClassPtr);
		NativeFieldInfoPtr_prefabCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, "prefabCondition");
		NativeFieldInfoPtr_txtPrize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, "txtPrize");
		NativeFieldInfoPtr_uiTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, "uiTask");
		NativeFieldInfoPtr_listPoolCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, "listPoolCondition");
		NativeMethodInfoPtr_Init_Public_Void_String_Int32_UITaskTracking_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, 100680039);
		NativeMethodInfoPtr_GetPrizeString_Private_String_Prize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, 100680040);
		NativeMethodInfoPtr_CreateCondition_Public_TaskCondition_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, 100680041);
		NativeMethodInfoPtr_ClearConditions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, 100680042);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContent>.NativeClassPtr, 100680043);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016350, RefRangeEnd = 1016351, XrefRangeStart = 1016234, XrefRangeEnd = 1016350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(string graphName, int saveID, UITaskTracking parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(graphName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &saveID;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_String_Int32_UITaskTracking_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016431, RefRangeEnd = 1016432, XrefRangeStart = 1016351, XrefRangeEnd = 1016431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPrizeString(TaskNode.Prize configPrize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configPrize);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrizeString_Private_String_Prize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016458, RefRangeEnd = 1016459, XrefRangeStart = 1016432, XrefRangeEnd = 1016458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskCondition CreateCondition(Transform content)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCondition_Public_TaskCondition_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TaskCondition>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016482, RefRangeEnd = 1016483, XrefRangeStart = 1016459, XrefRangeEnd = 1016482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearConditions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearConditions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskContent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskContent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TaskContent(IntPtr pointer)
		: base(pointer)
	{
	}
}
