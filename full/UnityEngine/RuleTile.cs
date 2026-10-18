using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Tilemaps;

namespace UnityEngine;

[System.Serializable]
public class RuleTile : TileBase
{
	[System.Serializable]
	public class TilingRule : Il2CppSystem.Object
	{
		public enum Transform
		{
			Fixed,
			Rotated,
			MirrorX,
			MirrorY
		}

		public enum Neighbor
		{
			DontCare,
			This,
			NotThis
		}

		public enum OutputSprite
		{
			Single,
			Random,
			Animation
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Neighbors;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Sprites;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimationSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PerlinScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_RuleTransform;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Output;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ColliderType;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_RandomTransform;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<Neighbor> m_Neighbors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Neighbors);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Neighbor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Neighbors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppReferenceArray<Sprite> m_Sprites
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sprites);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sprites)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe float m_AnimationSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationSpeed)) = num;
			}
		}

		public unsafe float m_PerlinScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerlinScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerlinScale)) = num;
			}
		}

		public unsafe Transform m_RuleTransform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RuleTransform);
				return *(Transform*)num;
			}
			set
			{
				*(Transform*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RuleTransform)) = transform;
			}
		}

		public unsafe OutputSprite m_Output
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Output);
				return *(OutputSprite*)num;
			}
			set
			{
				*(OutputSprite*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Output)) = outputSprite;
			}
		}

		public unsafe Tile.ColliderType m_ColliderType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColliderType);
				return *(Tile.ColliderType*)num;
			}
			set
			{
				*(Tile.ColliderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColliderType)) = colliderType;
			}
		}

		public unsafe Transform m_RandomTransform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RandomTransform);
				return *(Transform*)num;
			}
			set
			{
				*(Transform*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RandomTransform)) = transform;
			}
		}

		static TilingRule()
		{
			Il2CppClassPointerStore<TilingRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, "TilingRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilingRule>.NativeClassPtr);
			NativeFieldInfoPtr_m_Neighbors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_Neighbors");
			NativeFieldInfoPtr_m_Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_Sprites");
			NativeFieldInfoPtr_m_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_AnimationSpeed");
			NativeFieldInfoPtr_m_PerlinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_PerlinScale");
			NativeFieldInfoPtr_m_RuleTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_RuleTransform");
			NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_Output");
			NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_ColliderType");
			NativeFieldInfoPtr_m_RandomTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, "m_RandomTransform");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingRule>.NativeClassPtr, 100685341);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718305, XrefRangeEnd = 718313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TilingRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TilingRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TilingRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultColliderType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TilingRules;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTileData_Public_Virtual_Void_Vector3Int_ITilemap_byref_TileData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerlinValue_Private_Static_Single_Vector3Int_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTile_Public_Virtual_Void_Vector3Int_ITilemap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RuleMatches_Public_Virtual_New_Boolean_TilingRule_Vector3Int_ITilemap_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRandomTransform_Private_Static_Matrix4x4_Transform_Matrix4x4_Single_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexOfOffset_Protected_Int32_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotatedPos_Public_Vector3Int_Vector3Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Sprite m_DefaultSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Tile.ColliderType m_DefaultColliderType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultColliderType);
			return *(Tile.ColliderType*)num;
		}
		set
		{
			*(Tile.ColliderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultColliderType)) = colliderType;
		}
	}

	public unsafe List<TilingRule> m_TilingRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TilingRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TilingRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TilingRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static RuleTile()
	{
		Il2CppClassPointerStore<RuleTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine", "RuleTile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuleTile>.NativeClassPtr);
		NativeFieldInfoPtr_m_DefaultSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, "m_DefaultSprite");
		NativeFieldInfoPtr_m_DefaultColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, "m_DefaultColliderType");
		NativeFieldInfoPtr_m_TilingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, "m_TilingRules");
		NativeMethodInfoPtr_GetTileData_Public_Virtual_Void_Vector3Int_ITilemap_byref_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666667);
		NativeMethodInfoPtr_GetPerlinValue_Private_Static_Single_Vector3Int_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666668);
		NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666669);
		NativeMethodInfoPtr_RefreshTile_Public_Virtual_Void_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666670);
		NativeMethodInfoPtr_RuleMatches_Public_Virtual_New_Boolean_TilingRule_Vector3Int_ITilemap_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666671);
		NativeMethodInfoPtr_ApplyRandomTransform_Private_Static_Matrix4x4_Transform_Matrix4x4_Single_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666672);
		NativeMethodInfoPtr_GetIndexOfOffset_Protected_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666673);
		NativeMethodInfoPtr_GetRotatedPos_Public_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666674);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleTile>.NativeClassPtr, 100666675);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718313, XrefRangeEnd = 718347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GetTileData(Vector3Int position, ITilemap tileMap, ref TileData tileData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)tileData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTileData_Public_Virtual_Void_Vector3Int_ITilemap_byref_TileData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718347, XrefRangeEnd = 718350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerlinValue(Vector3Int position, float scale, float offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerlinValue_Private_Static_Single_Vector3Int_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718350, XrefRangeEnd = 718369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)tileAnimationData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718369, XrefRangeEnd = 718377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RefreshTile(Vector3Int location, ITilemap tileMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RefreshTile_Public_Virtual_Void_Vector3Int_ITilemap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718377, XrefRangeEnd = 718454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, ref Matrix4x4 transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RuleMatches_Public_Virtual_New_Boolean_TilingRule_Vector3Int_ITilemap_byref_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718474, RefRangeEnd = 718475, XrefRangeStart = 718454, XrefRangeEnd = 718474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 ApplyRandomTransform(TilingRule.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&type);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &original;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &perlinScale;
		*(Vector3Int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyRandomTransform_Private_Static_Matrix4x4_Transform_Matrix4x4_Single_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 718477, RefRangeEnd = 718481, XrefRangeStart = 718475, XrefRangeEnd = 718477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetIndexOfOffset(Vector3Int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndexOfOffset_Protected_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718493, RefRangeEnd = 718495, XrefRangeStart = 718481, XrefRangeEnd = 718493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3Int GetRotatedPos(Vector3Int original, int rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&original);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotatedPos_Public_Vector3Int_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718498, RefRangeEnd = 718499, XrefRangeStart = 718495, XrefRangeEnd = 718498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuleTile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuleTile>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RuleTile(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
