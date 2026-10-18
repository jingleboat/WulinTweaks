using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace XLua;

public class ObjectTranslatorPool : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_translators;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTranslator;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ObjectTranslatorPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_IntPtr_ObjectTranslator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_ObjectTranslator_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_IntPtr_0;

	public unsafe Dictionary<System.IntPtr, Il2CppSystem.WeakReference> translators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translators);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<System.IntPtr, Il2CppSystem.WeakReference>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translators)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe System.IntPtr lastPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPtr)) = intPtr;
		}
	}

	public unsafe ObjectTranslator lastTranslator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTranslator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectTranslator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTranslator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectTranslator));
		}
	}

	public unsafe static ObjectTranslatorPool Instance
	{
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 700237, RefRangeEnd = 700284, XrefRangeStart = 700232, XrefRangeEnd = 700237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_ObjectTranslatorPool_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectTranslatorPool>(intPtr) : null;
		}
	}

	static ObjectTranslatorPool()
	{
		Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "ObjectTranslatorPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr);
		NativeFieldInfoPtr_translators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, "translators");
		NativeFieldInfoPtr_lastPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, "lastPtr");
		NativeFieldInfoPtr_lastTranslator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, "lastTranslator");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_ObjectTranslatorPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr_Add_Public_Void_IntPtr_ObjectTranslator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr_Find_Public_ObjectTranslator_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr_Remove_Public_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr, 100664980);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700291, RefRangeEnd = 700292, XrefRangeStart = 700284, XrefRangeEnd = 700291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectTranslatorPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTranslatorPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700301, RefRangeEnd = 700302, XrefRangeStart = 700292, XrefRangeEnd = 700301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(System.IntPtr L, ObjectTranslator translator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&L);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)translator);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_IntPtr_ObjectTranslator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 700309, RefRangeEnd = 700354, XrefRangeStart = 700302, XrefRangeEnd = 700309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectTranslator Find(System.IntPtr L)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Public_ObjectTranslator_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectTranslator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700362, RefRangeEnd = 700363, XrefRangeStart = 700354, XrefRangeEnd = 700362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(System.IntPtr L)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&L);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectTranslatorPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
