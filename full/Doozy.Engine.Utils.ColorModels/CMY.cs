using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Doozy.Engine.Utils.ColorModels;

[System.Serializable]
public class CMY : Il2CppSystem.Object
{
	public class C : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN;

		private static readonly System.IntPtr NativeFieldInfoPtr_MAX;

		private static readonly System.IntPtr NativeFieldInfoPtr_F;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static float MIN
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN, (void*)(&num));
			}
		}

		public unsafe static float MAX
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX, (void*)(&num));
			}
		}

		public unsafe static int F
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_F, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_F, (void*)(&num));
			}
		}

		static C()
		{
			Il2CppClassPointerStore<C>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CMY>.NativeClassPtr, "C");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<C>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<C>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<C>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<C>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<C>.NativeClassPtr, 100685436);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe C()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<C>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public C(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class M : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN;

		private static readonly System.IntPtr NativeFieldInfoPtr_MAX;

		private static readonly System.IntPtr NativeFieldInfoPtr_F;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static float MIN
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN, (void*)(&num));
			}
		}

		public unsafe static float MAX
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX, (void*)(&num));
			}
		}

		public unsafe static int F
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_F, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_F, (void*)(&num));
			}
		}

		static M()
		{
			Il2CppClassPointerStore<M>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CMY>.NativeClassPtr, "M");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<M>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<M>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<M>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<M>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<M>.NativeClassPtr, 100685437);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe M()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<M>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public M(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Y : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN;

		private static readonly System.IntPtr NativeFieldInfoPtr_MAX;

		private static readonly System.IntPtr NativeFieldInfoPtr_F;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static float MIN
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN, (void*)(&num));
			}
		}

		public unsafe static float MAX
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX, (void*)(&num));
			}
		}

		public unsafe static int F
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_F, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_F, (void*)(&num));
			}
		}

		static Y()
		{
			Il2CppClassPointerStore<Y>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CMY>.NativeClassPtr, "Y");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Y>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Y>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Y>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Y>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Y>.NativeClassPtr, 100685438);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Y()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Y>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Y(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_m;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_CMY_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Color_Public_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRGB_Public_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_CMY_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Factorize_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_Boolean_0;

	public unsafe float c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c)) = num;
		}
	}

	public unsafe float m
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m)) = num;
		}
	}

	public unsafe float y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
		}
	}

	static CMY()
	{
		Il2CppClassPointerStore<CMY>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils.ColorModels", "CMY");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CMY>.NativeClassPtr);
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CMY>.NativeClassPtr, "c");
		NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CMY>.NativeClassPtr, "m");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CMY>.NativeClassPtr, "y");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667428);
		NativeMethodInfoPtr_Copy_Public_CMY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr_Color_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr_ToRGB_Public_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667431);
		NativeMethodInfoPtr_Validate_Public_CMY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667432);
		NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667433);
		NativeMethodInfoPtr_Factorize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667434);
		NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667435);
		NativeMethodInfoPtr_ToString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CMY>.NativeClassPtr, 100667436);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 728092, RefRangeEnd = 728117, XrefRangeStart = 728091, XrefRangeEnd = 728092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CMY(float C, float M, float Y)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CMY>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&C);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &M;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &Y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728117, XrefRangeEnd = 728121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CMY Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_CMY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CMY>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728121, XrefRangeEnd = 728124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color Color(float alpha = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alpha);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Color_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728124, XrefRangeEnd = 728125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RGB ToRGB()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRGB_Public_RGB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 728131, RefRangeEnd = 728153, XrefRangeStart = 728125, XrefRangeEnd = 728131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CMY Validate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Public_CMY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CMY>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728153, XrefRangeEnd = 728155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ValidateColor(float value, float min, float max)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 728164, RefRangeEnd = 728167, XrefRangeStart = 728155, XrefRangeEnd = 728164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 Factorize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Factorize_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728167, XrefRangeEnd = 728170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FactorizeColor(float value, float min, float max, float f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &f;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728170, XrefRangeEnd = 728217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToString(bool factorize = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&factorize);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public CMY(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
