using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class GameResManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_isInited;

	private static readonly IntPtr NativeFieldInfoPtr_kongfuAreaDataDict;

	private static readonly IntPtr NativeFieldInfoPtr_advancedAiDataDict;

	private static readonly IntPtr NativeFieldInfoPtr_npcViewDataDict;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReloadLabeledRes_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetKongfuAreaData_Public_Static_KongfuAreaData_Il2CppStringArray_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetKongfuAreaData_Public_Static_KongfuAreaData_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAdvancedAi_Public_Static_BattleActorAdvancedAI_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool isInited
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isInited, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isInited, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<string, KongfuAreaData> kongfuAreaDataDict
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kongfuAreaDataDict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, KongfuAreaData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kongfuAreaDataDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, BattleActorAdvancedAI> advancedAiDataDict
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_advancedAiDataDict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, BattleActorAdvancedAI>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_advancedAiDataDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, NpcViewData> npcViewDataDict
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_npcViewDataDict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, NpcViewData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_npcViewDataDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static GameResManager()
	{
		Il2CppClassPointerStore<GameResManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameResManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResManager>.NativeClassPtr);
		NativeFieldInfoPtr_isInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, "isInited");
		NativeFieldInfoPtr_kongfuAreaDataDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, "kongfuAreaDataDict");
		NativeFieldInfoPtr_advancedAiDataDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, "advancedAiDataDict");
		NativeFieldInfoPtr_npcViewDataDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, "npcViewDataDict");
		NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, 100672993);
		NativeMethodInfoPtr_ReloadLabeledRes_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, 100672994);
		NativeMethodInfoPtr_GetKongfuAreaData_Public_Static_KongfuAreaData_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, 100672995);
		NativeMethodInfoPtr_GetKongfuAreaData_Public_Static_KongfuAreaData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, 100672996);
		NativeMethodInfoPtr_GetAdvancedAi_Public_Static_BattleActorAdvancedAI_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, 100672997);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResManager>.NativeClassPtr, 100672998);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828027, XrefRangeEnd = 828033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 828085, RefRangeEnd = 828089, XrefRangeStart = 828033, XrefRangeEnd = 828085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReloadLabeledRes()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadLabeledRes_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 828130, RefRangeEnd = 828138, XrefRangeStart = 828089, XrefRangeEnd = 828130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KongfuAreaData GetKongfuAreaData(Il2CppStringArray keys, int index)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKongfuAreaData_Public_Static_KongfuAreaData_Il2CppStringArray_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<KongfuAreaData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828138, XrefRangeEnd = 828173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KongfuAreaData GetKongfuAreaData(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKongfuAreaData_Public_Static_KongfuAreaData_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<KongfuAreaData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 828183, RefRangeEnd = 828185, XrefRangeStart = 828173, XrefRangeEnd = 828183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BattleActorAdvancedAI GetAdvancedAi(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdvancedAi_Public_Static_BattleActorAdvancedAI_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActorAdvancedAI>(intPtr) : null;
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameResManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameResManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
