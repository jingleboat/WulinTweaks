using System;
using System.Runtime.CompilerServices;
using ChartAndGraph.DataSource;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ChartAndGraph;

public class ChartSparseDataSource : ChartDataSourceBase
{
	public sealed class KeyElement : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Row_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Column_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChartDataRow_ChartDataColumn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsIn_Public_Boolean_IDataItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsInRow_Public_Boolean_ChartDataRow_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsInColumn_Public_Boolean_ChartDataColumn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_KeyElement_KeyElement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_KeyElement_KeyElement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Row_Public_get_ChartDataRow_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Row_Private_set_Void_ChartDataRow_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Column_Public_get_ChartDataColumn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Column_Private_set_Void_ChartDataColumn_0;

		public unsafe ChartDataRow _Row_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Row_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartDataRow>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Row_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chartDataRow));
			}
		}

		public unsafe ChartDataColumn _Column_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Column_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartDataColumn>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Column_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chartDataColumn));
			}
		}

		public unsafe ChartDataRow Row
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28437, RefRangeEnd = 28438, XrefRangeStart = 28437, XrefRangeEnd = 28438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Row_Public_get_ChartDataRow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartDataRow>(intPtr) : null;
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 28614, RefRangeEnd = 28642, XrefRangeStart = 28614, XrefRangeEnd = 28642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Row_Private_set_Void_ChartDataRow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ChartDataColumn Column
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Column_Public_get_ChartDataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartDataColumn>(intPtr) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 245415, RefRangeEnd = 245419, XrefRangeStart = 245415, XrefRangeEnd = 245419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Column_Private_set_Void_ChartDataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static KeyElement()
		{
			Il2CppClassPointerStore<KeyElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "KeyElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyElement>.NativeClassPtr);
			NativeFieldInfoPtr__Row_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, "<Row>k__BackingField");
			NativeFieldInfoPtr__Column_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, "<Column>k__BackingField");
			NativeMethodInfoPtr__ctor_Public_Void_ChartDataRow_ChartDataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685882);
			NativeMethodInfoPtr_IsIn_Public_Boolean_IDataItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685883);
			NativeMethodInfoPtr_IsInRow_Public_Boolean_ChartDataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685884);
			NativeMethodInfoPtr_IsInColumn_Public_Boolean_ChartDataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685885);
			NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_KeyElement_KeyElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685886);
			NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_KeyElement_KeyElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685887);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685888);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685889);
			NativeMethodInfoPtr_get_Row_Public_get_ChartDataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685890);
			NativeMethodInfoPtr_set_Row_Private_set_Void_ChartDataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685891);
			NativeMethodInfoPtr_get_Column_Public_get_ChartDataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685892);
			NativeMethodInfoPtr_set_Column_Private_set_Void_ChartDataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyElement>.NativeClassPtr, 100685893);
		}

		[CallerCount(125)]
		[CachedScanResults(RefRangeStart = 41528, RefRangeEnd = 41653, XrefRangeStart = 41528, XrefRangeEnd = 41653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyElement(ChartDataRow row, ChartDataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyElement>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)column);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ChartDataRow_ChartDataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755036, RefRangeEnd = 755037, XrefRangeStart = 755036, XrefRangeEnd = 755036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIn(IDataItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIn_Public_Boolean_IDataItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool IsInRow(ChartDataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInRow_Public_Boolean_ChartDataRow_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool IsInColumn(ChartDataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)column);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInColumn_Public_Boolean_ChartDataColumn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755041, RefRangeEnd = 755043, XrefRangeStart = 755037, XrefRangeEnd = 755041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(KeyElement a, KeyElement b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_KeyElement_KeyElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755043, XrefRangeEnd = 755047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(KeyElement a, KeyElement b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_KeyElement_KeyElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755050, RefRangeEnd = 755052, XrefRangeStart = 755047, XrefRangeEnd = 755050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public KeyElement(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public KeyElement()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyElement>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mData;

	private static readonly System.IntPtr NativeFieldInfoPtr_mChartDataToIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMaxValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMinValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_mFireEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_mSuspendEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_mRawData;

	private static readonly System.IntPtr NativeFieldInfoPtr_mColumns;

	private static readonly System.IntPtr NativeFieldInfoPtr_mRows;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MRows_NameChanged_Private_Void_String_IDataItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MColumns_NameChanged_Private_Void_String_IDataItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SuspendEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SuspendEvents_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Columns_Public_Virtual_get_ChartColumnCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rows_Public_Virtual_get_ChartRowCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OrderChanged_Private_Void_Object_EventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMinMaxValue_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareRawData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasZeroItems_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRawMaxValue_Internal_Nullable_1_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRawMinValue_Internal_Nullable_1_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ItemRemoved_Private_Void_IDataItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rows_ItemRemoved_Private_Void_ChartDataRow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Columns_ItemRemoved_Private_Void_ChartDataColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureRawData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRawData_Public_Virtual_Il2CppObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyMinMaxValue_Private_Boolean_KeyElement_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InnerSetValue_Private_Void_ChartDataColumn_ChartDataRow_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InnerGetValue_Private_Double_ChartDataColumn_ChartDataRow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Double_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Double_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Double_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLabel_Public_Void_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_String_String_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_String_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_Int32_Double_0;

	public unsafe Dictionary<KeyElement, double> mData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<KeyElement, double>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<ChartDataItemBase, int> mChartDataToIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mChartDataToIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ChartDataItemBase, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mChartDataToIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>> mMaxValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMaxValue);
			return new Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMaxValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>> mMinValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMinValue);
			return new Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMinValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<KeyValuePair<KeyElement, double>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool mFireEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFireEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mFireEvent)) = flag;
		}
	}

	public unsafe bool mSuspendEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mSuspendEvents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mSuspendEvents)) = flag;
		}
	}

	public unsafe Il2CppObjectBase mRawData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mRawData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mRawData)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe ChartColumnCollection mColumns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mColumns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartColumnCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mColumns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chartColumnCollection));
		}
	}

	public unsafe ChartRowCollection mRows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mRows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartRowCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mRows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chartRowCollection));
		}
	}

	public unsafe bool SuspendEvents
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SuspendEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 755146, RefRangeEnd = 755160, XrefRangeStart = 755145, XrefRangeEnd = 755146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SuspendEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe override ChartColumnCollection Columns
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Columns_Public_Virtual_get_ChartColumnCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartColumnCollection>(intPtr) : null;
		}
	}

	public unsafe override ChartRowCollection Rows
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Rows_Public_Virtual_get_ChartRowCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChartRowCollection>(intPtr) : null;
		}
	}

	static ChartSparseDataSource()
	{
		Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartSparseDataSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr);
		NativeFieldInfoPtr_mData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mData");
		NativeFieldInfoPtr_mChartDataToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mChartDataToIndex");
		NativeFieldInfoPtr_mMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mMaxValue");
		NativeFieldInfoPtr_mMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mMinValue");
		NativeFieldInfoPtr_mFireEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mFireEvent");
		NativeFieldInfoPtr_mSuspendEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mSuspendEvents");
		NativeFieldInfoPtr_mRawData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mRawData");
		NativeFieldInfoPtr_mColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mColumns");
		NativeFieldInfoPtr_mRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, "mRows");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669972);
		NativeMethodInfoPtr_MRows_NameChanged_Private_Void_String_IDataItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669973);
		NativeMethodInfoPtr_MColumns_NameChanged_Private_Void_String_IDataItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669974);
		NativeMethodInfoPtr_get_SuspendEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669975);
		NativeMethodInfoPtr_set_SuspendEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669976);
		NativeMethodInfoPtr_get_Columns_Public_Virtual_get_ChartColumnCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669977);
		NativeMethodInfoPtr_get_Rows_Public_Virtual_get_ChartRowCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669978);
		NativeMethodInfoPtr_OrderChanged_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669979);
		NativeMethodInfoPtr_FindMinMaxValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669980);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669981);
		NativeMethodInfoPtr_PrepareRawData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669982);
		NativeMethodInfoPtr_HasZeroItems_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669983);
		NativeMethodInfoPtr_getRawMaxValue_Internal_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669984);
		NativeMethodInfoPtr_getRawMinValue_Internal_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669985);
		NativeMethodInfoPtr_ItemRemoved_Private_Void_IDataItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669986);
		NativeMethodInfoPtr_Rows_ItemRemoved_Private_Void_ChartDataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669987);
		NativeMethodInfoPtr_Columns_ItemRemoved_Private_Void_ChartDataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669988);
		NativeMethodInfoPtr_EnsureRawData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669989);
		NativeMethodInfoPtr_getRawData_Public_Virtual_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669990);
		NativeMethodInfoPtr_VerifyMinMaxValue_Private_Boolean_KeyElement_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669991);
		NativeMethodInfoPtr_InnerSetValue_Private_Void_ChartDataColumn_ChartDataRow_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669992);
		NativeMethodInfoPtr_InnerGetValue_Private_Double_ChartDataColumn_ChartDataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669993);
		NativeMethodInfoPtr_GetValue_Public_Double_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669994);
		NativeMethodInfoPtr_GetValue_Public_Double_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669995);
		NativeMethodInfoPtr_GetValue_Public_Double_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669996);
		NativeMethodInfoPtr_AddLabel_Public_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669997);
		NativeMethodInfoPtr_SetValue_Public_Void_String_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669998);
		NativeMethodInfoPtr_SetValue_Public_Void_String_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100669999);
		NativeMethodInfoPtr_SetValue_Public_Void_Int32_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr, 100670000);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 755136, RefRangeEnd = 755145, XrefRangeStart = 755052, XrefRangeEnd = 755136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartSparseDataSource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartSparseDataSource>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MRows_NameChanged(string arg1, IDataItem arg2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MRows_NameChanged_Private_Void_String_IDataItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MColumns_NameChanged(string arg1, IDataItem arg2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MColumns_NameChanged_Private_Void_String_IDataItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755160, XrefRangeEnd = 755163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OrderChanged(Il2CppSystem.Object sender, Il2CppSystem.EventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OrderChanged_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 755198, RefRangeEnd = 755201, XrefRangeStart = 755163, XrefRangeEnd = 755198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMinMaxValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMinMaxValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 755208, RefRangeEnd = 755211, XrefRangeStart = 755201, XrefRangeEnd = 755208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 755263, RefRangeEnd = 755268, XrefRangeStart = 755211, XrefRangeEnd = 755263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareRawData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareRawData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 755277, RefRangeEnd = 755279, XrefRangeStart = 755268, XrefRangeEnd = 755277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasZeroItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasZeroItems_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 755296, RefRangeEnd = 755300, XrefRangeStart = 755279, XrefRangeEnd = 755296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<double> getRawMaxValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRawMaxValue_Internal_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<double>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 755317, RefRangeEnd = 755319, XrefRangeStart = 755300, XrefRangeEnd = 755317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<double> getRawMinValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRawMinValue_Internal_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<double>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 755345, RefRangeEnd = 755347, XrefRangeStart = 755319, XrefRangeEnd = 755345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ItemRemoved(IDataItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ItemRemoved_Private_Void_IDataItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755347, XrefRangeEnd = 755348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rows_ItemRemoved(ChartDataRow obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rows_ItemRemoved_Private_Void_ChartDataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Columns_ItemRemoved(ChartDataColumn obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Columns_ItemRemoved_Private_Void_ChartDataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755348, XrefRangeEnd = 755349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureRawData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureRawData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755349, XrefRangeEnd = 755350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppObjectBase getRawData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_getRawData_Public_Virtual_Il2CppObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 755379, RefRangeEnd = 755380, XrefRangeStart = 755350, XrefRangeEnd = 755379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool VerifyMinMaxValue(KeyElement element, double value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)element));
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyMinMaxValue_Private_Boolean_KeyElement_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 755402, RefRangeEnd = 755405, XrefRangeStart = 755380, XrefRangeEnd = 755402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InnerSetValue(ChartDataColumn column, ChartDataRow row, double amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)column);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InnerSetValue_Private_Void_ChartDataColumn_ChartDataRow_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 755409, RefRangeEnd = 755412, XrefRangeStart = 755405, XrefRangeEnd = 755409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double InnerGetValue(ChartDataColumn column, ChartDataRow row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)column);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InnerGetValue_Private_Double_ChartDataColumn_ChartDataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 755420, RefRangeEnd = 755431, XrefRangeStart = 755412, XrefRangeEnd = 755420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetValue(string ColumnName, string RowName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ColumnName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(RowName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Double_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755431, XrefRangeEnd = 755439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetValue(string ColumnName, int rowIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ColumnName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Double_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755439, XrefRangeEnd = 755447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetValue(int columnIndex, int rowIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&columnIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Double_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLabel(string columnName, int rowIndex, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLabel_Public_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 755455, RefRangeEnd = 755461, XrefRangeStart = 755447, XrefRangeEnd = 755455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue(string ColumnName, string RowName, double amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ColumnName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(RowName);
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_String_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755461, XrefRangeEnd = 755469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue(string ColumnName, int rowIndex, double amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ColumnName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowIndex;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_String_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755469, XrefRangeEnd = 755477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue(int columnIndex, int rowIndex, double amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&columnIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowIndex;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_Int32_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartSparseDataSource(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
