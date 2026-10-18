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
using UnityEngine.UI;

public static class LoopScrollRectHelper : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_AddUIScrollItems_Public_Static_Void_byref_Dictionary_2_Int32_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddUIScrollItems_Public_Static_Void_byref_Dictionary_2_Int32_T_Int32_0, Il2CppClassPointerStore<LoopScrollRectHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_logicItemPool;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Static_Void_LoopScrollRect_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUIScrollItems_Public_Static_Void_byref_Dictionary_2_Int32_T_Int32_0;

	public unsafe static Dictionary<Il2CppSystem.Type, Queue<Il2CppSystem.Object>> logicItemPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logicItemPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Queue<Il2CppSystem.Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logicItemPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static LoopScrollRectHelper()
	{
		Il2CppClassPointerStore<LoopScrollRectHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LoopScrollRectHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopScrollRectHelper>.NativeClassPtr);
		NativeFieldInfoPtr_logicItemPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopScrollRectHelper>.NativeClassPtr, "logicItemPool");
		NativeMethodInfoPtr_SetVisible_Public_Static_Void_LoopScrollRect_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopScrollRectHelper>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr_AddUIScrollItems_Public_Static_Void_byref_Dictionary_2_Int32_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopScrollRectHelper>.NativeClassPtr, 100663785);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 671393, RefRangeEnd = 671412, XrefRangeStart = 671390, XrefRangeEnd = 671393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVisible(this LoopScrollRect loopScrollRect, bool isVisible, int count = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopScrollRect);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isVisible;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVisible_Public_Static_Void_LoopScrollRect_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 671467, RefRangeEnd = 671477, XrefRangeStart = 671412, XrefRangeEnd = 671467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddUIScrollItems<T>(ref Dictionary<int, T> dictionary, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddUIScrollItems_Public_Static_Void_byref_Dictionary_2_Int32_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<int, T>(intPtr4));
	}

	public LoopScrollRectHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
