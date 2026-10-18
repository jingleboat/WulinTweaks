using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class GlobalAudioListener : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_virtalAudioListeners;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_VirtualListenerRegister_Public_Void_VirtualAudioListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_VirtualListenerUnregister_Public_Void_VirtualAudioListener_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<VirtualAudioListener> virtalAudioListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtalAudioListeners);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<VirtualAudioListener>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtalAudioListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GlobalAudioListener()
	{
		Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GlobalAudioListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr);
		NativeFieldInfoPtr_virtalAudioListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr, "virtalAudioListeners");
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr, 100671930);
		NativeMethodInfoPtr_VirtualListenerRegister_Public_Void_VirtualAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr, 100671931);
		NativeMethodInfoPtr_VirtualListenerUnregister_Public_Void_VirtualAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr, 100671932);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr, 100671933);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795536, XrefRangeEnd = 795544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795559, RefRangeEnd = 795560, XrefRangeStart = 795544, XrefRangeEnd = 795559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VirtualListenerRegister(VirtualAudioListener audioListener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioListener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VirtualListenerRegister_Public_Void_VirtualAudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795566, RefRangeEnd = 795567, XrefRangeStart = 795560, XrefRangeEnd = 795566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VirtualListenerUnregister(VirtualAudioListener audioListener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioListener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VirtualListenerUnregister_Public_Void_VirtualAudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795567, XrefRangeEnd = 795574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalAudioListener()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalAudioListener>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GlobalAudioListener(IntPtr pointer)
		: base(pointer)
	{
	}
}
