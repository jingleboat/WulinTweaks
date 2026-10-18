using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace WuLin;

public class ActorInBattleReactEvent : BattleFieldEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_newActorAsEnemyOrAllie;

	private static readonly IntPtr NativeFieldInfoPtr_actorOffendChanged;

	private static readonly IntPtr NativeFieldInfoPtr_displayDelay;

	private static readonly IntPtr NativeFieldInfoPtr__nearestNewEnemy_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__nearestNewAllie_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__offendActors_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_nearestNewEnemy_Public_get_BattleActor_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_nearestNewEnemy_Private_set_Void_BattleActor_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_nearestNewAllie_Public_get_BattleActor_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_nearestNewAllie_Private_set_Void_BattleActor_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_offendActors_Public_get_Dictionary_2_BattleActor_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_offendActors_Private_set_Void_Dictionary_2_BattleActor_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Arrange_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe HashSet<BattleActor> newActorAsEnemyOrAllie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newActorAsEnemyOrAllie);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newActorAsEnemyOrAllie)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<BattleActor> actorOffendChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorOffendChanged);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<BattleActor>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorOffendChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe float displayDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayDelay)) = num;
		}
	}

	public unsafe BattleActor _nearestNewEnemy_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nearestNewEnemy_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nearestNewEnemy_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe BattleActor _nearestNewAllie_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nearestNewAllie_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nearestNewAllie_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)battleActor));
		}
	}

	public unsafe Dictionary<BattleActor, string> _offendActors_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__offendActors_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__offendActors_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe BattleActor nearestNewEnemy
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28448, RefRangeEnd = 28449, XrefRangeStart = 28448, XrefRangeEnd = 28449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nearestNewEnemy_Public_get_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nearestNewEnemy_Private_set_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe BattleActor nearestNewAllie
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18905, RefRangeEnd = 18906, XrefRangeStart = 18905, XrefRangeEnd = 18906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nearestNewAllie_Public_get_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BattleActor>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nearestNewAllie_Private_set_Void_BattleActor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<BattleActor, string> offendActors
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offendActors_Public_get_Dictionary_2_BattleActor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BattleActor, string>>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offendActors_Private_set_Void_Dictionary_2_BattleActor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ActorInBattleReactEvent()
	{
		Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "ActorInBattleReactEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr);
		NativeFieldInfoPtr_newActorAsEnemyOrAllie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, "newActorAsEnemyOrAllie");
		NativeFieldInfoPtr_actorOffendChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, "actorOffendChanged");
		NativeFieldInfoPtr_displayDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, "displayDelay");
		NativeFieldInfoPtr__nearestNewEnemy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, "<nearestNewEnemy>k__BackingField");
		NativeFieldInfoPtr__nearestNewAllie_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, "<nearestNewAllie>k__BackingField");
		NativeFieldInfoPtr__offendActors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, "<offendActors>k__BackingField");
		NativeMethodInfoPtr_get_nearestNewEnemy_Public_get_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671269);
		NativeMethodInfoPtr_set_nearestNewEnemy_Private_set_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671270);
		NativeMethodInfoPtr_get_nearestNewAllie_Public_get_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671271);
		NativeMethodInfoPtr_set_nearestNewAllie_Private_set_Void_BattleActor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671272);
		NativeMethodInfoPtr_get_offendActors_Public_get_Dictionary_2_BattleActor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671273);
		NativeMethodInfoPtr_set_offendActors_Private_set_Void_Dictionary_2_BattleActor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671274);
		NativeMethodInfoPtr_Arrange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671275);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr, 100671276);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 775230, RefRangeEnd = 775231, XrefRangeStart = 775148, XrefRangeEnd = 775230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Arrange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Arrange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 775248, RefRangeEnd = 775249, XrefRangeStart = 775231, XrefRangeEnd = 775248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActorInBattleReactEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorInBattleReactEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActorInBattleReactEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
