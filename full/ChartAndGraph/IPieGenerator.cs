using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ChartAndGraph;

public class IPieGenerator : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Void_Single_Single_Single_Single_Int32_Single_Single_0;

	static IPieGenerator()
	{
		Il2CppClassPointerStore<IPieGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ChartAndGraph", "IPieGenerator");
		NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Void_Single_Single_Single_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPieGenerator>.NativeClassPtr, 100670391);
	}

	[CallerCount(0)]
	public unsafe virtual void Generate(float startAngle, float angleSpan, float radius, float innerRadius, int segments, float outerDepth, float innerDepth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = (nint)(&startAngle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &angleSpan;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &innerRadius;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &segments;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &outerDepth;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &innerDepth;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Void_Single_Single_Single_Single_Int32_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IPieGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}
