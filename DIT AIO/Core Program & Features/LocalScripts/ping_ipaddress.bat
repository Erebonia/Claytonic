@echo off
color 0a
Title Ping IP

:pingloop
cls

echo.
set /p ip=Please enter an IP address to ping (or type 'exit' to quit): 
if "%ip%"=="exit" (
    echo Exiting...
    exit /B 0
)
echo.
ping %ip%
echo.

echo Press enter and type in another IP Address to ping.
pause
goto pingloop
