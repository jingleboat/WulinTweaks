using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WuLin;

public class JoystickDlc1ForeignAffairsPoint : JoystickDlc1MoveBase
{
	private static readonly IntPtr NativeFieldInfoPtr_uiObj_point;

	private static readonly IntPtr NativeFieldInfoPtr__cachedComponent;

	private static readonly IntPtr NativeFieldInfoPtr__pointerEvent;

	private static readonly IntPtr NativeFieldInfoPtr__eventSystem;

	private static readonly IntPtr NativeMethodInfoPtr_VF_Awake_Protected_Virtual_Void_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_VF_pointPosition_Protected_Virtual_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateJoyStickVirtualPoint_Private_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_VF_pressADown_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_VF_releaseAxis_Protected_Virtual_Void_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetForeignPointInteractive_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject uiObj_point
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiObj_point);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiObj_point)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject _cachedComponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedComponent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedComponent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe PointerEventData _pointerEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerEventData));
		}
	}

	public unsafe EventSystem _eventSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EventSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventSystem));
		}
	}

	static JoystickDlc1ForeignAffairsPoint()
	{
		Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "JoystickDlc1ForeignAffairsPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr);
		NativeFieldInfoPtr_uiObj_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, "uiObj_point");
		NativeFieldInfoPtr__cachedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, "_cachedComponent");
		NativeFieldInfoPtr__pointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, "_pointerEvent");
		NativeFieldInfoPtr__eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, "_eventSystem");
		NativeMethodInfoPtr_VF_Awake_Protected_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678888);
		NativeMethodInfoPtr_VF_pointPosition_Protected_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678889);
		NativeMethodInfoPtr_UpdateJoyStickVirtualPoint_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678890);
		NativeMethodInfoPtr_VF_pressADown_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678891);
		NativeMethodInfoPtr_VF_releaseAxis_Protected_Virtual_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678892);
		NativeMethodInfoPtr_SetForeignPointInteractive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678893);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr, 100678894);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987205, XrefRangeEnd = 987214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void VF_Awake(float maxWidth = 0f, float maxHeight = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&maxWidth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &maxHeight;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_VF_Awake_Protected_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987214, XrefRangeEnd = 987218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void VF_pointPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_VF_pointPosition_Protected_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 987262, RefRangeEnd = 987263, XrefRangeStart = 987218, XrefRangeEnd = 987262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateJoyStickVirtualPoint(Vector2 inputPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&inputPos);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateJoyStickVirtualPoint_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987263, XrefRangeEnd = 987271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void VF_pressADown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_VF_pressADown_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12001)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void VF_releaseAxis(Vector3 targetPos, float recoverTime = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&targetPos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &recoverTime;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_VF_releaseAxis_Protected_Virtual_Void_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 987273, RefRangeEnd = 987277, XrefRangeStart = 987271, XrefRangeEnd = 987273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForeignPointInteractive(bool isActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isActive);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForeignPointInteractive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987277, XrefRangeEnd = 987278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JoystickDlc1ForeignAffairsPoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickDlc1ForeignAffairsPoint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public JoystickDlc1ForeignAffairsPoint(IntPtr pointer)
		: base(pointer)
	{
	}
}
