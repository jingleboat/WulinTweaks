using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace ET;

[StructLayout(LayoutKind.Explicit)]
public struct AsyncETTaskCompletedMethodBuilder
{
	private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncETTaskCompletedMethodBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Task_Public_get_ETTaskCompleted_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

	public unsafe ETTaskCompleted Task
	{
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Task_Public_get_ETTaskCompleted_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ETTaskCompleted*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static AsyncETTaskCompletedMethodBuilder()
	{
		Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ET", "AsyncETTaskCompletedMethodBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_AsyncETTaskCompletedMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667185);
		NativeMethodInfoPtr_get_Task_Public_get_ETTaskCompleted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667186);
		NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667187);
		NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667188);
		NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667189);
		NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667190);
		NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667191);
		NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, 100667192);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncETTaskCompletedMethodBuilder Create()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AsyncETTaskCompletedMethodBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AsyncETTaskCompletedMethodBuilder*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723197, XrefRangeEnd = 723205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetException(Il2CppSystem.Exception e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetException_Public_Void_Exception_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetResult()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResult_Public_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723205, XrefRangeEnd = 723217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		//IL_0058: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got VT
		//IL_0056->IL0056: Incompatible stack types: Obj vs VT
		//IL_0069->IL0069: Incompatible stack types: Obj vs VT
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false) : ((object)null));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723217, XrefRangeEnd = 723229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		//IL_0058: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got VT
		//IL_0056->IL0056: Incompatible stack types: Obj vs VT
		//IL_0069->IL0069: Incompatible stack types: Obj vs VT
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false) : ((object)null));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false) : ((object)null));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723229, XrefRangeEnd = 723233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start<TStateMachine>(ref TStateMachine stateMachine)
	{
		//IL_0040: Expected Obj, but got VT
		//IL_003e->IL003e: Incompatible stack types: Obj vs VT
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr4 != (System.IntPtr)0) ? IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false) : ((object)null));
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncETTaskCompletedMethodBuilder>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
