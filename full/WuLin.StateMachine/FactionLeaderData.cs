using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin.StateMachine;

public class FactionLeaderData : StateMachineData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_paras;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<Il2CppSystem.Object> paras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paras);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paras)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static FactionLeaderData()
	{
		Il2CppClassPointerStore<FactionLeaderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "FactionLeaderData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionLeaderData>.NativeClassPtr);
		NativeFieldInfoPtr_paras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionLeaderData>.NativeClassPtr, "paras");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionLeaderData>.NativeClassPtr, 100680847);
	}

	[CallerCount(458)]
	[CachedScanResults(RefRangeStart = 26910, RefRangeEnd = 27368, XrefRangeStart = 26910, XrefRangeEnd = 27368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionLeaderData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionLeaderData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FactionLeaderData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
