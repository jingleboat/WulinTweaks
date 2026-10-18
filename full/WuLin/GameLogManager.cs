using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class GameLogManager : MonoSingleton<GameLogManager>
{
	public class ILogInfo : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_Abstract_Virtual_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Abstract_Virtual_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Abstract_Virtual_New_LogItemType_0;

		static ILogInfo()
		{
			Il2CppClassPointerStore<ILogInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "ILogInfo");
			NativeMethodInfoPtr_GetLog_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogInfo>.NativeClassPtr, 100686606);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogInfo>.NativeClassPtr, 100686607);
			NativeMethodInfoPtr_GetChatLogType_Public_Abstract_Virtual_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogInfo>.NativeClassPtr, 100686608);
		}

		[CallerCount(0)]
		public unsafe virtual string GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLog_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NeedShowOldLog_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetChatLogType_Public_Abstract_Virtual_New_LogItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public ILogInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class DLC1Report : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Message;

		private static readonly System.IntPtr NativeFieldInfoPtr_MessageIgnHead;

		private static readonly System.IntPtr NativeFieldInfoPtr_Title;

		private static readonly System.IntPtr NativeFieldInfoPtr_EventClose;

		private static readonly System.IntPtr NativeFieldInfoPtr_roundCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeReported;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRound_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_String_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTitle_Public_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe string Message
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string MessageIgnHead
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MessageIgnHead);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MessageIgnHead)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string Title
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Title)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppSystem.Action EventClose
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EventClose);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EventClose)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe int roundCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundCount)) = num;
			}
		}

		public unsafe Il2CppSystem.DateTime timeReported
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeReported);
				return *(Il2CppSystem.DateTime*)num;
			}
			set
			{
				*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeReported)) = dateTime;
			}
		}

		static DLC1Report()
		{
			Il2CppClassPointerStore<DLC1Report>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "DLC1Report");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr);
			NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, "Message");
			NativeFieldInfoPtr_MessageIgnHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, "MessageIgnHead");
			NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, "Title");
			NativeFieldInfoPtr_EventClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, "EventClose");
			NativeFieldInfoPtr_roundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, "roundCount");
			NativeFieldInfoPtr_timeReported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, "timeReported");
			NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686609);
			NativeMethodInfoPtr_GetRound_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686610);
			NativeMethodInfoPtr_GetLog_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686611);
			NativeMethodInfoPtr_GetLog_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686612);
			NativeMethodInfoPtr_GetTitle_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686613);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686614);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr, 100686615);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 822256, RefRangeEnd = 822260, XrefRangeStart = 822236, XrefRangeEnd = 822256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC1Report(string msg, string title = "", Il2CppSystem.Action eventClose = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventClose);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int GetRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRound_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual string GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLog_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 822260, RefRangeEnd = 822262, XrefRangeStart = 822260, XrefRangeEnd = 822260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLog(bool ignHead = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&ignHead);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLog_Public_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 13952, RefRangeEnd = 13960, XrefRangeStart = 13952, XrefRangeEnd = 13960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTitle_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 26795, RefRangeEnd = 26824, XrefRangeStart = 26795, XrefRangeEnd = 26824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public DLC1Report(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DLC1Report()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1Report>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct TeamExpInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		[FieldOffset(0)]
		public int value;

		static TeamExpInfo()
		{
			Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "TeamExpInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr);
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr, "value");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr, 100686616);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr, 100686617);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr, 100686618);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822262, XrefRangeEnd = 822274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeamExpInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct TeamKungfuExpInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		[FieldOffset(0)]
		public int value;

		static TeamKungfuExpInfo()
		{
			Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "TeamKungfuExpInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr);
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr, "value");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr, 100686619);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr, 100686620);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr, 100686621);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822274, XrefRangeEnd = 822287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeamKungfuExpInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class CharacterLevelUpInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_characterInstance;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe GameCharacterInstance characterInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		static CharacterLevelUpInfo()
		{
			Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "CharacterLevelUpInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr);
			NativeFieldInfoPtr_characterInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr, "characterInstance");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr, 100686622);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr, 100686623);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr, 100686624);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822287, XrefRangeEnd = 822300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public CharacterLevelUpInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CharacterLevelUpInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterLevelUpInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class KungfuGetExpInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_expAmount;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe KungfuInstance kungfuInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
			}
		}

		public unsafe int expAmount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expAmount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expAmount)) = num;
			}
		}

		static KungfuGetExpInfo()
		{
			Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "KungfuGetExpInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr);
			NativeFieldInfoPtr_kungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr, "kungfuInstance");
			NativeFieldInfoPtr_expAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr, "expAmount");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr, 100686625);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr, 100686626);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr, 100686627);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822300, XrefRangeEnd = 822314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public KungfuGetExpInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public KungfuGetExpInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KungfuGetExpInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class KungfuLevelUpInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kungfuInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_isNewKungfu;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe KungfuInstance kungfuInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KungfuInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kungfuInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kungfuInstance));
			}
		}

		public unsafe bool isNewKungfu
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNewKungfu);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNewKungfu)) = flag;
			}
		}

		static KungfuLevelUpInfo()
		{
			Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "KungfuLevelUpInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr);
			NativeFieldInfoPtr_kungfuInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr, "kungfuInstance");
			NativeFieldInfoPtr_isNewKungfu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr, "isNewKungfu");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr, 100686628);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr, 100686629);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr, 100686630);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822314, XrefRangeEnd = 822359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public KungfuLevelUpInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public KungfuLevelUpInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KungfuLevelUpInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class SimpleLocInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_logKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_paras;

		private static readonly System.IntPtr NativeFieldInfoPtr_dontShowOldLog;

		private static readonly System.IntPtr NativeFieldInfoPtr_ChatLogType;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetParas_Public_Void_Il2CppReferenceArray_1_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe string logKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppReferenceArray<Il2CppSystem.Object> paras
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paras);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paras)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe bool dontShowOldLog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontShowOldLog);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontShowOldLog)) = flag;
			}
		}

		public unsafe LogItemType ChatLogType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatLogType);
				return *(LogItemType*)num;
			}
			set
			{
				*(LogItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatLogType)) = logItemType;
			}
		}

		static SimpleLocInfo()
		{
			Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "SimpleLocInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr);
			NativeFieldInfoPtr_logKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, "logKey");
			NativeFieldInfoPtr_paras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, "paras");
			NativeFieldInfoPtr_dontShowOldLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, "dontShowOldLog");
			NativeFieldInfoPtr_ChatLogType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, "ChatLogType");
			NativeMethodInfoPtr_SetParas_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, 100686631);
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, 100686632);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, 100686633);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr, 100686634);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 245415, RefRangeEnd = 245419, XrefRangeStart = 245415, XrefRangeEnd = 245419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParas([Optional] Il2CppReferenceArray<Il2CppSystem.Object> paras)
		{
			if (paras == null)
			{
				paras = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParas_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822359, XrefRangeEnd = 822374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public void SetParas(params Il2CppSystem.Object[] paras)
		{
			SetParas(new Il2CppReferenceArray<Il2CppSystem.Object>(paras));
		}

		public SimpleLocInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SimpleLocInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleLocInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class CharacterRelationInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_characterInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_oldRelation;

		private static readonly System.IntPtr NativeFieldInfoPtr_newRelation;

		private static readonly System.IntPtr NativeFieldInfoPtr_logKey;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe GameCharacterInstance characterInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCharacterInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCharacterInstance));
			}
		}

		public unsafe int oldRelation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldRelation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldRelation)) = num;
			}
		}

		public unsafe int newRelation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newRelation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newRelation)) = num;
			}
		}

		public unsafe string logKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static CharacterRelationInfo()
		{
			Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "CharacterRelationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr);
			NativeFieldInfoPtr_characterInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, "characterInstance");
			NativeFieldInfoPtr_oldRelation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, "oldRelation");
			NativeFieldInfoPtr_newRelation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, "newRelation");
			NativeFieldInfoPtr_logKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, "logKey");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, 100686635);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, 100686636);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr, 100686637);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822374, XrefRangeEnd = 822412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public CharacterRelationInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CharacterRelationInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterRelationInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class FactionFameInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_factionInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_oldFame;

		private static readonly System.IntPtr NativeFieldInfoPtr_newFame;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe FactionInstance factionInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionInstance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionInstance>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factionInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factionInstance));
			}
		}

		public unsafe int oldFame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldFame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldFame)) = num;
			}
		}

		public unsafe int newFame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFame)) = num;
			}
		}

		static FactionFameInfo()
		{
			Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "FactionFameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr);
			NativeFieldInfoPtr_factionInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr, "factionInstance");
			NativeFieldInfoPtr_oldFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr, "oldFame");
			NativeFieldInfoPtr_newFame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr, "newFame");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr, 100686638);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr, 100686639);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr, 100686640);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822412, XrefRangeEnd = 822451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public FactionFameInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FactionFameInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionFameInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class ActorPropModifiedInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actor;

		private static readonly System.IntPtr NativeFieldInfoPtr_battleActorPropModifies;

		private static readonly System.IntPtr NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		public unsafe BattleActor actor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
			}
		}

		public unsafe Dictionary<BattleActor.BattleActorPropTypes, BattleActor.BattleActorPropModify> battleActorPropModifies
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorPropModifies);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor.BattleActorPropTypes, BattleActor.BattleActorPropModify>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battleActorPropModifies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static ActorPropModifiedInfo()
		{
			Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "ActorPropModifiedInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr);
			NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr, "actor");
			NativeFieldInfoPtr_battleActorPropModifies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr, "battleActorPropModifies");
			NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr, 100686641);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr, 100686642);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr, 100686643);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822451, XrefRangeEnd = 822453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WuLin_GameLogManager_ILogInfo_GetLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WuLin_GameLogManager_ILogInfo_GetLog_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24949, RefRangeEnd = 24971, XrefRangeStart = 24949, XrefRangeEnd = 24971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public ActorPropModifiedInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ActorPropModifiedInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorPropModifiedInfo>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AchvInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_achvId;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_Virtual_Final_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0;

		[FieldOffset(0)]
		public int achvId;

		static AchvInfo()
		{
			Il2CppClassPointerStore<AchvInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "AchvInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchvInfo>.NativeClassPtr);
			NativeFieldInfoPtr_achvId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchvInfo>.NativeClassPtr, "achvId");
			NativeMethodInfoPtr_GetLog_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchvInfo>.NativeClassPtr, 100686644);
			NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchvInfo>.NativeClassPtr, 100686645);
			NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchvInfo>.NativeClassPtr, 100686646);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822453, XrefRangeEnd = 822472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLog()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLog_Public_Virtual_Final_New_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 30872, RefRangeEnd = 30977, XrefRangeStart = 30872, XrefRangeEnd = 30977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NeedShowOldLog()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedShowOldLog_Public_Virtual_Final_New_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24971, RefRangeEnd = 24973, XrefRangeStart = 24971, XrefRangeEnd = 24973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LogItemType GetChatLogType()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChatLogType_Public_Virtual_Final_New_LogItemType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(LogItemType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchvInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_dlcShowOldLogRunTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_logInfoContainer;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLogContainer_Public_Void_List_1_ILogInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLogRaw_Public_Void_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameLogCurrency_Public_Void_Int64_GameLogType_Boolean_GameCharacterInstance_CurrencyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameLogItem_Public_Void_ItemData_Int32_GameLogType_Boolean_GameCharacterInstance_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameLogInfo_Public_Void_ILogInfo_GameLogType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool dlcShowOldLogRunTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlcShowOldLogRunTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlcShowOldLogRunTime)) = flag;
		}
	}

	public unsafe List<ILogInfo> logInfoContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logInfoContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ILogInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logInfoContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GameLogManager()
	{
		Il2CppClassPointerStore<GameLogManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "GameLogManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr);
		NativeFieldInfoPtr_dlcShowOldLogRunTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "dlcShowOldLogRunTime");
		NativeFieldInfoPtr_logInfoContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "logInfoContainer");
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672806);
		NativeMethodInfoPtr_SetLogContainer_Public_Void_List_1_ILogInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672807);
		NativeMethodInfoPtr_OnLogRaw_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672808);
		NativeMethodInfoPtr_GameLogCurrency_Public_Void_Int64_GameLogType_Boolean_GameCharacterInstance_CurrencyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672809);
		NativeMethodInfoPtr_GameLogItem_Public_Void_ItemData_Int32_GameLogType_Boolean_GameCharacterInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672810);
		NativeMethodInfoPtr_GameLogInfo_Public_Void_ILogInfo_GameLogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672811);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100672812);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822472, XrefRangeEnd = 822496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetLogContainer(List<ILogInfo> container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLogContainer_Public_Void_List_1_ILogInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822496, XrefRangeEnd = 822570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLogRaw(Il2CppReferenceArray<Il2CppSystem.Object> paras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paras);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLogRaw_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 822618, RefRangeEnd = 822619, XrefRangeStart = 822570, XrefRangeEnd = 822618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GameLogCurrency(long amount, GameLogType logType, bool isImportant = false, GameCharacterInstance characterInstance = null, CurrencyType currencyType = CurrencyType.Coin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&amount);
		*(GameLogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isImportant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInstance);
		*(CurrencyType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &currencyType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameLogCurrency_Public_Void_Int64_GameLogType_Boolean_GameCharacterInstance_CurrencyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 822657, RefRangeEnd = 822658, XrefRangeStart = 822619, XrefRangeEnd = 822657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GameLogItem(ItemData item, int amount, GameLogType logType, bool isImportant = false, GameCharacterInstance characterInstance = null, string spFormat = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(GameLogType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &logType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isImportant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInstance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(spFormat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameLogItem_Public_Void_ItemData_Int32_GameLogType_Boolean_GameCharacterInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822658, XrefRangeEnd = 822728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GameLogInfo(ILogInfo info, GameLogType logType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(GameLogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameLogInfo_Public_Void_ILogInfo_GameLogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822728, XrefRangeEnd = 822734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameLogManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameLogManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
