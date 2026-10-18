using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using XNode;

namespace WuLin.StateMachine;

public class SlgTechGraph : NodeGraph
{
	private static readonly IntPtr NativeMethodInfoPtr_GetStateNodeByName_Public_StateNode_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SlgTechGraph()
	{
		Il2CppClassPointerStore<SlgTechGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "SlgTechGraph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlgTechGraph>.NativeClassPtr);
		NativeMethodInfoPtr_GetStateNodeByName_Public_StateNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTechGraph>.NativeClassPtr, 100681494);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlgTechGraph>.NativeClassPtr, 100681495);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044966, XrefRangeEnd = 1044981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StateNode GetStateNodeByName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStateNodeByName_Public_StateNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StateNode>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 543420, RefRangeEnd = 543421, XrefRangeStart = 543420, XrefRangeEnd = 543421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlgTechGraph()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlgTechGraph>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlgTechGraph(IntPtr pointer)
		: base(pointer)
	{
	}
}
