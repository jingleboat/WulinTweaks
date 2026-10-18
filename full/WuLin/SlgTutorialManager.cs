using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class SlgTutorialManager : MonoSingleton<SlgTutorialManager>
{
	private static readonly IntPtr NativeMethodInfoPtr_Tutorial_BattleRecord_Public_Void_byref_Dlc1InvasionBattleData_0;

	private static readonly IntPtr NativeMethodInfoPtr_Tutorial_BattleWriteString_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Tutorial_CureWriteString_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SlgTutorialManager()
	{
		Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SlgTutorialManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr);
		NativeMethodInfoPtr_Tutorial_BattleRecord_Public_Void_byref_Dlc1InvasionBattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr, 100679625);
		NativeMethodInfoPtr_Tutorial_BattleWriteString_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr, 100679626);
		NativeMethodInfoPtr_Tutorial_CureWriteString_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr, 100679627);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr, 100679628);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007938, RefRangeEnd = 1007939, XrefRangeStart = 1007929, XrefRangeEnd = 1007938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tutorial_BattleRecord(ref Dlc1InvasionBattleData invasionBattleData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)invasionBattleData);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr3);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tutorial_BattleRecord_Public_Void_byref_Dlc1InvasionBattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		invasionBattleData = ((intPtr4 == (IntPtr)0) ? null : new Dlc1InvasionBattleData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007966, RefRangeEnd = 1007967, XrefRangeStart = 1007939, XrefRangeEnd = 1007966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tutorial_BattleWriteString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tutorial_BattleWriteString_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007983, RefRangeEnd = 1007984, XrefRangeStart = 1007967, XrefRangeEnd = 1007983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tutorial_CureWriteString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tutorial_CureWriteString_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007984, XrefRangeEnd = 1007990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgTutorialManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgTutorialManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgTutorialManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
