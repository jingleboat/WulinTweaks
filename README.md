# WulinTweaks

**《大侠立志传》（Hero's Adventure: Road to Passion）微调套件**
场景高亮 / 大地图解锁 / 剧情条件放宽 / 易物通吃

基于 BepInEx 6（IL2CPP）的 Harmony 插件。运行时按 `` ` `` 呼出面板，**所有开关默认关闭**（即原版行为），按需打开；面板上改动会立即写进 cfg，下次启动沿用上次状态。

![面板与场景高亮](docs/screenshot.png)

---

## 功能

| # | 功能 | 默认 | 说明 |
|---|------|------|------|
| ① | **场景高亮** | 关 | 进入场景时扫描一次，给可交互物体加描边。跳过建筑本体（房子、城墙等只显示轮廓的物件）；地面物品只点亮可拾取的（`TempID > 0`），这一条恒开、不做开关 |
| ② | **大地图解锁** | 关 | 大地图所有地点默认可见、可直接前往；马车地图图标同样全部放开 |
| ③ | **剧情条件放宽** | 关 | 触发 Scenario 时忽略「队伍中必须存在某角色」的判定，队伍里没有该角色也能推进剧情。**不会**临时增删队员 |
| ④ | **易物通吃** | 关 | 三个独立开关：作价恒占优（含空手也能确认）、易物列出必掉物＋暗取池、确认时搬空 NPC。拿走的池子物品会**同步从池子原件扣掉**，暗取/摸尸不会再拿到同一件 |

「高亮」只在**进入场景时扫描一次**，不做定时刷新，避免每帧遍历对象表。

---

## 安装

1. 安装 [BepInEx 6.0.0-be](https://github.com/BepInEx/BepInEx/releases)（**x64 / IL2CPP** 版）到游戏根目录，先启动一次游戏，让 BepInEx 生成 `BepInEx/interop/`
2. 从 [Releases](../../releases) 下载 `WulinTweaks.dll`，放进 `BepInEx/plugins/`
3. 启动游戏 → 读取存档 → 按 `` ` `` 呼出面板

插件自包含：**除 BepInEx 本体外不依赖任何第三方库**（不使用 UniverseLib，UI 为自建 UGUI）。

配置文件 `BepInEx/config/wulin.tweaks.cfg` 首次启动时自动生成；
池子台账在 `BepInEx/config/WulinTweaks/trade-taken.txt`。

### 从源码构建

```powershell
cd WulinTweaks
dotnet build -c Release -p:GameDir="D:\path\to\WulinSH"
# 产物：bin\Release\WulinTweaks.dll → 复制到 <游戏>\BepInEx\plugins\
```

`GameDir` 三种给法，优先级从高到低：

1. 命令行 `-p:GameDir="..."`；
2. 在 `WulinTweaks/` 下放一个 `local.props`（已 gitignore）：
   `<Project><PropertyGroup><GameDir>D:\path\to\WulinSH</GameDir></PropertyGroup></Project>`；
3. 都不给则用默认的 `C:\Program Files (x86)\Steam\steamapps\common\WulinSH`。

编译依赖游戏的 `BepInEx/core/*.dll` 与 `BepInEx/interop/*.dll`（先启动一次游戏让 BepInEx 生成 interop）。

---

## 使用

进存档后按 `` ` ``（反引号，Tab 键上方）呼出面板，点击条目切换开 / 关；内容超出时用滚轮翻页。

| 配置项 | 分组 | 键 | 默认值 |
|---|---|---|---|
| 呼出键 | `0_UI` | `ToggleKey` | `BackQuote` |
| 场景高亮 | `1_Highlight` | `AlwaysHighlight` | `false` |
| 跳过建筑本体 | `1_Highlight` | `ExcludeBuildings` | `true` |
| 大地图全解锁 | `2_WorldMap` | `UnlockAll` | `false` |
| 马车地图解锁 | `2_WorldMap` | `UnlockCabMap` | `false` |
| 放宽剧情角色条件 | `3_Story` | `IgnoreTeamMemberCondition` | `false` |
| 易物作价恒占优 | `4_Trade` | `AlwaysWin` | `false` |
| 易物列出必掉物＋暗取池 | `4_Trade` | `Pools` | `false` |
| 确认时搬空 NPC | `4_Trade` | `TakeAllOnConfirm` | `false` |
| 剧情诊断日志 | `5_Diag` | `StoryDiagnostics` | `false` |

`ToggleKey` 支持 BepInEx 的按键名（`BackQuote` / `F9` / `LeftControl` 等）。游戏内 `F8` 已被占用，故默认用反引号。

面板与配置项是同一份状态：面板上点了什么，cfg 里就写什么（点击后立即 `Config.Save()`），反之亦然。

三个易物开关的分工：

- **`AlwaysWin`** — 同时接管两件事：`ValueOffset()` 恒 `>= 0`（NPC 必接受）、`playerTradingZone.GetTotalValue()` 为空时的 0 兜底成 1（空手也能确认）。这两道正是 `ConfirmTrading` 的内部门槛，分开没意义。
- **`Pools`** — 只影响易物：打开后 NPC 侧额外列出「击杀必掉物」与「暗取池」的内容（池子里有的 + 模板里有但池子没填的）。**这是纯显示**：副本只写进 `npc.BackPack`，`stealBackPack` / `dropOnDeadBackPack` 一个字节都不动，所以暗取能偷到什么、打死掉什么完全不受影响。
- **`TakeAllOnConfirm`** — 只在成交那一刻生效，把交易区残留和 NPC 背包剩余一起搬进队伍背包。

`1_Highlight / ExcludeBuildings`（跳过建筑本体）默认仍为 `true`：它不是功能开关，而是高亮打开后的过滤条件，关掉会把整栋房子描边。

---

## 易物 / 暗取是怎么被改的

游戏里一个 NPC 有三份物品容器：

```
CharacterPoolData（策划表，模板）
    Items             ItemsDropOnKill      StealPool
        │                   │                 │
        ▼                   ▼                 ▼
GameCharacterInstance（运行时角色实例）
    backPack (0x140)  dropOnDeadBackPack (0x148)  stealBackPack (0x150)
        │                                           │
        │  易物 NPC 侧显示这个                       │  暗取读这个
        ▼                                           ▼
    易物面板                                     暗取面板
```

实测（慧元）：`dropOnDeadBackPack` / `stealBackPack` 运行时是**空的**，而模板里 `tplSteal=1` —— 游戏没把模板实例化进去。暗取只认运行时包（`StealManager.OnStealSuccess` 0x43E2C0：取 `[char+0x150]`，件数为 0 就跳走）。

`Pools` 开关做的是**复制 + 拿走时扣池**：

1. 把「池子里现有的实物 + 模板里有但池子没填的条目」各复制一份放进 `npc.BackPack`，让易物面板列出来、能拖走；
2. 副本被真的拿走（成交/搬空后进了队伍背包）→ 按拿走数量从 `stealBackPack` / `dropOnDeadBackPack` 里 `RemoveItem` 掉同样多；
3. 于是「易物换了一份，暗取还能再偷一份」这个漏洞被补上——原件少了，暗取就没货。

> v1.0 只复制不扣池，`stealBackPack` 一个字节都不动，同一件能拿两次；**v1.1 起改为扣池**（`TradeKit.PoolDeduct`）。

三处细节值得说明：

1. **副本按物品 id 记账**，记在 `BepInEx/config/WulinTweaks/trade-taken.txt`（键为 `TempleteUid:InstanceId:池:物品id`）。只有「副本真的被搬走」才记账；取消交易不记，所以下次还能看到。不记账的话每次开易物都会再造一份，等于无限复制。
2. **扣池按差值算**：造副本时记下数量 `Stack0`，成交后副本剩余 `Stack`，差值就是玩家实际拿走的数量，只扣这么多——玩家只取一部分时，池子里剩下的还在。
3. **副本在交易结束时清掉**：取消走 `CleanupCopies`，成交走搬空后的统一清理；异常关闭的残留由下次 `StartTrading` 的 Prefix 兜底。
4. **搬物品必须新建实例**。`GameItemPack.RemoveItem` 会就地做 `gii.Stack -= count`，而 `AddItem` / `AddItemAsIndependent` 以 `Stack > 0` 为前置条件。把同一个实例「加进目标包、再从源包删掉」会让两边都变成 `Stack == 0` 的空壳——表现为「源包清了、目标包什么都没有」。所以搬运一律 `new GameItemInstance(id, stack)` 进目标包，再删原件。

---

## 实现原理

游戏为 Unity **2020.3.13f1c1** + **IL2CPP**（x86-64）。用 Il2CppDumper 导出 `dump.cs` 定位类型与 RVA，再分别处理：

- **高亮** — Harmony patch `InteractiveObject.SetOutLine`。判定条件为 `clickType > 0`（`clickType == 0` 的是火把、凳子、桌子、灯笼、地板这类纯装饰），并按 `buildingType` 位掩码跳过建筑本体。
- **地图** — patch `UIWorldMapManager.Update` / `IsMapEnable` / `UIWorldMap.SetCityVisible`，以及 `UICabMapManager.IsPassIcon` / `UpdateIconShow`。地图图标节点的名字就是 mapID，遍历后逐个 `SetActive(true)`。
- **剧情** — `IsJoinedTeamCondition` / `HavePartnerCondition` 的 `CheckAllConnectNode` 在 IL2CPP 互操作程序集里没有导出，只能走机器码。读取 `GameAssembly.dll` 基址后按 RVA 写入 `E9 rel32`，直接跳到基类 `ConditionNode.CheckAllConnectNode`：跳过「角色是否在队」的委托判定，但保留前置条件链的递归遍历。原始字节会先保存，关闭开关时写回。
- **UI** — 自建 UGUI（`Canvas` ScreenSpaceOverlay + `CanvasScaler` 1920×1080 + `RectMask2D` 裁切 + 滚轮滚动），由 `RoamingManager.Update` 的 Harmony postfix 驱动，因此不需要注入 MonoBehaviour（IL2CPP 下注入的 `Update` 不会被执行）。
- **易物** — 反汇编 `TradingWithNpcManager` 得到真实流程：`StartTrading` 新建两个 `GameItemPack` 交易区并调 `TradingWithNpcUI.Init`；`MoveItem` 的源包是**按 PackType 写死**的（`Npc` → `npc.BackPack`），不是看物品在哪个包，所以只做显示层合并会导致点击拾取失败。`ConfirmTrading` 有两道门槛（见上），过了才 `npcTradingZone.MergeInto(TeamInventory)`、`playerTradingZone.MergeInto(npc.BackPack)`。确认之后插件再把交易区残留 + NPC 背包剩余一并搬进队伍背包。

安全性上，机器码 patch 前会校验入口 5 字节为 `48 89 5C 24 08`（`mov [rsp+8], rbx`，恰好一条完整指令），不匹配就放弃并打日志——游戏更新后不会写坏代码段。

### 对话闪退：Hold 空转引起的原生栈溢出

放宽「队友在队 / 有伙伴」之后，有些剧情图里的 `Hold` 节点会立刻满足，于是
`StoryManager.ContinueArrange` ↔ `HoldNode.OnActive` 在同一帧里互相递归，几千层后栈打穿。
现场证据（Windows 事件日志 `Application Error` id=1000）：

```
错误模块: GameAssembly.dll
异常代码: 0xc00000fd      # STATUS_STACK_OVERFLOW
```

因为是原生栈溢出，`Player.log` 里不会留下任何托管异常，表现为「对话到一半游戏直接消失」。

现在在 `StoryManager.ContinueArrange` 上挂了一个按**同一帧调用深度**的看门狗：超过 16 层就跳过这一层推进；
跨帧自动清零，所以卡住的那一帧下一帧会继续，不会把进度永久堵死。只在
`IgnoreTeamMemberCondition` 打开时生效，关掉时行为完全不变。触发的前 5 次会写日志：

```
[WulinTweaks] ContinueArrange 同帧已递归 16 层，阻断这一层
```

> 注意：`ContinueArrange` 的 Harmony patch 与机器码 patch 是两套机制，互不影响。
> 前者是托管层 prefix，后者改的是条件节点入口字节。

### 剧情反复触发：Hold 的「已成功」标志没人读

放宽之后还有第二个症状：同一段剧情反复播。

`HoldNode` 本来有 `checkSucessTimes`（`self+0x70`）作为「这个 Hold 已经成功过」的标志，
`addTimes()` 置 1、`clearTimes()` 置 0。但 `CheckCondition()` 根本不读它——反汇编确认它只做
`conditionPort.GetConnections()` → 逐个 `CheckAllConnectNode(io=1, line=null)`。
原版靠「条件为假」来实现一次性；条件被放宽成恒真之后，标志照常被置 1，结果却依然是 `true`。

诊断日志里同一个 Hold 的三次对比：

```
[diag] Hold "流程判断" ...  times=0 result=true    ← 第一次，该放行
[diag] Hold "流程判断" ...  times=1 result=true    ← 已经成功过，还在放行 ← 问题在这
[diag] Hold "流程判断" ...  times=1 result=false   ← 原版本来就会挡住的
```

对策是 `HoldOnceGuard`（同样挂在 `HoldNode.CheckCondition`）：`times` 非 0 的 Hold，
若这次仍被判为「可继续」，就把结果压回 `false`。每个 Hold 只可能因为放宽而通过一次；
游戏若用 `clearTimes()` 归零，之后还能再过一次，语义与原版一致。

```
[once] Hold "流程判断" times=1 已经通过过，压制本次继续（避免剧情重复触发）
```

> 实测 `frameHits` 恒为 1，说明重复触发**不是**同帧空转，与上面那条栈溢出是两条独立路径，
> 两个 guard 各管一段，不重叠。

### 排查开关

`5_Diag / StoryDiagnostics`（默认 `false`）会把每个 `Hold` 的条件检查结果、
`checkSucessTimes`、同帧重复次数写进日志（带采样：每个 Hold 前 5 次 + 之后每 50 次，
同帧重复 ≥5 次的一律记录），不会刷屏。只在排查剧情问题时打开。

---

## 兼容性

- 面向 **《大侠立志传》Hero's Adventure: Road to Passion** PC（Steam）版，Unity 2020.3.13f1c1
- 与 `HaxxToyBox` 共存无冲突（各自独立的 Harmony patch 与配置文件）
- 移动版结构不同（arm64、`libil2cpp.so`），RVA 不通用，未支持

## 已知限制

- 面板需**读取存档后**才能呼出（主菜单阶段 `RoamingManager` 尚未创建）
- 剧情放宽仅覆盖 `IsJoinedTeamCondition` / `HavePartnerCondition` 两类条件节点
- 极少数剧情图上放宽会让 `Hold` 节点空转，靠 `ContinueArrange` 看门狗兜住：不再崩溃，代价是那一帧的推进被跳过
- `HoldOnceGuard` 让每个 Hold 只通过一次；若某段剧情依赖同一 Hold 反复通过（而不是靠 `clearTimes()` 重置），会被压住，这类剧情需要单独加白名单
- 机器码 patch 绑定当前版本的 RVA，游戏更新后需重新定位偏移
- 池子台账按 `InstanceId` 记账；如果某次游戏更新让实例 id 重排，已处理过的角色可能被再补一次
- 扣池只扣运行时实例（`stealBackPack` / `dropOnDeadBackPack`），不改策划表模板；某个 NPC 若被重新生成、池子从模板重建，那件会再出现（此时台账仍会挡住易物侧的重复复制）
- 暗取是否成功仍由游戏自己的成功率公式决定（速度、天赋、等级差），插件只保证「有东西可偷」

## License

MIT
