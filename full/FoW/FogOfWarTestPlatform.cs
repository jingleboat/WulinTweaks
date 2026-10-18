using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace FoW;

public class FogOfWarTestPlatform : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_SetCameraTeam_Public_Abstract_Virtual_New_Void_Camera_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static FogOfWarTestPlatform()
	{
		Il2CppClassPointerStore<FogOfWarTestPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarTestPlatform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarTestPlatform>.NativeClassPtr);
		NativeMethodInfoPtr_SetCameraTeam_Public_Abstract_Virtual_New_Void_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarTestPlatform>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarTestPlatform>.NativeClassPtr, 100667164);
	}

	[CallerCount(0)]
	public unsafe virtual void SetCameraTeam(Camera cam, int team)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &team;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetCameraTeam_Public_Abstract_Virtual_New_Void_Camera_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarTestPlatform()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarTestPlatform>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarTestPlatform(IntPtr pointer)
		: base(pointer)
	{
	}
}
