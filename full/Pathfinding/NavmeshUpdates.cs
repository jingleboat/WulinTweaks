using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Pathfinding.Util;

namespace Pathfinding;

[System.Serializable]
public class NavmeshUpdates : Il2CppSystem.Object
{
	public class NavmeshUpdateSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeFieldInfoPtr_forcedReloadRects;

		private static readonly System.IntPtr NativeFieldInfoPtr_graph;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NavmeshBase_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnRecalculatedTiles_Public_Void_Il2CppReferenceArray_1_NavmeshTile_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddClipper_Public_Void_NavmeshClipper_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveClipper_Public_Void_NavmeshClipper_0;

		public unsafe TileHandler handler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TileHandler>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileHandler));
			}
		}

		public unsafe List<IntRect> forcedReloadRects
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedReloadRects);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntRect>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedReloadRects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe NavmeshBase graph
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graph);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavmeshBase>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navmeshBase));
			}
		}

		static NavmeshUpdateSettings()
		{
			Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, "NavmeshUpdateSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, "handler");
			NativeFieldInfoPtr_forcedReloadRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, "forcedReloadRects");
			NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, "graph");
			NativeMethodInfoPtr__ctor_Public_Void_NavmeshBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, 100689546);
			NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, 100689547);
			NativeMethodInfoPtr_OnRecalculatedTiles_Public_Void_Il2CppReferenceArray_1_NavmeshTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, 100689548);
			NativeMethodInfoPtr_AddClipper_Public_Void_NavmeshClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, 100689549);
			NativeMethodInfoPtr_RemoveClipper_Public_Void_NavmeshClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr, 100689550);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075297, RefRangeEnd = 1075299, XrefRangeStart = 1075290, XrefRangeEnd = 1075297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavmeshUpdateSettings(NavmeshBase graph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavmeshUpdateSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NavmeshBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1075331, RefRangeEnd = 1075337, XrefRangeStart = 1075299, XrefRangeEnd = 1075331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(bool forceCreate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&forceCreate);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075339, RefRangeEnd = 1075341, XrefRangeStart = 1075337, XrefRangeEnd = 1075339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRecalculatedTiles(Il2CppReferenceArray<NavmeshTile> tiles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tiles);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRecalculatedTiles_Public_Void_Il2CppReferenceArray_1_NavmeshTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075347, RefRangeEnd = 1075349, XrefRangeStart = 1075341, XrefRangeEnd = 1075347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClipper(NavmeshClipper obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddClipper_Public_Void_NavmeshClipper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075359, RefRangeEnd = 1075360, XrefRangeStart = 1075349, XrefRangeEnd = 1075359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveClipper(NavmeshClipper obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveClipper_Public_Void_NavmeshClipper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NavmeshUpdateSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_updateInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiscardPending_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleOnEnableCallback_Private_Void_NavmeshClipper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleOnDisableCallback_Private_Void_NavmeshClipper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float updateInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInterval)) = num;
		}
	}

	public unsafe float lastUpdateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdateTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdateTime)) = num;
		}
	}

	static NavmeshUpdates()
	{
		Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "NavmeshUpdates");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr);
		NativeFieldInfoPtr_updateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, "updateInterval");
		NativeFieldInfoPtr_lastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, "lastUpdateTime");
		NativeMethodInfoPtr_OnEnable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683651);
		NativeMethodInfoPtr_OnDisable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683652);
		NativeMethodInfoPtr_DiscardPending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683653);
		NativeMethodInfoPtr_HandleOnEnableCallback_Private_Void_NavmeshClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683654);
		NativeMethodInfoPtr_HandleOnDisableCallback_Private_Void_NavmeshClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683655);
		NativeMethodInfoPtr_Update_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683656);
		NativeMethodInfoPtr_ForceUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683657);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr, 100683658);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075360, XrefRangeEnd = 1075378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075396, RefRangeEnd = 1075397, XrefRangeStart = 1075378, XrefRangeEnd = 1075396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075425, RefRangeEnd = 1075426, XrefRangeStart = 1075397, XrefRangeEnd = 1075425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DiscardPending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscardPending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075426, XrefRangeEnd = 1075440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnEnableCallback(NavmeshClipper obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleOnEnableCallback_Private_Void_NavmeshClipper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075440, XrefRangeEnd = 1075451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnDisableCallback(NavmeshClipper obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleOnDisableCallback_Private_Void_NavmeshClipper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075467, RefRangeEnd = 1075468, XrefRangeStart = 1075451, XrefRangeEnd = 1075467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075517, RefRangeEnd = 1075519, XrefRangeStart = 1075468, XrefRangeEnd = 1075517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075520, RefRangeEnd = 1075521, XrefRangeStart = 1075519, XrefRangeEnd = 1075520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavmeshUpdates()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavmeshUpdates>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NavmeshUpdates(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
