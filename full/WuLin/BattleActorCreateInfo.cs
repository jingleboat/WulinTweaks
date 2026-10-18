using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

[System.Serializable]
public sealed class BattleActorCreateInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_battleTeamEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	private static readonly System.IntPtr NativeFieldInfoPtr_actorView;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasJumpInAnim;

	public unsafe BattleTeamEnum battleTeamEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleTeamEnum);
			return *(BattleTeamEnum*)num;
		}
		set
		{
			*(BattleTeamEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleTeamEnum)) = battleTeamEnum;
		}
	}

	public unsafe GameCharacterInstance characterInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
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

	public unsafe ActorViewElemenetAdapator actorView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActorViewElemenetAdapator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorViewElemenetAdapator));
		}
	}

	public unsafe TileDirection dir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir)) = tileDirection;
		}
	}

	public unsafe bool hasJumpInAnim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasJumpInAnim);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasJumpInAnim)) = flag;
		}
	}

	static BattleActorCreateInfo()
	{
		Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleActorCreateInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr);
		NativeFieldInfoPtr_battleTeamEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, "battleTeamEnum");
		NativeFieldInfoPtr_characterInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, "characterInstance");
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_actorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, "actorView");
		NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, "dir");
		NativeFieldInfoPtr_hasJumpInAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr, "hasJumpInAnim");
	}

	public BattleActorCreateInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BattleActorCreateInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleActorCreateInfo>.NativeClassPtr))
	{
	}
}
