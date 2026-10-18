using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace ET;

[StructLayout(LayoutKind.Explicit)]
public struct ETTaskCompleted : INotifyCompletion
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ETTaskCompleted_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

	public unsafe bool IsCompleted
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ETTaskCompleted()
	{
		Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ET", "ETTaskCompleted");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr);
		NativeMethodInfoPtr_GetAwaiter_Public_ETTaskCompleted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr, 100667252);
		NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr, 100667256);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 305708, RefRangeEnd = 305737, XrefRangeStart = 305708, XrefRangeEnd = 305737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ETTaskCompleted GetAwaiter()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAwaiter_Public_ETTaskCompleted_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ETTaskCompleted*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetResult()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResult_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnCompleted(Il2CppSystem.Action continuation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnsafeOnCompleted(Il2CppSystem.Action continuation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ETTaskCompleted>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void OnCompleted(System.Action continuation)
	{
		OnCompleted((Il2CppSystem.Action)continuation);
	}
}
