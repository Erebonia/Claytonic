@echo off
color 0a
Title DISM
echo.
echo Running DISM
echo.

REM Run DISM
DISM /Online /Cleanup-Image /RestoreHealth

echo.
echo DISM completed.
echo.
pause
