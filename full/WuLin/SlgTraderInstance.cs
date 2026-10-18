using System;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public class SlgTraderInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Templete;

	private static readonly System.IntPtr NativeFieldInfoPtr_isVisiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextVistingStateChange;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCTrader_Dlc1FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTradePortrait_Public_Sprite_0;

	public unsafe DLCTrader Templete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Templete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DLCTrader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Templete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCTrader));
		}
	}

	public unsafe bool isVisiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isVisiting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isVisiting)) = flag;
		}
	}

	public unsafe int nextVistingStateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextVistingStateChange);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextVistingStateChange)) = num;
		}
	}

	static SlgTraderInstance()
	{
		Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SlgTraderInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr);
		NativeFieldInfoPtr_Templete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr, "Templete");
		NativeFieldInfoPtr_isVisiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr, "isVisiting");
		NativeFieldInfoPtr_nextVistingStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr, "nextVistingStateChange");
		NativeMethodInfoPtr__ctor_Public_Void_DLCTrader_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr, 100679450);
		NativeMethodInfoPtr_GetTradePortrait_Public_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr, 100679451);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003850, RefRangeEnd = 1003851, XrefRangeStart = 1003836, XrefRangeEnd = 1003850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgTraderInstance(DLCTrader trader, Dlc1FactionInstance factionInstance)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgTraderInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DLCTrader_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1003863, RefRangeEnd = 1003864, XrefRangeStart = 1003851, XrefRangeEnd = 1003863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetTradePortrait()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTradePortrait_Public_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	public SlgTraderInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
