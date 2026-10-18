using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.Touchy;

[Serializable]
public class TouchySettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_LONG_TAP_DURATION_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_LONG_TAP_DURATION_MAX;

	private static readonly IntPtr NativeFieldInfoPtr_LONG_TAP_DURATION_MIN;

	private static readonly IntPtr NativeFieldInfoPtr_SWIPE_LENGTH_DEFAULT_VALUE;

	private static readonly IntPtr NativeFieldInfoPtr_SWIPE_LENGTH_MAX;

	private static readonly IntPtr NativeFieldInfoPtr_SWIPE_LENGTH_MIN;

	private static readonly IntPtr NativeFieldInfoPtr_LongTapDuration;

	private static readonly IntPtr NativeFieldInfoPtr_SwipeLength;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TouchySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UndoRecord_Public_Void_String_0;

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

	public unsafe static TouchySettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TouchySettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touchySettings));
		}
	}

	public unsafe static float LONG_TAP_DURATION_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LONG_TAP_DURATION_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LONG_TAP_DURATION_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static float LONG_TAP_DURATION_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LONG_TAP_DURATION_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LONG_TAP_DURATION_MAX, (void*)(&num));
		}
	}

	public unsafe static float LONG_TAP_DURATION_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LONG_TAP_DURATION_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LONG_TAP_DURATION_MIN, (void*)(&num));
		}
	}

	public unsafe static float SWIPE_LENGTH_DEFAULT_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SWIPE_LENGTH_DEFAULT_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SWIPE_LENGTH_DEFAULT_VALUE, (void*)(&num));
		}
	}

	public unsafe static float SWIPE_LENGTH_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SWIPE_LENGTH_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SWIPE_LENGTH_MAX, (void*)(&num));
		}
	}

	public unsafe static float SWIPE_LENGTH_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SWIPE_LENGTH_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SWIPE_LENGTH_MIN, (void*)(&num));
		}
	}

	public unsafe float LongTapDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongTapDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongTapDuration)) = num;
		}
	}

	public unsafe float SwipeLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwipeLength)) = num;
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742767, XrefRangeEnd = 742771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static TouchySettings Instance
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 742471, RefRangeEnd = 742477, XrefRangeStart = 742471, XrefRangeEnd = 742477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_TouchySettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TouchySettings>(intPtr) : null;
		}
	}

	static TouchySettings()
	{
		Il2CppClassPointerStore<TouchySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Touchy", "TouchySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_LONG_TAP_DURATION_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "LONG_TAP_DURATION_DEFAULT_VALUE");
		NativeFieldInfoPtr_LONG_TAP_DURATION_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "LONG_TAP_DURATION_MAX");
		NativeFieldInfoPtr_LONG_TAP_DURATION_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "LONG_TAP_DURATION_MIN");
		NativeFieldInfoPtr_SWIPE_LENGTH_DEFAULT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "SWIPE_LENGTH_DEFAULT_VALUE");
		NativeFieldInfoPtr_SWIPE_LENGTH_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "SWIPE_LENGTH_MAX");
		NativeFieldInfoPtr_SWIPE_LENGTH_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "SWIPE_LENGTH_MIN");
		NativeFieldInfoPtr_LongTapDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "LongTapDuration");
		NativeFieldInfoPtr_SwipeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, "SwipeLength");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668610);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_TouchySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668611);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668612);
		NativeMethodInfoPtr_Reset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668613);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668614);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668615);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr, 100668616);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742771, XrefRangeEnd = 742775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742775, XrefRangeEnd = 742779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742779, XrefRangeEnd = 742783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UndoRecord(string undoMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecord_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742783, XrefRangeEnd = 742784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TouchySettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchySettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TouchySettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
