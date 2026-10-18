using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WuLin;

public class UIRoot : MonoSingleton<UIRoot>
{
	public enum GameUiLayer
	{
		BeforeInGameUi = 0,
		AfterInGameUi = 1,
		Normal = 2,
		Window = 3,
		ToolTip = 4,
		Overlay = 5,
		ScenarioSkip = 6,
		SubPanel = 100
	}

	private static readonly IntPtr NativeFieldInfoPtr_rootCanvas;

	private static readonly IntPtr NativeFieldInfoPtr_canvasScaler;

	private static readonly IntPtr NativeFieldInfoPtr_rawImage;

	private static readonly IntPtr NativeFieldInfoPtr_VersionText;

	private static readonly IntPtr NativeFieldInfoPtr__layerRoots_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionRatio;

	private static readonly IntPtr NativeFieldInfoPtr_SAFE_AREA_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_m_SaveAreaFactor;

	private static readonly IntPtr NativeMethodInfoPtr_get_layerRoots_Public_get_Dictionary_2_GameUiLayer_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_layerRoots_Private_set_Void_Dictionary_2_GameUiLayer_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SafeAreaFactor_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetUiScaler_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRoot_Public_Transform_GameUiLayer_0;

	private static readonly IntPtr NativeMethodInfoPtr_AttachToRoot_Public_Void_GameUiLayer_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetRenderTexture_Public_Void_Texture_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Canvas rootCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootCanvas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootCanvas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas));
		}
	}

	public unsafe CanvasScaler canvasScaler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvasScaler);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvasScaler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasScaler));
		}
	}

	public unsafe RawImage rawImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawImage));
		}
	}

	public unsafe TextMeshProUGUI VersionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Dictionary<GameUiLayer, Transform> _layerRoots_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layerRoots_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameUiLayer, Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layerRoots_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float m_resolutionRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_resolutionRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_resolutionRatio)) = num;
		}
	}

	public unsafe static float SAFE_AREA_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAFE_AREA_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAFE_AREA_SIZE, (void*)(&num));
		}
	}

	public unsafe static float m_SaveAreaFactor
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_SaveAreaFactor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_SaveAreaFactor, (void*)(&num));
		}
	}

	public unsafe Dictionary<GameUiLayer, Transform> layerRoots
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layerRoots_Public_get_Dictionary_2_GameUiLayer_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameUiLayer, Transform>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_layerRoots_Private_set_Void_Dictionary_2_GameUiLayer_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static float SafeAreaFactor
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 252868, RefRangeEnd = 252872, XrefRangeStart = 252868, XrefRangeEnd = 252872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SafeAreaFactor_Public_Static_get_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UIRoot()
	{
		Il2CppClassPointerStore<UIRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UIRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRoot>.NativeClassPtr);
		NativeFieldInfoPtr_rootCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "rootCanvas");
		NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "canvasScaler");
		NativeFieldInfoPtr_rawImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "rawImage");
		NativeFieldInfoPtr_VersionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "VersionText");
		NativeFieldInfoPtr__layerRoots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "<layerRoots>k__BackingField");
		NativeFieldInfoPtr_m_resolutionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "m_resolutionRatio");
		NativeFieldInfoPtr_SAFE_AREA_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "SAFE_AREA_SIZE");
		NativeFieldInfoPtr_m_SaveAreaFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "m_SaveAreaFactor");
		NativeMethodInfoPtr_get_layerRoots_Public_get_Dictionary_2_GameUiLayer_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674070);
		NativeMethodInfoPtr_set_layerRoots_Private_set_Void_Dictionary_2_GameUiLayer_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674071);
		NativeMethodInfoPtr_get_SafeAreaFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674072);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674073);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674074);
		NativeMethodInfoPtr_SetUiScaler_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674075);
		NativeMethodInfoPtr_GetRoot_Public_Transform_GameUiLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674076);
		NativeMethodInfoPtr_AttachToRoot_Public_Void_GameUiLayer_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674077);
		NativeMethodInfoPtr_SetRenderTexture_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674078);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100674079);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860264, XrefRangeEnd = 860296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860296, XrefRangeEnd = 860303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUiScaler()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUiScaler_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860309, RefRangeEnd = 860310, XrefRangeStart = 860303, XrefRangeEnd = 860309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetRoot(GameUiLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&layer);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoot_Public_Transform_GameUiLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860318, RefRangeEnd = 860319, XrefRangeStart = 860310, XrefRangeEnd = 860318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AttachToRoot(GameUiLayer layer, Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&layer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttachToRoot_Public_Void_GameUiLayer_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860326, RefRangeEnd = 860328, XrefRangeStart = 860319, XrefRangeEnd = 860326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRenderTexture(Texture rt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTexture_Public_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860328, XrefRangeEnd = 860334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRoot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIRoot(IntPtr pointer)
		: base(pointer)
	{
	}
}
