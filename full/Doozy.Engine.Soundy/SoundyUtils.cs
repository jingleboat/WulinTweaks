using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Doozy.Engine.Soundy;

public static class SoundyUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TwelfthRootOfTwo;

	private static readonly System.IntPtr NativeMethodInfoPtr_SemitonesToPitch_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PitchToSemitones_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecibelToLinear_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LinearToDecibel_Public_Static_Single_Single_0;

	public unsafe static float TwelfthRootOfTwo
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TwelfthRootOfTwo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TwelfthRootOfTwo, (void*)(&num));
		}
	}

	static SoundyUtils()
	{
		Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Doozy.Engine.Soundy", "SoundyUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr);
		NativeFieldInfoPtr_TwelfthRootOfTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr, "TwelfthRootOfTwo");
		NativeMethodInfoPtr_SemitonesToPitch_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr, 100668787);
		NativeMethodInfoPtr_PitchToSemitones_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr, 100668788);
		NativeMethodInfoPtr_DecibelToLinear_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr, 100668789);
		NativeMethodInfoPtr_LinearToDecibel_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundyUtils>.NativeClassPtr, 100668790);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745446, XrefRangeEnd = 745455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SemitonesToPitch(float semitones)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&semitones);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SemitonesToPitch_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745455, XrefRangeEnd = 745460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float PitchToSemitones(float pitch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pitch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PitchToSemitones_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float DecibelToLinear(float dB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dB);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecibelToLinear_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float LinearToDecibel(float linear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&linear);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LinearToDecibel_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public SoundyUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
