using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Newtonsoft.Json;

namespace GameSteamwork;

public class FoundWorkshopEntryInfo : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_TryGet_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryGet_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_T_0, Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Steam;

	private static readonly System.IntPtr NativeFieldInfoPtr_SettingFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PublishId;

	private static readonly System.IntPtr NativeFieldInfoPtr_publicity;

	private static readonly System.IntPtr NativeFieldInfoPtr_tags;

	private static readonly System.IntPtr NativeFieldInfoPtr_previewImagePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_description;

	private static readonly System.IntPtr NativeFieldInfoPtr_titleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_author;

	private static readonly System.IntPtr NativeFieldInfoPtr_SerializerSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWritingSteam_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryReadingSteam_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryReadingManifest_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string Steam
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Steam, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Steam, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SettingFileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SettingFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SettingFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string IconFileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IconFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IconFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ulong PublishId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PublishId);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PublishId)) = num;
		}
	}

	public unsafe PublishSettings.VisibleType publicity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicity);
			return *(PublishSettings.VisibleType*)num;
		}
		set
		{
			*(PublishSettings.VisibleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicity)) = visibleType;
		}
	}

	public unsafe Il2CppStringArray tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string previewImagePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previewImagePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previewImagePath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string titleName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_titleName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_titleName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string author
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static JsonSerializerSettings SerializerSettings
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SerializerSettings, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<JsonSerializerSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SerializerSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jsonSerializerSettings));
		}
	}

	static FoundWorkshopEntryInfo()
	{
		Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameSteamwork", "FoundWorkshopEntryInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Steam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "Steam");
		NativeFieldInfoPtr_SettingFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "SettingFileName");
		NativeFieldInfoPtr_IconFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "IconFileName");
		NativeFieldInfoPtr_PublishId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "PublishId");
		NativeFieldInfoPtr_publicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "publicity");
		NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "tags");
		NativeFieldInfoPtr_previewImagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "previewImagePath");
		NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "description");
		NativeFieldInfoPtr_titleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "titleName");
		NativeFieldInfoPtr_author = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "author");
		NativeFieldInfoPtr_SerializerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, "SerializerSettings");
		NativeMethodInfoPtr_TryWritingSteam_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_TryReadingSteam_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_TryReadingManifest_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_TryGet_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr, 100664620);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693630, RefRangeEnd = 693631, XrefRangeStart = 693595, XrefRangeEnd = 693630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryWritingSteam(string projectDir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(projectDir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWritingSteam_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 693659, RefRangeEnd = 693661, XrefRangeStart = 693631, XrefRangeEnd = 693659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryReadingSteam(string projectDir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(projectDir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryReadingSteam_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 693738, RefRangeEnd = 693741, XrefRangeStart = 693661, XrefRangeEnd = 693738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryReadingManifest(string projectDir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(projectDir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryReadingManifest_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693772, RefRangeEnd = 693773, XrefRangeStart = 693741, XrefRangeEnd = 693772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGet<T>(Dictionary<string, Il2CppSystem.Object> dict, string name, out T outputValue)
	{
		//IL_0087: Expected Obj, but got VT
		//IL_004a->IL004c: Incompatible stack types: I vs Ref
		//IL_0085->IL0085: Incompatible stack types: Obj vs VT
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num2 = 0;
			reference = ref *(T*)(&num2);
		}
		else
		{
			reference = ref outputValue;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryGet_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		if (!typeof(T).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<T, object>(ref outputValue) = ((num3 != 0) ? IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num3, false, false) : ((object)null));
		}
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FoundWorkshopEntryInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoundWorkshopEntryInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FoundWorkshopEntryInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
