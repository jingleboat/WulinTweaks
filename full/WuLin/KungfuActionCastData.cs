using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

public sealed class KungfuActionCastData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_battleActorActionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	public unsafe BattleActorActionType battleActorActionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorActionType);
			return *(BattleActorActionType*)num;
		}
		set
		{
			*(BattleActorActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorActionType)) = battleActorActionType;
		}
	}

	public unsafe KungfuInstance kungfuInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
		}
	}

	public unsafe GameItemInstance itemInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameItemInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameItemInstance));
		}
	}

	public unsafe Vector3Int pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector3Int;
		}
	}

	static KungfuActionCastData()
	{
		Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "KungfuActionCastData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr);
		NativeFieldInfoPtr_battleActorActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr, "battleActorActionType");
		NativeFieldInfoPtr_kungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr, "kungfuInstance");
		NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr, "itemInstance");
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr, "pos");
	}

	public KungfuActionCastData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public KungfuActionCastData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KungfuActionCastData>.NativeClassPtr))
	{
	}
}
