using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace ChartAndGraph;

public class ChartItemMaterialLerpEffect : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float LerpTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LerpTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LerpTime)) = num;
		}
	}

	static ChartItemMaterialLerpEffect()
	{
		Il2CppClassPointerStore<ChartItemMaterialLerpEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "ChartItemMaterialLerpEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartItemMaterialLerpEffect>.NativeClassPtr);
		NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartItemMaterialLerpEffect>.NativeClassPtr, "LerpTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartItemMaterialLerpEffect>.NativeClassPtr, 100669854);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartItemMaterialLerpEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartItemMaterialLerpEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChartItemMaterialLerpEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}
