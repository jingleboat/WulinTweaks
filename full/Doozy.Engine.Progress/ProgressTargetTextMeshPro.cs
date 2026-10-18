using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Doozy.Engine.Progress;

public class ProgressTargetTextMeshPro : ProgressTarget
{
	private static readonly IntPtr NativeFieldInfoPtr_TargetVariable;

	private static readonly IntPtr NativeFieldInfoPtr_WholeNumbers;

	private static readonly IntPtr NativeFieldInfoPtr_UseMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Multiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Prefix;

	private static readonly IntPtr NativeFieldInfoPtr_Suffix;

	private static readonly IntPtr NativeFieldInfoPtr_m_targetValue;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateTarget_Public_Virtual_Void_Progressor_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TargetVariable TargetVariable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetVariable);
			return *(TargetVariable*)num;
		}
		set
		{
			*(TargetVariable*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetVariable)) = targetVariable;
		}
	}

	public unsafe bool WholeNumbers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WholeNumbers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WholeNumbers)) = flag;
		}
	}

	public unsafe bool UseMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMultiplier);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMultiplier)) = flag;
		}
	}

	public unsafe float Multiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Multiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Multiplier)) = num;
		}
	}

	public unsafe string Prefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Suffix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Suffix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Suffix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float m_targetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetValue)) = num;
		}
	}

	static ProgressTargetTextMeshPro()
	{
		Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Progress", "ProgressTargetTextMeshPro");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr);
		NativeFieldInfoPtr_TargetVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "TargetVariable");
		NativeFieldInfoPtr_WholeNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "WholeNumbers");
		NativeFieldInfoPtr_UseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "UseMultiplier");
		NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "Multiplier");
		NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "Prefix");
		NativeFieldInfoPtr_Suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "Suffix");
		NativeFieldInfoPtr_m_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, "m_targetValue");
		NativeMethodInfoPtr_UpdateTarget_Public_Virtual_Void_Progressor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, 100668876);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, 100668877);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr, 100668878);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateTarget(Progressor progressor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progressor);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateTarget_Public_Virtual_Void_Progressor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746592, XrefRangeEnd = 746595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProgressTargetTextMeshPro()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressTargetTextMeshPro>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ProgressTargetTextMeshPro(IntPtr pointer)
		: base(pointer)
	{
	}
}
