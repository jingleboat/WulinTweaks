using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin;

public class DeviceBugManager : MonoSingleton<DeviceBugManager>
{
	private static readonly IntPtr NativeFieldInfoPtr_noResourceReleaseOnGC;

	private static readonly IntPtr NativeFieldInfoPtr_noReleaseMiscItem;

	private static readonly IntPtr NativeFieldInfoPtr_noAssetBundleCache;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckBuggyDevice_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResMgrConfig_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool noResourceReleaseOnGC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noResourceReleaseOnGC);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noResourceReleaseOnGC)) = flag;
		}
	}

	public unsafe bool noReleaseMiscItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noReleaseMiscItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noReleaseMiscItem)) = flag;
		}
	}

	public unsafe bool noAssetBundleCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAssetBundleCache);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAssetBundleCache)) = flag;
		}
	}

	static DeviceBugManager()
	{
		Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DeviceBugManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr);
		NativeFieldInfoPtr_noResourceReleaseOnGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, "noResourceReleaseOnGC");
		NativeFieldInfoPtr_noReleaseMiscItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, "noReleaseMiscItem");
		NativeFieldInfoPtr_noAssetBundleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, "noAssetBundleCache");
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, 100671964);
		NativeMethodInfoPtr_CheckBuggyDevice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, 100671965);
		NativeMethodInfoPtr_ResMgrConfig_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, 100671966);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr, 100671967);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795971, XrefRangeEnd = 795986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795986, XrefRangeEnd = 795998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckBuggyDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckBuggyDevice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795998, XrefRangeEnd = 796002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResMgrConfig()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResMgrConfig_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796002, XrefRangeEnd = 796008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeviceBugManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceBugManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DeviceBugManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
