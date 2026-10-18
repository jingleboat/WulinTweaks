using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin;

[System.Serializable]
public class BuffCondition : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_opp;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffConditionOperator;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_BuffLib_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string key
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppSystem.Decimal start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start)) = obj;
		}
	}

	public unsafe Il2CppSystem.Decimal opp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opp);
			return *(Il2CppSystem.Decimal*)num;
		}
		set
		{
			*(Il2CppSystem.Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opp)) = obj;
		}
	}

	public unsafe BuffConditionOperator buffConditionOperator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffConditionOperator);
			return *(BuffConditionOperator*)num;
		}
		set
		{
			*(BuffConditionOperator*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffConditionOperator)) = buffConditionOperator;
		}
	}

	static BuffCondition()
	{
		Il2CppClassPointerStore<BuffCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BuffCondition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr);
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr, "key");
		NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr, "start");
		NativeFieldInfoPtr_opp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr, "opp");
		NativeFieldInfoPtr_buffConditionOperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr, "buffConditionOperator");
		NativeMethodInfoPtr_Check_Public_Boolean_BuffLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr, 100671655);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr, 100671656);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790797, XrefRangeEnd = 790805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Check(BuffLib actorBuffLib)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actorBuffLib);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_BuffLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790805, XrefRangeEnd = 790810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuffCondition()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffCondition>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuffCondition(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
