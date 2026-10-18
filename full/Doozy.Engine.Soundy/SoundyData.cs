using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Audio;

namespace Doozy.Engine.Soundy;

[System.Serializable]
public class SoundyData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SoundSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_DatabaseName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AudioClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutputAudioMixerGroup;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioData_Public_SoundGroupData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAudioClip_Public_SoundyData_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDatabaseName_Public_SoundyData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOutputAudioMixerGroup_Public_SoundyData_AudioMixerGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSoundName_Public_SoundyData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSoundSource_Public_SoundyData_SoundSource_0;

	public unsafe SoundSource SoundSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundSource);
			return *(SoundSource*)num;
		}
		set
		{
			*(SoundSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundSource)) = soundSource;
		}
	}

	public unsafe string DatabaseName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundName)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe AudioMixerGroup OutputAudioMixerGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputAudioMixerGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputAudioMixerGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioMixerGroup));
		}
	}

	static SoundyData()
	{
		Il2CppClassPointerStore<SoundyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Soundy", "SoundyData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundyData>.NativeClassPtr);
		NativeFieldInfoPtr_SoundSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, "SoundSource");
		NativeFieldInfoPtr_DatabaseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, "DatabaseName");
		NativeFieldInfoPtr_SoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, "SoundName");
		NativeFieldInfoPtr_AudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, "AudioClip");
		NativeFieldInfoPtr_OutputAudioMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, "OutputAudioMixerGroup");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668718);
		NativeMethodInfoPtr_GetAudioData_Public_SoundGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668719);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668720);
		NativeMethodInfoPtr_SetAudioClip_Public_SoundyData_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668721);
		NativeMethodInfoPtr_SetDatabaseName_Public_SoundyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668722);
		NativeMethodInfoPtr_SetOutputAudioMixerGroup_Public_SoundyData_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668723);
		NativeMethodInfoPtr_SetSoundName_Public_SoundyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668724);
		NativeMethodInfoPtr_SetSoundSource_Public_SoundyData_SoundSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyData>.NativeClassPtr, 100668725);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 744320, RefRangeEnd = 744322, XrefRangeStart = 744315, XrefRangeEnd = 744320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundyData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundyData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744322, XrefRangeEnd = 744324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundGroupData GetAudioData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAudioData_Public_SoundGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744324, XrefRangeEnd = 744328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe SoundyData SetAudioClip(AudioClip audioClip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAudioClip_Public_SoundyData_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundyData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe SoundyData SetDatabaseName(string databaseName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDatabaseName_Public_SoundyData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundyData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe SoundyData SetOutputAudioMixerGroup(AudioMixerGroup audioMixerGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioMixerGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOutputAudioMixerGroup_Public_SoundyData_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundyData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe SoundyData SetSoundName(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSoundName_Public_SoundyData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundyData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe SoundyData SetSoundSource(SoundSource soundSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&soundSource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSoundSource_Public_SoundyData_SoundSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundyData>(intPtr) : null;
	}

	public SoundyData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
