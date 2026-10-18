using System;
using System.Runtime.CompilerServices;
using GamePlugins.InspectorEnhance;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class AreaOwnerCell : SerializedMonoBehaviour
{
	[System.Serializable]
	public class AreaOwnerData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_IsOwnerPerson;

		private static readonly System.IntPtr NativeFieldInfoPtr_ID;

		private static readonly System.IntPtr NativeFieldInfoPtr_RelationValue;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0;

		public unsafe bool IsOwnerPerson
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOwnerPerson);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOwnerPerson)) = flag;
			}
		}

		public unsafe int ID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID)) = num;
			}
		}

		public unsafe int RelationValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelationValue);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelationValue)) = num;
			}
		}

		static AreaOwnerData()
		{
			Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr, "AreaOwnerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr);
			NativeFieldInfoPtr_IsOwnerPerson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr, "IsOwnerPerson");
			NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr, "ID");
			NativeFieldInfoPtr_RelationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr, "RelationValue");
			NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr, 100687320);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463954, RefRangeEnd = 463956, XrefRangeStart = 463954, XrefRangeEnd = 463956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AreaOwnerData(bool isOwnerPerson, int id, int relation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaOwnerData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&isOwnerPerson);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &relation;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AreaOwnerData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_OwnerColorList;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOwner_Public_Void_Color32_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnerData_Public_AreaOwnerData_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<Color32, AreaOwnerData> OwnerColorList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OwnerColorList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Color32, AreaOwnerData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OwnerColorList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static AreaOwnerCell()
	{
		Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "AreaOwnerCell");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr);
		NativeFieldInfoPtr_OwnerColorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr, "OwnerColorList");
		NativeMethodInfoPtr_SetOwner_Public_Void_Color32_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr, 100674564);
		NativeMethodInfoPtr_GetOwnerData_Public_AreaOwnerData_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr, 100674565);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr, 100674566);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873529, XrefRangeEnd = 873534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOwner(Color32 color, bool isOwnerPerson, int ID, int relation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&color);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOwnerPerson;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ID;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &relation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOwner_Public_Void_Color32_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873537, RefRangeEnd = 873539, XrefRangeStart = 873534, XrefRangeEnd = 873537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaOwnerData GetOwnerData(Color32 color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOwnerData_Public_AreaOwnerData_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AreaOwnerData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873539, XrefRangeEnd = 873546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AreaOwnerCell()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaOwnerCell>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AreaOwnerCell(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
