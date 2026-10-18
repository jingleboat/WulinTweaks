using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.InteropServices;

public class lzip : Il2CppSystem.Object
{
	public class inMemory : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pointer;

		private static readonly System.IntPtr NativeFieldInfoPtr_zf;

		private static readonly System.IntPtr NativeFieldInfoPtr_memStruct;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileStruct;

		private static readonly System.IntPtr NativeFieldInfoPtr_info;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastResult;

		private static readonly System.IntPtr NativeFieldInfoPtr_isClosed;

		private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getZipBuffer_Public_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe System.IntPtr pointer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointer);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointer)) = intPtr;
			}
		}

		public unsafe System.IntPtr zf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zf);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zf)) = intPtr;
			}
		}

		public unsafe System.IntPtr memStruct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memStruct);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memStruct)) = intPtr;
			}
		}

		public unsafe System.IntPtr fileStruct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileStruct);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileStruct)) = intPtr;
			}
		}

		public unsafe Il2CppStructArray<int> info
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int lastResult
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastResult);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastResult)) = num;
			}
		}

		public unsafe bool isClosed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClosed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClosed)) = flag;
			}
		}

		static inMemory()
		{
			Il2CppClassPointerStore<inMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzip>.NativeClassPtr, "inMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<inMemory>.NativeClassPtr);
			NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "pointer");
			NativeFieldInfoPtr_zf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "zf");
			NativeFieldInfoPtr_memStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "memStruct");
			NativeFieldInfoPtr_fileStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "fileStruct");
			NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "info");
			NativeFieldInfoPtr_lastResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "lastResult");
			NativeFieldInfoPtr_isClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "isClosed");
			NativeMethodInfoPtr_size_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100684650);
			NativeMethodInfoPtr_getZipBuffer_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100684651);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100684652);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 666641, RefRangeEnd = 666643, XrefRangeStart = 666641, XrefRangeEnd = 666641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int size()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_size_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 666652, RefRangeEnd = 666654, XrefRangeStart = 666643, XrefRangeEnd = 666652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> getZipBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipBuffer_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 666659, RefRangeEnd = 666669, XrefRangeStart = 666654, XrefRangeEnd = 666659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe inMemory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<inMemory>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public inMemory(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class zipInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_VersionMadeBy;

		private static readonly System.IntPtr NativeFieldInfoPtr_MinimumVersionToExtract;

		private static readonly System.IntPtr NativeFieldInfoPtr_BitFlag;

		private static readonly System.IntPtr NativeFieldInfoPtr_CompressionMethod;

		private static readonly System.IntPtr NativeFieldInfoPtr_FileLastModificationTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_FileLastModificationDate;

		private static readonly System.IntPtr NativeFieldInfoPtr_CRC;

		private static readonly System.IntPtr NativeFieldInfoPtr_CompressedSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_UncompressedSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_DiskNumberWhereFileStarts;

		private static readonly System.IntPtr NativeFieldInfoPtr_InternalFileAttributes;

		private static readonly System.IntPtr NativeFieldInfoPtr_ExternalFileAttributes;

		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader;

		private static readonly System.IntPtr NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore;

		private static readonly System.IntPtr NativeFieldInfoPtr_filename;

		private static readonly System.IntPtr NativeFieldInfoPtr_extraField;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileComment;

		public unsafe short VersionMadeBy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionMadeBy);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionMadeBy)) = num;
			}
		}

		public unsafe short MinimumVersionToExtract
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumVersionToExtract);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumVersionToExtract)) = num;
			}
		}

		public unsafe short BitFlag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitFlag);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitFlag)) = num;
			}
		}

		public unsafe short CompressionMethod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressionMethod);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressionMethod)) = num;
			}
		}

		public unsafe short FileLastModificationTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationTime);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationTime)) = num;
			}
		}

		public unsafe short FileLastModificationDate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationDate);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationDate)) = num;
			}
		}

		public unsafe int CRC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CRC);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CRC)) = num;
			}
		}

		public unsafe int CompressedSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressedSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressedSize)) = num;
			}
		}

		public unsafe int UncompressedSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UncompressedSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UncompressedSize)) = num;
			}
		}

		public unsafe short DiskNumberWhereFileStarts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiskNumberWhereFileStarts);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiskNumberWhereFileStarts)) = num;
			}
		}

		public unsafe short InternalFileAttributes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InternalFileAttributes);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InternalFileAttributes)) = num;
			}
		}

		public unsafe int ExternalFileAttributes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExternalFileAttributes);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExternalFileAttributes)) = num;
			}
		}

		public unsafe int RelativeOffsetOfLocalFileHeader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader)) = num;
			}
		}

		public unsafe int AbsoluteOffsetOfLocalFileHeaderStore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore)) = num;
			}
		}

		public unsafe string filename
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filename);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filename)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string extraField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraField)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string fileComment
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileComment);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileComment)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static zipInfo()
		{
			Il2CppClassPointerStore<zipInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zipInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zipInfo>.NativeClassPtr);
			NativeFieldInfoPtr_VersionMadeBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "VersionMadeBy");
			NativeFieldInfoPtr_MinimumVersionToExtract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "MinimumVersionToExtract");
			NativeFieldInfoPtr_BitFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "BitFlag");
			NativeFieldInfoPtr_CompressionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "CompressionMethod");
			NativeFieldInfoPtr_FileLastModificationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "FileLastModificationTime");
			NativeFieldInfoPtr_FileLastModificationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "FileLastModificationDate");
			NativeFieldInfoPtr_CRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "CRC");
			NativeFieldInfoPtr_CompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "CompressedSize");
			NativeFieldInfoPtr_UncompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "UncompressedSize");
			NativeFieldInfoPtr_DiskNumberWhereFileStarts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "DiskNumberWhereFileStarts");
			NativeFieldInfoPtr_InternalFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "InternalFileAttributes");
			NativeFieldInfoPtr_ExternalFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "ExternalFileAttributes");
			NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "RelativeOffsetOfLocalFileHeader");
			NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "AbsoluteOffsetOfLocalFileHeaderStore");
			NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "filename");
			NativeFieldInfoPtr_extraField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "extraField");
			NativeFieldInfoPtr_fileComment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "fileComment");
		}

		public zipInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public zipInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zipInfo>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_libname;

	private static readonly System.IntPtr NativeFieldInfoPtr_ninfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_uinfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_cinfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_localOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_zipFiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_zipFolders;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCompressedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalUncompressedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_zinfo;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTarEncoding_Public_Static_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEncoding_Public_Static_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipValidateFile_Internal_Static_Boolean_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetTotalFiles_Internal_Static_Int32_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetTotalEntries_Internal_Static_Int32_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetInfoA_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetInfo_Internal_Static_IntPtr_String_Int32_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_releaseBuffer_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetEntrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntryExists_Internal_Static_Boolean_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCD_Internal_Static_Int32_Int32_String_String_String_String_String_Boolean_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDList_Internal_Static_Int32_Int32_String_IntPtr_Int32_IntPtr_IntPtr_String_Boolean_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipBuf2File_Internal_Static_Boolean_Int32_String_String_IntPtr_Int32_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipDeleteFile_Internal_Static_Int32_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntry2Buffer_Internal_Static_Int32_String_String_IntPtr_Int32_IntPtr_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipDecompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEX_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntry_Internal_Static_Int32_String_String_String_IntPtr_Int32_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntryDateTime_Internal_Static_UInt32_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeMemStruct_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMem_Internal_Static_IntPtr_IntPtr_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initMemStruct_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initFileStruct_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeMemZ_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeFileZ_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMemStart_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMemAdd_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMemClose_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipUnGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipUnGzip2_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzip_File_Internal_Static_Int32_String_String_Int32_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ungzip_File_Internal_Static_Int32_String_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCancel_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readTarA_Internal_Static_Int32_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readTar_Internal_Static_IntPtr_String_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createTar_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extractTar_Internal_Static_Int32_String_String_String_IntPtr_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bz2_Internal_Static_Int32_Boolean_Int32_String_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTotalFiles_Public_Static_Int32_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTotalEntries_Public_Static_Int32_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntryIndex_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileInfo_Public_Static_UInt64_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntrySize_Public_Static_UInt64_String_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entryExists_Public_Static_Boolean_String_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buffer2File_Public_Static_Boolean_Int32_String_String_Il2CppStructArray_1_Byte_Boolean_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delete_entry_Public_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_String_Int32_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_Il2CppStructArray_1_Byte_Int32_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extract_entry_Public_Static_Int32_String_String_String_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress_File_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_File_Public_Static_Int32_Int32_String_String_Boolean_String_String_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_File_List_Public_Static_Int32_Int32_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Boolean_Il2CppStringArray_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressDir_Public_Static_Int32_String_Int32_String_Boolean_Il2CppStructArray_1_Int32_String_Boolean_Int32_Boolean_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fillPointers_Private_Static_Void_String_Il2CppStringArray_Il2CppStringArray_byref_Il2CppStructArray_1_IntPtr_byref_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fillLists_Private_Static_Void_String_Boolean_byref_List_1_String_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarExtract_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarExtractEntry_Public_Static_Int32_String_String_String_Boolean_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarDir_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarList_Public_Static_Int32_String_Il2CppStringArray_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTarInfo_Public_Static_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entryDateTime_Public_Static_DateTime_String_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_free_inmemory_Public_Static_Void_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inMemoryZipStart_Public_Static_Boolean_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inMemoryZipAdd_Public_Static_Int32_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inMemoryZipClose_Public_Static_IntPtr_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_Buf2Mem_Public_Static_IntPtr_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress_Mem2File_Public_Static_Int32_inMemory_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMem_Public_Static_Il2CppStructArray_1_Byte_inMemory_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileInfoMem_Public_Static_UInt64_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2Buffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBuffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_validateFile_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfo_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_String_byref_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findPK_Private_Static_Boolean_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findEnd_Private_Static_Int32_BinaryReader_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCentralDir_Private_Static_Void_BinaryReader_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_writeFile_Private_Static_Void_Il2CppStructArray_1_Byte_String_String_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzipUncompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzipCompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findGzStart_Public_Static_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unGzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unGzip2_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unGzip2Merged_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzipFile_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ungzipFile_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bz2Create_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bz2Decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string libname
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_libname, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_libname, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> ninfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ninfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ninfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> uinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> cinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> localOffset
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localOffset, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localOffset, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int zipFiles
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zipFiles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zipFiles, (void*)(&num));
		}
	}

	public unsafe static int zipFolders
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zipFolders, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zipFolders, (void*)(&num));
		}
	}

	public unsafe static ulong totalCompressedSize
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_totalCompressedSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_totalCompressedSize, (void*)(&num));
		}
	}

	public unsafe static ulong totalUncompressedSize
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_totalUncompressedSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_totalUncompressedSize, (void*)(&num));
		}
	}

	public unsafe static List<zipInfo> zinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<zipInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static lzip()
	{
		Il2CppClassPointerStore<lzip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "lzip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<lzip>.NativeClassPtr);
		NativeFieldInfoPtr_libname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "libname");
		NativeFieldInfoPtr_ninfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "ninfo");
		NativeFieldInfoPtr_uinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "uinfo");
		NativeFieldInfoPtr_cinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "cinfo");
		NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "localOffset");
		NativeFieldInfoPtr_zipFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zipFiles");
		NativeFieldInfoPtr_zipFolders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zipFolders");
		NativeFieldInfoPtr_totalCompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "totalCompressedSize");
		NativeFieldInfoPtr_totalUncompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "totalUncompressedSize");
		NativeFieldInfoPtr_zinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zinfo");
		NativeMethodInfoPtr_setTarEncoding_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_setEncoding_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_zipValidateFile_Internal_Static_Boolean_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_zipGetTotalFiles_Internal_Static_Int32_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_zipGetTotalEntries_Internal_Static_Int32_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_zipGetInfoA_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_zipGetInfo_Internal_Static_IntPtr_String_Int32_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_releaseBuffer_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_zipGetEntrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_zipEntryExists_Internal_Static_Boolean_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_zipCD_Internal_Static_Int32_Int32_String_String_String_String_String_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_zipCDList_Internal_Static_Int32_Int32_String_IntPtr_Int32_IntPtr_IntPtr_String_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_zipBuf2File_Internal_Static_Boolean_Int32_String_String_IntPtr_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_zipDeleteFile_Internal_Static_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_zipEntry2Buffer_Internal_Static_Int32_String_String_IntPtr_Int32_IntPtr_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_zipCompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_zipDecompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_zipEX_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_zipEntry_Internal_Static_Int32_String_String_String_IntPtr_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_getEntryDateTime_Internal_Static_UInt32_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_freeMemStruct_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_zipCDMem_Internal_Static_IntPtr_IntPtr_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_initMemStruct_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_initFileStruct_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_freeMemZ_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_freeFileZ_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_zipCDMemStart_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_zipCDMemAdd_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_zipCDMemClose_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_zipGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_zipUnGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_zipUnGzip2_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_gzip_File_Internal_Static_Int32_String_String_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_ungzip_File_Internal_Static_Int32_String_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_setCancel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_readTarA_Internal_Static_Int32_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_readTar_Internal_Static_IntPtr_String_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_createTar_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_extractTar_Internal_Static_Int32_String_String_String_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_bz2_Internal_Static_Int32_Boolean_Int32_String_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_getTotalFiles_Public_Static_Int32_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_getTotalEntries_Public_Static_Int32_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_getEntryIndex_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_getFileInfo_Public_Static_UInt64_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_getEntrySize_Public_Static_UInt64_String_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_entryExists_Public_Static_Boolean_String_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_buffer2File_Public_Static_Boolean_Int32_String_String_Il2CppStructArray_1_Byte_Boolean_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_delete_entry_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_String_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_Il2CppStructArray_1_Byte_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_extract_entry_Public_Static_Int32_String_String_String_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_decompress_File_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_compress_File_Public_Static_Int32_Int32_String_String_Boolean_String_String_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_compress_File_List_Public_Static_Int32_Int32_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Boolean_Il2CppStringArray_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_compressDir_Public_Static_Int32_String_Int32_String_Boolean_Il2CppStructArray_1_Int32_String_Boolean_Int32_Boolean_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_fillPointers_Private_Static_Void_String_Il2CppStringArray_Il2CppStringArray_byref_Il2CppStructArray_1_IntPtr_byref_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_fillLists_Private_Static_Void_String_Boolean_byref_List_1_String_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_tarExtract_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_tarExtractEntry_Public_Static_Int32_String_String_String_Boolean_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_tarDir_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_tarList_Public_Static_Int32_String_Il2CppStringArray_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_getTarInfo_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_entryDateTime_Public_Static_DateTime_String_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_free_inmemory_Public_Static_Void_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_inMemoryZipStart_Public_Static_Boolean_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_inMemoryZipAdd_Public_Static_Int32_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_inMemoryZipClose_Public_Static_IntPtr_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_compress_Buf2Mem_Public_Static_IntPtr_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_decompress_Mem2File_Public_Static_Int32_inMemory_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_entry2BufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_entry2BufferMem_Public_Static_Il2CppStructArray_1_Byte_inMemory_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_entry2FixedBufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_getFileInfoMem_Public_Static_UInt64_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_entry2Buffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_entry2FixedBuffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_entry2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_validateFile_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_getZipInfo_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_String_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_findPK_Private_Static_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_findEnd_Private_Static_Int32_BinaryReader_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_getCentralDir_Private_Static_Void_BinaryReader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_writeFile_Private_Static_Void_Il2CppStructArray_1_Byte_String_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_gzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_gzipUncompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_gzipCompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_findGzStart_Public_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_unGzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_unGzip2_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_unGzip2Merged_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_gzipFile_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_ungzipFile_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_bz2Create_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_bz2Decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663679);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 666671, RefRangeEnd = 666672, XrefRangeStart = 666669, XrefRangeEnd = 666671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTarEncoding(uint encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTarEncoding_Public_Static_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666672, XrefRangeEnd = 666674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setEncoding(uint encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEncoding_Public_Static_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666674, XrefRangeEnd = 666676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool zipValidateFile(string zipArchive, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipValidateFile_Internal_Static_Boolean_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666676, XrefRangeEnd = 666678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGetTotalFiles(string zipArchive, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetTotalFiles_Internal_Static_Int32_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666678, XrefRangeEnd = 666680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGetTotalEntries(string zipArchive, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetTotalEntries_Internal_Static_Int32_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 666682, RefRangeEnd = 666683, XrefRangeStart = 666680, XrefRangeEnd = 666682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGetInfoA(string zipArchive, System.IntPtr total, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &total;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetInfoA_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 666685, RefRangeEnd = 666688, XrefRangeStart = 666683, XrefRangeEnd = 666685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipGetInfo(string zipArchive, int size, System.IntPtr unc, System.IntPtr comp, System.IntPtr offs, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unc;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &comp;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offs;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetInfo_Internal_Static_IntPtr_String_Int32_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 666690, RefRangeEnd = 666699, XrefRangeStart = 666688, XrefRangeEnd = 666690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void releaseBuffer(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_releaseBuffer_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666699, XrefRangeEnd = 666701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong zipGetEntrySize(string zipArchive, string entry, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetEntrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666701, XrefRangeEnd = 666703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool zipEntryExists(string zipArchive, string entry, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntryExists_Internal_Static_Boolean_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666703, XrefRangeEnd = 666706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipCD(int levelOfCompression, string zipArchive, string inFilePath, string fileName, string comment, string password, bool useBz2, int diskSize, System.IntPtr bprog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCD_Internal_Static_Int32_Int32_String_String_String_String_String_Boolean_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666706, XrefRangeEnd = 666709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipCDList(int levelOfCompression, string zipArchive, System.IntPtr filename, int arrayLength, System.IntPtr prog, System.IntPtr filenameForced, string password, bool useBz2, int diskSize, System.IntPtr bprog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filename;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &prog;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &filenameForced;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDList_Internal_Static_Int32_Int32_String_IntPtr_Int32_IntPtr_IntPtr_String_Boolean_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666709, XrefRangeEnd = 666712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool zipBuf2File(int levelOfCompression, string zipArchive, string arc_filename, System.IntPtr buffer, int bufferSize, string comment, string password, bool useBz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipBuf2File_Internal_Static_Boolean_Int32_String_String_IntPtr_Int32_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666712, XrefRangeEnd = 666714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipDeleteFile(string zipArchive, string arc_filename, string tempArchive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tempArchive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipDeleteFile_Internal_Static_Int32_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 666717, RefRangeEnd = 666722, XrefRangeStart = 666714, XrefRangeEnd = 666717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEntry2Buffer(string zipArchive, string entry, System.IntPtr buffer, int bufferSize, System.IntPtr FileBuffer, int fileBufferLength, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntry2Buffer_Internal_Static_Int32_String_String_IntPtr_Int32_IntPtr_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666722, XrefRangeEnd = 666724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCompressBuffer(System.IntPtr source, int sourceLen, int levelOfCompression, ref int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666724, XrefRangeEnd = 666726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipDecompressBuffer(System.IntPtr source, int sourceLen, ref int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipDecompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 666729, RefRangeEnd = 666730, XrefRangeStart = 666726, XrefRangeEnd = 666729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEX(string zipArchive, string outPath, System.IntPtr progress, System.IntPtr FileBuffer, int fileBufferLength, System.IntPtr proc, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &proc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEX_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666730, XrefRangeEnd = 666733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEntry(string zipArchive, string arc_filename, string outpath, System.IntPtr FileBuffer, int fileBufferLength, System.IntPtr proc, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outpath);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &proc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntry_Internal_Static_Int32_String_String_String_IntPtr_Int32_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666733, XrefRangeEnd = 666735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint getEntryDateTime(string zipArchive, string arc_filename, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntryDateTime_Internal_Static_UInt32_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666735, XrefRangeEnd = 666737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int freeMemStruct(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeMemStruct_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666737, XrefRangeEnd = 666740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCDMem(System.IntPtr info, System.IntPtr pnt, int levelOfCompression, System.IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&info);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pnt;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMem_Internal_Static_IntPtr_IntPtr_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666740, XrefRangeEnd = 666742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr initMemStruct()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initMemStruct_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666742, XrefRangeEnd = 666744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr initFileStruct()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initFileStruct_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666744, XrefRangeEnd = 666746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int freeMemZ(System.IntPtr pointer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeMemZ_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666746, XrefRangeEnd = 666748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int freeFileZ(System.IntPtr pointer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeFileZ_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666748, XrefRangeEnd = 666750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCDMemStart(System.IntPtr info, System.IntPtr pnt, System.IntPtr fileStruct, System.IntPtr memStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&info);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pnt;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileStruct;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &memStruct;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMemStart_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666750, XrefRangeEnd = 666753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipCDMemAdd(System.IntPtr zf, int levelOfCompression, System.IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&zf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMemAdd_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666753, XrefRangeEnd = 666755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCDMemClose(System.IntPtr zf, System.IntPtr memStruct, System.IntPtr info, int err)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&zf);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &memStruct;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &err;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMemClose_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666755, XrefRangeEnd = 666757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGzip(System.IntPtr source, int sourceLen, System.IntPtr outBuffer, int levelOfCompression, bool addHeader, bool addFooter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &addFooter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666757, XrefRangeEnd = 666759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipUnGzip(System.IntPtr source, int sourceLen, System.IntPtr outBuffer, int outLen, bool hasHeader, bool hasFooter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outLen;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasHeader;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFooter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipUnGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 666761, RefRangeEnd = 666763, XrefRangeStart = 666759, XrefRangeEnd = 666761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipUnGzip2(System.IntPtr source, int sourceLen, System.IntPtr outBuffer, int outLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outLen;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipUnGzip2_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666763, XrefRangeEnd = 666765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzip_File(string inFile, string outFile, int level, System.IntPtr progress, bool addHeader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzip_File_Internal_Static_Int32_String_String_Int32_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666765, XrefRangeEnd = 666767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ungzip_File(string inFile, string outFile, System.IntPtr progress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ungzip_File_Internal_Static_Int32_String_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 666769, RefRangeEnd = 666770, XrefRangeStart = 666767, XrefRangeEnd = 666769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setCancel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCancel_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666770, XrefRangeEnd = 666772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int readTarA(string zipArchive, System.IntPtr total)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &total;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readTarA_Internal_Static_Int32_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666772, XrefRangeEnd = 666774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr readTar(string zipArchive, int size, System.IntPtr unc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unc;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readTar_Internal_Static_IntPtr_String_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666774, XrefRangeEnd = 666776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int createTar(string outFile, System.IntPtr filePath, System.IntPtr filename, int arrayLength, System.IntPtr prog, System.IntPtr bprog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filePath;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filename;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &prog;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createTar_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666776, XrefRangeEnd = 666778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extractTar(string inFile, string outDir, string entry, System.IntPtr prog, System.IntPtr bprog, bool fullPaths)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outDir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &prog;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extractTar_Internal_Static_Int32_String_String_String_IntPtr_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666778, XrefRangeEnd = 666780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bz2(bool decompress, int level, string inFile, string outFile, System.IntPtr byteProgress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&decompress);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteProgress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bz2_Internal_Static_Int32_Boolean_Int32_String_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GCHandle gcA(Il2CppSystem.Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GCHandle*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 666786, RefRangeEnd = 666788, XrefRangeStart = 666780, XrefRangeEnd = 666786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getTotalFiles(string zipArchive, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTotalFiles_Public_Static_Int32_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 666794, RefRangeEnd = 666796, XrefRangeStart = 666788, XrefRangeEnd = 666794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getTotalEntries(string zipArchive, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTotalEntries_Public_Static_Int32_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 666813, RefRangeEnd = 666814, XrefRangeStart = 666796, XrefRangeEnd = 666813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getEntryIndex(string entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntryIndex_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 666930, RefRangeEnd = 666933, XrefRangeStart = 666814, XrefRangeEnd = 666930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getFileInfo(string zipArchive, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFileInfo_Public_Static_UInt64_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 666939, RefRangeEnd = 666941, XrefRangeStart = 666933, XrefRangeEnd = 666939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getEntrySize(string zipArchive, string entry, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntrySize_Public_Static_UInt64_String_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 666947, RefRangeEnd = 666949, XrefRangeStart = 666941, XrefRangeEnd = 666947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool entryExists(string zipArchive, string entry, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entryExists_Public_Static_Boolean_String_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 257862, RefRangeEnd = 257871, XrefRangeStart = 257862, XrefRangeEnd = 257871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_user);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_group);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 666967, RefRangeEnd = 666970, XrefRangeStart = 666949, XrefRangeEnd = 666967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool buffer2File(int levelOfCompression, string zipArchive, string arc_filename, Il2CppStructArray<byte> buffer, bool append = false, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buffer2File_Public_Static_Boolean_Int32_String_String_Il2CppStructArray_1_Byte_Boolean_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 666980, RefRangeEnd = 666983, XrefRangeStart = 666970, XrefRangeEnd = 666980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int delete_entry(string zipArchive, string arc_filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delete_entry_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 666999, RefRangeEnd = 667000, XrefRangeStart = 666983, XrefRangeEnd = 666999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int replace_entry(string zipArchive, string arc_filename, string newFilePath, int level = 9, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newFilePath);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_String_Int32_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667008, RefRangeEnd = 667009, XrefRangeStart = 667000, XrefRangeEnd = 667008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int replace_entry(string zipArchive, string arc_filename, Il2CppStructArray<byte> newFileBuffer, int level = 9, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFileBuffer);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_Il2CppStructArray_1_Byte_Int32_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667034, RefRangeEnd = 667036, XrefRangeStart = 667009, XrefRangeEnd = 667034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extract_entry(string zipArchive, string arc_filename, string outpath, Il2CppStructArray<byte> FileBuffer = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arc_filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outpath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extract_entry_Public_Static_Int32_String_String_String_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 667091, RefRangeEnd = 667101, XrefRangeStart = 667036, XrefRangeEnd = 667091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress_File(string zipArchive, string outPath = null, Il2CppStructArray<int> progress = null, Il2CppStructArray<byte> FileBuffer = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress_File_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 667130, RefRangeEnd = 667136, XrefRangeStart = 667101, XrefRangeEnd = 667130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compress_File(int levelOfCompression, string zipArchive, string inFilePath, bool append = false, string fileName = "", string comment = null, string password = null, bool useBz2 = false, int diskSize = 0, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFilePath);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_File_Public_Static_Int32_Int32_String_String_Boolean_String_String_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667146, RefRangeEnd = 667148, XrefRangeStart = 667136, XrefRangeEnd = 667146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compress_File_List(int levelOfCompression, string zipArchive, Il2CppStringArray inFilePath, Il2CppStructArray<int> progress = null, bool append = false, Il2CppStringArray fileName = null, string password = null, bool useBz2 = false, int diskSize = 0, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_File_List_Public_Static_Int32_Int32_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Boolean_Il2CppStringArray_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667195, RefRangeEnd = 667196, XrefRangeStart = 667148, XrefRangeEnd = 667195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressDir(string sourceDir, int levelOfCompression, string zipArchive = null, bool includeRoot = false, Il2CppStructArray<int> progress = null, string password = null, bool useBz2 = false, int diskSize = 0, bool append = false, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceDir);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRoot;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressDir_Public_Static_Int32_String_Int32_String_Boolean_Il2CppStructArray_1_Int32_String_Boolean_Int32_Boolean_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667228, RefRangeEnd = 667229, XrefRangeStart = 667196, XrefRangeEnd = 667228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void fillPointers(string outFile, Il2CppStringArray fileName, Il2CppStringArray inFilePath, ref Il2CppStructArray<System.IntPtr> fp, ref Il2CppStructArray<System.IntPtr> np)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fp);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)np);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fillPointers_Private_Static_Void_String_Il2CppStringArray_Il2CppStringArray_byref_Il2CppStructArray_1_IntPtr_byref_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		fp = ((intPtr5 == (System.IntPtr)0) ? null : new Il2CppStructArray<System.IntPtr>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		np = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<System.IntPtr>(intPtr6));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667259, RefRangeEnd = 667261, XrefRangeStart = 667229, XrefRangeEnd = 667259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void fillLists(string fdir, bool includeRoot, ref List<string> inFilePath, ref List<string> fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fdir);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRoot;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fillLists_Private_Static_Void_String_Boolean_byref_List_1_String_byref_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		inFilePath = ((intPtr5 == (System.IntPtr)0) ? null : new List<string>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		fileName = ((intPtr6 == (System.IntPtr)0) ? null : new List<string>(intPtr6));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667261, XrefRangeEnd = 667264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getAllFiles(string dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667264, XrefRangeEnd = 667268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long getFileSize(string file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667268, XrefRangeEnd = 667277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getDirSize(string dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667298, RefRangeEnd = 667299, XrefRangeStart = 667277, XrefRangeEnd = 667298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarExtract(string inFile, string outPath = null, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarExtract_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667319, RefRangeEnd = 667321, XrefRangeStart = 667299, XrefRangeEnd = 667319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarExtractEntry(string inFile, string entry, string outPath = null, bool fullPaths = true, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarExtractEntry_Public_Static_Int32_String_String_String_Boolean_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667368, RefRangeEnd = 667369, XrefRangeStart = 667321, XrefRangeEnd = 667368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarDir(string sourceDir, string outFile = null, bool includeRoot = false, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceDir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRoot;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarDir_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667404, RefRangeEnd = 667405, XrefRangeStart = 667369, XrefRangeEnd = 667404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarList(string outFile, Il2CppStringArray inFilePath, Il2CppStringArray fileName = null, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarList_Public_Static_Int32_String_Il2CppStringArray_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667478, RefRangeEnd = 667479, XrefRangeStart = 667405, XrefRangeEnd = 667478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getTarInfo(string tarArchive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tarArchive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTarInfo_Public_Static_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667506, RefRangeEnd = 667507, XrefRangeStart = 667479, XrefRangeEnd = 667506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime entryDateTime(string zipArchive, string entry, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entryDateTime_Public_Static_DateTime_String_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667540, RefRangeEnd = 667542, XrefRangeStart = 667507, XrefRangeEnd = 667540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void free_inmemory(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_free_inmemory_Public_Static_Void_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667588, RefRangeEnd = 667590, XrefRangeStart = 667542, XrefRangeEnd = 667588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool inMemoryZipStart(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inMemoryZipStart_Public_Static_Boolean_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 667608, RefRangeEnd = 667612, XrefRangeStart = 667590, XrefRangeEnd = 667608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int inMemoryZipAdd(inMemory t, int levelOfCompression, Il2CppStructArray<byte> buffer, string fileName, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inMemoryZipAdd_Public_Static_Int32_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667624, RefRangeEnd = 667626, XrefRangeStart = 667612, XrefRangeEnd = 667624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr inMemoryZipClose(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inMemoryZipClose_Public_Static_IntPtr_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667648, RefRangeEnd = 667650, XrefRangeStart = 667626, XrefRangeEnd = 667648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr compress_Buf2Mem(inMemory t, int levelOfCompression, Il2CppStructArray<byte> buffer, string fileName, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_Buf2Mem_Public_Static_IntPtr_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 667682, RefRangeEnd = 667685, XrefRangeStart = 667650, XrefRangeEnd = 667682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress_Mem2File(inMemory t, string outPath, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress_Mem2File_Public_Static_Int32_inMemory_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 667707, RefRangeEnd = 667710, XrefRangeStart = 667685, XrefRangeEnd = 667707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2BufferMem(inMemory t, string entry, ref Il2CppStructArray<byte> buffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		buffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 667729, RefRangeEnd = 667732, XrefRangeStart = 667710, XrefRangeEnd = 667729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2BufferMem(inMemory t, string entry, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMem_Public_Static_Il2CppStructArray_1_Byte_inMemory_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 667748, RefRangeEnd = 667751, XrefRangeStart = 667732, XrefRangeEnd = 667748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBufferMem(inMemory t, string entry, ref Il2CppStructArray<byte> fixedBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667847, RefRangeEnd = 667848, XrefRangeStart = 667751, XrefRangeEnd = 667847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getFileInfoMem(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFileInfoMem_Public_Static_UInt64_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 667889, RefRangeEnd = 667893, XrefRangeStart = 667848, XrefRangeEnd = 667889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2Buffer(string zipArchive, string entry, ref Il2CppStructArray<byte> buffer, Il2CppStructArray<byte> FileBuffer = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2Buffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		buffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 667927, RefRangeEnd = 667928, XrefRangeStart = 667893, XrefRangeEnd = 667927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBuffer(string zipArchive, string entry, ref Il2CppStructArray<byte> fixedBuffer, Il2CppStructArray<byte> FileBuffer = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBuffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 667968, RefRangeEnd = 667971, XrefRangeStart = 667928, XrefRangeEnd = 667968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2Buffer(string zipArchive, string entry, Il2CppStructArray<byte> FileBuffer = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 667977, RefRangeEnd = 667979, XrefRangeStart = 667971, XrefRangeEnd = 667977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool validateFile(string zipArchive, Il2CppStructArray<byte> FileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)FileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_validateFile_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668013, RefRangeEnd = 668014, XrefRangeStart = 667979, XrefRangeEnd = 668013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfo(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfo_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 668054, RefRangeEnd = 668056, XrefRangeStart = 668014, XrefRangeEnd = 668054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfoMerged(string fileName, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getCentralDirectory;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_String_byref_Int32_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 668097, RefRangeEnd = 668104, XrefRangeStart = 668056, XrefRangeEnd = 668097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfoMerged(Il2CppStructArray<byte> buffer, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getCentralDirectory;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668140, RefRangeEnd = 668141, XrefRangeStart = 668104, XrefRangeEnd = 668140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfoMerged(Il2CppStructArray<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 668142, RefRangeEnd = 668146, XrefRangeStart = 668141, XrefRangeEnd = 668142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool findPK(BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findPK_Private_Static_Boolean_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 668146, RefRangeEnd = 668150, XrefRangeStart = 668146, XrefRangeEnd = 668146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findEnd(BinaryReader reader, ref int pos, ref int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findEnd_Private_Static_Int32_BinaryReader_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 668180, RefRangeEnd = 668184, XrefRangeStart = 668150, XrefRangeEnd = 668180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getCentralDir(BinaryReader reader, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCentralDir_Private_Static_Void_BinaryReader_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 668206, RefRangeEnd = 668211, XrefRangeStart = 668184, XrefRangeEnd = 668206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(string filePath, ref int position, ref int siz)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref siz);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668211, XrefRangeEnd = 668232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668232, XrefRangeEnd = 668256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(Il2CppStructArray<byte> buffer, ref int position, ref int siz)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref siz);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668256, XrefRangeEnd = 668279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(Il2CppStructArray<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668304, RefRangeEnd = 668305, XrefRangeStart = 668279, XrefRangeEnd = 668304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressZipMerged(string file, string outPath, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668329, RefRangeEnd = 668330, XrefRangeStart = 668305, XrefRangeEnd = 668329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressZipMerged(Il2CppStructArray<byte> buffer, string outPath, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668330, XrefRangeEnd = 668338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void writeFile(Il2CppStructArray<byte> tb, string entry, string outPath, string overrideEntryName, ref int res)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideEntryName);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_writeFile_Private_Static_Void_Il2CppStructArray_1_Byte_String_String_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668379, RefRangeEnd = 668380, XrefRangeStart = 668338, XrefRangeEnd = 668379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FileMerged(string file, string entry, string outPath, string overrideEntryName = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideEntryName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668420, RefRangeEnd = 668421, XrefRangeStart = 668380, XrefRangeEnd = 668420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FileMerged(Il2CppStructArray<byte> buffer, string entry, string outPath, string overrideEntryName = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideEntryName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668428, RefRangeEnd = 668429, XrefRangeStart = 668421, XrefRangeEnd = 668428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2BufferMerged(string file, string entry, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668429, XrefRangeEnd = 668448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2BufferMerged(string file, string entry, ref Il2CppStructArray<byte> refBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)refBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		refBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668467, RefRangeEnd = 668468, XrefRangeStart = 668448, XrefRangeEnd = 668467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBufferMerged(string file, string entry, ref Il2CppStructArray<byte> fixedBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668474, RefRangeEnd = 668475, XrefRangeStart = 668468, XrefRangeEnd = 668474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2BufferMerged(Il2CppStructArray<byte> buffer, string entry, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668475, XrefRangeEnd = 668493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2BufferMerged(Il2CppStructArray<byte> buffer, string entry, ref Il2CppStructArray<byte> refBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)refBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		refBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668511, RefRangeEnd = 668512, XrefRangeStart = 668493, XrefRangeEnd = 668511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBufferMerged(Il2CppStructArray<byte> buffer, string entry, ref Il2CppStructArray<byte> fixedBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668532, RefRangeEnd = 668533, XrefRangeStart = 668512, XrefRangeEnd = 668532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool compressBuffer(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer, int levelOfCompression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668550, RefRangeEnd = 668551, XrefRangeStart = 668533, XrefRangeEnd = 668550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressBufferFixed(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer, int levelOfCompression, bool safe = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668571, RefRangeEnd = 668572, XrefRangeStart = 668551, XrefRangeEnd = 668571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> compressBuffer(Il2CppStructArray<byte> source, int levelOfCompression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668592, RefRangeEnd = 668593, XrefRangeStart = 668572, XrefRangeEnd = 668592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decompressBuffer(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668610, RefRangeEnd = 668611, XrefRangeStart = 668593, XrefRangeEnd = 668610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressBufferFixed(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer, bool safe = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668631, RefRangeEnd = 668632, XrefRangeStart = 668611, XrefRangeEnd = 668631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> decompressBuffer(Il2CppStructArray<byte> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668645, RefRangeEnd = 668646, XrefRangeStart = 668632, XrefRangeEnd = 668645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzip(Il2CppStructArray<byte> source, Il2CppStructArray<byte> outBuffer, int level, bool addHeader = true, bool addFooter = true, bool overrideDateTimeWithLength = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addFooter;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &overrideDateTimeWithLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668646, RefRangeEnd = 668647, XrefRangeStart = 668646, XrefRangeEnd = 668646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzipUncompressedSize(Il2CppStructArray<byte> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzipUncompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668647, XrefRangeEnd = 668649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzipCompressedSize(Il2CppStructArray<byte> source, int offset = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzipCompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668649, XrefRangeEnd = 668650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findGzStart(Il2CppStructArray<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findGzStart_Public_Static_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668661, RefRangeEnd = 668662, XrefRangeStart = 668650, XrefRangeEnd = 668661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int unGzip(Il2CppStructArray<byte> source, Il2CppStructArray<byte> outBuffer, bool hasHeader = true, bool hasFooter = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasHeader;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFooter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unGzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668662, XrefRangeEnd = 668672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int unGzip2(Il2CppStructArray<byte> source, Il2CppStructArray<byte> outBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unGzip2_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668672, XrefRangeEnd = 668685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int unGzip2Merged(Il2CppStructArray<byte> source, int offset, int bufferLength, Il2CppStructArray<byte> outBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unGzip2Merged_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 668716, RefRangeEnd = 668719, XrefRangeStart = 668685, XrefRangeEnd = 668716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzipFile(string inFile, string outFile = null, int level = 9, Il2CppStructArray<ulong> progress = null, bool addHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzipFile_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 668741, RefRangeEnd = 668743, XrefRangeStart = 668719, XrefRangeEnd = 668741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ungzipFile(string inFile, string outFile = null, Il2CppStructArray<ulong> progress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ungzipFile_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 668774, RefRangeEnd = 668776, XrefRangeStart = 668743, XrefRangeEnd = 668774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bz2Create(string inFile, string outFile = null, int level = 9, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bz2Create_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 668798, RefRangeEnd = 668799, XrefRangeStart = 668776, XrefRangeEnd = 668798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bz2Decompress(string inFile, string outFile = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bz2Decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2961)]
	[CachedScanResults(RefRangeStart = 14100, RefRangeEnd = 17061, XrefRangeStart = 14100, XrefRangeEnd = 17061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe lzip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<lzip>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public lzip(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
