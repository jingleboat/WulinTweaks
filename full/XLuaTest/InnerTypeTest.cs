using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLuaTest;

public class InnerTypeTest : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct _InnerStruct
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		[FieldOffset(0)]
		public int x;

		[FieldOffset(4)]
		public int y;

		static _InnerStruct()
		{
			Il2CppClassPointerStore<_InnerStruct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr, "_InnerStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_InnerStruct>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InnerStruct>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InnerStruct>.NativeClassPtr, "y");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_InnerStruct>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Foo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bar_Private__InnerStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static InnerTypeTest()
	{
		Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLuaTest", "InnerTypeTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr);
		NativeMethodInfoPtr_Foo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr, 100665325);
		NativeMethodInfoPtr_Bar_Private__InnerStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr, 100665326);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr, 100665327);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 706129, RefRangeEnd = 706131, XrefRangeStart = 706105, XrefRangeEnd = 706129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Foo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Foo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe _InnerStruct Bar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bar_Private__InnerStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(_InnerStruct*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InnerTypeTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InnerTypeTest>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InnerTypeTest(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
