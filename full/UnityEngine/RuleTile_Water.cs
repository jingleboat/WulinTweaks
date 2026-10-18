using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Tilemaps;

namespace UnityEngine;

[Serializable]
public class RuleTile_Water : RuleTile
{
	private static readonly IntPtr NativeMethodInfoPtr_RuleMatches_Public_Virtual_Boolean_TilingRule_Vector3Int_ITilemap_byref_Matrix4x4_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RuleTile_Water()
	{
		Il2CppClassPointerStore<RuleTile_Water>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine", "RuleTile_Water");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuleTile_Water>.NativeClassPtr);
		NativeMethodInfoPtr_RuleMatches_Public_Virtual_Boolean_TilingRule_Vector3Int_ITilemap_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile_Water>.NativeClassPtr, 100666676);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile_Water>.NativeClassPtr, 100666677);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718499, XrefRangeEnd = 718572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, ref Matrix4x4 transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref transform);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RuleMatches_Public_Virtual_Boolean_TilingRule_Vector3Int_ITilemap_byref_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718572, XrefRangeEnd = 718573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuleTile_Water()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuleTile_Water>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RuleTile_Water(IntPtr pointer)
		: base(pointer)
	{
	}
}
