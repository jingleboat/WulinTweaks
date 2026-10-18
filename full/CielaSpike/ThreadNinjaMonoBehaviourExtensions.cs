using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace CielaSpike;

public static class ThreadNinjaMonoBehaviourExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutineAsync_Public_Static_Coroutine_MonoBehaviour_IEnumerator_byref_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartCoroutineAsync_Public_Static_Coroutine_MonoBehaviour_IEnumerator_0;

	static ThreadNinjaMonoBehaviourExtensions()
	{
		Il2CppClassPointerStore<ThreadNinjaMonoBehaviourExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "CielaSpike", "ThreadNinjaMonoBehaviourExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadNinjaMonoBehaviourExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_StartCoroutineAsync_Public_Static_Coroutine_MonoBehaviour_IEnumerator_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadNinjaMonoBehaviourExtensions>.NativeClassPtr, 100665406);
		NativeMethodInfoPtr_StartCoroutineAsync_Public_Static_Coroutine_MonoBehaviour_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadNinjaMonoBehaviourExtensions>.NativeClassPtr, 100665407);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706904, XrefRangeEnd = 706910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Coroutine StartCoroutineAsync(this MonoBehaviour behaviour, IEnumerator routine, out Task task)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)behaviour);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)routine);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCoroutineAsync_Public_Static_Coroutine_MonoBehaviour_IEnumerator_byref_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		task = ((num3 == 0) ? null : new Task(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Coroutine>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 706916, RefRangeEnd = 706919, XrefRangeStart = 706910, XrefRangeEnd = 706916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Coroutine StartCoroutineAsync(this MonoBehaviour behaviour, IEnumerator routine)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)behaviour);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)routine);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCoroutineAsync_Public_Static_Coroutine_MonoBehaviour_IEnumerator_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Coroutine>(intPtr) : null;
	}

	public ThreadNinjaMonoBehaviourExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
