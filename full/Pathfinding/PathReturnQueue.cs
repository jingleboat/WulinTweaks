using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Pathfinding;

public class PathReturnQueue : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pathReturnQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_pathsClaimedSilentlyBy;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnPaths_Public_Void_Boolean_0;

	public unsafe Queue<Path> pathReturnQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathReturnQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<Path>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathReturnQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe Il2CppSystem.Object pathsClaimedSilentlyBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathsClaimedSilentlyBy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathsClaimedSilentlyBy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	static PathReturnQueue()
	{
		Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "PathReturnQueue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr);
		NativeFieldInfoPtr_pathReturnQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr, "pathReturnQueue");
		NativeFieldInfoPtr_pathsClaimedSilentlyBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr, "pathsClaimedSilentlyBy");
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr, 100682711);
		NativeMethodInfoPtr_Enqueue_Public_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr, 100682712);
		NativeMethodInfoPtr_ReturnPaths_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr, 100682713);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065850, RefRangeEnd = 1065851, XrefRangeStart = 1065843, XrefRangeEnd = 1065850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PathReturnQueue(Il2CppSystem.Object pathsClaimedSilentlyBy)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathReturnQueue>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathsClaimedSilentlyBy);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065857, RefRangeEnd = 1065858, XrefRangeStart = 1065851, XrefRangeEnd = 1065857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Enqueue(Path path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enqueue_Public_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1065889, RefRangeEnd = 1065895, XrefRangeStart = 1065858, XrefRangeEnd = 1065889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnPaths(bool timeSlice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeSlice);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnPaths_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PathReturnQueue(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
