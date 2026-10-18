using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using XNode;

namespace WuLin.StateMachine;

public class StateMachineGraph : NodeGraph
{
	private static readonly IntPtr NativeFieldInfoPtr_defaultNode;

	private static readonly IntPtr NativeFieldInfoPtr_maxStateSwithCount;

	private static readonly IntPtr NativeMethodInfoPtr_GetStateNodeByName_Public_StateNode_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDefauleNode_Public_BaseStateNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BaseStateNode defaultNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultNode);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseStateNode>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseStateNode));
		}
	}

	public unsafe int maxStateSwithCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStateSwithCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStateSwithCount)) = num;
		}
	}

	static StateMachineGraph()
	{
		Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "StateMachineGraph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr);
		NativeFieldInfoPtr_defaultNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr, "defaultNode");
		NativeFieldInfoPtr_maxStateSwithCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr, "maxStateSwithCount");
		NativeMethodInfoPtr_GetStateNodeByName_Public_StateNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr, 100680902);
		NativeMethodInfoPtr_GetDefauleNode_Public_BaseStateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr, 100680903);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr, 100680904);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1033571, RefRangeEnd = 1033574, XrefRangeStart = 1033556, XrefRangeEnd = 1033571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1033593, RefRangeEnd = 1033594, XrefRangeStart = 1033574, XrefRangeEnd = 1033593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseStateNode GetDefauleNode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefauleNode_Public_BaseStateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseStateNode>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033594, XrefRangeEnd = 1033595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StateMachineGraph()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineGraph>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StateMachineGraph(IntPtr pointer)
		: base(pointer)
	{
	}
}
