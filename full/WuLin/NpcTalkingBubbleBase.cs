using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class NpcTalkingBubbleBase : MonoBehaviour
{
	public enum BubbleDir
	{
		RightUp = 0,
		LeftUp = 1,
		RightDown = 2,
		LeftDown = 3,
		DependNpcDown = 4,
		DependNpcUp = 5,
		Unknown = 10
	}

	public enum ScreeZone
	{
		ZoneL1R1,
		ZoneL1R2,
		ZoneL1R3,
		ZoneL1R4,
		ZoneL2R1,
		ZoneL2R2,
		ZoneL2R3,
		ZoneL2R4,
		ZoneL3R1,
		ZoneL3R2,
		ZoneL3R3,
		ZoneL3R4
	}

	private static readonly IntPtr NativeFieldInfoPtr_screenZoneToBubbleDir;

	private static readonly IntPtr NativeFieldInfoPtr_cachedAdapator;

	private static readonly IntPtr NativeFieldInfoPtr_cachedDir;

	private static readonly IntPtr NativeMethodInfoPtr_get_CachedDir_Public_get_BubbleDir_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_ActorViewElemenetAdapator_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateDir_Protected_Virtual_New_BubbleDir_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDir_Protected_Virtual_New_Void_BubbleDir_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DestroySelf_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Dictionary<ScreeZone, BubbleDir> screenZoneToBubbleDir
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_screenZoneToBubbleDir, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ScreeZone, BubbleDir>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_screenZoneToBubbleDir, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe ActorViewElemenetAdapator cachedAdapator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedAdapator);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActorViewElemenetAdapator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedAdapator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorViewElemenetAdapator));
		}
	}

	public unsafe BubbleDir cachedDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDir);
			return *(BubbleDir*)num;
		}
		set
		{
			*(BubbleDir*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDir)) = bubbleDir;
		}
	}

	public unsafe BubbleDir CachedDir
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CachedDir_Public_get_BubbleDir_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(BubbleDir*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static NpcTalkingBubbleBase()
	{
		Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "NpcTalkingBubbleBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr);
		NativeFieldInfoPtr_screenZoneToBubbleDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, "screenZoneToBubbleDir");
		NativeFieldInfoPtr_cachedAdapator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, "cachedAdapator");
		NativeFieldInfoPtr_cachedDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, "cachedDir");
		NativeMethodInfoPtr_get_CachedDir_Public_get_BubbleDir_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675890);
		NativeMethodInfoPtr_Init_Public_Void_ActorViewElemenetAdapator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675891);
		NativeMethodInfoPtr_CalculateDir_Protected_Virtual_New_BubbleDir_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675892);
		NativeMethodInfoPtr_SetDir_Protected_Virtual_New_Void_BubbleDir_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675893);
		NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675894);
		NativeMethodInfoPtr_DestroySelf_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675895);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr, 100675896);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 909809, RefRangeEnd = 909811, XrefRangeStart = 909759, XrefRangeEnd = 909809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(ActorViewElemenetAdapator adapator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adapator);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_ActorViewElemenetAdapator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 909811, XrefRangeEnd = 909833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual BubbleDir CalculateDir()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculateDir_Protected_Virtual_New_BubbleDir_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(BubbleDir*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 909833, XrefRangeEnd = 909842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetDir(BubbleDir dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&dir);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetDir_Protected_Virtual_New_Void_BubbleDir_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 909862, RefRangeEnd = 909864, XrefRangeStart = 909842, XrefRangeEnd = 909862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 909864, XrefRangeEnd = 909869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DestroySelf()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DestroySelf_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 671194, RefRangeEnd = 671195, XrefRangeStart = 671194, XrefRangeEnd = 671195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcTalkingBubbleBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcTalkingBubbleBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NpcTalkingBubbleBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
