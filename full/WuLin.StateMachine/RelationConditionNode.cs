using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace WuLin.StateMachine;

public class RelationConditionNode : ConditionNode
{
	private static readonly IntPtr NativeFieldInfoPtr_useKey;

	private static readonly IntPtr NativeFieldInfoPtr_checkKey;

	private static readonly IntPtr NativeFieldInfoPtr_minRelation;

	private static readonly IntPtr NativeFieldInfoPtr_maxRalation;

	private static readonly IntPtr NativeFieldInfoPtr_isReverse;

	private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Boolean_StateMachineDataContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool useKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useKey)) = flag;
		}
	}

	public unsafe string checkKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int minRelation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRelation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRelation)) = num;
		}
	}

	public unsafe int maxRalation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRalation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRalation)) = num;
		}
	}

	public unsafe bool isReverse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReverse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReverse)) = flag;
		}
	}

	static RelationConditionNode()
	{
		Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "RelationConditionNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr);
		NativeFieldInfoPtr_useKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, "useKey");
		NativeFieldInfoPtr_checkKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, "checkKey");
		NativeFieldInfoPtr_minRelation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, "minRelation");
		NativeFieldInfoPtr_maxRalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, "maxRalation");
		NativeFieldInfoPtr_isReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, "isReverse");
		NativeMethodInfoPtr_Check_Public_Boolean_StateMachineDataContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, 100680820);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr, 100680821);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031803, XrefRangeEnd = 1031821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Check(StateMachineDataContainer data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_StateMachineDataContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031821, XrefRangeEnd = 1031822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RelationConditionNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationConditionNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RelationConditionNode(IntPtr pointer)
		: base(pointer)
	{
	}
}
