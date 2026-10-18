using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

public class DynamicModifierInstance : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_postInvokeAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicModifierKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_relateBuff;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DModifier_Public_get_DynamicModifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeStage_Public_get_Il2CppStructArray_1_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConditions_Public_Boolean_GameCharacterInstance_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndDoAction_Public_Void_GameCharacterInstance_DynamicModifierActiveStage_0;

	public unsafe static Il2CppSystem.Action postInvokeAction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_postInvokeAction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_postInvokeAction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe string dynamicModifierKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicModifierKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicModifierKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe BuffInstance relateBuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relateBuff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relateBuff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance));
		}
	}

	public unsafe DynamicModifier DModifier
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 791800, RefRangeEnd = 791803, XrefRangeStart = 791796, XrefRangeEnd = 791800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DModifier_Public_get_DynamicModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicModifier>(intPtr) : null;
		}
	}

	public unsafe bool IsValid
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791811, RefRangeEnd = 791812, XrefRangeStart = 791803, XrefRangeEnd = 791811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Il2CppStructArray<DynamicModifier.DynamicModifierActiveStage> activeStage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791816, RefRangeEnd = 791817, XrefRangeStart = 791812, XrefRangeEnd = 791816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeStage_Public_get_Il2CppStructArray_1_DynamicModifierActiveStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<DynamicModifier.DynamicModifierActiveStage>>(intPtr) : null;
		}
	}

	static DynamicModifierInstance()
	{
		Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DynamicModifierInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr);
		NativeFieldInfoPtr_postInvokeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, "postInvokeAction");
		NativeFieldInfoPtr_dynamicModifierKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, "dynamicModifierKey");
		NativeFieldInfoPtr_relateBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, "relateBuff");
		NativeMethodInfoPtr_get_DModifier_Public_get_DynamicModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, 100671674);
		NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, 100671675);
		NativeMethodInfoPtr_get_activeStage_Public_get_Il2CppStructArray_1_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, 100671676);
		NativeMethodInfoPtr__ctor_Public_Void_String_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, 100671677);
		NativeMethodInfoPtr_CheckConditions_Public_Boolean_GameCharacterInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, 100671678);
		NativeMethodInfoPtr_CheckAndDoAction_Public_Void_GameCharacterInstance_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr, 100671679);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 14009, RefRangeEnd = 14099, XrefRangeStart = 14009, XrefRangeEnd = 14099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicModifierInstance(string key, BuffInstance buff)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicModifierInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buff);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 791836, RefRangeEnd = 791837, XrefRangeStart = 791817, XrefRangeEnd = 791836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckConditions(GameCharacterInstance gameCharacterInstance, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckConditions_Public_Boolean_GameCharacterInstance_DynamicModifierActiveStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 791906, RefRangeEnd = 791908, XrefRangeStart = 791837, XrefRangeEnd = 791906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAndDoAction(GameCharacterInstance gameCharacterInstance, DynamicModifier.DynamicModifierActiveStage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(DynamicModifier.DynamicModifierActiveStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndDoAction_Public_Void_GameCharacterInstance_DynamicModifierActiveStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DynamicModifierInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
