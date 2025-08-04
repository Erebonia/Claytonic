@echo off
@echo Only run for the "your form cache is probably corrupt" issue.
@echo It should work for Outlook 2007 to 2021
@echo This still needs testing.  Let Mike know if there are problems.
@echo Thank you. --Mike 7/26/19
@echo -------------------------

:: Verified script works for up to 2021 outlook. I double checked registry path this script checks.

for /F "tokens=3 delims=." %%O in ('reg query HKEY_CLASSES_ROOT\Outlook.Application\CurVer') do set verp=%%O
for /F "tokens=3" %%B in ('reg query HKLM\SOFTWARE\Microsoft\Office\%verp%.0\Outlook /v Bitness ^|findstr /ri "REG_SZ"') do set BITNESS=%%B
reg Query "HKLM\Hardware\Description\System\CentralProcessor\0" | find /i "x86" > NUL && set OSbit=x86|| set OSbit=x64

if %OSbit% == x86 GOTO 32BITOS

:: This section is run if the OS is 64 bit ::
if %BITNESS% == x86 (
  set REGPATH=Wow6432Node\
  @echo setting REGPATH to Wow6432Node\
  )
if %BITNESS% == x64 (
  set REGPATH=
  @echo blanking REGPATH)
GOTO MAIN

:32BITOS
set REGPATH=
@echo Blanking REGPATH

:MAIN
if "%verp%" == "11" (
  @echo Outlook 2003 %BITNESS% detected.
  )
if "%verp%" == "12" (
  @echo Outlook 2007 %BITNESS% detected.
  )
if "%verp%" == "14" (
  @echo Outlook 2010 %BITNESS% detected.
  )
if "%verp%" == "15" (
  @echo Outlook 2013 %BITNESS% detected.
  )
if "%verp%" == "16" (
  @echo Outlook 2016 or 2019 or 2021 %BITNESS% detected.
  )

set REGKEY1=HKLM\SOFTWARE\%REGPATH%Microsoft\Office\%verp%.0\Outlook\Forms\TrustedFormScriptList
set REGKEY2=HKLM\SOFTWARE\%REGPATH%Microsoft\Office\%verp%.0\Outlook\Security

@echo %OSbit% OS detected.
@echo The following keys will be modified:
@echo %REGKEY1%
@echo %REGKEY2%

REG ADD "%REGKEY1%" /v IPM.Note.PamMessage /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Note.PamMessage.Forwarded /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Note.PamMessage.Replied /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Note.PamMessage.Post /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Note.PamMessage.Document /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Contact.PamMessage /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Appointment.PamMessage /t REG_SZ /d "" /f
REG ADD "%REGKEY1%" /v IPM.Task.PamMessage /t REG_SZ /d "" /f

REG ADD "%REGKEY2%" /v DisableCustomFormItemScript /t REG_DWORD /d 00000000 /f