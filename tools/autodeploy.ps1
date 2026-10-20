$ErrorActionPreference = 'Continue'
$plugin = 'D:\steamgame\steamapps\common\WulinSH\BepInEx\plugins\WulinTweaks.dll'
$src    = 'C:\Users\User\Documents\deepseek-harness\default-workspace\wulin-mod\WulinTweaks\bin\Release\WulinTweaks.dll'
$log    = 'C:\Users\User\Documents\deepseek-harness\default-workspace\wulin-mod\tools\autodeploy.log'

function W([string]$m) { "$(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')  $m" | Add-Content -Path $log -Encoding utf8 }

W "watcher start (pid $PID); waiting for Wulin.exe to exit"

$deadline = (Get-Date).AddHours(8)
while ((Get-Date) -lt $deadline) {
    if (Get-Process Wulin -ErrorAction SilentlyContinue) {
        Start-Sleep -Seconds 3
        continue
    }

    # 进程没了：等两秒确认不是重启
    Start-Sleep -Seconds 2
    if (Get-Process Wulin -ErrorAction SilentlyContinue) { continue }

    $srcTime = (Get-Item $src).LastWriteTime
    $dstTime = if (Test-Path $plugin) { (Get-Item $plugin).LastWriteTime } else { [datetime]::MinValue }
    if ($srcTime -le $dstTime) {
        W "game exited; plugin already up to date ($($dstTime.ToString('HH:mm:ss'))), nothing to do"
    } else {
        try {
            Copy-Item $src $plugin -Force
            Remove-Item ($plugin + '.new') -ErrorAction SilentlyContinue
            W "game exited; DEPLOYED $((Get-Item $plugin).Length) bytes @ $((Get-Item $plugin).LastWriteTime.ToString('HH:mm:ss'))"
        } catch {
            W "game exited; deploy FAILED: $($_.Exception.Message)"
        }
    }
    break
}

if ((Get-Date) -ge $deadline) { W "watcher timeout after 8h, exiting" }
W "watcher done"
