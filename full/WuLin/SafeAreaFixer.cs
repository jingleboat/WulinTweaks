using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace WuLin;

public class SafeAreaFixer : MonoBehaviour
{
	public enum SafeAreaFixerType
	{
		FullScreenRec = 0,
		SafeAreaSelf = 100
	}

	private static readonly IntPtr NativeFieldInfoPtr_safeAreaFixerType;

	private static readonly IntPtr NativeFieldInfoPtr_fixAtStart;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixSelf_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SafeAreaFixerType safeAreaFixerType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeAreaFixerType);
			return *(SafeAreaFixerType*)num;
		}
		set
		{
			*(SafeAreaFixerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeAreaFixerType)) = safeAreaFixerType;
		}
	}

	public unsafe bool fixAtStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fixAtStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fixAtStart)) = flag;
		}
	}

	static SafeAreaFixer()
	{
		Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SafeAreaFixer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr);
		NativeFieldInfoPtr_safeAreaFixerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr, "safeAreaFixerType");
		NativeFieldInfoPtr_fixAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr, "fixAtStart");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr, 100673528);
		NativeMethodInfoPtr_FixSelf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr, 100673529);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr, 100673530);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845705, XrefRangeEnd = 845706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 845717, RefRangeEnd = 845718, XrefRangeStart = 845706, XrefRangeEnd = 845717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixSelf()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixSelf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeAreaFixer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAreaFixer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SafeAreaFixer(IntPtr pointer)
		: base(pointer)
	{
	}
}
