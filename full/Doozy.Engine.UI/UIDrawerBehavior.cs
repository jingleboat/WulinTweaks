using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Doozy.Engine.UI;

[System.Serializable]
public class UIDrawerBehavior : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DrawerBehaviorType;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnStart;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasAnimatorEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEffect_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasGameEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasUnityEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIDrawerBehaviorType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_UIDrawerBehaviorType_0;

	public unsafe UIDrawerBehaviorType DrawerBehaviorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawerBehaviorType);
			return *(UIDrawerBehaviorType*)num;
		}
		set
		{
			*(UIDrawerBehaviorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawerBehaviorType)) = uIDrawerBehaviorType;
		}
	}

	public unsafe UIAction OnFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAction));
		}
	}

	public unsafe UIAction OnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnStart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnStart)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAction));
		}
	}

	public unsafe bool HasAnimatorEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731146, XrefRangeEnd = 731147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasAnimatorEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasEffect
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731147, XrefRangeEnd = 731148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasEffect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasGameEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731148, XrefRangeEnd = 731149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasGameEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasSound
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731149, XrefRangeEnd = 731150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasUnityEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731150, XrefRangeEnd = 731151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasUnityEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UIDrawerBehavior()
	{
		Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIDrawerBehavior");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr);
		NativeFieldInfoPtr_DrawerBehaviorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, "DrawerBehaviorType");
		NativeFieldInfoPtr_OnFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, "OnFinished");
		NativeFieldInfoPtr_OnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, "OnStart");
		NativeMethodInfoPtr_get_HasAnimatorEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667714);
		NativeMethodInfoPtr_get_HasEffect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667715);
		NativeMethodInfoPtr_get_HasGameEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667716);
		NativeMethodInfoPtr_get_HasSound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667717);
		NativeMethodInfoPtr_get_HasUnityEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667718);
		NativeMethodInfoPtr__ctor_Public_Void_UIDrawerBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667719);
		NativeMethodInfoPtr_Reset_Public_Void_UIDrawerBehaviorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr, 100667720);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 731166, RefRangeEnd = 731169, XrefRangeStart = 731151, XrefRangeEnd = 731166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDrawerBehavior(UIDrawerBehaviorType behaviorType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDrawerBehavior>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&behaviorType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UIDrawerBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731169, XrefRangeEnd = 731176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(UIDrawerBehaviorType behaviorType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&behaviorType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_UIDrawerBehaviorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIDrawerBehavior(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
