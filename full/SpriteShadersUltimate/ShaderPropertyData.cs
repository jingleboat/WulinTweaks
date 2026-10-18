using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering;

namespace SpriteShadersUltimate;

[System.Serializable]
public class ShaderPropertyData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_propName;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_floatValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_vectorValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Boolean_byref_Material_String_ShaderPropertyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Void_byref_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShaderPropertyType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ShaderPropertyType*)num;
		}
		set
		{
			*(ShaderPropertyType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = shaderPropertyType;
		}
	}

	public unsafe string propName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color colorValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorValue);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorValue)) = color;
		}
	}

	public unsafe float floatValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floatValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floatValue)) = num;
		}
	}

	public unsafe Texture textureValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureValue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture));
		}
	}

	public unsafe Vector4 vectorValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vectorValue);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vectorValue)) = vector;
		}
	}

	static ShaderPropertyData()
	{
		Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SpriteShadersUltimate", "ShaderPropertyData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, "type");
		NativeFieldInfoPtr_propName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, "propName");
		NativeFieldInfoPtr_colorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, "colorValue");
		NativeFieldInfoPtr_floatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, "floatValue");
		NativeFieldInfoPtr_textureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, "textureValue");
		NativeFieldInfoPtr_vectorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, "vectorValue");
		NativeMethodInfoPtr_Set_Public_Boolean_byref_Material_String_ShaderPropertyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, 100665466);
		NativeMethodInfoPtr_Get_Public_Void_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, 100665467);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr, 100665468);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 707840, RefRangeEnd = 707842, XrefRangeStart = 707835, XrefRangeEnd = 707840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Set(ref Material mat, string propertyName, ShaderPropertyType propertyType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(ShaderPropertyType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &propertyType;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Boolean_byref_Material_String_ShaderPropertyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		mat = ((intPtr4 == (System.IntPtr)0) ? null : new Material(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 707853, RefRangeEnd = 707854, XrefRangeStart = 707842, XrefRangeEnd = 707853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Get(ref Material mat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Void_byref_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		mat = ((intPtr4 == (System.IntPtr)0) ? null : new Material(intPtr4));
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderPropertyData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderPropertyData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShaderPropertyData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
