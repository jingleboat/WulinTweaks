using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace WuLin.StateMachine;

public class InteractiveSingleCharacterStateMachineData : StateMachineData
{
	private static readonly IntPtr NativeFieldInfoPtr_characterInInteractiving;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameCharacterInstance characterInInteractiving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInInteractiving);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInInteractiving)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
		}
	}

	static InteractiveSingleCharacterStateMachineData()
	{
		Il2CppClassPointerStore<InteractiveSingleCharacterStateMachineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "InteractiveSingleCharacterStateMachineData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractiveSingleCharacterStateMachineData>.NativeClassPtr);
		NativeFieldInfoPtr_characterInInteractiving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveSingleCharacterStateMachineData>.NativeClassPtr, "characterInInteractiving");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveSingleCharacterStateMachineData>.NativeClassPtr, 100680844);
	}

	[CallerCount(458)]
	[CachedScanResults(RefRangeStart = 26910, RefRangeEnd = 27368, XrefRangeStart = 26910, XrefRangeEnd = 27368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractiveSingleCharacterStateMachineData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractiveSingleCharacterStateMachineData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InteractiveSingleCharacterStateMachineData(IntPtr pointer)
		: base(pointer)
	{
	}
}
