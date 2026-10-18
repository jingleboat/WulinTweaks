using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using WuLin.GameFrameworks;

namespace WuLin;

public class CreateRoleMar : GTSingleton<CreateRoleMar>
{
	private static readonly IntPtr NativeMethodInfoPtr_CreatePlayer_Public_GameObject_Vector3Int_Transform_EStage_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateColliderShowName_Private_GameObject_Transform_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateNpc_Public_GameObject_GameCharacterInstance_Vector3Int_Transform_EStage_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateNpc_Public_GameObject_GameCharacterInstance_Transform_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateNpc_Public_GameObject_String_Vector3Int_Transform_EStage_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateNpcForShowing_Public_GameObject_GameCharacterInstance_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNeighBor_Public_Vector3Int_Vector3Int_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsLand_Private_Boolean_Vector3Int_0;

	private static readonly IntPtr NativeMethodInfoPtr_SitDown_Private_Void_Role_Vector3Int_0;

	private static readonly IntPtr NativeMethodInfoPtr_SitDown_Private_Void_Role_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CreateRoleMar()
	{
		Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "CreateRoleMar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr);
		NativeMethodInfoPtr_CreatePlayer_Public_GameObject_Vector3Int_Transform_EStage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674356);
		NativeMethodInfoPtr_CreateColliderShowName_Private_GameObject_Transform_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674357);
		NativeMethodInfoPtr_CreateNpc_Public_GameObject_GameCharacterInstance_Vector3Int_Transform_EStage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674358);
		NativeMethodInfoPtr_CreateNpc_Public_GameObject_GameCharacterInstance_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674359);
		NativeMethodInfoPtr_CreateNpc_Public_GameObject_String_Vector3Int_Transform_EStage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674360);
		NativeMethodInfoPtr_CreateNpcForShowing_Public_GameObject_GameCharacterInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674361);
		NativeMethodInfoPtr_GetNeighBor_Public_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674362);
		NativeMethodInfoPtr_IsLand_Private_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674363);
		NativeMethodInfoPtr_SitDown_Private_Void_Role_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674364);
		NativeMethodInfoPtr_SitDown_Private_Void_Role_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674365);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr, 100674366);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 866159, RefRangeEnd = 866161, XrefRangeStart = 866015, XrefRangeEnd = 866159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreatePlayer(Vector3Int Cellpos, Transform pos = null, RoleAniManager.EStage state = RoleAniManager.EStage.Null, bool Isbattle = false, bool checkEmptyTile = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&Cellpos);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pos);
		*(RoleAniManager.EStage**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &state;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &Isbattle;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &checkEmptyTile;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePlayer_Public_GameObject_Vector3Int_Transform_EStage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 866194, RefRangeEnd = 866197, XrefRangeStart = 866161, XrefRangeEnd = 866194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateColliderShowName(Transform parent, int radiusCell, bool needRigidBody = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &radiusCell;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &needRigidBody;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateColliderShowName_Private_GameObject_Transform_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 866381, RefRangeEnd = 866391, XrefRangeStart = 866197, XrefRangeEnd = 866381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNpc(GameCharacterInstance gameCharacterInstance, Vector3Int Cellpos, Transform parent = null, RoleAniManager.EStage state = RoleAniManager.EStage.up, bool Isbattle = false, bool checkEmptyTile = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &Cellpos;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(RoleAniManager.EStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &state;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &Isbattle;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &checkEmptyTile;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNpc_Public_GameObject_GameCharacterInstance_Vector3Int_Transform_EStage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 866514, RefRangeEnd = 866516, XrefRangeStart = 866391, XrefRangeEnd = 866514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNpc(GameCharacterInstance gameCharacterInstance, Transform parent = null, bool Isbattle = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &Isbattle;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNpc_Public_GameObject_GameCharacterInstance_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 866562, RefRangeEnd = 866563, XrefRangeStart = 866516, XrefRangeEnd = 866562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNpc(string id, Vector3Int cell, Transform pos = null, RoleAniManager.EStage state = RoleAniManager.EStage.up, bool Isbattle = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &cell;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pos);
		*(RoleAniManager.EStage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &state;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &Isbattle;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNpc_Public_GameObject_String_Vector3Int_Transform_EStage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 866596, RefRangeEnd = 866599, XrefRangeStart = 866563, XrefRangeEnd = 866596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNpcForShowing(GameCharacterInstance gameCharacterInstance, Transform parent = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNpcForShowing_Public_GameObject_GameCharacterInstance_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866599, XrefRangeEnd = 866715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3Int GetNeighBor(Vector3Int lastPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&lastPos);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNeighBor_Public_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 866741, RefRangeEnd = 866749, XrefRangeStart = 866715, XrefRangeEnd = 866741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLand(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLand_Private_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 866765, RefRangeEnd = 866767, XrefRangeStart = 866749, XrefRangeEnd = 866765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SitDown(Role role_data, Vector3Int cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role_data);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &cell;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SitDown_Private_Void_Role_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 866786, RefRangeEnd = 866787, XrefRangeStart = 866767, XrefRangeEnd = 866786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SitDown(Role role_data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)role_data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SitDown_Private_Void_Role_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866787, XrefRangeEnd = 866793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateRoleMar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateRoleMar>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateRoleMar(IntPtr pointer)
		: base(pointer)
	{
	}
}
