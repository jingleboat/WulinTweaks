using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Doozy.Engine.Extensions;

public static class ClassUtils : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Clone_Public_Static_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Clone_Public_Static_T_T_0, Il2CppClassPointerStore<ClassUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Static_T_T_0;

	static ClassUtils()
	{
		Il2CppClassPointerStore<ClassUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Extensions", "ClassUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassUtils>.NativeClassPtr);
		NativeMethodInfoPtr_Clone_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassUtils>.NativeClassPtr, 100669259);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749697, RefRangeEnd = 749698, XrefRangeStart = 749671, XrefRangeEnd = 749697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Clone<T>(this T source)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = source;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref source;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Clone_Public_Static_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	public ClassUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
