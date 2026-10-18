using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Events;

namespace WuLin.StateMachine;

[System.Serializable]
public class StateMachineInstance : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetData_Public_StateMachineData_StateMachineDataTypes_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetData_Public_StateMachineData_StateMachineDataTypes_0, Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_stateMachineGraph;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateMachineDataContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_onStateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr__CurNode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeSwitched;

	private static readonly System.IntPtr NativeFieldInfoPtr_isProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedInitialGraph;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_inited;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurNode_Public_get_StateNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CurNode_Private_set_Void_StateNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_StateMachineGraph_UnityAction_2_StateNode_StateNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JumpToNodeByName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JumpToNode_Public_Void_StateNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_StateMachineDataTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_StateMachineDataTypes_StateMachineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_StateMachineData_StateMachineDataTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveData_Public_Void_StateMachineDataTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StateMachineGraph stateMachineGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateMachineGraph);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateMachineGraph>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateMachineGraph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineGraph));
		}
	}

	public unsafe StateMachineDataContainer stateMachineDataContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateMachineDataContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateMachineDataContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateMachineDataContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineDataContainer));
		}
	}

	public unsafe UnityAction<StateNode, StateNode> onStateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStateChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<StateNode, StateNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStateChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityAction));
		}
	}

	public unsafe StateNode _CurNode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurNode_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurNode_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateNode));
		}
	}

	public unsafe int nodeSwitched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeSwitched);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeSwitched)) = num;
		}
	}

	public unsafe bool isProcessing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isProcessing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isProcessing)) = flag;
		}
	}

	public unsafe StateMachineGraph cachedInitialGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedInitialGraph);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateMachineGraph>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedInitialGraph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineGraph));
		}
	}

	public unsafe bool m_inited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inited)) = flag;
		}
	}

	public unsafe StateNode CurNode
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18874, RefRangeEnd = 18877, XrefRangeStart = 18874, XrefRangeEnd = 18877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurNode_Public_get_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateNode>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40031, RefRangeEnd = 40034, XrefRangeStart = 40031, XrefRangeEnd = 40034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurNode_Private_set_Void_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static StateMachineInstance()
	{
		Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.StateMachine", "StateMachineInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr);
		NativeFieldInfoPtr_stateMachineGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "stateMachineGraph");
		NativeFieldInfoPtr_stateMachineDataContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "stateMachineDataContainer");
		NativeFieldInfoPtr_onStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "onStateChange");
		NativeFieldInfoPtr__CurNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "<CurNode>k__BackingField");
		NativeFieldInfoPtr_nodeSwitched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "nodeSwitched");
		NativeFieldInfoPtr_isProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "isProcessing");
		NativeFieldInfoPtr_cachedInitialGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "cachedInitialGraph");
		NativeFieldInfoPtr_m_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, "m_inited");
		NativeMethodInfoPtr_get_CurNode_Public_get_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680884);
		NativeMethodInfoPtr_set_CurNode_Private_set_Void_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680885);
		NativeMethodInfoPtr_Init_Public_Void_StateMachineGraph_UnityAction_2_StateNode_StateNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680886);
		NativeMethodInfoPtr_Tick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680887);
		NativeMethodInfoPtr_Process_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680888);
		NativeMethodInfoPtr_JumpToNodeByName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680889);
		NativeMethodInfoPtr_JumpToNode_Public_Void_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680890);
		NativeMethodInfoPtr_ContainsKey_Public_Boolean_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680891);
		NativeMethodInfoPtr_SetData_Public_Void_StateMachineDataTypes_StateMachineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680892);
		NativeMethodInfoPtr_GetData_Public_StateMachineData_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680893);
		NativeMethodInfoPtr_RemoveData_Public_Void_StateMachineDataTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680894);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr, 100680895);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1032807, RefRangeEnd = 1032812, XrefRangeStart = 1032785, XrefRangeEnd = 1032807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(StateMachineGraph graph = null, UnityAction<StateNode, StateNode> action = null, bool isReset = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isReset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_StateMachineGraph_UnityAction_2_StateNode_StateNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1032816, RefRangeEnd = 1032817, XrefRangeStart = 1032812, XrefRangeEnd = 1032816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1032838, RefRangeEnd = 1032842, XrefRangeStart = 1032817, XrefRangeEnd = 1032838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Process()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1032852, RefRangeEnd = 1032856, XrefRangeStart = 1032842, XrefRangeEnd = 1032852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JumpToNodeByName(string nodeName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JumpToNodeByName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1032874, RefRangeEnd = 1032876, XrefRangeStart = 1032856, XrefRangeEnd = 1032874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JumpToNode(StateNode jumpTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jumpTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JumpToNode_Public_Void_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1032880, RefRangeEnd = 1032882, XrefRangeStart = 1032876, XrefRangeEnd = 1032880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsKey(StateMachineDataTypes type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsKey_Public_Boolean_StateMachineDataTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1032890, RefRangeEnd = 1032908, XrefRangeStart = 1032882, XrefRangeEnd = 1032890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(StateMachineDataTypes type, StateMachineData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_StateMachineDataTypes_StateMachineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032908, XrefRangeEnd = 1033494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StateMachineData GetData<T>(StateMachineDataTypes type) where T : StateMachineData
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetData_Public_StateMachineData_StateMachineDataTypes_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateMachineData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1033494, XrefRangeEnd = 1033502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveData(StateMachineDataTypes type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveData_Public_Void_StateMachineDataTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StateMachineInstance()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineInstance>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StateMachineInstance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
