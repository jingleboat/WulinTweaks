using System;
using System.Runtime.CompilerServices;
using ChartAndGraph.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ChartAndGraph.DataSource;

public class ChartDataSourceBase : Il2CppSystem.Object
{
	public class DataValueChangedEventArgs : Il2CppSystem.EventArgs
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__ItemIndex_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__OldValue_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__NewValue_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__MinMaxChanged_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemIndex_Public_get_ChartItemIndex_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemIndex_Private_set_Void_ChartItemIndex_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_OldValue_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_OldValue_Private_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_NewValue_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_NewValue_Private_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MinMaxChanged_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_MinMaxChanged_Private_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Double_Double_Boolean_0;

		public unsafe ChartItemIndex _ItemIndex_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ItemIndex_k__BackingField);
				return *(ChartItemIndex*)num;
			}
			set
			{
				*(ChartItemIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ItemIndex_k__BackingField)) = chartItemIndex;
			}
		}

		public unsafe double _OldValue_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OldValue_k__BackingField);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OldValue_k__BackingField)) = num;
			}
		}

		public unsafe double _NewValue_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NewValue_k__BackingField);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NewValue_k__BackingField)) = num;
			}
		}

		public unsafe bool _MinMaxChanged_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinMaxChanged_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinMaxChanged_k__BackingField)) = flag;
			}
		}

		public unsafe ChartItemIndex ItemIndex
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 13952, RefRangeEnd = 13960, XrefRangeStart = 13952, XrefRangeEnd = 13960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemIndex_Public_get_ChartItemIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ChartItemIndex*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 13960, RefRangeEnd = 13981, XrefRangeStart = 13960, XrefRangeEnd = 13981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ItemIndex_Private_set_Void_ChartItemIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe double OldValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OldValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OldValue_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe double NewValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NewValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NewValue_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe bool MinMaxChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinMaxChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42106, RefRangeEnd = 42107, XrefRangeStart = 42106, XrefRangeEnd = 42107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MinMaxChanged_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static DataValueChangedEventArgs()
		{
			Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, "DataValueChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr);
			NativeFieldInfoPtr__ItemIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, "<ItemIndex>k__BackingField");
			NativeFieldInfoPtr__OldValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, "<OldValue>k__BackingField");
			NativeFieldInfoPtr__NewValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, "<NewValue>k__BackingField");
			NativeFieldInfoPtr__MinMaxChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, "<MinMaxChanged>k__BackingField");
			NativeMethodInfoPtr_get_ItemIndex_Public_get_ChartItemIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685987);
			NativeMethodInfoPtr_set_ItemIndex_Private_set_Void_ChartItemIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685988);
			NativeMethodInfoPtr_get_OldValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685989);
			NativeMethodInfoPtr_set_OldValue_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685990);
			NativeMethodInfoPtr_get_NewValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685991);
			NativeMethodInfoPtr_set_NewValue_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685992);
			NativeMethodInfoPtr_get_MinMaxChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685993);
			NativeMethodInfoPtr_set_MinMaxChanged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685994);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Double_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr, 100685995);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763634, RefRangeEnd = 763635, XrefRangeStart = 763629, XrefRangeEnd = 763634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataValueChangedEventArgs(int group, int category, double oldValue, double newValue, bool minMaxChanged)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataValueChangedEventArgs>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&group);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
			*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldValue;
			*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minMaxChanged;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Double_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DataValueChangedEventArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DataStructureChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_DataValueChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_DataStructureChanged_Public_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_DataStructureChanged_Public_rem_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_DataValueChanged_Public_add_Void_EventHandler_1_DataValueChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_DataValueChanged_Public_rem_Void_EventHandler_1_DataValueChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDataStructureChanged_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDataValueChanged_Protected_Void_DataValueChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRawData_Public_Abstract_Virtual_New_Il2CppObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Columns_Public_Abstract_Virtual_New_get_ChartColumnCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rows_Public_Abstract_Virtual_New_get_ChartRowCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe Il2CppSystem.EventHandler DataStructureChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DataStructureChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DataStructureChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventHandler));
		}
	}

	public unsafe Il2CppSystem.EventHandler<DataValueChangedEventArgs> DataValueChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DataValueChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.EventHandler<DataValueChangedEventArgs>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DataValueChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventHandler));
		}
	}

	public unsafe virtual ChartColumnCollection Columns
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Columns_Public_Abstract_Virtual_New_get_ChartColumnCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartColumnCollection>(intPtr) : null;
		}
	}

	public unsafe virtual ChartRowCollection Rows
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Rows_Public_Abstract_Virtual_New_get_ChartRowCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartRowCollection>(intPtr) : null;
		}
	}

	static ChartDataSourceBase()
	{
		Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph.DataSource", "ChartDataSourceBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr);
		NativeFieldInfoPtr_DataStructureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, "DataStructureChanged");
		NativeFieldInfoPtr_DataValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, "DataValueChanged");
		NativeMethodInfoPtr_add_DataStructureChanged_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670760);
		NativeMethodInfoPtr_remove_DataStructureChanged_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670761);
		NativeMethodInfoPtr_add_DataValueChanged_Public_add_Void_EventHandler_1_DataValueChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670762);
		NativeMethodInfoPtr_remove_DataValueChanged_Public_rem_Void_EventHandler_1_DataValueChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670763);
		NativeMethodInfoPtr_OnDataStructureChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670764);
		NativeMethodInfoPtr_OnDataValueChanged_Protected_Void_DataValueChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670765);
		NativeMethodInfoPtr_getRawData_Public_Abstract_Virtual_New_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670766);
		NativeMethodInfoPtr_get_Columns_Public_Abstract_Virtual_New_get_ChartColumnCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670767);
		NativeMethodInfoPtr_get_Rows_Public_Abstract_Virtual_New_get_ChartRowCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670768);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr, 100670769);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 763639, RefRangeEnd = 763642, XrefRangeStart = 763635, XrefRangeEnd = 763639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_DataStructureChanged(Il2CppSystem.EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_DataStructureChanged_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 763646, RefRangeEnd = 763649, XrefRangeStart = 763642, XrefRangeEnd = 763646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_DataStructureChanged(Il2CppSystem.EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_DataStructureChanged_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 763653, RefRangeEnd = 763656, XrefRangeStart = 763649, XrefRangeEnd = 763653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_DataValueChanged(Il2CppSystem.EventHandler<DataValueChangedEventArgs> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_DataValueChanged_Public_add_Void_EventHandler_1_DataValueChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 763660, RefRangeEnd = 763663, XrefRangeStart = 763656, XrefRangeEnd = 763660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_DataValueChanged(Il2CppSystem.EventHandler<DataValueChangedEventArgs> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_DataValueChanged_Public_rem_Void_EventHandler_1_DataValueChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 763668, RefRangeEnd = 763669, XrefRangeStart = 763663, XrefRangeEnd = 763668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDataStructureChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDataStructureChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763669, XrefRangeEnd = 763672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDataValueChanged(DataValueChangedEventArgs data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDataValueChanged_Protected_Void_DataValueChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppObjectBase getRawData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_getRawData_Public_Abstract_Virtual_New_Il2CppObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartDataSourceBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartDataSourceBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartDataSourceBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
