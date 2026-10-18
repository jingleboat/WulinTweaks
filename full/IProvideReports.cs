using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IProvideReports : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetReports_Public_Abstract_Virtual_New_List_1_IssueReport_0;

	static IProvideReports()
	{
		Il2CppClassPointerStore<IProvideReports>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IProvideReports");
		NativeMethodInfoPtr_GetReports_Public_Abstract_Virtual_New_List_1_IssueReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProvideReports>.NativeClassPtr, 100664137);
	}

	[CallerCount(0)]
	public unsafe virtual List<IssueReport> GetReports()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetReports_Public_Abstract_Virtual_New_List_1_IssueReport_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<IssueReport>>(intPtr) : null;
	}

	public IProvideReports(IntPtr pointer)
		: base(pointer)
	{
	}
}
