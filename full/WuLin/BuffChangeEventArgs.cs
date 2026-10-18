using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

public sealed class BuffChangeEventArgs : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Buff;

	private static readonly System.IntPtr NativeFieldInfoPtr_Character;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAdd;

	public unsafe BuffInstance Buff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Buff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Buff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance));
		}
	}

	public unsafe GameCharacterInstance Character
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Character);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Character)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	public unsafe bool IsAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAdd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAdd)) = flag;
		}
	}

	static BuffChangeEventArgs()
	{
		Il2CppClassPointerStore<BuffChangeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "BuffChangeEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffChangeEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffChangeEventArgs>.NativeClassPtr, "Buff");
		NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffChangeEventArgs>.NativeClassPtr, "Character");
		NativeFieldInfoPtr_IsAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffChangeEventArgs>.NativeClassPtr, "IsAdd");
	}

	public BuffChangeEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BuffChangeEventArgs()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffChangeEventArgs>.NativeClassPtr))
	{
	}
}
