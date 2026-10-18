using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameSteamwork;

public class TmodFile : Il2CppSystem.Object
{
	public enum ModFromType
	{
		None,
		Self,
		Other
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSelfMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastModified;

	private static readonly System.IntPtr NativeFieldInfoPtr_EntryInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFromSteam;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Private_Void_0;

	public unsafe string path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ModFromType isSelfMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelfMod);
			return *(ModFromType*)num;
		}
		set
		{
			*(ModFromType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelfMod)) = modFromType;
		}
	}

	public unsafe Il2CppSystem.DateTime lastModified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastModified);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastModified)) = dateTime;
		}
	}

	public unsafe FoundWorkshopEntryInfo EntryInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EntryInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FoundWorkshopEntryInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EntryInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)foundWorkshopEntryInfo));
		}
	}

	public unsafe bool isFromSteam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFromSteam);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFromSteam)) = flag;
		}
	}

	static TmodFile()
	{
		Il2CppClassPointerStore<TmodFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameSteamwork", "TmodFile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TmodFile>.NativeClassPtr);
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, "path");
		NativeFieldInfoPtr_isSelfMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, "isSelfMod");
		NativeFieldInfoPtr_lastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, "lastModified");
		NativeFieldInfoPtr_EntryInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, "EntryInfo");
		NativeFieldInfoPtr_isFromSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, "isFromSteam");
		NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, 100664637);
		NativeMethodInfoPtr_Parse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TmodFile>.NativeClassPtr, 100664638);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 693963, RefRangeEnd = 693965, XrefRangeStart = 693955, XrefRangeEnd = 693963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TmodFile(string path)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TmodFile>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693965, XrefRangeEnd = 693968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Parse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TmodFile(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
