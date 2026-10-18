# WulinTweaks

**《大侠立志传》（Hero's Adventure: Road to Passion）微调套件**
场景高亮 / 大地图解锁 / 剧情条件放宽 / 伤害倍率

基于 BepInEx 6（IL2CPP）的 Harmony 插件。运行时按 `` ` `` 呼出面板，所有功能**默认关闭**、按需开启、可随时开关撤销。

![面板与场景高亮](docs/screenshot.png)

---

## 功能

| # | 功能 | 默认 | 说明 |
|---|------|------|------|
| ① | **场景高亮** | 关 | 进入场景时扫描一次，给所有可交互物体加描边。默认跳过建筑本体（房子、城墙等只显示轮廓的物件），散落物与采集物一并点亮 |
| ② | **大地图解锁** | 关 | 大地图所有地点默认可见、可直接前往；马车地图图标同样全部放开 |
| ③ | **剧情条件放宽** | 关 | 触发 Scenario 时忽略「队伍中必须存在某角色」的判定，队伍里没有该角色也能推进剧情。**不会**临时增删队员 |
| ④ | **伤害倍率** | 关 | 分别调整我方 / 敌方造成的伤害倍率（实验性，默认 1.0 即原版） |

「高亮」只在**进入场景时扫描一次**，不做定时刷新，避免每帧遍历对象表。

---

## 安装

1. 安装 [BepInEx 6.0.0-be](https://github.com/BepInEx/BepInEx/releases)（**x64 / IL2CPP** 版）到游戏根目录，先启动一次游戏，让 BepInEx 生成 `BepInEx/interop/`
2. 从 [Releases](../../releases) 下载 `WulinTweaks.dll`，放进 `BepInEx/plugins/`
3. 启动游戏 → 读取存档 → 按 `` ` `` 呼出面板

插件自包含：**除 BepInEx 本体外不依赖任何第三方库**（不使用 UniverseLib，UI 为自建 UGUI）。

配置文件 `BepInEx/config/wulin.tweaks.cfg` 首次启动时自动生成。

---

## 使用

进存档后按 `` ` ``（反引号，Tab 键上方）呼出面板，点击条目切换开 / 关。

| 配置项 | 分组 | 键 | 默认值 |
|---|---|---|---|
| 呼出键 | `0_UI` | `ToggleKey` | `BackQuote` |
| 场景高亮 | `1_Highlight` | `AlwaysHighlight` | `false` |
| 跳过建筑本体 | `1_Highlight` | `ExcludeBuildings` | `true` |
| 散落物需可拾取 | `1_Highlight` | `MiscRequirePickable` | `false` |
| 大地图全解锁 | `2_WorldMap` | `UnlockAll` | `false` |
| 马车地图解锁 | `2_WorldMap` | `UnlockCabMap` | `false` |
| 放宽剧情角色条件 | `3_Story` | `IgnoreTeamMemberCondition` | `false` |
| 我方伤害倍率 | `4_Damage` | `PlayerMultiplier` | `1.0` |
| 敌方伤害倍率 | `4_Damage` | `EnemyMultiplier` | `1.0` |

`ToggleKey` 支持 BepInEx 的按键名（`BackQuote` / `F9` / `LeftControl` 等）。游戏内 `F8` 已被占用，故默认用反引号。

面板与配置项是同一份状态：面板上点了什么，cfg 里就写什么，反之亦然。

---

## 实现原理

游戏为 Unity **2020.3.13f1c1** + **IL2CPP**（x86-64）。用 Il2CppDumper 导出 `dump.cs` 定位类型与 RVA，再分别处理：

- **高亮** — Harmony patch `InteractiveObject.SetOutLine`。判定条件为 `clickType > 0`（`clickType == 0` 的是火把、凳子、桌子、灯笼、地板这类纯装饰），并按 `buildingType` 位掩码跳过建筑本体。
- **地图** — patch `UIWorldMapManager.Update` / `IsMapEnable` / `UIWorldMap.SetCityVisible`，以及 `UICabMapManager.IsPassIcon` / `UpdateIconShow`。地图图标节点的名字就是 mapID，遍历后逐个 `SetActive(true)`。
- **剧情** — `IsJoinedTeamCondition` / `HavePartnerCondition` 的 `CheckAllConnectNode` 在 IL2CPP 互操作程序集里没有导出，只能走机器码。读取 `GameAssembly.dll` 基址后按 RVA 写入 `E9 rel32`，直接跳到基类 `ConditionNode.CheckAllConnectNode`：跳过「角色是否在队」的委托判定，但保留前置条件链的递归遍历。原始字节会先保存，关闭开关时写回。
- **UI** — 自建 UGUI（`Canvas` ScreenSpaceOverlay + `CanvasScaler` 1920×1080），由 `RoamingManager.Update` 的 Harmony postfix 驱动，因此不需要注入 MonoBehaviour（IL2CPP 下注入的 `Update` 不会被执行）。

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

## License

MIT
