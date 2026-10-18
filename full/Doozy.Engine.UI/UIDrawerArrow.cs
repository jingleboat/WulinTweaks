using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Touchy;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.UI;

[System.Serializable]
public class UIDrawerArrow : Il2CppSystem.Object
{
	[System.Serializable]
	public class Holder : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Closed;

		private static readonly System.IntPtr NativeFieldInfoPtr_Opened;

		private static readonly System.IntPtr NativeFieldInfoPtr_Root;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClosedLocalPosition_Public_get_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_OpenedLocalPosition_Public_get_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectTransform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_RectTransform_0;

		public unsafe RectTransform Closed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Closed);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Closed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
			}
		}

		public unsafe RectTransform Opened
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opened);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
			}
		}

		public unsafe RectTransform Root
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Root);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Root)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
			}
		}

		public unsafe Vector3 ClosedLocalPosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 345416, RefRangeEnd = 345420, XrefRangeStart = 345416, XrefRangeEnd = 345420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClosedLocalPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe Vector3 OpenedLocalPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 730857, RefRangeEnd = 730858, XrefRangeStart = 730856, XrefRangeEnd = 730857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OpenedLocalPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static Holder()
		{
			Il2CppClassPointerStore<Holder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Holder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Holder>.NativeClassPtr);
			NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Holder>.NativeClassPtr, "Closed");
			NativeFieldInfoPtr_Opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Holder>.NativeClassPtr, "Opened");
			NativeFieldInfoPtr_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Holder>.NativeClassPtr, "Root");
			NativeMethodInfoPtr_get_ClosedLocalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Holder>.NativeClassPtr, 100685507);
			NativeMethodInfoPtr_get_OpenedLocalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Holder>.NativeClassPtr, 100685508);
			NativeMethodInfoPtr__ctor_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Holder>.NativeClassPtr, 100685509);
			NativeMethodInfoPtr_Reset_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Holder>.NativeClassPtr, 100685510);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 730875, RefRangeEnd = 730883, XrefRangeStart = 730858, XrefRangeEnd = 730875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Holder(RectTransform parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Holder>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730883, XrefRangeEnd = 730899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Holder(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ENABLED;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_OVERRIDE_COLOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_SCALE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultOpenedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultClosedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Animator;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClosedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Container;

	private static readonly System.IntPtr NativeFieldInfoPtr_Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_Up;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHolder_Public_Holder_SimpleSwipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrowClosedPosition_Public_Void_SimpleSwipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrowClosedPosition_Public_Static_Void_RectTransform_SimpleSwipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrowOpenedPosition_Public_Void_SimpleSwipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrowOpenedPosition_Public_Static_Void_RectTransform_SimpleSwipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrowRootPosition_Public_Void_SimpleSwipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrowRootPosition_Public_Static_Void_RectTransform_SimpleSwipe_0;

	public unsafe static bool DEFAULT_ENABLED
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ENABLED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ENABLED, (void*)(&flag));
		}
	}

	public unsafe static bool DEFAULT_OVERRIDE_COLOR
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_OVERRIDE_COLOR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_OVERRIDE_COLOR, (void*)(&flag));
		}
	}

	public unsafe static float DEFAULT_SCALE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SCALE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SCALE, (void*)(&num));
		}
	}

	public unsafe static Color DefaultOpenedColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultOpenedColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultOpenedColor, (void*)(&color));
		}
	}

	public unsafe static Color DefaultClosedColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultClosedColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultClosedColor, (void*)(&color));
		}
	}

	public unsafe UIDrawerArrowAnimator Animator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIDrawerArrowAnimator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Animator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIDrawerArrowAnimator));
		}
	}

	public unsafe Color ClosedColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosedColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosedColor)) = color;
		}
	}

	public unsafe RectTransform Container
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Container);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Container)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Holder Down
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Down);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Holder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Down)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)holder));
		}
	}

	public unsafe bool Enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enabled)) = flag;
		}
	}

	public unsafe Holder Left
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Left);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Holder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Left)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)holder));
		}
	}

	public unsafe Color OpenedColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenedColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpenedColor)) = color;
		}
	}

	public unsafe bool OverrideColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideColor)) = flag;
		}
	}

	public unsafe Holder Right
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Right);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Holder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Right)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)holder));
		}
	}

	public unsafe float Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale)) = num;
		}
	}

	public unsafe Holder Up
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Up);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Holder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Up)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)holder));
		}
	}

	static UIDrawerArrow()
	{
		Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI", "UIDrawerArrow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_ENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "DEFAULT_ENABLED");
		NativeFieldInfoPtr_DEFAULT_OVERRIDE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "DEFAULT_OVERRIDE_COLOR");
		NativeFieldInfoPtr_DEFAULT_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "DEFAULT_SCALE");
		NativeFieldInfoPtr_DefaultOpenedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "DefaultOpenedColor");
		NativeFieldInfoPtr_DefaultClosedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "DefaultClosedColor");
		NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Animator");
		NativeFieldInfoPtr_ClosedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "ClosedColor");
		NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Container");
		NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Down");
		NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Enabled");
		NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Left");
		NativeFieldInfoPtr_OpenedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "OpenedColor");
		NativeFieldInfoPtr_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "OverrideColor");
		NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Right");
		NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Scale");
		NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, "Up");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667685);
		NativeMethodInfoPtr_GetHolder_Public_Holder_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667686);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667687);
		NativeMethodInfoPtr_ResetArrowClosedPosition_Public_Void_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667688);
		NativeMethodInfoPtr_ResetArrowClosedPosition_Public_Static_Void_RectTransform_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667689);
		NativeMethodInfoPtr_ResetArrowOpenedPosition_Public_Void_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667690);
		NativeMethodInfoPtr_ResetArrowOpenedPosition_Public_Static_Void_RectTransform_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667691);
		NativeMethodInfoPtr_ResetArrowRootPosition_Public_Void_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667692);
		NativeMethodInfoPtr_ResetArrowRootPosition_Public_Static_Void_RectTransform_SimpleSwipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr, 100667693);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 730918, RefRangeEnd = 730919, XrefRangeStart = 730899, XrefRangeEnd = 730918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDrawerArrow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDrawerArrow>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Holder GetHolder(SimpleSwipe closeDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&closeDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHolder_Public_Holder_SimpleSwipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Holder>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730919, XrefRangeEnd = 730937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730937, XrefRangeEnd = 730944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetArrowClosedPosition(SimpleSwipe closeDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&closeDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetArrowClosedPosition_Public_Void_SimpleSwipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 730951, RefRangeEnd = 730952, XrefRangeStart = 730944, XrefRangeEnd = 730951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetArrowClosedPosition(RectTransform closed, SimpleSwipe closeDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)closed);
		*(SimpleSwipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetArrowClosedPosition_Public_Static_Void_RectTransform_SimpleSwipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730952, XrefRangeEnd = 730959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetArrowOpenedPosition(SimpleSwipe closeDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&closeDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetArrowOpenedPosition_Public_Void_SimpleSwipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 730966, RefRangeEnd = 730967, XrefRangeStart = 730959, XrefRangeEnd = 730966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetArrowOpenedPosition(RectTransform opened, SimpleSwipe closeDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)opened);
		*(SimpleSwipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetArrowOpenedPosition_Public_Static_Void_RectTransform_SimpleSwipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730967, XrefRangeEnd = 730974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetArrowRootPosition(SimpleSwipe closeDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&closeDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetArrowRootPosition_Public_Void_SimpleSwipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 730992, RefRangeEnd = 730993, XrefRangeStart = 730974, XrefRangeEnd = 730992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetArrowRootPosition(RectTransform root, SimpleSwipe closeDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(SimpleSwipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetArrowRootPosition_Public_Static_Void_RectTransform_SimpleSwipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIDrawerArrow(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
