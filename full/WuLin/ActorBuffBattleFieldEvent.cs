using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class ActorBuffBattleFieldEvent : BattleFieldEvent
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ActorBuffBattleFieldEvent()
	{
		Il2CppClassPointerStore<ActorBuffBattleFieldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ActorBuffBattleFieldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorBuffBattleFieldEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorBuffBattleFieldEvent>.NativeClassPtr, 100671258);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 774634, RefRangeEnd = 774647, XrefRangeStart = 774634, XrefRangeEnd = 774647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorBuffBattleFieldEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorBuffBattleFieldEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActorBuffBattleFieldEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
