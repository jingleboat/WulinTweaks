using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class BattleTeam : Il2CppSystem.Object
{
	public enum TeamState
	{
		NotPresent,
		InBattle,
		Elimated,
		Escaped,
		Betraied,
		System
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_teamEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_teamState;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLevelOnActorJoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_minLevelOnActorJoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_actors;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Actors_Public_get_List_1_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BattleTeamEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinActor_Public_Void_BattleActor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeaveActor_Public_Void_BattleActor_TeamState_0;

	public unsafe BattleTeamEnum teamEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamEnum);
			return *(BattleTeamEnum*)num;
		}
		set
		{
			*(BattleTeamEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamEnum)) = battleTeamEnum;
		}
	}

	public unsafe TeamState teamState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamState);
			return *(TeamState*)num;
		}
		set
		{
			*(TeamState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamState)) = teamState;
		}
	}

	public unsafe int maxLevelOnActorJoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLevelOnActorJoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLevelOnActorJoint)) = num;
		}
	}

	public unsafe int minLevelOnActorJoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLevelOnActorJoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLevelOnActorJoint)) = num;
		}
	}

	public unsafe List<BattleActor> actors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BattleActor> Actors
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Actors_Public_get_List_1_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BattleActor>>(intPtr) : null;
		}
	}

	static BattleTeam()
	{
		Il2CppClassPointerStore<BattleTeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleTeam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr);
		NativeFieldInfoPtr_teamEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, "teamEnum");
		NativeFieldInfoPtr_teamState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, "teamState");
		NativeFieldInfoPtr_maxLevelOnActorJoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, "maxLevelOnActorJoint");
		NativeFieldInfoPtr_minLevelOnActorJoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, "minLevelOnActorJoint");
		NativeFieldInfoPtr_actors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, "actors");
		NativeMethodInfoPtr_get_Actors_Public_get_List_1_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, 100671484);
		NativeMethodInfoPtr__ctor_Public_Void_BattleTeamEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, 100671485);
		NativeMethodInfoPtr_JoinActor_Public_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, 100671486);
		NativeMethodInfoPtr_LeaveActor_Public_Void_BattleActor_TeamState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr, 100671487);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 781409, RefRangeEnd = 781417, XrefRangeStart = 781402, XrefRangeEnd = 781409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleTeam(BattleTeamEnum battleTeamEnum)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleTeam>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&battleTeamEnum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BattleTeamEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 781437, RefRangeEnd = 781441, XrefRangeStart = 781417, XrefRangeEnd = 781437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoinActor(BattleActor battleActor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinActor_Public_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 781448, RefRangeEnd = 781455, XrefRangeStart = 781441, XrefRangeEnd = 781448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveActor(BattleActor battleActor, TeamState leaveReason)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor);
		*(TeamState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &leaveReason;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaveActor_Public_Void_BattleActor_TeamState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleTeam(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
