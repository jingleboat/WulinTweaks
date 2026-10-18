using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.UI.Animation;

[Serializable]
public class UIAnimations : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_DATABASE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PRESET_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_Show;

	private static readonly IntPtr NativeFieldInfoPtr_Hide;

	private static readonly IntPtr NativeFieldInfoPtr_Loop;

	private static readonly IntPtr NativeFieldInfoPtr_Punch;

	private static readonly IntPtr NativeFieldInfoPtr_State;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UIAnimations_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateDatabase_Public_UIAnimationDatabase_AnimationType_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_UIAnimationsDatabase_AnimationType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_UIAnimationData_AnimationType_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_UIAnimationDatabase_AnimationType_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SearchForUnregisteredDatabases_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadPreset_Public_Static_UIAnimation_AnimationType_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string FILE_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DEFAULT_DATABASE_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_DATABASE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_DATABASE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DEFAULT_PRESET_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_PRESET_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_PRESET_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static UIAnimations s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimations>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimations));
		}
	}

	public unsafe UIAnimationsDatabase Show
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Show);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationsDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Show)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimationsDatabase));
		}
	}

	public unsafe UIAnimationsDatabase Hide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hide);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationsDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hide)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimationsDatabase));
		}
	}

	public unsafe UIAnimationsDatabase Loop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Loop);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationsDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Loop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimationsDatabase));
		}
	}

	public unsafe UIAnimationsDatabase Punch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Punch);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationsDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Punch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimationsDatabase));
		}
	}

	public unsafe UIAnimationsDatabase State
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_State);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationsDatabase>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_State)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIAnimationsDatabase));
		}
	}

	public unsafe static UIAnimations Instance
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 740026, RefRangeEnd = 740037, XrefRangeStart = 739995, XrefRangeEnd = 740026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UIAnimations_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimations>(intPtr) : null;
		}
	}

	static UIAnimations()
	{
		Il2CppClassPointerStore<UIAnimations>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Animation", "UIAnimations");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_DEFAULT_DATABASE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "DEFAULT_DATABASE_NAME");
		NativeFieldInfoPtr_DEFAULT_PRESET_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "DEFAULT_PRESET_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "Show");
		NativeFieldInfoPtr_Hide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "Hide");
		NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "Loop");
		NativeFieldInfoPtr_Punch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "Punch");
		NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, "State");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UIAnimations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668445);
		NativeMethodInfoPtr_CreateDatabase_Public_UIAnimationDatabase_AnimationType_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668446);
		NativeMethodInfoPtr_Get_Public_UIAnimationsDatabase_AnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668447);
		NativeMethodInfoPtr_Get_Public_UIAnimationData_AnimationType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668448);
		NativeMethodInfoPtr_Get_Public_UIAnimationDatabase_AnimationType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668449);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668450);
		NativeMethodInfoPtr_SearchForUnregisteredDatabases_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668451);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668452);
		NativeMethodInfoPtr_LoadPreset_Public_Static_UIAnimation_AnimationType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668453);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr, 100668454);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740037, XrefRangeEnd = 740051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIAnimationDatabase CreateDatabase(AnimationType databaseType, string newPresetCategory, bool saveAssets = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&databaseType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newPresetCategory);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &saveAssets;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDatabase_Public_UIAnimationDatabase_AnimationType_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationDatabase>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe UIAnimationsDatabase Get(AnimationType databaseType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&databaseType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_UIAnimationsDatabase_AnimationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationsDatabase>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 740058, RefRangeEnd = 740068, XrefRangeStart = 740051, XrefRangeEnd = 740058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIAnimationData Get(AnimationType databaseType, string databaseName, string animationName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&databaseType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(animationName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_UIAnimationData_AnimationType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740068, XrefRangeEnd = 740074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIAnimationDatabase Get(AnimationType databaseType, string databaseName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&databaseType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(databaseName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_UIAnimationDatabase_AnimationType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimationDatabase>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 740099, RefRangeEnd = 740101, XrefRangeStart = 740074, XrefRangeEnd = 740099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 740174, RefRangeEnd = 740175, XrefRangeStart = 740101, XrefRangeEnd = 740174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SearchForUnregisteredDatabases(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchForUnregisteredDatabases_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740175, XrefRangeEnd = 740179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDirty(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740179, XrefRangeEnd = 740190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIAnimation LoadPreset(AnimationType animationType, string presetCategory, string presetName)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&animationType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(presetCategory);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(presetName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPreset_Public_Static_UIAnimation_AnimationType_String_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIAnimation>(intPtr) : null;
	}

	[CallerCount(99)]
	[CachedScanResults(RefRangeStart = 224141, RefRangeEnd = 224240, XrefRangeStart = 224141, XrefRangeEnd = 224240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIAnimations()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAnimations>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIAnimations(IntPtr pointer)
		: base(pointer)
	{
	}
}
