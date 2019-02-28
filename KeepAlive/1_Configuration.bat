@echo off
:variables
:: Change this to where you keep KeepAlive.ps1
set KeepAlive="C:\PATH\TO\KeepAlive.ps1"
goto init
:init
net session >nul 2>&1
if %errorLevel% == 0 (goto execute) else (goto error)
goto init
:execute
powershell Set-ExecutionPolicy Unrestricted
powershell -windowstyle hidden %KeepAlive%
exit
:error
color 4F
echo.
echo ERROR: This script needs elevated privileges!
timeout /t -1
exit
