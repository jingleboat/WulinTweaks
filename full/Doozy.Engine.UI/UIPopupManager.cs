using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Doozy.Engine.UI;

public class UIPopupManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_CurrentVisibleQueuePopup;

	private static readonly IntPtr NativeFieldInfoPtr_PopupQueue;

	private static readonly IntPtr NativeFieldInfoPtr__ApplicationIsQuitting_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIPopupManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PopupDatabase_Public_Static_get_UIPopupDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_QueueIsEmpty_Public_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationIsQuitting_Private_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationIsQuitting_Private_Static_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddToQueue_Public_Static_Void_UIPopup_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Public_Static_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPopup_Public_Static_UIPopup_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPopupData_Private_Static_UIPopupQueueData_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPopupData_Private_Static_UIPopupQueueData_UIPopup_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsInQueue_Public_Static_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsInQueue_Public_Static_Boolean_UIPopup_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveFromQueue_Public_Static_Void_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveFromQueue_Public_Static_Void_UIPopup_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowNextInQueue_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowPopup_Public_Static_Void_UIPopup_Boolean_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowPopup_Public_Static_Void_UIPopup_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowPopup_Public_Static_UIPopup_String_Boolean_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowPopup_Public_Static_UIPopup_String_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddToScene_Private_Static_UIPopupManager_Boolean_0;

	public unsafe static UIPopupManager s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPopupManager));
		}
	}

	public unsafe static UIPopup CurrentVisibleQueuePopup
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentVisibleQueuePopup, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentVisibleQueuePopup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIPopup));
		}
	}

	public unsafe static List<UIPopupQueueData> PopupQueue
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PopupQueue, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<UIPopupQueueData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PopupQueue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool _ApplicationIsQuitting_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ApplicationIsQuitting_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ApplicationIsQuitting_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static UIPopupManager Instance
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 732665, RefRangeEnd = 732675, XrefRangeStart = 732623, XrefRangeEnd = 732665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIPopupManager_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupManager>(intPtr) : null;
		}
	}

	public unsafe static UIPopupDatabase PopupDatabase
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 732691, RefRangeEnd = 732694, XrefRangeStart = 732675, XrefRangeEnd = 732691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PopupDatabase_Public_Static_get_UIPopupDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupDatabase>(intPtr) : null;
		}
	}

	public unsafe static bool QueueIsEmpty
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 732699, RefRangeEnd = 732703, XrefRangeStart = 732694, XrefRangeEnd = 732699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_QueueIsEmpty_Public_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static bool ApplicationIsQuitting
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732703, XrefRangeEnd = 732707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ApplicationIsQuitting_Private_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732707, XrefRangeEnd = 732711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ApplicationIsQuitting_Private_Static_set_Void_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool DebugComponent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732711, XrefRangeEnd = 732712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UIPopupManager()
	{
		Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIPopupManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_CurrentVisibleQueuePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, "CurrentVisibleQueuePopup");
		NativeFieldInfoPtr_PopupQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, "PopupQueue");
		NativeFieldInfoPtr__ApplicationIsQuitting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, "<ApplicationIsQuitting>k__BackingField");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667845);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIPopupManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667846);
		NativeMethodInfoPtr_get_PopupDatabase_Public_Static_get_UIPopupDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667847);
		NativeMethodInfoPtr_get_QueueIsEmpty_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667848);
		NativeMethodInfoPtr_get_ApplicationIsQuitting_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667849);
		NativeMethodInfoPtr_set_ApplicationIsQuitting_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667850);
		NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667851);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667852);
		NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667853);
		NativeMethodInfoPtr_AddToQueue_Public_Static_Void_UIPopup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667854);
		NativeMethodInfoPtr_ClearQueue_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667855);
		NativeMethodInfoPtr_GetPopup_Public_Static_UIPopup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_GetPopupData_Private_Static_UIPopupQueueData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667857);
		NativeMethodInfoPtr_GetPopupData_Private_Static_UIPopupQueueData_UIPopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667858);
		NativeMethodInfoPtr_IsInQueue_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr_IsInQueue_Public_Static_Boolean_UIPopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667860);
		NativeMethodInfoPtr_RemoveFromQueue_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667861);
		NativeMethodInfoPtr_RemoveFromQueue_Public_Static_Void_UIPopup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667862);
		NativeMethodInfoPtr_ShowNextInQueue_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr_ShowPopup_Public_Static_Void_UIPopup_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr_ShowPopup_Public_Static_Void_UIPopup_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr_ShowPopup_Public_Static_UIPopup_String_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_ShowPopup_Public_Static_UIPopup_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667867);
		NativeMethodInfoPtr_AddToScene_Private_Static_UIPopupManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr, 100667868);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIPopupManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732712, XrefRangeEnd = 732749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732749, XrefRangeEnd = 732757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 732789, RefRangeEnd = 732790, XrefRangeStart = 732757, XrefRangeEnd = 732789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddToQueue(UIPopup popup, bool instantAction = false)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &instantAction;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToQueue_Public_Static_Void_UIPopup_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732790, XrefRangeEnd = 732850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearQueue(bool instantAction = false)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&instantAction);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearQueue_Public_Static_Void_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 732885, RefRangeEnd = 732888, XrefRangeStart = 732850, XrefRangeEnd = 732885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPopup GetPopup(string popupName)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPopup_Public_Static_UIPopup_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 732913, RefRangeEnd = 732914, XrefRangeStart = 732888, XrefRangeEnd = 732913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPopupQueueData GetPopupData(string popupName)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPopupData_Private_Static_UIPopupQueueData_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupQueueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 732945, RefRangeEnd = 732946, XrefRangeStart = 732914, XrefRangeEnd = 732945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPopupQueueData GetPopupData(UIPopup popup)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPopupData_Private_Static_UIPopupQueueData_UIPopup_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupQueueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 732971, RefRangeEnd = 732972, XrefRangeStart = 732946, XrefRangeEnd = 732971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInQueue(string popupName)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInQueue_Public_Static_Boolean_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 733002, RefRangeEnd = 733003, XrefRangeStart = 732972, XrefRangeEnd = 733002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInQueue(UIPopup popup)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInQueue_Public_Static_Boolean_UIPopup_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733003, XrefRangeEnd = 733043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveFromQueue(string popupName, bool showNextInQueue = true)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &showNextInQueue;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromQueue_Public_Static_Void_String_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 733078, RefRangeEnd = 733079, XrefRangeStart = 733043, XrefRangeEnd = 733078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveFromQueue(UIPopup popup, bool showNextInQueue = true)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &showNextInQueue;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromQueue_Public_Static_Void_UIPopup_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 733113, RefRangeEnd = 733116, XrefRangeStart = 733079, XrefRangeEnd = 733113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowNextInQueue()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowNextInQueue_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733116, XrefRangeEnd = 733125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowPopup(UIPopup popup, bool addToPopupQueue, bool instantAction, string targetCanvasName)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &addToPopupQueue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &instantAction;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetCanvasName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPopup_Public_Static_Void_UIPopup_Boolean_Boolean_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 733146, RefRangeEnd = 733149, XrefRangeStart = 733125, XrefRangeEnd = 733146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowPopup(UIPopup popup, bool addToPopupQueue, bool instantAction)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &addToPopupQueue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &instantAction;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPopup_Public_Static_Void_UIPopup_Boolean_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733149, XrefRangeEnd = 733162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPopup ShowPopup(string popupName, bool addToPopupQueue, bool instantAction, string targetCanvasName)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &addToPopupQueue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &instantAction;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetCanvasName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPopup_Public_Static_UIPopup_String_Boolean_Boolean_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 733167, RefRangeEnd = 733169, XrefRangeStart = 733162, XrefRangeEnd = 733167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPopup ShowPopup(string popupName, bool addToPopupQueue, bool instantAction)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(popupName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &addToPopupQueue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &instantAction;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPopup_Public_Static_UIPopup_String_Boolean_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733169, XrefRangeEnd = 733177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIPopupManager AddToScene(bool selectGameObjectAfterCreation = false)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&selectGameObjectAfterCreation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToScene_Private_Static_UIPopupManager_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIPopupManager>(intPtr) : null;
	}

	public UIPopupManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
