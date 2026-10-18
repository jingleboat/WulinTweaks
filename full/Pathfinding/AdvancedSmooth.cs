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

namespace Pathfinding;

[System.Serializable]
public class AdvancedSmooth : MonoModifier
{
	[System.Serializable]
	public class MaxTurn : TurnConstructor
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preRightCircleCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_preLeftCircleCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightCircleCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftCircleCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_vaRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_vaLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_preVaLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_preVaRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_gammaLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_gammaRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_betaRightRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_betaRightLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_betaLeftRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_betaLeftLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaRightLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaLeftRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_alfaRightRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_alfaLeftLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_alfaRightLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_alfaLeftRight;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnTangentUpdate_Public_Virtual_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Int32_Il2CppStructArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TangentToTangent_Public_Virtual_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PointToTangent_Public_Virtual_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TangentToPoint_Public_Virtual_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_Virtual_Void_Turn_List_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 preRightCircleCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preRightCircleCenter);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preRightCircleCenter)) = vector;
			}
		}

		public unsafe Vector3 preLeftCircleCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preLeftCircleCenter);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preLeftCircleCenter)) = vector;
			}
		}

		public unsafe Vector3 rightCircleCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightCircleCenter);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightCircleCenter)) = vector;
			}
		}

		public unsafe Vector3 leftCircleCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftCircleCenter);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftCircleCenter)) = vector;
			}
		}

		public unsafe double vaRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vaRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vaRight)) = num;
			}
		}

		public unsafe double vaLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vaLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vaLeft)) = num;
			}
		}

		public unsafe double preVaLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preVaLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preVaLeft)) = num;
			}
		}

		public unsafe double preVaRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preVaRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preVaRight)) = num;
			}
		}

		public unsafe double gammaLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gammaLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gammaLeft)) = num;
			}
		}

		public unsafe double gammaRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gammaRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gammaRight)) = num;
			}
		}

		public unsafe double betaRightRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaRightRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaRightRight)) = num;
			}
		}

		public unsafe double betaRightLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaRightLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaRightLeft)) = num;
			}
		}

		public unsafe double betaLeftRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaLeftRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaLeftRight)) = num;
			}
		}

		public unsafe double betaLeftLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaLeftLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betaLeftLeft)) = num;
			}
		}

		public unsafe double deltaRightLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaRightLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaRightLeft)) = num;
			}
		}

		public unsafe double deltaLeftRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaLeftRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaLeftRight)) = num;
			}
		}

		public unsafe double alfaRightRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaRightRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaRightRight)) = num;
			}
		}

		public unsafe double alfaLeftLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaLeftLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaLeftLeft)) = num;
			}
		}

		public unsafe double alfaRightLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaRightLeft);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaRightLeft)) = num;
			}
		}

		public unsafe double alfaLeftRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaLeftRight);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alfaLeftRight)) = num;
			}
		}

		static MaxTurn()
		{
			Il2CppClassPointerStore<MaxTurn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "MaxTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr);
			NativeFieldInfoPtr_preRightCircleCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "preRightCircleCenter");
			NativeFieldInfoPtr_preLeftCircleCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "preLeftCircleCenter");
			NativeFieldInfoPtr_rightCircleCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "rightCircleCenter");
			NativeFieldInfoPtr_leftCircleCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "leftCircleCenter");
			NativeFieldInfoPtr_vaRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "vaRight");
			NativeFieldInfoPtr_vaLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "vaLeft");
			NativeFieldInfoPtr_preVaLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "preVaLeft");
			NativeFieldInfoPtr_preVaRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "preVaRight");
			NativeFieldInfoPtr_gammaLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "gammaLeft");
			NativeFieldInfoPtr_gammaRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "gammaRight");
			NativeFieldInfoPtr_betaRightRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "betaRightRight");
			NativeFieldInfoPtr_betaRightLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "betaRightLeft");
			NativeFieldInfoPtr_betaLeftRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "betaLeftRight");
			NativeFieldInfoPtr_betaLeftLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "betaLeftLeft");
			NativeFieldInfoPtr_deltaRightLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "deltaRightLeft");
			NativeFieldInfoPtr_deltaLeftRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "deltaLeftRight");
			NativeFieldInfoPtr_alfaRightRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "alfaRightRight");
			NativeFieldInfoPtr_alfaLeftLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "alfaLeftLeft");
			NativeFieldInfoPtr_alfaRightLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "alfaRightLeft");
			NativeFieldInfoPtr_alfaLeftRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, "alfaLeftRight");
			NativeMethodInfoPtr_OnTangentUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689507);
			NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689508);
			NativeMethodInfoPtr_TangentToTangent_Public_Virtual_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689509);
			NativeMethodInfoPtr_PointToTangent_Public_Virtual_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689510);
			NativeMethodInfoPtr_TangentToPoint_Public_Virtual_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689511);
			NativeMethodInfoPtr_GetPath_Public_Virtual_Void_Turn_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689512);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr, 100689513);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073556, XrefRangeEnd = 1073566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTangentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnTangentUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073566, XrefRangeEnd = 1073576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(int i, Il2CppStructArray<Vector3> vectorPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vectorPath);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Int32_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073576, XrefRangeEnd = 1073692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TangentToTangent(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TangentToTangent_Public_Virtual_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073692, XrefRangeEnd = 1073739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PointToTangent(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PointToTangent_Public_Virtual_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073739, XrefRangeEnd = 1073778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TangentToPoint(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TangentToPoint_Public_Virtual_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073778, XrefRangeEnd = 1073813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetPath(Turn turn, List<Vector3> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)turn));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPath_Public_Virtual_Void_Turn_List_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073819, RefRangeEnd = 1073820, XrefRangeStart = 1073813, XrefRangeEnd = 1073819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaxTurn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxTurn>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaxTurn(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ConstantTurn : TurnConstructor
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_circleCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_gamma1;

		private static readonly System.IntPtr NativeFieldInfoPtr_gamma2;

		private static readonly System.IntPtr NativeFieldInfoPtr_clockwise;

		private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Int32_Il2CppStructArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TangentToTangent_Public_Virtual_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_Virtual_Void_Turn_List_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 circleCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_circleCenter);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_circleCenter)) = vector;
			}
		}

		public unsafe double gamma1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamma1);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamma1)) = num;
			}
		}

		public unsafe double gamma2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamma2);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamma2)) = num;
			}
		}

		public unsafe bool clockwise
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clockwise);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clockwise)) = flag;
			}
		}

		static ConstantTurn()
		{
			Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "ConstantTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr);
			NativeFieldInfoPtr_circleCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, "circleCenter");
			NativeFieldInfoPtr_gamma1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, "gamma1");
			NativeFieldInfoPtr_gamma2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, "gamma2");
			NativeFieldInfoPtr_clockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, "clockwise");
			NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, 100689514);
			NativeMethodInfoPtr_TangentToTangent_Public_Virtual_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, 100689515);
			NativeMethodInfoPtr_GetPath_Public_Virtual_Void_Turn_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, 100689516);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr, 100689517);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(int i, Il2CppStructArray<Vector3> vectorPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vectorPath);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Int32_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073820, XrefRangeEnd = 1073853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TangentToTangent(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TangentToTangent_Public_Virtual_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073853, XrefRangeEnd = 1073875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetPath(Turn turn, List<Vector3> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)turn));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPath_Public_Virtual_Void_Turn_List_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073879, RefRangeEnd = 1073880, XrefRangeStart = 1073875, XrefRangeEnd = 1073879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantTurn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantTurn>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ConstantTurn(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TurnConstructor : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_constantBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_factorBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_turningRadius;

		private static readonly System.IntPtr NativeFieldInfoPtr_ThreeSixtyRadians;

		private static readonly System.IntPtr NativeFieldInfoPtr_prev;

		private static readonly System.IntPtr NativeFieldInfoPtr_current;

		private static readonly System.IntPtr NativeFieldInfoPtr_next;

		private static readonly System.IntPtr NativeFieldInfoPtr_t1;

		private static readonly System.IntPtr NativeFieldInfoPtr_t2;

		private static readonly System.IntPtr NativeFieldInfoPtr_normal;

		private static readonly System.IntPtr NativeFieldInfoPtr_prevNormal;

		private static readonly System.IntPtr NativeFieldInfoPtr_changedPreviousTangent;

		private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Abstract_Virtual_New_Void_Int32_Il2CppStructArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnTangentUpdate_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PointToTangent_Public_Virtual_New_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TangentToPoint_Public_Virtual_New_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TangentToTangent_Public_Virtual_New_Void_List_1_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_Abstract_Virtual_New_Void_Turn_List_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Static_Void_Int32_Il2CppStructArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PostPrepare_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddCircleSegment_Public_Void_Double_Double_Boolean_Vector3_List_1_Vector3_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DebugCircleSegment_Public_Void_Vector3_Double_Double_Double_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DebugCircle_Public_Void_Vector3_Double_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLengthFromAngle_Public_Double_Double_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClockwiseAngle_Public_Double_Double_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CounterClockwiseAngle_Public_Double_Double_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AngleToVector_Public_Vector3_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToDegrees_Public_Double_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Public_Double_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Atan2_Public_Double_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		public unsafe float constantBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBias)) = num;
			}
		}

		public unsafe float factorBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factorBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factorBias)) = num;
			}
		}

		public unsafe static float turningRadius
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_turningRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_turningRadius, (void*)(&num));
			}
		}

		public unsafe static double ThreeSixtyRadians
		{
			get
			{
				Unsafe.SkipInit(out double result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ThreeSixtyRadians, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ThreeSixtyRadians, (void*)(&num));
			}
		}

		public unsafe static Vector3 prev
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_prev, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_prev, (void*)(&vector));
			}
		}

		public unsafe static Vector3 current
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_current, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_current, (void*)(&vector));
			}
		}

		public unsafe static Vector3 next
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_next, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_next, (void*)(&vector));
			}
		}

		public unsafe static Vector3 t1
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_t1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_t1, (void*)(&vector));
			}
		}

		public unsafe static Vector3 t2
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_t2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_t2, (void*)(&vector));
			}
		}

		public unsafe static Vector3 normal
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_normal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_normal, (void*)(&vector));
			}
		}

		public unsafe static Vector3 prevNormal
		{
			get
			{
				Unsafe.SkipInit(out Vector3 result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_prevNormal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_prevNormal, (void*)(&vector));
			}
		}

		public unsafe static bool changedPreviousTangent
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_changedPreviousTangent, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_changedPreviousTangent, (void*)(&flag));
			}
		}

		static TurnConstructor()
		{
			Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "TurnConstructor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr);
			NativeFieldInfoPtr_constantBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "constantBias");
			NativeFieldInfoPtr_factorBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "factorBias");
			NativeFieldInfoPtr_turningRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "turningRadius");
			NativeFieldInfoPtr_ThreeSixtyRadians = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "ThreeSixtyRadians");
			NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "prev");
			NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "current");
			NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "next");
			NativeFieldInfoPtr_t1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "t1");
			NativeFieldInfoPtr_t2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "t2");
			NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "normal");
			NativeFieldInfoPtr_prevNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "prevNormal");
			NativeFieldInfoPtr_changedPreviousTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, "changedPreviousTangent");
			NativeMethodInfoPtr_Prepare_Public_Abstract_Virtual_New_Void_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689518);
			NativeMethodInfoPtr_OnTangentUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689519);
			NativeMethodInfoPtr_PointToTangent_Public_Virtual_New_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689520);
			NativeMethodInfoPtr_TangentToPoint_Public_Virtual_New_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689521);
			NativeMethodInfoPtr_TangentToTangent_Public_Virtual_New_Void_List_1_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689522);
			NativeMethodInfoPtr_GetPath_Public_Abstract_Virtual_New_Void_Turn_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689523);
			NativeMethodInfoPtr_Setup_Public_Static_Void_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689524);
			NativeMethodInfoPtr_PostPrepare_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689525);
			NativeMethodInfoPtr_AddCircleSegment_Public_Void_Double_Double_Boolean_Vector3_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689526);
			NativeMethodInfoPtr_DebugCircleSegment_Public_Void_Vector3_Double_Double_Double_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689527);
			NativeMethodInfoPtr_DebugCircle_Public_Void_Vector3_Double_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689528);
			NativeMethodInfoPtr_GetLengthFromAngle_Public_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689529);
			NativeMethodInfoPtr_ClockwiseAngle_Public_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689530);
			NativeMethodInfoPtr_CounterClockwiseAngle_Public_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689531);
			NativeMethodInfoPtr_AngleToVector_Public_Vector3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689532);
			NativeMethodInfoPtr_ToDegrees_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689533);
			NativeMethodInfoPtr_ClampAngle_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689534);
			NativeMethodInfoPtr_Atan2_Public_Double_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689535);
			NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr, 100689536);
		}

		[CallerCount(0)]
		public unsafe virtual void Prepare(int i, Il2CppStructArray<Vector3> vectorPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vectorPath);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Prepare_Public_Abstract_Virtual_New_Void_Int32_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTangentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnTangentUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PointToTangent(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PointToTangent_Public_Virtual_New_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TangentToPoint(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TangentToPoint_Public_Virtual_New_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(12001)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 12025, XrefRangeStart = 24, XrefRangeEnd = 12025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TangentToTangent(List<Turn> turnList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TangentToTangent_Public_Virtual_New_Void_List_1_Turn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual void GetPath(Turn turn, List<Vector3> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)turn));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPath_Public_Abstract_Virtual_New_Void_Turn_List_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073905, RefRangeEnd = 1073906, XrefRangeStart = 1073880, XrefRangeEnd = 1073905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Setup(int i, Il2CppStructArray<Vector3> vectorPath)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vectorPath);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Static_Void_Int32_Il2CppStructArray_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073910, RefRangeEnd = 1073911, XrefRangeStart = 1073906, XrefRangeEnd = 1073910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostPrepare()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostPrepare_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1073934, RefRangeEnd = 1073940, XrefRangeStart = 1073911, XrefRangeEnd = 1073934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCircleSegment(double startAngle, double endAngle, bool clockwise, Vector3 center, List<Vector3> output, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&startAngle);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &endAngle;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clockwise;
			*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCircleSegment_Public_Void_Double_Double_Boolean_Vector3_List_1_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073940, XrefRangeEnd = 1073964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugCircleSegment(Vector3 center, double startAngle, double endAngle, double radius, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&center);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startAngle;
			*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endAngle;
			*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
			*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugCircleSegment_Public_Void_Vector3_Double_Double_Double_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073964, XrefRangeEnd = 1073981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugCircle(Vector3 center, double radius, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&center);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
			*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugCircle_Public_Void_Vector3_Double_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe double GetLengthFromAngle(double angle, double radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&angle);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLengthFromAngle_Public_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe double ClockwiseAngle(double from, double to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&from);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClockwiseAngle_Public_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe double CounterClockwiseAngle(double from, double to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&from);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CounterClockwiseAngle_Public_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073981, XrefRangeEnd = 1073986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 AngleToVector(double a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&a);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleToVector_Public_Vector3_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe double ToDegrees(double rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&rad);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDegrees_Public_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe double ClampAngle(double a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&a);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle_Public_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073986, XrefRangeEnd = 1073990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Atan2(Vector3 v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&v);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan2_Public_Double_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073990, XrefRangeEnd = 1073991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TurnConstructor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnConstructor>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TurnConstructor(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class Turn : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_length;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_constructor;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_score_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_TurnConstructor_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_Void_List_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Turn_Turn_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Turn_Turn_0;

		public unsafe float length
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length)) = num;
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe TurnConstructor constructor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TurnConstructor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnConstructor));
			}
		}

		public unsafe float score
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_score_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static Turn()
		{
			Il2CppClassPointerStore<Turn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "Turn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Turn>.NativeClassPtr);
			NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Turn>.NativeClassPtr, "length");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Turn>.NativeClassPtr, "id");
			NativeFieldInfoPtr_constructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Turn>.NativeClassPtr, "constructor");
			NativeMethodInfoPtr_get_score_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Turn>.NativeClassPtr, 100689538);
			NativeMethodInfoPtr__ctor_Public_Void_Single_TurnConstructor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Turn>.NativeClassPtr, 100689539);
			NativeMethodInfoPtr_GetPath_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Turn>.NativeClassPtr, 100689540);
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Turn>.NativeClassPtr, 100689541);
			NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Turn_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Turn>.NativeClassPtr, 100689542);
			NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Turn_Turn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Turn>.NativeClassPtr, 100689543);
		}

		[CallerCount(0)]
		public unsafe Turn(float length, TurnConstructor constructor, int id = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Turn>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&length);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructor);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_TurnConstructor_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073991, RefRangeEnd = 1073992, XrefRangeStart = 1073991, XrefRangeEnd = 1073991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPath(List<Vector3> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPath_Public_Void_List_1_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual int CompareTo(Turn t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)t));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Turn_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe static bool operator <(Turn lhs, Turn rhs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lhs));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Turn_Turn_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe static bool operator >(Turn lhs, Turn rhs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lhs));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Turn_Turn_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public Turn(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Turn()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Turn>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_turningRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnConstruct1;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnConstruct2;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluatePaths_Private_Void_List_1_Turn_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float turningRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turningRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turningRadius)) = num;
		}
	}

	public unsafe MaxTurn turnConstruct1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnConstruct1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaxTurn>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnConstruct1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)maxTurn));
		}
	}

	public unsafe ConstantTurn turnConstruct2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnConstruct2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstantTurn>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnConstruct2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constantTurn));
		}
	}

	public unsafe override int Order
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static AdvancedSmooth()
	{
		Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "AdvancedSmooth");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr);
		NativeFieldInfoPtr_turningRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "turningRadius");
		NativeFieldInfoPtr_turnConstruct1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "turnConstruct1");
		NativeFieldInfoPtr_turnConstruct2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, "turnConstruct2");
		NativeMethodInfoPtr_get_Order_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, 100683558);
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, 100683559);
		NativeMethodInfoPtr_EvaluatePaths_Private_Void_List_1_Turn_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, 100683560);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr, 100683561);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073992, XrefRangeEnd = 1074024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply(Path p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_Path_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074039, RefRangeEnd = 1074041, XrefRangeStart = 1074024, XrefRangeEnd = 1074039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EvaluatePaths(List<Turn> turnList, List<Vector3> output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)turnList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluatePaths_Private_Void_List_1_Turn_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074041, XrefRangeEnd = 1074050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdvancedSmooth()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedSmooth>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AdvancedSmooth(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
