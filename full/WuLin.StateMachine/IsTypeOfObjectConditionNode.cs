using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.StateMachine;

public class IsTypeOfObjectConditionNode : StateMachineConditionNode
{
	private static readonly IntPtr NativeFieldInfoPtr_isChest;

	private static readonly IntPtr NativeFieldInfoPtr_isDoor;

	private static readonly IntPtr NativeFieldInfoPtr_isLight;

	private static readonly IntPtr NativeFieldInfoPtr_isTeleport;

	private static readonly IntPtr NativeFieldInfoPtr_isResPit;

	private static readonly IntPtr NativeFieldInfoPtr_isCookTable;

	private static readonly IntPtr NativeFieldInfoPtr_isBulletin;

	private static readonly IntPtr NativeFieldInfoPtr_isFiefStele;

	private static readonly IntPtr NativeFieldInfoPtr_isFiefTable;

	private static readonly IntPtr NativeFieldInfoPtr_IsFiefDevelop;

	private static readonly IntPtr NativeFieldInfoPtr_IsSwornTable;

	private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isChest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChest)) = flag;
		}
	}

	public unsafe bool isDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDoor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDoor)) = flag;
		}
	}

	public unsafe bool isLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLight)) = flag;
		}
	}

	public unsafe bool isTeleport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTeleport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTeleport)) = flag;
		}
	}

	public unsafe bool isResPit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isResPit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isResPit)) = flag;
		}
	}

	public unsafe bool isCookTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCookTable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCookTable)) = flag;
		}
	}

	public unsafe bool isBulletin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBulletin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBulletin)) = flag;
		}
	}

	public unsafe bool isFiefStele
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFiefStele);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFiefStele)) = flag;
		}
	}

	public unsafe bool isFiefTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFiefTable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFiefTable)) = flag;
		}
	}

	public unsafe bool IsFiefDevelop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFiefDevelop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFiefDevelop)) = flag;
		}
	}

	public unsafe bool IsSwornTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSwornTable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSwornTable)) = flag;
		}
	}

	static IsTypeOfObjectConditionNode()
	{
		Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "IsTypeOfObjectConditionNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr);
		NativeFieldInfoPtr_isChest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isChest");
		NativeFieldInfoPtr_isDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isDoor");
		NativeFieldInfoPtr_isLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isLight");
		NativeFieldInfoPtr_isTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isTeleport");
		NativeFieldInfoPtr_isResPit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isResPit");
		NativeFieldInfoPtr_isCookTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isCookTable");
		NativeFieldInfoPtr_isBulletin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isBulletin");
		NativeFieldInfoPtr_isFiefStele = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isFiefStele");
		NativeFieldInfoPtr_isFiefTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "isFiefTable");
		NativeFieldInfoPtr_IsFiefDevelop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "IsFiefDevelop");
		NativeFieldInfoPtr_IsSwornTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, "IsSwornTable");
		NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, 100680801);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr, 100680802);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031553, XrefRangeEnd = 1031565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Check(StateMachineDataContainer data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Check_Public_Virtual_Boolean_StateMachineDataContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IsTypeOfObjectConditionNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsTypeOfObjectConditionNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IsTypeOfObjectConditionNode(IntPtr pointer)
		: base(pointer)
	{
	}
}
