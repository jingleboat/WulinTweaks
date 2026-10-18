using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Nody.Connections;
using Doozy.Engine.Nody.Models;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Doozy.Engine.UI.Connections;

[Serializable]
public class WeightedConnection : PassthroughConnection
{
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_WEIGHT;

	private static readonly IntPtr NativeFieldInfoPtr_Weight;

	private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_WeightedConnection_Socket_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_Socket_WeightedConnection_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int DEFAULT_WEIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_WEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_WEIGHT, (void*)(&num));
		}
	}

	public unsafe int Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight)) = num;
		}
	}

	static WeightedConnection()
	{
		Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.UI.Connections", "WeightedConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_WEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr, "DEFAULT_WEIGHT");
		NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr, "Weight");
		NativeMethodInfoPtr_GetValue_Public_Static_WeightedConnection_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr, 100668267);
		NativeMethodInfoPtr_SetValue_Public_Static_Void_Socket_WeightedConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr, 100668268);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr, 100668269);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 737549, RefRangeEnd = 737551, XrefRangeStart = 737545, XrefRangeEnd = 737549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static WeightedConnection GetValue(Socket socket)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socket);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Static_WeightedConnection_Socket_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WeightedConnection>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 737537, RefRangeEnd = 737538, XrefRangeStart = 737537, XrefRangeEnd = 737538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValue(Socket socket, WeightedConnection value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socket);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Static_Void_Socket_WeightedConnection_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737551, XrefRangeEnd = 737552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeightedConnection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedConnection>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WeightedConnection(IntPtr pointer)
		: base(pointer)
	{
	}
}
