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
public class RGB : Il2CppSystem.Object
{
	public class R : Il2CppSystem.Object
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

		static R()
		{
			Il2CppClassPointerStore<R>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RGB>.NativeClassPtr, "R");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<R>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<R>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<R>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<R>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<R>.NativeClassPtr, 100685449);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe R()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<R>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public R(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class G : Il2CppSystem.Object
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

		static G()
		{
			Il2CppClassPointerStore<G>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RGB>.NativeClassPtr, "G");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G>.NativeClassPtr, 100685450);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe G()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public G(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class B : Il2CppSystem.Object
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

		static B()
		{
			Il2CppClassPointerStore<B>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RGB>.NativeClassPtr, "B");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<B>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<B>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<B>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<B>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<B>.NativeClassPtr, 100685451);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe B()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<B>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public B(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_g;

	private static readonly System.IntPtr NativeFieldInfoPtr_b;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Color_Public_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHSL_Public_HSL_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHSV_Public_HSV_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCMY_Public_CMY_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCMYK_Public_CMYK_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToXYZ_Public_XYZ_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Factorize_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHEX_Public_String_Boolean_0;

	public unsafe float r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r)) = num;
		}
	}

	public unsafe float g
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g)) = num;
		}
	}

	public unsafe float b
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b)) = num;
		}
	}

	static RGB()
	{
		Il2CppClassPointerStore<RGB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils.ColorModels", "RGB");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RGB>.NativeClassPtr);
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RGB>.NativeClassPtr, "r");
		NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RGB>.NativeClassPtr, "g");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RGB>.NativeClassPtr, "b");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667464);
		NativeMethodInfoPtr_Copy_Public_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667465);
		NativeMethodInfoPtr_Color_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667466);
		NativeMethodInfoPtr_ToHSL_Public_HSL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667467);
		NativeMethodInfoPtr_ToHSV_Public_HSV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667468);
		NativeMethodInfoPtr_ToCMY_Public_CMY_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667469);
		NativeMethodInfoPtr_ToCMYK_Public_CMYK_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667470);
		NativeMethodInfoPtr_ToXYZ_Public_XYZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667471);
		NativeMethodInfoPtr_Validate_Public_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667472);
		NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667473);
		NativeMethodInfoPtr_Factorize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667474);
		NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667475);
		NativeMethodInfoPtr_ToString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667476);
		NativeMethodInfoPtr_ToHEX_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RGB>.NativeClassPtr, 100667477);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 728092, RefRangeEnd = 728117, XrefRangeStart = 728092, XrefRangeEnd = 728117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RGB(float R, float G, float B)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RGB>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&R);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &G;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &B;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728447, XrefRangeEnd = 728451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RGB Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_RGB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 728453, RefRangeEnd = 728458, XrefRangeStart = 728451, XrefRangeEnd = 728453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728458, XrefRangeEnd = 728459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HSL ToHSL()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHSL_Public_HSL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HSL>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728459, XrefRangeEnd = 728460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HSV ToHSV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHSV_Public_HSV_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HSV>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728460, XrefRangeEnd = 728461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CMY ToCMY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCMY_Public_CMY_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CMY>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728461, XrefRangeEnd = 728462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CMYK ToCMYK()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCMYK_Public_CMYK_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CMYK>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728462, XrefRangeEnd = 728463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XYZ ToXYZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToXYZ_Public_XYZ_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XYZ>(intPtr) : null;
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 728131, RefRangeEnd = 728153, XrefRangeStart = 728131, XrefRangeEnd = 728153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RGB Validate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Public_RGB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RGB>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 728472, RefRangeEnd = 728475, XrefRangeStart = 728463, XrefRangeEnd = 728472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728475, XrefRangeEnd = 728522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728522, XrefRangeEnd = 728530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToHEX(bool addHashTag = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addHashTag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHEX_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public RGB(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
