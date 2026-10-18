using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class AsyncMethodBuilderAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__BuilderType_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BuilderType_Public_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	public unsafe Type _BuilderType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuilderType_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuilderType_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe Type BuilderType
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 13952, RefRangeEnd = 13960, XrefRangeStart = 13952, XrefRangeEnd = 13960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BuilderType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
	}

	static AsyncMethodBuilderAttribute()
	{
		Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "System.Runtime.CompilerServices", "AsyncMethodBuilderAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__BuilderType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr, "<BuilderType>k__BackingField");
		NativeMethodInfoPtr_get_BuilderType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr, 100667183);
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr, 100667184);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 26864, RefRangeEnd = 26891, XrefRangeStart = 26864, XrefRangeEnd = 26891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AsyncMethodBuilderAttribute(Type builderType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builderType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AsyncMethodBuilderAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
