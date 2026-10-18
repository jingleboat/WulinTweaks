using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class AchievementGlobalSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_complatedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_listTaskData;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeFrom_Public_Boolean_AchievementGlobalSaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<int> complatedData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complatedData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complatedData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, BitData> listTaskData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listTaskData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, BitData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listTaskData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static AchievementGlobalSaveData()
	{
		Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "AchievementGlobalSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_complatedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr, "complatedData");
		NativeFieldInfoPtr_listTaskData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr, "listTaskData");
		NativeMethodInfoPtr_MergeFrom_Public_Boolean_AchievementGlobalSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr, 100671885);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr, 100671886);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794499, RefRangeEnd = 794501, XrefRangeStart = 794459, XrefRangeEnd = 794499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MergeFrom(AchievementGlobalSaveData other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeFrom_Public_Boolean_AchievementGlobalSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794508, RefRangeEnd = 794511, XrefRangeStart = 794501, XrefRangeEnd = 794508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AchievementGlobalSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementGlobalSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AchievementGlobalSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
