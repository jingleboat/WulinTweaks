using System;
using System.Runtime.CompilerServices;
using Doozy.Engine.Progress;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Audio;

namespace Doozy.Examples;

public class ExampleProgressTargetAudioMixer : ProgressTarget
{
	private static readonly IntPtr NativeFieldInfoPtr_AudioMixer;

	private static readonly IntPtr NativeFieldInfoPtr_ExposedParameter;

	private static readonly IntPtr NativeFieldInfoPtr_TargetVariable;

	private static readonly IntPtr NativeFieldInfoPtr_m_targetValue;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateTarget_Public_Virtual_Void_Progressor_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AudioMixer AudioMixer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioMixer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioMixer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioMixer));
		}
	}

	public unsafe string ExposedParameter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposedParameter);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposedParameter)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

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

	static ExampleProgressTargetAudioMixer()
	{
		Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Examples", "ExampleProgressTargetAudioMixer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr);
		NativeFieldInfoPtr_AudioMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr, "AudioMixer");
		NativeFieldInfoPtr_ExposedParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr, "ExposedParameter");
		NativeFieldInfoPtr_TargetVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr, "TargetVariable");
		NativeFieldInfoPtr_m_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr, "m_targetValue");
		NativeMethodInfoPtr_UpdateTarget_Public_Virtual_Void_Progressor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr, 100667281);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr, 100667282);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724940, XrefRangeEnd = 724953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateTarget(Progressor progressor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progressor);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateTarget_Public_Virtual_Void_Progressor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 254918, RefRangeEnd = 254936, XrefRangeStart = 254918, XrefRangeEnd = 254936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExampleProgressTargetAudioMixer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExampleProgressTargetAudioMixer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ExampleProgressTargetAudioMixer(IntPtr pointer)
		: base(pointer)
	{
	}
}
