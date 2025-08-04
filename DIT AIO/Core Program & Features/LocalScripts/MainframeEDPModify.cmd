@pushd %~dp0
:home
@ipconfig /flushdns
@cls
@echo.
@echo.
@echo.
@echo.
@echo.
@set /p IPAddress=*******Please enter IP Address/Computername or Press H and Enter to go back to Main Menu:  
@if "%IPAddress%"=="h" (@goto home) else (goto next)
@echo.
@echo.
@echo.
@echo.
@echo.
:next
@for /f "tokens=1" %%a in ('ping -n 1 %IPAddress% ^|find /i /c "reply"') do @if %%a==1 (@goto Next) else (@goto Unpingable)
:next
@for /f "tokens=1-6" %%a in ('ping -a -n 1 %IPAddress% ^| findstr /i "pinging"') do (@set PCName=%%b)
@for /f "tokens=1-6" %%a in ('psloggedon -l \\%IPAddress% ^| findstr /i "cchnl"') do @set remuser=%%d
@cls
@echo.
@echo.
@echo.
@echo.
@echo.
@echo.         The IP is %IPAddress%
@echo.
@echo.         The  Computername is %PCName%
@echo.
@echo.         The Logged on user is %remuser%
@echo.
@echo.          Are you sure you want to continue?
@echo.
@echo.
@choice /n /t:60 /d y /c:yse   /m "Hit 'Y' to continue, 'S' to go to Start Over, 'E' to Quit"
@if %errorlevel%==1 goto next
@if %errorlevel%==2 goto home
@if %errorlevel%== 3 goto end
:next
@taskkill /s %IPAddress% /f /t  /im extra.exe 2>nul
::@pause
@notepad "\\%IPAddress%\c$\users\public\documents\attachmate\extra!\sessions\mainframe.edp"
@goto end
:Unpingable
@cls
@echo.
@echo.
@echo.
@echo.
@echo.                                          Unable to ping IP Address.  Do you want to re-enter another address?
@echo.
@echo.
@choice /n /t:60 /d y /c:yq   /m "Hit 'Y' to continue, 'Q' to go to Quit"
@if %errorlevel%==1 goto home
@if %errorlevel%==2 goto end
@pause
:end
@popd