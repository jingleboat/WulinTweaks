using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

[System.Serializable]
public class SlgModeState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_faction;

	private static readonly System.IntPtr NativeFieldInfoPtr_curHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_curEp;

	private static readonly System.IntPtr NativeFieldInfoPtr__slgFactionJob_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobForCurrentTurn;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_slgFactionJob_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_slgFactionJob_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFactionInstance_Public_Dlc1FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactionJob_Public_Void_Int32_0;

	public unsafe int faction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faction)) = num;
		}
	}

	public unsafe int curHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curHp)) = num;
		}
	}

	public unsafe int curEp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curEp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curEp)) = num;
		}
	}

	public unsafe int _slgFactionJob_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__slgFactionJob_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__slgFactionJob_k__BackingField)) = num;
		}
	}

	public unsafe SlgActionType jobForCurrentTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobForCurrentTurn);
			return *(SlgActionType*)num;
		}
		set
		{
			*(SlgActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobForCurrentTurn)) = slgActionType;
		}
	}

	public unsafe int slgFactionJob
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_slgFactionJob_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 55077, RefRangeEnd = 55079, XrefRangeStart = 55077, XrefRangeEnd = 55079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_slgFactionJob_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SlgModeState()
	{
		Il2CppClassPointerStore<SlgModeState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SlgModeState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr);
		NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, "faction");
		NativeFieldInfoPtr_curHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, "curHp");
		NativeFieldInfoPtr_curEp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, "curEp");
		NativeFieldInfoPtr__slgFactionJob_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, "<slgFactionJob>k__BackingField");
		NativeFieldInfoPtr_jobForCurrentTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, "jobForCurrentTurn");
		NativeMethodInfoPtr_get_slgFactionJob_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, 100672496);
		NativeMethodInfoPtr_set_slgFactionJob_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, 100672497);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, 100672498);
		NativeMethodInfoPtr__ctor_Public_Void_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, 100672499);
		NativeMethodInfoPtr_GetFactionInstance_Public_Dlc1FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, 100672500);
		NativeMethodInfoPtr_SetFactionJob_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr, 100672501);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 813351, RefRangeEnd = 813352, XrefRangeStart = 813350, XrefRangeEnd = 813351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgModeState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 813359, RefRangeEnd = 813360, XrefRangeStart = 813352, XrefRangeEnd = 813359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgModeState(GameCharacterInstance gameCharacterInstance)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgModeState>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameCharacterInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813360, XrefRangeEnd = 813368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dlc1FactionInstance GetFactionInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFactionInstance_Public_Dlc1FactionInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dlc1FactionInstance>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55077, RefRangeEnd = 55079, XrefRangeStart = 55077, XrefRangeEnd = 55079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFactionJob(int slgFactionJob)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&slgFactionJob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactionJob_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgModeState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
