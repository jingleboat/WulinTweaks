using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using WuLin.GameFrameworks;

namespace WuLin;

public sealed class DispatcherSystem : GTSingleton<DispatcherSystem>
{
	public class TypeSystems : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_typeSystemsMap;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateOneTypeSystems_Public_UnOrderMultiMap_2_Type_Object_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetOneTypeSystems_Public_UnOrderMultiMap_2_Type_Object_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetSystems_Public_List_1_Object_Type_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Dictionary<Il2CppSystem.Type, UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Object>> typeSystemsMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeSystemsMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Object>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeSystemsMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static TypeSystems()
		{
			Il2CppClassPointerStore<TypeSystems>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, "TypeSystems");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr);
			NativeFieldInfoPtr_typeSystemsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr, "typeSystemsMap");
			NativeMethodInfoPtr_GetOrCreateOneTypeSystems_Public_UnOrderMultiMap_2_Type_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr, 100686508);
			NativeMethodInfoPtr_GetOneTypeSystems_Public_UnOrderMultiMap_2_Type_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr, 100686509);
			NativeMethodInfoPtr_GetSystems_Public_List_1_Object_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr, 100686510);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr, 100686511);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796008, XrefRangeEnd = 796020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Object> GetOrCreateOneTypeSystems(Il2CppSystem.Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateOneTypeSystems_Public_UnOrderMultiMap_2_Type_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Object>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796020, XrefRangeEnd = 796023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Object> GetOneTypeSystems(Il2CppSystem.Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOneTypeSystems_Public_UnOrderMultiMap_2_Type_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Object>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796023, XrefRangeEnd = 796029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Il2CppSystem.Object> GetSystems(Il2CppSystem.Type type, Il2CppSystem.Type systemType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)systemType);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystems_Public_List_1_Object_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796029, XrefRangeEnd = 796036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeSystems()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeSystems>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TypeSystems(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_assemblies;

	private static readonly System.IntPtr NativeFieldInfoPtr_allTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_types;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseAttributes_Private_List_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Dictionary_2_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Assembly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypes_Public_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypes_Public_Dictionary_2_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetType_Public_Type_String_0;

	public unsafe Dictionary<string, Assembly> assemblies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Assembly>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Type> allTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Type> types
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_types);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnOrderMultiMap<Il2CppSystem.Type, Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_types)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unOrderMultiMap));
		}
	}

	static DispatcherSystem()
	{
		Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "DispatcherSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr);
		NativeFieldInfoPtr_assemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, "assemblies");
		NativeFieldInfoPtr_allTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, "allTypes");
		NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, "types");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671969);
		NativeMethodInfoPtr_GetBaseAttributes_Private_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671970);
		NativeMethodInfoPtr_Add_Public_Void_Dictionary_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671971);
		NativeMethodInfoPtr_Add_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671972);
		NativeMethodInfoPtr_GetTypes_Public_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671973);
		NativeMethodInfoPtr_GetTypes_Public_Dictionary_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671974);
		NativeMethodInfoPtr_GetType_Public_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr, 100671975);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796036, XrefRangeEnd = 796068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DispatcherSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispatcherSystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796099, RefRangeEnd = 796100, XrefRangeStart = 796068, XrefRangeEnd = 796099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Il2CppSystem.Type> GetBaseAttributes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseAttributes_Private_List_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796150, RefRangeEnd = 796151, XrefRangeStart = 796100, XrefRangeEnd = 796150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(Dictionary<string, Il2CppSystem.Type> addTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Dictionary_2_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 796184, RefRangeEnd = 796185, XrefRangeStart = 796151, XrefRangeEnd = 796184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(Assembly assembly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assembly);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 796189, RefRangeEnd = 796192, XrefRangeStart = 796185, XrefRangeEnd = 796189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Il2CppSystem.Type> GetTypes(Il2CppSystem.Type systemAttributeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)systemAttributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypes_Public_List_1_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 13943, RefRangeEnd = 13952, XrefRangeStart = 13943, XrefRangeEnd = 13952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, Il2CppSystem.Type> GetTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypes_Public_Dictionary_2_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796192, XrefRangeEnd = 796196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Type GetType(string typeName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetType_Public_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	public DispatcherSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
