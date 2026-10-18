using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class MeditationManager : MonoSingleton<MeditationManager>
{
	private static readonly IntPtr NativeFieldInfoPtr_meditationBeforeStart;

	private static readonly IntPtr NativeFieldInfoPtr_IsMeditating;

	private static readonly IntPtr NativeFieldInfoPtr_playerHeadTexts;

	private static readonly IntPtr NativeFieldInfoPtr_meditationStartTime;

	private static readonly IntPtr NativeFieldInfoPtr_meditationTime;

	private static readonly IntPtr NativeFieldInfoPtr_totalMeditationQuaterPassed;

	private static readonly IntPtr NativeFieldInfoPtr_manualMedition;

	private static readonly IntPtr NativeFieldInfoPtr_autoMedition;

	private static readonly IntPtr NativeFieldInfoPtr_meditationBlockers;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterMeditationBlocker_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnregisterMeditationBlocker_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ManualMeditation_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoMeditation_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopMeditation_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float meditationBeforeStart
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_meditationBeforeStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_meditationBeforeStart, (void*)(&num));
		}
	}

	public unsafe static bool IsMeditating
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsMeditating, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsMeditating, (void*)(&flag));
		}
	}

	public unsafe List<string> playerHeadTexts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeadTexts);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeadTexts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float meditationStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationStartTime)) = num;
		}
	}

	public unsafe float meditationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationTime)) = num;
		}
	}

	public unsafe float totalMeditationQuaterPassed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalMeditationQuaterPassed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalMeditationQuaterPassed)) = num;
		}
	}

	public unsafe int manualMedition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualMedition);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualMedition)) = num;
		}
	}

	public unsafe bool autoMedition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoMedition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoMedition)) = flag;
		}
	}

	public unsafe HashSet<string> meditationBlockers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationBlockers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meditationBlockers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static MeditationManager()
	{
		Il2CppClassPointerStore<MeditationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MeditationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr);
		NativeFieldInfoPtr_meditationBeforeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "meditationBeforeStart");
		NativeFieldInfoPtr_IsMeditating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "IsMeditating");
		NativeFieldInfoPtr_playerHeadTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "playerHeadTexts");
		NativeFieldInfoPtr_meditationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "meditationStartTime");
		NativeFieldInfoPtr_meditationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "meditationTime");
		NativeFieldInfoPtr_totalMeditationQuaterPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "totalMeditationQuaterPassed");
		NativeFieldInfoPtr_manualMedition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "manualMedition");
		NativeFieldInfoPtr_autoMedition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "autoMedition");
		NativeFieldInfoPtr_meditationBlockers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, "meditationBlockers");
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674387);
		NativeMethodInfoPtr_RegisterMeditationBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674388);
		NativeMethodInfoPtr_UnregisterMeditationBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674389);
		NativeMethodInfoPtr_ManualMeditation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674390);
		NativeMethodInfoPtr_DoMeditation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674391);
		NativeMethodInfoPtr_StopMeditation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674392);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr, 100674393);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867284, XrefRangeEnd = 867286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867290, RefRangeEnd = 867291, XrefRangeStart = 867286, XrefRangeEnd = 867290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterMeditationBlocker(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterMeditationBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867295, RefRangeEnd = 867296, XrefRangeStart = 867291, XrefRangeEnd = 867295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterMeditationBlocker(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterMeditationBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 867297, RefRangeEnd = 867300, XrefRangeStart = 867296, XrefRangeEnd = 867297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ManualMeditation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManualMeditation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867428, RefRangeEnd = 867430, XrefRangeStart = 867300, XrefRangeEnd = 867428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoMeditation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoMeditation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867484, RefRangeEnd = 867486, XrefRangeStart = 867430, XrefRangeEnd = 867484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopMeditation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopMeditation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867486, XrefRangeEnd = 867504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeditationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeditationManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MeditationManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
