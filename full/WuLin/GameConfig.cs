using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace WuLin;

public class GameConfig : MonoSingleton<GameConfig>
{
	private sealed class MethodInfoStoreGeneric_GetGameData_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetGameData_Public_Static_T_0, Il2CppClassPointerStore<GameConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_multiProposeSpriteMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteMaterialWithStencil;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIGreyMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_UISelectingMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_TwinkleShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_forbiddenWords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_globalCharacterPropModify;

	private static readonly System.IntPtr NativeFieldInfoPtr_forbiddenWordAssets;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpriteLitMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaskableSpriteLitMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_actorDodgrFriendCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_FontAssetInfoDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_MajorVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinorVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuildTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMaxBattleRandomCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BgmConfig_Public_get_BgmConfigScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterPoolDataScriptObject_Public_get_CharacterPoolDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterNamePoolDataScriptObject_Public_get_CharacterNamePoolDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KungfuDataScriptObject_Public_get_KungfuDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KungfuLevelDataScriptObject_Public_get_KungfuLevelDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KungfuExpDataScriptObject_Public_get_KungfuExpDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KungfuMoveDataScriptObject_Public_get_KungfuMoveDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GlobalCharacterPropModify_Public_get_Dictionary_2_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BuffDataScriptObject_Public_get_BuffDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemDataScriptObject_Public_get_ItemDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemRarityDataScriptObject_Public_get_ItemRarityDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterExpDataScriptObject_Public_get_CharacterExpDataScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasConfigValue_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigValue_Public_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigStr_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigStrArray_Public_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigDecimalValuesFromStr_Public_Il2CppStructArray_1_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameData_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForbiddenWords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFont_Public_FontAssetInfo_FontType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFullVersion_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Material multiProposeSpriteMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiProposeSpriteMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiProposeSpriteMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material spriteMaterialWithStencil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteMaterialWithStencil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteMaterialWithStencil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material UIGreyMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIGreyMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIGreyMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material UISelectingMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UISelectingMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UISelectingMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material TwinkleShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TwinkleShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TwinkleShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe List<string> forbiddenWords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenWords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenWords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, int> m_globalCharacterPropModify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_globalCharacterPropModify);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_globalCharacterPropModify)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppReferenceArray<TextAsset> forbiddenWordAssets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenWordAssets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenWordAssets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Material SpriteLitMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpriteLitMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpriteLitMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material MaskableSpriteLitMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskableSpriteLitMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskableSpriteLitMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe AnimationCurve actorDodgrFriendCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorDodgrFriendCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorDodgrFriendCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Dictionary<FontFileType, Dictionary<FontType, FontAssetInfo>> FontAssetInfoDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FontAssetInfoDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<FontFileType, Dictionary<FontType, FontAssetInfo>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FontAssetInfoDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe string MajorVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MajorVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MajorVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string MinorVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinorVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinorVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string BuildTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildTime);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildTime)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int mMaxBattleRandomCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMaxBattleRandomCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMaxBattleRandomCount)) = num;
		}
	}

	public unsafe BgmConfigScriptObject BgmConfig
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 813483, RefRangeEnd = 813485, XrefRangeStart = 813477, XrefRangeEnd = 813483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BgmConfig_Public_get_BgmConfigScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BgmConfigScriptObject>(intPtr) : null;
		}
	}

	public unsafe CharacterPoolDataScriptObject CharacterPoolDataScriptObject
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 813491, RefRangeEnd = 813492, XrefRangeStart = 813485, XrefRangeEnd = 813491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharacterPoolDataScriptObject_Public_get_CharacterPoolDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterPoolDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe CharacterNamePoolDataScriptObject CharacterNamePoolDataScriptObject
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 813498, RefRangeEnd = 813502, XrefRangeStart = 813492, XrefRangeEnd = 813498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharacterNamePoolDataScriptObject_Public_get_CharacterNamePoolDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterNamePoolDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe KungfuDataScriptObject KungfuDataScriptObject
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 813508, RefRangeEnd = 813520, XrefRangeStart = 813502, XrefRangeEnd = 813508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KungfuDataScriptObject_Public_get_KungfuDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe KungfuLevelDataScriptObject KungfuLevelDataScriptObject
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 813526, RefRangeEnd = 813547, XrefRangeStart = 813520, XrefRangeEnd = 813526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KungfuLevelDataScriptObject_Public_get_KungfuLevelDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuLevelDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe KungfuExpDataScriptObject KungfuExpDataScriptObject
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 813553, RefRangeEnd = 813554, XrefRangeStart = 813547, XrefRangeEnd = 813553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KungfuExpDataScriptObject_Public_get_KungfuExpDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuExpDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe KungfuMoveDataScriptObject KungfuMoveDataScriptObject
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 813560, RefRangeEnd = 813562, XrefRangeStart = 813554, XrefRangeEnd = 813560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KungfuMoveDataScriptObject_Public_get_KungfuMoveDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuMoveDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe Dictionary<string, int> GlobalCharacterPropModify
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GlobalCharacterPropModify_Public_get_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
	}

	public unsafe BuffDataScriptObject BuffDataScriptObject
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 813568, RefRangeEnd = 813573, XrefRangeStart = 813562, XrefRangeEnd = 813568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BuffDataScriptObject_Public_get_BuffDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe ItemDataScriptObject ItemDataScriptObject
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 813579, RefRangeEnd = 813582, XrefRangeStart = 813573, XrefRangeEnd = 813579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemDataScriptObject_Public_get_ItemDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe ItemRarityDataScriptObject ItemRarityDataScriptObject
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813582, XrefRangeEnd = 813588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemRarityDataScriptObject_Public_get_ItemRarityDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemRarityDataScriptObject>(intPtr) : null;
		}
	}

	public unsafe CharacterExpDataScriptObject CharacterExpDataScriptObject
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 813594, RefRangeEnd = 813598, XrefRangeStart = 813588, XrefRangeEnd = 813594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharacterExpDataScriptObject_Public_get_CharacterExpDataScriptObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterExpDataScriptObject>(intPtr) : null;
		}
	}

	static GameConfig()
	{
		Il2CppClassPointerStore<GameConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConfig>.NativeClassPtr);
		NativeFieldInfoPtr_multiProposeSpriteMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "multiProposeSpriteMaterial");
		NativeFieldInfoPtr_spriteMaterialWithStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "spriteMaterialWithStencil");
		NativeFieldInfoPtr_UIGreyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "UIGreyMaterial");
		NativeFieldInfoPtr_UISelectingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "UISelectingMaterial");
		NativeFieldInfoPtr_TwinkleShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "TwinkleShader");
		NativeFieldInfoPtr_forbiddenWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "forbiddenWords");
		NativeFieldInfoPtr_m_globalCharacterPropModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "m_globalCharacterPropModify");
		NativeFieldInfoPtr_forbiddenWordAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "forbiddenWordAssets");
		NativeFieldInfoPtr_SpriteLitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "SpriteLitMaterial");
		NativeFieldInfoPtr_MaskableSpriteLitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "MaskableSpriteLitMaterial");
		NativeFieldInfoPtr_actorDodgrFriendCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "actorDodgrFriendCurve");
		NativeFieldInfoPtr_FontAssetInfoDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "FontAssetInfoDict");
		NativeFieldInfoPtr_MajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "MajorVersion");
		NativeFieldInfoPtr_MinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "MinorVersion");
		NativeFieldInfoPtr_BuildTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "BuildTime");
		NativeFieldInfoPtr_mMaxBattleRandomCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "mMaxBattleRandomCount");
		NativeMethodInfoPtr_get_BgmConfig_Public_get_BgmConfigScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672515);
		NativeMethodInfoPtr_get_CharacterPoolDataScriptObject_Public_get_CharacterPoolDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672516);
		NativeMethodInfoPtr_get_CharacterNamePoolDataScriptObject_Public_get_CharacterNamePoolDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672517);
		NativeMethodInfoPtr_get_KungfuDataScriptObject_Public_get_KungfuDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672518);
		NativeMethodInfoPtr_get_KungfuLevelDataScriptObject_Public_get_KungfuLevelDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672519);
		NativeMethodInfoPtr_get_KungfuExpDataScriptObject_Public_get_KungfuExpDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672520);
		NativeMethodInfoPtr_get_KungfuMoveDataScriptObject_Public_get_KungfuMoveDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672521);
		NativeMethodInfoPtr_get_GlobalCharacterPropModify_Public_get_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672522);
		NativeMethodInfoPtr_get_BuffDataScriptObject_Public_get_BuffDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672523);
		NativeMethodInfoPtr_get_ItemDataScriptObject_Public_get_ItemDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672524);
		NativeMethodInfoPtr_get_ItemRarityDataScriptObject_Public_get_ItemRarityDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672525);
		NativeMethodInfoPtr_get_CharacterExpDataScriptObject_Public_get_CharacterExpDataScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672526);
		NativeMethodInfoPtr_HasConfigValue_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672527);
		NativeMethodInfoPtr_GetConfigValue_Public_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672528);
		NativeMethodInfoPtr_GetConfigStr_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672529);
		NativeMethodInfoPtr_GetConfigStrArray_Public_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672530);
		NativeMethodInfoPtr_GetConfigDecimalValuesFromStr_Public_Il2CppStructArray_1_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672531);
		NativeMethodInfoPtr_GetGameData_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672532);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672533);
		NativeMethodInfoPtr_PrepareForbiddenWords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672534);
		NativeMethodInfoPtr_GetFont_Public_FontAssetInfo_FontType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672535);
		NativeMethodInfoPtr_GetFullVersion_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672536);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100672537);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 813605, RefRangeEnd = 813607, XrefRangeStart = 813598, XrefRangeEnd = 813605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasConfigValue(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasConfigValue_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(258)]
	[CachedScanResults(RefRangeStart = 813622, RefRangeEnd = 813880, XrefRangeStart = 813607, XrefRangeEnd = 813622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetConfigValue(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigValue_Public_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 813888, RefRangeEnd = 813916, XrefRangeStart = 813880, XrefRangeEnd = 813888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetConfigStr(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigStr_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 813934, RefRangeEnd = 813967, XrefRangeStart = 813916, XrefRangeEnd = 813934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetConfigStrArray(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigStrArray_Public_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 813987, RefRangeEnd = 813997, XrefRangeStart = 813967, XrefRangeEnd = 813987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> GetConfigDecimalValuesFromStr(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigDecimalValuesFromStr_Public_Il2CppStructArray_1_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813997, XrefRangeEnd = 814000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetGameData<T>() where T : BaseDataClass
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetGameData_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 814000, XrefRangeEnd = 814078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 814078, XrefRangeEnd = 814092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForbiddenWords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForbiddenWords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 814113, RefRangeEnd = 814115, XrefRangeStart = 814092, XrefRangeEnd = 814113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FontAssetInfo GetFont(FontType fontType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fontType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFont_Public_FontAssetInfo_FontType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAssetInfo>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 814127, RefRangeEnd = 814134, XrefRangeStart = 814115, XrefRangeEnd = 814127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFullVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFullVersion_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 814134, XrefRangeEnd = 814167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameConfig>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
