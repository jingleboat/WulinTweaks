using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Nody.Models;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Doozy.Engine.UI.Connections;

[System.Serializable]
public class UIConnection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_TIME_DELAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_Trigger;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Static_UIConnection_Socket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_Socket_UIConnection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float DEFAULT_TIME_DELAY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_TIME_DELAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_TIME_DELAY, (void*)(&num));
		}
	}

	public unsafe string ButtonCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonCategory);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ButtonName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string GameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameEvent);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameEvent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float TimeDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeDelay)) = num;
		}
	}

	public unsafe UIConnectionTrigger Trigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trigger);
			return *(UIConnectionTrigger*)num;
		}
		set
		{
			*(UIConnectionTrigger*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trigger)) = uIConnectionTrigger;
		}
	}

	static UIConnection()
	{
		Il2CppClassPointerStore<UIConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Connections", "UIConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIConnection>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_TIME_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, "DEFAULT_TIME_DELAY");
		NativeFieldInfoPtr_ButtonCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, "ButtonCategory");
		NativeFieldInfoPtr_ButtonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, "ButtonName");
		NativeFieldInfoPtr_GameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, "GameEvent");
		NativeFieldInfoPtr_TimeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, "TimeDelay");
		NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, "Trigger");
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, 100668263);
		NativeMethodInfoPtr_GetValue_Public_Static_UIConnection_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, 100668264);
		NativeMethodInfoPtr_SetValue_Public_Static_Void_Socket_UIConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, 100668265);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConnection>.NativeClassPtr, 100668266);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737522, XrefRangeEnd = 737528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 737532, RefRangeEnd = 737536, XrefRangeStart = 737528, XrefRangeEnd = 737532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIConnection GetValue(Socket socket)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socket);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Static_UIConnection_Socket_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIConnection>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 737537, RefRangeEnd = 737538, XrefRangeStart = 737536, XrefRangeEnd = 737537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValue(Socket socket, UIConnection value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socket);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Static_Void_Socket_UIConnection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737538, XrefRangeEnd = 737545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIConnection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIConnection>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIConnection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
