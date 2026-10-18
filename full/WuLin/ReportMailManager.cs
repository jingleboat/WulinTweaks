using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;

namespace WuLin;

public class ReportMailManager : MonoSingleton<ReportMailManager>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_senderSmtp;

	private static readonly System.IntPtr NativeFieldInfoPtr_senderAcount;

	private static readonly System.IntPtr NativeFieldInfoPtr_senderPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverAcount;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackCurrentGameSaves_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_List_1_String_List_1_String_Action_2_Boolean_AsyncCompletedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveAndSendMail_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string senderSmtp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_senderSmtp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_senderSmtp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string senderAcount
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_senderAcount, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_senderAcount, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string senderPassword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_senderPassword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_senderPassword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string receiverAcount
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_receiverAcount, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_receiverAcount, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ReportMailManager()
	{
		Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ReportMailManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr);
		NativeFieldInfoPtr_senderSmtp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, "senderSmtp");
		NativeFieldInfoPtr_senderAcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, "senderAcount");
		NativeFieldInfoPtr_senderPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, "senderPassword");
		NativeFieldInfoPtr_receiverAcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, "receiverAcount");
		NativeMethodInfoPtr_PackCurrentGameSaves_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, 100673369);
		NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_List_1_String_List_1_String_Action_2_Boolean_AsyncCompletedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, 100673370);
		NativeMethodInfoPtr_SaveAndSendMail_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, 100673371);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr, 100673372);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PackCurrentGameSaves()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackCurrentGameSaves_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMail(string subject, string body, List<string> attachments, List<string> _receivers, Il2CppSystem.Action<bool, AsyncCompletedEventArgs> onSend)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(subject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(body);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_receivers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onSend);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_List_1_String_List_1_String_Action_2_Boolean_AsyncCompletedEventArgs_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveAndSendMail(string subject, string body)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(subject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(body);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAndSendMail_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839081, XrefRangeEnd = 839087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReportMailManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportMailManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ReportMailManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
