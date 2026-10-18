using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace WuLin;

public class MapConst : Il2CppSystem.Object
{
	[System.Flags]
	public enum BUILDING_TYPE
	{
		NONE = 0,
		GEAR = 1,
		GATEWAY = 2,
		GATEWAYBUILDING = 4,
		ESCAPEWAY = 8,
		DOOR = 0x10,
		BRIDGE = 0x20,
		SEAT = 0x40
	}

	public enum BuildingOpen
	{
		BOX = 1,
		DOOR
	}

	public enum BuildingOpenCondition
	{
		ITEM,
		PROPERTY
	}

	public enum EM_MISCITEM_TYPE
	{
		ITEM,
		MONEY,
		BAG
	}

	public enum CLICK_TYPE
	{
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant,
		EnumValueAsmResolver_002EDotNet_002EConstant
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxStaticSaveID;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MaxStaticSaveID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxStaticSaveID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxStaticSaveID, (void*)(&num));
		}
	}

	static MapConst()
	{
		Il2CppClassPointerStore<MapConst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MapConst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapConst>.NativeClassPtr);
		NativeFieldInfoPtr_MaxStaticSaveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapConst>.NativeClassPtr, "MaxStaticSaveID");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapConst>.NativeClassPtr, 100674644);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapConst()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapConst>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MapConst(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
