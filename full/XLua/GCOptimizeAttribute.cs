using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua;

public class GCOptimizeAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flag;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Flag_Public_get_OptimizeFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OptimizeFlag_0;

	public unsafe OptimizeFlag flag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag);
			return *(OptimizeFlag*)num;
		}
		set
		{
			*(OptimizeFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flag)) = optimizeFlag;
		}
	}

	public unsafe OptimizeFlag Flag
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Flag_Public_get_OptimizeFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(OptimizeFlag*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static GCOptimizeAttribute()
	{
		Il2CppClassPointerStore<GCOptimizeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "GCOptimizeAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCOptimizeAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCOptimizeAttribute>.NativeClassPtr, "flag");
		NativeMethodInfoPtr_get_Flag_Public_get_OptimizeFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCOptimizeAttribute>.NativeClassPtr, 100664749);
		NativeMethodInfoPtr__ctor_Public_Void_OptimizeFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCOptimizeAttribute>.NativeClassPtr, 100664750);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 57193, RefRangeEnd = 57209, XrefRangeStart = 57193, XrefRangeEnd = 57209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GCOptimizeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_OptimizeFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GCOptimizeAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
