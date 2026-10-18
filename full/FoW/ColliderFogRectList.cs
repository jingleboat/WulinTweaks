using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace FoW;

public class ColliderFogRectList : List<ColliderFogRect>
{
	private static readonly IntPtr NativeFieldInfoPtr__fogOfWar_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_fogOfWar_Public_get_FogOfWarTeam_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_fogOfWar_Private_set_Void_FogOfWarTeam_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FogOfWarTeam_0;

	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_Collider_0;

	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_Collider2D_0;

	private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2Int_0;

	private static readonly IntPtr NativeMethodInfoPtr_Optimise_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ExtendToCircleEdge_Public_Void_Vector2Int_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__Optimise_b__8_0_Private_Boolean_ColliderFogRect_0;

	public unsafe FogOfWarTeam _fogOfWar_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fogOfWar_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarTeam>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fogOfWar_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogOfWarTeam));
		}
	}

	public unsafe FogOfWarTeam fogOfWar
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18874, RefRangeEnd = 18877, XrefRangeStart = 18874, XrefRangeEnd = 18877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fogOfWar_Public_get_FogOfWarTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FogOfWarTeam>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40031, RefRangeEnd = 40034, XrefRangeStart = 40031, XrefRangeEnd = 40034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fogOfWar_Private_set_Void_FogOfWarTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ColliderFogRectList()
	{
		Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "ColliderFogRectList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr);
		NativeFieldInfoPtr__fogOfWar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, "<fogOfWar>k__BackingField");
		NativeMethodInfoPtr_get_fogOfWar_Public_get_FogOfWarTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666893);
		NativeMethodInfoPtr_set_fogOfWar_Private_set_Void_FogOfWarTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666894);
		NativeMethodInfoPtr__ctor_Public_Void_FogOfWarTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666895);
		NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666896);
		NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666897);
		NativeMethodInfoPtr_Contains_Public_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666898);
		NativeMethodInfoPtr_Optimise_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666899);
		NativeMethodInfoPtr_ExtendToCircleEdge_Public_Void_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666900);
		NativeMethodInfoPtr__Optimise_b__8_0_Private_Boolean_ColliderFogRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr, 100666901);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720726, XrefRangeEnd = 720732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColliderFogRectList(FogOfWarTeam fow)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColliderFogRectList>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fow);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FogOfWarTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720732, XrefRangeEnd = 720745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add([Optional] Il2CppReferenceArray<Collider> colliders)
	{
		if (colliders == null)
		{
			colliders = new Il2CppReferenceArray<Collider>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colliders);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720745, XrefRangeEnd = 720758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add([Optional] Il2CppReferenceArray<Collider2D> colliders)
	{
		if (colliders == null)
		{
			colliders = new Il2CppReferenceArray<Collider2D>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colliders);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720758, XrefRangeEnd = 720761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(Vector2Int p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720761, XrefRangeEnd = 720772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Optimise()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Optimise_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720772, XrefRangeEnd = 720775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExtendToCircleEdge(Vector2Int p, int radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&p);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &radius;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtendToCircleEdge_Public_Void_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720775, XrefRangeEnd = 720780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _Optimise_b__8_0(ColliderFogRect r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Optimise_b__8_0_Private_Boolean_ColliderFogRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public void Add(params Collider[] colliders)
	{
		Add(new Il2CppReferenceArray<Collider>(colliders));
	}

	public void Add(params Collider2D[] colliders)
	{
		Add(new Il2CppReferenceArray<Collider2D>(colliders));
	}

	public ColliderFogRectList(IntPtr pointer)
		: base(pointer)
	{
	}
}
