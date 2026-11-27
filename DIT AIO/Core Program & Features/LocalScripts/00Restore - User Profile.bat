@echo off
color 0a
Title Restore Data

:verify_drive
set /p drv="Enter drive letter of your external drive: "
if not exist %drv%:\ (
    echo Invalid drive letter
    goto verify_drive
)

:verify_id
set /p id="Enter User ID: "
if not exist C:\users\%id% (
    echo Invalid User ID. If this is a new computer, have them login first.
    goto verify_id
)
echo.

:: Set the drive to C
c:

:: Restore user data
echo Restoring signatures...
Robocopy "%drv%:\%id%\AppData\Local\Microsoft\Signatures" "C:\users\%id%\AppData\Local\Microsoft\Signatures" /MIR /R:3 /W:5
echo Restoring Desktop...
Robocopy "%drv%:\%id%\Desktop" "C:\users\%id%\Desktop" /MIR /R:3 /W:5
echo Restoring Documents...
Robocopy "%drv%:\%id%\Documents" "C:\users\%id%\Documents" /MIR /R:3 /W:5
echo Restoring Favorites...
Robocopy "%drv%:\%id%\Favorites" "C:\users\%id%\Favorites" /MIR /R:3 /W:5
echo Restoring Pictures...
Robocopy "%drv%:\%id%\Pictures" "C:\users\%id%\Pictures" /MIR /R:3 /W:5
echo Restoring Downloads...
Robocopy "%drv%:\%id%\Downloads" "C:\users\%id%\Downloads" /MIR /R:3 /W:5
echo Restoring Outlook data...
Robocopy "%drv%:\%id%\Outlook" "C:\users\%id%\Outlook" /MIR /R:3 /W:5

:: Restore bookmarks
echo Restoring Google Chrome bookmarks...
Robocopy "%drv%:\%id%\AppData\Local\Google\Chrome\User Data\Default" "C:\users\%id%\AppData\Local\Google\Chrome\User Data\Default" "Bookmarks" /R:3 /W:5

echo Restoring Microsoft Edge bookmarks...
Robocopy "%drv%:\%id%\AppData\Local\Microsoft\Edge\User Data\Default" "C:\users\%id%\AppData\Local\Microsoft\Edge\User Data\Default" "Bookmarks" /R:3 /W:5

:: Import print management printers
echo Importing print management printers...
c:\windows\system32\spool\tools\PrintBrm.exe -r -f %drv%:\%id%\printers\PrinterExport.printerExport -O FORCE
if %errorlevel% neq 0 (
    echo Failed to import printers.
    exit /b 1
)
echo Printer import completed.

echo All files have been successfully restored.

pause
