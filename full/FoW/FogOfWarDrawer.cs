using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace FoW;

[System.Serializable]
public class FogOfWarDrawer : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DrawInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fogCenterPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_fogEyePos;

		private static readonly System.IntPtr NativeFieldInfoPtr_fogForward;

		private static readonly System.IntPtr NativeFieldInfoPtr_forwardAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr__sin;

		private static readonly System.IntPtr NativeFieldInfoPtr__cos;

		private static readonly System.IntPtr NativeFieldInfoPtr_xMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_xMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_yMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_yMax;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FogOfWarMap_FogOfWarShape_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Vector2_Vector2_0;

		[FieldOffset(0)]
		public Vector2 fogCenterPos;

		[FieldOffset(8)]
		public Vector2Int fogEyePos;

		[FieldOffset(16)]
		public Vector2 fogForward;

		[FieldOffset(24)]
		public float forwardAngle;

		[FieldOffset(28)]
		public float _sin;

		[FieldOffset(32)]
		public float _cos;

		[FieldOffset(36)]
		public int xMin;

		[FieldOffset(40)]
		public int xMax;

		[FieldOffset(44)]
		public int yMin;

		[FieldOffset(48)]
		public int yMax;

		static DrawInfo()
		{
			Il2CppClassPointerStore<DrawInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, "DrawInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr);
			NativeFieldInfoPtr_fogCenterPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "fogCenterPos");
			NativeFieldInfoPtr_fogEyePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "fogEyePos");
			NativeFieldInfoPtr_fogForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "fogForward");
			NativeFieldInfoPtr_forwardAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "forwardAngle");
			NativeFieldInfoPtr__sin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "_sin");
			NativeFieldInfoPtr__cos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "_cos");
			NativeFieldInfoPtr_xMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "xMin");
			NativeFieldInfoPtr_xMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "xMax");
			NativeFieldInfoPtr_yMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "yMin");
			NativeFieldInfoPtr_yMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, "yMax");
			NativeMethodInfoPtr__ctor_Public_Void_FogOfWarMap_FogOfWarShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, 100685353);
			NativeMethodInfoPtr_Rotate_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, 100685354);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 720889, RefRangeEnd = 720895, XrefRangeStart = 720870, XrefRangeEnd = 720889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawInfo(FogOfWarMap map, FogOfWarShape shape)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FogOfWarMap_FogOfWarShape_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 720895, RefRangeEnd = 720896, XrefRangeStart = 720895, XrefRangeEnd = 720895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 Rotate(Vector2 pos)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&pos);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Public_Vector2_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__map;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialise_Public_Void_FogOfWarMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialise_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fade_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Abstract_Virtual_New_Void_FogOfWarShape_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe FogOfWarMap _map
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__map);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarMap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__map)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogOfWarMap));
		}
	}

	static FogOfWarDrawer()
	{
		Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarDrawer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr);
		NativeFieldInfoPtr__map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, "_map");
		NativeMethodInfoPtr_Initialise_Public_Void_FogOfWarMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666914);
		NativeMethodInfoPtr_OnInitialise_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666915);
		NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666916);
		NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666917);
		NativeMethodInfoPtr_Fade_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666918);
		NativeMethodInfoPtr_GetValues_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666919);
		NativeMethodInfoPtr_SetValues_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666920);
		NativeMethodInfoPtr_Draw_Public_Abstract_Virtual_New_Void_FogOfWarShape_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666921);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr, 100666922);
	}

	[CallerCount(0)]
	public unsafe void Initialise(FogOfWarMap map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialise_Public_Void_FogOfWarMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnInitialise()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInitialise_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void Clear(byte value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Fade(Il2CppStructArray<byte> currentvalues, Il2CppStructArray<byte> totalvalues, float partialfogamount, int inamount, int outamount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentvalues);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)totalvalues);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &partialfogamount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inamount;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outamount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Fade_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Single_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void GetValues(Il2CppStructArray<byte> outvalues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outvalues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValues_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetValues(Il2CppStructArray<byte> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetValues_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void Draw(FogOfWarShape shape, bool ismultithreaded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ismultithreaded;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Draw_Public_Abstract_Virtual_New_Void_FogOfWarShape_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarDrawer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarDrawer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarDrawer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
