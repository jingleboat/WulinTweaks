using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Pathfinding;

[System.Serializable]
public class AstarColor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__SolidColor;

	private static readonly System.IntPtr NativeFieldInfoPtr__UnwalkableNode;

	private static readonly System.IntPtr NativeFieldInfoPtr__BoundsHandles;

	private static readonly System.IntPtr NativeFieldInfoPtr__ConnectionLowLerp;

	private static readonly System.IntPtr NativeFieldInfoPtr__ConnectionHighLerp;

	private static readonly System.IntPtr NativeFieldInfoPtr__MeshEdgeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr__AreaColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_SolidColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnwalkableNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoundsHandles;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionLowLerp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionHighLerp;

	private static readonly System.IntPtr NativeFieldInfoPtr_MeshEdgeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_AreaColors;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorHash_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaColor_Public_Static_Color_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTagColor_Public_Static_Color_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushToStatic_Public_Void_AstarPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Color _SolidColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SolidColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SolidColor)) = color;
		}
	}

	public unsafe Color _UnwalkableNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UnwalkableNode);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UnwalkableNode)) = color;
		}
	}

	public unsafe Color _BoundsHandles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoundsHandles);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoundsHandles)) = color;
		}
	}

	public unsafe Color _ConnectionLowLerp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectionLowLerp);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectionLowLerp)) = color;
		}
	}

	public unsafe Color _ConnectionHighLerp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectionHighLerp);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectionHighLerp)) = color;
		}
	}

	public unsafe Color _MeshEdgeColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MeshEdgeColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MeshEdgeColor)) = color;
		}
	}

	public unsafe Il2CppStructArray<Color> _AreaColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AreaColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AreaColors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Color SolidColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SolidColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SolidColor, (void*)(&color));
		}
	}

	public unsafe static Color UnwalkableNode
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnwalkableNode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnwalkableNode, (void*)(&color));
		}
	}

	public unsafe static Color BoundsHandles
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BoundsHandles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BoundsHandles, (void*)(&color));
		}
	}

	public unsafe static Color ConnectionLowLerp
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConnectionLowLerp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConnectionLowLerp, (void*)(&color));
		}
	}

	public unsafe static Color ConnectionHighLerp
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConnectionHighLerp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConnectionHighLerp, (void*)(&color));
		}
	}

	public unsafe static Color MeshEdgeColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MeshEdgeColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MeshEdgeColor, (void*)(&color));
		}
	}

	public unsafe static Il2CppStructArray<Color> AreaColors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AreaColors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AreaColors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static AstarColor()
	{
		Il2CppClassPointerStore<AstarColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "AstarColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarColor>.NativeClassPtr);
		NativeFieldInfoPtr__SolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_SolidColor");
		NativeFieldInfoPtr__UnwalkableNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_UnwalkableNode");
		NativeFieldInfoPtr__BoundsHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_BoundsHandles");
		NativeFieldInfoPtr__ConnectionLowLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_ConnectionLowLerp");
		NativeFieldInfoPtr__ConnectionHighLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_ConnectionHighLerp");
		NativeFieldInfoPtr__MeshEdgeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_MeshEdgeColor");
		NativeFieldInfoPtr__AreaColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "_AreaColors");
		NativeFieldInfoPtr_SolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "SolidColor");
		NativeFieldInfoPtr_UnwalkableNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "UnwalkableNode");
		NativeFieldInfoPtr_BoundsHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "BoundsHandles");
		NativeFieldInfoPtr_ConnectionLowLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "ConnectionLowLerp");
		NativeFieldInfoPtr_ConnectionHighLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "ConnectionHighLerp");
		NativeFieldInfoPtr_MeshEdgeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "MeshEdgeColor");
		NativeFieldInfoPtr_AreaColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, "AreaColors");
		NativeMethodInfoPtr_ColorHash_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, 100682910);
		NativeMethodInfoPtr_GetAreaColor_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, 100682911);
		NativeMethodInfoPtr_GetTagColor_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, 100682912);
		NativeMethodInfoPtr_PushToStatic_Public_Void_AstarPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, 100682913);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarColor>.NativeClassPtr, 100682914);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067076, RefRangeEnd = 1067077, XrefRangeStart = 1067054, XrefRangeEnd = 1067076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ColorHash()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorHash_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067077, XrefRangeEnd = 1067083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetAreaColor(uint area)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&area);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaColor_Public_Static_Color_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067083, XrefRangeEnd = 1067089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetTagColor(uint tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTagColor_Public_Static_Color_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1067102, RefRangeEnd = 1067104, XrefRangeStart = 1067089, XrefRangeEnd = 1067102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushToStatic(AstarPath astar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)astar);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushToStatic_Public_Void_AstarPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067104, XrefRangeEnd = 1067111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AstarColor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarColor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AstarColor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
