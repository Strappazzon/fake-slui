@echo off
:init
net session >nul 2>&1
if %errorLevel% == 0 (goto execute) else (goto error)
goto init
:execute
powershell Set-ExecutionPolicy Unrestricted
powershell -windowstyle hidden "C:\Path\To\KeepAlive.ps1"
exit
:error
color 4F
echo.
echo ERROR: This script needs elevated privileges!
timeout /t -1
exit
