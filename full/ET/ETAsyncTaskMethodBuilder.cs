using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace ET;

public sealed class ETAsyncTaskMethodBuilder : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tcs;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ETAsyncTaskMethodBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Task_Public_get_ETTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

	public unsafe ETTask tcs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ETTask>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eTTask));
		}
	}

	public unsafe ETTask Task
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28437, RefRangeEnd = 28438, XrefRangeStart = 28437, XrefRangeEnd = 28438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Task_Public_get_ETTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ETTask>(intPtr) : null;
		}
	}

	static ETAsyncTaskMethodBuilder()
	{
		Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ET", "ETAsyncTaskMethodBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_tcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, "tcs");
		NativeMethodInfoPtr_Create_Public_Static_ETAsyncTaskMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667193);
		NativeMethodInfoPtr_get_Task_Public_get_ETTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667194);
		NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667195);
		NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667196);
		NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667197);
		NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667198);
		NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667199);
		NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr, 100667200);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 723249, RefRangeEnd = 723331, XrefRangeStart = 723233, XrefRangeEnd = 723249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ETAsyncTaskMethodBuilder Create()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ETAsyncTaskMethodBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ETAsyncTaskMethodBuilder(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723331, XrefRangeEnd = 723335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetException(Il2CppSystem.Exception exception)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(59)]
	[CachedScanResults(RefRangeStart = 723338, RefRangeEnd = 723397, XrefRangeStart = 723335, XrefRangeEnd = 723338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723397, XrefRangeEnd = 723419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		//IL_0069: Expected Obj, but got VT
		//IL_007c: Expected Obj, but got VT
		//IL_0067->IL0067: Incompatible stack types: Obj vs VT
		//IL_007a->IL007a: Incompatible stack types: Obj vs VT
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false) : ((object)null));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 723431, RefRangeEnd = 723433, XrefRangeStart = 723419, XrefRangeEnd = 723431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		//IL_0069: Expected Obj, but got VT
		//IL_007c: Expected Obj, but got VT
		//IL_0067->IL0067: Incompatible stack types: Obj vs VT
		//IL_007a->IL007a: Incompatible stack types: Obj vs VT
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false) : ((object)null));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723433, XrefRangeEnd = 723496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start<TStateMachine>(ref TStateMachine stateMachine)
	{
		//IL_0051: Expected Obj, but got VT
		//IL_004f->IL004f: Incompatible stack types: Obj vs VT
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr4 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false) : ((object)null));
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ETAsyncTaskMethodBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ETAsyncTaskMethodBuilder()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder>.NativeClassPtr))
	{
	}
}
public sealed class ETAsyncTaskMethodBuilder<T> : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(ETAsyncTaskMethodBuilder<T>.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(ETAsyncTaskMethodBuilder<T>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(ETAsyncTaskMethodBuilder<T>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tcs;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ETAsyncTaskMethodBuilder_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Task_Public_get_ETTask_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Public_Void_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

	public unsafe ETTask<T> tcs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ETTask<T>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eTTask));
		}
	}

	public unsafe ETTask<T> Task
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28437, RefRangeEnd = 28438, XrefRangeStart = 28437, XrefRangeEnd = 28438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Task_Public_get_ETTask_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ETTask<T>>(intPtr) : null;
		}
	}

	static ETAsyncTaskMethodBuilder()
	{
		Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ET", "ETAsyncTaskMethodBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr);
		NativeFieldInfoPtr_tcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, "tcs");
		NativeMethodInfoPtr_Create_Public_Static_ETAsyncTaskMethodBuilder_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667201);
		NativeMethodInfoPtr_get_Task_Public_get_ETTask_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667202);
		NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667203);
		NativeMethodInfoPtr_SetResult_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667204);
		NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667205);
		NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr, 100667208);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 723505, RefRangeEnd = 723520, XrefRangeStart = 723496, XrefRangeEnd = 723505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ETAsyncTaskMethodBuilder<T> Create()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ETAsyncTaskMethodBuilder_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ETAsyncTaskMethodBuilder<T>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723520, XrefRangeEnd = 723531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetException(Il2CppSystem.Exception exception)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 723534, RefRangeEnd = 723546, XrefRangeStart = 723531, XrefRangeEnd = 723534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetResult(T ret)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = ret;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref ret;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResult_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723546, XrefRangeEnd = 723582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		//IL_0069: Expected Obj, but got VT
		//IL_007c: Expected Obj, but got VT
		//IL_0067->IL0067: Incompatible stack types: Obj vs VT
		//IL_007a->IL007a: Incompatible stack types: Obj vs VT
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ETAsyncTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false) : ((object)null));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723594, RefRangeEnd = 723595, XrefRangeStart = 723582, XrefRangeEnd = 723594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		//IL_0069: Expected Obj, but got VT
		//IL_007c: Expected Obj, but got VT
		//IL_0067->IL0067: Incompatible stack types: Obj vs VT
		//IL_007a->IL007a: Incompatible stack types: Obj vs VT
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ETAsyncTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false) : ((object)null));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723599, RefRangeEnd = 723600, XrefRangeStart = 723595, XrefRangeEnd = 723599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start<TStateMachine>(ref TStateMachine stateMachine)
	{
		//IL_0051: Expected Obj, but got VT
		//IL_004f->IL004f: Incompatible stack types: Obj vs VT
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ETAsyncTaskMethodBuilder<TStateMachine>.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr4 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false) : ((object)null));
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ETAsyncTaskMethodBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ETAsyncTaskMethodBuilder()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ETAsyncTaskMethodBuilder<T>>.NativeClassPtr))
	{
	}
}
