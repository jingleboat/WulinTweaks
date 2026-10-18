using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin;

public class Dlc1InvasionBattleResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isAttackFactionWin;

	private static readonly System.IntPtr NativeFieldInfoPtr_isQuickBattle;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isAttackFactionWin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttackFactionWin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttackFactionWin)) = flag;
		}
	}

	public unsafe bool isQuickBattle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isQuickBattle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isQuickBattle)) = flag;
		}
	}

	static Dlc1InvasionBattleResult()
	{
		Il2CppClassPointerStore<Dlc1InvasionBattleResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "Dlc1InvasionBattleResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dlc1InvasionBattleResult>.NativeClassPtr);
		NativeFieldInfoPtr_isAttackFactionWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleResult>.NativeClassPtr, "isAttackFactionWin");
		NativeFieldInfoPtr_isQuickBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dlc1InvasionBattleResult>.NativeClassPtr, "isQuickBattle");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dlc1InvasionBattleResult>.NativeClassPtr, 100679025);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1InvasionBattleResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dlc1InvasionBattleResult>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Dlc1InvasionBattleResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
