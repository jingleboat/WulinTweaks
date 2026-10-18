using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Audio;

namespace Doozy.Engine.Soundy;

public class SoundyManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_DATABASE;

	private static readonly IntPtr NativeFieldInfoPtr_GENERAL;

	private static readonly IntPtr NativeFieldInfoPtr_NEW_SOUND_GROUP;

	private static readonly IntPtr NativeFieldInfoPtr_NO_SOUND;

	private static readonly IntPtr NativeFieldInfoPtr_SOUNDS;

	private static readonly IntPtr NativeFieldInfoPtr_SOUNDY;

	private static readonly IntPtr NativeFieldInfoPtr_ApplicationIsQuitting;

	private static readonly IntPtr NativeFieldInfoPtr_s_initialized;

	private static readonly IntPtr NativeFieldInfoPtr_s_pooler;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SoundyManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Pooler_Public_Static_get_SoundyPooler_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Database_Public_Static_get_SoundyDatabase_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddToScene_Public_Static_SoundyManager_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetController_Public_Static_SoundyController_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSoundDatabaseFilename_Public_Static_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_KillAllControllers_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_MuteAllControllers_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_MuteAllSounds_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PauseAllControllers_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PauseAllSounds_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_AudioMixerGroup_Vector3_Single_Single_Boolean_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_AudioMixerGroup_Transform_Single_Single_Boolean_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_SoundyController_SoundyData_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopAllControllers_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopAllSounds_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnmuteAllControllers_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnmuteAllSounds_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnpauseAllControllers_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnpauseAllSounds_Public_Static_Void_0;

	public unsafe static SoundyManager s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundyManager));
		}
	}

	public unsafe static string DATABASE
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DATABASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DATABASE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GENERAL
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GENERAL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GENERAL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEW_SOUND_GROUP
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEW_SOUND_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEW_SOUND_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NO_SOUND
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NO_SOUND, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NO_SOUND, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUNDS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUNDY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUNDY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUNDY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool ApplicationIsQuitting
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ApplicationIsQuitting, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ApplicationIsQuitting, (void*)(&flag));
		}
	}

	public unsafe static bool s_initialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_initialized, (void*)(&flag));
		}
	}

	public unsafe static SoundyPooler s_pooler
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_pooler, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyPooler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_pooler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundyPooler));
		}
	}

	public unsafe static SoundyManager Instance
	{
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 744366, RefRangeEnd = 744420, XrefRangeStart = 744328, XrefRangeEnd = 744366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SoundyManager_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyManager>(intPtr) : null;
		}
	}

	public unsafe static SoundyPooler Pooler
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 744451, RefRangeEnd = 744468, XrefRangeStart = 744420, XrefRangeEnd = 744451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Pooler_Public_Static_get_SoundyPooler_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyPooler>(intPtr) : null;
		}
	}

	public unsafe static SoundyDatabase Database
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744468, XrefRangeEnd = 744469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Database_Public_Static_get_SoundyDatabase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyDatabase>(intPtr) : null;
		}
	}

	public unsafe bool DebugComponent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744469, XrefRangeEnd = 744470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static SoundyManager()
	{
		Il2CppClassPointerStore<SoundyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Soundy", "SoundyManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_DATABASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "DATABASE");
		NativeFieldInfoPtr_GENERAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "GENERAL");
		NativeFieldInfoPtr_NEW_SOUND_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "NEW_SOUND_GROUP");
		NativeFieldInfoPtr_NO_SOUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "NO_SOUND");
		NativeFieldInfoPtr_SOUNDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "SOUNDS");
		NativeFieldInfoPtr_SOUNDY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "SOUNDY");
		NativeFieldInfoPtr_ApplicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "ApplicationIsQuitting");
		NativeFieldInfoPtr_s_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "s_initialized");
		NativeFieldInfoPtr_s_pooler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, "s_pooler");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668726);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SoundyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668727);
		NativeMethodInfoPtr_get_Pooler_Public_Static_get_SoundyPooler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668728);
		NativeMethodInfoPtr_get_Database_Public_Static_get_SoundyDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668729);
		NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668730);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668731);
		NativeMethodInfoPtr_AddToScene_Public_Static_SoundyManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668732);
		NativeMethodInfoPtr_GetController_Public_Static_SoundyController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668733);
		NativeMethodInfoPtr_GetSoundDatabaseFilename_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668734);
		NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668735);
		NativeMethodInfoPtr_KillAllControllers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668736);
		NativeMethodInfoPtr_MuteAllControllers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668737);
		NativeMethodInfoPtr_MuteAllSounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668738);
		NativeMethodInfoPtr_PauseAllControllers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668739);
		NativeMethodInfoPtr_PauseAllSounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668740);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668741);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668742);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668743);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668744);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668745);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668746);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_AudioMixerGroup_Vector3_Single_Single_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668747);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_AudioMixerGroup_Transform_Single_Single_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668748);
		NativeMethodInfoPtr_Play_Public_Static_SoundyController_SoundyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668749);
		NativeMethodInfoPtr_StopAllControllers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668750);
		NativeMethodInfoPtr_StopAllSounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668751);
		NativeMethodInfoPtr_UnmuteAllControllers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668752);
		NativeMethodInfoPtr_UnmuteAllSounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668753);
		NativeMethodInfoPtr_UnpauseAllControllers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668754);
		NativeMethodInfoPtr_UnpauseAllSounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr, 100668755);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundyManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundyManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744470, XrefRangeEnd = 744474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744474, XrefRangeEnd = 744482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyManager AddToScene(bool selectGameObjectAfterCreation = false)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&selectGameObjectAfterCreation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToScene_Public_Static_SoundyManager_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyManager>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744482, XrefRangeEnd = 744486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController GetController()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetController_Public_Static_SoundyController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744486, XrefRangeEnd = 744491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSoundDatabaseFilename(string databaseName)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSoundDatabaseFilename_Public_Static_String_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 744510, RefRangeEnd = 744511, XrefRangeStart = 744491, XrefRangeEnd = 744510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744511, XrefRangeEnd = 744527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void KillAllControllers()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KillAllControllers_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744527, XrefRangeEnd = 744543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MuteAllControllers()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MuteAllControllers_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 744573, RefRangeEnd = 744574, XrefRangeStart = 744543, XrefRangeEnd = 744573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MuteAllSounds()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MuteAllSounds_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744574, XrefRangeEnd = 744590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PauseAllControllers()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseAllControllers_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 744620, RefRangeEnd = 744621, XrefRangeStart = 744590, XrefRangeEnd = 744620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PauseAllSounds()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseAllSounds_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744621, XrefRangeEnd = 744683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(string databaseName, string soundName, Vector3 position)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(soundName);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744683, XrefRangeEnd = 744693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(AudioClip audioClip, Vector3 position)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744693, XrefRangeEnd = 744756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(string databaseName, string soundName, Transform followTarget)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(soundName);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)followTarget);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_Transform_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744756, XrefRangeEnd = 744766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(AudioClip audioClip, Transform followTarget)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)followTarget);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_Transform_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744766, XrefRangeEnd = 744807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(string databaseName, string soundName)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(soundName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_String_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744807, XrefRangeEnd = 744819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(AudioClip audioClip)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 744857, RefRangeEnd = 744858, XrefRangeStart = 744819, XrefRangeEnd = 744857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(AudioClip audioClip, AudioMixerGroup outputAudioMixerGroup, Vector3 position, float volume = 1f, float pitch = 1f, bool loop = false, float spatialBlend = 1f)
	{
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAudioMixerGroup);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &pitch;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &loop;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &spatialBlend;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_AudioMixerGroup_Vector3_Single_Single_Boolean_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 744902, RefRangeEnd = 744904, XrefRangeStart = 744858, XrefRangeEnd = 744902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(AudioClip audioClip, AudioMixerGroup outputAudioMixerGroup, Transform followTarget = null, float volume = 1f, float pitch = 1f, bool loop = false, float spatialBlend = 1f)
	{
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAudioMixerGroup);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)followTarget);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &pitch;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &loop;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &spatialBlend;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_AudioClip_AudioMixerGroup_Transform_Single_Single_Boolean_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 744924, RefRangeEnd = 744926, XrefRangeStart = 744904, XrefRangeEnd = 744924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundyController Play(SoundyData data)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_SoundyController_SoundyData_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SoundyController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744926, XrefRangeEnd = 744942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopAllControllers()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopAllControllers_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 744972, RefRangeEnd = 744973, XrefRangeStart = 744942, XrefRangeEnd = 744972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopAllSounds()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopAllSounds_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744973, XrefRangeEnd = 744989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmuteAllControllers()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmuteAllControllers_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 745019, RefRangeEnd = 745020, XrefRangeStart = 744989, XrefRangeEnd = 745019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmuteAllSounds()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmuteAllSounds_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745020, XrefRangeEnd = 745036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnpauseAllControllers()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpauseAllControllers_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 745066, RefRangeEnd = 745067, XrefRangeStart = 745036, XrefRangeEnd = 745066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnpauseAllSounds()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpauseAllSounds_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SoundyManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
