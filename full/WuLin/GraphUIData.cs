using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace WuLin;

public class GraphUIData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_configName;

	private static readonly System.IntPtr NativeFieldInfoPtr_storyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_check;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphData_0;

	public unsafe string configName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string storyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storyName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool check
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_check);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_check)) = flag;
		}
	}

	public unsafe SaveObjectStory.GraphData saveData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SaveObjectStory.GraphData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphData));
		}
	}

	static GraphUIData()
	{
		Il2CppClassPointerStore<GraphUIData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GraphUIData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr);
		NativeFieldInfoPtr_configName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr, "configName");
		NativeFieldInfoPtr_storyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr, "storyName");
		NativeFieldInfoPtr_check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr, "check");
		NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr, "saveData");
		NativeMethodInfoPtr__ctor_Public_Void_GraphData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr, 100673910);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 854824, RefRangeEnd = 854826, XrefRangeStart = 854820, XrefRangeEnd = 854824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphUIData(SaveObjectStory.GraphData data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphUIData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GraphData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GraphUIData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
