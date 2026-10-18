using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class HotkeySettingRegion : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_EnvMode;

	private static readonly IntPtr NativeFieldInfoPtr_HotKeyItemGroupGameObject;

	private static readonly IntPtr NativeFieldInfoPtr_HotKeys;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshItem_Public_Void_HotKeyType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHotKeyByKey_Public_HotKeyEntity_KeyCode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe HotKeyEnvMode EnvMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvMode);
			return *(HotKeyEnvMode*)num;
		}
		set
		{
			*(HotKeyEnvMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvMode)) = hotKeyEnvMode;
		}
	}

	public unsafe GameObject HotKeyItemGroupGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HotKeyItemGroupGameObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HotKeyItemGroupGameObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<HotKeyEntity> HotKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HotKeys);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<HotKeyEntity>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HotKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static HotkeySettingRegion()
	{
		Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "HotkeySettingRegion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr);
		NativeFieldInfoPtr_EnvMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, "EnvMode");
		NativeFieldInfoPtr_HotKeyItemGroupGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, "HotKeyItemGroupGameObject");
		NativeFieldInfoPtr_HotKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, "HotKeys");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, 100677031);
		NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, 100677032);
		NativeMethodInfoPtr_RefreshItem_Public_Void_HotKeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, 100677033);
		NativeMethodInfoPtr_GetHotKeyByKey_Public_HotKeyEntity_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, 100677034);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr, 100677035);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940497, XrefRangeEnd = 940498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940538, RefRangeEnd = 940539, XrefRangeStart = 940498, XrefRangeEnd = 940538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940549, RefRangeEnd = 940550, XrefRangeStart = 940539, XrefRangeEnd = 940549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshItem(HotKeyType hotKeyType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&hotKeyType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshItem_Public_Void_HotKeyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940566, RefRangeEnd = 940567, XrefRangeStart = 940550, XrefRangeEnd = 940566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HotKeyEntity GetHotKeyByKey(KeyCode keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHotKeyByKey_Public_HotKeyEntity_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HotKeyEntity>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940567, XrefRangeEnd = 940574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HotkeySettingRegion()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeySettingRegion>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HotkeySettingRegion(IntPtr pointer)
		: base(pointer)
	{
	}
}
