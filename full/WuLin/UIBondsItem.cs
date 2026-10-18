using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace WuLin;

public class UIBondsItem : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_imgLight;

	private static readonly IntPtr NativeFieldInfoPtr_imgHead;

	private static readonly IntPtr NativeFieldInfoPtr_NpcID;

	private static readonly IntPtr NativeFieldInfoPtr_rootPath;

	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Image imgLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image imgHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgHead);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgHead)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe int NpcID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcID)) = num;
		}
	}

	public unsafe string rootPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootPath);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static UIBondsItem()
	{
		Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UIBondsItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr);
		NativeFieldInfoPtr_imgLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr, "imgLight");
		NativeFieldInfoPtr_imgHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr, "imgHead");
		NativeFieldInfoPtr_NpcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr, "NpcID");
		NativeFieldInfoPtr_rootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr, "rootPath");
		NativeMethodInfoPtr_init_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr, 100675610);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr, 100675611);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 902142, RefRangeEnd = 902143, XrefRangeStart = 902069, XrefRangeEnd = 902142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(int npcID, bool isLight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&npcID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isLight;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902143, XrefRangeEnd = 902146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIBondsItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBondsItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIBondsItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
