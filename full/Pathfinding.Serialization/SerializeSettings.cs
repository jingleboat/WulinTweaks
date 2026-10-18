using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Pathfinding.Serialization;

public class SerializeSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_prettyPrint;

	private static readonly System.IntPtr NativeFieldInfoPtr_editorSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_Static_get_SerializeSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)) = flag;
		}
	}

	public unsafe bool prettyPrint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prettyPrint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prettyPrint)) = flag;
		}
	}

	public unsafe bool editorSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorSettings)) = flag;
		}
	}

	public unsafe static SerializeSettings Settings
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1080708, RefRangeEnd = 1080712, XrefRangeStart = 1080704, XrefRangeEnd = 1080708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Settings_Public_Static_get_SerializeSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializeSettings>(intPtr) : null;
		}
	}

	static SerializeSettings()
	{
		Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Serialization", "SerializeSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr);
		NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr, "nodes");
		NativeFieldInfoPtr_prettyPrint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr, "prettyPrint");
		NativeFieldInfoPtr_editorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr, "editorSettings");
		NativeMethodInfoPtr_get_Settings_Public_Static_get_SerializeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr, 100684023);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr, 100684024);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializeSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SerializeSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
