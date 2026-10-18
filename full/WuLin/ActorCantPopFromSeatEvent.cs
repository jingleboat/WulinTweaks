using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace WuLin;

public class ActorCantPopFromSeatEvent : BattleFieldEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_actor;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BattleActor actor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	static ActorCantPopFromSeatEvent()
	{
		Il2CppClassPointerStore<ActorCantPopFromSeatEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ActorCantPopFromSeatEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorCantPopFromSeatEvent>.NativeClassPtr);
		NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCantPopFromSeatEvent>.NativeClassPtr, "actor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorCantPopFromSeatEvent>.NativeClassPtr, 100671279);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 774634, RefRangeEnd = 774647, XrefRangeStart = 774634, XrefRangeEnd = 774647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorCantPopFromSeatEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorCantPopFromSeatEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActorCantPopFromSeatEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
