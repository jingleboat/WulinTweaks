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
        /// <summary>v1.11.70：基类 ConditionNode.CheckAllConnectNode 的委托，用于"只跳过队友这一条"。</summary>
        private static CheckAllFn _baseFn;
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
                try
                {
                    _baseFn = Marshal.GetDelegateForFunctionPointer<CheckAllFn>(_baseCheck);
                    Plugin.L.LogInfo("[dobby] 基类 CheckAllConnectNode 委托已就绪 @ " + _baseCheck.ToString("X"));
                }
                catch (Exception e) { ModKit.Err("make base CheckAllConnectNode delegate", e); }

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
            => Dispatch(self, io, line, _origJoinedFn, true);

        private static bool FakePartner(IntPtr self, int io, IntPtr line)
            => Dispatch(self, io, line, _origPartnerFn, false);

        /// <summary>v1.11.55：本次门判定里是否发生过"放宽"（供 [gate] 源标记）。</summary>
        internal static bool RelaxedThisEval;

        /// <summary>v1.11.60：本道门已通过过（times != 0）→ 本次一律不放宽。
        /// 取代被删除的 HoldOnceGuard（那个是事后压制，会污染 times）。</summary>
        internal static bool NoRelaxThisEval;

        private static bool Dispatch(IntPtr self, int io, IntPtr line, CheckAllFn orig, bool isJoined)
        {
            TeamCondHits++;
            RelaxName.MaybeSync();   // v1.9.9：探测「剧情播放中」状态翻转

            // v1.10.0：剧情分支展开 —— 顺手在目标图上套补丁（除首次命中，其余只是一次哈希查找）。
            // 门的「无条件判真」不在这里做：PC 版认不出 conditionPort 连着的条件节点
            // （那个 ConditionPort 是空壳），改成按门指针判断，见 Patch_FlattenGate。
            // 注意：它有自己的开关（FlattenBranches），与本函数的总开关无关，所以放在 gate 之前。
            try { BranchFlatten.Try(self); } catch { }

            // v1.11.47（用户指定）：IsJoinedTeamCondition（“曾经加入过队伍”）**不作为被放宽的条件**
            // —— 放宽它等于允许“从未加入”也能触发本命事件；但它的判定必须按原版保留。
            if (isJoined) return orig != null ? orig(self, io, line) : true;

            /* v1.11.27 修 bug：这里原来**没有**检查总开关。
             * 后果：配置里把「剧情触发时忽略队伍角色条件」(IgnoreTeamMemberCondition) 关掉之后，
             * RelaxName / HoldOnceGuard / Patch_ChangePartner 都被开关挡住了，
             * 唯独这一层还在按 TeamRule.ShouldRelax() 用基类实现顶掉原版判定 ——
             * 也就是「关掉放宽」根本关不干净，剧情条件仍然被 mod 接管。
             * 现在一律先看开关：关着就直接执行原版子类实现。 */
            if (Plugin.IgnoreTeamCondition == null || !Plugin.IgnoreTeamCondition.Value)
                return orig != null ? orig(self, io, line) : true;

            // v1.11.56（用户要求 1）：**先按原版判定；通过就不消耗放额度**
            bool r0;
            try { r0 = orig != null ? orig(self, io, line) : true; }
            catch { r0 = true; }
            if (r0) return true;

            if (NoRelaxThisEval) return orig != null ? orig(self, io, line) : true;   // v1.11.60

            bool relax;
            try { relax = TeamRule.ShouldRelax(self); }
            catch { relax = true; }

            if ((_calls++ & 0x1F) == 0)
                Plugin.L.LogInfo("[dobby-hit] cond=" + self.ToString("X")
                    + " graph=" + (TeamRule.GraphNameOf(self) ?? "?")
                    + " relax=" + relax + " calls=" + _calls);

            if (!relax) return false;
            RelaxedThisEval = true;
            try { MarkRelaxed(self); } catch { }

            /* v1.11.70：**改回 v137 的做法 —— 放宽队友条件后调用基类，由基类检查其余条件。**
             *
             * v1.11.61 曾经改成 `return true`，理由是"调基类会把整条条件链一起放行，
             * 导致剧情连播多遍"。但那个改动把**同一道门上的其它条件**也一起跳过了：
             *   开场剧情的门同时挂着「队友在队」和「经过 3 时辰」，
             *   放宽队友条件后直接 return true → 时辰根本没被检查 →
             *   门在不该通过时通过、走错分支、times 被消耗 → 真正到时辰反而不播。
             *   这正是用户报的「开场没触发」，也是手机端 v177 的同一个错误。
             *
             * 正确语义：只丢掉「队友在队」这一条，其余条件照检 —— 交给基类
             * ConditionNode.CheckAllConnectNode。基类地址 _baseCheck 在 Install 时已拿好。
             * 若再出现"连播多遍"，那是基类之外的问题，不该靠跳过其它条件来掩盖。 */
            try
            {
                if (_baseFn != null) return _baseFn(self, io, line);
            }
            catch (Exception e) { ModKit.Err("call base CheckAllConnectNode", e); }
            return true;
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
                if (pid <= 0 || neg) return;
                RelaxName.MarkRelaxed(pid, TeamRule.GraphNameOf(self));
                // v1.11.40：清陌生名的调用已挪到 TeamRule.Compute（那里才能做到
                // 「不受每图一次的限制、且在结缘图/未入队等守卫之后」），这里不再重复调用。
            }
            catch { }
        }

    }
}