using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Touchy;

public static class CardinalDirection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_None;

	private static readonly System.IntPtr NativeFieldInfoPtr_Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_DownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_DownLeft;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Vector2_Swipe_0;

	public unsafe static Vector2 None
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_None, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_None, (void*)(&vector));
		}
	}

	public unsafe static Vector2 Up
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Up, (void*)(&vector));
		}
	}

	public unsafe static Vector2 Down
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Down, (void*)(&vector));
		}
	}

	public unsafe static Vector2 Right
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Right, (void*)(&vector));
		}
	}

	public unsafe static Vector2 Left
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Left, (void*)(&vector));
		}
	}

	public unsafe static Vector2 UpRight
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpRight, (void*)(&vector));
		}
	}

	public unsafe static Vector2 UpLeft
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpLeft, (void*)(&vector));
		}
	}

	public unsafe static Vector2 DownRight
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DownRight, (void*)(&vector));
		}
	}

	public unsafe static Vector2 DownLeft
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DownLeft, (void*)(&vector));
		}
	}

	static CardinalDirection()
	{
		Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Touchy", "CardinalDirection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr);
		NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "None");
		NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "Up");
		NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "Down");
		NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "Right");
		NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "Left");
		NativeFieldInfoPtr_UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "UpRight");
		NativeFieldInfoPtr_UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "UpLeft");
		NativeFieldInfoPtr_DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "DownRight");
		NativeFieldInfoPtr_DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, "DownLeft");
		NativeMethodInfoPtr_Get_Public_Static_Vector2_Swipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirection>.NativeClassPtr, 100668521);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 741906, RefRangeEnd = 741907, XrefRangeStart = 741902, XrefRangeEnd = 741906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Get(Swipe swipe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&swipe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_Vector2_Swipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CardinalDirection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
