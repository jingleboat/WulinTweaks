using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class GameModeSelectUI : UiSingletonPrefab<GameModeSelectUI>
{
	private static readonly IntPtr NativeMethodInfoPtr_SelectMode_Public_Void_GameDlcMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_QuitGame_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__SelectMode_b__0_0_Private_Void_0;

	static GameModeSelectUI()
	{
		Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameModeSelectUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr);
		NativeMethodInfoPtr_SelectMode_Public_Void_GameDlcMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr, 100676305);
		NativeMethodInfoPtr_QuitGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr, 100676306);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr, 100676307);
		NativeMethodInfoPtr__SelectMode_b__0_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr, 100676308);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 921750, RefRangeEnd = 921751, XrefRangeStart = 921700, XrefRangeEnd = 921750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectMode(GameDlcMode gameDlcMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&gameDlcMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectMode_Public_Void_GameDlcMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921751, XrefRangeEnd = 921752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QuitGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuitGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921752, XrefRangeEnd = 921758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameModeSelectUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameModeSelectUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _SelectMode_b__0_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SelectMode_b__0_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameModeSelectUI(IntPtr pointer)
		: base(pointer)
	{
	}
}
