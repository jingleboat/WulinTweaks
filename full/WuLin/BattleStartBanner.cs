using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class BattleStartBanner : UiSingletonPrefab<BattleStartBanner>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BattleStartBanner()
	{
		Il2CppClassPointerStore<BattleStartBanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleStartBanner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleStartBanner>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleStartBanner>.NativeClassPtr, 100675376);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 896713, XrefRangeEnd = 896719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleStartBanner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleStartBanner>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleStartBanner(IntPtr pointer)
		: base(pointer)
	{
	}
}
