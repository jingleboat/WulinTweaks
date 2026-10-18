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
| ④ | **易物通吃** | 关 | 三个独立开关：作价恒占优（含空手也能确认）、易物列出必掉物＋暗取池、确认时搬空 NPC |

「高亮」只在**进入场景时扫描一次**，不做定时刷新，避免每帧遍历对象表。

---

## 安装

1. 安装 [BepInEx 6.0.0-be](https://github.com/BepInEx/BepInEx/releases)（**x64 / IL2CPP** 版）到游戏根目录，先启动一次游戏，让 BepInEx 生成 `BepInEx/interop/`
2. 从 [Releases](../../releases) 下载 `WulinTweaks.dll`，放进 `BepInEx/plugins/`
3. 启动游戏 → 读取存档 → 按 `` ` `` 呼出面板

插件自包含：**除 BepInEx 本体外不依赖任何第三方库**（不使用 UniverseLib，UI 为自建 UGUI）。

配置文件 `BepInEx/config/wulin.tweaks.cfg` 首次启动时自动生成；
池子台账在 `BepInEx/config/WulinTweaks/trade-taken.txt`。

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

`Pools` 开关**只做易物显示**：把「池子里现有的实物 + 模板里有但池子没填的条目」各复制一份放进 `npc.BackPack`，让易物面板列出来、能拖走。`stealBackPack` / `dropOnDeadBackPack` 本身不写一个字节，因此：

- 暗取能偷到什么 = 原版（对慧元这类运行时池子为空的 NPC，就是没货）
- 打死掉什么 = 原版
- 同一件东西可以「易物换一份 + 暗取/掉落再得一份」，这是纯显示方案必然的代价

三处细节值得说明：

1. **副本按物品 id 记账**，记在 `BepInEx/config/WulinTweaks/trade-taken.txt`（键为 `TempleteUid:InstanceId:池:物品id`）。只有「副本真的被搬走」才记账；取消交易不记，所以下次还能看到。不记账的话每次开易物都会再造一份，等于无限复制。
2. **副本在交易结束时清掉**：取消走 `CleanupCopies`，成交走搬空后的统一清理；异常关闭的残留由下次 `StartTrading` 的 Prefix 兜底。
3. **搬物品必须新建实例**。`GameItemPack.RemoveItem` 会就地做 `gii.Stack -= count`，而 `AddItem` / `AddItemAsIndependent` 以 `Stack > 0` 为前置条件。把同一个实例「加进目标包、再从源包删掉」会让两边都变成 `Stack == 0` 的空壳——表现为「源包清了、目标包什么都没有」。所以搬运一律 `new GameItemInstance(id, stack)` 进目标包，再删原件。

---

## 实现原理

游戏为 Unity **2020.3.13f1c1** + **IL2CPP**（x86-64）。用 Il2CppDumper 导出 `dump.cs` 定位类型与 RVA，再分别处理：

- **高亮** — Harmony patch `InteractiveObject.SetOutLine`。判定条件为 `clickType > 0`（`clickType == 0` 的是火把、凳子、桌子、灯笼、地板这类纯装饰），并按 `buildingType` 位掩码跳过建筑本体。
- **地图** — patch `UIWorldMapManager.Update` / `IsMapEnable` / `UIWorldMap.SetCityVisible`，以及 `UICabMapManager.IsPassIcon` / `UpdateIconShow`。地图图标节点的名字就是 mapID，遍历后逐个 `SetActive(true)`。
- **剧情** — `IsJoinedTeamCondition` / `HavePartnerCondition` 的 `CheckAllConnectNode` 在 IL2CPP 互操作程序集里没有导出，只能走机器码。读取 `GameAssembly.dll` 基址后按 RVA 写入 `E9 rel32`，直接跳到基类 `ConditionNode.CheckAllConnectNode`：跳过「角色是否在队」的委托判定，但保留前置条件链的递归遍历。原始字节会先保存，关闭开关时写回。
- **UI** — 自建 UGUI（`Canvas` ScreenSpaceOverlay + `CanvasScaler` 1920×1080 + `RectMask2D` 裁切 + 滚轮滚动），由 `RoamingManager.Update` 的 Harmony postfix 驱动，因此不需要注入 MonoBehaviour（IL2CPP 下注入的 `Update` 不会被执行）。
- **易物** — 反汇编 `TradingWithNpcManager` 得到真实流程：`StartTrading` 新建两个 `GameItemPack` 交易区并调 `TradingWithNpcUI.Init`；`MoveItem` 的源包是**按 PackType 写死**的（`Npc` → `npc.BackPack`），不是看物品在哪个包，所以只做显示层合并会导致点击拾取失败。`ConfirmTrading` 有两道门槛（见上），过了才 `npcTradingZone.MergeInto(TeamInventory)`、`playerTradingZone.MergeInto(npc.BackPack)`。确认之后插件再把交易区残留 + NPC 背包剩余一并搬进队伍背包。

安全性上，机器码 patch 前会校验入口 5 字节为 `48 89 5C 24 08`（`mov [rsp+8], rbx`，恰好一条完整指令），不匹配就放弃并打日志——游戏更新后不会写坏代码段。

---

## 兼容性

- 面向 **《大侠立志传》Hero's Adventure: Road to Passion** PC（Steam）版，Unity 2020.3.13f1c1
- 与 `HaxxToyBox` 共存无冲突（各自独立的 Harmony patch 与配置文件）
- 移动版结构不同（arm64、`libil2cpp.so`），RVA 不通用，未支持

## 已知限制

- 面板需**读取存档后**才能呼出（主菜单阶段 `RoamingManager` 尚未创建）
- 剧情放宽仅覆盖 `IsJoinedTeamCondition` / `HavePartnerCondition` 两类条件节点
- 机器码 patch 绑定当前版本的 RVA，游戏更新后需重新定位偏移
- 池子台账按 `InstanceId` 记账；如果某次游戏更新让实例 id 重排，已处理过的角色可能被再补一次
- 暗取是否成功仍由游戏自己的成功率公式决定（速度、天赋、等级差），插件只保证「有东西可偷」

## License

MIT
