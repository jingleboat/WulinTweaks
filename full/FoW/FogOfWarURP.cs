using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace FoW;

[Serializable]
public sealed class FogOfWarURP : VolumeComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_team;

	private static readonly IntPtr NativeFieldInfoPtr_fogFarPlane;

	private static readonly IntPtr NativeFieldInfoPtr_outsideFogStrength;

	private static readonly IntPtr NativeFieldInfoPtr_pointFiltering;

	private static readonly IntPtr NativeFieldInfoPtr_fogColor;

	private static readonly IntPtr NativeFieldInfoPtr_fogColorTexture;

	private static readonly IntPtr NativeFieldInfoPtr_fogTextureScreenSpace;

	private static readonly IntPtr NativeFieldInfoPtr_fogColorTextureScale;

	private static readonly IntPtr NativeFieldInfoPtr_fogColorTextureHeight;

	private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IntParameter team
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_team);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IntParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_team)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)intParameter));
		}
	}

	public unsafe BoolParameter fogFarPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogFarPlane);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogFarPlane)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boolParameter));
		}
	}

	public unsafe FloatParameter outsideFogStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideFogStrength);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideFogStrength)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)floatParameter));
		}
	}

	public unsafe BoolParameter pointFiltering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointFiltering);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointFiltering)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boolParameter));
		}
	}

	public unsafe ColorParameter fogColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorParameter));
		}
	}

	public unsafe TextureParameter fogColorTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColorTexture);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColorTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureParameter));
		}
	}

	public unsafe BoolParameter fogTextureScreenSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogTextureScreenSpace);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogTextureScreenSpace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boolParameter));
		}
	}

	public unsafe FloatParameter fogColorTextureScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColorTextureScale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColorTextureScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)floatParameter));
		}
	}

	public unsafe FloatParameter fogColorTextureHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColorTextureHeight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColorTextureHeight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)floatParameter));
		}
	}

	static FogOfWarURP()
	{
		Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FoW", "FogOfWarURP");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr);
		NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "team");
		NativeFieldInfoPtr_fogFarPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "fogFarPlane");
		NativeFieldInfoPtr_outsideFogStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "outsideFogStrength");
		NativeFieldInfoPtr_pointFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "pointFiltering");
		NativeFieldInfoPtr_fogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "fogColor");
		NativeFieldInfoPtr_fogColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "fogColorTexture");
		NativeFieldInfoPtr_fogTextureScreenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "fogTextureScreenSpace");
		NativeFieldInfoPtr_fogColorTextureScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "fogColorTextureScale");
		NativeFieldInfoPtr_fogColorTextureHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, "fogColorTextureHeight");
		NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, 100667119);
		NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, 100667120);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr, 100667121);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722453, XrefRangeEnd = 722454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsTileCompatible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722454, XrefRangeEnd = 722489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogOfWarURP()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogOfWarURP>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogOfWarURP(IntPtr pointer)
		: base(pointer)
	{
	}
}
