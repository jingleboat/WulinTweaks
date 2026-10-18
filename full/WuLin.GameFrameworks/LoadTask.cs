using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace WuLin.GameFrameworks;

public sealed class LoadTask : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_url;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_callfunc;

	public unsafe string url
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_url);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_url)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe LOAD_TASK_TYPE type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(LOAD_TASK_TYPE*)num;
		}
		set
		{
			*(LOAD_TASK_TYPE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = lOAD_TASK_TYPE;
		}
	}

	public unsafe Il2CppSystem.Action<UnityEngine.Object> callfunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callfunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<UnityEngine.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callfunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static LoadTask()
	{
		Il2CppClassPointerStore<LoadTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.GameFrameworks", "LoadTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadTask>.NativeClassPtr);
		NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTask>.NativeClassPtr, "url");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTask>.NativeClassPtr, "type");
		NativeFieldInfoPtr_callfunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTask>.NativeClassPtr, "callfunc");
	}

	public LoadTask(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LoadTask()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadTask>.NativeClassPtr))
	{
	}
}
