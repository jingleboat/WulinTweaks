using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace FoW;

public class FogOfWarBlur : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__target;

	private static readonly System.IntPtr NativeFieldInfoPtr__source;

	private static readonly System.IntPtr NativeFieldInfoPtr__blurMaterial;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderTarget_Private_Void_Vector2Int_byref_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Texture_Texture2D_Vector2Int_Int32_Int32_FogOfWarBlurType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RenderTexture _target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__target);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__target)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTexture));
		}
	}

	public unsafe RenderTexture _source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__source);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTexture));
		}
	}

	public unsafe static Material _blurMaterial
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__blurMaterial, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__blurMaterial, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	static FogOfWarBlur()
	{
		Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarBlur");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr);
		NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr, "_target");
		NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr, "_source");
		NativeFieldInfoPtr__blurMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr, "_blurMaterial");
		NativeMethodInfoPtr_SetupRenderTarget_Private_Void_Vector2Int_byref_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr, 100666850);
		NativeMethodInfoPtr_Apply_Public_Texture_Texture2D_Vector2Int_Int32_Int32_FogOfWarBlurType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr, 100666851);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr, 100666852);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 720317, RefRangeEnd = 720319, XrefRangeStart = 720309, XrefRangeEnd = 720317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderTarget(Vector2Int resolution, ref RenderTexture tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&resolution);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderTarget_Private_Void_Vector2Int_byref_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		tex = ((intPtr4 == (System.IntPtr)0) ? null : new RenderTexture(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 720375, RefRangeEnd = 720376, XrefRangeStart = 720319, XrefRangeEnd = 720375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture Apply(Texture2D fogtexture, Vector2Int resolution, int amount, int iterations, FogOfWarBlurType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogtexture);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolution;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &iterations;
		*(FogOfWarBlurType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Public_Texture_Texture2D_Vector2Int_Int32_Int32_FogOfWarBlurType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarBlur()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarBlur>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarBlur(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
