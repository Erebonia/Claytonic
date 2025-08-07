@pushd %~dp0

xcopy /y "\\ditfp1\helpdesk\VistaTN3270\Program Files (x86)\" "C:\Program Files (x86)\" /E /H /C /I

xcopy /y "\\ditfp1\helpdesk\VistaTN3270\ProgramData\" "C:\ProgramData\" /E /H /C /I

xcopy /y "\\ditfp1\helpdesk\VistaTN3270\Programs\" "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\" /E /H /C /I

::@pause
@popd