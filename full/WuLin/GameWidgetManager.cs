using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class GameWidgetManager : SerializedMonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	private static readonly IntPtr NativeFieldInfoPtr_blackMask;

	private static readonly IntPtr NativeFieldInfoPtr_widgetViews;

	private static readonly IntPtr NativeFieldInfoPtr_testCreateWidgetType;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateWidget_Public_UIView_GameWidgetType_0;

	private static readonly IntPtr NativeMethodInfoPtr_CallBlackMask_Public_UIView_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_TestCreateWidget_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static GameWidgetManager instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<GameWidgetManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameWidgetManager));
		}
	}

	public unsafe UIView blackMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackMask);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackMask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIView));
		}
	}

	public unsafe Dictionary<GameWidgetType, UIView> widgetViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_widgetViews);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameWidgetType, UIView>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_widgetViews)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameWidgetType testCreateWidgetType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testCreateWidgetType);
			return *(GameWidgetType*)num;
		}
		set
		{
			*(GameWidgetType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testCreateWidgetType)) = gameWidgetType;
		}
	}

	static GameWidgetManager()
	{
		Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameWidgetManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_blackMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, "blackMask");
		NativeFieldInfoPtr_widgetViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, "widgetViews");
		NativeFieldInfoPtr_testCreateWidgetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, "testCreateWidgetType");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, 100671845);
		NativeMethodInfoPtr_CreateWidget_Public_UIView_GameWidgetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, 100671846);
		NativeMethodInfoPtr_CallBlackMask_Public_UIView_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, 100671847);
		NativeMethodInfoPtr_TestCreateWidget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, 100671848);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr, 100671849);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794023, XrefRangeEnd = 794025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794053, RefRangeEnd = 794054, XrefRangeStart = 794025, XrefRangeEnd = 794053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIView CreateWidget(GameWidgetType key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWidget_Public_UIView_GameWidgetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIView>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794068, RefRangeEnd = 794069, XrefRangeStart = 794054, XrefRangeEnd = 794068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIView CallBlackMask(Transform tf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tf);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallBlackMask_Public_UIView_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIView>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794069, XrefRangeEnd = 794070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestCreateWidget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestCreateWidget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794070, XrefRangeEnd = 794077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameWidgetManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameWidgetManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameWidgetManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
