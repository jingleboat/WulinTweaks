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

public class BattleAuraInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_auraData;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionCheckOwner;

	private static readonly System.IntPtr NativeFieldInfoPtr_factionCheckActor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleAuraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MayAffect_Public_Boolean_BattleActor_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactionCheck_Private_Boolean_BattleActor_BattleActor_0;

	public unsafe BattleAuraData auraData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auraData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleAuraData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auraData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleAuraData));
		}
	}

	public unsafe static HashSet<int> factionCheckOwner
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_factionCheckOwner, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_factionCheckOwner, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static HashSet<int> factionCheckActor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_factionCheckActor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_factionCheckActor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static BattleAuraInstance()
	{
		Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleAuraInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr);
		NativeFieldInfoPtr_auraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr, "auraData");
		NativeFieldInfoPtr_factionCheckOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr, "factionCheckOwner");
		NativeFieldInfoPtr_factionCheckActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr, "factionCheckActor");
		NativeMethodInfoPtr__ctor_Public_Void_BattleAuraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr, 100671135);
		NativeMethodInfoPtr_MayAffect_Public_Boolean_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr, 100671136);
		NativeMethodInfoPtr_FactionCheck_Private_Boolean_BattleActor_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr, 100671137);
	}

	[CallerCount(171)]
	[CachedScanResults(RefRangeStart = 27398, RefRangeEnd = 27569, XrefRangeStart = 27398, XrefRangeEnd = 27569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleAuraInstance(BattleAuraData auraData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleAuraInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)auraData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleAuraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 772412, RefRangeEnd = 772413, XrefRangeStart = 772401, XrefRangeEnd = 772412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MayAffect(BattleActor owner, BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MayAffect_Public_Boolean_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772413, XrefRangeEnd = 772488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FactionCheck(BattleActor owner, BattleActor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactionCheck_Private_Boolean_BattleActor_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BattleAuraInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
