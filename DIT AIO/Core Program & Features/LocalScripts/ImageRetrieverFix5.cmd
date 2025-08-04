@pushd %~dp0
:home
::Check if user exists in CCHSCAN1
@for /f "tokens=1" %%a in ('@dir /b \\cchscan1\ftpscan') do @if exist  "\\cchscan1\ftpscan\%%a\%username%" (@set dept=%%a)
::echo.%dept%
::@pause
@if  "%dept%" equ "" (@cls &&  (goto NoUserDefined)) else (goto ISRepwatch1)
::@pause
::@popd

:ISRepwatch1
if exist "\\cchscan1\ftpscan\%dept%\%username%\repwatch.xsw" (goto IsRepwatch) else (goto OnePC)

:ISRepwatch
for /f %%i in ("\\cchscan1\ftpscan\%dept%\%username%\repwatch.xsw ") do set size=%%~zi
if %size% gtr 0 (goto IsUserOnAnotherPC) else (@del \\cchscan1\ftpscan\%dept%\%username%\repwatch.xsw && @goto OnePC)




:IsUserOnAnotherPC

@for /f "tokens=1-6" %%a in ('type  "\\cchscan1\ftpscan\%dept%\%username%\repwatch.xsw" ^| findstr /i "computer"') do @set PC=%%d
@set PCName=%PC:~1,-2%
::@echo.%pcname%
::@pause
@if /i %PCName% equ %computername% (@goto OnePC) else (@Goto KillOtherPC)

:KillOtherPC
@taskkill /s %pcname% /F /IM xdcla.exe
@erase /q \\cchscan1\ftpscan\%dept%\%username%\repwatch.xsw

:OnePC

@taskkill /F /IM xdcla.exe
::timeout /t 5
::@pause
@if exist "%programdata%\microsoft\windows\start menu\programs\Scansoft Paperport 11" (goto 10Reg) else (goto 111213Reg)
::@pause
@del /q "\\cchscan1\ftpscan\%dept%\%username%\repwatch.xsw" 
:10Reg
@reg add "hkcu\software\scansoft\ImageRetriever\ScanWatch" /V Folder /t Reg_SZ /d "\\cchscan1\ftpscan\%dept%\%username%" /f
@reg add "hkcu\software\scansoft\ImageRetriever\ScanWatch" /V Interval  /t Reg_Dword /d 3 /f
@reg add "hkcu\software\scansoft\ImageRetriever\ScanWatch" /V FolderWatch /t Reg_Dword /d 1 /f
@goto 10
::@pause
:111213REG
@reg add "hkcu\software\scansoft\DesktopDeliveryPSP\ScanWatch" /V Folder /t Reg_SZ /d "\\cchscan1\ftpscan\%dept%\%username%" /f
@reg add "hkcu\software\scansoft\DesktopDeliveryPSP\ScanWatch" /V Interval  /t Reg_Dword /d 3 /f
@reg add "hkcu\software\scansoft\DesktopDeliveryPSP\ScanWatch" /V FolderWatch /t Reg_Dword /d 1 /f



@if exist "%programdata%\microsoft\windows\start menu\programs\Scansoft Paperport 11" (goto 10) else (goto 11)

:10
@start "" "%programdata%\microsoft\windows\start menu\programs\Scansoft Paperport 11\Image Retriever.lnk"
@goto TestPDF

:11
@if exist "%programdata%\microsoft\windows\start menu\programs\xerox scan to pc desktop 11" (goto 11A) else (goto 1213)
:11A
@cls
@ start "" "%programdata%\microsoft\windows\start menu\programs\xerox scan to pc desktop 11\paperport\imageretriever.lnk"
@goto TestPDF
:1213
@cls
@ cd /d  "%programdata%\microsoft\windows\start menu\programs\xerox scan to pc desktop *\paperport"
@start "" "image retriever.lnk"
:TestPDF
::@copy /y "%~dp0\test.pdf" \\cchscan1\ftpscan\%dept%\%username%"
@goto end

: MoreThanOnePC
@cls
@echo.***User already running Image Retriever on %pcname%.  Have user log off that PC before continuing and run the batch again
@pause
@goto Home
:NoUserDefined
@cls
@echo.**User is not setup in CCHSCAN1.  Please contact CSR!!!**
@pause
:end
@popd