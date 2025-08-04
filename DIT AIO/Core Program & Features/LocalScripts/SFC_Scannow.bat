@echo off
color 0a
Title SFC Scan

echo.
echo Running System File Checker...
echo.

REM Run the System File Checker
sfc /scannow

echo.
echo System File Checker scan completed.
echo.
pause
