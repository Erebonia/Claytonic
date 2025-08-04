@echo off
color 2
echo.
echo DIT - Copy Sy's ACID Reset Macro to PC


echo.

Xcopy "\\ditfp1\helpdesk\BN\Mainframe\Sy-ACID-Reset.mac" "C:\ProgramData\TomBrennanSoftware\VistaTN3270\macros" /E /C /I /Y /Q

pause