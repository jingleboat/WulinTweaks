using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Pathfinding;

public class IRaycastableGraph : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_byref_GraphHitInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_byref_GraphHitInfo_List_1_GraphNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_byref_GraphHitInfo_List_1_GraphNode_Func_2_GraphNode_Boolean_0;

	static IRaycastableGraph()
	{
		Il2CppClassPointerStore<IRaycastableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "IRaycastableGraph");
		NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRaycastableGraph>.NativeClassPtr, 100682947);
		NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRaycastableGraph>.NativeClassPtr, 100682948);
		NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_byref_GraphHitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRaycastableGraph>.NativeClassPtr, 100682949);
		NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_byref_GraphHitInfo_List_1_GraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRaycastableGraph>.NativeClassPtr, 100682950);
		NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_byref_GraphHitInfo_List_1_GraphNode_Func_2_GraphNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRaycastableGraph>.NativeClassPtr, 100682951);
	}

	[CallerCount(0)]
	public unsafe virtual bool Linecast(Vector3 start, Vector3 end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Linecast(Vector3 start, Vector3 end, GraphNode hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_byref_GraphHitInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		hit = ((num3 == 0) ? null : new GraphHitInfo(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trace);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_GraphNode_byref_GraphHitInfo_List_1_GraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		hit = ((num3 == 0) ? null : new GraphHitInfo(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace = null, Il2CppSystem.Func<GraphNode, bool> filter = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Linecast_Public_Abstract_Virtual_New_Boolean_Vector3_Vector3_byref_GraphHitInfo_List_1_GraphNode_Func_2_GraphNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		hit = ((num3 == 0) ? null : new GraphHitInfo(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IRaycastableGraph(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
