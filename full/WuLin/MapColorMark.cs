using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using WuLin.GameFrameworks;

namespace WuLin;

public class MapColorMark : GTSingleton<MapColorMark>
{
	public enum EM_MARK_LAYER
	{
		MOVE,
		SKILL
	}

	public enum EM_GROUND_COLOR
	{
		NONE,
		RED,
		GREEN,
		YELLOW,
		GRAY,
		TINT
	}

	public enum EM_PLAY_ANIMATION
	{
		NONE,
		SHOW,
		WALK
	}

	public class CWaitPlayData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mHashID;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_layer;

		private static readonly System.IntPtr NativeFieldInfoPtr_animationType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int mHashID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHashID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mHashID)) = num;
			}
		}

		public unsafe Vector3Int pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector3Int;
			}
		}

		public unsafe EM_MARK_LAYER layer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer);
				return *(EM_MARK_LAYER*)num;
			}
			set
			{
				*(EM_MARK_LAYER*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer)) = eM_MARK_LAYER;
			}
		}

		public unsafe EM_PLAY_ANIMATION animationType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationType);
				return *(EM_PLAY_ANIMATION*)num;
			}
			set
			{
				*(EM_PLAY_ANIMATION*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationType)) = eM_PLAY_ANIMATION;
			}
		}

		static CWaitPlayData()
		{
			Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "CWaitPlayData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr);
			NativeFieldInfoPtr_mHashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr, "mHashID");
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr, "layer");
			NativeFieldInfoPtr_animationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr, "animationType");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr, 100687360);
		}

		[CallerCount(2961)]
		[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CWaitPlayData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CWaitPlayData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CWaitPlayData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaskObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMapGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLayerMoveMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLayerSkillMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_mBattleAreaSideMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_mBattleTileSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_mBattleAreaCornerMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_mBattleTileCorner;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileLightMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMarkListMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMarkListSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_mWaitPlayData;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLayerTouchMark;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControlMethodChange_Private_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMark_Public_Boolean_Vector3Int_EM_MARK_LAYER_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowBattleArea_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideBattleArea_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBattleAreaPos_Public_Void_HashSet_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearBattleArea_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowTouch_Public_Void_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideTouch_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mark_Public_Void_HashSet_1_Vector3Int_EM_MARK_LAYER_EM_GROUND_COLOR_EM_PLAY_ANIMATION_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitPlay_Public_Void_Int32_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayAnimation_Private_Void_Vector3Int_EM_MARK_LAYER_EM_PLAY_ANIMATION_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopAnimation_Public_Void_Vector3Int_EM_MARK_LAYER_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initObj_Private_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorMarkPath_Private_String_EM_GROUND_COLOR_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_EM_MARK_LAYER_0;

	public unsafe GameObject MaskObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Tilemap mMapGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMapGround);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMapGround)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap));
		}
	}

	public unsafe GameObject mLayerMoveMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLayerMoveMark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLayerMoveMark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject mLayerSkillMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLayerSkillMark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLayerSkillMark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Tilemap mBattleAreaSideMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleAreaSideMark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleAreaSideMark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap));
		}
	}

	public unsafe RuleTile mBattleTileSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleTileSide);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RuleTile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleTileSide)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ruleTile));
		}
	}

	public unsafe Tilemap mBattleAreaCornerMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleAreaCornerMark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleAreaCornerMark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap));
		}
	}

	public unsafe RuleTile mBattleTileCorner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleTileCorner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RuleTile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mBattleTileCorner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ruleTile));
		}
	}

	public unsafe GameObject tileLightMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileLightMask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileLightMask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Dictionary<Vector3Int, GameObject> mMarkListMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMarkListMove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMarkListMove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Vector3Int, GameObject> mMarkListSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMarkListSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMarkListSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, CWaitPlayData> mWaitPlayData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mWaitPlayData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CWaitPlayData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mWaitPlayData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameObject mLayerTouchMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLayerTouchMark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLayerTouchMark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	static MapColorMark()
	{
		Il2CppClassPointerStore<MapColorMark>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "MapColorMark");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr);
		NativeFieldInfoPtr_MaskObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "MaskObject");
		NativeFieldInfoPtr_mMapGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mMapGround");
		NativeFieldInfoPtr_mLayerMoveMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mLayerMoveMark");
		NativeFieldInfoPtr_mLayerSkillMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mLayerSkillMark");
		NativeFieldInfoPtr_mBattleAreaSideMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mBattleAreaSideMark");
		NativeFieldInfoPtr_mBattleTileSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mBattleTileSide");
		NativeFieldInfoPtr_mBattleAreaCornerMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mBattleAreaCornerMark");
		NativeFieldInfoPtr_mBattleTileCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mBattleTileCorner");
		NativeFieldInfoPtr_tileLightMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "tileLightMask");
		NativeFieldInfoPtr_mMarkListMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mMarkListMove");
		NativeFieldInfoPtr_mMarkListSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mMarkListSkill");
		NativeFieldInfoPtr_mWaitPlayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mWaitPlayData");
		NativeFieldInfoPtr_mLayerTouchMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, "mLayerTouchMark");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674721);
		NativeMethodInfoPtr_OnControlMethodChange_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674722);
		NativeMethodInfoPtr_init_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674723);
		NativeMethodInfoPtr_IsMark_Public_Boolean_Vector3Int_EM_MARK_LAYER_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674724);
		NativeMethodInfoPtr_ShowBattleArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674725);
		NativeMethodInfoPtr_HideBattleArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674726);
		NativeMethodInfoPtr_AddBattleAreaPos_Public_Void_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674727);
		NativeMethodInfoPtr_ClearBattleArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674728);
		NativeMethodInfoPtr_ShowTouch_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674729);
		NativeMethodInfoPtr_HideTouch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674730);
		NativeMethodInfoPtr_Mark_Public_Void_HashSet_1_Vector3Int_EM_MARK_LAYER_EM_GROUND_COLOR_EM_PLAY_ANIMATION_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674731);
		NativeMethodInfoPtr_WaitPlay_Public_Void_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674732);
		NativeMethodInfoPtr_PlayAnimation_Private_Void_Vector3Int_EM_MARK_LAYER_EM_PLAY_ANIMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674733);
		NativeMethodInfoPtr_StopAnimation_Public_Void_Vector3Int_EM_MARK_LAYER_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674734);
		NativeMethodInfoPtr_initObj_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674735);
		NativeMethodInfoPtr_GetColorMarkPath_Private_String_EM_GROUND_COLOR_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674736);
		NativeMethodInfoPtr_Clear_Public_Void_EM_MARK_LAYER_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr, 100674737);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876376, XrefRangeEnd = 876598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapColorMark()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapColorMark>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876598, XrefRangeEnd = 876609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnControlMethodChange(Il2CppReferenceArray<Il2CppSystem.Object> arg0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnControlMethodChange_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876621, RefRangeEnd = 876622, XrefRangeStart = 876609, XrefRangeEnd = 876621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(GameObject mapobj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapobj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876625, RefRangeEnd = 876626, XrefRangeStart = 876622, XrefRangeEnd = 876625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsMark(Vector3Int pos, EM_MARK_LAYER layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(EM_MARK_LAYER**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMark_Public_Boolean_Vector3Int_EM_MARK_LAYER_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 876637, RefRangeEnd = 876639, XrefRangeStart = 876626, XrefRangeEnd = 876637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowBattleArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowBattleArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 876650, RefRangeEnd = 876652, XrefRangeStart = 876639, XrefRangeEnd = 876650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideBattleArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideBattleArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876675, RefRangeEnd = 876676, XrefRangeStart = 876652, XrefRangeEnd = 876675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBattleAreaPos(HashSet<Vector3Int> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBattleAreaPos_Public_Void_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876685, RefRangeEnd = 876686, XrefRangeStart = 876676, XrefRangeEnd = 876685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearBattleArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearBattleArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876686, XrefRangeEnd = 876696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTouch(Vector3Int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowTouch_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876696, XrefRangeEnd = 876701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideTouch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideTouch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 876839, RefRangeEnd = 876847, XrefRangeStart = 876701, XrefRangeEnd = 876839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Mark(HashSet<Vector3Int> poslist, EM_MARK_LAYER layer, EM_GROUND_COLOR color = EM_GROUND_COLOR.NONE, EM_PLAY_ANIMATION animationType = EM_PLAY_ANIMATION.NONE, float delaySecond = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poslist);
		*(EM_MARK_LAYER**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(EM_GROUND_COLOR**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(EM_PLAY_ANIMATION**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &animationType;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &delaySecond;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mark_Public_Void_HashSet_1_Vector3Int_EM_MARK_LAYER_EM_GROUND_COLOR_EM_PLAY_ANIMATION_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876847, XrefRangeEnd = 876867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WaitPlay(int timerID, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&timerID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitPlay_Public_Void_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876886, RefRangeEnd = 876887, XrefRangeStart = 876867, XrefRangeEnd = 876886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayAnimation(Vector3Int pos, EM_MARK_LAYER layer, EM_PLAY_ANIMATION type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pos);
		*(EM_MARK_LAYER**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(EM_PLAY_ANIMATION**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayAnimation_Private_Void_Vector3Int_EM_MARK_LAYER_EM_PLAY_ANIMATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 876957, RefRangeEnd = 876959, XrefRangeStart = 876887, XrefRangeEnd = 876957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopAnimation(Vector3Int pos, EM_MARK_LAYER layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(EM_MARK_LAYER**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopAnimation_Public_Void_Vector3Int_EM_MARK_LAYER_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876959, XrefRangeEnd = 876992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initObj(GameObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initObj_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 877011, RefRangeEnd = 877012, XrefRangeStart = 876992, XrefRangeEnd = 877011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetColorMarkPath(EM_GROUND_COLOR color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorMarkPath_Private_String_EM_GROUND_COLOR_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 877100, RefRangeEnd = 877108, XrefRangeStart = 877012, XrefRangeEnd = 877100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear(EM_MARK_LAYER layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_EM_MARK_LAYER_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MapColorMark(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
