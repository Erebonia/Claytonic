@pushd %~dp0

xcopy /y "%~dp0SourceFiles\Program Files (x86)\" "C:\Program Files (x86)\" /E /H /C /I

xcopy /y "%~dp0SourceFiles\ProgramData\" "C:\ProgramData\" /E /H /C /I

xcopy /y "%~dp0SourceFiles\Programs\" "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\" /E /H /C /I

::@pause
@popd