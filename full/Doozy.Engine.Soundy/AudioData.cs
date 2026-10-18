using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Soundy;

[System.Serializable]
public class AudioData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_WEIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_WEIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_WEIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_AudioClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AudioClip_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	public unsafe static float DEFAULT_WEIGHT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_WEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_WEIGHT, (void*)(&num));
		}
	}

	public unsafe static float MAX_WEIGHT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_WEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_WEIGHT, (void*)(&num));
		}
	}

	public unsafe static float MIN_WEIGHT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_WEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_WEIGHT, (void*)(&num));
		}
	}

	public unsafe AudioClip AudioClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioClip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip));
		}
	}

	public unsafe float Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight)) = num;
		}
	}

	static AudioData()
	{
		Il2CppClassPointerStore<AudioData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Soundy", "AudioData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioData>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_WEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "DEFAULT_WEIGHT");
		NativeFieldInfoPtr_MAX_WEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "MAX_WEIGHT");
		NativeFieldInfoPtr_MIN_WEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "MIN_WEIGHT");
		NativeFieldInfoPtr_AudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "AudioClip");
		NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "Weight");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioData>.NativeClassPtr, 100668617);
		NativeMethodInfoPtr__ctor_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioData>.NativeClassPtr, 100668618);
		NativeMethodInfoPtr__ctor_Public_Void_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioData>.NativeClassPtr, 100668619);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioData>.NativeClassPtr, 100668620);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742784, XrefRangeEnd = 742785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742785, XrefRangeEnd = 742786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioData(AudioClip audioClip)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742786, XrefRangeEnd = 742787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioData(AudioClip audioClip, float weight)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AudioClip_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AudioData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
