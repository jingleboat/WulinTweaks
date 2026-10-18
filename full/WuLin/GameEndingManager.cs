using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class GameEndingManager : MonoSingleton<GameEndingManager>
{
	private static readonly System.IntPtr NativeFieldInfoPtr__AutoBackToMenu_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AutoBackToMenuWaitTime_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__EndingTimer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_EndFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr__EndingPics_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__EndingDescs_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextEndingIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastShowPic;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AutoBackToMenu_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AutoBackToMenu_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AutoBackToMenuWaitTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AutoBackToMenuWaitTime_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EndingTimer_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EndingTimer_Private_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EndingPics_Public_get_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EndingPics_Private_set_Void_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EndingDescs_Public_get_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EndingDescs_Private_set_Void_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopEndingPlaying_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnding_Public_Void_List_1_KeyValuePair_2_String_Single_List_1_KeyValuePair_2_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEndingPic_Public_Void_List_1_KeyValuePair_2_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEndingDesc_Public_Void_List_1_KeyValuePair_2_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PicEndTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DescEndTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CouldSkipCurEnding_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUiClick_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentPicHasFadeIn_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentPicHasFadeOut_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _AutoBackToMenu_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AutoBackToMenu_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AutoBackToMenu_k__BackingField)) = flag;
		}
	}

	public unsafe float _AutoBackToMenuWaitTime_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AutoBackToMenuWaitTime_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AutoBackToMenuWaitTime_k__BackingField)) = num;
		}
	}

	public unsafe double _EndingTimer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndingTimer_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndingTimer_k__BackingField)) = num;
		}
	}

	public unsafe Il2CppSystem.Action EndFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe List<KeyValuePair<KeyValuePair<string, float>, float>> _EndingPics_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndingPics_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyValuePair<KeyValuePair<string, float>, float>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndingPics_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<KeyValuePair<KeyValuePair<string, float>, float>> _EndingDescs_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndingDescs_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyValuePair<KeyValuePair<string, float>, float>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndingDescs_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int nextEndingIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextEndingIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextEndingIndex)) = num;
		}
	}

	public unsafe string lastShowPic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastShowPic);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastShowPic)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool AutoBackToMenu
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AutoBackToMenu_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AutoBackToMenu_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float AutoBackToMenuWaitTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AutoBackToMenuWaitTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AutoBackToMenuWaitTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe double EndingTimer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EndingTimer_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EndingTimer_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<KeyValuePair<KeyValuePair<string, float>, float>> EndingPics
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18873, RefRangeEnd = 18874, XrefRangeStart = 18873, XrefRangeEnd = 18874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EndingPics_Public_get_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyValuePair<KeyValuePair<string, float>, float>>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EndingPics_Private_set_Void_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<KeyValuePair<KeyValuePair<string, float>, float>> EndingDescs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EndingDescs_Public_get_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyValuePair<KeyValuePair<string, float>, float>>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EndingDescs_Private_set_Void_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GameEndingManager()
	{
		Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameEndingManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr);
		NativeFieldInfoPtr__AutoBackToMenu_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "<AutoBackToMenu>k__BackingField");
		NativeFieldInfoPtr__AutoBackToMenuWaitTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "<AutoBackToMenuWaitTime>k__BackingField");
		NativeFieldInfoPtr__EndingTimer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "<EndingTimer>k__BackingField");
		NativeFieldInfoPtr_EndFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "EndFunc");
		NativeFieldInfoPtr__EndingPics_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "<EndingPics>k__BackingField");
		NativeFieldInfoPtr__EndingDescs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "<EndingDescs>k__BackingField");
		NativeFieldInfoPtr_nextEndingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "nextEndingIndex");
		NativeFieldInfoPtr_lastShowPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, "lastShowPic");
		NativeMethodInfoPtr_get_AutoBackToMenu_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671861);
		NativeMethodInfoPtr_set_AutoBackToMenu_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671862);
		NativeMethodInfoPtr_get_AutoBackToMenuWaitTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671863);
		NativeMethodInfoPtr_set_AutoBackToMenuWaitTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671864);
		NativeMethodInfoPtr_get_EndingTimer_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671865);
		NativeMethodInfoPtr_set_EndingTimer_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671866);
		NativeMethodInfoPtr_get_EndingPics_Public_get_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671867);
		NativeMethodInfoPtr_set_EndingPics_Private_set_Void_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671868);
		NativeMethodInfoPtr_get_EndingDescs_Public_get_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671869);
		NativeMethodInfoPtr_set_EndingDescs_Private_set_Void_List_1_KeyValuePair_2_KeyValuePair_2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671870);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671871);
		NativeMethodInfoPtr_StopEndingPlaying_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671872);
		NativeMethodInfoPtr_SetEnding_Public_Void_List_1_KeyValuePair_2_String_Single_List_1_KeyValuePair_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671873);
		NativeMethodInfoPtr_SetEndingPic_Public_Void_List_1_KeyValuePair_2_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671874);
		NativeMethodInfoPtr_SetEndingDesc_Public_Void_List_1_KeyValuePair_2_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671875);
		NativeMethodInfoPtr_PicEndTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671876);
		NativeMethodInfoPtr_DescEndTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671877);
		NativeMethodInfoPtr_CouldSkipCurEnding_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671878);
		NativeMethodInfoPtr_OnUiClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671879);
		NativeMethodInfoPtr_CurrentPicHasFadeIn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671880);
		NativeMethodInfoPtr_CurrentPicHasFadeOut_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671881);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr, 100671882);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794159, RefRangeEnd = 794160, XrefRangeStart = 794138, XrefRangeEnd = 794159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794172, RefRangeEnd = 794173, XrefRangeStart = 794160, XrefRangeEnd = 794172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopEndingPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopEndingPlaying_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794298, RefRangeEnd = 794300, XrefRangeStart = 794173, XrefRangeEnd = 794298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnding(List<KeyValuePair<string, float>> _picsList, List<KeyValuePair<string, float>> _descsList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_picsList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_descsList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnding_Public_Void_List_1_KeyValuePair_2_String_Single_List_1_KeyValuePair_2_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794339, RefRangeEnd = 794340, XrefRangeStart = 794300, XrefRangeEnd = 794339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEndingPic(List<KeyValuePair<string, float>> picsList, bool showInstantly = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)picsList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInstantly;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEndingPic_Public_Void_List_1_KeyValuePair_2_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794379, RefRangeEnd = 794380, XrefRangeStart = 794340, XrefRangeEnd = 794379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEndingDesc(List<KeyValuePair<string, float>> descsList, bool showInstantly = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)descsList);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showInstantly;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEndingDesc_Public_Void_List_1_KeyValuePair_2_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794387, RefRangeEnd = 794390, XrefRangeStart = 794380, XrefRangeEnd = 794387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float PicEndTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PicEndTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794397, RefRangeEnd = 794400, XrefRangeStart = 794390, XrefRangeEnd = 794397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float DescEndTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DescEndTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794410, RefRangeEnd = 794413, XrefRangeStart = 794400, XrefRangeEnd = 794410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CouldSkipCurEnding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CouldSkipCurEnding_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794413, XrefRangeEnd = 794420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUiClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUiClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794420, XrefRangeEnd = 794426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CurrentPicHasFadeIn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentPicHasFadeIn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794426, XrefRangeEnd = 794433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CurrentPicHasFadeOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentPicHasFadeOut_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794433, XrefRangeEnd = 794451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEndingManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEndingManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameEndingManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
