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
public class HSL : Il2CppSystem.Object
{
	public class H : Il2CppSystem.Object
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

		static H()
		{
			Il2CppClassPointerStore<H>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HSL>.NativeClassPtr, "H");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<H>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<H>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<H>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<H>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<H>.NativeClassPtr, 100685443);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe H()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<H>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public H(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class S : Il2CppSystem.Object
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

		static S()
		{
			Il2CppClassPointerStore<S>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HSL>.NativeClassPtr, "S");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<S>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<S>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<S>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<S>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<S>.NativeClassPtr, 100685444);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe S()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<S>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public S(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class L : Il2CppSystem.Object
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

		static L()
		{
			Il2CppClassPointerStore<L>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HSL>.NativeClassPtr, "L");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<L>.NativeClassPtr);
			NativeFieldInfoPtr_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "MIN");
			NativeFieldInfoPtr_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "MAX");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "F");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100685445);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe L()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<L>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public L(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_s;

	private static readonly System.IntPtr NativeFieldInfoPtr_l;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_HSL_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Color_Public_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRGB_Public_RGB_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_HSL_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Factorize_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_Boolean_0;

	public unsafe float h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h)) = num;
		}
	}

	public unsafe float s
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)) = num;
		}
	}

	public unsafe float l
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_l);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_l)) = num;
		}
	}

	static HSL()
	{
		Il2CppClassPointerStore<HSL>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Utils.ColorModels", "HSL");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSL>.NativeClassPtr);
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSL>.NativeClassPtr, "h");
		NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSL>.NativeClassPtr, "s");
		NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSL>.NativeClassPtr, "l");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667446);
		NativeMethodInfoPtr_Copy_Public_HSL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667447);
		NativeMethodInfoPtr_Color_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667448);
		NativeMethodInfoPtr_ToRGB_Public_RGB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667449);
		NativeMethodInfoPtr_Validate_Public_HSL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667450);
		NativeMethodInfoPtr_ValidateColor_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667451);
		NativeMethodInfoPtr_Factorize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667452);
		NativeMethodInfoPtr_FactorizeColor_Private_Int32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667453);
		NativeMethodInfoPtr_ToString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSL>.NativeClassPtr, 100667454);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 728092, RefRangeEnd = 728117, XrefRangeStart = 728092, XrefRangeEnd = 728117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HSL(float H, float S, float L)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HSL>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&H);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &S;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &L;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728312, XrefRangeEnd = 728316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HSL Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_HSL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HSL>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728316, XrefRangeEnd = 728319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728319, XrefRangeEnd = 728320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 728131, RefRangeEnd = 728153, XrefRangeStart = 728131, XrefRangeEnd = 728153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HSL Validate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Public_HSL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HSL>(intPtr) : null;
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

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 728329, RefRangeEnd = 728337, XrefRangeStart = 728320, XrefRangeEnd = 728329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728337, XrefRangeEnd = 728385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public HSL(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
