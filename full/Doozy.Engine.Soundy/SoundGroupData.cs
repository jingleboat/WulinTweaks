using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Doozy.Engine.Soundy;

[Serializable]
public class SoundGroupData : ScriptableObject
{
	public enum PlayMode
	{
		Random,
		Sequence
	}

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_IGNORE_LISTENER_PAUSE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_LOOP;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_RESET_SEQUENCE_AFTER_INACTIVE_TIME;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PITCH;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SEQUENCE_RESET_TIME;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SPATIAL_BLEND;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_VOLUME;

	private static readonly IntPtr NativeFieldInfoPtr_MAX_PITCH;

	private static readonly IntPtr NativeFieldInfoPtr_MAX_SPATIAL_BLEND;

	private static readonly IntPtr NativeFieldInfoPtr_MAX_VOLUME;

	private static readonly IntPtr NativeFieldInfoPtr_MIN_PITCH;

	private static readonly IntPtr NativeFieldInfoPtr_MIN_SPATIAL_BLEND;

	private static readonly IntPtr NativeFieldInfoPtr_MIN_VOLUME;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PLAY_MODE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SOUND_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_DatabaseName;

	private static readonly IntPtr NativeFieldInfoPtr_SoundName;

	private static readonly IntPtr NativeFieldInfoPtr_IgnoreListenerPause;

	private static readonly IntPtr NativeFieldInfoPtr_Volume;

	private static readonly IntPtr NativeFieldInfoPtr_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_SpatialBlend;

	private static readonly IntPtr NativeFieldInfoPtr_Loop;

	private static readonly IntPtr NativeFieldInfoPtr_Mode;

	private static readonly IntPtr NativeFieldInfoPtr_ResetSequenceAfterInactiveTime;

	private static readonly IntPtr NativeFieldInfoPtr_SequenceResetTime;

	private static readonly IntPtr NativeFieldInfoPtr_Sounds;

	private static readonly IntPtr NativeFieldInfoPtr_m_lastPlayedSoundsIndex;

	private static readonly IntPtr NativeFieldInfoPtr_m_lastPlayedSoundTime;

	private static readonly IntPtr NativeFieldInfoPtr_m_playedSounds;

	private static readonly IntPtr NativeFieldInfoPtr_m_lastPlayedAudioData;

	private static readonly IntPtr NativeMethodInfoPtr_get_HasMissingAudioClips_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RandomPitch_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RandomVolume_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_AudioClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_SoundyController_Transform_AudioMixerGroup_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_SoundyController_Vector3_AudioMixerGroup_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySoundPreview_Public_Void_AudioSource_AudioMixerGroup_AudioClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySoundPreview_Public_Void_AudioSource_AudioMixerGroup_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopSoundPreview_Public_Void_AudioSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAudioData_Private_AudioData_PlayMode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool DEFAULT_IGNORE_LISTENER_PAUSE
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_IGNORE_LISTENER_PAUSE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_IGNORE_LISTENER_PAUSE, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_LOOP
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_LOOP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_LOOP, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_RESET_SEQUENCE_AFTER_INACTIVE_TIME
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_RESET_SEQUENCE_AFTER_INACTIVE_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_RESET_SEQUENCE_AFTER_INACTIVE_TIME, (void*)(&flag));
		}
	}

	public unsafe static float DEFAULT_PITCH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_PITCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_PITCH, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_SEQUENCE_RESET_TIME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SEQUENCE_RESET_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SEQUENCE_RESET_TIME, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_SPATIAL_BLEND
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SPATIAL_BLEND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SPATIAL_BLEND, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_VOLUME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_VOLUME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_VOLUME, (void*)(&num));
		}
	}

	public unsafe static float MAX_PITCH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_PITCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_PITCH, (void*)(&num));
		}
	}

	public unsafe static float MAX_SPATIAL_BLEND
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_SPATIAL_BLEND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_SPATIAL_BLEND, (void*)(&num));
		}
	}

	public unsafe static float MAX_VOLUME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_VOLUME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_VOLUME, (void*)(&num));
		}
	}

	public unsafe static float MIN_PITCH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_PITCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_PITCH, (void*)(&num));
		}
	}

	public unsafe static float MIN_SPATIAL_BLEND
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_SPATIAL_BLEND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_SPATIAL_BLEND, (void*)(&num));
		}
	}

	public unsafe static float MIN_VOLUME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_VOLUME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_VOLUME, (void*)(&num));
		}
	}

	public unsafe static PlayMode DEFAULT_PLAY_MODE
	{
		get
		{
			Unsafe.SkipInit(out PlayMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_PLAY_MODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_PLAY_MODE, (void*)(&playMode));
		}
	}

	public unsafe static string DEFAULT_SOUND_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SOUND_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SOUND_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DatabaseName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DatabaseName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string SoundName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool IgnoreListenerPause
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreListenerPause);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreListenerPause)) = flag;
		}
	}

	public unsafe RangedFloat Volume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Volume);
			return *(RangedFloat*)num;
		}
		set
		{
			*(RangedFloat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Volume)) = rangedFloat;
		}
	}

	public unsafe RangedFloat Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Pitch);
			return *(RangedFloat*)num;
		}
		set
		{
			*(RangedFloat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Pitch)) = rangedFloat;
		}
	}

	public unsafe float SpatialBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpatialBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpatialBlend)) = num;
		}
	}

	public unsafe bool Loop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Loop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Loop)) = flag;
		}
	}

	public unsafe PlayMode Mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mode);
			return *(PlayMode*)num;
		}
		set
		{
			*(PlayMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mode)) = playMode;
		}
	}

	public unsafe bool ResetSequenceAfterInactiveTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetSequenceAfterInactiveTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResetSequenceAfterInactiveTime)) = flag;
		}
	}

	public unsafe float SequenceResetTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SequenceResetTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SequenceResetTime)) = num;
		}
	}

	public unsafe List<AudioData> Sounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sounds);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int m_lastPlayedSoundsIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastPlayedSoundsIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastPlayedSoundsIndex)) = num;
		}
	}

	public unsafe float m_lastPlayedSoundTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastPlayedSoundTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastPlayedSoundTime)) = num;
		}
	}

	public unsafe List<AudioData> m_playedSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_playedSounds);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_playedSounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AudioData m_lastPlayedAudioData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastPlayedAudioData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastPlayedAudioData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioData));
		}
	}

	public unsafe bool HasMissingAudioClips
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 743399, RefRangeEnd = 743402, XrefRangeStart = 743375, XrefRangeEnd = 743399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasMissingAudioClips_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasSound
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743402, XrefRangeEnd = 743407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float RandomPitch
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 743418, RefRangeEnd = 743420, XrefRangeStart = 743407, XrefRangeEnd = 743418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RandomPitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float RandomVolume
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 743424, RefRangeEnd = 743426, XrefRangeStart = 743420, XrefRangeEnd = 743424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RandomVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static SoundGroupData()
	{
		Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Soundy", "SoundGroupData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_IGNORE_LISTENER_PAUSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_IGNORE_LISTENER_PAUSE");
		NativeFieldInfoPtr_DEFAULT_LOOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_LOOP");
		NativeFieldInfoPtr_DEFAULT_RESET_SEQUENCE_AFTER_INACTIVE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_RESET_SEQUENCE_AFTER_INACTIVE_TIME");
		NativeFieldInfoPtr_DEFAULT_PITCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_PITCH");
		NativeFieldInfoPtr_DEFAULT_SEQUENCE_RESET_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_SEQUENCE_RESET_TIME");
		NativeFieldInfoPtr_DEFAULT_SPATIAL_BLEND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_SPATIAL_BLEND");
		NativeFieldInfoPtr_DEFAULT_VOLUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_VOLUME");
		NativeFieldInfoPtr_MAX_PITCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "MAX_PITCH");
		NativeFieldInfoPtr_MAX_SPATIAL_BLEND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "MAX_SPATIAL_BLEND");
		NativeFieldInfoPtr_MAX_VOLUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "MAX_VOLUME");
		NativeFieldInfoPtr_MIN_PITCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "MIN_PITCH");
		NativeFieldInfoPtr_MIN_SPATIAL_BLEND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "MIN_SPATIAL_BLEND");
		NativeFieldInfoPtr_MIN_VOLUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "MIN_VOLUME");
		NativeFieldInfoPtr_DEFAULT_PLAY_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_PLAY_MODE");
		NativeFieldInfoPtr_DEFAULT_SOUND_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DEFAULT_SOUND_NAME");
		NativeFieldInfoPtr_DatabaseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "DatabaseName");
		NativeFieldInfoPtr_SoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "SoundName");
		NativeFieldInfoPtr_IgnoreListenerPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "IgnoreListenerPause");
		NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "Volume");
		NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "Pitch");
		NativeFieldInfoPtr_SpatialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "SpatialBlend");
		NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "Loop");
		NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "Mode");
		NativeFieldInfoPtr_ResetSequenceAfterInactiveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "ResetSequenceAfterInactiveTime");
		NativeFieldInfoPtr_SequenceResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "SequenceResetTime");
		NativeFieldInfoPtr_Sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "Sounds");
		NativeFieldInfoPtr_m_lastPlayedSoundsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "m_lastPlayedSoundsIndex");
		NativeFieldInfoPtr_m_lastPlayedSoundTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "m_lastPlayedSoundTime");
		NativeFieldInfoPtr_m_playedSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "m_playedSounds");
		NativeFieldInfoPtr_m_lastPlayedAudioData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, "m_lastPlayedAudioData");
		NativeMethodInfoPtr_get_HasMissingAudioClips_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668643);
		NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668644);
		NativeMethodInfoPtr_get_RandomPitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668645);
		NativeMethodInfoPtr_get_RandomVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668646);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668647);
		NativeMethodInfoPtr_Contains_Public_Boolean_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668648);
		NativeMethodInfoPtr_Play_Public_SoundyController_Transform_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668649);
		NativeMethodInfoPtr_Play_Public_SoundyController_Vector3_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668650);
		NativeMethodInfoPtr_PlaySoundPreview_Public_Void_AudioSource_AudioMixerGroup_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668651);
		NativeMethodInfoPtr_PlaySoundPreview_Public_Void_AudioSource_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668652);
		NativeMethodInfoPtr_StopSoundPreview_Public_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668653);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668654);
		NativeMethodInfoPtr_GetAudioData_Private_AudioData_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668655);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr, 100668656);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743426, XrefRangeEnd = 743428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743428, XrefRangeEnd = 743451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(AudioClip audioClip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743451, XrefRangeEnd = 743453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundyController Play(Transform followTarget, AudioMixerGroup outputAudioMixerGroup = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)followTarget);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAudioMixerGroup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_SoundyController_Transform_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 743482, RefRangeEnd = 743486, XrefRangeStart = 743453, XrefRangeEnd = 743482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundyController Play(Vector3 position, AudioMixerGroup outputAudioMixerGroup = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&position);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAudioMixerGroup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_SoundyController_Vector3_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 743515, RefRangeEnd = 743516, XrefRangeStart = 743486, XrefRangeEnd = 743515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySoundPreview(AudioSource audioSource, AudioMixerGroup outputAudioMixerGroup, AudioClip audioClip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAudioMixerGroup);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySoundPreview_Public_Void_AudioSource_AudioMixerGroup_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743516, XrefRangeEnd = 743517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySoundPreview(AudioSource audioSource, AudioMixerGroup outputAudioMixerGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAudioMixerGroup);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySoundPreview_Public_Void_AudioSource_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743517, XrefRangeEnd = 743522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSoundPreview(AudioSource audioSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSoundPreview_Public_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 743526, RefRangeEnd = 743527, XrefRangeStart = 743522, XrefRangeEnd = 743526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDirty(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 743544, RefRangeEnd = 743546, XrefRangeStart = 743527, XrefRangeEnd = 743544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioData GetAudioData(PlayMode playMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&playMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAudioData_Private_AudioData_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743546, XrefRangeEnd = 743557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundGroupData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundGroupData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SoundGroupData(IntPtr pointer)
		: base(pointer)
	{
	}
}
