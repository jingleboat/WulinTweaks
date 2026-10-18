using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

public class AuctionBidInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Bidder;

	private static readonly System.IntPtr NativeFieldInfoPtr_Money;

	private static readonly System.IntPtr NativeFieldInfoPtr_Strategy;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AuctionRole Bidder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bidder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AuctionRole>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bidder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)auctionRole));
		}
	}

	public unsafe int Money
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Money);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Money)) = num;
		}
	}

	public unsafe AuctionBidStrategy Strategy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strategy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AuctionBidStrategy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strategy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)auctionBidStrategy));
		}
	}

	static AuctionBidInfo()
	{
		Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "AuctionBidInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Bidder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr, "Bidder");
		NativeFieldInfoPtr_Money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr, "Money");
		NativeFieldInfoPtr_Strategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr, "Strategy");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr, 100674259);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AuctionBidInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuctionBidInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AuctionBidInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
