using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin;

public class SaveObjectGameTime : SaveObjectBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_simulatedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_simulationStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__Year_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Month_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Day_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Dhour_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Quarter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_QuaterOfDay;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsDaylight_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TotalQuaterPassed_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TotalQuaterPassedAsInt_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalYearChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSecsTimeYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedDayTimeTheshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedNightTimeTheshold;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Year_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Month_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Day_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Dhour_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Dhour_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Quarter_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Quarter_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDaylight_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDaylight_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalQuaterPassed_Public_get_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TotalQuaterPassed_Private_set_Void_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalQuaterPassedAsInt_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TotalQuaterPassedAsInt_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalDaysPassed_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStartTime_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddQuarterTime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDayTime_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDeltaTime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppSystem.DateTime simulatedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulatedTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulatedTime)) = dateTime;
		}
	}

	public unsafe Il2CppSystem.DateTime simulationStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulationStartTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulationStartTime)) = dateTime;
		}
	}

	public unsafe int _Year_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Year_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Year_k__BackingField)) = num;
		}
	}

	public unsafe int _Month_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Month_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Month_k__BackingField)) = num;
		}
	}

	public unsafe int _Day_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Day_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Day_k__BackingField)) = num;
		}
	}

	public unsafe int _Dhour_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Dhour_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Dhour_k__BackingField)) = num;
		}
	}

	public unsafe int _Quarter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Quarter_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Quarter_k__BackingField)) = num;
		}
	}

	public unsafe Il2CppSystem.Decimal QuaterOfDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuaterOfDay);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuaterOfDay)) = obj;
		}
	}

	public unsafe bool _IsDaylight_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsDaylight_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsDaylight_k__BackingField)) = flag;
		}
	}

	public unsafe Il2CppSystem.Decimal _TotalQuaterPassed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalQuaterPassed_k__BackingField);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalQuaterPassed_k__BackingField)) = obj;
		}
	}

	public unsafe int _TotalQuaterPassedAsInt_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalQuaterPassedAsInt_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TotalQuaterPassedAsInt_k__BackingField)) = num;
		}
	}

	public unsafe int totalYearChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalYearChanged);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalYearChanged)) = num;
		}
	}

	public unsafe double totalSecsTimeYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSecsTimeYear);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSecsTimeYear)) = num;
		}
	}

	public unsafe Il2CppSystem.Decimal m_cachedDayTimeTheshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedDayTimeTheshold);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedDayTimeTheshold)) = obj;
		}
	}

	public unsafe Il2CppSystem.Decimal m_cachedNightTimeTheshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedNightTimeTheshold);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedNightTimeTheshold)) = obj;
		}
	}

	public unsafe int Year
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 73513, RefRangeEnd = 73520, XrefRangeStart = 73513, XrefRangeEnd = 73520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Year_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Year_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int Month
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Month_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Month_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int Day
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 18877, RefRangeEnd = 18887, XrefRangeStart = 18877, XrefRangeEnd = 18887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Day_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Day_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int Dhour
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Dhour_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Dhour_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int Quarter
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48653, RefRangeEnd = 48654, XrefRangeStart = 48653, XrefRangeEnd = 48654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Quarter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Quarter_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsDaylight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDaylight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsDaylight_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Decimal TotalQuaterPassed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalQuaterPassed_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TotalQuaterPassed_Private_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int TotalQuaterPassedAsInt
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalQuaterPassedAsInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TotalQuaterPassedAsInt_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int TotalDaysPassed
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 848261, RefRangeEnd = 848262, XrefRangeStart = 848250, XrefRangeEnd = 848261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalDaysPassed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static SaveObjectGameTime()
	{
		Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectGameTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr);
		NativeFieldInfoPtr_simulatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "simulatedTime");
		NativeFieldInfoPtr_simulationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "simulationStartTime");
		NativeFieldInfoPtr__Year_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<Year>k__BackingField");
		NativeFieldInfoPtr__Month_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<Month>k__BackingField");
		NativeFieldInfoPtr__Day_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<Day>k__BackingField");
		NativeFieldInfoPtr__Dhour_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<Dhour>k__BackingField");
		NativeFieldInfoPtr__Quarter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<Quarter>k__BackingField");
		NativeFieldInfoPtr_QuaterOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "QuaterOfDay");
		NativeFieldInfoPtr__IsDaylight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<IsDaylight>k__BackingField");
		NativeFieldInfoPtr__TotalQuaterPassed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<TotalQuaterPassed>k__BackingField");
		NativeFieldInfoPtr__TotalQuaterPassedAsInt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "<TotalQuaterPassedAsInt>k__BackingField");
		NativeFieldInfoPtr_totalYearChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "totalYearChanged");
		NativeFieldInfoPtr_totalSecsTimeYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "totalSecsTimeYear");
		NativeFieldInfoPtr_m_cachedDayTimeTheshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "m_cachedDayTimeTheshold");
		NativeFieldInfoPtr_m_cachedNightTimeTheshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, "m_cachedNightTimeTheshold");
		NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673647);
		NativeMethodInfoPtr_set_Year_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673648);
		NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673649);
		NativeMethodInfoPtr_set_Month_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673650);
		NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673651);
		NativeMethodInfoPtr_set_Day_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673652);
		NativeMethodInfoPtr_get_Dhour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673653);
		NativeMethodInfoPtr_set_Dhour_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673654);
		NativeMethodInfoPtr_get_Quarter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673655);
		NativeMethodInfoPtr_set_Quarter_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673656);
		NativeMethodInfoPtr_get_IsDaylight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673657);
		NativeMethodInfoPtr_set_IsDaylight_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673658);
		NativeMethodInfoPtr_get_TotalQuaterPassed_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673659);
		NativeMethodInfoPtr_set_TotalQuaterPassed_Private_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673660);
		NativeMethodInfoPtr_get_TotalQuaterPassedAsInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673661);
		NativeMethodInfoPtr_set_TotalQuaterPassedAsInt_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673662);
		NativeMethodInfoPtr_get_TotalDaysPassed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673663);
		NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673664);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673665);
		NativeMethodInfoPtr_SetStartTime_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673666);
		NativeMethodInfoPtr_AddQuarterTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673667);
		NativeMethodInfoPtr_IsDayTime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673668);
		NativeMethodInfoPtr_AddDeltaTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673669);
		NativeMethodInfoPtr_ApplyTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673670);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr, 100673671);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848262, XrefRangeEnd = 848279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 848287, RefRangeEnd = 848288, XrefRangeStart = 848279, XrefRangeEnd = 848287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStartTime(int month = 1, int day = 1, int dhour = 0, int quarter = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&month);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dhour;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &quarter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStartTime_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 848289, RefRangeEnd = 848290, XrefRangeStart = 848288, XrefRangeEnd = 848289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddQuarterTime(float quarter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quarter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddQuarterTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848290, XrefRangeEnd = 848294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDayTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDayTime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 848434, RefRangeEnd = 848436, XrefRangeStart = 848294, XrefRangeEnd = 848434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDeltaTime(float gameDeltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gameDeltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDeltaTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 848469, RefRangeEnd = 848473, XrefRangeStart = 848436, XrefRangeEnd = 848469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848473, XrefRangeEnd = 848474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectGameTime()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectGameTime>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectGameTime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
