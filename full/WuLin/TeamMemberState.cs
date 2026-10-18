using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace WuLin;

[System.Serializable]
public class TeamMemberState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isJoined;

	private static readonly System.IntPtr NativeFieldInfoPtr_curHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_curEp;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaveTeamMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaveTeamPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaveTeamDir;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isJoined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJoined);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJoined)) = flag;
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

	public unsafe int leaveTeamMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveTeamMap);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveTeamMap)) = num;
		}
	}

	public unsafe Vector3Int leaveTeamPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveTeamPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveTeamPos)) = vector3Int;
		}
	}

	public unsafe TileDirection leaveTeamDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveTeamDir);
			return *(TileDirection*)num;
		}
		set
		{
			*(TileDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveTeamDir)) = tileDirection;
		}
	}

	static TeamMemberState()
	{
		Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "TeamMemberState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr);
		NativeFieldInfoPtr_isJoined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, "isJoined");
		NativeFieldInfoPtr_curHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, "curHp");
		NativeFieldInfoPtr_curEp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, "curEp");
		NativeFieldInfoPtr_leaveTeamMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, "leaveTeamMap");
		NativeFieldInfoPtr_leaveTeamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, "leaveTeamPos");
		NativeFieldInfoPtr_leaveTeamDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, "leaveTeamDir");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr, 100672495);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 813347, RefRangeEnd = 813350, XrefRangeStart = 813346, XrefRangeEnd = 813347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TeamMemberState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeamMemberState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TeamMemberState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
