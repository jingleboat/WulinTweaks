using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace WuLin.StateMachine;

public class StateMachineDataContainer : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetData_Public_T_StateMachineDataTypes_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetData_Public_T_StateMachineDataTypes_0, Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_stateMachineInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataDic;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_Dictionary_2_StateMachineDataTypes_StateMachineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StateMachineInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_StateMachineDataTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_StateMachineDataTypes_StateMachineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_T_StateMachineDataTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveData_Public_Void_StateMachineDataTypes_0;

	public unsafe StateMachineInstance stateMachineInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateMachineInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateMachineInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateMachineInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineInstance));
		}
	}

	public unsafe Dictionary<StateMachineDataTypes, StateMachineData> dataDic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataDic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StateMachineDataTypes, StateMachineData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataDic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<StateMachineDataTypes, StateMachineData> Data
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Data_Public_get_Dictionary_2_StateMachineDataTypes_StateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StateMachineDataTypes, StateMachineData>>(intPtr) : null;
		}
	}

	static StateMachineDataContainer()
	{
		Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "StateMachineDataContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr);
		NativeFieldInfoPtr_stateMachineInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, "stateMachineInstance");
		NativeFieldInfoPtr_dataDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, "dataDic");
		NativeMethodInfoPtr_get_Data_Public_get_Dictionary_2_StateMachineDataTypes_StateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, 100680896);
		NativeMethodInfoPtr__ctor_Public_Void_StateMachineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, 100680897);
		NativeMethodInfoPtr_ContainsKey_Public_Boolean_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, 100680898);
		NativeMethodInfoPtr_SetData_Public_Void_StateMachineDataTypes_StateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, 100680899);
		NativeMethodInfoPtr_GetData_Public_T_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, 100680900);
		NativeMethodInfoPtr_RemoveData_Public_Void_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr, 100680901);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1033509, RefRangeEnd = 1033512, XrefRangeStart = 1033502, XrefRangeEnd = 1033509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StateMachineDataContainer(StateMachineInstance stateMachineInstance)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineDataContainer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StateMachineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1033516, RefRangeEnd = 1033521, XrefRangeStart = 1033512, XrefRangeEnd = 1033516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsKey(StateMachineDataTypes type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsKey_Public_Boolean_StateMachineDataTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1033525, RefRangeEnd = 1033526, XrefRangeStart = 1033521, XrefRangeEnd = 1033525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(StateMachineDataTypes type, StateMachineData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_StateMachineDataTypes_StateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1033528, RefRangeEnd = 1033548, XrefRangeStart = 1033526, XrefRangeEnd = 1033528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetData<T>(StateMachineDataTypes type) where T : StateMachineData
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetData_Public_T_StateMachineDataTypes_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1033554, RefRangeEnd = 1033556, XrefRangeStart = 1033548, XrefRangeEnd = 1033554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveData(StateMachineDataTypes type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveData_Public_Void_StateMachineDataTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StateMachineDataContainer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
