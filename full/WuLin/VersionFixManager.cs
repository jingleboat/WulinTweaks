using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class VersionFixManager : MonoSingleton<VersionFixManager>
{
	private static readonly IntPtr NativeMethodInfoPtr_Fix_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static VersionFixManager()
	{
		Il2CppClassPointerStore<VersionFixManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "VersionFixManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionFixManager>.NativeClassPtr);
		NativeMethodInfoPtr_Fix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionFixManager>.NativeClassPtr, 100674082);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionFixManager>.NativeClassPtr, 100674083);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860382, RefRangeEnd = 860383, XrefRangeStart = 860341, XrefRangeEnd = 860382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Fix()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860383, XrefRangeEnd = 860389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionFixManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionFixManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VersionFixManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
