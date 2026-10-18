using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class FactionGoodList : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_faction;

	private static readonly System.IntPtr NativeFieldInfoPtr_allItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_onGoodChange;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemByJob_Public_List_1_FactionGoodItem_FactionJobData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FactionInstance faction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance));
		}
	}

	public unsafe List<FactionGoodItem> allItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionGoodItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppSystem.Action onGoodChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onGoodChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onGoodChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static FactionGoodList()
	{
		Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "FactionGoodList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr);
		NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr, "faction");
		NativeFieldInfoPtr_allItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr, "allItem");
		NativeFieldInfoPtr_onGoodChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr, "onGoodChange");
		NativeMethodInfoPtr_Init_Public_Void_FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr, 100672085);
		NativeMethodInfoPtr_GetItemByJob_Public_List_1_FactionGoodItem_FactionJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr, 100672086);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr, 100672087);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 800460, RefRangeEnd = 800461, XrefRangeStart = 800431, XrefRangeEnd = 800460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(FactionInstance factionInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 800484, RefRangeEnd = 800491, XrefRangeStart = 800461, XrefRangeEnd = 800484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<FactionGoodItem> GetItemByJob(FactionJobData factionJobData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionJobData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemByJob_Public_List_1_FactionGoodItem_FactionJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactionGoodItem>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800491, XrefRangeEnd = 800498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionGoodList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionGoodList>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FactionGoodList(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
