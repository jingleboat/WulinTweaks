using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Doozy.Engine.Nody;

public class NodySettings : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_FILE_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	private static readonly IntPtr NativeFieldInfoPtr_NormalOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_ActiveOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_HoverOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_FooterHeight;

	private static readonly IntPtr NativeFieldInfoPtr_MaxNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_MinNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_NodeAccentLineHeight;

	private static readonly IntPtr NativeFieldInfoPtr_NodeAddSocketButtonSize;

	private static readonly IntPtr NativeFieldInfoPtr_NodeBodyOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_NodeDeleteButtonSize;

	private static readonly IntPtr NativeFieldInfoPtr_NodeGlowOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_NodeHeaderHeight;

	private static readonly IntPtr NativeFieldInfoPtr_NodeHeaderIconSize;

	private static readonly IntPtr NativeFieldInfoPtr_PingColorChangeSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_SocketConnectedOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_SocketCurveModifierMaxValue;

	private static readonly IntPtr NativeFieldInfoPtr_SocketCurveModifierMinValue;

	private static readonly IntPtr NativeFieldInfoPtr_SocketDividerHeight;

	private static readonly IntPtr NativeFieldInfoPtr_SocketDividerOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_SocketHeight;

	private static readonly IntPtr NativeFieldInfoPtr_SocketNotConnectedOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_SocketVerticalSpacing;

	private static readonly IntPtr NativeFieldInfoPtr_ConnectionPointHeight;

	private static readonly IntPtr NativeFieldInfoPtr_ConnectionPointOffsetFromLeftMargin;

	private static readonly IntPtr NativeFieldInfoPtr_ConnectionPointOffsetFromRightMargin;

	private static readonly IntPtr NativeFieldInfoPtr_ConnectionPointWidth;

	private static readonly IntPtr NativeFieldInfoPtr_CurvePointsMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_CurveStrengthModifier;

	private static readonly IntPtr NativeFieldInfoPtr_CurveWidth;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultCurveModifier;

	private static readonly IntPtr NativeFieldInfoPtr_MaxCurveModifier;

	private static readonly IntPtr NativeFieldInfoPtr_MinCurveModifier;

	private static readonly IntPtr NativeFieldInfoPtr_GraphTabDividerWidth;

	private static readonly IntPtr NativeFieldInfoPtr_GraphTabElementSpacing;

	private static readonly IntPtr NativeFieldInfoPtr_GraphTabMaximumWidth;

	private static readonly IntPtr NativeFieldInfoPtr_GraphTabMinimumWidth;

	private static readonly IntPtr NativeFieldInfoPtr_GraphTabsAreaHeight;

	private static readonly IntPtr NativeFieldInfoPtr_GraphTabsBackgroundOpacity;

	private static readonly IntPtr NativeFieldInfoPtr_RepaintIntervalDuringPlayMode;

	private static readonly IntPtr NativeFieldInfoPtr_RepaintIntervalWhileIdle;

	private static readonly IntPtr NativeFieldInfoPtr_EditorPrefsKeyWindowToolbar;

	private static readonly IntPtr NativeFieldInfoPtr_EditorPrefsKeyDotAnimationSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultNodeHeight;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_EnterNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_ExitNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_StartNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_SubGraphNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_SwitchBackNodeWidth;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultHideFlagsForNodes;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_NodySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UndoRecord_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string FILE_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static NodySettings s_instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<NodySettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodySettings));
		}
	}

	public unsafe float NormalOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalOpacity)) = num;
		}
	}

	public unsafe float ActiveOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveOpacity)) = num;
		}
	}

	public unsafe float HoverOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverOpacity)) = num;
		}
	}

	public unsafe float FooterHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FooterHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FooterHeight)) = num;
		}
	}

	public unsafe float MaxNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxNodeWidth)) = num;
		}
	}

	public unsafe float MinNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinNodeWidth)) = num;
		}
	}

	public unsafe float NodeAccentLineHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeAccentLineHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeAccentLineHeight)) = num;
		}
	}

	public unsafe float NodeAddSocketButtonSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeAddSocketButtonSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeAddSocketButtonSize)) = num;
		}
	}

	public unsafe float NodeBodyOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeBodyOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeBodyOpacity)) = num;
		}
	}

	public unsafe float NodeDeleteButtonSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeDeleteButtonSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeDeleteButtonSize)) = num;
		}
	}

	public unsafe float NodeGlowOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeGlowOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeGlowOpacity)) = num;
		}
	}

	public unsafe float NodeHeaderHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeHeaderHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeHeaderHeight)) = num;
		}
	}

	public unsafe float NodeHeaderIconSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeHeaderIconSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeHeaderIconSize)) = num;
		}
	}

	public unsafe float PingColorChangeSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PingColorChangeSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PingColorChangeSpeed)) = num;
		}
	}

	public unsafe float SocketConnectedOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketConnectedOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketConnectedOpacity)) = num;
		}
	}

	public unsafe float SocketCurveModifierMaxValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketCurveModifierMaxValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketCurveModifierMaxValue)) = num;
		}
	}

	public unsafe float SocketCurveModifierMinValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketCurveModifierMinValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketCurveModifierMinValue)) = num;
		}
	}

	public unsafe float SocketDividerHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketDividerHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketDividerHeight)) = num;
		}
	}

	public unsafe float SocketDividerOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketDividerOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketDividerOpacity)) = num;
		}
	}

	public unsafe float SocketHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketHeight)) = num;
		}
	}

	public unsafe float SocketNotConnectedOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketNotConnectedOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketNotConnectedOpacity)) = num;
		}
	}

	public unsafe float SocketVerticalSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketVerticalSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SocketVerticalSpacing)) = num;
		}
	}

	public unsafe float ConnectionPointHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointHeight)) = num;
		}
	}

	public unsafe float ConnectionPointOffsetFromLeftMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointOffsetFromLeftMargin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointOffsetFromLeftMargin)) = num;
		}
	}

	public unsafe float ConnectionPointOffsetFromRightMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointOffsetFromRightMargin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointOffsetFromRightMargin)) = num;
		}
	}

	public unsafe float ConnectionPointWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionPointWidth)) = num;
		}
	}

	public unsafe float CurvePointsMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurvePointsMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurvePointsMultiplier)) = num;
		}
	}

	public unsafe float CurveStrengthModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveStrengthModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveStrengthModifier)) = num;
		}
	}

	public unsafe float CurveWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveWidth)) = num;
		}
	}

	public unsafe float DefaultCurveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultCurveModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultCurveModifier)) = num;
		}
	}

	public unsafe float MaxCurveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCurveModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCurveModifier)) = num;
		}
	}

	public unsafe float MinCurveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinCurveModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinCurveModifier)) = num;
		}
	}

	public unsafe float GraphTabDividerWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabDividerWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabDividerWidth)) = num;
		}
	}

	public unsafe float GraphTabElementSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabElementSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabElementSpacing)) = num;
		}
	}

	public unsafe float GraphTabMaximumWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabMaximumWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabMaximumWidth)) = num;
		}
	}

	public unsafe float GraphTabMinimumWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabMinimumWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabMinimumWidth)) = num;
		}
	}

	public unsafe float GraphTabsAreaHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabsAreaHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabsAreaHeight)) = num;
		}
	}

	public unsafe float GraphTabsBackgroundOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabsBackgroundOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphTabsBackgroundOpacity)) = num;
		}
	}

	public unsafe double RepaintIntervalDuringPlayMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepaintIntervalDuringPlayMode);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepaintIntervalDuringPlayMode)) = num;
		}
	}

	public unsafe double RepaintIntervalWhileIdle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepaintIntervalWhileIdle);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepaintIntervalWhileIdle)) = num;
		}
	}

	public unsafe string EditorPrefsKeyWindowToolbar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorPrefsKeyWindowToolbar);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorPrefsKeyWindowToolbar)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string EditorPrefsKeyDotAnimationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorPrefsKeyDotAnimationSpeed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorPrefsKeyDotAnimationSpeed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float DefaultNodeHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultNodeHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultNodeHeight)) = num;
		}
	}

	public unsafe float DefaultNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultNodeWidth)) = num;
		}
	}

	public unsafe float EnterNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterNodeWidth)) = num;
		}
	}

	public unsafe float ExitNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExitNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExitNodeWidth)) = num;
		}
	}

	public unsafe float StartNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartNodeWidth)) = num;
		}
	}

	public unsafe float SubGraphNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubGraphNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubGraphNodeWidth)) = num;
		}
	}

	public unsafe float SwitchBackNodeWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwitchBackNodeWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SwitchBackNodeWidth)) = num;
		}
	}

	public unsafe HideFlags DefaultHideFlagsForNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultHideFlagsForNodes);
			return *(HideFlags*)num;
		}
		set
		{
			*(HideFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultHideFlagsForNodes)) = hideFlags;
		}
	}

	public unsafe static string ResourcesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747363, XrefRangeEnd = 747367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static NodySettings Instance
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 747384, RefRangeEnd = 747413, XrefRangeStart = 747367, XrefRangeEnd = 747384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_NodySettings_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NodySettings>(intPtr) : null;
		}
	}

	static NodySettings()
	{
		Il2CppClassPointerStore<NodySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Nody", "NodySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodySettings>.NativeClassPtr);
		NativeFieldInfoPtr_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "FILE_NAME");
		NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "s_instance");
		NativeFieldInfoPtr_NormalOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NormalOpacity");
		NativeFieldInfoPtr_ActiveOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "ActiveOpacity");
		NativeFieldInfoPtr_HoverOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "HoverOpacity");
		NativeFieldInfoPtr_FooterHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "FooterHeight");
		NativeFieldInfoPtr_MaxNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "MaxNodeWidth");
		NativeFieldInfoPtr_MinNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "MinNodeWidth");
		NativeFieldInfoPtr_NodeAccentLineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeAccentLineHeight");
		NativeFieldInfoPtr_NodeAddSocketButtonSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeAddSocketButtonSize");
		NativeFieldInfoPtr_NodeBodyOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeBodyOpacity");
		NativeFieldInfoPtr_NodeDeleteButtonSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeDeleteButtonSize");
		NativeFieldInfoPtr_NodeGlowOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeGlowOpacity");
		NativeFieldInfoPtr_NodeHeaderHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeHeaderHeight");
		NativeFieldInfoPtr_NodeHeaderIconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "NodeHeaderIconSize");
		NativeFieldInfoPtr_PingColorChangeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "PingColorChangeSpeed");
		NativeFieldInfoPtr_SocketConnectedOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketConnectedOpacity");
		NativeFieldInfoPtr_SocketCurveModifierMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketCurveModifierMaxValue");
		NativeFieldInfoPtr_SocketCurveModifierMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketCurveModifierMinValue");
		NativeFieldInfoPtr_SocketDividerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketDividerHeight");
		NativeFieldInfoPtr_SocketDividerOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketDividerOpacity");
		NativeFieldInfoPtr_SocketHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketHeight");
		NativeFieldInfoPtr_SocketNotConnectedOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketNotConnectedOpacity");
		NativeFieldInfoPtr_SocketVerticalSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SocketVerticalSpacing");
		NativeFieldInfoPtr_ConnectionPointHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "ConnectionPointHeight");
		NativeFieldInfoPtr_ConnectionPointOffsetFromLeftMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "ConnectionPointOffsetFromLeftMargin");
		NativeFieldInfoPtr_ConnectionPointOffsetFromRightMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "ConnectionPointOffsetFromRightMargin");
		NativeFieldInfoPtr_ConnectionPointWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "ConnectionPointWidth");
		NativeFieldInfoPtr_CurvePointsMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "CurvePointsMultiplier");
		NativeFieldInfoPtr_CurveStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "CurveStrengthModifier");
		NativeFieldInfoPtr_CurveWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "CurveWidth");
		NativeFieldInfoPtr_DefaultCurveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "DefaultCurveModifier");
		NativeFieldInfoPtr_MaxCurveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "MaxCurveModifier");
		NativeFieldInfoPtr_MinCurveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "MinCurveModifier");
		NativeFieldInfoPtr_GraphTabDividerWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "GraphTabDividerWidth");
		NativeFieldInfoPtr_GraphTabElementSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "GraphTabElementSpacing");
		NativeFieldInfoPtr_GraphTabMaximumWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "GraphTabMaximumWidth");
		NativeFieldInfoPtr_GraphTabMinimumWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "GraphTabMinimumWidth");
		NativeFieldInfoPtr_GraphTabsAreaHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "GraphTabsAreaHeight");
		NativeFieldInfoPtr_GraphTabsBackgroundOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "GraphTabsBackgroundOpacity");
		NativeFieldInfoPtr_RepaintIntervalDuringPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "RepaintIntervalDuringPlayMode");
		NativeFieldInfoPtr_RepaintIntervalWhileIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "RepaintIntervalWhileIdle");
		NativeFieldInfoPtr_EditorPrefsKeyWindowToolbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "EditorPrefsKeyWindowToolbar");
		NativeFieldInfoPtr_EditorPrefsKeyDotAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "EditorPrefsKeyDotAnimationSpeed");
		NativeFieldInfoPtr_DefaultNodeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "DefaultNodeHeight");
		NativeFieldInfoPtr_DefaultNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "DefaultNodeWidth");
		NativeFieldInfoPtr_EnterNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "EnterNodeWidth");
		NativeFieldInfoPtr_ExitNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "ExitNodeWidth");
		NativeFieldInfoPtr_StartNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "StartNodeWidth");
		NativeFieldInfoPtr_SubGraphNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SubGraphNodeWidth");
		NativeFieldInfoPtr_SwitchBackNodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "SwitchBackNodeWidth");
		NativeFieldInfoPtr_DefaultHideFlagsForNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, "DefaultHideFlagsForNodes");
		NativeMethodInfoPtr_get_ResourcesPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, 100668971);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_NodySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, 100668972);
		NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, 100668973);
		NativeMethodInfoPtr_UndoRecord_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, 100668974);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodySettings>.NativeClassPtr, 100668975);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747413, XrefRangeEnd = 747417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDirty(bool saveAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&saveAssets);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747417, XrefRangeEnd = 747421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UndoRecord(string undoMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(undoMessage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoRecord_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747421, XrefRangeEnd = 747426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NodySettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodySettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NodySettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
