using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Doozy.Engine;

public class GameEventMessage : Message
{
	private static readonly IntPtr NativeFieldInfoPtr_NO_GAME_EVENT;

	private static readonly IntPtr NativeFieldInfoPtr__IsSystemEvent_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_EventName;

	private static readonly IntPtr NativeFieldInfoPtr_Source;

	private static readonly IntPtr NativeMethodInfoPtr_get_HasGameEvent_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsSystemEvent_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsSystemEvent_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemGameEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemGameEvent_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_SystemGameEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_SystemGameEvent_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Public_Static_Void_List_1_String_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Private_Static_Void_GameEventMessage_0;

	public unsafe static string NO_GAME_EVENT
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NO_GAME_EVENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NO_GAME_EVENT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool _IsSystemEvent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSystemEvent_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsSystemEvent_k__BackingField)) = flag;
		}
	}

	public unsafe string EventName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EventName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EventName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe GameObject Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool HasGameEvent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725266, XrefRangeEnd = 725269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasGameEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsSystemEvent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSystemEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsSystemEvent_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GameEventMessage()
	{
		Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine", "GameEventMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr);
		NativeFieldInfoPtr_NO_GAME_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, "NO_GAME_EVENT");
		NativeFieldInfoPtr__IsSystemEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, "<IsSystemEvent>k__BackingField");
		NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, "EventName");
		NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, "Source");
		NativeMethodInfoPtr_get_HasGameEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667319);
		NativeMethodInfoPtr_get_IsSystemEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667320);
		NativeMethodInfoPtr_set_IsSystemEvent_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667321);
		NativeMethodInfoPtr__ctor_Public_Void_SystemGameEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667322);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667323);
		NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667324);
		NativeMethodInfoPtr__ctor_Public_Void_SystemGameEvent_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667325);
		NativeMethodInfoPtr__ctor_Public_Void_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667326);
		NativeMethodInfoPtr_SendEvent_Public_Static_Void_SystemGameEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667327);
		NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667328);
		NativeMethodInfoPtr_SendEvent_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667329);
		NativeMethodInfoPtr_SendEvent_Public_Static_Void_SystemGameEvent_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667330);
		NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667331);
		NativeMethodInfoPtr_SendEvents_Public_Static_Void_List_1_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667332);
		NativeMethodInfoPtr_SendEvent_Private_Static_Void_GameEventMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr, 100667333);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725269, XrefRangeEnd = 725277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventMessage(SystemGameEvent systemGameEvent)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&systemGameEvent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SystemGameEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725277, XrefRangeEnd = 725281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventMessage(string gameEvent)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameEvent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725281, XrefRangeEnd = 725287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventMessage(GameObject source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725287, XrefRangeEnd = 725295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventMessage(SystemGameEvent systemGameEvent, GameObject source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&systemGameEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SystemGameEvent_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725295, XrefRangeEnd = 725299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEventMessage(string gameEvent, GameObject source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEventMessage>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725312, RefRangeEnd = 725314, XrefRangeStart = 725299, XrefRangeEnd = 725312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(SystemGameEvent systemGameEvent)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&systemGameEvent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Public_Static_Void_SystemGameEvent_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725322, RefRangeEnd = 725323, XrefRangeStart = 725314, XrefRangeEnd = 725322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(string gameEvent)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameEvent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725323, XrefRangeEnd = 725333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(GameObject source)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Public_Static_Void_GameObject_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725333, XrefRangeEnd = 725346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(SystemGameEvent systemGameEvent, GameObject source)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&systemGameEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Public_Static_Void_SystemGameEvent_GameObject_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 725354, RefRangeEnd = 725359, XrefRangeStart = 725346, XrefRangeEnd = 725354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(string gameEvent, GameObject source)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_GameObject_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 725375, RefRangeEnd = 725379, XrefRangeStart = 725359, XrefRangeEnd = 725375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvents(List<string> gameEvents, GameObject source = null)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEvents);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvents_Public_Static_Void_List_1_String_GameObject_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 725386, RefRangeEnd = 725391, XrefRangeStart = 725379, XrefRangeEnd = 725386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(GameEventMessage gameEventMessage)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventMessage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Private_Static_Void_GameEventMessage_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameEventMessage(IntPtr pointer)
		: base(pointer)
	{
	}
}
