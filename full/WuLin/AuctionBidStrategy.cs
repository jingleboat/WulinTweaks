using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin;

public class AuctionBidStrategy : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastUseTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_CD;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCdDuration_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float IncreaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncreaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncreaseRate)) = num;
		}
	}

	public unsafe float LastUseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUseTime)) = num;
		}
	}

	public unsafe float CD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CD);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CD)) = num;
		}
	}

	static AuctionBidStrategy()
	{
		Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "AuctionBidStrategy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr);
		NativeFieldInfoPtr_IncreaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr, "IncreaseRate");
		NativeFieldInfoPtr_LastUseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr, "LastUseTime");
		NativeFieldInfoPtr_CD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr, "CD");
		NativeMethodInfoPtr_GetCdDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr, 100674260);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr, 100674261);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863817, XrefRangeEnd = 863819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCdDuration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCdDuration_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863819, XrefRangeEnd = 863820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AuctionBidStrategy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuctionBidStrategy>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AuctionBidStrategy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
