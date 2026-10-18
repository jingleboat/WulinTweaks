using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace WuLin;

public class SaveObjectBountyHunter : SaveObjectBase
{
	public class TaskData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_taskID;

		private static readonly System.IntPtr NativeFieldInfoPtr_taskState;

		private static readonly System.IntPtr NativeFieldInfoPtr_acceptTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_closeTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreNum;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int taskID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskID)) = num;
			}
		}

		public unsafe TaskState taskState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskState);
				return *(TaskState*)num;
			}
			set
			{
				*(TaskState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskState)) = taskState;
			}
		}

		public unsafe int acceptTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceptTime);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceptTime)) = num;
			}
		}

		public unsafe int closeTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeTime);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeTime)) = num;
			}
		}

		public unsafe int ignoreNum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreNum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreNum)) = num;
			}
		}

		static TaskData()
		{
			Il2CppClassPointerStore<TaskData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, "TaskData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskData>.NativeClassPtr);
			NativeFieldInfoPtr_taskID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskData>.NativeClassPtr, "taskID");
			NativeFieldInfoPtr_taskState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskData>.NativeClassPtr, "taskState");
			NativeFieldInfoPtr_acceptTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskData>.NativeClassPtr, "acceptTime");
			NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskData>.NativeClassPtr, "closeTime");
			NativeFieldInfoPtr_ignoreNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskData>.NativeClassPtr, "ignoreNum");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskData>.NativeClassPtr, 100686918);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 813347, RefRangeEnd = 813350, XrefRangeStart = 813347, XrefRangeEnd = 813350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TaskData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class FactionTaskBoardData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_updateDay;

		private static readonly System.IntPtr NativeFieldInfoPtr_listTaskData;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTask_Public_TaskData_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTask_Public_TaskData_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CloseTask_Public_Void_TaskData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int updateDay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateDay);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateDay)) = num;
			}
		}

		public unsafe List<TaskData> listTaskData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listTaskData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TaskData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listTaskData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static FactionTaskBoardData()
		{
			Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, "FactionTaskBoardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr);
			NativeFieldInfoPtr_updateDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr, "updateDay");
			NativeFieldInfoPtr_listTaskData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr, "listTaskData");
			NativeMethodInfoPtr_GetTask_Public_TaskData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr, 100686919);
			NativeMethodInfoPtr_UpdateTask_Public_TaskData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr, 100686920);
			NativeMethodInfoPtr_CloseTask_Public_Void_TaskData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr, 100686921);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr, 100686922);
		}

		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 846337, RefRangeEnd = 846353, XrefRangeStart = 846321, XrefRangeEnd = 846337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskData GetTask(int taskID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&taskID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTask_Public_TaskData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskData>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 846364, RefRangeEnd = 846366, XrefRangeStart = 846353, XrefRangeEnd = 846364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskData UpdateTask(int index, int taskID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&index);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskID;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTask_Public_TaskData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskData>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 846372, RefRangeEnd = 846374, XrefRangeStart = 846366, XrefRangeEnd = 846372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTask(TaskData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseTask_Public_Void_TaskData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 846381, RefRangeEnd = 846384, XrefRangeStart = 846374, XrefRangeEnd = 846381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FactionTaskBoardData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionTaskBoardData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FactionTaskBoardData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_listFactionTaskBoard;

	private static readonly System.IntPtr NativeFieldInfoPtr_listNotRepeatComplated;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoteCheckTask;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAcceptedNum_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAcceptedTaskList_Public_HashSet_1_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseTask_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFactionTaskBoard_Public_FactionTaskBoardData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<int, FactionTaskBoardData> listFactionTaskBoard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listFactionTaskBoard);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, FactionTaskBoardData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listFactionTaskBoard)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<int> listNotRepeatComplated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listNotRepeatComplated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listNotRepeatComplated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector2Int> NoteCheckTask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoteCheckTask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2Int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoteCheckTask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SaveObjectBountyHunter()
	{
		Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "SaveObjectBountyHunter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr);
		NativeFieldInfoPtr_listFactionTaskBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, "listFactionTaskBoard");
		NativeFieldInfoPtr_listNotRepeatComplated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, "listNotRepeatComplated");
		NativeFieldInfoPtr_NoteCheckTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, "NoteCheckTask");
		NativeMethodInfoPtr_GetAcceptedNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673565);
		NativeMethodInfoPtr_GetAcceptedTaskList_Public_HashSet_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673566);
		NativeMethodInfoPtr_CloseTask_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673567);
		NativeMethodInfoPtr_GetFactionTaskBoard_Public_FactionTaskBoardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673568);
		NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673569);
		NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673570);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673571);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr, 100673572);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846384, XrefRangeEnd = 846409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAcceptedNum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAcceptedNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 846444, RefRangeEnd = 846446, XrefRangeStart = 846409, XrefRangeEnd = 846444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Vector2Int> GetAcceptedTaskList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAcceptedTaskList_Public_HashSet_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 846490, RefRangeEnd = 846498, XrefRangeStart = 846446, XrefRangeEnd = 846490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseTask(int factionID, int taskID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&factionID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseTask_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 846509, RefRangeEnd = 846528, XrefRangeStart = 846498, XrefRangeEnd = 846509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionTaskBoardData GetFactionTaskBoard(int factionID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&factionID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFactionTaskBoard_Public_FactionTaskBoardData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactionTaskBoardData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846528, XrefRangeEnd = 846580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInto(SaveObjectBase origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInto_Public_Virtual_Void_SaveObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Save(bool sync = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sync);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Save_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846580, XrefRangeEnd = 846590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846590, XrefRangeEnd = 846609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveObjectBountyHunter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveObjectBountyHunter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SaveObjectBountyHunter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
