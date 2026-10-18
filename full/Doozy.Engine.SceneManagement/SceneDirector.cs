using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Progress;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Doozy.Engine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr__ApplicationIsQuitting_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_DebugMode;

	private static readonly IntPtr NativeFieldInfoPtr_OnActiveSceneChanged;

	private static readonly IntPtr NativeFieldInfoPtr_OnSceneLoaded;

	private static readonly IntPtr NativeFieldInfoPtr_OnSceneUnloaded;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SceneDirector_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationIsQuitting_Private_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationIsQuitting_Private_Static_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActiveSceneChanged_Private_Void_Scene_Scene_0;

	private static readonly IntPtr NativeMethodInfoPtr_SceneLoaded_Private_Void_Scene_LoadSceneMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_SceneUnloaded_Private_Void_Scene_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_SceneLoader_Int32_LoadSceneMode_Progressor_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_SceneLoader_String_LoadSceneMode_Progressor_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddToScene_Public_Static_SceneDirector_Boolean_0;

	public unsafe static SceneDirector s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneDirector));
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

	public unsafe bool DebugMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugMode)) = flag;
		}
	}

	public unsafe ActiveSceneChangedEvent OnActiveSceneChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnActiveSceneChanged);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveSceneChangedEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnActiveSceneChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeSceneChangedEvent));
		}
	}

	public unsafe SceneLoadedEvent OnSceneLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSceneLoaded);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SceneLoadedEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSceneLoaded)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneLoadedEvent));
		}
	}

	public unsafe SceneUnloadedEvent OnSceneUnloaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSceneUnloaded);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SceneUnloadedEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSceneUnloaded)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneUnloadedEvent));
		}
	}

	public unsafe static SceneDirector Instance
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 745755, RefRangeEnd = 745769, XrefRangeStart = 745726, XrefRangeEnd = 745755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SceneDirector_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr) : null;
		}
	}

	public unsafe static bool ApplicationIsQuitting
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745769, XrefRangeEnd = 745771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ApplicationIsQuitting_Private_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745771, XrefRangeEnd = 745773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static SceneDirector()
	{
		Il2CppClassPointerStore<SceneDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.SceneManagement", "SceneDirector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr);
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr__ApplicationIsQuitting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<ApplicationIsQuitting>k__BackingField");
		NativeFieldInfoPtr_DebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "DebugMode");
		NativeFieldInfoPtr_OnActiveSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "OnActiveSceneChanged");
		NativeFieldInfoPtr_OnSceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "OnSceneLoaded");
		NativeFieldInfoPtr_OnSceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "OnSceneUnloaded");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668799);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SceneDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668800);
		NativeMethodInfoPtr_get_ApplicationIsQuitting_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668801);
		NativeMethodInfoPtr_set_ApplicationIsQuitting_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668802);
		NativeMethodInfoPtr_get_DebugComponent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668803);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668804);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668805);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668806);
		NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668807);
		NativeMethodInfoPtr_ActiveSceneChanged_Private_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668808);
		NativeMethodInfoPtr_SceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668809);
		NativeMethodInfoPtr_SceneUnloaded_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668810);
		NativeMethodInfoPtr_LoadSceneAsync_Public_Static_SceneLoader_Int32_LoadSceneMode_Progressor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668811);
		NativeMethodInfoPtr_LoadSceneAsync_Public_Static_SceneLoader_String_LoadSceneMode_Progressor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668812);
		NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668813);
		NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668814);
		NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668815);
		NativeMethodInfoPtr_AddToScene_Public_Static_SceneDirector_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100668816);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745709, XrefRangeEnd = 745726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneDirector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745773, XrefRangeEnd = 745804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745804, XrefRangeEnd = 745834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745834, XrefRangeEnd = 745864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745864, XrefRangeEnd = 745866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745866, XrefRangeEnd = 745878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActiveSceneChanged(Scene current, Scene next)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&current);
		*(Scene**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &next;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveSceneChanged_Private_Void_Scene_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745878, XrefRangeEnd = 745893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SceneLoaded(Scene scene, LoadSceneMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&scene);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745893, XrefRangeEnd = 745902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SceneUnloaded(Scene unloadedScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&unloadedScene);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SceneUnloaded_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745902, XrefRangeEnd = 745943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SceneLoader LoadSceneAsync(int sceneBuildIndex, LoadSceneMode loadSceneMode, Progressor progressor = null)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&sceneBuildIndex);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &loadSceneMode;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progressor);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSceneAsync_Public_Static_SceneLoader_Int32_LoadSceneMode_Progressor_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SceneLoader>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745943, XrefRangeEnd = 745983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SceneLoader LoadSceneAsync(string sceneName, LoadSceneMode loadSceneMode, Progressor progressor = null)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &loadSceneMode;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progressor);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSceneAsync_Public_Static_SceneLoader_String_LoadSceneMode_Progressor_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SceneLoader>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745983, XrefRangeEnd = 745995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation UnloadSceneAsync(Scene scene)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&scene);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 746007, RefRangeEnd = 746009, XrefRangeStart = 745995, XrefRangeEnd = 746007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&sceneBuildIndex);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 746021, RefRangeEnd = 746023, XrefRangeStart = 746009, XrefRangeEnd = 746021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation UnloadSceneAsync(string sceneName)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746023, XrefRangeEnd = 746031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SceneDirector AddToScene(bool selectGameObjectAfterCreation = false)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&selectGameObjectAfterCreation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToScene_Public_Static_SceneDirector_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr) : null;
	}

	public SceneDirector(IntPtr pointer)
		: base(pointer)
	{
	}
}
