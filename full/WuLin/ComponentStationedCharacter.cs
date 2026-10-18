using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace WuLin;

public class ComponentStationedCharacter : Dlc1SlgComponentBase
{
	private static readonly IntPtr NativeFieldInfoPtr_uiImage_head;

	private static readonly IntPtr NativeFieldInfoPtr_uiImage_realHp;

	private static readonly IntPtr NativeFieldInfoPtr_uiImage_virtualHp;

	private static readonly IntPtr NativeFieldInfoPtr__portraitPath;

	private static readonly IntPtr NativeFieldInfoPtr__gameCharacter;

	private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshView_Public_Void_GameCharacterInstance_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComponentOnClick_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Image uiImage_head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage_head);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage_head)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image uiImage_realHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage_realHp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage_realHp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image uiImage_virtualHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage_virtualHp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage_virtualHp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe string _portraitPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__portraitPath);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__portraitPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe GameCharacterInstance _gameCharacter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameCharacter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameCharacter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	static ComponentStationedCharacter()
	{
		Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ComponentStationedCharacter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr);
		NativeFieldInfoPtr_uiImage_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, "uiImage_head");
		NativeFieldInfoPtr_uiImage_realHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, "uiImage_realHp");
		NativeFieldInfoPtr_uiImage_virtualHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, "uiImage_virtualHp");
		NativeFieldInfoPtr__portraitPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, "_portraitPath");
		NativeFieldInfoPtr__gameCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, "_gameCharacter");
		NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, 100680005);
		NativeMethodInfoPtr_RefreshView_Public_Void_GameCharacterInstance_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, 100680006);
		NativeMethodInfoPtr_ComponentOnClick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, 100680007);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr, 100680008);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015710, XrefRangeEnd = 1015713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnAwake(bool isBtn = false, string btnGroupId = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&isBtn);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(btnGroupId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1015717, RefRangeEnd = 1015721, XrefRangeStart = 1015713, XrefRangeEnd = 1015717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshView(GameCharacterInstance gameCharacter, Vector2 realHpAndEp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacter);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &realHpAndEp;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshView_Public_Void_GameCharacterInstance_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015721, XrefRangeEnd = 1015729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ComponentOnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComponentOnClick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015729, XrefRangeEnd = 1015733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComponentStationedCharacter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentStationedCharacter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ComponentStationedCharacter(IntPtr pointer)
		: base(pointer)
	{
	}
}
