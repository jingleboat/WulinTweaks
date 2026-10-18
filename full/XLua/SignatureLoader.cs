using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace XLua;

public class SignatureLoader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_userLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_rsa;

	private static readonly System.IntPtr NativeFieldInfoPtr_sha;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CustomLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_load_and_verify_Private_Il2CppStructArray_1_Byte_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_CustomLoader_SignatureLoader_0;

	public unsafe LuaEnv.CustomLoader userLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LuaEnv.CustomLoader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userLoader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customLoader));
		}
	}

	public unsafe RSACryptoServiceProvider rsa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rsa);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RSACryptoServiceProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rsa)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rSACryptoServiceProvider));
		}
	}

	public unsafe SHA1 sha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sha);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SHA1>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sha)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sHA));
		}
	}

	static SignatureLoader()
	{
		Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "XLua", "SignatureLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr);
		NativeFieldInfoPtr_userLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr, "userLoader");
		NativeFieldInfoPtr_rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr, "rsa");
		NativeFieldInfoPtr_sha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr, "sha");
		NativeMethodInfoPtr__ctor_Public_Void_String_CustomLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_load_and_verify_Private_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_op_Implicit_Public_Static_CustomLoader_SignatureLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr, 100664984);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700363, XrefRangeEnd = 700377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SignatureLoader(string publicKey, LuaEnv.CustomLoader loader)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureLoader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(publicKey);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_CustomLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700377, XrefRangeEnd = 700386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> load_and_verify(ref string filepath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(filepath);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_load_and_verify_Private_Il2CppStructArray_1_Byte_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		filepath = IL2CPP.Il2CppStringToManaged(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700386, XrefRangeEnd = 700392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)signatureLoader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_CustomLoader_SignatureLoader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LuaEnv.CustomLoader>(intPtr) : null;
	}

	public SignatureLoader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
