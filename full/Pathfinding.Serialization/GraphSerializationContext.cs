using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnityEngine;

namespace Pathfinding.Serialization;

public class GraphSerializationContext : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id2NodeMapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_writer;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_meta;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_Il2CppReferenceArray_1_GraphNode_UInt32_GraphMeta_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeNodeReference_Public_Void_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeNodeReference_Public_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeVector3_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeVector3_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeInt3_Public_Void_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeInt3_Public_Int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeInt_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeFloat_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeUnityObject_Public_Object_0;

	public unsafe Il2CppReferenceArray<GraphNode> id2NodeMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id2NodeMapping);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id2NodeMapping)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe BinaryReader reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binaryReader));
		}
	}

	public unsafe BinaryWriter writer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binaryWriter));
		}
	}

	public unsafe uint graphIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphIndex);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphIndex)) = num;
		}
	}

	public unsafe GraphMeta meta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meta);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphMeta>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meta)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphMeta));
		}
	}

	static GraphSerializationContext()
	{
		Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding.Serialization", "GraphSerializationContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr);
		NativeFieldInfoPtr_id2NodeMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, "id2NodeMapping");
		NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, "reader");
		NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, "writer");
		NativeFieldInfoPtr_graphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, "graphIndex");
		NativeFieldInfoPtr_meta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, "meta");
		NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_Il2CppReferenceArray_1_GraphNode_UInt32_GraphMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683969);
		NativeMethodInfoPtr__ctor_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683970);
		NativeMethodInfoPtr_SerializeNodeReference_Public_Void_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683971);
		NativeMethodInfoPtr_DeserializeNodeReference_Public_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683972);
		NativeMethodInfoPtr_SerializeVector3_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683973);
		NativeMethodInfoPtr_DeserializeVector3_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683974);
		NativeMethodInfoPtr_SerializeInt3_Public_Void_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683975);
		NativeMethodInfoPtr_DeserializeInt3_Public_Int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683976);
		NativeMethodInfoPtr_DeserializeInt_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683977);
		NativeMethodInfoPtr_DeserializeFloat_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683978);
		NativeMethodInfoPtr_DeserializeUnityObject_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr, 100683979);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1079819, RefRangeEnd = 1079827, XrefRangeStart = 1079818, XrefRangeEnd = 1079819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphSerializationContext(BinaryReader reader, Il2CppReferenceArray<GraphNode> id2NodeMapping, uint graphIndex, GraphMeta meta)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)id2NodeMapping);
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_Il2CppReferenceArray_1_GraphNode_UInt32_GraphMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 109868, RefRangeEnd = 109877, XrefRangeStart = 109868, XrefRangeEnd = 109877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphSerializationContext(BinaryWriter writer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphSerializationContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1079829, RefRangeEnd = 1079836, XrefRangeStart = 1079827, XrefRangeEnd = 1079829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeNodeReference(GraphNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeNodeReference_Public_Void_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1079837, RefRangeEnd = 1079844, XrefRangeStart = 1079836, XrefRangeEnd = 1079837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphNode DeserializeNodeReference()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeNodeReference_Public_GraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphNode>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079845, RefRangeEnd = 1079847, XrefRangeStart = 1079844, XrefRangeEnd = 1079845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeVector3(Vector3 v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeVector3_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1079847, RefRangeEnd = 1079854, XrefRangeStart = 1079847, XrefRangeEnd = 1079847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 DeserializeVector3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeVector3_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1079855, RefRangeEnd = 1079860, XrefRangeStart = 1079854, XrefRangeEnd = 1079855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeInt3(Int3 v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeInt3_Public_Void_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1079861, RefRangeEnd = 1079866, XrefRangeStart = 1079860, XrefRangeEnd = 1079861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Int3 DeserializeInt3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeInt3_Public_Int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Int3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079866, RefRangeEnd = 1079867, XrefRangeStart = 1079866, XrefRangeEnd = 1079866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int DeserializeInt(int defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&defaultValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeInt_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079867, RefRangeEnd = 1079869, XrefRangeStart = 1079867, XrefRangeEnd = 1079867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float DeserializeFloat(float defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&defaultValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeFloat_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079903, RefRangeEnd = 1079905, XrefRangeStart = 1079869, XrefRangeEnd = 1079903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityEngine.Object DeserializeUnityObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeUnityObject_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr) : null;
	}

	public GraphSerializationContext(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
