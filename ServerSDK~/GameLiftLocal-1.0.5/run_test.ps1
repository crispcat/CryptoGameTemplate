$process = Get-Process -Id (Get-NetTCPConnection -LocalPort 5757).OwningProcess
Stop-Process -ID $process.Id -Force
java -jar GameLiftLocal.jar