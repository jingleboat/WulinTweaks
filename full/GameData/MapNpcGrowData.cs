using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace GameData;

public class MapNpcGrowData : SerializedScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_diff0;

	private static readonly IntPtr NativeFieldInfoPtr_diff1;

	private static readonly IntPtr NativeFieldInfoPtr_diff2;

	private static readonly IntPtr NativeFieldInfoPtr_diff3;

	private static readonly IntPtr NativeFieldInfoPtr_freeDiff;

	private static readonly IntPtr NativeMethodInfoPtr_GetCurDiff_Public_NpcGrowDiffcult_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NpcGrowDiffcult diff0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff0);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcGrowDiffcult>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcGrowDiffcult));
		}
	}

	public unsafe NpcGrowDiffcult diff1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff1);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcGrowDiffcult>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcGrowDiffcult));
		}
	}

	public unsafe NpcGrowDiffcult diff2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff2);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcGrowDiffcult>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcGrowDiffcult));
		}
	}

	public unsafe NpcGrowDiffcult diff3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff3);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcGrowDiffcult>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcGrowDiffcult));
		}
	}

	public unsafe Dictionary<int, NpcGrowDiffcult> freeDiff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeDiff);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NpcGrowDiffcult>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeDiff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static MapNpcGrowData()
	{
		Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "MapNpcGrowData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr);
		NativeFieldInfoPtr_diff0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, "diff0");
		NativeFieldInfoPtr_diff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, "diff1");
		NativeFieldInfoPtr_diff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, "diff2");
		NativeFieldInfoPtr_diff3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, "diff3");
		NativeFieldInfoPtr_freeDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, "freeDiff");
		NativeMethodInfoPtr_GetCurDiff_Public_NpcGrowDiffcult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, 100664657);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr, 100664658);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 694833, RefRangeEnd = 694838, XrefRangeStart = 694827, XrefRangeEnd = 694833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcGrowDiffcult GetCurDiff(int diff)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&diff);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurDiff_Public_NpcGrowDiffcult_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcGrowDiffcult>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694838, XrefRangeEnd = 694858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapNpcGrowData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapNpcGrowData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MapNpcGrowData(IntPtr pointer)
		: base(pointer)
	{
	}
}
