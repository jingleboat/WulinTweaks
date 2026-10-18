using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace WuLin;

public class MiscAnimation : MiscBase
{
	private static readonly IntPtr NativeFieldInfoPtr_SaveID;

	private static readonly IntPtr NativeFieldInfoPtr_frameCount;

	private static readonly IntPtr NativeFieldInfoPtr_intervalTime;

	private static readonly IntPtr NativeFieldInfoPtr_startIndex;

	private static readonly IntPtr NativeFieldInfoPtr_sleepStepMin;

	private static readonly IntPtr NativeFieldInfoPtr_sleepStepMax;

	private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Static_MiscAnimation_String_Transform_Vector3_Texture2D_Vector2_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateEmptyAni_Public_Static_GameObject_Transform_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixTexture_Public_Void_String_Transform_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int SaveID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveID)) = num;
		}
	}

	public unsafe int frameCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameCount)) = num;
		}
	}

	public unsafe float intervalTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalTime)) = num;
		}
	}

	public unsafe int startIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startIndex)) = num;
		}
	}

	public unsafe int sleepStepMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepStepMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepStepMin)) = num;
		}
	}

	public unsafe int sleepStepMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepStepMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepStepMax)) = num;
		}
	}

	static MiscAnimation()
	{
		Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MiscAnimation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr);
		NativeFieldInfoPtr_SaveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, "SaveID");
		NativeFieldInfoPtr_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, "frameCount");
		NativeFieldInfoPtr_intervalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, "intervalTime");
		NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, "startIndex");
		NativeFieldInfoPtr_sleepStepMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, "sleepStepMin");
		NativeFieldInfoPtr_sleepStepMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, "sleepStepMax");
		NativeMethodInfoPtr_AddItem_Public_Static_MiscAnimation_String_Transform_Vector3_Texture2D_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, 100674648);
		NativeMethodInfoPtr_CreateEmptyAni_Public_Static_GameObject_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, 100674649);
		NativeMethodInfoPtr_FixTexture_Public_Void_String_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, 100674650);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr, 100674651);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875059, XrefRangeEnd = 875106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MiscAnimation AddItem(string texturePath, Transform parent, Vector3 worldpos, Texture2D texture, Vector2 texturePivot, bool bGround, bool bFlipX)
	{
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(texturePath);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &worldpos;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &texturePivot;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &bGround;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &bFlipX;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItem_Public_Static_MiscAnimation_String_Transform_Vector3_Texture2D_Vector2_Boolean_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MiscAnimation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875133, RefRangeEnd = 875134, XrefRangeStart = 875106, XrefRangeEnd = 875133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateEmptyAni(Transform parent, Vector3 worldpos)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &worldpos;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateEmptyAni_Public_Static_GameObject_Transform_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875264, RefRangeEnd = 875265, XrefRangeStart = 875134, XrefRangeEnd = 875264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixTexture(string path, Transform item, bool noShaderEffect = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &noShaderEffect;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixTexture_Public_Void_String_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875265, XrefRangeEnd = 875266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MiscAnimation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiscAnimation>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MiscAnimation(IntPtr pointer)
		: base(pointer)
	{
	}
}
