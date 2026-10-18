using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using UnityEngine;

namespace Pathfinding.Serialization;

public class TinyJsonDeserializer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_contextRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_numberFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_builder;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_Object_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Private_Object_Type_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeUnityObject_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeUnityObjectInner_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Eat_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EatUntil_Private_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEat_Private_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EatField_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipFieldData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextReader reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textReader));
		}
	}

	public unsafe GameObject contextRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextRoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextRoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static NumberFormatInfo numberFormat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numberFormat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numberFormat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)numberFormatInfo));
		}
	}

	public unsafe StringBuilder builder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringBuilder));
		}
	}

	static TinyJsonDeserializer()
	{
		Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Serialization", "TinyJsonDeserializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr);
		NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, "reader");
		NativeFieldInfoPtr_contextRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, "contextRoot");
		NativeFieldInfoPtr_numberFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, "numberFormat");
		NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, "builder");
		NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_Object_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684041);
		NativeMethodInfoPtr_Deserialize_Private_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684042);
		NativeMethodInfoPtr_DeserializeUnityObject_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684043);
		NativeMethodInfoPtr_DeserializeUnityObjectInner_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684044);
		NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684045);
		NativeMethodInfoPtr_Eat_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684046);
		NativeMethodInfoPtr_EatUntil_Private_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684047);
		NativeMethodInfoPtr_TryEat_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684048);
		NativeMethodInfoPtr_EatField_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684049);
		NativeMethodInfoPtr_SkipFieldData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684050);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr, 100684051);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1081069, RefRangeEnd = 1081072, XrefRangeStart = 1081056, XrefRangeEnd = 1081069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Deserialize(string text, Il2CppSystem.Type type, Il2CppSystem.Object populate = null, GameObject contextRoot = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)populate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextRoot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_Object_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1081266, RefRangeEnd = 1081270, XrefRangeStart = 1081072, XrefRangeEnd = 1081266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object Deserialize(Il2CppSystem.Type tp, Il2CppSystem.Object populate = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)populate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Private_Object_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081270, XrefRangeEnd = 1081277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityEngine.Object DeserializeUnityObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeUnityObject_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081341, RefRangeEnd = 1081343, XrefRangeStart = 1081277, XrefRangeEnd = 1081341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityEngine.Object DeserializeUnityObjectInner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeUnityObjectInner_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1081348, RefRangeEnd = 1081363, XrefRangeStart = 1081343, XrefRangeEnd = 1081348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EatWhitespace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1081366, RefRangeEnd = 1081376, XrefRangeStart = 1081363, XrefRangeEnd = 1081366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Eat(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Eat_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1081388, RefRangeEnd = 1081390, XrefRangeStart = 1081376, XrefRangeEnd = 1081388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string EatUntil(string c, bool inString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(c);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inString;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EatUntil_Private_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1081391, RefRangeEnd = 1081394, XrefRangeStart = 1081390, XrefRangeEnd = 1081391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryEat(char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEat_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1081402, RefRangeEnd = 1081413, XrefRangeStart = 1081394, XrefRangeEnd = 1081402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string EatField()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EatField_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081416, RefRangeEnd = 1081417, XrefRangeStart = 1081413, XrefRangeEnd = 1081416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipFieldData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipFieldData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081417, XrefRangeEnd = 1081422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TinyJsonDeserializer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TinyJsonDeserializer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TinyJsonDeserializer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
