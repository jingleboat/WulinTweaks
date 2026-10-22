using System;
using System.Runtime.InteropServices;

namespace WulinTweaks
{
    /// <summary>
    /// 用 BepInEx 自带的 dobby.dll 做原生 inline hook，接管
    /// IsJoinedTeamCondition / HavePartnerCondition 的 CheckAllConnectNode。
    ///
    /// dobby 自行处理入口指令重定位、trampoline 生成，并用不受 ±2GB 限制的跳转，
    /// 因此避开了此前手写 E9 的全部问题。
    ///
    /// bool CheckAllConnectNode(NodePort.IO io, List&lt;ConditionNode&gt; line)
    ///   x64: rcx = this, edx = io, r8 = line, 返回 al
    /// </summary>
    internal static class NativeTeamHook
    {
        [DllImport("dobby", CallingConvention = CallingConvention.Cdecl)]
        private static extern int DobbyHook(IntPtr address, IntPtr fakeFunc, out IntPtr originFunc);

        [DllImport("dobby", CallingConvention = CallingConvention.Cdecl)]
        private static extern int DobbyDestroy(IntPtr address);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool CheckAllFn(IntPtr self, int io, IntPtr line);

        // PC 版（GameAssembly.dll）RVA，与 ModKit 中既有定义保持一致
        private const int RVA_BASE_CHECK    = 0x1105A00;   // ConditionNode.CheckAllConnectNode
        private const int RVA_JOINED_CHECK  = 0x10F4CB0;   // IsJoinedTeamCondition.CheckAllConnectNode
        private const int RVA_PARTNER_CHECK = 0x10F2230;   // HavePartnerCondition.CheckAllConnectNode

        private static IntPtr _baseCheck;
        private static CheckAllFn _origJoinedFn, _origPartnerFn;

        // 两个独立委托，各自持有对应的原函数；保持引用防 GC
        private static readonly CheckAllFn _fakeJoined = FakeJoined;
        private static readonly CheckAllFn _fakePartner = FakePartner;

        private static bool _installed;
        private static int _calls;

        /// <summary>
        /// 每次「需要伙伴 / 有伙伴」条件判定 +1（按线程）。
        /// HoldNode.CheckCondition 的 override 用它判断「这次判定到底有没有碰队友条件」——
        /// 没碰就说明这个 Hold 与放宽无关，不该被压制（避免打断游戏设计的重复剧情）。
        /// </summary>
        [ThreadStatic] internal static int TeamCondHits;

        /// <summary>v1.9.8：名字窗口改由 RelaxName 按 uid 维护，这里只保留一个「最后命中」便于日志。</summary>
        internal static int LastRelaxedPid;

        /// <summary>
        /// v1.9.6：最近一次「放宽放过了谁」+ 窗口截止时间（TickCount64 毫秒）。
        /// 供 Patch_RealName 在剧情期间把该角色显示成「熟悉后姓名」。
        /// 只记录 Negate=0 那一侧（"要求某人在队"）被放宽的情况。
        /// </summary>




        // PC 版 ConditionNode(IsJoinedTeam/HavePartner).partnerID = 0x48（手机是 0x58）
        private const int OFF_PARTNER_ID_PC = 0x48;
        private const int OFF_PARTNER_NEGATE_PC = 0x4C;

        internal static bool IsInstalled => _installed;

        internal static bool Install(IntPtr moduleBase)
        {
            if (_installed) return true;
            if (moduleBase == IntPtr.Zero) return false;

            try
            {
                _baseCheck = moduleBase + RVA_BASE_CHECK;

                int r1 = DobbyHook(moduleBase + RVA_JOINED_CHECK,
                    Marshal.GetFunctionPointerForDelegate(_fakeJoined), out var o1);
                int r2 = DobbyHook(moduleBase + RVA_PARTNER_CHECK,
                    Marshal.GetFunctionPointerForDelegate(_fakePartner), out var o2);

                Plugin.L.LogInfo("[dobby] DobbyHook 返回 joined=" + r1 + " partner=" + r2);
                if (r1 != 0 || r2 != 0)
                {
                    Plugin.L.LogError("[dobby] hook 失败，放弃原生拦截");
                    return false;
                }

                _origJoinedFn = Marshal.GetDelegateForFunctionPointer<CheckAllFn>(o1);
                _origPartnerFn = Marshal.GetDelegateForFunctionPointer<CheckAllFn>(o2);
                _installed = true;

                Plugin.L.LogInfo("[dobby] 已接管：base=" + _baseCheck.ToString("X")
                    + " joinedTramp=" + o1.ToString("X") + " partnerTramp=" + o2.ToString("X"));
                return true;
            }
            catch (Exception e) { ModKit.Err("dobby install", e); return false; }
        }

        internal static void Uninstall(IntPtr moduleBase)
        {
            if (!_installed || moduleBase == IntPtr.Zero) return;
            try
            {
                DobbyDestroy(moduleBase + RVA_JOINED_CHECK);
                DobbyDestroy(moduleBase + RVA_PARTNER_CHECK);
            }
            catch (Exception e) { ModKit.Err("dobby uninstall", e); }
            _installed = false;
        }

        private static bool FakeJoined(IntPtr self, int io, IntPtr line)
            => Dispatch(self, io, line, _origJoinedFn);

        private static bool FakePartner(IntPtr self, int io, IntPtr line)
            => Dispatch(self, io, line, _origPartnerFn);

        private static bool Dispatch(IntPtr self, int io, IntPtr line, CheckAllFn orig)
        {
            TeamCondHits++;
            RelaxName.MaybeSync();   // v1.9.9：探测「剧情播放中」状态翻转

            // v1.10.0：剧情分支展开 —— 顺手在目标图上套补丁（除首次命中，其余只是一次哈希查找）。
            // 门的「无条件判真」不在这里做：PC 版认不出 conditionPort 连着的条件节点
            // （那个 ConditionPort 是空壳），改成按门指针判断，见 Patch_FlattenGate。
            try { BranchFlatten.Try(self); } catch { }

            bool relax;
            try { relax = TeamRule.ShouldRelax(self); }
            catch { relax = true; }

            if ((_calls++ & 0x1F) == 0)
                Plugin.L.LogInfo("[dobby-hit] cond=" + self.ToString("X")
                    + " graph=" + (TeamRule.GraphNameOf(self) ?? "?")
                    + " relax=" + relax + " calls=" + _calls);

            if (!relax)
            {
                // 不放宽：执行原版子类实现
                if (orig != null) return orig(self, io, line);
                return true;
            }

            // 放宽：走基类实现（与手机端 base_check_all 一致）
            try
            {
                MarkRelaxed(self);
                var baseFn = Marshal.GetDelegateForFunctionPointer<CheckAllFn>(_baseCheck);
                return baseFn(self, io, line);
            }
            catch (Exception e)
            {
                ModKit.Err("dobby base call", e);
                return true;
            }
        }

        /// <summary>
        /// v1.9.8：改为「每个 uid 一个窗口」—— 见 RelaxName 的注释。
        /// 1.9.6 的单个全局 LastRelaxedPid 会被反复重判的门对钉死，别的角色永远轮不到。
        /// </summary>
        private static unsafe void MarkRelaxed(IntPtr self)
        {
            try
            {
                if (self == IntPtr.Zero) return;
                byte* p = (byte*)self;
                int pid = *(int*)(p + OFF_PARTNER_ID_PC);
                bool neg = *(byte*)(p + OFF_PARTNER_NEGATE_PC) != 0;
                if (_relaxLog++ < 30)
                    Plugin.L.LogInfo("[name] 放宽候选 pid=" + pid + " neg=" + neg);
                if (pid <= 0 || neg) return;
                RelaxName.MarkRelaxed(pid, TeamRule.GraphNameOf(self));
            }
            catch { }
        }

        private static int _relaxLog;
        private static int _flatLog;
    }
}