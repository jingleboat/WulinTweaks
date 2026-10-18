using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Pathfinding;

public class ThreadControlQueue : Il2CppSystem.Object
{
	public class QueueTerminationException : Il2CppSystem.Exception
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static QueueTerminationException()
		{
			Il2CppClassPointerStore<QueueTerminationException>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "QueueTerminationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueTerminationException>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueTerminationException>.NativeClassPtr, 100689356);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065895, XrefRangeEnd = 1065899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueTerminationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueTerminationException>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public QueueTerminationException(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_head;

	private static readonly System.IntPtr NativeFieldInfoPtr_tail;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_numReceivers;

	private static readonly System.IntPtr NativeFieldInfoPtr_blocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedReceivers;

	private static readonly System.IntPtr NativeFieldInfoPtr_starving;

	private static readonly System.IntPtr NativeFieldInfoPtr_terminate;

	private static readonly System.IntPtr NativeFieldInfoPtr_block;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Block_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unblock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllReceiversBlocked_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushFront_Public_Void_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Push_Public_Void_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Starving_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TerminateReceivers_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Public_Path_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiverTerminated_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopNoBlock_Public_Path_Boolean_0;

	public unsafe Path head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_head);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Path>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_head)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path));
		}
	}

	public unsafe Path tail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Path>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path));
		}
	}

	public unsafe Il2CppSystem.Object lockObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe int numReceivers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numReceivers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numReceivers)) = num;
		}
	}

	public unsafe bool blocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocked)) = flag;
		}
	}

	public unsafe int blockedReceivers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedReceivers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedReceivers)) = num;
		}
	}

	public unsafe bool starving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starving)) = flag;
		}
	}

	public unsafe bool terminate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terminate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terminate)) = flag;
		}
	}

	public unsafe ManualResetEvent block
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_block);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_block)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manualResetEvent));
		}
	}

	public unsafe bool IsEmpty
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 97337, RefRangeEnd = 97346, XrefRangeStart = 97337, XrefRangeEnd = 97346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsTerminating
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool AllReceiversBlocked
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1065925, RefRangeEnd = 1065928, XrefRangeStart = 1065921, XrefRangeEnd = 1065925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllReceiversBlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ThreadControlQueue()
	{
		Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Pathfinding", "ThreadControlQueue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr);
		NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "head");
		NativeFieldInfoPtr_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "tail");
		NativeFieldInfoPtr_lockObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "lockObj");
		NativeFieldInfoPtr_numReceivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "numReceivers");
		NativeFieldInfoPtr_blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "blocked");
		NativeFieldInfoPtr_blockedReceivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "blockedReceivers");
		NativeFieldInfoPtr_starving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "starving");
		NativeFieldInfoPtr_terminate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "terminate");
		NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, "block");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682714);
		NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682715);
		NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682716);
		NativeMethodInfoPtr_Block_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682717);
		NativeMethodInfoPtr_Unblock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682718);
		NativeMethodInfoPtr_Lock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682719);
		NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682720);
		NativeMethodInfoPtr_get_AllReceiversBlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682721);
		NativeMethodInfoPtr_PushFront_Public_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682722);
		NativeMethodInfoPtr_Push_Public_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682723);
		NativeMethodInfoPtr_Starving_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682724);
		NativeMethodInfoPtr_TerminateReceivers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682725);
		NativeMethodInfoPtr_Pop_Public_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682726);
		NativeMethodInfoPtr_ReceiverTerminated_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682727);
		NativeMethodInfoPtr_PopNoBlock_Public_Path_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr, 100682728);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065908, RefRangeEnd = 1065909, XrefRangeStart = 1065899, XrefRangeEnd = 1065908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThreadControlQueue(int numReceivers)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadControlQueue>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numReceivers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065913, RefRangeEnd = 1065914, XrefRangeStart = 1065909, XrefRangeEnd = 1065913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Block()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Block_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065918, RefRangeEnd = 1065919, XrefRangeStart = 1065914, XrefRangeEnd = 1065918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unblock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unblock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065919, XrefRangeEnd = 1065920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Lock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065920, XrefRangeEnd = 1065921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unlock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065935, RefRangeEnd = 1065936, XrefRangeStart = 1065928, XrefRangeEnd = 1065935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushFront(Path path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushFront_Public_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065943, RefRangeEnd = 1065944, XrefRangeStart = 1065936, XrefRangeEnd = 1065943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Push(Path path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Public_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065944, XrefRangeEnd = 1065946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Starving()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Starving_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1065950, RefRangeEnd = 1065953, XrefRangeStart = 1065946, XrefRangeEnd = 1065950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TerminateReceivers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TerminateReceivers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065961, RefRangeEnd = 1065962, XrefRangeStart = 1065953, XrefRangeEnd = 1065961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Path Pop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pop_Public_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Path>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1065964, RefRangeEnd = 1065965, XrefRangeStart = 1065962, XrefRangeEnd = 1065964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReceiverTerminated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiverTerminated_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1065972, RefRangeEnd = 1065974, XrefRangeStart = 1065965, XrefRangeEnd = 1065972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Path PopNoBlock(bool blockedBefore)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&blockedBefore);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopNoBlock_Public_Path_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Path>(intPtr) : null;
	}

	public ThreadControlQueue(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
