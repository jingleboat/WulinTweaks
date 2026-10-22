using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WulinTweaks
{
    /// <summary>
    /// 通过 GameAssembly.dll 导出的 il2cpp 反射 API，在**运行期**解析字段偏移。
    ///
    /// === 为什么不写死偏移 ===
    /// PC 是 Unity 2020.3 的另一套编译产物，字段布局与手机端（Unity 2022.3）并不一致：
    /// `Hooks.HoldCondProbeNative` 的注释已经实证过「按手机端的 0x60 裸读 conditionPort 拿到的是垃圾值」。
    /// 与其猜偏移，不如直接问 il2cpp 自己。
    ///
    /// 用到的导出（已用 PE 导出表核对过存在，GameAssembly.dll 共 243 个导出）：
    ///   il2cpp_object_get_class(obj)                     -> Il2CppClass*
    ///   il2cpp_class_get_name(klass)                     -> const char*
    ///   il2cpp_class_get_parent(klass)                   -> Il2CppClass*
    ///   il2cpp_class_get_field_from_name(klass, name)    -> FieldInfo*
    ///   il2cpp_field_get_offset(field)                   -> size_t
    ///
    /// 只有两个常量是 il2cpp 的固定 ABI（与游戏/平台无关）：
    ///   List&lt;T&gt;._items 0x10 / ._size 0x18；数组元素起点 0x20；string 长度 0x10 / 字符 0x14。
    ///
    /// 所有读取都先过 `Hooks.SafeMem.Readable`，并且取到的 klass 指针还要通过
    /// 「可读 + 类名像样」两道校验才敢用 —— 手机端 v68 就是在「把垃圾当节点、
    /// 再拿它当 Dictionary 用」上直接 SIGSEGV 的。
    /// </summary>
    internal static class Il2CppNative
    {
        // ================= il2cpp 固定 ABI =================
        internal const int OFF_LIST_ITEMS = 0x10;   // List<T>._items
        internal const int OFF_LIST_SIZE = 0x18;    // List<T>._size
        internal const int OFF_ARRAY_DATA = 0x20;   // T[] 元素起点（klass/monitor/bounds/max_length 之后）
        internal const int OFF_STR_LEN = 0x10;      // System.String.length（int32）
        internal const int OFF_STR_CHARS = 0x14;    // System.String 字符数据（UTF-16）

        // ================= 导出函数 =================
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern IntPtr GetModuleHandleA(string name);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr module, string proc);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr FnObjToClass(IntPtr obj);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr FnClsToName(IntPtr klass);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr FnClsToParent(IntPtr klass);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr FnClsFindField(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr FnFieldToOffset(IntPtr field);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr FnClsGetMethod(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name, int argsCount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr FnRuntimeInvoke(IntPtr method, IntPtr obj, IntPtr args, out IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr FnStringNew([MarshalAs(UnmanagedType.LPStr)] string s);

        private static FnObjToClass _objectGetClass;
        private static FnClsToName _classGetName;
        private static FnClsToParent _classGetParent;
        private static FnClsFindField _classGetFieldFromName;
        private static FnFieldToOffset _fieldGetOffset;
        private static FnClsGetMethod _classGetMethodFromName;
        private static FnRuntimeInvoke _runtimeInvoke;
        private static FnStringNew _stringNew;

        private static bool _tried;

        internal static bool Ready =>
            _objectGetClass != null && _classGetName != null && _classGetParent != null
            && _classGetFieldFromName != null && _fieldGetOffset != null;

        /// <summary>能不能调托管方法（Node.GetPort 那条路）。</summary>
        private static bool InvokeReady =>
            _classGetMethodFromName != null && _runtimeInvoke != null && _stringNew != null;

        /// <summary>类 → (字段名 → 偏移)。-1 = 这个类（及其父类）没有该字段。</summary>
        private static readonly Dictionary<IntPtr, Dictionary<string, int>> _offCache =
            new Dictionary<IntPtr, Dictionary<string, int>>();

        // ================= 初始化 =================
        internal static void Init()
        {
            if (_tried) return;
            _tried = true;
            try
            {
                var h = GetModuleHandleA("GameAssembly.dll");
                if (h == IntPtr.Zero)
                {
                    Plugin.L.LogError("[il2cpp] GameAssembly.dll 没找到，字段偏移无法解析");
                    return;
                }

                _objectGetClass = Bind<FnObjToClass>(h, "il2cpp_object_get_class");
                _classGetName = Bind<FnClsToName>(h, "il2cpp_class_get_name");
                _classGetParent = Bind<FnClsToParent>(h, "il2cpp_class_get_parent");
                _classGetFieldFromName = Bind<FnClsFindField>(h, "il2cpp_class_get_field_from_name");
                _fieldGetOffset = Bind<FnFieldToOffset>(h, "il2cpp_field_get_offset");

                _classGetMethodFromName = Bind<FnClsGetMethod>(h, "il2cpp_class_get_method_from_name");
                _runtimeInvoke = Bind<FnRuntimeInvoke>(h, "il2cpp_runtime_invoke");
                _stringNew = Bind<FnStringNew>(h, "il2cpp_string_new");

                if (Ready) Plugin.L.LogInfo("[il2cpp] 字段偏移解析可用（5 个导出全部就绪）");
                else Plugin.L.LogError("[il2cpp] 导出不全，依赖字段偏移的功能会禁用");
                if (!InvokeReady) Plugin.L.LogWarning("[il2cpp] invoke 相关导出不全，Node.GetPort 调用将停用");
            }
            catch (Exception e) { ModKit.Err("il2cpp init", e); }
        }

        private static T Bind<T>(IntPtr module, string name) where T : Delegate
        {
            try
            {
                var p = GetProcAddress(module, name);
                if (p == IntPtr.Zero)
                {
                    Plugin.L.LogWarning("[il2cpp] 缺少导出: " + name);
                    return null;
                }
                return Marshal.GetDelegateForFunctionPointer<T>(p);
            }
            catch (Exception e)
            {
                Plugin.L.LogWarning("[il2cpp] 绑定失败 " + name + ": " + e.Message);
                return null;
            }
        }

        // ================= 类 =================
        /// <summary>取对象的类指针；不可信（不可读 / 类名不像样）时返回 Zero。</summary>
        internal static IntPtr SafeClass(IntPtr obj)
        {
            if (!Ready || obj == IntPtr.Zero) return IntPtr.Zero;
            if (!Hooks.SafeMem.Readable(obj, 0x10)) return IntPtr.Zero;

            IntPtr k;
            try { k = _objectGetClass(obj); } catch { return IntPtr.Zero; }
            if (k == IntPtr.Zero || !Hooks.SafeMem.Readable(k, 0x80)) return IntPtr.Zero;

            // 类名读不出来 → 这个 klass 指针基本是垃圾，别往里走
            return ClassName(k) == null ? IntPtr.Zero : k;
        }

        /// <summary>类名（不含命名空间）；失败返回 null。</summary>
        internal static string ClassName(IntPtr klass)
        {
            if (!Ready || klass == IntPtr.Zero) return null;
            try
            {
                var p = _classGetName(klass);
                if (p == IntPtr.Zero || !Hooks.SafeMem.Readable(p, 1)) return null;

                // ⚠️ 这里**必须**用不定长的 PtrToStringAnsi(ptr)：定长版本
                // （PtrToStringAnsi(ptr, 128)）会把结尾的 \0 和后面的内存一起读进来，
                // 结果字符串里带一串 \0/垃圾，下面的字符校验必然拒绝 →
                // SafeClass() 对任何对象都返回 0 → 整个展开功能静默失效。
                // 2026-10-23 第一版就是踩在这个坑上（日志里 [flat] 一行都没有）。
                var s = Marshal.PtrToStringAnsi(p);
                if (string.IsNullOrEmpty(s) || s.Length > 128) return null;

                // 类名只可能是标识符：出现奇怪字符就当它不可信
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (!(char.IsLetterOrDigit(c) || c == '_' || c == '.' || c == '`' || c == '+')) return null;
                }
                return s;
            }
            catch { return null; }
        }

        internal static string ClassNameOf(IntPtr obj)
        {
            var k = SafeClass(obj);
            return k == IntPtr.Zero ? null : ClassName(k);
        }

        // ================= 字段偏移 =================
        /// <summary>字段偏移；找不到返回 -1。走父类链，结果按类缓存。</summary>
        internal static int FieldOffset(IntPtr klass, string field)
        {
            if (!Ready || klass == IntPtr.Zero || string.IsNullOrEmpty(field)) return -1;

            if (_offCache.TryGetValue(klass, out var map) && map.TryGetValue(field, out int cached))
                return cached;

            int off = -1;
            try
            {
                IntPtr k = klass;
                for (int depth = 0; k != IntPtr.Zero && depth < 32; depth++)
                {
                    var f = _classGetFieldFromName(k, field);
                    if (f != IntPtr.Zero)
                    {
                        off = (int)(long)_fieldGetOffset(f);
                        break;
                    }
                    k = _classGetParent(k);
                }
            }
            catch { off = -1; }

            if (!_offCache.TryGetValue(klass, out map))
            {
                map = new Dictionary<string, int>(8);
                _offCache[klass] = map;
            }
            if (map.Count < 512) map[field] = off;
            return off;
        }

        private static int OffsetOf(IntPtr obj, string field)
        {
            var k = SafeClass(obj);
            return k == IntPtr.Zero ? -1 : FieldOffset(k, field);
        }

        // ================= 读 =================
        internal static IntPtr Ptr(IntPtr obj, string field)
        {
            int off = OffsetOf(obj, field);
            if (off < 0) return IntPtr.Zero;
            return Hooks.SafeMem.Ptr(obj, off);
        }

        internal static int Int32(IntPtr obj, string field)
        {
            int off = OffsetOf(obj, field);
            if (off < 0) return 0;
            return Hooks.SafeMem.Int32(obj, off);
        }

        internal static byte Byte(IntPtr obj, string field)
        {
            int off = OffsetOf(obj, field);
            if (off < 0) return 0;
            return Hooks.SafeMem.Byte(obj, off);
        }

        /// <summary>读一个 string 字段的值。</summary>
        internal static string Str(IntPtr obj, string field)
        {
            return ReadString(Ptr(obj, field));
        }

        /// <summary>读 il2cpp System.String 的 UTF-16 内容。</summary>
        internal static string ReadString(IntPtr str)
        {
            if (str == IntPtr.Zero) return null;
            if (!Hooks.SafeMem.Readable(str, OFF_STR_CHARS)) return null;
            int len = Hooks.SafeMem.Int32(str, OFF_STR_LEN);
            if (len < 0 || len > 4096) return null;
            if (!Hooks.SafeMem.Readable(str, OFF_STR_CHARS + len * 2)) return null;
            try
            {
                return Marshal.PtrToStringUni(new IntPtr(str.ToInt64() + OFF_STR_CHARS), len);
            }
            catch { return null; }
        }

        // ================= 写 =================
        /// <summary>写一个引用字段。成功返回 true。</summary>
        internal static bool WritePtr(IntPtr obj, string field, IntPtr value)
        {
            int off = OffsetOf(obj, field);
            if (off < 0 || value == IntPtr.Zero) return false;
            if (!Hooks.SafeMem.Readable(obj, off + 8)) return false;
            try
            {
                Marshal.WriteIntPtr(obj, off, value);
                return true;
            }
            catch { return false; }
        }

        // ================= 调托管方法 =================
        /// <summary>类 → (方法名|参数个数 → MethodInfo*)。0 表示查过但没有。</summary>
        private static readonly Dictionary<IntPtr, Dictionary<string, IntPtr>> _miCache =
            new Dictionary<IntPtr, Dictionary<string, IntPtr>>();

        /// <summary>找不到方法时返回 Zero（父类链上找）。</summary>
        private static IntPtr FindMethod(IntPtr klass, string name, int argc)
        {
            if (!InvokeReady || klass == IntPtr.Zero) return IntPtr.Zero;
            string key = name + "/" + argc;

            if (_miCache.TryGetValue(klass, out var map) && map.TryGetValue(key, out var hit))
                return hit;

            IntPtr mi = IntPtr.Zero;
            try
            {
                IntPtr k = klass;
                for (int depth = 0; k != IntPtr.Zero && depth < 32; depth++)
                {
                    var m = _classGetMethodFromName(k, name, argc);
                    if (m != IntPtr.Zero) { mi = m; break; }
                    k = _classGetParent(k);
                }
            }
            catch { mi = IntPtr.Zero; }

            if (!_miCache.TryGetValue(klass, out map))
            {
                map = new Dictionary<string, IntPtr>(8);
                _miCache[klass] = map;
            }
            if (map.Count < 256) map[key] = mi;
            return mi;
        }

        /// <summary>
        /// 调 `XNode.Node.GetPort(string)` —— 与手机端 RVA_NODE_GET_PORT 是同一个方法。
        ///
        /// 为什么走方法而不是直接读端口字段：端口字段（InPort/OutPort/conditionPort）
        /// 都是 [NonSerialized]，由 XNode 的 UpdatePorts 在运行期按 ports 字典回填；
        /// 而 ports 虽然是 Dictionary，但它的 keys/values 两个 List 会被 ClearSerialize 清空
        /// （手机端 v65 就是在这个坑里丢了一整天）。GetPort 直接查字典本体，最稳。
        /// </summary>
        internal static IntPtr GetPort(IntPtr node, string portName)
        {
            if (!InvokeReady || node == IntPtr.Zero || string.IsNullOrEmpty(portName)) return IntPtr.Zero;

            var klass = SafeClass(node);
            if (klass == IntPtr.Zero) return IntPtr.Zero;

            var mi = FindMethod(klass, "GetPort", 1);
            if (mi == IntPtr.Zero) return IntPtr.Zero;

            IntPtr args = IntPtr.Zero;
            try
            {
                var s = _stringNew(portName);
                if (s == IntPtr.Zero) return IntPtr.Zero;

                args = Marshal.AllocHGlobal(8);
                Marshal.WriteIntPtr(args, 0, s);

                var r = _runtimeInvoke(mi, node, args, out var exc);
                if (exc != IntPtr.Zero)
                {
                    if (_invokeWarn++ < 3) Plugin.L.LogWarning("[il2cpp] GetPort(\"" + portName + "\") 抛了托管异常，已忽略");
                    return IntPtr.Zero;
                }
                return r;
            }
            catch (Exception e)
            {
                if (_invokeWarn++ < 3) Plugin.L.LogWarning("[il2cpp] GetPort 调用失败: " + e.Message);
                return IntPtr.Zero;
            }
            finally
            {
                if (args != IntPtr.Zero) Marshal.FreeHGlobal(args);
            }
        }

        private static int _invokeWarn;

        /// <summary>调一个「无参数、返回引用」的实例方法（如 get_Connection / get_node）。</summary>
        internal static IntPtr CallRef(IntPtr obj, string method)
        {
            if (!InvokeReady || obj == IntPtr.Zero) return IntPtr.Zero;
            var klass = SafeClass(obj);
            if (klass == IntPtr.Zero) return IntPtr.Zero;
            var mi = FindMethod(klass, method, 0);
            if (mi == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                var r = _runtimeInvoke(mi, obj, IntPtr.Zero, out var exc);
                if (exc != IntPtr.Zero)
                {
                    if (_invokeWarn++ < 5) Plugin.L.LogWarning("[il2cpp] " + method + "() 抛了托管异常，已忽略");
                    return IntPtr.Zero;
                }
                return r;
            }
            catch (Exception e)
            {
                if (_invokeWarn++ < 5) Plugin.L.LogWarning("[il2cpp] " + method + "() 调用失败: " + e.Message);
                return IntPtr.Zero;
            }
        }

        /// <summary>调一个「1 个引用参数、无返回值」的实例方法（如 Connect / Disconnect）。</summary>
        internal static bool CallVoid1(IntPtr obj, string method, IntPtr arg)
        {
            if (!InvokeReady || obj == IntPtr.Zero) return false;
            var klass = SafeClass(obj);
            if (klass == IntPtr.Zero) return false;
            var mi = FindMethod(klass, method, 1);
            if (mi == IntPtr.Zero) return false;

            IntPtr args = IntPtr.Zero;
            try
            {
                args = Marshal.AllocHGlobal(8);
                Marshal.WriteIntPtr(args, 0, arg);
                _runtimeInvoke(mi, obj, args, out var exc);
                if (exc != IntPtr.Zero)
                {
                    if (_invokeWarn++ < 5) Plugin.L.LogWarning("[il2cpp] " + method + "(…) 抛了托管异常，已忽略");
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                if (_invokeWarn++ < 5) Plugin.L.LogWarning("[il2cpp] " + method + "(…) 调用失败: " + e.Message);
                return false;
            }
            finally
            {
                if (args != IntPtr.Zero) Marshal.FreeHGlobal(args);
            }
        }

        /// <summary>调一个「1 个 bool 参数、返回引用」的实例方法（如 GetConnections(bool)）。</summary>
        internal static IntPtr CallRefBool(IntPtr obj, string method, bool arg)
        {
            if (!InvokeReady || obj == IntPtr.Zero) return IntPtr.Zero;
            var klass = SafeClass(obj);
            if (klass == IntPtr.Zero) return IntPtr.Zero;
            var mi = FindMethod(klass, method, 1);
            if (mi == IntPtr.Zero) return IntPtr.Zero;

            IntPtr args = IntPtr.Zero;
            try
            {
                args = Marshal.AllocHGlobal(8);
                Marshal.WriteInt32(args, 0, arg ? 1 : 0);
                var r = _runtimeInvoke(mi, obj, args, out var exc);
                if (exc != IntPtr.Zero)
                {
                    if (_invokeWarn++ < 5) Plugin.L.LogWarning("[il2cpp] " + method + "(bool) 抛了托管异常，已忽略");
                    return IntPtr.Zero;
                }
                return r;
            }
            catch (Exception e)
            {
                if (_invokeWarn++ < 5) Plugin.L.LogWarning("[il2cpp] " + method + "(bool) 调用失败: " + e.Message);
                return IntPtr.Zero;
            }
            finally
            {
                if (args != IntPtr.Zero) Marshal.FreeHGlobal(args);
            }
        }

        /// <summary>某个字段在对象的类（含父类链）上是否存在 —— 排查用。</summary>
        internal static bool HasField(IntPtr obj, string field)
        {
            return OffsetOf(obj, field) >= 0;
        }

        /// <summary>某个方法在对象的类（含父类链）上是否存在 —— 排查/预检用。</summary>
        internal static bool HasMethod(IntPtr obj, string method, int argc)
        {
            var k = SafeClass(obj);
            return k != IntPtr.Zero && FindMethod(k, method, argc) != IntPtr.Zero;
        }

        /// <summary>对象的类继承链（"A&gt;B&gt;C"），排查用。</summary>
        internal static string ClassChain(IntPtr obj)
        {
            var k = SafeClass(obj);
            if (k == IntPtr.Zero) return "?";
            var sb = new System.Text.StringBuilder(64);
            try
            {
                for (int i = 0; k != IntPtr.Zero && i < 12; i++)
                {
                    var n = ClassName(k);
                    if (n == null) break;
                    if (sb.Length > 0) sb.Append('>');
                    sb.Append(n);
                    k = _classGetParent(k);
                }
            }
            catch { }
            return sb.Length == 0 ? "?" : sb.ToString();
        }

        // ================= 通用小工具 =================
        /// <summary>List&lt;T&gt; 的元素个数（异常值一律当 0）。</summary>
        internal static int ListCount(IntPtr list)
        {
            if (list == IntPtr.Zero) return 0;
            int n = Hooks.SafeMem.Int32(list, OFF_LIST_SIZE);
            return (n < 0 || n > 65536) ? 0 : n;
        }

        /// <summary>List&lt;T&gt;[i]（元素是引用类型）。</summary>
        internal static IntPtr ListItem(IntPtr list, int i)
        {
            if (list == IntPtr.Zero || i < 0) return IntPtr.Zero;
            IntPtr arr = Hooks.SafeMem.Ptr(list, OFF_LIST_ITEMS);
            if (arr == IntPtr.Zero) return IntPtr.Zero;
            return Hooks.SafeMem.Ptr(arr, OFF_ARRAY_DATA + i * 8);
        }
    }
}
