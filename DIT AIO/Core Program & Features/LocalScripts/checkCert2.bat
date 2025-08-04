certutil -delstore -user my "UserSignEmail"

timeout /t 5

certutil -user -store my | findstr /r /c:"UserSignEmail"
if %errorlevel%==1 (
  @echo Certificate not found.  Trying to request...
  certreq -enroll -q UserSignEmail
  )
if %errorlevel%==0 (
  @echo Certificate found.
  goto next
  )

timeout /t 5

certutil -user -store my | findstr /r /c:"UserSignEmail"
if %errorlevel%==1 (
  @echo Certificate not found.  Please manually request it.
  goto end
  )
if %errorlevel%==0 (
  @echo Certificate found.
  goto next
  )

:next
reg query "HKCR\SOFTWARE\Adobe\Acrobat\EXE"
if %errorlevel%==1 (
  @echo Acrobat is not installed.
  goto end
  )
FOR /F "tokens=2* skip=2" %%a in ('reg query "HKCR\SOFTWARE\Adobe\Acrobat\EXE"') do set acroPath=%%b

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET DateTime=%DTS:~0,8%-%DTS:~8,6%

REM Copy file to every version of Acrobat
 
FOR /F "tokens=*" %%d in ('@dir /b "%appdata%\Adobe\Acrobat"') DO (
ECHO %%d
ren "%appdata%\Adobe\Acrobat\%%d\Security\addressbook.acrodata" "addressbook_%DateTime%.acrodata"
robocopy "%~dp0." "%appdata%\Adobe\Acrobat\%%d\Security" *.acrodata /E
)

start /w "" %acroPath%

:end


PAUSE
CMD/K