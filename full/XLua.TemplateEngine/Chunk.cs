using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace XLua.TemplateEngine;

public class Chunk : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Type_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Text_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_TokenType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_TokenType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Private_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TokenType_String_0;

	public unsafe TokenType _Type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Type_k__BackingField);
			return *(TokenType*)num;
		}
		set
		{
			*(TokenType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Type_k__BackingField)) = tokenType;
		}
	}

	public unsafe string _Text_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Text_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Text_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe TokenType Type
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20050, RefRangeEnd = 20053, XrefRangeStart = 20050, XrefRangeEnd = 20053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_get_TokenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(TokenType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57209, RefRangeEnd = 57214, XrefRangeStart = 57209, XrefRangeEnd = 57214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Type_Private_set_Void_TokenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string Text
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Text_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Chunk()
	{
		Il2CppClassPointerStore<Chunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua.TemplateEngine", "Chunk");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chunk>.NativeClassPtr);
		NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "<Type>k__BackingField");
		NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "<Text>k__BackingField");
		NativeMethodInfoPtr_get_Type_Public_get_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100665067);
		NativeMethodInfoPtr_set_Type_Private_set_Void_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100665068);
		NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100665069);
		NativeMethodInfoPtr_set_Text_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100665070);
		NativeMethodInfoPtr__ctor_Public_Void_TokenType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100665071);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 85091, RefRangeEnd = 85121, XrefRangeStart = 85091, XrefRangeEnd = 85121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chunk(TokenType type, string text)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chunk>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TokenType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Chunk(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
