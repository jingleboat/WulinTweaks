using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class ImageHitAreaSettingComponent : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_MinAlphaThreshold;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float MinAlphaThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinAlphaThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinAlphaThreshold)) = num;
		}
	}

	static ImageHitAreaSettingComponent()
	{
		Il2CppClassPointerStore<ImageHitAreaSettingComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ImageHitAreaSettingComponent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageHitAreaSettingComponent>.NativeClassPtr);
		NativeFieldInfoPtr_MinAlphaThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageHitAreaSettingComponent>.NativeClassPtr, "MinAlphaThreshold");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageHitAreaSettingComponent>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageHitAreaSettingComponent>.NativeClassPtr, 100663963);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674019, XrefRangeEnd = 674022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674022, XrefRangeEnd = 674023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImageHitAreaSettingComponent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageHitAreaSettingComponent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImageHitAreaSettingComponent(IntPtr pointer)
		: base(pointer)
	{
	}
}
