using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace WuLin;

public class UIThumbnailEditor : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_ScenePos1;

	private static readonly IntPtr NativeFieldInfoPtr_MapPos1;

	private static readonly IntPtr NativeFieldInfoPtr_ScenePos2;

	private static readonly IntPtr NativeFieldInfoPtr_MapPos2;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2Int ScenePos1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScenePos1);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScenePos1)) = vector2Int;
		}
	}

	public unsafe RectTransform MapPos1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapPos1);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapPos1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Vector2Int ScenePos2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScenePos2);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScenePos2)) = vector2Int;
		}
	}

	public unsafe RectTransform MapPos2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapPos2);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapPos2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	static UIThumbnailEditor()
	{
		Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WuLin", "UIThumbnailEditor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr);
		NativeFieldInfoPtr_ScenePos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr, "ScenePos1");
		NativeFieldInfoPtr_MapPos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr, "MapPos1");
		NativeFieldInfoPtr_ScenePos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr, "ScenePos2");
		NativeFieldInfoPtr_MapPos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr, "MapPos2");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr, 100677219);
	}

	[CallerCount(115)]
	[CachedScanResults(RefRangeStart = 169215, RefRangeEnd = 169330, XrefRangeStart = 169215, XrefRangeEnd = 169330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIThumbnailEditor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIThumbnailEditor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIThumbnailEditor(IntPtr pointer)
		: base(pointer)
	{
	}
}
