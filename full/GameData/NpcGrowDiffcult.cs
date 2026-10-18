using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData;

[System.Serializable]
public class NpcGrowDiffcult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_moneyDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyPer0;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyPer1;

	private static readonly System.IntPtr NativeFieldInfoPtr_expDayGeneral;

	private static readonly System.IntPtr NativeFieldInfoPtr_expPerGeneral;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillLvDayGeneral;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillGetdayGeneral;

	private static readonly System.IntPtr NativeFieldInfoPtr_expDayElite;

	private static readonly System.IntPtr NativeFieldInfoPtr_expPerElite;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillLvDayElite;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillGetdayElite;

	private static readonly System.IntPtr NativeFieldInfoPtr_expDayBoss;

	private static readonly System.IntPtr NativeFieldInfoPtr_expPerBoss;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillLvDayBoss;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillGetdayBoss;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int moneyDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyDay)) = num;
		}
	}

	public unsafe float moneyPer0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyPer0);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyPer0)) = num;
		}
	}

	public unsafe float moneyPer1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyPer1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyPer1)) = num;
		}
	}

	public unsafe int expDayGeneral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expDayGeneral);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expDayGeneral)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> expPerGeneral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expPerGeneral);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expPerGeneral)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int skillLvDayGeneral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLvDayGeneral);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLvDayGeneral)) = num;
		}
	}

	public unsafe int skillGetdayGeneral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillGetdayGeneral);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillGetdayGeneral)) = num;
		}
	}

	public unsafe int expDayElite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expDayElite);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expDayElite)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> expPerElite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expPerElite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expPerElite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int skillLvDayElite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLvDayElite);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLvDayElite)) = num;
		}
	}

	public unsafe int skillGetdayElite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillGetdayElite);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillGetdayElite)) = num;
		}
	}

	public unsafe int expDayBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expDayBoss);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expDayBoss)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> expPerBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expPerBoss);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expPerBoss)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int skillLvDayBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLvDayBoss);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillLvDayBoss)) = num;
		}
	}

	public unsafe int skillGetdayBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillGetdayBoss);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillGetdayBoss)) = num;
		}
	}

	static NpcGrowDiffcult()
	{
		Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "NpcGrowDiffcult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr);
		NativeFieldInfoPtr_moneyDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "moneyDay");
		NativeFieldInfoPtr_moneyPer0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "moneyPer0");
		NativeFieldInfoPtr_moneyPer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "moneyPer1");
		NativeFieldInfoPtr_expDayGeneral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "expDayGeneral");
		NativeFieldInfoPtr_expPerGeneral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "expPerGeneral");
		NativeFieldInfoPtr_skillLvDayGeneral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "skillLvDayGeneral");
		NativeFieldInfoPtr_skillGetdayGeneral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "skillGetdayGeneral");
		NativeFieldInfoPtr_expDayElite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "expDayElite");
		NativeFieldInfoPtr_expPerElite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "expPerElite");
		NativeFieldInfoPtr_skillLvDayElite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "skillLvDayElite");
		NativeFieldInfoPtr_skillGetdayElite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "skillGetdayElite");
		NativeFieldInfoPtr_expDayBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "expDayBoss");
		NativeFieldInfoPtr_expPerBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "expPerBoss");
		NativeFieldInfoPtr_skillLvDayBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "skillLvDayBoss");
		NativeFieldInfoPtr_skillGetdayBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, "skillGetdayBoss");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr, 100664656);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 694823, RefRangeEnd = 694827, XrefRangeStart = 694815, XrefRangeEnd = 694823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcGrowDiffcult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcGrowDiffcult>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NpcGrowDiffcult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
