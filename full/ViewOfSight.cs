using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public sealed class ViewOfSight : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_light;

	private static readonly System.IntPtr NativeFieldInfoPtr_shade;

	public unsafe List<Vector3Int> light
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_light);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_light)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3Int> shade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shade);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shade)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ViewOfSight()
	{
		Il2CppClassPointerStore<ViewOfSight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ViewOfSight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewOfSight>.NativeClassPtr);
		NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOfSight>.NativeClassPtr, "light");
		NativeFieldInfoPtr_shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOfSight>.NativeClassPtr, "shade");
	}

	public ViewOfSight(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ViewOfSight()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewOfSight>.NativeClassPtr))
	{
	}
}
