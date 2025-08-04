@echo off
color 2
echo.

echo DIT - Copy Unsuspend Macro to PC

echo.

Xcopy "\\ditfp1\helpdesk\BN\Mainframe\Bao-ACID-Unsuspend.mac" "C:\ProgramData\TomBrennanSoftware\VistaTN3270\macros" /E /C /I /Y /Q

pause