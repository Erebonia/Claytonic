@echo off
setlocal EnableDelayedExpansion

title Check User

:Start
cls

:Ask for User ID
set /p id="Enter user id to lookup (or type 'exit' to quit): "

:Check for exit condition
if /i "%id%"=="exit" goto :End

:Perform the net user lookup and capture output in a temporary file
net user %id% /domain > temp.txt

rem Print the captured user info
type temp.txt

rem Check if "Account active" line contains "Yes" or "No"
findstr /r /c:"Account active.*Yes" temp.txt >nul
if !errorlevel! == 0 (
    set "active_status=Account is active."
    set "color_code=32"
) else (
    set "active_status=Account is not active."
    set "color_code=31"
)

rem Print the active status with appropriate color
call :ColorText "!active_status!" !color_code!

rem Check if the user has a VPN role by searching all lines for the substring "VPN"
findstr /i "VPN" temp.txt >nul
if !errorlevel! == 0 (
    set "vpn_status=User has VPN Role."
    set "vpn_color_code=32"
) else (
    set "vpn_status=VPN role not detected."
    set "vpn_color_code=31"
)

rem Print the VPN role status with appropriate color
call :ColorText "!vpn_status!" !vpn_color_code!

rem Check if the user has a Telework role by searching all lines for the substring "Telework"
findstr /i "Telework" temp.txt >nul
if !errorlevel! == 0 (
    set "telework_status=User has Telework Role."
    set "telework_color_code=32"
) else (
    set "telework_status=Telework role not detected."
    set "telework_color_code=31"
)

rem Print the Telework role status with appropriate color
call :ColorText "!telework_status!" !telework_color_code!

rem Extract the password expiry date
for /f "tokens=3,4 delims= " %%a in ('findstr /c:"Password expires" temp.txt') do set password_expires=%%a %%b

rem Compare password expiry date with current date using PowerShell
set expired_status=Password is not expired.
set expired_color_code=32

for /f %%i in ('powershell -Command "if ((Get-Date) -gt (Get-Date '!password_expires!')) {Write-Output 'expired'}"') do (
    if %%i==expired (
        set expired_status=Password is expired.
        set expired_color_code=31
    )
)

rem Print the password expiry status with appropriate color
call :ColorText "!expired_status!" !expired_color_code!

rem Cleanup
del temp.txt

pause

goto :Start

:End
echo Exiting the program.
exit /b

:ColorText
setlocal EnableDelayedExpansion
for /f %%a in ('echo prompt $E ^| cmd') do set "ESC=%%a"
echo !ESC![0;%2m%1!ESC![0m
exit /b
