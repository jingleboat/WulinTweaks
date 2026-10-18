using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace FoW;

public class FogOfWarDrawerSoftware : FogOfWarDrawer
{
	private static readonly IntPtr NativeFieldInfoPtr__values;

	private static readonly IntPtr NativeFieldInfoPtr__filterMode;

	private static readonly IntPtr NativeFieldInfoPtr___isMultithreaded_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get__isMultithreaded_Protected_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set__isMultithreaded_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_Void_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetValues_Public_Virtual_Void_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnInitialise_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_Fade_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Single_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_LineOfSightCanSee_Private_Boolean_FogOfWarShape_Vector2_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_LineOfSightCanSeeCell_Private_Boolean_FogOfWarShape_Vector2Int_0;

	private static readonly IntPtr NativeMethodInfoPtr_SampleTexture_Private_Byte_Texture2D_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Unfog_Private_Void_Int32_Int32_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Virtual_Void_FogOfWarShape_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawCircle_Private_Void_FogOfWarShapeCircle_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawAxisAlignedBox_Private_Void_FogOfWarShapeBox_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawRotatedBox_Private_Void_FogOfWarShapeBox_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeshVertex_Private_Vector2Int_Int32_FogOfWarShapeMesh_byref_DrawInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Private_Void_FogOfWarShapeMesh_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawTriangle_Private_Void_FogOfWarShapeMesh_byref_DrawInfo_Single_Vector2Int_Vector2Int_Vector2Int_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<byte> _values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__values);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__values)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe FilterMode _filterMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filterMode);
			return *(FilterMode*)num;
		}
		set
		{
			*(FilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filterMode)) = filterMode;
		}
	}

	public unsafe bool __isMultithreaded_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___isMultithreaded_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___isMultithreaded_k__BackingField)) = flag;
		}
	}

	public unsafe bool _isMultithreaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__isMultithreaded_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set__isMultithreaded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static FogOfWarDrawerSoftware()
	{
		Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarDrawerSoftware");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr);
		NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, "_values");
		NativeFieldInfoPtr__filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, "_filterMode");
		NativeFieldInfoPtr___isMultithreaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, "<_isMultithreaded>k__BackingField");
		NativeMethodInfoPtr_get__isMultithreaded_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666933);
		NativeMethodInfoPtr_set__isMultithreaded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr_GetValues_Public_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666935);
		NativeMethodInfoPtr_SetValues_Public_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666936);
		NativeMethodInfoPtr_OnInitialise_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666937);
		NativeMethodInfoPtr_Clear_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666938);
		NativeMethodInfoPtr_Fade_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666939);
		NativeMethodInfoPtr_LineOfSightCanSee_Private_Boolean_FogOfWarShape_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666940);
		NativeMethodInfoPtr_LineOfSightCanSeeCell_Private_Boolean_FogOfWarShape_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666941);
		NativeMethodInfoPtr_SampleTexture_Private_Byte_Texture2D_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666942);
		NativeMethodInfoPtr_Unfog_Private_Void_Int32_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666943);
		NativeMethodInfoPtr_Draw_Public_Virtual_Void_FogOfWarShape_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666944);
		NativeMethodInfoPtr_DrawCircle_Private_Void_FogOfWarShapeCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666945);
		NativeMethodInfoPtr_DrawAxisAlignedBox_Private_Void_FogOfWarShapeBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666946);
		NativeMethodInfoPtr_DrawRotatedBox_Private_Void_FogOfWarShapeBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666947);
		NativeMethodInfoPtr_GetMeshVertex_Private_Vector2Int_Int32_FogOfWarShapeMesh_byref_DrawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666948);
		NativeMethodInfoPtr_DrawMesh_Private_Void_FogOfWarShapeMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666949);
		NativeMethodInfoPtr_DrawTriangle_Private_Void_FogOfWarShapeMesh_byref_DrawInfo_Single_Vector2Int_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666950);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr, 100666951);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721104, XrefRangeEnd = 721106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GetValues(Il2CppStructArray<byte> outvalues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outvalues);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValues_Public_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721106, XrefRangeEnd = 721108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetValues(Il2CppStructArray<byte> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetValues_Public_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721108, XrefRangeEnd = 721112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnInitialise()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInitialise_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721112, XrefRangeEnd = 721113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Clear(byte value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clear_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Fade(Il2CppStructArray<byte> currentvalues, Il2CppStructArray<byte> totalvalues, float partialfogamount, int inamount, int outamount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentvalues);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)totalvalues);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &partialfogamount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &inamount;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &outamount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Fade_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Single_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 721123, RefRangeEnd = 721127, XrefRangeStart = 721113, XrefRangeEnd = 721123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LineOfSightCanSee(FogOfWarShape shape, Vector2 offset, float fogradius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &offset;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &fogradius;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineOfSightCanSee_Private_Boolean_FogOfWarShape_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 721127, RefRangeEnd = 721131, XrefRangeStart = 721127, XrefRangeEnd = 721127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LineOfSightCanSeeCell(FogOfWarShape shape, Vector2Int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &offset;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineOfSightCanSeeCell_Private_Boolean_FogOfWarShape_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721136, RefRangeEnd = 721138, XrefRangeStart = 721131, XrefRangeEnd = 721136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte SampleTexture(Texture2D texture, float u, float v, float brightness)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &u;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &v;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &brightness;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SampleTexture_Private_Byte_Texture2D_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 721138, RefRangeEnd = 721142, XrefRangeStart = 721138, XrefRangeEnd = 721138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unfog(int x, int y, byte v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &v;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unfog_Private_Void_Int32_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721142, XrefRangeEnd = 721162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Draw(FogOfWarShape shape, bool ismultithreaded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &ismultithreaded;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Draw_Public_Virtual_Void_FogOfWarShape_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721172, RefRangeEnd = 721173, XrefRangeStart = 721162, XrefRangeEnd = 721172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawCircle(FogOfWarShapeCircle shape)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCircle_Private_Void_FogOfWarShapeCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721183, RefRangeEnd = 721184, XrefRangeStart = 721173, XrefRangeEnd = 721183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawAxisAlignedBox(FogOfWarShapeBox shape)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawAxisAlignedBox_Private_Void_FogOfWarShapeBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721194, RefRangeEnd = 721195, XrefRangeStart = 721184, XrefRangeEnd = 721194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawRotatedBox(FogOfWarShapeBox shape)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawRotatedBox_Private_Void_FogOfWarShapeBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 721204, RefRangeEnd = 721210, XrefRangeStart = 721195, XrefRangeEnd = 721204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int GetMeshVertex(int index, FogOfWarShapeMesh shape, ref DrawInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&index);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref info);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshVertex_Private_Vector2Int_Int32_FogOfWarShapeMesh_byref_DrawInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721210, XrefRangeEnd = 721216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawMesh(FogOfWarShapeMesh shape)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMesh_Private_Void_FogOfWarShapeMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721236, RefRangeEnd = 721238, XrefRangeStart = 721216, XrefRangeEnd = 721236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawTriangle(FogOfWarShapeMesh shape, ref DrawInfo info, float lineofsightradius, Vector2Int v1, Vector2Int v2, Vector2Int v3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shape);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref info);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &lineofsightradius;
		*(Vector2Int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &v1;
		*(Vector2Int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &v2;
		*(Vector2Int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &v3;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTriangle_Private_Void_FogOfWarShapeMesh_byref_DrawInfo_Single_Vector2Int_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarDrawerSoftware()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarDrawerSoftware>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarDrawerSoftware(IntPtr pointer)
		: base(pointer)
	{
	}
}
