using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Doozy.Engine;

public static class MessageExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Send_Public_Static_Void_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Send_Public_Static_Void_T_0, Il2CppClassPointerStore<MessageExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Static_Void_T_0;

	static MessageExtensions()
	{
		Il2CppClassPointerStore<MessageExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine", "MessageExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Send_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageExtensions>.NativeClassPtr, 100667350);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725772, XrefRangeEnd = 725775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Send<T>(this T self) where T : Message
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = self;
			reference = ref *(T*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref self;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Send_Public_Static_Void_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MessageExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
