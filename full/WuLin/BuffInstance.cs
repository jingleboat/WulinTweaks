using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

[System.Serializable]
public class BuffInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_stack;

	private static readonly System.IntPtr NativeFieldInfoPtr_initTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lifeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectIsRemoved;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialCode;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsNew_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataId;

	private static readonly System.IntPtr NativeFieldInfoPtr_replacedBySameTemplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_masterBuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_onEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_templete;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedDynamicModifierInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedBattleAuraInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceAura;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedLib;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNew_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsNew_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Templete_Public_get_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DynamicModifierInstances_Public_get_HashSet_1_DynamicModifierInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BattleAuras_Public_get_HashSet_1_BattleAuraInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuffData_Il2CppStructArray_1_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLib_Public_Void_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNew_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMasterBuff_Public_Void_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSameValue_Public_Boolean_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLifeTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffTickType_Public_BuffTickType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTag_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckClearByTag_Public_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Void_Single_BuffTickType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllContinousEffectValue_Public_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContinousEffectValue_Public_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPostLoad_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyOverrideValues_Public_Void_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyOverrideValueInternal_Internal_Void_Il2CppStructArray_1_Decimal_0;

	public unsafe bool isValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValid)) = flag;
		}
	}

	public unsafe Il2CppSystem.Decimal stack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stack);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stack)) = obj;
		}
	}

	public unsafe Il2CppSystem.Decimal initTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTime);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTime)) = obj;
		}
	}

	public unsafe float lifeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTime)) = num;
		}
	}

	public unsafe bool effectIsRemoved
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectIsRemoved);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectIsRemoved)) = flag;
		}
	}

	public unsafe int initialCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialCode)) = num;
		}
	}

	public unsafe bool _IsNew_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsNew_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsNew_k__BackingField)) = flag;
		}
	}

	public unsafe string dataId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool replacedBySameTemplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacedBySameTemplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacedBySameTemplete)) = flag;
		}
	}

	public unsafe BuffInstance masterBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterBuff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterBuff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance));
		}
	}

	public unsafe Il2CppSystem.Action onEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe BuffData templete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffData));
		}
	}

	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> overrideValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe HashSet<DynamicModifierInstance> cachedDynamicModifierInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDynamicModifierInstances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<DynamicModifierInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedDynamicModifierInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleAuraInstance> cachedBattleAuraInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBattleAuraInstances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleAuraInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedBattleAuraInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe BattleAuraInstance sourceAura
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceAura);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleAuraInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceAura)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleAuraInstance));
		}
	}

	public unsafe BuffLib m_CachedLib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedLib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffLib>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedLib)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffLib));
		}
	}

	public unsafe bool IsNew
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNew_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98575, RefRangeEnd = 98578, XrefRangeStart = 98575, XrefRangeEnd = 98578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsNew_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsValid
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 790407, RefRangeEnd = 790409, XrefRangeStart = 790407, XrefRangeEnd = 790407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe BuffData Templete
	{
		[CallerCount(162)]
		[CachedScanResults(RefRangeStart = 790416, RefRangeEnd = 790578, XrefRangeStart = 790409, XrefRangeEnd = 790416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Templete_Public_get_BuffData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffData>(intPtr) : null;
		}
	}

	public unsafe HashSet<DynamicModifierInstance> DynamicModifierInstances
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 790597, RefRangeEnd = 790603, XrefRangeStart = 790578, XrefRangeEnd = 790597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DynamicModifierInstances_Public_get_HashSet_1_DynamicModifierInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<DynamicModifierInstance>>(intPtr) : null;
		}
	}

	public unsafe HashSet<BattleAuraInstance> BattleAuras
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 790628, RefRangeEnd = 790631, XrefRangeStart = 790603, XrefRangeEnd = 790628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BattleAuras_Public_get_HashSet_1_BattleAuraInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleAuraInstance>>(intPtr) : null;
		}
	}

	static BuffInstance()
	{
		Il2CppClassPointerStore<BuffInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BuffInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr);
		NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "isValid");
		NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "stack");
		NativeFieldInfoPtr_initTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "initTime");
		NativeFieldInfoPtr_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "lifeTime");
		NativeFieldInfoPtr_effectIsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "effectIsRemoved");
		NativeFieldInfoPtr_initialCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "initialCode");
		NativeFieldInfoPtr__IsNew_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "<IsNew>k__BackingField");
		NativeFieldInfoPtr_dataId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "dataId");
		NativeFieldInfoPtr_replacedBySameTemplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "replacedBySameTemplete");
		NativeFieldInfoPtr_masterBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "masterBuff");
		NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "onEnd");
		NativeFieldInfoPtr_templete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "templete");
		NativeFieldInfoPtr_overrideValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "overrideValues");
		NativeFieldInfoPtr_cachedDynamicModifierInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "cachedDynamicModifierInstances");
		NativeFieldInfoPtr_cachedBattleAuraInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "cachedBattleAuraInstances");
		NativeFieldInfoPtr_sourceAura = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "sourceAura");
		NativeFieldInfoPtr_m_CachedLib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, "m_CachedLib");
		NativeMethodInfoPtr_get_IsNew_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671631);
		NativeMethodInfoPtr_set_IsNew_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671632);
		NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671633);
		NativeMethodInfoPtr_get_Templete_Public_get_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671634);
		NativeMethodInfoPtr_get_DynamicModifierInstances_Public_get_HashSet_1_DynamicModifierInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671635);
		NativeMethodInfoPtr_get_BattleAuras_Public_get_HashSet_1_BattleAuraInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671636);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671637);
		NativeMethodInfoPtr__ctor_Public_Void_BuffData_Il2CppStructArray_1_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671638);
		NativeMethodInfoPtr_SetLib_Public_Void_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671639);
		NativeMethodInfoPtr_SetNew_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671640);
		NativeMethodInfoPtr_SetMasterBuff_Public_Void_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671641);
		NativeMethodInfoPtr_IsSameValue_Public_Boolean_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671642);
		NativeMethodInfoPtr_GetLifeTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671643);
		NativeMethodInfoPtr_GetBuffTickType_Public_BuffTickType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671644);
		NativeMethodInfoPtr_CheckTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671645);
		NativeMethodInfoPtr_CheckClearByTag_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671646);
		NativeMethodInfoPtr_Check_Public_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671647);
		NativeMethodInfoPtr_Tick_Public_Void_Single_BuffTickType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671648);
		NativeMethodInfoPtr_GetAllContinousEffectValue_Public_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671649);
		NativeMethodInfoPtr_GetContinousEffectValue_Public_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671650);
		NativeMethodInfoPtr_OnPostLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671651);
		NativeMethodInfoPtr_GetInfo_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671652);
		NativeMethodInfoPtr_ApplyOverrideValues_Public_Void_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671653);
		NativeMethodInfoPtr_ApplyOverrideValueInternal_Internal_Void_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr, 100671654);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790639, RefRangeEnd = 790640, XrefRangeStart = 790631, XrefRangeEnd = 790639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 790666, RefRangeEnd = 790673, XrefRangeStart = 790640, XrefRangeEnd = 790666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffInstance(BuffData _data, [Optional][DefaultParameterValue(null)] Il2CppStructArray<Il2CppSystem.Decimal> overrideValues, [Optional] Il2CppSystem.Decimal stack)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValues);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stack;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BuffData_Il2CppStructArray_1_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetLib(BuffLib lib)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lib);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLib_Public_Void_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 98575, RefRangeEnd = 98578, XrefRangeStart = 98575, XrefRangeEnd = 98578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNew(bool isNew)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isNew);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNew_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetMasterBuff(BuffInstance master)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)master);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMasterBuff_Public_Void_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790686, RefRangeEnd = 790687, XrefRangeStart = 790673, XrefRangeEnd = 790686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSameValue(BuffInstance other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameValue_Public_Boolean_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 790688, RefRangeEnd = 790696, XrefRangeStart = 790687, XrefRangeEnd = 790688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLifeTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLifeTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 790698, RefRangeEnd = 790708, XrefRangeStart = 790696, XrefRangeEnd = 790698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffTickType GetBuffTickType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffTickType_Public_BuffTickType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(BuffTickType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790708, XrefRangeEnd = 790712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckTag(string tag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 790717, RefRangeEnd = 790721, XrefRangeStart = 790712, XrefRangeEnd = 790717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckClearByTag(string tag, bool instantClear = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instantClear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckClearByTag_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 790733, RefRangeEnd = 790735, XrefRangeStart = 790721, XrefRangeEnd = 790733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal Check(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790743, RefRangeEnd = 790744, XrefRangeStart = 790735, XrefRangeEnd = 790743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tick(float deltaTime, BuffTickType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&deltaTime);
		*(BuffTickType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tick_Public_Void_Single_BuffTickType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 790750, RefRangeEnd = 790758, XrefRangeStart = 790744, XrefRangeEnd = 790750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Il2CppSystem.Decimal> GetAllContinousEffectValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllContinousEffectValue_Public_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Decimal>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 790763, RefRangeEnd = 790770, XrefRangeStart = 790758, XrefRangeEnd = 790763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Decimal GetContinousEffectValue(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContinousEffectValue_Public_Decimal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790770, XrefRangeEnd = 790788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPostLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPostLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 790793, RefRangeEnd = 790796, XrefRangeStart = 790788, XrefRangeEnd = 790793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790796, RefRangeEnd = 790797, XrefRangeStart = 790796, XrefRangeEnd = 790796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyOverrideValues(Il2CppStructArray<Il2CppSystem.Decimal> overrideValues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyOverrideValues_Public_Void_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ApplyOverrideValueInternal(Il2CppStructArray<Il2CppSystem.Decimal> overrideValues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyOverrideValueInternal_Internal_Void_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuffInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
