using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace WuLin.Defines;

public class GTDefine : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AssetPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_RealNameURL;

	private static readonly System.IntPtr NativeFieldInfoPtr_V_INTERVAL_FINDENEMY;

	private static readonly System.IntPtr NativeFieldInfoPtr_V_INTERVAL_VALUE;

	private static readonly System.IntPtr NativeFieldInfoPtr_V_DAMAGE_RATIO;

	private static readonly System.IntPtr NativeFieldInfoPtr_V_SEARCH_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlineTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_RECOVER_COST_ITEM_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_RECOVER_COST_ITEM_NUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_Gold;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_Shishi;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_white;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_bule;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_violet;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_yellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_grey;

	private static readonly System.IntPtr NativeFieldInfoPtr_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_yellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_bule;

	private static readonly System.IntPtr NativeFieldInfoPtr_orange;

	private static readonly System.IntPtr NativeFieldInfoPtr_white;

	private static readonly System.IntPtr NativeFieldInfoPtr_violet;

	private static readonly System.IntPtr NativeFieldInfoPtr_grey;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_Yang;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_YangOrYin;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color_Yin;

	private static readonly System.IntPtr NativeFieldInfoPtr_Anilist;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForgeTypeList;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoopAnimationList_Public_Static_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForgeTypeList_Public_Static_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextColor_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringColor_Public_Static_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemColor_Public_Static_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIconColor_Public_Static_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRole_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerState_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEquPosition_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGold_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAllGold_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HMACSHA1Text_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValidationResult_Public_Static_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertDateTimeToInt_Public_Static_Int64_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearnTransfrom_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationStr_Public_Static_String_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FeelingWithPlayer_Public_Static_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string AssetPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AssetPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AssetPath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RealNameURL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RealNameURL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RealNameURL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static float V_INTERVAL_FINDENEMY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_V_INTERVAL_FINDENEMY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_V_INTERVAL_FINDENEMY, (void*)(&num));
		}
	}

	public unsafe static float V_INTERVAL_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_V_INTERVAL_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_V_INTERVAL_VALUE, (void*)(&num));
		}
	}

	public unsafe static float V_DAMAGE_RATIO
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_V_DAMAGE_RATIO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_V_DAMAGE_RATIO, (void*)(&num));
		}
	}

	public unsafe static float V_SEARCH_DISTANCE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_V_SEARCH_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_V_SEARCH_DISTANCE, (void*)(&num));
		}
	}

	public unsafe static int onlineTime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onlineTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onlineTime, (void*)(&num));
		}
	}

	public unsafe static int RECOVER_COST_ITEM_ID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RECOVER_COST_ITEM_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RECOVER_COST_ITEM_ID, (void*)(&num));
		}
	}

	public unsafe static int RECOVER_COST_ITEM_NUM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RECOVER_COST_ITEM_NUM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RECOVER_COST_ITEM_NUM, (void*)(&num));
		}
	}

	public unsafe static Color Color_Gold
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_Gold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_Gold, (void*)(&color));
		}
	}

	public unsafe static Color Color_Shishi
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_Shishi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_Shishi, (void*)(&color));
		}
	}

	public unsafe static Color Color_white
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_white, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_white, (void*)(&color));
		}
	}

	public unsafe static Color Color_green
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_green, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_green, (void*)(&color));
		}
	}

	public unsafe static Color Color_bule
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_bule, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_bule, (void*)(&color));
		}
	}

	public unsafe static Color Color_violet
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_violet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_violet, (void*)(&color));
		}
	}

	public unsafe static Color Color_yellow
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_yellow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_yellow, (void*)(&color));
		}
	}

	public unsafe static Color Color_red
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_red, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_red, (void*)(&color));
		}
	}

	public unsafe static Color Color_grey
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_grey, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_grey, (void*)(&color));
		}
	}

	public unsafe static string green
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_green, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_green, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string yellow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yellow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yellow, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string red
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_red, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_red, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string bule
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bule, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bule, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string orange
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_orange, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_orange, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string white
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_white, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_white, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string violet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_violet, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_violet, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string grey
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_grey, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_grey, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Color_Yang
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_Yang, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_Yang, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Color_YangOrYin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_YangOrYin, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_YangOrYin, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Color_Yin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color_Yin, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color_Yin, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> Anilist
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Anilist, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Anilist, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ForgeTypeList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForgeTypeList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForgeTypeList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GTDefine()
	{
		Il2CppClassPointerStore<GTDefine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin.Defines", "GTDefine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GTDefine>.NativeClassPtr);
		NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "AssetPath");
		NativeFieldInfoPtr_RealNameURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "RealNameURL");
		NativeFieldInfoPtr_V_INTERVAL_FINDENEMY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "V_INTERVAL_FINDENEMY");
		NativeFieldInfoPtr_V_INTERVAL_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "V_INTERVAL_VALUE");
		NativeFieldInfoPtr_V_DAMAGE_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "V_DAMAGE_RATIO");
		NativeFieldInfoPtr_V_SEARCH_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "V_SEARCH_DISTANCE");
		NativeFieldInfoPtr_onlineTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "onlineTime");
		NativeFieldInfoPtr_RECOVER_COST_ITEM_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "RECOVER_COST_ITEM_ID");
		NativeFieldInfoPtr_RECOVER_COST_ITEM_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "RECOVER_COST_ITEM_NUM");
		NativeFieldInfoPtr_Color_Gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_Gold");
		NativeFieldInfoPtr_Color_Shishi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_Shishi");
		NativeFieldInfoPtr_Color_white = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_white");
		NativeFieldInfoPtr_Color_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_green");
		NativeFieldInfoPtr_Color_bule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_bule");
		NativeFieldInfoPtr_Color_violet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_violet");
		NativeFieldInfoPtr_Color_yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_yellow");
		NativeFieldInfoPtr_Color_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_red");
		NativeFieldInfoPtr_Color_grey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_grey");
		NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "green");
		NativeFieldInfoPtr_yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "yellow");
		NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "red");
		NativeFieldInfoPtr_bule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "bule");
		NativeFieldInfoPtr_orange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "orange");
		NativeFieldInfoPtr_white = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "white");
		NativeFieldInfoPtr_violet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "violet");
		NativeFieldInfoPtr_grey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "grey");
		NativeFieldInfoPtr_Color_Yang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_Yang");
		NativeFieldInfoPtr_Color_YangOrYin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_YangOrYin");
		NativeFieldInfoPtr_Color_Yin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Color_Yin");
		NativeFieldInfoPtr_Anilist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "Anilist");
		NativeFieldInfoPtr_ForgeTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, "ForgeTypeList");
		NativeMethodInfoPtr_GetLoopAnimationList_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680760);
		NativeMethodInfoPtr_GetForgeTypeList_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680761);
		NativeMethodInfoPtr_GetTextColor_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680762);
		NativeMethodInfoPtr_GetStringColor_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680763);
		NativeMethodInfoPtr_GetItemColor_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680764);
		NativeMethodInfoPtr_GetIconColor_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680765);
		NativeMethodInfoPtr_GetRole_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680766);
		NativeMethodInfoPtr_GetPlayerState_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680767);
		NativeMethodInfoPtr_GetEquPosition_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680768);
		NativeMethodInfoPtr_GetGold_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680769);
		NativeMethodInfoPtr_ShowAllGold_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680770);
		NativeMethodInfoPtr_HMACSHA1Text_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680771);
		NativeMethodInfoPtr_CheckValidationResult_Public_Static_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680772);
		NativeMethodInfoPtr_ConvertDateTimeToInt_Public_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680773);
		NativeMethodInfoPtr_ClearnTransfrom_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680774);
		NativeMethodInfoPtr_GetRelationStr_Public_Static_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680775);
		NativeMethodInfoPtr_FeelingWithPlayer_Public_Static_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680776);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GTDefine>.NativeClassPtr, 100680777);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1030988, RefRangeEnd = 1030989, XrefRangeStart = 1030958, XrefRangeEnd = 1030988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetLoopAnimationList()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoopAnimationList_Public_Static_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1031019, RefRangeEnd = 1031026, XrefRangeStart = 1030989, XrefRangeEnd = 1031019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetForgeTypeList()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForgeTypeList_Public_Static_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031026, XrefRangeEnd = 1031030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTextColor(int Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextColor_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031030, XrefRangeEnd = 1031040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetStringColor(string Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(Type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringColor_Public_Static_Color_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031040, XrefRangeEnd = 1031044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetItemColor(int Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemColor_Public_Static_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031044, XrefRangeEnd = 1031048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetIconColor(int Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIconColor_Public_Static_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031048, XrefRangeEnd = 1031051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRole(int Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRole_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031051, XrefRangeEnd = 1031054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPlayerState(int PlayerState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&PlayerState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerState_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031054, XrefRangeEnd = 1031064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEquPosition(int Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquPosition_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031064, XrefRangeEnd = 1031075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGold(long gold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gold);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGold_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031075, XrefRangeEnd = 1031094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ShowAllGold(long gold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gold);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowAllGold_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031094, XrefRangeEnd = 1031106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string HMACSHA1Text(string EncryptText, string EncryptKey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(EncryptText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(EncryptKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HMACSHA1Text_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckValidationResult(Il2CppSystem.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(SslPolicyErrors**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &errors;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckValidationResult_Public_Static_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031106, XrefRangeEnd = 1031113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ConvertDateTimeToInt(Il2CppSystem.DateTime time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertDateTimeToInt_Public_Static_Int64_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031113, XrefRangeEnd = 1031123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearnTransfrom(Transform content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearnTransfrom_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1031143, RefRangeEnd = 1031144, XrefRangeStart = 1031123, XrefRangeEnd = 1031143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRelationStr(int relation, bool isKnow, bool withColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&relation);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isKnow;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &withColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelationStr_Public_Static_String_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1031188, RefRangeEnd = 1031192, XrefRangeStart = 1031144, XrefRangeEnd = 1031188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FeelingWithPlayer(int index, bool withColor = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withColor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FeelingWithPlayer_Public_Static_String_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GTDefine()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GTDefine>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GTDefine(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
