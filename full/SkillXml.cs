using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class SkillXml : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SkillName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Anchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Audio1;

	private static readonly System.IntPtr NativeFieldInfoPtr_Audio2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Audio3;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_CouldFlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_Speed;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string SkillName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Anchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Anchor);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Anchor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Audio1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Audio1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Audio1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Audio2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Audio2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Audio2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Audio3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Audio3);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Audio3)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string OnAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAttack);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAttack)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string CouldFlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CouldFlip);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CouldFlip)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SkillXml()
	{
		Il2CppClassPointerStore<SkillXml>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkillXml");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillXml>.NativeClassPtr);
		NativeFieldInfoPtr_SkillName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "SkillName");
		NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "Anchor");
		NativeFieldInfoPtr_Audio1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "Audio1");
		NativeFieldInfoPtr_Audio2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "Audio2");
		NativeFieldInfoPtr_Audio3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "Audio3");
		NativeFieldInfoPtr_OnAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "OnAttack");
		NativeFieldInfoPtr_CouldFlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "CouldFlip");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, "Speed");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillXml>.NativeClassPtr, 100664005);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680567, XrefRangeEnd = 680577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillXml()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillXml>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillXml(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
