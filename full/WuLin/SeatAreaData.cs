using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

public class SeatAreaData : Il2CppSystem.Object
{
	public enum TileDir
	{
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tileDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetTile;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppObjectBase tileDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileDir);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileDir)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase targetTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetTile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetTile)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	static SeatAreaData()
	{
		Il2CppClassPointerStore<SeatAreaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SeatAreaData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeatAreaData>.NativeClassPtr);
		NativeFieldInfoPtr_tileDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeatAreaData>.NativeClassPtr, "tileDir");
		NativeFieldInfoPtr_targetTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeatAreaData>.NativeClassPtr, "targetTile");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeatAreaData>.NativeClassPtr, 100674707);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876239, XrefRangeEnd = 876243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SeatAreaData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeatAreaData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SeatAreaData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
