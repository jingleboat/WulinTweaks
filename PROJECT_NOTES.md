# wulin-mod 工程约束

> 本文件记录**本工程特有**的约定，与通用的 `~/.dsh/AGENTS.md`（工作纪律）分开。
> 通用纪律见 `AGENTS.md`；这里只写「做这个 mod 时必须守住」的东西。

---

## 一、剧情条件放宽的语义（用户明确定义，不要自行改动）

### 规则

```
R{角色id}-xxx 这类角色剧情图：
    条件里的 partnerID != 图名角色 id   → 放宽（触发别人的彩蛋，这是要的）
    partnerID == 图名角色 id 且未入队    → 按原版（该角色入队后才开启自己的故事线）
    本命角色入过队（哪怕现在离队）       → 放宽（故事线可继续）

Fame-2 / Guide10099-6,11,13,15,16,18   → 固定按原版（主线与师父线）

手动名单（IgnoreTeamConditionBlacklist） → 不放宽
其余                                    → 放宽
```

### 「从未入队」的判据

`GameCharacterInstance.m_TeamMemberState(+0x130) == NULL`。

已实测：苗彩蝶(10005)、曼陀罗(10021)、癞头癫(10025) 为 `NULL`；猎户(20001)、铁匠(20006)、玩家(100401) 非 `NULL`。不是懒创建，可靠。

---

## 二、不要自作主张撤掉全局压制

**这是用户明确批评过一次的事，不要再犯。**

背景：曾经为了让剧情能触发，把「Hold `checkSucessTimes != 0` → 压回 false」这个兜底撤掉，结果未知事件开始无限重复触发，用户反馈「很多正常交互该有的事件剧情也没触发」。

要求：

- **全局压制必须保留**。名单只能覆盖已知事件，未知的循环事件靠这个兜底压住；
- 要动这个机制，**先问用户**，不要以「为了让它触发」为理由自行移除；
- 名单内的图可以「不压制」（否则角色入队后也只剩一次），但**名单外必须继续压制**。

---

## 三、改动配置/环境前必须说明

涉及以下操作，先讲清「会动什么、怎么回滚」，再执行：

- 改 `BepInEx/config/wulin.tweaks.cfg`（每次改前 `Copy-Item` 一份 `.bak-before-<原因>`）
- 替换 `BepInEx/plugins/WulinTweaks.dll`
- 改 `native/src/*.cpp` 里的 hook 逻辑
- 改存档相关路径

---

## 四、两端语义必须一致

PC 插件（`wulin-mod`）与手机 native（`wulin-apk`）实现同一套规则。

- 手机端 hook 在条件函数层，位置 A/B 都能覆盖，是**参考实现**；
- PC 端受 IL2CPP 导出限制，目前只能覆盖位置 A；
- 改一端时，另一端的规则定义要同步更新，并在文档里注明**能力差异**，不要假装两端等价。

---

## 五、失败结论也要留档

已经付过代价验证过的死路，写进 `E:\笔记\PC端剧情条件放宽-技术复盘.md` 的「已知的坑」一节，避免后来者（包括其它 AI）重试：

1. `HoldNode.conditionPort` 是空的，`CheckCondition` 恒返回 true；
2. 剧情图入口端口挂的是区域/NPC 交互条件，没有队友条件；
3. `GameAssembly.dll` 的 `.text` 没有 512 字节连续 `0xCC` 填充区；
4. `VirtualAlloc` 分配的地址远超 ±2GB；
5. `StoryDefaultNode.ConditionPort` 在 interop 里继承链断裂，`GetConnections()` 不可用；
6. 苗彩蝶（位置 B）拦不住，曼陀罗（位置 A）能拦住——差别只在「条件挂在哪一层」。

---

## 六、最终实现（2026-10-21 定稿）

PC 端改用 **dobby 原生 inline hook**（`BepInEx\core\dobby.dll`），接管：

```
ConditionNode.CheckAllConnectNode（基类）       0x1105A00   ← 放宽时调它
IsJoinedTeamCondition.CheckAllConnectNode      0x10F4CB0
HavePartnerCondition.CheckAllConnectNode       0x10F2230
```

手机端 native inline hook，规则完全相同。

### 不放宽的范围（只有三类）

1. `R{角色id}-*` 图中，**partnerID == 图名角色 id 且该角色从未入队**（个人剧情等人入队）；
2. 主线与师父线：`Fame-2`、`Guide10099-6/11/13/15/16/18`；
3. 手动名单 `IgnoreTeamConditionBlacklist`（当前空）。

其余一律放宽。

### 必须守住的三个细节

1. **判定缓存要带 TTL（3 秒）**——结果包含「是否从未入队」，入队状态会变；
2. **`find_class(ns, name)` 的命名空间不能传错**——传错会静默返回 null
   （`GameCharacterManager` 在 `WuLin` 命名空间下，此处曾出错导致三个版本空转）；
3. **兜底不要静默**——`never_joined` 拿不到管理器时按「已入队」返回，正好掩盖了上述错误。