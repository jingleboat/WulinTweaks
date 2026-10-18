using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.AddressableAssets;

public static class AddressablesUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAddressFromAssetReference_Public_Static_String_AssetReference_0;

	static AddressablesUtility()
	{
		Il2CppClassPointerStore<AddressablesUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AddressablesUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesUtility>.NativeClassPtr);
		NativeMethodInfoPtr_GetAddressFromAssetReference_Public_Static_String_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesUtility>.NativeClassPtr, 100664557);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693080, XrefRangeEnd = 693099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetAddressFromAssetReference(AssetReference reference)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAddressFromAssetReference_Public_Static_String_AssetReference_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public AddressablesUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
