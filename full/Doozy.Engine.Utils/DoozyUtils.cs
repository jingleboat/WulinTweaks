using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Engine.Utils;

public static class DoozyUtils : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_AddToScene_Public_Static_T_String_Boolean_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddToScene_Public_Static_T_String_Boolean_Boolean_0, Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_BACKGROUND;

	private static readonly System.IntPtr NativeFieldInfoPtr_OVERLAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CheckmarkColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverlayColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_FONT_SIZE;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddImageToGameObject_Public_Static_Image_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameObjectWithAnImageComponent_Public_Static_GameObject_String_Color_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBackgroundImage_Public_Static_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOverlayImage_Public_Static_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToScene_Public_Static_T_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObjectToAsset_Public_Static_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayDialog_Public_Static_Boolean_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayDialog_Public_Static_Boolean_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayProgressBar_Public_Static_Void_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayCancelableProgressBar_Public_Static_Boolean_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearProgressBar_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveAssetToTrash_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveAssets_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UndoRecordObject_Public_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UndoRecordObject_Public_Static_Void_Object_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UndoRecordObjects_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UndoRecordObjects_Public_Static_Void_Il2CppReferenceArray_1_Object_String_Boolean_0;

	public unsafe static string BACKGROUND
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BACKGROUND, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BACKGROUND, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OVERLAY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OVERLAY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OVERLAY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Color BackgroundColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BackgroundColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BackgroundColor, (void*)(&color));
		}
	}

	public unsafe static Color CheckmarkColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CheckmarkColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CheckmarkColor, (void*)(&color));
		}
	}

	public unsafe static Color OverlayColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OverlayColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OverlayColor, (void*)(&color));
		}
	}

	public unsafe static Color TextColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextColor, (void*)(&color));
		}
	}

	public unsafe static int TEXT_FONT_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_FONT_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_FONT_SIZE, (void*)(&num));
		}
	}

	static DoozyUtils()
	{
		Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils", "DoozyUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr);
		NativeFieldInfoPtr_BACKGROUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "BACKGROUND");
		NativeFieldInfoPtr_OVERLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "OVERLAY");
		NativeFieldInfoPtr_BackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "BackgroundColor");
		NativeFieldInfoPtr_CheckmarkColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "CheckmarkColor");
		NativeFieldInfoPtr_OverlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "OverlayColor");
		NativeFieldInfoPtr_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "TextColor");
		NativeFieldInfoPtr_TEXT_FONT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, "TEXT_FONT_SIZE");
		NativeMethodInfoPtr_AddImageToGameObject_Public_Static_Image_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_CreateGameObjectWithAnImageComponent_Public_Static_GameObject_String_Color_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667378);
		NativeMethodInfoPtr_CreateBackgroundImage_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667379);
		NativeMethodInfoPtr_CreateOverlayImage_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667380);
		NativeMethodInfoPtr_AddToScene_Public_Static_T_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667381);
		NativeMethodInfoPtr_AddObjectToAsset_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667382);
		NativeMethodInfoPtr_DisplayDialog_Public_Static_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667383);
		NativeMethodInfoPtr_DisplayDialog_Public_Static_Boolean_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667384);
		NativeMethodInfoPtr_DisplayProgressBar_Public_Static_Void_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667385);
		NativeMethodInfoPtr_DisplayCancelableProgressBar_Public_Static_Boolean_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667386);
		NativeMethodInfoPtr_ClearProgressBar_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667387);
		NativeMethodInfoPtr_MoveAssetToTrash_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667388);
		NativeMethodInfoPtr_SaveAssets_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667389);
		NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667390);
		NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667391);
		NativeMethodInfoPtr_UndoRecordObject_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667392);
		NativeMethodInfoPtr_UndoRecordObject_Public_Static_Void_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667393);
		NativeMethodInfoPtr_UndoRecordObjects_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667394);
		NativeMethodInfoPtr_UndoRecordObjects_Public_Static_Void_Il2CppReferenceArray_1_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoozyUtils>.NativeClassPtr, 100667395);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726135, XrefRangeEnd = 726145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image AddImageToGameObject(GameObject target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddImageToGameObject_Public_Static_Image_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726183, RefRangeEnd = 726185, XrefRangeStart = 726145, XrefRangeEnd = 726183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateGameObjectWithAnImageComponent(string objectName, Color color, GameObject parent = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGameObjectWithAnImageComponent_Public_Static_GameObject_String_Color_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726185, XrefRangeEnd = 726192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateBackgroundImage(GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBackgroundImage_Public_Static_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726192, XrefRangeEnd = 726199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateOverlayImage(GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateOverlayImage_Public_Static_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 726217, RefRangeEnd = 726246, XrefRangeStart = 726199, XrefRangeEnd = 726217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddToScene<T>(string gameObjectName, bool isSingleton, bool selectGameObjectAfterCreation = false) where T : MonoBehaviour
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSingleton;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectGameObjectAfterCreation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddToScene_Public_Static_T_String_Boolean_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToAdd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assetObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObjectToAsset_Public_Static_Void_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DisplayDialog(string title, string message, string ok)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ok);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayDialog_Public_Static_Boolean_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DisplayDialog(string title, string message, string ok, string cancel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ok);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cancel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayDialog_Public_Static_Boolean_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisplayProgressBar(string title, string info, float progress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(info);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayProgressBar_Public_Static_Void_String_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DisplayCancelableProgressBar(string title, string info, float progress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(info);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayCancelableProgressBar_Public_Static_Boolean_String_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearProgressBar()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearProgressBar_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MoveAssetToTrash(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveAssetToTrash_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveAssets()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAssets_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726246, XrefRangeEnd = 726250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDirty(UnityEngine.Object target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(75)]
	[CachedScanResults(RefRangeStart = 726278, RefRangeEnd = 726353, XrefRangeStart = 726250, XrefRangeEnd = 726278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDirty(UnityEngine.Object target, bool saveAssets)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveAssets;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 726357, RefRangeEnd = 726387, XrefRangeStart = 726353, XrefRangeEnd = 726357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UndoRecordObject(UnityEngine.Object objectToUndo, string undoMessage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToUndo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecordObject_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726387, XrefRangeEnd = 726400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UndoRecordObject(UnityEngine.Object objectToUndo, string undoMessage, bool saveAssets)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToUndo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveAssets;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecordObject_Public_Static_Void_Object_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UndoRecordObjects(Il2CppReferenceArray<UnityEngine.Object> objectsToUndo, string undoMessage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectsToUndo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecordObjects_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726400, XrefRangeEnd = 726405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UndoRecordObjects(Il2CppReferenceArray<UnityEngine.Object> objectsToUndo, string undoMessage, bool saveAssets)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectsToUndo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveAssets;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecordObjects_Public_Static_Void_Il2CppReferenceArray_1_Object_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoozyUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
