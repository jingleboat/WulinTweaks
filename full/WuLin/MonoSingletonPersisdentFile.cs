using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class MonoSingletonPersisdentFile : MonoSingleton<MonoSingletonPersisdentFile>
{
	private static readonly IntPtr NativeFieldInfoPtr_allSingletonWithPersisdentFile;

	private static readonly IntPtr NativeFieldInfoPtr_saveFile;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Save_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static HashSet<MonoSingletonPersisdentFile> allSingletonWithPersisdentFile
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_allSingletonWithPersisdentFile, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<MonoSingletonPersisdentFile>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_allSingletonWithPersisdentFile, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe ES3File saveFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveFile);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ES3File>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveFile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eS3File));
		}
	}

	static MonoSingletonPersisdentFile()
	{
		Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MonoSingletonPersisdentFile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr);
		NativeFieldInfoPtr_allSingletonWithPersisdentFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr, "allSingletonWithPersisdentFile");
		NativeFieldInfoPtr_saveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr, "saveFile");
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr, 100673531);
		NativeMethodInfoPtr_Save_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr, 100673532);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr, 100673533);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845718, XrefRangeEnd = 845737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Save_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845737, XrefRangeEnd = 845743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoSingletonPersisdentFile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoSingletonPersisdentFile>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MonoSingletonPersisdentFile(IntPtr pointer)
		: base(pointer)
	{
	}
}
