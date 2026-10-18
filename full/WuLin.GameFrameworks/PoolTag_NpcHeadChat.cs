using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.GameFrameworks;

public class PoolTag_NpcHeadChat : PoolAnalysis
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PoolTag_NpcHeadChat()
	{
		Il2CppClassPointerStore<PoolTag_NpcHeadChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.GameFrameworks", "PoolTag_NpcHeadChat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolTag_NpcHeadChat>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolTag_NpcHeadChat>.NativeClassPtr, 100680741);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030805, XrefRangeEnd = 1030813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolTag_NpcHeadChat()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolTag_NpcHeadChat>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PoolTag_NpcHeadChat(IntPtr pointer)
		: base(pointer)
	{
	}
}
