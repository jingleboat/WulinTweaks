using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.UI.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Doozy.Engine.UI;

[Serializable]
public class UIDrawerContainer : UIContainer
{
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_CONTAINER_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_FADE_OUT;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_FIXED_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_MINIMUM_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PERCENTAGE_OF_SCREEN_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_CalculatedSize;

	private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

	private static readonly IntPtr NativeFieldInfoPtr_CurrentPosition;

	private static readonly IntPtr NativeFieldInfoPtr_FadeOut;

	private static readonly IntPtr NativeFieldInfoPtr_FixedSize;

	private static readonly IntPtr NativeFieldInfoPtr_MinimumSize;

	private static readonly IntPtr NativeFieldInfoPtr_OpenedPosition;

	private static readonly IntPtr NativeFieldInfoPtr_PercentageOfScreen;

	private static readonly IntPtr NativeFieldInfoPtr_PreviousPosition;

	private static readonly IntPtr NativeFieldInfoPtr_Size;

	private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	public unsafe static UIDrawerContainerSize DEFAULT_CONTAINER_SIZE
	{
		get
		{
			Unsafe.SkipInit(out UIDrawerContainerSize result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_CONTAINER_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_CONTAINER_SIZE, (void*)(&uIDrawerContainerSize));
		}
	}

	public unsafe static bool DEFAULT_FADE_OUT
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_FADE_OUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_FADE_OUT, (void*)(&flag));
		}
	}

	public unsafe static float DEFAULT_FIXED_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_FIXED_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_FIXED_SIZE, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_MINIMUM_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_MINIMUM_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_MINIMUM_SIZE, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_PERCENTAGE_OF_SCREEN_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_PERCENTAGE_OF_SCREEN_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_PERCENTAGE_OF_SCREEN_SIZE, (void*)(&num));
		}
	}

	public unsafe Vector2 CalculatedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CalculatedSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CalculatedSize)) = vector;
		}
	}

	public unsafe Vector3 ClosedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosedPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosedPosition)) = vector;
		}
	}

	public unsafe Vector3 CurrentPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentPosition)) = vector;
		}
	}

	public unsafe bool FadeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOut);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOut)) = flag;
		}
	}

	public unsafe float FixedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedSize)) = num;
		}
	}

	public unsafe float MinimumSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumSize)) = num;
		}
	}

	public unsafe Vector3 OpenedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenedPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenedPosition)) = vector;
		}
	}

	public unsafe float PercentageOfScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PercentageOfScreen);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PercentageOfScreen)) = num;
		}
	}

	public unsafe Vector3 PreviousPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousPosition)) = vector;
		}
	}

	public unsafe UIDrawerContainerSize Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size);
			return *(UIDrawerContainerSize*)num;
		}
		set
		{
			*(UIDrawerContainerSize*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size)) = uIDrawerContainerSize;
		}
	}

	public unsafe Vector2 Velocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Velocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UIDrawerContainer()
	{
		Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIDrawerContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_CONTAINER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "DEFAULT_CONTAINER_SIZE");
		NativeFieldInfoPtr_DEFAULT_FADE_OUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "DEFAULT_FADE_OUT");
		NativeFieldInfoPtr_DEFAULT_FIXED_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "DEFAULT_FIXED_SIZE");
		NativeFieldInfoPtr_DEFAULT_MINIMUM_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "DEFAULT_MINIMUM_SIZE");
		NativeFieldInfoPtr_DEFAULT_PERCENTAGE_OF_SCREEN_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "DEFAULT_PERCENTAGE_OF_SCREEN_SIZE");
		NativeFieldInfoPtr_CalculatedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "CalculatedSize");
		NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "ClosedPosition");
		NativeFieldInfoPtr_CurrentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "CurrentPosition");
		NativeFieldInfoPtr_FadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "FadeOut");
		NativeFieldInfoPtr_FixedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "FixedSize");
		NativeFieldInfoPtr_MinimumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "MinimumSize");
		NativeFieldInfoPtr_OpenedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "OpenedPosition");
		NativeFieldInfoPtr_PercentageOfScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "PercentageOfScreen");
		NativeFieldInfoPtr_PreviousPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "PreviousPosition");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, "Size");
		NativeMethodInfoPtr_get_Velocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, 100667721);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, 100667722);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr, 100667723);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 731177, RefRangeEnd = 731178, XrefRangeStart = 731176, XrefRangeEnd = 731177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDrawerContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDrawerContainer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731178, XrefRangeEnd = 731179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIDrawerContainer(IntPtr pointer)
		: base(pointer)
	{
	}
}
