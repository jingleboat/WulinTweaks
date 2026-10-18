using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin;

public class BattleFinishCondition : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_checkType;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_isValid;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTeam_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActor_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitFromStr_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveAsEndOfBattle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BattleFinishConditionCheckType checkType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkType);
			return *(BattleFinishConditionCheckType*)num;
		}
		set
		{
			*(BattleFinishConditionCheckType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkType)) = battleFinishConditionCheckType;
		}
	}

	public unsafe BattleFinishConditionCheckTarget checkTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkTarget);
			return *(BattleFinishConditionCheckTarget*)num;
		}
		set
		{
			*(BattleFinishConditionCheckTarget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkTarget)) = battleFinishConditionCheckTarget;
		}
	}

	public unsafe BattleTeamEnum checkTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkTeam);
			return *(BattleTeamEnum*)num;
		}
		set
		{
			*(BattleTeamEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkTeam)) = battleTeamEnum;
		}
	}

	public unsafe string checkActor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkActor);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkActor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValid)) = flag;
		}
	}

	public unsafe bool IsTeam
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsTeam_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsActor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749133, RefRangeEnd = 749134, XrefRangeStart = 749133, XrefRangeEnd = 749134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActor_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BattleFinishCondition()
	{
		Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BattleFinishCondition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr);
		NativeFieldInfoPtr_checkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, "checkType");
		NativeFieldInfoPtr_checkTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, "checkTarget");
		NativeFieldInfoPtr_checkTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, "checkTeam");
		NativeFieldInfoPtr_checkActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, "checkActor");
		NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, "isValid");
		NativeMethodInfoPtr_get_IsTeam_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, 100671488);
		NativeMethodInfoPtr_get_IsActor_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, 100671489);
		NativeMethodInfoPtr_InitFromStr_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, 100671490);
		NativeMethodInfoPtr_Check_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, 100671491);
		NativeMethodInfoPtr_ActiveAsEndOfBattle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, 100671492);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr, 100671493);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 781481, RefRangeEnd = 781483, XrefRangeStart = 781455, XrefRangeEnd = 781481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitFromStr(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitFromStr_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 781512, RefRangeEnd = 781513, XrefRangeStart = 781483, XrefRangeEnd = 781512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Check()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActiveAsEndOfBattle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveAsEndOfBattle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114078, RefRangeEnd = 114080, XrefRangeStart = 114078, XrefRangeEnd = 114080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleFinishCondition()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleFinishCondition>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BattleFinishCondition(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
