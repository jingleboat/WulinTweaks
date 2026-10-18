using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Pathfinding;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WuLin;

public static class GameUtil : Il2CppSystem.Object
{
	[ObfuscatedName("WuLin.GameUtil+<>c__DisplayClass43_0")]
	public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dict;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortWithPathNear_b__0_Internal_Int32_Vector3Int_Vector3Int_0;

		public unsafe Dictionary<Vector3Int, int> dict
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dict);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static __c__DisplayClass43_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c__DisplayClass43_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr);
			NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, "dict");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, 100688354);
			NativeMethodInfoPtr__SortWithPathNear_b__0_Internal_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, 100688355);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass43_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980306, XrefRangeEnd = 980312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortWithPathNear_b__0(Vector3Int a, Vector3Int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortWithPathNear_b__0_Internal_Int32_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass43_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.GameUtil+<>c__DisplayClass44_0")]
	public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dict;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortWithPathFar_b__0_Internal_Int32_Vector3Int_Vector3Int_0;

		public unsafe Dictionary<Vector3Int, int> dict
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dict);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static __c__DisplayClass44_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c__DisplayClass44_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr);
			NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, "dict");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, 100688356);
			NativeMethodInfoPtr__SortWithPathFar_b__0_Internal_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, 100688357);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass44_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980312, XrefRangeEnd = 980318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortWithPathFar_b__0(Vector3Int a, Vector3Int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortWithPathFar_b__0_Internal_Int32_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass44_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.GameUtil+<>c__DisplayClass45_0")]
	public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_target;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNearesetPointPathTo_b__0_Internal_Int32_Vector3Int_Vector3Int_0;

		public unsafe Vector3Int target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)) = vector3Int;
			}
		}

		static __c__DisplayClass45_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c__DisplayClass45_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr);
			NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, "target");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, 100688358);
			NativeMethodInfoPtr__GetNearesetPointPathTo_b__0_Internal_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, 100688359);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass45_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980318, XrefRangeEnd = 980324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetNearesetPointPathTo_b__0(Vector3Int x, Vector3Int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&x);
			*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNearesetPointPathTo_b__0_Internal_Int32_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass45_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("WuLin.GameUtil+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__103_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__136_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__136_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortById_b__103_0_Internal_Int32_ItemData_ItemData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBuffListData_b__136_0_Internal_Int32_BuffInstance_BuffInstance_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBuffListData_b__136_1_Internal_Int32_BuffInstance_BuffInstance_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<ItemData> __9__103_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__103_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ItemData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__103_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<BuffInstance> __9__136_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__136_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<BuffInstance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__136_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<BuffInstance> __9__136_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__136_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<BuffInstance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__136_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__103_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__103_0");
			NativeFieldInfoPtr___9__136_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__136_0");
			NativeFieldInfoPtr___9__136_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__136_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688361);
			NativeMethodInfoPtr__SortById_b__103_0_Internal_Int32_ItemData_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688362);
			NativeMethodInfoPtr__GetBuffListData_b__136_0_Internal_Int32_BuffInstance_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688363);
			NativeMethodInfoPtr__GetBuffListData_b__136_1_Internal_Int32_BuffInstance_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100688364);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SortById_b__103_0(ItemData x, ItemData y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortById_b__103_0_Internal_Int32_ItemData_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980324, XrefRangeEnd = 980330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetBuffListData_b__136_0(BuffInstance x, BuffInstance y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBuffListData_b__136_0_Internal_Int32_BuffInstance_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetBuffListData_b__136_1(BuffInstance x, BuffInstance y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBuffListData_b__136_1_Internal_Int32_BuffInstance_BuffInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.GameUtil+<>c__DisplayClass114_0")]
	public sealed class __c__DisplayClass114_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNearestNoBlockTile_b__0_Internal_Int32_Vector3Int_Vector3Int_0;

		public unsafe Vector3Int pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector3Int;
			}
		}

		static __c__DisplayClass114_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c__DisplayClass114_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr);
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr, "pos");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr, 100688365);
			NativeMethodInfoPtr__GetNearestNoBlockTile_b__0_Internal_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr, 100688366);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass114_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980330, XrefRangeEnd = 980336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetNearestNoBlockTile_b__0(Vector3Int x, Vector3Int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&x);
			*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNearestNoBlockTile_b__0_Internal_Int32_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass114_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.GameUtil+<>c__DisplayClass136_0")]
	public sealed class __c__DisplayClass136_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_buffInstance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBuffListData_b__2_Internal_Boolean_TraitData_0;

		public unsafe BuffInstance buffInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuffInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffInstance));
			}
		}

		static __c__DisplayClass136_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass136_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c__DisplayClass136_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass136_0>.NativeClassPtr);
			NativeFieldInfoPtr_buffInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass136_0>.NativeClassPtr, "buffInstance");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass136_0>.NativeClassPtr, 100688367);
			NativeMethodInfoPtr__GetBuffListData_b__2_Internal_Boolean_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass136_0>.NativeClassPtr, 100688368);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass136_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass136_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980336, XrefRangeEnd = 980339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetBuffListData_b__2(TraitData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBuffListData_b__2_Internal_Boolean_TraitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass136_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WuLin.GameUtil+<>c__DisplayClass140_0")]
	public sealed class __c__DisplayClass140_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DoAConfirmQueue_b__0_Internal_Void_0;

		public unsafe List<string> confirmQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmQueue);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Il2CppSystem.Action action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c__DisplayClass140_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "<>c__DisplayClass140_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr);
			NativeFieldInfoPtr_confirmQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr, "confirmQueue");
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr, "action");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr, 100688369);
			NativeMethodInfoPtr__DoAConfirmQueue_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr, 100688370);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass140_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass140_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980339, XrefRangeEnd = 980343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _DoAConfirmQueue_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DoAConfirmQueue_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass140_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetRandom_Public_Static_T_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRandom_Public_Static_T_List_1_T_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TryGetDictValue_Public_Static_V_Dictionary_2_T_V_T_0<T, V>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryGetDictValue_Public_Static_V_Dictionary_2_T_V_T_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_ClearAndDestroyGameobject_Public_Static_Void_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ClearAndDestroyGameobject_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetOrCreateViewAdapator_Public_Static_T_IViewElemenet_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetOrCreateViewAdapator_Public_Static_T_IViewElemenet_Boolean_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetViewAdapator_Public_Static_T_IViewElemenet_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetViewAdapator_Public_Static_T_IViewElemenet_Boolean_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetChildrenType_Public_Static_T_Transform_List_1_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetChildrenType_Public_Static_T_Transform_List_1_Int32_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetThresholdIndex_Public_Static_Int32_IList_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetThresholdIndex_Public_Static_Int32_IList_1_T_T_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_T_IList_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValueOrDefault_Public_Static_T_IList_1_T_Int32_0, Il2CppClassPointerStore<GameUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_num0to10;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZNnum0to10;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityColorGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityColorBlue;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityColorPurple;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityColorYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityColorRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityColorDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedSprites;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PixelResolution_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RawPixelPerUnit_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RealPixelPerUnit_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pixelize_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ScreenStrenchRatio_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandom_Public_Static_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandom_Public_Static_T_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropValue_Public_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Single_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Decimal_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDictValue_Public_Static_V_Dictionary_2_T_V_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomChoose_Public_Static_Int32_List_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomChooseMulti_Public_Static_List_1_Int32_List_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBasicFourWay_Public_Static_Boolean_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Opposite_Public_Static_TileDirection_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnClockwise_Public_Static_TileDirection_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnCounterclockwise_Public_Static_TileDirection_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vector3IntToDirection_Public_Static_TileDirection_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGrey_Public_Static_Button_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNormal_Public_Static_Button_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectionToVector3Int_Public_Static_Vector3Int_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileDirectionToEStage_Public_Static_EStage_TileDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EStageToTileDirection_Public_Static_TileDirection_EStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipXY_Public_Static_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegX_Public_Static_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegY_Public_Static_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipXY_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegX_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegY_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipXY_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegX_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegY_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOutSkirt_Public_Static_HashSet_1_Vector3Int_ICollection_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileDistanceWith_Public_Static_Int32_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TilePathTo_Public_Static_Int32_Vector3Int_Vector3Int_ITraversalProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortWithPathNear_Public_Static_Void_List_1_Vector3Int_Vector3Int_ITraversalProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortWithPathFar_Public_Static_Void_List_1_Vector3Int_Vector3Int_ITraversalProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearesetPointPathTo_Public_Static_Nullable_1_Vector3Int_List_1_Vector3Int_Vector3Int_ITraversalProvider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOffset_Public_Static_List_1_Vector3Int_List_1_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remap_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsCountDownTime_Public_Static_String_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAndDestroyGameobject_Public_Static_Void_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTMProSpriteAssetRichText_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EStageToVectorInt_Public_Static_Vector3Int_EStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RateAsBool_Public_Static_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RateAsBool_Public_Static_Boolean_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerWithChild_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerWithChild_Public_Static_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateViewAdapator_Public_Static_T_IViewElemenet_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateViewAdapator_Public_Static_ViewElemenetAdapator_IViewElemenet_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewAdapator_Public_Static_T_IViewElemenet_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewAdapator_Public_Static_ViewElemenetAdapator_IViewElemenet_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectViewAdapator_Public_Static_ObjectViewElemenetAdapator_DamagicalBuildingKit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ZN_NUM_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLessTimeLoc_Public_Static_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityColorStruct_Public_Static_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityColor_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetstrringQualityColor_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceWithPlayerName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceWithCharacterName_Public_Static_String_String_GameCharacterInstance_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntStrToChineseStr_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceWithTeamerName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceWithSlgPlayerFactionName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceWithSlgPlayerLeaderName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceWithStoryTagNum_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckFame_Public_Static_Boolean_AreaOwnerData_byref_FactionInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMainProp_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMainPropExp_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPropAbility_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPropAbilityExp_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropAbilityToAbilityExp_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropAbilityExpToAbility_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPosOnSprite_Public_Static_Boolean_SpriteRenderer_Vector3_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemDataRarity_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayHourQuarter_Public_Static_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsForbiddenWord_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_KeyWithValues_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_IEnumerable_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_KeyWithValues_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_IEnumerable_1_KeyWithValues_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collapse_Public_Static_List_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collapse_Public_Static_List_1_KeyWithValues_List_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_Il2CppReferenceArray_1_KeyWithValues_String_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_Il2CppReferenceArray_1_KeyWithValues_Decimal_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDecimals_Public_Static_Int32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortById_Public_Static_Void_List_1_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllItemReciptKey_Public_Static_List_1_String_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecipeStr_Public_Static_String_ItemType_List_1_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecipeStr_Public_Static_String_ItemType_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAvalibleReciptStrs_Public_Static_HashSet_1_String_ItemType_List_1_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowLog_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowLogNew_Public_Static_Void_String_LogItemType_Boolean_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowSlgLog_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowSlgLog_Public_Static_Void_String_String_Action_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringCutting_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestEmptyTileWithoutRole_Public_Static_Vector3Int_Vector3Int_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestNoBlockTile_Public_Static_Vector3Int_Vector3Int_Int32_HashSet_1_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTilesFromPosRecursively_Public_Static_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_HashSet_1_Vector3Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstInteractiveObjectOnTile_Public_Static_InteractiveObject_Vector3Int_BUILDING_TYPE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTMPRichText_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearby_Public_Static_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiamondZone_Public_Static_HashSet_1_Vector3Int_Vector3Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOwnerValidAndWillStopPlayer_Public_Static_Boolean_AreaOwnerData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNode_Public_Static_Vector3Int_List_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BronCubeObj_Public_Static_GameObject_GameObject_Transform_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DmStageIsBattleStage_Public_Static_Boolean_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DmStageIsInternalTriggerStage_Public_Static_Boolean_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DmStageIsRoamingStage_Public_Static_Boolean_DynamicModifierActiveStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToTmpRichTextTag_Public_Static_String_Color_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHtmlString_Public_Static_String_Color_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRoleGhost_Public_Static_Void_Role_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildrenType_Public_Static_T_Transform_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickInvoke_Public_Static_Void_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_TextMeshProUGUI_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_TMP_InputField_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextIsNull_Public_Static_Void_TextMeshProUGUI_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstActiveObjectWithComponent_Public_Static_GameObject_Transform_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffListData_Public_Static_Void_byref_List_1_TraitData_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_Int32_byref_Dictionary_2_String_String_byref_List_1_BuffInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffText_Public_Static_String_String_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveColorTags_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGuanWenStr_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAConfirmQueue_Public_Static_Void_List_1_String_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimpleEvalPrecede_Private_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimpleEvalOperate_Private_Static_Decimal_Decimal_Char_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimpleEval_Public_Static_String_String_Func_2_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_CurrencyType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_FactionGoodsData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteAnimList_Public_Static_List_1_Sprite_String_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThresholdIndex_Public_Static_Int32_IList_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Static_T_IList_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDescString_Public_Static_String_CompareData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStrangerName_Public_Static_String_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocSurName_Public_Static_String_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocGivenName_Public_Static_String_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocFullName_Public_Static_String_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocTitle_Public_Static_String_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocFullNameWithTitle_Public_Static_String_CharacterPoolData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTempleteLocSurName_Public_Static_String_CharacterPoolDataScriptObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTempleteLocGivenName_Public_Static_String_CharacterPoolDataScriptObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTempleteLocFullName_Public_Static_String_CharacterPoolDataScriptObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTempleteFullNameWithTitle_Public_Static_String_CharacterPoolDataScriptObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_FactionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_Static_String_FactionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_ItemData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_Static_String_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_ItemForgeEffectData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMove_Public_Static_List_1_KungfuMoveData_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKungfuInfo_Public_Static_String_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalKungfuEffect_Public_Static_String_KungfuData_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasName_Public_Static_Boolean_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_Static_String_BuffData_Il2CppStructArray_1_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectInfo_Public_Static_String_BuffData_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsElixirBuff_Public_Static_Boolean_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSlgTrait_Public_Static_Boolean_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSlgTraitInborn_Public_Static_Boolean_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlgTraitCost_Public_Static_Int32_BuffData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAvalible_Public_Static_Boolean_SelfPropBufflData_GameCharacterInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnitName_Public_Static_String_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNameWithCount_Public_Static_String_ItemData_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRelationImproveItemInSlgMode_Public_Static_Boolean_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationImproveInSlgMode_Public_Static_Int32_ItemData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_TraitData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_KungfuData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_DLCTrader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_Static_String_TraitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntroductionLocText_Public_Static_String_NewsConfigScriptObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTempModifier_Public_Static_Void_TMP_InputField_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirstSelectable_Public_Static_Selectable_GameObject_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNeg_Public_Static_KeyWithValues_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNeg_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMultiply_Public_Static_KeyWithValues_KeyWithValues_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMultiply_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTipScreenPos_Public_Static_Void_RectTransform_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLockIcon_Public_Static_Sprite_ComponentShowCommonTip_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_ComponentShowCommonTip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCTech_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_DLCTech_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_Static_String_DLCTech_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_DLCFaction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginName_Public_Static_String_DLCFaction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfo_Public_Static_String_DLCFaction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCFaction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_DLCProvince_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCProvince_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLocTextForAllLanguage_Public_Static_Void_LocData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SafeClone_Public_Static_LocData_LocData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixLocData_Public_Static_Void_LocData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixLocDataOneLanguage_Private_Static_Void_byref_String_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceTextSpriteCurrency_Public_Static_String_String_0;

	public unsafe static Il2CppStructArray<int> num0to10
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_num0to10, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_num0to10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray ZNnum0to10
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ZNnum0to10, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ZNnum0to10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Color QualityColorGreen
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityColorGreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityColorGreen, (void*)(&color));
		}
	}

	public unsafe static Color QualityColorBlue
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityColorBlue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityColorBlue, (void*)(&color));
		}
	}

	public unsafe static Color QualityColorPurple
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityColorPurple, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityColorPurple, (void*)(&color));
		}
	}

	public unsafe static Color QualityColorYellow
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityColorYellow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityColorYellow, (void*)(&color));
		}
	}

	public unsafe static Color QualityColorRed
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityColorRed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityColorRed, (void*)(&color));
		}
	}

	public unsafe static Color QualityColorDefault
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityColorDefault, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityColorDefault, (void*)(&color));
		}
	}

	public unsafe static Dictionary<string, Dictionary<string, Sprite>> cachedSprites
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedSprites, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, Sprite>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedSprites, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static int PixelResolution
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PixelResolution_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static int RawPixelPerUnit
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312719, RefRangeEnd = 312721, XrefRangeStart = 312719, XrefRangeEnd = 312721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RawPixelPerUnit_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static int RealPixelPerUnit
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 980347, RefRangeEnd = 980349, XrefRangeStart = 980343, XrefRangeEnd = 980347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RealPixelPerUnit_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static float ScreenStrenchRatio
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980372, RefRangeEnd = 980373, XrefRangeStart = 980364, XrefRangeEnd = 980372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScreenStrenchRatio_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static GameUtil()
	{
		Il2CppClassPointerStore<GameUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameUtil>.NativeClassPtr);
		NativeFieldInfoPtr_num0to10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "num0to10");
		NativeFieldInfoPtr_ZNnum0to10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "ZNnum0to10");
		NativeFieldInfoPtr_QualityColorGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "QualityColorGreen");
		NativeFieldInfoPtr_QualityColorBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "QualityColorBlue");
		NativeFieldInfoPtr_QualityColorPurple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "QualityColorPurple");
		NativeFieldInfoPtr_QualityColorYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "QualityColorYellow");
		NativeFieldInfoPtr_QualityColorRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "QualityColorRed");
		NativeFieldInfoPtr_QualityColorDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "QualityColorDefault");
		NativeFieldInfoPtr_cachedSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, "cachedSprites");
		NativeMethodInfoPtr_get_PixelResolution_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678611);
		NativeMethodInfoPtr_get_RawPixelPerUnit_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678612);
		NativeMethodInfoPtr_get_RealPixelPerUnit_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678613);
		NativeMethodInfoPtr_Pixelize_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678614);
		NativeMethodInfoPtr_get_ScreenStrenchRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678615);
		NativeMethodInfoPtr_GetRandom_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678616);
		NativeMethodInfoPtr_GetRandom_Public_Static_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678617);
		NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678618);
		NativeMethodInfoPtr_GetPropValue_Public_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678619);
		NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678620);
		NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678621);
		NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678622);
		NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Decimal_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678623);
		NativeMethodInfoPtr_TryGetDictValue_Public_Static_V_Dictionary_2_T_V_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678624);
		NativeMethodInfoPtr_RandomChoose_Public_Static_Int32_List_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678625);
		NativeMethodInfoPtr_RandomChooseMulti_Public_Static_List_1_Int32_List_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678626);
		NativeMethodInfoPtr_IsBasicFourWay_Public_Static_Boolean_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678627);
		NativeMethodInfoPtr_Opposite_Public_Static_TileDirection_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678628);
		NativeMethodInfoPtr_TurnClockwise_Public_Static_TileDirection_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678629);
		NativeMethodInfoPtr_TurnCounterclockwise_Public_Static_TileDirection_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678630);
		NativeMethodInfoPtr_Vector3IntToDirection_Public_Static_TileDirection_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678631);
		NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678632);
		NativeMethodInfoPtr_SetGrey_Public_Static_Button_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678633);
		NativeMethodInfoPtr_SetNormal_Public_Static_Button_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678634);
		NativeMethodInfoPtr_DirectionToVector3Int_Public_Static_Vector3Int_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678635);
		NativeMethodInfoPtr_TileDirectionToEStage_Public_Static_EStage_TileDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678636);
		NativeMethodInfoPtr_EStageToTileDirection_Public_Static_TileDirection_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678637);
		NativeMethodInfoPtr_FlipXY_Public_Static_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678638);
		NativeMethodInfoPtr_NegX_Public_Static_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678639);
		NativeMethodInfoPtr_NegY_Public_Static_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678640);
		NativeMethodInfoPtr_FlipXY_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678641);
		NativeMethodInfoPtr_NegX_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678642);
		NativeMethodInfoPtr_NegY_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678643);
		NativeMethodInfoPtr_FlipXY_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678644);
		NativeMethodInfoPtr_NegX_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678645);
		NativeMethodInfoPtr_NegY_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678646);
		NativeMethodInfoPtr_GetOutSkirt_Public_Static_HashSet_1_Vector3Int_ICollection_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678647);
		NativeMethodInfoPtr_TileDistanceWith_Public_Static_Int32_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678648);
		NativeMethodInfoPtr_TilePathTo_Public_Static_Int32_Vector3Int_Vector3Int_ITraversalProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678649);
		NativeMethodInfoPtr_SortWithPathNear_Public_Static_Void_List_1_Vector3Int_Vector3Int_ITraversalProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678650);
		NativeMethodInfoPtr_SortWithPathFar_Public_Static_Void_List_1_Vector3Int_Vector3Int_ITraversalProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678651);
		NativeMethodInfoPtr_GetNearesetPointPathTo_Public_Static_Nullable_1_Vector3Int_List_1_Vector3Int_Vector3Int_ITraversalProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678652);
		NativeMethodInfoPtr_AddOffset_Public_Static_List_1_Vector3Int_List_1_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678653);
		NativeMethodInfoPtr_Remap_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678654);
		NativeMethodInfoPtr_AsCountDownTime_Public_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678655);
		NativeMethodInfoPtr_ClearAndDestroyGameobject_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678656);
		NativeMethodInfoPtr_GetTMProSpriteAssetRichText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678657);
		NativeMethodInfoPtr_EStageToVectorInt_Public_Static_Vector3Int_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678658);
		NativeMethodInfoPtr_RateAsBool_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678659);
		NativeMethodInfoPtr_RateAsBool_Public_Static_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678660);
		NativeMethodInfoPtr_SetLayerWithChild_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678661);
		NativeMethodInfoPtr_SetLayerWithChild_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678662);
		NativeMethodInfoPtr_GetOrCreateViewAdapator_Public_Static_T_IViewElemenet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678663);
		NativeMethodInfoPtr_GetOrCreateViewAdapator_Public_Static_ViewElemenetAdapator_IViewElemenet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678664);
		NativeMethodInfoPtr_GetViewAdapator_Public_Static_T_IViewElemenet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678665);
		NativeMethodInfoPtr_GetViewAdapator_Public_Static_ViewElemenetAdapator_IViewElemenet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678666);
		NativeMethodInfoPtr_GetObjectViewAdapator_Public_Static_ObjectViewElemenetAdapator_DamagicalBuildingKit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678667);
		NativeMethodInfoPtr_ZN_NUM_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678668);
		NativeMethodInfoPtr_GetLessTimeLoc_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678669);
		NativeMethodInfoPtr_GetQualityColorStruct_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678670);
		NativeMethodInfoPtr_GetQualityColor_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678671);
		NativeMethodInfoPtr_GetstrringQualityColor_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678672);
		NativeMethodInfoPtr_ReplaceWithPlayerName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678673);
		NativeMethodInfoPtr_ReplaceWithCharacterName_Public_Static_String_String_GameCharacterInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678674);
		NativeMethodInfoPtr_IntStrToChineseStr_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678675);
		NativeMethodInfoPtr_ReplaceWithTeamerName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678676);
		NativeMethodInfoPtr_ReplaceWithSlgPlayerFactionName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678677);
		NativeMethodInfoPtr_ReplaceWithSlgPlayerLeaderName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678678);
		NativeMethodInfoPtr_ReplaceWithStoryTagNum_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678679);
		NativeMethodInfoPtr_CheckFame_Public_Static_Boolean_AreaOwnerData_byref_FactionInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678680);
		NativeMethodInfoPtr_IsMainProp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678681);
		NativeMethodInfoPtr_IsMainPropExp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678682);
		NativeMethodInfoPtr_IsPropAbility_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678683);
		NativeMethodInfoPtr_IsPropAbilityExp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678684);
		NativeMethodInfoPtr_PropAbilityToAbilityExp_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678685);
		NativeMethodInfoPtr_PropAbilityExpToAbility_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678686);
		NativeMethodInfoPtr_GetPropName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678687);
		NativeMethodInfoPtr_IsPosOnSprite_Public_Static_Boolean_SpriteRenderer_Vector3_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678688);
		NativeMethodInfoPtr_GetItemDataRarity_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678689);
		NativeMethodInfoPtr_GetDayHourQuarter_Public_Static_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678690);
		NativeMethodInfoPtr_ContainsForbiddenWord_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678691);
		NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_KeyWithValues_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678692);
		NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_IEnumerable_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678693);
		NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_KeyWithValues_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678694);
		NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_IEnumerable_1_KeyWithValues_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678695);
		NativeMethodInfoPtr_Copy_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678696);
		NativeMethodInfoPtr_Collapse_Public_Static_List_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678697);
		NativeMethodInfoPtr_Collapse_Public_Static_List_1_KeyWithValues_List_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678698);
		NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_Il2CppReferenceArray_1_KeyWithValues_String_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678699);
		NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_Il2CppReferenceArray_1_KeyWithValues_Decimal_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678700);
		NativeMethodInfoPtr_GetDecimals_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678701);
		NativeMethodInfoPtr_SortById_Public_Static_Void_List_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678702);
		NativeMethodInfoPtr_GetAllItemReciptKey_Public_Static_List_1_String_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678703);
		NativeMethodInfoPtr_GetRecipeStr_Public_Static_String_ItemType_List_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678704);
		NativeMethodInfoPtr_GetRecipeStr_Public_Static_String_ItemType_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678705);
		NativeMethodInfoPtr_GetAllAvalibleReciptStrs_Public_Static_HashSet_1_String_ItemType_List_1_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678706);
		NativeMethodInfoPtr_ShowLog_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678707);
		NativeMethodInfoPtr_ShowLogNew_Public_Static_Void_String_LogItemType_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678708);
		NativeMethodInfoPtr_ShowSlgLog_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678709);
		NativeMethodInfoPtr_ShowSlgLog_Public_Static_Void_String_String_Action_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678710);
		NativeMethodInfoPtr_StringCutting_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678711);
		NativeMethodInfoPtr_GetNearestEmptyTileWithoutRole_Public_Static_Vector3Int_Vector3Int_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678712);
		NativeMethodInfoPtr_GetNearestNoBlockTile_Public_Static_Vector3Int_Vector3Int_Int32_HashSet_1_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678713);
		NativeMethodInfoPtr_GetTilesFromPosRecursively_Public_Static_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_HashSet_1_Vector3Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678714);
		NativeMethodInfoPtr_GetFirstInteractiveObjectOnTile_Public_Static_InteractiveObject_Vector3Int_BUILDING_TYPE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678715);
		NativeMethodInfoPtr_RemoveTMPRichText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678716);
		NativeMethodInfoPtr_GetNearby_Public_Static_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678717);
		NativeMethodInfoPtr_GetDiamondZone_Public_Static_HashSet_1_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678718);
		NativeMethodInfoPtr_IsOwnerValidAndWillStopPlayer_Public_Static_Boolean_AreaOwnerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678719);
		NativeMethodInfoPtr_GetNode_Public_Static_Vector3Int_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678720);
		NativeMethodInfoPtr_BronCubeObj_Public_Static_GameObject_GameObject_Transform_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678721);
		NativeMethodInfoPtr_DmStageIsBattleStage_Public_Static_Boolean_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678722);
		NativeMethodInfoPtr_DmStageIsInternalTriggerStage_Public_Static_Boolean_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678723);
		NativeMethodInfoPtr_DmStageIsRoamingStage_Public_Static_Boolean_DynamicModifierActiveStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678724);
		NativeMethodInfoPtr_ToTmpRichTextTag_Public_Static_String_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678725);
		NativeMethodInfoPtr_ToHtmlString_Public_Static_String_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678726);
		NativeMethodInfoPtr_CreateRoleGhost_Public_Static_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678727);
		NativeMethodInfoPtr_GetChildrenType_Public_Static_T_Transform_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678728);
		NativeMethodInfoPtr_OnClickInvoke_Public_Static_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678729);
		NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678730);
		NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_TextMeshProUGUI_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678731);
		NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_TMP_InputField_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678732);
		NativeMethodInfoPtr_SetTextIsNull_Public_Static_Void_TextMeshProUGUI_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678733);
		NativeMethodInfoPtr_FindFirstActiveObjectWithComponent_Public_Static_GameObject_Transform_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678734);
		NativeMethodInfoPtr_GetBuffListData_Public_Static_Void_byref_List_1_TraitData_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_Int32_byref_Dictionary_2_String_String_byref_List_1_BuffInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678735);
		NativeMethodInfoPtr_GetBuffText_Public_Static_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678736);
		NativeMethodInfoPtr_RemoveColorTags_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678737);
		NativeMethodInfoPtr_GetGuanWenStr_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678738);
		NativeMethodInfoPtr_DoAConfirmQueue_Public_Static_Void_List_1_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678739);
		NativeMethodInfoPtr_SimpleEvalPrecede_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678740);
		NativeMethodInfoPtr_SimpleEvalOperate_Private_Static_Decimal_Decimal_Char_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678741);
		NativeMethodInfoPtr_SimpleEval_Public_Static_String_String_Func_2_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678742);
		NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_CurrencyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678743);
		NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_FactionGoodsData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678744);
		NativeMethodInfoPtr_GetSpriteAnimList_Public_Static_List_1_Sprite_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678745);
		NativeMethodInfoPtr_GetThresholdIndex_Public_Static_Int32_IList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678746);
		NativeMethodInfoPtr_GetValueOrDefault_Public_Static_T_IList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678747);
		NativeMethodInfoPtr_ToDescString_Public_Static_String_CompareData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678748);
		NativeMethodInfoPtr_GetStrangerName_Public_Static_String_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678749);
		NativeMethodInfoPtr_GetLocSurName_Public_Static_String_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678750);
		NativeMethodInfoPtr_GetLocGivenName_Public_Static_String_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678751);
		NativeMethodInfoPtr_GetLocFullName_Public_Static_String_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678752);
		NativeMethodInfoPtr_GetLocTitle_Public_Static_String_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678753);
		NativeMethodInfoPtr_GetLocFullNameWithTitle_Public_Static_String_CharacterPoolData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678754);
		NativeMethodInfoPtr_GetTempleteLocSurName_Public_Static_String_CharacterPoolDataScriptObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678755);
		NativeMethodInfoPtr_GetTempleteLocGivenName_Public_Static_String_CharacterPoolDataScriptObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678756);
		NativeMethodInfoPtr_GetTempleteLocFullName_Public_Static_String_CharacterPoolDataScriptObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678757);
		NativeMethodInfoPtr_GetTempleteFullNameWithTitle_Public_Static_String_CharacterPoolDataScriptObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678758);
		NativeMethodInfoPtr_GetName_Public_Static_String_FactionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678759);
		NativeMethodInfoPtr_GetInfo_Public_Static_String_FactionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678760);
		NativeMethodInfoPtr_GetName_Public_Static_String_ItemData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678761);
		NativeMethodInfoPtr_GetInfo_Public_Static_String_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678762);
		NativeMethodInfoPtr_GetName_Public_Static_String_ItemForgeEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678763);
		NativeMethodInfoPtr_GetAllMove_Public_Static_List_1_KungfuMoveData_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678764);
		NativeMethodInfoPtr_GetKungfuInfo_Public_Static_String_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678765);
		NativeMethodInfoPtr_GetInternalKungfuEffect_Public_Static_String_KungfuData_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678766);
		NativeMethodInfoPtr_GetName_Public_Static_String_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678767);
		NativeMethodInfoPtr_HasName_Public_Static_Boolean_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678768);
		NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678769);
		NativeMethodInfoPtr_GetInfo_Public_Static_String_BuffData_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678770);
		NativeMethodInfoPtr_GetEffectInfo_Public_Static_String_BuffData_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678771);
		NativeMethodInfoPtr_IsElixirBuff_Public_Static_Boolean_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678772);
		NativeMethodInfoPtr_IsSlgTrait_Public_Static_Boolean_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678773);
		NativeMethodInfoPtr_IsSlgTraitInborn_Public_Static_Boolean_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678774);
		NativeMethodInfoPtr_GetSlgTraitCost_Public_Static_Int32_BuffData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678775);
		NativeMethodInfoPtr_CheckAvalible_Public_Static_Boolean_SelfPropBufflData_GameCharacterInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678776);
		NativeMethodInfoPtr_GetUnitName_Public_Static_String_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678777);
		NativeMethodInfoPtr_GetNameWithCount_Public_Static_String_ItemData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678778);
		NativeMethodInfoPtr_IsRelationImproveItemInSlgMode_Public_Static_Boolean_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678779);
		NativeMethodInfoPtr_GetRelationImproveInSlgMode_Public_Static_Int32_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678780);
		NativeMethodInfoPtr_GetName_Public_Static_String_TraitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678781);
		NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_KungfuData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678782);
		NativeMethodInfoPtr_GetName_Public_Static_String_DLCTrader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678783);
		NativeMethodInfoPtr_GetInfo_Public_Static_String_TraitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678784);
		NativeMethodInfoPtr_GetIntroductionLocText_Public_Static_String_NewsConfigScriptObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678785);
		NativeMethodInfoPtr_AddTempModifier_Public_Static_Void_TMP_InputField_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678786);
		NativeMethodInfoPtr_SelectFirstSelectable_Public_Static_Selectable_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678787);
		NativeMethodInfoPtr_GetNeg_Public_Static_KeyWithValues_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678788);
		NativeMethodInfoPtr_GetNeg_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678789);
		NativeMethodInfoPtr_GetMultiply_Public_Static_KeyWithValues_KeyWithValues_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678790);
		NativeMethodInfoPtr_GetMultiply_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678791);
		NativeMethodInfoPtr_GetTipScreenPos_Public_Static_Void_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678792);
		NativeMethodInfoPtr_GetLockIcon_Public_Static_Sprite_ComponentShowCommonTip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678793);
		NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_ComponentShowCommonTip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678794);
		NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCTech_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678795);
		NativeMethodInfoPtr_GetName_Public_Static_String_DLCTech_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678796);
		NativeMethodInfoPtr_GetInfo_Public_Static_String_DLCTech_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678797);
		NativeMethodInfoPtr_GetName_Public_Static_String_DLCFaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678798);
		NativeMethodInfoPtr_GetOriginName_Public_Static_String_DLCFaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678799);
		NativeMethodInfoPtr_GetInfo_Public_Static_String_DLCFaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678800);
		NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCFaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678801);
		NativeMethodInfoPtr_GetName_Public_Static_String_DLCProvince_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678802);
		NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCProvince_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678803);
		NativeMethodInfoPtr_ApplyLocTextForAllLanguage_Public_Static_Void_LocData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678804);
		NativeMethodInfoPtr_SafeClone_Public_Static_LocData_LocData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678805);
		NativeMethodInfoPtr_FixLocData_Public_Static_Void_LocData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678806);
		NativeMethodInfoPtr_FixLocDataOneLanguage_Private_Static_Void_byref_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678807);
		NativeMethodInfoPtr_ReplaceTextSpriteCurrency_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtil>.NativeClassPtr, 100678808);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 980362, RefRangeEnd = 980364, XrefRangeStart = 980349, XrefRangeEnd = 980362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Pixelize(this Vector3 vec3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vec3);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pixelize_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 980375, RefRangeEnd = 980389, XrefRangeStart = 980373, XrefRangeEnd = 980375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRandom(this Il2CppStringArray from)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandom_Public_Static_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 980390, RefRangeEnd = 980393, XrefRangeStart = 980389, XrefRangeEnd = 980390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetRandom<T>(this List<T> from)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRandom_Public_Static_T_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 980394, RefRangeEnd = 980403, XrefRangeStart = 980393, XrefRangeEnd = 980394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Contains<T>(this Il2CppArrayBase<T> values, T value)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Contains_Public_Static_Boolean_Il2CppArrayBase_1_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 980404, RefRangeEnd = 980423, XrefRangeStart = 980403, XrefRangeEnd = 980404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPropValue(this Il2CppStructArray<int> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropValue_Public_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 980435, RefRangeEnd = 980445, XrefRangeStart = 980423, XrefRangeEnd = 980435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddVaule(this Dictionary<string, int> dict, string key, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980445, XrefRangeEnd = 980457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddVaule(this Dictionary<string, float> dict, string key, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Single_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 980469, RefRangeEnd = 980471, XrefRangeStart = 980457, XrefRangeEnd = 980469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddVaule(this Dictionary<int, int> dict, int key, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 980484, RefRangeEnd = 980499, XrefRangeStart = 980471, XrefRangeEnd = 980484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddVaule(this Dictionary<string, Il2CppSystem.Decimal> dict, string key, Il2CppSystem.Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVaule_Public_Static_Void_Dictionary_2_String_Decimal_String_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(196)]
	[CachedScanResults(RefRangeStart = 696579, RefRangeEnd = 696775, XrefRangeStart = 696579, XrefRangeEnd = 696775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static V TryGetDictValue<T, V>(this Dictionary<T, V> dict, T key)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = key;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref key;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryGetDictValue_Public_Static_V_Dictionary_2_T_V_T_0<T, V>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 980528, RefRangeEnd = 980534, XrefRangeStart = 980499, XrefRangeEnd = 980528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RandomChoose(this List<float> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomChoose_Public_Static_Int32_List_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 980556, RefRangeEnd = 980558, XrefRangeStart = 980534, XrefRangeEnd = 980556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> RandomChooseMulti(this List<float> list, int Count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &Count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomChooseMulti_Public_Static_List_1_Int32_List_1_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 980558, RefRangeEnd = 980562, XrefRangeStart = 980558, XrefRangeEnd = 980558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBasicFourWay(this TileDirection tileDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBasicFourWay_Public_Static_Boolean_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 980562, RefRangeEnd = 980566, XrefRangeStart = 980562, XrefRangeEnd = 980562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TileDirection Opposite(this TileDirection tileDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Opposite_Public_Static_TileDirection_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 980566, RefRangeEnd = 980570, XrefRangeStart = 980566, XrefRangeEnd = 980566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TileDirection TurnClockwise(this TileDirection tileDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnClockwise_Public_Static_TileDirection_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static TileDirection TurnCounterclockwise(this TileDirection tileDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnCounterclockwise_Public_Static_TileDirection_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 980586, RefRangeEnd = 980608, XrefRangeStart = 980570, XrefRangeEnd = 980586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TileDirection Vector3IntToDirection(this Vector3Int vector3Int, bool eightDir = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vector3Int);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eightDir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vector3IntToDirection_Public_Static_TileDirection_Vector3Int_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 980611, RefRangeEnd = 980613, XrefRangeStart = 980608, XrefRangeEnd = 980611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 ToVector3(this Vector3Int vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 980628, RefRangeEnd = 980645, XrefRangeStart = 980613, XrefRangeEnd = 980628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Button SetGrey(this Button UIBtn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)UIBtn);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGrey_Public_Static_Button_Button_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 980654, RefRangeEnd = 980662, XrefRangeStart = 980645, XrefRangeEnd = 980654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Button SetNormal(this Button UIBtn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)UIBtn);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNormal_Public_Static_Button_Button_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 980693, RefRangeEnd = 980712, XrefRangeStart = 980662, XrefRangeEnd = 980693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int DirectionToVector3Int(this TileDirection tileDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectionToVector3Int_Public_Static_Vector3Int_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 980712, RefRangeEnd = 980719, XrefRangeStart = 980712, XrefRangeEnd = 980712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RoleAniManager.EStage TileDirectionToEStage(this TileDirection tileDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileDirectionToEStage_Public_Static_EStage_TileDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(RoleAniManager.EStage*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(100)]
	[CachedScanResults(RefRangeStart = 292569, RefRangeEnd = 292669, XrefRangeStart = 292569, XrefRangeEnd = 292669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TileDirection EStageToTileDirection(this RoleAniManager.EStage eStage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eStage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EStageToTileDirection_Public_Static_TileDirection_EStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TileDirection*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980719, XrefRangeEnd = 980723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int FlipXY(this Vector3Int vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipXY_Public_Static_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980723, XrefRangeEnd = 980725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int NegX(this Vector3Int vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegX_Public_Static_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980725, XrefRangeEnd = 980727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int NegY(this Vector3Int vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegY_Public_Static_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector3 FlipXY(this Vector3 vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipXY_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector3 NegX(this Vector3 vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegX_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector3 NegY(this Vector3 vector3Int)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3Int);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegY_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 980741, RefRangeEnd = 980743, XrefRangeStart = 980727, XrefRangeEnd = 980741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3Int> FlipXY(this List<Vector3Int> vector3Ints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vector3Ints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipXY_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 980755, RefRangeEnd = 980756, XrefRangeStart = 980743, XrefRangeEnd = 980755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3Int> NegX(this List<Vector3Int> vector3Ints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vector3Ints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegX_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 980768, RefRangeEnd = 980769, XrefRangeStart = 980756, XrefRangeEnd = 980768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3Int> NegY(this List<Vector3Int> vector3Ints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vector3Ints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegY_Public_Static_List_1_Vector3Int_List_1_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 980865, RefRangeEnd = 980866, XrefRangeStart = 980769, XrefRangeEnd = 980865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<Vector3Int> GetOutSkirt(this ICollection<Vector3Int> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutSkirt_Public_Static_HashSet_1_Vector3Int_ICollection_1_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 980877, RefRangeEnd = 980924, XrefRangeStart = 980866, XrefRangeEnd = 980877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TileDistanceWith(this Vector3Int a, Vector3Int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileDistanceWith_Public_Static_Int32_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 980932, RefRangeEnd = 980937, XrefRangeStart = 980924, XrefRangeEnd = 980932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TilePathTo(this Vector3Int a, Vector3Int b, ITraversalProvider traversalProvider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traversalProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TilePathTo_Public_Static_Int32_Vector3Int_Vector3Int_ITraversalProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980937, XrefRangeEnd = 981019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortWithPathNear(this List<Vector3Int> poses, Vector3Int target, ITraversalProvider traversalProvider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poses);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traversalProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortWithPathNear_Public_Static_Void_List_1_Vector3Int_Vector3Int_ITraversalProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981101, RefRangeEnd = 981102, XrefRangeStart = 981019, XrefRangeEnd = 981101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortWithPathFar(this List<Vector3Int> poses, Vector3Int target, ITraversalProvider traversalProvider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poses);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traversalProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortWithPathFar_Public_Static_Void_List_1_Vector3Int_Vector3Int_ITraversalProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 981159, RefRangeEnd = 981163, XrefRangeStart = 981102, XrefRangeEnd = 981159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<Vector3Int> GetNearesetPointPathTo(this List<Vector3Int> poses, Vector3Int target, ITraversalProvider traversalProvider = null, bool fallBack = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poses);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traversalProvider);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallBack;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearesetPointPathTo_Public_Static_Nullable_1_Vector3Int_List_1_Vector3Int_Vector3Int_ITraversalProvider_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<Vector3Int>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 981176, RefRangeEnd = 981179, XrefRangeStart = 981163, XrefRangeEnd = 981176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3Int> AddOffset(this List<Vector3Int> vector3Ints, Vector3Int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vector3Ints);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOffset_Public_Static_List_1_Vector3Int_List_1_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981179, RefRangeEnd = 981180, XrefRangeStart = 981179, XrefRangeEnd = 981179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Remap(this float value, float from1, float to1, float from2, float to2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &from2;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &to2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remap_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981180, XrefRangeEnd = 981204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AsCountDownTime(this double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsCountDownTime_Public_Static_String_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981204, XrefRangeEnd = 981219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearAndDestroyGameobject<T>(this List<T> list) where T : MonoBehaviour
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ClearAndDestroyGameobject_Public_Static_Void_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981219, XrefRangeEnd = 981222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTMProSpriteAssetRichText(string spriteName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(spriteName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTMProSpriteAssetRichText_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 981231, RefRangeEnd = 981233, XrefRangeStart = 981222, XrefRangeEnd = 981231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int EStageToVectorInt(this RoleAniManager.EStage eStage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eStage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EStageToVectorInt_Public_Static_Vector3Int_EStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 981234, RefRangeEnd = 981251, XrefRangeStart = 981233, XrefRangeEnd = 981234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RateAsBool(this float foo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&foo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RateAsBool_Public_Static_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 981259, RefRangeEnd = 981261, XrefRangeStart = 981251, XrefRangeEnd = 981259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RateAsBool(this Il2CppSystem.Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RateAsBool_Public_Static_Boolean_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981261, XrefRangeEnd = 981267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerWithChild(this GameObject go, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerWithChild_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981267, XrefRangeEnd = 981277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerWithChild(this GameObject go, string layerName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layerName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerWithChild_Public_Static_Void_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 981284, RefRangeEnd = 981349, XrefRangeStart = 981277, XrefRangeEnd = 981284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetOrCreateViewAdapator<T>(this IViewElemenet viewElemenet, bool isShow = true) where T : ViewElemenetAdapator
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewElemenet);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetOrCreateViewAdapator_Public_Static_T_IViewElemenet_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(109)]
	[CachedScanResults(RefRangeStart = 981376, RefRangeEnd = 981485, XrefRangeStart = 981349, XrefRangeEnd = 981376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ViewElemenetAdapator GetOrCreateViewAdapator(this IViewElemenet viewElemenet, bool isShow = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewElemenet);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateViewAdapator_Public_Static_ViewElemenetAdapator_IViewElemenet_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ViewElemenetAdapator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981492, RefRangeEnd = 981493, XrefRangeStart = 981485, XrefRangeEnd = 981492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetViewAdapator<T>(this IViewElemenet viewElemenet, bool isShow = true) where T : ViewElemenetAdapator
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewElemenet);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetViewAdapator_Public_Static_T_IViewElemenet_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981506, RefRangeEnd = 981507, XrefRangeStart = 981493, XrefRangeEnd = 981506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ViewElemenetAdapator GetViewAdapator(this IViewElemenet viewElemenet, bool isShow = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewElemenet);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViewAdapator_Public_Static_ViewElemenetAdapator_IViewElemenet_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ViewElemenetAdapator>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 981518, RefRangeEnd = 981521, XrefRangeStart = 981507, XrefRangeEnd = 981518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ObjectViewElemenetAdapator GetObjectViewAdapator(this DamagicalBuildingKit damagicalBuildingKit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damagicalBuildingKit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectViewAdapator_Public_Static_ObjectViewElemenetAdapator_DamagicalBuildingKit_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectViewElemenetAdapator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981526, RefRangeEnd = 981527, XrefRangeStart = 981521, XrefRangeEnd = 981526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ZN_NUM(int num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZN_NUM_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 981565, RefRangeEnd = 981581, XrefRangeStart = 981527, XrefRangeEnd = 981565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLessTimeLoc(int Quarter, bool minUnitIsDay = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&Quarter);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minUnitIsDay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLessTimeLoc_Public_Static_String_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 981585, RefRangeEnd = 981587, XrefRangeStart = 981581, XrefRangeEnd = 981585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetQualityColorStruct(int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualityColorStruct_Public_Static_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 981595, RefRangeEnd = 981612, XrefRangeStart = 981587, XrefRangeEnd = 981595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetQualityColor(int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualityColor_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 981621, RefRangeEnd = 981636, XrefRangeStart = 981612, XrefRangeEnd = 981621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetstrringQualityColor(int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetstrringQualityColor_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(41)]
	[CachedScanResults(RefRangeStart = 981655, RefRangeEnd = 981696, XrefRangeStart = 981636, XrefRangeEnd = 981655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceWithPlayerName(this string rawStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceWithPlayerName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 981719, RefRangeEnd = 981721, XrefRangeStart = 981696, XrefRangeEnd = 981719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceWithCharacterName(this string rawStr, GameCharacterInstance gameCharacterInstance, int index = 1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawStr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceWithCharacterName_Public_Static_String_String_GameCharacterInstance_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 981752, RefRangeEnd = 981760, XrefRangeStart = 981721, XrefRangeEnd = 981752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IntStrToChineseStr(this string x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntStrToChineseStr_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 981796, RefRangeEnd = 981803, XrefRangeStart = 981760, XrefRangeEnd = 981796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceWithTeamerName(this string rawStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceWithTeamerName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 981815, RefRangeEnd = 981817, XrefRangeStart = 981803, XrefRangeEnd = 981815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceWithSlgPlayerFactionName(this string rawStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceWithSlgPlayerFactionName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 981860, RefRangeEnd = 981863, XrefRangeStart = 981817, XrefRangeEnd = 981860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceWithSlgPlayerLeaderName(this string rawStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceWithSlgPlayerLeaderName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 981887, RefRangeEnd = 981899, XrefRangeStart = 981863, XrefRangeEnd = 981887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceWithStoryTagNum(this string rawStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceWithStoryTagNum_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 981911, RefRangeEnd = 981915, XrefRangeStart = 981899, XrefRangeEnd = 981911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckFame(this AreaOwnerCell.AreaOwnerData areaState, ref FactionInstance factionInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaState);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckFame_Public_Static_Boolean_AreaOwnerData_byref_FactionInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		factionInstance = ((intPtr4 == (System.IntPtr)0) ? null : new FactionInstance(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981930, RefRangeEnd = 981931, XrefRangeStart = 981915, XrefRangeEnd = 981930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMainProp(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMainProp_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 981946, RefRangeEnd = 981947, XrefRangeStart = 981931, XrefRangeEnd = 981946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMainPropExp(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMainPropExp_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 981951, RefRangeEnd = 981956, XrefRangeStart = 981947, XrefRangeEnd = 981951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPropAbility(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPropAbility_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 981960, RefRangeEnd = 981963, XrefRangeStart = 981956, XrefRangeEnd = 981960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPropAbilityExp(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPropAbilityExp_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 981969, RefRangeEnd = 981976, XrefRangeStart = 981963, XrefRangeEnd = 981969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PropAbilityToAbilityExp(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropAbilityToAbilityExp_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 981982, RefRangeEnd = 981985, XrefRangeStart = 981976, XrefRangeEnd = 981982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PropAbilityExpToAbility(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropAbilityExpToAbility_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 981996, RefRangeEnd = 982017, XrefRangeStart = 981985, XrefRangeEnd = 981996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPropName(this string propStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 982038, RefRangeEnd = 982041, XrefRangeStart = 982017, XrefRangeEnd = 982038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPosOnSprite(SpriteRenderer spriteRenderer, Vector3 mousePos, out Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mousePos;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPosOnSprite_Public_Static_Boolean_SpriteRenderer_Vector3_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 982054, RefRangeEnd = 982068, XrefRangeStart = 982041, XrefRangeEnd = 982054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetItemDataRarity(int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemDataRarity_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982071, RefRangeEnd = 982072, XrefRangeStart = 982068, XrefRangeEnd = 982071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetDayHourQuarter(int Quarter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Quarter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayHourQuarter_Public_Static_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 982116, RefRangeEnd = 982122, XrefRangeStart = 982072, XrefRangeEnd = 982116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsForbiddenWord(this string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsForbiddenWord_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 982236, RefRangeEnd = 982252, XrefRangeStart = 982122, XrefRangeEnd = 982236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToEffectInfo(this KeyWithValues keyWithValues, [Optional] Il2CppSystem.Decimal overrideValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &overrideValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_KeyWithValues_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 982323, RefRangeEnd = 982325, XrefRangeStart = 982252, XrefRangeEnd = 982323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToEffectInfo(IEnumerable<KeyWithValues> valueItems)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)valueItems);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_IEnumerable_1_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 982578, RefRangeEnd = 982582, XrefRangeStart = 982325, XrefRangeEnd = 982578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToEffectPreviewInfo(this KeyWithValues keyWithValues, Il2CppSystem.Decimal minFactor, Il2CppSystem.Decimal maxFactor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minFactor;
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_KeyWithValues_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 982708, RefRangeEnd = 982711, XrefRangeStart = 982582, XrefRangeEnd = 982708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToEffectPreviewInfo(IEnumerable<KeyWithValues> valueItems, Il2CppSystem.Decimal minFactor, Il2CppSystem.Decimal maxFactor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)valueItems);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minFactor;
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_IEnumerable_1_KeyWithValues_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982711, XrefRangeEnd = 982720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<KeyWithValues> Copy(this Il2CppReferenceArray<KeyWithValues> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyWithValues>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 982747, RefRangeEnd = 982749, XrefRangeStart = 982720, XrefRangeEnd = 982747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<KeyWithValues> Collapse(this Il2CppReferenceArray<KeyWithValues> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collapse_Public_Static_List_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyWithValues>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982783, RefRangeEnd = 982784, XrefRangeStart = 982749, XrefRangeEnd = 982783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<KeyWithValues> Collapse(this List<KeyWithValues> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collapse_Public_Static_List_1_KeyWithValues_List_1_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyWithValues>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 982799, RefRangeEnd = 982801, XrefRangeStart = 982784, XrefRangeEnd = 982799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToEffectInfo(this Il2CppReferenceArray<KeyWithValues> keyWithValues, string sepr = "\ufffd", Il2CppStructArray<Il2CppSystem.Decimal> overrideValues = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sepr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEffectInfo_Public_Static_String_Il2CppReferenceArray_1_KeyWithValues_String_Il2CppStructArray_1_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982801, XrefRangeEnd = 982818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToEffectPreviewInfo(this Il2CppReferenceArray<KeyWithValues> keyWithValues, Il2CppSystem.Decimal minFactor, Il2CppSystem.Decimal maxFactor, string sepr = "\ufffd")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minFactor;
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFactor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sepr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEffectPreviewInfo_Public_Static_String_Il2CppReferenceArray_1_KeyWithValues_Decimal_Decimal_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982818, XrefRangeEnd = 982823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDecimals(this Il2CppSystem.Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDecimals_Public_Static_Int32_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982823, XrefRangeEnd = 982842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortById(this List<ItemData> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortById_Public_Static_Void_List_1_ItemData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982856, RefRangeEnd = 982857, XrefRangeStart = 982842, XrefRangeEnd = 982856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetAllItemReciptKey(this ItemData data, bool containsEmpty = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &containsEmpty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllItemReciptKey_Public_Static_List_1_String_ItemData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982857, XrefRangeEnd = 982900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRecipeStr(ItemType itemType, List<ItemData> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&itemType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecipeStr_Public_Static_String_ItemType_List_1_ItemData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982925, RefRangeEnd = 982926, XrefRangeStart = 982900, XrefRangeEnd = 982925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRecipeStr(ItemType itemType, List<string> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&itemType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecipeStr_Public_Static_String_ItemType_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982926, XrefRangeEnd = 982991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<string> GetAllAvalibleReciptStrs(ItemType itemType, List<ItemData> items, bool containSubRecipt = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&itemType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &containSubRecipt;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAvalibleReciptStrs_Public_Static_HashSet_1_String_ItemType_List_1_ItemData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 983004, RefRangeEnd = 983046, XrefRangeStart = 982991, XrefRangeEnd = 983004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowLog(string key, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		if (paras == null)
		{
			paras = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowLog_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 983059, RefRangeEnd = 983080, XrefRangeStart = 983046, XrefRangeEnd = 983059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowLogNew(string key, LogItemType chatLogType, bool showOldLog, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		if (paras == null)
		{
			paras = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(LogItemType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chatLogType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showOldLog;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowLogNew_Public_Static_Void_String_LogItemType_Boolean_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 983086, RefRangeEnd = 983126, XrefRangeStart = 983080, XrefRangeEnd = 983086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowSlgLog(string key, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		if (paras == null)
		{
			paras = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowSlgLog_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 983157, RefRangeEnd = 983166, XrefRangeStart = 983126, XrefRangeEnd = 983157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowSlgLog(string titleKey, string contentKey, Il2CppSystem.Action eventClose, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		if (paras == null)
		{
			paras = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(titleKey);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(contentKey);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventClose);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowSlgLog_Public_Static_Void_String_String_Action_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983166, XrefRangeEnd = 983172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StringCutting(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringCutting_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 983191, RefRangeEnd = 983207, XrefRangeStart = 983172, XrefRangeEnd = 983191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int GetNearestEmptyTileWithoutRole(this Vector3Int pos, int maxDist = 5, bool canSwim = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pos);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDist;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canSwim;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestEmptyTileWithoutRole_Public_Static_Vector3Int_Vector3Int_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 983313, RefRangeEnd = 983314, XrefRangeStart = 983207, XrefRangeEnd = 983313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int GetNearestNoBlockTile(this Vector3Int pos, int maxDist = 5, HashSet<Vector3Int> softBlocks = null, bool canSwim = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&pos);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDist;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)softBlocks);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &canSwim;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestNoBlockTile_Public_Static_Vector3Int_Vector3Int_Int32_HashSet_1_Vector3Int_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 983373, RefRangeEnd = 983382, XrefRangeStart = 983314, XrefRangeEnd = 983373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTilesFromPosRecursively(int movePoint, Vector3Int pos, ref Dictionary<Vector3Int, int> area, HashSet<Vector3Int> additionBlocks = null, bool canSwim = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&movePoint);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)area);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionBlocks);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &canSwim;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTilesFromPosRecursively_Public_Static_Void_Int32_Vector3Int_byref_Dictionary_2_Vector3Int_Int32_HashSet_1_Vector3Int_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		area = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Vector3Int, int>(intPtr4));
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 983395, RefRangeEnd = 983402, XrefRangeStart = 983382, XrefRangeEnd = 983395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InteractiveObject GetFirstInteractiveObjectOnTile(Vector3Int pos, MapConst.BUILDING_TYPE type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(MapConst.BUILDING_TYPE**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstInteractiveObjectOnTile_Public_Static_InteractiveObject_Vector3Int_BUILDING_TYPE_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractiveObject>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 983406, RefRangeEnd = 983410, XrefRangeStart = 983402, XrefRangeEnd = 983406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RemoveTMPRichText(this string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTMPRichText_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983410, XrefRangeEnd = 983423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int GetNearby(Vector3Int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearby_Public_Static_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 983440, RefRangeEnd = 983442, XrefRangeStart = 983423, XrefRangeEnd = 983440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<Vector3Int> GetDiamondZone(Vector3Int center, int radius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&center);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiamondZone_Public_Static_HashSet_1_Vector3Int_Vector3Int_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 983461, RefRangeEnd = 983465, XrefRangeStart = 983442, XrefRangeEnd = 983461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOwnerValidAndWillStopPlayer(this AreaOwnerCell.AreaOwnerData areaOwnerData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)areaOwnerData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOwnerValidAndWillStopPlayer_Public_Static_Boolean_AreaOwnerData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 983601, RefRangeEnd = 983602, XrefRangeStart = 983465, XrefRangeEnd = 983601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int GetNode(List<Vector3Int> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNode_Public_Static_Vector3Int_List_1_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983602, XrefRangeEnd = 983618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject BronCubeObj(GameObject obj, Transform t, Vector3Int node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(Vector3Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &node;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BronCubeObj_Public_Static_GameObject_GameObject_Transform_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 983618, RefRangeEnd = 983624, XrefRangeStart = 983618, XrefRangeEnd = 983618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DmStageIsBattleStage(this DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DmStageIsBattleStage_Public_Static_Boolean_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 983624, RefRangeEnd = 983625, XrefRangeStart = 983624, XrefRangeEnd = 983624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DmStageIsInternalTriggerStage(this DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DmStageIsInternalTriggerStage_Public_Static_Boolean_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool DmStageIsRoamingStage(this DynamicModifier.DynamicModifierActiveStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DmStageIsRoamingStage_Public_Static_Boolean_DynamicModifierActiveStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983625, XrefRangeEnd = 983636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToTmpRichTextTag(this Color color, bool withAlpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAlpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTmpRichTextTag_Public_Static_String_Color_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 983637, RefRangeEnd = 983638, XrefRangeStart = 983636, XrefRangeEnd = 983637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToHtmlString(this Color color, bool withAlpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAlpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHtmlString_Public_Static_String_Color_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 983682, RefRangeEnd = 983688, XrefRangeStart = 983638, XrefRangeEnd = 983682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRoleGhost(Role role)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRoleGhost_Public_Static_Void_Role_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 983697, RefRangeEnd = 983708, XrefRangeStart = 983688, XrefRangeEnd = 983697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetChildrenType<T>(this Transform transform, List<int> childPaths)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)childPaths);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetChildrenType_Public_Static_T_Transform_List_1_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 983712, RefRangeEnd = 983722, XrefRangeStart = 983708, XrefRangeEnd = 983712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnClickInvoke(this Button btn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)btn);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickInvoke_Public_Static_Void_Button_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983722, XrefRangeEnd = 983727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveIsNull(this GameObject obj, bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 983733, RefRangeEnd = 983739, XrefRangeStart = 983727, XrefRangeEnd = 983733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveIsNull(this TextMeshProUGUI text, bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_TextMeshProUGUI_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 983745, RefRangeEnd = 983747, XrefRangeStart = 983739, XrefRangeEnd = 983745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveIsNull(this TMP_InputField inputField, bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputField);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveIsNull_Public_Static_Void_TMP_InputField_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 983752, RefRangeEnd = 983754, XrefRangeStart = 983747, XrefRangeEnd = 983752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTextIsNull(this TextMeshProUGUI text, string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextIsNull_Public_Static_Void_TextMeshProUGUI_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 983789, RefRangeEnd = 983795, XrefRangeStart = 983754, XrefRangeEnd = 983789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindFirstActiveObjectWithComponent(Transform parent, Il2CppSystem.Type componentType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstActiveObjectWithComponent_Public_Static_GameObject_Transform_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 983955, RefRangeEnd = 983964, XrefRangeStart = 983795, XrefRangeEnd = 983955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetBuffListData([In] ref List<TraitData> traits, [In] ref List<BuffInstance> allBuffs, out List<BuffInstance> residentList, out List<BuffInstance> limitList, out List<BuffInstance> traitList, out int objCount, out Dictionary<string, string> nameDic, [Optional][DefaultParameterValue(null)][In] ref List<BuffInstance> addBuffs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)traits);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allBuffs);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		byte* num4 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num5 = 0;
		*(nint**)num4 = &num5;
		byte* num6 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num7 = 0;
		*(nint**)num6 = &num7;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref objCount);
		byte* num8 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num9 = 0;
		*(nint**)num8 = &num9;
		byte* num10 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addBuffs);
		*(System.IntPtr**)num10 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr5);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffListData_Public_Static_Void_byref_List_1_TraitData_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_List_1_BuffInstance_byref_Int32_byref_Dictionary_2_String_String_byref_List_1_BuffInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		System.IntPtr intPtr6 = intPtr;
		traits = ((intPtr6 == (System.IntPtr)0) ? null : new List<TraitData>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		allBuffs = ((intPtr7 == (System.IntPtr)0) ? null : new List<BuffInstance>(intPtr7));
		nint num11 = num3;
		residentList = ((num11 == 0) ? null : new List<BuffInstance>(num11));
		nint num12 = num5;
		limitList = ((num12 == 0) ? null : new List<BuffInstance>(num12));
		nint num13 = num7;
		traitList = ((num13 == 0) ? null : new List<BuffInstance>(num13));
		nint num14 = num9;
		nameDic = ((num14 == 0) ? null : new Dictionary<string, string>(num14));
		System.IntPtr intPtr8 = intPtr3;
		addBuffs = ((intPtr8 == (System.IntPtr)0) ? null : new List<BuffInstance>(intPtr8));
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 983979, RefRangeEnd = 983995, XrefRangeStart = 983964, XrefRangeEnd = 983979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBuffText(string orinText, bool isPositive, int rarity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(orinText);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPositive;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rarity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffText_Public_Static_String_String_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984003, RefRangeEnd = 984004, XrefRangeStart = 983995, XrefRangeEnd = 984003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RemoveColorTags(string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveColorTags_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 984029, RefRangeEnd = 984033, XrefRangeStart = 984004, XrefRangeEnd = 984029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGuanWenStr(long num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGuanWenStr_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 984055, RefRangeEnd = 984057, XrefRangeStart = 984033, XrefRangeEnd = 984055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoAConfirmQueue(List<string> confirmQueue, Il2CppSystem.Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)confirmQueue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAConfirmQueue_Public_Static_Void_List_1_String_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984101, RefRangeEnd = 984102, XrefRangeStart = 984057, XrefRangeEnd = 984101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SimpleEvalPrecede(string p, string q)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimpleEvalPrecede_Private_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984202, RefRangeEnd = 984203, XrefRangeStart = 984102, XrefRangeEnd = 984202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Decimal SimpleEvalOperate(Il2CppSystem.Decimal a, char o, Il2CppSystem.Decimal b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &o;
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimpleEvalOperate_Private_Static_Decimal_Decimal_Char_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 984338, RefRangeEnd = 984342, XrefRangeStart = 984203, XrefRangeEnd = 984338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SimpleEval(string expression, Il2CppSystem.Func<string, Il2CppSystem.Decimal> converter = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimpleEval_Public_Static_String_String_Func_2_String_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 984374, RefRangeEnd = 984378, XrefRangeStart = 984342, XrefRangeEnd = 984374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetIcon(this CurrencyType currencyType, bool isSmall = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currencyType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSmall;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_CurrencyType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 984395, RefRangeEnd = 984399, XrefRangeStart = 984378, XrefRangeEnd = 984395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetIcon(this FactionGoodsData factionGoodsData, bool isSmall = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionGoodsData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSmall;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_FactionGoodsData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 984457, RefRangeEnd = 984469, XrefRangeStart = 984399, XrefRangeEnd = 984457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Sprite> GetSpriteAnimList(string atlasPath, List<string> keysWithFallBack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(atlasPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keysWithFallBack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteAnimList_Public_Static_List_1_Sprite_String_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984518, RefRangeEnd = 984519, XrefRangeStart = 984469, XrefRangeEnd = 984518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetThresholdIndex<T>(IList<T> list, T value)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(T*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetThresholdIndex_Public_Static_Int32_IList_1_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984519, XrefRangeEnd = 984524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetValueOrDefault<T>(this IList<T> list, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_T_IList_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 984586, RefRangeEnd = 984589, XrefRangeStart = 984524, XrefRangeEnd = 984586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToDescString(this CompareData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDescString_Public_Static_String_CompareData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984589, XrefRangeEnd = 984609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStrangerName(this CharacterPoolData characterPoolData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStrangerName_Public_Static_String_CharacterPoolData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 984619, RefRangeEnd = 984622, XrefRangeStart = 984609, XrefRangeEnd = 984619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocSurName(this CharacterPoolData characterPoolData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocSurName_Public_Static_String_CharacterPoolData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 984632, RefRangeEnd = 984635, XrefRangeStart = 984622, XrefRangeEnd = 984632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocGivenName(this CharacterPoolData characterPoolData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocGivenName_Public_Static_String_CharacterPoolData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 984652, RefRangeEnd = 984666, XrefRangeStart = 984635, XrefRangeEnd = 984652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocFullName(this CharacterPoolData characterPoolData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocFullName_Public_Static_String_CharacterPoolData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984676, RefRangeEnd = 984677, XrefRangeStart = 984666, XrefRangeEnd = 984676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocTitle(this CharacterPoolData characterPoolData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocTitle_Public_Static_String_CharacterPoolData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 984706, RefRangeEnd = 984708, XrefRangeStart = 984677, XrefRangeEnd = 984706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocFullNameWithTitle(this CharacterPoolData characterPoolData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterPoolData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocFullNameWithTitle_Public_Static_String_CharacterPoolData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984708, XrefRangeEnd = 984717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTempleteLocSurName(this CharacterPoolDataScriptObject self, string idOrName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(idOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTempleteLocSurName_Public_Static_String_CharacterPoolDataScriptObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984717, XrefRangeEnd = 984726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTempleteLocGivenName(this CharacterPoolDataScriptObject self, string idOrName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(idOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTempleteLocGivenName_Public_Static_String_CharacterPoolDataScriptObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984726, XrefRangeEnd = 984735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTempleteLocFullName(this CharacterPoolDataScriptObject self, string idOrName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(idOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTempleteLocFullName_Public_Static_String_CharacterPoolDataScriptObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984735, XrefRangeEnd = 984744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTempleteFullNameWithTitle(this CharacterPoolDataScriptObject self, string idOrName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(idOrName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTempleteFullNameWithTitle_Public_Static_String_CharacterPoolDataScriptObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 984755, RefRangeEnd = 984765, XrefRangeStart = 984744, XrefRangeEnd = 984755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this FactionData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_FactionData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 984776, RefRangeEnd = 984778, XrefRangeStart = 984765, XrefRangeEnd = 984776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInfo(this FactionData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_Static_String_FactionData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 984810, RefRangeEnd = 984853, XrefRangeStart = 984778, XrefRangeEnd = 984810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this ItemData self, bool isRichText = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isRichText;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_ItemData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 984864, RefRangeEnd = 984872, XrefRangeStart = 984853, XrefRangeEnd = 984864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInfo(this ItemData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_Static_String_ItemData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 984891, RefRangeEnd = 984899, XrefRangeStart = 984872, XrefRangeEnd = 984891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this ItemForgeEffectData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_ItemForgeEffectData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984935, RefRangeEnd = 984936, XrefRangeStart = 984899, XrefRangeEnd = 984935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<KungfuMoveData> GetAllMove(this KungfuData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllMove_Public_Static_List_1_KungfuMoveData_KungfuData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KungfuMoveData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 984947, RefRangeEnd = 984948, XrefRangeStart = 984936, XrefRangeEnd = 984947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetKungfuInfo(this KungfuData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKungfuInfo_Public_Static_String_KungfuData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 984967, RefRangeEnd = 984977, XrefRangeStart = 984948, XrefRangeEnd = 984967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInternalKungfuEffect(this KungfuData self, bool isActive, string sep = "\n")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sep);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInternalKungfuEffect_Public_Static_String_KungfuData_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 984983, RefRangeEnd = 985013, XrefRangeStart = 984977, XrefRangeEnd = 984983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 985024, RefRangeEnd = 985032, XrefRangeStart = 985013, XrefRangeEnd = 985024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasName(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasName_Public_Static_Boolean_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985065, RefRangeEnd = 985067, XrefRangeStart = 985032, XrefRangeEnd = 985065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNameWithColor(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 985139, RefRangeEnd = 985161, XrefRangeStart = 985067, XrefRangeEnd = 985139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInfo(this BuffData self, Il2CppStructArray<Il2CppSystem.Decimal> overrideContinousEffect = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideContinousEffect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_Static_String_BuffData_Il2CppStructArray_1_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985161, XrefRangeEnd = 985166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEffectInfo(this BuffData self, KeyWithValues keyWithValues)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyWithValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEffectInfo_Public_Static_String_BuffData_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985170, RefRangeEnd = 985171, XrefRangeStart = 985166, XrefRangeEnd = 985170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsElixirBuff(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsElixirBuff_Public_Static_Boolean_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 985175, RefRangeEnd = 985180, XrefRangeStart = 985171, XrefRangeEnd = 985175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSlgTrait(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSlgTrait_Public_Static_Boolean_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985188, RefRangeEnd = 985189, XrefRangeStart = 985180, XrefRangeEnd = 985188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSlgTraitInborn(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSlgTraitInborn_Public_Static_Boolean_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 985200, RefRangeEnd = 985207, XrefRangeStart = 985189, XrefRangeEnd = 985200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSlgTraitCost(this BuffData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlgTraitCost_Public_Static_Int32_BuffData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 985213, RefRangeEnd = 985216, XrefRangeStart = 985207, XrefRangeEnd = 985213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckAvalible(this SelfPropBufflData self, GameCharacterInstance gameCharacterInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAvalible_Public_Static_Boolean_SelfPropBufflData_GameCharacterInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985216, XrefRangeEnd = 985226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetUnitName(this ItemData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnitName_Public_Static_String_ItemData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 985259, RefRangeEnd = 985269, XrefRangeStart = 985226, XrefRangeEnd = 985259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNameWithCount(this ItemData self, int count = 1, bool isRichText = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isRichText;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNameWithCount_Public_Static_String_ItemData_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985269, XrefRangeEnd = 985272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRelationImproveItemInSlgMode(this ItemData itemData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRelationImproveItemInSlgMode_Public_Static_Boolean_ItemData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985286, RefRangeEnd = 985287, XrefRangeStart = 985272, XrefRangeEnd = 985286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRelationImproveInSlgMode(this ItemData itemData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationImproveInSlgMode_Public_Static_Int32_ItemData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 985319, RefRangeEnd = 985324, XrefRangeStart = 985287, XrefRangeEnd = 985319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this TraitData self, bool isRichText = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isRichText;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_TraitData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 985377, RefRangeEnd = 985380, XrefRangeStart = 985324, XrefRangeEnd = 985377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNameWithColor(this KungfuData kungfuData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_KungfuData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 985391, RefRangeEnd = 985394, XrefRangeStart = 985380, XrefRangeEnd = 985391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this DLCTrader dLCTrader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCTrader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_DLCTrader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985422, RefRangeEnd = 985424, XrefRangeStart = 985394, XrefRangeEnd = 985422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInfo(this TraitData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_Static_String_TraitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985451, RefRangeEnd = 985453, XrefRangeStart = 985424, XrefRangeEnd = 985451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetIntroductionLocText(this NewsConfigScriptObject self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIntroductionLocText_Public_Static_String_NewsConfigScriptObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 985459, RefRangeEnd = 985462, XrefRangeStart = 985453, XrefRangeEnd = 985459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddTempModifier(this TMP_InputField inputField, int length, bool allowNonLatin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputField);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowNonLatin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTempModifier_Public_Static_Void_TMP_InputField_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 985526, RefRangeEnd = 985530, XrefRangeStart = 985462, XrefRangeEnd = 985526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable SelectFirstSelectable(this GameObject root, Transform nearestAnchor = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nearestAnchor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectFirstSelectable_Public_Static_Selectable_GameObject_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 985535, RefRangeEnd = 985540, XrefRangeStart = 985530, XrefRangeEnd = 985535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KeyWithValues GetNeg(this KeyWithValues origin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNeg_Public_Static_KeyWithValues_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyWithValues>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985540, XrefRangeEnd = 985549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<KeyWithValues> GetNeg(this Il2CppReferenceArray<KeyWithValues> origin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNeg_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyWithValues>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 985554, RefRangeEnd = 985560, XrefRangeStart = 985549, XrefRangeEnd = 985554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KeyWithValues GetMultiply(this KeyWithValues origin, Il2CppSystem.Decimal mul)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mul;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMultiply_Public_Static_KeyWithValues_KeyWithValues_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyWithValues>(intPtr) : null;
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 985569, RefRangeEnd = 985588, XrefRangeStart = 985560, XrefRangeEnd = 985569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<KeyWithValues> GetMultiply(this Il2CppReferenceArray<KeyWithValues> origin, Il2CppSystem.Decimal mul)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		*(Il2CppSystem.Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mul;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMultiply_Public_Static_Il2CppReferenceArray_1_KeyWithValues_Il2CppReferenceArray_1_KeyWithValues_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyWithValues>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985646, RefRangeEnd = 985648, XrefRangeStart = 985588, XrefRangeEnd = 985646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTipScreenPos(RectTransform tip, RectTransform target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tip);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTipScreenPos_Public_Static_Void_RectTransform_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985664, RefRangeEnd = 985665, XrefRangeStart = 985648, XrefRangeEnd = 985664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetLockIcon(this ComponentShowCommonTip commonTip, bool isType1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commonTip);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isType1;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLockIcon_Public_Static_Sprite_ComponentShowCommonTip_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985681, RefRangeEnd = 985683, XrefRangeStart = 985665, XrefRangeEnd = 985681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetIcon(this ComponentShowCommonTip commonTip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commonTip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_ComponentShowCommonTip_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985695, RefRangeEnd = 985696, XrefRangeStart = 985683, XrefRangeEnd = 985695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetIcon(this DLCTech tech)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tech);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCTech_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 985707, RefRangeEnd = 985710, XrefRangeStart = 985696, XrefRangeEnd = 985707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this DLCTech tech)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tech);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_DLCTech_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985721, RefRangeEnd = 985722, XrefRangeStart = 985710, XrefRangeEnd = 985721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInfo(this DLCTech tech)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tech);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_Static_String_DLCTech_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 985746, RefRangeEnd = 985756, XrefRangeStart = 985722, XrefRangeEnd = 985746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this DLCFaction dLCFaction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_DLCFaction_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 985769, RefRangeEnd = 985770, XrefRangeStart = 985756, XrefRangeEnd = 985769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetOriginName(this DLCFaction dLCFaction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOriginName_Public_Static_String_DLCFaction_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985783, RefRangeEnd = 985785, XrefRangeStart = 985770, XrefRangeEnd = 985783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInfo(this DLCFaction dLCFaction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfo_Public_Static_String_DLCFaction_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 985798, RefRangeEnd = 985802, XrefRangeStart = 985785, XrefRangeEnd = 985798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetIcon(this DLCFaction dLCFaction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCFaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCFaction_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 985829, RefRangeEnd = 985837, XrefRangeStart = 985802, XrefRangeEnd = 985829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this DLCProvince dLCProvince, bool useCapitalName = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCProvince);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCapitalName;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_DLCProvince_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 985849, RefRangeEnd = 985851, XrefRangeStart = 985837, XrefRangeEnd = 985849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetIcon(this DLCProvince dLCProvince)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dLCProvince);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Static_Sprite_DLCProvince_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 985851, RefRangeEnd = 985855, XrefRangeStart = 985851, XrefRangeEnd = 985851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyLocTextForAllLanguage(this LocData self, string loc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(loc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLocTextForAllLanguage_Public_Static_Void_LocData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985855, XrefRangeEnd = 985909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LocData SafeClone(this LocData self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SafeClone_Public_Static_LocData_LocData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 985943, RefRangeEnd = 985946, XrefRangeStart = 985909, XrefRangeEnd = 985943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FixLocData(this LocData self, string defaultLoc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultLoc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixLocData_Public_Static_Void_LocData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 985973, RefRangeEnd = 985987, XrefRangeStart = 985946, XrefRangeEnd = 985973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FixLocDataOneLanguage(ref string str, List<string> allLocs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allLocs);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixLocDataOneLanguage_Private_Static_Void_byref_String_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		str = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 986020, RefRangeEnd = 986021, XrefRangeStart = 985987, XrefRangeEnd = 986020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceTextSpriteCurrency(string src)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceTextSpriteCurrency_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public static void ShowLog(string key, params Il2CppSystem.Object[] paras)
	{
		ShowLog(key, new Il2CppReferenceArray<Il2CppSystem.Object>(paras));
	}

	public static void ShowLogNew(string key, LogItemType chatLogType, bool showOldLog, params Il2CppSystem.Object[] paras)
	{
		ShowLogNew(key, chatLogType, showOldLog, new Il2CppReferenceArray<Il2CppSystem.Object>(paras));
	}

	public static void ShowSlgLog(string key, params Il2CppSystem.Object[] paras)
	{
		ShowSlgLog(key, new Il2CppReferenceArray<Il2CppSystem.Object>(paras));
	}

	public static void ShowSlgLog(string titleKey, string contentKey, Il2CppSystem.Action eventClose, params Il2CppSystem.Object[] paras)
	{
		ShowSlgLog(titleKey, contentKey, eventClose, new Il2CppReferenceArray<Il2CppSystem.Object>(paras));
	}

	public GameUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
