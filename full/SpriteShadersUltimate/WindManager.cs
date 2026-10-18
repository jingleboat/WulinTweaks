using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace SpriteShadersUltimate;

public class WindManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_windNoiseScale;

	private static readonly IntPtr NativeFieldInfoPtr_lastWindNoiseScale;

	private static readonly IntPtr NativeFieldInfoPtr_windNoiseSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_lastWindNoiseSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_windIntensityFrom;

	private static readonly IntPtr NativeFieldInfoPtr_lastWindIntensityFrom;

	private static readonly IntPtr NativeFieldInfoPtr_windIntensityTo;

	private static readonly IntPtr NativeFieldInfoPtr_lastWindIntensityTo;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ModifyIfChanged_Public_Void_byref_Single_byref_Single_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float windNoiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windNoiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windNoiseScale)) = num;
		}
	}

	public unsafe float lastWindNoiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindNoiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindNoiseScale)) = num;
		}
	}

	public unsafe float windNoiseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windNoiseSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windNoiseSpeed)) = num;
		}
	}

	public unsafe float lastWindNoiseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindNoiseSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindNoiseSpeed)) = num;
		}
	}

	public unsafe float windIntensityFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windIntensityFrom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windIntensityFrom)) = num;
		}
	}

	public unsafe float lastWindIntensityFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindIntensityFrom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindIntensityFrom)) = num;
		}
	}

	public unsafe float windIntensityTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windIntensityTo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windIntensityTo)) = num;
		}
	}

	public unsafe float lastWindIntensityTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindIntensityTo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindIntensityTo)) = num;
		}
	}

	static WindManager()
	{
		Il2CppClassPointerStore<WindManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SpriteShadersUltimate", "WindManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindManager>.NativeClassPtr);
		NativeFieldInfoPtr_windNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "windNoiseScale");
		NativeFieldInfoPtr_lastWindNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "lastWindNoiseScale");
		NativeFieldInfoPtr_windNoiseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "windNoiseSpeed");
		NativeFieldInfoPtr_lastWindNoiseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "lastWindNoiseSpeed");
		NativeFieldInfoPtr_windIntensityFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "windIntensityFrom");
		NativeFieldInfoPtr_lastWindIntensityFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "lastWindIntensityFrom");
		NativeFieldInfoPtr_windIntensityTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "windIntensityTo");
		NativeFieldInfoPtr_lastWindIntensityTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindManager>.NativeClassPtr, "lastWindIntensityTo");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindManager>.NativeClassPtr, 100665476);
		NativeMethodInfoPtr_ModifyIfChanged_Public_Void_byref_Single_byref_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindManager>.NativeClassPtr, 100665477);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindManager>.NativeClassPtr, 100665478);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707949, XrefRangeEnd = 707961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707961, XrefRangeEnd = 707962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ModifyIfChanged(ref float currentValue, ref float oldValue, string globalShaderName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref currentValue);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref oldValue);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(globalShaderName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModifyIfChanged_Public_Void_byref_Single_byref_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707962, XrefRangeEnd = 707963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WindManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WindManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
